using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for managed_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock : TerraformBlock
{
    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskId is required")]
    public required TerraformProperty<string> DiskId
    {
        get => GetProperty<TerraformProperty<string>>("disk_id");
        set => WithProperty("disk_id", value);
    }

    /// <summary>
    /// The log_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogStorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("log_storage_account_id");
        set => WithProperty("log_storage_account_id", value);
    }

    /// <summary>
    /// The target_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetDiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("target_disk_encryption_set_id");
        set => WithProperty("target_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The target_disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDiskType is required")]
    public required TerraformProperty<string> TargetDiskType
    {
        get => GetProperty<TerraformProperty<string>>("target_disk_type");
        set => WithProperty("target_disk_type", value);
    }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The is_primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrimary is required")]
    public required TerraformProperty<bool> IsPrimary
    {
        get => GetProperty<TerraformProperty<bool>>("is_primary");
        set => WithProperty("is_primary", value);
    }

    /// <summary>
    /// The source_mac_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceMacAddress is required")]
    public required TerraformProperty<string> SourceMacAddress
    {
        get => GetProperty<TerraformProperty<string>>("source_mac_address");
        set => WithProperty("source_mac_address", value);
    }

    /// <summary>
    /// The target_static_ip attribute.
    /// </summary>
    public TerraformProperty<string>? TargetStaticIp
    {
        get => GetProperty<TerraformProperty<string>>("target_static_ip");
        set => WithProperty("target_static_ip", value);
    }

    /// <summary>
    /// The target_subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetSubnetName
    {
        get => GetProperty<TerraformProperty<string>>("target_subnet_name");
        set => WithProperty("target_subnet_name", value);
    }

    /// <summary>
    /// The test_subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? TestSubnetName
    {
        get => GetProperty<TerraformProperty<string>>("test_subnet_name");
        set => WithProperty("test_subnet_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_site_recovery_vmware_replicated_vm resource.
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVm : TerraformResource
{
    public AzurermSiteRecoveryVmwareReplicatedVm(string name) : base("azurerm_site_recovery_vmware_replicated_vm", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The appliance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplianceName is required")]
    public required TerraformProperty<string> ApplianceName
    {
        get => GetProperty<TerraformProperty<string>>("appliance_name");
        set => this.WithProperty("appliance_name", value);
    }

    /// <summary>
    /// The default_log_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultLogStorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("default_log_storage_account_id");
        set => this.WithProperty("default_log_storage_account_id", value);
    }

    /// <summary>
    /// The default_recovery_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRecoveryDiskType
    {
        get => GetProperty<TerraformProperty<string>>("default_recovery_disk_type");
        set => this.WithProperty("default_recovery_disk_type", value);
    }

    /// <summary>
    /// The default_target_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultTargetDiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("default_target_disk_encryption_set_id");
        set => this.WithProperty("default_target_disk_encryption_set_id", value);
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
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The multi_vm_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? MultiVmGroupName
    {
        get => GetProperty<TerraformProperty<string>>("multi_vm_group_name");
        set => this.WithProperty("multi_vm_group_name", value);
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
    /// The physical_server_credential_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalServerCredentialName is required")]
    public required TerraformProperty<string> PhysicalServerCredentialName
    {
        get => GetProperty<TerraformProperty<string>>("physical_server_credential_name");
        set => this.WithProperty("physical_server_credential_name", value);
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    public required TerraformProperty<string> RecoveryReplicationPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_replication_policy_id");
        set => this.WithProperty("recovery_replication_policy_id", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformProperty<string> RecoveryVaultId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_vm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmName is required")]
    public required TerraformProperty<string> SourceVmName
    {
        get => GetProperty<TerraformProperty<string>>("source_vm_name");
        set => this.WithProperty("source_vm_name", value);
    }

    /// <summary>
    /// The target_availability_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetAvailabilitySetId
    {
        get => GetProperty<TerraformProperty<string>>("target_availability_set_id");
        set => this.WithProperty("target_availability_set_id", value);
    }

    /// <summary>
    /// The target_boot_diagnostics_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetBootDiagnosticsStorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("target_boot_diagnostics_storage_account_id");
        set => this.WithProperty("target_boot_diagnostics_storage_account_id", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("target_network_id");
        set => this.WithProperty("target_network_id", value);
    }

    /// <summary>
    /// The target_proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetProximityPlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("target_proximity_placement_group_id");
        set => this.WithProperty("target_proximity_placement_group_id", value);
    }

    /// <summary>
    /// The target_resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceGroupId is required")]
    public required TerraformProperty<string> TargetResourceGroupId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_group_id");
        set => this.WithProperty("target_resource_group_id", value);
    }

    /// <summary>
    /// The target_vm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVmName is required")]
    public required TerraformProperty<string> TargetVmName
    {
        get => GetProperty<TerraformProperty<string>>("target_vm_name");
        set => this.WithProperty("target_vm_name", value);
    }

    /// <summary>
    /// The target_vm_size attribute.
    /// </summary>
    public TerraformProperty<string>? TargetVmSize
    {
        get => GetProperty<TerraformProperty<string>>("target_vm_size");
        set => this.WithProperty("target_vm_size", value);
    }

    /// <summary>
    /// The target_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TargetZone
    {
        get => GetProperty<TerraformProperty<string>>("target_zone");
        set => this.WithProperty("target_zone", value);
    }

    /// <summary>
    /// The test_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? TestNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("test_network_id");
        set => this.WithProperty("test_network_id", value);
    }

    /// <summary>
    /// Block for managed_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock>? ManagedDisk
    {
        get => GetProperty<List<AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock>>("managed_disk");
        set => this.WithProperty("managed_disk", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetProperty<List<AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock>>("network_interface");
        set => this.WithProperty("network_interface", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
