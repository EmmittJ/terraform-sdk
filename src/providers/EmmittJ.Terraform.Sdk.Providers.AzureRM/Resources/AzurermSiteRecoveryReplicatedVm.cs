using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSiteRecoveryReplicatedVmTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_site_recovery_replicated_vm resource.
/// </summary>
public partial class AzurermSiteRecoveryReplicatedVm : TerraformResource
{
    public AzurermSiteRecoveryReplicatedVm(string name) : base("azurerm_site_recovery_replicated_vm", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_disk attribute.
    /// </summary>
    [TerraformProperty("managed_disk")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<object> ManagedDisk { get; set; }

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
    /// The network_interface attribute.
    /// </summary>
    [TerraformProperty("network_interface")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<object> NetworkInterface { get; set; }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    [TerraformProperty("recovery_replication_policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoveryReplicationPolicyId { get; set; }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    [TerraformProperty("recovery_vault_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoveryVaultName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricName is required")]
    [TerraformProperty("source_recovery_fabric_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceRecoveryFabricName { get; set; }

    /// <summary>
    /// The source_recovery_protection_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryProtectionContainerName is required")]
    [TerraformProperty("source_recovery_protection_container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceRecoveryProtectionContainerName { get; set; }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmId is required")]
    [TerraformProperty("source_vm_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceVmId { get; set; }

    /// <summary>
    /// The target_availability_set_id attribute.
    /// </summary>
    [TerraformProperty("target_availability_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetAvailabilitySetId { get; set; }

    /// <summary>
    /// The target_boot_diagnostic_storage_account_id attribute.
    /// </summary>
    [TerraformProperty("target_boot_diagnostic_storage_account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetBootDiagnosticStorageAccountId { get; set; }

    /// <summary>
    /// The target_capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformProperty("target_capacity_reservation_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetCapacityReservationGroupId { get; set; }

    /// <summary>
    /// The target_edge_zone attribute.
    /// </summary>
    [TerraformProperty("target_edge_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetEdgeZone { get; set; }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    [TerraformProperty("target_network_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TargetNetworkId { get; set; }

    /// <summary>
    /// The target_proximity_placement_group_id attribute.
    /// </summary>
    [TerraformProperty("target_proximity_placement_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    [TerraformProperty("target_recovery_fabric_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetRecoveryFabricId { get; set; }

    /// <summary>
    /// The target_recovery_protection_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryProtectionContainerId is required")]
    [TerraformProperty("target_recovery_protection_container_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetRecoveryProtectionContainerId { get; set; }

    /// <summary>
    /// The target_resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceGroupId is required")]
    [TerraformProperty("target_resource_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetResourceGroupId { get; set; }

    /// <summary>
    /// The target_virtual_machine_scale_set_id attribute.
    /// </summary>
    [TerraformProperty("target_virtual_machine_scale_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetVirtualMachineScaleSetId { get; set; }

    /// <summary>
    /// The target_virtual_machine_size attribute.
    /// </summary>
    [TerraformProperty("target_virtual_machine_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TargetVirtualMachineSize { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TestNetworkId { get; set; }

    /// <summary>
    /// The unmanaged_disk attribute.
    /// </summary>
    [TerraformProperty("unmanaged_disk")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<object> UnmanagedDisk { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSiteRecoveryReplicatedVmTimeoutsBlock Timeouts { get; set; } = new();

}
