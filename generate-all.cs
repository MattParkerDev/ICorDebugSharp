#!/usr/bin/env -S dotnet --
#:property UserSecretsId=22cafe66-901a-442d-851b-5025b0e268cc
#:package Microsoft.Extensions.Configuration.UserSecrets@10.0.0

using System.Diagnostics;
using Microsoft.Extensions.Configuration;

var repoDirectory = AppContext.GetData("EntryPointFileDirectoryPath") as string ?? throw new InvalidOperationException("Not running as a file-based app.");

if (args.Length > 1 || (args.Length == 1 && args[0] != "--check"))
{
    Console.Error.WriteLine("Usage: dotnet generate-all.cs [--check]");
    return 1;
}

try
{
    var configuration = new ConfigurationBuilder().AddUserSecrets(typeof(Program).Assembly).Build();
    var runtime = GetDirectory("Runtime");
    var diagnostics = GetDirectory("Diagnostics");
    var docs = GetDirectory("Docs");
    var windowsSdk = GetDirectory("WindowsSdkInclude");
    var msvc = GetDirectory("MsvcInclude");
    var runtimeInclude = Path.Combine(runtime, "src/coreclr/inc");
    var runtimePrebuilt = Path.Combine(runtime, "src/coreclr/pal/prebuilt/inc");
    var dbgShimInclude = Path.Combine(diagnostics, "src/dbgshim");
    var dbgShimHeader = Path.Combine(dbgShimInclude, "dbgshim.h");
    string[] includes = [runtimeInclude, runtimePrebuilt, dbgShimInclude,
        Path.Combine(windowsSdk, "um"), Path.Combine(windowsSdk, "shared"),
        Path.Combine(windowsSdk, "ucrt"), Path.Combine(windowsSdk, "winrt"), msvc];

    foreach (var directory in includes)
        if (!Directory.Exists(directory)) throw new DirectoryNotFoundException(directory);
    foreach (var file in new[] { "cordebug.idl", "metahost.idl", "cor.h", "corhdr.h" }
        .Select(name => Path.Combine(runtimeInclude, name))
        .Append(Path.Combine(runtimePrebuilt, "corerror.h")).Append(dbgShimHeader))
        if (!File.Exists(file)) throw new FileNotFoundException($"Required input not found: {file}");

    Console.WriteLine("Generator paths validated.");
    if (args.Contains("--check")) return 0;

    foreach (var idl in new[] { "cordebug.idl", "metahost.idl" })
        await Run("PythonICorDebugGenerator", "uv", "run", "--with-requirements", "requirements.txt",
            "python", "generate.py", Path.Combine(runtimeInclude, idl), "../ICorDebugSharp/Generated");

    await Run("ClangSharpCliDbgShimGenerator", "dotnet",
        ["dnx", "clangSharpPInvokeGenerator", "--", "@GenerateClang.rsp",
        "--include-directory", ..includes, "--file", dbgShimHeader,
        "--traverse", Path.Combine(runtimeInclude, "corhdr.h"), Path.Combine(runtimeInclude, "cor.h"), dbgShimHeader]);
    await Run("ClangSharpMetadataGenerator", "dotnet", "run", "--", runtime, windowsSdk, msvc);
    await Run("DocsGenerator", "dotnet", "run", "--", docs);
    await Run("ExtensionGenerator", "dotnet", "run");
    return 0;

    string GetDirectory(string name)
    {
        var key = $"Paths:{name}";
        var value = configuration[key];
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidOperationException($"Missing {key}. Set it with: dotnet user-secrets set \"{key}\" \"<absolute path>\" --id ICorDebugSharp.Generators");
        if (!Path.IsPathFullyQualified(value))
            throw new InvalidOperationException($"{key} must be an absolute path: {value}");
        var path = Path.GetFullPath(value);
        if (!Directory.Exists(path)) throw new DirectoryNotFoundException($"{key}: {path}");
        return path;
    }
}
catch (Exception exception)
{
    Console.Error.WriteLine(exception.Message);
    return 1;
}

async Task Run(string project, string executable, params string[] arguments)
{
    Console.WriteLine($"Running {project}...");
    var startInfo = new ProcessStartInfo(executable)
    {
        WorkingDirectory = Path.Combine(repoDirectory, "src", project),
        UseShellExecute = false,
    };
    foreach (var argument in arguments) startInfo.ArgumentList.Add(argument);
    using var process = Process.Start(startInfo) ?? throw new InvalidOperationException($"Could not start {executable}.");
    await process.WaitForExitAsync();
    if (process.ExitCode != 0)
        throw new InvalidOperationException($"{project} failed with exit code {process.ExitCode}.");
}
