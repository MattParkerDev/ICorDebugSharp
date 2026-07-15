using ClangSharp;
using ClangSharp.Interop;
using ClangType = ClangSharp.Type;

namespace MetadataGenerator;

internal sealed class ComInterfaceTypeMapper
{
	private static readonly HashSet<string> MetadataTokens =
	[
		"mdToken", "mdModule", "mdTypeRef", "mdTypeDef", "mdFieldDef", "mdMethodDef",
		"mdParamDef", "mdInterfaceImpl", "mdMemberRef", "mdCustomAttribute", "mdPermission",
		"mdSignature", "mdEvent", "mdProperty", "mdModuleRef", "mdAssembly", "mdAssemblyRef",
		"mdFile", "mdExportedType", "mdManifestResource", "mdTypeSpec", "mdGenericParam",
		"mdMethodSpec", "mdGenericParamConstraint", "mdString", "mdCPToken",
	];

	public string Map(ClangType type)
	{
		return type switch
		{
			AttributedType attributed => Map(attributed.ModifiedType),
			ElaboratedType elaborated => Map(elaborated.NamedType),
			AdjustedType adjusted => Map(adjusted.GetAdjustedType),
			TypedefType typedef => MapTypedef(typedef),
			PointerType pointer => MapPointer(pointer.PointeeType),
			ReferenceType reference => $"{Map(reference.PointeeType)}*",
			ArrayType array => $"{Map(array.ElementType)}*",
			EnumType enumType => enumType.Decl.Name,
			TagType tagType => MapTag(tagType.Decl),
			BuiltinType => MapBuiltin(type),
			_ => throw new NotSupportedException($"Unsupported Clang type {type.TypeClassSpelling}: {type.AsString}"),
		};
	}

	private string MapTypedef(TypedefType type)
	{
		var name = type.Decl.Name;
		if (MetadataTokens.Contains(name))
			return name;

		return name switch
		{
			"HRESULT" or "BOOL" or "LONG" or "INT" => "int",
			"ULONG" or "DWORD" or "UINT" or "ULONG32" or "UINT32" => "uint",
			"USHORT" or "WORD" or "UINT16" => "ushort",
			"SHORT" or "INT16" => "short",
			"BYTE" or "UCHAR" or "COR_SIGNATURE" => "byte",
			"CHAR" => "sbyte",
			"WCHAR" => "char",
			"UINT64" or "ULONG64" => "ulong",
			"INT64" or "LONG64" => "long",
			"HCORENUM" => "HCorEnum",
			"LPWSTR" or "LPCWSTR" => "char*",
			"LPCVOID" or "LPVOID" or "UVCP_CONSTANT" => "nint",
			"PCOR_SIGNATURE" or "PCCOR_SIGNATURE" => "byte*",
			"MDUTF8CSTR" => "sbyte*",
			"GUID" or "IID" or "CLSID" => "Guid",
			_ when type.Decl.UnderlyingType is TagType or EnumType => name,
			_ => Map(type.Decl.UnderlyingType),
		};
	}

	private string MapPointer(ClangType pointee)
	{
		var unwrapped = Unwrap(pointee);
		if (unwrapped is BuiltinType { Kind: CXTypeKind.CXType_Void })
			return "nint";
		if (unwrapped is TagType { Decl: CXXRecordDecl record } && IsComInterface(record))
			return "nint";

		return $"{Map(pointee)}*";
	}

	private static ClangType Unwrap(ClangType type)
	{
		while (true)
		{
			type = type switch
			{
				AttributedType attributed => attributed.ModifiedType,
				ElaboratedType elaborated => elaborated.NamedType,
				TypedefType typedef => typedef.Decl.UnderlyingType,
				_ => type,
			};
			if (type is not AttributedType and not ElaboratedType and not TypedefType)
				return type;
		}
	}

	private static bool IsComInterface(CXXRecordDecl record) =>
		record.Name == "IUnknown" || record.Methods.Any(method => method.IsVirtual);

	private static string MapTag(TagDecl declaration) => declaration.Name switch
	{
		"_GUID" => "Guid",
		var name when !string.IsNullOrEmpty(name) => name,
		_ => throw new NotSupportedException("Anonymous record types are not supported in COM signatures."),
	};

	private static string MapBuiltin(ClangType type) => type.Kind switch
	{
		CXTypeKind.CXType_Void => "void",
		CXTypeKind.CXType_Bool or CXTypeKind.CXType_Int or CXTypeKind.CXType_Long => "int",
		CXTypeKind.CXType_UInt or CXTypeKind.CXType_ULong => "uint",
		CXTypeKind.CXType_Short => "short",
		CXTypeKind.CXType_UShort => "ushort",
		CXTypeKind.CXType_Char_S or CXTypeKind.CXType_SChar => "sbyte",
		CXTypeKind.CXType_Char_U or CXTypeKind.CXType_UChar => "byte",
		CXTypeKind.CXType_WChar or CXTypeKind.CXType_Char16 => "char",
		CXTypeKind.CXType_LongLong => "long",
		CXTypeKind.CXType_ULongLong => "ulong",
		CXTypeKind.CXType_Float => "float",
		CXTypeKind.CXType_Double => "double",
		_ => throw new NotSupportedException($"Unsupported builtin Clang type: {type.AsString}"),
	};
}
