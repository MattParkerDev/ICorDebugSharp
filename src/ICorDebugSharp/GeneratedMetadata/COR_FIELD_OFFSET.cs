// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

public partial struct COR_FIELD_OFFSET
{
    [NativeTypeName("mdFieldDef")]
    public uint ridOfField;

    [NativeTypeName("uint32_t")]
    public uint ulOffset;
}
