// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Indicates the visibility of resources encoded in an assembly manifest.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/cormanifestresourceflags-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorManifestResourceFlags
{
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    mrVisibilityMask = 0x0007,
    /// <summary>
    /// <para>The resources are public.</para>
    /// </summary>
    mrPublic = 0x0001,
    /// <summary>
    /// <para>The resources are private.</para>
    /// </summary>
    mrPrivate = 0x0002,
}
