// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains details about the operating system for an assembly or module.</para>
/// </summary>
/// <remarks>
/// <para><c>OSINFO</c> is based on the <c>OSVERSIONINFOEX</c> structure that is used in calls to the Microsoft Windows platform function <c>GetVersionEx</c>. This structure is used by the <c>ASSEMBLYMETADATA</c> structure to indicate its operating system support.</para>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/structures/osinfo-structure">Microsoft Learn</see>.</para>
/// </remarks>
public partial struct OSINFO
{
    /// <summary>
    /// <para>One of the identifier values defined by the Microsoft Windows platform function <c>GetVersionEx</c>. The following values are supported:<br/><br/> - VER_PLATFORM_WIN32s, or 0x0000, to specify Microsoft Windows 3.1.<br/>- VER_PLATFORM_WIN32_WINDOWS, or 0x0001, to specify Windows 95, Windows 98, or operating systems descended from them.<br/>- VER_PLATFORM_WIN32_NT, or 0x0002, to specify Windows NT or operating systems descended from it.</para>
    /// </summary>
    [NativeTypeName("DWORD")]
    public uint dwOSPlatformId;

    /// <summary>
    /// <para>The operating system major version, or a NULL value to indicate any version.</para>
    /// </summary>
    [NativeTypeName("DWORD")]
    public uint dwOSMajorVersion;

    /// <summary>
    /// <para>The operating system minor version, or a NULL value to indicate any version.</para>
    /// </summary>
    [NativeTypeName("DWORD")]
    public uint dwOSMinorVersion;
}
