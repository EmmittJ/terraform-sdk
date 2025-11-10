using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_blob_fs_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetDelimitedTextAzureBlobFsLocationBlock : TerraformBlock
{
    /// <summary>
    /// The dynamic_file_system_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicFileSystemEnabled
    {
        set => SetProperty("dynamic_file_system_enabled", value);
    }

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicFilenameEnabled
    {
        set => SetProperty("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicPathEnabled
    {
        set => SetProperty("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The file_system attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystem
    {
        set => SetProperty("file_system", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformProperty<string>? Filename
    {
        set => SetProperty("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

}

/// <summary>
/// Block type for azure_blob_storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetDelimitedTextAzureBlobStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    public required TerraformProperty<string> Container
    {
        set => SetProperty("container", value);
    }

    /// <summary>
    /// The dynamic_container_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicContainerEnabled
    {
        set => SetProperty("dynamic_container_enabled", value);
    }

    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicFilenameEnabled
    {
        set => SetProperty("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicPathEnabled
    {
        set => SetProperty("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformProperty<string>? Filename
    {
        set => SetProperty("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

}

/// <summary>
/// Block type for http_server_location in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetDelimitedTextHttpServerLocationBlock : TerraformBlock
{
    /// <summary>
    /// The dynamic_filename_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicFilenameEnabled
    {
        set => SetProperty("dynamic_filename_enabled", value);
    }

    /// <summary>
    /// The dynamic_path_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicPathEnabled
    {
        set => SetProperty("dynamic_path_enabled", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformProperty<string> Filename
    {
        set => SetProperty("filename", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The relative_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUrl is required")]
    public required TerraformProperty<string> RelativeUrl
    {
        set => SetProperty("relative_url", value);
    }

}

/// <summary>
/// Block type for schema_column in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetDelimitedTextSchemaColumnBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryDatasetDelimitedTextTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_data_factory_dataset_delimited_text resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryDatasetDelimitedText : TerraformResource
{
    public AzurermDataFactoryDatasetDelimitedText(string name) : base("azurerm_data_factory_dataset_delimited_text", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("additional_properties");
        SetOutput("annotations");
        SetOutput("column_delimiter");
        SetOutput("compression_codec");
        SetOutput("compression_level");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("encoding");
        SetOutput("escape_character");
        SetOutput("first_row_as_header");
        SetOutput("folder");
        SetOutput("id");
        SetOutput("linked_service_name");
        SetOutput("name");
        SetOutput("null_value");
        SetOutput("parameters");
        SetOutput("quote_character");
        SetOutput("row_delimiter");
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdditionalProperties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => SetProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The column_delimiter attribute.
    /// </summary>
    public TerraformProperty<string> ColumnDelimiter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("column_delimiter");
        set => SetProperty("column_delimiter", value);
    }

    /// <summary>
    /// The compression_codec attribute.
    /// </summary>
    public TerraformProperty<string> CompressionCodec
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compression_codec");
        set => SetProperty("compression_codec", value);
    }

    /// <summary>
    /// The compression_level attribute.
    /// </summary>
    public TerraformProperty<string> CompressionLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compression_level");
        set => SetProperty("compression_level", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_factory_id");
        set => SetProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformProperty<string> Encoding
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encoding");
        set => SetProperty("encoding", value);
    }

    /// <summary>
    /// The escape_character attribute.
    /// </summary>
    public TerraformProperty<string> EscapeCharacter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("escape_character");
        set => SetProperty("escape_character", value);
    }

    /// <summary>
    /// The first_row_as_header attribute.
    /// </summary>
    public TerraformProperty<bool> FirstRowAsHeader
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("first_row_as_header");
        set => SetProperty("first_row_as_header", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public TerraformProperty<string> Folder
    {
        get => GetRequiredOutput<TerraformProperty<string>>("folder");
        set => SetProperty("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformProperty<string> LinkedServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("linked_service_name");
        set => SetProperty("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The null_value attribute.
    /// </summary>
    public TerraformProperty<string> NullValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("null_value");
        set => SetProperty("null_value", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The quote_character attribute.
    /// </summary>
    public TerraformProperty<string> QuoteCharacter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("quote_character");
        set => SetProperty("quote_character", value);
    }

    /// <summary>
    /// The row_delimiter attribute.
    /// </summary>
    public TerraformProperty<string> RowDelimiter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("row_delimiter");
        set => SetProperty("row_delimiter", value);
    }

    /// <summary>
    /// Block for azure_blob_fs_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobFsLocation block(s) allowed")]
    public List<AzurermDataFactoryDatasetDelimitedTextAzureBlobFsLocationBlock>? AzureBlobFsLocation
    {
        set => SetProperty("azure_blob_fs_location", value);
    }

    /// <summary>
    /// Block for azure_blob_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorageLocation block(s) allowed")]
    public List<AzurermDataFactoryDatasetDelimitedTextAzureBlobStorageLocationBlock>? AzureBlobStorageLocation
    {
        set => SetProperty("azure_blob_storage_location", value);
    }

    /// <summary>
    /// Block for http_server_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpServerLocation block(s) allowed")]
    public List<AzurermDataFactoryDatasetDelimitedTextHttpServerLocationBlock>? HttpServerLocation
    {
        set => SetProperty("http_server_location", value);
    }

    /// <summary>
    /// Block for schema_column.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDataFactoryDatasetDelimitedTextSchemaColumnBlock>? SchemaColumn
    {
        set => SetProperty("schema_column", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryDatasetDelimitedTextTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
