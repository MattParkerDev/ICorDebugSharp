// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static ICorDebugSharp.DbgShim;

namespace ICorDebugSharp;

[Guid("BD39D1D2-BA2F-486A-89B0-B4B0CB466891")]
[NativeTypeName("struct ICLRRuntimeInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICLRRuntimeInfo : ICLRRuntimeInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICLRRuntimeInfo);

    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, uint>)(lpVtbl[1]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, uint>)(lpVtbl[2]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public int GetVersionString([NativeTypeName("LPWSTR")] char* pwzBuffer, [NativeTypeName("DWORD *")] uint* pcchBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, char*, uint*, int>)(lpVtbl[3]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), pwzBuffer, pcchBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public int GetRuntimeDirectory([NativeTypeName("LPWSTR")] char* pwzBuffer, [NativeTypeName("DWORD *")] uint* pcchBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, char*, uint*, int>)(lpVtbl[4]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), pwzBuffer, pcchBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("HRESULT")]
    public int IsLoaded([NativeTypeName("HANDLE")] void* hndProcess, [NativeTypeName("BOOL *")] int* pbLoaded)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, void*, int*, int>)(lpVtbl[5]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), hndProcess, pbLoaded);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("HRESULT")]
    public int LoadErrorString(uint iResourceID, [NativeTypeName("LPWSTR")] char* pwzBuffer, [NativeTypeName("DWORD *")] uint* pcchBuffer, [NativeTypeName("LONG")] int iLocaleID)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, uint, char*, uint*, int, int>)(lpVtbl[6]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), iResourceID, pwzBuffer, pcchBuffer, iLocaleID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("HRESULT")]
    public int LoadLibraryA([NativeTypeName("LPCWSTR")] char* pwzDllName, [NativeTypeName("HMODULE *")] HINSTANCE__** phndModule)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, char*, HINSTANCE__**, int>)(lpVtbl[7]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), pwzDllName, phndModule);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("HRESULT")]
    public int GetProcAddress([NativeTypeName("LPCSTR")] sbyte* pszProcName, [NativeTypeName("LPVOID *")] void** ppProc)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, sbyte*, void**, int>)(lpVtbl[8]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), pszProcName, ppProc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("HRESULT")]
    public int GetInterface([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, Guid*, Guid*, void**, int>)(lpVtbl[9]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), rclsid, riid, ppUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("HRESULT")]
    public int IsLoadable([NativeTypeName("BOOL *")] int* pbLoadable)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, int*, int>)(lpVtbl[10]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), pbLoadable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("HRESULT")]
    public int SetDefaultStartupFlags([NativeTypeName("DWORD")] uint dwStartupFlags, [NativeTypeName("LPCWSTR")] char* pwzHostConfigFile)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, uint, char*, int>)(lpVtbl[11]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), dwStartupFlags, pwzHostConfigFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("HRESULT")]
    public int GetDefaultStartupFlags([NativeTypeName("DWORD *")] uint* pdwStartupFlags, [NativeTypeName("LPWSTR")] char* pwzHostConfigFile, [NativeTypeName("DWORD *")] uint* pcchHostConfigFile)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, uint*, char*, uint*, int>)(lpVtbl[12]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), pdwStartupFlags, pwzHostConfigFile, pcchHostConfigFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("HRESULT")]
    public int BindAsLegacyV2Runtime()
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, int>)(lpVtbl[13]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("HRESULT")]
    public int IsStarted([NativeTypeName("BOOL *")] int* pbStarted, [NativeTypeName("DWORD *")] uint* pdwStartupFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ICLRRuntimeInfo*, int*, uint*, int>)(lpVtbl[14]))((ICLRRuntimeInfo*)Unsafe.AsPointer(ref this), pbStarted, pdwStartupFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        int GetVersionString([NativeTypeName("LPWSTR")] char* pwzBuffer, [NativeTypeName("DWORD *")] uint* pcchBuffer);

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        int GetRuntimeDirectory([NativeTypeName("LPWSTR")] char* pwzBuffer, [NativeTypeName("DWORD *")] uint* pcchBuffer);

        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        int IsLoaded([NativeTypeName("HANDLE")] void* hndProcess, [NativeTypeName("BOOL *")] int* pbLoaded);

        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        int LoadErrorString(uint iResourceID, [NativeTypeName("LPWSTR")] char* pwzBuffer, [NativeTypeName("DWORD *")] uint* pcchBuffer, [NativeTypeName("LONG")] int iLocaleID);

        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        int LoadLibraryA([NativeTypeName("LPCWSTR")] char* pwzDllName, [NativeTypeName("HMODULE *")] HINSTANCE__** phndModule);

        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        int GetProcAddress([NativeTypeName("LPCSTR")] sbyte* pszProcName, [NativeTypeName("LPVOID *")] void** ppProc);

        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        int GetInterface([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppUnk);

        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        int IsLoadable([NativeTypeName("BOOL *")] int* pbLoadable);

        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        int SetDefaultStartupFlags([NativeTypeName("DWORD")] uint dwStartupFlags, [NativeTypeName("LPCWSTR")] char* pwzHostConfigFile);

        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        int GetDefaultStartupFlags([NativeTypeName("DWORD *")] uint* pdwStartupFlags, [NativeTypeName("LPWSTR")] char* pwzHostConfigFile, [NativeTypeName("DWORD *")] uint* pcchHostConfigFile);

        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        int BindAsLegacyV2Runtime();

        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        int IsStarted([NativeTypeName("BOOL *")] int* pbStarted, [NativeTypeName("DWORD *")] uint* pdwStartupFlags);
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

        [NativeTypeName("HRESULT (LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, int> GetVersionString;

        [NativeTypeName("HRESULT (LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, int> GetRuntimeDirectory;

        [NativeTypeName("HRESULT (HANDLE, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, int*, int> IsLoaded;

        [NativeTypeName("HRESULT (UINT, LPWSTR, DWORD *, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int, int> LoadErrorString;

        [NativeTypeName("HRESULT (LPCWSTR, HMODULE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HINSTANCE__**, int> LoadLibraryA;

        [NativeTypeName("HRESULT (LPCSTR, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, void**, int> GetProcAddress;

        [NativeTypeName("HRESULT (const IID &, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, void**, int> GetInterface;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> IsLoadable;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> SetDefaultStartupFlags;

        [NativeTypeName("HRESULT (DWORD *, LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char*, uint*, int> GetDefaultStartupFlags;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> BindAsLegacyV2Runtime;

        [NativeTypeName("HRESULT (BOOL *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, uint*, int> IsStarted;
    }
}
