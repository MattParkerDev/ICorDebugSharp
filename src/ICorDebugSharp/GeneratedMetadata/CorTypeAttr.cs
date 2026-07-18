// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values that indicate type metadata.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/cortypeattr-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorTypeAttr
{
    /// <summary>
    /// <para>Used for type visibility information.</para>
    /// </summary>
    tdVisibilityMask = 0x00000007,
    /// <summary>
    /// <para>Specifies that the type is not in public scope.</para>
    /// </summary>
    tdNotPublic = 0x00000000,
    /// <summary>
    /// <para>Specifies that the type is in public scope.</para>
    /// </summary>
    tdPublic = 0x00000001,
    /// <summary>
    /// <para>Specifies that the type is nested with public visibility.</para>
    /// </summary>
    tdNestedPublic = 0x00000002,
    /// <summary>
    /// <para>Specifies that the type is nested with private visibility.</para>
    /// </summary>
    tdNestedPrivate = 0x00000003,
    /// <summary>
    /// <para>Specifies that the type is nested with family visibility.</para>
    /// </summary>
    tdNestedFamily = 0x00000004,
    /// <summary>
    /// <para>Specifies that the type is nested with assembly visibility.</para>
    /// </summary>
    tdNestedAssembly = 0x00000005,
    /// <summary>
    /// <para>Specifies that the type is nested with family and assembly visibility.</para>
    /// </summary>
    tdNestedFamANDAssem = 0x00000006,
    /// <summary>
    /// <para>Specifies that the type is nested with family or assembly visibility.</para>
    /// </summary>
    tdNestedFamORAssem = 0x00000007,
    /// <summary>
    /// <para>Gets layout information for the type.</para>
    /// </summary>
    tdLayoutMask = 0x00000018,
    /// <summary>
    /// <para>Specifies that the fields of this type are laid out automatically.</para>
    /// </summary>
    tdAutoLayout = 0x00000000,
    /// <summary>
    /// <para>Specifies that the fields of this type are laid out sequentially.</para>
    /// </summary>
    tdSequentialLayout = 0x00000008,
    /// <summary>
    /// <para>Specifies that field layout is supplied explicitly.</para>
    /// </summary>
    tdExplicitLayout = 0x00000010,
    tdExtendedLayout = 0x00000018,
    /// <summary>
    /// <para>Gets semantic information about the type.</para>
    /// </summary>
    tdClassSemanticsMask = 0x00000020,
    /// <summary>
    /// <para>Specifies that the type is a class.</para>
    /// </summary>
    tdClass = 0x00000000,
    /// <summary>
    /// <para>Specifies that the type is an interface.</para>
    /// </summary>
    tdInterface = 0x00000020,
    /// <summary>
    /// <para>Specifies that the type is abstract.</para>
    /// </summary>
    tdAbstract = 0x00000080,
    /// <summary>
    /// <para>Specifies that the type cannot be extended.</para>
    /// </summary>
    tdSealed = 0x00000100,
    /// <summary>
    /// <para>Specifies that the class name is special. Its name describes how.</para>
    /// </summary>
    tdSpecialName = 0x00000400,
    /// <summary>
    /// <para>Specifies that the type is imported.</para>
    /// </summary>
    tdImport = 0x00001000,
    /// <summary>
    /// <para>Specifies that the type is serializable.</para>
    /// </summary>
    tdSerializable = 0x00002000,
    /// <summary>
    /// <para>Specifies that this type is a Windows Runtime type.</para>
    /// </summary>
    tdWindowsRuntime = 0x00004000,
    /// <summary>
    /// <para>Gets information about how strings are encoded and formatted.</para>
    /// </summary>
    tdStringFormatMask = 0x00030000,
    /// <summary>
    /// <para>Specifies that this type interprets an LPTSTR as ANSI.</para>
    /// </summary>
    tdAnsiClass = 0x00000000,
    /// <summary>
    /// <para>Specifies that this type interprets an LPTSTR as Unicode.</para>
    /// </summary>
    tdUnicodeClass = 0x00010000,
    /// <summary>
    /// <para>Specifies that this type interprets an LPTSTR automatically.</para>
    /// </summary>
    tdAutoClass = 0x00020000,
    /// <summary>
    /// <para>Specifies that the type has a non-standard encoding, as specified by <c>CustomFormatMask</c>.</para>
    /// </summary>
    tdCustomFormatClass = 0x00030000,
    /// <summary>
    /// <para>Use this mask to get non-standard encoding information for native interop. The meaning of the values of these two bits is unspecified.</para>
    /// </summary>
    tdCustomFormatMask = 0x00C00000,
    /// <summary>
    /// <para>Specifies that the type must be initialized before the first attempt to access a static field.</para>
    /// </summary>
    tdBeforeFieldInit = 0x00100000,
    /// <summary>
    /// <para>Specifies that the type is exported, and a type forwarder.</para>
    /// </summary>
    tdForwarder = 0x00200000,
    /// <summary>
    /// <para>This flag and the flags below are used internally by the common language runtime.</para>
    /// </summary>
    tdReservedMask = 0x00040800,
    /// <summary>
    /// <para>Specifies that the common language runtime should check the name encoding.</para>
    /// </summary>
    tdRTSpecialName = 0x00000800,
    /// <summary>
    /// <para>Specifies that the type has security associated with it.</para>
    /// </summary>
    tdHasSecurity = 0x00040000,
}
