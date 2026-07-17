// ReSharper disable InconsistentNaming
using System.Runtime.InteropServices;

namespace ICorDebugSharp;

public static unsafe partial class DbgShim
{
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
