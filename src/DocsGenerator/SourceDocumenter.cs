using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DocsGenerator;

internal sealed record DocumentationResult(
	int FilesSeen,
	int FilesWritten,
	int TypesSeen,
	int TypesDocumented,
	int MethodsSeen,
	int MethodsDocumented,
	int MembersSeen,
	int MembersDocumented,
	IReadOnlyCollection<string> UnmatchedDeclarations,
	IReadOnlyCollection<string> UnmatchedParameters);

internal static partial class SourceDocumenter
{
	public static DocumentationResult Rewrite(DocumentationCatalog catalog, params string[] sourceDirectories)
	{
		foreach (var directory in sourceDirectories)
		{
			if (!Directory.Exists(directory))
				throw new DirectoryNotFoundException($"Generated source directory not found: {directory}");
		}

		var files = sourceDirectories
			.SelectMany(directory => Directory.EnumerateFiles(directory, "*.cs", SearchOption.TopDirectoryOnly))
			.Order(StringComparer.Ordinal)
			.ToArray();
		var filesWritten = 0;
		var totals = new RewriteStatistics();

		foreach (var path in files)
		{
			var source = File.ReadAllText(path).Replace("\r\n", "\n", StringComparison.Ordinal);
			var tree = CSharpSyntaxTree.ParseText(source, path: path);
			var errors = tree.GetDiagnostics().Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error).ToArray();
			if (errors.Length > 0)
				throw new InvalidOperationException($"Cannot parse '{path}': {string.Join(Environment.NewLine, errors)}");

			var rewriter = new DocumentationRewriter(catalog, totals);
			var root = rewriter.Visit(tree.GetRoot()) ?? throw new InvalidOperationException($"Cannot rewrite '{path}'.");
			var rewritten = root.ToFullString().Replace("\r\n", "\n", StringComparison.Ordinal);
			if (!rewritten.EndsWith('\n'))
				rewritten += "\n";
			if (source == rewritten)
				continue;
			File.WriteAllText(path, rewritten);
			filesWritten++;
		}

