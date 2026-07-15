// ReSharper disable InconsistentNaming
using static ICorDebugSharp.GeneratedMetadata.CorUnmanagedCallingConvention;

namespace ICorDebugSharp.GeneratedMetadata;

public enum CorCallingConvention
{
    DEFAULT = 0x0,
    C = IMAGE_CEE_UNMANAGED_CALLCONV_C,
    STDCALL = IMAGE_CEE_UNMANAGED_CALLCONV_STDCALL,
    THISCALL = IMAGE_CEE_UNMANAGED_CALLCONV_THISCALL,
    FASTCALL = IMAGE_CEE_UNMANAGED_CALLCONV_FASTCALL,
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
