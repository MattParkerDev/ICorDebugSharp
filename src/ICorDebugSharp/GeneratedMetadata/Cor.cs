// ReSharper disable InconsistentNaming
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static ICorDebugSharp.GeneratedMetadata.CorCallingConvention;
using static ICorDebugSharp.GeneratedMetadata.CorElementType;
using static ICorDebugSharp.GeneratedMetadata.CorTokenType;

namespace ICorDebugSharp.GeneratedMetadata;

public static unsafe partial class Cor
{
    [NativeTypeName("const IID")]
    public static ref readonly _GUID CLSID_CLR_v1_MetaData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xCA, 0x23, 0x50, 0x00,
                0xB1, 0x72,
                0xD3, 0x11,
                0x9F,
                0xC4,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0xA0,
                0xA3
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID CLSID_CLR_v2_MetaData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1A, 0x47, 0xEA, 0xEF,
                0xFD, 0x44,
                0x62, 0x48,
                0x92,
                0x92,
                0x0C,
                0x58,
                0xD4,
                0x6E,
                0x1F,
                0x3A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataCheckDuplicatesFor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE8, 0x7B, 0xFE, 0x30,
                0xD9, 0xD7,
                0xD2, 0x11,
                0x9F,
                0x80,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0xA0,
                0xA3
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataRefToDefCheck
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF8, 0x56, 0x38, 0xDE,
                0xD9, 0xD7,
                0xD2, 0x11,
                0x9F,
                0x80,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0xA0,
                0xA3
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataNotificationForTokenMovement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4C, 0x1A, 0xD7, 0xE5,
                0xDA, 0xD7,
                0xD2, 0x11,
                0x9F,
                0x80,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0xA0,
                0xA3
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataSetUpdate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5C, 0x31, 0xEE, 0x2E,
                0xDB, 0xD7,
                0xD2, 0x11,
                0x9F,
                0x80,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0xA0,
                0xA3
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataImportOption
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x36, 0x0F, 0x70, 0x79,
                0xAC, 0x4A,
                0xD3, 0x11,
                0x84,
                0xC3,
                0x00,
                0x90,
                0x27,
                0x86,
                0x8C,
                0xB1
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataThreadSafetyOptions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0x98, 0x55, 0xF7,
                0x66, 0xF2,
                0xEA, 0x42,
                0x8C,
                0x63,
                0x0A,
                0xDB,
                0x45,
                0xE8,
                0xB2,
                0x34
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataErrorIfEmitOutOfOrder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2D, 0x87, 0x47, 0x15,
                0x03, 0xDC,
                0xD2, 0x11,
                0x94,
                0x20,
                0x00,
                0x00,
                0xF8,
                0x08,
                0x34,
                0x60
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataGenerateTCEAdapters
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x90, 0xDE, 0xC9, 0xDC,
                0x51, 0x41,
                0xD3, 0x11,
                0x88,
                0xD6,
                0x00,
                0x90,
                0x27,
                0x54,
                0xC4,
                0x3A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataTypeLibImportNamespace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x89, 0xF8, 0x7F, 0xF1,
                0x63, 0x5A,
                0xD3, 0x11,
                0x9F,
                0xF2,
                0x00,
                0xC0,
                0x4F,
                0xF7,
                0x43,
                0x1A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataLinkerOptions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB6, 0x99, 0xE0, 0x47,
                0x7C, 0xAE,
                0x97, 0x47,
                0x83,
                0x17,
                0xB4,
                0x8A,
                0xA6,
                0x45,
                0xB8,
                0xF9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataRuntimeVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xB7, 0x99, 0xE0, 0x47,
                0x7C, 0xAE,
                0x97, 0x47,
                0x83,
                0x17,
                0xB4,
                0x8A,
                0xA6,
                0x45,
                0xB8,
                0xF9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataMergerOptions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x6E, 0x3A, 0x2D, 0x13,
                0x5D, 0xB3,
                0x4E, 0x46,
                0x95,
                0x1A,
                0x42,
                0xEF,
                0xB9,
                0xFB,
                0x66,
                0x01
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID MetaDataPreserveLocalRefs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x54, 0x03, 0x5C, 0xA5,
                0x1B, 0xE9,
                0x8B, 0x46,
                0x86,
                0x48,
                0x7C,
                0xC3,
                0x10,
                0x35,
                0xD5,
                0x33
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    public const int DESCR_GROUP_METHODDEF = 0;
    public const int DESCR_GROUP_METHODIMPL = 1;

