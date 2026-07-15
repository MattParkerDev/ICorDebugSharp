from __future__ import annotations

import argparse
import re
import uuid
from pathlib import Path

from midl_classic import (
    BinaryOp,
    EnumDef,
    FloatLiteral,
    IdentifierRef,
    IntegerLiteral,
    InterfaceDef,
    Method,
    MethodParam,
    MidlFile,
    ParenExpr,
    StringLiteral,
    StructDef,
    StructField,
    TypeSpec,
    UnaryOp,
    parse_string,
)


DEFAULT_NAMESPACE = "ICorDebugSharp"
EXTENSIONS_NAMESPACE = "ICorDebugSharp.Extensions"

# size_is describes marshalling, but not whether a method supports a null/zero
# size probe. Only methods with a documented query/fill contract belong here.
# Values are (kind, capacity parameter, count parameter, buffer parameter).
QUERY_BUFFER_METHODS = {
    ("ICorDebugStaticFieldSymbol", "GetName"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugInstanceFieldSymbol", "GetName"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugVariableSymbol", "GetName"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugMergedAssemblyRecord", "GetSimpleName"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugMergedAssemblyRecord", "GetCulture"): ("string", "cchCulture", "pcchCulture", "szCulture"),
    ("ICorDebugDataTarget2", "GetImageLocation"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugLoadedModule", "GetName"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugRemoteTarget", "GetHostName"): ("string", "cchHostName", "pcchHostName", "szHostName"),
    ("ICorDebugAppDomain", "GetName"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugAssembly", "GetCodeBase"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugAssembly", "GetName"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugModule", "GetName"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugStringValue", "GetString"): ("string", "cchString", "pcchString", "szString"),
    ("ICorDebugMDA", "GetName"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugMDA", "GetDescription"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugMDA", "GetXML"): ("string", "cchName", "pcchName", "szName"),
    ("ICorDebugEditAndContinueErrorInfo", "GetString"): ("string", "cchString", "pcchString", "szString"),
    ("ICorDebugThread2", "GetActiveFunctions"): ("array", "cFunctions", "pcFunctions", "pFunctions"),
    ("ICorDebugCode", "GetILToNativeMapping"): ("array", "cMap", "pcMap", "map"),
    ("ICorDebugCode2", "GetCodeChunks"): ("array", "cbufSize", "pcnumChunks", "chunks"),
    ("ICorDebugILCode", "GetEHClauses"): ("array", "cClauses", "pcClauses", "clauses"),
    ("ICorDebugILCode2", "GetInstrumentedILMap"): ("array", "cMap", "pcMap", "map"),
    ("ICorDebugComObjectValue", "GetCachedInterfacePointers"): ("array", "celt", "pcEltFetched", "ptrs"),
}

CSHARP_KEYWORDS = {
    "base", "bool", "break", "byte", "case", "catch", "char", "checked",
    "class", "const", "continue", "decimal", "default", "delegate", "do",
    "double", "else", "enum", "event", "explicit", "extern", "false",
    "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit",
    "in", "int", "interface", "internal", "is", "lock", "long", "namespace",
    "new", "null", "object", "operator", "out", "override", "params", "private",
    "protected", "public", "readonly", "ref", "return", "sbyte", "sealed",
    "short", "sizeof", "stackalloc", "static", "string", "struct", "switch",
    "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked",
    "unsafe", "ushort", "using", "virtual", "void", "volatile", "while",
}

PRIMITIVE_TYPES = {
    "BOOL": "int",
    "BOOLEAN": "byte",
    "BYTE": "byte",
    "CHAR": "sbyte",
    "DOUBLE": "double",
    "DWORD": "uint",
    "FLOAT": "float",
    "HRESULT": "int",
    "INT": "int",
    "INT16": "short",
    "INT32": "int",
    "INT64": "long",
    "LONG": "int",
    "LONG32": "int",
    "LONG64": "long",
    "SHORT": "short",
    "SIZE_T": "nuint",
    "SSIZE_T": "nint",
    "UCHAR": "byte",
    "UINT": "uint",
    "UINT16": "ushort",
    "UINT32": "uint",
    "UINT64": "ulong",
    "UINT_PTR": "nuint",
    "ULONG": "uint",
    "ULONG32": "uint",
    "ULONG64": "ulong",
    "USHORT": "ushort",
    "WCHAR": "char",
    "void": "void",
}

# These aliases are pointer-shaped or are intentionally projected differently
# from their parser-visible typedef target.
SPECIAL_TYPES = {
    "GUID": "Guid",
    "HPROCESS": "nint",
    "HTHREAD": "nint",
    "IStream": "nint",
    "IUnknown": "nint",
    "LPCVOID": "nint",
    "LPCWSTR": "string",
    "LPDEBUG_EVENT": "nint",
    "LPPROCESS_INFORMATION": "nint",
    "LPSECURITY_ATTRIBUTES": "nint",
    "LPSTARTUPINFOW": "nint",
    "LPVOID": "nint",
    "LPWSTR": "string",
    "PCCOR_SIGNATURE": "nuint",
    "PVOID": "nint",
    "REFIID": "Guid",
}

