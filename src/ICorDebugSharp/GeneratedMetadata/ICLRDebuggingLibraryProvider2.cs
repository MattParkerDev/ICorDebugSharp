// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static ICorDebugSharp.DbgShim;

namespace ICorDebugSharp;

[Guid("E04E2FF1-DCFD-45D5-BCD1-16FFF2FAF7BA")]
[NativeTypeName("struct ICLRDebuggingLibraryProvider2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICLRDebuggingLibraryProvider2 : ICLRDebuggingLibraryProvider2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICLRDebuggingLibraryProvider2);

    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider2*, Guid*, void**, int>)(lpVtbl[0]))((ICLRDebuggingLibraryProvider2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider2*, uint>)(lpVtbl[1]))((ICLRDebuggingLibraryProvider2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider2*, uint>)(lpVtbl[2]))((ICLRDebuggingLibraryProvider2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public int ProvideLibrary2([NativeTypeName("const WCHAR *")] char* pwszFileName, [NativeTypeName("DWORD")] uint dwTimestamp, [NativeTypeName("DWORD")] uint dwSizeOfImage, [NativeTypeName("LPWSTR *")] char** ppResolvedModulePath)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider2*, char*, uint, uint, char**, int>)(lpVtbl[3]))((ICLRDebuggingLibraryProvider2*)Unsafe.AsPointer(ref this), pwszFileName, dwTimestamp, dwSizeOfImage, ppResolvedModulePath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        int ProvideLibrary2([NativeTypeName("const WCHAR *")] char* pwszFileName, [NativeTypeName("DWORD")] uint dwTimestamp, [NativeTypeName("DWORD")] uint dwSizeOfImage, [NativeTypeName("LPWSTR *")] char** ppResolvedModulePath);
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

        [NativeTypeName("HRESULT (const WCHAR *, DWORD, DWORD, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, uint, char**, int> ProvideLibrary2;
    }
}
