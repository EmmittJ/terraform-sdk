using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for azure_blob_fs_location in AzurermDataFactoryDatasetParquet.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetParquetAzureBlobFsLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_blob_fs_location";

    /// <summary>
    /// The dynamic_file_system_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicFileSystemEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_file_system_enabled");
        set => SetArgument("dynamic_file_system_enabled", value);
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
    /// The file_system attribute.
    /// </summary>
    public TerraformValue<string>? FileSystem
    {
        get => GetArgument<TerraformValue<string>>("file_system");
        set => SetArgument("file_system", value);
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
/// Block type for azure_blob_storage_location in AzurermDataFactoryDatasetParquet.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetParquetAzureBlobStorageLocationBlock : TerraformBlock
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
/// Block type for http_server_location in AzurermDataFactoryDatasetParquet.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetParquetHttpServerLocationBlock : TerraformBlock
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
    public TerraformValue<string>? Path
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
/// Block type for schema_column in AzurermDataFactoryDatasetParquet.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetParquetSchemaColumnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_column";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactoryDatasetParquet.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryDatasetParquetTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_data_factory_dataset_parquet Terraform resource.
/// Manages a azurerm_data_factory_dataset_parquet resource.
/// </summary>
public partial class AzurermDataFactoryDatasetParquet(string name) : TerraformResource("azurerm_data_factory_dataset_parquet", name)
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
    /// The compression_codec attribute.
    /// </summary>
    public TerraformValue<string>? CompressionCodec
    {
        get => GetArgument<TerraformValue<string>>("compression_codec");
        set => SetArgument("compression_codec", value);
    }

    /// <summary>
    /// The compression_level attribute.
    /// </summary>
    public TerraformValue<string>? CompressionLevel
    {
        get => GetArgument<TerraformValue<string>>("compression_level");
        set => SetArgument("compression_level", value);
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
    /// AzureBlobFsLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobFsLocation block(s) allowed")]
    public TerraformList<AzurermDataFactoryDatasetParquetAzureBlobFsLocationBlock>? AzureBlobFsLocation
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDatasetParquetAzureBlobFsLocationBlock>>("azure_blob_fs_location");
        set => SetArgument("azure_blob_fs_location", value);
    }

    /// <summary>
    /// AzureBlobStorageLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorageLocation block(s) allowed")]
    public TerraformList<AzurermDataFactoryDatasetParquetAzureBlobStorageLocationBlock>? AzureBlobStorageLocation
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDatasetParquetAzureBlobStorageLocationBlock>>("azure_blob_storage_location");
        set => SetArgument("azure_blob_storage_location", value);
    }

    /// <summary>
    /// HttpServerLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpServerLocation block(s) allowed")]
    public TerraformList<AzurermDataFactoryDatasetParquetHttpServerLocationBlock>? HttpServerLocation
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDatasetParquetHttpServerLocationBlock>>("http_server_location");
        set => SetArgument("http_server_location", value);
    }

    /// <summary>
    /// SchemaColumn block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataFactoryDatasetParquetSchemaColumnBlock>? SchemaColumn
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDatasetParquetSchemaColumnBlock>>("schema_column");
        set => SetArgument("schema_column", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryDatasetParquetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryDatasetParquetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
