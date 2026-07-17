// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static ICorDebugSharp.DbgShim;

namespace ICorDebugSharp;

[Guid("D28F3C5A-9634-4206-A509-477552EEFB10")]
[NativeTypeName("struct ICLRDebugging : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICLRDebugging : ICLRDebugging.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICLRDebugging);

    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebugging*, Guid*, void**, int>)(lpVtbl[0]))((ICLRDebugging*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebugging*, uint>)(lpVtbl[1]))((ICLRDebugging*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebugging*, uint>)(lpVtbl[2]))((ICLRDebugging*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public int OpenVirtualProcess([NativeTypeName("ULONG64")] ulong moduleBaseAddress, IUnknown* pDataTarget, ICLRDebuggingLibraryProvider* pLibraryProvider, [NativeTypeName("CLR_DEBUGGING_VERSION *")] _CLR_DEBUGGING_VERSION* pMaxDebuggerSupportedVersion, [NativeTypeName("const IID &")] Guid* riidProcess, IUnknown** ppProcess, [NativeTypeName("CLR_DEBUGGING_VERSION *")] _CLR_DEBUGGING_VERSION* pVersion, [NativeTypeName("CLR_DEBUGGING_PROCESS_FLAGS *")] __MIDL___MIDL_itf_metahost_0000_0001_0001* pdwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebugging*, ulong, IUnknown*, ICLRDebuggingLibraryProvider*, _CLR_DEBUGGING_VERSION*, Guid*, IUnknown**, _CLR_DEBUGGING_VERSION*, __MIDL___MIDL_itf_metahost_0000_0001_0001*, int>)(lpVtbl[3]))((ICLRDebugging*)Unsafe.AsPointer(ref this), moduleBaseAddress, pDataTarget, pLibraryProvider, pMaxDebuggerSupportedVersion, riidProcess, ppProcess, pVersion, pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public int CanUnloadNow([NativeTypeName("HMODULE")] HINSTANCE__* hModule)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRDebugging*, HINSTANCE__*, int>)(lpVtbl[4]))((ICLRDebugging*)Unsafe.AsPointer(ref this), hModule);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        int OpenVirtualProcess([NativeTypeName("ULONG64")] ulong moduleBaseAddress, IUnknown* pDataTarget, ICLRDebuggingLibraryProvider* pLibraryProvider, [NativeTypeName("CLR_DEBUGGING_VERSION *")] _CLR_DEBUGGING_VERSION* pMaxDebuggerSupportedVersion, [NativeTypeName("const IID &")] Guid* riidProcess, IUnknown** ppProcess, [NativeTypeName("CLR_DEBUGGING_VERSION *")] _CLR_DEBUGGING_VERSION* pVersion, [NativeTypeName("CLR_DEBUGGING_PROCESS_FLAGS *")] __MIDL___MIDL_itf_metahost_0000_0001_0001* pdwFlags);

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        int CanUnloadNow([NativeTypeName("HMODULE")] HINSTANCE__* hModule);
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

        [NativeTypeName("HRESULT (ULONG64, IUnknown *, ICLRDebuggingLibraryProvider *, CLR_DEBUGGING_VERSION *, const IID &, IUnknown **, CLR_DEBUGGING_VERSION *, CLR_DEBUGGING_PROCESS_FLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IUnknown*, ICLRDebuggingLibraryProvider*, _CLR_DEBUGGING_VERSION*, Guid*, IUnknown**, _CLR_DEBUGGING_VERSION*, __MIDL___MIDL_itf_metahost_0000_0001_0001*, int> OpenVirtualProcess;

        [NativeTypeName("HRESULT (HMODULE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HINSTANCE__*, int> CanUnloadNow;
    }
}
