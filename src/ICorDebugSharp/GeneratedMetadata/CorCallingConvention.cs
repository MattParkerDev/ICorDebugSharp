// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

public enum CorCallingConvention
{
    DEFAULT = 0x0,
    C = CorUnmanagedCallingConvention.C,
    STDCALL = CorUnmanagedCallingConvention.STDCALL,
    THISCALL = CorUnmanagedCallingConvention.THISCALL,
    FASTCALL = CorUnmanagedCallingConvention.FASTCALL,
    VARARG = 0x5,
    FIELD = 0x6,
    LOCAL_SIG = 0x7,
    PROPERTY = 0x8,
    UNMANAGED = 0x9,
    GENERICINST = 0xa,
    NATIVEVARARG = 0xb,
    ASYNC = 0xc,
    MAX = 0xd,
    MASK = 0x0f,
    HASTHIS = 0x20,
    EXPLICITTHIS = 0x40,
    GENERIC = 0x10,
}
