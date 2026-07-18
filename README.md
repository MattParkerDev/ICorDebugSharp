## ICorDebugSharp

Run generator with:

```shell
python generate.py "C:\src\dotnet\src\runtime\src\coreclr\inc\cordebug.idl" ../ICorDebugSharp/Generated
python generate.py "C:\src\dotnet\src\runtime\src\coreclr\inc\metahost.idl" ../ICorDebugSharp/Generated
```

Add Microsoft Learn XML documentation to the generated declarations with:

```shell
dotnet run --project src/DocsGenerator -- <path-to-dotnet-docs>
```

The documentation pass can also be enabled for `generate-all.cs` by passing the dotnet/docs repository path as its
first argument or by setting `DOTNET_DOCS_ROOT`.
