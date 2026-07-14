// ReSharper disable InconsistentNaming
using System.Runtime.InteropServices;

namespace ICorDebugSharp.GeneratedMetadata;

[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_COR_ILMETHOD_SECT_EH
{
    [FieldOffset(0)]
    public IMAGE_COR_ILMETHOD_SECT_EH_SMALL Small;

    [FieldOffset(0)]
    public IMAGE_COR_ILMETHOD_SECT_EH_FAT Fat;
}
