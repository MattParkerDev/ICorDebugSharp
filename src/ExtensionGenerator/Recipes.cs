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

internal sealed record BoolResultRecipe(string Interface, string Method);

internal sealed record CapabilityFamily(string BaseInterface, string CapabilityInterface);

internal static class Recipes
{
	public static readonly CapabilityFamily[] CapabilityFamilies =
	[
		//new("ICorDebug", "ICorDebug2"), // Has no methods, and generates badly (just "2")
		new("ICorDebugAppDomain", "ICorDebugAppDomain2"),
		new("ICorDebugAppDomain", "ICorDebugAppDomain3"),
		new("ICorDebugAppDomain", "ICorDebugAppDomain4"),
		new("ICorDebugAssembly", "ICorDebugAssembly2"),
		new("ICorDebugAssembly", "ICorDebugAssembly3"),
		new("ICorDebugClass", "ICorDebugClass2"),
		new("ICorDebugCode", "ICorDebugCode2"),
		new("ICorDebugCode", "ICorDebugCode3"),
		new("ICorDebugCode", "ICorDebugCode4"),
		new("ICorDebugEval", "ICorDebugEval2"),
		new("ICorDebugExceptionObjectValue", "ICorDebugExceptionObjectValue2"),
		new("ICorDebugFunction", "ICorDebugFunction2"),
		new("ICorDebugFunction", "ICorDebugFunction3"),
		new("ICorDebugFunction", "ICorDebugFunction4"),
		new("ICorDebugFunction", "ICorDebugFunction5"),
		new("ICorDebugHeapValue", "ICorDebugHeapValue2"),
		new("ICorDebugHeapValue", "ICorDebugHeapValue3"),
		new("ICorDebugHeapValue", "ICorDebugHeapValue4"),
		new("ICorDebugILCode", "ICorDebugILCode2"),
		new("ICorDebugILFrame", "ICorDebugILFrame2"),
		new("ICorDebugILFrame", "ICorDebugILFrame3"),
		new("ICorDebugILFrame", "ICorDebugILFrame4"),
		new("ICorDebugInternalFrame", "ICorDebugInternalFrame2"),
		new("ICorDebugModule", "ICorDebugModule2"),
		new("ICorDebugModule", "ICorDebugModule3"),
		new("ICorDebugModule", "ICorDebugModule4"),
		new("ICorDebugNativeFrame", "ICorDebugNativeFrame2"),
		new("ICorDebugObjectValue", "ICorDebugObjectValue2"),
		new("ICorDebugProcess", "ICorDebugProcess2"),
		new("ICorDebugProcess", "ICorDebugProcess3"),
		new("ICorDebugProcess", "ICorDebugProcess5"),
		new("ICorDebugProcess", "ICorDebugProcess6"),
		new("ICorDebugProcess", "ICorDebugProcess7"),
		new("ICorDebugProcess", "ICorDebugProcess8"),
		new("ICorDebugProcess", "ICorDebugProcess10"),
		new("ICorDebugProcess", "ICorDebugProcess12"),
		new("ICorDebugRegisterSet", "ICorDebugRegisterSet2"),
		new("ICorDebugStepper", "ICorDebugStepper2"),
		new("ICorDebugSymbolProvider", "ICorDebugSymbolProvider2"),
		new("ICorDebugThread", "ICorDebugThread2"),
		new("ICorDebugThread", "ICorDebugThread3"),
		new("ICorDebugThread", "ICorDebugThread4"),
		new("ICorDebugThread", "ICorDebugThread5"),
		new("ICorDebugType", "ICorDebugType2"),
		new("ICorDebugValue", "ICorDebugValue2"),
		new("ICorDebugValue", "ICorDebugValue3"),
	];

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
		new("IMetaDataImport", "GetScopeProps", "ScopeProps", "(string szName, Guid pmvid)", "", "null, 0, out var required, out _", "buffer, capacity, out var actual, out var pmvid", "(CreateString(buffer, actual, true), pmvid)"),
		new("IMetaDataImport", "GetTypeDefProps", "TypeDefProps", "(string szTypeDef, CorTypeAttr pdwTypeDefFlags, mdToken ptkExtends)", "mdTypeDef typeDefinition", "typeDefinition, null, 0, out var required, out _, out _", "typeDefinition, buffer, capacity, out var actual, out var pdwTypeDefFlags, out var ptkExtends", "(CreateString(buffer, actual, true), pdwTypeDefFlags, ptkExtends)"),
		new("IMetaDataImport", "GetTypeRefProps", "TypeRefProps", "(mdToken ptkResolutionScope, string szName)", "mdTypeRef typeReference", "typeReference, out _, null, 0, out var required", "typeReference, out var ptkResolutionScope, buffer, capacity, out var actual", "(ptkResolutionScope, CreateString(buffer, actual, true))"),
		new("IMetaDataImport", "GetModuleRefProps", "ModuleRefName", "string", "mdModuleRef moduleReference", "moduleReference, null, 0, out var required", "moduleReference, buffer, capacity, out var actual", "CreateString(buffer, actual, true)"),
		new("IMetaDataImport", "GetUserString", "UserString", "string", "mdString userString", "userString, null, 0, out var required", "userString, buffer, capacity, out var actual", "CreateString(buffer, actual, false)", false),
		new("IMetaDataImport2", "GetVersionString", "VersionString", "string", "", "null, 0, out var required", "buffer, capacity, out var actual", "CreateString(buffer, actual, true)"),
		new("IMetaDataAssemblyImport", "GetFileProps", "FileName", "string", "mdFile file", "file, null, 0, out var required, out _, out _, out _", "file, buffer, capacity, out var actual, out _, out _, out _", "CreateString(buffer, actual, true)"),
		new("IMetaDataAssemblyImport", "GetExportedTypeProps", "ExportedTypeName", "string", "mdExportedType exportedType", "exportedType, null, 0, out var required, out _, out _, out _", "exportedType, buffer, capacity, out var actual, out _, out _, out _", "CreateString(buffer, actual, true)"),
		new("IMetaDataAssemblyImport", "GetManifestResourceProps", "ManifestResourceName", "string", "mdManifestResource resource", "resource, null, 0, out var required, out _, out _, out _", "resource, buffer, capacity, out var actual, out _, out _, out _", "CreateString(buffer, actual, true)"),
	];

	public static readonly BoolResultRecipe[] BoolResults =
	[
		new("IMetaDataImport", "IsValidToken"),
	];
}
