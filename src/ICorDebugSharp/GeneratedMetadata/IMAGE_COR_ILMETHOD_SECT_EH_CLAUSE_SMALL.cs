// ReSharper disable InconsistentNaming
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ICorDebugSharp.GeneratedMetadata;

public partial struct IMAGE_COR_ILMETHOD_SECT_EH_CLAUSE_SMALL
{
    public int _bitfield1;

    [NativeTypeName("CorExceptionFlag : 16")]
    public CorExceptionFlag Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (CorExceptionFlag)((_bitfield1 << 16) >> 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~0xFFFF) | ((int)(value) & 0xFFFF);
        }
    }

    [NativeTypeName("unsigned int : 16")]
    public uint TryOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (uint)((_bitfield1 >> 16) & 0xFFFF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0xFFFF << 16)) | (int)((value & 0xFFFFu) << 16);
        }
    }

    public uint _bitfield2;

    [NativeTypeName("unsigned int : 8")]
    public uint TryLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return _bitfield2 & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~0xFFu) | (value & 0xFFu);
        }
    }

    [NativeTypeName("unsigned int : 16")]
    public uint HandlerOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 >> 8) & 0xFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0xFFFFu << 8)) | ((value & 0xFFFFu) << 8);
        }
    }

    [NativeTypeName("unsigned int : 8")]
    public uint HandlerLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 >> 24) & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
        }
    }

    [NativeTypeName("__AnonymousRecord_corhdr_L1192_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint ClassToken
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ClassToken;
        }
    }

    [UnscopedRef]
    public ref uint FilterOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FilterOffset;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("uint32_t")]
        public uint ClassToken;

        [FieldOffset(0)]
        [NativeTypeName("uint32_t")]
        public uint FilterOffset;
    }
}
