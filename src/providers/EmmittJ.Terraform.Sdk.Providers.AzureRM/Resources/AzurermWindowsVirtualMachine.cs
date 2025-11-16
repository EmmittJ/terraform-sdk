using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineAdditionalCapabilitiesBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "hibernation_enabled");
        set => SetArgument("hibernation_enabled", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UltraSsdEnabled
    {
        get => new TerraformReference<bool>(this, "ultra_ssd_enabled");
        set => SetArgument("ultra_ssd_enabled", value);
    }

}

/// <summary>
/// Block type for additional_unattend_content in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineAdditionalUnattendContentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_unattend_content";

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The setting attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Setting is required")]
    public required TerraformValue<string> Setting
    {
        get => new TerraformReference<string>(this, "setting");
        set => SetArgument("setting", value);
    }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineBootDiagnosticsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "storage_account_uri");
        set => SetArgument("storage_account_uri", value);
    }

}

/// <summary>
/// Block type for gallery_application in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineGalleryApplicationBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "automatic_upgrade_enabled");
        set => SetArgument("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationBlobUri
    {
        get => new TerraformReference<string>(this, "configuration_blob_uri");
        set => SetArgument("configuration_blob_uri", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformValue<double>? Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The treat_failure_as_deployment_failure_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TreatFailureAsDeploymentFailureEnabled
    {
        get => new TerraformReference<bool>(this, "treat_failure_as_deployment_failure_enabled");
        set => SetArgument("treat_failure_as_deployment_failure_enabled", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    public required TerraformValue<string> VersionId
    {
        get => new TerraformReference<string>(this, "version_id");
        set => SetArgument("version_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineIdentityBlock : TerraformBlock
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineOsDiskBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? SecureVmDiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "secure_vm_disk_encryption_set_id");
        set => SetArgument("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    public TerraformValue<string>? SecurityEncryptionType
    {
        get => new TerraformReference<string>(this, "security_encryption_type");
        set => SetArgument("security_encryption_type", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for os_image_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineOsImageNotificationBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "timeout");
        set => SetArgument("timeout", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachinePlanBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformValue<string> Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineSecretBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineSourceImageReferenceBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineTerminationNotificationBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => new TerraformReference<string>(this, "timeout");
        set => SetArgument("timeout", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWindowsVirtualMachineTimeoutsBlock : TerraformBlock
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
/// Block type for winrm_listener in .
/// Nesting mode: set
/// </summary>
public class AzurermWindowsVirtualMachineWinrmListenerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "winrm_listener";

    /// <summary>
    /// The certificate_url attribute.
    /// </summary>
    public TerraformValue<string>? CertificateUrl
    {
        get => new TerraformReference<string>(this, "certificate_url");
        set => SetArgument("certificate_url", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

}

/// <summary>
/// Represents a azurerm_windows_virtual_machine Terraform resource.
/// Manages a azurerm_windows_virtual_machine resource.
/// </summary>
public partial class AzurermWindowsVirtualMachine(string name) : TerraformResource("azurerm_windows_virtual_machine", name)
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformValue<string>? AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string>? AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The allow_extension_operations attribute.
    /// </summary>
    public TerraformValue<bool> AllowExtensionOperations
    {
        get => new TerraformReference<bool>(this, "allow_extension_operations");
        set => SetArgument("allow_extension_operations", value);
    }

    /// <summary>
    /// The automatic_updates_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutomaticUpdatesEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_updates_enabled");
        set => SetArgument("automatic_updates_enabled", value);
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilitySetId
    {
        get => new TerraformReference<string>(this, "availability_set_id");
        set => SetArgument("availability_set_id", value);
    }

    /// <summary>
    /// The bypass_platform_safety_checks_on_user_schedule_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BypassPlatformSafetyChecksOnUserScheduleEnabled
    {
        get => new TerraformReference<bool>(this, "bypass_platform_safety_checks_on_user_schedule_enabled");
        set => SetArgument("bypass_platform_safety_checks_on_user_schedule_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationGroupId
    {
        get => new TerraformReference<string>(this, "capacity_reservation_group_id");
        set => SetArgument("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformValue<string> ComputerName
    {
        get => new TerraformReference<string>(this, "computer_name");
        set => SetArgument("computer_name", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformValue<string>? CustomData
    {
        get => new TerraformReference<string>(this, "custom_data");
        set => SetArgument("custom_data", value);
    }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    public TerraformValue<string>? DedicatedHostGroupId
    {
        get => new TerraformReference<string>(this, "dedicated_host_group_id");
        set => SetArgument("dedicated_host_group_id", value);
    }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    public TerraformValue<string>? DedicatedHostId
    {
        get => new TerraformReference<string>(this, "dedicated_host_id");
        set => SetArgument("dedicated_host_id", value);
    }

    /// <summary>
    /// The disk_controller_type attribute.
    /// </summary>
    public TerraformValue<string> DiskControllerType
    {
        get => new TerraformReference<string>(this, "disk_controller_type");
        set => SetArgument("disk_controller_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableAutomaticUpdates
    {
        get => new TerraformReference<bool>(this, "enable_automatic_updates");
        set => SetArgument("enable_automatic_updates", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionAtHostEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_at_host_enabled");
        set => SetArgument("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformValue<string>? EvictionPolicy
    {
        get => new TerraformReference<string>(this, "eviction_policy");
        set => SetArgument("eviction_policy", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public TerraformValue<string>? ExtensionsTimeBudget
    {
        get => new TerraformReference<string>(this, "extensions_time_budget");
        set => SetArgument("extensions_time_budget", value);
    }

    /// <summary>
    /// The hotpatching_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HotpatchingEnabled
    {
        get => new TerraformReference<bool>(this, "hotpatching_enabled");
        set => SetArgument("hotpatching_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    public TerraformValue<double>? MaxBidPrice
    {
        get => new TerraformReference<double>(this, "max_bid_price");
        set => SetArgument("max_bid_price", value);
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
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    public TerraformList<string>? NetworkInterfaceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "network_interface_ids").ResolveNodes(ctx));
        set => SetArgument("network_interface_ids", value);
    }

    /// <summary>
    /// The os_managed_disk_id attribute.
    /// </summary>
    public TerraformValue<string> OsManagedDiskId
    {
        get => new TerraformReference<string>(this, "os_managed_disk_id");
        set => SetArgument("os_managed_disk_id", value);
    }

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    public TerraformValue<string> PatchAssessmentMode
    {
        get => new TerraformReference<string>(this, "patch_assessment_mode");
        set => SetArgument("patch_assessment_mode", value);
    }

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    public TerraformValue<string> PatchMode
    {
        get => new TerraformReference<string>(this, "patch_mode");
        set => SetArgument("patch_mode", value);
    }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    public TerraformValue<double>? PlatformFaultDomain
    {
        get => new TerraformReference<double>(this, "platform_fault_domain");
        set => SetArgument("platform_fault_domain", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<string>? Priority
    {
        get => new TerraformReference<string>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformValue<bool> ProvisionVmAgent
    {
        get => new TerraformReference<bool>(this, "provision_vm_agent");
        set => SetArgument("provision_vm_agent", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The reboot_setting attribute.
    /// </summary>
    public TerraformValue<string>? RebootSetting
    {
        get => new TerraformReference<string>(this, "reboot_setting");
        set => SetArgument("reboot_setting", value);
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
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SecureBootEnabled
    {
        get => new TerraformReference<bool>(this, "secure_boot_enabled");
        set => SetArgument("secure_boot_enabled", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<string> Size
    {
        get => new TerraformReference<string>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceImageId
    {
        get => new TerraformReference<string>(this, "source_image_id");
        set => SetArgument("source_image_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string>? UserData
    {
        get => new TerraformReference<string>(this, "user_data");
        set => SetArgument("user_data", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualMachineScaleSetId
    {
        get => new TerraformReference<string>(this, "virtual_machine_scale_set_id");
        set => SetArgument("virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The vm_agent_platform_updates_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> VmAgentPlatformUpdatesEnabled
    {
        get => new TerraformReference<bool>(this, "vm_agent_platform_updates_enabled");
        set => SetArgument("vm_agent_platform_updates_enabled", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VtpmEnabled
    {
        get => new TerraformReference<bool>(this, "vtpm_enabled");
        set => SetArgument("vtpm_enabled", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
    }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PublicIpAddress
    {
        get => new TerraformReference<string>(this, "public_ip_address");
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PublicIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
    }

    /// <summary>
    /// AdditionalCapabilities block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public TerraformList<AzurermWindowsVirtualMachineAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        get => GetArgument<TerraformList<AzurermWindowsVirtualMachineAdditionalCapabilitiesBlock>>("additional_capabilities");
        set => SetArgument("additional_capabilities", value);
    }

    /// <summary>
    /// AdditionalUnattendContent block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWindowsVirtualMachineAdditionalUnattendContentBlock>? AdditionalUnattendContent
    {
        get => GetArgument<TerraformList<AzurermWindowsVirtualMachineAdditionalUnattendContentBlock>>("additional_unattend_content");
        set => SetArgument("additional_unattend_content", value);
    }

    /// <summary>
    /// BootDiagnostics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public TerraformList<AzurermWindowsVirtualMachineBootDiagnosticsBlock>? BootDiagnostics
    {
        get => GetArgument<TerraformList<AzurermWindowsVirtualMachineBootDiagnosticsBlock>>("boot_diagnostics");
        set => SetArgument("boot_diagnostics", value);
    }

    /// <summary>
    /// GalleryApplication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    public TerraformList<AzurermWindowsVirtualMachineGalleryApplicationBlock>? GalleryApplication
    {
        get => GetArgument<TerraformList<AzurermWindowsVirtualMachineGalleryApplicationBlock>>("gallery_application");
        set => SetArgument("gallery_application", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermWindowsVirtualMachineIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermWindowsVirtualMachineIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// OsDisk block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public required TerraformList<AzurermWindowsVirtualMachineOsDiskBlock> OsDisk
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsVirtualMachineOsDiskBlock>>("os_disk");
        set => SetArgument("os_disk", value);
    }

    /// <summary>
    /// OsImageNotification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsImageNotification block(s) allowed")]
    public TerraformList<AzurermWindowsVirtualMachineOsImageNotificationBlock>? OsImageNotification
    {
        get => GetArgument<TerraformList<AzurermWindowsVirtualMachineOsImageNotificationBlock>>("os_image_notification");
        set => SetArgument("os_image_notification", value);
    }

    /// <summary>
    /// Plan block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public TerraformList<AzurermWindowsVirtualMachinePlanBlock>? Plan
    {
        get => GetArgument<TerraformList<AzurermWindowsVirtualMachinePlanBlock>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWindowsVirtualMachineSecretBlock>? Secret
    {
        get => GetArgument<TerraformList<AzurermWindowsVirtualMachineSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// SourceImageReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    public TerraformList<AzurermWindowsVirtualMachineSourceImageReferenceBlock>? SourceImageReference
    {
        get => GetArgument<TerraformList<AzurermWindowsVirtualMachineSourceImageReferenceBlock>>("source_image_reference");
        set => SetArgument("source_image_reference", value);
    }

    /// <summary>
    /// TerminationNotification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    public TerraformList<AzurermWindowsVirtualMachineTerminationNotificationBlock>? TerminationNotification
    {
        get => GetArgument<TerraformList<AzurermWindowsVirtualMachineTerminationNotificationBlock>>("termination_notification");
        set => SetArgument("termination_notification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWindowsVirtualMachineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWindowsVirtualMachineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WinrmListener block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsVirtualMachineWinrmListenerBlock>? WinrmListener
    {
        get => GetArgument<TerraformSet<AzurermWindowsVirtualMachineWinrmListenerBlock>>("winrm_listener");
        set => SetArgument("winrm_listener", value);
    }

}
