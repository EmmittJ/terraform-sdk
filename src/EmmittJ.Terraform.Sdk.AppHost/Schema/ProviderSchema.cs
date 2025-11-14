using System.Text.Json.Serialization;

namespace EmmittJ.Terraform.Sdk.AppHost.Schema;

/// <summary>
/// Root schema representation as defined in the Terraform provider schema specification.
/// See: https://developer.hashicorp.com/terraform/cli/commands/providers/schema
/// </summary>
public class ProviderSchemaRoot
{
    [JsonPropertyName("format_version")]
    public string FormatVersion { get; set; } = string.Empty;

    [JsonPropertyName("provider_schemas")]
    public Dictionary<string, ProviderSchema> ProviderSchemas { get; set; } = new();
}

/// <summary>
/// Provider schema containing resource schemas, data source schemas, and function definitions.
/// See: https://developer.hashicorp.com/terraform/cli/commands/providers/schema#providers-schema-representation
/// </summary>
public class ProviderSchema
{
    [JsonPropertyName("provider")]
    public ResourceSchema? Provider { get; set; }

    [JsonPropertyName("resource_schemas")]
    public Dictionary<string, ResourceSchema> ResourceSchemas { get; set; } = new();

    [JsonPropertyName("data_source_schemas")]
    public Dictionary<string, ResourceSchema> DataSourceSchemas { get; set; } = new();

    [JsonPropertyName("ephemeral_resource_schemas")]
    public Dictionary<string, ResourceSchema> EphemeralResourceSchemas { get; set; } = new();

    [JsonPropertyName("functions")]
    public Dictionary<string, FunctionSchema> Functions { get; set; } = new();
}

/// <summary>
/// Schema representation pairing a provider or resource schema with its version.
/// See: https://developer.hashicorp.com/terraform/cli/commands/providers/schema#schema-representation
/// </summary>
public class ResourceSchema
{
    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("block")]
    public SchemaBlock Block { get; set; } = new();
}

/// <summary>
/// Block representation containing attributes and nested block types.
/// See: https://developer.hashicorp.com/terraform/cli/commands/providers/schema#block-representation
/// </summary>
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

/// <summary>
/// Attribute definition within a block.
/// See: https://developer.hashicorp.com/terraform/cli/commands/providers/schema#block-representation
/// </summary>
public class SchemaAttribute
{
    [JsonPropertyName("type")]
    public object? Type { get; set; }

    [JsonPropertyName("nested_type")]
    public SchemaNestedType? NestedType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("description_kind")]
    public string? DescriptionKind { get; set; }

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

/// <summary>
/// Nested type definition for attributes with complex structures.
/// See: https://developer.hashicorp.com/terraform/plugin/framework/handling-data/attributes#nested-attribute-types
/// </summary>
public class SchemaNestedType
{
    [JsonPropertyName("nesting_mode")]
    public string NestingMode { get; set; } = string.Empty;

    [JsonPropertyName("attributes")]
    public Dictionary<string, SchemaAttribute> Attributes { get; set; } = new();

    [JsonPropertyName("min_items")]
    public int? MinItems { get; set; }

    [JsonPropertyName("max_items")]
    public int? MaxItems { get; set; }
}

/// <summary>
/// Nested block type definition with nesting mode (single, list, set, map).
/// See: https://developer.hashicorp.com/terraform/cli/commands/providers/schema#block-representation
/// </summary>
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

/// <summary>
/// Function definition including parameters, return type, and documentation.
/// See: https://developer.hashicorp.com/terraform/cli/commands/providers/schema#function-representation
/// </summary>
public class FunctionSchema
{
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("deprecation_message")]
    public string? DeprecationMessage { get; set; }

    [JsonPropertyName("return_type")]
    public object? ReturnType { get; set; }

    [JsonPropertyName("parameters")]
    public List<ParameterSchema> Parameters { get; set; } = new();

    [JsonPropertyName("variadic_parameter")]
    public ParameterSchema? VariadicParameter { get; set; }
}

/// <summary>
/// Parameter definition for function signatures.
/// See: https://developer.hashicorp.com/terraform/cli/commands/providers/schema#parameter-representation
/// </summary>
public class ParameterSchema
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("is_nullable")]
    public bool IsNullable { get; set; }

    [JsonPropertyName("type")]
    public object? Type { get; set; }
}
