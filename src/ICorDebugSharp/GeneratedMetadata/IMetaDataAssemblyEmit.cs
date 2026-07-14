// ReSharper disable InconsistentNaming
using System.Runtime.CompilerServices;

namespace ICorDebugSharp.GeneratedMetadata;

[NativeTypeName("struct IMetaDataAssemblyEmit : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMetaDataAssemblyEmit : IMetaDataAssemblyEmit.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("HRESULT")]
    public nint QueryInterface([NativeTypeName("const IID &")] _GUID* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, _GUID*, void**, nint>)(lpVtbl[0]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, nuint>)(lpVtbl[1]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, nuint>)(lpVtbl[2]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineAssembly([NativeTypeName("const void *")] void* pbPublicKey, [NativeTypeName("ULONG")] nuint cbPublicKey, [NativeTypeName("ULONG")] nuint ulHashAlgId, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const ASSEMBLYMETADATA *")] ASSEMBLYMETADATA* pMetaData, [NativeTypeName("DWORD")] nuint dwAssemblyFlags, [NativeTypeName("mdAssembly *")] uint* pma)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, void*, nuint, nuint, uint*, ASSEMBLYMETADATA*, nuint, uint*, nint>)(lpVtbl[3]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), pbPublicKey, cbPublicKey, ulHashAlgId, szName, pMetaData, dwAssemblyFlags, pma);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineAssemblyRef([NativeTypeName("const void *")] void* pbPublicKeyOrToken, [NativeTypeName("ULONG")] nuint cbPublicKeyOrToken, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const ASSEMBLYMETADATA *")] ASSEMBLYMETADATA* pMetaData, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, [NativeTypeName("DWORD")] nuint dwAssemblyRefFlags, [NativeTypeName("mdAssemblyRef *")] uint* pmdar)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, void*, nuint, uint*, ASSEMBLYMETADATA*, void*, nuint, nuint, uint*, nint>)(lpVtbl[4]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), pbPublicKeyOrToken, cbPublicKeyOrToken, szName, pMetaData, pbHashValue, cbHashValue, dwAssemblyRefFlags, pmdar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineFile([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, [NativeTypeName("DWORD")] nuint dwFileFlags, [NativeTypeName("mdFile *")] uint* pmdf)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, uint*, void*, nuint, nuint, uint*, nint>)(lpVtbl[5]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), szName, pbHashValue, cbHashValue, dwFileFlags, pmdf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineExportedType([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdToken")] uint tkImplementation, [NativeTypeName("mdTypeDef")] uint tkTypeDef, [NativeTypeName("DWORD")] nuint dwExportedTypeFlags, [NativeTypeName("mdExportedType *")] uint* pmdct)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, uint*, uint, uint, nuint, uint*, nint>)(lpVtbl[6]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), szName, tkImplementation, tkTypeDef, dwExportedTypeFlags, pmdct);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("HRESULT")]
    public nint DefineManifestResource([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdToken")] uint tkImplementation, [NativeTypeName("DWORD")] nuint dwOffset, [NativeTypeName("DWORD")] nuint dwResourceFlags, [NativeTypeName("mdManifestResource *")] uint* pmdmr)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, uint*, uint, nuint, nuint, uint*, nint>)(lpVtbl[7]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), szName, tkImplementation, dwOffset, dwResourceFlags, pmdmr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("HRESULT")]
    public nint SetAssemblyProps([NativeTypeName("mdAssembly")] uint pma, [NativeTypeName("const void *")] void* pbPublicKey, [NativeTypeName("ULONG")] nuint cbPublicKey, [NativeTypeName("ULONG")] nuint ulHashAlgId, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const ASSEMBLYMETADATA *")] ASSEMBLYMETADATA* pMetaData, [NativeTypeName("DWORD")] nuint dwAssemblyFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, uint, void*, nuint, nuint, uint*, ASSEMBLYMETADATA*, nuint, nint>)(lpVtbl[8]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), pma, pbPublicKey, cbPublicKey, ulHashAlgId, szName, pMetaData, dwAssemblyFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("HRESULT")]
    public nint SetAssemblyRefProps([NativeTypeName("mdAssemblyRef")] uint ar, [NativeTypeName("const void *")] void* pbPublicKeyOrToken, [NativeTypeName("ULONG")] nuint cbPublicKeyOrToken, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const ASSEMBLYMETADATA *")] ASSEMBLYMETADATA* pMetaData, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, [NativeTypeName("DWORD")] nuint dwAssemblyRefFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, uint, void*, nuint, uint*, ASSEMBLYMETADATA*, void*, nuint, nuint, nint>)(lpVtbl[9]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), ar, pbPublicKeyOrToken, cbPublicKeyOrToken, szName, pMetaData, pbHashValue, cbHashValue, dwAssemblyRefFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("HRESULT")]
    public nint SetFileProps([NativeTypeName("mdFile")] uint file, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, [NativeTypeName("DWORD")] nuint dwFileFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, uint, void*, nuint, nuint, nint>)(lpVtbl[10]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), file, pbHashValue, cbHashValue, dwFileFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("HRESULT")]
    public nint SetExportedTypeProps([NativeTypeName("mdExportedType")] uint ct, [NativeTypeName("mdToken")] uint tkImplementation, [NativeTypeName("mdTypeDef")] uint tkTypeDef, [NativeTypeName("DWORD")] nuint dwExportedTypeFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, uint, uint, uint, nuint, nint>)(lpVtbl[11]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), ct, tkImplementation, tkTypeDef, dwExportedTypeFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("HRESULT")]
    public nint SetManifestResourceProps([NativeTypeName("mdManifestResource")] uint mr, [NativeTypeName("mdToken")] uint tkImplementation, [NativeTypeName("DWORD")] nuint dwOffset, [NativeTypeName("DWORD")] nuint dwResourceFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMetaDataAssemblyEmit*, uint, uint, nuint, nuint, nint>)(lpVtbl[12]))((IMetaDataAssemblyEmit*)Unsafe.AsPointer(ref this), mr, tkImplementation, dwOffset, dwResourceFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        nint DefineAssembly([NativeTypeName("const void *")] void* pbPublicKey, [NativeTypeName("ULONG")] nuint cbPublicKey, [NativeTypeName("ULONG")] nuint ulHashAlgId, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const ASSEMBLYMETADATA *")] ASSEMBLYMETADATA* pMetaData, [NativeTypeName("DWORD")] nuint dwAssemblyFlags, [NativeTypeName("mdAssembly *")] uint* pma);

        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        nint DefineAssemblyRef([NativeTypeName("const void *")] void* pbPublicKeyOrToken, [NativeTypeName("ULONG")] nuint cbPublicKeyOrToken, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const ASSEMBLYMETADATA *")] ASSEMBLYMETADATA* pMetaData, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, [NativeTypeName("DWORD")] nuint dwAssemblyRefFlags, [NativeTypeName("mdAssemblyRef *")] uint* pmdar);

        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        nint DefineFile([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, [NativeTypeName("DWORD")] nuint dwFileFlags, [NativeTypeName("mdFile *")] uint* pmdf);

        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        nint DefineExportedType([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdToken")] uint tkImplementation, [NativeTypeName("mdTypeDef")] uint tkTypeDef, [NativeTypeName("DWORD")] nuint dwExportedTypeFlags, [NativeTypeName("mdExportedType *")] uint* pmdct);

        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        nint DefineManifestResource([NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("mdToken")] uint tkImplementation, [NativeTypeName("DWORD")] nuint dwOffset, [NativeTypeName("DWORD")] nuint dwResourceFlags, [NativeTypeName("mdManifestResource *")] uint* pmdmr);

        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        nint SetAssemblyProps([NativeTypeName("mdAssembly")] uint pma, [NativeTypeName("const void *")] void* pbPublicKey, [NativeTypeName("ULONG")] nuint cbPublicKey, [NativeTypeName("ULONG")] nuint ulHashAlgId, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const ASSEMBLYMETADATA *")] ASSEMBLYMETADATA* pMetaData, [NativeTypeName("DWORD")] nuint dwAssemblyFlags);

        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        nint SetAssemblyRefProps([NativeTypeName("mdAssemblyRef")] uint ar, [NativeTypeName("const void *")] void* pbPublicKeyOrToken, [NativeTypeName("ULONG")] nuint cbPublicKeyOrToken, [NativeTypeName("LPCWSTR")] uint* szName, [NativeTypeName("const ASSEMBLYMETADATA *")] ASSEMBLYMETADATA* pMetaData, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, [NativeTypeName("DWORD")] nuint dwAssemblyRefFlags);

        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        nint SetFileProps([NativeTypeName("mdFile")] uint file, [NativeTypeName("const void *")] void* pbHashValue, [NativeTypeName("ULONG")] nuint cbHashValue, [NativeTypeName("DWORD")] nuint dwFileFlags);

        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        nint SetExportedTypeProps([NativeTypeName("mdExportedType")] uint ct, [NativeTypeName("mdToken")] uint tkImplementation, [NativeTypeName("mdTypeDef")] uint tkTypeDef, [NativeTypeName("DWORD")] nuint dwExportedTypeFlags);

        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        nint SetManifestResourceProps([NativeTypeName("mdManifestResource")] uint mr, [NativeTypeName("mdToken")] uint tkImplementation, [NativeTypeName("DWORD")] nuint dwOffset, [NativeTypeName("DWORD")] nuint dwResourceFlags);
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

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG, LPCWSTR, const ASSEMBLYMETADATA *, DWORD, mdAssembly *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, nuint, nuint, uint*, ASSEMBLYMETADATA*, nuint, uint*, nint> DefineAssembly;

        [NativeTypeName("HRESULT (const void *, ULONG, LPCWSTR, const ASSEMBLYMETADATA *, const void *, ULONG, DWORD, mdAssemblyRef *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, nuint, uint*, ASSEMBLYMETADATA*, void*, nuint, nuint, uint*, nint> DefineAssemblyRef;

        [NativeTypeName("HRESULT (LPCWSTR, const void *, ULONG, DWORD, mdFile *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, void*, nuint, nuint, uint*, nint> DefineFile;

        [NativeTypeName("HRESULT (LPCWSTR, mdToken, mdTypeDef, DWORD, mdExportedType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint, uint, nuint, uint*, nint> DefineExportedType;

        [NativeTypeName("HRESULT (LPCWSTR, mdToken, DWORD, DWORD, mdManifestResource *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint, nuint, nuint, uint*, nint> DefineManifestResource;

        [NativeTypeName("HRESULT (mdAssembly, const void *, ULONG, ULONG, LPCWSTR, const ASSEMBLYMETADATA *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, nuint, nuint, uint*, ASSEMBLYMETADATA*, nuint, nint> SetAssemblyProps;

        [NativeTypeName("HRESULT (mdAssemblyRef, const void *, ULONG, LPCWSTR, const ASSEMBLYMETADATA *, const void *, ULONG, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, nuint, uint*, ASSEMBLYMETADATA*, void*, nuint, nuint, nint> SetAssemblyRefProps;

        [NativeTypeName("HRESULT (mdFile, const void *, ULONG, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, nuint, nuint, nint> SetFileProps;

        [NativeTypeName("HRESULT (mdExportedType, mdToken, mdTypeDef, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, nuint, nint> SetExportedTypeProps;

        [NativeTypeName("HRESULT (mdManifestResource, mdToken, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, nuint, nuint, nint> SetManifestResourceProps;
    }
}
