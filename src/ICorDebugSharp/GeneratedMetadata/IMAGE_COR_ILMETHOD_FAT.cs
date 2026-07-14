// ReSharper disable InconsistentNaming
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

public partial struct IMAGE_COR_ILMETHOD_FAT
{
	public uint _bitfield;

	[NativeTypeName("unsigned int : 12")]
	public uint Flags
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		readonly get
		{
			return _bitfield & 0xFFFu;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
			_bitfield = (_bitfield & ~0xFFFu) | (value & 0xFFFu);
		}
	}

	[NativeTypeName("unsigned int : 4")]
	public uint Size
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		readonly get
		{
			return (_bitfield >> 12) & 0xFu;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
			_bitfield = (_bitfield & ~(0xFu << 12)) | ((value & 0xFu) << 12);
		}
	}

	[NativeTypeName("unsigned int : 16")]
	public uint MaxStack
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		readonly get
		{
			return (_bitfield >> 16) & 0xFFFFu;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
			_bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
		}
	}

	[NativeTypeName("uint32_t")]
	public uint CodeSize;

	[NativeTypeName("mdSignature")]
	public uint LocalVarSigTok;
}
