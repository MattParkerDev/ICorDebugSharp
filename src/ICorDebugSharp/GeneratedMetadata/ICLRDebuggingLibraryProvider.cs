// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static ICorDebugSharp.DbgShim;

namespace ICorDebugSharp;

[Guid("3151C08D-4D09-4F9B-8838-2880BF18FE51")]
[NativeTypeName("struct ICLRDebuggingLibraryProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICLRDebuggingLibraryProvider : ICLRDebuggingLibraryProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICLRDebuggingLibraryProvider);

    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider*, Guid*, void**, int>)(lpVtbl[0]))((ICLRDebuggingLibraryProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider*, uint>)(lpVtbl[1]))((ICLRDebuggingLibraryProvider*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider*, uint>)(lpVtbl[2]))((ICLRDebuggingLibraryProvider*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public int ProvideLibrary([NativeTypeName("const WCHAR *")] char* pwszFileName, [NativeTypeName("DWORD")] uint dwTimestamp, [NativeTypeName("DWORD")] uint dwSizeOfImage, [NativeTypeName("HMODULE *")] HINSTANCE__** phModule)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebuggingLibraryProvider*, char*, uint, uint, HINSTANCE__**, int>)(lpVtbl[3]))((ICLRDebuggingLibraryProvider*)Unsafe.AsPointer(ref this), pwszFileName, dwTimestamp, dwSizeOfImage, phModule);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        int ProvideLibrary([NativeTypeName("const WCHAR *")] char* pwszFileName, [NativeTypeName("DWORD")] uint dwTimestamp, [NativeTypeName("DWORD")] uint dwSizeOfImage, [NativeTypeName("HMODULE *")] HINSTANCE__** phModule);
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

        [NativeTypeName("HRESULT (const WCHAR *, DWORD, DWORD, HMODULE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, uint, HINSTANCE__**, int> ProvideLibrary;
    }
}
