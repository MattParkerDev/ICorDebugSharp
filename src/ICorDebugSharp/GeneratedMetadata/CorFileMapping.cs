// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values that describe the type of file mapping that is returned from a call to the <see cref="IMetaDataInfo.TryGetFileMapping">IMetaDataInfo::GetFileMapping</see> method.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corfilemapping-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorFileMapping
{
    /// <summary>
    /// <para>The file is mapped as a data file. That is, the <c>SEC_IMAGE</c> flag was not passed to the Microsoft Win32 <c>CreateFileMapping</c> function.</para>
    /// </summary>
    fmFlat = 0,
    /// <summary>
    /// <para>The file is mapped for execution, by using either the <c>LoadLibrary</c> function or the <c>CreateFileMapping</c> function with the <c>SEC_IMAGE</c> flag.</para>
    /// </summary>
    fmExecutableImage = 1,
}
