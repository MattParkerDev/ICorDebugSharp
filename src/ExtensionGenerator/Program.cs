using ExtensionGenerator;

var projectDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../.."));
var repositoryRoot = args.Length == 0
	? Path.GetFullPath(Path.Combine(projectDirectory, "../.."))
	: Path.GetFullPath(args[0]);
var libraryDirectory = Path.Combine(repositoryRoot, "src", "ICorDebugSharp");
var outputDirectory = Path.Combine(libraryDirectory, "GeneratedExtensions");
var catalog = ManagedInterfaceCatalog.Load(
	Path.Combine(libraryDirectory, "Generated"),
	Path.Combine(libraryDirectory, "GeneratedMetadata"));
var files = new ExtensionRenderer(catalog).Render();

Directory.CreateDirectory(outputDirectory);
foreach (var stalePath in Directory.EnumerateFiles(outputDirectory, "*.cs", SearchOption.TopDirectoryOnly)
	.Where(path => !files.ContainsKey(Path.GetFileName(path))))
	File.Delete(stalePath);

var written = 0;
foreach (var (name, source) in files.OrderBy(item => item.Key, StringComparer.Ordinal))
{
	var path = Path.Combine(outputDirectory, name);
	if (File.Exists(path) && File.ReadAllText(path) == source)
		continue;
	File.WriteAllText(path, source.Replace("\r\n", "\n", StringComparison.Ordinal));
	written++;
}

Console.WriteLine($"Generated {files.Count} extension files ({written} written)." );
