// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values indicating the level of precision required when querying for the size of a save operation.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corsavesize-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorSaveSize
{
    /// <summary>
    /// <para>Specifies that the return value should be exact.</para>
    /// </summary>
    cssAccurate = 0x0000,
    /// <summary>
    /// <para>Specifies that the return value should be estimated.</para>
    /// </summary>
    cssQuick = 0x0001,
    /// <summary>
    /// <para>Specifies that discardable types should be removed.</para>
    /// </summary>
    cssDiscardTransientCAs = 0x0002,
}
