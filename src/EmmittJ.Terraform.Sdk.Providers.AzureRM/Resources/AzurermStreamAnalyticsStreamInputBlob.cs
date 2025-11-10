using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for serialization in .
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsStreamInputBlobSerializationBlock : TerraformBlock
{
    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformProperty<string>? Encoding
    {
        get => GetProperty<TerraformProperty<string>>("encoding");
        set => WithProperty("encoding", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? FieldDelimiter
    {
        get => GetProperty<TerraformProperty<string>>("field_delimiter");
        set => WithProperty("field_delimiter", value);
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsStreamInputBlobTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_stream_analytics_stream_input_blob resource.
/// </summary>
public class AzurermStreamAnalyticsStreamInputBlob : TerraformResource
{
    public AzurermStreamAnalyticsStreamInputBlob(string name) : base("azurerm_stream_analytics_stream_input_blob", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationMode
    {
        get => GetProperty<TerraformProperty<string>>("authentication_mode");
        set => this.WithProperty("authentication_mode", value);
    }

    /// <summary>
    /// The date_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DateFormat is required")]
    public required TerraformProperty<string> DateFormat
    {
        get => GetProperty<TerraformProperty<string>>("date_format");
        set => this.WithProperty("date_format", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The path_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPattern is required")]
    public required TerraformProperty<string> PathPattern
    {
        get => GetProperty<TerraformProperty<string>>("path_pattern");
        set => this.WithProperty("path_pattern", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountKey is required")]
    public required TerraformProperty<string> StorageAccountKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_key");
        set => this.WithProperty("storage_account_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformProperty<string> StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerName is required")]
    public required TerraformProperty<string> StorageContainerName
    {
        get => GetProperty<TerraformProperty<string>>("storage_container_name");
        set => this.WithProperty("storage_container_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformProperty<string> StreamAnalyticsJobName
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The time_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeFormat is required")]
    public required TerraformProperty<string> TimeFormat
    {
        get => GetProperty<TerraformProperty<string>>("time_format");
        set => this.WithProperty("time_format", value);
    }

    /// <summary>
    /// Block for serialization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    public List<AzurermStreamAnalyticsStreamInputBlobSerializationBlock>? Serialization
    {
        get => GetProperty<List<AzurermStreamAnalyticsStreamInputBlobSerializationBlock>>("serialization");
        set => this.WithProperty("serialization", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsStreamInputBlobTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStreamAnalyticsStreamInputBlobTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
