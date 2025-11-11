using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_blob_storage_location in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryDatasetBinaryAzureBlobStorageLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [TerraformProperty("container")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Container { get; set; }

    /// <summary>
    /// The dynamic_container_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_container_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DynamicContainerEnabled { get; set; }

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_filename_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DynamicFilenameEnabled { get; set; }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_path_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DynamicPathEnabled { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformProperty("filename")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filename { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Path { get; set; }

}

/// <summary>
/// Block type for compression in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryDatasetBinaryCompressionBlock : TerraformBlockBase
{
    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformProperty("level")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Level { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for http_server_location in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryDatasetBinaryHttpServerLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_filename_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DynamicFilenameEnabled { get; set; }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_path_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DynamicPathEnabled { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformProperty("filename")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Filename { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The relative_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUrl is required")]
    [TerraformProperty("relative_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RelativeUrl { get; set; }

}

/// <summary>
/// Block type for sftp_server_location in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryDatasetBinarySftpServerLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_filename_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DynamicFilenameEnabled { get; set; }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_path_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DynamicPathEnabled { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformProperty("filename")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Filename { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryDatasetBinaryTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_dataset_binary resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataFactoryDatasetBinary : TerraformResource
{
    public AzurermDataFactoryDatasetBinary(string name) : base("azurerm_data_factory_dataset_binary", name)
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformProperty("additional_properties")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Annotations { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [TerraformProperty("folder")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LinkedServiceName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// Block for azure_blob_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorageLocation block(s) allowed")]
    [TerraformProperty("azure_blob_storage_location")]
    public TerraformList<TerraformBlock<AzurermDataFactoryDatasetBinaryAzureBlobStorageLocationBlock>>? AzureBlobStorageLocation { get; set; }

    /// <summary>
    /// Block for compression.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Compression block(s) allowed")]
    [TerraformProperty("compression")]
    public TerraformList<TerraformBlock<AzurermDataFactoryDatasetBinaryCompressionBlock>>? Compression { get; set; }

    /// <summary>
    /// Block for http_server_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpServerLocation block(s) allowed")]
    [TerraformProperty("http_server_location")]
    public TerraformList<TerraformBlock<AzurermDataFactoryDatasetBinaryHttpServerLocationBlock>>? HttpServerLocation { get; set; }

    /// <summary>
    /// Block for sftp_server_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SftpServerLocation block(s) allowed")]
    [TerraformProperty("sftp_server_location")]
    public TerraformList<TerraformBlock<AzurermDataFactoryDatasetBinarySftpServerLocationBlock>>? SftpServerLocation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDataFactoryDatasetBinaryTimeoutsBlock>? Timeouts { get; set; }

}
