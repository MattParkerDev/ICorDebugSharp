// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values used to influence behavior during the generation of metadata.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corsetenc-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorSetENC
{
    /// <summary>
    /// <para>Obsolete.</para>
    /// </summary>
    MDSetENCOn = 0x00000001,
    /// <summary>
    /// <para>Obsolete.</para>
    /// </summary>
    MDSetENCOff = 0x00000002,
    /// <summary>
    /// <para>Indicates that whereas metadata can be updated, tokens cannot be moved.</para>
    /// </summary>
    MDUpdateENC = 0x00000001,
    /// <summary>
    /// <para>Indicates that tokens can be moved during updates.</para>
    /// </summary>
    MDUpdateFull = 0x00000002,
    /// <summary>
    /// <para>Indicates that updates can consist only of additions. Tokens cannot be moved.</para>
    /// </summary>
    MDUpdateExtension = 0x00000003,
    /// <summary>
    /// <para>Indicates that compilation is incremental.</para>
    /// </summary>
    MDUpdateIncremental = 0x00000004,
    /// <summary>
    /// <para>Indicates that only changed metadata should be saved.</para>
    /// </summary>
    MDUpdateDelta = 0x00000005,
    /// <summary>
    /// <para>Includes <c>MDUpdateENC</c>, <c>MDUpdateFull</c> and <c>MDUpdateIncremental</c>.</para>
    /// </summary>
    MDUpdateMask = 0x00000007,
}
