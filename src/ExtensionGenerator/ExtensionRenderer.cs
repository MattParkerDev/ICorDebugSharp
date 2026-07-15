using System.Text;

namespace ExtensionGenerator;

internal sealed class ExtensionRenderer(ManagedInterfaceCatalog catalog)
{
	public IReadOnlyDictionary<string, string> Render()
	{
		var files = new Dictionary<string, string>(StringComparer.Ordinal);
		foreach (var group in Recipes.QueryBuffers.GroupBy(recipe => recipe.Interface, StringComparer.Ordinal))
			files[$"{group.Key}BufferExtensions.cs"] = RenderQueryBuffers(group.Key, group.ToArray());
		foreach (var interfaceName in Recipes.Enumerations.Select(recipe => recipe.Interface)
			.Concat(Recipes.MetadataStrings.Select(recipe => recipe.Interface)).Distinct(StringComparer.Ordinal))
			files[$"{interfaceName}Extensions.cs"] = RenderMetadata(interfaceName);
		foreach (var @interface in catalog.Interfaces)
		{
			var methods = @interface.Methods.Values.Where(CanProjectOutputs).OrderBy(method => method.Name, StringComparer.Ordinal).ToArray();
			if (methods.Length != 0)
				files[$"{@interface.Name}ProjectedExtensions.cs"] = RenderProjectedMembers(@interface, methods);
			var configuredStrings = Recipes.MetadataStrings.Select(recipe => (recipe.Interface, recipe.Method)).ToHashSet();
			var stringMethods = @interface.Methods.Values
				.Where(method => TryGetStringBuffer(method, out _) && !configuredStrings.Contains((@interface.Name, method.Name)))
				.OrderBy(method => method.Name, StringComparer.Ordinal).ToArray();
			if (stringMethods.Length != 0)
				files[$"{@interface.Name}StringExtensions.cs"] = RenderAutomaticStringQueries(@interface, stringMethods);
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

	private string RenderCapabilityFamily(ManagedInterface baseInterface, ManagedInterface capabilityInterface)
	{
		var capabilityName = capabilityInterface.Name["ICorDebug".Length..];
		var members = new List<string>
		{
			$"\t\tpublic bool Supports{capabilityName} => instance is {capabilityInterface.Name};",
			$"\t\tpublic {capabilityInterface.Name} {capabilityName} => GetCapability(instance);",
		};

		foreach (var method in capabilityInterface.Methods.Values.Where(method => method.ReturnType == "int").OrderBy(method => method.Name, StringComparer.Ordinal))
		{
			if (IsSimpleOutputProperty(method))
				members.Add(RenderCapabilityProperty(method));
			members.Add(method.Parameters.Any(parameter => parameter.IsOut)
				? RenderProjectedMethod(method).Replace("instance.", "GetCapability(instance).", StringComparison.Ordinal)
				: RenderCapabilityVoidMethod(method));
		}

		foreach (var recipe in Recipes.QueryBuffers.Where(recipe => recipe.Interface == capabilityInterface.Name))
			members.Add(RenderCapabilityQueryBuffer(recipe));

		var configuredStrings = Recipes.MetadataStrings.Select(recipe => (recipe.Interface, recipe.Method)).ToHashSet();
		foreach (var method in capabilityInterface.Methods.Values
			.Where(method => TryGetStringBuffer(method, out _) && !configuredStrings.Contains((capabilityInterface.Name, method.Name)))
			.OrderBy(method => method.Name, StringComparer.Ordinal))
			members.Add(RenderCapabilityStringQuery(method));

		return Header(baseInterface.Namespace) +
			$"public static unsafe class {baseInterface.Name[1..]}{capabilityName}Extensions\n{{\n" +
			$"\textension({baseInterface.Name} instance)\n\t{{\n{string.Join("\n\n", members)}\n\t}}\n\n" +
			$"\tprivate static {capabilityInterface.Name} GetCapability({baseInterface.Name} instance) =>\n" +
			$"\t\tinstance as {capabilityInterface.Name} ?? throw new NotSupportedException(\"{baseInterface.Name} does not support {capabilityInterface.Name}.\");\n}}\n";
	}

	private static string RenderCapabilityProperty(ManagedMethod method)
	{
		var output = method.Parameters[0];
		return $"\t\tpublic {output.Type} {method.Name[3..]}\n\t\t{{\n\t\t\tget\n\t\t\t{{\n" +
			$"\t\t\t\tvar hr = GetCapability(instance).{method.Name}(out var value);\n\t\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\t\treturn value;\n" +
			"\t\t\t}\n\t\t}";
	}

	private static string RenderCapabilityVoidMethod(ManagedMethod method)
	{
		var parameters = string.Join(", ", method.Parameters.Where(parameter => !parameter.IsEnumeratorMaxOne).Select(RenderProjectedInputParameter));
		var arguments = string.Join(", ", method.Parameters.Select(parameter => parameter.IsEnumeratorMaxOne
			? "1"
			: parameter.IsRef ? $"ref {Escape(parameter.Name)}" : Escape(parameter.Name)));
		return $"\t\tpublic void {method.Name}({parameters})\n\t\t{{\n" +
			$"\t\t\tvar hr = GetCapability(instance).{method.Name}({arguments});\n\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t}}";
	}

	private string RenderCapabilityQueryBuffer(QueryBufferRecipe recipe)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		var retained = method.Parameters.Where(parameter => parameter.Name != recipe.Capacity && parameter.Name != recipe.Count && parameter.Name != recipe.Buffer).ToArray();
		var buffer = method.GetParameter(recipe.Buffer);
		var returnType = recipe.Kind == BufferKind.String
			? "string"
			: $"{buffer.Type.Replace("?", "", StringComparison.Ordinal).Replace("[]", "", StringComparison.Ordinal)}[]";
		var publicName = recipe.Method.StartsWith("Get", StringComparison.Ordinal) ? recipe.Method[3..] : recipe.Method;
		return retained.Length == 0
			? $"\t\tpublic {returnType} {publicName} => GetCapability(instance).{publicName};"
			: $"\t\tpublic {returnType} {publicName}({string.Join(", ", retained.Select(RenderInputParameter))}) => GetCapability(instance).{publicName}({string.Join(", ", retained.Select(parameter => Escape(parameter.Name)))});";
	}

	private static string RenderCapabilityStringQuery(ManagedMethod method)
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
			$"GetCapability(instance).{method.Name}({string.Join(", ", inputs.Select(parameter => parameter.IsRef ? $"ref {Escape(parameter.Name)}" : Escape(parameter.Name)))});";
	}

