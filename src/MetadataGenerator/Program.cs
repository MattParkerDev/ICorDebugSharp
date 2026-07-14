// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using ClangSharp;
using ClangSharp.Interop;

Console.WriteLine("Hello, World!");
var rootFilePath = "C:/Users/Matthew/Documents/Git/libgit2/include/git2.h";
var projectDirectory = Environment.GetEnvironmentVariable("ProjectDir");
ArgumentNullException.ThrowIfNull(projectDirectory);

var pInvokeGeneratorConfigurationOptions = PInvokeGeneratorConfigurationOptions.None;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateMultipleFiles;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.ExcludeComProxies;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.ExcludeEnumOperators;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateAggressiveInlining;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateCallConvMemberFunction;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateCppAttributes;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateDisableRuntimeMarshalling;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateFileScopedNamespaces;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateGuidMember;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateMacroBindings;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateMarkerInterfaces;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateNativeInheritanceAttribute;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateSetsLastSystemErrorAttribute;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateUnmanagedConstants;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateVtblIndexAttribute;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.LogPotentialTypedefRemappings;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.LogExclusions;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.StripEnumMemberTypeName;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateTrimmableVtbls;
pInvokeGeneratorConfigurationOptions |= PInvokeGeneratorConfigurationOptions.GenerateUnixTypes;

var config = new PInvokeGeneratorConfiguration
("c++", 
    "",
    "LibGit2.Interop",
    $"{projectDirectory}/../../src/LibGit2.Interop2/",
    "", 
    PInvokeGeneratorOutputMode.CSharp,
    pInvokeGeneratorConfigurationOptions)
{
    DefaultClass = "libgit2"
};

var translationFlags = CXTranslationUnit_Flags.CXTranslationUnit_None;
if (config.GenerateMacroBindings)
{
    translationFlags |=  CXTranslationUnit_Flags.CXTranslationUnit_DetailedPreprocessingRecord;
}

using var pinvokeGenerator = new PInvokeGenerator(config);

List<string> files = [rootFilePath];

Span<string> clangCommandLineArgs =
[
    "--language=c++",
    "-Wno-pragma-once-outside-header"
];

foreach (string filePath in files)
{
    var translationUnitError = CXTranslationUnit.TryParse(pinvokeGenerator.IndexHandle, rootFilePath, clangCommandLineArgs, [], translationFlags, out var handle);
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
        Console.WriteLine($"Skipping '{filePath}' due to one or more errors listed above.");
        Console.WriteLine("");
        
        continue;
    }
    
    try
    {
        using var translationUnit = TranslationUnit.GetOrCreate(handle);
        Debug.Assert(translationUnit is not null);

        Console.WriteLine($"Processing '{filePath}'");
        pinvokeGenerator.GenerateBindings(translationUnit, filePath, clangCommandLineArgs.ToArray(), translationFlags);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
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
