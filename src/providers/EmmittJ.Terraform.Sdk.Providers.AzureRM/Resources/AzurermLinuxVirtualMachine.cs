using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock : ITerraformBlock
{
    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("hibernation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HibernationEnabled { get; set; }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for admin_ssh_key in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineAdminSshKeyBlock : ITerraformBlock
{
    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    [TerraformPropertyName("public_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PublicKey { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineBootDiagnosticsBlock : ITerraformBlock
{
    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountUri { get; set; }

}

/// <summary>
/// Block type for gallery_application in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineGalleryApplicationBlock : ITerraformBlock
{
    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_upgrade_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutomaticUpgradeEnabled { get; set; }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    [TerraformPropertyName("configuration_blob_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConfigurationBlobUri { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformPropertyName("order")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Order { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tag { get; set; }

    /// <summary>
    /// The treat_failure_as_deployment_failure_enabled attribute.
    /// </summary>
    [TerraformPropertyName("treat_failure_as_deployment_failure_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TreatFailureAsDeploymentFailureEnabled { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    [TerraformPropertyName("version_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VersionId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineOsDiskBlock : ITerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformPropertyName("caching")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Caching { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DiskSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "disk_size_gb");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("secure_vm_disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("security_encryption_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecurityEncryptionType { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageAccountType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "storage_account_type");

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("write_accelerator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for os_image_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineOsImageNotificationBlock : ITerraformBlock
{
    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Timeout { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachinePlanBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformPropertyName("product")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Publisher { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineSecretBlock : ITerraformBlock
{
    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineSourceImageReferenceBlock : ITerraformBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformPropertyName("offer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineTerminationNotificationBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Timeout { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLinuxVirtualMachineTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("admin_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformPropertyName("admin_username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdminUsername { get; set; }

    /// <summary>
    /// The allow_extension_operations attribute.
    /// </summary>
    [TerraformPropertyName("allow_extension_operations")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AllowExtensionOperations { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_extension_operations");

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AvailabilitySetId { get; set; }

    /// <summary>
    /// The bypass_platform_safety_checks_on_user_schedule_enabled attribute.
    /// </summary>
    [TerraformPropertyName("bypass_platform_safety_checks_on_user_schedule_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BypassPlatformSafetyChecksOnUserScheduleEnabled { get; set; }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CapacityReservationGroupId { get; set; }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [TerraformPropertyName("computer_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ComputerName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "computer_name");

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformPropertyName("custom_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomData { get; set; }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_host_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DedicatedHostGroupId { get; set; }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_host_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DedicatedHostId { get; set; }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [TerraformPropertyName("disable_password_authentication")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DisablePasswordAuthentication { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_password_authentication");

    /// <summary>
    /// The disk_controller_type attribute.
    /// </summary>
    [TerraformPropertyName("disk_controller_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiskControllerType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_controller_type");

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EdgeZone { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_host_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformPropertyName("eviction_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EvictionPolicy { get; set; }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    [TerraformPropertyName("extensions_time_budget")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExtensionsTimeBudget { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    [TerraformPropertyName("max_bid_price")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxBidPrice { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    [TerraformPropertyName("network_interface_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? NetworkInterfaceIds { get; set; }

    /// <summary>
    /// The os_managed_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("os_managed_disk_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OsManagedDiskId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_managed_disk_id");

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    [TerraformPropertyName("patch_assessment_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PatchAssessmentMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "patch_assessment_mode");

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    [TerraformPropertyName("patch_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PatchMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "patch_mode");

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    [TerraformPropertyName("platform_fault_domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PlatformFaultDomain { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Priority { get; set; }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformPropertyName("provision_vm_agent")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ProvisionVmAgent { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "provision_vm_agent");

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The reboot_setting attribute.
    /// </summary>
    [TerraformPropertyName("reboot_setting")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RebootSetting { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    [TerraformPropertyName("secure_boot_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SecureBootEnabled { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformPropertyName("size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Size { get; set; }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformPropertyName("source_image_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceImageId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserData { get; set; }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_machine_scale_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VirtualMachineScaleSetId { get; set; }

    /// <summary>
    /// The vm_agent_platform_updates_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("vm_agent_platform_updates_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> VmAgentPlatformUpdatesEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "vm_agent_platform_updates_enabled");

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vtpm_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VtpmEnabled { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Zone { get; set; }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformPropertyName("additional_capabilities")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock>>? AdditionalCapabilities { get; set; } = new();

    /// <summary>
    /// Block for admin_ssh_key.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("admin_ssh_key")]
    public TerraformSet<TerraformBlock<AzurermLinuxVirtualMachineAdminSshKeyBlock>>? AdminSshKey { get; set; } = new();

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformPropertyName("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineBootDiagnosticsBlock>>? BootDiagnostics { get; set; } = new();

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    [TerraformPropertyName("gallery_application")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineGalleryApplicationBlock>>? GalleryApplication { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformPropertyName("os_disk")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineOsDiskBlock>>? OsDisk { get; set; } = new();

    /// <summary>
    /// Block for os_image_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsImageNotification block(s) allowed")]
    [TerraformPropertyName("os_image_notification")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineOsImageNotificationBlock>>? OsImageNotification { get; set; } = new();

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformPropertyName("plan")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachinePlanBlock>>? Plan { get; set; } = new();

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("secret")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineSecretBlock>>? Secret { get; set; } = new();

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    [TerraformPropertyName("source_image_reference")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineSourceImageReferenceBlock>>? SourceImageReference { get; set; } = new();

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    [TerraformPropertyName("termination_notification")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineTerminationNotificationBlock>>? TerminationNotification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLinuxVirtualMachineTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ip_address");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PrivateIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "private_ip_addresses");

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ip_address");

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PublicIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "public_ip_addresses");

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_machine_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualMachineId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_machine_id");

}
