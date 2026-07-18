using System.Text;

namespace ExtensionGenerator;

internal sealed class ExtensionRenderer(ManagedInterfaceCatalog catalog)
{
	public IReadOnlyDictionary<string, string> Render()
	{
		var files = new Dictionary<string, string>(StringComparer.Ordinal);
		foreach (var @interface in catalog.Interfaces)
		{
			var source = RenderInterface(@interface);
			if (source is not null)
				files[$"{@interface.Name}Extensions.cs"] = source;
		}
		foreach (var family in Recipes.CapabilityFamilies)
		{
			var baseInterface = catalog.GetInterface(family.BaseInterface);
			var capabilityInterface = catalog.GetInterface(family.CapabilityInterface);
			files[$"{family.BaseInterface}{family.CapabilityInterface["ICorDebug".Length..]}Extensions.cs"] =
				RenderCapabilityFamily(baseInterface, capabilityInterface);
		}
		return files;
	}

	private string? RenderInterface(ManagedInterface @interface)
	{
		var queryBuffers = Recipes.QueryBuffers.Where(recipe => recipe.Interface == @interface.Name).ToArray();
		var queryBufferMethods = queryBuffers.Select(recipe => recipe.Method).ToHashSet(StringComparer.Ordinal);
		var enumerations = Recipes.Enumerations.Where(recipe => recipe.Interface == @interface.Name).ToArray();
		var metadataStrings = Recipes.MetadataStrings.Where(recipe => recipe.Interface == @interface.Name).ToArray();
		var boolResults = Recipes.BoolResults.Where(recipe => recipe.Interface == @interface.Name).ToArray();
		var comEnumerations = @interface.Methods.Values
			.Where(IsComEnumeration)
			.OrderBy(method => method.Name, StringComparer.Ordinal)
			.ToArray();
		var configuredStringMethods = queryBufferMethods
			.Concat(metadataStrings.Select(recipe => recipe.Method)).ToHashSet(StringComparer.Ordinal);
		var automaticStrings = @interface.Methods.Values
			.Where(method => TryGetStringBuffer(method, out _) && !configuredStringMethods.Contains(method.Name))
			.OrderBy(method => method.Name, StringComparer.Ordinal).ToArray();
		var outputArrays = @interface.Methods.Values
			.Where(method => TryGetOutputArrayBuffer(method, out _) && !queryBufferMethods.Contains(method.Name) && !comEnumerations.Contains(method))
			.OrderBy(method => method.Name, StringComparer.Ordinal).ToArray();
		var projected = @interface.Methods.Values
			.Where(method => CanProjectOutputs(method) && !queryBufferMethods.Contains(method.Name) && !comEnumerations.Contains(method) && !outputArrays.Contains(method))
			.OrderBy(method => method.Name, StringComparer.Ordinal).ToArray();
		var returnProperties = @interface.Methods.Values.Where(CanProjectReturn).OrderBy(method => method.Name, StringComparer.Ordinal).ToArray();
		var boolResultMethods = boolResults.Select(recipe => catalog.GetMethod(recipe.Interface, recipe.Method)).ToHashSet();
		var propertySetters = projected.Where(IsParameterlessGetter)
			.Select(getter => FindPropertySetter(@interface, getter))
			.OfType<ManagedMethod>()
			.ToHashSet();
		var voidMethods = @interface.Methods.Values
			.Where(method => method.ReturnType == "int" && !method.Parameters.Any(parameter => parameter.IsOut) && !boolResultMethods.Contains(method) && !propertySetters.Contains(method))
			.OrderBy(method => method.Name, StringComparer.Ordinal)
			.ToArray();

		if (queryBuffers.Length == 0 && enumerations.Length == 0 && metadataStrings.Length == 0 && boolResults.Length == 0 && comEnumerations.Length == 0 && automaticStrings.Length == 0 && outputArrays.Length == 0 && projected.Length == 0 && returnProperties.Length == 0 && voidMethods.Length == 0)
			return null;

		foreach (var recipe in enumerations)
			ValidateEnumeration(recipe);
		foreach (var recipe in metadataStrings)
			ValidateHResult(catalog.GetMethod(recipe.Interface, recipe.Method), recipe.Interface);
		foreach (var recipe in boolResults)
			ValidateBoolResult(catalog.GetMethod(recipe.Interface, recipe.Method), recipe.Interface);

		var members = queryBuffers.Select(RenderQueryBuffer)
			.Concat(enumerations.Select(RenderEnumerationMember))
			.Concat(metadataStrings.Select(RenderStringMember))
			.Concat(boolResults.Select(RenderBoolResult))
			.Concat(comEnumerations.Select(method => RenderComEnumerationMember(@interface, method)))
			.Concat(comEnumerations.Where(IsParameterlessEnumeration).Select(RenderEnumerationArrayProperty))
			.Concat(automaticStrings.Select(RenderAutomaticStringQuery))
			.Concat(outputArrays.Select(RenderOutputArrayMethod))
			.Concat(projected.Select(method => IsParameterlessGetter(method)
				? RenderOutputProperty(method, GetPropertyName(method), $"instance.{method.InvocationName}", FindPropertySetter(@interface, method))
				: RenderProjectedMethod(method)))
			.Concat(returnProperties.Select(RenderReturnProperty))
			.Concat(voidMethods.Select(RenderVoidMethod));
		var helpers = enumerations.Select(RenderEnumerationHelper).ToList();
		helpers.AddRange(comEnumerations.Select(RenderComEnumerationHelper));
		helpers.AddRange(metadataStrings.Select(RenderStringHelper));
		if (metadataStrings.Length != 0 || automaticStrings.Length != 0)
			helpers.Add(RenderStringHelper());

		return Header(@interface.Namespace) +
			$"public static unsafe class {@interface.Name[1..]}Extensions\n{{\n" +
			$"\textension({@interface.Name} instance)\n\t{{\n{string.Join("\n\n", members)}\n\t}}\n" +
			(helpers.Count == 0 ? "" : $"\n{string.Join("\n\n", helpers)}\n") +
			"}\n";
	}

