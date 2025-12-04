using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for additional_capabilities in AzurermLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_capabilities";

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HibernationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("hibernation_enabled");
        set => SetArgument("hibernation_enabled", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UltraSsdEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ultra_ssd_enabled");
        set => SetArgument("ultra_ssd_enabled", value);
    }

}


/// <summary>
/// Block type for admin_ssh_key in AzurermLinuxVirtualMachine.
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineAdminSshKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_ssh_key";

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    public required TerraformValue<string> PublicKey
    {
        get => GetArgument<TerraformValue<string>>("public_key");
        set => SetArgument("public_key", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for boot_diagnostics in AzurermLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineBootDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_diagnostics";

    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountUri
    {
        get => GetArgument<TerraformValue<string>>("storage_account_uri");
        set => SetArgument("storage_account_uri", value);
    }

}


/// <summary>
/// Block type for gallery_application in AzurermLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineGalleryApplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gallery_application";

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticUpgradeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("automatic_upgrade_enabled");
        set => SetArgument("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationBlobUri
    {
        get => GetArgument<TerraformValue<string>>("configuration_blob_uri");
        set => SetArgument("configuration_blob_uri", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformValue<double>? Order
    {
        get => GetArgument<TerraformValue<double>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The treat_failure_as_deployment_failure_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TreatFailureAsDeploymentFailureEnabled
    {
        get => GetArgument<TerraformValue<bool>>("treat_failure_as_deployment_failure_enabled");
        set => SetArgument("treat_failure_as_deployment_failure_enabled", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    public required TerraformValue<string> VersionId
    {
        get => GetArgument<TerraformValue<string>>("version_id");
        set => SetArgument("version_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for os_disk in AzurermLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_disk";

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformValue<string> Caching
    {
        get => GetArgument<TerraformValue<string>>("caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double>? DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? SecureVmDiskEncryptionSetId
    {
        get => GetArgument<TerraformValue<string>>("secure_vm_disk_encryption_set_id");
        set => SetArgument("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    public TerraformValue<string>? SecurityEncryptionType
    {
        get => GetArgument<TerraformValue<string>>("security_encryption_type");
        set => SetArgument("security_encryption_type", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountType
    {
        get => GetArgument<TerraformValue<string>>("storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => GetArgument<TerraformValue<bool>>("write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

    /// <summary>
    /// DiffDiskSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiffDiskSettings block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineOsDiskBlockDiffDiskSettingsBlock>? DiffDiskSettings
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineOsDiskBlockDiffDiskSettingsBlock>>("diff_disk_settings");
        set => SetArgument("diff_disk_settings", value);
    }

}

/// <summary>
/// Block type for diff_disk_settings in AzurermLinuxVirtualMachineOsDiskBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineOsDiskBlockDiffDiskSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "diff_disk_settings";

    /// <summary>
    /// The option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Option is required")]
    public required TerraformValue<string> Option
    {
        get => GetArgument<TerraformValue<string>>("option");
        set => SetArgument("option", value);
    }

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformValue<string>? Placement
    {
        get => GetArgument<TerraformValue<string>>("placement");
        set => SetArgument("placement", value);
    }

}


/// <summary>
/// Block type for os_image_notification in AzurermLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineOsImageNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_image_notification";

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

}


/// <summary>
/// Block type for plan in AzurermLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachinePlanBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plan";

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
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformValue<string> Product
    {
        get => GetArgument<TerraformValue<string>>("product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

}


/// <summary>
/// Block type for secret in AzurermLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Certificate block(s) required")]
    public required TerraformSet<AzurermLinuxVirtualMachineSecretBlockCertificateBlock> Certificate
    {
        get => GetRequiredArgument<TerraformSet<AzurermLinuxVirtualMachineSecretBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

}

/// <summary>
/// Block type for certificate in AzurermLinuxVirtualMachineSecretBlock.
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineSecretBlockCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for source_image_reference in AzurermLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineSourceImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_image_reference";

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformValue<string> Offer
    {
        get => GetArgument<TerraformValue<string>>("offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for termination_notification in AzurermLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineTerminationNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "termination_notification";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermLinuxVirtualMachine.
/// Nesting mode: single
/// </summary>
public class AzurermLinuxVirtualMachineTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_linux_virtual_machine Terraform resource.
/// Manages a azurerm_linux_virtual_machine resource.
/// </summary>
public partial class AzurermLinuxVirtualMachine(string name) : TerraformResource("azurerm_linux_virtual_machine", name)
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformValue<string>? AdminPassword
    {
        get => GetArgument<TerraformValue<string>>("admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string>? AdminUsername
    {
        get => GetArgument<TerraformValue<string>>("admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The allow_extension_operations attribute.
    /// </summary>
    public TerraformValue<bool>? AllowExtensionOperations
    {
        get => GetArgument<TerraformValue<bool>>("allow_extension_operations");
        set => SetArgument("allow_extension_operations", value);
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilitySetId
    {
        get => GetArgument<TerraformValue<string>>("availability_set_id");
        set => SetArgument("availability_set_id", value);
    }

    /// <summary>
    /// The bypass_platform_safety_checks_on_user_schedule_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BypassPlatformSafetyChecksOnUserScheduleEnabled
    {
        get => GetArgument<TerraformValue<bool>>("bypass_platform_safety_checks_on_user_schedule_enabled");
        set => SetArgument("bypass_platform_safety_checks_on_user_schedule_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationGroupId
    {
        get => GetArgument<TerraformValue<string>>("capacity_reservation_group_id");
        set => SetArgument("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformValue<string>? ComputerName
    {
        get => GetArgument<TerraformValue<string>>("computer_name");
        set => SetArgument("computer_name", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformValue<string>? CustomData
    {
        get => GetArgument<TerraformValue<string>>("custom_data");
        set => SetArgument("custom_data", value);
    }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    public TerraformValue<string>? DedicatedHostGroupId
    {
        get => GetArgument<TerraformValue<string>>("dedicated_host_group_id");
        set => SetArgument("dedicated_host_group_id", value);
    }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    public TerraformValue<string>? DedicatedHostId
    {
        get => GetArgument<TerraformValue<string>>("dedicated_host_id");
        set => SetArgument("dedicated_host_id", value);
    }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    public TerraformValue<bool>? DisablePasswordAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("disable_password_authentication");
        set => SetArgument("disable_password_authentication", value);
    }

    /// <summary>
    /// The disk_controller_type attribute.
    /// </summary>
    public TerraformValue<string>? DiskControllerType
    {
        get => GetArgument<TerraformValue<string>>("disk_controller_type");
        set => SetArgument("disk_controller_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => GetArgument<TerraformValue<string>>("edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionAtHostEnabled
    {
        get => GetArgument<TerraformValue<bool>>("encryption_at_host_enabled");
        set => SetArgument("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformValue<string>? EvictionPolicy
    {
        get => GetArgument<TerraformValue<string>>("eviction_policy");
        set => SetArgument("eviction_policy", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public TerraformValue<string>? ExtensionsTimeBudget
    {
        get => GetArgument<TerraformValue<string>>("extensions_time_budget");
        set => SetArgument("extensions_time_budget", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string>? LicenseType
    {
        get => GetArgument<TerraformValue<string>>("license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    public TerraformValue<double>? MaxBidPrice
    {
        get => GetArgument<TerraformValue<double>>("max_bid_price");
        set => SetArgument("max_bid_price", value);
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
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    public TerraformList<string>? NetworkInterfaceIds
    {
        get => GetArgument<TerraformList<string>>("network_interface_ids");
        set => SetArgument("network_interface_ids", value);
    }

    /// <summary>
    /// The os_managed_disk_id attribute.
    /// </summary>
    public TerraformValue<string>? OsManagedDiskId
    {
        get => GetArgument<TerraformValue<string>>("os_managed_disk_id");
        set => SetArgument("os_managed_disk_id", value);
    }

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    public TerraformValue<string>? PatchAssessmentMode
    {
        get => GetArgument<TerraformValue<string>>("patch_assessment_mode");
        set => SetArgument("patch_assessment_mode", value);
    }

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    public TerraformValue<string>? PatchMode
    {
        get => GetArgument<TerraformValue<string>>("patch_mode");
        set => SetArgument("patch_mode", value);
    }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    public TerraformValue<double>? PlatformFaultDomain
    {
        get => GetArgument<TerraformValue<double>>("platform_fault_domain");
        set => SetArgument("platform_fault_domain", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<string>? Priority
    {
        get => GetArgument<TerraformValue<string>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformValue<bool>? ProvisionVmAgent
    {
        get => GetArgument<TerraformValue<bool>>("provision_vm_agent");
        set => SetArgument("provision_vm_agent", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => GetArgument<TerraformValue<string>>("proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The reboot_setting attribute.
    /// </summary>
    public TerraformValue<string>? RebootSetting
    {
        get => GetArgument<TerraformValue<string>>("reboot_setting");
        set => SetArgument("reboot_setting", value);
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
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SecureBootEnabled
    {
        get => GetArgument<TerraformValue<bool>>("secure_boot_enabled");
        set => SetArgument("secure_boot_enabled", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<string> Size
    {
        get => GetArgument<TerraformValue<string>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceImageId
    {
        get => GetArgument<TerraformValue<string>>("source_image_id");
        set => SetArgument("source_image_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string>? UserData
    {
        get => GetArgument<TerraformValue<string>>("user_data");
        set => SetArgument("user_data", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualMachineScaleSetId
    {
        get => GetArgument<TerraformValue<string>>("virtual_machine_scale_set_id");
        set => SetArgument("virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The vm_agent_platform_updates_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? VmAgentPlatformUpdatesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("vm_agent_platform_updates_enabled");
        set => SetArgument("vm_agent_platform_updates_enabled", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VtpmEnabled
    {
        get => GetArgument<TerraformValue<bool>>("vtpm_enabled");
        set => SetArgument("vtpm_enabled", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
        => AsReference("private_ip_address");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
        => AsReference("private_ip_addresses");

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PublicIpAddress
        => AsReference("public_ip_address");

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PublicIpAddresses
        => AsReference("public_ip_addresses");

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualMachineId
        => AsReference("virtual_machine_id");

    /// <summary>
    /// AdditionalCapabilities block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock>>("additional_capabilities");
        set => SetArgument("additional_capabilities", value);
    }

    /// <summary>
    /// AdminSshKey block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermLinuxVirtualMachineAdminSshKeyBlock>? AdminSshKey
    {
        get => GetArgument<TerraformSet<AzurermLinuxVirtualMachineAdminSshKeyBlock>>("admin_ssh_key");
        set => SetArgument("admin_ssh_key", value);
    }

    /// <summary>
    /// BootDiagnostics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineBootDiagnosticsBlock>? BootDiagnostics
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineBootDiagnosticsBlock>>("boot_diagnostics");
        set => SetArgument("boot_diagnostics", value);
    }

    /// <summary>
    /// GalleryApplication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineGalleryApplicationBlock>? GalleryApplication
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineGalleryApplicationBlock>>("gallery_application");
        set => SetArgument("gallery_application", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// OsDisk block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public required TerraformList<AzurermLinuxVirtualMachineOsDiskBlock> OsDisk
    {
        get => GetRequiredArgument<TerraformList<AzurermLinuxVirtualMachineOsDiskBlock>>("os_disk");
        set => SetArgument("os_disk", value);
    }

    /// <summary>
    /// OsImageNotification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsImageNotification block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineOsImageNotificationBlock>? OsImageNotification
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineOsImageNotificationBlock>>("os_image_notification");
        set => SetArgument("os_image_notification", value);
    }

    /// <summary>
    /// Plan block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachinePlanBlock>? Plan
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachinePlanBlock>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLinuxVirtualMachineSecretBlock>? Secret
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// SourceImageReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineSourceImageReferenceBlock>? SourceImageReference
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineSourceImageReferenceBlock>>("source_image_reference");
        set => SetArgument("source_image_reference", value);
    }

    /// <summary>
    /// TerminationNotification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineTerminationNotificationBlock>? TerminationNotification
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineTerminationNotificationBlock>>("termination_notification");
        set => SetArgument("termination_notification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLinuxVirtualMachineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLinuxVirtualMachineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
