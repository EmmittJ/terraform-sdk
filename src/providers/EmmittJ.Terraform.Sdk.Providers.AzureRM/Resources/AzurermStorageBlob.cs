using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageBlobTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_storage_blob resource.
/// </summary>
public class AzurermStorageBlob : TerraformResource
{
    public AzurermStorageBlob(string name) : base("azurerm_storage_blob", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("url");
        SetOutput("access_tier");
        SetOutput("cache_control");
        SetOutput("content_md5");
        SetOutput("content_type");
        SetOutput("encryption_scope");
        SetOutput("id");
        SetOutput("metadata");
        SetOutput("name");
        SetOutput("parallelism");
        SetOutput("size");
        SetOutput("source");
        SetOutput("source_content");
        SetOutput("source_uri");
        SetOutput("storage_account_name");
        SetOutput("storage_container_name");
        SetOutput("type");
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformProperty<string> AccessTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_tier");
        set => SetProperty("access_tier", value);
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformProperty<string> CacheControl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cache_control");
        set => SetProperty("cache_control", value);
    }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    public TerraformProperty<string> ContentMd5
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_md5");
        set => SetProperty("content_md5", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformProperty<string> ContentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_type");
        set => SetProperty("content_type", value);
    }

    /// <summary>
    /// The encryption_scope attribute.
    /// </summary>
    public TerraformProperty<string> EncryptionScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_scope");
        set => SetProperty("encryption_scope", value);
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
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Metadata
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => SetProperty("metadata", value);
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
    /// The parallelism attribute.
    /// </summary>
    public TerraformProperty<double> Parallelism
    {
        get => GetRequiredOutput<TerraformProperty<double>>("parallelism");
        set => SetProperty("parallelism", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<double> Size
    {
        get => GetRequiredOutput<TerraformProperty<double>>("size");
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformProperty<string> Source
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source");
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The source_content attribute.
    /// </summary>
    public TerraformProperty<string> SourceContent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_content");
        set => SetProperty("source_content", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformProperty<string> SourceUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_uri");
        set => SetProperty("source_uri", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageBlobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
