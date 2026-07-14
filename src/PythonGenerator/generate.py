from midl_classic import parse_file, parse_string

# Parse an IDL file
midl = parse_file("C:/src/dotnet/src/runtime/src/coreclr/inc/cordebug.idl")

# Or parse from a string
# midl = parse_string('''
#     typedef enum Color { RED = 0, GREEN = 1, BLUE = 2 } COLOR;
# ''')

# Access parsed elements by type
for iface in midl.interfaces:
    print(f"Interface: {iface.name} (UUID: {iface.uuid})")
    for method in iface.methods:
        print(f"  {method.return_type.format()} {method.name}()")
        for param in method.params:
            print(f"    [{param.direction_str()}] {param.type_spec.format()} {param.name}")

for enum in midl.enums:
    print(f"Enum: {enum.name} ({len(enum.members)} values)")

for struct in midl.structs:
    print(f"Struct: {struct.name} ({len(struct.members)} fields)")