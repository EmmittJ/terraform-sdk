using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSiteRecoveryReplicatedVm.
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicatedVmTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_site_recovery_replicated_vm Terraform resource.
/// Manages a azurerm_site_recovery_replicated_vm resource.
/// </summary>
public partial class AzurermSiteRecoveryReplicatedVm(string name) : TerraformResource("azurerm_site_recovery_replicated_vm", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_disk attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>>? ManagedDisk
    {
        get => GetArgument<TerraformSet<TerraformMap<object>>>("managed_disk");
        set => SetArgument("managed_disk", value);
    }

    /// <summary>
    /// The multi_vm_group_name attribute.
    /// </summary>
    public TerraformValue<string>? MultiVmGroupName
    {
        get => GetArgument<TerraformValue<string>>("multi_vm_group_name");
        set => SetArgument("multi_vm_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>>? NetworkInterface
    {
        get => GetArgument<TerraformSet<TerraformMap<object>>>("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    public required TerraformValue<string> RecoveryReplicationPolicyId
    {
        get => GetArgument<TerraformValue<string>>("recovery_replication_policy_id");
        set => SetArgument("recovery_replication_policy_id", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformValue<string> RecoveryVaultName
    {
        get => GetArgument<TerraformValue<string>>("recovery_vault_name");
        set => SetArgument("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricName is required")]
    public required TerraformValue<string> SourceRecoveryFabricName
    {
        get => GetArgument<TerraformValue<string>>("source_recovery_fabric_name");
        set => SetArgument("source_recovery_fabric_name", value);
    }

    /// <summary>
    /// The source_recovery_protection_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryProtectionContainerName is required")]
    public required TerraformValue<string> SourceRecoveryProtectionContainerName
    {
        get => GetArgument<TerraformValue<string>>("source_recovery_protection_container_name");
        set => SetArgument("source_recovery_protection_container_name", value);
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmId is required")]
    public required TerraformValue<string> SourceVmId
    {
        get => GetArgument<TerraformValue<string>>("source_vm_id");
        set => SetArgument("source_vm_id", value);
    }

    /// <summary>
    /// The target_availability_set_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetAvailabilitySetId
    {
        get => GetArgument<TerraformValue<string>>("target_availability_set_id");
        set => SetArgument("target_availability_set_id", value);
    }

    /// <summary>
    /// The target_boot_diagnostic_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetBootDiagnosticStorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("target_boot_diagnostic_storage_account_id");
        set => SetArgument("target_boot_diagnostic_storage_account_id", value);
    }

    /// <summary>
    /// The target_capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetCapacityReservationGroupId
    {
        get => GetArgument<TerraformValue<string>>("target_capacity_reservation_group_id");
        set => SetArgument("target_capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The target_edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? TargetEdgeZone
    {
        get => GetArgument<TerraformValue<string>>("target_edge_zone");
        set => SetArgument("target_edge_zone", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetNetworkId
    {
        get => GetArgument<TerraformValue<string>>("target_network_id");
        set => SetArgument("target_network_id", value);
    }

    /// <summary>
    /// The target_proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetProximityPlacementGroupId
    {
        get => GetArgument<TerraformValue<string>>("target_proximity_placement_group_id");
        set => SetArgument("target_proximity_placement_group_id", value);
    }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    public required TerraformValue<string> TargetRecoveryFabricId
    {
        get => GetArgument<TerraformValue<string>>("target_recovery_fabric_id");
        set => SetArgument("target_recovery_fabric_id", value);
    }

    /// <summary>
    /// The target_recovery_protection_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryProtectionContainerId is required")]
    public required TerraformValue<string> TargetRecoveryProtectionContainerId
    {
        get => GetArgument<TerraformValue<string>>("target_recovery_protection_container_id");
        set => SetArgument("target_recovery_protection_container_id", value);
    }

    /// <summary>
    /// The target_resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceGroupId is required")]
    public required TerraformValue<string> TargetResourceGroupId
    {
        get => GetArgument<TerraformValue<string>>("target_resource_group_id");
        set => SetArgument("target_resource_group_id", value);
    }

    /// <summary>
    /// The target_virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetVirtualMachineScaleSetId
    {
        get => GetArgument<TerraformValue<string>>("target_virtual_machine_scale_set_id");
        set => SetArgument("target_virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The target_virtual_machine_size attribute.
    /// </summary>
    public TerraformValue<string>? TargetVirtualMachineSize
    {
        get => GetArgument<TerraformValue<string>>("target_virtual_machine_size");
        set => SetArgument("target_virtual_machine_size", value);
    }

    /// <summary>
    /// The target_zone attribute.
    /// </summary>
    public TerraformValue<string>? TargetZone
    {
        get => GetArgument<TerraformValue<string>>("target_zone");
        set => SetArgument("target_zone", value);
    }

    /// <summary>
    /// The test_network_id attribute.
    /// </summary>
    public TerraformValue<string>? TestNetworkId
    {
        get => GetArgument<TerraformValue<string>>("test_network_id");
        set => SetArgument("test_network_id", value);
    }

    /// <summary>
    /// The unmanaged_disk attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>>? UnmanagedDisk
    {
        get => GetArgument<TerraformSet<TerraformMap<object>>>("unmanaged_disk");
        set => SetArgument("unmanaged_disk", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSiteRecoveryReplicatedVmTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSiteRecoveryReplicatedVmTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
