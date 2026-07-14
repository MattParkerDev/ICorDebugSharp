
namespace ICorDebugSharp.Extensions;

public static class CorDebugModuleExtensions
{
	public static int GetMetaDataInterface<T>(this ICorDebugModule module, out T? metadata) where T : class
	{
		var iid = typeof(T).GUID;
		var hr = module.GetMetaDataInterface(ref iid, out var value);

		metadata = hr >= 0 ? (T?) value : null;
		return hr;
	}
}