	private string RenderCapabilityFamily(ManagedInterface baseInterface, ManagedInterface capabilityInterface)
	{
		var capabilityName = capabilityInterface.Name["ICorDebug".Length..];
		var members = new List<string>
		{
			$"\t\tpublic bool Supports{capabilityName} => instance is {capabilityInterface.Name};",
			$"\t\tpublic {capabilityInterface.Name} {capabilityName} =>\n" +
				$"\t\t\tinstance as {capabilityInterface.Name} ?? throw new NotSupportedException(\"{baseInterface.Name} does not support {capabilityInterface.Name}.\");",
		};

		foreach (var method in capabilityInterface.Methods.Values.Where(method => method.ReturnType == "int").OrderBy(method => method.Name, StringComparer.Ordinal))
		{
			members.Add(RenderCapabilityTryMethod(method, capabilityName));
			if (method.Name.StartsWith("Set", StringComparison.Ordinal) && capabilityInterface.Methods.TryGetValue("Get" + method.Name[3..], out var getter) && IsPropertySetter(getter, method))
				continue;
			if (Recipes.QueryBuffers.Any(recipe => recipe.Interface == capabilityInterface.Name && recipe.Method == method.Name))
				continue;
			members.Add(TryGetOutputArrayBuffer(method, out var outputBuffer)
				? RenderCapabilityOutputArrayMethod(method, capabilityName, outputBuffer)
				: method.Parameters.Any(parameter => parameter.IsOut)
				? (IsParameterlessGetter(method)
					? RenderOutputProperty(method, GetPropertyName(method), $"instance.{capabilityName}.{method.InvocationName}", FindPropertySetter(capabilityInterface, method), $"instance.{capabilityName}.{FindPropertySetter(capabilityInterface, method)?.InvocationName}")
					: RenderCapabilityProjectedMethod(method, capabilityName))
				: RenderCapabilityVoidMethod(method, capabilityName));
			if (IsParameterlessEnumeration(method))
				members.Add(RenderCapabilityEnumerationArrayProperty(method, capabilityName));
		}

		foreach (var recipe in Recipes.QueryBuffers.Where(recipe => recipe.Interface == capabilityInterface.Name))
			members.Add(RenderCapabilityQueryBuffer(recipe, capabilityName));

		var configuredStrings = Recipes.MetadataStrings.Select(recipe => (recipe.Interface, recipe.Method)).ToHashSet();
		foreach (var method in capabilityInterface.Methods.Values
			.Where(method => TryGetStringBuffer(method, out _) && !configuredStrings.Contains((capabilityInterface.Name, method.Name)))
			.OrderBy(method => method.Name, StringComparer.Ordinal))
			members.Add(RenderCapabilityStringQuery(method, capabilityName));

		return Header(baseInterface.Namespace) +
			$"public static unsafe class {baseInterface.Name[1..]}{capabilityName}Extensions\n{{\n" +
			$"\textension({baseInterface.Name} instance)\n\t{{\n{string.Join("\n\n", members)}\n\t}}\n}}\n";
	}

	private static string RenderCapabilityVoidMethod(ManagedMethod method, string capabilityName)
	{
		var parameters = string.Join(", ", method.Parameters.Where(parameter => !parameter.IsEnumeratorMaxOne).Select(RenderProjectedInputParameter));
		var arguments = string.Join(", ", method.Parameters.Select(parameter => parameter.IsEnumeratorMaxOne
			? "1"
			: parameter.IsRef ? $"ref {Escape(parameter.Name)}" : Escape(parameter.Name)));
		return $"\t\tpublic void {method.Name}({parameters}) => instance.{capabilityName}.{method.Name}({arguments});";
	}

	private static string RenderCapabilityTryMethod(ManagedMethod method, string capabilityName)
	{
		var parameters = string.Join(", ", method.Parameters.Select(RenderRawParameter));
		var arguments = string.Join(", ", method.Parameters.Select(parameter => parameter.IsOut
			? $"out {Escape(parameter.Name)}"
			: parameter.IsRef ? $"ref {Escape(parameter.Name)}" : Escape(parameter.Name)));
		return $"\t\tpublic int Try{method.Name}({parameters}) => instance.{capabilityName}.{method.InvocationName}({arguments});";
	}

	private string RenderCapabilityProjectedMethod(ManagedMethod method, string capabilityName)
	{
		var inputs = method.Parameters.Where(parameter => !parameter.IsOut && !parameter.IsEnumeratorMaxOne).ToArray();
		var parameters = string.Join(", ", inputs.Select(RenderProjectedInputParameter));
		var arguments = string.Join(", ", inputs.Select(parameter => parameter.IsRef ? $"ref {Escape(parameter.Name)}" : Escape(parameter.Name)));
		if (IsComEnumeration(method))
		{
			var enumerator = method.Parameters.Single(parameter => parameter.IsOut);
			var next = catalog.GetMethod(enumerator.Type.TrimEnd('?'), "Next");
			var values = next.Parameters.Single(parameter => parameter.Type.Contains("[]", StringComparison.Ordinal));
			return $"\t\tpublic IEnumerable<{ElementType(values.Type)}> {method.Name}({parameters}) => instance.{capabilityName}.{method.Name}({arguments});";
		}

		var outputs = method.Parameters.Where(parameter => parameter.IsOut).ToArray();
		var returnType = outputs.Length == 1
			? ProjectedOutputType(outputs[0])
			: $"({string.Join(", ", outputs.Select(output => $"{ProjectedOutputType(output)} {Escape(output.Name)}"))})";
		return $"\t\tpublic {returnType} {method.Name}({parameters}) => instance.{capabilityName}.{method.Name}({arguments});";
	}

	private string RenderCapabilityEnumerationArrayProperty(ManagedMethod method, string capabilityName)
	{
		var enumerator = method.Parameters.Single(parameter => parameter.IsOut);
		var next = catalog.GetMethod(enumerator.Type.TrimEnd('?'), "Next");
		var values = next.Parameters.Single(parameter => parameter.Type.Contains("[]", StringComparison.Ordinal));
		return $"\t\tpublic {ElementType(values.Type)}[] {PropertyName(method.Name["Enumerate".Length..])} => instance.{capabilityName}.{method.Name}().ToArray();";
	}

