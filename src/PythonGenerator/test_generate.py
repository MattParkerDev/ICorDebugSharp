import tempfile
import unittest
from pathlib import Path

from midl_classic import parse_string

from generate import CSharpGenerator, GenerationError, parse_midl_file, write_interfaces


IDL = """
typedef UINT32 mdToken;
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

        self.assertIn("int GetBaseAddress(out ulong pAddress);", source)
        self.assertIn(
            "int GetName(uint cchName, out uint pcchName, "
            "[MarshalUsing(CountElementName = nameof(cchName))][Out] char[] szName);",
            source,
        )
        self.assertIn("int SetName(string name);", source)
        self.assertIn("int GetUnknown(out nint value);", source)
        self.assertIn("int GetImplicitOutput(out ICorDebugProcess value);", source)
        self.assertIn("int GetImplicitScalar(out uint value);", source)

    def test_generates_inheritance_and_ref_parameter(self) -> None:
        source = self.generate("ICorDebugAppDomain")

        self.assertIn("[GeneratedComInterface]\n", source)
        self.assertNotIn("StringMarshalling = StringMarshalling.Utf16", source)
        self.assertIn(
            "public partial interface ICorDebugAppDomain : ICorDebugModule", source
        )
        self.assertIn("int GetToken(ref uint token);", source)

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

    def test_writes_one_file_per_interface_without_deleting_other_files(self) -> None:
        with tempfile.TemporaryDirectory() as directory:
            output = Path(directory)
            unrelated = output / "Unrelated.cs"
            unrelated.write_text("keep", encoding="utf-8")

            written, unchanged = write_interfaces(self.midl, output)
            second_written, second_unchanged = write_interfaces(self.midl, output)

            self.assertEqual((2, 0), (written, unchanged))
            self.assertEqual((0, 2), (second_written, second_unchanged))
            self.assertEqual("keep", unrelated.read_text(encoding="utf-8"))

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
