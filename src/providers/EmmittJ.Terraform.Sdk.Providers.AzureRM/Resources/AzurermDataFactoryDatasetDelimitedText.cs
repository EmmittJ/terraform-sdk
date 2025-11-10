using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_blob_fs_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetDelimitedTextAzureBlobFsLocationBlock : ITerraformBlock
{
    /// <summary>
    /// The dynamic_file_system_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_file_system_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicFileSystemEnabled { get; set; }

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_filename_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicFilenameEnabled { get; set; }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_path_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicPathEnabled { get; set; }

    /// <summary>
    /// The file_system attribute.
    /// </summary>
    [TerraformPropertyName("file_system")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FileSystem { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformPropertyName("filename")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filename { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Path { get; set; }

}

/// <summary>
/// Block type for azure_blob_storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetDelimitedTextAzureBlobStorageLocationBlock : ITerraformBlock
{
    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [TerraformPropertyName("container")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Container { get; set; }

    /// <summary>
    /// The dynamic_container_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_container_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicContainerEnabled { get; set; }

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_filename_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicFilenameEnabled { get; set; }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_path_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicPathEnabled { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformPropertyName("filename")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filename { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Path { get; set; }

}

/// <summary>
/// Block type for http_server_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetDelimitedTextHttpServerLocationBlock : ITerraformBlock
{
    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_filename_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicFilenameEnabled { get; set; }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_path_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicPathEnabled { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformPropertyName("filename")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Filename { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Path { get; set; }

    /// <summary>
    /// The relative_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUrl is required")]
    [TerraformPropertyName("relative_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RelativeUrl { get; set; }

}

/// <summary>
/// Block type for schema_column in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetDelimitedTextSchemaColumnBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryDatasetDelimitedTextTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_dataset_delimited_text resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryDatasetDelimitedText : TerraformResource
{
    public AzurermDataFactoryDatasetDelimitedText(string name) : base("azurerm_data_factory_dataset_delimited_text", name)
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformPropertyName("additional_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// The column_delimiter attribute.
    /// </summary>
    [TerraformPropertyName("column_delimiter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ColumnDelimiter { get; set; }

    /// <summary>
    /// The compression_codec attribute.
    /// </summary>
    [TerraformPropertyName("compression_codec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CompressionCodec { get; set; }

    /// <summary>
    /// The compression_level attribute.
    /// </summary>
    [TerraformPropertyName("compression_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CompressionLevel { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformPropertyName("data_factory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [TerraformPropertyName("encoding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Encoding { get; set; }

    /// <summary>
    /// The escape_character attribute.
    /// </summary>
    [TerraformPropertyName("escape_character")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EscapeCharacter { get; set; }

    /// <summary>
    /// The first_row_as_header attribute.
    /// </summary>
    [TerraformPropertyName("first_row_as_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FirstRowAsHeader { get; set; }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [TerraformPropertyName("folder")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformPropertyName("linked_service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LinkedServiceName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The null_value attribute.
    /// </summary>
    [TerraformPropertyName("null_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NullValue { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The quote_character attribute.
    /// </summary>
    [TerraformPropertyName("quote_character")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QuoteCharacter { get; set; }

    /// <summary>
    /// The row_delimiter attribute.
    /// </summary>
    [TerraformPropertyName("row_delimiter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RowDelimiter { get; set; }

    /// <summary>
    /// Block for azure_blob_fs_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobFsLocation block(s) allowed")]
    [TerraformPropertyName("azure_blob_fs_location")]
    public TerraformList<TerraformBlock<AzurermDataFactoryDatasetDelimitedTextAzureBlobFsLocationBlock>>? AzureBlobFsLocation { get; set; } = new();

    /// <summary>
    /// Block for azure_blob_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorageLocation block(s) allowed")]
    [TerraformPropertyName("azure_blob_storage_location")]
    public TerraformList<TerraformBlock<AzurermDataFactoryDatasetDelimitedTextAzureBlobStorageLocationBlock>>? AzureBlobStorageLocation { get; set; } = new();

    /// <summary>
    /// Block for http_server_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpServerLocation block(s) allowed")]
    [TerraformPropertyName("http_server_location")]
    public TerraformList<TerraformBlock<AzurermDataFactoryDatasetDelimitedTextHttpServerLocationBlock>>? HttpServerLocation { get; set; } = new();

    /// <summary>
    /// Block for schema_column.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("schema_column")]
    public TerraformList<TerraformBlock<AzurermDataFactoryDatasetDelimitedTextSchemaColumnBlock>>? SchemaColumn { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataFactoryDatasetDelimitedTextTimeoutsBlock>? Timeouts { get; set; } = new();

}
