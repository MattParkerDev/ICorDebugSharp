// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Specifies the type of a module.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corvalidatormoduletype-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorValidatorModuleType
{
    /// <summary>
    /// <para>The module is an invalid type.</para>
    /// </summary>
    ValidatorModuleTypeInvalid = 0x0,
    /// <summary>
    /// <para>The minimum value of the <c>CorValidatorModuleType</c> enum.</para>
    /// </summary>
    ValidatorModuleTypeMin = 0x00000001,
    /// <summary>
    /// <para>The module is a portable executable (PE) file.</para>
    /// </summary>
    ValidatorModuleTypePE = 0x00000001,
    /// <summary>
    /// <para>The module is a .obj file.</para>
    /// </summary>
    ValidatorModuleTypeObj = 0x00000002,
    /// <summary>
    /// <para>The module is an edit-and-continue debugger session.</para>
    /// </summary>
    ValidatorModuleTypeEnc = 0x00000003,
    /// <summary>
    /// <para>The module is one that has been incrementally built.</para>
    /// </summary>
    ValidatorModuleTypeIncr = 0x00000004,
    /// <summary>
    /// <para>The maximum value of the <c>CorValidatorModuleType</c> enum.</para>
    /// </summary>
    ValidatorModuleTypeMax = 0x00000004,
}
