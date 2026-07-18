// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains flag values that control metadata behavior upon opening manifest files.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/coropenflags-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorOpenFlags
{
    /// <summary>
    /// <para>Indicates that the file should be opened for reading only.</para>
    /// </summary>
    ofRead = 0x00000000,
    /// <summary>
    /// <para>Indicates that the file should be opened for writing.<br/><br/> If you are using the <c>ofWrite</c> flag when opening a .winmd file, you should also pass the <c>ofNoTransform</c> flag.</para>
    /// </summary>
    ofWrite = 0x00000001,
    /// <summary>
    /// <para>A mask for reading and writing.</para>
    /// </summary>
    ofReadWriteMask = 0x00000001,
    /// <summary>
    /// <para>Indicates that the file should be read into memory. Metadata should maintain its own copy.</para>
    /// </summary>
    ofCopyMemory = 0x00000002,
    /// <summary>
    /// <para>Indicates that the file should be opened for reading, and that a call to <c>QueryInterface</c> for an <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/interfaces/imetadataemit-interface">IMetaDataEmit</see> cannot be made.</para>
    /// </summary>
    ofReadOnly = 0x00000010,
    /// <summary>
    /// <para>Indicates that the memory was allocated using a call to <see href="https://learn.microsoft.com/windows/desktop/api/combaseapi/nf-combaseapi-cotaskmemalloc">CoTaskMemAlloc</see> and will be freed by the metadata.</para>
    /// </summary>
    ofTakeOwnership = 0x00000020,
    /// <summary>
    /// <para>Obsolete. This flag is ignored.</para>
    /// </summary>
    ofNoTypeLib = 0x00000080,
    /// <summary>
    /// <para>Indicates that automatic transforms of .winmd files should be disabled. In other words, the projection of a Windows Runtime type to a .NET type should be disabled. For more information, see <see href="https://learn.microsoft.com/archive/msdn-magazine/2012/windows-8-special-issue/windows-runtime-and-the-clr-underneath-the-hood-with-net-and-the-windows-runtime">Windows Runtime and the CLR - Underneath the Hood with .NET and the Windows Runtime</see>.</para>
    /// </summary>
    ofNoTransform = 0x00001000,
    /// <summary>
    /// <para>Reserved for internal use.</para>
    /// </summary>
    ofReserved1 = 0x00000100,
    /// <summary>
    /// <para>Reserved for internal use.</para>
    /// </summary>
    ofReserved2 = 0x00000200,
    ofReserved3 = 0x00000400,
    /// <summary>
    /// <para>Reserved for internal use.</para>
    /// </summary>
    ofReserved = unchecked((int)(0xffffef40)),
}
