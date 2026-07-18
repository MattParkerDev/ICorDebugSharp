using DocsGenerator;

if (args.Length > 2)
{
	Console.Error.WriteLine("Usage: DocsGenerator <dotnet-docs-root> [repository-root]");
	return 1;
}

var docsRootArgument = args.FirstOrDefault() ?? Environment.GetEnvironmentVariable("DOTNET_DOCS_ROOT");
if (string.IsNullOrWhiteSpace(docsRootArgument))
{
	Console.Error.WriteLine(
		"Specify the dotnet/docs repository root or set the DOTNET_DOCS_ROOT environment variable.");
	return 1;
}

var projectDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../.."));
var repositoryRoot = args.Length > 1
	? Path.GetFullPath(args[1])
	: Path.GetFullPath(Path.Combine(projectDirectory, "../.."));
var docsRoot = Path.GetFullPath(docsRootArgument);
var libraryDirectory = Path.Combine(repositoryRoot, "src", "ICorDebugSharp");

try
{
	var catalog = DocumentationCatalog.Load(docsRoot);
	var result = SourceDocumenter.Rewrite(
		catalog,
		Path.Combine(libraryDirectory, "Generated"),
		Path.Combine(libraryDirectory, "GeneratedMetadata"));

	Console.WriteLine($"Indexed {catalog.TypeCount} type pages and {catalog.MethodCount} method pages.");
	Console.WriteLine(
		$"Documented {result.TypesDocumented}/{result.TypesSeen} types, " +
		$"{result.MethodsDocumented}/{result.MethodsSeen} interface methods, and " +
		$"{result.MembersDocumented}/{result.MembersSeen} fields or enum members.");
	Console.WriteLine($"Rewrote {result.FilesWritten}/{result.FilesSeen} generated source files.");

	if (result.UnmatchedDeclarations.Count > 0)
	{
		Console.WriteLine("Declarations without Microsoft documentation:");
		foreach (var declaration in result.UnmatchedDeclarations.Order(StringComparer.Ordinal))
			Console.WriteLine($"  {declaration}");
	}

	if (result.UnmatchedParameters.Count > 0)
	{
		Console.WriteLine("Documented methods with unmatched parameters:");
		foreach (var parameter in result.UnmatchedParameters.Order(StringComparer.Ordinal))
			Console.WriteLine($"  {parameter}");
	}

	return 0;
}
catch (Exception exception)
{
	Console.Error.WriteLine(exception.Message);
	return 1;
}
