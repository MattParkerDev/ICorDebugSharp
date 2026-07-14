// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMapToken : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMapToken : IMapToken.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMapToken*, Guid*, void**, nint>)(lpVtbl[0]))((IMapToken*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMapToken*, nuint>)(lpVtbl[1]))((IMapToken*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMapToken*, nuint>)(lpVtbl[2]))((IMapToken*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint Map([NativeTypeName("mdToken")] uint tkImp, [NativeTypeName("mdToken")] uint tkEmit)
    {
        return ((delegate* unmanaged[MemberFunction]<IMapToken*, uint, uint, nint>)(lpVtbl[3]))((IMapToken*)Unsafe.AsPointer(ref this), tkImp, tkEmit);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        nint Map([NativeTypeName("mdToken")] uint tkImp, [NativeTypeName("mdToken")] uint tkEmit);
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

        [NativeTypeName("HRESULT (mdToken, mdToken) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, nint> Map;
    }
}
