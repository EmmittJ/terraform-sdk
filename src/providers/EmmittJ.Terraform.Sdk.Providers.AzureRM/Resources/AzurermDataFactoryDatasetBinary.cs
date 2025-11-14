using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for azure_blob_storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetBinaryAzureBlobStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_blob_storage_location";

    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [TerraformArgument("container")]
    public required TerraformValue<string> Container
    {
        get => new TerraformReference<string>(this, "container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// The dynamic_container_enabled attribute.
    /// </summary>
    [TerraformArgument("dynamic_container_enabled")]
    public TerraformValue<bool>? DynamicContainerEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_container_enabled");
        set => SetArgument("dynamic_container_enabled", value);
    }

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformArgument("dynamic_filename_enabled")]
    public TerraformValue<bool>? DynamicFilenameEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_filename_enabled");
        set => SetArgument("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformArgument("dynamic_path_enabled")]
    public TerraformValue<bool>? DynamicPathEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_path_enabled");
        set => SetArgument("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformArgument("filename")]
    public TerraformValue<string>? Filename
    {
        get => new TerraformReference<string>(this, "filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for compression in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetBinaryCompressionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compression";

    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformArgument("level")]
    public TerraformValue<string>? Level
    {
        get => new TerraformReference<string>(this, "level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for http_server_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetBinaryHttpServerLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_server_location";

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformArgument("dynamic_filename_enabled")]
    public TerraformValue<bool>? DynamicFilenameEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_filename_enabled");
        set => SetArgument("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformArgument("dynamic_path_enabled")]
    public TerraformValue<bool>? DynamicPathEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_path_enabled");
        set => SetArgument("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformArgument("filename")]
    public required TerraformValue<string> Filename
    {
        get => new TerraformReference<string>(this, "filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformArgument("path")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The relative_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUrl is required")]
    [TerraformArgument("relative_url")]
    public required TerraformValue<string> RelativeUrl
    {
        get => new TerraformReference<string>(this, "relative_url");
        set => SetArgument("relative_url", value);
    }

}

/// <summary>
/// Block type for sftp_server_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetBinarySftpServerLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sftp_server_location";

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    [TerraformArgument("dynamic_filename_enabled")]
    public TerraformValue<bool>? DynamicFilenameEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_filename_enabled");
        set => SetArgument("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    [TerraformArgument("dynamic_path_enabled")]
    public TerraformValue<bool>? DynamicPathEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_path_enabled");
        set => SetArgument("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    [TerraformArgument("filename")]
    public required TerraformValue<string> Filename
    {
        get => new TerraformReference<string>(this, "filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformArgument("path")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryDatasetBinaryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_data_factory_dataset_binary resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryDatasetBinary : TerraformResource
{
    public AzurermDataFactoryDatasetBinary(string name) : base("azurerm_data_factory_dataset_binary", name)
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformArgument("additional_properties")]
    public TerraformMap<string>? AdditionalProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_properties").ResolveNodes(ctx));
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformArgument("annotations")]
    public TerraformList<string>? Annotations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformArgument("data_factory_id")]
    public required TerraformValue<string> DataFactoryId
    {
        get => new TerraformReference<string>(this, "data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [TerraformArgument("folder")]
    public TerraformValue<string>? Folder
    {
        get => new TerraformReference<string>(this, "folder");
        set => SetArgument("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformArgument("linked_service_name")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => new TerraformReference<string>(this, "linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformArgument("parameters")]
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Block for azure_blob_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorageLocation block(s) allowed")]
    [TerraformArgument("azure_blob_storage_location")]
    public TerraformList<AzurermDataFactoryDatasetBinaryAzureBlobStorageLocationBlock> AzureBlobStorageLocation { get; set; } = new();

    /// <summary>
    /// Block for compression.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Compression block(s) allowed")]
    [TerraformArgument("compression")]
    public TerraformList<AzurermDataFactoryDatasetBinaryCompressionBlock> Compression { get; set; } = new();

    /// <summary>
    /// Block for http_server_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpServerLocation block(s) allowed")]
    [TerraformArgument("http_server_location")]
    public TerraformList<AzurermDataFactoryDatasetBinaryHttpServerLocationBlock> HttpServerLocation { get; set; } = new();

    /// <summary>
    /// Block for sftp_server_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SftpServerLocation block(s) allowed")]
    [TerraformArgument("sftp_server_location")]
    public TerraformList<AzurermDataFactoryDatasetBinarySftpServerLocationBlock> SftpServerLocation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataFactoryDatasetBinaryTimeoutsBlock Timeouts { get; set; } = new();

}