IID_SELECTED_OUTPUT_OVERRIDES = {
    ("ICorDebugModule", "GetMetaDataInterface", "ppObj"): "riid",
}

IDENTIFIER_RE = re.compile(r"^[A-Za-z_][A-Za-z0-9_]*$")
NAMESPACE_RE = re.compile(r"^[A-Za-z_][A-Za-z0-9_]*(?:\.[A-Za-z_][A-Za-z0-9_]*)*$")
METADATA_TYPEDEF_RE = re.compile(r"^md[A-Z][A-Za-z0-9_]*$")
METADATA_TOKEN_TYPES = {
    "mdModule": "mdtModule",
    "mdTypeRef": "mdtTypeRef",
    "mdTypeDef": "mdtTypeDef",
    "mdFieldDef": "mdtFieldDef",
    "mdMethodDef": "mdtMethodDef",
    "mdParamDef": "mdtParamDef",
    "mdInterfaceImpl": "mdtInterfaceImpl",
    "mdMemberRef": "mdtMemberRef",
    "mdCustomAttribute": "mdtCustomAttribute",
    "mdPermission": "mdtPermission",
    "mdSignature": "mdtSignature",
    "mdEvent": "mdtEvent",
    "mdProperty": "mdtProperty",
    "mdModuleRef": "mdtModuleRef",
    "mdTypeSpec": "mdtTypeSpec",
    "mdAssembly": "mdtAssembly",
    "mdAssemblyRef": "mdtAssemblyRef",
    "mdFile": "mdtFile",
    "mdExportedType": "mdtExportedType",
    "mdManifestResource": "mdtManifestResource",
    "mdGenericParam": "mdtGenericParam",
    "mdMethodSpec": "mdtMethodSpec",
    "mdGenericParamConstraint": "mdtGenericParamConstraint",
    "mdString": "mdtString",
}
GENERIC_METADATA_TOKENS = {"mdToken", "mdSourceFile", "mdCPToken"}
PRESERVED_TYPEDEFS = {"CORDB_ADDRESS"}
INTERFACE_DEFINITION_RE = re.compile(
    r"\binterface\s+([A-Za-z_]\w*)\s*:\s*[A-Za-z_]\w*"
)
COMMA_FIELD_RE = re.compile(
    r"(?m)^(\s*)([A-Za-z_]\w*(?:\s*\*)?)\s+([A-Za-z_]\w*)\s*,\s*([A-Za-z_]\w*)\s*;"
)


class GenerationError(ValueError):
    pass


def parse_midl_file(path: Path) -> MidlFile:
    source = path.read_text(encoding="utf-8-sig")

    # midl-classic 0.1.0 recovers by dropping the containing interface for
    # these valid MIDL forms. Normalize them until the parser handles them.
    normalized = re.sub(r"\]\s*\[", ", ", source)
    normalized = COMMA_FIELD_RE.sub(r"\1\2 \3;\n\1\2 \4;", normalized)
    midl = parse_string(normalized, filename=str(path))

    without_comments = re.sub(r"/\*.*?\*/|//[^\r\n]*", "", source, flags=re.DOTALL)
    expected = set(INTERFACE_DEFINITION_RE.findall(without_comments))
    actual = {interface.name for interface in midl.interfaces}
    missing = sorted(expected - actual)
    if missing:
        raise GenerationError(
            "MIDL parser omitted interface definitions: " + ", ".join(missing)
        )

    return midl


