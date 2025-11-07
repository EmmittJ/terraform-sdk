using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_protection_backup_instance_disk resource.
/// </summary>
public class AzurermDataProtectionBackupInstanceDisk : TerraformResource
{
    public AzurermDataProtectionBackupInstanceDisk(string name) : base("azurerm_data_protection_backup_instance_disk", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? BackupPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("backup_policy_id");
        set => this.WithProperty("backup_policy_id", value);
    }

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskId
    {
        get => GetProperty<TerraformProperty<string>>("disk_id");
        set => this.WithProperty("disk_id", value);
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
    /// The snapshot_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_resource_group_name");
        set => this.WithProperty("snapshot_resource_group_name", value);
    }

    /// <summary>
    /// The snapshot_subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotSubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_subscription_id");
        set => this.WithProperty("snapshot_subscription_id", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? VaultId
    {
        get => GetProperty<TerraformProperty<string>>("vault_id");
        set => this.WithProperty("vault_id", value);
    }

}
