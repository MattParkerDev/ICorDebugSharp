using System.Runtime.InteropServices.Marshalling;
using ICorDebugSharp.GeneratedMetadata;

namespace ICorDebugSharp;

[NativeMarshalling(typeof(TokenMarshaller))]
public readonly record struct Token(int Value)
{
	public static readonly Token Nil = new Token(0x06000000);

    public int Value { get; } = Value;

    public CorTokenType Type => (CorTokenType) (Value & 0xFF000000);
    public int Rid => Value & 0xFFFFFF;
    public bool IsNil => Rid == 0;


}

[CustomMarshaller(typeof(Token), MarshalMode.Default, typeof(TokenMarshaller))]
internal static class TokenMarshaller
{
	public static int ConvertToUnmanaged(Token managed) => managed.Value;
	public static Token ConvertToManaged(int unmanaged) => new(unmanaged);
}
