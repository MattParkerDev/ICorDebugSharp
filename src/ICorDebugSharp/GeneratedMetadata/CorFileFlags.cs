// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values that describe the type of file defined in a call to <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/interfaces/imetadataassemblyemit-definefile-method">IMetaDataAssemblyEmit::DefineFile</see>.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corfileflags-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorFileFlags
{
    /// <summary>
    /// <para>Indicates that the file is not a resource file.</para>
    /// </summary>
    ffContainsMetaData = 0x0000,
    /// <summary>
    /// <para>Indicates that the file, possibly a resource file, does not contain metadata.</para>
    /// </summary>
    ffContainsNoMetaData = 0x0001,
}
