// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains flag values that control the behavior during importation of an assembly outside the current scope.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corimportoptions-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorImportOptions
{
    /// <summary>
    /// <para>Indicates the default behavior, which is to skip deleted records.</para>
    /// </summary>
    MDImportOptionDefault = 0x00000000,
    /// <summary>
    /// <para>Indicates that all metadata should be enumerated.</para>
    /// </summary>
    MDImportOptionAll = unchecked((int)(0xFFFFFFFF)),
    /// <summary>
    /// <para>Indicates that all TypeDefs, including deleted ones, should be enumerated.</para>
    /// </summary>
    MDImportOptionAllTypeDefs = 0x00000001,
    /// <summary>
    /// <para>Indicates that all MethodDefs, including deleted ones, should be enumerated.</para>
    /// </summary>
    MDImportOptionAllMethodDefs = 0x00000002,
    /// <summary>
    /// <para>Indicates that all FieldDefs, including deleted ones, should be enumerated.</para>
    /// </summary>
    MDImportOptionAllFieldDefs = 0x00000004,
    /// <summary>
    /// <para>Indicates that all PropertyDefs, including deleted ones, should be enumerated.</para>
    /// </summary>
    MDImportOptionAllProperties = 0x00000008,
    /// <summary>
    /// <para>Indicates that all EventDefs, including deleted ones, should be enumerated.</para>
    /// </summary>
    MDImportOptionAllEvents = 0x00000010,
    /// <summary>
    /// <para>Indicates that all custom attributes, including deleted ones, should be enumerated.</para>
    /// </summary>
    MDImportOptionAllCustomAttributes = 0x00000020,
    /// <summary>
    /// <para>Indicates that all exported types, including deleted ones, should be enumerated.</para>
    /// </summary>
    MDImportOptionAllExportedTypes = 0x00000040,
}
