// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static ICorDebugSharp.DbgShim;

namespace ICorDebugSharp;

[Guid("DE3AAB18-46A0-48B4-BF0D-2C336E69EA1B")]
[NativeTypeName("struct ICLRDebuggingLibraryProvider3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICLRDebuggingLibraryProvider3 : ICLRDebuggingLibraryProvider3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICLRDebuggingLibraryProvider3);

    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider3*, Guid*, void**, int>)(lpVtbl[0]))((ICLRDebuggingLibraryProvider3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider3*, uint>)(lpVtbl[1]))((ICLRDebuggingLibraryProvider3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider3*, uint>)(lpVtbl[2]))((ICLRDebuggingLibraryProvider3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public int ProvideWindowsLibrary([NativeTypeName("const WCHAR *")] char* pwszFileName, [NativeTypeName("const WCHAR *")] char* pwszRuntimeModule, [NativeTypeName("LIBRARY_PROVIDER_INDEX_TYPE")] __MIDL___MIDL_itf_metahost_0000_0000_0001 indexType, [NativeTypeName("DWORD")] uint dwTimestamp, [NativeTypeName("DWORD")] uint dwSizeOfImage, [NativeTypeName("LPWSTR *")] char** ppResolvedModulePath)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider3*, char*, char*, __MIDL___MIDL_itf_metahost_0000_0000_0001, uint, uint, char**, int>)(lpVtbl[3]))((ICLRDebuggingLibraryProvider3*)Unsafe.AsPointer(ref this), pwszFileName, pwszRuntimeModule, indexType, dwTimestamp, dwSizeOfImage, ppResolvedModulePath);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public int ProvideUnixLibrary([NativeTypeName("const WCHAR *")] char* pwszFileName, [NativeTypeName("const WCHAR *")] char* pwszRuntimeModule, [NativeTypeName("LIBRARY_PROVIDER_INDEX_TYPE")] __MIDL___MIDL_itf_metahost_0000_0000_0001 indexType, byte* pbBuildId, int iBuildIdSize, [NativeTypeName("LPWSTR *")] char** ppResolvedModulePath)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider3*, char*, char*, __MIDL___MIDL_itf_metahost_0000_0000_0001, byte*, int, char**, int>)(lpVtbl[4]))((ICLRDebuggingLibraryProvider3*)Unsafe.AsPointer(ref this), pwszFileName, pwszRuntimeModule, indexType, pbBuildId, iBuildIdSize, ppResolvedModulePath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        int ProvideWindowsLibrary([NativeTypeName("const WCHAR *")] char* pwszFileName, [NativeTypeName("const WCHAR *")] char* pwszRuntimeModule, [NativeTypeName("LIBRARY_PROVIDER_INDEX_TYPE")] __MIDL___MIDL_itf_metahost_0000_0000_0001 indexType, [NativeTypeName("DWORD")] uint dwTimestamp, [NativeTypeName("DWORD")] uint dwSizeOfImage, [NativeTypeName("LPWSTR *")] char** ppResolvedModulePath);

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        int ProvideUnixLibrary([NativeTypeName("const WCHAR *")] char* pwszFileName, [NativeTypeName("const WCHAR *")] char* pwszRuntimeModule, [NativeTypeName("LIBRARY_PROVIDER_INDEX_TYPE")] __MIDL___MIDL_itf_metahost_0000_0000_0001 indexType, byte* pbBuildId, int iBuildIdSize, [NativeTypeName("LPWSTR *")] char** ppResolvedModulePath);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (const WCHAR *, const WCHAR *, LIBRARY_PROVIDER_INDEX_TYPE, DWORD, DWORD, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, __MIDL___MIDL_itf_metahost_0000_0000_0001, uint, uint, char**, int> ProvideWindowsLibrary;

        [NativeTypeName("HRESULT (const WCHAR *, const WCHAR *, LIBRARY_PROVIDER_INDEX_TYPE, BYTE *, int, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, __MIDL___MIDL_itf_metahost_0000_0000_0001, byte*, int, char**, int> ProvideUnixLibrary;
    }
}
