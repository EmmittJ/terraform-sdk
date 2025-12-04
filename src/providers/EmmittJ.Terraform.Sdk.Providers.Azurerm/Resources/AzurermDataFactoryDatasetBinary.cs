using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for azure_blob_storage_location in AzurermDataFactoryDatasetBinary.
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
    public required TerraformValue<string> Container
    {
        get => GetArgument<TerraformValue<string>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// The dynamic_container_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicContainerEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_container_enabled");
        set => SetArgument("dynamic_container_enabled", value);
    }

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicFilenameEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_filename_enabled");
        set => SetArgument("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicPathEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_path_enabled");
        set => SetArgument("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformValue<string>? Filename
    {
        get => GetArgument<TerraformValue<string>>("filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for compression in AzurermDataFactoryDatasetBinary.
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
    public TerraformValue<string>? Level
    {
        get => GetArgument<TerraformValue<string>>("level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for http_server_location in AzurermDataFactoryDatasetBinary.
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
    public TerraformValue<bool>? DynamicFilenameEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_filename_enabled");
        set => SetArgument("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicPathEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_path_enabled");
        set => SetArgument("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformValue<string> Filename
    {
        get => GetArgument<TerraformValue<string>>("filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The relative_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUrl is required")]
    public required TerraformValue<string> RelativeUrl
    {
        get => GetArgument<TerraformValue<string>>("relative_url");
        set => SetArgument("relative_url", value);
    }

}


/// <summary>
/// Block type for sftp_server_location in AzurermDataFactoryDatasetBinary.
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
    public TerraformValue<bool>? DynamicFilenameEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_filename_enabled");
        set => SetArgument("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicPathEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_path_enabled");
        set => SetArgument("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformValue<string> Filename
    {
        get => GetArgument<TerraformValue<string>>("filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactoryDatasetBinary.
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_data_factory_dataset_binary Terraform resource.
/// Manages a azurerm_data_factory_dataset_binary resource.
/// </summary>
public partial class AzurermDataFactoryDatasetBinary(string name) : TerraformResource("azurerm_data_factory_dataset_binary", name)
{
    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalProperties
    {
        get => GetArgument<TerraformMap<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string>? Annotations
    {
        get => GetArgument<TerraformList<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => GetArgument<TerraformValue<string>>("data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public TerraformValue<string>? Folder
    {
        get => GetArgument<TerraformValue<string>>("folder");
        set => SetArgument("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => GetArgument<TerraformValue<string>>("linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// AzureBlobStorageLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorageLocation block(s) allowed")]
    public TerraformList<AzurermDataFactoryDatasetBinaryAzureBlobStorageLocationBlock>? AzureBlobStorageLocation
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDatasetBinaryAzureBlobStorageLocationBlock>>("azure_blob_storage_location");
        set => SetArgument("azure_blob_storage_location", value);
    }

    /// <summary>
    /// Compression block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Compression block(s) allowed")]
    public TerraformList<AzurermDataFactoryDatasetBinaryCompressionBlock>? Compression
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDatasetBinaryCompressionBlock>>("compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// HttpServerLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpServerLocation block(s) allowed")]
    public TerraformList<AzurermDataFactoryDatasetBinaryHttpServerLocationBlock>? HttpServerLocation
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDatasetBinaryHttpServerLocationBlock>>("http_server_location");
        set => SetArgument("http_server_location", value);
    }

    /// <summary>
    /// SftpServerLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SftpServerLocation block(s) allowed")]
    public TerraformList<AzurermDataFactoryDatasetBinarySftpServerLocationBlock>? SftpServerLocation
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDatasetBinarySftpServerLocationBlock>>("sftp_server_location");
        set => SetArgument("sftp_server_location", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryDatasetBinaryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryDatasetBinaryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
