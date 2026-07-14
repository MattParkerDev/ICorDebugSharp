using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ExtensionGenerator;

internal sealed class ManagedInterfaceCatalog
{
	private readonly Dictionary<string, ManagedInterface> _interfaces;

	private ManagedInterfaceCatalog(Dictionary<string, ManagedInterface> interfaces) => _interfaces = interfaces;

	public static ManagedInterfaceCatalog Load(params string[] directories)
	{
		var interfaces = new Dictionary<string, ManagedInterface>(StringComparer.Ordinal);
		foreach (var path in directories.SelectMany(directory => Directory.EnumerateFiles(directory, "*.cs", SearchOption.TopDirectoryOnly)))
		{
			var root = CSharpSyntaxTree.ParseText(File.ReadAllText(path)).GetCompilationUnitRoot();
			foreach (var declaration in root.DescendantNodes().OfType<InterfaceDeclarationSyntax>())
			{
				if (!declaration.AttributeLists.SelectMany(list => list.Attributes)
					.Any(attribute => attribute.Name.ToString().Contains("GeneratedComInterface", StringComparison.Ordinal)))
					continue;

				var @namespace = declaration.Ancestors().OfType<BaseNamespaceDeclarationSyntax>().FirstOrDefault()?.Name.ToString()
					?? throw new InvalidOperationException($"{path}: {declaration.Identifier.ValueText} has no namespace.");
				var methods = declaration.Members.OfType<MethodDeclarationSyntax>()
					.ToDictionary(method => method.Identifier.ValueText, ManagedMethod.Create, StringComparer.Ordinal);
				var item = new ManagedInterface(declaration.Identifier.ValueText, @namespace, methods);
				if (!interfaces.TryAdd(item.Name, item))
					throw new InvalidOperationException($"Duplicate managed interface {item.Name}.");
			}
		}
		return new ManagedInterfaceCatalog(interfaces);
	}

	public ManagedMethod GetMethod(string interfaceName, string methodName)
	{
		if (!_interfaces.TryGetValue(interfaceName, out var @interface))
			throw new InvalidOperationException($"Generated interface {interfaceName} was not found.");
		if (!@interface.Methods.TryGetValue(methodName, out var method))
			throw new InvalidOperationException($"Generated method {interfaceName}.{methodName} was not found.");
		return method;
	}

	public ManagedInterface GetInterface(string name) =>
		_interfaces.TryGetValue(name, out var value) ? value : throw new InvalidOperationException($"Generated interface {name} was not found.");
}

internal sealed record ManagedInterface(string Name, string Namespace, IReadOnlyDictionary<string, ManagedMethod> Methods);

internal sealed record ManagedMethod(string Name, string ReturnType, IReadOnlyList<ManagedParameter> Parameters)
{
	public static ManagedMethod Create(MethodDeclarationSyntax method) => new(
		method.Identifier.ValueText,
		method.ReturnType.ToString(),
		method.ParameterList.Parameters.Select(ManagedParameter.Create).ToArray());

	public ManagedParameter GetParameter(string name) =>
		Parameters.FirstOrDefault(parameter => parameter.Name == name)
		?? throw new InvalidOperationException($"{Name} has no parameter named {name}.");
}

internal sealed record ManagedParameter(string Name, string Type, bool IsOut, bool IsRef)
{
	public static ManagedParameter Create(ParameterSyntax parameter) => new(
		parameter.Identifier.ValueText,
		parameter.Type?.ToString() ?? throw new InvalidOperationException($"Parameter {parameter.Identifier.ValueText} has no type."),
		parameter.Modifiers.Any(modifier => modifier.IsKind(Microsoft.CodeAnalysis.CSharp.SyntaxKind.OutKeyword)),
		parameter.Modifiers.Any(modifier => modifier.IsKind(Microsoft.CodeAnalysis.CSharp.SyntaxKind.RefKeyword)));
}
