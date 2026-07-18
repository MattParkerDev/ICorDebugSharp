// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values that describe the relationship between a method and an associated property or event.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/cormethodsemanticsattr-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorMethodSemanticsAttr
{
    /// <summary>
    /// <para>Specifies that the method is a <c>set</c> accessor for a property.</para>
    /// </summary>
    msSetter = 0x0001,
    /// <summary>
    /// <para>Specifies that the method is a <c>get</c> accessor for a property.</para>
    /// </summary>
    msGetter = 0x0002,
    /// <summary>
    /// <para>Specifies that the method has a relationship to a property or an event other than those defined here.</para>
    /// </summary>
    msOther = 0x0004,
    /// <summary>
    /// <para>Specifies that the method adds handler methods for an event.</para>
    /// </summary>
    msAddOn = 0x0008,
    /// <summary>
    /// <para>Specifies that the method removes handler methods for an event.</para>
    /// </summary>
    msRemoveOn = 0x0010,
    /// <summary>
    /// <para>Specifies that the method raises an event.</para>
    /// </summary>
    msFire = 0x0020,
}
