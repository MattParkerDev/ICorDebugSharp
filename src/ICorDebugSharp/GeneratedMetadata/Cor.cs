// ReSharper disable InconsistentNaming
using System;
using static ICorDebugSharp.GeneratedMetadata.CorCallingConvention;
using static ICorDebugSharp.GeneratedMetadata.CorElementType;
using static ICorDebugSharp.GeneratedMetadata.CorTokenType;

namespace ICorDebugSharp.GeneratedMetadata;

public static unsafe partial class Cor
{
	[NativeTypeName("const IID")]
	public static readonly Guid CLSID_CLR_v1_MetaData = new Guid(0x005023ca, 0x72b1, 0x11d3, 0x9f, 0xc4, 0x0, 0xc0, 0x4f, 0x79, 0xa0, 0xa3);

	[NativeTypeName("const IID")]
	public static readonly Guid CLSID_CLR_v2_MetaData = new Guid(0xefea471a, 0x44fd, 0x4862, 0x92, 0x92, 0xc, 0x58, 0xd4, 0x6e, 0x1f, 0x3a);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataCheckDuplicatesFor = new Guid(0x30fe7be8, 0xd7d9, 0x11d2, 0x9f, 0x80, 0x0, 0xc0, 0x4f, 0x79, 0xa0, 0xa3);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataRefToDefCheck = new Guid(0xde3856f8, 0xd7d9, 0x11d2, 0x9f, 0x80, 0x0, 0xc0, 0x4f, 0x79, 0xa0, 0xa3);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataNotificationForTokenMovement = new Guid(0xe5d71a4c, 0xd7da, 0x11d2, 0x9f, 0x80, 0x0, 0xc0, 0x4f, 0x79, 0xa0, 0xa3);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataSetUpdate = new Guid(0x2eee315c, 0xd7db, 0x11d2, 0x9f, 0x80, 0x0, 0xc0, 0x4f, 0x79, 0xa0, 0xa3);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataImportOption = new Guid(0x79700f36, 0x4aac, 0x11d3, 0x84, 0xc3, 0x0, 0x90, 0x27, 0x86, 0x8c, 0xb1);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataThreadSafetyOptions = new Guid(0xf7559806, 0xf266, 0x42ea, 0x8c, 0x63, 0xa, 0xdb, 0x45, 0xe8, 0xb2, 0x34);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataErrorIfEmitOutOfOrder = new Guid(0x1547872d, 0xdc03, 0x11d2, 0x94, 0x20, 0x0, 0x0, 0xf8, 0x8, 0x34, 0x60);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataGenerateTCEAdapters = new Guid(0xdcc9de90, 0x4151, 0x11d3, 0x88, 0xd6, 0x0, 0x90, 0x27, 0x54, 0xc4, 0x3a);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataTypeLibImportNamespace = new Guid(0xf17ff889, 0x5a63, 0x11d3, 0x9f, 0xf2, 0x0, 0xc0, 0x4f, 0xf7, 0x43, 0x1a);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataLinkerOptions = new Guid(0x47e099b6, 0xae7c, 0x4797, 0x83, 0x17, 0xb4, 0x8a, 0xa6, 0x45, 0xb8, 0xf9);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataRuntimeVersion = new Guid(0x47e099b7, 0xae7c, 0x4797, 0x83, 0x17, 0xb4, 0x8a, 0xa6, 0x45, 0xb8, 0xf9);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataMergerOptions = new Guid(0x132d3a6e, 0xb35d, 0x464e, 0x95, 0x1a, 0x42, 0xef, 0xb9, 0xfb, 0x66, 0x1);

	[NativeTypeName("const IID")]
	public static readonly Guid MetaDataPreserveLocalRefs = new Guid(0xa55c0354, 0xe91b, 0x468b, 0x86, 0x48, 0x7c, 0xc3, 0x10, 0x35, 0xd5, 0x33);

	public const int DESCR_GROUP_METHODDEF = 0;
	public const int DESCR_GROUP_METHODIMPL = 1;

	[NativeTypeName("const IID")]
	public static readonly Guid CLSID_CorMetaDataDispenser = new Guid(0xe5cb7a31, 0x7512, 0x11d2, 0x89, 0xce, 0x0, 0x80, 0xc7, 0x92, 0xe5, 0xd8);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataError = new Guid(0xb81ff171, 0x20f3, 0x11d2, 0x8d, 0xcc, 0x0, 0xa0, 0xc9, 0xb0, 0x9c, 0x19);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMapToken = new Guid(0x6a3ea8b, 0x225, 0x11d1, 0xbf, 0x72, 0x0, 0xc0, 0x4f, 0xc3, 0x1e, 0x12);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataDispenser = new Guid(0x809c652e, 0x7396, 0x11d2, 0x97, 0x71, 0x00, 0xa0, 0xc9, 0xb4, 0xd5, 0x0c);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataEmit = new Guid(0xba3fee4c, 0xecb9, 0x4e41, 0x83, 0xb7, 0x18, 0x3f, 0xa4, 0x1c, 0xd8, 0x59);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataEmit2 = new Guid(0xf5dd9950, 0xf693, 0x42e6, 0x83, 0xe, 0x7b, 0x83, 0x3e, 0x81, 0x46, 0xa9);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataImport = new Guid(0x7dac8207, 0xd3ae, 0x4c75, 0x9b, 0x67, 0x92, 0x80, 0x1a, 0x49, 0x7d, 0x44);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataImport2 = new Guid(0xfce5efa0, 0x8bba, 0x4f8e, 0xa0, 0x36, 0x8f, 0x20, 0x22, 0xb0, 0x84, 0x66);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataFilter = new Guid(0xd0e80dd1, 0x12d4, 0x11d3, 0xb3, 0x9d, 0x0, 0xc0, 0x4f, 0xf8, 0x17, 0x95);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IHostFilter = new Guid(0xd0e80dd3, 0x12d4, 0x11d3, 0xb3, 0x9d, 0x0, 0xc0, 0x4f, 0xf8, 0x17, 0x95);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataAssemblyEmit = new Guid(0x211ef15b, 0x5317, 0x4438, 0xb1, 0x96, 0xde, 0xc8, 0x7b, 0x88, 0x76, 0x93);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataAssemblyImport = new Guid(0xee62470b, 0xe94b, 0x424e, 0x9b, 0x7c, 0x2f, 0x0, 0xc9, 0x24, 0x9f, 0x93);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataValidate = new Guid(0x4709c9c6, 0x81ff, 0x11d3, 0x9f, 0xc7, 0x0, 0xc0, 0x4f, 0x79, 0xa0, 0xa3);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataDispenserEx = new Guid(0x31bcfce2, 0xdafb, 0x11d2, 0x9f, 0x81, 0x0, 0xc0, 0x4f, 0x79, 0xa0, 0xa3);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataTables = new Guid(0xd8f579ab, 0x402d, 0x4b8e, 0x82, 0xd9, 0x5d, 0x63, 0xb1, 0x6, 0x5c, 0x68);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataTables2 = new Guid(0xbadb5f70, 0x58da, 0x43a9, 0xa1, 0xc6, 0xd7, 0x48, 0x19, 0xf1, 0x9b, 0x15);

	[NativeTypeName("const IID")]
	public static readonly Guid IID_IMetaDataInfo = new Guid(0x7998EA64, 0x7F95, 0x48B8, 0x86, 0xFC, 0x17, 0xCA, 0xF4, 0x8B, 0xF5, 0xCB);

	public static int CorIsPrimitiveType(CorElementType elementtype)
	{
		return (elementtype < (int)(ELEMENT_TYPE_PTR) || elementtype == ELEMENT_TYPE_I || elementtype == ELEMENT_TYPE_U) ? 1 : 0;
	}

	public static bool CorIsNumericalType(CorElementType elementType)
	{
		return ((elementType >= (int)(ELEMENT_TYPE_I1)) && (elementType <= (int)(ELEMENT_TYPE_R8))) || (elementType == ELEMENT_TYPE_I) || (elementType == ELEMENT_TYPE_U);
	}

