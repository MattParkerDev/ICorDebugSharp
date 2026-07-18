// ReSharper disable InconsistentNaming
namespace ICorDebugSharp;

/// <summary>
/// <para>Contains values that describe method implementation features.</para>
/// </summary>
/// <remarks>
/// <para>Documentation adapted from <see href="https://learn.microsoft.com/dotnet/core/unmanaged-api/metadata/enumerations/cormethodimpl-enumeration">Microsoft Learn</see>.</para>
/// </remarks>
public enum CorMethodImpl
{
    /// <summary>
    /// <para>Flags that describe code type.</para>
    /// </summary>
    miCodeTypeMask = 0x0003,
    /// <summary>
    /// <para>Specifies that the method implementation is common intermediate language (CIL).</para>
    /// </summary>
    miIL = 0x0000,
    /// <summary>
    /// <para>Specifies that the method implementation is native.</para>
    /// </summary>
    miNative = 0x0001,
    /// <summary>
    /// <para>Specifies that the method implementation is OPTIL.</para>
    /// </summary>
    miOPTIL = 0x0002,
    /// <summary>
    /// <para>Specifies that the method implementation is provided by the common language runtime.</para>
    /// </summary>
    miRuntime = 0x0003,
    /// <summary>
    /// <para>Flags that indicate whether the code is managed or unmanaged.</para>
    /// </summary>
    miManagedMask = 0x0004,
    /// <summary>
    /// <para>Specifies that the method implementation is unmanaged.</para>
    /// </summary>
    miUnmanaged = 0x0004,
    /// <summary>
    /// <para>Specifies that the method implementation is managed.</para>
    /// </summary>
    miManaged = 0x0000,
    /// <summary>
    /// <para>Specifies that the method is defined. This flag is used primarily in merge scenarios.</para>
    /// </summary>
    miForwardRef = 0x0010,
    /// <summary>
    /// <para>Specifies that the method signature cannot be mangled for an HRESULT conversion.</para>
    /// </summary>
    miPreserveSig = 0x0080,
    /// <summary>
    /// <para>Reserved for internal use by the common language runtime.</para>
    /// </summary>
    miInternalCall = 0x1000,
    /// <summary>
    /// <para>Specifies that the method is single-threaded through its body.</para>
    /// </summary>
    miSynchronized = 0x0020,
    /// <summary>
    /// <para>Specifies that the method cannot be inlined.</para>
    /// </summary>
    miNoInlining = 0x0008,
    /// <summary>
    /// <para>Specifies that the method should be inlined if possible.</para>
    /// </summary>
    miAggressiveInlining = 0x0100,
    /// <summary>
    /// <para>Specifies that the method should not be optimized.</para>
    /// </summary>
    miNoOptimization = 0x0040,
    miAggressiveOptimization = 0x0200,
    miAsync = 0x2000,
    miUserMask = miManagedMask | miForwardRef | miPreserveSig | miInternalCall | miSynchronized | miNoInlining | miAggressiveInlining | miNoOptimization | miAggressiveOptimization | miAsync,
    /// <summary>
    /// <para>The maximum valid value for a <c>CorMethodImpl</c>.</para>
    /// </summary>
    miMaxMethodImplVal = 0xffff,
}
