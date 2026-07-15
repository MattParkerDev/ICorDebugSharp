import tempfile
import unittest
from pathlib import Path

from midl_classic import parse_string

from generate import CSharpGenerator, GenerationError, parse_midl_file, write_interfaces


IDL = """
typedef UINT32 mdToken;
typedef mdToken mdTypeDef;
typedef ULONG64 CORDB_ADDRESS;

[
    object,
    uuid(dba2d8c1-e5c5-4069-8c13-10a7c6abf43d),
    pointer_default(unique)
]
interface ICorDebugModule : IUnknown
{
    HRESULT GetProcess([out] ICorDebugProcess **ppProcess);
    HRESULT GetBaseAddress([out] CORDB_ADDRESS *pAddress);
    HRESULT GetName(
        [in] ULONG32 cchName,
        [out] ULONG32 *pcchName,
        [out, size_is(cchName), length_is(*pcchName)] WCHAR szName[]);
    HRESULT SetName([in] WCHAR *name);
    HRESULT GetUnknown([out] IUnknown **value);
    HRESULT GetMetaDataInterface([in] REFIID riid, [out] IUnknown **ppObj);
    HRESULT GetDynamic([in] REFIID riid, [out, iid_is(riid)] void **value);
    HRESULT SetStream([in] IStream *value);
    HRESULT GetImplicitOutput(ICorDebugProcess **value);
    HRESULT GetImplicitScalar(ULONG32 *value);
};

[
    object,
    uuid(3d6f5f63-7538-11d3-8d5b-00104b35e7ef),
    pointer_default(unique)
]
interface ICorDebugAppDomain : ICorDebugModule
{
    HRESULT GetToken([in, out] mdToken *token);
};
"""

DATA_IDL = """
typedef enum Values
{
    Zero = 0,
    Negative = -1,
    Shifted = 1 << 4,
    Alias = Shifted,
    HighBit = 0x80000001
} Values;

typedef struct Plain
{
    ULONG32 count;
    UINT64 address;
} Plain;

typedef struct WithInterface
{
    IFoo *value;
    BOOL enabled;
} WithInterface;

[object, uuid(00000000-0000-0000-0000-000000000001)]
interface IFoo : IUnknown
{
    typedef enum LocalEnum { First = 1, Second } LocalEnum;
    typedef struct LocalStruct { ULONG32 value; } LocalStruct;
    HRESULT M([in] LocalEnum value, [out] LocalStruct *result);
};
"""

CALLBACK_IDL = """
[object, uuid(00000000-0000-0000-0000-000000000001)]
interface ICorDebugManagedCallback : IUnknown
{
    HRESULT Breakpoint(
        ICorDebugAppDomain pAppDomain,
        ICorDebugThread pThread,
        ICorDebugBreakpoint pBreakpoint);
    HRESULT Exception(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, BOOL unhandled);
};

[object, uuid(00000000-0000-0000-0000-000000000002)]
interface ICorDebugManagedCallback2 : IUnknown
{
    HRESULT FunctionRemapOpportunity(
        ICorDebugAppDomain pAppDomain,
        ICorDebugThread pThread,
        ICorDebugFunction pOldFunction,
        ICorDebugFunction pNewFunction,
        ULONG32 oldILOffset);
    HRESULT Exception(
        ICorDebugAppDomain pAppDomain,
        ICorDebugThread pThread,
        ICorDebugFrame pFrame,
        ULONG32 nOffset,
        ULONG32 dwEventType,
        ULONG32 dwFlags);
};
"""


