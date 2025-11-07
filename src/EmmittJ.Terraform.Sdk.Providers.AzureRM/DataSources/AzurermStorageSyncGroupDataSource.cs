using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_storage_sync_group.
/// </summary>
public class AzurermStorageSyncGroupDataSource : TerraformDataSource
{
    public AzurermStorageSyncGroupDataSource(string name) : base("azurerm_storage_sync_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The storage_sync_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageSyncId
    {
        get => GetProperty<TerraformProperty<string>>("storage_sync_id");
        set => this.WithProperty("storage_sync_id", value);
    }

}
