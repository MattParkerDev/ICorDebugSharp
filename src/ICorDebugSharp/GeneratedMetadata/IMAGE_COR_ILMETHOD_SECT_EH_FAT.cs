// ReSharper disable InconsistentNaming
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ICorDebugSharp.GeneratedMetadata;

public partial struct IMAGE_COR_ILMETHOD_SECT_EH_FAT
{
	public IMAGE_COR_ILMETHOD_SECT_FAT SectFat;

	[NativeTypeName("IMAGE_COR_ILMETHOD_SECT_EH_CLAUSE_FAT[1]")]
	public _Clauses_e__FixedBuffer Clauses;

	public partial struct _Clauses_e__FixedBuffer
	{
		public IMAGE_COR_ILMETHOD_SECT_EH_CLAUSE_FAT e0;

		[UnscopedRef]
		public ref IMAGE_COR_ILMETHOD_SECT_EH_CLAUSE_FAT this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ref Unsafe.Add(ref e0, index);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[UnscopedRef]
		public Span<IMAGE_COR_ILMETHOD_SECT_EH_CLAUSE_FAT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
	}
}
