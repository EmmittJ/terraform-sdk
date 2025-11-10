using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: list
/// </summary>
public class AzurermDataShareDatasetBlobStorageStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformProperty<string> SubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("subscription_id");
        set => WithProperty("subscription_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDatasetBlobStorageTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_data_share_dataset_blob_storage resource.
/// </summary>
public class AzurermDataShareDatasetBlobStorage : TerraformResource
{
    public AzurermDataShareDatasetBlobStorage(string name) : base("azurerm_data_share_dataset_blob_storage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("display_name");
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        get => GetProperty<TerraformProperty<string>>("container_name");
        set => this.WithProperty("container_name", value);
    }

    /// <summary>
    /// The data_share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareId is required")]
    public required TerraformProperty<string> DataShareId
    {
        get => GetProperty<TerraformProperty<string>>("data_share_id");
        set => this.WithProperty("data_share_id", value);
    }

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    public TerraformProperty<string>? FilePath
    {
        get => GetProperty<TerraformProperty<string>>("file_path");
        set => this.WithProperty("file_path", value);
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    public TerraformProperty<string>? FolderPath
    {
        get => GetProperty<TerraformProperty<string>>("folder_path");
        set => this.WithProperty("folder_path", value);
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
    /// Block for storage_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageAccount block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccount block(s) allowed")]
    public List<AzurermDataShareDatasetBlobStorageStorageAccountBlock>? StorageAccount
    {
        get => GetProperty<List<AzurermDataShareDatasetBlobStorageStorageAccountBlock>>("storage_account");
        set => this.WithProperty("storage_account", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataShareDatasetBlobStorageTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataShareDatasetBlobStorageTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

}
