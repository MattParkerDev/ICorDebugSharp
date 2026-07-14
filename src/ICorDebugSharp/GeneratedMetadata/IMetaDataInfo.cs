// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMetaDataInfo : IMetaDataInfo.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataInfo*, Guid*, void**, nint>)(lpVtbl[0]))((IMetaDataInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataInfo*, nuint>)(lpVtbl[1]))((IMetaDataInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataInfo*, nuint>)(lpVtbl[2]))((IMetaDataInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint GetFileMapping([NativeTypeName("const void **")] void** ppvData, [NativeTypeName("ULONGLONG *")] ulong* pcbData, [NativeTypeName("DWORD *")] nuint* pdwMappingType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataInfo*, void**, ulong*, nuint*, nint>)(lpVtbl[3]))((IMetaDataInfo*)Unsafe.AsPointer(ref this), ppvData, pcbData, pdwMappingType);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        nint GetFileMapping([NativeTypeName("const void **")] void** ppvData, [NativeTypeName("ULONGLONG *")] ulong* pcbData, [NativeTypeName("DWORD *")] nuint* pdwMappingType);
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

        [NativeTypeName("HRESULT (const void **, ULONGLONG *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, ulong*, nuint*, nint> GetFileMapping;
    }
}
