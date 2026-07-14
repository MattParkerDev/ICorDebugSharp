namespace ExtensionGenerator;

internal enum BufferKind
{
	String,
	Array,
}

internal sealed record QueryBufferRecipe(
	string Interface,
	string Method,
	BufferKind Kind,
	string Capacity,
	string Count,
	string Buffer);

internal sealed record EnumerationInput(string Type, string Name);
internal sealed record EnumerationOutput(string Type, string RawName, string PublicName);

internal sealed record EnumerationRecipe(
	string Interface,
	string Method,
	string PublicName,
	IReadOnlyList<EnumerationInput> Inputs,
	IReadOnlyList<EnumerationOutput> Outputs);

internal sealed record StringQueryRecipe(
	string Interface,
	string Method,
	string PublicName,
	string ReturnType,
	string Parameters,
	string QueryArguments,
	string FillArguments,
	string ReturnExpression,
	bool TrimTerminator = true);

internal static class Recipes
{
	public static readonly QueryBufferRecipe[] QueryBuffers =
	[
		new("ICorDebugStaticFieldSymbol", "GetName", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugInstanceFieldSymbol", "GetName", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugVariableSymbol", "GetName", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugMergedAssemblyRecord", "GetSimpleName", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugMergedAssemblyRecord", "GetCulture", BufferKind.String, "cchCulture", "pcchCulture", "szCulture"),
		new("ICorDebugDataTarget2", "GetImageLocation", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugLoadedModule", "GetName", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugRemoteTarget", "GetHostName", BufferKind.String, "cchHostName", "pcchHostName", "szHostName"),
		new("ICorDebugAppDomain", "GetName", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugAssembly", "GetCodeBase", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugAssembly", "GetName", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugModule", "GetName", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugStringValue", "GetString", BufferKind.String, "cchString", "pcchString", "szString"),
		new("ICorDebugMDA", "GetName", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugMDA", "GetDescription", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugMDA", "GetXML", BufferKind.String, "cchName", "pcchName", "szName"),
		new("ICorDebugEditAndContinueErrorInfo", "GetString", BufferKind.String, "cchString", "pcchString", "szString"),
		new("ICorDebugThread2", "GetActiveFunctions", BufferKind.Array, "cFunctions", "pcFunctions", "pFunctions"),
		new("ICorDebugCode", "GetILToNativeMapping", BufferKind.Array, "cMap", "pcMap", "map"),
		new("ICorDebugCode2", "GetCodeChunks", BufferKind.Array, "cbufSize", "pcnumChunks", "chunks"),
		new("ICorDebugILCode", "GetEHClauses", BufferKind.Array, "cClauses", "pcClauses", "clauses"),
		new("ICorDebugILCode2", "GetInstrumentedILMap", BufferKind.Array, "cMap", "pcMap", "map"),
		new("ICorDebugComObjectValue", "GetCachedInterfacePointers", BufferKind.Array, "celt", "pcEltFetched", "ptrs"),
	];

	private static EnumerationInput Input(string type, string name) => new(type, name);
	private static EnumerationOutput Output(string rawName, string publicName) => new("Token", rawName, publicName);

