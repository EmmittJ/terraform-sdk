using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace EmmittJ.Terraform.Sdk.SourceGenerators;

/// <summary>
/// Source generator that creates property implementations for Terraform resources.
/// Generates getters that return TerraformReferences and setters that store values.
/// </summary>
[Generator(LanguageNames.CSharp)]
public class TerraformPropertyGenerator : IIncrementalGenerator
{
    private const string TerraformPropertyAttributeName = "TerraformPropertyAttribute";
    private const string TerraformResourceBaseClassName = "TerraformResource";
    private const string TerraformDataSourceBaseClassName = "TerraformDataSource";
    private const string TerraformProviderBaseClassName = "TerraformProvider";
    private const string TerraformBlockBaseClassName = "TerraformBlockBase";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Find all partial classes that could have Terraform properties
        var classDeclarations = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: static (node, _) => IsPartialClassCandidate(node),
                transform: static (ctx, _) => GetSemanticModel(ctx))
            .Where(static item => item is not null);

        // Generate property implementations for each class
        context.RegisterSourceOutput(classDeclarations, static (spc, source) => Execute(spc, source!));
    }

    private static bool IsPartialClassCandidate(SyntaxNode node)
    {
        return node is ClassDeclarationSyntax classDecl
            && classDecl.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword));
    }

    private static ClassToGenerate? GetSemanticModel(GeneratorSyntaxContext context)
    {
        var classDecl = (ClassDeclarationSyntax)context.Node;
        var semanticModel = context.SemanticModel;
        var classSymbol = semanticModel.GetDeclaredSymbol(classDecl);

        if (classSymbol is null)
            return null;

        // Check if class inherits from TerraformResource, TerraformDataSource, or TerraformProvider
        var baseClassName = GetTerraformBaseClass(classSymbol);
        if (baseClassName is null)
            return null;

        // Find all properties with [TerraformProperty] attribute
        var properties = classSymbol.GetMembers()
            .OfType<IPropertySymbol>()
            .Where(p => HasTerraformPropertyAttribute(p))
            .Select(p => new PropertyToGenerate(
                Name: p.Name,
                TerraformName: GetTerraformName(p),
                TypeName: p.Type.ToDisplayString(),
                IsRequired: p.IsRequired,
                IsNullable: p.NullableAnnotation == NullableAnnotation.Annotated,
                HasSet: p.SetMethod is not null))
            .ToImmutableArray();

        if (properties.IsEmpty)
            return null;

        return new ClassToGenerate(
            NamespaceName: classSymbol.ContainingNamespace.ToDisplayString(),
            ClassName: classSymbol.Name,
            BaseClassName: baseClassName,
            Properties: properties);
    }

    private static string? GetTerraformBaseClass(INamedTypeSymbol classSymbol)
    {
        var baseType = classSymbol.BaseType;
        while (baseType is not null)
        {
            if (baseType.Name == TerraformResourceBaseClassName)
                return TerraformResourceBaseClassName;
            if (baseType.Name == TerraformDataSourceBaseClassName)
                return TerraformDataSourceBaseClassName;
            if (baseType.Name == TerraformProviderBaseClassName)
                return TerraformProviderBaseClassName;
            if (baseType.Name == TerraformBlockBaseClassName)
                return TerraformBlockBaseClassName;
            baseType = baseType.BaseType;
        }
        return null;
    }

    private static bool HasTerraformPropertyAttribute(IPropertySymbol property)
    {
        return property.GetAttributes()
            .Any(attr => attr.AttributeClass?.Name == TerraformPropertyAttributeName);
    }

    private static string GetTerraformName(IPropertySymbol property)
    {
        var attribute = property.GetAttributes()
            .FirstOrDefault(attr => attr.AttributeClass?.Name == TerraformPropertyAttributeName);

        if (attribute?.ConstructorArguments.Length > 0)
        {
            var arg = attribute.ConstructorArguments[0];
            if (arg.Value is string name)
                return name;
        }

        // Fallback: use property name in snake_case
        return ToSnakeCase(property.Name);
    }

    private static string ToSnakeCase(string pascalCase)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < pascalCase.Length; i++)
        {
            var c = pascalCase[i];
            if (i > 0 && char.IsUpper(c))
                sb.Append('_');
            sb.Append(char.ToLowerInvariant(c));
        }
        return sb.ToString();
    }

    private static void Execute(SourceProductionContext context, ClassToGenerate classToGenerate)
    {
        var code = GenerateClass(classToGenerate);
        context.AddSource($"{classToGenerate.ClassName}.g.cs", code);
    }

    private static string GenerateClass(ClassToGenerate classInfo)
    {
        var sb = new StringBuilder();

        // File header
        sb.AppendLine("// <auto-generated/>");
        sb.AppendLine("#nullable enable");
        sb.AppendLine();

        // Namespace
        sb.AppendLine($"namespace {classInfo.NamespaceName};");
        sb.AppendLine();

        // Class declaration
        sb.AppendLine($"partial class {classInfo.ClassName}");
        sb.AppendLine("{");

        // Generate each property
        foreach (var property in classInfo.Properties)
        {
            GenerateProperty(sb, property, classInfo.BaseClassName);
        }

        sb.AppendLine("}");

        return sb.ToString();
    }

    private static void GenerateProperty(StringBuilder sb, PropertyToGenerate property, string baseClassName)
    {
        var requiredModifier = property.IsRequired ? "required " : "";

        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// Terraform property: {property.TerraformName}");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    public {requiredModifier}{property.TypeName} {property.Name}");
        sb.AppendLine("    {");

        // Generate getter
        GenerateGetter(sb, property, baseClassName);

        // Generate setter (if property has one)
        if (property.HasSet)
        {
            GenerateSetter(sb, property);
        }

        sb.AppendLine("    }");
        sb.AppendLine();

        // Generate {Property}Value accessor for properties with setters
        // This retrieves the stored value (not the reference)
        if (property.HasSet)
        {
            GenerateValueAccessor(sb, property);
        }
    }

    private static void GenerateGetter(StringBuilder sb, PropertyToGenerate property, string baseClassName)
    {
        // Determine if getter should return reference or stored value
        var shouldReturnReference = baseClassName == TerraformResourceBaseClassName ||
                                     baseClassName == TerraformDataSourceBaseClassName;

        var innerType = GetGenericTypeArgument(property.TypeName);

        if (shouldReturnReference)
        {
            // Resources & Data Sources: Getter ALWAYS returns a reference
            // This is the key to natural Terraform syntax
            // When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
            // The value that was SET is only used during serialization
            sb.AppendLine($"        get => new EmmittJ.Terraform.Sdk.TerraformReference<{innerType}>(this, \"{property.TerraformName}\");");
        }
        else
        {
            // Providers & Blocks: Getter returns stored value
            // Providers are not referenced in HCL
            // Blocks are used inline, not referenced
            if (property.IsRequired)
            {
                sb.AppendLine($"        get => GetRequiredPropertyValue<{property.TypeName}>(\"{property.TerraformName}\");");
            }
            else
            {
                sb.AppendLine($"        get => GetPropertyValue<{property.TypeName}>(\"{property.TerraformName}\");");
            }
        }
    }

    private static void GenerateSetter(StringBuilder sb, PropertyToGenerate property)
    {
        // Setter stores the value for serialization
        sb.AppendLine($"        set => SetPropertyValue(\"{property.TerraformName}\", value);");
    }

    private static void GenerateValueAccessor(StringBuilder sb, PropertyToGenerate property)
    {
        // Generate {Property}Value accessor to retrieve the stored value
        // This is useful for inspection/debugging, but most code will use the main property
        // which returns a reference for resources/data sources
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// Gets the stored value for {property.Name} (not a reference).");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    public {property.TypeName} {property.Name}Value");
        sb.AppendLine("    {");

        if (property.IsRequired)
        {
            sb.AppendLine($"        get => GetRequiredPropertyValue<{property.TypeName}>(\"{property.TerraformName}\");");
        }
        else
        {
            sb.AppendLine($"        get => GetPropertyValue<{property.TypeName}>(\"{property.TerraformName}\");");
        }

        sb.AppendLine("    }");
        sb.AppendLine();
    }

    private static string GetGenericTypeArgument(string typeName)
    {
        // Extract T from TerraformValue<T>, TerraformList<T>, TerraformMap<T>, etc.
        var startIndex = typeName.IndexOf('<');
        if (startIndex == -1)
            return "object";

        var endIndex = typeName.LastIndexOf('>');
        if (endIndex == -1)
            return "object";

        return typeName.Substring(startIndex + 1, endIndex - startIndex - 1);
    }

    private record ClassToGenerate(
        string NamespaceName,
        string ClassName,
        string BaseClassName,
        ImmutableArray<PropertyToGenerate> Properties);

    private record PropertyToGenerate(
        string Name,
        string TerraformName,
        string TypeName,
        bool IsRequired,
        bool IsNullable,
        bool HasSet);
}
