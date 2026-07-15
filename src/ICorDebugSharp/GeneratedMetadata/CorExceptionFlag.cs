// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

public enum CorExceptionFlag
{
    NONE,
    FILTER = 0x0001,
    FINALLY = 0x0002,
    FAULT = 0x0004,
    DUPLICATED = 0x0008,
    SAMETRY = 0x0010,
    R2R_SYSTEM_EXCEPTION = 0x0020,
}
