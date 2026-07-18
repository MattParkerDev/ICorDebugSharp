// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains information about the referenced assembly, including its version and its level of support for locales, processors, and operating systems.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/structures/assemblymetadata-structure">Microsoft Learn</see>.</para>
/// </remarks>
public unsafe partial struct ASSEMBLYMETADATA
{
    /// <summary>
    /// <para>The major version number of the referenced assembly. This value cannot be zero. If all the bits of <c>usMajorVersion</c> are set, the major version is not specified.</para>
    /// </summary>
    public ushort usMajorVersion;

    /// <summary>
    /// <para>The minor version number of the referenced assembly. This value cannot be zero. If all the bits of <c>usMinorVersion</c> are set, the minor version is not specified.</para>
    /// </summary>
    public ushort usMinorVersion;

    /// <summary>
    /// <para>The build number of the referenced assembly. This value cannot be zero. If all the bits of <c>usBuildNumber</c> are set, the build number is not specified.</para>
    /// </summary>
    public ushort usBuildNumber;

    /// <summary>
    /// <para>The revision number of the referenced assembly. This value cannot be zero. If all the bits of <c>usRevisionNumber</c> are set, the revision number is not specified.</para>
    /// </summary>
    public ushort usRevisionNumber;

    /// <summary>
    /// <para>A list of locale names conforming to the RFC1766 specification, separated by semicolons, specifying the locales supported by the referenced assembly. A null value indicates locale independence.</para>
    /// </summary>
    [NativeTypeName("LPWSTR")]
    public char* szLocale;

    /// <summary>
    /// <para>The size in wide characters of <c>szLocale</c>.</para>
    /// </summary>
    [NativeTypeName("ULONG")]
    public uint cbLocale;

    /// <summary>
    /// <para>An array of identifiers, as defined in Winnt.h, for the processor types that are supported by the referenced assembly. A NULL value indicates processor independence.</para>
    /// </summary>
    [NativeTypeName("DWORD *")]
    public uint* rProcessor;

    /// <summary>
    /// <para>The length of the <c>rdwProcessor</c> array.</para>
    /// </summary>
    [NativeTypeName("ULONG")]
    public uint ulProcessor;

    /// <summary>
    /// <para>An array of <see cref="OSINFO">OSINFO</see> instances specifying the operating systems that are supported by the referenced assembly. A NULL value indicates operating-system independence.</para>
    /// </summary>
    public OSINFO* rOS;

    /// <summary>
    /// <para>The length of the <c>rOS</c> array.</para>
    /// </summary>
    [NativeTypeName("ULONG")]
    public uint ulOS;
}
