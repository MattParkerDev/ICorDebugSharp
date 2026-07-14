// ReSharper disable InconsistentNaming
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ICorDebugSharp.GeneratedMetadata;

public partial struct IMAGE_COR_ILMETHOD_SECT_EH_CLAUSE_FAT
{
	public CorExceptionFlag Flags;

	[NativeTypeName("uint32_t")]
	public uint TryOffset;

	[NativeTypeName("uint32_t")]
	public uint TryLength;

	[NativeTypeName("uint32_t")]
	public uint HandlerOffset;

	[NativeTypeName("uint32_t")]
	public uint HandlerLength;

	[NativeTypeName("__AnonymousRecord_corhdr_L1168_C5")]
	public _Anonymous_e__Union Anonymous;

	[UnscopedRef]
	public ref uint ClassToken
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.ClassToken;
		}
	}

	[UnscopedRef]
	public ref uint FilterOffset
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.FilterOffset;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous_e__Union
	{
		[FieldOffset(0)]
		[NativeTypeName("uint32_t")]
		public uint ClassToken;

		[FieldOffset(0)]
		[NativeTypeName("uint32_t")]
		public uint FilterOffset;
	}
}
