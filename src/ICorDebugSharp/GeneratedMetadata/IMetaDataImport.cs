// ReSharper disable InconsistentNaming
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataImport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMetaDataImport : IMetaDataImport.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] _GUID* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, _GUID*, void**, nint>)(lpVtbl[0]))((IMetaDataImport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, nuint>)(lpVtbl[1]))((IMetaDataImport*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, nuint>)(lpVtbl[2]))((IMetaDataImport*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void CloseEnum([NativeTypeName("HCORENUM")] void* hEnum)
    {
        ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void*, void>)(lpVtbl[3]))((IMetaDataImport*)Unsafe.AsPointer(ref this), hEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public nint CountEnum([NativeTypeName("HCORENUM")] void* hEnum, [NativeTypeName("ULONG *")] nuint* pulCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void*, nuint*, nint>)(lpVtbl[4]))((IMetaDataImport*)Unsafe.AsPointer(ref this), hEnum, pulCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("HRESULT")]
    public nint ResetEnum([NativeTypeName("HCORENUM")] void* hEnum, [NativeTypeName("ULONG")] nuint ulPos)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void*, nuint, nint>)(lpVtbl[5]))((IMetaDataImport*)Unsafe.AsPointer(ref this), hEnum, ulPos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumTypeDefs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef[]")] uint* rTypeDefs, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTypeDefs)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[6]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, rTypeDefs, cMax, pcTypeDefs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumInterfaceImpls([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("mdInterfaceImpl[]")] uint* rImpls, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcImpls)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, nuint, nuint*, nint>)(lpVtbl[7]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, td, rImpls, cMax, pcImpls);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumTypeRefs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeRef[]")] uint* rTypeRefs, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTypeRefs)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[8]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, rTypeRefs, cMax, pcTypeRefs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("HRESULT")]
    public nint FindTypeDefByName([NativeTypeName("LPCWSTR")] uint* szTypeDef, [NativeTypeName("mdToken")] uint tkEnclosingClass, [NativeTypeName("mdTypeDef *")] uint* ptd)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint*, uint, uint*, nint>)(lpVtbl[9]))((IMetaDataImport*)Unsafe.AsPointer(ref this), szTypeDef, tkEnclosingClass, ptd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("HRESULT")]
    public nint GetScopeProps([NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, [NativeTypeName("GUID *")] _GUID* pmvid)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint*, nuint, nuint*, _GUID*, nint>)(lpVtbl[10]))((IMetaDataImport*)Unsafe.AsPointer(ref this), szName, cchName, pchName, pmvid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("HRESULT")]
    public nint GetModuleFromScope([NativeTypeName("mdModule *")] uint* pmd)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint*, nint>)(lpVtbl[11]))((IMetaDataImport*)Unsafe.AsPointer(ref this), pmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("HRESULT")]
    public nint GetTypeDefProps([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPWSTR")] uint* szTypeDef, [NativeTypeName("ULONG")] nuint cchTypeDef, [NativeTypeName("ULONG *")] nuint* pchTypeDef, [NativeTypeName("DWORD *")] nuint* pdwTypeDefFlags, [NativeTypeName("mdToken *")] uint* ptkExtends)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, nuint, nuint*, nuint*, uint*, nint>)(lpVtbl[12]))((IMetaDataImport*)Unsafe.AsPointer(ref this), td, szTypeDef, cchTypeDef, pchTypeDef, pdwTypeDefFlags, ptkExtends);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("HRESULT")]
    public nint GetInterfaceImplProps([NativeTypeName("mdInterfaceImpl")] uint iiImpl, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("mdToken *")] uint* ptkIface)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, uint*, nint>)(lpVtbl[13]))((IMetaDataImport*)Unsafe.AsPointer(ref this), iiImpl, pClass, ptkIface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("HRESULT")]
    public nint GetTypeRefProps([NativeTypeName("mdTypeRef")] uint tr, [NativeTypeName("mdToken *")] uint* ptkResolutionScope, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, uint*, nuint, nuint*, nint>)(lpVtbl[14]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tr, ptkResolutionScope, szName, cchName, pchName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [return: NativeTypeName("HRESULT")]
    public nint ResolveTypeRef([NativeTypeName("mdTypeRef")] uint tr, [NativeTypeName("const IID &")] _GUID* riid, IUnknown** ppIScope, [NativeTypeName("mdTypeDef *")] uint* ptd)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, _GUID*, IUnknown**, uint*, nint>)(lpVtbl[15]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tr, riid, ppIScope, ptd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumMembers([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("mdToken[]")] uint* rMembers, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, nuint, nuint*, nint>)(lpVtbl[16]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, cl, rMembers, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumMembersWithName([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdToken[]")] uint* rMembers, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, uint*, nuint, nuint*, nint>)(lpVtbl[17]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, cl, szName, rMembers, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumMethods([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("mdMethodDef[]")] uint* rMethods, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, nuint, nuint*, nint>)(lpVtbl[18]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, cl, rMethods, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumMethodsWithName([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdMethodDef[]")] uint* rMethods, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, uint*, nuint, nuint*, nint>)(lpVtbl[19]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, cl, szName, rMethods, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumFields([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("mdFieldDef[]")] uint* rFields, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, nuint, nuint*, nint>)(lpVtbl[20]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, cl, rFields, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumFieldsWithName([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdFieldDef[]")] uint* rFields, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, uint*, nuint, nuint*, nint>)(lpVtbl[21]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, cl, szName, rFields, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumParams([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdMethodDef")] uint mb, [NativeTypeName("mdParamDef[]")] uint* rParams, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, nuint, nuint*, nint>)(lpVtbl[22]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, mb, rParams, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumMemberRefs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdToken")] uint tkParent, [NativeTypeName("mdMemberRef[]")] uint* rMemberRefs, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, nuint, nuint*, nint>)(lpVtbl[23]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, tkParent, rMemberRefs, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumMethodImpls([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("mdToken[]")] uint* rMethodBody, [NativeTypeName("mdToken[]")] uint* rMethodDecl, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, uint*, nuint, nuint*, nint>)(lpVtbl[24]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, td, rMethodBody, rMethodDecl, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumPermissionSets([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD")] nuint dwActions, [NativeTypeName("mdPermission[]")] uint* rPermission, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, nuint, uint*, nuint, nuint*, nint>)(lpVtbl[25]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, tk, dwActions, rPermission, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("HRESULT")]
    public nint FindMember([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("mdToken *")] uint* pmb)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, byte*, nuint, uint*, nint>)(lpVtbl[26]))((IMetaDataImport*)Unsafe.AsPointer(ref this), td, szName, pvSigBlob, cbSigBlob, pmb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [return: NativeTypeName("HRESULT")]
    public nint FindMethod([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("mdMethodDef *")] uint* pmb)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, byte*, nuint, uint*, nint>)(lpVtbl[27]))((IMetaDataImport*)Unsafe.AsPointer(ref this), td, szName, pvSigBlob, cbSigBlob, pmb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [return: NativeTypeName("HRESULT")]
    public nint FindField([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("mdFieldDef *")] uint* pmb)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, byte*, nuint, uint*, nint>)(lpVtbl[28]))((IMetaDataImport*)Unsafe.AsPointer(ref this), td, szName, pvSigBlob, cbSigBlob, pmb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    [return: NativeTypeName("HRESULT")]
    public nint FindMemberRef([NativeTypeName("mdTypeRef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("mdMemberRef *")] uint* pmr)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, byte*, nuint, uint*, nint>)(lpVtbl[29]))((IMetaDataImport*)Unsafe.AsPointer(ref this), td, szName, pvSigBlob, cbSigBlob, pmr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [return: NativeTypeName("HRESULT")]
    public nint GetMethodProps([NativeTypeName("mdMethodDef")] uint mb, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("LPWSTR")] uint* szMethod, [NativeTypeName("ULONG")] nuint cchMethod, [NativeTypeName("ULONG *")] nuint* pchMethod, [NativeTypeName("DWORD *")] nuint* pdwAttr, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSigBlob, [NativeTypeName("ULONG *")] nuint* pcbSigBlob, [NativeTypeName("ULONG *")] nuint* pulCodeRVA, [NativeTypeName("DWORD *")] nuint* pdwImplFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, uint*, nuint, nuint*, nuint*, byte**, nuint*, nuint*, nuint*, nint>)(lpVtbl[30]))((IMetaDataImport*)Unsafe.AsPointer(ref this), mb, pClass, szMethod, cchMethod, pchMethod, pdwAttr, ppvSigBlob, pcbSigBlob, pulCodeRVA, pdwImplFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [return: NativeTypeName("HRESULT")]
    public nint GetMemberRefProps([NativeTypeName("mdMemberRef")] uint mr, [NativeTypeName("mdToken *")] uint* ptk, [NativeTypeName("LPWSTR")] uint* szMember, [NativeTypeName("ULONG")] nuint cchMember, [NativeTypeName("ULONG *")] nuint* pchMember, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSigBlob, [NativeTypeName("ULONG *")] nuint* pbSig)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, uint*, nuint, nuint*, byte**, nuint*, nint>)(lpVtbl[31]))((IMetaDataImport*)Unsafe.AsPointer(ref this), mr, ptk, szMember, cchMember, pchMember, ppvSigBlob, pbSig);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumProperties([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("mdProperty[]")] uint* rProperties, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcProperties)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, nuint, nuint*, nint>)(lpVtbl[32]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, td, rProperties, cMax, pcProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumEvents([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("mdEvent[]")] uint* rEvents, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcEvents)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, nuint, nuint*, nint>)(lpVtbl[33]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, td, rEvents, cMax, pcEvents);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    [return: NativeTypeName("HRESULT")]
    public nint GetEventProps([NativeTypeName("mdEvent")] uint ev, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("LPCWSTR")] uint* szEvent, [NativeTypeName("ULONG")] nuint cchEvent, [NativeTypeName("ULONG *")] nuint* pchEvent, [NativeTypeName("DWORD *")] nuint* pdwEventFlags, [NativeTypeName("mdToken *")] uint* ptkEventType, [NativeTypeName("mdMethodDef *")] uint* pmdAddOn, [NativeTypeName("mdMethodDef *")] uint* pmdRemoveOn, [NativeTypeName("mdMethodDef *")] uint* pmdFire, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethod, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcOtherMethod)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, uint*, nuint, nuint*, nuint*, uint*, uint*, uint*, uint*, uint*, nuint, nuint*, nint>)(lpVtbl[34]))((IMetaDataImport*)Unsafe.AsPointer(ref this), ev, pClass, szEvent, cchEvent, pchEvent, pdwEventFlags, ptkEventType, pmdAddOn, pmdRemoveOn, pmdFire, rmdOtherMethod, cMax, pcOtherMethod);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumMethodSemantics([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdMethodDef")] uint mb, [NativeTypeName("mdToken[]")] uint* rEventProp, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcEventProp)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint*, nuint, nuint*, nint>)(lpVtbl[35]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, mb, rEventProp, cMax, pcEventProp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    [return: NativeTypeName("HRESULT")]
    public nint GetMethodSemantics([NativeTypeName("mdMethodDef")] uint mb, [NativeTypeName("mdToken")] uint tkEventProp, [NativeTypeName("DWORD *")] nuint* pdwSemanticsFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint, nuint*, nint>)(lpVtbl[36]))((IMetaDataImport*)Unsafe.AsPointer(ref this), mb, tkEventProp, pdwSemanticsFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    [return: NativeTypeName("HRESULT")]
    public nint GetClassLayout([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("DWORD *")] nuint* pdwPackSize, [NativeTypeName("COR_FIELD_OFFSET[]")] COR_FIELD_OFFSET* rFieldOffset, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcFieldOffset, [NativeTypeName("ULONG *")] nuint* pulClassSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, nuint*, COR_FIELD_OFFSET*, nuint, nuint*, nuint*, nint>)(lpVtbl[37]))((IMetaDataImport*)Unsafe.AsPointer(ref this), td, pdwPackSize, rFieldOffset, cMax, pcFieldOffset, pulClassSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    [return: NativeTypeName("HRESULT")]
    public nint GetFieldMarshal([NativeTypeName("mdToken")] uint tk, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvNativeType, [NativeTypeName("ULONG *")] nuint* pcbNativeType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, byte**, nuint*, nint>)(lpVtbl[38]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tk, ppvNativeType, pcbNativeType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [return: NativeTypeName("HRESULT")]
    public nint GetRVA([NativeTypeName("mdToken")] uint tk, [NativeTypeName("ULONG *")] nuint* pulCodeRVA, [NativeTypeName("DWORD *")] nuint* pdwImplFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, nuint*, nuint*, nint>)(lpVtbl[39]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tk, pulCodeRVA, pdwImplFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    [return: NativeTypeName("HRESULT")]
    public nint GetPermissionSetProps([NativeTypeName("mdPermission")] uint pm, [NativeTypeName("DWORD *")] nuint* pdwAction, [NativeTypeName("const void **")] void** ppvPermission, [NativeTypeName("ULONG *")] nuint* pcbPermission)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, nuint*, void**, nuint*, nint>)(lpVtbl[40]))((IMetaDataImport*)Unsafe.AsPointer(ref this), pm, pdwAction, ppvPermission, pcbPermission);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    [return: NativeTypeName("HRESULT")]
    public nint GetSigFromToken([NativeTypeName("mdSignature")] uint mdSig, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSig, [NativeTypeName("ULONG *")] nuint* pcbSig)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, byte**, nuint*, nint>)(lpVtbl[41]))((IMetaDataImport*)Unsafe.AsPointer(ref this), mdSig, ppvSig, pcbSig);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    [return: NativeTypeName("HRESULT")]
    public nint GetModuleRefProps([NativeTypeName("mdModuleRef")] uint mur, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, nuint, nuint*, nint>)(lpVtbl[42]))((IMetaDataImport*)Unsafe.AsPointer(ref this), mur, szName, cchName, pchName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumModuleRefs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdModuleRef[]")] uint* rModuleRefs, [NativeTypeName("ULONG")] nuint cmax, [NativeTypeName("ULONG *")] nuint* pcModuleRefs)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[43]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, rModuleRefs, cmax, pcModuleRefs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    [return: NativeTypeName("HRESULT")]
    public nint GetTypeSpecFromToken([NativeTypeName("mdTypeSpec")] uint typespec, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSig, [NativeTypeName("ULONG *")] nuint* pcbSig)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, byte**, nuint*, nint>)(lpVtbl[44]))((IMetaDataImport*)Unsafe.AsPointer(ref this), typespec, ppvSig, pcbSig);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    [return: NativeTypeName("HRESULT")]
    public nint GetNameFromToken([NativeTypeName("mdToken")] uint tk, [NativeTypeName("MDUTF8CSTR *")] sbyte** pszUtf8NamePtr)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, sbyte**, nint>)(lpVtbl[45]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tk, pszUtf8NamePtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumUnresolvedMethods([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdToken[]")] uint* rMethods, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[46]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, rMethods, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    [return: NativeTypeName("HRESULT")]
    public nint GetUserString([NativeTypeName("mdString")] uint stk, [NativeTypeName("LPWSTR")] uint* szString, [NativeTypeName("ULONG")] nuint cchString, [NativeTypeName("ULONG *")] nuint* pchString)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, nuint, nuint*, nint>)(lpVtbl[47]))((IMetaDataImport*)Unsafe.AsPointer(ref this), stk, szString, cchString, pchString);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    [return: NativeTypeName("HRESULT")]
    public nint GetPinvokeMap([NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD *")] nuint* pdwMappingFlags, [NativeTypeName("LPWSTR")] uint* szImportName, [NativeTypeName("ULONG")] nuint cchImportName, [NativeTypeName("ULONG *")] nuint* pchImportName, [NativeTypeName("mdModuleRef *")] uint* pmrImportDLL)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, nuint*, uint*, nuint, nuint*, uint*, nint>)(lpVtbl[48]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tk, pdwMappingFlags, szImportName, cchImportName, pchImportName, pmrImportDLL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumSignatures([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdSignature[]")] uint* rSignatures, [NativeTypeName("ULONG")] nuint cmax, [NativeTypeName("ULONG *")] nuint* pcSignatures)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[49]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, rSignatures, cmax, pcSignatures);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumTypeSpecs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeSpec[]")] uint* rTypeSpecs, [NativeTypeName("ULONG")] nuint cmax, [NativeTypeName("ULONG *")] nuint* pcTypeSpecs)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[50]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, rTypeSpecs, cmax, pcTypeSpecs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumUserStrings([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdString[]")] uint* rStrings, [NativeTypeName("ULONG")] nuint cmax, [NativeTypeName("ULONG *")] nuint* pcStrings)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[51]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, rStrings, cmax, pcStrings);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    [return: NativeTypeName("HRESULT")]
    public nint GetParamForMethodIndex([NativeTypeName("mdMethodDef")] uint md, [NativeTypeName("ULONG")] nuint ulParamSeq, [NativeTypeName("mdParamDef *")] uint* ppd)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, nuint, uint*, nint>)(lpVtbl[52]))((IMetaDataImport*)Unsafe.AsPointer(ref this), md, ulParamSeq, ppd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumCustomAttributes([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdToken")] uint tk, [NativeTypeName("mdToken")] uint tkType, [NativeTypeName("mdCustomAttribute[]")] uint* rCustomAttributes, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcCustomAttributes)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void**, uint, uint, uint*, nuint, nuint*, nint>)(lpVtbl[53]))((IMetaDataImport*)Unsafe.AsPointer(ref this), phEnum, tk, tkType, rCustomAttributes, cMax, pcCustomAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    [return: NativeTypeName("HRESULT")]
    public nint GetCustomAttributeProps([NativeTypeName("mdCustomAttribute")] uint cv, [NativeTypeName("mdToken *")] uint* ptkObj, [NativeTypeName("mdToken *")] uint* ptkType, [NativeTypeName("const void **")] void** ppBlob, [NativeTypeName("ULONG *")] nuint* pcbSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, uint*, void**, nuint*, nint>)(lpVtbl[54]))((IMetaDataImport*)Unsafe.AsPointer(ref this), cv, ptkObj, ptkType, ppBlob, pcbSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    [return: NativeTypeName("HRESULT")]
    public nint FindTypeRef([NativeTypeName("mdToken")] uint tkResolutionScope, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdTypeRef *")] uint* ptr)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, uint*, nint>)(lpVtbl[55]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tkResolutionScope, szName, ptr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    [return: NativeTypeName("HRESULT")]
    public nint GetMemberProps([NativeTypeName("mdToken")] uint mb, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("LPWSTR")] uint* szMember, [NativeTypeName("ULONG")] nuint cchMember, [NativeTypeName("ULONG *")] nuint* pchMember, [NativeTypeName("DWORD *")] nuint* pdwAttr, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSigBlob, [NativeTypeName("ULONG *")] nuint* pcbSigBlob, [NativeTypeName("ULONG *")] nuint* pulCodeRVA, [NativeTypeName("DWORD *")] nuint* pdwImplFlags, [NativeTypeName("DWORD *")] nuint* pdwCPlusTypeFlag, [NativeTypeName("UVCP_CONSTANT *")] void** ppValue, [NativeTypeName("ULONG *")] nuint* pcchValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, uint*, nuint, nuint*, nuint*, byte**, nuint*, nuint*, nuint*, nuint*, void**, nuint*, nint>)(lpVtbl[56]))((IMetaDataImport*)Unsafe.AsPointer(ref this), mb, pClass, szMember, cchMember, pchMember, pdwAttr, ppvSigBlob, pcbSigBlob, pulCodeRVA, pdwImplFlags, pdwCPlusTypeFlag, ppValue, pcchValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    [return: NativeTypeName("HRESULT")]
    public nint GetFieldProps([NativeTypeName("mdFieldDef")] uint mb, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("LPWSTR")] uint* szField, [NativeTypeName("ULONG")] nuint cchField, [NativeTypeName("ULONG *")] nuint* pchField, [NativeTypeName("DWORD *")] nuint* pdwAttr, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSigBlob, [NativeTypeName("ULONG *")] nuint* pcbSigBlob, [NativeTypeName("DWORD *")] nuint* pdwCPlusTypeFlag, [NativeTypeName("UVCP_CONSTANT *")] void** ppValue, [NativeTypeName("ULONG *")] nuint* pcchValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, uint*, nuint, nuint*, nuint*, byte**, nuint*, nuint*, void**, nuint*, nint>)(lpVtbl[57]))((IMetaDataImport*)Unsafe.AsPointer(ref this), mb, pClass, szField, cchField, pchField, pdwAttr, ppvSigBlob, pcbSigBlob, pdwCPlusTypeFlag, ppValue, pcchValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    [return: NativeTypeName("HRESULT")]
    public nint GetPropertyProps([NativeTypeName("mdProperty")] uint prop, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("LPCWSTR")] uint* szProperty, [NativeTypeName("ULONG")] nuint cchProperty, [NativeTypeName("ULONG *")] nuint* pchProperty, [NativeTypeName("DWORD *")] nuint* pdwPropFlags, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSig, [NativeTypeName("ULONG *")] nuint* pbSig, [NativeTypeName("DWORD *")] nuint* pdwCPlusTypeFlag, [NativeTypeName("UVCP_CONSTANT *")] void** ppDefaultValue, [NativeTypeName("ULONG *")] nuint* pcchDefaultValue, [NativeTypeName("mdMethodDef *")] uint* pmdSetter, [NativeTypeName("mdMethodDef *")] uint* pmdGetter, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethod, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcOtherMethod)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, uint*, nuint, nuint*, nuint*, byte**, nuint*, nuint*, void**, nuint*, uint*, uint*, uint*, nuint, nuint*, nint>)(lpVtbl[58]))((IMetaDataImport*)Unsafe.AsPointer(ref this), prop, pClass, szProperty, cchProperty, pchProperty, pdwPropFlags, ppvSig, pbSig, pdwCPlusTypeFlag, ppDefaultValue, pcchDefaultValue, pmdSetter, pmdGetter, rmdOtherMethod, cMax, pcOtherMethod);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    [return: NativeTypeName("HRESULT")]
    public nint GetParamProps([NativeTypeName("mdParamDef")] uint tk, [NativeTypeName("mdMethodDef *")] uint* pmd, [NativeTypeName("ULONG *")] nuint* pulSequence, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, [NativeTypeName("DWORD *")] nuint* pdwAttr, [NativeTypeName("DWORD *")] nuint* pdwCPlusTypeFlag, [NativeTypeName("UVCP_CONSTANT *")] void** ppValue, [NativeTypeName("ULONG *")] nuint* pcchValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, nuint*, uint*, nuint, nuint*, nuint*, nuint*, void**, nuint*, nint>)(lpVtbl[59]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tk, pmd, pulSequence, szName, cchName, pchName, pdwAttr, pdwCPlusTypeFlag, ppValue, pcchValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    [return: NativeTypeName("HRESULT")]
    public nint GetCustomAttributeByName([NativeTypeName("mdToken")] uint tkObj, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const void **")] void** ppData, [NativeTypeName("ULONG *")] nuint* pcbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, void**, nuint*, nint>)(lpVtbl[60]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tkObj, szName, ppData, pcbData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    [return: NativeTypeName("BOOL")]
    public int IsValidToken([NativeTypeName("mdToken")] uint tk)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, int>)(lpVtbl[61]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    [return: NativeTypeName("HRESULT")]
    public nint GetNestedClassProps([NativeTypeName("mdTypeDef")] uint tdNestedClass, [NativeTypeName("mdTypeDef *")] uint* ptdEnclosingClass)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, uint*, nint>)(lpVtbl[62]))((IMetaDataImport*)Unsafe.AsPointer(ref this), tdNestedClass, ptdEnclosingClass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    [return: NativeTypeName("HRESULT")]
    public nint GetNativeCallConvFromSig([NativeTypeName("const void *")] void* pvSig, [NativeTypeName("ULONG")] nuint cbSig, [NativeTypeName("ULONG *")] nuint* pCallConv)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, void*, nuint, nuint*, nint>)(lpVtbl[63]))((IMetaDataImport*)Unsafe.AsPointer(ref this), pvSig, cbSig, pCallConv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    [return: NativeTypeName("HRESULT")]
    public nint IsGlobal([NativeTypeName("mdToken")] uint pd, int* pbGlobal)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataImport*, uint, int*, nint>)(lpVtbl[64]))((IMetaDataImport*)Unsafe.AsPointer(ref this), pd, pbGlobal);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void CloseEnum([NativeTypeName("HCORENUM")] void* hEnum);

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        nint CountEnum([NativeTypeName("HCORENUM")] void* hEnum, [NativeTypeName("ULONG *")] nuint* pulCount);

        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        nint ResetEnum([NativeTypeName("HCORENUM")] void* hEnum, [NativeTypeName("ULONG")] nuint ulPos);

        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        nint EnumTypeDefs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef[]")] uint* rTypeDefs, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTypeDefs);

        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        nint EnumInterfaceImpls([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("mdInterfaceImpl[]")] uint* rImpls, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcImpls);

        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        nint EnumTypeRefs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeRef[]")] uint* rTypeRefs, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTypeRefs);

        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        nint FindTypeDefByName([NativeTypeName("LPCWSTR")] uint* szTypeDef, [NativeTypeName("mdToken")] uint tkEnclosingClass, [NativeTypeName("mdTypeDef *")] uint* ptd);

        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        nint GetScopeProps([NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, [NativeTypeName("GUID *")] _GUID* pmvid);

        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        nint GetModuleFromScope([NativeTypeName("mdModule *")] uint* pmd);

        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        nint GetTypeDefProps([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPWSTR")] uint* szTypeDef, [NativeTypeName("ULONG")] nuint cchTypeDef, [NativeTypeName("ULONG *")] nuint* pchTypeDef, [NativeTypeName("DWORD *")] nuint* pdwTypeDefFlags, [NativeTypeName("mdToken *")] uint* ptkExtends);

        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        nint GetInterfaceImplProps([NativeTypeName("mdInterfaceImpl")] uint iiImpl, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("mdToken *")] uint* ptkIface);

        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        nint GetTypeRefProps([NativeTypeName("mdTypeRef")] uint tr, [NativeTypeName("mdToken *")] uint* ptkResolutionScope, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName);

        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        nint ResolveTypeRef([NativeTypeName("mdTypeRef")] uint tr, [NativeTypeName("const IID &")] _GUID* riid, IUnknown** ppIScope, [NativeTypeName("mdTypeDef *")] uint* ptd);

        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        nint EnumMembers([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("mdToken[]")] uint* rMembers, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        nint EnumMembersWithName([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdToken[]")] uint* rMembers, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        nint EnumMethods([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("mdMethodDef[]")] uint* rMethods, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        nint EnumMethodsWithName([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdMethodDef[]")] uint* rMethods, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        nint EnumFields([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("mdFieldDef[]")] uint* rFields, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        nint EnumFieldsWithName([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint cl, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdFieldDef[]")] uint* rFields, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        nint EnumParams([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdMethodDef")] uint mb, [NativeTypeName("mdParamDef[]")] uint* rParams, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        nint EnumMemberRefs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdToken")] uint tkParent, [NativeTypeName("mdMemberRef[]")] uint* rMemberRefs, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        nint EnumMethodImpls([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("mdToken[]")] uint* rMethodBody, [NativeTypeName("mdToken[]")] uint* rMethodDecl, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        nint EnumPermissionSets([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD")] nuint dwActions, [NativeTypeName("mdPermission[]")] uint* rPermission, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        nint FindMember([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("mdToken *")] uint* pmb);

        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        nint FindMethod([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("mdMethodDef *")] uint* pmb);

        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        nint FindField([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("mdFieldDef *")] uint* pmb);

        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        nint FindMemberRef([NativeTypeName("mdTypeRef")] uint td, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("PCCOR_SIGNATURE")] byte* pvSigBlob, [NativeTypeName("ULONG")] nuint cbSigBlob, [NativeTypeName("mdMemberRef *")] uint* pmr);

        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        nint GetMethodProps([NativeTypeName("mdMethodDef")] uint mb, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("LPWSTR")] uint* szMethod, [NativeTypeName("ULONG")] nuint cchMethod, [NativeTypeName("ULONG *")] nuint* pchMethod, [NativeTypeName("DWORD *")] nuint* pdwAttr, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSigBlob, [NativeTypeName("ULONG *")] nuint* pcbSigBlob, [NativeTypeName("ULONG *")] nuint* pulCodeRVA, [NativeTypeName("DWORD *")] nuint* pdwImplFlags);

        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        nint GetMemberRefProps([NativeTypeName("mdMemberRef")] uint mr, [NativeTypeName("mdToken *")] uint* ptk, [NativeTypeName("LPWSTR")] uint* szMember, [NativeTypeName("ULONG")] nuint cchMember, [NativeTypeName("ULONG *")] nuint* pchMember, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSigBlob, [NativeTypeName("ULONG *")] nuint* pbSig);

        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        nint EnumProperties([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("mdProperty[]")] uint* rProperties, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcProperties);

        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        nint EnumEvents([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("mdEvent[]")] uint* rEvents, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcEvents);

        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        nint GetEventProps([NativeTypeName("mdEvent")] uint ev, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("LPCWSTR")] uint* szEvent, [NativeTypeName("ULONG")] nuint cchEvent, [NativeTypeName("ULONG *")] nuint* pchEvent, [NativeTypeName("DWORD *")] nuint* pdwEventFlags, [NativeTypeName("mdToken *")] uint* ptkEventType, [NativeTypeName("mdMethodDef *")] uint* pmdAddOn, [NativeTypeName("mdMethodDef *")] uint* pmdRemoveOn, [NativeTypeName("mdMethodDef *")] uint* pmdFire, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethod, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcOtherMethod);

        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        nint EnumMethodSemantics([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdMethodDef")] uint mb, [NativeTypeName("mdToken[]")] uint* rEventProp, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcEventProp);

        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        nint GetMethodSemantics([NativeTypeName("mdMethodDef")] uint mb, [NativeTypeName("mdToken")] uint tkEventProp, [NativeTypeName("DWORD *")] nuint* pdwSemanticsFlags);

        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        nint GetClassLayout([NativeTypeName("mdTypeDef")] uint td, [NativeTypeName("DWORD *")] nuint* pdwPackSize, [NativeTypeName("COR_FIELD_OFFSET[]")] COR_FIELD_OFFSET* rFieldOffset, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcFieldOffset, [NativeTypeName("ULONG *")] nuint* pulClassSize);

        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        nint GetFieldMarshal([NativeTypeName("mdToken")] uint tk, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvNativeType, [NativeTypeName("ULONG *")] nuint* pcbNativeType);

        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        nint GetRVA([NativeTypeName("mdToken")] uint tk, [NativeTypeName("ULONG *")] nuint* pulCodeRVA, [NativeTypeName("DWORD *")] nuint* pdwImplFlags);

        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        nint GetPermissionSetProps([NativeTypeName("mdPermission")] uint pm, [NativeTypeName("DWORD *")] nuint* pdwAction, [NativeTypeName("const void **")] void** ppvPermission, [NativeTypeName("ULONG *")] nuint* pcbPermission);

        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        nint GetSigFromToken([NativeTypeName("mdSignature")] uint mdSig, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSig, [NativeTypeName("ULONG *")] nuint* pcbSig);

        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        nint GetModuleRefProps([NativeTypeName("mdModuleRef")] uint mur, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName);

        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        nint EnumModuleRefs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdModuleRef[]")] uint* rModuleRefs, [NativeTypeName("ULONG")] nuint cmax, [NativeTypeName("ULONG *")] nuint* pcModuleRefs);

        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        nint GetTypeSpecFromToken([NativeTypeName("mdTypeSpec")] uint typespec, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSig, [NativeTypeName("ULONG *")] nuint* pcbSig);

        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        nint GetNameFromToken([NativeTypeName("mdToken")] uint tk, [NativeTypeName("MDUTF8CSTR *")] sbyte** pszUtf8NamePtr);

        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        nint EnumUnresolvedMethods([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdToken[]")] uint* rMethods, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        nint GetUserString([NativeTypeName("mdString")] uint stk, [NativeTypeName("LPWSTR")] uint* szString, [NativeTypeName("ULONG")] nuint cchString, [NativeTypeName("ULONG *")] nuint* pchString);

        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        nint GetPinvokeMap([NativeTypeName("mdToken")] uint tk, [NativeTypeName("DWORD *")] nuint* pdwMappingFlags, [NativeTypeName("LPWSTR")] uint* szImportName, [NativeTypeName("ULONG")] nuint cchImportName, [NativeTypeName("ULONG *")] nuint* pchImportName, [NativeTypeName("mdModuleRef *")] uint* pmrImportDLL);

        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        nint EnumSignatures([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdSignature[]")] uint* rSignatures, [NativeTypeName("ULONG")] nuint cmax, [NativeTypeName("ULONG *")] nuint* pcSignatures);

        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        nint EnumTypeSpecs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdTypeSpec[]")] uint* rTypeSpecs, [NativeTypeName("ULONG")] nuint cmax, [NativeTypeName("ULONG *")] nuint* pcTypeSpecs);

        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        nint EnumUserStrings([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdString[]")] uint* rStrings, [NativeTypeName("ULONG")] nuint cmax, [NativeTypeName("ULONG *")] nuint* pcStrings);

        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        nint GetParamForMethodIndex([NativeTypeName("mdMethodDef")] uint md, [NativeTypeName("ULONG")] nuint ulParamSeq, [NativeTypeName("mdParamDef *")] uint* ppd);

        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        nint EnumCustomAttributes([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdToken")] uint tk, [NativeTypeName("mdToken")] uint tkType, [NativeTypeName("mdCustomAttribute[]")] uint* rCustomAttributes, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcCustomAttributes);

        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        nint GetCustomAttributeProps([NativeTypeName("mdCustomAttribute")] uint cv, [NativeTypeName("mdToken *")] uint* ptkObj, [NativeTypeName("mdToken *")] uint* ptkType, [NativeTypeName("const void **")] void** ppBlob, [NativeTypeName("ULONG *")] nuint* pcbSize);

        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        nint FindTypeRef([NativeTypeName("mdToken")] uint tkResolutionScope, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdTypeRef *")] uint* ptr);

        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        nint GetMemberProps([NativeTypeName("mdToken")] uint mb, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("LPWSTR")] uint* szMember, [NativeTypeName("ULONG")] nuint cchMember, [NativeTypeName("ULONG *")] nuint* pchMember, [NativeTypeName("DWORD *")] nuint* pdwAttr, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSigBlob, [NativeTypeName("ULONG *")] nuint* pcbSigBlob, [NativeTypeName("ULONG *")] nuint* pulCodeRVA, [NativeTypeName("DWORD *")] nuint* pdwImplFlags, [NativeTypeName("DWORD *")] nuint* pdwCPlusTypeFlag, [NativeTypeName("UVCP_CONSTANT *")] void** ppValue, [NativeTypeName("ULONG *")] nuint* pcchValue);

        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        nint GetFieldProps([NativeTypeName("mdFieldDef")] uint mb, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("LPWSTR")] uint* szField, [NativeTypeName("ULONG")] nuint cchField, [NativeTypeName("ULONG *")] nuint* pchField, [NativeTypeName("DWORD *")] nuint* pdwAttr, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSigBlob, [NativeTypeName("ULONG *")] nuint* pcbSigBlob, [NativeTypeName("DWORD *")] nuint* pdwCPlusTypeFlag, [NativeTypeName("UVCP_CONSTANT *")] void** ppValue, [NativeTypeName("ULONG *")] nuint* pcchValue);

        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        nint GetPropertyProps([NativeTypeName("mdProperty")] uint prop, [NativeTypeName("mdTypeDef *")] uint* pClass, [NativeTypeName("LPCWSTR")] uint* szProperty, [NativeTypeName("ULONG")] nuint cchProperty, [NativeTypeName("ULONG *")] nuint* pchProperty, [NativeTypeName("DWORD *")] nuint* pdwPropFlags, [NativeTypeName("PCCOR_SIGNATURE *")] byte** ppvSig, [NativeTypeName("ULONG *")] nuint* pbSig, [NativeTypeName("DWORD *")] nuint* pdwCPlusTypeFlag, [NativeTypeName("UVCP_CONSTANT *")] void** ppDefaultValue, [NativeTypeName("ULONG *")] nuint* pcchDefaultValue, [NativeTypeName("mdMethodDef *")] uint* pmdSetter, [NativeTypeName("mdMethodDef *")] uint* pmdGetter, [NativeTypeName("mdMethodDef[]")] uint* rmdOtherMethod, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcOtherMethod);

        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        nint GetParamProps([NativeTypeName("mdParamDef")] uint tk, [NativeTypeName("mdMethodDef *")] uint* pmd, [NativeTypeName("ULONG *")] nuint* pulSequence, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, [NativeTypeName("DWORD *")] nuint* pdwAttr, [NativeTypeName("DWORD *")] nuint* pdwCPlusTypeFlag, [NativeTypeName("UVCP_CONSTANT *")] void** ppValue, [NativeTypeName("ULONG *")] nuint* pcchValue);

        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        nint GetCustomAttributeByName([NativeTypeName("mdToken")] uint tkObj, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const void **")] void** ppData, [NativeTypeName("ULONG *")] nuint* pcbData);

        [VtblIndex(61)]
        [return: NativeTypeName("BOOL")]
        int IsValidToken([NativeTypeName("mdToken")] uint tk);

        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        nint GetNestedClassProps([NativeTypeName("mdTypeDef")] uint tdNestedClass, [NativeTypeName("mdTypeDef *")] uint* ptdEnclosingClass);

        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        nint GetNativeCallConvFromSig([NativeTypeName("const void *")] void* pvSig, [NativeTypeName("ULONG")] nuint cbSig, [NativeTypeName("ULONG *")] nuint* pCallConv);

        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        nint IsGlobal([NativeTypeName("mdToken")] uint pd, int* pbGlobal);
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

        [NativeTypeName("void (HCORENUM) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, void> CloseEnum;

        [NativeTypeName("HRESULT (HCORENUM, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, nuint*, nint> CountEnum;

        [NativeTypeName("HRESULT (HCORENUM, ULONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, nuint, nint> ResetEnum;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumTypeDefs;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef, mdInterfaceImpl *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, nuint, nuint*, nint> EnumInterfaceImpls;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeRef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumTypeRefs;

        [NativeTypeName("HRESULT (LPCWSTR, mdToken, mdTypeDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint, uint*, nint> FindTypeDefByName;

        [NativeTypeName("HRESULT (LPWSTR, ULONG, ULONG *, GUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, nuint, nuint*, _GUID*, nint> GetScopeProps;

        [NativeTypeName("HRESULT (mdModule *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, nint> GetModuleFromScope;

        [NativeTypeName("HRESULT (mdTypeDef, LPWSTR, ULONG, ULONG *, DWORD *, mdToken *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, nuint*, nuint*, uint*, nint> GetTypeDefProps;

        [NativeTypeName("HRESULT (mdInterfaceImpl, mdTypeDef *, mdToken *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, nint> GetInterfaceImplProps;

        [NativeTypeName("HRESULT (mdTypeRef, mdToken *, LPWSTR, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, nuint, nuint*, nint> GetTypeRefProps;

        [NativeTypeName("HRESULT (mdTypeRef, const IID &, IUnknown **, mdTypeDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, _GUID*, IUnknown**, uint*, nint> ResolveTypeRef;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef, mdToken *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, nuint, nuint*, nint> EnumMembers;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef, LPCWSTR, mdToken *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, uint*, nuint, nuint*, nint> EnumMembersWithName;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef, mdMethodDef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, nuint, nuint*, nint> EnumMethods;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef, LPCWSTR, mdMethodDef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, uint*, nuint, nuint*, nint> EnumMethodsWithName;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef, mdFieldDef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, nuint, nuint*, nint> EnumFields;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef, LPCWSTR, mdFieldDef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, uint*, nuint, nuint*, nint> EnumFieldsWithName;

        [NativeTypeName("HRESULT (HCORENUM *, mdMethodDef, mdParamDef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, nuint, nuint*, nint> EnumParams;

        [NativeTypeName("HRESULT (HCORENUM *, mdToken, mdMemberRef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, nuint, nuint*, nint> EnumMemberRefs;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef, mdToken *, mdToken *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, uint*, nuint, nuint*, nint> EnumMethodImpls;

        [NativeTypeName("HRESULT (HCORENUM *, mdToken, DWORD, mdPermission *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, nuint, uint*, nuint, nuint*, nint> EnumPermissionSets;

        [NativeTypeName("HRESULT (mdTypeDef, LPCWSTR, PCCOR_SIGNATURE, ULONG, mdToken *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, nuint, uint*, nint> FindMember;

        [NativeTypeName("HRESULT (mdTypeDef, LPCWSTR, PCCOR_SIGNATURE, ULONG, mdMethodDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, nuint, uint*, nint> FindMethod;

        [NativeTypeName("HRESULT (mdTypeDef, LPCWSTR, PCCOR_SIGNATURE, ULONG, mdFieldDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, nuint, uint*, nint> FindField;

        [NativeTypeName("HRESULT (mdTypeRef, LPCWSTR, PCCOR_SIGNATURE, ULONG, mdMemberRef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, nuint, uint*, nint> FindMemberRef;

        [NativeTypeName("HRESULT (mdMethodDef, mdTypeDef *, LPWSTR, ULONG, ULONG *, DWORD *, PCCOR_SIGNATURE *, ULONG *, ULONG *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, nuint, nuint*, nuint*, byte**, nuint*, nuint*, nuint*, nint> GetMethodProps;

        [NativeTypeName("HRESULT (mdMemberRef, mdToken *, LPWSTR, ULONG, ULONG *, PCCOR_SIGNATURE *, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, nuint, nuint*, byte**, nuint*, nint> GetMemberRefProps;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef, mdProperty *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, nuint, nuint*, nint> EnumProperties;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeDef, mdEvent *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, nuint, nuint*, nint> EnumEvents;

        [NativeTypeName("HRESULT (mdEvent, mdTypeDef *, LPCWSTR, ULONG, ULONG *, DWORD *, mdToken *, mdMethodDef *, mdMethodDef *, mdMethodDef *, mdMethodDef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, nuint, nuint*, nuint*, uint*, uint*, uint*, uint*, uint*, nuint, nuint*, nint> GetEventProps;

        [NativeTypeName("HRESULT (HCORENUM *, mdMethodDef, mdToken *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint*, nuint, nuint*, nint> EnumMethodSemantics;

        [NativeTypeName("HRESULT (mdMethodDef, mdToken, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, nuint*, nint> GetMethodSemantics;

        [NativeTypeName("HRESULT (mdTypeDef, DWORD *, COR_FIELD_OFFSET *, ULONG, ULONG *, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint*, COR_FIELD_OFFSET*, nuint, nuint*, nuint*, nint> GetClassLayout;

        [NativeTypeName("HRESULT (mdToken, PCCOR_SIGNATURE *, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte**, nuint*, nint> GetFieldMarshal;

        [NativeTypeName("HRESULT (mdToken, ULONG *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint*, nuint*, nint> GetRVA;

        [NativeTypeName("HRESULT (mdPermission, DWORD *, const void **, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint*, void**, nuint*, nint> GetPermissionSetProps;

        [NativeTypeName("HRESULT (mdSignature, PCCOR_SIGNATURE *, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte**, nuint*, nint> GetSigFromToken;

        [NativeTypeName("HRESULT (mdModuleRef, LPWSTR, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, nuint*, nint> GetModuleRefProps;

        [NativeTypeName("HRESULT (HCORENUM *, mdModuleRef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumModuleRefs;

        [NativeTypeName("HRESULT (mdTypeSpec, PCCOR_SIGNATURE *, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte**, nuint*, nint> GetTypeSpecFromToken;

        [NativeTypeName("HRESULT (mdToken, MDUTF8CSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, sbyte**, nint> GetNameFromToken;

        [NativeTypeName("HRESULT (HCORENUM *, mdToken *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumUnresolvedMethods;

        [NativeTypeName("HRESULT (mdString, LPWSTR, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, nuint*, nint> GetUserString;

        [NativeTypeName("HRESULT (mdToken, DWORD *, LPWSTR, ULONG, ULONG *, mdModuleRef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint*, uint*, nuint, nuint*, uint*, nint> GetPinvokeMap;

        [NativeTypeName("HRESULT (HCORENUM *, mdSignature *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumSignatures;

        [NativeTypeName("HRESULT (HCORENUM *, mdTypeSpec *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumTypeSpecs;

        [NativeTypeName("HRESULT (HCORENUM *, mdString *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumUserStrings;

        [NativeTypeName("HRESULT (mdMethodDef, ULONG, mdParamDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, uint*, nint> GetParamForMethodIndex;

        [NativeTypeName("HRESULT (HCORENUM *, mdToken, mdToken, mdCustomAttribute *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint, uint, uint*, nuint, nuint*, nint> EnumCustomAttributes;

        [NativeTypeName("HRESULT (mdCustomAttribute, mdToken *, mdToken *, const void **, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, void**, nuint*, nint> GetCustomAttributeProps;

        [NativeTypeName("HRESULT (mdToken, LPCWSTR, mdTypeRef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, nint> FindTypeRef;

        [NativeTypeName("HRESULT (mdToken, mdTypeDef *, LPWSTR, ULONG, ULONG *, DWORD *, PCCOR_SIGNATURE *, ULONG *, ULONG *, DWORD *, DWORD *, UVCP_CONSTANT *, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, nuint, nuint*, nuint*, byte**, nuint*, nuint*, nuint*, nuint*, void**, nuint*, nint> GetMemberProps;

        [NativeTypeName("HRESULT (mdFieldDef, mdTypeDef *, LPWSTR, ULONG, ULONG *, DWORD *, PCCOR_SIGNATURE *, ULONG *, DWORD *, UVCP_CONSTANT *, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, nuint, nuint*, nuint*, byte**, nuint*, nuint*, void**, nuint*, nint> GetFieldProps;

        [NativeTypeName("HRESULT (mdProperty, mdTypeDef *, LPCWSTR, ULONG, ULONG *, DWORD *, PCCOR_SIGNATURE *, ULONG *, DWORD *, UVCP_CONSTANT *, ULONG *, mdMethodDef *, mdMethodDef *, mdMethodDef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, nuint, nuint*, nuint*, byte**, nuint*, nuint*, void**, nuint*, uint*, uint*, uint*, nuint, nuint*, nint> GetPropertyProps;

        [NativeTypeName("HRESULT (mdParamDef, mdMethodDef *, ULONG *, LPWSTR, ULONG, ULONG *, DWORD *, DWORD *, UVCP_CONSTANT *, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint*, uint*, nuint, nuint*, nuint*, nuint*, void**, nuint*, nint> GetParamProps;

        [NativeTypeName("HRESULT (mdToken, LPCWSTR, const void **, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, void**, nuint*, nint> GetCustomAttributeByName;

        [NativeTypeName("BOOL (mdToken) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> IsValidToken;

        [NativeTypeName("HRESULT (mdTypeDef, mdTypeDef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nint> GetNestedClassProps;

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, nuint, nuint*, nint> GetNativeCallConvFromSig;

        [NativeTypeName("HRESULT (mdToken, int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int*, nint> IsGlobal;
    }
}
