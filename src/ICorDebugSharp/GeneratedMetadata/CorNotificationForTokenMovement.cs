// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Specifies the notifications that will be sent to the metadata API client when a token remap occurs.</para>
/// </summary>
/// <remarks>
/// <para>A token may be re-mapped (that is, moved) during a metadata merge.</para>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/cornotificationfortokenmovement-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorNotificationForTokenMovement
{
    /// <summary>
    /// <para>Notify when <c>mdTypeRef</c>, <c>mdMethodDef</c>, <c>mdMemberRef</c>, or <c>mdFieldDef</c> tokens move.</para>
    /// </summary>
    MDNotifyDefault = 0x0000000f,
    /// <summary>
    /// <para>Notify when any token moves.</para>
    /// </summary>
    MDNotifyAll = unchecked((int)(0xffffffff)),
    /// <summary>
    /// <para>Do not notify when tokens move.</para>
    /// </summary>
    MDNotifyNone = 0x00000000,
    /// <summary>
    /// <para>Notify when an <c>mdMethodDef</c> token moves.</para>
    /// </summary>
    MDNotifyMethodDef = 0x00000001,
    /// <summary>
    /// <para>Notify when an <c>mdMemberRef</c> token moves.</para>
    /// </summary>
    MDNotifyMemberRef = 0x00000002,
    /// <summary>
    /// <para>Notify when an <c>mdFieldDef</c> token moves.</para>
    /// </summary>
    MDNotifyFieldDef = 0x00000004,
    /// <summary>
    /// <para>Notify when an <c>mdTypeRef</c> token moves.</para>
    /// </summary>
    MDNotifyTypeRef = 0x00000008,
    /// <summary>
    /// <para>Notify when an <c>mdTypeDef</c> token moves.</para>
    /// </summary>
    MDNotifyTypeDef = 0x00000010,
    /// <summary>
    /// <para>Notify when an <c>mdParamDef</c> token moves.</para>
    /// </summary>
    MDNotifyParamDef = 0x00000020,
    /// <summary>
    /// <para>Notify when an <c>mdInterfaceImpl</c> token moves.</para>
    /// </summary>
    MDNotifyInterfaceImpl = 0x00000040,
    /// <summary>
    /// <para>Notify when an <c>mdProperty</c> token moves.</para>
    /// </summary>
    MDNotifyProperty = 0x00000080,
    /// <summary>
    /// <para>Notify when an <c>mdEvent</c> token moves.</para>
    /// </summary>
    MDNotifyEvent = 0x00000100,
    /// <summary>
    /// <para>Notify when an <c>mdSignature</c> token moves.</para>
    /// </summary>
    MDNotifySignature = 0x00000200,
    /// <summary>
    /// <para>Notify when an <c>mdTypeSpec</c> token moves.</para>
    /// </summary>
    MDNotifyTypeSpec = 0x00000400,
    /// <summary>
    /// <para>Notify when an <c>mdCustomAttribute</c> token moves.</para>
    /// </summary>
    MDNotifyCustomAttribute = 0x00000800,
    /// <summary>
    /// <para>Notify when an <c>mdSecurityValue</c> token moves.</para>
    /// </summary>
    MDNotifySecurityValue = 0x00001000,
    /// <summary>
    /// <para>Notify when an <c>mdPermission</c> token moves.</para>
    /// </summary>
    MDNotifyPermission = 0x00002000,
    /// <summary>
    /// <para>Notify when an <c>mdModuleRef</c> token moves.</para>
    /// </summary>
    MDNotifyModuleRef = 0x00004000,
    /// <summary>
    /// <para>Notify when an <c>mdNameSpace</c> token moves.</para>
    /// </summary>
    MDNotifyNameSpace = 0x00008000,
    /// <summary>
    /// <para>Notify when an <c>mdAssemblyRef</c> token moves.</para>
    /// </summary>
    MDNotifyAssemblyRef = 0x01000000,
    /// <summary>
    /// <para>Notify when an <c>mdFile</c> token moves.</para>
    /// </summary>
    MDNotifyFile = 0x02000000,
    /// <summary>
    /// <para>Notify when an <c>mdExportedType</c> token moves.</para>
    /// </summary>
    MDNotifyExportedType = 0x04000000,
    /// <summary>
    /// <para>Notify when an <c>mdManifestResource</c> token moves.</para>
    /// </summary>
    MDNotifyResource = 0x08000000,
}
