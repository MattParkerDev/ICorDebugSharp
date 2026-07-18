using System.Text.RegularExpressions;

namespace DocsGenerator;

internal enum DocumentationKind
{
	Interface,
	Enumeration,
	Structure,
	Method,
}

internal sealed record DocumentationPage(
	DocumentationKind Kind,
	string TypeName,
	string? MethodName,
	string Summary,
	string? Returns,
	string? Remarks,
	IReadOnlyDictionary<string, string> Parameters,
	IReadOnlyDictionary<string, string> Members,
	string SourceUrl,
	string SourcePath);

internal sealed partial class DocumentationCatalog
{
	private readonly Dictionary<string, DocumentationPage> _types = new(StringComparer.OrdinalIgnoreCase);
	private readonly Dictionary<string, DocumentationPage> _methods = new(StringComparer.OrdinalIgnoreCase);

	private static readonly IReadOnlyDictionary<string, string> MethodAliases =
		new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
		{
			["ICorDebugThread4.HasUnhandledException"] = "HadUnhandledException",
			["ICorDebugInternalFrame2.GetAddress"] = "GetFrameAddress",
		};

	public int TypeCount => _types.Count;

	public int MethodCount => _methods.Count;

	public static DocumentationCatalog Load(string docsRoot)
	{
		var contentRoot = Path.Combine(docsRoot, "docs", "core", "unmanaged-api");
		var roots = new[]
		{
			Path.Combine(contentRoot, "debugging"),
			Path.Combine(contentRoot, "metadata"),
		};

		foreach (var root in roots)
		{
			if (!Directory.Exists(root))
				throw new DirectoryNotFoundException($"Documentation directory not found: {root}");
		}

		var catalog = new DocumentationCatalog();
		foreach (var path in roots.SelectMany(root => Directory.EnumerateFiles(root, "*.md", SearchOption.AllDirectories)))
		{
			var page = ParsePage(path, contentRoot);
			if (page is not null)
				catalog.Add(page);
		}

		return catalog;
	}

	public bool TryGetType(string typeName, out DocumentationPage page) =>
		_types.TryGetValue(typeName, out page!);

	public bool TryGetMethod(string typeName, string generatedMethodName, out DocumentationPage page)
	{
		var nativeName = generatedMethodName.StartsWith("Try", StringComparison.Ordinal)
			? generatedMethodName[3..]
			: generatedMethodName;
		if (MethodAliases.TryGetValue(MethodKey(typeName, nativeName), out var alias))
			nativeName = alias;
		return _methods.TryGetValue(MethodKey(typeName, nativeName), out page!);
	}

	private void Add(DocumentationPage page)
	{
		var entries = page.Kind == DocumentationKind.Method ? _methods : _types;
		var key = page.Kind == DocumentationKind.Method
			? MethodKey(page.TypeName, page.MethodName!)
			: page.TypeName;
		if (!entries.TryAdd(key, page))
		{
			throw new InvalidOperationException(
				$"Duplicate documentation key '{key}': '{entries[key].SourcePath}' and '{page.SourcePath}'.");
		}
	}

	private static DocumentationPage? ParsePage(string path, string contentRoot)
	{
		var markdown = File.ReadAllText(path).Replace("\r\n", "\n", StringComparison.Ordinal);
		var content = RemoveFrontMatter(markdown);
		var lines = content.Split('\n');
		var headingIndex = Array.FindIndex(lines, line => line.StartsWith("# ", StringComparison.Ordinal));
		if (headingIndex < 0)
			return null;

		var heading = lines[headingIndex];
		var methodMatch = MethodHeadingRegex().Match(heading);
		var typeMatch = TypeHeadingRegex().Match(heading);
		if (!methodMatch.Success && !typeMatch.Success)
			return null;

		var sections = SplitSections(lines, headingIndex);
		var summary = JoinMarkdown(lines[(headingIndex + 1)..FirstSectionIndex(lines, headingIndex)]);
		var sourceUrl = CreateSourceUrl(path, contentRoot);

		if (methodMatch.Success)
		{
			return new DocumentationPage(
				DocumentationKind.Method,
				methodMatch.Groups["type"].Value,
				methodMatch.Groups["method"].Value,
				summary,
				GetSection(sections, "Return Value", "Return Values"),
				GetSection(sections, "Remarks"),
				ParseParameters(GetSection(sections, "Parameters")),
				EmptyEntries,
				sourceUrl,
				path);
		}

		return new DocumentationPage(
			ParseKind(typeMatch.Groups["kind"].Value),
			typeMatch.Groups["type"].Value,
			null,
			summary,
			null,
			GetSection(sections, "Remarks"),
			EmptyEntries,
			ParseMembers(GetSection(sections, "Members")),
			sourceUrl,
			path);
	}

	private static Dictionary<string, string> SplitSections(string[] lines, int headingIndex)
	{
		var sections = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		for (var index = headingIndex + 1; index < lines.Length; index++)
		{
			if (!lines[index].StartsWith("## ", StringComparison.Ordinal))
				continue;

			var name = lines[index][3..].Trim();
			var end = index + 1;
			while (end < lines.Length && !lines[end].StartsWith("## ", StringComparison.Ordinal))
				end++;
			sections[name] = JoinMarkdown(lines[(index + 1)..end]);
			index = end - 1;
		}
		return sections;
	}

