using System.Runtime.InteropServices.Marshalling;

namespace ICorDebugSharp;

[CustomMarshaller(typeof(uint), MarshalMode.Default, typeof(EnumeratorMax1Marshaller))]
internal static class EnumeratorMax1Marshaller
{
	public static uint ConvertToUnmanaged(uint cMax) => Validate(cMax);
	public static uint ConvertToManaged(uint cMax) => Validate(cMax);

	private static uint Validate(uint cMax) => cMax is 1 ? cMax : throw new ArgumentException("Because we decided to make the type of 'uint* rTypeDefs' be 'out Token rTypeDefs', cMax cannot be > 1", nameof(cMax));
}
