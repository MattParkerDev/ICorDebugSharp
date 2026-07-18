// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains flag values for the treatment of local references.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corlocalrefpreservation-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorLocalRefPreservation
{
    /// <summary>
    /// <para>Preserve no local references.</para>
    /// </summary>
    MDPreserveLocalRefsNone = 0x00000000,
    /// <summary>
    /// <para>Preserve local type references.</para>
    /// </summary>
    MDPreserveLocalTypeRef = 0x00000001,
    /// <summary>
    /// <para>Preserve local member references.</para>
    /// </summary>
    MDPreserveLocalMemberRef = 0x00000002,
}
