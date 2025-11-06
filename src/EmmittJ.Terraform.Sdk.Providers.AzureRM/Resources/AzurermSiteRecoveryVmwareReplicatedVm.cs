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
    public string? ApplianceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("appliance_name")?.Value;
        set => this.WithProperty("appliance_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_log_storage_account_id attribute.
    /// </summary>
    public string? DefaultLogStorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_log_storage_account_id")?.Value;
        set => this.WithProperty("default_log_storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_recovery_disk_type attribute.
    /// </summary>
    public string? DefaultRecoveryDiskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_recovery_disk_type")?.Value;
        set => this.WithProperty("default_recovery_disk_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_target_disk_encryption_set_id attribute.
    /// </summary>
    public string? DefaultTargetDiskEncryptionSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_target_disk_encryption_set_id")?.Value;
        set => this.WithProperty("default_target_disk_encryption_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The license_type attribute.
    /// </summary>
    public string? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type")?.Value;
        set => this.WithProperty("license_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The physical_server_credential_name attribute.
    /// </summary>
    public string? PhysicalServerCredentialName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("physical_server_credential_name")?.Value;
        set => this.WithProperty("physical_server_credential_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The recovery_vault_id attribute.
    /// </summary>
    public string? RecoveryVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_id")?.Value;
        set => this.WithProperty("recovery_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_vm_name attribute.
    /// </summary>
    public string? SourceVmName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_vm_name")?.Value;
        set => this.WithProperty("source_vm_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_boot_diagnostics_storage_account_id attribute.
    /// </summary>
    public string? TargetBootDiagnosticsStorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_boot_diagnostics_storage_account_id")?.Value;
        set => this.WithProperty("target_boot_diagnostics_storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_resource_group_id attribute.
    /// </summary>
    public string? TargetResourceGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_group_id")?.Value;
        set => this.WithProperty("target_resource_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_vm_name attribute.
    /// </summary>
    public string? TargetVmName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_vm_name")?.Value;
        set => this.WithProperty("target_vm_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_vm_size attribute.
    /// </summary>
    public string? TargetVmSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_vm_size")?.Value;
        set => this.WithProperty("target_vm_size", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}
