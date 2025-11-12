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

        // Check if class has the required property infrastructure methods
        if (!HasRequiredPropertyMethods(classSymbol))
            return null;

        // Determine if this type returns references (has TerraformReference constructor)
        bool shouldReturnReferences = ShouldReturnReferences(classSymbol);

        // Find all properties with [TerraformProperty] attribute that are partial (need implementation)
        var propertiesBuilder = ImmutableArray.CreateBuilder<PropertyToGenerate>();

        foreach (var member in classSymbol.GetMembers().OfType<IPropertySymbol>())
        {
            if (!HasTerraformPropertyAttribute(member))
                continue;

            // Find the corresponding syntax node to check if it's a partial property
            var propertySyntax = member.DeclaringSyntaxReferences
                .Select(r => r.GetSyntax() as PropertyDeclarationSyntax)
                .FirstOrDefault(p => p is not null);

            if (propertySyntax is null)
                continue;

            // Only generate implementation for partial properties (declarations without implementation)
            // C# 13 partial property declaration: "public partial int Foo { get; set; }" - accessors have NO bodies
            // C# 13 partial property implementation: "public partial int Foo { get => ...; set => ...; }" - accessors HAVE bodies
            // auto-property: "public int Foo { get; set; }" - no partial keyword
            bool isPartial = propertySyntax.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword));
            if (!isPartial)
                continue;

            // Check if this is a declaration (no accessor bodies) or implementation (has accessor bodies)
            // Declaration: { get; set; } - accessors have neither Body nor ExpressionBody
            // Implementation: { get => ...; set => ...; } OR { get { ... } set { ... } } - accessors have Body or ExpressionBody
            bool isDeclaration = propertySyntax.AccessorList?.Accessors
                .All(a => a.Body == null && a.ExpressionBody == null) ?? false;

            if (!isDeclaration)
                continue; // Skip if already implemented

            // Check if property has a setter
            bool hasSet = propertySyntax.AccessorList?.Accessors
                .Any(a => a.IsKind(SyntaxKind.SetAccessorDeclaration) || a.IsKind(SyntaxKind.InitAccessorDeclaration)) ?? false;

            // Check if the property type is a TerraformBlock
            bool isBlockType = IsBlockType(member.Type);

            // Check if the property has the 'new' modifier
            bool hasNewModifier = propertySyntax.Modifiers.Any(m => m.IsKind(SyntaxKind.NewKeyword));

            propertiesBuilder.Add(new PropertyToGenerate(
                Name: member.Name,
                TerraformName: GetTerraformName(member),
                TypeName: member.Type.ToDisplayString(),
                IsRequired: member.IsRequired,
                IsNullable: member.NullableAnnotation == NullableAnnotation.Annotated,
                HasSet: hasSet,
                IsBlockType: isBlockType,
                HasNewModifier: hasNewModifier));
        }

        var properties = propertiesBuilder.ToImmutable();

        if (properties.IsEmpty)
            return null;

        return new ClassToGenerate(
            NamespaceName: classSymbol.ContainingNamespace.ToDisplayString(),
            ClassName: classSymbol.Name,
            ShouldReturnReferences: shouldReturnReferences,
            Properties: properties);
    }

    private static bool HasRequiredPropertyMethods(INamedTypeSymbol classSymbol)
    {
        var allMembers = GetAllMembers(classSymbol);

        // Check for GetPropertyValue, GetRequiredPropertyValue, and SetPropertyValue methods
        bool hasGetPropertyValue = allMembers.Any(m =>
            m is IMethodSymbol method &&
            method.Name == "GetPropertyValue" &&
            method.IsGenericMethod);

        bool hasGetRequiredPropertyValue = allMembers.Any(m =>
            m is IMethodSymbol method &&
            method.Name == "GetRequiredPropertyValue" &&
            method.IsGenericMethod);

        bool hasSetPropertyValue = allMembers.Any(m =>
            m is IMethodSymbol method &&
            method.Name == "SetPropertyValue");

        return hasGetPropertyValue && hasGetRequiredPropertyValue && hasSetPropertyValue;
    }

    private static bool ShouldReturnReferences(INamedTypeSymbol classSymbol)
    {
        // Check the inheritance chain
        // Resources, Data Sources, Ephemeral Resources, and Blocks return references from their getters
        // Providers return actual values - they're config that can't be referenced in HCL
        var baseType = classSymbol.BaseType;
        while (baseType is not null)
        {
            var name = baseType.Name;

            // Providers don't return references - they return actual stored values
            // Provider configuration values cannot be referenced in HCL
            // Providers are only used via alias selection (provider = aws.west)
            if (name == "TerraformProvider")
                return false;

            // Resources, DataSources, EphemeralResources, and Blocks return references
            // These can all be referenced in HCL expressions
            if (name == "TerraformResource" ||
                name == "TerraformDataSource" ||
                name == "TerraformEphemeralResource" ||
                name == "TerraformBlock")
                return true;

            baseType = baseType.BaseType;
        }

        // Default to not returning references if we can't determine
        return false;
    }

    private static bool IsBlockType(ITypeSymbol typeSymbol)
    {
        // In Terraform, ALL properties on resources/data sources/blocks return references
        // when accessed in HCL (e.g., azurerm_redis_cache.example.primary_connection_string)
        //
        // The only exception is Providers, which return actual stored values because
        // provider config is not referenced in HCL.
        //
        // This method should return false for everything, meaning "return references"
        // The class-level ShouldReturnReferences already handles the Provider vs Resource distinction

        return false;
    }

    private static IEnumerable<ISymbol> GetAllMembers(INamedTypeSymbol type)
    {
        var current = type;
        while (current is not null)
        {
            foreach (var member in current.GetMembers())
                yield return member;
            current = current.BaseType;
        }
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
            GenerateProperty(sb, property, classInfo.ShouldReturnReferences);
        }

        sb.AppendLine("}");

        return sb.ToString();
    }

    private static void GenerateProperty(StringBuilder sb, PropertyToGenerate property, bool shouldReturnReferences)
    {
        var requiredModifier = property.IsRequired ? "required " : "";
        var newModifier = property.HasNewModifier ? "new " : "";

        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// Terraform property: {property.TerraformName}");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    public {requiredModifier}{newModifier}partial {property.TypeName} {property.Name}");
        sb.AppendLine("    {");

        // Determine if THIS property should return a reference
        // Block properties should return actual values, not references
        bool propertyReturnsReference = shouldReturnReferences && !property.IsBlockType;

        // Generate getter
        GenerateGetter(sb, property, propertyReturnsReference);

        // Generate setter (if property has one)
        if (property.HasSet)
        {
            GenerateSetter(sb, property);
        }

        sb.AppendLine("    }");
        sb.AppendLine();

        // Generate {Property}Value accessor for properties with setters that return references
        // This retrieves the stored value (not the reference)
        if (property.HasSet && propertyReturnsReference)
        {
            GenerateValueAccessor(sb, property);
        }
    }

    private static void GenerateGetter(StringBuilder sb, PropertyToGenerate property, bool shouldReturnReferences)
    {
        var innerType = GetGenericTypeArgument(property.TypeName);

        if (shouldReturnReferences)
        {
            // Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
            // This is the key to natural Terraform syntax
            // When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
            // The value that was SET is only used during serialization
            sb.AppendLine($"        get => new EmmittJ.Terraform.Sdk.TerraformReference<{innerType}>(this, \"{property.TerraformName}\");");
        }
        else
        {
            // Providers: Getter returns stored value
            // Providers are not referenced in HCL
            // Use required getter if property is required or non-nullable
            if (property.IsRequired || !property.IsNullable)
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

        // Use required getter if property is required or non-nullable
        if (property.IsRequired || !property.IsNullable)
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
        bool ShouldReturnReferences,
        ImmutableArray<PropertyToGenerate> Properties);

    private record PropertyToGenerate(
        string Name,
        string TerraformName,
        string TypeName,
        bool IsRequired,
        bool IsNullable,
        bool HasSet,
        bool IsBlockType,
        bool HasNewModifier);
}
