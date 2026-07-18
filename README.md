## ICorDebugSharp

Run generator with:

```shell
dotnet generate-all.cs
```

Ensure you have done `uv pip install -r requirements.txt` in `PythonICorDebugGenerator` first.

You will need some dotnet repos cloned, and update their paths in the various tools.
* runtime
* diagnostics
* docs

Additionally, some headers from MSVC and the Windows 10 SDK are required for ClangSharp.
