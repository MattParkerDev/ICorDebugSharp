using DocsGenerator;

if (args.Length != 1)
{
    Console.Error.WriteLine("Usage: dotnet run -- <dotnet-docs-root> (or use generate-all.cs from the repository root)");
    return 1;
}
var dotnetDocsFolder = args[0];
if (!Directory.Exists(dotnetDocsFolder)) throw new DirectoryNotFoundException(dotnetDocsFolder);

var projectDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../.."));
var docsRoot = Path.GetFullPath(dotnetDocsFolder);
var libraryDirectory = Path.GetFullPath(Path.Combine(projectDirectory, "../ICorDebugSharp"));
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
