// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

public unsafe partial struct COR_SECATTR
{
    [NativeTypeName("mdMemberRef")]
    public uint tkCtor;

    [NativeTypeName("const void *")]
    public void* pCustomAttribute;

    [NativeTypeName("uint32_t")]
    public uint cbCustomAttribute;
}
