namespace EmmittJ.Terraform.Sdk.AppHost.Models;

public class ProviderConfig
{
    public required string Name { get; set; }
    public required string Namespace { get; set; }
    public required string FolderPath { get; set; }
    public required string Version { get; set; }
    public string? Description { get; set; }
    public int ResourceCount { get; set; }
    public int DataSourceCount { get; set; }
    public List<PropertyModel> Arguments { get; set; } = new();
}

public class ResourceModel
{
    public required string Name { get; set; }
    public required string TerraformType { get; set; }
    public required string ClassName { get; set; }
    public required string Description { get; set; }
    public List<PropertyModel> Arguments { get; set; } = new();
    public List<PropertyModel> OutputAttributes { get; set; } = new();
    public List<BlockTypeModel> BlockTypes { get; set; } = new();
    public bool IsDeprecated { get; set; }
    public bool RequiresUnreferencedCode { get; set; }
}

public class PropertyModel
{
    public required string Name { get; set; }
    public required string TerraformName { get; set; }
    public required string CSharpType { get; set; }
    public required string Description { get; set; }
    public bool IsRequired { get; set; }
    public bool IsOptional { get; set; }
    public bool IsComputed { get; set; }
    public bool IsSensitive { get; set; }
    public bool IsDeprecated { get; set; }
    public bool IsCollection { get; set; }
    public bool IsValueType { get; set; }

    /// <summary>
    /// If this property has a nested type structure, this contains the nested struct definition.
    /// </summary>
    public NestedStructModel? NestedStruct { get; set; }
}

/// <summary>
/// Represents a nested struct type within an attribute.
/// </summary>
public class NestedStructModel
{
    public required string ClassName { get; set; }
    public required string NestingMode { get; set; }
    public List<PropertyModel> Properties { get; set; } = new();

    /// <summary>
    /// Gets the C# type for the property based on nesting mode.
    /// </summary>
    public string PropertyType => NestingMode switch
    {
        "single" => ClassName,
        "list" => $"List<{ClassName}>",
        "set" => $"HashSet<{ClassName}>",
        "map" => $"Dictionary<string, {ClassName}>",
        _ => ClassName
    };
}

public class BlockTypeModel
{
    public required string Name { get; set; }
    public required string TerraformName { get; set; }
    public required string ClassName { get; set; }
    public required string NestingMode { get; set; }
    public List<PropertyModel> Arguments { get; set; } = new();
    public int? MinItems { get; set; }
    public int? MaxItems { get; set; }
    public bool IsDeprecated { get; set; }

    /// <summary>
    /// Gets the C# property type based on the nesting mode.
    /// </summary>
    public string BlockPropertyType => NestingMode switch
    {
        "single" => ClassName,
        "list" => $"List<{ClassName}>",
        "set" => $"HashSet<{ClassName}>",
        "map" => $"Dictionary<string, {ClassName}>",
        _ => ClassName
    };
}

public class ProviderFunctionModel
{
    public required string Name { get; set; }
    public required string TerraformName { get; set; }
    public required string ProviderName { get; set; }
    public string? Summary { get; set; }
    public string? Description { get; set; }
    public string? DeprecationMessage { get; set; }
    public string ReturnType { get; set; } = "TerraformExpression";
    public List<FunctionParameterModel> Parameters { get; set; } = new();
    public FunctionParameterModel? VariadicParameter { get; set; }

    /// <summary>
    /// Gets the full Terraform function call name (provider::provider_name::function_name).
    /// </summary>
    public string TerraformFunctionCall => $"provider::{ProviderName}::{TerraformName}";

    /// <summary>
    /// Gets the method signature parameters as a comma-separated string.
    /// </summary>
    public string ParameterList
    {
        get
        {
            var parameters = Parameters.Select(p => $"TerraformExpression {p.Name}").ToList();
            if (VariadicParameter != null)
            {
                parameters.Add($"params TerraformExpression[] {VariadicParameter.Name}");
            }
            return string.Join(", ", parameters);
        }
    }

    /// <summary>
    /// Gets the argument list for passing to the Call method.
    /// </summary>
    public string ArgumentList
    {
        get
        {
            var args = Parameters.Select(p => p.Name).ToList();
            if (VariadicParameter != null)
            {
                args.Add(VariadicParameter.Name);
            }
            return string.Join(", ", args);
        }
    }

    public bool HasParameters => Parameters.Count > 0 || VariadicParameter != null;
}

public class FunctionParameterModel
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool IsNullable { get; set; }
    public string CSharpType { get; set; } = "TerraformExpression";
}
