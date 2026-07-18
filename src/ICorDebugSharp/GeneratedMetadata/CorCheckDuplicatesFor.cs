// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Specifies the metadata tokens that will be checked for duplicates.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corcheckduplicatesfor-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorCheckDuplicatesFor
{
    /// <summary>
    /// <para>Check all metadata tokens for duplicates.</para>
    /// </summary>
    MDDupAll = unchecked((int)(0xffffffff)),
    /// <summary>
    /// <para>Not used.</para>
    /// </summary>
    MDDupENC = MDDupAll,
    /// <summary>
    /// <para>Do not check metadata tokens for duplicates.</para>
    /// </summary>
    MDNoDupChecks = 0x00000000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdTypeDef</c> tokens.</para>
    /// </summary>
    MDDupTypeDef = 0x00000001,
    /// <summary>
    /// <para>Check for duplicates of <c>mdInterfaceImpl</c> tokens.</para>
    /// </summary>
    MDDupInterfaceImpl = 0x00000002,
    /// <summary>
    /// <para>Check for duplicates of <c>mdMethodDef</c> tokens.</para>
    /// </summary>
    MDDupMethodDef = 0x00000004,
    /// <summary>
    /// <para>Check for duplicates of <c>mdTypeRef</c> tokens.</para>
    /// </summary>
    MDDupTypeRef = 0x00000008,
    /// <summary>
    /// <para>Check for duplicates of <c>mdMemberRef</c> tokens.</para>
    /// </summary>
    MDDupMemberRef = 0x00000010,
    /// <summary>
    /// <para>Check for duplicates of <c>mdCustomAttribute</c> tokens.</para>
    /// </summary>
    MDDupCustomAttribute = 0x00000020,
    /// <summary>
    /// <para>Check for duplicates of <c>mdParamDef</c> tokens.</para>
    /// </summary>
    MDDupParamDef = 0x00000040,
    /// <summary>
    /// <para>Check for duplicates of <c>mdPermission</c> tokens.</para>
    /// </summary>
    MDDupPermission = 0x00000080,
    /// <summary>
    /// <para>Check for duplicates of <c>mdProperty</c> tokens.</para>
    /// </summary>
    MDDupProperty = 0x00000100,
    /// <summary>
    /// <para>Check for duplicates of <c>mdEvent</c> tokens.</para>
    /// </summary>
    MDDupEvent = 0x00000200,
    /// <summary>
    /// <para>Check for duplicates of <c>mdFieldDef</c> tokens.</para>
    /// </summary>
    MDDupFieldDef = 0x00000400,
    /// <summary>
    /// <para>Check for duplicates of <c>mdSignature</c> tokens.</para>
    /// </summary>
    MDDupSignature = 0x00000800,
    /// <summary>
    /// <para>Check for duplicates of <c>mdModuleRef</c> tokens.</para>
    /// </summary>
    MDDupModuleRef = 0x00001000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdTypeSpec</c> tokens.</para>
    /// </summary>
    MDDupTypeSpec = 0x00002000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdImplMap</c> tokens.</para>
    /// </summary>
    MDDupImplMap = 0x00004000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdAssemblyRef</c> tokens.</para>
    /// </summary>
    MDDupAssemblyRef = 0x00008000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdFile</c> tokens.</para>
    /// </summary>
    MDDupFile = 0x00010000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdExportedType</c> tokens.</para>
    /// </summary>
    MDDupExportedType = 0x00020000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdManifestResource</c> tokens.</para>
    /// </summary>
    MDDupManifestResource = 0x00040000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdGenericParam</c> tokens.</para>
    /// </summary>
    MDDupGenericParam = 0x00080000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdMethodSpec</c> tokens.</para>
    /// </summary>
    MDDupMethodSpec = 0x00100000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdGenericParamConstraint</c> tokens.</para>
    /// </summary>
    MDDupGenericParamConstraint = 0x00200000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdAssembly</c> tokens.</para>
    /// </summary>
    MDDupAssembly = 0x10000000,
    /// <summary>
    /// <para>Check for duplicates of <c>mdMemberRef</c>, <c>mdTypeRef</c>, <c>mdSignature</c>, <c>mdTypeSpec</c>, and <c>mdMethodSpec</c> tokens.</para>
    /// </summary>
    MDDupDefault = MDNoDupChecks | MDDupTypeRef | MDDupMemberRef | MDDupSignature | MDDupTypeSpec | MDDupMethodSpec,
}
