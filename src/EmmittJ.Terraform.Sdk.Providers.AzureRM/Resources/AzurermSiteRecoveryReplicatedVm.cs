using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicatedVmTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_site_recovery_replicated_vm resource.
/// </summary>
public class AzurermSiteRecoveryReplicatedVm : TerraformResource
{
    public AzurermSiteRecoveryReplicatedVm(string name) : base("azurerm_site_recovery_replicated_vm", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The managed_disk attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>>? ManagedDisk
    {
        get => GetProperty<HashSet<TerraformProperty<object>>>("managed_disk");
        set => this.WithProperty("managed_disk", value);
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
    /// The network_interface attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>>? NetworkInterface
    {
        get => GetProperty<HashSet<TerraformProperty<object>>>("network_interface");
        set => this.WithProperty("network_interface", value);
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
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformProperty<string> RecoveryVaultName
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricName is required")]
    public required TerraformProperty<string> SourceRecoveryFabricName
    {
        get => GetProperty<TerraformProperty<string>>("source_recovery_fabric_name");
        set => this.WithProperty("source_recovery_fabric_name", value);
    }

    /// <summary>
    /// The source_recovery_protection_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryProtectionContainerName is required")]
    public required TerraformProperty<string> SourceRecoveryProtectionContainerName
    {
        get => GetProperty<TerraformProperty<string>>("source_recovery_protection_container_name");
        set => this.WithProperty("source_recovery_protection_container_name", value);
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmId is required")]
    public required TerraformProperty<string> SourceVmId
    {
        get => GetProperty<TerraformProperty<string>>("source_vm_id");
        set => this.WithProperty("source_vm_id", value);
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
    /// The target_boot_diagnostic_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetBootDiagnosticStorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("target_boot_diagnostic_storage_account_id");
        set => this.WithProperty("target_boot_diagnostic_storage_account_id", value);
    }

    /// <summary>
    /// The target_capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetCapacityReservationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("target_capacity_reservation_group_id");
        set => this.WithProperty("target_capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The target_edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TargetEdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("target_edge_zone");
        set => this.WithProperty("target_edge_zone", value);
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
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    public required TerraformProperty<string> TargetRecoveryFabricId
    {
        get => GetProperty<TerraformProperty<string>>("target_recovery_fabric_id");
        set => this.WithProperty("target_recovery_fabric_id", value);
    }

    /// <summary>
    /// The target_recovery_protection_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryProtectionContainerId is required")]
    public required TerraformProperty<string> TargetRecoveryProtectionContainerId
    {
        get => GetProperty<TerraformProperty<string>>("target_recovery_protection_container_id");
        set => this.WithProperty("target_recovery_protection_container_id", value);
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
    /// The target_virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetVirtualMachineScaleSetId
    {
        get => GetProperty<TerraformProperty<string>>("target_virtual_machine_scale_set_id");
        set => this.WithProperty("target_virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The target_virtual_machine_size attribute.
    /// </summary>
    public TerraformProperty<string>? TargetVirtualMachineSize
    {
        get => GetProperty<TerraformProperty<string>>("target_virtual_machine_size");
        set => this.WithProperty("target_virtual_machine_size", value);
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
    /// The unmanaged_disk attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>>? UnmanagedDisk
    {
        get => GetProperty<HashSet<TerraformProperty<object>>>("unmanaged_disk");
        set => this.WithProperty("unmanaged_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryReplicatedVmTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSiteRecoveryReplicatedVmTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
