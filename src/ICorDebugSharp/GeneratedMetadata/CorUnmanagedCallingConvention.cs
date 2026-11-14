// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

public enum CorUnmanagedCallingConvention
{
    C = 0x1,
    STDCALL = 0x2,
    THISCALL = 0x3,
    FASTCALL = 0x4,
}
