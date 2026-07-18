// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Specifies flags to select options for thread safety.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corthreadsafetyoptions-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorThreadSafetyOptions
{
    /// <summary>
    /// <para>Default value. Same as <c>MDThreadSafetyOff</c>.</para>
    /// </summary>
    MDThreadSafetyDefault = 0x00000000,
    /// <summary>
    /// <para>Indicates that a reader/writer lock cannot be set.</para>
    /// </summary>
    MDThreadSafetyOff = 0x00000000,
    /// <summary>
    /// <para>Indicates that a reader/writer lock can be set.</para>
    /// </summary>
    MDThreadSafetyOn = 0x00000001,
}
