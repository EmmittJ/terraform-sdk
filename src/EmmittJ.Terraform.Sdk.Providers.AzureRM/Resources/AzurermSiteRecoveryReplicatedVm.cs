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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_disk attribute.
    /// </summary>
    public HashSet<object>? ManagedDisk
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("managed_disk")?.Value;
        set => this.WithProperty("managed_disk", value == null ? null : new TerraformLiteralProperty<HashSet<object>>(value));
    }

    /// <summary>
    /// The multi_vm_group_name attribute.
    /// </summary>
    public string? MultiVmGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("multi_vm_group_name")?.Value;
        set => this.WithProperty("multi_vm_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public HashSet<object>? NetworkInterface
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("network_interface")?.Value;
        set => this.WithProperty("network_interface", value == null ? null : new TerraformLiteralProperty<HashSet<object>>(value));
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    public string? RecoveryReplicationPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_replication_policy_id")?.Value;
        set => this.WithProperty("recovery_replication_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    public string? RecoveryVaultName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_name")?.Value;
        set => this.WithProperty("recovery_vault_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    public string? SourceRecoveryFabricName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_recovery_fabric_name")?.Value;
        set => this.WithProperty("source_recovery_fabric_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_recovery_protection_container_name attribute.
    /// </summary>
    public string? SourceRecoveryProtectionContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_recovery_protection_container_name")?.Value;
        set => this.WithProperty("source_recovery_protection_container_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    public string? SourceVmId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_vm_id")?.Value;
        set => this.WithProperty("source_vm_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_availability_set_id attribute.
    /// </summary>
    public string? TargetAvailabilitySetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_availability_set_id")?.Value;
        set => this.WithProperty("target_availability_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_boot_diagnostic_storage_account_id attribute.
    /// </summary>
    public string? TargetBootDiagnosticStorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_boot_diagnostic_storage_account_id")?.Value;
        set => this.WithProperty("target_boot_diagnostic_storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_capacity_reservation_group_id attribute.
    /// </summary>
    public string? TargetCapacityReservationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_capacity_reservation_group_id")?.Value;
        set => this.WithProperty("target_capacity_reservation_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_edge_zone attribute.
    /// </summary>
    public string? TargetEdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_edge_zone")?.Value;
        set => this.WithProperty("target_edge_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    public string? TargetNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_network_id")?.Value;
        set => this.WithProperty("target_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_proximity_placement_group_id attribute.
    /// </summary>
    public string? TargetProximityPlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_proximity_placement_group_id")?.Value;
        set => this.WithProperty("target_proximity_placement_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    public string? TargetRecoveryFabricId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_recovery_fabric_id")?.Value;
        set => this.WithProperty("target_recovery_fabric_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_recovery_protection_container_id attribute.
    /// </summary>
    public string? TargetRecoveryProtectionContainerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_recovery_protection_container_id")?.Value;
        set => this.WithProperty("target_recovery_protection_container_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_resource_group_id attribute.
    /// </summary>
    public string? TargetResourceGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_group_id")?.Value;
        set => this.WithProperty("target_resource_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_virtual_machine_scale_set_id attribute.
    /// </summary>
    public string? TargetVirtualMachineScaleSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_virtual_machine_scale_set_id")?.Value;
        set => this.WithProperty("target_virtual_machine_scale_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_virtual_machine_size attribute.
    /// </summary>
    public string? TargetVirtualMachineSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_virtual_machine_size")?.Value;
        set => this.WithProperty("target_virtual_machine_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_zone attribute.
    /// </summary>
    public string? TargetZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_zone")?.Value;
        set => this.WithProperty("target_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The test_network_id attribute.
    /// </summary>
    public string? TestNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("test_network_id")?.Value;
        set => this.WithProperty("test_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unmanaged_disk attribute.
    /// </summary>
    public HashSet<object>? UnmanagedDisk
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("unmanaged_disk")?.Value;
        set => this.WithProperty("unmanaged_disk", value == null ? null : new TerraformLiteralProperty<HashSet<object>>(value));
    }

}
