using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_blob_fs_location in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryDatasetDelimitedTextAzureBlobFsLocationBlock() : TerraformBlock("azure_blob_fs_location")
{
    /// <summary>
    /// The dynamic_file_system_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_file_system_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicFileSystemEnabled { get; set; }

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_filename_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicFilenameEnabled { get; set; }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_path_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicPathEnabled { get; set; }

    /// <summary>
    /// The file_system attribute.
    /// </summary>
    [TerraformProperty("file_system")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileSystem { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformProperty("filename")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Filename { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

}

/// <summary>
/// Block type for azure_blob_storage_location in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryDatasetDelimitedTextAzureBlobStorageLocationBlock() : TerraformBlock("azure_blob_storage_location")
{
    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [TerraformProperty("container")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Container { get; set; }

    /// <summary>
    /// The dynamic_container_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_container_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicContainerEnabled { get; set; }

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_filename_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicFilenameEnabled { get; set; }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_path_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicPathEnabled { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformProperty("filename")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Filename { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

}

/// <summary>
/// Block type for http_server_location in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryDatasetDelimitedTextHttpServerLocationBlock() : TerraformBlock("http_server_location")
{
    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_filename_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicFilenameEnabled { get; set; }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_path_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicPathEnabled { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformProperty("filename")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Filename { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The relative_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUrl is required")]
    [TerraformProperty("relative_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RelativeUrl { get; set; }

}

/// <summary>
/// Block type for schema_column in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryDatasetDelimitedTextSchemaColumnBlock() : TerraformBlock("schema_column")
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryDatasetDelimitedTextTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_dataset_delimited_text resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataFactoryDatasetDelimitedText : TerraformResource
{
    public AzurermDataFactoryDatasetDelimitedText(string name) : base("azurerm_data_factory_dataset_delimited_text", name)
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformProperty("additional_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Annotations { get; set; }

    /// <summary>
    /// The column_delimiter attribute.
    /// </summary>
    [TerraformProperty("column_delimiter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ColumnDelimiter { get; set; }

    /// <summary>
    /// The compression_codec attribute.
    /// </summary>
    [TerraformProperty("compression_codec")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CompressionCodec { get; set; }

    /// <summary>
    /// The compression_level attribute.
    /// </summary>
    [TerraformProperty("compression_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CompressionLevel { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [TerraformProperty("encoding")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Encoding { get; set; }

    /// <summary>
    /// The escape_character attribute.
    /// </summary>
    [TerraformProperty("escape_character")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EscapeCharacter { get; set; }

    /// <summary>
    /// The first_row_as_header attribute.
    /// </summary>
    [TerraformProperty("first_row_as_header")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FirstRowAsHeader { get; set; }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [TerraformProperty("folder")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkedServiceName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The null_value attribute.
    /// </summary>
    [TerraformProperty("null_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NullValue { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The quote_character attribute.
    /// </summary>
    [TerraformProperty("quote_character")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QuoteCharacter { get; set; }

    /// <summary>
    /// The row_delimiter attribute.
    /// </summary>
    [TerraformProperty("row_delimiter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RowDelimiter { get; set; }

    /// <summary>
    /// Block for azure_blob_fs_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobFsLocation block(s) allowed")]
    [TerraformProperty("azure_blob_fs_location")]
    public TerraformList<AzurermDataFactoryDatasetDelimitedTextAzureBlobFsLocationBlock> AzureBlobFsLocation { get; set; } = new();

    /// <summary>
    /// Block for azure_blob_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorageLocation block(s) allowed")]
    [TerraformProperty("azure_blob_storage_location")]
    public TerraformList<AzurermDataFactoryDatasetDelimitedTextAzureBlobStorageLocationBlock> AzureBlobStorageLocation { get; set; } = new();

    /// <summary>
    /// Block for http_server_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpServerLocation block(s) allowed")]
    [TerraformProperty("http_server_location")]
    public TerraformList<AzurermDataFactoryDatasetDelimitedTextHttpServerLocationBlock> HttpServerLocation { get; set; } = new();

    /// <summary>
    /// Block for schema_column.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("schema_column")]
    public TerraformList<AzurermDataFactoryDatasetDelimitedTextSchemaColumnBlock> SchemaColumn { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataFactoryDatasetDelimitedTextTimeoutsBlock Timeouts { get; set; } = new();

}
