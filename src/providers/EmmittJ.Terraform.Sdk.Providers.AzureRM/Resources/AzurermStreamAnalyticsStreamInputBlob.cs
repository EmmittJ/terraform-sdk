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
        set => SetProperty("encoding", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? FieldDelimiter
    {
        set => SetProperty("field_delimiter", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
/// Manages a azurerm_stream_analytics_stream_input_blob resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStreamAnalyticsStreamInputBlob : TerraformResource
{
    public AzurermStreamAnalyticsStreamInputBlob(string name) : base("azurerm_stream_analytics_stream_input_blob", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authentication_mode");
        SetOutput("date_format");
        SetOutput("id");
        SetOutput("name");
        SetOutput("path_pattern");
        SetOutput("resource_group_name");
        SetOutput("storage_account_key");
        SetOutput("storage_account_name");
        SetOutput("storage_container_name");
        SetOutput("stream_analytics_job_name");
        SetOutput("time_format");
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_mode");
        set => SetProperty("authentication_mode", value);
    }

    /// <summary>
    /// The date_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DateFormat is required")]
    public required TerraformProperty<string> DateFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("date_format");
        set => SetProperty("date_format", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The path_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPattern is required")]
    public required TerraformProperty<string> PathPattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path_pattern");
        set => SetProperty("path_pattern", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountKey is required")]
    public required TerraformProperty<string> StorageAccountKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_key");
        set => SetProperty("storage_account_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformProperty<string> StorageAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_name");
        set => SetProperty("storage_account_name", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerName is required")]
    public required TerraformProperty<string> StorageContainerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_container_name");
        set => SetProperty("storage_container_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformProperty<string> StreamAnalyticsJobName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_analytics_job_name");
        set => SetProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The time_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeFormat is required")]
    public required TerraformProperty<string> TimeFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_format");
        set => SetProperty("time_format", value);
    }

    /// <summary>
    /// Block for serialization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serialization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    public List<AzurermStreamAnalyticsStreamInputBlobSerializationBlock>? Serialization
    {
        set => SetProperty("serialization", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsStreamInputBlobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
