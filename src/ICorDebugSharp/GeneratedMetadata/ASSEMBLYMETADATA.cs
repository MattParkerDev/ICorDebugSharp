// ReSharper disable InconsistentNaming
namespace ICorDebugSharp.GeneratedMetadata;

public unsafe partial struct ASSEMBLYMETADATA
{
    public ushort usMajorVersion;

    public ushort usMinorVersion;

    public ushort usBuildNumber;

    public ushort usRevisionNumber;

    [NativeTypeName("LPWSTR")]
    public uint* szLocale;

    [NativeTypeName("ULONG")]
    public nuint cbLocale;

    [NativeTypeName("DWORD *")]
    public nuint* rProcessor;

    [NativeTypeName("ULONG")]
    public nuint ulProcessor;

    public OSINFO* rOS;

    [NativeTypeName("ULONG")]
    public nuint ulOS;
}
