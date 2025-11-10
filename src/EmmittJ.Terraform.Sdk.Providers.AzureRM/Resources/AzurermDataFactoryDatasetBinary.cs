using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_blob_storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetBinaryAzureBlobStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    public required TerraformProperty<string> Container
    {
        get => GetProperty<TerraformProperty<string>>("container");
        set => WithProperty("container", value);
    }

    /// <summary>
    /// The dynamic_container_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicContainerEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_container_enabled");
        set => WithProperty("dynamic_container_enabled", value);
    }

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicFilenameEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_filename_enabled");
        set => WithProperty("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicPathEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_path_enabled");
        set => WithProperty("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformProperty<string>? Filename
    {
        get => GetProperty<TerraformProperty<string>>("filename");
        set => WithProperty("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

}

/// <summary>
/// Block type for compression in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetBinaryCompressionBlock : TerraformBlock
{
    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformProperty<string>? Level
    {
        get => GetProperty<TerraformProperty<string>>("level");
        set => WithProperty("level", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for http_server_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetBinaryHttpServerLocationBlock : TerraformBlock
{
    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicFilenameEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_filename_enabled");
        set => WithProperty("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicPathEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_path_enabled");
        set => WithProperty("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformProperty<string> Filename
    {
        get => GetProperty<TerraformProperty<string>>("filename");
        set => WithProperty("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The relative_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUrl is required")]
    public required TerraformProperty<string> RelativeUrl
    {
        get => GetProperty<TerraformProperty<string>>("relative_url");
        set => WithProperty("relative_url", value);
    }

}

/// <summary>
/// Block type for sftp_server_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetBinarySftpServerLocationBlock : TerraformBlock
{
    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicFilenameEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_filename_enabled");
        set => WithProperty("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicPathEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_path_enabled");
        set => WithProperty("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformProperty<string> Filename
    {
        get => GetProperty<TerraformProperty<string>>("filename");
        set => WithProperty("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryDatasetBinaryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Annotations
    {
        get => GetProperty<List<TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public TerraformProperty<string>? Folder
    {
        get => GetProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformProperty<string> LinkedServiceName
    {
        get => GetProperty<TerraformProperty<string>>("linked_service_name");
        set => this.WithProperty("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// Block for azure_blob_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorageLocation block(s) allowed")]
    public List<AzurermDataFactoryDatasetBinaryAzureBlobStorageLocationBlock>? AzureBlobStorageLocation
    {
        get => GetProperty<List<AzurermDataFactoryDatasetBinaryAzureBlobStorageLocationBlock>>("azure_blob_storage_location");
        set => this.WithProperty("azure_blob_storage_location", value);
    }

    /// <summary>
    /// Block for compression.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Compression block(s) allowed")]
    public List<AzurermDataFactoryDatasetBinaryCompressionBlock>? Compression
    {
        get => GetProperty<List<AzurermDataFactoryDatasetBinaryCompressionBlock>>("compression");
        set => this.WithProperty("compression", value);
    }

    /// <summary>
    /// Block for http_server_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpServerLocation block(s) allowed")]
    public List<AzurermDataFactoryDatasetBinaryHttpServerLocationBlock>? HttpServerLocation
    {
        get => GetProperty<List<AzurermDataFactoryDatasetBinaryHttpServerLocationBlock>>("http_server_location");
        set => this.WithProperty("http_server_location", value);
    }

    /// <summary>
    /// Block for sftp_server_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SftpServerLocation block(s) allowed")]
    public List<AzurermDataFactoryDatasetBinarySftpServerLocationBlock>? SftpServerLocation
    {
        get => GetProperty<List<AzurermDataFactoryDatasetBinarySftpServerLocationBlock>>("sftp_server_location");
        set => this.WithProperty("sftp_server_location", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryDatasetBinaryTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryDatasetBinaryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