	public static int CorIsModifierElementType(CorElementType elementtype)
	{
		if (elementtype == ELEMENT_TYPE_PTR || elementtype == ELEMENT_TYPE_BYREF)
		{
			return 1;
		}

		return (elementtype & (int)(ELEMENT_TYPE_MODIFIER));
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigUncompressedDataSize([NativeTypeName("PCCOR_SIGNATURE")] byte* pData)
	{
		if ((*pData & 0x80) == 0)
		{
			return 1;
		}
		else if ((*pData & 0xC0) == 0x80)
		{
			return 2;
		}
		else
		{
			return 4;
		}
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigUncompressBigData([NativeTypeName("PCCOR_SIGNATURE &")] byte** pData)
	{
		uint res;

		if ((*pData & 0xC0) == 0x80)
		{
			res = (uint)((*pData++ & 0x3f) << 8);
			res |= *pData++;
		}
		else
		{
			res = (*pData++ & 0x1f) << 24;
			res |= *pData++ << 16;
			res |= *pData++ << 8;
			res |= *pData++;
		}

		return res;
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigUncompressData([NativeTypeName("PCCOR_SIGNATURE &")] byte** pData)
	{
		if ((*pData & 0x80) == 0x00)
		{
			return *pData++;
		}

		return CorSigUncompressBigData(pData);
	}

	[return: NativeTypeName("HRESULT")]
	public static int CorSigUncompressData([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, [NativeTypeName("DWORD")] uint len, [NativeTypeName("uint32_t *")] uint* pDataOut, [NativeTypeName("uint32_t *")] uint* pDataLen)
	{
		int hr = ((int)(0));
		byte* pBytes = (byte*)(pData);

		if ((*pBytes & 0x80) == 0x00)
		{
			if (len < 1)
			{
				*pDataOut = 0;
				*pDataLen = 0;
				hr = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1192))));
			}
			else
			{
				*pDataOut = *pBytes;
				*pDataLen = 1;
			}
		}
		else if ((*pBytes & 0xC0) == 0x80)
		{
			if (len < 2)
			{
				*pDataOut = 0;
				*pDataLen = 0;
				hr = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1192))));
			}
			else
			{
				*pDataOut = (uint)(((*pBytes & 0x3f) << 8 | *(pBytes + 1)));
				*pDataLen = 2;
			}
		}
		else if ((*pBytes & 0xE0) == 0xC0)
		{
			if (len < 4)
			{
				*pDataOut = 0;
				*pDataLen = 0;
				hr = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1192))));
			}
			else
			{
				*pDataOut = (uint)(((*pBytes & 0x1f) << 24 | *(pBytes + 1) << 16 | *(pBytes + 2) << 8 | *(pBytes + 3)));
				*pDataLen = 4;
			}
		}
		else
		{
			*pDataOut = 0;
			*pDataLen = 0;
			hr = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1192))));
		}

		return hr;
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigUncompressData([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, [NativeTypeName("ULONG *")] uint* pDataOut)
	{
		uint dwSizeOfData = 0;

		if ((((int)(CorSigUncompressData(pData, 0xff, (uint*)(pDataOut), (uint*)(&dwSizeOfData)))) < 0))
		{
			*pDataOut = 0;
			return (uint)(unchecked(-1));
		}

		return dwSizeOfData;
	}

	[return: NativeTypeName("mdToken")]
	public static uint CorSigDecodeTokenType(int encoded)
	{
		uint[] s_tableTokenTypes = new uint[4]
		{
			(uint)(mdtTypeDef),
			(uint)(mdtTypeRef),
			(uint)(mdtTypeSpec),
			(uint)(mdtBaseType),
		};

		return s_tableTokenTypes[encoded];
	}

	[return: NativeTypeName("mdToken")]
	public static uint CorSigUncompressToken([NativeTypeName("PCCOR_SIGNATURE &")] byte** pData)
	{
		uint tk;
		uint tkType;

		tk = CorSigUncompressData(pData);
		tkType = CorSigDecodeTokenType(tk & 0x3);
		tk = ((tk >> 2) | (tkType));
		return tk;
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigUncompressToken([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, [NativeTypeName("mdToken *")] uint* pToken)
	{
		uint cb;
		uint tk;
		uint tkType;

		cb = CorSigUncompressData(pData, (uint*)(&tk));
		tkType = CorSigDecodeTokenType(tk & 0x3);
		tk = ((tk >> 2) | (tkType));
		*pToken = tk;
		return cb;
	}

	[return: NativeTypeName("HRESULT")]
	public static int CorSigUncompressToken([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, [NativeTypeName("uint32_t")] uint dwLen, [NativeTypeName("mdToken *")] uint* pToken, [NativeTypeName("uint32_t *")] uint* dwTokenLength)
	{
		uint tk;
		uint tkType;
		int hr = CorSigUncompressData(pData, dwLen, unchecked((uint*)(&tk)), dwTokenLength);

		if ((((int)(hr)) >= 0))
		{
			tkType = CorSigDecodeTokenType(tk & 0x3);
			tk = ((tk >> 2) | (tkType));
			*pToken = tk;
		}
		else
		{
			*pToken = ((uint)(0));
		}

		return hr;
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigUncompressCallingConv([NativeTypeName("PCCOR_SIGNATURE &")] byte** pData)
	{
		return *pData++;
	}

	[return: NativeTypeName("HRESULT")]
	public static int CorSigUncompressCallingConv([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, [NativeTypeName("DWORD")] uint dwLen, [NativeTypeName("uint32_t *")] uint* data)
	{
		if (dwLen > 0)
		{
			*data = *pData;
			return ((int)(0));
		}
		else
		{
			*data = 0;
			return (unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1192)))));
		}
	}

	public const int SIGN_MASK_ONEBYTE = unchecked((int)(0xffffffc0));
	public const int SIGN_MASK_TWOBYTE = unchecked((int)(0xffffe000));
	public const int SIGN_MASK_FOURBYTE = unchecked((int)(0xf0000000));

	[return: NativeTypeName("ULONG")]
	public static uint CorSigUncompressSignedInt([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, int* pInt)
	{
		uint cb;
		uint ulSigned;
		uint iData;

		cb = CorSigUncompressData(pData, &iData);
		if (cb == unchecked((uint)(-1)))
		{
			return cb;
		}

		ulSigned = iData & 0x1;
		iData = iData >> 1;
		if ((ulSigned) != 0)
		{
			if (cb == 1)
			{
				iData |= (uint)(SIGN_MASK_ONEBYTE);
			}
			else if (cb == 2)
			{
				iData |= (uint)(SIGN_MASK_TWOBYTE);
			}
			else
			{
				iData |= (uint)(SIGN_MASK_FOURBYTE);
			}
		}

		*pInt = (int)(iData);
		return cb;
	}

	public static CorElementType CorSigUncompressElementType([NativeTypeName("PCCOR_SIGNATURE &")] byte** pData)
	{
		return (CorElementType)(*pData++);
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigUncompressElementType([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, CorElementType* pElementType)
	{
		*pElementType = (CorElementType)(*pData & 0x7f);
		return 1;
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigCompressData([NativeTypeName("ULONG")] uint iLen, void* pDataOut)
	{
		byte* pBytes = (byte*)(pDataOut);

		if (iLen <= 0x7F)
		{
			*pBytes = (byte)(iLen);
			return 1;
		}

		if (iLen <= 0x3FFF)
		{
			*pBytes = (byte)((iLen >> 8) | 0x80);
			*(pBytes + 1) = (byte)(iLen & 0xff);
			return 2;
		}

		if (iLen <= 0x1FFFFFFF)
		{
			*pBytes = (byte)((iLen >> 24) | 0xC0);
			*(pBytes + 1) = (byte)((iLen >> 16) & 0xff);
			*(pBytes + 2) = (byte)((iLen >> 8) & 0xff);
			*(pBytes + 3) = (byte)(iLen & 0xff);
			return 4;
		}

		return (uint)(unchecked(-1));
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigCompressToken([NativeTypeName("mdToken")] uint tk, void* pDataOut)
	{
		uint rid = ((uint)((tk) & 0x00ffffff));
		uint ulTyp = ((uint)((tk) & 0xff000000));

		if (unchecked(rid) > 0x3FFFFFF)
		{
			return (uint)(unchecked(-1));
		}

		rid = (rid << 2);
		if (unchecked(ulTyp) == CorSigDecodeTokenType(1))
		{
			rid |= 0x1;
		}
		else if (unchecked(ulTyp) == CorSigDecodeTokenType(2))
		{
			rid |= 0x2;
		}
		else if (unchecked(ulTyp) == CorSigDecodeTokenType(3))
		{
			rid |= 0x3;
		}

		return CorSigCompressData((uint)(rid), pDataOut);
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigCompressSignedInt(int iData, void* pDataOut)
	{
		uint isSigned = 0;
		byte* pBytes = (byte*)(pDataOut);

		if (iData < 0)
		{
			isSigned = 0x1;
		}

		if ((iData & (int)(SIGN_MASK_ONEBYTE)) == 0 || (iData & (int)(SIGN_MASK_ONEBYTE)) == SIGN_MASK_ONEBYTE)
		{
			iData = (int)(unchecked((iData & ~(int)(SIGN_MASK_ONEBYTE)) << 1 | isSigned));
			*pBytes = (byte)(iData);
			return 1;
		}
		else if ((iData & (int)(SIGN_MASK_TWOBYTE)) == 0 || (iData & (int)(SIGN_MASK_TWOBYTE)) == SIGN_MASK_TWOBYTE)
		{
			iData = (int)(unchecked((iData & ~(int)(SIGN_MASK_TWOBYTE)) << 1 | isSigned));
			*pBytes = (byte)((iData >> 8) | 0x80);
			*(pBytes + 1) = (byte)(iData & 0xff);
			return 2;
		}
		else if ((iData & (int)(SIGN_MASK_FOURBYTE)) == 0 || (iData & (int)(SIGN_MASK_FOURBYTE)) == SIGN_MASK_FOURBYTE)
		{
			iData = (int)(unchecked((iData & ~(int)(SIGN_MASK_FOURBYTE)) << 1 | isSigned));
			*pBytes = (byte)((iData >> 24) | 0xC0);
			*(pBytes + 1) = (byte)((iData >> 16) & 0xff);
			*(pBytes + 2) = (byte)((iData >> 8) & 0xff);
			*(pBytes + 3) = (byte)(iData & 0xff);
			return 4;
		}

		return (uint)(unchecked(-1));
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigCompressElementType(CorElementType et, void* pData)
	{
		byte* pBytes = (byte*)(pData);

		*pBytes = (byte)(et);
		return 1;
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigCompressPointer(void* pvPointer, void* pData)
	{
		*((void**)(pData)) = pvPointer;
		return sizeof(void*);
	}

	[return: NativeTypeName("ULONG")]
	public static uint CorSigUncompressPointer([NativeTypeName("PCCOR_SIGNATURE")] byte* pData, void** ppvPointer)
	{
		*ppvPointer = *(void**)(pData);
		return sizeof(void*);
	}

	[NativeTypeName("#define CLDB_S_TRUNCATION SMAKEHR(0x1106)")]
	public const int CLDB_S_TRUNCATION = unchecked((int)(((uint)(0) << 31) | ((uint)(19) << 16) | ((uint)(0x1106))));

	[NativeTypeName("#define META_S_DUPLICATE SMAKEHR(0x1197)")]
	public const int META_S_DUPLICATE = unchecked((int)(((uint)(0) << 31) | ((uint)(19) << 16) | ((uint)(0x1197))));

	[NativeTypeName("#define CORDBG_S_BAD_START_SEQUENCE_POINT SMAKEHR(0x130b)")]
	public const int CORDBG_S_BAD_START_SEQUENCE_POINT = unchecked((int)(((uint)(0) << 31) | ((uint)(19) << 16) | ((uint)(0x130b))));

	[NativeTypeName("#define CORDBG_S_BAD_END_SEQUENCE_POINT SMAKEHR(0x130c)")]
	public const int CORDBG_S_BAD_END_SEQUENCE_POINT = unchecked((int)(((uint)(0) << 31) | ((uint)(19) << 16) | ((uint)(0x130c))));

	[NativeTypeName("#define CORDBG_S_FUNC_EVAL_HAS_NO_RESULT SMAKEHR(0x1316)")]
	public const int CORDBG_S_FUNC_EVAL_HAS_NO_RESULT = unchecked((int)(((uint)(0) << 31) | ((uint)(19) << 16) | ((uint)(0x1316))));

	[NativeTypeName("#define CORDBG_S_VALUE_POINTS_TO_VOID SMAKEHR(0x1317)")]
	public const int CORDBG_S_VALUE_POINTS_TO_VOID = unchecked((int)(((uint)(0) << 31) | ((uint)(19) << 16) | ((uint)(0x1317))));

	[NativeTypeName("#define CORDBG_S_FUNC_EVAL_ABORTED SMAKEHR(0x1319)")]
	public const int CORDBG_S_FUNC_EVAL_ABORTED = unchecked((int)(((uint)(0) << 31) | ((uint)(19) << 16) | ((uint)(0x1319))));

	[NativeTypeName("#define CORDBG_S_AT_END_OF_STACK SMAKEHR(0x1324)")]
	public const int CORDBG_S_AT_END_OF_STACK = unchecked((int)(((uint)(0) << 31) | ((uint)(19) << 16) | ((uint)(0x1324))));

	[NativeTypeName("#define CORDBG_S_NOT_ALL_BITS_SET SMAKEHR(0x1c13)")]
	public const int CORDBG_S_NOT_ALL_BITS_SET = unchecked((int)(((uint)(0) << 31) | ((uint)(19) << 16) | ((uint)(0x1c13))));

	[NativeTypeName("#define COR_E_TYPEUNLOADED EMAKEHR(0x1013)")]
	public const int COR_E_TYPEUNLOADED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1013))));

	[NativeTypeName("#define COR_E_APPDOMAINUNLOADED EMAKEHR(0x1014)")]
	public const int COR_E_APPDOMAINUNLOADED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1014))));

	[NativeTypeName("#define COR_E_CANNOTUNLOADAPPDOMAIN EMAKEHR(0x1015)")]
	public const int COR_E_CANNOTUNLOADAPPDOMAIN = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1015))));

	[NativeTypeName("#define MSEE_E_ASSEMBLYLOADINPROGRESS EMAKEHR(0x1016)")]
	public const int MSEE_E_ASSEMBLYLOADINPROGRESS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1016))));

	[NativeTypeName("#define COR_E_ASSEMBLYEXPECTED EMAKEHR(0x1018)")]
	public const int COR_E_ASSEMBLYEXPECTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1018))));

	[NativeTypeName("#define COR_E_NEWER_RUNTIME EMAKEHR(0x101b)")]
	public const int COR_E_NEWER_RUNTIME = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x101b))));

	[NativeTypeName("#define COR_E_MULTIMODULEASSEMBLIESDIALLOWED EMAKEHR(0x101e)")]
	public const int COR_E_MULTIMODULEASSEMBLIESDIALLOWED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x101e))));

	[NativeTypeName("#define HOST_E_INVALIDOPERATION EMAKEHR(0x1022)")]
	public const int HOST_E_INVALIDOPERATION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1022))));

	[NativeTypeName("#define HOST_E_CLRNOTAVAILABLE EMAKEHR(0x1023)")]
	public const int HOST_E_CLRNOTAVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1023))));

	[NativeTypeName("#define FUSION_E_REF_DEF_MISMATCH EMAKEHR(0x1040)")]
	public const int FUSION_E_REF_DEF_MISMATCH = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1040))));

	[NativeTypeName("#define FUSION_E_INVALID_NAME EMAKEHR(0x1047)")]
	public const int FUSION_E_INVALID_NAME = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1047))));

	[NativeTypeName("#define FUSION_E_APP_DOMAIN_LOCKED EMAKEHR(0x1053)")]
	public const int FUSION_E_APP_DOMAIN_LOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1053))));

	[NativeTypeName("#define COR_E_LOADING_REFERENCE_ASSEMBLY EMAKEHR(0x1058)")]
	public const int COR_E_LOADING_REFERENCE_ASSEMBLY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1058))));

	[NativeTypeName("#define COR_E_AMBIGUOUSIMPLEMENTATION EMAKEHR(0x106a)")]
	public const int COR_E_AMBIGUOUSIMPLEMENTATION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x106a))));

	[NativeTypeName("#define CLDB_E_FILE_BADREAD EMAKEHR(0x1100)")]
	public const int CLDB_E_FILE_BADREAD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1100))));

	[NativeTypeName("#define CLDB_E_FILE_BADWRITE EMAKEHR(0x1101)")]
	public const int CLDB_E_FILE_BADWRITE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1101))));

	[NativeTypeName("#define CLDB_E_FILE_OLDVER EMAKEHR(0x1107)")]
	public const int CLDB_E_FILE_OLDVER = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1107))));

	[NativeTypeName("#define CLDB_E_SMDUPLICATE EMAKEHR(0x110a)")]
	public const int CLDB_E_SMDUPLICATE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x110a))));

	[NativeTypeName("#define CLDB_E_NO_DATA EMAKEHR(0x110b)")]
	public const int CLDB_E_NO_DATA = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x110b))));

	[NativeTypeName("#define CLDB_E_INCOMPATIBLE EMAKEHR(0x110d)")]
	public const int CLDB_E_INCOMPATIBLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x110d))));

	[NativeTypeName("#define CLDB_E_FILE_CORRUPT EMAKEHR(0x110e)")]
	public const int CLDB_E_FILE_CORRUPT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x110e))));

	[NativeTypeName("#define CLDB_E_BADUPDATEMODE EMAKEHR(0x1110)")]
	public const int CLDB_E_BADUPDATEMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1110))));

	[NativeTypeName("#define CLDB_E_INDEX_NOTFOUND EMAKEHR(0x1124)")]
	public const int CLDB_E_INDEX_NOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1124))));

	[NativeTypeName("#define CLDB_E_RECORD_NOTFOUND EMAKEHR(0x1130)")]
	public const int CLDB_E_RECORD_NOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1130))));

	[NativeTypeName("#define CLDB_E_RECORD_OUTOFORDER EMAKEHR(0x1135)")]
	public const int CLDB_E_RECORD_OUTOFORDER = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1135))));

	[NativeTypeName("#define CLDB_E_TOO_BIG EMAKEHR(0x1154)")]
	public const int CLDB_E_TOO_BIG = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1154))));

	[NativeTypeName("#define META_E_INVALID_TOKEN_TYPE EMAKEHR(0x115f)")]
	public const int META_E_INVALID_TOKEN_TYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x115f))));

	[NativeTypeName("#define TLBX_E_LIBNOTREGISTERED EMAKEHR(0x1165)")]
	public const int TLBX_E_LIBNOTREGISTERED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1165))));

	[NativeTypeName("#define META_E_BADMETADATA EMAKEHR(0x118a)")]
	public const int META_E_BADMETADATA = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x118a))));

	[NativeTypeName("#define META_E_BAD_SIGNATURE EMAKEHR(0x1192)")]
	public const int META_E_BAD_SIGNATURE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1192))));

	[NativeTypeName("#define META_E_BAD_INPUT_PARAMETER EMAKEHR(0x1193)")]
	public const int META_E_BAD_INPUT_PARAMETER = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1193))));

	[NativeTypeName("#define META_E_CANNOTRESOLVETYPEREF EMAKEHR(0x1196)")]
	public const int META_E_CANNOTRESOLVETYPEREF = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1196))));

	[NativeTypeName("#define META_E_STRINGSPACE_FULL EMAKEHR(0x1198)")]
	public const int META_E_STRINGSPACE_FULL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1198))));

	[NativeTypeName("#define META_E_HAS_UNMARKALL EMAKEHR(0x119a)")]
	public const int META_E_HAS_UNMARKALL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x119a))));

	[NativeTypeName("#define META_E_MUST_CALL_UNMARKALL EMAKEHR(0x119b)")]
	public const int META_E_MUST_CALL_UNMARKALL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x119b))));

	[NativeTypeName("#define META_E_CA_INVALID_TARGET EMAKEHR(0x11c0)")]
	public const int META_E_CA_INVALID_TARGET = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11c0))));

	[NativeTypeName("#define META_E_CA_INVALID_VALUE EMAKEHR(0x11c1)")]
	public const int META_E_CA_INVALID_VALUE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11c1))));

	[NativeTypeName("#define META_E_CA_INVALID_BLOB EMAKEHR(0x11c2)")]
	public const int META_E_CA_INVALID_BLOB = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11c2))));

	[NativeTypeName("#define META_E_CA_REPEATED_ARG EMAKEHR(0x11c3)")]
	public const int META_E_CA_REPEATED_ARG = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11c3))));

	[NativeTypeName("#define META_E_CA_UNKNOWN_ARGUMENT EMAKEHR(0x11c4)")]
	public const int META_E_CA_UNKNOWN_ARGUMENT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11c4))));

	[NativeTypeName("#define META_E_CA_UNEXPECTED_TYPE EMAKEHR(0x11c7)")]
	public const int META_E_CA_UNEXPECTED_TYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11c7))));

	[NativeTypeName("#define META_E_CA_INVALID_ARGTYPE EMAKEHR(0x11c8)")]
	public const int META_E_CA_INVALID_ARGTYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11c8))));

	[NativeTypeName("#define META_E_CA_INVALID_ARG_FOR_TYPE EMAKEHR(0x11c9)")]
	public const int META_E_CA_INVALID_ARG_FOR_TYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11c9))));

	[NativeTypeName("#define META_E_CA_INVALID_UUID EMAKEHR(0x11ca)")]
	public const int META_E_CA_INVALID_UUID = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11ca))));

	[NativeTypeName("#define META_E_CA_INVALID_MARSHALAS_FIELDS EMAKEHR(0x11cb)")]
	public const int META_E_CA_INVALID_MARSHALAS_FIELDS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11cb))));

	[NativeTypeName("#define META_E_CA_NT_FIELDONLY EMAKEHR(0x11cc)")]
	public const int META_E_CA_NT_FIELDONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11cc))));

	[NativeTypeName("#define META_E_CA_NEGATIVE_PARAMINDEX EMAKEHR(0x11cd)")]
	public const int META_E_CA_NEGATIVE_PARAMINDEX = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11cd))));

	[NativeTypeName("#define META_E_CA_NEGATIVE_CONSTSIZE EMAKEHR(0x11cf)")]
	public const int META_E_CA_NEGATIVE_CONSTSIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11cf))));

	[NativeTypeName("#define META_E_CA_FIXEDSTR_SIZE_REQUIRED EMAKEHR(0x11d0)")]
	public const int META_E_CA_FIXEDSTR_SIZE_REQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11d0))));

	[NativeTypeName("#define META_E_CA_CUSTMARSH_TYPE_REQUIRED EMAKEHR(0x11d1)")]
	public const int META_E_CA_CUSTMARSH_TYPE_REQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11d1))));

	[NativeTypeName("#define META_E_NOT_IN_ENC_MODE EMAKEHR(0x11d4)")]
	public const int META_E_NOT_IN_ENC_MODE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11d4))));

	[NativeTypeName("#define META_E_CA_BAD_FRIENDS_ARGS EMAKEHR(0x11e5)")]
	public const int META_E_CA_BAD_FRIENDS_ARGS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11e5))));

	[NativeTypeName("#define META_E_CA_FRIENDS_SN_REQUIRED EMAKEHR(0x11e6)")]
	public const int META_E_CA_FRIENDS_SN_REQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x11e6))));

	[NativeTypeName("#define VLDTR_E_RID_OUTOFRANGE EMAKEHR(0x1203)")]
	public const int VLDTR_E_RID_OUTOFRANGE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1203))));

	[NativeTypeName("#define VLDTR_E_STRING_INVALID EMAKEHR(0x1206)")]
	public const int VLDTR_E_STRING_INVALID = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1206))));

	[NativeTypeName("#define VLDTR_E_GUID_INVALID EMAKEHR(0x1207)")]
	public const int VLDTR_E_GUID_INVALID = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1207))));

	[NativeTypeName("#define VLDTR_E_BLOB_INVALID EMAKEHR(0x1208)")]
	public const int VLDTR_E_BLOB_INVALID = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1208))));

	[NativeTypeName("#define VLDTR_E_MR_BADCALLINGCONV EMAKEHR(0x1224)")]
	public const int VLDTR_E_MR_BADCALLINGCONV = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1224))));

	[NativeTypeName("#define VLDTR_E_SIGNULL EMAKEHR(0x1237)")]
	public const int VLDTR_E_SIGNULL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1237))));

	[NativeTypeName("#define VLDTR_E_MD_BADCALLINGCONV EMAKEHR(0x1239)")]
	public const int VLDTR_E_MD_BADCALLINGCONV = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1239))));

	[NativeTypeName("#define VLDTR_E_MD_THISSTATIC EMAKEHR(0x123a)")]
	public const int VLDTR_E_MD_THISSTATIC = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x123a))));

	[NativeTypeName("#define VLDTR_E_MD_NOTTHISNOTSTATIC EMAKEHR(0x123b)")]
	public const int VLDTR_E_MD_NOTTHISNOTSTATIC = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x123b))));

	[NativeTypeName("#define VLDTR_E_MD_NOARGCNT EMAKEHR(0x123c)")]
	public const int VLDTR_E_MD_NOARGCNT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x123c))));

	[NativeTypeName("#define VLDTR_E_SIG_MISSELTYPE EMAKEHR(0x123d)")]
	public const int VLDTR_E_SIG_MISSELTYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x123d))));

	[NativeTypeName("#define VLDTR_E_SIG_MISSTKN EMAKEHR(0x123e)")]
	public const int VLDTR_E_SIG_MISSTKN = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x123e))));

	[NativeTypeName("#define VLDTR_E_SIG_TKNBAD EMAKEHR(0x123f)")]
	public const int VLDTR_E_SIG_TKNBAD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x123f))));

	[NativeTypeName("#define VLDTR_E_SIG_MISSFPTR EMAKEHR(0x1240)")]
	public const int VLDTR_E_SIG_MISSFPTR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1240))));

	[NativeTypeName("#define VLDTR_E_SIG_MISSFPTRARGCNT EMAKEHR(0x1241)")]
	public const int VLDTR_E_SIG_MISSFPTRARGCNT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1241))));

	[NativeTypeName("#define VLDTR_E_SIG_MISSRANK EMAKEHR(0x1242)")]
	public const int VLDTR_E_SIG_MISSRANK = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1242))));

	[NativeTypeName("#define VLDTR_E_SIG_MISSNSIZE EMAKEHR(0x1243)")]
	public const int VLDTR_E_SIG_MISSNSIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1243))));

	[NativeTypeName("#define VLDTR_E_SIG_MISSSIZE EMAKEHR(0x1244)")]
	public const int VLDTR_E_SIG_MISSSIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1244))));

	[NativeTypeName("#define VLDTR_E_SIG_MISSNLBND EMAKEHR(0x1245)")]
	public const int VLDTR_E_SIG_MISSNLBND = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1245))));

	[NativeTypeName("#define VLDTR_E_SIG_MISSLBND EMAKEHR(0x1246)")]
	public const int VLDTR_E_SIG_MISSLBND = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1246))));

	[NativeTypeName("#define VLDTR_E_SIG_BADELTYPE EMAKEHR(0x1247)")]
	public const int VLDTR_E_SIG_BADELTYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1247))));

	[NativeTypeName("#define VLDTR_E_TD_ENCLNOTNESTED EMAKEHR(0x1256)")]
	public const int VLDTR_E_TD_ENCLNOTNESTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1256))));

	[NativeTypeName("#define VLDTR_E_FMD_PINVOKENOTSTATIC EMAKEHR(0x1277)")]
	public const int VLDTR_E_FMD_PINVOKENOTSTATIC = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1277))));

	[NativeTypeName("#define VLDTR_E_SIG_SENTINMETHODDEF EMAKEHR(0x12df)")]
	public const int VLDTR_E_SIG_SENTINMETHODDEF = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x12df))));

	[NativeTypeName("#define VLDTR_E_SIG_SENTMUSTVARARG EMAKEHR(0x12e0)")]
	public const int VLDTR_E_SIG_SENTMUSTVARARG = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x12e0))));

	[NativeTypeName("#define VLDTR_E_SIG_MULTSENTINELS EMAKEHR(0x12e1)")]
	public const int VLDTR_E_SIG_MULTSENTINELS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x12e1))));

	[NativeTypeName("#define VLDTR_E_SIG_MISSARG EMAKEHR(0x12e3)")]
	public const int VLDTR_E_SIG_MISSARG = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x12e3))));

	[NativeTypeName("#define VLDTR_E_SIG_BYREFINFIELD EMAKEHR(0x12e4)")]
	public const int VLDTR_E_SIG_BYREFINFIELD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x12e4))));

	[NativeTypeName("#define CORDBG_E_UNRECOVERABLE_ERROR EMAKEHR(0x1300)")]
	public const int CORDBG_E_UNRECOVERABLE_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1300))));

	[NativeTypeName("#define CORDBG_E_PROCESS_TERMINATED EMAKEHR(0x1301)")]
	public const int CORDBG_E_PROCESS_TERMINATED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1301))));

	[NativeTypeName("#define CORDBG_E_PROCESS_NOT_SYNCHRONIZED EMAKEHR(0x1302)")]
	public const int CORDBG_E_PROCESS_NOT_SYNCHRONIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1302))));

	[NativeTypeName("#define CORDBG_E_CLASS_NOT_LOADED EMAKEHR(0x1303)")]
	public const int CORDBG_E_CLASS_NOT_LOADED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1303))));

	[NativeTypeName("#define CORDBG_E_IL_VAR_NOT_AVAILABLE EMAKEHR(0x1304)")]
	public const int CORDBG_E_IL_VAR_NOT_AVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1304))));

	[NativeTypeName("#define CORDBG_E_BAD_REFERENCE_VALUE EMAKEHR(0x1305)")]
	public const int CORDBG_E_BAD_REFERENCE_VALUE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1305))));

	[NativeTypeName("#define CORDBG_E_FIELD_NOT_AVAILABLE EMAKEHR(0x1306)")]
	public const int CORDBG_E_FIELD_NOT_AVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1306))));

	[NativeTypeName("#define CORDBG_E_NON_NATIVE_FRAME EMAKEHR(0x1307)")]
	public const int CORDBG_E_NON_NATIVE_FRAME = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1307))));

	[NativeTypeName("#define CORDBG_E_CODE_NOT_AVAILABLE EMAKEHR(0x1309)")]
	public const int CORDBG_E_CODE_NOT_AVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1309))));

	[NativeTypeName("#define CORDBG_E_FUNCTION_NOT_IL EMAKEHR(0x130a)")]
	public const int CORDBG_E_FUNCTION_NOT_IL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x130a))));

	[NativeTypeName("#define CORDBG_E_CANT_SET_IP_INTO_FINALLY EMAKEHR(0x130e)")]
	public const int CORDBG_E_CANT_SET_IP_INTO_FINALLY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x130e))));

	[NativeTypeName("#define CORDBG_E_CANT_SET_IP_OUT_OF_FINALLY EMAKEHR(0x130f)")]
	public const int CORDBG_E_CANT_SET_IP_OUT_OF_FINALLY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x130f))));

	[NativeTypeName("#define CORDBG_E_CANT_SET_IP_INTO_CATCH EMAKEHR(0x1310)")]
	public const int CORDBG_E_CANT_SET_IP_INTO_CATCH = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1310))));

	[NativeTypeName("#define CORDBG_E_SET_IP_NOT_ALLOWED_ON_NONLEAF_FRAME EMAKEHR(0x1311)")]
	public const int CORDBG_E_SET_IP_NOT_ALLOWED_ON_NONLEAF_FRAME = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1311))));

	[NativeTypeName("#define CORDBG_E_SET_IP_IMPOSSIBLE EMAKEHR(0x1312)")]
	public const int CORDBG_E_SET_IP_IMPOSSIBLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1312))));

	[NativeTypeName("#define CORDBG_E_FUNC_EVAL_BAD_START_POINT EMAKEHR(0x1313)")]
	public const int CORDBG_E_FUNC_EVAL_BAD_START_POINT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1313))));

	[NativeTypeName("#define CORDBG_E_INVALID_OBJECT EMAKEHR(0x1314)")]
	public const int CORDBG_E_INVALID_OBJECT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1314))));

	[NativeTypeName("#define CORDBG_E_FUNC_EVAL_NOT_COMPLETE EMAKEHR(0x1315)")]
	public const int CORDBG_E_FUNC_EVAL_NOT_COMPLETE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1315))));

	[NativeTypeName("#define CORDBG_E_STATIC_VAR_NOT_AVAILABLE EMAKEHR(0x131a)")]
	public const int CORDBG_E_STATIC_VAR_NOT_AVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x131a))));

	[NativeTypeName("#define CORDBG_E_CANT_SETIP_INTO_OR_OUT_OF_FILTER EMAKEHR(0x131c)")]
	public const int CORDBG_E_CANT_SETIP_INTO_OR_OUT_OF_FILTER = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x131c))));

	[NativeTypeName("#define CORDBG_E_CANT_CHANGE_JIT_SETTING_FOR_ZAP_MODULE EMAKEHR(0x131d)")]
	public const int CORDBG_E_CANT_CHANGE_JIT_SETTING_FOR_ZAP_MODULE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x131d))));

	[NativeTypeName("#define CORDBG_E_CANT_SET_IP_OUT_OF_FINALLY_ON_WIN64 EMAKEHR(0x131e)")]
	public const int CORDBG_E_CANT_SET_IP_OUT_OF_FINALLY_ON_WIN64 = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x131e))));

	[NativeTypeName("#define CORDBG_E_CANT_SET_IP_OUT_OF_CATCH_ON_WIN64 EMAKEHR(0x131f)")]
	public const int CORDBG_E_CANT_SET_IP_OUT_OF_CATCH_ON_WIN64 = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x131f))));

	[NativeTypeName("#define CORDBG_E_CANT_SET_TO_JMC EMAKEHR(0x1323)")]
	public const int CORDBG_E_CANT_SET_TO_JMC = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1323))));

	[NativeTypeName("#define CORDBG_E_NO_CONTEXT_FOR_INTERNAL_FRAME EMAKEHR(0x1325)")]
	public const int CORDBG_E_NO_CONTEXT_FOR_INTERNAL_FRAME = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1325))));

	[NativeTypeName("#define CORDBG_E_NOT_CHILD_FRAME EMAKEHR(0x1326)")]
	public const int CORDBG_E_NOT_CHILD_FRAME = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1326))));

	[NativeTypeName("#define CORDBG_E_NON_MATCHING_CONTEXT EMAKEHR(0x1327)")]
	public const int CORDBG_E_NON_MATCHING_CONTEXT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1327))));

	[NativeTypeName("#define CORDBG_E_PAST_END_OF_STACK EMAKEHR(0x1328)")]
	public const int CORDBG_E_PAST_END_OF_STACK = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1328))));

	[NativeTypeName("#define CORDBG_E_FUNC_EVAL_CANNOT_UPDATE_REGISTER_IN_NONLEAF_FRAME EMAKEHR(0x1329)")]
	public const int CORDBG_E_FUNC_EVAL_CANNOT_UPDATE_REGISTER_IN_NONLEAF_FRAME = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1329))));

	[NativeTypeName("#define CORDBG_E_BAD_THREAD_STATE EMAKEHR(0x132d)")]
	public const int CORDBG_E_BAD_THREAD_STATE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x132d))));

	[NativeTypeName("#define CORDBG_E_DEBUGGER_ALREADY_ATTACHED EMAKEHR(0x132e)")]
	public const int CORDBG_E_DEBUGGER_ALREADY_ATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x132e))));

	[NativeTypeName("#define CORDBG_E_SUPERFLOUS_CONTINUE EMAKEHR(0x132f)")]
	public const int CORDBG_E_SUPERFLOUS_CONTINUE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x132f))));

	[NativeTypeName("#define CORDBG_E_SET_VALUE_NOT_ALLOWED_ON_NONLEAF_FRAME EMAKEHR(0x1330)")]
	public const int CORDBG_E_SET_VALUE_NOT_ALLOWED_ON_NONLEAF_FRAME = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1330))));

	[NativeTypeName("#define CORDBG_E_ENC_MODULE_NOT_ENC_ENABLED EMAKEHR(0x1332)")]
	public const int CORDBG_E_ENC_MODULE_NOT_ENC_ENABLED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1332))));

	[NativeTypeName("#define CORDBG_E_SET_IP_NOT_ALLOWED_ON_EXCEPTION EMAKEHR(0x1333)")]
	public const int CORDBG_E_SET_IP_NOT_ALLOWED_ON_EXCEPTION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1333))));

	[NativeTypeName("#define CORDBG_E_VARIABLE_IS_ACTUALLY_LITERAL EMAKEHR(0x1334)")]
	public const int CORDBG_E_VARIABLE_IS_ACTUALLY_LITERAL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1334))));

	[NativeTypeName("#define CORDBG_E_PROCESS_DETACHED EMAKEHR(0x1335)")]
	public const int CORDBG_E_PROCESS_DETACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1335))));

	[NativeTypeName("#define CORDBG_E_ENC_CANT_ADD_FIELD_TO_VALUE_OR_LAYOUT_CLASS EMAKEHR(0x1338)")]
	public const int CORDBG_E_ENC_CANT_ADD_FIELD_TO_VALUE_OR_LAYOUT_CLASS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1338))));

	[NativeTypeName("#define CORDBG_E_FIELD_NOT_STATIC EMAKEHR(0x133b)")]
	public const int CORDBG_E_FIELD_NOT_STATIC = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x133b))));

	[NativeTypeName("#define CORDBG_E_FIELD_NOT_INSTANCE EMAKEHR(0x133c)")]
	public const int CORDBG_E_FIELD_NOT_INSTANCE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x133c))));

	[NativeTypeName("#define CORDBG_E_ENC_JIT_CANT_UPDATE EMAKEHR(0x133f)")]
	public const int CORDBG_E_ENC_JIT_CANT_UPDATE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x133f))));

	[NativeTypeName("#define CORDBG_E_ENC_INTERNAL_ERROR EMAKEHR(0x1341)")]
	public const int CORDBG_E_ENC_INTERNAL_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1341))));

	[NativeTypeName("#define CORDBG_E_ENC_HANGING_FIELD EMAKEHR(0x1342)")]
	public const int CORDBG_E_ENC_HANGING_FIELD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1342))));

	[NativeTypeName("#define CORDBG_E_MODULE_NOT_LOADED EMAKEHR(0x1343)")]
	public const int CORDBG_E_MODULE_NOT_LOADED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1343))));

	[NativeTypeName("#define CORDBG_E_UNABLE_TO_SET_BREAKPOINT EMAKEHR(0x1345)")]
	public const int CORDBG_E_UNABLE_TO_SET_BREAKPOINT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1345))));

	[NativeTypeName("#define CORDBG_E_DEBUGGING_NOT_POSSIBLE EMAKEHR(0x1346)")]
	public const int CORDBG_E_DEBUGGING_NOT_POSSIBLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1346))));

	[NativeTypeName("#define CORDBG_E_KERNEL_DEBUGGER_ENABLED EMAKEHR(0x1347)")]
	public const int CORDBG_E_KERNEL_DEBUGGER_ENABLED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1347))));

	[NativeTypeName("#define CORDBG_E_KERNEL_DEBUGGER_PRESENT EMAKEHR(0x1348)")]
	public const int CORDBG_E_KERNEL_DEBUGGER_PRESENT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1348))));

	[NativeTypeName("#define CORDBG_E_INCOMPATIBLE_PROTOCOL EMAKEHR(0x134b)")]
	public const int CORDBG_E_INCOMPATIBLE_PROTOCOL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x134b))));

	[NativeTypeName("#define CORDBG_E_TOO_MANY_PROCESSES EMAKEHR(0x134c)")]
	public const int CORDBG_E_TOO_MANY_PROCESSES = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x134c))));

	[NativeTypeName("#define CORDBG_E_INTEROP_NOT_SUPPORTED EMAKEHR(0x134d)")]
	public const int CORDBG_E_INTEROP_NOT_SUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x134d))));

	[NativeTypeName("#define CORDBG_E_NO_REMAP_BREAKPIONT EMAKEHR(0x134e)")]
	public const int CORDBG_E_NO_REMAP_BREAKPIONT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x134e))));

	[NativeTypeName("#define CORDBG_E_OBJECT_NEUTERED EMAKEHR(0x134f)")]
	public const int CORDBG_E_OBJECT_NEUTERED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x134f))));

	[NativeTypeName("#define CORPROF_E_FUNCTION_NOT_COMPILED EMAKEHR(0x1350)")]
	public const int CORPROF_E_FUNCTION_NOT_COMPILED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1350))));

	[NativeTypeName("#define CORPROF_E_DATAINCOMPLETE EMAKEHR(0x1351)")]
	public const int CORPROF_E_DATAINCOMPLETE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1351))));

	[NativeTypeName("#define CORPROF_E_FUNCTION_NOT_IL EMAKEHR(0x1354)")]
	public const int CORPROF_E_FUNCTION_NOT_IL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1354))));

	[NativeTypeName("#define CORPROF_E_NOT_MANAGED_THREAD EMAKEHR(0x1355)")]
	public const int CORPROF_E_NOT_MANAGED_THREAD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1355))));

	[NativeTypeName("#define CORPROF_E_CALL_ONLY_FROM_INIT EMAKEHR(0x1356)")]
	public const int CORPROF_E_CALL_ONLY_FROM_INIT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1356))));

	[NativeTypeName("#define CORPROF_E_NOT_YET_AVAILABLE EMAKEHR(0x135b)")]
	public const int CORPROF_E_NOT_YET_AVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x135b))));

	[NativeTypeName("#define CORPROF_E_TYPE_IS_PARAMETERIZED EMAKEHR(0x135c)")]
	public const int CORPROF_E_TYPE_IS_PARAMETERIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x135c))));

	[NativeTypeName("#define CORPROF_E_FUNCTION_IS_PARAMETERIZED EMAKEHR(0x135d)")]
	public const int CORPROF_E_FUNCTION_IS_PARAMETERIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x135d))));

	[NativeTypeName("#define CORPROF_E_STACKSNAPSHOT_INVALID_TGT_THREAD EMAKEHR(0x135e)")]
	public const int CORPROF_E_STACKSNAPSHOT_INVALID_TGT_THREAD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x135e))));

	[NativeTypeName("#define CORPROF_E_STACKSNAPSHOT_UNMANAGED_CTX EMAKEHR(0x135f)")]
	public const int CORPROF_E_STACKSNAPSHOT_UNMANAGED_CTX = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x135f))));

	[NativeTypeName("#define CORPROF_E_STACKSNAPSHOT_UNSAFE EMAKEHR(0x1360)")]
	public const int CORPROF_E_STACKSNAPSHOT_UNSAFE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1360))));

	[NativeTypeName("#define CORPROF_E_STACKSNAPSHOT_ABORTED EMAKEHR(0x1361)")]
	public const int CORPROF_E_STACKSNAPSHOT_ABORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1361))));

	[NativeTypeName("#define CORPROF_E_LITERALS_HAVE_NO_ADDRESS EMAKEHR(0x1362)")]
	public const int CORPROF_E_LITERALS_HAVE_NO_ADDRESS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1362))));

	[NativeTypeName("#define CORPROF_E_UNSUPPORTED_CALL_SEQUENCE EMAKEHR(0x1363)")]
	public const int CORPROF_E_UNSUPPORTED_CALL_SEQUENCE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1363))));

	[NativeTypeName("#define CORPROF_E_ASYNCHRONOUS_UNSAFE EMAKEHR(0x1364)")]
	public const int CORPROF_E_ASYNCHRONOUS_UNSAFE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1364))));

	[NativeTypeName("#define CORPROF_E_CLASSID_IS_ARRAY EMAKEHR(0x1365)")]
	public const int CORPROF_E_CLASSID_IS_ARRAY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1365))));

	[NativeTypeName("#define CORPROF_E_CLASSID_IS_COMPOSITE EMAKEHR(0x1366)")]
	public const int CORPROF_E_CLASSID_IS_COMPOSITE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1366))));

	[NativeTypeName("#define CORPROF_E_PROFILER_DETACHING EMAKEHR(0x1367)")]
	public const int CORPROF_E_PROFILER_DETACHING = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1367))));

	[NativeTypeName("#define CORPROF_E_PROFILER_NOT_ATTACHABLE EMAKEHR(0x1368)")]
	public const int CORPROF_E_PROFILER_NOT_ATTACHABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1368))));

	[NativeTypeName("#define CORPROF_E_UNRECOGNIZED_PIPE_MSG_FORMAT EMAKEHR(0x1369)")]
	public const int CORPROF_E_UNRECOGNIZED_PIPE_MSG_FORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1369))));

	[NativeTypeName("#define CORPROF_E_PROFILER_ALREADY_ACTIVE EMAKEHR(0x136a)")]
	public const int CORPROF_E_PROFILER_ALREADY_ACTIVE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x136a))));

	[NativeTypeName("#define CORPROF_E_PROFILEE_INCOMPATIBLE_WITH_TRIGGER EMAKEHR(0x136b)")]
	public const int CORPROF_E_PROFILEE_INCOMPATIBLE_WITH_TRIGGER = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x136b))));

	[NativeTypeName("#define CORPROF_E_IPC_FAILED EMAKEHR(0x136c)")]
	public const int CORPROF_E_IPC_FAILED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x136c))));

	[NativeTypeName("#define CORPROF_E_PROFILEE_PROCESS_NOT_FOUND EMAKEHR(0x136d)")]
	public const int CORPROF_E_PROFILEE_PROCESS_NOT_FOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x136d))));

	[NativeTypeName("#define CORPROF_E_CALLBACK3_REQUIRED EMAKEHR(0x136e)")]
	public const int CORPROF_E_CALLBACK3_REQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x136e))));

	[NativeTypeName("#define CORPROF_E_UNSUPPORTED_FOR_ATTACHING_PROFILER EMAKEHR(0x136f)")]
	public const int CORPROF_E_UNSUPPORTED_FOR_ATTACHING_PROFILER = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x136f))));

	[NativeTypeName("#define CORPROF_E_IRREVERSIBLE_INSTRUMENTATION_PRESENT EMAKEHR(0x1370)")]
	public const int CORPROF_E_IRREVERSIBLE_INSTRUMENTATION_PRESENT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1370))));

	[NativeTypeName("#define CORPROF_E_RUNTIME_UNINITIALIZED EMAKEHR(0x1371)")]
	public const int CORPROF_E_RUNTIME_UNINITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1371))));

	[NativeTypeName("#define CORPROF_E_IMMUTABLE_FLAGS_SET EMAKEHR(0x1372)")]
	public const int CORPROF_E_IMMUTABLE_FLAGS_SET = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1372))));

	[NativeTypeName("#define CORPROF_E_PROFILER_NOT_YET_INITIALIZED EMAKEHR(0x1373)")]
	public const int CORPROF_E_PROFILER_NOT_YET_INITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1373))));

	[NativeTypeName("#define CORPROF_E_INCONSISTENT_WITH_FLAGS EMAKEHR(0x1374)")]
	public const int CORPROF_E_INCONSISTENT_WITH_FLAGS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1374))));

	[NativeTypeName("#define CORPROF_E_PROFILER_CANCEL_ACTIVATION EMAKEHR(0x1375)")]
	public const int CORPROF_E_PROFILER_CANCEL_ACTIVATION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1375))));

	[NativeTypeName("#define CORPROF_E_CONCURRENT_GC_NOT_PROFILABLE EMAKEHR(0x1376)")]
	public const int CORPROF_E_CONCURRENT_GC_NOT_PROFILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1376))));

	[NativeTypeName("#define CORPROF_E_DEBUGGING_DISABLED EMAKEHR(0x1378)")]
	public const int CORPROF_E_DEBUGGING_DISABLED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1378))));

	[NativeTypeName("#define CORPROF_E_TIMEOUT_WAITING_FOR_CONCURRENT_GC EMAKEHR(0x1379)")]
	public const int CORPROF_E_TIMEOUT_WAITING_FOR_CONCURRENT_GC = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1379))));

	[NativeTypeName("#define CORPROF_E_MODULE_IS_DYNAMIC EMAKEHR(0x137a)")]
	public const int CORPROF_E_MODULE_IS_DYNAMIC = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x137a))));

	[NativeTypeName("#define CORPROF_E_CALLBACK4_REQUIRED EMAKEHR(0x137b)")]
	public const int CORPROF_E_CALLBACK4_REQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x137b))));

	[NativeTypeName("#define CORPROF_E_REJIT_NOT_ENABLED EMAKEHR(0x137c)")]
	public const int CORPROF_E_REJIT_NOT_ENABLED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x137c))));

	[NativeTypeName("#define CORPROF_E_FUNCTION_IS_COLLECTIBLE EMAKEHR(0x137e)")]
	public const int CORPROF_E_FUNCTION_IS_COLLECTIBLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x137e))));

	[NativeTypeName("#define CORPROF_E_CALLBACK6_REQUIRED EMAKEHR(0x1380)")]
	public const int CORPROF_E_CALLBACK6_REQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1380))));

	[NativeTypeName("#define CORPROF_E_CALLBACK7_REQUIRED EMAKEHR(0x1382)")]
	public const int CORPROF_E_CALLBACK7_REQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1382))));

	[NativeTypeName("#define CORPROF_E_REJIT_INLINING_DISABLED EMAKEHR(0x1383)")]
	public const int CORPROF_E_REJIT_INLINING_DISABLED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1383))));

	[NativeTypeName("#define CORDIAGIPC_E_BAD_ENCODING EMAKEHR(0x1384)")]
	public const int CORDIAGIPC_E_BAD_ENCODING = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1384))));

	[NativeTypeName("#define CORDIAGIPC_E_UNKNOWN_COMMAND EMAKEHR(0x1385)")]
	public const int CORDIAGIPC_E_UNKNOWN_COMMAND = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1385))));

	[NativeTypeName("#define CORDIAGIPC_E_UNKNOWN_MAGIC EMAKEHR(0x1386)")]
	public const int CORDIAGIPC_E_UNKNOWN_MAGIC = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1386))));

	[NativeTypeName("#define CORDIAGIPC_E_UNKNOWN_ERROR EMAKEHR(0x1387)")]
	public const int CORDIAGIPC_E_UNKNOWN_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1387))));

	[NativeTypeName("#define CORPROF_E_SUSPENSION_IN_PROGRESS EMAKEHR(0x1388)")]
	public const int CORPROF_E_SUSPENSION_IN_PROGRESS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1388))));

	[NativeTypeName("#define CORPROF_E_NOT_GC_OBJECT EMAKEHR(0x1389)")]
	public const int CORPROF_E_NOT_GC_OBJECT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1389))));

	[NativeTypeName("#define CORPROF_E_MODULE_IS_ENC EMAKEHR(0x138a)")]
	public const int CORPROF_E_MODULE_IS_ENC = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x138a))));

	[NativeTypeName("#define CORSEC_E_POLICY_EXCEPTION EMAKEHR(0x1416)")]
	public const int CORSEC_E_POLICY_EXCEPTION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1416))));

	[NativeTypeName("#define CORSEC_E_MIN_GRANT_FAIL EMAKEHR(0x1417)")]
	public const int CORSEC_E_MIN_GRANT_FAIL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1417))));

	[NativeTypeName("#define CORSEC_E_NO_EXEC_PERM EMAKEHR(0x1418)")]
	public const int CORSEC_E_NO_EXEC_PERM = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1418))));

	[NativeTypeName("#define CORSEC_E_XMLSYNTAX EMAKEHR(0x1419)")]
	public const int CORSEC_E_XMLSYNTAX = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1419))));

	[NativeTypeName("#define CORSEC_E_INVALID_STRONGNAME EMAKEHR(0x141a)")]
	public const int CORSEC_E_INVALID_STRONGNAME = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x141a))));

	[NativeTypeName("#define CORSEC_E_INVALID_IMAGE_FORMAT EMAKEHR(0x141d)")]
	public const int CORSEC_E_INVALID_IMAGE_FORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x141d))));

	[NativeTypeName("#define CORSEC_E_INVALID_PUBLICKEY EMAKEHR(0x141e)")]
	public const int CORSEC_E_INVALID_PUBLICKEY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x141e))));

	[NativeTypeName("#define CORSEC_E_SIGNATURE_MISMATCH EMAKEHR(0x1420)")]
	public const int CORSEC_E_SIGNATURE_MISMATCH = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1420))));

	[NativeTypeName("#define CORSEC_E_CRYPTO EMAKEHR(0x1430)")]
	public const int CORSEC_E_CRYPTO = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1430))));

	[NativeTypeName("#define CORSEC_E_CRYPTO_UNEX_OPER EMAKEHR(0x1431)")]
	public const int CORSEC_E_CRYPTO_UNEX_OPER = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1431))));

	[NativeTypeName("#define COR_E_EXCEPTION EMAKEHR(0x1500)")]
	public const int COR_E_EXCEPTION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1500))));

	[NativeTypeName("#define COR_E_SYSTEM EMAKEHR(0x1501)")]
	public const int COR_E_SYSTEM = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1501))));

	[NativeTypeName("#define COR_E_ARGUMENTOUTOFRANGE EMAKEHR(0x1502)")]
	public const int COR_E_ARGUMENTOUTOFRANGE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1502))));

	[NativeTypeName("#define COR_E_ARRAYTYPEMISMATCH EMAKEHR(0x1503)")]
	public const int COR_E_ARRAYTYPEMISMATCH = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1503))));

	[NativeTypeName("#define COR_E_CONTEXTMARSHAL EMAKEHR(0x1504)")]
	public const int COR_E_CONTEXTMARSHAL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1504))));

	[NativeTypeName("#define COR_E_TIMEOUT EMAKEHR(0x1505)")]
	public const int COR_E_TIMEOUT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1505))));

	[NativeTypeName("#define COR_E_EXECUTIONENGINE EMAKEHR(0x1506)")]
	public const int COR_E_EXECUTIONENGINE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1506))));

	[NativeTypeName("#define COR_E_FIELDACCESS EMAKEHR(0x1507)")]
	public const int COR_E_FIELDACCESS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1507))));

	[NativeTypeName("#define COR_E_INDEXOUTOFRANGE EMAKEHR(0x1508)")]
	public const int COR_E_INDEXOUTOFRANGE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1508))));

	[NativeTypeName("#define COR_E_INVALIDOPERATION EMAKEHR(0x1509)")]
	public const int COR_E_INVALIDOPERATION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1509))));

	[NativeTypeName("#define COR_E_SECURITY EMAKEHR(0x150a)")]
	public const int COR_E_SECURITY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x150a))));

	[NativeTypeName("#define COR_E_SERIALIZATION EMAKEHR(0x150c)")]
	public const int COR_E_SERIALIZATION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x150c))));

	[NativeTypeName("#define COR_E_VERIFICATION EMAKEHR(0x150d)")]
	public const int COR_E_VERIFICATION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x150d))));

	[NativeTypeName("#define COR_E_METHODACCESS EMAKEHR(0x1510)")]
	public const int COR_E_METHODACCESS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1510))));

	[NativeTypeName("#define COR_E_MISSINGFIELD EMAKEHR(0x1511)")]
	public const int COR_E_MISSINGFIELD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1511))));

	[NativeTypeName("#define COR_E_MISSINGMEMBER EMAKEHR(0x1512)")]
	public const int COR_E_MISSINGMEMBER = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1512))));

	[NativeTypeName("#define COR_E_MISSINGMETHOD EMAKEHR(0x1513)")]
	public const int COR_E_MISSINGMETHOD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1513))));

	[NativeTypeName("#define COR_E_MULTICASTNOTSUPPORTED EMAKEHR(0x1514)")]
	public const int COR_E_MULTICASTNOTSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1514))));

	[NativeTypeName("#define COR_E_NOTSUPPORTED EMAKEHR(0x1515)")]
	public const int COR_E_NOTSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1515))));

	[NativeTypeName("#define COR_E_OVERFLOW EMAKEHR(0x1516)")]
	public const int COR_E_OVERFLOW = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1516))));

	[NativeTypeName("#define COR_E_RANK EMAKEHR(0x1517)")]
	public const int COR_E_RANK = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1517))));

	[NativeTypeName("#define COR_E_SYNCHRONIZATIONLOCK EMAKEHR(0x1518)")]
	public const int COR_E_SYNCHRONIZATIONLOCK = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1518))));

	[NativeTypeName("#define COR_E_THREADINTERRUPTED EMAKEHR(0x1519)")]
	public const int COR_E_THREADINTERRUPTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1519))));

	[NativeTypeName("#define COR_E_MEMBERACCESS EMAKEHR(0x151a)")]
	public const int COR_E_MEMBERACCESS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x151a))));

	[NativeTypeName("#define COR_E_THREADSTATE EMAKEHR(0x1520)")]
	public const int COR_E_THREADSTATE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1520))));

	[NativeTypeName("#define COR_E_THREADSTOP EMAKEHR(0x1521)")]
	public const int COR_E_THREADSTOP = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1521))));

	[NativeTypeName("#define COR_E_TYPELOAD EMAKEHR(0x1522)")]
	public const int COR_E_TYPELOAD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1522))));

	[NativeTypeName("#define COR_E_ENTRYPOINTNOTFOUND EMAKEHR(0x1523)")]
	public const int COR_E_ENTRYPOINTNOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1523))));

	[NativeTypeName("#define COR_E_DLLNOTFOUND EMAKEHR(0x1524)")]
	public const int COR_E_DLLNOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1524))));

	[NativeTypeName("#define COR_E_THREADSTART EMAKEHR(0x1525)")]
	public const int COR_E_THREADSTART = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1525))));

	[NativeTypeName("#define COR_E_INVALIDCOMOBJECT EMAKEHR(0x1527)")]
	public const int COR_E_INVALIDCOMOBJECT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1527))));

	[NativeTypeName("#define COR_E_NOTFINITENUMBER EMAKEHR(0x1528)")]
	public const int COR_E_NOTFINITENUMBER = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1528))));

	[NativeTypeName("#define COR_E_DUPLICATEWAITOBJECT EMAKEHR(0x1529)")]
	public const int COR_E_DUPLICATEWAITOBJECT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1529))));

	[NativeTypeName("#define COR_E_SEMAPHOREFULL EMAKEHR(0x152b)")]
	public const int COR_E_SEMAPHOREFULL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x152b))));

	[NativeTypeName("#define COR_E_WAITHANDLECANNOTBEOPENED EMAKEHR(0x152c)")]
	public const int COR_E_WAITHANDLECANNOTBEOPENED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x152c))));

	[NativeTypeName("#define COR_E_ABANDONEDMUTEX EMAKEHR(0x152d)")]
	public const int COR_E_ABANDONEDMUTEX = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x152d))));

	[NativeTypeName("#define COR_E_THREADABORTED EMAKEHR(0x1530)")]
	public const int COR_E_THREADABORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1530))));

	[NativeTypeName("#define COR_E_INVALIDOLEVARIANTTYPE EMAKEHR(0x1531)")]
	public const int COR_E_INVALIDOLEVARIANTTYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1531))));

	[NativeTypeName("#define COR_E_MISSINGMANIFESTRESOURCE EMAKEHR(0x1532)")]
	public const int COR_E_MISSINGMANIFESTRESOURCE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1532))));

	[NativeTypeName("#define COR_E_SAFEARRAYTYPEMISMATCH EMAKEHR(0x1533)")]
	public const int COR_E_SAFEARRAYTYPEMISMATCH = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1533))));

	[NativeTypeName("#define COR_E_TYPEINITIALIZATION EMAKEHR(0x1534)")]
	public const int COR_E_TYPEINITIALIZATION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1534))));

	[NativeTypeName("#define COR_E_MARSHALDIRECTIVE EMAKEHR(0x1535)")]
	public const int COR_E_MARSHALDIRECTIVE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1535))));

	[NativeTypeName("#define COR_E_MISSINGSATELLITEASSEMBLY EMAKEHR(0x1536)")]
	public const int COR_E_MISSINGSATELLITEASSEMBLY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1536))));

	[NativeTypeName("#define COR_E_FORMAT EMAKEHR(0x1537)")]
	public const int COR_E_FORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1537))));

	[NativeTypeName("#define COR_E_SAFEARRAYRANKMISMATCH EMAKEHR(0x1538)")]
	public const int COR_E_SAFEARRAYRANKMISMATCH = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1538))));

	[NativeTypeName("#define COR_E_PLATFORMNOTSUPPORTED EMAKEHR(0x1539)")]
	public const int COR_E_PLATFORMNOTSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1539))));

	[NativeTypeName("#define COR_E_INVALIDPROGRAM EMAKEHR(0x153a)")]
	public const int COR_E_INVALIDPROGRAM = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x153a))));

	[NativeTypeName("#define COR_E_OPERATIONCANCELED EMAKEHR(0x153b)")]
	public const int COR_E_OPERATIONCANCELED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x153b))));

	[NativeTypeName("#define COR_E_INSUFFICIENTMEMORY EMAKEHR(0x153d)")]
	public const int COR_E_INSUFFICIENTMEMORY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x153d))));

	[NativeTypeName("#define COR_E_RUNTIMEWRAPPED EMAKEHR(0x153e)")]
	public const int COR_E_RUNTIMEWRAPPED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x153e))));

	[NativeTypeName("#define COR_E_DATAMISALIGNED EMAKEHR(0x1541)")]
	public const int COR_E_DATAMISALIGNED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1541))));

	[NativeTypeName("#define COR_E_CODECONTRACTFAILED EMAKEHR(0x1542)")]
	public const int COR_E_CODECONTRACTFAILED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1542))));

	[NativeTypeName("#define COR_E_TYPEACCESS EMAKEHR(0x1543)")]
	public const int COR_E_TYPEACCESS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1543))));

	[NativeTypeName("#define COR_E_ACCESSING_CCW EMAKEHR(0x1544)")]
	public const int COR_E_ACCESSING_CCW = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1544))));

	[NativeTypeName("#define COR_E_KEYNOTFOUND EMAKEHR(0x1577)")]
	public const int COR_E_KEYNOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1577))));

	[NativeTypeName("#define COR_E_INSUFFICIENTEXECUTIONSTACK EMAKEHR(0x1578)")]
	public const int COR_E_INSUFFICIENTEXECUTIONSTACK = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1578))));

	[NativeTypeName("#define COR_E_APPLICATION EMAKEHR(0x1600)")]
	public const int COR_E_APPLICATION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1600))));

	[NativeTypeName("#define COR_E_INVALIDFILTERCRITERIA EMAKEHR(0x1601)")]
	public const int COR_E_INVALIDFILTERCRITERIA = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1601))));

	[NativeTypeName("#define COR_E_REFLECTIONTYPELOAD EMAKEHR(0x1602)")]
	public const int COR_E_REFLECTIONTYPELOAD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1602))));

	[NativeTypeName("#define COR_E_TARGET EMAKEHR(0x1603)")]
	public const int COR_E_TARGET = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1603))));

	[NativeTypeName("#define COR_E_TARGETINVOCATION EMAKEHR(0x1604)")]
	public const int COR_E_TARGETINVOCATION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1604))));

	[NativeTypeName("#define COR_E_CUSTOMATTRIBUTEFORMAT EMAKEHR(0x1605)")]
	public const int COR_E_CUSTOMATTRIBUTEFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1605))));

	[NativeTypeName("#define COR_E_IO EMAKEHR(0x1620)")]
	public const int COR_E_IO = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1620))));

	[NativeTypeName("#define COR_E_FILELOAD EMAKEHR(0x1621)")]
	public const int COR_E_FILELOAD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1621))));

	[NativeTypeName("#define COR_E_OBJECTDISPOSED EMAKEHR(0x1622)")]
	public const int COR_E_OBJECTDISPOSED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1622))));

	[NativeTypeName("#define COR_E_FAILFAST EMAKEHR(0x1623)")]
	public const int COR_E_FAILFAST = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1623))));

	[NativeTypeName("#define COR_E_HOSTPROTECTION EMAKEHR(0x1640)")]
	public const int COR_E_HOSTPROTECTION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1640))));

	[NativeTypeName("#define COR_E_ILLEGAL_REENTRANCY EMAKEHR(0x1641)")]
	public const int COR_E_ILLEGAL_REENTRANCY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1641))));

	[NativeTypeName("#define CLR_E_SHIM_RUNTIMELOAD EMAKEHR(0x1700)")]
	public const int CLR_E_SHIM_RUNTIMELOAD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1700))));

	[NativeTypeName("#define CLR_E_SHIM_LEGACYRUNTIMEALREADYBOUND EMAKEHR(0x1704)")]
	public const int CLR_E_SHIM_LEGACYRUNTIMEALREADYBOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1704))));

	[NativeTypeName("#define VER_E_FIELD_SIG EMAKEHR(0x1815)")]
	public const int VER_E_FIELD_SIG = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1815))));

	[NativeTypeName("#define VER_E_CIRCULAR_VAR_CONSTRAINTS EMAKEHR(0x18ce)")]
	public const int VER_E_CIRCULAR_VAR_CONSTRAINTS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x18ce))));

	[NativeTypeName("#define VER_E_CIRCULAR_MVAR_CONSTRAINTS EMAKEHR(0x18cf)")]
	public const int VER_E_CIRCULAR_MVAR_CONSTRAINTS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x18cf))));

	[NativeTypeName("#define COR_E_Data EMAKEHR(0x1920)")]
	public const int COR_E_Data = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1920))));

	[NativeTypeName("#define VLDTR_E_SIG_BADVOID EMAKEHR(0x1b24)")]
	public const int VLDTR_E_SIG_BADVOID = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1b24))));

	[NativeTypeName("#define VLDTR_E_GP_ILLEGAL_VARIANT_MVAR EMAKEHR(0x1b2d)")]
	public const int VLDTR_E_GP_ILLEGAL_VARIANT_MVAR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1b2d))));

	[NativeTypeName("#define CORDBG_E_THREAD_NOT_SCHEDULED EMAKEHR(0x1c00)")]
	public const int CORDBG_E_THREAD_NOT_SCHEDULED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c00))));

	[NativeTypeName("#define CORDBG_E_HANDLE_HAS_BEEN_DISPOSED EMAKEHR(0x1c01)")]
	public const int CORDBG_E_HANDLE_HAS_BEEN_DISPOSED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c01))));

	[NativeTypeName("#define CORDBG_E_NONINTERCEPTABLE_EXCEPTION EMAKEHR(0x1c02)")]
	public const int CORDBG_E_NONINTERCEPTABLE_EXCEPTION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c02))));

	[NativeTypeName("#define CORDBG_E_INTERCEPT_FRAME_ALREADY_SET EMAKEHR(0x1c04)")]
	public const int CORDBG_E_INTERCEPT_FRAME_ALREADY_SET = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c04))));

	[NativeTypeName("#define CORDBG_E_NO_NATIVE_PATCH_AT_ADDR EMAKEHR(0x1c05)")]
	public const int CORDBG_E_NO_NATIVE_PATCH_AT_ADDR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c05))));

	[NativeTypeName("#define CORDBG_E_MUST_BE_INTEROP_DEBUGGING EMAKEHR(0x1c06)")]
	public const int CORDBG_E_MUST_BE_INTEROP_DEBUGGING = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c06))));

	[NativeTypeName("#define CORDBG_E_NATIVE_PATCH_ALREADY_AT_ADDR EMAKEHR(0x1c07)")]
	public const int CORDBG_E_NATIVE_PATCH_ALREADY_AT_ADDR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c07))));

	[NativeTypeName("#define CORDBG_E_TIMEOUT EMAKEHR(0x1c08)")]
	public const int CORDBG_E_TIMEOUT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c08))));

	[NativeTypeName("#define CORDBG_E_CANT_CALL_ON_THIS_THREAD EMAKEHR(0x1c09)")]
	public const int CORDBG_E_CANT_CALL_ON_THIS_THREAD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c09))));

	[NativeTypeName("#define CORDBG_E_ENC_INFOLESS_METHOD EMAKEHR(0x1c0a)")]
	public const int CORDBG_E_ENC_INFOLESS_METHOD = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c0a))));

	[NativeTypeName("#define CORDBG_E_ENC_IN_FUNCLET EMAKEHR(0x1c0c)")]
	public const int CORDBG_E_ENC_IN_FUNCLET = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c0c))));

	[NativeTypeName("#define CORDBG_E_ENC_EDIT_NOT_SUPPORTED EMAKEHR(0x1c0e)")]
	public const int CORDBG_E_ENC_EDIT_NOT_SUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c0e))));

	[NativeTypeName("#define CORDBG_E_NOTREADY EMAKEHR(0x1c10)")]
	public const int CORDBG_E_NOTREADY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c10))));

	[NativeTypeName("#define CORDBG_E_CANNOT_RESOLVE_ASSEMBLY EMAKEHR(0x1c11)")]
	public const int CORDBG_E_CANNOT_RESOLVE_ASSEMBLY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c11))));

	[NativeTypeName("#define CORDBG_E_MUST_BE_IN_LOAD_MODULE EMAKEHR(0x1c12)")]
	public const int CORDBG_E_MUST_BE_IN_LOAD_MODULE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c12))));

	[NativeTypeName("#define CORDBG_E_CANNOT_BE_ON_ATTACH EMAKEHR(0x1c13)")]
	public const int CORDBG_E_CANNOT_BE_ON_ATTACH = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c13))));

	[NativeTypeName("#define CORDBG_E_NGEN_NOT_SUPPORTED EMAKEHR(0x1c14)")]
	public const int CORDBG_E_NGEN_NOT_SUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c14))));

	[NativeTypeName("#define CORDBG_E_ILLEGAL_SHUTDOWN_ORDER EMAKEHR(0x1c15)")]
	public const int CORDBG_E_ILLEGAL_SHUTDOWN_ORDER = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c15))));

	[NativeTypeName("#define CORDBG_E_MUST_BE_IN_CREATE_PROCESS EMAKEHR(0x1c17)")]
	public const int CORDBG_E_MUST_BE_IN_CREATE_PROCESS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c17))));

	[NativeTypeName("#define CORDBG_E_DETACH_FAILED_OUTSTANDING_EVALS EMAKEHR(0x1c18)")]
	public const int CORDBG_E_DETACH_FAILED_OUTSTANDING_EVALS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c18))));

	[NativeTypeName("#define CORDBG_E_DETACH_FAILED_OUTSTANDING_STEPPERS EMAKEHR(0x1c19)")]
	public const int CORDBG_E_DETACH_FAILED_OUTSTANDING_STEPPERS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c19))));

	[NativeTypeName("#define CORDBG_E_CANT_INTEROP_STEP_OUT EMAKEHR(0x1c20)")]
	public const int CORDBG_E_CANT_INTEROP_STEP_OUT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c20))));

	[NativeTypeName("#define CORDBG_E_DETACH_FAILED_OUTSTANDING_BREAKPOINTS EMAKEHR(0x1c21)")]
	public const int CORDBG_E_DETACH_FAILED_OUTSTANDING_BREAKPOINTS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c21))));

	[NativeTypeName("#define CORDBG_E_ILLEGAL_IN_STACK_OVERFLOW EMAKEHR(0x1c22)")]
	public const int CORDBG_E_ILLEGAL_IN_STACK_OVERFLOW = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c22))));

	[NativeTypeName("#define CORDBG_E_ILLEGAL_AT_GC_UNSAFE_POINT EMAKEHR(0x1c23)")]
	public const int CORDBG_E_ILLEGAL_AT_GC_UNSAFE_POINT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c23))));

	[NativeTypeName("#define CORDBG_E_ILLEGAL_IN_PROLOG EMAKEHR(0x1c24)")]
	public const int CORDBG_E_ILLEGAL_IN_PROLOG = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c24))));

	[NativeTypeName("#define CORDBG_E_ILLEGAL_IN_NATIVE_CODE EMAKEHR(0x1c25)")]
	public const int CORDBG_E_ILLEGAL_IN_NATIVE_CODE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c25))));

	[NativeTypeName("#define CORDBG_E_ILLEGAL_IN_OPTIMIZED_CODE EMAKEHR(0x1c26)")]
	public const int CORDBG_E_ILLEGAL_IN_OPTIMIZED_CODE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c26))));

	[NativeTypeName("#define CORDBG_E_APPDOMAIN_MISMATCH EMAKEHR(0x1c28)")]
	public const int CORDBG_E_APPDOMAIN_MISMATCH = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c28))));

	[NativeTypeName("#define CORDBG_E_CONTEXT_UNVAILABLE EMAKEHR(0x1c29)")]
	public const int CORDBG_E_CONTEXT_UNVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c29))));

	[NativeTypeName("#define CORDBG_E_INCOMPATIBLE_PLATFORMS EMAKEHR(0x1c30)")]
	public const int CORDBG_E_INCOMPATIBLE_PLATFORMS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c30))));

	[NativeTypeName("#define CORDBG_E_DEBUGGING_DISABLED EMAKEHR(0x1c31)")]
	public const int CORDBG_E_DEBUGGING_DISABLED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c31))));

	[NativeTypeName("#define CORDBG_E_DETACH_FAILED_ON_ENC EMAKEHR(0x1c32)")]
	public const int CORDBG_E_DETACH_FAILED_ON_ENC = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c32))));

	[NativeTypeName("#define CORDBG_E_CURRENT_EXCEPTION_IS_OUTSIDE_CURRENT_EXECUTION_SCOPE EMAKEHR(0x1c33)")]
	public const int CORDBG_E_CURRENT_EXCEPTION_IS_OUTSIDE_CURRENT_EXECUTION_SCOPE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c33))));

	[NativeTypeName("#define CORDBG_E_HELPER_MAY_DEADLOCK EMAKEHR(0x1c34)")]
	public const int CORDBG_E_HELPER_MAY_DEADLOCK = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c34))));

	[NativeTypeName("#define CORDBG_E_MISSING_METADATA EMAKEHR(0x1c35)")]
	public const int CORDBG_E_MISSING_METADATA = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c35))));

	[NativeTypeName("#define CORDBG_E_TARGET_INCONSISTENT EMAKEHR(0x1c36)")]
	public const int CORDBG_E_TARGET_INCONSISTENT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c36))));

	[NativeTypeName("#define CORDBG_E_DETACH_FAILED_OUTSTANDING_TARGET_RESOURCES EMAKEHR(0x1c37)")]
	public const int CORDBG_E_DETACH_FAILED_OUTSTANDING_TARGET_RESOURCES = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c37))));

	[NativeTypeName("#define CORDBG_E_TARGET_READONLY EMAKEHR(0x1c38)")]
	public const int CORDBG_E_TARGET_READONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c38))));

	[NativeTypeName("#define CORDBG_E_MISMATCHED_CORWKS_AND_DACWKS_DLLS EMAKEHR(0x1c39)")]
	public const int CORDBG_E_MISMATCHED_CORWKS_AND_DACWKS_DLLS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c39))));

	[NativeTypeName("#define CORDBG_E_MODULE_LOADED_FROM_DISK EMAKEHR(0x1c3a)")]
	public const int CORDBG_E_MODULE_LOADED_FROM_DISK = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c3a))));

	[NativeTypeName("#define CORDBG_E_SYMBOLS_NOT_AVAILABLE EMAKEHR(0x1c3b)")]
	public const int CORDBG_E_SYMBOLS_NOT_AVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c3b))));

	[NativeTypeName("#define CORDBG_E_DEBUG_COMPONENT_MISSING EMAKEHR(0x1c3c)")]
	public const int CORDBG_E_DEBUG_COMPONENT_MISSING = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c3c))));

	[NativeTypeName("#define CORDBG_E_LIBRARY_PROVIDER_ERROR EMAKEHR(0x1c43)")]
	public const int CORDBG_E_LIBRARY_PROVIDER_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c43))));

	[NativeTypeName("#define CORDBG_E_NOT_CLR EMAKEHR(0x1c44)")]
	public const int CORDBG_E_NOT_CLR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c44))));

	[NativeTypeName("#define CORDBG_E_MISSING_DATA_TARGET_INTERFACE EMAKEHR(0x1c45)")]
	public const int CORDBG_E_MISSING_DATA_TARGET_INTERFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c45))));

	[NativeTypeName("#define CORDBG_E_UNSUPPORTED_DEBUGGING_MODEL EMAKEHR(0x1c46)")]
	public const int CORDBG_E_UNSUPPORTED_DEBUGGING_MODEL = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c46))));

	[NativeTypeName("#define CORDBG_E_UNSUPPORTED_FORWARD_COMPAT EMAKEHR(0x1c47)")]
	public const int CORDBG_E_UNSUPPORTED_FORWARD_COMPAT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c47))));

	[NativeTypeName("#define CORDBG_E_UNSUPPORTED_VERSION_STRUCT EMAKEHR(0x1c48)")]
	public const int CORDBG_E_UNSUPPORTED_VERSION_STRUCT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c48))));

	[NativeTypeName("#define CORDBG_E_READVIRTUAL_FAILURE EMAKEHR(0x1c49)")]
	public const int CORDBG_E_READVIRTUAL_FAILURE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c49))));

	[NativeTypeName("#define CORDBG_E_VALUE_POINTS_TO_FUNCTION EMAKEHR(0x1c4a)")]
	public const int CORDBG_E_VALUE_POINTS_TO_FUNCTION = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c4a))));

	[NativeTypeName("#define CORDBG_E_CORRUPT_OBJECT EMAKEHR(0x1c4b)")]
	public const int CORDBG_E_CORRUPT_OBJECT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c4b))));

	[NativeTypeName("#define CORDBG_E_GC_STRUCTURES_INVALID EMAKEHR(0x1c4c)")]
	public const int CORDBG_E_GC_STRUCTURES_INVALID = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c4c))));

	[NativeTypeName("#define CORDBG_E_INVALID_OPCODE EMAKEHR(0x1c4d)")]
	public const int CORDBG_E_INVALID_OPCODE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c4d))));

	[NativeTypeName("#define CORDBG_E_UNSUPPORTED EMAKEHR(0x1c4e)")]
	public const int CORDBG_E_UNSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c4e))));

	[NativeTypeName("#define CORDBG_E_MISSING_DEBUGGER_EXPORTS EMAKEHR(0x1c4f)")]
	public const int CORDBG_E_MISSING_DEBUGGER_EXPORTS = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c4f))));

	[NativeTypeName("#define CORDBG_E_DATA_TARGET_ERROR EMAKEHR(0x1c61)")]
	public const int CORDBG_E_DATA_TARGET_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c61))));

	[NativeTypeName("#define CORDBG_E_UNSUPPORTED_DELEGATE EMAKEHR(0x1c68)")]
	public const int CORDBG_E_UNSUPPORTED_DELEGATE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c68))));

	[NativeTypeName("#define CORDBG_E_ASSEMBLY_UPDATES_APPLIED EMAKEHR(0x1c69)")]
	public const int CORDBG_E_ASSEMBLY_UPDATES_APPLIED = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1c69))));

	[NativeTypeName("#define PEFMT_E_64BIT EMAKEHR(0x1d02)")]
	public const int PEFMT_E_64BIT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1d02))));

	[NativeTypeName("#define PEFMT_E_32BIT EMAKEHR(0x1d0b)")]
	public const int PEFMT_E_32BIT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1d0b))));

	[NativeTypeName("#define CLDB_E_INTERNALERROR EMAKEHR(0x1fff)")]
	public const int CLDB_E_INTERNALERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x1fff))));

	[NativeTypeName("#define CLR_E_BIND_ARCHITECTURE_MISMATCH EMAKEHR(0x2006)")]
	public const int CLR_E_BIND_ARCHITECTURE_MISMATCH = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x2006))));

	[NativeTypeName("#define CLR_E_GC_OOM EMAKEHR(0x2009)")]
	public const int CLR_E_GC_OOM = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x2009))));

	[NativeTypeName("#define CLR_E_GC_BAD_AFFINITY_CONFIG EMAKEHR(0x200a)")]
	public const int CLR_E_GC_BAD_AFFINITY_CONFIG = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x200a))));

	[NativeTypeName("#define CLR_E_GC_BAD_AFFINITY_CONFIG_FORMAT EMAKEHR(0x200b)")]
	public const int CLR_E_GC_BAD_AFFINITY_CONFIG_FORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x200b))));

	[NativeTypeName("#define CLR_E_GC_BAD_HARD_LIMIT EMAKEHR(0x200d)")]
	public const int CLR_E_GC_BAD_HARD_LIMIT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x200d))));

	[NativeTypeName("#define CLR_E_GC_LARGE_PAGE_MISSING_HARD_LIMIT EMAKEHR(0x200e)")]
	public const int CLR_E_GC_LARGE_PAGE_MISSING_HARD_LIMIT = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x200e))));

	[NativeTypeName("#define CLR_E_GC_BAD_REGION_SIZE EMAKEHR(0x200f)")]
	public const int CLR_E_GC_BAD_REGION_SIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(19) << 16) | ((uint)(0x200f))));

	[NativeTypeName("#define COR_E_UNAUTHORIZEDACCESS E_ACCESSDENIED")]
	public const int COR_E_UNAUTHORIZEDACCESS = unchecked((int)(0x80070005));

	[NativeTypeName("#define COR_E_ARGUMENT E_INVALIDARG")]
	public const int COR_E_ARGUMENT = unchecked((int)(0x80070057));

	[NativeTypeName("#define COR_E_INVALIDCAST E_NOINTERFACE")]
	public const int COR_E_INVALIDCAST = unchecked((int)(0x80004002));

	[NativeTypeName("#define COR_E_OUTOFMEMORY E_OUTOFMEMORY")]
	public const int COR_E_OUTOFMEMORY = unchecked((int)(0x8007000E));

	[NativeTypeName("#define COR_E_NULLREFERENCE E_POINTER")]
	public const int COR_E_NULLREFERENCE = unchecked((int)(0x80004003));

	[NativeTypeName("#define COR_E_ARITHMETIC __HRESULT_FROM_WIN32(ERROR_ARITHMETIC_OVERFLOW)")]
	public const int COR_E_ARITHMETIC = unchecked((int)(534) <= 0 ? ((int)(534)) : ((int)(((534) & 0x0000FFFF) | (7 << 16) | 0x80000000)));

	[NativeTypeName("#define COR_E_PATHTOOLONG __HRESULT_FROM_WIN32(ERROR_FILENAME_EXCED_RANGE)")]
	public const int COR_E_PATHTOOLONG = unchecked((int)(206) <= 0 ? ((int)(206)) : ((int)(((206) & 0x0000FFFF) | (7 << 16) | 0x80000000)));

	[NativeTypeName("#define COR_E_FILENOTFOUND __HRESULT_FROM_WIN32(ERROR_FILE_NOT_FOUND)")]
	public const int COR_E_FILENOTFOUND = unchecked((int)(2) <= 0 ? ((int)(2)) : ((int)(((2) & 0x0000FFFF) | (7 << 16) | 0x80000000)));

	[NativeTypeName("#define COR_E_ENDOFSTREAM __HRESULT_FROM_WIN32(ERROR_HANDLE_EOF)")]
	public const int COR_E_ENDOFSTREAM = unchecked((int)(38) <= 0 ? ((int)(38)) : ((int)(((38) & 0x0000FFFF) | (7 << 16) | 0x80000000)));

	[NativeTypeName("#define COR_E_DIRECTORYNOTFOUND __HRESULT_FROM_WIN32(ERROR_PATH_NOT_FOUND)")]
	public const int COR_E_DIRECTORYNOTFOUND = unchecked((int)(3) <= 0 ? ((int)(3)) : ((int)(((3) & 0x0000FFFF) | (7 << 16) | 0x80000000)));

	[NativeTypeName("#define COR_E_STACKOVERFLOW __HRESULT_FROM_WIN32(ERROR_STACK_OVERFLOW)")]
	public const int COR_E_STACKOVERFLOW = unchecked((int)(1001) <= 0 ? ((int)(1001)) : ((int)(((1001) & 0x0000FFFF) | (7 << 16) | 0x80000000)));

	[NativeTypeName("#define COR_E_AMBIGUOUSMATCH _HRESULT_TYPEDEF_(0x8000211DL)")]
	public const int COR_E_AMBIGUOUSMATCH = unchecked((int)(0x8000211D));

	[NativeTypeName("#define COR_E_TARGETPARAMCOUNT _HRESULT_TYPEDEF_(0x8002000EL)")]
	public const int COR_E_TARGETPARAMCOUNT = unchecked((int)(0x8002000E));

	[NativeTypeName("#define COR_E_DIVIDEBYZERO _HRESULT_TYPEDEF_(0x80020012L)")]
	public const int COR_E_DIVIDEBYZERO = unchecked((int)(0x80020012));

	[NativeTypeName("#define COR_E_BADIMAGEFORMAT _HRESULT_TYPEDEF_(0x8007000BL)")]
	public const int COR_E_BADIMAGEFORMAT = unchecked((int)(0x8007000B));

	[NativeTypeName("#define CLSID_CorMetaDataRuntime CLSID_CLR_v2_MetaData")]
	public static readonly Guid CLSID_CorMetaDataRuntime = ref CLSID_CLR_v2_MetaData;

	[NativeTypeName("#define MetaDataSetENC MetaDataSetUpdate")]
	public static readonly Guid MetaDataSetENC = ref MetaDataSetUpdate;

	[NativeTypeName("#define INVALID_CONNECTION_ID 0x0")]
	public const int INVALID_CONNECTION_ID = 0x0;

	[NativeTypeName("#define INVALID_TASK_ID 0x0")]
	public const int INVALID_TASK_ID = 0x0;

	[NativeTypeName("#define MAX_CONNECTION_NAME MAX_PATH")]
	public const int MAX_CONNECTION_NAME = 260;

	[NativeTypeName("#define MAIN_CLR_MODULE_NAME_A \"coreclr\"")]
	public static ReadOnlySpan<byte> MAIN_CLR_MODULE_NAME_A => "coreclr"u8;

	[NativeTypeName("#define COR_CTOR_METHOD_NAME \".ctor\"")]
	public static ReadOnlySpan<byte> COR_CTOR_METHOD_NAME => ".ctor"u8;

	[NativeTypeName("#define COR_CCTOR_METHOD_NAME \".cctor\"")]
	public static ReadOnlySpan<byte> COR_CCTOR_METHOD_NAME => ".cctor"u8;

	[NativeTypeName("#define COR_ENUM_FIELD_NAME \"value__\"")]
	public static ReadOnlySpan<byte> COR_ENUM_FIELD_NAME => "value__"u8;

	[NativeTypeName("#define COR_DELETED_NAME_A \"_Deleted\"")]
	public static ReadOnlySpan<byte> COR_DELETED_NAME_A => "_Deleted"u8;

	[NativeTypeName("#define COR_VTABLEGAP_NAME_A \"_VtblGap\"")]
	public static ReadOnlySpan<byte> COR_VTABLEGAP_NAME_A => "_VtblGap"u8;

	[NativeTypeName("#define IMAGE_CEE_CS_CALLCONV_INSTANTIATION IMAGE_CEE_CS_CALLCONV_GENERICINST")]
	public const CorCallingConvention IMAGE_CEE_CS_CALLCONV_INSTANTIATION = IMAGE_CEE_CS_CALLCONV_GENERICINST;

	[NativeTypeName("#define mdTokenNil ((mdToken)0)")]
	public const uint mdTokenNil = ((uint)(0));

	[NativeTypeName("#define mdModuleNil ((mdModule)mdtModule)")]
	public const uint mdModuleNil = ((uint)(mdtModule));

	[NativeTypeName("#define mdTypeRefNil ((mdTypeRef)mdtTypeRef)")]
	public const uint mdTypeRefNil = ((uint)(mdtTypeRef));

	[NativeTypeName("#define mdTypeDefNil ((mdTypeDef)mdtTypeDef)")]
	public const uint mdTypeDefNil = ((uint)(mdtTypeDef));

	[NativeTypeName("#define mdFieldDefNil ((mdFieldDef)mdtFieldDef)")]
	public const uint mdFieldDefNil = ((uint)(mdtFieldDef));

	[NativeTypeName("#define mdMethodDefNil ((mdMethodDef)mdtMethodDef)")]
	public const uint mdMethodDefNil = ((uint)(mdtMethodDef));

	[NativeTypeName("#define mdParamDefNil ((mdParamDef)mdtParamDef)")]
	public const uint mdParamDefNil = ((uint)(mdtParamDef));

	[NativeTypeName("#define mdInterfaceImplNil ((mdInterfaceImpl)mdtInterfaceImpl)")]
	public const uint mdInterfaceImplNil = ((uint)(mdtInterfaceImpl));

	[NativeTypeName("#define mdMemberRefNil ((mdMemberRef)mdtMemberRef)")]
	public const uint mdMemberRefNil = ((uint)(mdtMemberRef));

	[NativeTypeName("#define mdCustomAttributeNil ((mdCustomAttribute)mdtCustomAttribute)")]
	public const uint mdCustomAttributeNil = ((uint)(mdtCustomAttribute));

	[NativeTypeName("#define mdPermissionNil ((mdPermission)mdtPermission)")]
	public const uint mdPermissionNil = ((uint)(mdtPermission));

	[NativeTypeName("#define mdSignatureNil ((mdSignature)mdtSignature)")]
	public const uint mdSignatureNil = ((uint)(mdtSignature));

	[NativeTypeName("#define mdEventNil ((mdEvent)mdtEvent)")]
	public const uint mdEventNil = ((uint)(mdtEvent));

	[NativeTypeName("#define mdPropertyNil ((mdProperty)mdtProperty)")]
	public const uint mdPropertyNil = ((uint)(mdtProperty));

	[NativeTypeName("#define mdModuleRefNil ((mdModuleRef)mdtModuleRef)")]
	public const uint mdModuleRefNil = ((uint)(mdtModuleRef));

	[NativeTypeName("#define mdTypeSpecNil ((mdTypeSpec)mdtTypeSpec)")]
	public const uint mdTypeSpecNil = ((uint)(mdtTypeSpec));

	[NativeTypeName("#define mdAssemblyNil ((mdAssembly)mdtAssembly)")]
	public const uint mdAssemblyNil = ((uint)(mdtAssembly));

	[NativeTypeName("#define mdAssemblyRefNil ((mdAssemblyRef)mdtAssemblyRef)")]
	public const uint mdAssemblyRefNil = ((uint)(mdtAssemblyRef));

	[NativeTypeName("#define mdFileNil ((mdFile)mdtFile)")]
	public const uint mdFileNil = ((uint)(mdtFile));

	[NativeTypeName("#define mdExportedTypeNil ((mdExportedType)mdtExportedType)")]
	public const uint mdExportedTypeNil = ((uint)(mdtExportedType));

	[NativeTypeName("#define mdManifestResourceNil ((mdManifestResource)mdtManifestResource)")]
	public const uint mdManifestResourceNil = ((uint)(mdtManifestResource));

	[NativeTypeName("#define mdGenericParamNil ((mdGenericParam)mdtGenericParam)")]
	public const uint mdGenericParamNil = ((uint)(mdtGenericParam));

	[NativeTypeName("#define mdGenericParamConstraintNil ((mdGenericParamConstraint)mdtGenericParamConstraint)")]
	public const uint mdGenericParamConstraintNil = ((uint)(mdtGenericParamConstraint));

	[NativeTypeName("#define mdMethodSpecNil ((mdMethodSpec)mdtMethodSpec)")]
	public const uint mdMethodSpecNil = ((uint)(mdtMethodSpec));

	[NativeTypeName("#define mdStringNil ((mdString)mdtString)")]
	public const uint mdStringNil = ((uint)(mdtString));

	[NativeTypeName("#define IMAGE_CEE_CS_CALLCONV_DEFAULT_HASTHIS (IMAGE_CEE_CS_CALLCONV_DEFAULT | IMAGE_CEE_CS_CALLCONV_HASTHIS)")]
	public const int IMAGE_CEE_CS_CALLCONV_DEFAULT_HASTHIS = ((int)(IMAGE_CEE_CS_CALLCONV_DEFAULT) | (int)(IMAGE_CEE_CS_CALLCONV_HASTHIS));

	[NativeTypeName("#define INTEROP_DISPID_TYPE \"System.Runtime.InteropServices.DispIdAttribute\"")]
	public static ReadOnlySpan<byte> INTEROP_DISPID_TYPE => "System.Runtime.InteropServices.DispIdAttribute"u8;

	[NativeTypeName("#define INTEROP_INTERFACETYPE_TYPE \"System.Runtime.InteropServices.InterfaceTypeAttribute\"")]
	public static ReadOnlySpan<byte> INTEROP_INTERFACETYPE_TYPE => "System.Runtime.InteropServices.InterfaceTypeAttribute"u8;

	[NativeTypeName("#define INTEROP_GUID_TYPE \"System.Runtime.InteropServices.GuidAttribute\"")]
	public static ReadOnlySpan<byte> INTEROP_GUID_TYPE => "System.Runtime.InteropServices.GuidAttribute"u8;

	[NativeTypeName("#define INTEROP_TYPELIBVERSION_TYPE \"System.Runtime.InteropServices.TypeLibVersionAttribute\"")]
	public static ReadOnlySpan<byte> INTEROP_TYPELIBVERSION_TYPE => "System.Runtime.InteropServices.TypeLibVersionAttribute"u8;

	[NativeTypeName("#define INTEROP_COMEVENTINTERFACE_TYPE \"System.Runtime.InteropServices.ComEventInterfaceAttribute\"")]
	public static ReadOnlySpan<byte> INTEROP_COMEVENTINTERFACE_TYPE => "System.Runtime.InteropServices.ComEventInterfaceAttribute"u8;

	[NativeTypeName("#define FRIEND_ASSEMBLY_TYPE \"System.Runtime.CompilerServices.InternalsVisibleToAttribute\"")]
	public static ReadOnlySpan<byte> FRIEND_ASSEMBLY_TYPE => "System.Runtime.CompilerServices.InternalsVisibleToAttribute"u8;

	[NativeTypeName("#define FRIEND_ASSEMBLY_TYPE_NAMESPACE \"System.Runtime.CompilerServices\"")]
	public static ReadOnlySpan<byte> FRIEND_ASSEMBLY_TYPE_NAMESPACE => "System.Runtime.CompilerServices"u8;

	[NativeTypeName("#define FRIEND_ASSEMBLY_TYPE_NAME \"InternalsVisibleToAttribute\"")]
	public static ReadOnlySpan<byte> FRIEND_ASSEMBLY_TYPE_NAME => "InternalsVisibleToAttribute"u8;

	[NativeTypeName("#define SUBJECT_ASSEMBLY_TYPE \"System.Runtime.CompilerServices.IgnoresAccessChecksToAttribute\"")]
	public static ReadOnlySpan<byte> SUBJECT_ASSEMBLY_TYPE => "System.Runtime.CompilerServices.IgnoresAccessChecksToAttribute"u8;

	[NativeTypeName("#define SUBJECT_ASSEMBLY_TYPE_NAMESPACE \"System.Runtime.CompilerServices\"")]
	public static ReadOnlySpan<byte> SUBJECT_ASSEMBLY_TYPE_NAMESPACE => "System.Runtime.CompilerServices"u8;

	[NativeTypeName("#define SUBJECT_ASSEMBLY_TYPE_NAME \"IgnoresAccessChecksToAttribute\"")]
	public static ReadOnlySpan<byte> SUBJECT_ASSEMBLY_TYPE_NAME => "IgnoresAccessChecksToAttribute"u8;

	[NativeTypeName("#define DEFAULTDOMAIN_STA_TYPE \"System.STAThreadAttribute\"")]
	public static ReadOnlySpan<byte> DEFAULTDOMAIN_STA_TYPE => "System.STAThreadAttribute"u8;

	[NativeTypeName("#define DEFAULTDOMAIN_MTA_TYPE \"System.MTAThreadAttribute\"")]
	public static ReadOnlySpan<byte> DEFAULTDOMAIN_MTA_TYPE => "System.MTAThreadAttribute"u8;

	[NativeTypeName("#define DEBUGGABLE_ATTRIBUTE_TYPE \"System.Diagnostics.DebuggableAttribute\"")]
	public static ReadOnlySpan<byte> DEBUGGABLE_ATTRIBUTE_TYPE => "System.Diagnostics.DebuggableAttribute"u8;

	[NativeTypeName("#define DEBUGGABLE_ATTRIBUTE_TYPE_NAMESPACE \"System.Diagnostics\"")]
	public static ReadOnlySpan<byte> DEBUGGABLE_ATTRIBUTE_TYPE_NAMESPACE => "System.Diagnostics"u8;

	[NativeTypeName("#define DEBUGGABLE_ATTRIBUTE_TYPE_NAME \"DebuggableAttribute\"")]
	public static ReadOnlySpan<byte> DEBUGGABLE_ATTRIBUTE_TYPE_NAME => "DebuggableAttribute"u8;

	[NativeTypeName("#define RUNTIMECOMPATIBILITY_TYPE \"System.Runtime.CompilerServices.RuntimeCompatibilityAttribute\"")]
	public static ReadOnlySpan<byte> RUNTIMECOMPATIBILITY_TYPE => "System.Runtime.CompilerServices.RuntimeCompatibilityAttribute"u8;

	[NativeTypeName("#define RUNTIMECOMPATIBILITY_TYPE_NAMESPACE \"System.Runtime.CompilerServices\"")]
	public static ReadOnlySpan<byte> RUNTIMECOMPATIBILITY_TYPE_NAMESPACE => "System.Runtime.CompilerServices"u8;

	[NativeTypeName("#define RUNTIMECOMPATIBILITY_TYPE_NAME \"RuntimeCompatibilityAttribute\"")]
	public static ReadOnlySpan<byte> RUNTIMECOMPATIBILITY_TYPE_NAME => "RuntimeCompatibilityAttribute"u8;

	[NativeTypeName("#define CMOD_CALLCONV_NAMESPACE_OLD \"System.Runtime.InteropServices\"")]
	public static ReadOnlySpan<byte> CMOD_CALLCONV_NAMESPACE_OLD => "System.Runtime.InteropServices"u8;

	[NativeTypeName("#define CMOD_CALLCONV_NAMESPACE \"System.Runtime.CompilerServices\"")]
	public static ReadOnlySpan<byte> CMOD_CALLCONV_NAMESPACE => "System.Runtime.CompilerServices"u8;

	[NativeTypeName("#define CMOD_CALLCONV_NAME_CDECL \"CallConvCdecl\"")]
	public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_CDECL => "CallConvCdecl"u8;

	[NativeTypeName("#define CMOD_CALLCONV_NAME_STDCALL \"CallConvStdcall\"")]
	public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_STDCALL => "CallConvStdcall"u8;

	[NativeTypeName("#define CMOD_CALLCONV_NAME_THISCALL \"CallConvThiscall\"")]
	public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_THISCALL => "CallConvThiscall"u8;

	[NativeTypeName("#define CMOD_CALLCONV_NAME_FASTCALL \"CallConvFastcall\"")]
	public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_FASTCALL => "CallConvFastcall"u8;

	[NativeTypeName("#define CMOD_CALLCONV_NAME_SWIFT \"CallConvSwift\"")]
	public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_SWIFT => "CallConvSwift"u8;

	[NativeTypeName("#define CMOD_CALLCONV_NAME_SUPPRESSGCTRANSITION \"CallConvSuppressGCTransition\"")]
	public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_SUPPRESSGCTRANSITION => "CallConvSuppressGCTransition"u8;

	[NativeTypeName("#define CMOD_CALLCONV_NAME_MEMBERFUNCTION \"CallConvMemberFunction\"")]
	public static ReadOnlySpan<byte> CMOD_CALLCONV_NAME_MEMBERFUNCTION => "CallConvMemberFunction"u8;

	[NativeTypeName("#define COR_BASE_SECURITY_ATTRIBUTE_CLASS L\"System.Security.Permissions.SecurityAttribute\"")]
	public const string COR_BASE_SECURITY_ATTRIBUTE_CLASS = "System.Security.Permissions.SecurityAttribute";

	[NativeTypeName("#define COR_BASE_SECURITY_ATTRIBUTE_CLASS_ANSI \"System.Security.Permissions.SecurityAttribute\"")]
	public static ReadOnlySpan<byte> COR_BASE_SECURITY_ATTRIBUTE_CLASS_ANSI => "System.Security.Permissions.SecurityAttribute"u8;

	[NativeTypeName("#define COR_SUPPRESS_UNMANAGED_CODE_CHECK_ATTRIBUTE L\"System.Security.SuppressUnmanagedCodeSecurityAttribute\"")]
	public const string COR_SUPPRESS_UNMANAGED_CODE_CHECK_ATTRIBUTE = "System.Security.SuppressUnmanagedCodeSecurityAttribute";

	[NativeTypeName("#define COR_SUPPRESS_UNMANAGED_CODE_CHECK_ATTRIBUTE_ANSI \"System.Security.SuppressUnmanagedCodeSecurityAttribute\"")]
	public static ReadOnlySpan<byte> COR_SUPPRESS_UNMANAGED_CODE_CHECK_ATTRIBUTE_ANSI => "System.Security.SuppressUnmanagedCodeSecurityAttribute"u8;

	[NativeTypeName("#define COR_UNVER_CODE_ATTRIBUTE L\"System.Security.UnverifiableCodeAttribute\"")]
	public const string COR_UNVER_CODE_ATTRIBUTE = "System.Security.UnverifiableCodeAttribute";

	[NativeTypeName("#define COR_UNVER_CODE_ATTRIBUTE_ANSI \"System.Security.UnverifiableCodeAttribute\"")]
	public static ReadOnlySpan<byte> COR_UNVER_CODE_ATTRIBUTE_ANSI => "System.Security.UnverifiableCodeAttribute"u8;

	[NativeTypeName("#define COR_REQUIRES_SECOBJ_ATTRIBUTE_ANSI \"System.Security.DynamicSecurityMethodAttribute\"")]
	public static ReadOnlySpan<byte> COR_REQUIRES_SECOBJ_ATTRIBUTE_ANSI => "System.Security.DynamicSecurityMethodAttribute"u8;

	[NativeTypeName("#define COR_COMPILERSERVICE_DISCARDABLEATTRIBUTE L\"System.Runtime.CompilerServices.DiscardableAttribute\"")]
	public const string COR_COMPILERSERVICE_DISCARDABLEATTRIBUTE = "System.Runtime.CompilerServices.DiscardableAttribute";

	[NativeTypeName("#define COR_COMPILERSERVICE_DISCARDABLEATTRIBUTE_ASNI \"System.Runtime.CompilerServices.DiscardableAttribute\"")]
	public static ReadOnlySpan<byte> COR_COMPILERSERVICE_DISCARDABLEATTRIBUTE_ASNI => "System.Runtime.CompilerServices.DiscardableAttribute"u8;
}
