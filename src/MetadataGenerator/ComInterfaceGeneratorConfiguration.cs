namespace MetadataGenerator;

internal sealed record ComInterfaceGeneratorConfiguration(
	string Namespace,
	string OutputDirectory,
	IReadOnlyDictionary<string, int> InterfaceMethodCounts,
	IReadOnlyDictionary<string, Guid> InterfaceGuids);
