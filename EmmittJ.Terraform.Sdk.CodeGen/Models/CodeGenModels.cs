namespace EmmittJ.Terraform.Sdk.CodeGen.Models;

public class ProviderConfig
{
    public required string Name { get; set; }
    public required string Namespace { get; set; }
    public required string FolderPath { get; set; }
    public required string Version { get; set; }
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
}