class CSharpGenerator:
    def __init__(self, midl: MidlFile, namespace: str = DEFAULT_NAMESPACE) -> None:
        if not NAMESPACE_RE.fullmatch(namespace):
            raise GenerationError(f"Invalid C# namespace: {namespace!r}")

        self.midl = midl
        self.namespace = namespace
        self.interfaces = {interface.name for interface in midl.interfaces}
        self.enums = self.collect_declarations(EnumDef, midl.enums)
        self.structs = self.collect_declarations(StructDef, midl.structs)
        self.named_types = {*self.enums, *self.structs, *(union.name for union in midl.unions)}
        self.aliases = {alias.name: alias for alias in midl.typedefs}
        self.metadata_typedefs = {
            name: alias.type_spec.base_name
            for name, alias in self.aliases.items()
            if METADATA_TYPEDEF_RE.fullmatch(name)
        }
        if "mdToken" in self.metadata_typedefs:
            for name in {*METADATA_TOKEN_TYPES, *GENERIC_METADATA_TOKENS}:
                self.metadata_typedefs.setdefault(name, "UINT32")
        self.preserved_typedefs = {
            name: self.aliases[name].type_spec.base_name
            for name in PRESERVED_TYPEDEFS
            if name in self.aliases
        }

    def collect_declarations(self, declaration_type: type, top_level: list) -> dict:
        declarations = {declaration.name: declaration for declaration in top_level}
        for interface in self.midl.interfaces:
            for interface_typedef in interface.typedefs:
                declaration = interface_typedef.typedef
                if not isinstance(declaration, declaration_type):
                    continue
                if declaration.name in declarations:
                    raise GenerationError(
                        f"Duplicate {declaration_type.__name__} declaration: {declaration.name}"
                    )
                declarations[declaration.name] = declaration
        return declarations

    def generate_interface(self, interface: InterfaceDef) -> str:
        if not interface.uuid:
            raise GenerationError(f"Interface {interface.name} has no UUID")

        try:
            guid = str(uuid.UUID(interface.uuid)).upper()
        except ValueError as error:
            raise GenerationError(
                f"Interface {interface.name} has invalid UUID {interface.uuid!r}"
            ) from error

        parent = ""
        if interface.parent and interface.parent != "IUnknown":
            parent = f" : {self.escape_identifier(interface.parent)}"

        methods = "\n\n".join(self.generate_method(interface, method) for method in interface.methods)
        if methods:
            methods = f"\n{methods}\n"
        else:
            methods = "\n"

        generated_com_interface = "[GeneratedComInterface]"
        if self.interface_uses_utf16(interface):
            generated_com_interface = (
                "[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]"
            )
        return (
            "// <auto-generated />\n"
            "#nullable enable\n"
            "using System;\n"
            "using System.Runtime.InteropServices;\n"
            "using System.Runtime.InteropServices.Marshalling;\n\n"
            f"namespace {self.namespace};\n\n"
            f"{generated_com_interface}\n"
            "[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]\n"
            f"[Guid(\"{guid}\")]\n"
            f"public partial interface {self.escape_identifier(interface.name)}{parent}\n"
            "{"
            f"{methods}"
            "}\n"
        )

    def generate_buffer_extensions(self) -> list[tuple[str, str]]:
        generated: list[tuple[str, str]] = []
        for interface in self.midl.interfaces:
            methods = [
                method
                for method in interface.methods
                if (interface.name, method.name) in QUERY_BUFFER_METHODS
            ]
            if not methods:
                continue

            class_name = f"{interface.name.removeprefix('I')}BufferExtensions"
            method_text = "\n\n".join(
                self.generate_buffer_extension(interface, method) for method in methods
            )
            source = (
                "// <auto-generated />\n"
                "#nullable enable\n"
                "using System;\n"
                "using System.Runtime.InteropServices;\n"
                f"using {self.namespace};\n\n"
                f"namespace {EXTENSIONS_NAMESPACE};\n\n"
                f"public static class {class_name}\n"
                "{\n"
                f"{method_text}\n"
                "}\n"
            )
            generated.append((class_name, source))
        return generated

    def generate_buffer_extension(self, interface: InterfaceDef, method: Method) -> str:
        kind, capacity_name, count_name, buffer_name = QUERY_BUFFER_METHODS[
            (interface.name, method.name)
        ]
        parameters = {parameter.name: parameter for parameter in method.params}
        try:
            count = parameters[count_name]
            buffer = parameters[buffer_name]
            parameters[capacity_name]
        except KeyError as error:
            raise GenerationError(
                f"{interface.name}.{method.name} query-buffer projection references "
                f"missing parameter {error.args[0]!r}"
            ) from error

        expected_size = (buffer.size_is or "").strip().lstrip("*")
        expected_length = (buffer.length_is or "").strip().lstrip("*")
        if (
            expected_size != capacity_name
            or expected_length != count_name
            or not buffer.is_out
            or not count.type_spec.is_pointer
        ):
            raise self.parameter_error(
                interface,
                method.name,
                buffer,
                "query-buffer projection does not match size/count metadata",
            )

        retained = [
            parameter
            for parameter in method.params
            if parameter.name not in {capacity_name, count_name, buffer_name}
        ]
        extension_parameters = []
        for parameter in retained:
            if parameter.type_spec.is_pointer or parameter.array_dimensions or parameter.is_out:
                raise self.parameter_error(
                    interface,
                    method.name,
                    parameter,
                    "query-buffer extensions only support retained scalar inputs",
                )
            extension_parameters.append(
                f"{self.map_type(parameter.type_spec)} {self.escape_identifier(parameter.name)}"
            )

        element_type = self.map_type(buffer.type_spec)
        if kind == "string":
            if element_type != "char":
                raise self.parameter_error(
                    interface,
                    method.name,
                    buffer,
                    "string query buffer must contain WCHAR elements",
                )
            return_type = "string"
            result = (
                "            var length = checked((int)actual);\n"
                "            if (length > 0 && buffer[length - 1] == '\\0')\n"
                "                length--;\n\n"
                "            return new string(buffer, 0, length);"
            )
            empty_result = "string.Empty"
        elif kind == "array":
            return_type = f"{element_type}[]"
            result = (
                "            if (actual != capacity)\n"
                "                Array.Resize(ref buffer, checked((int)actual));\n\n"
                "            return buffer;"
            )
            empty_result = "[]"
        else:
            raise GenerationError(
                f"{interface.name}.{method.name} has unknown query-buffer kind {kind!r}"
            )

        signature_tail = "" if not extension_parameters else ", " + ", ".join(extension_parameters)
        first_arguments = self.generate_buffer_call_arguments(
            method, retained, capacity_name, count_name, buffer_name, "0", "required", "null!"
        )
        second_arguments = self.generate_buffer_call_arguments(
            method,
            retained,
            capacity_name,
            count_name,
            buffer_name,
            "capacity",
            "actual",
            "buffer",
        )
        return (
            f"    public static {return_type} {self.escape_identifier(method.name)}("
            f"this {interface.name} instance{signature_tail})\n"
            "    {\n"
            f"        var hr = instance.{self.escape_identifier(method.name)}({first_arguments});\n"
            "        Marshal.ThrowExceptionForHR(hr);\n"
            "        if (required == 0)\n"
            f"            return {empty_result};\n\n"
            "        for (var attempt = 0; attempt < 3; attempt++)\n"
            "        {\n"
            "            var capacity = required;\n"
            f"            var buffer = new {element_type}[checked((int)capacity)];\n"
            f"            hr = instance.{self.escape_identifier(method.name)}({second_arguments});\n"
            "            Marshal.ThrowExceptionForHR(hr);\n"
            "            if (actual > capacity)\n"
            "            {\n"
            "                required = actual;\n"
            "                continue;\n"
            "            }\n\n"
            f"{result}\n"
            "        }\n\n"
            "        throw new InvalidOperationException(\"Native buffer size did not stabilize.\");\n"
            "    }"
        )

    def generate_buffer_call_arguments(
        self,
        method: Method,
        retained: list[MethodParam],
        capacity_name: str,
        count_name: str,
        buffer_name: str,
        capacity_value: str,
        count_variable: str,
        buffer_value: str,
    ) -> str:
        retained_names = {parameter.name for parameter in retained}
        arguments = []
        for parameter in method.params:
            if parameter.name == capacity_name:
                arguments.append(capacity_value)
            elif parameter.name == count_name:
                arguments.append(f"out var {count_variable}")
            elif parameter.name == buffer_name:
                arguments.append(buffer_value)
            elif parameter.name in retained_names:
                arguments.append(self.escape_identifier(parameter.name))
            else:
                raise GenerationError(
                    f"Unexpected parameter in {method.name} query-buffer projection: "
                    f"{parameter.name!r}"
                )
        return ", ".join(arguments)

    def interface_uses_utf16(self, interface: InterfaceDef) -> bool:
        return any(
            self.type_uses_utf16(parameter.type_spec, set())
            for method in interface.methods
            for parameter in method.params
        )

    def type_uses_utf16(self, type_spec: TypeSpec, resolving: set[str]) -> bool:
        base_name = type_spec.base_name
        if base_name in {"WCHAR", "LPCWSTR", "LPWSTR"}:
            return True

        alias = self.aliases.get(base_name)
        if not alias or base_name in resolving:
            return False

        resolving.add(base_name)
        uses_utf16 = self.type_uses_utf16(alias.type_spec, resolving)
        resolving.remove(base_name)
        return uses_utf16

    def generate_enum(self, enum: EnumDef) -> str:
        members = []
        for member in enum.members:
            value = "" if member.value is None else f" = {self.generate_expression(member.value)}"
            members.append(f"    {self.escape_identifier(member.name)}{value},")

        body = "\n".join(members)
        return (
            "// <auto-generated />\n"
            "#nullable enable\n\n"
            f"namespace {self.namespace};\n\n"
            f"public enum {self.escape_identifier(enum.name)}\n"
            "{\n"
            f"{body}\n"
            "}\n"
        )

    def generate_expression(self, expression: object) -> str:
        if isinstance(expression, IntegerLiteral):
            if expression.value > 0xFFFFFFFF or expression.value < -0x80000000:
                raise GenerationError(f"Enum value is outside 32-bit range: {expression.value}")
            if expression.value > 0x7FFFFFFF:
                return f"unchecked((int)0x{expression.value:X})"
            if expression.base == 16 and expression.value >= 0:
                return f"0x{expression.value:X}"
            return str(expression.value)
        if isinstance(expression, IdentifierRef):
            return self.escape_identifier(expression.name)
        if isinstance(expression, BinaryOp):
            return (
                f"{self.generate_expression(expression.left)} {expression.op} "
                f"{self.generate_expression(expression.right)}"
            )
        if isinstance(expression, UnaryOp):
            return f"{expression.op}{self.generate_expression(expression.operand)}"
        if isinstance(expression, ParenExpr):
            return f"({self.generate_expression(expression.inner)})"
        if isinstance(expression, (FloatLiteral, StringLiteral)):
            raise GenerationError(
                f"Unsupported enum expression: {type(expression).__name__}"
            )
        raise GenerationError(f"Unsupported enum expression: {type(expression).__name__}")

    def generate_struct(self, struct: StructDef) -> str:
        fields = self.get_struct_fields(struct)
        if any(self.is_interface_pointer(field) for field in fields):
            return self.generate_custom_marshaled_struct(struct, fields)
        return self.generate_plain_struct(struct, fields)

    def get_struct_fields(self, struct: StructDef) -> list[StructField]:
        fields: list[StructField] = []
        for member in struct.members:
            if not isinstance(member, StructField):
                raise GenerationError(
                    f"Struct {struct.name} at IDL line {struct.line}: "
                    f"unsupported member {type(member).__name__}"
                )
            if member.array_dimensions:
                raise GenerationError(
                    f"Struct {struct.name}.{member.name} at IDL line {member.line}: "
                    "inline arrays are not supported"
                )
            if member.bitfield_width is not None:
                raise GenerationError(
                    f"Struct {struct.name}.{member.name} at IDL line {member.line}: "
                    "bit fields are not supported"
                )
            fields.append(member)
        return fields

    def generate_plain_struct(self, struct: StructDef, fields: list[StructField]) -> str:
        field_text = "\n\n".join(
            f"    public {self.map_struct_field_type(field, native=True)} "
            f"{self.escape_identifier(field.name)};"
            for field in fields
        )
        return (
            "// <auto-generated />\n"
            "#nullable enable\n"
            "using System;\n"
            "using System.Runtime.InteropServices;\n\n"
            f"namespace {self.namespace};\n\n"
            "[StructLayout(LayoutKind.Sequential)]\n"
            f"public struct {self.escape_identifier(struct.name)}\n"
            "{\n"
            f"{field_text}\n"
            "}\n"
        )

    def generate_custom_marshaled_struct(
        self, struct: StructDef, fields: list[StructField]
    ) -> str:
        marshaller_name = f"{self.to_pascal_case(struct.name)}Marshaller"
        managed_fields = "\n\n".join(
            f"    public {self.map_managed_struct_field_type(struct, field)} "
            f"{self.escape_identifier(field.name)};"
            for field in fields
        )
        native_fields = "\n\n".join(
            f"        public {self.map_struct_field_type(field, native=True)} "
            f"{self.escape_identifier(field.name)};"
            for field in fields
        )
        to_unmanaged = ",\n".join(
            f"            {self.escape_identifier(field.name)} = "
            f"{self.convert_field_to_unmanaged(field)}"
            for field in fields
        )
        to_managed = ",\n".join(
            f"            {self.escape_identifier(field.name)} = "
            f"{self.convert_field_to_managed(struct, field)}"
            for field in fields
        )
        free_statements = "\n".join(
            f"        ComInterfaceMarshaller<{self.map_type(field.type_spec)}>.Free("
            f"(void*)unmanaged.{self.escape_identifier(field.name)});"
            for field in fields
            if self.is_interface_pointer(field)
        )
        return (
            "// <auto-generated />\n"
            "#nullable enable\n"
            "using System;\n"
            "using System.Runtime.InteropServices;\n"
            "using System.Runtime.InteropServices.Marshalling;\n\n"
            f"namespace {self.namespace};\n\n"
            f"[NativeMarshalling(typeof({marshaller_name}))]\n"
            f"public struct {self.escape_identifier(struct.name)}\n"
            "{\n"
            f"{managed_fields}\n"
            "}\n\n"
            f"[CustomMarshaller(typeof({self.escape_identifier(struct.name)}), "
            f"MarshalMode.Default, typeof({marshaller_name}))]\n"
            f"internal static class {marshaller_name}\n"
            "{\n"
            "    [StructLayout(LayoutKind.Sequential)]\n"
            "    internal struct Native\n"
            "    {\n"
            f"{native_fields}\n"
            "    }\n\n"
            f"    public static unsafe Native ConvertToUnmanaged(in {self.escape_identifier(struct.name)} managed)\n"
            "    {\n"
            "        return new Native\n"
            "        {\n"
            f"{to_unmanaged}\n"
            "        };\n"
            "    }\n\n"
            f"    public static unsafe {self.escape_identifier(struct.name)} ConvertToManaged(in Native unmanaged)\n"
            "    {\n"
            f"        return new {self.escape_identifier(struct.name)}\n"
            "        {\n"
            f"{to_managed}\n"
            "        };\n"
            "    }\n\n"
            "    public static unsafe void Free(in Native unmanaged)\n"
            "    {\n"
            f"{free_statements}\n"
            "    }\n"
            "}\n"
        )

    def map_managed_struct_field_type(self, struct: StructDef, field: StructField) -> str:
        csharp_type = self.map_struct_field_type(field, native=False)
        if (struct.name, field.name) == ("COR_GC_REFERENCE", "Domain"):
            csharp_type += "?"
        return csharp_type

    def map_struct_field_type(self, field: StructField, native: bool) -> str:
        if field.type_spec.is_pointer:
            if not native and self.is_interface_pointer(field):
                return self.map_type(field.type_spec)
            return "nint"
        return self.map_type(field.type_spec)

    def convert_field_to_unmanaged(self, field: StructField) -> str:
        name = self.escape_identifier(field.name)
        if not self.is_interface_pointer(field):
            return f"managed.{name}"
        interface_type = self.map_type(field.type_spec)
        return (
            f"(nint)ComInterfaceMarshaller<{interface_type}>."
            f"ConvertToUnmanaged(managed.{name})"
        )

    def convert_field_to_managed(self, struct: StructDef, field: StructField) -> str:
        name = self.escape_identifier(field.name)
        if not self.is_interface_pointer(field):
            return f"unmanaged.{name}"
        interface_type = self.map_type(field.type_spec)
        conversion = (
            f"ComInterfaceMarshaller<{interface_type}>."
            f"ConvertToManaged((void*)unmanaged.{name})"
        )
        if (struct.name, field.name) == ("COR_GC_REFERENCE", "Domain"):
            return conversion
        return (
            f"{conversion} ?? throw new InvalidOperationException("
            f"\"Native {struct.name}.{field.name} was null.\")"
        )

    def is_interface_pointer(self, field: StructField) -> bool:
        return field.type_spec.is_pointer and field.type_spec.base_name in self.interfaces

    @staticmethod
    def to_pascal_case(name: str) -> str:
        if "_" not in name:
            return name
        return "".join(part.title() for part in name.split("_") if part)

    def generate_method(self, interface: InterfaceDef, method: Method) -> str:
        return_type = self.map_type(method.return_type)
        if return_type != "int":
            raise GenerationError(
                f"{interface.name}.{method.name} at IDL line {method.line}: "
                f"expected HRESULT return type, got {method.return_type.format()}"
            )

        parameters = ", ".join(
            self.generate_parameter(interface, method, parameter)
            for parameter in method.params
        )
        return (
            "    [PreserveSig]\n"
            f"    int {self.escape_identifier(method.name)}({parameters});"
        )

    def generate_metadata_typedef(self, name: str) -> str:
        underlying_type = self.map_base_type(
            self.metadata_typedefs[name], {name}, preserve_metadata_typedefs=False
        )
        if underlying_type == "uint":
            token_type = METADATA_TOKEN_TYPES.get(name)
            nil_value = f"(uint) CorTokenType.{token_type}" if token_type else "0"
            conversions = (
                f"    public static implicit operator int({self.escape_identifier(name)} value) => "
                "unchecked((int)value.Value);\n\n"
                f"    public static implicit operator uint({self.escape_identifier(name)} value) => value.Value;\n\n"
            )
            if name != "mdToken":
                conversions += (
                    f"    public static implicit operator mdToken"
                    f"({self.escape_identifier(name)} value) => new(value.Value);\n\n"
                )
            return (
                "// <auto-generated />\n"
                "#nullable enable\n"
                "using System.Runtime.InteropServices;\n"
                "using ICorDebugSharp.GeneratedMetadata;\n\n"
                f"namespace {self.namespace};\n\n"
                "[StructLayout(LayoutKind.Sequential)]\n"
                f"public readonly record struct {self.escape_identifier(name)}\n"
                "{\n"
                f"    public static readonly {self.escape_identifier(name)} Nil = "
                f"new({nil_value});\n\n"
                f"    public {self.escape_identifier(name)}(uint value) => Value = value;\n\n"
                "    /// <summary>Gets the Row ID of the metadata token.</summary>\n"
                "    public int Rid => (int)Value & 0x00FFFFFF;\n\n"
                "    public CorTokenType Type => (CorTokenType)(Value & 0xFF000000);\n\n"
                "    /// <summary>Gets the raw numeric value of the metadata token.</summary>\n"
                "    public uint Value { get; }\n\n"
                f"{conversions}"
                "    public bool IsNil => Rid == 0;\n"
                "}\n"
            )
        return (
            "// <auto-generated />\n"
            "#nullable enable\n"
            "using System.Runtime.InteropServices;\n\n"
            f"namespace {self.namespace};\n\n"
            "[StructLayout(LayoutKind.Sequential)]\n"
            f"public readonly record struct {self.escape_identifier(name)}"
            f"({underlying_type} Value);\n"
        )

    def generate_preserved_typedef(self, name: str) -> str:
        underlying_type = self.map_base_type(
            self.preserved_typedefs[name], {name}, preserve_typedefs=False
        )
        conversion = ""
        if name == "CORDB_ADDRESS":
            conversion = (
                "\n\n"
                "    public static implicit operator int(CORDB_ADDRESS value) => (int)value.Value;"
            )
        return (
            "// <auto-generated />\n"
            "#nullable enable\n"
            "using System.Runtime.InteropServices;\n\n"
            f"namespace {self.namespace};\n\n"
            "[StructLayout(LayoutKind.Sequential)]\n"
            f"public readonly record struct {self.escape_identifier(name)}"
            f"({underlying_type} Value)"
            "\n{"
            f"{conversion}\n"
            "}\n"
        )

    def generate_parameter(
        self, interface: InterfaceDef, method: Method, parameter: MethodParam
    ) -> str:
        if not parameter.name:
            raise GenerationError(
                f"{interface.name}.{method.name} at IDL line {parameter.line}: "
                "unnamed parameters are not supported"
            )

        base_name = parameter.type_spec.base_name
        csharp_type = self.map_type(parameter.type_spec)
        is_array = bool(parameter.array_dimensions) or parameter.size_is is not None
        attributes: list[str] = []
        modifier = ""
        iid_selector = self.get_iid_selector(interface, method, parameter)

        if iid_selector:
            attributes.append("MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))")
            modifier = "out "
            csharp_type = "object?"
        elif is_array:
            if parameter.size_is:
                count_name = parameter.size_is.strip().lstrip("*")
                if not IDENTIFIER_RE.fullmatch(count_name):
                    raise self.parameter_error(
                        interface, method.name, parameter,
                        f"unsupported size_is expression {parameter.size_is!r}",
                    )
                attributes.append(
                    f"MarshalUsing(CountElementName = nameof({self.escape_identifier(count_name)}))"
                )
            if parameter.is_in:
                attributes.append("In")
            if parameter.is_out:
                attributes.append("Out")
            csharp_type += "[]"
        elif base_name in {"LPCWSTR", "LPWSTR"}:
            if parameter.is_out:
                raise self.parameter_error(
                    interface, method.name, parameter,
                    f"output {base_name} requires an explicit buffer size",
                )
        elif base_name == "WCHAR" and parameter.type_spec.is_pointer and parameter.is_in:
            csharp_type = "string"
        elif parameter.type_spec.is_pointer:
            modifier, csharp_type = self.project_pointer(parameter, csharp_type)
        elif base_name == "REFIID":
            modifier = "ref "

        if parameter.is_optional and (is_array or csharp_type in self.interfaces or csharp_type == "string"):
            csharp_type += "?"
        elif self.is_query_buffer(interface, method, parameter):
            csharp_type += "?"

        attribute_text = "" if not attributes else "[" + "][".join(attributes) + "] "
        return (
            f"{attribute_text}{modifier}{csharp_type} "
            f"{self.escape_identifier(parameter.name)}"
        )

    @staticmethod
    def is_query_buffer(
        interface: InterfaceDef, method: Method, parameter: MethodParam
    ) -> bool:
        projection = QUERY_BUFFER_METHODS.get((interface.name, method.name))
        return projection is not None and parameter.name == projection[3]

    def get_iid_selector(
        self, interface: InterfaceDef, method: Method, parameter: MethodParam
    ) -> str | None:
        if not parameter.name:
            return None

        selector = parameter.iid_is or IID_SELECTED_OUTPUT_OVERRIDES.get(
            (interface.name, method.name, parameter.name)
        )
        if not selector:
            return None

        selector = selector.strip()
        if not IDENTIFIER_RE.fullmatch(selector):
            raise self.parameter_error(
                interface,
                method.name,
                parameter,
                f"unsupported iid_is expression {selector!r}",
            )
        if (
            not parameter.is_out
            or parameter.is_in
            or parameter.type_spec.base_name not in {"IUnknown", "void"}
            or parameter.type_spec.pointer_depth != 2
        ):
            raise self.parameter_error(
                interface,
                method.name,
                parameter,
                "IID-selected outputs must be [out] void** or IUnknown**",
            )

        selector_parameter = next(
            (candidate for candidate in method.params if candidate.name == selector),
            None,
        )
        if selector_parameter is None:
            raise self.parameter_error(
                interface,
                method.name,
                parameter,
                f"iid_is references missing parameter {selector!r}",
            )
        if selector_parameter.type_spec.base_name not in {"GUID", "REFIID"}:
            raise self.parameter_error(
                interface,
                method.name,
                parameter,
                f"iid_is parameter {selector!r} is not a GUID or REFIID",
            )

        return selector

    def project_pointer(self, parameter: MethodParam, csharp_type: str) -> tuple[str, str]:
        base_name = parameter.type_spec.base_name
        is_opaque_pointer = base_name == "void" or csharp_type == "nint"
        if is_opaque_pointer:
            csharp_type = "nint"

        if parameter.is_out and not parameter.is_in:
            return "out ", csharp_type
        if parameter.is_in and parameter.is_out:
            return "ref ", csharp_type
        if not parameter.is_in and not parameter.is_out:
            if csharp_type in self.interfaces and parameter.type_spec.pointer_depth == 1:
                return "", csharp_type
            return "out ", csharp_type
        if is_opaque_pointer:
            return "", csharp_type
        if csharp_type in self.interfaces and parameter.type_spec.pointer_depth == 1:
            return "", csharp_type
        if csharp_type == "string":
            return "", csharp_type
        return "ref ", csharp_type

    def map_type(self, type_spec: TypeSpec) -> str:
        return self.map_base_type(type_spec.base_name, set())

    def map_base_type(
        self,
        base_name: str,
        resolving: set[str],
        preserve_metadata_typedefs: bool = True,
        preserve_typedefs: bool = True,
    ) -> str:
        if preserve_metadata_typedefs and base_name in self.metadata_typedefs:
            return self.escape_identifier(base_name)
        if preserve_typedefs and base_name in self.preserved_typedefs:
            return self.escape_identifier(base_name)
        if base_name in SPECIAL_TYPES:
            return SPECIAL_TYPES[base_name]
        if base_name in PRIMITIVE_TYPES:
            return PRIMITIVE_TYPES[base_name]
        if base_name in self.interfaces or base_name in self.named_types:
            return self.escape_identifier(base_name)

        alias = self.aliases.get(base_name)
        if alias:
            if base_name in resolving:
                raise GenerationError(f"Cyclic typedef involving {base_name}")
            resolving.add(base_name)
            mapped = self.map_base_type(
                alias.type_spec.base_name,
                resolving,
                preserve_metadata_typedefs,
                preserve_typedefs,
            )
            resolving.remove(base_name)
            return mapped

        # Imported and cpp_quote-provided declarations are not represented in
        # the AST. Preserve their names so consumers can supply those types.
        return self.escape_identifier(base_name)

    @staticmethod
    def escape_identifier(name: str) -> str:
        if not IDENTIFIER_RE.fullmatch(name):
            raise GenerationError(f"Invalid C# identifier: {name!r}")
        return f"@{name}" if name in CSHARP_KEYWORDS else name

    @staticmethod
    def parameter_error(
        interface: InterfaceDef,
        method_name: str,
        parameter: MethodParam,
        message: str,
    ) -> GenerationError:
        return GenerationError(
            f"{interface.name}.{method_name} parameter {parameter.name!r} "
            f"at IDL line {parameter.line}: {message}"
        )


