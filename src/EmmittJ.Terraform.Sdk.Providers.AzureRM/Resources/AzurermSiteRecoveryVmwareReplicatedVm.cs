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
    public TerraformLiteralProperty<string>? ApplianceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("appliance_name");
        set => this.WithProperty("appliance_name", value);
    }

    /// <summary>
    /// The default_log_storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultLogStorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_log_storage_account_id");
        set => this.WithProperty("default_log_storage_account_id", value);
    }

    /// <summary>
    /// The default_recovery_disk_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultRecoveryDiskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_recovery_disk_type");
        set => this.WithProperty("default_recovery_disk_type", value);
    }

    /// <summary>
    /// The default_target_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultTargetDiskEncryptionSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_target_disk_encryption_set_id");
        set => this.WithProperty("default_target_disk_encryption_set_id", value);
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
    /// The license_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
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
    /// The physical_server_credential_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PhysicalServerCredentialName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("physical_server_credential_name");
        set => this.WithProperty("physical_server_credential_name", value);
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
    /// The recovery_vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoveryVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_vm_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceVmName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_vm_name");
        set => this.WithProperty("source_vm_name", value);
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
    /// The target_boot_diagnostics_storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetBootDiagnosticsStorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_boot_diagnostics_storage_account_id");
        set => this.WithProperty("target_boot_diagnostics_storage_account_id", value);
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
    /// The target_resource_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetResourceGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_group_id");
        set => this.WithProperty("target_resource_group_id", value);
    }

    /// <summary>
    /// The target_vm_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetVmName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_vm_name");
        set => this.WithProperty("target_vm_name", value);
    }

    /// <summary>
    /// The target_vm_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetVmSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_vm_size");
        set => this.WithProperty("target_vm_size", value);
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

}
