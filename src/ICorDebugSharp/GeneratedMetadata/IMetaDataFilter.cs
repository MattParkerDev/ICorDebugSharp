// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMetaDataFilter : IMetaDataFilter.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataFilter*, Guid*, void**, nint>)(lpVtbl[0]))((IMetaDataFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataFilter*, nuint>)(lpVtbl[1]))((IMetaDataFilter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataFilter*, nuint>)(lpVtbl[2]))((IMetaDataFilter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint UnmarkAll()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataFilter*, nint>)(lpVtbl[3]))((IMetaDataFilter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public nint MarkToken([NativeTypeName("mdToken")] uint tk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataFilter*, uint, nint>)(lpVtbl[4]))((IMetaDataFilter*)Unsafe.AsPointer(ref this), tk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("HRESULT")]
    public nint IsTokenMarked([NativeTypeName("mdToken")] uint tk, [NativeTypeName("BOOL *")] int* pIsMarked)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataFilter*, uint, int*, nint>)(lpVtbl[5]))((IMetaDataFilter*)Unsafe.AsPointer(ref this), tk, pIsMarked);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        nint UnmarkAll();

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        nint MarkToken([NativeTypeName("mdToken")] uint tk);

        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        nint IsTokenMarked([NativeTypeName("mdToken")] uint tk, [NativeTypeName("BOOL *")] int* pIsMarked);
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nint> UnmarkAll;

        [NativeTypeName("HRESULT (mdToken) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nint> MarkToken;

        [NativeTypeName("HRESULT (mdToken, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int*, nint> IsTokenMarked;
    }
}