class CSharpGeneratorTests(unittest.TestCase):
    def setUp(self) -> None:
        self.midl = parse_string(IDL)
        self.generator = CSharpGenerator(self.midl)

    def generate(self, name: str) -> str:
        interface = next(item for item in self.midl.interfaces if item.name == name)
        return self.generator.generate_interface(interface)

    def test_generates_com_interface_and_preserves_hresult(self) -> None:
        source = self.generate("ICorDebugModule")

        self.assertIn(
            "[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]",
            source,
        )
        self.assertIn('[Guid("DBA2D8C1-E5C5-4069-8C13-10A7C6ABF43D")]', source)
        self.assertIn("public partial interface ICorDebugModule", source)
        self.assertIn("[PreserveSig]\n    int GetProcess(out ICorDebugProcess ppProcess);", source)

    def test_maps_typedefs_pointers_and_sized_arrays(self) -> None:
        source = self.generate("ICorDebugModule")

        self.assertIn("int GetBaseAddress(out CORDB_ADDRESS pAddress);", source)
        self.assertIn(
            "int GetName(uint cchName, out uint pcchName, "
            "[MarshalUsing(CountElementName = nameof(cchName))][Out] char[]? szName);",
            source,
        )
        self.assertIn("int SetName(string name);", source)
        self.assertIn("int GetUnknown(out nint value);", source)
        self.assertIn("int SetStream(nint value);", source)
        self.assertIn("int GetImplicitOutput(out ICorDebugProcess value);", source)
        self.assertIn("int GetImplicitScalar(out uint value);", source)

    def test_generates_unique_marshalling_for_iid_selected_outputs(self) -> None:
        source = self.generate("ICorDebugModule")

        marshalling = (
            "[MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] "
            "out object?"
        )
        self.assertIn(
            f"int GetMetaDataInterface(ref Guid riid, {marshalling} ppObj);",
            source,
        )
        self.assertIn(
            f"int GetDynamic(ref Guid riid, {marshalling} value);",
            source,
        )
        self.assertIn("int GetUnknown(out nint value);", source)

    def test_generates_throwing_string_buffer_extension(self) -> None:
        extensions = dict(self.generator.generate_buffer_extensions())

        source = extensions["CorDebugModuleBufferExtensions"]

        self.assertIn("namespace ICorDebugSharp.Extensions;", source)
        self.assertIn(
            "public static string GetName(this ICorDebugModule instance)", source
        )
        self.assertIn("instance.GetName(0, out var required, null!)", source)
        self.assertIn(
            "instance.GetName(capacity, out var actual, buffer)", source
        )
        self.assertIn("Marshal.ThrowExceptionForHR(hr);", source)
        self.assertIn("return new string(buffer, 0, length);", source)

    def test_generates_throwing_array_buffer_extension(self) -> None:
        midl = parse_string("""
            typedef struct CorDebugEHClause { ULONG32 Flags; } CorDebugEHClause;
            [object, uuid(00000000-0000-0000-0000-000000000001)]
            interface ICorDebugILCode : IUnknown
            {
                HRESULT GetEHClauses(
                    [in] ULONG32 cClauses,
                    [out] ULONG32 *pcClauses,
                    [out, size_is(cClauses), length_is(*pcClauses)]
                    CorDebugEHClause clauses[]);
            };
        """)

        extensions = dict(CSharpGenerator(midl).generate_buffer_extensions())
        source = extensions["CorDebugILCodeBufferExtensions"]

        self.assertIn(
            "public static CorDebugEHClause[] GetEHClauses(", source
        )
        self.assertIn("return [];", source)
        self.assertIn("Array.Resize(ref buffer, checked((int)actual));", source)

    def test_rejects_invalid_iid_selected_output(self) -> None:
        midl = parse_string("""
            [object, uuid(00000000-0000-0000-0000-000000000001)]
            interface IBad : IUnknown
            {
                HRESULT M([out, iid_is(missing)] void **value);
            };
        """)

        with self.assertRaisesRegex(GenerationError, "missing parameter 'missing'"):
            CSharpGenerator(midl).generate_interface(midl.interfaces[0])

    def test_generates_inheritance_and_ref_parameter(self) -> None:
        source = self.generate("ICorDebugAppDomain")

        self.assertIn("[GeneratedComInterface]\n", source)
        self.assertNotIn("StringMarshalling = StringMarshalling.Utf16", source)
        self.assertIn(
            "public partial interface ICorDebugAppDomain : ICorDebugModule", source
        )
        self.assertIn("int GetToken(ref mdToken token);", source)

    def test_generates_metadata_typedef_with_resolved_storage_type(self) -> None:
        source = self.generator.generate_metadata_typedef("mdToken")
        typed_source = self.generator.generate_metadata_typedef("mdTypeDef")

        self.assertIn("public static readonly mdToken Nil = new(0);", source)
        self.assertIn("public uint Value { get; }", source)
        self.assertIn("public bool IsNil => Rid == 0;", source)
        self.assertIn(
            "public static readonly mdTypeDef Nil = new((uint) CorTokenType.mdtTypeDef);",
            typed_source,
        )
        self.assertIn(
            "public static implicit operator mdToken(mdTypeDef value) => new(value.Value);",
            typed_source,
        )
        self.assertNotIn("implicit operator mdToken(mdToken", source)

    def test_generates_preserved_typedef_with_resolved_storage_type(self) -> None:
        source = self.generator.generate_preserved_typedef("CORDB_ADDRESS")

        self.assertIn(
            "public readonly record struct CORDB_ADDRESS(ulong Value);", source
        )

    def test_detects_utf16_through_typedef_chain(self) -> None:
        midl = parse_string("""
            typedef WCHAR WIDE_CHAR;
            typedef WIDE_CHAR NAME_CHAR;
            [object, uuid(00000000-0000-0000-0000-000000000001)]
            interface IWideAlias : IUnknown
            {
                HRESULT GetName([in] ULONG count, [out, size_is(count)] NAME_CHAR value[]);
            };
        """)

        source = CSharpGenerator(midl).generate_interface(midl.interfaces[0])

        self.assertIn(
            "[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]",
            source,
        )

    def test_generates_top_level_and_interface_local_enums(self) -> None:
        generator = CSharpGenerator(parse_string(DATA_IDL))

        values = generator.generate_enum(generator.enums["Values"])
        local = generator.generate_enum(generator.enums["LocalEnum"])

        self.assertIn("Negative = -1", values)
        self.assertIn("Shifted = 1 << 4", values)
        self.assertIn("Alias = Shifted", values)
        self.assertIn("HighBit = unchecked((int)0x80000001)", values)
        self.assertIn("public enum LocalEnum", local)

    def test_generates_plain_and_interface_local_structs(self) -> None:
        generator = CSharpGenerator(parse_string(DATA_IDL))

        plain = generator.generate_struct(generator.structs["Plain"])
        local = generator.generate_struct(generator.structs["LocalStruct"])

        self.assertIn("[StructLayout(LayoutKind.Sequential)]", plain)
        self.assertIn("public uint count;", plain)
        self.assertIn("public ulong address;", plain)
        self.assertIn("public struct LocalStruct", local)

    def test_generates_custom_marshaller_for_interface_struct_fields(self) -> None:
        generator = CSharpGenerator(parse_string(DATA_IDL))

        source = generator.generate_struct(generator.structs["WithInterface"])

        self.assertIn(
            "[NativeMarshalling(typeof(WithInterfaceMarshaller))]", source
        )
        self.assertIn("public IFoo value;", source)
        self.assertIn("public nint value;", source)
        self.assertIn("ComInterfaceMarshaller<IFoo>.ConvertToUnmanaged", source)
        self.assertIn("ComInterfaceMarshaller<IFoo>.ConvertToManaged", source)
        self.assertIn("ComInterfaceMarshaller<IFoo>.Free", source)

    def test_generates_managed_callback_event_dispatcher(self) -> None:
        source = dict(CSharpGenerator(parse_string(CALLBACK_IDL)).generate_managed_callback())["CorDebugManagedCallback"]

        self.assertIn("[GeneratedComClass]", source)
        self.assertIn(
            "public partial class CorDebugManagedCallback : ICorDebugManagedCallback, ICorDebugManagedCallback2",
            source,
        )
        self.assertIn(
            "public event EventHandler<CorDebugManagedCallbackEventArgs>? OnAnyEvent;",
            source,
        )
        self.assertIn(
            "public event EventHandler<BreakpointCorDebugManagedCallbackEventArgs>? OnBreakpoint;",
            source,
        )
        self.assertIn(
            "int ICorDebugManagedCallback2.FunctionRemapOpportunity(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, ICorDebugFunction pOldFunction, ICorDebugFunction pNewFunction, uint oldILOffset) => HandleEvent(OnFunctionRemapOpportunity, new FunctionRemapOpportunityCorDebugManagedCallbackEventArgs(pAppDomain, pThread, pOldFunction, pNewFunction, oldILOffset));",
            source,
        )
        self.assertIn("OnException;", source)
        self.assertIn("OnException2;", source)
        self.assertIn("OnAnyEvent?.Invoke(this, args);", source)
        self.assertIn(
            "public sealed class BreakpointCorDebugManagedCallbackEventArgs",
            source,
        )

    def test_writes_managed_callback_dispatcher(self) -> None:
        midl = parse_string(CALLBACK_IDL)
        with tempfile.TemporaryDirectory() as directory:
            output = Path(directory)

            written, unchanged = write_interfaces(midl, output)

            self.assertEqual((3, 0), (written, unchanged))
            self.assertTrue((output / "CorDebugManagedCallback.cs").exists())

    def test_writes_one_file_per_interface_without_deleting_other_files(self) -> None:
        with tempfile.TemporaryDirectory() as directory:
            output = Path(directory)
            unrelated = output / "Unrelated.cs"
            unrelated.write_text("keep", encoding="utf-8")

            written, unchanged = write_interfaces(self.midl, output)
            second_written, second_unchanged = write_interfaces(self.midl, output)

            declaration_count = (
                2
                + len(self.generator.metadata_typedefs)
                + len(self.generator.preserved_typedefs)
            )
            self.assertEqual((declaration_count, 0), (written, unchanged))
            self.assertEqual((0, declaration_count), (second_written, second_unchanged))
            self.assertEqual("keep", unrelated.read_text(encoding="utf-8"))
            self.assertTrue((output / "mdToken.cs").exists())
            self.assertFalse(
                (output / "Extensions" / "CorDebugModuleBufferExtensions.cs").exists()
            )

    def test_writes_every_declaration(self) -> None:
        midl = parse_string(DATA_IDL)
        with tempfile.TemporaryDirectory() as directory:
            output = Path(directory)

            written, unchanged = write_interfaces(midl, output)

            self.assertEqual((6, 0), (written, unchanged))
            self.assertTrue((output / "IFoo.cs").exists())
            self.assertTrue((output / "Values.cs").exists())
            self.assertTrue((output / "LocalEnum.cs").exists())
            self.assertTrue((output / "Plain.cs").exists())
            self.assertTrue((output / "WithInterface.cs").exists())
            self.assertTrue((output / "LocalStruct.cs").exists())

    def test_rejects_unsupported_array_size_expression(self) -> None:
        midl = parse_string("""
            [object, uuid(00000000-0000-0000-0000-000000000001)]
            interface IBad : IUnknown
            {
                HRESULT M([in] ULONG count, [in, size_is(count + 1)] BYTE values[]);
            };
        """)

        with self.assertRaisesRegex(GenerationError, "unsupported size_is expression"):
            CSharpGenerator(midl).generate_interface(midl.interfaces[0])

    def test_normalizes_valid_midl_forms_dropped_by_parser(self) -> None:
        source = """
            [object, uuid(00000000-0000-0000-0000-000000000001)]
            interface ILocalTypes : IUnknown
            {
                typedef struct RANGE
                {
                    ULONG32 start, end;
                } RANGE;
                HRESULT M([in] RANGE value);
            };
            [object, uuid(00000000-0000-0000-0000-000000000002)]
            interface IAdjacentAttributes : IUnknown
            {
                HRESULT M([out][iid_is(id)] void **value);
            };
        """
        with tempfile.TemporaryDirectory() as directory:
            path = Path(directory) / "input.idl"
            path.write_text(source, encoding="utf-8")

            midl = parse_midl_file(path)

        self.assertEqual(
            ["ILocalTypes", "IAdjacentAttributes"],
            [interface.name for interface in midl.interfaces],
        )


if __name__ == "__main__":
    unittest.main()