	public static readonly EnumerationRecipe[] Enumerations =
	[
		new("IMetaDataImport", "EnumTypeDefs", "TypeDefs", [], [Output("rTypeDefs", "TypeDef")]),
		new("IMetaDataImport", "EnumInterfaceImpls", "InterfaceImpls", [Input("Token", "td")], [Output("rImpls", "InterfaceImpl")]),
		new("IMetaDataImport", "EnumTypeRefs", "TypeRefs", [], [Output("rTypeRefs", "TypeRef")]),
		new("IMetaDataImport", "EnumMembers", "Members", [Input("Token", "cl")], [Output("rMembers", "Member")]),
		new("IMetaDataImport", "EnumMembersWithName", "MembersWithName", [Input("Token", "cl"), Input("string", "szName")], [Output("rMembers", "Member")]),
		new("IMetaDataImport", "EnumMethods", "Methods", [Input("Token", "cl")], [Output("rMethods", "Method")]),
		new("IMetaDataImport", "EnumMethodsWithName", "MethodsWithName", [Input("Token", "cl"), Input("string", "szName")], [Output("rMethods", "Method")]),
		new("IMetaDataImport", "EnumFields", "Fields", [Input("Token", "cl")], [Output("rFields", "Field")]),
		new("IMetaDataImport", "EnumFieldsWithName", "FieldsWithName", [Input("Token", "cl"), Input("string", "szName")], [Output("rFields", "Field")]),
		new("IMetaDataImport", "EnumParams", "Parameters", [Input("Token", "mb")], [Output("rParams", "Parameter")]),
		new("IMetaDataImport", "EnumMemberRefs", "MemberRefs", [Input("Token", "tkParent")], [Output("rMemberRefs", "MemberRef")]),
		new("IMetaDataImport", "EnumMethodImpls", "MethodImpls", [Input("Token", "td")], [Output("rMethodBody", "MethodBody"), Output("rMethodDecl", "MethodDeclaration")]),
		new("IMetaDataImport", "EnumPermissionSets", "PermissionSets", [Input("Token", "tk"), Input("uint", "dwActions")], [Output("rPermission", "Permission")]),
		new("IMetaDataImport", "EnumProperties", "Properties", [Input("Token", "td")], [Output("rProperties", "Property")]),
		new("IMetaDataImport", "EnumEvents", "Events", [Input("Token", "td")], [Output("rEvents", "Event")]),
		new("IMetaDataImport", "EnumMethodSemantics", "MethodSemantics", [Input("Token", "mb")], [Output("rEventProp", "EventOrProperty")]),
		new("IMetaDataImport", "EnumModuleRefs", "ModuleRefs", [], [Output("rModuleRefs", "ModuleRef")]),
		new("IMetaDataImport", "EnumUnresolvedMethods", "UnresolvedMethods", [], [Output("rMethods", "Method")]),
		new("IMetaDataImport", "EnumSignatures", "Signatures", [], [Output("rSignatures", "Signature")]),
		new("IMetaDataImport", "EnumTypeSpecs", "TypeSpecs", [], [Output("rTypeSpecs", "TypeSpec")]),
		new("IMetaDataImport", "EnumUserStrings", "UserStrings", [], [Output("rStrings", "UserString")]),
		new("IMetaDataImport", "EnumCustomAttributes", "CustomAttributes", [Input("Token", "tk"), Input("Token", "tkType")], [Output("rCustomAttributes", "CustomAttribute")]),
		new("IMetaDataImport2", "EnumGenericParams", "GenericParameters", [Input("Token", "tk")], [Output("rGenericParams", "GenericParameter")]),
		new("IMetaDataImport2", "EnumGenericParamConstraints", "GenericParameterConstraints", [Input("Token", "tk")], [Output("rGenericParamConstraints", "Constraint")]),
		new("IMetaDataImport2", "EnumMethodSpecs", "MethodSpecs", [Input("Token", "tk")], [Output("rMethodSpecs", "MethodSpec")]),
		new("IMetaDataAssemblyImport", "EnumAssemblyRefs", "AssemblyRefs", [], [Output("rAssemblyRefs", "AssemblyRef")]),
		new("IMetaDataAssemblyImport", "EnumFiles", "Files", [], [Output("rFiles", "File")]),
		new("IMetaDataAssemblyImport", "EnumExportedTypes", "ExportedTypes", [], [Output("rExportedTypes", "ExportedType")]),
		new("IMetaDataAssemblyImport", "EnumManifestResources", "ManifestResources", [], [Output("rManifestResources", "ManifestResource")]),
	];

	public static readonly StringQueryRecipe[] MetadataStrings =
	[
		new("IMetaDataImport", "GetScopeProps", "ScopeProps", "(string Name, Guid ModuleVersionId)", "", "null, 0, out var required, out _", "buffer, capacity, out var actual, out var moduleVersionId", "(CreateString(buffer, actual, true), moduleVersionId)"),
		new("IMetaDataImport", "GetTypeDefProps", "TypeDefProps", "(string Name, TypeAttributes Attributes, Token Extends)", "Token typeDefinition", "typeDefinition, null, 0, out var required, out _, out _", "typeDefinition, buffer, capacity, out var actual, out var attributes, out var extends", "(CreateString(buffer, actual, true), attributes, extends)"),
		new("IMetaDataImport", "GetTypeRefProps", "TypeRefProps", "(Token ResolutionScope, string Name)", "Token typeReference", "typeReference, out _, null, 0, out var required", "typeReference, out var resolutionScope, buffer, capacity, out var actual", "(resolutionScope, CreateString(buffer, actual, true))"),
		new("IMetaDataImport", "GetModuleRefProps", "ModuleRefName", "string", "Token moduleReference", "moduleReference, null, 0, out var required", "moduleReference, buffer, capacity, out var actual", "CreateString(buffer, actual, true)"),
		new("IMetaDataImport", "GetUserString", "UserString", "string", "Token userString", "userString, null, 0, out var required", "userString, buffer, capacity, out var actual", "CreateString(buffer, actual, false)", false),
		new("IMetaDataImport2", "GetVersionString", "VersionString", "string", "", "null, 0, out var required", "buffer, capacity, out var actual", "CreateString(buffer, actual, true)"),
		new("IMetaDataAssemblyImport", "GetFileProps", "FileName", "string", "Token file", "file, null, 0, out var required, out _, out _, out _", "file, buffer, capacity, out var actual, out _, out _, out _", "CreateString(buffer, actual, true)"),
		new("IMetaDataAssemblyImport", "GetExportedTypeProps", "ExportedTypeName", "string", "Token exportedType", "exportedType, null, 0, out var required, out _, out _, out _", "exportedType, buffer, capacity, out var actual, out _, out _, out _", "CreateString(buffer, actual, true)"),
		new("IMetaDataAssemblyImport", "GetManifestResourceProps", "ManifestResourceName", "string", "Token resource", "resource, null, 0, out var required, out _, out _, out _", "resource, buffer, capacity, out var actual, out _, out _, out _", "CreateString(buffer, actual, true)"),
	];
}
