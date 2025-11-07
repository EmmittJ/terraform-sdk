using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    public TerraformProperty<string>? FileShareName
    {
        get => GetProperty<TerraformProperty<string>>("file_share_name");
        set => this.WithProperty("file_share_name", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountTenantId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_tenant_id");
        set => this.WithProperty("storage_account_tenant_id", value);
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageSyncGroupId
    {
        get => GetProperty<TerraformProperty<string>>("storage_sync_group_id");
        set => this.WithProperty("storage_sync_group_id", value);
    }

}
