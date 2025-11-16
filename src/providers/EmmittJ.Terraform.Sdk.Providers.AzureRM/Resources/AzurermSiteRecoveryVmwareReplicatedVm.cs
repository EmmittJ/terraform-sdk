using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for managed_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_disk";

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskId is required")]
    public required TerraformValue<string> DiskId
    {
        get => new TerraformReference<string>(this, "disk_id");
        set => SetArgument("disk_id", value);
    }

    /// <summary>
    /// The log_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? LogStorageAccountId
    {
        get => new TerraformReference<string>(this, "log_storage_account_id");
        set => SetArgument("log_storage_account_id", value);
    }

    /// <summary>
    /// The target_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetDiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "target_disk_encryption_set_id");
        set => SetArgument("target_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The target_disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDiskType is required")]
    public required TerraformValue<string> TargetDiskType
    {
        get => new TerraformReference<string>(this, "target_disk_type");
        set => SetArgument("target_disk_type", value);
    }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface";

    /// <summary>
    /// The is_primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrimary is required")]
    public required TerraformValue<bool> IsPrimary
    {
        get => new TerraformReference<bool>(this, "is_primary");
        set => SetArgument("is_primary", value);
    }

    /// <summary>
    /// The source_mac_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceMacAddress is required")]
    public required TerraformValue<string> SourceMacAddress
    {
        get => new TerraformReference<string>(this, "source_mac_address");
        set => SetArgument("source_mac_address", value);
    }

    /// <summary>
    /// The target_static_ip attribute.
    /// </summary>
    public TerraformValue<string>? TargetStaticIp
    {
        get => new TerraformReference<string>(this, "target_static_ip");
        set => SetArgument("target_static_ip", value);
    }

    /// <summary>
    /// The target_subnet_name attribute.
    /// </summary>
    public TerraformValue<string>? TargetSubnetName
    {
        get => new TerraformReference<string>(this, "target_subnet_name");
        set => SetArgument("target_subnet_name", value);
    }

    /// <summary>
    /// The test_subnet_name attribute.
    /// </summary>
    public TerraformValue<string>? TestSubnetName
    {
        get => new TerraformReference<string>(this, "test_subnet_name");
        set => SetArgument("test_subnet_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_site_recovery_vmware_replicated_vm Terraform resource.
/// Manages a azurerm_site_recovery_vmware_replicated_vm resource.
/// </summary>
public partial class AzurermSiteRecoveryVmwareReplicatedVm(string name) : TerraformResource("azurerm_site_recovery_vmware_replicated_vm", name)
{
    /// <summary>
    /// The appliance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplianceName is required")]
    public required TerraformValue<string> ApplianceName
    {
        get => new TerraformReference<string>(this, "appliance_name");
        set => SetArgument("appliance_name", value);
    }

    /// <summary>
    /// The default_log_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? DefaultLogStorageAccountId
    {
        get => new TerraformReference<string>(this, "default_log_storage_account_id");
        set => SetArgument("default_log_storage_account_id", value);
    }

    /// <summary>
    /// The default_recovery_disk_type attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRecoveryDiskType
    {
        get => new TerraformReference<string>(this, "default_recovery_disk_type");
        set => SetArgument("default_recovery_disk_type", value);
    }

    /// <summary>
    /// The default_target_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DefaultTargetDiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "default_target_disk_encryption_set_id");
        set => SetArgument("default_target_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string>? LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
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
    /// The physical_server_credential_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalServerCredentialName is required")]
    public required TerraformValue<string> PhysicalServerCredentialName
    {
        get => new TerraformReference<string>(this, "physical_server_credential_name");
        set => SetArgument("physical_server_credential_name", value);
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
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformValue<string> RecoveryVaultId
    {
        get => new TerraformReference<string>(this, "recovery_vault_id");
        set => SetArgument("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_vm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVmName is required")]
    public required TerraformValue<string> SourceVmName
    {
        get => new TerraformReference<string>(this, "source_vm_name");
        set => SetArgument("source_vm_name", value);
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
    /// The target_boot_diagnostics_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetBootDiagnosticsStorageAccountId
    {
        get => new TerraformReference<string>(this, "target_boot_diagnostics_storage_account_id");
        set => SetArgument("target_boot_diagnostics_storage_account_id", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    public TerraformValue<string>? TargetNetworkId
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
    /// The target_resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceGroupId is required")]
    public required TerraformValue<string> TargetResourceGroupId
    {
        get => new TerraformReference<string>(this, "target_resource_group_id");
        set => SetArgument("target_resource_group_id", value);
    }

    /// <summary>
    /// The target_vm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVmName is required")]
    public required TerraformValue<string> TargetVmName
    {
        get => new TerraformReference<string>(this, "target_vm_name");
        set => SetArgument("target_vm_name", value);
    }

    /// <summary>
    /// The target_vm_size attribute.
    /// </summary>
    public TerraformValue<string>? TargetVmSize
    {
        get => new TerraformReference<string>(this, "target_vm_size");
        set => SetArgument("target_vm_size", value);
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
    public TerraformValue<string>? TestNetworkId
    {
        get => new TerraformReference<string>(this, "test_network_id");
        set => SetArgument("test_network_id", value);
    }

    /// <summary>
    /// ManagedDisk block (nesting mode: list).
    /// </summary>
    public AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock? ManagedDisk
    {
        get => GetArgument<AzurermSiteRecoveryVmwareReplicatedVmManagedDiskBlock>("managed_disk");
        set => SetArgument("managed_disk", value);
    }

    /// <summary>
    /// NetworkInterface block (nesting mode: list).
    /// </summary>
    public AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock? NetworkInterface
    {
        get => GetArgument<AzurermSiteRecoveryVmwareReplicatedVmNetworkInterfaceBlock>("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSiteRecoveryVmwareReplicatedVmTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
