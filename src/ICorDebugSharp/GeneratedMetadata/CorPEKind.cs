// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values that describe a portable executable (PE) file, as returned from a call to <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/interfaces/imetadataimport2-getpekind-method">IMetaDataImport2::GetPEKind</see>.</para>
/// </summary>
/// <remarks>
/// <para>These values can be used in bitwise combinations.</para>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corpekind-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorPEKind
{
    /// <summary>
    /// <para>Indicates that this is not a PE file.</para>
    /// </summary>
    peNot = 0x00000000,
    /// <summary>
    /// <para>Indicates that this PE file contains only managed code.</para>
    /// </summary>
    peILonly = 0x00000001,
    /// <summary>
    /// <para>Indicates that this PE file makes Win32 calls.</para>
    /// </summary>
    pe32BitRequired = 0x00000002,
    /// <summary>
    /// <para>Indicates that this PE file runs on a 64-bit platform.</para>
    /// </summary>
    pe32Plus = 0x00000004,
    /// <summary>
    /// <para>Indicates that this PE file is native code.</para>
    /// </summary>
    pe32Unmanaged = 0x00000008,
    /// <summary>
    /// <para>Indicates that this PE file is platform-neutral and prefers to be loaded in a 32-bit environment.</para>
    /// </summary>
    pe32BitPreferred = 0x00000010,
}
