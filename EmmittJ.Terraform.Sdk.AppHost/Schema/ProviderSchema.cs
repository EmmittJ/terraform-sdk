using System.Text.Json.Serialization;

namespace EmmittJ.Terraform.Sdk.AppHost.Schema;

public class ProviderSchemaRoot
{
    [JsonPropertyName("format_version")]
    public string FormatVersion { get; set; } = string.Empty;

    [JsonPropertyName("provider_schemas")]
    public Dictionary<string, ProviderSchema> ProviderSchemas { get; set; } = new();
}

public class ProviderSchema
{
    [JsonPropertyName("provider")]
    public SchemaBlock? Provider { get; set; }

    [JsonPropertyName("resource_schemas")]
    public Dictionary<string, ResourceSchema> ResourceSchemas { get; set; } = new();

    [JsonPropertyName("data_source_schemas")]
    public Dictionary<string, ResourceSchema> DataSourceSchemas { get; set; } = new();
}

public class ResourceSchema
{
    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("block")]
    public SchemaBlock Block { get; set; } = new();
}

public class SchemaBlock
{
    [JsonPropertyName("attributes")]
    public Dictionary<string, SchemaAttribute> Attributes { get; set; } = new();

    [JsonPropertyName("block_types")]
    public Dictionary<string, SchemaBlockType> BlockTypes { get; set; } = new();

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("description_kind")]
    public string? DescriptionKind { get; set; }

    [JsonPropertyName("deprecated")]
    public bool Deprecated { get; set; }
}

public class SchemaAttribute
{
    [JsonPropertyName("type")]
    public object? Type { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("required")]
    public bool Required { get; set; }

    [JsonPropertyName("optional")]
    public bool Optional { get; set; }

    [JsonPropertyName("computed")]
    public bool Computed { get; set; }

    [JsonPropertyName("sensitive")]
    public bool Sensitive { get; set; }

    [JsonPropertyName("deprecated")]
    public bool Deprecated { get; set; }
}

public class SchemaBlockType
{
    [JsonPropertyName("nesting_mode")]
    public string NestingMode { get; set; } = string.Empty;

    [JsonPropertyName("block")]
    public SchemaBlock Block { get; set; } = new();

    [JsonPropertyName("min_items")]
    public int? MinItems { get; set; }

    [JsonPropertyName("max_items")]
    public int? MaxItems { get; set; }
}
