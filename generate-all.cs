#!/usr/bin/env -S dotnet --

using System.Diagnostics;

var repoDirectory = AppContext.GetData("EntryPointFileDirectoryPath") as string ?? throw new InvalidOperationException("Not running as a file-based app.");
var docsDirectory = args.FirstOrDefault() ?? Environment.GetEnvironmentVariable("DOTNET_DOCS_ROOT");

await Process.RunAsync(new ProcessStartInfo { FileName = "uv", Arguments = "run python generate.py C:/src/dotnet/src/runtime/src/coreclr/inc/cordebug.idl ../ICorDebugSharp/Generated", WorkingDirectory = $"{repoDirectory}/src/PythonGenerator" });
await Process.RunAsync(new ProcessStartInfo { FileName = "uv", Arguments = "run python generate.py C:/src/dotnet/src/runtime/src/coreclr/inc/metahost.idl ../ICorDebugSharp/Generated", WorkingDirectory = $"{repoDirectory}/src/PythonGenerator" });
await Process.RunAsync(new ProcessStartInfo { FileName = "dotnet", ArgumentList = { "dnx", "clangSharpPInvokeGenerator", "--", "@GenerateClang.rsp" }, WorkingDirectory = $"{repoDirectory}/src/ClangSharpCliDbgShimGenerator" });
await Process.RunAsync(new ProcessStartInfo { FileName = "dotnet", Arguments = "run", WorkingDirectory = $"{repoDirectory}/src/MetadataGenerator" });
if (!string.IsNullOrWhiteSpace(docsDirectory))
	await Process.RunAsync(new ProcessStartInfo { FileName = "dotnet", ArgumentList = { "run", "--", docsDirectory }, WorkingDirectory = $"{repoDirectory}/src/DocsGenerator" });
await Process.RunAsync(new ProcessStartInfo { FileName = "dotnet", Arguments = "run", WorkingDirectory = $"{repoDirectory}/src/ExtensionGenerator" });