	private string RenderCapabilityQueryBuffer(QueryBufferRecipe recipe, string capabilityName)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		ValidateHResult(method, recipe.Interface);
		ValidateQueryBuffer(method, recipe);
		var retained = method.Parameters.Where(parameter => parameter.Name != recipe.Capacity && parameter.Name != recipe.Count && parameter.Name != recipe.Buffer).ToArray();
		var buffer = method.GetParameter(recipe.Buffer);
		if (retained.Any(parameter => parameter.IsOut || parameter.IsRef))
			throw new InvalidOperationException($"{recipe.Interface}.{recipe.Method} has unsupported retained output parameters.");
		var elementType = buffer.Type.Replace("?", "", StringComparison.Ordinal).Replace("[]", "", StringComparison.Ordinal);
		var returnType = recipe.Kind == BufferKind.String
			? "string"
			: $"{elementType}[]";
		if (retained.Length == 0 && recipe.Method.StartsWith("Get", StringComparison.Ordinal))
			return $"\t\tpublic {returnType} {recipe.Method[3..]} => instance.{capabilityName}.{recipe.Method[3..]};";
		var body = RenderQueryBody(method, recipe, retained, elementType, retained.Length == 0 ? 4 : 3)
			.Replace("instance.", $"instance.{capabilityName}.", StringComparison.Ordinal);
		return $"\t\tpublic {returnType} {recipe.Method}({string.Join(", ", retained.Select(RenderInputParameter))})\n\t\t{{\n{body}\n\t\t}}";
	}

	private static string RenderCapabilityStringQuery(ManagedMethod method, string capabilityName)
	{
		if (!TryGetStringBuffer(method, out var stringBuffer))
			throw new InvalidOperationException($"{method.Name} is not a string query method.");
		var omitted = new HashSet<string>(StringComparer.Ordinal) { stringBuffer.Buffer.Name, stringBuffer.Capacity.Name, stringBuffer.Count.Name };
		var inputs = method.Parameters.Where(parameter => !parameter.IsOut && !parameter.IsEnumeratorMaxOne && !omitted.Contains(parameter.Name)).ToArray();
		var outputs = method.Parameters.Where(parameter => parameter.IsOut && parameter.Name != stringBuffer.Count.Name).ToArray();
		var returnType = outputs.Length == 0
			? "string"
			: $"(string {Escape(stringBuffer.Buffer.Name)}, {string.Join(", ", outputs.Select(output => $"{ProjectedOutputType(output)} {Escape(output.Name)}"))})";
		return $"\t\tpublic {returnType} {method.Name}({string.Join(", ", inputs.Select(RenderProjectedInputParameter))}) => " +
			$"instance.{capabilityName}.{method.InvocationName}({string.Join(", ", inputs.Select(parameter => parameter.IsRef ? $"ref {Escape(parameter.Name)}" : Escape(parameter.Name)))});";
	}

	private static bool CanProjectOutputs(ManagedMethod method) =>
		method.ReturnType == "int" &&
		method.Parameters.Any(parameter => parameter.IsOut);

	private static bool TryGetOutputArrayBuffer(ManagedMethod method, out ManagedParameter buffer)
	{
		var candidate = method.Parameters.SingleOrDefault(parameter =>
			parameter.Type is not "char[]" and not "char[]?" &&
			parameter.Type.Contains("[]", StringComparison.Ordinal) &&
			parameter.IsOutAttribute && !parameter.IsInAttribute &&
			parameter.CountElementName is not null);
		if (candidate is null || !method.Parameters.Any(parameter => parameter.Name == candidate.CountElementName && !parameter.IsOut && !parameter.IsRef))
		{
			buffer = null!;
			return false;
		}
		buffer = candidate;
		return true;
	}

	private static string RenderCapabilityOutputArrayMethod(ManagedMethod method, string capabilityName, ManagedParameter buffer)
	{
		var inputs = method.Parameters.Where(parameter => !parameter.IsOut && parameter != buffer && !parameter.IsEnumeratorMaxOne).ToArray();
		var outputs = method.Parameters.Where(parameter => parameter.IsOut).Prepend(buffer).ToArray();
		var bufferType = buffer.Type.Replace("?", "", StringComparison.Ordinal);
		var returnType = outputs.Length == 1
			? bufferType
			: $"({string.Join(", ", outputs.Select(output => $"{(output == buffer ? bufferType : ProjectedOutputType(output))} {Escape(output.Name)}"))})";
		var arguments = string.Join(", ", inputs.Select(parameter => parameter.IsRef ? $"ref {Escape(parameter.Name)}" : Escape(parameter.Name)));
		return $"\t\tpublic {returnType} {method.Name}({string.Join(", ", inputs.Select(RenderProjectedInputParameter))}) => " +
			$"instance.{capabilityName}.{method.Name}({arguments});";
	}

	private static bool IsComEnumeration(ManagedMethod method) =>
		method.ReturnType == "int" &&
		method.Parameters.Count(parameter => parameter.IsOut) == 1 &&
		method.Parameters.Single(parameter => parameter.IsOut).Type is { } type &&
		type is not "ICorDebugEnum" and not "ICorDebugEnum?" &&
		(type.EndsWith("Enum", StringComparison.Ordinal) || type.EndsWith("Enum?", StringComparison.Ordinal));

	private static bool IsParameterlessEnumeration(ManagedMethod method) =>
		IsComEnumeration(method) &&
		method.Name.StartsWith("Enumerate", StringComparison.Ordinal) &&
		method.Parameters.All(parameter => parameter.IsOut);

	private string RenderComEnumerationMember(ManagedInterface @interface, ManagedMethod method)
	{
		var enumerator = method.Parameters.Single(parameter => parameter.IsOut);
		var next = catalog.GetMethod(enumerator.Type.TrimEnd('?'), "Next");
		var values = next.Parameters.Single(parameter => parameter.Type.Contains("[]", StringComparison.Ordinal));
		var inputs = method.Parameters.Where(parameter => !parameter.IsOut).ToArray();
		var arguments = string.Join(", ", method.Parameters.Select(parameter => parameter.IsOut
			? $"out var {Escape(parameter.Name)}"
			: parameter.IsRef ? $"ref {Escape(parameter.Name)}" : RenderRawArgument(parameter)));
		return $"\t\tpublic IEnumerable<{ElementType(values.Type)}> {method.Name}({string.Join(", ", inputs.Select(RenderProjectedInputParameter))})\n\t\t{{\n" +
			$"\t\t\tvar hr = instance.{method.InvocationName}({arguments});\n\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\treturn {method.Name}Core({Escape(enumerator.Name)});\n\t\t}}";
	}

	private string RenderEnumerationArrayProperty(ManagedMethod method)
	{
		var enumerator = method.Parameters.Single(parameter => parameter.IsOut);
		var next = catalog.GetMethod(enumerator.Type.TrimEnd('?'), "Next");
		var values = next.Parameters.Single(parameter => parameter.Type.Contains("[]", StringComparison.Ordinal));
		return $"\t\tpublic {ElementType(values.Type)}[] {PropertyName(method.Name["Enumerate".Length..])} => instance.{method.Name}().ToArray();";
	}

	private string RenderComEnumerationHelper(ManagedMethod method)
	{
		var enumerator = method.Parameters.Single(parameter => parameter.IsOut);
		var next = catalog.GetMethod(enumerator.Type.TrimEnd('?'), "Next");
		var values = next.Parameters.Single(parameter => parameter.Type.Contains("[]", StringComparison.Ordinal));
		var count = next.Parameters.Single(parameter => parameter.IsOut);
		var elementType = ElementType(values.Type);
		return $"\tprivate static IEnumerable<{elementType}> {method.Name}Core({enumerator.Type} enumerator)\n\t{{\n\t\twhile (true)\n\t\t{{\n" +
			$"\t\t\tvar values = new {elementType}[1];\n\t\t\tvar hr = enumerator.{next.InvocationName}(1, values, out var {Escape(count.Name)});\n" +
			$"\t\t\tif ({Escape(count.Name)} == 0)\n\t\t\t\tyield break;\n\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\tif ({Escape(count.Name)} != 1)\n\t\t\t\tthrow new InvalidOperationException(\"Native debugger enumerator returned an invalid item count.\");\n\t\t\tyield return values[0];\n\t\t}}\n\t}}";
	}

	private static string ElementType(string arrayType) => arrayType.Replace("?", "", StringComparison.Ordinal).Replace("[]", "", StringComparison.Ordinal);

	private static bool CanProjectReturn(ManagedMethod method) =>
		method.ReturnType is not "int" and not "void" &&
		method.Parameters.Count == 0;

	private static bool IsParameterlessGetter(ManagedMethod method) =>
		(method.Name.StartsWith("Get", StringComparison.Ordinal) && method.Name.Length > 3 ||
		 method.Name.StartsWith("Is", StringComparison.Ordinal) && method.Name.Length > 2) &&
		method.Parameters.All(parameter => parameter.IsOut);

	private static string GetPropertyName(ManagedMethod method) =>
		method.Name.StartsWith("Get", StringComparison.Ordinal) ? PropertyName(method.Name[3..]) : method.Name;

	private static string RenderProjectedMethod(ManagedMethod method, string? publicName = null)
	{
		var outputs = method.Parameters.Where(parameter => parameter.IsOut).ToArray();
		var inputs = method.Parameters.Where(parameter => !parameter.IsOut && !parameter.IsEnumeratorMaxOne).ToArray();
		var refUInts = inputs.Where(IsRefUInt).ToArray();
		var returnType = outputs.Length == 1
			? ProjectedOutputType(outputs[0])
			: $"({string.Join(", ", outputs.Select(output => $"{ProjectedOutputType(output)} {Escape(output.Name)}"))})";
		var parameters = string.Join(", ", inputs.Select(RenderProjectedInputParameter));
		var arguments = string.Join(", ", method.Parameters.Select(parameter => parameter.IsOut
			? $"out var {Escape(parameter.Name)}"
			: parameter.IsEnumeratorMaxOne ? "1"
			: IsRefUInt(parameter) ? $"ref {RefUIntLocalName(parameter)}"
			: parameter.IsRef ? $"ref {Escape(parameter.Name)}" : RenderRawArgument(parameter)));
		var result = outputs.Length == 1
			? ProjectedOutputValue(outputs[0])
			: $"({string.Join(", ", outputs.Select(output => ProjectedOutputValue(output)))})";
		return $"\t\tpublic {returnType} {publicName ?? method.Name}({parameters})\n\t\t{{\n" +
			$"{RenderRefUIntLocals(refUInts, "\t\t\t")}\t\t\tvar hr = instance.{method.InvocationName}({arguments});\n{RenderRefUIntAssignments(refUInts, "\t\t\t")}" +
			$"\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\treturn {result};\n\t\t}}";
	}

	private static string RenderOutputArrayMethod(ManagedMethod method)
	{
		if (!TryGetOutputArrayBuffer(method, out var buffer))
			throw new InvalidOperationException($"{method.Name} does not have a supported output array buffer.");
		var inputs = method.Parameters.Where(parameter => !parameter.IsOut && parameter != buffer && !parameter.IsEnumeratorMaxOne).ToArray();
		var outputs = method.Parameters.Where(parameter => parameter.IsOut).Prepend(buffer).ToArray();
		var bufferType = buffer.Type.Replace("?", "", StringComparison.Ordinal);
		var returnType = outputs.Length == 1
			? bufferType
			: $"({string.Join(", ", outputs.Select(output => $"{(output == buffer ? bufferType : ProjectedOutputType(output))} {Escape(output.Name)}"))})";
		var parameters = string.Join(", ", inputs.Select(RenderProjectedInputParameter));
		var arguments = string.Join(", ", method.Parameters.Select(parameter => parameter == buffer
			? Escape(buffer.Name)
			: parameter.IsOut ? $"out var {Escape(parameter.Name)}"
			: parameter.IsEnumeratorMaxOne ? "1"
			: parameter.IsRef ? $"ref {Escape(parameter.Name)}" : RenderRawArgument(parameter)));
		var result = outputs.Length == 1
			? Escape(buffer.Name)
			: $"({string.Join(", ", outputs.Select(output => output == buffer ? Escape(output.Name) : ProjectedOutputValue(output)))})";
		return $"\t\tpublic {returnType} {method.Name}({parameters})\n\t\t{{\n" +
			$"\t\t\tvar {Escape(buffer.Name)} = new {ElementType(buffer.Type)}[checked((int){Escape(buffer.CountElementName!)})];\n" +
			$"\t\t\tvar hr = instance.{method.InvocationName}({arguments});\n\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\treturn {result};\n\t\t}}";
	}

	private static string RenderOutputProperty(ManagedMethod method, string propertyName, string call, ManagedMethod? setter = null, string? setterCall = null)
	{
		var outputs = method.Parameters;
		var returnType = outputs.Count == 1
			? ProjectedOutputType(outputs[0])
			: $"({string.Join(", ", outputs.Select(output => $"{ProjectedOutputType(output)} {Escape(output.Name)}"))})";
		var arguments = string.Join(", ", outputs.Select(output => $"out var {Escape(output.Name)}"));
		var result = outputs.Count == 1
			? ProjectedOutputValue(outputs[0])
			: $"({string.Join(", ", outputs.Select(output => ProjectedOutputValue(output)))})";
		return $"\t\tpublic {returnType} {propertyName}\n\t\t{{\n\t\t\tget\n\t\t\t{{\n" +
			$"\t\t\t\tvar hr = {call}({arguments});\n\t\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\t\treturn {result};\n" +
			"\t\t\t}" +
			(setter is null ? "" : $"\n\t\t\tset\n\t\t\t{{\n\t\t\t\tvar hr = {setterCall ?? $"instance.{setter.InvocationName}"}({RenderRawArgument(setter.Parameters[0], "value")});\n\t\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\t}}") +
			"\n\t\t}";
	}

	private static ManagedMethod? FindPropertySetter(ManagedInterface @interface, ManagedMethod getter) =>
		getter.Name.StartsWith("Get", StringComparison.Ordinal) && @interface.Methods.TryGetValue("Set" + getter.Name[3..], out var setter) && IsPropertySetter(getter, setter)
			? setter
			: null;

	private static bool IsPropertySetter(ManagedMethod getter, ManagedMethod setter) =>
		IsParameterlessGetter(getter) &&
		getter.Parameters.Count == 1 &&
		setter.ReturnType == "int" &&
		setter.Parameters.Count == 1 &&
		!setter.Parameters[0].IsOut &&
		!setter.Parameters[0].IsRef &&
		ProjectedOutputType(getter.Parameters[0]) == setter.Parameters[0].Type;

	private static string RenderReturnProperty(ManagedMethod method) =>
		$"\t\tpublic {PublicType(method.ReturnType)} {method.Name} => {ProjectValue(method.ReturnType, $"instance.{method.InvocationName}()")};";

	private string RenderBoolResult(BoolResultRecipe recipe)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		var parameters = string.Join(", ", method.Parameters.Select(RenderProjectedInputParameter));
		var arguments = string.Join(", ", method.Parameters.Select(parameter => parameter.IsRef ? $"ref {Escape(parameter.Name)}" : RenderRawArgument(parameter)));
		return $"\t\tpublic bool {method.Name}({parameters}) => instance.{method.InvocationName}({arguments}) != 0;";
	}

	private static string RenderVoidMethod(ManagedMethod method)
	{
		var inputs = method.Parameters.Where(parameter => !parameter.IsEnumeratorMaxOne).ToArray();
		var refUInts = inputs.Where(IsRefUInt).ToArray();
		var parameters = string.Join(", ", inputs.Select(RenderProjectedInputParameter));
		var arguments = string.Join(", ", method.Parameters.Select(parameter => parameter.IsEnumeratorMaxOne
			? "1"
			: IsRefUInt(parameter) ? $"ref {RefUIntLocalName(parameter)}"
			: parameter.IsRef ? $"ref {Escape(parameter.Name)}" : RenderRawArgument(parameter)));
		return $"\t\tpublic void {method.Name}({parameters})\n\t\t{{\n" +
			$"{RenderRefUIntLocals(refUInts, "\t\t\t")}\t\t\tvar hr = instance.{method.InvocationName}({arguments});\n{RenderRefUIntAssignments(refUInts, "\t\t\t")}" +
			"\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t}";
	}


	private static string RenderProjectedInputParameter(ManagedParameter parameter) =>
		$"{(parameter.IsOut ? "out " : parameter.IsRef ? "ref " : "")}{PublicType(parameter)} {Escape(parameter.Name)}";

	private static string RenderRawParameter(ManagedParameter parameter) =>
		$"{(parameter.IsOut ? "out " : parameter.IsRef ? "ref " : "")}{(IsSignatureBlob(parameter) ? "nint" : parameter.Type)} {Escape(parameter.Name)}";

	private static string RenderRawArgument(ManagedParameter parameter, string? name = null) =>
		IsUInt(parameter) ? $"checked((uint){name ?? Escape(parameter.Name)})" :
		IsSignatureBlob(parameter) ? $"(byte*){name ?? Escape(parameter.Name)}" :
		name ?? Escape(parameter.Name);

	private static bool TryGetStringBuffer(ManagedMethod method, out (ManagedParameter Buffer, ManagedParameter Capacity, ManagedParameter Count) value)
	{
		var buffer = method.Parameters.FirstOrDefault(parameter =>
			parameter.Type is "char[]" or "char[]?" && parameter.SizeParamIndex is not null);
		if (buffer?.SizeParamIndex is not int capacityIndex || capacityIndex + 1 >= method.Parameters.Count)
		{
			value = default;
			return false;
		}
		var count = method.Parameters[capacityIndex + 1];
		if (!count.IsOut)
			throw new InvalidOperationException($"{method.Name}.{buffer.Name} is not followed by an output character count.");
		value = (buffer, method.Parameters[capacityIndex], count);
		return true;
	}

	private static string RenderAutomaticStringQuery(ManagedMethod method)
	{
		if (!TryGetStringBuffer(method, out var stringBuffer))
			throw new InvalidOperationException($"{method.Name} is not a string query method.");
		var omitted = new HashSet<string>(StringComparer.Ordinal) { stringBuffer.Buffer.Name, stringBuffer.Capacity.Name, stringBuffer.Count.Name };
		var inputs = method.Parameters.Where(parameter =>
			!parameter.IsOut && !parameter.IsEnumeratorMaxOne && !omitted.Contains(parameter.Name)).ToArray();
		var outputs = method.Parameters.Where(parameter => parameter.IsOut && parameter.Name != stringBuffer.Count.Name).ToArray();
		var returnType = outputs.Length == 0
			? "string"
			: $"(string {Escape(stringBuffer.Buffer.Name)}, {string.Join(", ", outputs.Select(output => $"{ProjectedOutputType(output)} {Escape(output.Name)}"))})";
		var parameters = string.Join(", ", inputs.Select(RenderProjectedInputParameter));
		var queryArguments = RenderStringCallArguments(method, stringBuffer, inputs, outputs, true);
		var fillArguments = RenderStringCallArguments(method, stringBuffer, inputs, outputs, false);
		var result = outputs.Length == 0
			? "CreateString(buffer, actual, true)"
			: $"(CreateString(buffer, actual, true), {string.Join(", ", outputs.Select(output => ProjectedOutputValue(output)))})";
		var emptyResult = outputs.Length == 0
			? "string.Empty"
			: $"(string.Empty, {string.Join(", ", outputs.Select(output => ProjectedOutputValue(output, "query")))})";
		var body =
			$"\t\t\tvar hr = instance.{method.InvocationName}({queryArguments});\n\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\tif (required == 0)\n\t\t\t\treturn {emptyResult};\n\n" +
			"\t\t\tfor (var attempt = 0; attempt < 3; attempt++)\n\t\t\t{\n\t\t\t\tvar capacity = required;\n\t\t\t\tvar buffer = new char[checked((int)capacity)];\n" +
			$"\t\t\t\thr = instance.{method.InvocationName}({fillArguments});\n\t\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\t\tif (actual > capacity)\n\t\t\t\t{{\n\t\t\t\t\trequired = actual;\n\t\t\t\t\tcontinue;\n\t\t\t\t}}\n\n" +
			$"\t\t\t\treturn {result};\n\t\t\t}}\n\n\t\t\tthrow new InvalidOperationException(\"Native buffer size did not stabilize.\");\n\t\t}}";
		return inputs.Length == 0 && method.Name.StartsWith("Get", StringComparison.Ordinal) && method.Name.Length > 3
			? $"\t\tpublic {returnType} {method.Name[3..]}\n\t\t{{\n\t\t\tget\n\t\t\t{{\n{Indent(body, "\t")}\n\t\t\t}}\n\t\t}}"
			: $"\t\tpublic {returnType} {method.Name}({parameters})\n\t\t{{\n{body}";
	}

	private static string RenderStringCallArguments(ManagedMethod method,
		(ManagedParameter Buffer, ManagedParameter Capacity, ManagedParameter Count) stringBuffer,
		IReadOnlyCollection<ManagedParameter> inputs, IReadOnlyCollection<ManagedParameter> outputs, bool query)
	{
		var inputNames = inputs.Select(parameter => parameter.Name).ToHashSet(StringComparer.Ordinal);
		var outputNames = outputs.Select(parameter => parameter.Name).ToHashSet(StringComparer.Ordinal);
		return string.Join(", ", method.Parameters.Select(parameter => parameter.Name switch
		{
			var name when name == stringBuffer.Buffer.Name => query ? "null" : "buffer",
			var name when name == stringBuffer.Capacity.Name => query ? "0" : "capacity",
			var name when name == stringBuffer.Count.Name => query ? "out var required" : "out var actual",
			var name when outputNames.Contains(name) => $"out var {(query ? "query" + char.ToUpperInvariant(name[0]) + name[1..] : Escape(name))}",
			_ when parameter.IsEnumeratorMaxOne => "1",
			var name when inputNames.Contains(name) => parameter.IsRef ? $"ref {Escape(name)}" : RenderRawArgument(parameter),
			_ => throw new InvalidOperationException($"Unexpected parameter {parameter.Name} in {method.Name} string query."),
		}));
	}

	private static string ProjectedOutputType(ManagedParameter parameter)
	{
		if (parameter.Type == "byte*")
			return "nint";
		const string readOnlySpanPrefix = "ReadOnlySpan<";
		const string spanPrefix = "Span<";
		if (parameter.Type.StartsWith(readOnlySpanPrefix, StringComparison.Ordinal) && parameter.Type.EndsWith('>'))
			return parameter.Type[readOnlySpanPrefix.Length..^1] + "[]";
		if (parameter.Type.StartsWith(spanPrefix, StringComparison.Ordinal) && parameter.Type.EndsWith('>'))
			return parameter.Type[spanPrefix.Length..^1] + "[]";
		return PublicType(parameter.Type);
	}

	private static string ProjectedOutputValue(ManagedParameter parameter, string prefix = "") =>
		parameter.Type.Contains("Span<", StringComparison.Ordinal)
			? $"{Escape(prefix + (prefix.Length == 0 ? parameter.Name : char.ToUpperInvariant(parameter.Name[0]) + parameter.Name[1..]))}.ToArray()"
			: ProjectValue(parameter.Type, Escape(prefix + (prefix.Length == 0 ? parameter.Name : char.ToUpperInvariant(parameter.Name[0]) + parameter.Name[1..])));

	private string RenderQueryBuffer(QueryBufferRecipe recipe)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		ValidateHResult(method, recipe.Interface);
		ValidateQueryBuffer(method, recipe);
		var buffer = method.GetParameter(recipe.Buffer);

		var retained = method.Parameters.Where(parameter => parameter.Name != recipe.Capacity && parameter.Name != recipe.Count && parameter.Name != recipe.Buffer).ToArray();
		if (retained.Any(parameter => parameter.IsOut || parameter.IsRef))
			throw new InvalidOperationException($"{recipe.Interface}.{recipe.Method} has unsupported retained output parameters.");
		var elementType = buffer.Type.Replace("?", "", StringComparison.Ordinal).Replace("[]", "", StringComparison.Ordinal);
		var returnType = recipe.Kind == BufferKind.String ? "string" : $"{elementType}[]";
		var declaration = retained.Length == 0 && recipe.Method.StartsWith("Get", StringComparison.Ordinal)
			? $"\t\tpublic {returnType} {PropertyName(recipe.Method[3..])}\n\t\t{{\n\t\t\tget\n\t\t\t{{\n{RenderQueryBody(method, recipe, retained, elementType, 4)}\n\t\t\t}}\n\t\t}}"
			: $"\t\tpublic {returnType} {recipe.Method}({string.Join(", ", retained.Select(RenderInputParameter))})\n\t\t{{\n{RenderQueryBody(method, recipe, retained, elementType, 3)}\n\t\t}}";
		return declaration;
	}

	private static string RenderQueryBody(ManagedMethod method, QueryBufferRecipe recipe, IReadOnlyList<ManagedParameter> retained, string elementType, int indent)
	{
		var prefix = new string('\t', indent);
		if (recipe.CapacityProperty is not null)
		{
			var arguments = RenderArguments(method, recipe, retained, "checked((uint)capacity)", "actual", "buffer");
			var directEmpty = recipe.Kind == BufferKind.String ? "string.Empty" : "[]";
			var directResult = recipe.Kind == BufferKind.String
				? "var length = checked((int)actual);\nif (length > 0 && buffer[length - 1] == '\\0')\n\tlength--;\n\nreturn new string(buffer, 0, length);"
				: "if (actual != capacity)\n\tArray.Resize(ref buffer, checked((int)actual));\n\nreturn buffer;";
			return $"{prefix}var capacity = instance.{recipe.CapacityProperty};\n" +
				$"{prefix}if (capacity == 0)\n{prefix}\treturn {directEmpty};\n\n" +
				$"{prefix}var buffer = new {elementType}[capacity];\n" +
				$"{prefix}var hr = instance.{method.InvocationName}({arguments});\n" +
				$"{prefix}Marshal.ThrowExceptionForHR(hr);\n" +
				$"{prefix}if (actual > capacity)\n{prefix}\tthrow new InvalidOperationException(\"Native buffer size exceeded the reported capacity.\");\n\n" +
				Indent(directResult, prefix);
		}
		var first = RenderArguments(method, recipe, retained, "0", "required", "null!");
		var second = RenderArguments(method, recipe, retained, "capacity", "actual", "buffer");
		var empty = recipe.Kind == BufferKind.String ? "string.Empty" : "[]";
		var result = recipe.Kind == BufferKind.String
			? "var length = checked((int)actual);\nif (length > 0 && buffer[length - 1] == '\\0')\n\tlength--;\n\nreturn new string(buffer, 0, length);"
			: "if (actual != capacity)\n\tArray.Resize(ref buffer, checked((int)actual));\n\nreturn buffer;";
		return $"{prefix}var hr = instance.{method.InvocationName}({first});\n" +
			$"{prefix}Marshal.ThrowExceptionForHR(hr);\n{prefix}if (required == 0)\n{prefix}\treturn {empty};\n\n" +
			$"{prefix}for (var attempt = 0; attempt < 3; attempt++)\n{prefix}{{\n" +
			$"{prefix}\tvar capacity = required;\n{prefix}\tvar buffer = new {elementType}[checked((int)capacity)];\n" +
			$"{prefix}\thr = instance.{method.InvocationName}({second});\n{prefix}\tMarshal.ThrowExceptionForHR(hr);\n" +
			$"{prefix}\tif (actual > capacity)\n{prefix}\t{{\n{prefix}\t\trequired = actual;\n{prefix}\t\tcontinue;\n{prefix}\t}}\n\n" +
			$"{Indent(result, prefix + "\t")}\n{prefix}}}\n\n" +
			$"{prefix}throw new InvalidOperationException(\"Native buffer size did not stabilize.\");";
	}

	private static string RenderArguments(ManagedMethod method, QueryBufferRecipe recipe, IReadOnlyList<ManagedParameter> retained, string capacity, string count, string buffer)
	{
		var retainedNames = retained.Select(parameter => parameter.Name).ToHashSet(StringComparer.Ordinal);
		return string.Join(", ", method.Parameters.Select(parameter => parameter.Name switch
		{
			var name when name == recipe.Capacity => capacity,
			var name when name == recipe.Count => $"out var {count}",
			var name when name == recipe.Buffer => buffer,
			var name when retainedNames.Contains(name) => RenderRawArgument(parameter),
			_ => throw new InvalidOperationException($"Unexpected parameter {parameter.Name} in {method.Name} recipe."),
		}));
	}

	private string RenderEnumerationMember(EnumerationRecipe recipe)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		var returnType = EnumerationReturnType(recipe);
		var call = $"Enumerate{recipe.Method[4..]}Core(instance{string.Concat(recipe.Inputs.Select(input => $", {Escape(input.Name)}"))})";
		return $"\t\tpublic IEnumerable<{returnType}> {recipe.Method}({string.Join(", ", recipe.Inputs.Select(input => $"{PublicType(method.GetParameter(input.Name).Type)} {Escape(input.Name)}"))}) => {call};";
	}

	private string RenderEnumerationHelper(EnumerationRecipe recipe)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		var suffix = recipe.Method[4..];
		var inputs = string.Concat(recipe.Inputs.Select(input => $", {PublicType(method.GetParameter(input.Name).Type)} {Escape(input.Name)}"));
		var outputArguments = string.Join(", ", recipe.Outputs.Select(output => $"out var {Escape(Camel(output.PublicName))}"));
		var callArguments = new List<string> { "ref handle" };
		callArguments.AddRange(recipe.Inputs.Select(input => RenderRawArgument(method.GetParameter(input.Name))));
		callArguments.Add(outputArguments);
		callArguments.Add("1");
		callArguments.Add("out var count");
		var result = recipe.Outputs.Count == 1
			? Escape(Camel(recipe.Outputs[0].PublicName))
			: $"({string.Join(", ", recipe.Outputs.Select(output => Escape(Camel(output.PublicName))))})";
		return $"\tprivate static IEnumerable<{EnumerationReturnType(recipe)}> Enumerate{suffix}Core({recipe.Interface} instance{inputs})\n" +
			"\t{\n\t\tvar handle = default(HCorEnum);\n\t\ttry\n\t\t{\n\t\t\twhile (true)\n\t\t\t{\n" +
			$"\t\t\t\tvar hr = instance.{method.InvocationName}({string.Join(", ", callArguments)});\n" +
			"\t\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\t\tif (count == 0)\n\t\t\t\t\tyield break;\n" +
			"\t\t\t\tif (count != 1)\n\t\t\t\t\tthrow new InvalidOperationException(\"Native metadata enumerator returned an invalid item count.\");\n" +
			$"\t\t\t\tyield return {result};\n\t\t\t}}\n\t\t}}\n\t\tfinally\n\t\t{{\n\t\t\tif (!handle.IsNull)\n\t\t\t\tinstance.TryCloseEnum(handle);\n\t\t}}\n\t}}";
	}

	private static string RenderStringMember(StringQueryRecipe recipe)
	{
		var call = $"Query{recipe.Method}(instance{(recipe.Parameters.Length == 0 ? "" : ", " + string.Join(", ", recipe.Parameters.Split(", ").Select(parameter => parameter.Split(' ')[^1])))})";
		return recipe.Parameters.Length == 0 && recipe.Method.StartsWith("Get", StringComparison.Ordinal)
			? $"\t\tpublic {recipe.ReturnType} {recipe.Method[3..]} => {call};"
			: $"\t\tpublic {recipe.ReturnType} {recipe.Method}({recipe.Parameters}) => {call};";
	}

	private static string RenderStringHelper(StringQueryRecipe recipe) =>
		$"\tprivate static {recipe.ReturnType} Query{recipe.Method}({recipe.Interface} instance{(recipe.Parameters.Length == 0 ? "" : ", " + recipe.Parameters)})\n" +
		"\t{\n" +
		$"\t\tvar hr = instance.Try{recipe.Method}({recipe.QueryArguments});\n\t\tMarshal.ThrowExceptionForHR(hr);\n\t\tif (required == 0)\n\t\t\treturn {EmptyStringResult(recipe)};\n\n" +
		"\t\tfor (var attempt = 0; attempt < 3; attempt++)\n\t\t{\n\t\t\tvar capacity = required;\n\t\t\tvar buffer = new char[checked((int)capacity)];\n" +
		$"\t\t\thr = instance.Try{recipe.Method}({recipe.FillArguments});\n\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\tif (actual > capacity)\n\t\t\t{{\n\t\t\t\trequired = actual;\n\t\t\t\tcontinue;\n\t\t\t}}\n\n" +
		$"\t\t\treturn {recipe.ReturnExpression};\n\t\t}}\n\n\t\tthrow new InvalidOperationException(\"Native buffer size did not stabilize.\");\n\t}}";

	private static string EmptyStringResult(StringQueryRecipe recipe) => recipe.ReturnType switch
	{
		"string" => "string.Empty",
		"(string szName, Guid pmvid)" => "(string.Empty, default)",
		"(string szTypeDef, CorTypeAttr pdwTypeDefFlags, mdToken ptkExtends)" => "(string.Empty, default, default)",
		"(mdToken ptkResolutionScope, string szName)" => "(default, string.Empty)",
		_ => throw new InvalidOperationException($"No empty result is configured for {recipe.Interface}.{recipe.Method}."),
	};

	private static string RenderStringHelper() =>
		"\tprivate static string CreateString(char[] buffer, uint count, bool trimTerminator)\n\t{\n\t\tvar length = checked((int)count);\n\t\tif (trimTerminator && length > 0 && buffer[length - 1] == '\\0')\n\t\t\tlength--;\n\t\treturn new string(buffer, 0, length);\n\t}";

	private void ValidateEnumeration(EnumerationRecipe recipe)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		ValidateHResult(method, recipe.Interface);
		var expected = new List<string> { "phEnum" };
		expected.AddRange(recipe.Inputs.Select(input => input.Name));
		expected.AddRange(recipe.Outputs.Select(output => output.RawName));
		expected.Add(method.Parameters[^2].Name);
		expected.Add(method.Parameters[^1].Name);
		if (!method.Parameters.Select(parameter => parameter.Name).SequenceEqual(expected, StringComparer.Ordinal))
			throw new InvalidOperationException($"{recipe.Interface}.{recipe.Method} no longer matches its enumeration recipe.");
	}

	private static void ValidateHResult(ManagedMethod method, string interfaceName)
	{
		if (method.ReturnType != "int")
			throw new InvalidOperationException($"{interfaceName}.{method.Name} must return an HRESULT-compatible int.");
	}

	private static void ValidateQueryBuffer(ManagedMethod method, QueryBufferRecipe recipe)
	{
		var capacity = method.GetParameter(recipe.Capacity);
		var count = method.GetParameter(recipe.Count);
		var buffer = method.GetParameter(recipe.Buffer);
		if (capacity is not { Type: "uint", IsOut: false, IsRef: false } ||
			count is not { Type: "uint", IsOut: true, IsRef: false } ||
			!buffer.Type.Contains("[]", StringComparison.Ordinal) ||
			!buffer.IsOutAttribute ||
			buffer.CountElementName != recipe.Capacity)
			throw new InvalidOperationException($"{recipe.Interface}.{recipe.Method} no longer has the configured query-buffer shape.");
	}

	private static void ValidateBoolResult(ManagedMethod method, string interfaceName)
	{
		if (method.ReturnType != "int" || method.Parameters.Any(parameter => parameter.IsOut))
			throw new InvalidOperationException($"{interfaceName}.{method.Name} no longer has the configured BOOL result shape.");
	}

	private string EnumerationReturnType(EnumerationRecipe recipe)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		return recipe.Outputs.Count == 1
			? method.GetParameter(recipe.Outputs[0].RawName).Type
			: $"({string.Join(", ", recipe.Outputs.Select(output => $"{method.GetParameter(output.RawName).Type} {output.PublicName}"))})";
	}

	private static string Header(string rawNamespace)
	{
		var namespaceUsings = new[] { "ICorDebugSharp", rawNamespace }.Distinct(StringComparer.Ordinal);
		return "// <auto-generated />\n#nullable enable\nusing System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Reflection;\nusing System.Runtime.InteropServices;\n" +
			string.Concat(namespaceUsings.Select(@namespace => $"using {@namespace};\n")) +
			"\nnamespace ICorDebugSharp.Extensions;\n\n";
	}

	private static string Indent(string value, string indentation) =>
		string.Join("\n", value.Split('\n').Select(line => line.Length == 0 ? "" : indentation + line));

	private static string RenderInputParameter(ManagedParameter parameter) => $"{PublicType(parameter)} {Escape(parameter.Name)}";
	private static bool IsUInt(ManagedParameter parameter) => parameter.Type == "uint";
	private static bool IsRefUInt(ManagedParameter parameter) => parameter.IsRef && IsUInt(parameter);
	private static bool IsSignatureBlob(ManagedParameter parameter) => parameter.Type == "byte*" && parameter.Name == "pvSigBlob";
	private static string RefUIntLocalName(ManagedParameter parameter) => Escape(parameter.Name + "Native");
	private static string RenderRefUIntLocals(IEnumerable<ManagedParameter> parameters, string indentation) =>
		string.Concat(parameters.Select(parameter => $"{indentation}var {RefUIntLocalName(parameter)} = checked((uint){Escape(parameter.Name)});\n"));
	private static string RenderRefUIntAssignments(IEnumerable<ManagedParameter> parameters, string indentation) =>
		string.Concat(parameters.Select(parameter => $"{indentation}{Escape(parameter.Name)} = checked((int){RefUIntLocalName(parameter)});\n"));
	private static string PublicType(ManagedParameter parameter) => IsSignatureBlob(parameter) ? "nint" : PublicType(parameter.Type);
	private static string PublicType(string type) => type == "uint" ? "int" : type;
	private static string ProjectValue(string type, string value) => type switch
	{
		"uint" => $"checked((int){value})",
		"byte*" => $"(nint){value}",
		_ => value,
	};
	private static string PropertyName(string name) => name == "ID" ? "Id" : name;
	private static string Escape(string name) => name is "base" or "event" or "params" or "ref" or "string" ? $"@{name}" : name;
	private static string Camel(string value) => char.ToLowerInvariant(value[0]) + value[1..];
}