def write_interfaces(
    midl: MidlFile, output_directory: Path, namespace: str = DEFAULT_NAMESPACE
) -> tuple[int, int]:
    generator = CSharpGenerator(midl, namespace)
    declarations = [
        (interface.name, Path(f"{interface.name}.cs"), generator.generate_interface(interface))
        for interface in midl.interfaces
        if interface.uuid
    ]
    declarations.extend(
        (enum.name, Path(f"{enum.name}.cs"), generator.generate_enum(enum))
        for enum in generator.enums.values()
    )
    declarations.extend(
        (struct.name, Path(f"{struct.name}.cs"), generator.generate_struct(struct))
        for struct in generator.structs.values()
    )
    declarations.extend(
        (name, Path(f"{name}.cs"), generator.generate_metadata_typedef(name))
        for name in generator.metadata_typedefs
    )
    declarations.extend(
        (name, Path(f"{name}.cs"), generator.generate_preserved_typedef(name))
        for name in generator.preserved_typedefs
    )
    names = [name for name, _, _ in declarations]
    duplicates = sorted(name for name in set(names) if names.count(name) > 1)
    if duplicates:
        raise GenerationError(
            "C# declaration name collisions: " + ", ".join(duplicates)
        )

    output_directory.mkdir(parents=True, exist_ok=True)

    written = 0
    unchanged = 0
    for _, relative_path, content in sorted(declarations):
        output_path = output_directory / relative_path
        if output_path.exists() and output_path.read_text(encoding="utf-8") == content:
            unchanged += 1
            continue
        output_path.parent.mkdir(parents=True, exist_ok=True)
        output_path.write_text(content, encoding="utf-8", newline="\n")
        written += 1

    return written, unchanged


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Generate C# GeneratedComInterface declarations from classic MIDL."
    )
    parser.add_argument("idl", type=Path, help="Path to the input IDL file")
    parser.add_argument("output", type=Path, help="Directory for generated .cs files")
    parser.add_argument(
        "--namespace",
        default=DEFAULT_NAMESPACE,
        help=f"C# namespace (default: {DEFAULT_NAMESPACE})",
    )
    return parser.parse_args()


def main() -> int:
    args = parse_args()
    midl = parse_midl_file(args.idl)
    generator = CSharpGenerator(midl, args.namespace)
    written, unchanged = write_interfaces(midl, args.output, args.namespace)
    interface_count = sum(interface.uuid is not None for interface in midl.interfaces)
    declaration_count = (
        interface_count
        + len(generator.enums)
        + len(generator.structs)
        + len(generator.metadata_typedefs)
        + len(generator.preserved_typedefs)
    )
    print(
        f"Generated {declaration_count} declarations in {args.output}: "
        f"{interface_count} interfaces, {len(generator.enums)} enums, "
        f"{len(generator.structs)} structs, "
        f"{len(generator.metadata_typedefs)} metadata typedefs "
        f"and {len(generator.preserved_typedefs)} preserved typedefs "
        f"({written} written, {unchanged} unchanged)."
    )
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
