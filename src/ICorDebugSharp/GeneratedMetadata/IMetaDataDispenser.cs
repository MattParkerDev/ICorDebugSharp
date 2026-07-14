// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataDispenser : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMetaDataDispenser : IMetaDataDispenser.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenser*, Guid*, void**, nint>)(lpVtbl[0]))((IMetaDataDispenser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenser*, nuint>)(lpVtbl[1]))((IMetaDataDispenser*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenser*, nuint>)(lpVtbl[2]))((IMetaDataDispenser*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineScope([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] nuint dwCreateFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenser*, Guid*, nuint, Guid*, IUnknown**, nint>)(lpVtbl[3]))((IMetaDataDispenser*)Unsafe.AsPointer(ref this), rclsid, dwCreateFlags, riid, ppIUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public nint OpenScope([NativeTypeName("LPCWSTR")] uint* szScope, [NativeTypeName("DWORD")] nuint dwOpenFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenser*, uint*, nuint, Guid*, IUnknown**, nint>)(lpVtbl[4]))((IMetaDataDispenser*)Unsafe.AsPointer(ref this), szScope, dwOpenFlags, riid, ppIUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("HRESULT")]
    public nint OpenScopeOnMemory([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("ULONG")] nuint cbData, [NativeTypeName("DWORD")] nuint dwOpenFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenser*, void*, nuint, nuint, Guid*, IUnknown**, nint>)(lpVtbl[5]))((IMetaDataDispenser*)Unsafe.AsPointer(ref this), pData, cbData, dwOpenFlags, riid, ppIUnk);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        nint DefineScope([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] nuint dwCreateFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk);

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        nint OpenScope([NativeTypeName("LPCWSTR")] uint* szScope, [NativeTypeName("DWORD")] nuint dwOpenFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk);

        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        nint OpenScopeOnMemory([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("ULONG")] nuint cbData, [NativeTypeName("DWORD")] nuint dwOpenFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk);
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

        [NativeTypeName("HRESULT (const IID &, DWORD, const IID &, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, nuint, Guid*, IUnknown**, nint> DefineScope;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, const IID &, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, nuint, Guid*, IUnknown**, nint> OpenScope;

        [NativeTypeName("HRESULT (LPCVOID, ULONG, DWORD, const IID &, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, nuint, nuint, Guid*, IUnknown**, nint> OpenScopeOnMemory;
    }
}
