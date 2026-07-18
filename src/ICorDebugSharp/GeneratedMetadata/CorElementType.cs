// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Specifies a common language runtime , a type modifier, or information about a type in a metadata type signature.</para>
/// </summary>
/// <remarks>
/// <para>The type modifiers form the basis for representing more complex types. A <c>CorElementType</c> type modifier value is applied to the value that immediately follows it in the type signature. The value that follows the <c>CorElementType</c> type modifier value can be a <c>CorElementType</c> simple type value, a metadata token, or other value, as specified in the following table.</para>
/// <para><b>Note:</b> All numbers ( number ,  argument Count ,  metadata token ,  rank ,  count , and  bound ) are stored as compressed integers. See  Standard ECMA-335 - Common Language Infrastructure (CLI)  on the ECMA Web site for details.</para>
/// <list type="table">
/// <listheader><term>Type modifier</term><description>Format</description></listheader>
/// <item><term><c>ELEMENT_TYPE_PTR</c></term><description>ELEMENT_TYPE_PTR &lt;a <c>CorElementType</c> value&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_BYREF</c></term><description>ELEMENT_TYPE_BYREF &lt;a <c>CorElementType</c> value&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_VALUETYPE</c></term><description>ELEMENT_TYPE_VALUETYPE &lt;an <c>mdTypeDef</c> metadata token&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_CLASS</c></term><description>ELEMENT_TYPE_CLASS &lt;an <c>mdTypeDef</c> metadata token&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_VAR</c></term><description>ELEMENT_TYPE_VAR &lt;number&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_ARRAY</c></term><description>ELEMENT_TYPE_ARRAY &lt;a <c>CorElementType</c> value&gt; &lt;rank&gt; &lt;count1&gt; &lt;bound1&gt; ... &lt;countN&gt; &lt;boundN&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_GENERICINST</c></term><description>ELEMENT_TYPE_GENERICINST &lt;an <c>mdTypeDef</c> metadata token&gt; &lt;argument Count&gt; &lt;arg1&gt; ... &lt;argN&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_FNPTR</c></term><description>ELEMENT_TYPE_FNPTR &lt;complete signature for the function, including calling convention&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_SZARRAY</c></term><description>ELEMENT_TYPE_SZARRAY &lt;a <c>CorElementType</c> value&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_MVAR</c></term><description>ELEMENT_TYPE_MVAR &lt;number&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_CMOD_REQD</c></term><description>ELEMENT_TYPE_&lt;a <c>mdTypeRef</c> or <c>mdTypeDef</c> metadata token&gt;</description></item>
/// <item><term><c>ELEMENT_TYPE_CMOD_OPT</c></term><description>E_T_CMOD_OPT &lt;a <c>mdTypeRef</c> or <c>mdTypeDef</c> metadata token&gt;</description></item>
/// </list>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/corelementtype-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorElementType
{
    /// <summary>
    /// <para>Used internally.</para>
    /// </summary>
    END = 0x00,
    /// <summary>
    /// <para>A void type.</para>
    /// </summary>
    VOID = 0x01,
    /// <summary>
    /// <para>A Boolean type</para>
    /// </summary>
    BOOLEAN = 0x02,
    /// <summary>
    /// <para>A character type.</para>
    /// </summary>
    CHAR = 0x03,
    /// <summary>
    /// <para>A signed 1-byte integer.</para>
    /// </summary>
    I1 = 0x04,
    /// <summary>
    /// <para>An unsigned 1-byte integer.</para>
    /// </summary>
    U1 = 0x05,
    /// <summary>
    /// <para>A signed 2-byte integer.</para>
    /// </summary>
    I2 = 0x06,
    /// <summary>
    /// <para>An unsigned 2-byte integer.</para>
    /// </summary>
    U2 = 0x07,
    /// <summary>
    /// <para>A signed 4-byte integer.</para>
    /// </summary>
    I4 = 0x08,
    /// <summary>
    /// <para>An unsigned 4-byte integer.</para>
    /// </summary>
    U4 = 0x09,
    /// <summary>
    /// <para>A signed 8-byte integer.</para>
    /// </summary>
    I8 = 0x0a,
    /// <summary>
    /// <para>An unsigned 8-byte integer.</para>
    /// </summary>
    U8 = 0x0b,
    /// <summary>
    /// <para>A 4-byte floating point.</para>
    /// </summary>
    R4 = 0x0c,
    /// <summary>
    /// <para>An 8-byte floating point.</para>
    /// </summary>
    R8 = 0x0d,
    /// <summary>
    /// <para>A System.String type.</para>
    /// </summary>
    STRING = 0x0e,
    /// <summary>
    /// <para>A pointer type modifier.</para>
    /// </summary>
    PTR = 0x0f,
    /// <summary>
    /// <para>A reference type modifier.</para>
    /// </summary>
    BYREF = 0x10,
    /// <summary>
    /// <para>A value type modifier.</para>
    /// </summary>
    VALUETYPE = 0x11,
    /// <summary>
    /// <para>A class type modifier.</para>
    /// </summary>
    CLASS = 0x12,
    /// <summary>
    /// <para>A class variable type modifier.</para>
    /// </summary>
    VAR = 0x13,
    /// <summary>
    /// <para>A multi-dimensional array type modifier.</para>
    /// </summary>
    ARRAY = 0x14,
    /// <summary>
    /// <para>A type modifier for generic types.</para>
    /// </summary>
    GENERICINST = 0x15,
    /// <summary>
    /// <para>A typed reference.</para>
    /// </summary>
    TYPEDBYREF = 0x16,
    /// <summary>
    /// <para>Size of a native integer.</para>
    /// </summary>
    I = 0x18,
    /// <summary>
    /// <para>Size of an unsigned native integer.</para>
    /// </summary>
    U = 0x19,
    /// <summary>
    /// <para>A pointer to a function.</para>
    /// </summary>
    FNPTR = 0x1b,
    /// <summary>
    /// <para>A System.Object type.</para>
    /// </summary>
    OBJECT = 0x1c,
    /// <summary>
    /// <para>A single-dimensional, zero lower-bound array type modifier.</para>
    /// </summary>
    SZARRAY = 0x1d,
    /// <summary>
    /// <para>A method variable type modifier.</para>
    /// </summary>
    MVAR = 0x1e,
    /// <summary>
    /// <para>A C language required modifier.</para>
    /// </summary>
    CMOD_REQD = 0x1f,
    /// <summary>
    /// <para>A C language optional modifier.</para>
    /// </summary>
    CMOD_OPT = 0x20,
    /// <summary>
    /// <para>Used internally.</para>
    /// </summary>
    INTERNAL = 0x21,
    CMOD_INTERNAL = 0x22,
    /// <summary>
    /// <para>An invalid type.</para>
    /// </summary>
    MAX = 0x23,
    /// <summary>
    /// <para>Used internally.</para>
    /// </summary>
    MODIFIER = 0x40,
    /// <summary>
    /// <para>A type modifier that is a sentinel for a list of a variable number of parameters.</para>
    /// </summary>
    SENTINEL = 0x01 | MODIFIER,
    /// <summary>
    /// <para>Used internally.</para>
    /// </summary>
    PINNED = 0x05 | MODIFIER,
}
