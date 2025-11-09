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
    public List<PropertyModel> ConfigurationAttributes { get; set; } = new();
}

public class ResourceModel
{
    public required string Name { get; set; }
    public required string TerraformType { get; set; }
    public required string ClassName { get; set; }
    public required string Description { get; set; }
    public List<PropertyModel> Properties { get; set; } = new();
    public List<PropertyModel> OutputAttributes { get; set; } = new();
    public List<BlockTypeModel> BlockTypes { get; set; } = new();
    public bool IsDeprecated { get; set; }
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
}

public class BlockTypeModel
{
    public required string Name { get; set; }
    public required string TerraformName { get; set; }
    public required string ClassName { get; set; }
    public required string NestingMode { get; set; }
    public List<PropertyModel> Properties { get; set; } = new();
    public int? MinItems { get; set; }
    public int? MaxItems { get; set; }

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
