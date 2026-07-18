// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values that describe the metadata of a property.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corpropertyattr-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorPropertyAttr
{
    /// <summary>
    /// <para>Specifies that the property is special, and that its name describes how.</para>
    /// </summary>
    prSpecialName = 0x0200,
    /// <summary>
    /// <para>Reserved for internal use by the common language runtime.</para>
    /// </summary>
    prReservedMask = 0xf400,
    /// <summary>
    /// <para>Specifies that the common language runtime metadata internal APIs should check the encoding of the property name.</para>
    /// </summary>
    prRTSpecialName = 0x0400,
    /// <summary>
    /// <para>Specifies that the property has a default value.</para>
    /// </summary>
    prHasDefault = 0x1000,
    /// <summary>
    /// <para>Unused.</para>
    /// </summary>
    prUnused = 0xe9ff,
}
