namespace ICorDebugSharp;

public struct HCorEnum
{
	private nint hEnum;

	public readonly bool IsNull => hEnum == 0;
}
