// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

public partial struct _CLR_DEBUGGING_VERSION
{
    [NativeTypeName("WORD")]
    public ushort wStructVersion;

    [NativeTypeName("WORD")]
    public ushort wMajor;

    [NativeTypeName("WORD")]
    public ushort wMinor;

    [NativeTypeName("WORD")]
    public ushort wBuild;

    [NativeTypeName("WORD")]
    public ushort wRevision;
}
