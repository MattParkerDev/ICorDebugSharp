// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

public enum CorSerializationType
{
    UNDEFINED = 0,
    BOOLEAN = CorElementType.BOOLEAN,
    CHAR = CorElementType.CHAR,
    I1 = CorElementType.I1,
    U1 = CorElementType.U1,
    I2 = CorElementType.I2,
    U2 = CorElementType.U2,
    I4 = CorElementType.I4,
    U4 = CorElementType.U4,
    I8 = CorElementType.I8,
    U8 = CorElementType.U8,
    R4 = CorElementType.R4,
    R8 = CorElementType.R8,
    STRING = CorElementType.STRING,
    SZARRAY = CorElementType.SZARRAY,
    TYPE = 0x50,
    TAGGED_OBJECT = 0x51,
    FIELD = 0x53,
    PROPERTY = 0x54,
    ENUM = 0x55,
}
