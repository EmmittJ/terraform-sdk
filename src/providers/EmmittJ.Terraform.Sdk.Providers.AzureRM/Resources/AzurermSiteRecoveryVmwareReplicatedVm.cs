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
        set => SetProperty("disk_id", value);
    }

    /// <summary>
    /// The log_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogStorageAccountId
    {
        set => SetProperty("log_storage_account_id", value);
    }

    /// <summary>
    /// The target_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetDiskEncryptionSetId
    {
        set => SetProperty("target_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The target_disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDiskType is required")]
    public required TerraformProperty<string> TargetDiskType
    {
        set => SetProperty("target_disk_type", value);
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
        set => SetProperty("is_primary", value);
    }

    /// <summary>
    /// The source_mac_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceMacAddress is required")]
    public required TerraformProperty<string> SourceMacAddress
    {
        set => SetProperty("source_mac_address", value);
    }

    /// <summary>
    /// The target_static_ip attribute.
    /// </summary>
    public TerraformProperty<string>? TargetStaticIp
    {
        set => SetProperty("target_static_ip", value);
    }

    /// <summary>
    /// The target_subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetSubnetName
    {
        set => SetProperty("target_subnet_name", value);
    }

    /// <summary>
    /// The test_subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? TestSubnetName
    {
        set => SetProperty("test_subnet_name", value);
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
        SetOutput("appliance_name");
        SetOutput("default_log_storage_account_id");
        SetOutput("default_recovery_disk_type");
        SetOutput("default_target_disk_encryption_set_id");
        SetOutput("id");
        SetOutput("license_type");
        SetOutput("multi_vm_group_name");
        SetOutput("name");
        SetOutput("physical_server_credential_name");
        SetOutput("recovery_replication_policy_id");
        SetOutput("recovery_vault_id");
        SetOutput("source_vm_name");
        SetOutput("target_availability_set_id");
        SetOutput("target_boot_diagnostics_storage_account_id");
        SetOutput("target_network_id");
        SetOutput("target_proximity_placement_group_id");
        SetOutput("target_resource_group_id");
        SetOutput("target_vm_name");
        SetOutput("target_vm_size");
        SetOutput("target_zone");
        SetOutput("test_network_id");
    }

    /// <summary>
    /// The appliance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplianceName is required")]
    public required TerraformProperty<string> ApplianceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("appliance_name");
        set => SetProperty("appliance_name", value);
    }

    /// <summary>
    /// The default_log_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string> DefaultLogStorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_log_storage_account_id");
        set => SetProperty("default_log_storage_account_id", value);
    }

    /// <summary>
    /// The default_recovery_disk_type attribute.
    /// </summary>
    public TerraformProperty<string> DefaultRecoveryDiskType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_recovery_disk_type");
        set => SetProperty("default_recovery_disk_type", value);
    }

    /// <summary>
    /// The default_target_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string> DefaultTargetDiskEncryptionSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_target_disk_encryption_set_id");
        set => SetProperty("default_target_disk_encryption_set_id", value);
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
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string> LicenseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_type");
        set => SetProperty("license_type", value);
    }

    /// <summary>
    /// The multi_vm_group_name attribute.
    /// </summary>
    public TerraformProperty<string> MultiVmGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("multi_vm_group_name");
        set => SetProperty("multi_vm_group_name", value);
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
    /// The physical_server_credential_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalServerCredentialName is required")]
    public required TerraformProperty<string> PhysicalServerCredentialName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("physical_server_credential_name");
        set => SetProperty("physical_server_credential_name", value);
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    public required TerraformProperty<string> RecoveryReplicationPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_replication_policy_id");
        set => SetProperty("recovery_replication_policy_id", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformProperty<string> RecoveryVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_vault_id");
        set => SetProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_vm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmName is required")]
    public required TerraformProperty<string> SourceVmName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_vm_name");
        set => SetProperty("source_vm_name", value);
    }

    /// <summary>
    /// The target_availability_set_id attribute.
    /// </summary>
    public TerraformProperty<string> TargetAvailabilitySetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_availability_set_id");
        set => SetProperty("target_availability_set_id", value);
    }

    /// <summary>
    /// The target_boot_diagnostics_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string> TargetBootDiagnosticsStorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_boot_diagnostics_storage_account_id");
        set => SetProperty("target_boot_diagnostics_storage_account_id", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    public TerraformProperty<string> TargetNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_network_id");
        set => SetProperty("target_network_id", value);
    }

    /// <summary>
    /// The target_proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string> TargetProximityPlacementGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_proximity_placement_group_id");
        set => SetProperty("target_proximity_placement_group_id", value);
    }

    /// <summary>
    /// The target_resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceGroupId is required")]
    public required TerraformProperty<string> TargetResourceGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_resource_group_id");
        set => SetProperty("target_resource_group_id", value);
    }

    /// <summary>
    /// The target_vm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVmName is required")]
    public required TerraformProperty<string> TargetVmName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_vm_name");
        set => SetProperty("target_vm_name", value);
    }

    /// <summary>
    /// The target_vm_size attribute.
    /// </summary>
    public TerraformProperty<string> TargetVmSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_vm_size");
        set => SetProperty("target_vm_size", value);
    }

    /// <summary>
    /// The target_zone attribute.
    /// </summary>
    public TerraformProperty<string> TargetZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_zone");
        set => SetProperty("target_zone", value);
    }

    /// <summary>
    /// The test_network_id attribute.
    /// </summary>
    public TerraformProperty<string> TestNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("test_network_id");
        set => SetProperty("test_network_id", value);
    }

    /// <summary>
    /// Block for managed_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock>? ManagedDisk
    {
        set => SetProperty("managed_disk", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock>? NetworkInterface
    {
        set => SetProperty("network_interface", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
