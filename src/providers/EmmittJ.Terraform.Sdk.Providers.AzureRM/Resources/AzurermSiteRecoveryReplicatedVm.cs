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
        SetOutput("id");
        SetOutput("managed_disk");
        SetOutput("multi_vm_group_name");
        SetOutput("name");
        SetOutput("network_interface");
        SetOutput("recovery_replication_policy_id");
        SetOutput("recovery_vault_name");
        SetOutput("resource_group_name");
        SetOutput("source_recovery_fabric_name");
        SetOutput("source_recovery_protection_container_name");
        SetOutput("source_vm_id");
        SetOutput("target_availability_set_id");
        SetOutput("target_boot_diagnostic_storage_account_id");
        SetOutput("target_capacity_reservation_group_id");
        SetOutput("target_edge_zone");
        SetOutput("target_network_id");
        SetOutput("target_proximity_placement_group_id");
        SetOutput("target_recovery_fabric_id");
        SetOutput("target_recovery_protection_container_id");
        SetOutput("target_resource_group_id");
        SetOutput("target_virtual_machine_scale_set_id");
        SetOutput("target_virtual_machine_size");
        SetOutput("target_zone");
        SetOutput("test_network_id");
        SetOutput("unmanaged_disk");
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
    /// The managed_disk attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>> ManagedDisk
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<object>>>("managed_disk");
        set => SetProperty("managed_disk", value);
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
    /// The network_interface attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>> NetworkInterface
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<object>>>("network_interface");
        set => SetProperty("network_interface", value);
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
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformProperty<string> RecoveryVaultName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_vault_name");
        set => SetProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricName is required")]
    public required TerraformProperty<string> SourceRecoveryFabricName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_recovery_fabric_name");
        set => SetProperty("source_recovery_fabric_name", value);
    }

    /// <summary>
    /// The source_recovery_protection_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryProtectionContainerName is required")]
    public required TerraformProperty<string> SourceRecoveryProtectionContainerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_recovery_protection_container_name");
        set => SetProperty("source_recovery_protection_container_name", value);
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmId is required")]
    public required TerraformProperty<string> SourceVmId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_vm_id");
        set => SetProperty("source_vm_id", value);
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
    /// The target_boot_diagnostic_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string> TargetBootDiagnosticStorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_boot_diagnostic_storage_account_id");
        set => SetProperty("target_boot_diagnostic_storage_account_id", value);
    }

    /// <summary>
    /// The target_capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string> TargetCapacityReservationGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_capacity_reservation_group_id");
        set => SetProperty("target_capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The target_edge_zone attribute.
    /// </summary>
    public TerraformProperty<string> TargetEdgeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_edge_zone");
        set => SetProperty("target_edge_zone", value);
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
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricId is required")]
    public required TerraformProperty<string> TargetRecoveryFabricId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_recovery_fabric_id");
        set => SetProperty("target_recovery_fabric_id", value);
    }

    /// <summary>
    /// The target_recovery_protection_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryProtectionContainerId is required")]
    public required TerraformProperty<string> TargetRecoveryProtectionContainerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_recovery_protection_container_id");
        set => SetProperty("target_recovery_protection_container_id", value);
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
    /// The target_virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformProperty<string> TargetVirtualMachineScaleSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_virtual_machine_scale_set_id");
        set => SetProperty("target_virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The target_virtual_machine_size attribute.
    /// </summary>
    public TerraformProperty<string> TargetVirtualMachineSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_virtual_machine_size");
        set => SetProperty("target_virtual_machine_size", value);
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
    /// The unmanaged_disk attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>> UnmanagedDisk
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<object>>>("unmanaged_disk");
        set => SetProperty("unmanaged_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryReplicatedVmTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
