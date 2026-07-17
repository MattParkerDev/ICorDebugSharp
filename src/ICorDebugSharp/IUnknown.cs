// // ReSharper disable InconsistentNaming
// using System;
// using System.Runtime.CompilerServices;
// using System.Runtime.InteropServices;
//
// namespace ICorDebugSharp;
//
// [Guid("00000000-0000-0000-C000-000000000046")]
// [NativeTypeName("struct IUnknown")]
// public unsafe partial struct IUnknown : IUnknown.Interface
// {
//     public void** lpVtbl;
//
//     [MethodImpl(MethodImplOptions.AggressiveInlining)]
//     [VtblIndex(0)]
//     [return: NativeTypeName("HRESULT")]
//     public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
//     {
//         return ((delegate* unmanaged[MemberFunction]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
//     }
//
//     [MethodImpl(MethodImplOptions.AggressiveInlining)]
//     [VtblIndex(1)]
//     [return: NativeTypeName("ULONG")]
//     public uint AddRef()
//     {
//         return ((delegate* unmanaged[MemberFunction]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
//     }
//
//     [MethodImpl(MethodImplOptions.AggressiveInlining)]
//     [VtblIndex(2)]
//     [return: NativeTypeName("ULONG")]
//     public uint Release()
//     {
//         return ((delegate* unmanaged[MemberFunction]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
//     }
//
//     public interface Interface
//     {
//         [VtblIndex(0)]
//         [return: NativeTypeName("HRESULT")]
//         int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject);
//
//         [VtblIndex(1)]
//         [return: NativeTypeName("ULONG")]
//         uint AddRef();
//
//         [VtblIndex(2)]
//         [return: NativeTypeName("ULONG")]
//         uint Release();
//     }
//
//     public partial struct Vtbl<TSelf>
//         where TSelf : unmanaged, Interface
//     {
//         [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
//         public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;
//
//         [NativeTypeName("ULONG () __attribute__((stdcall))")]
//         public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;
//
//         [NativeTypeName("ULONG () __attribute__((stdcall))")]
//         public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;
//     }
// }