	private static bool IsSimpleOutputProperty(ManagedMethod method) =>
		method.Name.StartsWith("Get", StringComparison.Ordinal) &&
		method.Name.Length > 3 &&
		method.Parameters.Count == 1 &&
		method.Parameters[0].IsOut;

	private static bool CanProjectOutputs(ManagedMethod method) =>
		method.ReturnType == "int" &&
		method.Parameters.Any(parameter => parameter.IsOut);

	private static string RenderProjectedMembers(ManagedInterface @interface, IReadOnlyList<ManagedMethod> methods)
	{
		var properties = methods.Where(IsSimpleOutputProperty).Select(method =>
		{
			var output = method.Parameters[0];
			var propertyName = method.Name[3..];
			return $"\t\tpublic {output.Type} {propertyName}\n\t\t{{\n\t\t\tget\n\t\t\t{{\n" +
				$"\t\t\t\tvar hr = instance.{method.Name}(out var value);\n\t\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\t\treturn value;\n" +
				"\t\t\t}\n\t\t}";
		});
		var projectedMethods = methods.Select(RenderProjectedMethod);
		var members = properties.Concat(projectedMethods);
		return Header(@interface.Namespace) +
			$"public static unsafe class {@interface.Name[1..]}ProjectedExtensions\n{{\n" +
			$"\textension({@interface.Name} instance)\n\t{{\n{string.Join("\n\n", members)}\n\t}}\n}}\n";
	}

