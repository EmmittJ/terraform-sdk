using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_vmware_replicated_vm resource.
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVm : TerraformResource
{
    public AzurermSiteRecoveryVmwareReplicatedVm(string name) : base("azurerm_site_recovery_vmware_replicated_vm", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The appliance_name attribute.
    /// </summary>
    public TerraformProperty<string>? ApplianceName
    {
        get => GetProperty<TerraformProperty<string>>("appliance_name");
        set => this.WithProperty("appliance_name", value);
    }

    /// <summary>
    /// The default_log_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultLogStorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("default_log_storage_account_id");
        set => this.WithProperty("default_log_storage_account_id", value);
    }

    /// <summary>
    /// The default_recovery_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRecoveryDiskType
    {
        get => GetProperty<TerraformProperty<string>>("default_recovery_disk_type");
        set => this.WithProperty("default_recovery_disk_type", value);
    }

    /// <summary>
    /// The default_target_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultTargetDiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("default_target_disk_encryption_set_id");
        set => this.WithProperty("default_target_disk_encryption_set_id", value);
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
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The physical_server_credential_name attribute.
    /// </summary>
    public TerraformProperty<string>? PhysicalServerCredentialName
    {
        get => GetProperty<TerraformProperty<string>>("physical_server_credential_name");
        set => this.WithProperty("physical_server_credential_name", value);
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryReplicationPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_replication_policy_id");
        set => this.WithProperty("recovery_replication_policy_id", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryVaultId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_vm_name attribute.
    /// </summary>
    public TerraformProperty<string>? SourceVmName
    {
        get => GetProperty<TerraformProperty<string>>("source_vm_name");
        set => this.WithProperty("source_vm_name", value);
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
    /// The target_boot_diagnostics_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetBootDiagnosticsStorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("target_boot_diagnostics_storage_account_id");
        set => this.WithProperty("target_boot_diagnostics_storage_account_id", value);
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
    /// The target_resource_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceGroupId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_group_id");
        set => this.WithProperty("target_resource_group_id", value);
    }

    /// <summary>
    /// The target_vm_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetVmName
    {
        get => GetProperty<TerraformProperty<string>>("target_vm_name");
        set => this.WithProperty("target_vm_name", value);
    }

    /// <summary>
    /// The target_vm_size attribute.
    /// </summary>
    public TerraformProperty<string>? TargetVmSize
    {
        get => GetProperty<TerraformProperty<string>>("target_vm_size");
        set => this.WithProperty("target_vm_size", value);
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

}
