// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataDispenserEx : IMetaDataDispenser")]
[NativeInheritance("IMetaDataDispenser")]
public unsafe partial struct IMetaDataDispenserEx : IMetaDataDispenserEx.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, Guid*, void**, nint>)(lpVtbl[0]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, nuint>)(lpVtbl[1]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, nuint>)(lpVtbl[2]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineScope([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] nuint dwCreateFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, Guid*, nuint, Guid*, IUnknown**, nint>)(lpVtbl[3]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this), rclsid, dwCreateFlags, riid, ppIUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public nint OpenScope([NativeTypeName("LPCWSTR")] uint* szScope, [NativeTypeName("DWORD")] nuint dwOpenFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, uint*, nuint, Guid*, IUnknown**, nint>)(lpVtbl[4]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this), szScope, dwOpenFlags, riid, ppIUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("HRESULT")]
    public nint OpenScopeOnMemory([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("ULONG")] nuint cbData, [NativeTypeName("DWORD")] nuint dwOpenFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, void*, nuint, nuint, Guid*, IUnknown**, nint>)(lpVtbl[5]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this), pData, cbData, dwOpenFlags, riid, ppIUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("HRESULT")]
    public nint SetOption([NativeTypeName("const GUID &")] Guid* optionid, [NativeTypeName("const VARIANT *")] tagVARIANT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, Guid*, tagVARIANT*, nint>)(lpVtbl[6]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this), optionid, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("HRESULT")]
    public nint GetOption([NativeTypeName("const GUID &")] Guid* optionid, [NativeTypeName("VARIANT *")] tagVARIANT* pvalue)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, Guid*, tagVARIANT*, nint>)(lpVtbl[7]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this), optionid, pvalue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("HRESULT")]
    public nint OpenScopeOnITypeInfo(ITypeInfo* pITI, [NativeTypeName("DWORD")] nuint dwOpenFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, ITypeInfo*, nuint, Guid*, IUnknown**, nint>)(lpVtbl[8]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this), pITI, dwOpenFlags, riid, ppIUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("HRESULT")]
    public nint GetCORSystemDirectory([NativeTypeName("LPWSTR")] uint* szBuffer, [NativeTypeName("DWORD")] nuint cchBuffer, [NativeTypeName("DWORD *")] nuint* pchBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, uint*, nuint, nuint*, nint>)(lpVtbl[9]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this), szBuffer, cchBuffer, pchBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("HRESULT")]
    public nint FindAssembly([NativeTypeName("LPCWSTR")] uint* szAppBase, [NativeTypeName("LPCWSTR")] uint* szPrivateBin, [NativeTypeName("LPCWSTR")] uint* szGlobalBin, [NativeTypeName("LPCWSTR")] uint* szAssemblyName, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pcName)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, uint*, uint*, uint*, uint*, uint*, nuint, nuint*, nint>)(lpVtbl[10]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this), szAppBase, szPrivateBin, szGlobalBin, szAssemblyName, szName, cchName, pcName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("HRESULT")]
    public nint FindAssemblyModule([NativeTypeName("LPCWSTR")] uint* szAppBase, [NativeTypeName("LPCWSTR")] uint* szPrivateBin, [NativeTypeName("LPCWSTR")] uint* szGlobalBin, [NativeTypeName("LPCWSTR")] uint* szAssemblyName, [NativeTypeName("LPCWSTR")] uint* szModuleName, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pcName)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataDispenserEx*, uint*, uint*, uint*, uint*, uint*, uint*, nuint, nuint*, nint>)(lpVtbl[11]))((IMetaDataDispenserEx*)Unsafe.AsPointer(ref this), szAppBase, szPrivateBin, szGlobalBin, szAssemblyName, szModuleName, szName, cchName, pcName);
    }

    public interface Interface : IMetaDataDispenser.Interface
    {
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        nint SetOption([NativeTypeName("const GUID &")] Guid* optionid, [NativeTypeName("const VARIANT *")] tagVARIANT* value);

        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        nint GetOption([NativeTypeName("const GUID &")] Guid* optionid, [NativeTypeName("VARIANT *")] tagVARIANT* pvalue);

        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        nint OpenScopeOnITypeInfo(ITypeInfo* pITI, [NativeTypeName("DWORD")] nuint dwOpenFlags, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppIUnk);

        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        nint GetCORSystemDirectory([NativeTypeName("LPWSTR")] uint* szBuffer, [NativeTypeName("DWORD")] nuint cchBuffer, [NativeTypeName("DWORD *")] nuint* pchBuffer);

        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        nint FindAssembly([NativeTypeName("LPCWSTR")] uint* szAppBase, [NativeTypeName("LPCWSTR")] uint* szPrivateBin, [NativeTypeName("LPCWSTR")] uint* szGlobalBin, [NativeTypeName("LPCWSTR")] uint* szAssemblyName, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pcName);

        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        nint FindAssemblyModule([NativeTypeName("LPCWSTR")] uint* szAppBase, [NativeTypeName("LPCWSTR")] uint* szPrivateBin, [NativeTypeName("LPCWSTR")] uint* szGlobalBin, [NativeTypeName("LPCWSTR")] uint* szAssemblyName, [NativeTypeName("LPCWSTR")] uint* szModuleName, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pcName);
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

        [NativeTypeName("HRESULT (const GUID &, const VARIANT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, tagVARIANT*, nint> SetOption;

        [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, tagVARIANT*, nint> GetOption;

        [NativeTypeName("HRESULT (ITypeInfo *, DWORD, const IID &, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypeInfo*, nuint, Guid*, IUnknown**, nint> OpenScopeOnITypeInfo;

        [NativeTypeName("HRESULT (LPWSTR, DWORD, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, nuint, nuint*, nint> GetCORSystemDirectory;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, uint*, uint*, uint*, nuint, nuint*, nint> FindAssembly;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPWSTR, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, uint*, uint*, uint*, uint*, nuint, nuint*, nint> FindAssemblyModule;
    }
}
