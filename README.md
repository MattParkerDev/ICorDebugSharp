## ICorDebugSharp

### Generator setup

Regeneration requires the .NET 11 SDK (the documentation generator targets .NET 11),
[uv](https://docs.astral.sh/uv/), clones of `dotnet/runtime`, `dotnet/diagnostics`,
and `dotnet/docs`, plus MSVC and Windows SDK headers.

Set these five absolute paths once using .NET user secrets. Replace the example
paths and installed toolchain versions with your own:

```shell
dotnet user-secrets set "Paths:Runtime" "C:/src/runtime" --file ./generate-all.cs
dotnet user-secrets set "Paths:Diagnostics" "C:/src/diagnostics" --file ./generate-all.cs
dotnet user-secrets set "Paths:Docs" "C:/src/docs" --file ./generate-all.cs
dotnet user-secrets set "Paths:WindowsSdkInclude" "C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0" --file ./generate-all.cs
dotnet user-secrets set "Paths:MsvcInclude" "C:/Program Files/Microsoft Visual Studio/18/Enterprise/VC/Tools/MSVC/14.50.35717/include" --file ./generate-all.cs
```

The first three paths are repository roots. `WindowsSdkInclude` is the versioned
include directory containing `um`, `shared`, `ucrt`, and `winrt`; `MsvcInclude`
is the compiler's `include` directory.

Run these commands from the repository root. These settings are stored outside
the repository, per user, under the `UserSecretsId` declared in `generate-all.cs`.
All clones for that user use the same settings.
To update a path, run its `set` command again.

Validate the configured directories and required input headers without generating:

```shell
dotnet run --file generate-all.cs -- --check
```

Run all generators from the repository root:

```shell
dotnet run --file generate-all.cs
```

`generate-all.cs` reads user secrets and passes paths as individual command-line
arguments, including paths containing spaces. It supplies the Python requirements
through `uv` and stops if any generator fails. Child generators do not read user secrets.
Finally, the runner normalizes generated C# line endings to CRLF on Windows or LF
on Unix, preserving blank lines, indentation, and existing UTF-8 BOMs. Only files
with different line endings are rewritten.

For individual runs, pass paths explicitly (from the repository root):

```shell
dotnet run --project src/ClangSharpMetadataGenerator -- "<runtime-root>" "<windows-sdk-version-include>" "<msvc-include>"
dotnet run --project src/DocsGenerator -- "<docs-root>"
```

The archived tools under `src/deprecated` are not part of this pipeline.
