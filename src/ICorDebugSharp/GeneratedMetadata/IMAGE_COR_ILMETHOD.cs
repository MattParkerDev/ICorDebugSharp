// ReSharper disable InconsistentNaming
using System.Runtime.InteropServices;

namespace ICorDebugSharp.GeneratedMetadata;

[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_COR_ILMETHOD
{
    [FieldOffset(0)]
    public IMAGE_COR_ILMETHOD_TINY Tiny;

    [FieldOffset(0)]
    public IMAGE_COR_ILMETHOD_FAT Fat;
}
