// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static ICorDebugSharp.DbgShim;

namespace ICorDebugSharp;

[Guid("D332DB9E-B9B3-4125-8207-A14884F53216")]
[NativeTypeName("struct ICLRMetaHost : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICLRMetaHost : ICLRMetaHost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICLRMetaHost);

    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRMetaHost*, Guid*, void**, int>)(lpVtbl[0]))((ICLRMetaHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRMetaHost*, uint>)(lpVtbl[1]))((ICLRMetaHost*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRMetaHost*, uint>)(lpVtbl[2]))((ICLRMetaHost*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public int GetRuntime([NativeTypeName("LPCWSTR")] char* pwzVersion, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppRuntime)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRMetaHost*, char*, Guid*, void**, int>)(lpVtbl[3]))((ICLRMetaHost*)Unsafe.AsPointer(ref this), pwzVersion, riid, ppRuntime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public int GetVersionFromFile([NativeTypeName("LPCWSTR")] char* pwzFilePath, [NativeTypeName("LPWSTR")] char* pwzBuffer, [NativeTypeName("DWORD *")] uint* pcchBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRMetaHost*, char*, char*, uint*, int>)(lpVtbl[4]))((ICLRMetaHost*)Unsafe.AsPointer(ref this), pwzFilePath, pwzBuffer, pcchBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("HRESULT")]
    public int EnumerateInstalledRuntimes(IEnumUnknown** ppEnumerator)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRMetaHost*, IEnumUnknown**, int>)(lpVtbl[5]))((ICLRMetaHost*)Unsafe.AsPointer(ref this), ppEnumerator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("HRESULT")]
    public int EnumerateLoadedRuntimes([NativeTypeName("HANDLE")] void* hndProcess, IEnumUnknown** ppEnumerator)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRMetaHost*, void*, IEnumUnknown**, int>)(lpVtbl[6]))((ICLRMetaHost*)Unsafe.AsPointer(ref this), hndProcess, ppEnumerator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("HRESULT")]
    public int RequestRuntimeLoadedNotification([NativeTypeName("RuntimeLoadedCallbackFnPtr")] delegate* unmanaged[Stdcall]<ICLRRuntimeInfo*, delegate* unmanaged[Stdcall]<int>, delegate* unmanaged[Stdcall]<int>, void> pCallbackFunction)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRMetaHost*, delegate* unmanaged[Stdcall]<ICLRRuntimeInfo*, delegate* unmanaged[Stdcall]<int>, delegate* unmanaged[Stdcall]<int>, void>, int>)(lpVtbl[7]))((ICLRMetaHost*)Unsafe.AsPointer(ref this), pCallbackFunction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("HRESULT")]
    public int QueryLegacyV2RuntimeBinding([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRMetaHost*, Guid*, void**, int>)(lpVtbl[8]))((ICLRMetaHost*)Unsafe.AsPointer(ref this), riid, ppUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("HRESULT")]
    public int ExitProcess([NativeTypeName("INT32")] int iExitCode)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRMetaHost*, int, int>)(lpVtbl[9]))((ICLRMetaHost*)Unsafe.AsPointer(ref this), iExitCode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        int GetRuntime([NativeTypeName("LPCWSTR")] char* pwzVersion, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppRuntime);

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        int GetVersionFromFile([NativeTypeName("LPCWSTR")] char* pwzFilePath, [NativeTypeName("LPWSTR")] char* pwzBuffer, [NativeTypeName("DWORD *")] uint* pcchBuffer);

        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        int EnumerateInstalledRuntimes(IEnumUnknown** ppEnumerator);

        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        int EnumerateLoadedRuntimes([NativeTypeName("HANDLE")] void* hndProcess, IEnumUnknown** ppEnumerator);

        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        int QueryLegacyV2RuntimeBinding([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppUnk);

        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        int ExitProcess([NativeTypeName("INT32")] int iExitCode);
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

        [NativeTypeName("HRESULT (LPCWSTR, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, void**, int> GetRuntime;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint*, int> GetVersionFromFile;

        [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumUnknown**, int> EnumerateInstalledRuntimes;

        [NativeTypeName("HRESULT (HANDLE, IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, IEnumUnknown**, int> EnumerateLoadedRuntimes;

        [NativeTypeName("HRESULT (RuntimeLoadedCallbackFnPtr) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, delegate* unmanaged[Stdcall]<ICLRRuntimeInfo*, delegate* unmanaged[Stdcall]<int>, delegate* unmanaged[Stdcall]<int>, void>, int> RequestRuntimeLoadedNotification;

        [NativeTypeName("HRESULT (const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryLegacyV2RuntimeBinding;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> ExitProcess;
    }
}
