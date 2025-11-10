using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageSyncCloudEndpointTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_storage_sync_cloud_endpoint resource.
/// </summary>
public class AzurermStorageSyncCloudEndpoint : TerraformResource
{
    public AzurermStorageSyncCloudEndpoint(string name) : base("azurerm_storage_sync_cloud_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("file_share_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("storage_account_id");
        SetOutput("storage_account_tenant_id");
        SetOutput("storage_sync_group_id");
    }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileShareName is required")]
    public required TerraformProperty<string> FileShareName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_share_name");
        set => SetProperty("file_share_name", value);
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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_tenant_id attribute.
    /// </summary>
    public TerraformProperty<string> StorageAccountTenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_tenant_id");
        set => SetProperty("storage_account_tenant_id", value);
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSyncGroupId is required")]
    public required TerraformProperty<string> StorageSyncGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_sync_group_id");
        set => SetProperty("storage_sync_group_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageSyncCloudEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
