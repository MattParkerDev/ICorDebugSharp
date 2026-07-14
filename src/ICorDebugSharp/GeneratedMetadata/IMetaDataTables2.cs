// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataTables2 : IMetaDataTables")]
[NativeInheritance("IMetaDataTables")]
public unsafe partial struct IMetaDataTables2 : IMetaDataTables2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, Guid*, void**, nint>)(lpVtbl[0]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint>)(lpVtbl[1]))((IMetaDataTables2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint>)(lpVtbl[2]))((IMetaDataTables2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint GetStringHeapSize([NativeTypeName("ULONG *")] nuint* pcbStrings)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint*, nint>)(lpVtbl[3]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), pcbStrings);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public nint GetBlobHeapSize([NativeTypeName("ULONG *")] nuint* pcbBlobs)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint*, nint>)(lpVtbl[4]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), pcbBlobs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("HRESULT")]
    public nint GetGuidHeapSize([NativeTypeName("ULONG *")] nuint* pcbGuids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint*, nint>)(lpVtbl[5]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), pcbGuids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("HRESULT")]
    public nint GetUserStringHeapSize([NativeTypeName("ULONG *")] nuint* pcbBlobs)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint*, nint>)(lpVtbl[6]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), pcbBlobs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("HRESULT")]
    public nint GetNumTables([NativeTypeName("ULONG *")] nuint* pcTables)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint*, nint>)(lpVtbl[7]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), pcTables);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("HRESULT")]
    public nint GetTableIndex([NativeTypeName("ULONG")] nuint token, [NativeTypeName("ULONG *")] nuint* pixTbl)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint*, nint>)(lpVtbl[8]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), token, pixTbl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("HRESULT")]
    public nint GetTableInfo([NativeTypeName("ULONG")] nuint ixTbl, [NativeTypeName("ULONG *")] nuint* pcbRow, [NativeTypeName("ULONG *")] nuint* pcRows, [NativeTypeName("ULONG *")] nuint* pcCols, [NativeTypeName("ULONG *")] nuint* piKey, [NativeTypeName("const char **")] sbyte** ppName)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint*, nuint*, nuint*, nuint*, sbyte**, nint>)(lpVtbl[9]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixTbl, pcbRow, pcRows, pcCols, piKey, ppName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("HRESULT")]
    public nint GetColumnInfo([NativeTypeName("ULONG")] nuint ixTbl, [NativeTypeName("ULONG")] nuint ixCol, [NativeTypeName("ULONG *")] nuint* poCol, [NativeTypeName("ULONG *")] nuint* pcbCol, [NativeTypeName("ULONG *")] nuint* pType, [NativeTypeName("const char **")] sbyte** ppName)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint, nuint*, nuint*, nuint*, sbyte**, nint>)(lpVtbl[10]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixTbl, ixCol, poCol, pcbCol, pType, ppName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("HRESULT")]
    public nint GetCodedTokenInfo([NativeTypeName("ULONG")] nuint ixCdTkn, [NativeTypeName("ULONG *")] nuint* pcTokens, [NativeTypeName("ULONG **")] nuint** ppTokens, [NativeTypeName("const char **")] sbyte** ppName)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint*, nuint**, sbyte**, nint>)(lpVtbl[11]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixCdTkn, pcTokens, ppTokens, ppName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("HRESULT")]
    public nint GetRow([NativeTypeName("ULONG")] nuint ixTbl, [NativeTypeName("ULONG")] nuint rid, void** ppRow)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint, void**, nint>)(lpVtbl[12]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixTbl, rid, ppRow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("HRESULT")]
    public nint GetColumn([NativeTypeName("ULONG")] nuint ixTbl, [NativeTypeName("ULONG")] nuint ixCol, [NativeTypeName("ULONG")] nuint rid, [NativeTypeName("ULONG *")] nuint* pVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint, nuint, nuint*, nint>)(lpVtbl[13]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixTbl, ixCol, rid, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("HRESULT")]
    public nint GetString([NativeTypeName("ULONG")] nuint ixString, [NativeTypeName("const char **")] sbyte** ppString)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, sbyte**, nint>)(lpVtbl[14]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixString, ppString);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [return: NativeTypeName("HRESULT")]
    public nint GetBlob([NativeTypeName("ULONG")] nuint ixBlob, [NativeTypeName("ULONG *")] nuint* pcbData, [NativeTypeName("const void **")] void** ppData)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint*, void**, nint>)(lpVtbl[15]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixBlob, pcbData, ppData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [return: NativeTypeName("HRESULT")]
    public nint GetGuid([NativeTypeName("ULONG")] nuint ixGuid, [NativeTypeName("const GUID **")] Guid** ppGUID)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, Guid**, nint>)(lpVtbl[16]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixGuid, ppGUID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [return: NativeTypeName("HRESULT")]
    public nint GetUserString([NativeTypeName("ULONG")] nuint ixUserString, [NativeTypeName("ULONG *")] nuint* pcbData, [NativeTypeName("const void **")] void** ppData)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint*, void**, nint>)(lpVtbl[17]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixUserString, pcbData, ppData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("HRESULT")]
    public nint GetNextString([NativeTypeName("ULONG")] nuint ixString, [NativeTypeName("ULONG *")] nuint* pNext)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint*, nint>)(lpVtbl[18]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixString, pNext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [return: NativeTypeName("HRESULT")]
    public nint GetNextBlob([NativeTypeName("ULONG")] nuint ixBlob, [NativeTypeName("ULONG *")] nuint* pNext)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint*, nint>)(lpVtbl[19]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixBlob, pNext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("HRESULT")]
    public nint GetNextGuid([NativeTypeName("ULONG")] nuint ixGuid, [NativeTypeName("ULONG *")] nuint* pNext)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint*, nint>)(lpVtbl[20]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixGuid, pNext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("HRESULT")]
    public nint GetNextUserString([NativeTypeName("ULONG")] nuint ixUserString, [NativeTypeName("ULONG *")] nuint* pNext)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, nuint*, nint>)(lpVtbl[21]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ixUserString, pNext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("HRESULT")]
    public nint GetMetaDataStorage([NativeTypeName("const void **")] void** ppvMd, [NativeTypeName("ULONG *")] nuint* pcbMd)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, void**, nuint*, nint>)(lpVtbl[22]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ppvMd, pcbMd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("HRESULT")]
    public nint GetMetaDataStreamInfo([NativeTypeName("ULONG")] nuint ix, [NativeTypeName("const char **")] sbyte** ppchName, [NativeTypeName("const void **")] void** ppv, [NativeTypeName("ULONG *")] nuint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataTables2*, nuint, sbyte**, void**, nuint*, nint>)(lpVtbl[23]))((IMetaDataTables2*)Unsafe.AsPointer(ref this), ix, ppchName, ppv, pcb);
    }

    public interface Interface : IMetaDataTables.Interface
    {
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        nint GetMetaDataStorage([NativeTypeName("const void **")] void** ppvMd, [NativeTypeName("ULONG *")] nuint* pcbMd);

        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        nint GetMetaDataStreamInfo([NativeTypeName("ULONG")] nuint ix, [NativeTypeName("const char **")] sbyte** ppchName, [NativeTypeName("const void **")] void** ppv, [NativeTypeName("ULONG *")] nuint* pcb);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, nint> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint> Release;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint*, nint> GetStringHeapSize;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint*, nint> GetBlobHeapSize;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint*, nint> GetGuidHeapSize;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint*, nint> GetUserStringHeapSize;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint*, nint> GetNumTables;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint*, nint> GetTableIndex;

        [NativeTypeName("HRESULT (ULONG, ULONG *, ULONG *, ULONG *, ULONG *, const char **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint*, nuint*, nuint*, nuint*, sbyte**, nint> GetTableInfo;

        [NativeTypeName("HRESULT (ULONG, ULONG, ULONG *, ULONG *, ULONG *, const char **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint, nuint*, nuint*, nuint*, sbyte**, nint> GetColumnInfo;

        [NativeTypeName("HRESULT (ULONG, ULONG *, ULONG **, const char **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint*, nuint**, sbyte**, nint> GetCodedTokenInfo;

        [NativeTypeName("HRESULT (ULONG, ULONG, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint, void**, nint> GetRow;

        [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint, nuint, nuint*, nint> GetColumn;

        [NativeTypeName("HRESULT (ULONG, const char **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, sbyte**, nint> GetString;

        [NativeTypeName("HRESULT (ULONG, ULONG *, const void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint*, void**, nint> GetBlob;

        [NativeTypeName("HRESULT (ULONG, const GUID **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, Guid**, nint> GetGuid;

        [NativeTypeName("HRESULT (ULONG, ULONG *, const void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint*, void**, nint> GetUserString;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint*, nint> GetNextString;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint*, nint> GetNextBlob;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint*, nint> GetNextGuid;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, nuint*, nint> GetNextUserString;

        [NativeTypeName("HRESULT (const void **, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, nuint*, nint> GetMetaDataStorage;

        [NativeTypeName("HRESULT (ULONG, const char **, const void **, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, sbyte**, void**, nuint*, nint> GetMetaDataStreamInfo;
    }
}
