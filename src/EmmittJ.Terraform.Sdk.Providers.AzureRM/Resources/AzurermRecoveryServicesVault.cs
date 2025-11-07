using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_recovery_services_vault resource.
/// </summary>
public class AzurermRecoveryServicesVault : TerraformResource
{
    public AzurermRecoveryServicesVault(string name) : base("azurerm_recovery_services_vault", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The classic_vmware_replication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ClassicVmwareReplicationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("classic_vmware_replication_enabled");
        set => this.WithProperty("classic_vmware_replication_enabled", value);
    }

    /// <summary>
    /// The cross_region_restore_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CrossRegionRestoreEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cross_region_restore_enabled");
        set => this.WithProperty("cross_region_restore_enabled", value);
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
    /// The immutability attribute.
    /// </summary>
    public TerraformProperty<string>? Immutability
    {
        get => GetProperty<TerraformProperty<string>>("immutability");
        set => this.WithProperty("immutability", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The soft_delete_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SoftDeleteEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("soft_delete_enabled");
        set => this.WithProperty("soft_delete_enabled", value);
    }

    /// <summary>
    /// The storage_mode_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageModeType
    {
        get => GetProperty<TerraformProperty<string>>("storage_mode_type");
        set => this.WithProperty("storage_mode_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
