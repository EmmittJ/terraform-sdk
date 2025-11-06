using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_sync_group resource.
/// </summary>
public class AzurermStorageSyncGroup : TerraformResource
{
    public AzurermStorageSyncGroup(string name) : base("azurerm_storage_sync_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The storage_sync_id attribute.
    /// </summary>
    public string? StorageSyncId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_sync_id")?.Value;
        set => this.WithProperty("storage_sync_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
