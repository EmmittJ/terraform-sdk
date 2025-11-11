using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for managed_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock
{
    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskId is required")]
    [TerraformPropertyName("disk_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DiskId { get; set; }

    /// <summary>
    /// The log_storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("log_storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogStorageAccountId { get; set; }

    /// <summary>
    /// The target_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("target_disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The target_disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDiskType is required")]
    [TerraformPropertyName("target_disk_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetDiskType { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock
{
    /// <summary>
    /// The is_primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrimary is required")]
    [TerraformPropertyName("is_primary")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> IsPrimary { get; set; }

    /// <summary>
    /// The source_mac_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceMacAddress is required")]
    [TerraformPropertyName("source_mac_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceMacAddress { get; set; }

    /// <summary>
    /// The target_static_ip attribute.
    /// </summary>
    [TerraformPropertyName("target_static_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetStaticIp { get; set; }

    /// <summary>
    /// The target_subnet_name attribute.
    /// </summary>
    [TerraformPropertyName("target_subnet_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetSubnetName { get; set; }

    /// <summary>
    /// The test_subnet_name attribute.
    /// </summary>
    [TerraformPropertyName("test_subnet_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TestSubnetName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_site_recovery_vmware_replicated_vm resource.
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVm : TerraformResource
{
    public AzurermSiteRecoveryVmwareReplicatedVm(string name) : base("azurerm_site_recovery_vmware_replicated_vm", name)
    {
    }

    /// <summary>
    /// The appliance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplianceName is required")]
    [TerraformPropertyName("appliance_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApplianceName { get; set; }

    /// <summary>
    /// The default_log_storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("default_log_storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultLogStorageAccountId { get; set; }

    /// <summary>
    /// The default_recovery_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("default_recovery_disk_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultRecoveryDiskType { get; set; }

    /// <summary>
    /// The default_target_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("default_target_disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultTargetDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LicenseType { get; set; }

    /// <summary>
    /// The multi_vm_group_name attribute.
    /// </summary>
    [TerraformPropertyName("multi_vm_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MultiVmGroupName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The physical_server_credential_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalServerCredentialName is required")]
    [TerraformPropertyName("physical_server_credential_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PhysicalServerCredentialName { get; set; }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    [TerraformPropertyName("recovery_replication_policy_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RecoveryReplicationPolicyId { get; set; }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    [TerraformPropertyName("recovery_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RecoveryVaultId { get; set; }

    /// <summary>
    /// The source_vm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmName is required")]
    [TerraformPropertyName("source_vm_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceVmName { get; set; }

    /// <summary>
    /// The target_availability_set_id attribute.
    /// </summary>
    [TerraformPropertyName("target_availability_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetAvailabilitySetId { get; set; }

    /// <summary>
    /// The target_boot_diagnostics_storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("target_boot_diagnostics_storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetBootDiagnosticsStorageAccountId { get; set; }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    [TerraformPropertyName("target_network_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetNetworkId { get; set; }

    /// <summary>
    /// The target_proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("target_proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The target_resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceGroupId is required")]
    [TerraformPropertyName("target_resource_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetResourceGroupId { get; set; }

    /// <summary>
    /// The target_vm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVmName is required")]
    [TerraformPropertyName("target_vm_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetVmName { get; set; }

    /// <summary>
    /// The target_vm_size attribute.
    /// </summary>
    [TerraformPropertyName("target_vm_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetVmSize { get; set; }

    /// <summary>
    /// The target_zone attribute.
    /// </summary>
    [TerraformPropertyName("target_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetZone { get; set; }

    /// <summary>
    /// The test_network_id attribute.
    /// </summary>
    [TerraformPropertyName("test_network_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TestNetworkId { get; set; }

    /// <summary>
    /// Block for managed_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("managed_disk")]
    public TerraformList<TerraformBlock<AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock>>? ManagedDisk { get; set; }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_interface")]
    public TerraformList<TerraformBlock<AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock>>? NetworkInterface { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock>? Timeouts { get; set; }

}
