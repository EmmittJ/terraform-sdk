using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for property_definitions in GoogleDocumentAiWarehouseDocumentSchema.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property_definitions";

    /// <summary>
    /// The display-name for the property, used for front-end.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Whether the property can be filtered. If this is a sub-property, all the parent properties must be marked filterable.
    /// </summary>
    public TerraformValue<bool>? IsFilterable
    {
        get => GetArgument<TerraformValue<bool>>("is_filterable");
        set => SetArgument("is_filterable", value);
    }

    /// <summary>
    /// Whether the property is user supplied metadata.
    /// </summary>
    public TerraformValue<bool>? IsMetadata
    {
        get => GetArgument<TerraformValue<bool>>("is_metadata");
        set => SetArgument("is_metadata", value);
    }

    /// <summary>
    /// Whether the property can have multiple values.
    /// </summary>
    public TerraformValue<bool>? IsRepeatable
    {
        get => GetArgument<TerraformValue<bool>>("is_repeatable");
        set => SetArgument("is_repeatable", value);
    }

    /// <summary>
    /// Whether the property is mandatory.
    /// </summary>
    public TerraformValue<bool>? IsRequired
    {
        get => GetArgument<TerraformValue<bool>>("is_required");
        set => SetArgument("is_required", value);
    }

    /// <summary>
    /// Indicates that the property should be included in a global search.
    /// </summary>
    public TerraformValue<bool>? IsSearchable
    {
        get => GetArgument<TerraformValue<bool>>("is_searchable");
        set => SetArgument("is_searchable", value);
    }

    /// <summary>
    /// The name of the metadata property.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Stores the retrieval importance. Possible values: [&amp;quot;HIGHEST&amp;quot;, &amp;quot;HIGHER&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;LOWEST&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RetrievalImportance
    {
        get => GetArgument<TerraformValue<string>>("retrieval_importance");
        set => SetArgument("retrieval_importance", value);
    }

    /// <summary>
    /// DateTimeTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateTimeTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockDateTimeTypeOptionsBlock>? DateTimeTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockDateTimeTypeOptionsBlock>>("date_time_type_options");
        set => SetArgument("date_time_type_options", value);
    }

    /// <summary>
    /// EnumTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnumTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockEnumTypeOptionsBlock>? EnumTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockEnumTypeOptionsBlock>>("enum_type_options");
        set => SetArgument("enum_type_options", value);
    }

    /// <summary>
    /// FloatTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FloatTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockFloatTypeOptionsBlock>? FloatTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockFloatTypeOptionsBlock>>("float_type_options");
        set => SetArgument("float_type_options", value);
    }

    /// <summary>
    /// IntegerTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntegerTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockIntegerTypeOptionsBlock>? IntegerTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockIntegerTypeOptionsBlock>>("integer_type_options");
        set => SetArgument("integer_type_options", value);
    }

    /// <summary>
    /// MapTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MapTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockMapTypeOptionsBlock>? MapTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockMapTypeOptionsBlock>>("map_type_options");
        set => SetArgument("map_type_options", value);
    }

    /// <summary>
    /// PropertyTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PropertyTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlock>? PropertyTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlock>>("property_type_options");
        set => SetArgument("property_type_options", value);
    }

    /// <summary>
    /// SchemaSources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockSchemaSourcesBlock>? SchemaSources
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockSchemaSourcesBlock>>("schema_sources");
        set => SetArgument("schema_sources", value);
    }

    /// <summary>
    /// TextTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TextTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockTextTypeOptionsBlock>? TextTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockTextTypeOptionsBlock>>("text_type_options");
        set => SetArgument("text_type_options", value);
    }

    /// <summary>
    /// TimestampTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimestampTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockTimestampTypeOptionsBlock>? TimestampTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockTimestampTypeOptionsBlock>>("timestamp_type_options");
        set => SetArgument("timestamp_type_options", value);
    }

}

/// <summary>
/// Block type for date_time_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockDateTimeTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_time_type_options";

}

