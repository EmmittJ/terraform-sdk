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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_disk attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ManagedDisk
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "managed_disk").ResolveNodes(ctx));
        set => SetArgument("managed_disk", value);
    }

    /// <summary>
    /// The multi_vm_group_name attribute.
    /// </summary>
    public TerraformValue<string>? MultiVmGroupName
    {
        get => new TerraformReference<string>(this, "multi_vm_group_name");
        set => SetArgument("multi_vm_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NetworkInterface
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "network_interface").ResolveNodes(ctx));
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    public required TerraformValue<string> RecoveryReplicationPolicyId
    {
        get => new TerraformReference<string>(this, "recovery_replication_policy_id");
        set => SetArgument("recovery_replication_policy_id", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformValue<string> RecoveryVaultName
    {
        get => new TerraformReference<string>(this, "recovery_vault_name");
        set => SetArgument("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricName is required")]
    public required TerraformValue<string> SourceRecoveryFabricName
    {
        get => new TerraformReference<string>(this, "source_recovery_fabric_name");
        set => SetArgument("source_recovery_fabric_name", value);
    }

    /// <summary>
    /// The source_recovery_protection_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryProtectionContainerName is required")]
    public required TerraformValue<string> SourceRecoveryProtectionContainerName
    {
        get => new TerraformReference<string>(this, "source_recovery_protection_container_name");
        set => SetArgument("source_recovery_protection_container_name", value);
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmId is required")]
    public required TerraformValue<string> SourceVmId
    {
        get => new TerraformReference<string>(this, "source_vm_id");
        set => SetArgument("source_vm_id", value);
    }

    /// <summary>
    /// The target_availability_set_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetAvailabilitySetId
    {
        get => new TerraformReference<string>(this, "target_availability_set_id");
        set => SetArgument("target_availability_set_id", value);
    }

    /// <summary>
    /// The target_boot_diagnostic_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetBootDiagnosticStorageAccountId
    {
        get => new TerraformReference<string>(this, "target_boot_diagnostic_storage_account_id");
        set => SetArgument("target_boot_diagnostic_storage_account_id", value);
    }

    /// <summary>
    /// The target_capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetCapacityReservationGroupId
    {
        get => new TerraformReference<string>(this, "target_capacity_reservation_group_id");
        set => SetArgument("target_capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The target_edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? TargetEdgeZone
    {
        get => new TerraformReference<string>(this, "target_edge_zone");
        set => SetArgument("target_edge_zone", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    public TerraformValue<string> TargetNetworkId
    {
        get => new TerraformReference<string>(this, "target_network_id");
        set => SetArgument("target_network_id", value);
    }

    /// <summary>
    /// The target_proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "target_proximity_placement_group_id");
        set => SetArgument("target_proximity_placement_group_id", value);
    }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    public required TerraformValue<string> TargetRecoveryFabricId
    {
        get => new TerraformReference<string>(this, "target_recovery_fabric_id");
        set => SetArgument("target_recovery_fabric_id", value);
    }

    /// <summary>
    /// The target_recovery_protection_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryProtectionContainerId is required")]
    public required TerraformValue<string> TargetRecoveryProtectionContainerId
    {
        get => new TerraformReference<string>(this, "target_recovery_protection_container_id");
        set => SetArgument("target_recovery_protection_container_id", value);
    }

    /// <summary>
    /// The target_resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceGroupId is required")]
    public required TerraformValue<string> TargetResourceGroupId
    {
        get => new TerraformReference<string>(this, "target_resource_group_id");
        set => SetArgument("target_resource_group_id", value);
    }

    /// <summary>
    /// The target_virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetVirtualMachineScaleSetId
    {
        get => new TerraformReference<string>(this, "target_virtual_machine_scale_set_id");
        set => SetArgument("target_virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The target_virtual_machine_size attribute.
    /// </summary>
    public TerraformValue<string> TargetVirtualMachineSize
    {
        get => new TerraformReference<string>(this, "target_virtual_machine_size");
        set => SetArgument("target_virtual_machine_size", value);
    }

    /// <summary>
    /// The target_zone attribute.
    /// </summary>
    public TerraformValue<string>? TargetZone
    {
        get => new TerraformReference<string>(this, "target_zone");
        set => SetArgument("target_zone", value);
    }

    /// <summary>
    /// The test_network_id attribute.
    /// </summary>
    public TerraformValue<string> TestNetworkId
    {
        get => new TerraformReference<string>(this, "test_network_id");
        set => SetArgument("test_network_id", value);
    }

    /// <summary>
    /// The unmanaged_disk attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> UnmanagedDisk
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "unmanaged_disk").ResolveNodes(ctx));
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
