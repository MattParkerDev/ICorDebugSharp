using System.Diagnostics;
using ClangSharp;
using ClangSharp.Interop;
using MetadataGenerator;

var rootFilePath = "C:/src/dotnet/src/runtime/src/coreclr/inc/cor.h";
var projectDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../.."));
var generatedFileHeaderPath = Path.Combine(projectDirectory, "../ClangSharpCliMetadataGenerator", "Header.txt");
var outputDirectory = Path.GetFullPath(Path.Combine(projectDirectory, "../ICorDebugSharp/GeneratedMetadata"));
var interfaceMethodCounts = new Dictionary<string, int>(StringComparer.Ordinal)
{
	["IMetaDataImport"] = 62,
	["IMetaDataImport2"] = 8,
	["IMetaDataAssemblyImport"] = 14,
	//["IMetaDataAssemblyEmit"] = 10,
	//["IMetaDataEmit"] = 49,
	//["IMetaDataEmit2"] = 8,
	//["IMetaDataFilter"] = 3,
	//["IMetaDataDispenser"] = 3,
	//["IMetaDataDispenserEx"] = 6,
	//["IMetaDataInfo"] = 1,
	//["IMetaDataError"] = 1,
	//["IMetaDataValidate"] = 2,
	//["IMetaDataTables"] = 19,
	//["IMetaDataTables2"] = 2,
	//["IHostFilter"] = 1,
	//["IMapToken"] = 1,
};
string[] comInterfaceNames =
[
	"IMetaDataImport",
	"IMetaDataImport2",
	"IMetaDataAssemblyImport",
	"IMetaDataAssemblyEmit",
	"IMetaDataEmit",
	"IMetaDataEmit2",
	"IMetaDataFilter",
	"IMetaDataDispenser",
	"IMetaDataDispenserEx",
	"IMetaDataInfo",
	"IMetaDataError",
	"IMetaDataValidate",
	"IMetaDataTables",
	"IMetaDataTables2",
	"IHostFilter",
	"IMapToken",
];
var interfaceGuids = ExternGuidParser.ParseInterfaceGuids(rootFilePath);

var pInvokeGeneratorConfigurationOptions = PInvokeGeneratorConfigurationOptions.None;
// corerror.h defines HRESULT values as macros rather than declarations.
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateMacroBindings;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateMultipleFiles;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.ExcludeComProxies;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.ExcludeEnumOperators;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateAggressiveInlining;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateCallConvMemberFunction;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateCppAttributes;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateDisableRuntimeMarshalling;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateFileScopedNamespaces;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateGuidMember;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateMarkerInterfaces;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateNativeInheritanceAttribute;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateSetsLastSystemErrorAttribute;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateVtblIndexAttribute;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.LogPotentialTypedefRemappings;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.LogExclusions;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.StripEnumMemberTypeName;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateTrimmableVtbls;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateHelperTypes;

var config = new PInvokeGeneratorConfiguration
("c++",
    "",
    "ICorDebugSharp.GeneratedMetadata",
    $"{projectDirectory}/../ICorDebugSharp/GeneratedMetadata/",
    generatedFileHeaderPath,
    PInvokeGeneratorOutputMode.CSharp,
    pInvokeGeneratorConfigurationOptions)
{
    DefaultClass = "Cor",
    RemappedNames = new Dictionary<string, string>
    {
	    ["_GUID"] = "Guid",
    },
    TraversalNames =
    [
	    "C:/src/dotnet/src/runtime/src/coreclr/inc/corhdr.h",
	    "C:/src/dotnet/src/runtime/src/coreclr/inc/cor.h",
        "C:/src/dotnet/src/runtime/src/coreclr/pal/prebuilt/inc/corerror.h",
    ],
    ExcludedNames =
    [
        ..comInterfaceNames,
        "MAIN_CLR_DLL_NAME_W",
        "TARGET_MAIN_CLR_DLL_NAME_W",
    ],
};

var comInterfaceGenerator = new ComInterfaceGenerator(new ComInterfaceGeneratorConfiguration(
	"ICorDebugSharp.GeneratedMetadata",
	outputDirectory,
	interfaceMethodCounts,
	interfaceGuids));

var translationFlags = CXTranslationUnit_Flags.CXTranslationUnit_IncludeAttributedTypes |
                       CXTranslationUnit_Flags.CXTranslationUnit_VisitImplicitAttributes;
if (config.GenerateMacroBindings)
{
    translationFlags |=  CXTranslationUnit_Flags.CXTranslationUnit_DetailedPreprocessingRecord;
}

var pinvokeGenerator = new PInvokeGenerator(config);

List<string> files = [rootFilePath];

Span<string> clangCommandLineArgs =
[
    "--language=c++",
	"--target=x86_64-pc-windows-msvc",
    "-Wno-pragma-once-outside-header",

    "-I", "C:/src/dotnet/src/runtime/src/coreclr/inc/",
    "-I", "C:/src/dotnet/src/runtime/src/coreclr/pal/prebuilt/inc",
    "-I", "C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um",
    "-I", "C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/shared",
    "-I", "C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/ucrt",
    "-I", "C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/winrt",
    "-I", "C:/Program Files/Microsoft Visual Studio/18/Enterprise/VC/Tools/MSVC/14.50.35717/include",
];

foreach (string filePath in files)
{
    var translationUnitError = CXTranslationUnit.TryParse(pinvokeGenerator.IndexHandle, filePath, clangCommandLineArgs, [], translationFlags, out var handle);
    var skipProcessing = false;
    if (translationUnitError != CXErrorCode.CXError_Success)
    {
        Console.WriteLine($"Error: Parsing failed for '{filePath}' due to '{translationUnitError}'.");
        skipProcessing = true;
    }
    else if (handle.NumDiagnostics != 0)
    {
        Console.WriteLine($"Diagnostics for '{filePath}':");

        for (uint i = 0; i < handle.NumDiagnostics; ++i)
        {
            using var diagnostic = handle.GetDiagnostic(i);

            Console.Write("    ");
            Console.WriteLine(diagnostic.Format(CXDiagnostic.DefaultDisplayOptions).ToString());

            skipProcessing |= diagnostic.Severity == CXDiagnosticSeverity.CXDiagnostic_Error;
            skipProcessing |= diagnostic.Severity == CXDiagnosticSeverity.CXDiagnostic_Fatal;
        }
    }

    if (skipProcessing)
    {
		throw new InvalidOperationException($"Parsing failed for '{filePath}' due to one or more errors listed above.");
    }

    try
    {
        using var translationUnit = TranslationUnit.GetOrCreate(handle);
        Debug.Assert(translationUnit is not null);

        Console.WriteLine($"Processing '{filePath}'");
        pinvokeGenerator.GenerateBindings(translationUnit, filePath, clangCommandLineArgs.ToArray(), translationFlags);
		foreach (var interfaceName in comInterfaceNames.Except(interfaceMethodCounts.Keys, StringComparer.Ordinal))
		{
			var stalePath = Path.Combine(outputDirectory, $"{interfaceName}.cs");
			if (File.Exists(stalePath))
				File.Delete(stalePath);
		}
		comInterfaceGenerator.GenerateBindings(translationUnit);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
		throw;
    }

    if (pinvokeGenerator.Diagnostics.Count != 0)
    {
        Console.WriteLine($"Diagnostics for binding generation of {pinvokeGenerator.FilePath}:");

        foreach (var diagnostic in pinvokeGenerator.Diagnostics)
        {
            Console.Write("    ");
            Console.WriteLine(diagnostic.ToString());
        }
    }
}

pinvokeGenerator.Dispose();
