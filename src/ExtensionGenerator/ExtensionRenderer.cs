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
		return files;
	}

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
			? $"var length = checked((int)actual);\n{prefix}if (length > 0 && buffer[length - 1] == '\\0')\n{prefix}\tlength--;\n\n{prefix}return new string(buffer, 0, length);"
			: $"if (actual != capacity)\n{prefix}\tArray.Resize(ref buffer, checked((int)actual));\n\n{prefix}return buffer;";
		return $"{prefix}var hr = instance.{method.Name}({first});\n" +
			$"{prefix}Marshal.ThrowExceptionForHR(hr);\n{prefix}if (required == 0)\n{prefix}\treturn {empty};\n\n" +
			$"{prefix}for (var attempt = 0; attempt < 3; attempt++)\n{prefix}{{\n" +
			$"{prefix}\tvar capacity = required;\n{prefix}\tvar buffer = new {elementType}[checked((int)capacity)];\n" +
			$"{prefix}\thr = instance.{method.Name}({second});\n{prefix}\tMarshal.ThrowExceptionForHR(hr);\n" +
			$"{prefix}\tif (actual > capacity)\n{prefix}\t{{\n{prefix}\t\trequired = actual;\n{prefix}\t\tcontinue;\n{prefix}\t}}\n\n" +
			$"{prefix}\t{result.Replace("\n", $"\n{prefix}\t", StringComparison.Ordinal)}\n{prefix}}}\n\n" +
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
			$"using ICorDebugSharp;\n\npublic static class {interfaceName[1..]}Extensions\n{{\n" +
			$"\textension({interfaceName} instance)\n\t{{\n{string.Join("\n\n", publicMembers)}\n\t}}\n\n" +
			$"{string.Join("\n\n", helpers)}\n}}\n";
	}

	private static string RenderEnumerationMember(EnumerationRecipe recipe)
	{
		var returnType = EnumerationReturnType(recipe);
		var call = $"Enumerate{recipe.Method[4..]}Core(instance{string.Concat(recipe.Inputs.Select(input => $", {Escape(input.Name)}"))})";
		return recipe.Inputs.Count == 0
			? $"\t\tpublic IEnumerable<{returnType}> {recipe.PublicName} => {call};"
			: $"\t\tpublic IEnumerable<{returnType}> {recipe.PublicName}({string.Join(", ", recipe.Inputs.Select(input => $"{input.Type} {Escape(input.Name)}"))}) => {call};";
	}

	private static string RenderEnumerationHelper(EnumerationRecipe recipe)
	{
		var suffix = recipe.Method[4..];
		var inputs = string.Concat(recipe.Inputs.Select(input => $", {input.Type} {Escape(input.Name)}"));
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
		"(string Name, Guid ModuleVersionId)" => "(string.Empty, default)",
		"(string Name, TypeAttributes Attributes, Token Extends)" => "(string.Empty, default, default)",
		"(Token ResolutionScope, string Name)" => "(default, string.Empty)",
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

	private static string EnumerationReturnType(EnumerationRecipe recipe) => recipe.Outputs.Count == 1
		? recipe.Outputs[0].Type
		: $"({string.Join(", ", recipe.Outputs.Select(output => $"{output.Type} {output.PublicName}"))})";

	private static string Header(string rawNamespace) =>
		"// <auto-generated />\n#nullable enable\nusing System;\nusing System.Collections.Generic;\nusing System.Reflection;\nusing System.Runtime.InteropServices;\n" +
		$"using {rawNamespace};\n\nnamespace ICorDebugSharp.Extensions;\n\n";

	private static string RenderInputParameter(ManagedParameter parameter) => $"{parameter.Type} {Escape(parameter.Name)}";
	private static string Escape(string name) => name is "base" or "event" or "params" or "ref" or "string" ? $"@{name}" : name;
	private static string Camel(string value) => char.ToLowerInvariant(value[0]) + value[1..];
}