/// <summary>
/// Block type for enum_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockEnumTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enum_type_options";

    /// <summary>
    /// List of possible enum values.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PossibleValues is required")]
    public TerraformList<string>? PossibleValues
    {
        get => GetArgument<TerraformList<string>>("possible_values");
        set => SetArgument("possible_values", value);
    }

    /// <summary>
    /// Make sure the enum property value provided in the document is in the possile value list during document creation. The validation check runs by default.
    /// </summary>
    public TerraformValue<bool>? ValidationCheckDisabled
    {
        get => GetArgument<TerraformValue<bool>>("validation_check_disabled");
        set => SetArgument("validation_check_disabled", value);
    }

}

/// <summary>
/// Block type for float_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockFloatTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "float_type_options";

}

/// <summary>
/// Block type for integer_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockIntegerTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "integer_type_options";

}

/// <summary>
/// Block type for map_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockMapTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "map_type_options";

}

/// <summary>
/// Block type for property_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property_type_options";

    /// <summary>
    /// PropertyDefinitions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropertyDefinitions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PropertyDefinitions block(s) required")]
    public required TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock> PropertyDefinitions
    {
        get => GetRequiredArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock>>("property_definitions");
        set => SetArgument("property_definitions", value);
    }

}

/// <summary>
/// Block type for property_definitions in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property_definitions";

    /// <summary>
    /// The display-name for the property, used for front-end.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Whether the property can be filtered. If this is a sub-property, all the parent properties must be marked filterable.
    /// </summary>
    public TerraformValue<bool>? IsFilterable
    {
        get => GetArgument<TerraformValue<bool>>("is_filterable");
        set => SetArgument("is_filterable", value);
    }

    /// <summary>
    /// Whether the property is user supplied metadata.
    /// </summary>
    public TerraformValue<bool>? IsMetadata
    {
        get => GetArgument<TerraformValue<bool>>("is_metadata");
        set => SetArgument("is_metadata", value);
    }

    /// <summary>
    /// Whether the property can have multiple values.
    /// </summary>
    public TerraformValue<bool>? IsRepeatable
    {
        get => GetArgument<TerraformValue<bool>>("is_repeatable");
        set => SetArgument("is_repeatable", value);
    }

    /// <summary>
    /// Whether the property is mandatory.
    /// </summary>
    public TerraformValue<bool>? IsRequired
    {
        get => GetArgument<TerraformValue<bool>>("is_required");
        set => SetArgument("is_required", value);
    }

    /// <summary>
    /// Indicates that the property should be included in a global search.
    /// </summary>
    public TerraformValue<bool>? IsSearchable
    {
        get => GetArgument<TerraformValue<bool>>("is_searchable");
        set => SetArgument("is_searchable", value);
    }

    /// <summary>
    /// The name of the metadata property.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Stores the retrieval importance. Possible values: [&amp;quot;HIGHEST&amp;quot;, &amp;quot;HIGHER&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;LOWEST&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RetrievalImportance
    {
        get => GetArgument<TerraformValue<string>>("retrieval_importance");
        set => SetArgument("retrieval_importance", value);
    }

    /// <summary>
    /// DateTimeTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateTimeTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockDateTimeTypeOptionsBlock>? DateTimeTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockDateTimeTypeOptionsBlock>>("date_time_type_options");
        set => SetArgument("date_time_type_options", value);
    }

    /// <summary>
    /// EnumTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnumTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockEnumTypeOptionsBlock>? EnumTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockEnumTypeOptionsBlock>>("enum_type_options");
        set => SetArgument("enum_type_options", value);
    }

    /// <summary>
    /// FloatTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FloatTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockFloatTypeOptionsBlock>? FloatTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockFloatTypeOptionsBlock>>("float_type_options");
        set => SetArgument("float_type_options", value);
    }

    /// <summary>
    /// IntegerTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntegerTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockIntegerTypeOptionsBlock>? IntegerTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockIntegerTypeOptionsBlock>>("integer_type_options");
        set => SetArgument("integer_type_options", value);
    }

    /// <summary>
    /// MapTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MapTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockMapTypeOptionsBlock>? MapTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockMapTypeOptionsBlock>>("map_type_options");
        set => SetArgument("map_type_options", value);
    }

    /// <summary>
    /// SchemaSources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockSchemaSourcesBlock>? SchemaSources
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockSchemaSourcesBlock>>("schema_sources");
        set => SetArgument("schema_sources", value);
    }

    /// <summary>
    /// TextTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TextTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockTextTypeOptionsBlock>? TextTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockTextTypeOptionsBlock>>("text_type_options");
        set => SetArgument("text_type_options", value);
    }

    /// <summary>
    /// TimestampTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimestampTypeOptions block(s) allowed")]
    public TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockTimestampTypeOptionsBlock>? TimestampTypeOptions
    {
        get => GetArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockTimestampTypeOptionsBlock>>("timestamp_type_options");
        set => SetArgument("timestamp_type_options", value);
    }

}

