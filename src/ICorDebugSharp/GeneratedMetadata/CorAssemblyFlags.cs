// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values that describe the metadata applied to an assembly compilation.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corassemblyflags-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorAssemblyFlags
{
    /// <summary>
    /// <para>Indicates that the assembly reference holds the full, unhashed public key.</para>
    /// </summary>
    afPublicKey = 0x0001,
    /// <summary>
    /// <para>Indicates that the processor architecture is unspecified.</para>
    /// </summary>
    afPA_None = 0x0000,
    /// <summary>
    /// <para>Indicates that the processor architecture is neutral (PE32).</para>
    /// </summary>
    afPA_MSIL = 0x0010,
    /// <summary>
    /// <para>Indicates that the processor architecture is x86 (PE32).</para>
    /// </summary>
    afPA_x86 = 0x0020,
    /// <summary>
    /// <para>Indicates that the processor architecture is Itanium (PE32+).</para>
    /// </summary>
    afPA_IA64 = 0x0030,
    /// <summary>
    /// <para>Indicates that the processor architecture is x86-64 (PE32+).</para>
    /// </summary>
    afPA_AMD64 = 0x0040,
    /// <summary>
    /// <para>Indicates that the processor architecture is ARM (PE32).</para>
    /// </summary>
    afPA_ARM = 0x0050,
    /// <summary>
    /// <para>Indicates that the processor architecture is ARM64 (PE32+).</para>
    /// </summary>
    afPA_ARM64 = 0x0060,
    /// <summary>
    /// <para>Indicates that the assembly is a reference assembly; that is, it applies to any architecture but cannot run on any architecture. Thus, the flag is the same as <c>afPA_Mask</c>.</para>
    /// </summary>
    afPA_NoPlatform = 0x0070,
    /// <summary>
    /// <para>Indicates that the processor architecture flags should be propagated to the <c>AssemblyRef</c> record.</para>
    /// </summary>
    afPA_Specified = 0x0080,
    /// <summary>
    /// <para>A mask that describes the processor architecture.</para>
    /// </summary>
    afPA_Mask = 0x0070,
    /// <summary>
    /// <para>Specifies that the processor architecture description is included.</para>
    /// </summary>
    afPA_FullMask = 0x00F0,
    /// <summary>
    /// <para>Indicates a shift count in the processor architecture flags to and from the index.</para>
    /// </summary>
    afPA_Shift = 0x0004,
    /// <summary>
    /// <para>Indicates the corresponding value from the  of the .</para>
    /// </summary>
    afEnableJITcompileTracking = 0x8000,
    /// <summary>
    /// <para>Indicates the corresponding value from the  of the .</para>
    /// </summary>
    afDisableJITcompileOptimizer = 0x4000,
    afDebuggableAttributeMask = 0xc000,
    /// <summary>
    /// <para>Indicates that the assembly can be retargeted at runtime to an assembly from a different publisher.</para>
    /// </summary>
    afRetargetable = 0x0100,
    /// <summary>
    /// <para>Indicates the default content type.</para>
    /// </summary>
    afContentType_Default = 0x0000,
    /// <summary>
    /// <para>Indicates the Windows Runtime content type.</para>
    /// </summary>
    afContentType_WindowsRuntime = 0x0200,
    /// <summary>
    /// <para>A mask that describes the content type.</para>
    /// </summary>
    afContentType_Mask = 0x0E00,
}
