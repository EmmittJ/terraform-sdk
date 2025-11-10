using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageShareFileTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_storage_share_file resource.
/// </summary>
public class AzurermStorageShareFile : TerraformResource
{
    public AzurermStorageShareFile(string name) : base("azurerm_storage_share_file", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("content_length");
        SetOutput("content_disposition");
        SetOutput("content_encoding");
        SetOutput("content_md5");
        SetOutput("content_type");
        SetOutput("id");
        SetOutput("metadata");
        SetOutput("name");
        SetOutput("path");
        SetOutput("source");
        SetOutput("storage_share_id");
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformProperty<string> ContentDisposition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_disposition");
        set => SetProperty("content_disposition", value);
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformProperty<string> ContentEncoding
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_encoding");
        set => SetProperty("content_encoding", value);
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
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string> Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path");
        set => SetProperty("path", value);
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
    /// The storage_share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageShareId is required")]
    public required TerraformProperty<string> StorageShareId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_share_id");
        set => SetProperty("storage_share_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageShareFileTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    public TerraformExpression ContentLength => this["content_length"];

}
