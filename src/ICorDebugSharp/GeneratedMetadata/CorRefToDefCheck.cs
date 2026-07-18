// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Specifies flags to control which referenced items are converted to their definitions in order to optimize the code.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/correftodefcheck-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorRefToDefCheck
{
    /// <summary>
    /// <para>Specifies that type references and member references should be converted to definitions. This is the default value (<c>MDTypeRefToDef</c>  <c>MDMemberRefToDef</c>).</para>
    /// </summary>
    MDRefToDefDefault = 0x00000003,
    /// <summary>
    /// <para>Specifies that all referenced items should be converted to definitions.</para>
    /// </summary>
    MDRefToDefAll = unchecked((int)(0xffffffff)),
    /// <summary>
    /// <para>Specifies that no referenced items should be converted to definitions.</para>
    /// </summary>
    MDRefToDefNone = 0x00000000,
    /// <summary>
    /// <para>Specifies that only type references should be converted to type definitions.</para>
    /// </summary>
    MDTypeRefToDef = 0x00000001,
    /// <summary>
    /// <para>Specifies that only member references should be converted to definitions. That is, member references should be converted to either method definitions or field definitions.</para>
    /// </summary>
    MDMemberRefToDef = 0x00000002,
}