	private static string RenderProjectedMethod(ManagedMethod method)
	{
		var outputs = method.Parameters.Where(parameter => parameter.IsOut).ToArray();
		var inputs = method.Parameters.Where(parameter => !parameter.IsOut && !parameter.IsEnumeratorMaxOne).ToArray();
		var returnType = outputs.Length == 1
			? ProjectedOutputType(outputs[0])
			: $"({string.Join(", ", outputs.Select(output => $"{ProjectedOutputType(output)} {Escape(output.Name)}"))})";
		var parameters = string.Join(", ", inputs.Select(RenderProjectedInputParameter));
		var arguments = string.Join(", ", method.Parameters.Select(parameter => parameter.IsOut
			? $"out var {Escape(parameter.Name)}"
			: parameter.IsEnumeratorMaxOne ? "1"
			: parameter.IsRef ? $"ref {Escape(parameter.Name)}" : Escape(parameter.Name)));
		var result = outputs.Length == 1
			? ProjectedOutputValue(outputs[0])
			: $"({string.Join(", ", outputs.Select(output => ProjectedOutputValue(output)))})";
		return $"\t\tpublic {returnType} {method.Name}({parameters})\n\t\t{{\n" +
			$"\t\t\tvar hr = instance.{method.Name}({arguments});\n\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\treturn {result};\n\t\t}}";
	}

	private static string RenderProjectedInputParameter(ManagedParameter parameter) =>
		$"{(parameter.IsRef ? "ref " : "")}{parameter.Type} {Escape(parameter.Name)}";

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

