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
    public TerraformLiteralProperty<string>? BackupPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_policy_id");
        set => this.WithProperty("backup_policy_id", value);
    }

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DiskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_id");
        set => this.WithProperty("disk_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The snapshot_resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnapshotResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_resource_group_name");
        set => this.WithProperty("snapshot_resource_group_name", value);
    }

    /// <summary>
    /// The snapshot_subscription_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnapshotSubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_subscription_id");
        set => this.WithProperty("snapshot_subscription_id", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vault_id");
        set => this.WithProperty("vault_id", value);
    }

}
