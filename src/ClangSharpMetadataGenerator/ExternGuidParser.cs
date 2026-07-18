using System.Globalization;
using System.Text.RegularExpressions;

namespace MetadataGenerator;

internal static partial class ExternGuidParser
{
	public static IReadOnlyDictionary<string, Guid> ParseInterfaceGuids(string path)
	{
		var source = File.ReadAllText(path);
		var guids = new Dictionary<string, Guid>(StringComparer.Ordinal);

		foreach (Match match in ExternGuidRegex().Matches(source))
		{
			var values = match.Groups["values"].Value
				.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
				.Select(ParseInteger)
				.ToArray();
			if (values.Length != 11)
				throw new InvalidOperationException($"IID_{match.Groups["name"].Value} has {values.Length} components instead of 11.");

			var guid = new Guid(
				unchecked((int)values[0]),
				unchecked((short)values[1]),
				unchecked((short)values[2]),
				values.Skip(3).Select(value => checked((byte)value)).ToArray());
			if (!guids.TryAdd(match.Groups["name"].Value, guid))
				throw new InvalidOperationException($"Duplicate IID declaration for {match.Groups["name"].Value}.");
		}

		return guids;
	}

	private static uint ParseInteger(string value)
	{
		value = value.Trim();
		return value.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
			? uint.Parse(value.AsSpan(2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture)
			: uint.Parse(value, CultureInfo.InvariantCulture);
	}

	[GeneratedRegex(@"EXTERN_GUID\s*\(\s*IID_(?<name>[A-Za-z_]\w*)\s*,(?<values>[^)]*)\)\s*;", RegexOptions.CultureInvariant)]
	private static partial Regex ExternGuidRegex();
}
