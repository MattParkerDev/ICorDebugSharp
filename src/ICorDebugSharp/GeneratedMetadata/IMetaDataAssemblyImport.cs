// ReSharper disable InconsistentNaming
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataAssemblyImport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMetaDataAssemblyImport : IMetaDataAssemblyImport.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] _GUID* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, _GUID*, void**, nint>)(lpVtbl[0]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, nuint>)(lpVtbl[1]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, nuint>)(lpVtbl[2]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint GetAssemblyProps([NativeTypeName("mdAssembly")] uint mda, [NativeTypeName("const void **")] void** ppbPublicKey, [NativeTypeName("ULONG *")] nuint* pcbPublicKey, [NativeTypeName("ULONG *")] nuint* pulHashAlgId, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, ASSEMBLYMETADATA* pMetaData, [NativeTypeName("DWORD *")] nuint* pdwAssemblyFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, uint, void**, nuint*, nuint*, uint*, nuint, nuint*, ASSEMBLYMETADATA*, nuint*, nint>)(lpVtbl[3]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), mda, ppbPublicKey, pcbPublicKey, pulHashAlgId, szName, cchName, pchName, pMetaData, pdwAssemblyFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public nint GetAssemblyRefProps([NativeTypeName("mdAssemblyRef")] uint mdar, [NativeTypeName("const void **")] void** ppbPublicKeyOrToken, [NativeTypeName("ULONG *")] nuint* pcbPublicKeyOrToken, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, ASSEMBLYMETADATA* pMetaData, [NativeTypeName("const void **")] void** ppbHashValue, [NativeTypeName("ULONG *")] nuint* pcbHashValue, [NativeTypeName("DWORD *")] nuint* pdwAssemblyRefFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, uint, void**, nuint*, uint*, nuint, nuint*, ASSEMBLYMETADATA*, void**, nuint*, nuint*, nint>)(lpVtbl[4]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), mdar, ppbPublicKeyOrToken, pcbPublicKeyOrToken, szName, cchName, pchName, pMetaData, ppbHashValue, pcbHashValue, pdwAssemblyRefFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("HRESULT")]
    public nint GetFileProps([NativeTypeName("mdFile")] uint mdf, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, [NativeTypeName("const void **")] void** ppbHashValue, [NativeTypeName("ULONG *")] nuint* pcbHashValue, [NativeTypeName("DWORD *")] nuint* pdwFileFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, uint, uint*, nuint, nuint*, void**, nuint*, nuint*, nint>)(lpVtbl[5]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), mdf, szName, cchName, pchName, ppbHashValue, pcbHashValue, pdwFileFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("HRESULT")]
    public nint GetExportedTypeProps([NativeTypeName("mdExportedType")] uint mdct, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, [NativeTypeName("mdToken *")] uint* ptkImplementation, [NativeTypeName("mdTypeDef *")] uint* ptkTypeDef, [NativeTypeName("DWORD *")] nuint* pdwExportedTypeFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, uint, uint*, nuint, nuint*, uint*, uint*, nuint*, nint>)(lpVtbl[6]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), mdct, szName, cchName, pchName, ptkImplementation, ptkTypeDef, pdwExportedTypeFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("HRESULT")]
    public nint GetManifestResourceProps([NativeTypeName("mdManifestResource")] uint mdmr, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, [NativeTypeName("mdToken *")] uint* ptkImplementation, [NativeTypeName("DWORD *")] nuint* pdwOffset, [NativeTypeName("DWORD *")] nuint* pdwResourceFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, uint, uint*, nuint, nuint*, uint*, nuint*, nuint*, nint>)(lpVtbl[7]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), mdmr, szName, cchName, pchName, ptkImplementation, pdwOffset, pdwResourceFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumAssemblyRefs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdAssemblyRef[]")] uint* rAssemblyRefs, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[8]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), phEnum, rAssemblyRefs, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumFiles([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdFile[]")] uint* rFiles, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[9]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), phEnum, rFiles, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumExportedTypes([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdExportedType[]")] uint* rExportedTypes, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[10]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), phEnum, rExportedTypes, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("HRESULT")]
    public nint EnumManifestResources([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdManifestResource[]")] uint* rManifestResources, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, void**, uint*, nuint, nuint*, nint>)(lpVtbl[11]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), phEnum, rManifestResources, cMax, pcTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("HRESULT")]
    public nint GetAssemblyFromScope([NativeTypeName("mdAssembly *")] uint* ptkAssembly)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, uint*, nint>)(lpVtbl[12]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), ptkAssembly);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("HRESULT")]
    public nint FindExportedTypeByName([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdToken")] uint mdtExportedType, [NativeTypeName("mdExportedType *")] uint* ptkExportedType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, uint*, uint, uint*, nint>)(lpVtbl[13]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), szName, mdtExportedType, ptkExportedType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("HRESULT")]
    public nint FindManifestResourceByName([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdManifestResource *")] uint* ptkManifestResource)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, uint*, uint*, nint>)(lpVtbl[14]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), szName, ptkManifestResource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void CloseEnum([NativeTypeName("HCORENUM")] void* hEnum)
    {
        ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, void*, void>)(lpVtbl[15]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), hEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [return: NativeTypeName("HRESULT")]
    public nint FindAssembliesByName([NativeTypeName("LPCWSTR")] uint* szAppBase, [NativeTypeName("LPCWSTR")] uint* szPrivateBin, [NativeTypeName("LPCWSTR")] uint* szAssemblyName, [NativeTypeName("IUnknown *[]")] IUnknown** ppIUnk, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcAssemblies)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyImport*, uint*, uint*, uint*, IUnknown**, nuint, nuint*, nint>)(lpVtbl[16]))((IMetaDataAssemblyImport*)Unsafe.AsPointer(ref this), szAppBase, szPrivateBin, szAssemblyName, ppIUnk, cMax, pcAssemblies);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        nint GetAssemblyProps([NativeTypeName("mdAssembly")] uint mda, [NativeTypeName("const void **")] void** ppbPublicKey, [NativeTypeName("ULONG *")] nuint* pcbPublicKey, [NativeTypeName("ULONG *")] nuint* pulHashAlgId, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, ASSEMBLYMETADATA* pMetaData, [NativeTypeName("DWORD *")] nuint* pdwAssemblyFlags);

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        nint GetAssemblyRefProps([NativeTypeName("mdAssemblyRef")] uint mdar, [NativeTypeName("const void **")] void** ppbPublicKeyOrToken, [NativeTypeName("ULONG *")] nuint* pcbPublicKeyOrToken, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, ASSEMBLYMETADATA* pMetaData, [NativeTypeName("const void **")] void** ppbHashValue, [NativeTypeName("ULONG *")] nuint* pcbHashValue, [NativeTypeName("DWORD *")] nuint* pdwAssemblyRefFlags);

        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        nint GetFileProps([NativeTypeName("mdFile")] uint mdf, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, [NativeTypeName("const void **")] void** ppbHashValue, [NativeTypeName("ULONG *")] nuint* pcbHashValue, [NativeTypeName("DWORD *")] nuint* pdwFileFlags);

        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        nint GetExportedTypeProps([NativeTypeName("mdExportedType")] uint mdct, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, [NativeTypeName("mdToken *")] uint* ptkImplementation, [NativeTypeName("mdTypeDef *")] uint* ptkTypeDef, [NativeTypeName("DWORD *")] nuint* pdwExportedTypeFlags);

        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        nint GetManifestResourceProps([NativeTypeName("mdManifestResource")] uint mdmr, [NativeTypeName("LPWSTR")] uint* szName, [NativeTypeName("ULONG")] nuint cchName, [NativeTypeName("ULONG *")] nuint* pchName, [NativeTypeName("mdToken *")] uint* ptkImplementation, [NativeTypeName("DWORD *")] nuint* pdwOffset, [NativeTypeName("DWORD *")] nuint* pdwResourceFlags);

        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        nint EnumAssemblyRefs([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdAssemblyRef[]")] uint* rAssemblyRefs, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        nint EnumFiles([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdFile[]")] uint* rFiles, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        nint EnumExportedTypes([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdExportedType[]")] uint* rExportedTypes, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        nint EnumManifestResources([NativeTypeName("HCORENUM *")] void** phEnum, [NativeTypeName("mdManifestResource[]")] uint* rManifestResources, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcTokens);

        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        nint GetAssemblyFromScope([NativeTypeName("mdAssembly *")] uint* ptkAssembly);

        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        nint FindExportedTypeByName([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdToken")] uint mdtExportedType, [NativeTypeName("mdExportedType *")] uint* ptkExportedType);

        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        nint FindManifestResourceByName([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdManifestResource *")] uint* ptkManifestResource);

        [VtblIndex(15)]
        void CloseEnum([NativeTypeName("HCORENUM")] void* hEnum);

        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        nint FindAssembliesByName([NativeTypeName("LPCWSTR")] uint* szAppBase, [NativeTypeName("LPCWSTR")] uint* szPrivateBin, [NativeTypeName("LPCWSTR")] uint* szAssemblyName, [NativeTypeName("IUnknown *[]")] IUnknown** ppIUnk, [NativeTypeName("ULONG")] nuint cMax, [NativeTypeName("ULONG *")] nuint* pcAssemblies);
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

        [NativeTypeName("HRESULT (mdAssembly, const void **, ULONG *, ULONG *, LPWSTR, ULONG, ULONG *, ASSEMBLYMETADATA *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void**, nuint*, nuint*, uint*, nuint, nuint*, ASSEMBLYMETADATA*, nuint*, nint> GetAssemblyProps;

        [NativeTypeName("HRESULT (mdAssemblyRef, const void **, ULONG *, LPWSTR, ULONG, ULONG *, ASSEMBLYMETADATA *, const void **, ULONG *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void**, nuint*, uint*, nuint, nuint*, ASSEMBLYMETADATA*, void**, nuint*, nuint*, nint> GetAssemblyRefProps;

        [NativeTypeName("HRESULT (mdFile, LPWSTR, ULONG, ULONG *, const void **, ULONG *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, nuint*, void**, nuint*, nuint*, nint> GetFileProps;

        [NativeTypeName("HRESULT (mdExportedType, LPWSTR, ULONG, ULONG *, mdToken *, mdTypeDef *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, nuint*, uint*, uint*, nuint*, nint> GetExportedTypeProps;

        [NativeTypeName("HRESULT (mdManifestResource, LPWSTR, ULONG, ULONG *, mdToken *, DWORD *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, nuint, nuint*, uint*, nuint*, nuint*, nint> GetManifestResourceProps;

        [NativeTypeName("HRESULT (HCORENUM *, mdAssemblyRef *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumAssemblyRefs;

        [NativeTypeName("HRESULT (HCORENUM *, mdFile *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumFiles;

        [NativeTypeName("HRESULT (HCORENUM *, mdExportedType *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumExportedTypes;

        [NativeTypeName("HRESULT (HCORENUM *, mdManifestResource *, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, nuint, nuint*, nint> EnumManifestResources;

        [NativeTypeName("HRESULT (mdAssembly *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, nint> GetAssemblyFromScope;

        [NativeTypeName("HRESULT (LPCWSTR, mdToken, mdExportedType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint, uint*, nint> FindExportedTypeByName;

        [NativeTypeName("HRESULT (LPCWSTR, mdManifestResource *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, nint> FindManifestResourceByName;

        [NativeTypeName("void (HCORENUM) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, void> CloseEnum;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, IUnknown **, ULONG, ULONG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, uint*, IUnknown**, nuint, nuint*, nint> FindAssembliesByName;
    }
}
