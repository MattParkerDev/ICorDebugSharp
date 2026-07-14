// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataError : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMetaDataError : IMetaDataError.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataError*, Guid*, void**, nint>)(lpVtbl[0]))((IMetaDataError*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataError*, nuint>)(lpVtbl[1]))((IMetaDataError*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataError*, nuint>)(lpVtbl[2]))((IMetaDataError*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint OnError([NativeTypeName("HRESULT")] nint hrError, [NativeTypeName("mdToken")] uint token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataError*, nint, uint, nint>)(lpVtbl[3]))((IMetaDataError*)Unsafe.AsPointer(ref this), hrError, token);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        nint OnError([NativeTypeName("HRESULT")] nint hrError, [NativeTypeName("mdToken")] uint token);
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

        [NativeTypeName("HRESULT (HRESULT, mdToken) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nint, uint, nint> OnError;
    }
}
