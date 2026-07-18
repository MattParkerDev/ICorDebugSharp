// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Specifies the security actions that can be performed using declarative security.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/cordeclsecurity-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorDeclSecurity
{
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    dclActionMask = 0x001f,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    dclActionNil = 0x0000,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    dclRequest = 0x0001,
    /// <summary>
    /// <para>All callers higher in the call stack are required to have been granted the permission specified by the current permission object.</para>
    /// </summary>
    dclDemand = 0x0002,
    /// <summary>
    /// <para>The calling code can access the resource identified by the current permission object, even if callers higher in the stack have not been granted permission to access the resource</para>
    /// </summary>
    dclAssert = 0x0003,
    /// <summary>
    /// <para>The ability to access the resource specified by the current permission object is denied to callers, even if they have been granted permission to access it.</para>
    /// </summary>
    dclDeny = 0x0004,
    /// <summary>
    /// <para>Only the resources specified by this permission object can be accessed, even if the code has been granted permission to access other resources.</para>
    /// </summary>
    dclPermitOnly = 0x0005,
    /// <summary>
    /// <para>The immediate caller is required to have been granted the specified permission for a given period of time.</para>
    /// </summary>
    dclLinktimeCheck = 0x0006,
    /// <summary>
    /// <para>The derived class inheriting another class or overriding a method is required to have been granted the specified permission.</para>
    /// </summary>
    dclInheritanceCheck = 0x0007,
    /// <summary>
    /// <para>The caller can request for the minimum permissions required for code to run. This action can only be used within the scope of the assembly.</para>
    /// </summary>
    dclRequestMinimum = 0x0008,
    /// <summary>
    /// <para>The caller can request for additional permissions that are optional (not required to run). This request implicitly refuses all other permissions not specifically requested. This action can only be used within the scope of the assembly.</para>
    /// </summary>
    dclRequestOptional = 0x0009,
    /// <summary>
    /// <para>The caller&#39;s request for permissions that might be misused will not be granted. This action can only be used within the scope of the assembly.</para>
    /// </summary>
    dclRequestRefuse = 0x000a,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    dclPrejitGrant = 0x000b,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    dclPrejitDenied = 0x000c,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    dclNonCasDemand = 0x000d,
    /// <summary>
    /// <para>The immediate caller is required to have been granted the specified permission.</para>
    /// </summary>
    dclNonCasLinkDemand = 0x000e,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    dclNonCasInheritance = 0x000f,
    /// <summary>
    /// <para>Reserved.</para>
    /// </summary>
    dclMaximumValue = 0x000f,
}