		return new DocumentationResult(
			files.Length,
			filesWritten,
			totals.TypesSeen,
			totals.TypesDocumented,
			totals.MethodsSeen,
			totals.MethodsDocumented,
			totals.MembersSeen,
			totals.MembersDocumented,
			totals.UnmatchedDeclarations,
			totals.UnmatchedParameters);
	}

	private sealed class DocumentationRewriter(DocumentationCatalog catalog, RewriteStatistics statistics)
		: CSharpSyntaxRewriter
	{
		private readonly MarkdownXmlRenderer _renderer = new();
		private static readonly IReadOnlyDictionary<string, string> ParameterAliases =
			new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
			{
				["ICorDebugArrayValue.TryGetBaseIndicies.indices"] = "indicies",
				["ICorDebugProcess5.TryEnumerateHeap.ppObjects"] = "ppObject",
				["ICorDebugProcess5.TryGetObject.pObject"] = "ppObject",
				["ICorDebugRemote.TryDebugActiveProcessEx.dwProcessId"] = "id",
				["ICorDebugRemote.TryDebugActiveProcessEx.fWin32Attach"] = "win32Attach",
				["ICorDebugSymbolProvider.TryGetTypeProps.vtableRva"] = "tableRva",
				["IMetaDataImport.TryGetMemberRefProps.ppvSigBlob"] = "ppvSibBlob",
			};

		public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
		{
			var rewritten = (InterfaceDeclarationSyntax)base.VisitInterfaceDeclaration(node)!;
			return IsTopLevel(node) ? DocumentType(rewritten, node.Identifier.ValueText) : rewritten;
		}

		public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
		{
			var rewritten = (StructDeclarationSyntax)base.VisitStructDeclaration(node)!;
			return IsTopLevel(node) ? DocumentType(rewritten, node.Identifier.ValueText) : rewritten;
		}

		public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
		{
			var rewritten = (EnumDeclarationSyntax)base.VisitEnumDeclaration(node)!;
			return IsTopLevel(node) ? DocumentType(rewritten, node.Identifier.ValueText) : rewritten;
		}

		public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
		{
			var rewritten = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;
			if (node.Parent is not InterfaceDeclarationSyntax containingType)
				return rewritten;

			statistics.MethodsSeen++;
			var typeName = containingType.Identifier.ValueText;
			var methodName = node.Identifier.ValueText;
			if (!catalog.TryGetMethod(typeName, methodName, out var page))
			{
				statistics.UnmatchedDeclarations.Add($"{typeName}.{methodName}");
				return rewritten;
			}

			statistics.MethodsDocumented++;
			var comment = BuildMethodComment(page, rewritten, typeName, methodName);
			return AddDocumentation(rewritten, comment);
		}

		public override SyntaxNode? VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
		{
			var rewritten = (EnumMemberDeclarationSyntax)base.VisitEnumMemberDeclaration(node)!;
			if (node.Parent is not EnumDeclarationSyntax containingType || !IsTopLevel(containingType))
				return rewritten;
			return DocumentMember(rewritten, containingType.Identifier.ValueText, node.Identifier.ValueText);
		}

		public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
		{
			var rewritten = (FieldDeclarationSyntax)base.VisitFieldDeclaration(node)!;
			if (node.Parent is not StructDeclarationSyntax containingType || !IsTopLevel(containingType) ||
				node.Declaration.Variables.Count != 1 || !node.Modifiers.Any(SyntaxKind.PublicKeyword))
				return rewritten;
			return DocumentMember(
				rewritten,
				containingType.Identifier.ValueText,
				node.Declaration.Variables[0].Identifier.ValueText);
		}

		private T DocumentType<T>(T declaration, string typeName) where T : MemberDeclarationSyntax
		{
			statistics.TypesSeen++;
			if (!catalog.TryGetType(typeName, out var page))
			{
				statistics.UnmatchedDeclarations.Add(typeName);
				return declaration;
			}

			statistics.TypesDocumented++;
			var comment = BuildComment(page.Summary, page.Remarks, page.SourceUrl);
			return AddDocumentation(declaration, comment);
		}

		private T DocumentMember<T>(T declaration, string typeName, string memberName)
			where T : MemberDeclarationSyntax
		{
			if (!catalog.TryGetType(typeName, out var page))
				return declaration;
			statistics.MembersSeen++;
			if (!TryGetMemberDocumentation(page, typeName, memberName, out var markdown))
				return declaration;

			statistics.MembersDocumented++;
			var comment = WrapElement("summary", _renderer.Render(markdown, page.SourceUrl));
			return AddDocumentation(declaration, comment);
		}

		private string BuildMethodComment(
			DocumentationPage page,
			MethodDeclarationSyntax method,
			string typeName,
			string methodName)
		{
			var elements = new List<string>
			{
				WrapElement("summary", _renderer.Render(page.Summary, page.SourceUrl)),
			};
			var matchedParameters = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			foreach (var parameter in method.ParameterList.Parameters)
			{
				var name = parameter.Identifier.ValueText;
				var documentationName = ParameterAliases.GetValueOrDefault($"{typeName}.{methodName}.{name}", name);
				if (!page.Parameters.TryGetValue(documentationName, out var markdown))
				{
					if (page.Parameters.Count > 0)
						statistics.UnmatchedParameters.Add($"{typeName}.{methodName}({name})");
					continue;
				}
				matchedParameters.Add(documentationName);
				elements.Add(WrapElement(
					$"param name=\"{name}\"",
					_renderer.Render(markdown, page.SourceUrl)));
			}
			foreach (var documentedName in page.Parameters.Keys)
			{
				if (method.ParameterList.Parameters.Count > 0 && !matchedParameters.Contains(documentedName))
					statistics.UnmatchedParameters.Add($"{typeName}.{methodName}: documented '{documentedName}'");
			}
			if (!string.IsNullOrWhiteSpace(page.Returns))
				elements.Add(WrapElement("returns", _renderer.Render(page.Returns, page.SourceUrl)));
			elements.Add(BuildRemarks(page.Remarks, page.SourceUrl));
			return string.Join('\n', elements);
		}

		private string BuildComment(string summary, string? remarks, string sourceUrl) =>
			string.Join('\n', WrapElement("summary", _renderer.Render(summary, sourceUrl)), BuildRemarks(remarks, sourceUrl));

		private string BuildRemarks(string? remarks, string sourceUrl)
		{
			var content = string.IsNullOrWhiteSpace(remarks) ? "" : _renderer.Render(remarks, sourceUrl) + "\n";
			content += $"<para>Documentation adapted from <see href=\"{sourceUrl}\">Microsoft Learn</see>.</para>";
			return WrapElement("remarks", content);
		}

		private static bool TryGetMemberDocumentation(
			DocumentationPage page,
			string typeName,
			string memberName,
			out string markdown)
		{
			if (page.Members.TryGetValue(memberName, out markdown!))
				return true;

			var nativeName = typeName switch
			{
				"CorElementType" => $"ELEMENT_TYPE_{memberName}",
				"LIBRARY_PROVIDER_INDEX_TYPE" when memberName == "UnknownIndex" => "Unknown",
				"COR_SEGMENT" when memberName == "type" => "gen",
				"ASSEMBLYMETADATA" when memberName == "rProcessor" => "rdwProcessor",
				_ => memberName,
			};
			return page.Members.TryGetValue(nativeName, out markdown!);
		}

		private static T AddDocumentation<T>(T declaration, string xml) where T : MemberDeclarationSyntax
		{
			var leadingText = declaration.GetLeadingTrivia().ToFullString();
			leadingText = ExistingDocumentationRegex().Replace(leadingText, "");
			var lastNewLine = leadingText.LastIndexOf('\n');
			var indentation = lastNewLine < 0 ? leadingText : leadingText[(lastNewLine + 1)..];
			var prefix = lastNewLine < 0 ? "" : leadingText[..(lastNewLine + 1)];
			var comment = string.Join(
				'\n',
				xml.Split('\n').Select(line => $"{indentation}/// {line}"));
			var trivia = SyntaxFactory.ParseLeadingTrivia($"{prefix}{comment}\n{indentation}");
			return declaration.WithLeadingTrivia(trivia);
		}

		private static string WrapElement(string element, string content)
		{
			var elementName = element.Split(' ')[0];
			return $"<{element}>\n{content}\n</{elementName}>";
		}

		private static bool IsTopLevel(MemberDeclarationSyntax declaration) =>
			declaration.Parent is BaseNamespaceDeclarationSyntax or CompilationUnitSyntax;
	}

	private sealed class RewriteStatistics
	{
		public int TypesSeen { get; set; }
		public int TypesDocumented { get; set; }
		public int MethodsSeen { get; set; }
		public int MethodsDocumented { get; set; }
		public int MembersSeen { get; set; }
		public int MembersDocumented { get; set; }
		public HashSet<string> UnmatchedDeclarations { get; } = new(StringComparer.Ordinal);
		public HashSet<string> UnmatchedParameters { get; } = new(StringComparer.Ordinal);
	}

	[GeneratedRegex(@"(?m)^[ \t]*///.*(?:\n|$)")]
	private static partial Regex ExistingDocumentationRegex();
}
