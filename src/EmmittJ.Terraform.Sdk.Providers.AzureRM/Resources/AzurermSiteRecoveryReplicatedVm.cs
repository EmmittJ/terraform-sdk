using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The managed_disk attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<object>>? ManagedDisk
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("managed_disk");
        set => this.WithProperty("managed_disk", value);
    }

    /// <summary>
    /// The multi_vm_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MultiVmGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("multi_vm_group_name");
        set => this.WithProperty("multi_vm_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<object>>? NetworkInterface
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("network_interface");
        set => this.WithProperty("network_interface", value);
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoveryReplicationPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_replication_policy_id");
        set => this.WithProperty("recovery_replication_policy_id", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoveryVaultName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceRecoveryFabricName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_recovery_fabric_name");
        set => this.WithProperty("source_recovery_fabric_name", value);
    }

    /// <summary>
    /// The source_recovery_protection_container_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceRecoveryProtectionContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_recovery_protection_container_name");
        set => this.WithProperty("source_recovery_protection_container_name", value);
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceVmId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_vm_id");
        set => this.WithProperty("source_vm_id", value);
    }

    /// <summary>
    /// The target_availability_set_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetAvailabilitySetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_availability_set_id");
        set => this.WithProperty("target_availability_set_id", value);
    }

    /// <summary>
    /// The target_boot_diagnostic_storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetBootDiagnosticStorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_boot_diagnostic_storage_account_id");
        set => this.WithProperty("target_boot_diagnostic_storage_account_id", value);
    }

    /// <summary>
    /// The target_capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetCapacityReservationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_capacity_reservation_group_id");
        set => this.WithProperty("target_capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The target_edge_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetEdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_edge_zone");
        set => this.WithProperty("target_edge_zone", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_network_id");
        set => this.WithProperty("target_network_id", value);
    }

    /// <summary>
    /// The target_proximity_placement_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetProximityPlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_proximity_placement_group_id");
        set => this.WithProperty("target_proximity_placement_group_id", value);
    }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetRecoveryFabricId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_recovery_fabric_id");
        set => this.WithProperty("target_recovery_fabric_id", value);
    }

    /// <summary>
    /// The target_recovery_protection_container_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetRecoveryProtectionContainerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_recovery_protection_container_id");
        set => this.WithProperty("target_recovery_protection_container_id", value);
    }

    /// <summary>
    /// The target_resource_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetResourceGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_group_id");
        set => this.WithProperty("target_resource_group_id", value);
    }

    /// <summary>
    /// The target_virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetVirtualMachineScaleSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_virtual_machine_scale_set_id");
        set => this.WithProperty("target_virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The target_virtual_machine_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetVirtualMachineSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_virtual_machine_size");
        set => this.WithProperty("target_virtual_machine_size", value);
    }

    /// <summary>
    /// The target_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_zone");
        set => this.WithProperty("target_zone", value);
    }

    /// <summary>
    /// The test_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TestNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("test_network_id");
        set => this.WithProperty("test_network_id", value);
    }

    /// <summary>
    /// The unmanaged_disk attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<object>>? UnmanagedDisk
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("unmanaged_disk");
        set => this.WithProperty("unmanaged_disk", value);
    }

}
