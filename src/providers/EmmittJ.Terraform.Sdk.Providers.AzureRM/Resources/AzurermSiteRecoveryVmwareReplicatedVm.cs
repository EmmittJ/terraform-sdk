using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for managed_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskId is required")]
    [TerraformProperty("disk_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DiskId { get; set; }

    /// <summary>
    /// The log_storage_account_id attribute.
    /// </summary>
    [TerraformProperty("log_storage_account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogStorageAccountId { get; set; }

    /// <summary>
    /// The target_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("target_disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The target_disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDiskType is required")]
    [TerraformProperty("target_disk_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetDiskType { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock : TerraformBlockBase
{
    /// <summary>
    /// The is_primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrimary is required")]
    [TerraformProperty("is_primary")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsPrimary { get; set; }

    /// <summary>
    /// The source_mac_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceMacAddress is required")]
    [TerraformProperty("source_mac_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceMacAddress { get; set; }

    /// <summary>
    /// The target_static_ip attribute.
    /// </summary>
    [TerraformProperty("target_static_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetStaticIp { get; set; }

    /// <summary>
    /// The target_subnet_name attribute.
    /// </summary>
    [TerraformProperty("target_subnet_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetSubnetName { get; set; }

    /// <summary>
    /// The test_subnet_name attribute.
    /// </summary>
    [TerraformProperty("test_subnet_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TestSubnetName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_site_recovery_vmware_replicated_vm resource.
/// </summary>
public partial class AzurermSiteRecoveryVmwareReplicatedVm : TerraformResource
{
    public AzurermSiteRecoveryVmwareReplicatedVm(string name) : base("azurerm_site_recovery_vmware_replicated_vm", name)
    {
    }

    /// <summary>
    /// The appliance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplianceName is required")]
    [TerraformProperty("appliance_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplianceName { get; set; }

    /// <summary>
    /// The default_log_storage_account_id attribute.
    /// </summary>
    [TerraformProperty("default_log_storage_account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultLogStorageAccountId { get; set; }

    /// <summary>
    /// The default_recovery_disk_type attribute.
    /// </summary>
    [TerraformProperty("default_recovery_disk_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultRecoveryDiskType { get; set; }

    /// <summary>
    /// The default_target_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("default_target_disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultTargetDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LicenseType { get; set; }

    /// <summary>
    /// The multi_vm_group_name attribute.
    /// </summary>
    [TerraformProperty("multi_vm_group_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MultiVmGroupName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The physical_server_credential_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalServerCredentialName is required")]
    [TerraformProperty("physical_server_credential_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PhysicalServerCredentialName { get; set; }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    [TerraformProperty("recovery_replication_policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoveryReplicationPolicyId { get; set; }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    [TerraformProperty("recovery_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoveryVaultId { get; set; }

    /// <summary>
    /// The source_vm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmName is required")]
    [TerraformProperty("source_vm_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceVmName { get; set; }

    /// <summary>
    /// The target_availability_set_id attribute.
    /// </summary>
    [TerraformProperty("target_availability_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetAvailabilitySetId { get; set; }

    /// <summary>
    /// The target_boot_diagnostics_storage_account_id attribute.
    /// </summary>
    [TerraformProperty("target_boot_diagnostics_storage_account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetBootDiagnosticsStorageAccountId { get; set; }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    [TerraformProperty("target_network_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetNetworkId { get; set; }

    /// <summary>
    /// The target_proximity_placement_group_id attribute.
    /// </summary>
    [TerraformProperty("target_proximity_placement_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The target_resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceGroupId is required")]
    [TerraformProperty("target_resource_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetResourceGroupId { get; set; }

    /// <summary>
    /// The target_vm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVmName is required")]
    [TerraformProperty("target_vm_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetVmName { get; set; }

    /// <summary>
    /// The target_vm_size attribute.
    /// </summary>
    [TerraformProperty("target_vm_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetVmSize { get; set; }

    /// <summary>
    /// The target_zone attribute.
    /// </summary>
    [TerraformProperty("target_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetZone { get; set; }

    /// <summary>
    /// The test_network_id attribute.
    /// </summary>
    [TerraformProperty("test_network_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TestNetworkId { get; set; }

    /// <summary>
    /// Block for managed_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("managed_disk")]
    public partial TerraformList<TerraformBlock<AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock>>? ManagedDisk { get; set; }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("network_interface")]
    public partial TerraformList<TerraformBlock<AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock>>? NetworkInterface { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock>? Timeouts { get; set; }

}
