# ICorDebug Generator

For the full pipeline, use the repository's [generator setup](../../README.md#generator-setup).
`generate-all.cs` supplies the runtime path from user secrets.

To run this generator independently from this directory:

```shell
uv run --with-requirements requirements.txt python generate.py "<runtime-root>/src/coreclr/inc/cordebug.idl" ../ICorDebugSharp/Generated
uv run --with-requirements requirements.txt python generate.py "<runtime-root>/src/coreclr/inc/metahost.idl" ../ICorDebugSharp/Generated
```
