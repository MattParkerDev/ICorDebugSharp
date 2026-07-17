#!/usr/bin/env -S dotnet --

using System.Diagnostics;

var repoDirectory = AppContext.GetData("EntryPointFileDirectoryPath") as string ?? throw new InvalidOperationException("Not running as a file-based app.");

await Process.RunAsync(new ProcessStartInfo { FileName = "uv", Arguments = "run python generate.py C:/src/dotnet/src/runtime/src/coreclr/inc/cordebug.idl ../ICorDebugSharp/Generated", WorkingDirectory = $"{repoDirectory}/src/PythonGenerator" });
await Process.RunAsync(new ProcessStartInfo { FileName = "uv", Arguments = "run python generate.py C:/src/dotnet/src/runtime/src/coreclr/inc/metahost.idl ../ICorDebugSharp/Generated", WorkingDirectory = $"{repoDirectory}/src/PythonGenerator" });
await Process.RunAsync(new ProcessStartInfo { FileName = "clangSharpPInvokeGenerator", ArgumentList = { "@GenerateClang.rsp" }, WorkingDirectory = $"{repoDirectory}/src/MetadataGenerator" });
await Process.RunAsync(new ProcessStartInfo { FileName = "dotnet", Arguments = "run", WorkingDirectory = $"{repoDirectory}/src/MetadataGenerator" });
await Process.RunAsync(new ProcessStartInfo { FileName = "dotnet", Arguments = "run", WorkingDirectory = $"{repoDirectory}/src/ExtensionGenerator" });
