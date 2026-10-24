
# DbgShim Generator

Use the repository's [generator setup](../../README.md#generator-setup) to configure
paths once in .NET user secrets, then run the pipeline from the repository root:

```shell
dotnet run --file generate-all.cs
```

`GenerateClang.rsp` contains the portable generator options. The runner supplies
`--include-directory`, `--file`, and `--traverse` from the configured paths when
invoking ClangSharp through `dotnet dnx`. Running the response file alone requires
supplying those options yourself.
