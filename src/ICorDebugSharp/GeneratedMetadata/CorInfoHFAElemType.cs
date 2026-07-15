// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

[NativeTypeName("unsigned int")]
public enum CorInfoHFAElemType : uint
{
    NONE,
    FLOAT,
    DOUBLE,
    VECTOR64,
    VECTOR128,
}
