using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicatedVmTimeoutsBlock
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
/// Manages a azurerm_site_recovery_replicated_vm resource.
/// </summary>
public class AzurermSiteRecoveryReplicatedVm : TerraformResource
{
    public AzurermSiteRecoveryReplicatedVm(string name) : base("azurerm_site_recovery_replicated_vm", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The managed_disk attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<object> ManagedDisk { get; set; } = default!;

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
    /// The network_interface attribute.
    /// </summary>
    [TerraformPropertyName("network_interface")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<object> NetworkInterface { get; set; } = default!;

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    [TerraformPropertyName("recovery_replication_policy_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RecoveryReplicationPolicyId { get; set; }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    [TerraformPropertyName("recovery_vault_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RecoveryVaultName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricName is required")]
    [TerraformPropertyName("source_recovery_fabric_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceRecoveryFabricName { get; set; }

    /// <summary>
    /// The source_recovery_protection_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryProtectionContainerName is required")]
    [TerraformPropertyName("source_recovery_protection_container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceRecoveryProtectionContainerName { get; set; }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmId is required")]
    [TerraformPropertyName("source_vm_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceVmId { get; set; }

    /// <summary>
    /// The target_availability_set_id attribute.
    /// </summary>
    [TerraformPropertyName("target_availability_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetAvailabilitySetId { get; set; }

    /// <summary>
    /// The target_boot_diagnostic_storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("target_boot_diagnostic_storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetBootDiagnosticStorageAccountId { get; set; }

    /// <summary>
    /// The target_capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformPropertyName("target_capacity_reservation_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetCapacityReservationGroupId { get; set; }

    /// <summary>
    /// The target_edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("target_edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetEdgeZone { get; set; }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    [TerraformPropertyName("target_network_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TargetNetworkId { get; set; } = default!;

    /// <summary>
    /// The target_proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("target_proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    [TerraformPropertyName("target_recovery_fabric_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetRecoveryFabricId { get; set; }

    /// <summary>
    /// The target_recovery_protection_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryProtectionContainerId is required")]
    [TerraformPropertyName("target_recovery_protection_container_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetRecoveryProtectionContainerId { get; set; }

    /// <summary>
    /// The target_resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceGroupId is required")]
    [TerraformPropertyName("target_resource_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetResourceGroupId { get; set; }

    /// <summary>
    /// The target_virtual_machine_scale_set_id attribute.
    /// </summary>
    [TerraformPropertyName("target_virtual_machine_scale_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetVirtualMachineScaleSetId { get; set; }

    /// <summary>
    /// The target_virtual_machine_size attribute.
    /// </summary>
    [TerraformPropertyName("target_virtual_machine_size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TargetVirtualMachineSize { get; set; } = default!;

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TestNetworkId { get; set; } = default!;

    /// <summary>
    /// The unmanaged_disk attribute.
    /// </summary>
    [TerraformPropertyName("unmanaged_disk")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<object> UnmanagedDisk { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSiteRecoveryReplicatedVmTimeoutsBlock>? Timeouts { get; set; }

}
