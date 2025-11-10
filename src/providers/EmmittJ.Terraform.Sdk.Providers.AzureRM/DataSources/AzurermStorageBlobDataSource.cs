using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageBlobDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_storage_blob.
/// </summary>
public class AzurermStorageBlobDataSource : TerraformDataSource
{
    public AzurermStorageBlobDataSource(string name) : base("azurerm_storage_blob", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_tier");
        SetOutput("content_md5");
        SetOutput("content_type");
        SetOutput("encryption_scope");
        SetOutput("type");
        SetOutput("url");
        SetOutput("id");
        SetOutput("metadata");
        SetOutput("name");
        SetOutput("storage_account_name");
        SetOutput("storage_container_name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageBlobDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformExpression AccessTier => this["access_tier"];

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    public TerraformExpression ContentMd5 => this["content_md5"];

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformExpression ContentType => this["content_type"];

    /// <summary>
    /// The encryption_scope attribute.
    /// </summary>
    public TerraformExpression EncryptionScope => this["encryption_scope"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
