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
    public string? FileShareName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_share_name")?.Value;
        set => this.WithProperty("file_share_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_tenant_id attribute.
    /// </summary>
    public string? StorageAccountTenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_tenant_id")?.Value;
        set => this.WithProperty("storage_account_tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    public string? StorageSyncGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_sync_group_id")?.Value;
        set => this.WithProperty("storage_sync_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
