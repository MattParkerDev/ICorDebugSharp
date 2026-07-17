// ReSharper disable InconsistentNaming
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ICorDebugSharp;

public static unsafe partial class DbgShim
{
    [DllImport("", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int CLRCreateInstance([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppInterface);

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_ICLRMetaHost
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x9E, 0xDB, 0x32, 0xD3,
                0xB3, 0xB9,
                0x25, 0x41,
                0x82,
                0x07,
                0xA1,
                0x48,
                0x84,
                0xF5,
                0x32,
                0x16
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_CLRMetaHost
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8D, 0x18, 0x80, 0x92,
                0x8E, 0x0E,
                0x67, 0x48,
                0xB3,
                0x0C,
                0x7F,
                0xA8,
                0x38,
                0x84,
                0xE8,
                0xDE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_ICLRDebugging
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5A, 0x3C, 0x8F, 0xD2,
                0x34, 0x96,
                0x06, 0x42,
                0xA5,
                0x09,
                0x47,
                0x75,
                0x52,
                0xEE,
                0xFB,
                0x10
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_CLRDebugging
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8D, 0x57, 0xCC, 0xBA,
                0xDD, 0xFB,
                0xA4, 0x48,
                0x96,
                0x9F,
                0x02,
                0xD9,
                0x32,
                0xB7,
                0x46,
                0x34
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_ICLRRuntimeInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD2, 0xD1, 0x39, 0xBD,
                0x2F, 0xBA,
                0x6A, 0x48,
                0x89,
                0xB0,
                0xB4,
                0xB0,
                0xCB,
                0x46,
                0x68,
                0x91
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_ICLRDebuggingLibraryProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x8D, 0xC0, 0x51, 0x31,
                0x09, 0x4D,
                0x9B, 0x4F,
                0x88,
                0x38,
                0x28,
                0x80,
                0xBF,
                0x18,
                0xFE,
                0x51
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_ICLRDebuggingLibraryProvider2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF1, 0x2F, 0x4E, 0xE0,
                0xFD, 0xDC,
                0xD5, 0x45,
                0xBC,
                0xD1,
                0x16,
                0xFF,
                0xF2,
                0xFA,
                0xF7,
                0xBA
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_ICLRDebuggingLibraryProvider3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0xAB, 0x3A, 0xDE,
                0xA0, 0x46,
                0xB4, 0x48,
                0xBF,
                0x0D,
                0x2C,
                0x33,
                0x6E,
                0x69,
                0xEA,
                0x1B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int CreateProcessForLaunch([NativeTypeName("LPWSTR")] char* lpCommandLine, [NativeTypeName("BOOL")] int bSuspendProcess, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] char* lpCurrentDirectory, [NativeTypeName("PDWORD")] uint* pProcessId, [NativeTypeName("HANDLE *")] void** pResumeHandle);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int ResumeProcess([NativeTypeName("HANDLE")] void* hResumeHandle);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int CloseResumeHandle([NativeTypeName("HANDLE")] void* hResumeHandle);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int RegisterForRuntimeStartup([NativeTypeName("DWORD")] uint dwProcessId, [NativeTypeName("PSTARTUP_CALLBACK")] delegate* unmanaged[Cdecl]<IUnknown*, void*, int, void> pfnCallback, [NativeTypeName("PVOID")] void* parameter, [NativeTypeName("PVOID *")] void** ppUnregisterToken);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int RegisterForRuntimeStartupEx([NativeTypeName("DWORD")] uint dwProcessId, [NativeTypeName("LPCWSTR")] char* szApplicationGroupId, [NativeTypeName("PSTARTUP_CALLBACK")] delegate* unmanaged[Cdecl]<IUnknown*, void*, int, void> pfnCallback, [NativeTypeName("PVOID")] void* parameter, [NativeTypeName("PVOID *")] void** ppUnregisterToken);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int RegisterForRuntimeStartup3([NativeTypeName("DWORD")] uint dwProcessId, [NativeTypeName("LPCWSTR")] char* szApplicationGroupId, ICLRDebuggingLibraryProvider3* pLibraryProvider, [NativeTypeName("PSTARTUP_CALLBACK")] delegate* unmanaged[Cdecl]<IUnknown*, void*, int, void> pfnCallback, [NativeTypeName("PVOID")] void* parameter, [NativeTypeName("PVOID *")] void** ppUnregisterToken);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int UnregisterForRuntimeStartup([NativeTypeName("PVOID")] void* pUnregisterToken);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int GetStartupNotificationEvent([NativeTypeName("DWORD")] uint debuggeePID, [NativeTypeName("HANDLE *")] void** phStartupEvent);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int EnumerateCLRs([NativeTypeName("DWORD")] uint debuggeePID, [NativeTypeName("HANDLE **")] void*** ppHandleArrayOut, [NativeTypeName("LPWSTR **")] char*** ppStringArrayOut, [NativeTypeName("DWORD *")] uint* pdwArrayLengthOut);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int CloseCLREnumeration([NativeTypeName("HANDLE *")] void** pHandleArray, [NativeTypeName("LPWSTR *")] char** pStringArray, [NativeTypeName("DWORD")] uint dwArrayLength);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int CreateVersionStringFromModule([NativeTypeName("DWORD")] uint pidDebuggee, [NativeTypeName("LPCWSTR")] char* szModuleName, [NativeTypeName("LPWSTR")] char* pBuffer, [NativeTypeName("DWORD")] uint cchBuffer, [NativeTypeName("DWORD *")] uint* pdwLength);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int CreateDebuggingInterfaceFromVersion([NativeTypeName("LPCWSTR")] char* szDebuggeeVersion, IUnknown** ppCordb);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int CreateDebuggingInterfaceFromVersionEx(int iDebuggerVersion, [NativeTypeName("LPCWSTR")] char* szDebuggeeVersion, IUnknown** ppCordb);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int CreateDebuggingInterfaceFromVersion2(int iDebuggerVersion, [NativeTypeName("LPCWSTR")] char* szDebuggeeVersion, [NativeTypeName("LPCWSTR")] char* szApplicationGroupId, IUnknown** ppCordb);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int CreateDebuggingInterfaceFromVersion3(int iDebuggerVersion, [NativeTypeName("LPCWSTR")] char* szDebuggeeVersion, [NativeTypeName("LPCWSTR")] char* szApplicationGroupId, ICLRDebuggingLibraryProvider3* pLibraryProvider, IUnknown** ppCordb);

    [DllImport("", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("HRESULT")]
    public static extern int RegisterForRuntimeStartupRemotePort([NativeTypeName("LPCWSTR")] char* szIp, [NativeTypeName("DWORD")] uint dwPort, [NativeTypeName("LPCWSTR")] char* szPlatform, [NativeTypeName("BOOL")] int bIsServer, [NativeTypeName("LPCWSTR")] char* szMscordbiPath, [NativeTypeName("LPCWSTR")] char* szAssemblyBasePath, IUnknown** ppCordb);
}
