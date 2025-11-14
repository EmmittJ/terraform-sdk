using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for additional_capabilities in .
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
    [TerraformArgument("hibernation_enabled")]
    public TerraformValue<bool>? HibernationEnabled
    {
        get => new TerraformReference<bool>(this, "hibernation_enabled");
        set => SetArgument("hibernation_enabled", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformArgument("ultra_ssd_enabled")]
    public TerraformValue<bool>? UltraSsdEnabled
    {
        get => new TerraformReference<bool>(this, "ultra_ssd_enabled");
        set => SetArgument("ultra_ssd_enabled", value);
    }

}

/// <summary>
/// Block type for admin_ssh_key in .
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
    [TerraformArgument("public_key")]
    public required TerraformValue<string> PublicKey
    {
        get => new TerraformReference<string>(this, "public_key");
        set => SetArgument("public_key", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformArgument("username")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for boot_diagnostics in .
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
    [TerraformArgument("storage_account_uri")]
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
public class AzurermLinuxVirtualMachineGalleryApplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gallery_application";

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformArgument("automatic_upgrade_enabled")]
    public TerraformValue<bool>? AutomaticUpgradeEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_upgrade_enabled");
        set => SetArgument("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    [TerraformArgument("configuration_blob_uri")]
    public TerraformValue<string>? ConfigurationBlobUri
    {
        get => new TerraformReference<string>(this, "configuration_blob_uri");
        set => SetArgument("configuration_blob_uri", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformArgument("order")]
    public TerraformValue<double>? Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformArgument("tag")]
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The treat_failure_as_deployment_failure_enabled attribute.
    /// </summary>
    [TerraformArgument("treat_failure_as_deployment_failure_enabled")]
    public TerraformValue<bool>? TreatFailureAsDeploymentFailureEnabled
    {
        get => new TerraformReference<bool>(this, "treat_failure_as_deployment_failure_enabled");
        set => SetArgument("treat_failure_as_deployment_failure_enabled", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    [TerraformArgument("version_id")]
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
public class AzurermLinuxVirtualMachineIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
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
    [TerraformArgument("caching")]
    public required TerraformValue<string> Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("disk_encryption_set_id")]
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformArgument("disk_size_gb")]
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("secure_vm_disk_encryption_set_id")]
    public TerraformValue<string>? SecureVmDiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "secure_vm_disk_encryption_set_id");
        set => SetArgument("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    [TerraformArgument("security_encryption_type")]
    public TerraformValue<string>? SecurityEncryptionType
    {
        get => new TerraformReference<string>(this, "security_encryption_type");
        set => SetArgument("security_encryption_type", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformArgument("storage_account_type")]
    public TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformArgument("write_accelerator_enabled")]
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
public class AzurermLinuxVirtualMachineOsImageNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_image_notification";

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformArgument("timeout")]
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformArgument("product")]
    public required TerraformValue<string> Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformArgument("publisher")]
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
    [TerraformArgument("key_vault_id")]
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
    [TerraformArgument("offer")]
    public required TerraformValue<string> Offer
    {
        get => new TerraformReference<string>(this, "offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformArgument("publisher")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
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
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformArgument("timeout")]
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
public class AzurermLinuxVirtualMachineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_linux_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLinuxVirtualMachine : TerraformResource
{
    public AzurermLinuxVirtualMachine(string name) : base("azurerm_linux_virtual_machine", name)
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformArgument("admin_password")]
    public TerraformValue<string>? AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformArgument("admin_username")]
    public TerraformValue<string>? AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The allow_extension_operations attribute.
    /// </summary>
    [TerraformArgument("allow_extension_operations")]
    public TerraformValue<bool> AllowExtensionOperations
    {
        get => new TerraformReference<bool>(this, "allow_extension_operations");
        set => SetArgument("allow_extension_operations", value);
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    [TerraformArgument("availability_set_id")]
    public TerraformValue<string>? AvailabilitySetId
    {
        get => new TerraformReference<string>(this, "availability_set_id");
        set => SetArgument("availability_set_id", value);
    }

    /// <summary>
    /// The bypass_platform_safety_checks_on_user_schedule_enabled attribute.
    /// </summary>
    [TerraformArgument("bypass_platform_safety_checks_on_user_schedule_enabled")]
    public TerraformValue<bool>? BypassPlatformSafetyChecksOnUserScheduleEnabled
    {
        get => new TerraformReference<bool>(this, "bypass_platform_safety_checks_on_user_schedule_enabled");
        set => SetArgument("bypass_platform_safety_checks_on_user_schedule_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformArgument("capacity_reservation_group_id")]
    public TerraformValue<string>? CapacityReservationGroupId
    {
        get => new TerraformReference<string>(this, "capacity_reservation_group_id");
        set => SetArgument("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [TerraformArgument("computer_name")]
    public TerraformValue<string> ComputerName
    {
        get => new TerraformReference<string>(this, "computer_name");
        set => SetArgument("computer_name", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformArgument("custom_data")]
    public TerraformValue<string>? CustomData
    {
        get => new TerraformReference<string>(this, "custom_data");
        set => SetArgument("custom_data", value);
    }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    [TerraformArgument("dedicated_host_group_id")]
    public TerraformValue<string>? DedicatedHostGroupId
    {
        get => new TerraformReference<string>(this, "dedicated_host_group_id");
        set => SetArgument("dedicated_host_group_id", value);
    }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    [TerraformArgument("dedicated_host_id")]
    public TerraformValue<string>? DedicatedHostId
    {
        get => new TerraformReference<string>(this, "dedicated_host_id");
        set => SetArgument("dedicated_host_id", value);
    }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [TerraformArgument("disable_password_authentication")]
    public TerraformValue<bool> DisablePasswordAuthentication
    {
        get => new TerraformReference<bool>(this, "disable_password_authentication");
        set => SetArgument("disable_password_authentication", value);
    }

    /// <summary>
    /// The disk_controller_type attribute.
    /// </summary>
    [TerraformArgument("disk_controller_type")]
    public TerraformValue<string> DiskControllerType
    {
        get => new TerraformReference<string>(this, "disk_controller_type");
        set => SetArgument("disk_controller_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformArgument("edge_zone")]
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformArgument("encryption_at_host_enabled")]
    public TerraformValue<bool>? EncryptionAtHostEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_at_host_enabled");
        set => SetArgument("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformArgument("eviction_policy")]
    public TerraformValue<string>? EvictionPolicy
    {
        get => new TerraformReference<string>(this, "eviction_policy");
        set => SetArgument("eviction_policy", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    [TerraformArgument("extensions_time_budget")]
    public TerraformValue<string>? ExtensionsTimeBudget
    {
        get => new TerraformReference<string>(this, "extensions_time_budget");
        set => SetArgument("extensions_time_budget", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformArgument("license_type")]
    public TerraformValue<string>? LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    [TerraformArgument("max_bid_price")]
    public TerraformValue<double>? MaxBidPrice
    {
        get => new TerraformReference<double>(this, "max_bid_price");
        set => SetArgument("max_bid_price", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    [TerraformArgument("network_interface_ids")]
    public TerraformList<string>? NetworkInterfaceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "network_interface_ids").ResolveNodes(ctx));
        set => SetArgument("network_interface_ids", value);
    }

    /// <summary>
    /// The os_managed_disk_id attribute.
    /// </summary>
    [TerraformArgument("os_managed_disk_id")]
    public TerraformValue<string> OsManagedDiskId
    {
        get => new TerraformReference<string>(this, "os_managed_disk_id");
        set => SetArgument("os_managed_disk_id", value);
    }

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    [TerraformArgument("patch_assessment_mode")]
    public TerraformValue<string> PatchAssessmentMode
    {
        get => new TerraformReference<string>(this, "patch_assessment_mode");
        set => SetArgument("patch_assessment_mode", value);
    }

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    [TerraformArgument("patch_mode")]
    public TerraformValue<string> PatchMode
    {
        get => new TerraformReference<string>(this, "patch_mode");
        set => SetArgument("patch_mode", value);
    }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    [TerraformArgument("platform_fault_domain")]
    public TerraformValue<double>? PlatformFaultDomain
    {
        get => new TerraformReference<double>(this, "platform_fault_domain");
        set => SetArgument("platform_fault_domain", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformArgument("priority")]
    public TerraformValue<string>? Priority
    {
        get => new TerraformReference<string>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformArgument("provision_vm_agent")]
    public TerraformValue<bool> ProvisionVmAgent
    {
        get => new TerraformReference<bool>(this, "provision_vm_agent");
        set => SetArgument("provision_vm_agent", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformArgument("proximity_placement_group_id")]
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The reboot_setting attribute.
    /// </summary>
    [TerraformArgument("reboot_setting")]
    public TerraformValue<string>? RebootSetting
    {
        get => new TerraformReference<string>(this, "reboot_setting");
        set => SetArgument("reboot_setting", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    [TerraformArgument("secure_boot_enabled")]
    public TerraformValue<bool>? SecureBootEnabled
    {
        get => new TerraformReference<bool>(this, "secure_boot_enabled");
        set => SetArgument("secure_boot_enabled", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformArgument("size")]
    public required TerraformValue<string> Size
    {
        get => new TerraformReference<string>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformArgument("source_image_id")]
    public TerraformValue<string>? SourceImageId
    {
        get => new TerraformReference<string>(this, "source_image_id");
        set => SetArgument("source_image_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformArgument("user_data")]
    public TerraformValue<string>? UserData
    {
        get => new TerraformReference<string>(this, "user_data");
        set => SetArgument("user_data", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    [TerraformArgument("virtual_machine_scale_set_id")]
    public TerraformValue<string>? VirtualMachineScaleSetId
    {
        get => new TerraformReference<string>(this, "virtual_machine_scale_set_id");
        set => SetArgument("virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The vm_agent_platform_updates_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("vm_agent_platform_updates_enabled")]
    public TerraformValue<bool> VmAgentPlatformUpdatesEnabled
    {
        get => new TerraformReference<bool>(this, "vm_agent_platform_updates_enabled");
        set => SetArgument("vm_agent_platform_updates_enabled", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    [TerraformArgument("vtpm_enabled")]
    public TerraformValue<bool>? VtpmEnabled
    {
        get => new TerraformReference<bool>(this, "vtpm_enabled");
        set => SetArgument("vtpm_enabled", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformArgument("zone")]
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformArgument("additional_capabilities")]
    public TerraformList<AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock> AdditionalCapabilities { get; set; } = new();

    /// <summary>
    /// Block for admin_ssh_key.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("admin_ssh_key")]
    public TerraformSet<AzurermLinuxVirtualMachineAdminSshKeyBlock> AdminSshKey { get; set; } = new();

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformArgument("boot_diagnostics")]
    public TerraformList<AzurermLinuxVirtualMachineBootDiagnosticsBlock> BootDiagnostics { get; set; } = new();

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    [TerraformArgument("gallery_application")]
    public TerraformList<AzurermLinuxVirtualMachineGalleryApplicationBlock> GalleryApplication { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermLinuxVirtualMachineIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformArgument("os_disk")]
    public required TerraformList<AzurermLinuxVirtualMachineOsDiskBlock> OsDisk { get; set; } = new();

    /// <summary>
    /// Block for os_image_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsImageNotification block(s) allowed")]
    [TerraformArgument("os_image_notification")]
    public TerraformList<AzurermLinuxVirtualMachineOsImageNotificationBlock> OsImageNotification { get; set; } = new();

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformArgument("plan")]
    public TerraformList<AzurermLinuxVirtualMachinePlanBlock> Plan { get; set; } = new();

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("secret")]
    public TerraformList<AzurermLinuxVirtualMachineSecretBlock> Secret { get; set; } = new();

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    [TerraformArgument("source_image_reference")]
    public TerraformList<AzurermLinuxVirtualMachineSourceImageReferenceBlock> SourceImageReference { get; set; } = new();

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    [TerraformArgument("termination_notification")]
    public TerraformList<AzurermLinuxVirtualMachineTerminationNotificationBlock> TerminationNotification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermLinuxVirtualMachineTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformArgument("private_ip_address")]
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
    }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("private_ip_addresses")]
    public TerraformList<string> PrivateIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    [TerraformArgument("public_ip_address")]
    public TerraformValue<string> PublicIpAddress
    {
        get => new TerraformReference<string>(this, "public_ip_address");
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("public_ip_addresses")]
    public TerraformList<string> PublicIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [TerraformArgument("virtual_machine_id")]
    public TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
    }

}
