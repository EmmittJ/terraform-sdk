using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupInstanceDiskTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("backup_policy_id");
        SetOutput("disk_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("snapshot_resource_group_name");
        SetOutput("snapshot_subscription_id");
        SetOutput("vault_id");
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    public required TerraformProperty<string> BackupPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_policy_id");
        set => SetProperty("backup_policy_id", value);
    }

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskId is required")]
    public required TerraformProperty<string> DiskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_id");
        set => SetProperty("disk_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The snapshot_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotResourceGroupName is required")]
    public required TerraformProperty<string> SnapshotResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_resource_group_name");
        set => SetProperty("snapshot_resource_group_name", value);
    }

    /// <summary>
    /// The snapshot_subscription_id attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotSubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_subscription_id");
        set => SetProperty("snapshot_subscription_id", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformProperty<string> VaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vault_id");
        set => SetProperty("vault_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataProtectionBackupInstanceDiskTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