	private static string RenderAutomaticStringQueries(ManagedInterface @interface, IReadOnlyList<ManagedMethod> methods)
	{
		var members = methods.Select(RenderAutomaticStringQuery);
		return Header(@interface.Namespace) +
			$"public static unsafe class {@interface.Name[1..]}StringExtensions\n{{\n" +
			$"\textension({@interface.Name} instance)\n\t{{\n{string.Join("\n\n", members)}\n\t}}\n\n" +
			RenderStringHelper() + "\n}\n";
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
		return $"\t\tpublic {returnType} {method.Name}({parameters})\n\t\t{{\n" +
			$"\t\t\tvar hr = instance.{method.Name}({queryArguments});\n\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\tif (required == 0)\n\t\t\t\treturn {emptyResult};\n\n" +
			"\t\t\tfor (var attempt = 0; attempt < 3; attempt++)\n\t\t\t{\n\t\t\t\tvar capacity = required;\n\t\t\t\tvar buffer = new char[checked((int)capacity)];\n" +
			$"\t\t\t\thr = instance.{method.Name}({fillArguments});\n\t\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\t\tif (actual > capacity)\n\t\t\t\t{{\n\t\t\t\t\trequired = actual;\n\t\t\t\t\tcontinue;\n\t\t\t\t}}\n\n" +
			$"\t\t\t\treturn {result};\n\t\t\t}}\n\n\t\t\tthrow new InvalidOperationException(\"Native buffer size did not stabilize.\");\n\t\t}}";
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
			var name when inputNames.Contains(name) => parameter.IsRef ? $"ref {Escape(name)}" : Escape(name),
			_ => throw new InvalidOperationException($"Unexpected parameter {parameter.Name} in {method.Name} string query."),
		}));
	}

	private static string ProjectedOutputType(ManagedParameter parameter)
	{
		const string readOnlySpanPrefix = "ReadOnlySpan<";
		const string spanPrefix = "Span<";
		if (parameter.Type.StartsWith(readOnlySpanPrefix, StringComparison.Ordinal) && parameter.Type.EndsWith('>'))
			return parameter.Type[readOnlySpanPrefix.Length..^1] + "[]";
		if (parameter.Type.StartsWith(spanPrefix, StringComparison.Ordinal) && parameter.Type.EndsWith('>'))
			return parameter.Type[spanPrefix.Length..^1] + "[]";
		return parameter.Type;
	}

	private static string ProjectedOutputValue(ManagedParameter parameter, string prefix = "") =>
		parameter.Type.Contains("Span<", StringComparison.Ordinal)
			? $"{Escape(prefix + (prefix.Length == 0 ? parameter.Name : char.ToUpperInvariant(parameter.Name[0]) + parameter.Name[1..]))}.ToArray()"
			: Escape(prefix + (prefix.Length == 0 ? parameter.Name : char.ToUpperInvariant(parameter.Name[0]) + parameter.Name[1..]));

	private string RenderQueryBuffers(string interfaceName, IReadOnlyList<QueryBufferRecipe> recipes)
	{
		var @interface = catalog.GetInterface(interfaceName);
		var members = recipes.Select(RenderQueryBuffer).ToArray();
		return Header(@interface.Namespace) +
			$"public static class {interfaceName[1..]}BufferExtensions\n{{\n" +
			$"\textension({interfaceName} instance)\n\t{{\n{string.Join("\n\n", members)}\n\t}}\n}}\n";
	}

	private string RenderQueryBuffer(QueryBufferRecipe recipe)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		ValidateHResult(method, recipe.Interface);
		var capacity = method.GetParameter(recipe.Capacity);
		var count = method.GetParameter(recipe.Count);
		var buffer = method.GetParameter(recipe.Buffer);
		if (!count.IsOut || !buffer.Type.Contains("[]", StringComparison.Ordinal))
			throw new InvalidOperationException($"{recipe.Interface}.{recipe.Method} no longer has the configured output buffer shape.");

		var retained = method.Parameters.Where(parameter => parameter.Name != recipe.Capacity && parameter.Name != recipe.Count && parameter.Name != recipe.Buffer).ToArray();
		if (retained.Any(parameter => parameter.IsOut || parameter.IsRef))
			throw new InvalidOperationException($"{recipe.Interface}.{recipe.Method} has unsupported retained output parameters.");
		var elementType = buffer.Type.Replace("?", "", StringComparison.Ordinal).Replace("[]", "", StringComparison.Ordinal);
		var returnType = recipe.Kind == BufferKind.String ? "string" : $"{elementType}[]";
		var publicName = recipe.Method.StartsWith("Get", StringComparison.Ordinal) ? recipe.Method[3..] : recipe.Method;
		var declaration = retained.Length == 0
			? $"\t\tpublic {returnType} {publicName}\n\t\t{{\n\t\t\tget\n\t\t\t{{\n{RenderQueryBody(method, recipe, retained, elementType, 4)}\n\t\t\t}}\n\t\t}}"
			: $"\t\tpublic {returnType} {publicName}({string.Join(", ", retained.Select(RenderInputParameter))})\n\t\t{{\n{RenderQueryBody(method, recipe, retained, elementType, 3)}\n\t\t}}";
		return declaration;
	}

	private static string RenderQueryBody(ManagedMethod method, QueryBufferRecipe recipe, IReadOnlyList<ManagedParameter> retained, string elementType, int indent)
	{
		var prefix = new string('\t', indent);
		var first = RenderArguments(method, recipe, retained, "0", "required", "null!");
		var second = RenderArguments(method, recipe, retained, "capacity", "actual", "buffer");
		var empty = recipe.Kind == BufferKind.String ? "string.Empty" : "[]";
		var result = recipe.Kind == BufferKind.String
			? "var length = checked((int)actual);\nif (length > 0 && buffer[length - 1] == '\\0')\n\tlength--;\n\nreturn new string(buffer, 0, length);"
			: "if (actual != capacity)\n\tArray.Resize(ref buffer, checked((int)actual));\n\nreturn buffer;";
		return $"{prefix}var hr = instance.{method.Name}({first});\n" +
			$"{prefix}Marshal.ThrowExceptionForHR(hr);\n{prefix}if (required == 0)\n{prefix}\treturn {empty};\n\n" +
			$"{prefix}for (var attempt = 0; attempt < 3; attempt++)\n{prefix}{{\n" +
			$"{prefix}\tvar capacity = required;\n{prefix}\tvar buffer = new {elementType}[checked((int)capacity)];\n" +
			$"{prefix}\thr = instance.{method.Name}({second});\n{prefix}\tMarshal.ThrowExceptionForHR(hr);\n" +
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
			var name when retainedNames.Contains(name) => Escape(name),
			_ => throw new InvalidOperationException($"Unexpected parameter {parameter.Name} in {method.Name} recipe."),
		}));
	}

	private string RenderMetadata(string interfaceName)
	{
		var enumerationRecipes = Recipes.Enumerations.Where(recipe => recipe.Interface == interfaceName).ToArray();
		var stringRecipes = Recipes.MetadataStrings.Where(recipe => recipe.Interface == interfaceName).ToArray();
		foreach (var recipe in enumerationRecipes)
			ValidateEnumeration(recipe);
		foreach (var recipe in stringRecipes)
			ValidateHResult(catalog.GetMethod(recipe.Interface, recipe.Method), recipe.Interface);

		var publicMembers = enumerationRecipes.Select(RenderEnumerationMember)
			.Concat(stringRecipes.Select(RenderStringMember));
		var helpers = enumerationRecipes.Select(RenderEnumerationHelper).ToList();
		helpers.AddRange(stringRecipes.Select(RenderStringHelper));
		if (stringRecipes.Length != 0)
			helpers.Add(RenderStringHelper());
		return Header("ICorDebugSharp.GeneratedMetadata") +
			$"public static class {interfaceName[1..]}Extensions\n{{\n" +
			$"\textension({interfaceName} instance)\n\t{{\n{string.Join("\n\n", publicMembers)}\n\t}}\n\n" +
			$"{string.Join("\n\n", helpers)}\n}}\n";
	}

	private string RenderEnumerationMember(EnumerationRecipe recipe)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		var returnType = EnumerationReturnType(recipe);
		var call = $"Enumerate{recipe.Method[4..]}Core(instance{string.Concat(recipe.Inputs.Select(input => $", {Escape(input.Name)}"))})";
		return recipe.Inputs.Count == 0
			? $"\t\tpublic IEnumerable<{returnType}> {recipe.PublicName} => {call};"
			: $"\t\tpublic IEnumerable<{returnType}> {recipe.PublicName}({string.Join(", ", recipe.Inputs.Select(input => $"{method.GetParameter(input.Name).Type} {Escape(input.Name)}"))}) => {call};";
	}

	private string RenderEnumerationHelper(EnumerationRecipe recipe)
	{
		var method = catalog.GetMethod(recipe.Interface, recipe.Method);
		var suffix = recipe.Method[4..];
		var inputs = string.Concat(recipe.Inputs.Select(input => $", {method.GetParameter(input.Name).Type} {Escape(input.Name)}"));
		var outputArguments = string.Join(", ", recipe.Outputs.Select(output => $"out var {Escape(Camel(output.PublicName))}"));
		var callArguments = new List<string> { "ref handle" };
		callArguments.AddRange(recipe.Inputs.Select(input => Escape(input.Name)));
		callArguments.Add(outputArguments);
		callArguments.Add("1");
		callArguments.Add("out var count");
		var result = recipe.Outputs.Count == 1
			? Escape(Camel(recipe.Outputs[0].PublicName))
			: $"({string.Join(", ", recipe.Outputs.Select(output => Escape(Camel(output.PublicName))))})";
		return $"\tprivate static IEnumerable<{EnumerationReturnType(recipe)}> Enumerate{suffix}Core({recipe.Interface} instance{inputs})\n" +
			"\t{\n\t\tvar handle = default(HCorEnum);\n\t\ttry\n\t\t{\n\t\t\twhile (true)\n\t\t\t{\n" +
			$"\t\t\t\tvar hr = instance.{recipe.Method}({string.Join(", ", callArguments)});\n" +
			"\t\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\t\tif (count == 0)\n\t\t\t\t\tyield break;\n" +
			"\t\t\t\tif (count != 1)\n\t\t\t\t\tthrow new InvalidOperationException(\"Native metadata enumerator returned an invalid item count.\");\n" +
			$"\t\t\t\tyield return {result};\n\t\t\t}}\n\t\t}}\n\t\tfinally\n\t\t{{\n\t\t\tif (!handle.IsNull)\n\t\t\t\tinstance.CloseEnum(handle);\n\t\t}}\n\t}}";
	}

	private static string RenderStringMember(StringQueryRecipe recipe)
	{
		var call = $"Query{recipe.Method}(instance{(recipe.Parameters.Length == 0 ? "" : ", " + string.Join(", ", recipe.Parameters.Split(", ").Select(parameter => parameter.Split(' ')[^1])))})";
		return recipe.Parameters.Length == 0
			? $"\t\tpublic {recipe.ReturnType} {recipe.PublicName} => {call};"
			: $"\t\tpublic {recipe.ReturnType} {recipe.PublicName}({recipe.Parameters}) => {call};";
	}

	private static string RenderStringHelper(StringQueryRecipe recipe) =>
		$"\tprivate static {recipe.ReturnType} Query{recipe.Method}({recipe.Interface} instance{(recipe.Parameters.Length == 0 ? "" : ", " + recipe.Parameters)})\n" +
		"\t{\n" +
		$"\t\tvar hr = instance.{recipe.Method}({recipe.QueryArguments});\n\t\tMarshal.ThrowExceptionForHR(hr);\n\t\tif (required == 0)\n\t\t\treturn {EmptyStringResult(recipe)};\n\n" +
		"\t\tfor (var attempt = 0; attempt < 3; attempt++)\n\t\t{\n\t\t\tvar capacity = required;\n\t\t\tvar buffer = new char[checked((int)capacity)];\n" +
		$"\t\t\thr = instance.{recipe.Method}({recipe.FillArguments});\n\t\t\tMarshal.ThrowExceptionForHR(hr);\n\t\t\tif (actual > capacity)\n\t\t\t{{\n\t\t\t\trequired = actual;\n\t\t\t\tcontinue;\n\t\t\t}}\n\n" +
		$"\t\t\treturn {recipe.ReturnExpression};\n\t\t}}\n\n\t\tthrow new InvalidOperationException(\"Native buffer size did not stabilize.\");\n\t}}";

	private static string EmptyStringResult(StringQueryRecipe recipe) => recipe.ReturnType switch
	{
		"string" => "string.Empty",
		"(string szName, Guid pmvid)" => "(string.Empty, default)",
		"(string szTypeDef, TypeAttributes pdwTypeDefFlags, mdToken ptkExtends)" => "(string.Empty, default, default)",
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
		return "// <auto-generated />\n#nullable enable\nusing System;\nusing System.Collections.Generic;\nusing System.Reflection;\nusing System.Runtime.InteropServices;\n" +
			string.Concat(namespaceUsings.Select(@namespace => $"using {@namespace};\n")) +
			"\nnamespace ICorDebugSharp.Extensions;\n\n";
	}

	private static string Indent(string value, string indentation) =>
		string.Join("\n", value.Split('\n').Select(line => line.Length == 0 ? "" : indentation + line));

	private static string RenderInputParameter(ManagedParameter parameter) => $"{parameter.Type} {Escape(parameter.Name)}";
	private static string Escape(string name) => name is "base" or "event" or "params" or "ref" or "string" ? $"@{name}" : name;
	private static string Camel(string value) => char.ToLowerInvariant(value[0]) + value[1..];
}