	private static IReadOnlyDictionary<string, string> ParseParameters(string? markdown)
	{
		if (string.IsNullOrWhiteSpace(markdown))
			return EmptyEntries;

		var lines = markdown.Split('\n');
		var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		for (var index = 0; index < lines.Length; index++)
		{
			var match = ParameterNameRegex().Match(lines[index]);
			if (!match.Success)
				continue;

			var name = match.Groups["name"].Value;
			var end = index + 1;
			while (end < lines.Length && !ParameterNameRegex().IsMatch(lines[end]))
				end++;
			var description = JoinMarkdown(lines[(index + 1)..end]);
			description = ParameterDirectionRegex().Replace(description, "");
			if (!string.IsNullOrWhiteSpace(description))
				result[name] = description.Trim();
			index = end - 1;
		}
		return result;
	}

	private static IReadOnlyDictionary<string, string> ParseMembers(string? markdown)
	{
		if (string.IsNullOrWhiteSpace(markdown))
			return EmptyEntries;

		var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		foreach (var line in markdown.Split('\n'))
		{
			if (!line.TrimStart().StartsWith('|') || TableSeparatorRegex().IsMatch(line))
				continue;
			var cells = SplitTableRow(line);
			if (cells.Count < 2)
				continue;
			var name = ExtractMemberName(cells[0]);
			if (name is null || name.Equals("Member", StringComparison.OrdinalIgnoreCase) ||
				name.Equals("Value", StringComparison.OrdinalIgnoreCase))
				continue;
			result.TryAdd(name, cells[1].Trim());
		}
		return result;
	}

	private static List<string> SplitTableRow(string line)
	{
		var cells = new List<string>();
		var current = new System.Text.StringBuilder();
		var escaped = false;
		foreach (var character in line.Trim().Trim('|'))
		{
			if (character == '|' && !escaped)
			{
				cells.Add(current.ToString().Trim());
				current.Clear();
			}
			else
			{
				current.Append(character);
			}
			escaped = character == '\\' && !escaped;
			if (character != '\\')
				escaped = false;
		}
		cells.Add(current.ToString().Trim());
		return cells;
	}

	private static string? ExtractMemberName(string cell)
	{
		var codeMatch = Regex.Match(cell, "`(?<name>[^`]+)`");
		if (codeMatch.Success)
			return codeMatch.Groups["name"].Value.Trim();
		var linkMatch = Regex.Match(cell, @"\[(?<name>[^]]+)\]\([^)]+\)");
		var value = linkMatch.Success ? linkMatch.Groups["name"].Value : cell;
		value = value.Trim().Trim('*', '_', '`');
		return IdentifierRegex().IsMatch(value) ? value : null;
	}

	private static string RemoveFrontMatter(string markdown)
	{
		if (!markdown.StartsWith("---\n", StringComparison.Ordinal))
			return markdown;
		var end = markdown.IndexOf("\n---\n", 4, StringComparison.Ordinal);
		return end < 0 ? markdown : markdown[(end + 5)..];
	}

	private static int FirstSectionIndex(string[] lines, int headingIndex)
	{
		var index = Array.FindIndex(lines, headingIndex + 1,
			line => line.StartsWith("## ", StringComparison.Ordinal));
		return index < 0 ? lines.Length : index;
	}

	private static string JoinMarkdown(IEnumerable<string> lines) =>
		string.Join('\n', lines).Trim();

	private static string? GetSection(Dictionary<string, string> sections, params string[] names)
	{
		foreach (var name in names)
		{
			if (sections.TryGetValue(name, out var section) && !string.IsNullOrWhiteSpace(section))
				return section;
		}
		return null;
	}

	private static DocumentationKind ParseKind(string kind) => kind.ToLowerInvariant() switch
	{
		"interface" => DocumentationKind.Interface,
		"enumeration" => DocumentationKind.Enumeration,
		"structure" => DocumentationKind.Structure,
		_ => throw new InvalidOperationException($"Unknown documentation kind '{kind}'."),
	};

	private static string CreateSourceUrl(string path, string contentRoot)
	{
		var relativePath = Path.GetRelativePath(contentRoot, path).Replace('\\', '/');
		if (relativePath.EndsWith(".md", StringComparison.OrdinalIgnoreCase))
			relativePath = relativePath[..^3];
		return $"https://learn.microsoft.com/dotnet/core/unmanaged-api/{relativePath}";
	}

	private static string MethodKey(string typeName, string methodName) => $"{typeName}.{methodName}";

	private static readonly IReadOnlyDictionary<string, string> EmptyEntries =
		new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	[GeneratedRegex(@"^#\s+(?<type>[A-Za-z_][A-Za-z0-9_]*)::(?<method>[A-Za-z_][A-Za-z0-9_]*)\s+Method\s*$", RegexOptions.IgnoreCase)]
	private static partial Regex MethodHeadingRegex();

	[GeneratedRegex(@"^#\s+(?<type>[A-Za-z_][A-Za-z0-9_]*)\s+(?<kind>Interface|Enumeration|Structure)\s*$", RegexOptions.IgnoreCase)]
	private static partial Regex TypeHeadingRegex();

	[GeneratedRegex(@"^\s*`(?<name>[A-Za-z_][A-Za-z0-9_]*)`\s*$")]
	private static partial Regex ParameterNameRegex();

	[GeneratedRegex(@"^\s*\[(?:in|out)(?:\s*,[^]]+)?\]\s*", RegexOptions.IgnoreCase)]
	private static partial Regex ParameterDirectionRegex();

	[GeneratedRegex(@"^\s*\|?[\s:|-]+\|?\s*$")]
	private static partial Regex TableSeparatorRegex();

	[GeneratedRegex(@"^[A-Za-z_][A-Za-z0-9_]*$")]
	private static partial Regex IdentifierRegex();
}
