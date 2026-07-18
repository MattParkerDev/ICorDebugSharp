// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values that describe the  parameters for generic types, as used in calls to <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/interfaces/imetadataemit2-definegenericparam-method">IMetaDataEmit2::DefineGenericParam</see>.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corgenericparamattr-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorGenericParamAttr
{
    /// <summary>
    /// <para>Parameter variance applies only to generic parameters for interfaces and delegates.</para>
    /// </summary>
    gpVarianceMask = 0x0003,
    /// <summary>
    /// <para>Indicates the absence of variance.</para>
    /// </summary>
    gpNonVariant = 0x0000,
    /// <summary>
    /// <para>Indicates covariance.</para>
    /// </summary>
    gpCovariant = 0x0001,
    /// <summary>
    /// <para>Indicates contravariance.</para>
    /// </summary>
    gpContravariant = 0x0002,
    /// <summary>
    /// <para>Special constraints can apply to any  parameter.</para>
    /// </summary>
    gpSpecialConstraintMask = 0x003C,
    /// <summary>
    /// <para>Indicates that no constraint applies to the  parameter.</para>
    /// </summary>
    gpNoSpecialConstraint = 0x0000,
    /// <summary>
    /// <para>Indicates that the  parameter must be a reference type.</para>
    /// </summary>
    gpReferenceTypeConstraint = 0x0004,
    /// <summary>
    /// <para>Indicates that the  parameter must be a value type that cannot be a null value.</para>
    /// </summary>
    gpNotNullableValueTypeConstraint = 0x0008,
    /// <summary>
    /// <para>Indicates that the  parameter must have a default public constructor that takes no parameters.</para>
    /// </summary>
    gpDefaultConstructorConstraint = 0x0010,
    /// <summary>
    /// <para>Indicates that the  parameter can be a <see href="xref:System.Type.IsByRefLike">byref-like type</see>. (Available since .NET 7.)</para>
    /// </summary>
    gpAllowByRefLike = 0x0020,
}
