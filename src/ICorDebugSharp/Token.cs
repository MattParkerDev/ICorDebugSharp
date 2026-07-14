using ICorDebugSharp.GeneratedMetadata;

namespace ICorDebugSharp;

public readonly record struct Token(int Value)
{
	public static readonly Token Nil = new Token(0x06000000);

    public int Value { get; } = Value;

    public CorTokenType Type => (CorTokenType) (Value & 0xFF000000);
    public int Rid => Value & 0xFFFFFF;
    public bool IsNil => Rid == 0;


}
