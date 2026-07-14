// ReSharper disable InconsistentNaming
using System;
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataEmit : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMetaDataEmit : IMetaDataEmit.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, Guid*, void**, nint>)(lpVtbl[0]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, nuint>)(lpVtbl[1]))((IMetaDataEmit*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, nuint>)(lpVtbl[2]))((IMetaDataEmit*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint SetModuleProps([NativeTypeName("LPCWSTR")] uint* szName)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint*, nint>)(lpVtbl[3]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), szName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public nint Save([NativeTypeName("LPCWSTR")] uint* szFile, [NativeTypeName("DWORD")] nuint dwSaveFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint*, nuint, nint>)(lpVtbl[4]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), szFile, dwSaveFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("HRESULT")]
    public nint SaveToStream(IStream* pIStream, [NativeTypeName("DWORD")] nuint dwSaveFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, IStream*, nuint, nint>)(lpVtbl[5]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pIStream, dwSaveFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("HRESULT")]
    public nint GetSaveSize(CorSaveSize fSave, [NativeTypeName("DWORD *")] nuint* pdwSaveSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, CorSaveSize, nuint*, nint>)(lpVtbl[6]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), fSave, pdwSaveSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineTypeDef([NativeTypeName("LPCWSTR")] uint* szTypeDef, [NativeTypeName("DWORD")] nuint dwTypeDefFlags, [NativeTypeName("mdToken")] uint tkExtends, [NativeTypeName("mdToken[]")] uint* rtkImplements, [NativeTypeName("mdTypeDef *")] uint* ptd)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint*, nuint, uint, uint*, uint*, nint>)(lpVtbl[7]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), szTypeDef, dwTypeDefFlags, tkExtends, rtkImplements, ptd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineNestedType([NativeTypeName("LPCWSTR")] uint* szTypeDef, [NativeTypeName("DWORD")] nuint dwTypeDefFlags, [NativeTypeName("mdToken")] uint tkExtends, [NativeTypeName("mdToken[]")] uint* rtkImplements, [NativeTypeName("mdTypeDef")] uint tdEncloser, [NativeTypeName("mdTypeDef *")] uint* ptd)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint*, nuint, uint, uint*, uint, uint*, nint>)(lpVtbl[8]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), szTypeDef, dwTypeDefFlags, tkExtends, rtkImplements, tdEncloser, ptd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("HRESULT")]
    public nint SetHandler(IUnknown* pUnk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, IUnknown*, nint>)(lpVtbl[9]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineMethod([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("DWORD")] nuint dwMethodFlags, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("ULONG")] nuint ulCodeRVA, [NativeTypeName("DWORD")] nuint dwImplFlags, [NativeTypeName("mdMethodDef *")] uint* pmd)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, uint*, nuint, byte*, nuint, nuint, nuint, uint*, nint>)(lpVtbl[10]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), td, szName, dwMethodFlags, pvSigBlob, cbSigBlob, ulCodeRVA, dwImplFlags, pmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineMethodImpl([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("mdToken")] uint tkBody, [NativeTypeName("mdToken")] uint tkDecl)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, uint, uint, nint>)(lpVtbl[11]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), td, tkBody, tkDecl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineTypeRefByName([NativeTypeName("mdToken")] uint tkResolutionScope, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdTypeRef *")] uint* ptr)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, uint*, uint*, nint>)(lpVtbl[12]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tkResolutionScope, szName, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineImportType(IMetaDataAssemblyImport* pAssemImport, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, IMetaDataImport* pImport, [NativeTypeName("mdTypeDef")] uint tdImport, IMetaDataAssemblyEmit* pAssemEmit, [NativeTypeName("mdTypeRef *")] uint* ptr)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, IMetaDataAssemblyImport*, void*, nuint, IMetaDataImport*, uint, IMetaDataAssemblyEmit*, uint*, nint>)(lpVtbl[13]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pAssemImport, pbHashValue, cbHashValue, pImport, tdImport, pAssemEmit, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineMemberRef([NativeTypeName("mdToken")] uint tkImport, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("mdMemberRef *")] uint* pmr)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, uint*, byte*, nuint, uint*, nint>)(lpVtbl[14]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tkImport, szName, pvSigBlob, cbSigBlob, pmr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineImportMember(IMetaDataAssemblyImport* pAssemImport, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, IMetaDataImport* pImport, [NativeTypeName("mdToken")] uint mbMember, IMetaDataAssemblyEmit* pAssemEmit, [NativeTypeName("mdToken")] uint tkParent, [NativeTypeName("mdMemberRef *")] uint* pmr)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, IMetaDataAssemblyImport*, void*, nuint, IMetaDataImport*, uint, IMetaDataAssemblyEmit*, uint, uint*, nint>)(lpVtbl[15]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pAssemImport, pbHashValue, cbHashValue, pImport, mbMember, pAssemEmit, tkParent, pmr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineEvent([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szEvent, [NativeTypeName("DWORD")] nuint dwEventFlags, [NativeTypeName("mdToken")] uint tkEventType, [NativeTypeName("mdMethodDef")] uint mdAddOn, [NativeTypeName("mdMethodDef")] uint mdRemoveOn, [NativeTypeName("mdMethodDef")] uint mdFire, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethods, [NativeTypeName("mdEvent *")] uint* pmdEvent)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, uint*, nuint, uint, uint, uint, uint, uint*, uint*, nint>)(lpVtbl[16]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), td, szEvent, dwEventFlags, tkEventType, mdAddOn, mdRemoveOn, mdFire, rmdOtherMethods, pmdEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [return: NativeTypeName("HRESULT")]
    public nint SetClassLayout([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("DWORD")] nuint dwPackSize, [NativeTypeName("COR_FIELD_OFFSET[]")] COR_FIELD_OFFSET* rFieldOffsets, [NativeTypeName("ULONG")] nuint ulClassSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, COR_FIELD_OFFSET*, nuint, nint>)(lpVtbl[17]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), td, dwPackSize, rFieldOffsets, ulClassSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("HRESULT")]
    public nint DeleteClassLayout([NativeTypeName("mdTypeDef")] uint td)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nint>)(lpVtbl[18]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), td);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [return: NativeTypeName("HRESULT")]
    public nint SetFieldMarshal([NativeTypeName("mdToken")] uint tk, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvNativeType, [NativeTypeName("ULONG")] nuint cbNativeType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, byte*, nuint, nint>)(lpVtbl[19]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tk, pvNativeType, cbNativeType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("HRESULT")]
    public nint DeleteFieldMarshal([NativeTypeName("mdToken")] uint tk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nint>)(lpVtbl[20]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("HRESULT")]
    public nint DefinePermissionSet([NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD")] nuint dwAction, [NativeTypeName("const void *")] void* pvPermission, [NativeTypeName("ULONG")] nuint cbPermission, [NativeTypeName("mdPermission *")] uint* ppm)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, void*, nuint, uint*, nint>)(lpVtbl[21]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tk, dwAction, pvPermission, cbPermission, ppm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("HRESULT")]
    public nint SetRVA([NativeTypeName("mdMethodDef")] uint md, [NativeTypeName("ULONG")] nuint ulRVA)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, nint>)(lpVtbl[22]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), md, ulRVA);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("HRESULT")]
    public nint GetTokenFromSig([NativeTypeName("PCCOR_SIGNATURE")] byte* pvSig, [NativeTypeName("ULONG")] nuint cbSig, [NativeTypeName("mdSignature *")] uint* pmsig)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, byte*, nuint, uint*, nint>)(lpVtbl[23]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pvSig, cbSig, pmsig);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineModuleRef([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdModuleRef *")] uint* pmur)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint*, uint*, nint>)(lpVtbl[24]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), szName, pmur);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [return: NativeTypeName("HRESULT")]
    public nint SetParent([NativeTypeName("mdMemberRef")] uint mr, [NativeTypeName("mdToken")] uint tk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, uint, nint>)(lpVtbl[25]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), mr, tk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("HRESULT")]
    public nint GetTokenFromTypeSpec([NativeTypeName("PCCOR_SIGNATURE")] byte* pvSig, [NativeTypeName("ULONG")] nuint cbSig, [NativeTypeName("mdTypeSpec *")] uint* ptypespec)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, byte*, nuint, uint*, nint>)(lpVtbl[26]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pvSig, cbSig, ptypespec);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [return: NativeTypeName("HRESULT")]
    public nint SaveToMemory(void* pbData, [NativeTypeName("ULONG")] nuint cbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, void*, nuint, nint>)(lpVtbl[27]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pbData, cbData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineUserString([NativeTypeName("LPCWSTR")] uint* szString, [NativeTypeName("ULONG")] nuint cchString, [NativeTypeName("mdString *")] uint* pstk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint*, nuint, uint*, nint>)(lpVtbl[28]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), szString, cchString, pstk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    [return: NativeTypeName("HRESULT")]
    public nint DeleteToken([NativeTypeName("mdToken")] uint tkObj)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nint>)(lpVtbl[29]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tkObj);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [return: NativeTypeName("HRESULT")]
    public nint SetMethodProps([NativeTypeName("mdMethodDef")] uint md, [NativeTypeName("DWORD")] nuint dwMethodFlags, [NativeTypeName("ULONG")] nuint ulCodeRVA, [NativeTypeName("DWORD")] nuint dwImplFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, nuint, nuint, nint>)(lpVtbl[30]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), md, dwMethodFlags, ulCodeRVA, dwImplFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [return: NativeTypeName("HRESULT")]
    public nint SetTypeDefProps([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("DWORD")] nuint dwTypeDefFlags, [NativeTypeName("mdToken")] uint tkExtends, [NativeTypeName("mdToken[]")] uint* rtkImplements)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, uint, uint*, nint>)(lpVtbl[31]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), td, dwTypeDefFlags, tkExtends, rtkImplements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [return: NativeTypeName("HRESULT")]
    public nint SetEventProps([NativeTypeName("mdEvent")] uint ev, [NativeTypeName("DWORD")] nuint dwEventFlags, [NativeTypeName("mdToken")] uint tkEventType, [NativeTypeName("mdMethodDef")] uint mdAddOn, [NativeTypeName("mdMethodDef")] uint mdRemoveOn, [NativeTypeName("mdMethodDef")] uint mdFire, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethods)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, uint, uint, uint, uint, uint*, nint>)(lpVtbl[32]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), ev, dwEventFlags, tkEventType, mdAddOn, mdRemoveOn, mdFire, rmdOtherMethods);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [return: NativeTypeName("HRESULT")]
    public nint SetPermissionSetProps([NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD")] nuint dwAction, [NativeTypeName("const void *")] void* pvPermission, [NativeTypeName("ULONG")] nuint cbPermission, [NativeTypeName("mdPermission *")] uint* ppm)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, void*, nuint, uint*, nint>)(lpVtbl[33]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tk, dwAction, pvPermission, cbPermission, ppm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    [return: NativeTypeName("HRESULT")]
    public nint DefinePinvokeMap([NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD")] nuint dwMappingFlags, [NativeTypeName("LPCWSTR")] uint* szImportName, [NativeTypeName("mdModuleRef")] uint mrImportDLL)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, uint*, uint, nint>)(lpVtbl[34]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tk, dwMappingFlags, szImportName, mrImportDLL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    [return: NativeTypeName("HRESULT")]
    public nint SetPinvokeMap([NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD")] nuint dwMappingFlags, [NativeTypeName("LPCWSTR")] uint* szImportName, [NativeTypeName("mdModuleRef")] uint mrImportDLL)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, uint*, uint, nint>)(lpVtbl[35]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tk, dwMappingFlags, szImportName, mrImportDLL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    [return: NativeTypeName("HRESULT")]
    public nint DeletePinvokeMap([NativeTypeName("mdToken")] uint tk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nint>)(lpVtbl[36]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineCustomAttribute([NativeTypeName("mdToken")] uint tkOwner, [NativeTypeName("mdToken")] uint tkCtor, [NativeTypeName("const void *")] void* pCustomAttribute, [NativeTypeName("ULONG")] nuint cbCustomAttribute, [NativeTypeName("mdCustomAttribute *")] uint* pcv)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, uint, void*, nuint, uint*, nint>)(lpVtbl[37]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tkOwner, tkCtor, pCustomAttribute, cbCustomAttribute, pcv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    [return: NativeTypeName("HRESULT")]
    public nint SetCustomAttributeValue([NativeTypeName("mdCustomAttribute")] uint pcv, [NativeTypeName("const void *")] void* pCustomAttribute, [NativeTypeName("ULONG")] nuint cbCustomAttribute)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, void*, nuint, nint>)(lpVtbl[38]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pcv, pCustomAttribute, cbCustomAttribute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineField([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("DWORD")] nuint dwFieldFlags, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue, [NativeTypeName("mdFieldDef *")] uint* pmd)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, uint*, nuint, byte*, nuint, nuint, void*, nuint, uint*, nint>)(lpVtbl[39]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), td, szName, dwFieldFlags, pvSigBlob, cbSigBlob, dwCPlusTypeFlag, pValue, cchValue, pmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineProperty([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szProperty, [NativeTypeName("DWORD")] nuint dwPropFlags, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSig, [NativeTypeName("ULONG")] nuint cbSig, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue, [NativeTypeName("mdMethodDef")] uint mdSetter, [NativeTypeName("mdMethodDef")] uint mdGetter, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethods, [NativeTypeName("mdProperty *")] uint* pmdProp)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, uint*, nuint, byte*, nuint, nuint, void*, nuint, uint, uint, uint*, uint*, nint>)(lpVtbl[40]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), td, szProperty, dwPropFlags, pvSig, cbSig, dwCPlusTypeFlag, pValue, cchValue, mdSetter, mdGetter, rmdOtherMethods, pmdProp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineParam([NativeTypeName("mdMethodDef")] uint md, [NativeTypeName("ULONG")] nuint ulParamSeq, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("DWORD")] nuint dwParamFlags, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue, [NativeTypeName("mdParamDef *")] uint* ppd)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, uint*, nuint, nuint, void*, nuint, uint*, nint>)(lpVtbl[41]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), md, ulParamSeq, szName, dwParamFlags, dwCPlusTypeFlag, pValue, cchValue, ppd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    [return: NativeTypeName("HRESULT")]
    public nint SetFieldProps([NativeTypeName("mdFieldDef")] uint fd, [NativeTypeName("DWORD")] nuint dwFieldFlags, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, nuint, void*, nuint, nint>)(lpVtbl[42]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), fd, dwFieldFlags, dwCPlusTypeFlag, pValue, cchValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    [return: NativeTypeName("HRESULT")]
    public nint SetPropertyProps([NativeTypeName("mdProperty")] uint pr, [NativeTypeName("DWORD")] nuint dwPropFlags, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue, [NativeTypeName("mdMethodDef")] uint mdSetter, [NativeTypeName("mdMethodDef")] uint mdGetter, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethods)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, nuint, void*, nuint, uint, uint, uint*, nint>)(lpVtbl[43]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pr, dwPropFlags, dwCPlusTypeFlag, pValue, cchValue, mdSetter, mdGetter, rmdOtherMethods);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    [return: NativeTypeName("HRESULT")]
    public nint SetParamProps([NativeTypeName("mdParamDef")] uint pd, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("DWORD")] nuint dwParamFlags, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, uint*, nuint, nuint, void*, nuint, nint>)(lpVtbl[44]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pd, szName, dwParamFlags, dwCPlusTypeFlag, pValue, cchValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineSecurityAttributeSet([NativeTypeName("mdToken")] uint tkObj, [NativeTypeName("COR_SECATTR[]")] COR_SECATTR* rSecAttrs, [NativeTypeName("ULONG")] nuint cSecAttrs, [NativeTypeName("ULONG *")] nuint* pulErrorAttr)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, COR_SECATTR*, nuint, nuint*, nint>)(lpVtbl[45]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), tkObj, rSecAttrs, cSecAttrs, pulErrorAttr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    [return: NativeTypeName("HRESULT")]
    public nint ApplyEditAndContinue(IUnknown* pImport)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, IUnknown*, nint>)(lpVtbl[46]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pImport);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    [return: NativeTypeName("HRESULT")]
    public nint TranslateSigWithScope(IMetaDataAssemblyImport* pAssemImport, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, IMetaDataImport* import, [NativeTypeName("PCCOR_SIGNATURE")] byte* pbSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, IMetaDataAssemblyEmit* pAssemEmit, IMetaDataEmit* emit, [NativeTypeName("PCOR_SIGNATURE")] byte* pvTranslatedSig, [NativeTypeName("ULONG")] nuint cbTranslatedSigMax, [NativeTypeName("ULONG *")] nuint* pcbTranslatedSig)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, IMetaDataAssemblyImport*, void*, nuint, IMetaDataImport*, byte*, nuint, IMetaDataAssemblyEmit*, IMetaDataEmit*, byte*, nuint, nuint*, nint>)(lpVtbl[47]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pAssemImport, pbHashValue, cbHashValue, import, pbSigBlob, cbSigBlob, pAssemEmit, emit, pvTranslatedSig, cbTranslatedSigMax, pcbTranslatedSig);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    [return: NativeTypeName("HRESULT")]
    public nint SetMethodImplFlags([NativeTypeName("mdMethodDef")] uint md, [NativeTypeName("DWORD")] nuint dwImplFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, nint>)(lpVtbl[48]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), md, dwImplFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    [return: NativeTypeName("HRESULT")]
    public nint SetFieldRVA([NativeTypeName("mdFieldDef")] uint fd, [NativeTypeName("ULONG")] nuint ulRVA)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, uint, nuint, nint>)(lpVtbl[49]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), fd, ulRVA);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    [return: NativeTypeName("HRESULT")]
    public nint Merge(IMetaDataImport* pImport, IMapToken* pHostMapToken, IUnknown* pHandler)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, IMetaDataImport*, IMapToken*, IUnknown*, nint>)(lpVtbl[50]))((IMetaDataEmit*)Unsafe.AsPointer(ref this), pImport, pHostMapToken, pHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    [return: NativeTypeName("HRESULT")]
    public nint MergeEnd()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataEmit*, nint>)(lpVtbl[51]))((IMetaDataEmit*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        nint SetModuleProps([NativeTypeName("LPCWSTR")] uint* szName);

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        nint Save([NativeTypeName("LPCWSTR")] uint* szFile, [NativeTypeName("DWORD")] nuint dwSaveFlags);

        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        nint SaveToStream(IStream* pIStream, [NativeTypeName("DWORD")] nuint dwSaveFlags);

        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        nint GetSaveSize(CorSaveSize fSave, [NativeTypeName("DWORD *")] nuint* pdwSaveSize);

        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        nint DefineTypeDef([NativeTypeName("LPCWSTR")] uint* szTypeDef, [NativeTypeName("DWORD")] nuint dwTypeDefFlags, [NativeTypeName("mdToken")] uint tkExtends, [NativeTypeName("mdToken[]")] uint* rtkImplements, [NativeTypeName("mdTypeDef *")] uint* ptd);

        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        nint DefineNestedType([NativeTypeName("LPCWSTR")] uint* szTypeDef, [NativeTypeName("DWORD")] nuint dwTypeDefFlags, [NativeTypeName("mdToken")] uint tkExtends, [NativeTypeName("mdToken[]")] uint* rtkImplements, [NativeTypeName("mdTypeDef")] uint tdEncloser, [NativeTypeName("mdTypeDef *")] uint* ptd);

        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        nint SetHandler(IUnknown* pUnk);

        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        nint DefineMethod([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("DWORD")] nuint dwMethodFlags, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("ULONG")] nuint ulCodeRVA, [NativeTypeName("DWORD")] nuint dwImplFlags, [NativeTypeName("mdMethodDef *")] uint* pmd);

        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        nint DefineMethodImpl([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("mdToken")] uint tkBody, [NativeTypeName("mdToken")] uint tkDecl);

        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        nint DefineTypeRefByName([NativeTypeName("mdToken")] uint tkResolutionScope, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdTypeRef *")] uint* ptr);

        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        nint DefineImportType(IMetaDataAssemblyImport* pAssemImport, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, IMetaDataImport* pImport, [NativeTypeName("mdTypeDef")] uint tdImport, IMetaDataAssemblyEmit* pAssemEmit, [NativeTypeName("mdTypeRef *")] uint* ptr);

        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        nint DefineMemberRef([NativeTypeName("mdToken")] uint tkImport, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("mdMemberRef *")] uint* pmr);

        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        nint DefineImportMember(IMetaDataAssemblyImport* pAssemImport, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, IMetaDataImport* pImport, [NativeTypeName("mdToken")] uint mbMember, IMetaDataAssemblyEmit* pAssemEmit, [NativeTypeName("mdToken")] uint tkParent, [NativeTypeName("mdMemberRef *")] uint* pmr);

        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        nint DefineEvent([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szEvent, [NativeTypeName("DWORD")] nuint dwEventFlags, [NativeTypeName("mdToken")] uint tkEventType, [NativeTypeName("mdMethodDef")] uint mdAddOn, [NativeTypeName("mdMethodDef")] uint mdRemoveOn, [NativeTypeName("mdMethodDef")] uint mdFire, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethods, [NativeTypeName("mdEvent *")] uint* pmdEvent);

        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        nint SetClassLayout([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("DWORD")] nuint dwPackSize, [NativeTypeName("COR_FIELD_OFFSET[]")] COR_FIELD_OFFSET* rFieldOffsets, [NativeTypeName("ULONG")] nuint ulClassSize);

        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        nint DeleteClassLayout([NativeTypeName("mdTypeDef")] uint td);

        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        nint SetFieldMarshal([NativeTypeName("mdToken")] uint tk, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvNativeType, [NativeTypeName("ULONG")] nuint cbNativeType);

        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        nint DeleteFieldMarshal([NativeTypeName("mdToken")] uint tk);

        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        nint DefinePermissionSet([NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD")] nuint dwAction, [NativeTypeName("const void *")] void* pvPermission, [NativeTypeName("ULONG")] nuint cbPermission, [NativeTypeName("mdPermission *")] uint* ppm);

        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        nint SetRVA([NativeTypeName("mdMethodDef")] uint md, [NativeTypeName("ULONG")] nuint ulRVA);

        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        nint GetTokenFromSig([NativeTypeName("PCCOR_SIGNATURE")] byte* pvSig, [NativeTypeName("ULONG")] nuint cbSig, [NativeTypeName("mdSignature *")] uint* pmsig);

        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        nint DefineModuleRef([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdModuleRef *")] uint* pmur);

        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        nint SetParent([NativeTypeName("mdMemberRef")] uint mr, [NativeTypeName("mdToken")] uint tk);

        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        nint GetTokenFromTypeSpec([NativeTypeName("PCCOR_SIGNATURE")] byte* pvSig, [NativeTypeName("ULONG")] nuint cbSig, [NativeTypeName("mdTypeSpec *")] uint* ptypespec);

        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        nint SaveToMemory(void* pbData, [NativeTypeName("ULONG")] nuint cbData);

        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        nint DefineUserString([NativeTypeName("LPCWSTR")] uint* szString, [NativeTypeName("ULONG")] nuint cchString, [NativeTypeName("mdString *")] uint* pstk);

        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        nint DeleteToken([NativeTypeName("mdToken")] uint tkObj);

        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        nint SetMethodProps([NativeTypeName("mdMethodDef")] uint md, [NativeTypeName("DWORD")] nuint dwMethodFlags, [NativeTypeName("ULONG")] nuint ulCodeRVA, [NativeTypeName("DWORD")] nuint dwImplFlags);

        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        nint SetTypeDefProps([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("DWORD")] nuint dwTypeDefFlags, [NativeTypeName("mdToken")] uint tkExtends, [NativeTypeName("mdToken[]")] uint* rtkImplements);

        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        nint SetEventProps([NativeTypeName("mdEvent")] uint ev, [NativeTypeName("DWORD")] nuint dwEventFlags, [NativeTypeName("mdToken")] uint tkEventType, [NativeTypeName("mdMethodDef")] uint mdAddOn, [NativeTypeName("mdMethodDef")] uint mdRemoveOn, [NativeTypeName("mdMethodDef")] uint mdFire, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethods);

        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        nint SetPermissionSetProps([NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD")] nuint dwAction, [NativeTypeName("const void *")] void* pvPermission, [NativeTypeName("ULONG")] nuint cbPermission, [NativeTypeName("mdPermission *")] uint* ppm);

        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        nint DefinePinvokeMap([NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD")] nuint dwMappingFlags, [NativeTypeName("LPCWSTR")] uint* szImportName, [NativeTypeName("mdModuleRef")] uint mrImportDLL);

        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        nint SetPinvokeMap([NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD")] nuint dwMappingFlags, [NativeTypeName("LPCWSTR")] uint* szImportName, [NativeTypeName("mdModuleRef")] uint mrImportDLL);

        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        nint DeletePinvokeMap([NativeTypeName("mdToken")] uint tk);

        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        nint DefineCustomAttribute([NativeTypeName("mdToken")] uint tkOwner, [NativeTypeName("mdToken")] uint tkCtor, [NativeTypeName("const void *")] void* pCustomAttribute, [NativeTypeName("ULONG")] nuint cbCustomAttribute, [NativeTypeName("mdCustomAttribute *")] uint* pcv);

        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        nint SetCustomAttributeValue([NativeTypeName("mdCustomAttribute")] uint pcv, [NativeTypeName("const void *")] void* pCustomAttribute, [NativeTypeName("ULONG")] nuint cbCustomAttribute);

        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        nint DefineField([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("DWORD")] nuint dwFieldFlags, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue, [NativeTypeName("mdFieldDef *")] uint* pmd);

        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        nint DefineProperty([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szProperty, [NativeTypeName("DWORD")] nuint dwPropFlags, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSig, [NativeTypeName("ULONG")] nuint cbSig, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue, [NativeTypeName("mdMethodDef")] uint mdSetter, [NativeTypeName("mdMethodDef")] uint mdGetter, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethods, [NativeTypeName("mdProperty *")] uint* pmdProp);

        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        nint DefineParam([NativeTypeName("mdMethodDef")] uint md, [NativeTypeName("ULONG")] nuint ulParamSeq, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("DWORD")] nuint dwParamFlags, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue, [NativeTypeName("mdParamDef *")] uint* ppd);

        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        nint SetFieldProps([NativeTypeName("mdFieldDef")] uint fd, [NativeTypeName("DWORD")] nuint dwFieldFlags, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue);

        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        nint SetPropertyProps([NativeTypeName("mdProperty")] uint pr, [NativeTypeName("DWORD")] nuint dwPropFlags, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue, [NativeTypeName("mdMethodDef")] uint mdSetter, [NativeTypeName("mdMethodDef")] uint mdGetter, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethods);

        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        nint SetParamProps([NativeTypeName("mdParamDef")] uint pd, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("DWORD")] nuint dwParamFlags, [NativeTypeName("DWORD")] nuint dwCPlusTypeFlag, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("ULONG")] nuint cchValue);

        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        nint DefineSecurityAttributeSet([NativeTypeName("mdToken")] uint tkObj, [NativeTypeName("COR_SECATTR[]")] COR_SECATTR* rSecAttrs, [NativeTypeName("ULONG")] nuint cSecAttrs, [NativeTypeName("ULONG *")] nuint* pulErrorAttr);

        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        nint ApplyEditAndContinue(IUnknown* pImport);

        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        nint TranslateSigWithScope(IMetaDataAssemblyImport* pAssemImport, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, IMetaDataImport* import, [NativeTypeName("PCCOR_SIGNATURE")] byte* pbSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, IMetaDataAssemblyEmit* pAssemEmit, IMetaDataEmit* emit, [NativeTypeName("PCOR_SIGNATURE")] byte* pvTranslatedSig, [NativeTypeName("ULONG")] nuint cbTranslatedSigMax, [NativeTypeName("ULONG *")] nuint* pcbTranslatedSig);

        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        nint SetMethodImplFlags([NativeTypeName("mdMethodDef")] uint md, [NativeTypeName("DWORD")] nuint dwImplFlags);

        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        nint SetFieldRVA([NativeTypeName("mdFieldDef")] uint fd, [NativeTypeName("ULONG")] nuint ulRVA);

        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        nint Merge(IMetaDataImport* pImport, IMapToken* pHostMapToken, IUnknown* pHandler);

        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        nint MergeEnd();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, nint> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint> Release;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, nint> SetModuleProps;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, nuint, nint> Save;

        [NativeTypeName("HRESULT (IStream *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, nuint, nint> SaveToStream;

        [NativeTypeName("HRESULT (CorSaveSize, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CorSaveSize, nuint*, nint> GetSaveSize;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, mdToken, mdToken *, mdTypeDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, nuint, uint, uint*, uint*, nint> DefineTypeDef;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, mdToken, mdToken *, mdTypeDef, mdTypeDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, nuint, uint, uint*, uint, uint*, nint> DefineNestedType;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, nint> SetHandler;

        [NativeTypeName("HRESULT (mdTypeDef, LPCWSTR, DWORD, PCCOR_SIGNATURE, ULONG, ULONG, DWORD, mdMethodDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, byte*, nuint, nuint, nuint, uint*, nint> DefineMethod;

        [NativeTypeName("HRESULT (mdTypeDef, mdToken, mdToken) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, nint> DefineMethodImpl;

        [NativeTypeName("HRESULT (mdToken, LPCWSTR, mdTypeRef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, nint> DefineTypeRefByName;

        [NativeTypeName("HRESULT (IMetaDataAssemblyImport *, const void *, ULONG, IMetaDataImport *, mdTypeDef, IMetaDataAssemblyEmit *, mdTypeRef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMetaDataAssemblyImport*, void*, nuint, IMetaDataImport*, uint, IMetaDataAssemblyEmit*, uint*, nint> DefineImportType;

        [NativeTypeName("HRESULT (mdToken, LPCWSTR, PCCOR_SIGNATURE, ULONG, mdMemberRef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, nuint, uint*, nint> DefineMemberRef;

        [NativeTypeName("HRESULT (IMetaDataAssemblyImport *, const void *, ULONG, IMetaDataImport *, mdToken, IMetaDataAssemblyEmit *, mdToken, mdMemberRef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMetaDataAssemblyImport*, void*, nuint, IMetaDataImport*, uint, IMetaDataAssemblyEmit*, uint, uint*, nint> DefineImportMember;

        [NativeTypeName("HRESULT (mdTypeDef, LPCWSTR, DWORD, mdToken, mdMethodDef, mdMethodDef, mdMethodDef, mdMethodDef *, mdEvent *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, uint, uint, uint, uint, uint*, uint*, nint> DefineEvent;

        [NativeTypeName("HRESULT (mdTypeDef, DWORD, COR_FIELD_OFFSET *, ULONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, COR_FIELD_OFFSET*, nuint, nint> SetClassLayout;

        [NativeTypeName("HRESULT (mdTypeDef) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nint> DeleteClassLayout;

        [NativeTypeName("HRESULT (mdToken, PCCOR_SIGNATURE, ULONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, nuint, nint> SetFieldMarshal;

        [NativeTypeName("HRESULT (mdToken) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nint> DeleteFieldMarshal;

        [NativeTypeName("HRESULT (mdToken, DWORD, const void *, ULONG, mdPermission *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, void*, nuint, uint*, nint> DefinePermissionSet;

        [NativeTypeName("HRESULT (mdMethodDef, ULONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, nint> SetRVA;

        [NativeTypeName("HRESULT (PCCOR_SIGNATURE, ULONG, mdSignature *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, nuint, uint*, nint> GetTokenFromSig;

        [NativeTypeName("HRESULT (LPCWSTR, mdModuleRef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, nint> DefineModuleRef;

        [NativeTypeName("HRESULT (mdMemberRef, mdToken) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, nint> SetParent;

        [NativeTypeName("HRESULT (PCCOR_SIGNATURE, ULONG, mdTypeSpec *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, nuint, uint*, nint> GetTokenFromTypeSpec;

        [NativeTypeName("HRESULT (void *, ULONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, nuint, nint> SaveToMemory;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, mdString *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, nuint, uint*, nint> DefineUserString;

        [NativeTypeName("HRESULT (mdToken) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nint> DeleteToken;

        [NativeTypeName("HRESULT (mdMethodDef, DWORD, ULONG, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, nuint, nuint, nint> SetMethodProps;

        [NativeTypeName("HRESULT (mdTypeDef, DWORD, mdToken, mdToken *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, uint, uint*, nint> SetTypeDefProps;

        [NativeTypeName("HRESULT (mdEvent, DWORD, mdToken, mdMethodDef, mdMethodDef, mdMethodDef, mdMethodDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, uint, uint, uint, uint, uint*, nint> SetEventProps;

        [NativeTypeName("HRESULT (mdToken, DWORD, const void *, ULONG, mdPermission *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, void*, nuint, uint*, nint> SetPermissionSetProps;

        [NativeTypeName("HRESULT (mdToken, DWORD, LPCWSTR, mdModuleRef) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, uint*, uint, nint> DefinePinvokeMap;

        [NativeTypeName("HRESULT (mdToken, DWORD, LPCWSTR, mdModuleRef) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, uint*, uint, nint> SetPinvokeMap;

        [NativeTypeName("HRESULT (mdToken) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nint> DeletePinvokeMap;

        [NativeTypeName("HRESULT (mdToken, mdToken, const void *, ULONG, mdCustomAttribute *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, void*, nuint, uint*, nint> DefineCustomAttribute;

        [NativeTypeName("HRESULT (mdCustomAttribute, const void *, ULONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, nuint, nint> SetCustomAttributeValue;

        [NativeTypeName("HRESULT (mdTypeDef, LPCWSTR, DWORD, PCCOR_SIGNATURE, ULONG, DWORD, const void *, ULONG, mdFieldDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, byte*, nuint, nuint, void*, nuint, uint*, nint> DefineField;

        [NativeTypeName("HRESULT (mdTypeDef, LPCWSTR, DWORD, PCCOR_SIGNATURE, ULONG, DWORD, const void *, ULONG, mdMethodDef, mdMethodDef, mdMethodDef *, mdProperty *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, byte*, nuint, nuint, void*, nuint, uint, uint, uint*, uint*, nint> DefineProperty;

        [NativeTypeName("HRESULT (mdMethodDef, ULONG, LPCWSTR, DWORD, DWORD, const void *, ULONG, mdParamDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, uint*, nuint, nuint, void*, nuint, uint*, nint> DefineParam;

        [NativeTypeName("HRESULT (mdFieldDef, DWORD, DWORD, const void *, ULONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, nuint, void*, nuint, nint> SetFieldProps;

        [NativeTypeName("HRESULT (mdProperty, DWORD, DWORD, const void *, ULONG, mdMethodDef, mdMethodDef, mdMethodDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, nuint, void*, nuint, uint, uint, uint*, nint> SetPropertyProps;

        [NativeTypeName("HRESULT (mdParamDef, LPCWSTR, DWORD, DWORD, const void *, ULONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, nuint, void*, nuint, nint> SetParamProps;

        [NativeTypeName("HRESULT (mdToken, COR_SECATTR *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, COR_SECATTR*, nuint, nuint*, nint> DefineSecurityAttributeSet;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, nint> ApplyEditAndContinue;

        [NativeTypeName("HRESULT (IMetaDataAssemblyImport *, const void *, ULONG, IMetaDataImport *, PCCOR_SIGNATURE, ULONG, IMetaDataAssemblyEmit *, IMetaDataEmit *, PCOR_SIGNATURE, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMetaDataAssemblyImport*, void*, nuint, IMetaDataImport*, byte*, nuint, IMetaDataAssemblyEmit*, IMetaDataEmit*, byte*, nuint, nuint*, nint> TranslateSigWithScope;

        [NativeTypeName("HRESULT (mdMethodDef, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, nint> SetMethodImplFlags;

        [NativeTypeName("HRESULT (mdFieldDef, ULONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, nint> SetFieldRVA;

        [NativeTypeName("HRESULT (IMetaDataImport *, IMapToken *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMetaDataImport*, IMapToken*, IUnknown*, nint> Merge;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nint> MergeEnd;
    }
}