    [NativeTypeName("const IID")]
    public static ref readonly _GUID CLSID_CorMetaDataDispenser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x31, 0x7A, 0xCB, 0xE5,
                0x12, 0x75,
                0xD2, 0x11,
                0x89,
                0xCE,
                0x00,
                0x80,
                0xC7,
                0x92,
                0xE5,
                0xD8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataError
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x71, 0xF1, 0x1F, 0xB8,
                0xF3, 0x20,
                0xD2, 0x11,
                0x8D,
                0xCC,
                0x00,
                0xA0,
                0xC9,
                0xB0,
                0x9C,
                0x19
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMapToken
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8B, 0xEA, 0xA3, 0x06,
                0x25, 0x02,
                0xD1, 0x11,
                0xBF,
                0x72,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x1E,
                0x12
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataDispenser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2E, 0x65, 0x9C, 0x80,
                0x96, 0x73,
                0xD2, 0x11,
                0x97,
                0x71,
                0x00,
                0xA0,
                0xC9,
                0xB4,
                0xD5,
                0x0C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataEmit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4C, 0xEE, 0x3F, 0xBA,
                0xB9, 0xEC,
                0x41, 0x4E,
                0x83,
                0xB7,
                0x18,
                0x3F,
                0xA4,
                0x1C,
                0xD8,
                0x59
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataEmit2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x50, 0x99, 0xDD, 0xF5,
                0x93, 0xF6,
                0xE6, 0x42,
                0x83,
                0x0E,
                0x7B,
                0x83,
                0x3E,
                0x81,
                0x46,
                0xA9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataImport
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x07, 0x82, 0xAC, 0x7D,
                0xAE, 0xD3,
                0x75, 0x4C,
                0x9B,
                0x67,
                0x92,
                0x80,
                0x1A,
                0x49,
                0x7D,
                0x44
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataImport2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA0, 0xEF, 0xE5, 0xFC,
                0xBA, 0x8B,
                0x8E, 0x4F,
                0xA0,
                0x36,
                0x8F,
                0x20,
                0x22,
                0xB0,
                0x84,
                0x66
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD1, 0x0D, 0xE8, 0xD0,
                0xD4, 0x12,
                0xD3, 0x11,
                0xB3,
                0x9D,
                0x00,
                0xC0,
                0x4F,
                0xF8,
                0x17,
                0x95
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IHostFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD3, 0x0D, 0xE8, 0xD0,
                0xD4, 0x12,
                0xD3, 0x11,
                0xB3,
                0x9D,
                0x00,
                0xC0,
                0x4F,
                0xF8,
                0x17,
                0x95
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataAssemblyEmit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5B, 0xF1, 0x1E, 0x21,
                0x17, 0x53,
                0x38, 0x44,
                0xB1,
                0x96,
                0xDE,
                0xC8,
                0x7B,
                0x88,
                0x76,
                0x93
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataAssemblyImport
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0x47, 0x62, 0xEE,
                0x4B, 0xE9,
                0x4E, 0x42,
                0x9B,
                0x7C,
                0x2F,
                0x00,
                0xC9,
                0x24,
                0x9F,
                0x93
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataValidate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0xC9, 0x09, 0x47,
                0xFF, 0x81,
                0xD3, 0x11,
                0x9F,
                0xC7,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0xA0,
                0xA3
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataDispenserEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE2, 0xFC, 0xBC, 0x31,
                0xFB, 0xDA,
                0xD2, 0x11,
                0x9F,
                0x81,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0xA0,
                0xA3
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataTables
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xAB, 0x79, 0xF5, 0xD8,
                0x2D, 0x40,
                0x8E, 0x4B,
                0x82,
                0xD9,
                0x5D,
                0x63,
                0xB1,
                0x06,
                0x5C,
                0x68
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataTables2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x70, 0x5F, 0xDB, 0xBA,
                0xDA, 0x58,
                0xA9, 0x43,
                0xA1,
                0xC6,
                0xD7,
                0x48,
                0x19,
                0xF1,
                0x9B,
                0x15
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly _GUID IID_IMetaDataInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x64, 0xEA, 0x98, 0x79,
                0x95, 0x7F,
                0xB8, 0x48,
                0x86,
                0xFC,
                0x17,
                0xCA,
                0xF4,
                0x8B,
                0xF5,
                0xCB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<_GUID>());
            return ref Unsafe.As<byte, _GUID>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static int CorIsPrimitiveType(CorElementType elementtype)
    {
        return (elementtype < (int)(ELEMENT_TYPE_PTR) || elementtype == ELEMENT_TYPE_I || elementtype == ELEMENT_TYPE_U) ? 1 : 0;
    }

    public static bool CorIsNumericalType(CorElementType elementType)
    {
        return ((elementType >= (int)(ELEMENT_TYPE_I1)) && (elementType <= (int)(ELEMENT_TYPE_R8))) || (elementType == ELEMENT_TYPE_I) || (elementType == ELEMENT_TYPE_U);
    }

    public static int CorIsModifierElementType(CorElementType elementtype)
    {
        if (elementtype == ELEMENT_TYPE_PTR || elementtype == ELEMENT_TYPE_BYREF)
        {
            return 1;
        }

        return (elementtype & (int)(ELEMENT_TYPE_MODIFIER));
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigUncompressedDataSize([NativeTypeName("PCCOR_SIGNATURE")] byte* pData)
    {
        if ((*pData & 0x80) == 0)
        {
            return 1;
        }
        else if ((*pData & 0xC0) == 0x80)
        {
            return 2;
        }
        else
        {
            return 4;
        }
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigUncompressBigData([NativeTypeName("PCCOR_SIGNATURE &")] byte** pData)
    {
        nuint res;

        if ((*pData & 0xC0) == 0x80)
        {
            res = (nuint)((*pData++ & 0x3f) << 8);
            res |= *pData++;
        }
        else
        {
            res = (*pData++ & 0x1f) << 24;
            res |= *pData++ << 16;
            res |= *pData++ << 8;
            res |= *pData++;
        }

        return res;
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigUncompressData([NativeTypeName("PCCOR_SIGNATURE &")] byte** pData)
    {
        if ((*pData & 0x80) == 0x00)
        {
            return *pData++;
        }

        return CorSigUncompressBigData(pData);
    }

    [return: NativeTypeName("HRESULT")]
    public static nint CorSigUncompressData([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, [NativeTypeName("DWORD")] nuint len, [NativeTypeName("uint32_t *")] uint* pDataOut, [NativeTypeName("uint32_t *")] uint* pDataLen)
    {
        nint hr = ((nint)(0));
        byte* pBytes = (byte*)(pData);

        if ((*pBytes & 0x80) == 0x00)
        {
            if (len < 1)
            {
                *pDataOut = 0;
                *pDataLen = 0;
                hr = unchecked((nint)(((nuint)(1) << 31) | ((nuint)(19) << 16) | ((nuint)(0x1192))));
            }
            else
            {
                *pDataOut = *pBytes;
                *pDataLen = 1;
            }
        }
        else if ((*pBytes & 0xC0) == 0x80)
        {
            if (len < 2)
            {
                *pDataOut = 0;
                *pDataLen = 0;
                hr = unchecked((nint)(((nuint)(1) << 31) | ((nuint)(19) << 16) | ((nuint)(0x1192))));
            }
            else
            {
                *pDataOut = (uint)(((*pBytes & 0x3f) << 8 | *(pBytes + 1)));
                *pDataLen = 2;
            }
        }
        else if ((*pBytes & 0xE0) == 0xC0)
        {
            if (len < 4)
            {
                *pDataOut = 0;
                *pDataLen = 0;
                hr = unchecked((nint)(((nuint)(1) << 31) | ((nuint)(19) << 16) | ((nuint)(0x1192))));
            }
            else
            {
                *pDataOut = (uint)(((*pBytes & 0x1f) << 24 | *(pBytes + 1) << 16 | *(pBytes + 2) << 8 | *(pBytes + 3)));
                *pDataLen = 4;
            }
        }
        else
        {
            *pDataOut = 0;
            *pDataLen = 0;
            hr = unchecked((nint)(((nuint)(1) << 31) | ((nuint)(19) << 16) | ((nuint)(0x1192))));
        }

        return hr;
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigUncompressData([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, [NativeTypeName("ULONG *")] nuint* pDataOut)
    {
        nuint dwSizeOfData = 0;

        if ((((nint)(CorSigUncompressData(pData, 0xff, (uint*)(pDataOut), (uint*)(&dwSizeOfData)))) < 0))
        {
            *pDataOut = 0;
            return (nuint)(unchecked(-1));
        }

        return dwSizeOfData;
    }

    [return: NativeTypeName("mdToken")]
    public static uint CorSigDecodeTokenType(int encoded)
    {
        uint[] s_tableTokenTypes = new uint[4]
        {
            (uint)(mdtTypeDef),
            (uint)(mdtTypeRef),
            (uint)(mdtTypeSpec),
            (uint)(mdtBaseType),
        };

        return s_tableTokenTypes[encoded];
    }

    [return: NativeTypeName("mdToken")]
    public static uint CorSigUncompressToken([NativeTypeName("PCCOR_SIGNATURE &")] byte** pData)
    {
        uint tk;
        uint tkType;

        tk = CorSigUncompressData(pData);
        tkType = CorSigDecodeTokenType(tk & 0x3);
        tk = ((tk >> 2) | (tkType));
        return tk;
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigUncompressToken([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, [NativeTypeName("mdToken *")] uint* pToken)
    {
        nuint cb;
        uint tk;
        uint tkType;

        cb = CorSigUncompressData(pData, (nuint*)(&tk));
        tkType = CorSigDecodeTokenType(tk & 0x3);
        tk = ((tk >> 2) | (tkType));
        *pToken = tk;
        return cb;
    }

    [return: NativeTypeName("HRESULT")]
    public static nint CorSigUncompressToken([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, [NativeTypeName("uint32_t")] uint dwLen, [NativeTypeName("mdToken *")] uint* pToken, [NativeTypeName("uint32_t *")] uint* dwTokenLength)
    {
        uint tk;
        uint tkType;
        nint hr = CorSigUncompressData(pData, dwLen, unchecked((uint*)(&tk)), dwTokenLength);

        if ((((nint)(hr)) >= 0))
        {
            tkType = CorSigDecodeTokenType(tk & 0x3);
            tk = ((tk >> 2) | (tkType));
            *pToken = tk;
        }
        else
        {
            *pToken = ((uint)(0));
        }

        return hr;
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigUncompressCallingConv([NativeTypeName("PCCOR_SIGNATURE &")] byte** pData)
    {
        return *pData++;
    }

    [return: NativeTypeName("HRESULT")]
    public static nint CorSigUncompressCallingConv([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, [NativeTypeName("DWORD")] nuint dwLen, [NativeTypeName("uint32_t *")] uint* data)
    {
        if (dwLen > 0)
        {
            *data = *pData;
            return ((nint)(0));
        }
        else
        {
            *data = 0;
            return (unchecked((nint)(((nuint)(1) << 31) | ((nuint)(19) << 16) | ((nuint)(0x1192)))));
        }
    }

    public const int SIGN_MASK_ONEBYTE = unchecked((int)(0xffffffc0));
    public const int SIGN_MASK_TWOBYTE = unchecked((int)(0xffffe000));
    public const int SIGN_MASK_FOURBYTE = unchecked((int)(0xf0000000));

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigUncompressSignedInt([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, int* pInt)
    {
        nuint cb;
        nuint ulSigned;
        nuint iData;

        cb = CorSigUncompressData(pData, &iData);
        if (cb == unchecked((nuint)(-1)))
        {
            return cb;
        }

        ulSigned = iData & 0x1;
        iData = iData >> 1;
        if ((ulSigned) != 0)
        {
            if (cb == 1)
            {
                iData |= (nuint)(SIGN_MASK_ONEBYTE);
            }
            else if (cb == 2)
            {
                iData |= (nuint)(SIGN_MASK_TWOBYTE);
            }
            else
            {
                iData |= (nuint)(SIGN_MASK_FOURBYTE);
            }
        }

        *pInt = (int)(iData);
        return cb;
    }

    public static CorElementType CorSigUncompressElementType([NativeTypeName("PCCOR_SIGNATURE &")] byte** pData)
    {
        return (CorElementType)(*pData++);
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigUncompressElementType([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, CorElementType* pElementType)
    {
        *pElementType = (CorElementType)(*pData & 0x7f);
        return 1;
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigCompressData([NativeTypeName("ULONG")] nuint iLen, void* pDataOut)
    {
        byte* pBytes = (byte*)(pDataOut);

        if (iLen <= 0x7F)
        {
            *pBytes = (byte)(iLen);
            return 1;
        }

        if (iLen <= 0x3FFF)
        {
            *pBytes = (byte)((iLen >> 8) | 0x80);
            *(pBytes + 1) = (byte)(iLen & 0xff);
            return 2;
        }

        if (iLen <= 0x1FFFFFFF)
        {
            *pBytes = (byte)((iLen >> 24) | 0xC0);
            *(pBytes + 1) = (byte)((iLen >> 16) & 0xff);
            *(pBytes + 2) = (byte)((iLen >> 8) & 0xff);
            *(pBytes + 3) = (byte)(iLen & 0xff);
            return 4;
        }

        return (nuint)(unchecked(-1));
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigCompressToken([NativeTypeName("mdToken")] uint tk, void* pDataOut)
    {
        uint rid = ((uint)((tk) & 0x00ffffff));
        uint ulTyp = ((uint)((tk) & 0xff000000));

        if (unchecked(rid) > 0x3FFFFFF)
        {
            return (nuint)(unchecked(-1));
        }

        rid = (rid << 2);
        if (unchecked(ulTyp) == CorSigDecodeTokenType(1))
        {
            rid |= 0x1;
        }
        else if (unchecked(ulTyp) == CorSigDecodeTokenType(2))
        {
            rid |= 0x2;
        }
        else if (unchecked(ulTyp) == CorSigDecodeTokenType(3))
        {
            rid |= 0x3;
        }

        return CorSigCompressData((nuint)(rid), pDataOut);
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigCompressSignedInt(int iData, void* pDataOut)
    {
        nuint isSigned = 0;
        byte* pBytes = (byte*)(pDataOut);

        if (iData < 0)
        {
            isSigned = 0x1;
        }

        if ((iData & (int)(SIGN_MASK_ONEBYTE)) == 0 || (iData & (int)(SIGN_MASK_ONEBYTE)) == SIGN_MASK_ONEBYTE)
        {
            iData = (int)(unchecked((iData & ~(int)(SIGN_MASK_ONEBYTE)) << 1 | isSigned));
            *pBytes = (byte)(iData);
            return 1;
        }
        else if ((iData & (int)(SIGN_MASK_TWOBYTE)) == 0 || (iData & (int)(SIGN_MASK_TWOBYTE)) == SIGN_MASK_TWOBYTE)
        {
            iData = (int)(unchecked((iData & ~(int)(SIGN_MASK_TWOBYTE)) << 1 | isSigned));
            *pBytes = (byte)((iData >> 8) | 0x80);
            *(pBytes + 1) = (byte)(iData & 0xff);
            return 2;
        }
        else if ((iData & (int)(SIGN_MASK_FOURBYTE)) == 0 || (iData & (int)(SIGN_MASK_FOURBYTE)) == SIGN_MASK_FOURBYTE)
        {
            iData = (int)(unchecked((iData & ~(int)(SIGN_MASK_FOURBYTE)) << 1 | isSigned));
            *pBytes = (byte)((iData >> 24) | 0xC0);
            *(pBytes + 1) = (byte)((iData >> 16) & 0xff);
            *(pBytes + 2) = (byte)((iData >> 8) & 0xff);
            *(pBytes + 3) = (byte)(iData & 0xff);
            return 4;
        }

        return (nuint)(unchecked(-1));
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigCompressElementType(CorElementType et, void* pData)
    {
        byte* pBytes = (byte*)(pData);

        *pBytes = (byte)(et);
        return 1;
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigCompressPointer(void* pvPointer, void* pData)
    {
        *((void**)(pData)) = pvPointer;
        return sizeof(void*);
    }

    [return: NativeTypeName("ULONG")]
    public static nuint CorSigUncompressPointer([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, void** ppvPointer)
    {
        *ppvPointer = *(void**)(pData);
        return sizeof(void*);
    }

    [NativeTypeName("#define CLSID_CorMetaDataRuntime CLSID_CLR_v2_MetaData")]
    public static ref readonly _GUID CLSID_CorMetaDataRuntime => ref CLSID_CLR_v2_MetaData;

    [NativeTypeName("#define MetaDataSetENC MetaDataSetUpdate")]
    public static ref readonly _GUID MetaDataSetENC => ref MetaDataSetUpdate;

    [NativeTypeName("#define INVALID_CONNECTION_ID 0x0")]
    public const int INVALID_CONNECTION_ID = 0x0;

    [NativeTypeName("#define INVALID_TASK_ID 0x0")]
    public const int INVALID_TASK_ID = 0x0;

    [NativeTypeName("#define MAX_CONNECTION_NAME MAX_PATH")]
    public const int MAX_CONNECTION_NAME = 260;

    [NativeTypeName("#define MAIN_CLR_MODULE_NAME_A \"coreclr\"")]
    public static ReadOnlySpan<byte> MAIN_CLR_MODULE_NAME_A => "coreclr"u8;

    [NativeTypeName("#define MAIN_CLR_DLL_NAME_W MAKEDLLNAME_W(MAIN_CLR_MODULE_NAME_W)")]
    public static ref readonly <dependent type> MAIN_CLR_DLL_NAME_W
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
    MAKEDLLNAME_W()    }
    }

    [NativeTypeName("#define TARGET_MAIN_CLR_DLL_NAME_W MAKE_TARGET_DLLNAME_W(MAIN_CLR_MODULE_NAME_W)")]
    public static ref readonly <dependent type> TARGET_MAIN_CLR_DLL_NAME_W
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
    MAKE_TARGET_DLLNAME_W()    }
    }

    [NativeTypeName("#define COR_CTOR_METHOD_NAME \".ctor\"")]
    public static ReadOnlySpan<byte> COR_CTOR_METHOD_NAME => ".ctor"u8;

    [NativeTypeName("#define COR_CCTOR_METHOD_NAME \".cctor\"")]
    public static ReadOnlySpan<byte> COR_CCTOR_METHOD_NAME => ".cctor"u8;

    [NativeTypeName("#define COR_ENUM_FIELD_NAME \"value__\"")]
    public static ReadOnlySpan<byte> COR_ENUM_FIELD_NAME => "value__"u8;

    [NativeTypeName("#define COR_DELETED_NAME_A \"_Deleted\"")]
    public static ReadOnlySpan<byte> COR_DELETED_NAME_A => "_Deleted"u8;

    [NativeTypeName("#define COR_VTABLEGAP_NAME_A \"_VtblGap\"")]
    public static ReadOnlySpan<byte> COR_VTABLEGAP_NAME_A => "_VtblGap"u8;

    [NativeTypeName("#define IMAGE_CEE_CS_CALLCONV_INSTANTIATION IMAGE_CEE_CS_CALLCONV_GENERICINST")]
    public const CorCallingConvention IMAGE_CEE_CS_CALLCONV_INSTANTIATION = IMAGE_CEE_CS_CALLCONV_GENERICINST;

    [NativeTypeName("#define mdTokenNil ((mdToken)0)")]
    public const uint mdTokenNil = ((uint)(0));

    [NativeTypeName("#define mdModuleNil ((mdModule)mdtModule)")]
    public const uint mdModuleNil = ((uint)(mdtModule));

    [NativeTypeName("#define mdTypeRefNil ((mdTypeRef)mdtTypeRef)")]
    public const uint mdTypeRefNil = ((uint)(mdtTypeRef));

    [NativeTypeName("#define mdTypeDefNil ((mdTypeDef)mdtTypeDef)")]
    public const uint mdTypeDefNil = ((uint)(mdtTypeDef));

    [NativeTypeName("#define mdFieldDefNil ((mdFieldDef)mdtFieldDef)")]
    public const uint mdFieldDefNil = ((uint)(mdtFieldDef));

    [NativeTypeName("#define mdMethodDefNil ((mdMethodDef)mdtMethodDef)")]
    public const uint mdMethodDefNil = ((uint)(mdtMethodDef));

    [NativeTypeName("#define mdParamDefNil ((mdParamDef)mdtParamDef)")]
    public const uint mdParamDefNil = ((uint)(mdtParamDef));

    [NativeTypeName("#define mdInterfaceImplNil ((mdInterfaceImpl)mdtInterfaceImpl)")]
    public const uint mdInterfaceImplNil = ((uint)(mdtInterfaceImpl));

    [NativeTypeName("#define mdMemberRefNil ((mdMemberRef)mdtMemberRef)")]
    public const uint mdMemberRefNil = ((uint)(mdtMemberRef));

    [NativeTypeName("#define mdCustomAttributeNil ((mdCustomAttribute)mdtCustomAttribute)")]
    public const uint mdCustomAttributeNil = ((uint)(mdtCustomAttribute));

    [NativeTypeName("#define mdPermissionNil ((mdPermission)mdtPermission)")]
    public const uint mdPermissionNil = ((uint)(mdtPermission));

    [NativeTypeName("#define mdSignatureNil ((mdSignature)mdtSignature)")]
    public const uint mdSignatureNil = ((uint)(mdtSignature));

    [NativeTypeName("#define mdEventNil ((mdEvent)mdtEvent)")]
    public const uint mdEventNil = ((uint)(mdtEvent));

    [NativeTypeName("#define mdPropertyNil ((mdProperty)mdtProperty)")]
    public const uint mdPropertyNil = ((uint)(mdtProperty));

    [NativeTypeName("#define mdModuleRefNil ((mdModuleRef)mdtModuleRef)")]
    public const uint mdModuleRefNil = ((uint)(mdtModuleRef));

    [NativeTypeName("#define mdTypeSpecNil ((mdTypeSpec)mdtTypeSpec)")]
    public const uint mdTypeSpecNil = ((uint)(mdtTypeSpec));

    [NativeTypeName("#define mdAssemblyNil ((mdAssembly)mdtAssembly)")]
    public const uint mdAssemblyNil = ((uint)(mdtAssembly));

    [NativeTypeName("#define mdAssemblyRefNil ((mdAssemblyRef)mdtAssemblyRef)")]
    public const uint mdAssemblyRefNil = ((uint)(mdtAssemblyRef));

    [NativeTypeName("#define mdFileNil ((mdFile)mdtFile)")]
    public const uint mdFileNil = ((uint)(mdtFile));

    [NativeTypeName("#define mdExportedTypeNil ((mdExportedType)mdtExportedType)")]
    public const uint mdExportedTypeNil = ((uint)(mdtExportedType));

    [NativeTypeName("#define mdManifestResourceNil ((mdManifestResource)mdtManifestResource)")]
    public const uint mdManifestResourceNil = ((uint)(mdtManifestResource));

    [NativeTypeName("#define mdGenericParamNil ((mdGenericParam)mdtGenericParam)")]
    public const uint mdGenericParamNil = ((uint)(mdtGenericParam));

    [NativeTypeName("#define mdGenericParamConstraintNil ((mdGenericParamConstraint)mdtGenericParamConstraint)")]
    public const uint mdGenericParamConstraintNil = ((uint)(mdtGenericParamConstraint));

    [NativeTypeName("#define mdMethodSpecNil ((mdMethodSpec)mdtMethodSpec)")]
    public const uint mdMethodSpecNil = ((uint)(mdtMethodSpec));

    [NativeTypeName("#define mdStringNil ((mdString)mdtString)")]
    public const uint mdStringNil = ((uint)(mdtString));

    [NativeTypeName("#define IMAGE_CEE_CS_CALLCONV_DEFAULT_HASTHIS (IMAGE_CEE_CS_CALLCONV_DEFAULT | IMAGE_CEE_CS_CALLCONV_HASTHIS)")]
    public const int IMAGE_CEE_CS_CALLCONV_DEFAULT_HASTHIS = ((int)(IMAGE_CEE_CS_CALLCONV_DEFAULT) | (int)(IMAGE_CEE_CS_CALLCONV_HASTHIS));

    [NativeTypeName("#define INTEROP_DISPID_TYPE \"System.Runtime.InteropServices.DispIdAttribute\"")]
    public static ReadOnlySpan<byte> INTEROP_DISPID_TYPE => "System.Runtime.InteropServices.DispIdAttribute"u8;

    [NativeTypeName("#define INTEROP_INTERFACETYPE_TYPE \"System.Runtime.InteropServices.InterfaceTypeAttribute\"")]
    public static ReadOnlySpan<byte> INTEROP_INTERFACETYPE_TYPE => "System.Runtime.InteropServices.InterfaceTypeAttribute"u8;

    [NativeTypeName("#define INTEROP_GUID_TYPE \"System.Runtime.InteropServices.GuidAttribute\"")]
    public static ReadOnlySpan<byte> INTEROP_GUID_TYPE => "System.Runtime.InteropServices.GuidAttribute"u8;

    [NativeTypeName("#define INTEROP_TYPELIBVERSION_TYPE \"System.Runtime.InteropServices.TypeLibVersionAttribute\"")]
    public static ReadOnlySpan<byte> INTEROP_TYPELIBVERSION_TYPE => "System.Runtime.InteropServices.TypeLibVersionAttribute"u8;

    [NativeTypeName("#define INTEROP_COMEVENTINTERFACE_TYPE \"System.Runtime.InteropServices.ComEventInterfaceAttribute\"")]
    public static ReadOnlySpan<byte> INTEROP_COMEVENTINTERFACE_TYPE => "System.Runtime.InteropServices.ComEventInterfaceAttribute"u8;

    [NativeTypeName("#define FRIEND_ASSEMBLY_TYPE \"System.Runtime.CompilerServices.InternalsVisibleToAttribute\"")]
    public static ReadOnlySpan<byte> FRIEND_ASSEMBLY_TYPE => "System.Runtime.CompilerServices.InternalsVisibleToAttribute"u8;

    [NativeTypeName("#define FRIEND_ASSEMBLY_TYPE_NAMESPACE \"System.Runtime.CompilerServices\"")]
    public static ReadOnlySpan<byte> FRIEND_ASSEMBLY_TYPE_NAMESPACE => "System.Runtime.CompilerServices"u8;

    [NativeTypeName("#define FRIEND_ASSEMBLY_TYPE_NAME \"InternalsVisibleToAttribute\"")]
    public static ReadOnlySpan<byte> FRIEND_ASSEMBLY_TYPE_NAME => "InternalsVisibleToAttribute"u8;

    [NativeTypeName("#define SUBJECT_ASSEMBLY_TYPE \"System.Runtime.CompilerServices.IgnoresAccessChecksToAttribute\"")]
    public static ReadOnlySpan<byte> SUBJECT_ASSEMBLY_TYPE => "System.Runtime.CompilerServices.IgnoresAccessChecksToAttribute"u8;

    [NativeTypeName("#define SUBJECT_ASSEMBLY_TYPE_NAMESPACE \"System.Runtime.CompilerServices\"")]
    public static ReadOnlySpan<byte> SUBJECT_ASSEMBLY_TYPE_NAMESPACE => "System.Runtime.CompilerServices"u8;

    [NativeTypeName("#define SUBJECT_ASSEMBLY_TYPE_NAME \"IgnoresAccessChecksToAttribute\"")]
    public static ReadOnlySpan<byte> SUBJECT_ASSEMBLY_TYPE_NAME => "IgnoresAccessChecksToAttribute"u8;

    [NativeTypeName("#define DEFAULTDOMAIN_STA_TYPE \"System.STAThreadAttribute\"")]
    public static ReadOnlySpan<byte> DEFAULTDOMAIN_STA_TYPE => "System.STAThreadAttribute"u8;

    [NativeTypeName("#define DEFAULTDOMAIN_MTA_TYPE \"System.MTAThreadAttribute\"")]
    public static ReadOnlySpan<byte> DEFAULTDOMAIN_MTA_TYPE => "System.MTAThreadAttribute"u8;

    [NativeTypeName("#define DEBUGGABLE_ATTRIBUTE_TYPE \"System.Diagnostics.DebuggableAttribute\"")]
    public static ReadOnlySpan<byte> DEBUGGABLE_ATTRIBUTE_TYPE => "System.Diagnostics.DebuggableAttribute"u8;

    [NativeTypeName("#define DEBUGGABLE_ATTRIBUTE_TYPE_NAMESPACE \"System.Diagnostics\"")]
    public static ReadOnlySpan<byte> DEBUGGABLE_ATTRIBUTE_TYPE_NAMESPACE => "System.Diagnostics"u8;

    [NativeTypeName("#define DEBUGGABLE_ATTRIBUTE_TYPE_NAME \"DebuggableAttribute\"")]
    public static ReadOnlySpan<byte> DEBUGGABLE_ATTRIBUTE_TYPE_NAME => "DebuggableAttribute"u8;

    [NativeTypeName("#define RUNTIMECOMPATIBILITY_TYPE \"System.Runtime.CompilerServices.RuntimeCompatibilityAttribute\"")]
    public static ReadOnlySpan<byte> RUNTIMECOMPATIBILITY_TYPE => "System.Runtime.CompilerServices.RuntimeCompatibilityAttribute"u8;

    [NativeTypeName("#define RUNTIMECOMPATIBILITY_TYPE_NAMESPACE \"System.Runtime.CompilerServices\"")]
    public static ReadOnlySpan<byte> RUNTIMECOMPATIBILITY_TYPE_NAMESPACE => "System.Runtime.CompilerServices"u8;

    [NativeTypeName("#define RUNTIMECOMPATIBILITY_TYPE_NAME \"RuntimeCompatibilityAttribute\"")]
    public static ReadOnlySpan<byte> RUNTIMECOMPATIBILITY_TYPE_NAME => "RuntimeCompatibilityAttribute"u8;

    [NativeTypeName("#define CMOD_CALLCONV_NAMESPACE_OLD \"System.Runtime.InteropServices\"")]
    public static ReadOnlySpan<byte> CMOD_CALLCONV_NAMESPACE_OLD => "System.Runtime.InteropServices"u8;

    [NativeTypeName("#define CMOD_CALLCONV_NAMESPACE \"System.Runtime.CompilerServices\"")]
    public static ReadOnlySpan<byte> CMOD_CALLCONV_NAMESPACE => "System.Runtime.CompilerServices"u8;

    [NativeTypeName("#define CMOD_CALLCONV_NAME_CDECL \"CallConvCdecl\"")]
    public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_CDECL => "CallConvCdecl"u8;

    [NativeTypeName("#define CMOD_CALLCONV_NAME_STDCALL \"CallConvStdcall\"")]
    public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_STDCALL => "CallConvStdcall"u8;

    [NativeTypeName("#define CMOD_CALLCONV_NAME_THISCALL \"CallConvThiscall\"")]
    public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_THISCALL => "CallConvThiscall"u8;

    [NativeTypeName("#define CMOD_CALLCONV_NAME_FASTCALL \"CallConvFastcall\"")]
    public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_FASTCALL => "CallConvFastcall"u8;

    [NativeTypeName("#define CMOD_CALLCONV_NAME_SWIFT \"CallConvSwift\"")]
    public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_SWIFT => "CallConvSwift"u8;

    [NativeTypeName("#define CMOD_CALLCONV_NAME_SUPPRESSGCTRANSITION \"CallConvSuppressGCTransition\"")]
    public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_SUPPRESSGCTRANSITION => "CallConvSuppressGCTransition"u8;

    [NativeTypeName("#define CMOD_CALLCONV_NAME_MEMBERFUNCTION \"CallConvMemberFunction\"")]
    public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_MEMBERFUNCTION => "CallConvMemberFunction"u8;

    [NativeTypeName("#define COR_BASE_SECURITY_ATTRIBUTE_CLASS L\"System.Security.Permissions.SecurityAttribute\"")]
    public static ReadOnlySpan<uint> COR_BASE_SECURITY_ATTRIBUTE_CLASS => [0x00000053, 0x00000079, 0x00000073, 0x00000074, 0x00000065, 0x0000006D, 0x0000002E, 0x00000053, 0x00000065, 0x00000063, 0x00000075, 0x00000072, 0x00000069, 0x00000074, 0x00000079, 0x0000002E, 0x00000050, 0x00000065, 0x00000072, 0x0000006D, 0x00000069, 0x00000073, 0x00000073, 0x00000069, 0x0000006F, 0x0000006E, 0x00000073, 0x0000002E, 0x00000053, 0x00000065, 0x00000063, 0x00000075, 0x00000072, 0x00000069, 0x00000074, 0x00000079, 0x00000041, 0x00000074, 0x00000074, 0x00000072, 0x00000069, 0x00000062, 0x00000075, 0x00000074, 0x00000065, 0x00000000];

    [NativeTypeName("#define COR_BASE_SECURITY_ATTRIBUTE_CLASS_ANSI \"System.Security.Permissions.SecurityAttribute\"")]
    public static ReadOnlySpan<byte> COR_BASE_SECURITY_ATTRIBUTE_CLASS_ANSI => "System.Security.Permissions.SecurityAttribute"u8;

    [NativeTypeName("#define COR_SUPPRESS_UNMANAGED_CODE_CHECK_ATTRIBUTE L\"System.Security.SuppressUnmanagedCodeSecurityAttribute\"")]
    public static ReadOnlySpan<uint> COR_SUPPRESS_UNMANAGED_CODE_CHECK_ATTRIBUTE => [0x00000053, 0x00000079, 0x00000073, 0x00000074, 0x00000065, 0x0000006D, 0x0000002E, 0x00000053, 0x00000065, 0x00000063, 0x00000075, 0x00000072, 0x00000069, 0x00000074, 0x00000079, 0x0000002E, 0x00000053, 0x00000075, 0x00000070, 0x00000070, 0x00000072, 0x00000065, 0x00000073, 0x00000073, 0x00000055, 0x0000006E, 0x0000006D, 0x00000061, 0x0000006E, 0x00000061, 0x00000067, 0x00000065, 0x00000064, 0x00000043, 0x0000006F, 0x00000064, 0x00000065, 0x00000053, 0x00000065, 0x00000063, 0x00000075, 0x00000072, 0x00000069, 0x00000074, 0x00000079, 0x00000041, 0x00000074, 0x00000074, 0x00000072, 0x00000069, 0x00000062, 0x00000075, 0x00000074, 0x00000065, 0x00000000];

    [NativeTypeName("#define COR_SUPPRESS_UNMANAGED_CODE_CHECK_ATTRIBUTE_ANSI \"System.Security.SuppressUnmanagedCodeSecurityAttribute\"")]
    public static ReadOnlySpan<byte> COR_SUPPRESS_UNMANAGED_CODE_CHECK_ATTRIBUTE_ANSI => "System.Security.SuppressUnmanagedCodeSecurityAttribute"u8;

    [NativeTypeName("#define COR_UNVER_CODE_ATTRIBUTE L\"System.Security.UnverifiableCodeAttribute\"")]
    public static ReadOnlySpan<uint> COR_UNVER_CODE_ATTRIBUTE => [0x00000053, 0x00000079, 0x00000073, 0x00000074, 0x00000065, 0x0000006D, 0x0000002E, 0x00000053, 0x00000065, 0x00000063, 0x00000075, 0x00000072, 0x00000069, 0x00000074, 0x00000079, 0x0000002E, 0x00000055, 0x0000006E, 0x00000076, 0x00000065, 0x00000072, 0x00000069, 0x00000066, 0x00000069, 0x00000061, 0x00000062, 0x0000006C, 0x00000065, 0x00000043, 0x0000006F, 0x00000064, 0x00000065, 0x00000041, 0x00000074, 0x00000074, 0x00000072, 0x00000069, 0x00000062, 0x00000075, 0x00000074, 0x00000065, 0x00000000];

    [NativeTypeName("#define COR_UNVER_CODE_ATTRIBUTE_ANSI \"System.Security.UnverifiableCodeAttribute\"")]
    public static ReadOnlySpan<byte> COR_UNVER_CODE_ATTRIBUTE_ANSI => "System.Security.UnverifiableCodeAttribute"u8;

    [NativeTypeName("#define COR_REQUIRES_SECOBJ_ATTRIBUTE_ANSI \"System.Security.DynamicSecurityMethodAttribute\"")]
    public static ReadOnlySpan<byte> COR_REQUIRES_SECOBJ_ATTRIBUTE_ANSI => "System.Security.DynamicSecurityMethodAttribute"u8;

    [NativeTypeName("#define COR_COMPILERSERVICE_DISCARDABLEATTRIBUTE L\"System.Runtime.CompilerServices.DiscardableAttribute\"")]
    public static ReadOnlySpan<uint> COR_COMPILERSERVICE_DISCARDABLEATTRIBUTE => [0x00000053, 0x00000079, 0x00000073, 0x00000074, 0x00000065, 0x0000006D, 0x0000002E, 0x00000052, 0x00000075, 0x0000006E, 0x00000074, 0x00000069, 0x0000006D, 0x00000065, 0x0000002E, 0x00000043, 0x0000006F, 0x0000006D, 0x00000070, 0x00000069, 0x0000006C, 0x00000065, 0x00000072, 0x00000053, 0x00000065, 0x00000072, 0x00000076, 0x00000069, 0x00000063, 0x00000065, 0x00000073, 0x0000002E, 0x00000044, 0x00000069, 0x00000073, 0x00000063, 0x00000061, 0x00000072, 0x00000064, 0x00000061, 0x00000062, 0x0000006C, 0x00000065, 0x00000041, 0x00000074, 0x00000074, 0x00000072, 0x00000069, 0x00000062, 0x00000075, 0x00000074, 0x00000065, 0x00000000];

    [NativeTypeName("#define COR_COMPILERSERVICE_DISCARDABLEATTRIBUTE_ASNI \"System.Runtime.CompilerServices.DiscardableAttribute\"")]
    public static ReadOnlySpan<byte> COR_COMPILERSERVICE_DISCARDABLEATTRIBUTE_ASNI => "System.Runtime.CompilerServices.DiscardableAttribute"u8;
}
