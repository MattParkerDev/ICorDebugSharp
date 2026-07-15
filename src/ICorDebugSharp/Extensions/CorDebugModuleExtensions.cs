
namespace ICorDebugSharp.Extensions;

public static class CorDebugModuleManualExtensions
{
	public static T GetMetaDataInterface<T>(this ICorDebugModule module) where T : class
	{
		var result = TryGetMetaDataInterface(module, out T? metadata);
		if (result < 0 || metadata is null)
		{
			throw new InvalidOperationException($"Failed to get metadata interface of type {typeof(T).FullName} from module {module.Name}. HRESULT: 0x{result:X8}");
		}
		return metadata;
	}

	public static int TryGetMetaDataInterface<T>(this ICorDebugModule module, out T? metadata) where T : class
	{
		var iid = typeof(T).GUID;
		var hr = module.GetMetaDataInterface(ref iid, out var value);

		metadata = hr >= 0 ? (T?)value : null;
		return hr;
	}
}
