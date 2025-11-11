using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    [TerraformProperty("hibernation_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? HibernationEnabled { get; set; }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformProperty("ultra_ssd_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for admin_ssh_key in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLinuxVirtualMachineAdminSshKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    [TerraformProperty("public_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PublicKey { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineBootDiagnosticsBlock : TerraformBlockBase
{
    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    [TerraformProperty("storage_account_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountUri { get; set; }

}

/// <summary>
/// Block type for gallery_application in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineGalleryApplicationBlock : TerraformBlockBase
{
    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_upgrade_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutomaticUpgradeEnabled { get; set; }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    [TerraformProperty("configuration_blob_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConfigurationBlobUri { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformProperty("order")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Order { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Tag { get; set; }

    /// <summary>
    /// The treat_failure_as_deployment_failure_enabled attribute.
    /// </summary>
    [TerraformProperty("treat_failure_as_deployment_failure_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TreatFailureAsDeploymentFailureEnabled { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    [TerraformProperty("version_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VersionId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineOsDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformProperty("caching")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Caching { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskSizeGb { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("secure_vm_disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    [TerraformProperty("security_encryption_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecurityEncryptionType { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformProperty("storage_account_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StorageAccountType { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformProperty("write_accelerator_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for os_image_notification in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineOsImageNotificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Timeout { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachinePlanBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformProperty("product")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Publisher { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineSecretBlock : TerraformBlockBase
{
    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultId { get; set; }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineSourceImageReferenceBlock : TerraformBlockBase
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformProperty("offer")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineTerminationNotificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Timeout { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLinuxVirtualMachineTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_linux_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLinuxVirtualMachine : TerraformResource
{
    public AzurermLinuxVirtualMachine(string name) : base("azurerm_linux_virtual_machine", name)
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformProperty("admin_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformProperty("admin_username")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AdminUsername { get; set; }

    /// <summary>
    /// The allow_extension_operations attribute.
    /// </summary>
    [TerraformProperty("allow_extension_operations")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> AllowExtensionOperations { get; set; }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    [TerraformProperty("availability_set_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AvailabilitySetId { get; set; }

    /// <summary>
    /// The bypass_platform_safety_checks_on_user_schedule_enabled attribute.
    /// </summary>
    [TerraformProperty("bypass_platform_safety_checks_on_user_schedule_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BypassPlatformSafetyChecksOnUserScheduleEnabled { get; set; }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformProperty("capacity_reservation_group_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CapacityReservationGroupId { get; set; }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [TerraformProperty("computer_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ComputerName { get; set; }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformProperty("custom_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomData { get; set; }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    [TerraformProperty("dedicated_host_group_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DedicatedHostGroupId { get; set; }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    [TerraformProperty("dedicated_host_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DedicatedHostId { get; set; }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [TerraformProperty("disable_password_authentication")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DisablePasswordAuthentication { get; set; }

    /// <summary>
    /// The disk_controller_type attribute.
    /// </summary>
    [TerraformProperty("disk_controller_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DiskControllerType { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformProperty("edge_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformProperty("encryption_at_host_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformProperty("eviction_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EvictionPolicy { get; set; }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    [TerraformProperty("extensions_time_budget")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExtensionsTimeBudget { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    [TerraformProperty("max_bid_price")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxBidPrice { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    [TerraformProperty("network_interface_ids")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? NetworkInterfaceIds { get; set; }

    /// <summary>
    /// The os_managed_disk_id attribute.
    /// </summary>
    [TerraformProperty("os_managed_disk_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OsManagedDiskId { get; set; }

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    [TerraformProperty("patch_assessment_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PatchAssessmentMode { get; set; }

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    [TerraformProperty("patch_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PatchMode { get; set; }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    [TerraformProperty("platform_fault_domain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? PlatformFaultDomain { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Priority { get; set; }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformProperty("provision_vm_agent")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ProvisionVmAgent { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformProperty("proximity_placement_group_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The reboot_setting attribute.
    /// </summary>
    [TerraformProperty("reboot_setting")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RebootSetting { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    [TerraformProperty("secure_boot_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SecureBootEnabled { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformProperty("size")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Size { get; set; }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformProperty("source_image_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceImageId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    [TerraformProperty("virtual_machine_scale_set_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VirtualMachineScaleSetId { get; set; }

    /// <summary>
    /// The vm_agent_platform_updates_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("vm_agent_platform_updates_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> VmAgentPlatformUpdatesEnabled { get; set; }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    [TerraformProperty("vtpm_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? VtpmEnabled { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformProperty("additional_capabilities")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock>>? AdditionalCapabilities { get; set; }

    /// <summary>
    /// Block for admin_ssh_key.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("admin_ssh_key")]
    public TerraformSet<TerraformBlock<AzurermLinuxVirtualMachineAdminSshKeyBlock>>? AdminSshKey { get; set; }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformProperty("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineBootDiagnosticsBlock>>? BootDiagnostics { get; set; }

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    [TerraformProperty("gallery_application")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineGalleryApplicationBlock>>? GalleryApplication { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformProperty("os_disk")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineOsDiskBlock>>? OsDisk { get; set; }

    /// <summary>
    /// Block for os_image_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsImageNotification block(s) allowed")]
    [TerraformProperty("os_image_notification")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineOsImageNotificationBlock>>? OsImageNotification { get; set; }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformProperty("plan")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachinePlanBlock>>? Plan { get; set; }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("secret")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineSecretBlock>>? Secret { get; set; }

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    [TerraformProperty("source_image_reference")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineSourceImageReferenceBlock>>? SourceImageReference { get; set; }

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    [TerraformProperty("termination_notification")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineTerminationNotificationBlock>>? TerminationNotification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLinuxVirtualMachineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateIpAddress { get; }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("private_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> PrivateIpAddresses { get; }

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    [TerraformProperty("public_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicIpAddress { get; }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("public_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> PublicIpAddresses { get; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [TerraformProperty("virtual_machine_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualMachineId { get; }

}
