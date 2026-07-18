// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Specifies options for a PInvoke call.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corpinvokemap-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorPinvokeMap
{
    /// <summary>
    /// <para>Use each member name as specified.</para>
    /// </summary>
    pmNoMangle = 0x0001,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    pmCharSetMask = 0x0006,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    pmCharSetNotSpec = 0x0000,
    /// <summary>
    /// <para>Marshal strings as multiple-byte character strings.</para>
    /// </summary>
    pmCharSetAnsi = 0x0002,
    /// <summary>
    /// <para>Marshal strings as Unicode 2-byte characters.</para>
    /// </summary>
    pmCharSetUnicode = 0x0004,
    /// <summary>
    /// <para>Automatically marshal strings appropriately for the target operating system. The default is Unicode on Windows.</para>
    /// </summary>
    pmCharSetAuto = 0x0006,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    pmBestFitUseAssem = 0x0000,
    /// <summary>
    /// <para>Perform best-fit mapping of Unicode characters that lack an exact match in the ANSI character set.</para>
    /// </summary>
    pmBestFitEnabled = 0x0010,
    /// <summary>
    /// <para>Do not perform best-fit mapping of Unicode characters. In this case, all unmappable characters will be replaced by a ‘?’.</para>
    /// </summary>
    pmBestFitDisabled = 0x0020,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    pmBestFitMask = 0x0030,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    pmThrowOnUnmappableCharUseAssem = 0x0000,
    /// <summary>
    /// <para>Throw an exception when the interop marshaller encounters an unmappable character.</para>
    /// </summary>
    pmThrowOnUnmappableCharEnabled = 0x1000,
    /// <summary>
    /// <para>Do not throw an exception when the interop marshaller encounters an unmappable character.</para>
    /// </summary>
    pmThrowOnUnmappableCharDisabled = 0x2000,
    /// <summary>
    /// <para>Reserved</para>
    /// </summary>
    pmThrowOnUnmappableCharMask = 0x3000,
    /// <summary>
    /// <para>Allow the callee to call the Win32 <c>SetLastError</c> function before returning from the attributed method.</para>
    /// </summary>
    pmSupportsLastError = 0x0040,
    /// <summary>
    /// <para>Reserved</para>
    /// </summary>
    pmCallConvMask = 0x0700,
    /// <summary>
    /// <para>Use the default platform calling convention. For example, on Windows the default is <c>StdCall</c> and on Windows CE .NET it is <c>Cdecl</c>.</para>
    /// </summary>
    pmCallConvWinapi = 0x0100,
    /// <summary>
    /// <para>Use the <c>Cdecl</c> calling convention. In this case, the caller cleans the stack. This enables calling functions with <c>varargs</c> (that is, functions that accept a variable number of parameters).</para>
    /// </summary>
    pmCallConvCdecl = 0x0200,
    /// <summary>
    /// <para>Use the <c>StdCall</c> calling convention. In this case, the callee cleans the stack. This is the default convention for calling unmanaged functions with platform invoke.</para>
    /// </summary>
    pmCallConvStdcall = 0x0300,
    /// <summary>
    /// <para>Use the <c>ThisCall</c> calling convention. In this case, the first parameter is the <c>this</c> pointer and is stored in register ECX. Other parameters are pushed on the stack. The <c>ThisCall</c> calling convention is used to call methods on classes exported from an unmanaged DLL.</para>
    /// </summary>
    pmCallConvThiscall = 0x0400,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    pmCallConvFastcall = 0x0500,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    pmMaxValue = 0xFFFF,
}
