// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values that describe the features of a method.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/cormethodattr-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorMethodAttr
{
    /// <summary>
    /// <para>Specifies member access.</para>
    /// </summary>
    mdMemberAccessMask = 0x0007,
    /// <summary>
    /// <para>Specifies that the member cannot be referenced.</para>
    /// </summary>
    mdPrivateScope = 0x0000,
    /// <summary>
    /// <para>Specifies that the member is accessible only by the parent type.</para>
    /// </summary>
    mdPrivate = 0x0001,
    /// <summary>
    /// <para>Specifies that the member is accessible by subtypes only in this assembly.</para>
    /// </summary>
    mdFamANDAssem = 0x0002,
    /// <summary>
    /// <para>Specifies that the member is accessibly by anyone in the assembly.</para>
    /// </summary>
    mdAssem = 0x0003,
    /// <summary>
    /// <para>Specifies that the member is accessible only by type and subtypes.</para>
    /// </summary>
    mdFamily = 0x0004,
    /// <summary>
    /// <para>Specifies that the member is accessible by derived classes and by other types in its assembly.</para>
    /// </summary>
    mdFamORAssem = 0x0005,
    /// <summary>
    /// <para>Specifies that the member is accessible by all types with access to the scope.</para>
    /// </summary>
    mdPublic = 0x0006,
    /// <summary>
    /// <para>Specifies that the member is defined as part of the type rather than as a member of an instance.</para>
    /// </summary>
    mdStatic = 0x0010,
    /// <summary>
    /// <para>Specifies that the method cannot be overridden.</para>
    /// </summary>
    mdFinal = 0x0020,
    /// <summary>
    /// <para>Specifies that the method can be overridden.</para>
    /// </summary>
    mdVirtual = 0x0040,
    /// <summary>
    /// <para>Specifies that the method hides by name and signature, rather than just by name.</para>
    /// </summary>
    mdHideBySig = 0x0080,
    /// <summary>
    /// <para>Specifies virtual table layout.</para>
    /// </summary>
    mdVtableLayoutMask = 0x0100,
    /// <summary>
    /// <para>Specifies that the slot used for this method in the virtual table be reused. This is the default.</para>
    /// </summary>
    mdReuseSlot = 0x0000,
    /// <summary>
    /// <para>Specifies that the method always gets a new slot in the virtual table.</para>
    /// </summary>
    mdNewSlot = 0x0100,
    /// <summary>
    /// <para>Specifies that the method can be overridden by the same types to which it is visible.</para>
    /// </summary>
    mdCheckAccessOnOverride = 0x0200,
    /// <summary>
    /// <para>Specifies that the method is not implemented.</para>
    /// </summary>
    mdAbstract = 0x0400,
    /// <summary>
    /// <para>Specifies that the method is special, and that its name describes how.</para>
    /// </summary>
    mdSpecialName = 0x0800,
    /// <summary>
    /// <para>Specifies that the method implementation is forwarded using PInvoke.</para>
    /// </summary>
    mdPinvokeImpl = 0x2000,
    /// <summary>
    /// <para>Specifies that the method is a managed method exported to unmanaged code.</para>
    /// </summary>
    mdUnmanagedExport = 0x0008,
    /// <summary>
    /// <para>Reserved for internal use by the common language runtime.</para>
    /// </summary>
    mdReservedMask = 0xd000,
    /// <summary>
    /// <para>Specifies that the common language runtime should check the encoding of the method name.</para>
    /// </summary>
    mdRTSpecialName = 0x1000,
    /// <summary>
    /// <para>Specifies that the method has security associated with it.</para>
    /// </summary>
    mdHasSecurity = 0x4000,
    /// <summary>
    /// <para>Specifies that the method calls another method containing security code.</para>
    /// </summary>
    mdRequireSecObject = 0x8000,
}