/// <summary>
/// Block type for date_time_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockDateTimeTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_time_type_options";

}

/// <summary>
/// Block type for enum_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockEnumTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enum_type_options";

    /// <summary>
    /// List of possible enum values.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PossibleValues is required")]
    public TerraformList<string>? PossibleValues
    {
        get => GetArgument<TerraformList<string>>("possible_values");
        set => SetArgument("possible_values", value);
    }

    /// <summary>
    /// Make sure the enum property value provided in the document is in the possile value list during document creation. The validation check runs by default.
    /// </summary>
    public TerraformValue<bool>? ValidationCheckDisabled
    {
        get => GetArgument<TerraformValue<bool>>("validation_check_disabled");
        set => SetArgument("validation_check_disabled", value);
    }

}

/// <summary>
/// Block type for float_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockFloatTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "float_type_options";

}

/// <summary>
/// Block type for integer_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockIntegerTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "integer_type_options";

}

/// <summary>
/// Block type for map_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockMapTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "map_type_options";

}

/// <summary>
/// Block type for schema_sources in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockSchemaSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_sources";

    /// <summary>
    /// The schema name in the source.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Doc AI processor type name.
    /// </summary>
    public TerraformValue<string>? ProcessorType
    {
        get => GetArgument<TerraformValue<string>>("processor_type");
        set => SetArgument("processor_type", value);
    }

}

/// <summary>
/// Block type for text_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockTextTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text_type_options";

}

/// <summary>
/// Block type for timestamp_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockPropertyTypeOptionsBlockPropertyDefinitionsBlockTimestampTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timestamp_type_options";

}

/// <summary>
/// Block type for schema_sources in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockSchemaSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_sources";

    /// <summary>
    /// The schema name in the source.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Doc AI processor type name.
    /// </summary>
    public TerraformValue<string>? ProcessorType
    {
        get => GetArgument<TerraformValue<string>>("processor_type");
        set => SetArgument("processor_type", value);
    }

}

/// <summary>
/// Block type for text_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockTextTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text_type_options";

}

/// <summary>
/// Block type for timestamp_type_options in GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlockTimestampTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timestamp_type_options";

}


/// <summary>
/// Block type for timeouts in GoogleDocumentAiWarehouseDocumentSchema.
/// Nesting mode: single
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_document_ai_warehouse_document_schema Terraform resource.
/// Manages a google_document_ai_warehouse_document_schema resource.
/// </summary>
public partial class GoogleDocumentAiWarehouseDocumentSchema(string name) : TerraformResource("google_document_ai_warehouse_document_schema", name)
{
    /// <summary>
    /// Name of the schema given by the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Tells whether the document is a folder or a typical document.
    /// </summary>
    public TerraformValue<bool>? DocumentIsFolder
    {
        get => GetArgument<TerraformValue<bool>>("document_is_folder");
        set => SetArgument("document_is_folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectNumber is required")]
    public required TerraformValue<string> ProjectNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_number");
        set => SetArgument("project_number", value);
    }

    /// <summary>
    /// The resource name of the document schema.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// PropertyDefinitions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropertyDefinitions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PropertyDefinitions block(s) required")]
    public required TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock> PropertyDefinitions
    {
        get => GetRequiredArgument<TerraformList<GoogleDocumentAiWarehouseDocumentSchemaPropertyDefinitionsBlock>>("property_definitions");
        set => SetArgument("property_definitions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDocumentAiWarehouseDocumentSchemaTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
