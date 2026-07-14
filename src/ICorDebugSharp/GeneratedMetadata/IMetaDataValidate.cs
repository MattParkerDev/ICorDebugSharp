// ReSharper disable InconsistentNaming
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataValidate : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMetaDataValidate : IMetaDataValidate.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] _GUID* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataValidate*, _GUID*, void**, nint>)(lpVtbl[0]))((IMetaDataValidate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataValidate*, nuint>)(lpVtbl[1]))((IMetaDataValidate*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataValidate*, nuint>)(lpVtbl[2]))((IMetaDataValidate*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint ValidatorInit([NativeTypeName("DWORD")] nuint dwModuleType, IUnknown* pUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataValidate*, nuint, IUnknown*, nint>)(lpVtbl[3]))((IMetaDataValidate*)Unsafe.AsPointer(ref this), dwModuleType, pUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public nint ValidateMetaData()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataValidate*, nint>)(lpVtbl[4]))((IMetaDataValidate*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        nint ValidatorInit([NativeTypeName("DWORD")] nuint dwModuleType, IUnknown* pUnk);

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        nint ValidateMetaData();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, _GUID*, void**, nint> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint> Release;

        [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, IUnknown*, nint> ValidatorInit;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nint> ValidateMetaData;
    }
}
