using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineAdditionalCapabilitiesBlock
{
    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("hibernation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HibernationEnabled { get; set; }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for additional_unattend_content in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineAdditionalUnattendContentBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The setting attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Setting is required")]
    [TerraformPropertyName("setting")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Setting { get; set; }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineBootDiagnosticsBlock
{
    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountUri { get; set; }

}

/// <summary>
/// Block type for gallery_application in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineGalleryApplicationBlock
{
    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_upgrade_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutomaticUpgradeEnabled { get; set; }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    [TerraformPropertyName("configuration_blob_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConfigurationBlobUri { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformPropertyName("order")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Order { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tag { get; set; }

    /// <summary>
    /// The treat_failure_as_deployment_failure_enabled attribute.
    /// </summary>
    [TerraformPropertyName("treat_failure_as_deployment_failure_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TreatFailureAsDeploymentFailureEnabled { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    [TerraformPropertyName("version_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VersionId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineOsDiskBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformPropertyName("caching")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Caching { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskSizeGb { get; set; } = default!;


    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("secure_vm_disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("security_encryption_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityEncryptionType { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageAccountType { get; set; } = default!;

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("write_accelerator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for os_image_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineOsImageNotificationBlock
{
    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Timeout { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachinePlanBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformPropertyName("product")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Publisher { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineSecretBlock
{
    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVaultId { get; set; }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineSourceImageReferenceBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformPropertyName("offer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineTerminationNotificationBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Timeout { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWindowsVirtualMachineTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for winrm_listener in .
/// Nesting mode: set
/// </summary>
public class AzurermWindowsVirtualMachineWinrmListenerBlock
{
    /// <summary>
    /// The certificate_url attribute.
    /// </summary>
    [TerraformPropertyName("certificate_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateUrl { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

}

/// <summary>
/// Manages a azurerm_windows_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWindowsVirtualMachine : TerraformResource
{
    public AzurermWindowsVirtualMachine(string name) : base("azurerm_windows_virtual_machine", name)
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformPropertyName("admin_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformPropertyName("admin_username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdminUsername { get; set; }

    /// <summary>
    /// The allow_extension_operations attribute.
    /// </summary>
    [TerraformPropertyName("allow_extension_operations")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AllowExtensionOperations { get; set; } = default!;

    /// <summary>
    /// The automatic_updates_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_updates_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AutomaticUpdatesEnabled { get; set; } = default!;

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AvailabilitySetId { get; set; }

    /// <summary>
    /// The bypass_platform_safety_checks_on_user_schedule_enabled attribute.
    /// </summary>
    [TerraformPropertyName("bypass_platform_safety_checks_on_user_schedule_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BypassPlatformSafetyChecksOnUserScheduleEnabled { get; set; }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CapacityReservationGroupId { get; set; }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [TerraformPropertyName("computer_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ComputerName { get; set; } = default!;

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformPropertyName("custom_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomData { get; set; }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_host_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DedicatedHostGroupId { get; set; }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_host_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DedicatedHostId { get; set; }

    /// <summary>
    /// The disk_controller_type attribute.
    /// </summary>
    [TerraformPropertyName("disk_controller_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskControllerType { get; set; } = default!;

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_automatic_updates")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableAutomaticUpdates { get; set; } = default!;

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_host_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformPropertyName("eviction_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EvictionPolicy { get; set; }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    [TerraformPropertyName("extensions_time_budget")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExtensionsTimeBudget { get; set; }

    /// <summary>
    /// The hotpatching_enabled attribute.
    /// </summary>
    [TerraformPropertyName("hotpatching_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> HotpatchingEnabled { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    [TerraformPropertyName("max_bid_price")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxBidPrice { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    [TerraformPropertyName("network_interface_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? NetworkInterfaceIds { get; set; }

    /// <summary>
    /// The os_managed_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("os_managed_disk_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OsManagedDiskId { get; set; } = default!;

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    [TerraformPropertyName("patch_assessment_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PatchAssessmentMode { get; set; } = default!;

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    [TerraformPropertyName("patch_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PatchMode { get; set; } = default!;

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    [TerraformPropertyName("platform_fault_domain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PlatformFaultDomain { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Priority { get; set; }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformPropertyName("provision_vm_agent")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ProvisionVmAgent { get; set; } = default!;

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The reboot_setting attribute.
    /// </summary>
    [TerraformPropertyName("reboot_setting")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RebootSetting { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    [TerraformPropertyName("secure_boot_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SecureBootEnabled { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformPropertyName("size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Size { get; set; }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformPropertyName("source_image_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceImageId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Timezone { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_machine_scale_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VirtualMachineScaleSetId { get; set; }

    /// <summary>
    /// The vm_agent_platform_updates_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("vm_agent_platform_updates_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> VmAgentPlatformUpdatesEnabled { get; set; } = default!;

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vtpm_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VtpmEnabled { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformPropertyName("additional_capabilities")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineAdditionalCapabilitiesBlock>>? AdditionalCapabilities { get; set; }

    /// <summary>
    /// Block for additional_unattend_content.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("additional_unattend_content")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineAdditionalUnattendContentBlock>>? AdditionalUnattendContent { get; set; }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformPropertyName("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineBootDiagnosticsBlock>>? BootDiagnostics { get; set; }

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    [TerraformPropertyName("gallery_application")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineGalleryApplicationBlock>>? GalleryApplication { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformPropertyName("os_disk")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineOsDiskBlock>>? OsDisk { get; set; }

    /// <summary>
    /// Block for os_image_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsImageNotification block(s) allowed")]
    [TerraformPropertyName("os_image_notification")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineOsImageNotificationBlock>>? OsImageNotification { get; set; }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformPropertyName("plan")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachinePlanBlock>>? Plan { get; set; }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("secret")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineSecretBlock>>? Secret { get; set; }

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    [TerraformPropertyName("source_image_reference")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineSourceImageReferenceBlock>>? SourceImageReference { get; set; }

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    [TerraformPropertyName("termination_notification")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineTerminationNotificationBlock>>? TerminationNotification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermWindowsVirtualMachineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for winrm_listener.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("winrm_listener")]
    public TerraformSet<TerraformBlock<AzurermWindowsVirtualMachineWinrmListenerBlock>>? WinrmListener { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateIpAddress => new TerraformReference(this, "private_ip_address");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PrivateIpAddresses => new TerraformReference(this, "private_ip_addresses");

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicIpAddress => new TerraformReference(this, "public_ip_address");

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PublicIpAddresses => new TerraformReference(this, "public_ip_addresses");

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_machine_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualMachineId => new TerraformReference(this, "virtual_machine_id");

}
