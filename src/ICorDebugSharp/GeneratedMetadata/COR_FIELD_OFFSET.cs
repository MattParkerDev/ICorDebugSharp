// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Stores the offset, within a class, of the specified field.</para>
/// </summary>
/// <remarks>
/// <para><see cref="IMetaDataImport.TryGetClassLayout">IMetaDataImport::GetClassLayout</see> and <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/interfaces/imetadataemit-setclasslayout-method">IMetaDataEmit::SetClassLayout</see> methods take a parameter of type <c>COR_FIELD_OFFSET</c>.</para>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/structures/cor-field-offset-structure">Microsoft Learn</see>.</para>
/// </remarks>
public partial struct COR_FIELD_OFFSET
{
    /// <summary>
    /// <para>An <c>mdFieldDef</c> metadata token that represents the field.</para>
    /// </summary>
    [NativeTypeName("mdFieldDef")]
    public uint ridOfField;

    /// <summary>
    /// <para>The field&#39;s offset within its class.</para>
    /// </summary>
    [NativeTypeName("uint32_t")]
    public uint ulOffset;
}
