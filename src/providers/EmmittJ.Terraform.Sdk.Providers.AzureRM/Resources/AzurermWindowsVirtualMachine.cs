using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineAdditionalCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HibernationEnabled
    {
        set => SetProperty("hibernation_enabled", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UltraSsdEnabled
    {
        set => SetProperty("ultra_ssd_enabled", value);
    }

}

/// <summary>
/// Block type for additional_unattend_content in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineAdditionalUnattendContentBlock : TerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The setting attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Setting is required")]
    public required TerraformProperty<string> Setting
    {
        set => SetProperty("setting", value);
    }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineBootDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountUri
    {
        set => SetProperty("storage_account_uri", value);
    }

}

/// <summary>
/// Block type for gallery_application in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineGalleryApplicationBlock : TerraformBlock
{
    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticUpgradeEnabled
    {
        set => SetProperty("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationBlobUri
    {
        set => SetProperty("configuration_blob_uri", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        set => SetProperty("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        set => SetProperty("tag", value);
    }

    /// <summary>
    /// The treat_failure_as_deployment_failure_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TreatFailureAsDeploymentFailureEnabled
    {
        set => SetProperty("treat_failure_as_deployment_failure_enabled", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    public required TerraformProperty<string> VersionId
    {
        set => SetProperty("version_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformProperty<string> Caching
    {
        set => SetProperty("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        set => SetProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        set => SetProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? SecureVmDiskEncryptionSetId
    {
        set => SetProperty("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityEncryptionType
    {
        set => SetProperty("security_encryption_type", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountType
    {
        set => SetProperty("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WriteAcceleratorEnabled
    {
        set => SetProperty("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for os_image_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineOsImageNotificationBlock : TerraformBlock
{
    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        set => SetProperty("timeout", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachinePlanBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformProperty<string> Product
    {
        set => SetProperty("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        set => SetProperty("publisher", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineSecretBlock : TerraformBlock
{
    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        set => SetProperty("key_vault_id", value);
    }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineSourceImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformProperty<string> Offer
    {
        set => SetProperty("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineTerminationNotificationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        set => SetProperty("timeout", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWindowsVirtualMachineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for winrm_listener in .
/// Nesting mode: set
/// </summary>
public class AzurermWindowsVirtualMachineWinrmListenerBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_url attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateUrl
    {
        set => SetProperty("certificate_url", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

}

/// <summary>
/// Manages a azurerm_windows_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWindowsVirtualMachine : TerraformResource
{
    public AzurermWindowsVirtualMachine(string name) : base("azurerm_windows_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("private_ip_address");
        SetOutput("private_ip_addresses");
        SetOutput("public_ip_address");
        SetOutput("public_ip_addresses");
        SetOutput("virtual_machine_id");
        SetOutput("admin_password");
        SetOutput("admin_username");
        SetOutput("allow_extension_operations");
        SetOutput("automatic_updates_enabled");
        SetOutput("availability_set_id");
        SetOutput("bypass_platform_safety_checks_on_user_schedule_enabled");
        SetOutput("capacity_reservation_group_id");
        SetOutput("computer_name");
        SetOutput("custom_data");
        SetOutput("dedicated_host_group_id");
        SetOutput("dedicated_host_id");
        SetOutput("disk_controller_type");
        SetOutput("edge_zone");
        SetOutput("enable_automatic_updates");
        SetOutput("encryption_at_host_enabled");
        SetOutput("eviction_policy");
        SetOutput("extensions_time_budget");
        SetOutput("hotpatching_enabled");
        SetOutput("id");
        SetOutput("license_type");
        SetOutput("location");
        SetOutput("max_bid_price");
        SetOutput("name");
        SetOutput("network_interface_ids");
        SetOutput("os_managed_disk_id");
        SetOutput("patch_assessment_mode");
        SetOutput("patch_mode");
        SetOutput("platform_fault_domain");
        SetOutput("priority");
        SetOutput("provision_vm_agent");
        SetOutput("proximity_placement_group_id");
        SetOutput("reboot_setting");
        SetOutput("resource_group_name");
        SetOutput("secure_boot_enabled");
        SetOutput("size");
        SetOutput("source_image_id");
        SetOutput("tags");
        SetOutput("timezone");
        SetOutput("user_data");
        SetOutput("virtual_machine_scale_set_id");
        SetOutput("vm_agent_platform_updates_enabled");
        SetOutput("vtpm_enabled");
        SetOutput("zone");
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformProperty<string> AdminPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_password");
        set => SetProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformProperty<string> AdminUsername
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_username");
        set => SetProperty("admin_username", value);
    }

    /// <summary>
    /// The allow_extension_operations attribute.
    /// </summary>
    public TerraformProperty<bool> AllowExtensionOperations
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_extension_operations");
        set => SetProperty("allow_extension_operations", value);
    }

    /// <summary>
    /// The automatic_updates_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutomaticUpdatesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatic_updates_enabled");
        set => SetProperty("automatic_updates_enabled", value);
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilitySetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_set_id");
        set => SetProperty("availability_set_id", value);
    }

    /// <summary>
    /// The bypass_platform_safety_checks_on_user_schedule_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BypassPlatformSafetyChecksOnUserScheduleEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bypass_platform_safety_checks_on_user_schedule_enabled");
        set => SetProperty("bypass_platform_safety_checks_on_user_schedule_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string> CapacityReservationGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("capacity_reservation_group_id");
        set => SetProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformProperty<string> ComputerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("computer_name");
        set => SetProperty("computer_name", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformProperty<string> CustomData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_data");
        set => SetProperty("custom_data", value);
    }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    public TerraformProperty<string> DedicatedHostGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dedicated_host_group_id");
        set => SetProperty("dedicated_host_group_id", value);
    }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    public TerraformProperty<string> DedicatedHostId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dedicated_host_id");
        set => SetProperty("dedicated_host_id", value);
    }

    /// <summary>
    /// The disk_controller_type attribute.
    /// </summary>
    public TerraformProperty<string> DiskControllerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_controller_type");
        set => SetProperty("disk_controller_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string> EdgeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edge_zone");
        set => SetProperty("edge_zone", value);
    }

    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool> EnableAutomaticUpdates
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_automatic_updates");
        set => SetProperty("enable_automatic_updates", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> EncryptionAtHostEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("encryption_at_host_enabled");
        set => SetProperty("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string> EvictionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eviction_policy");
        set => SetProperty("eviction_policy", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public TerraformProperty<string> ExtensionsTimeBudget
    {
        get => GetRequiredOutput<TerraformProperty<string>>("extensions_time_budget");
        set => SetProperty("extensions_time_budget", value);
    }

    /// <summary>
    /// The hotpatching_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> HotpatchingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("hotpatching_enabled");
        set => SetProperty("hotpatching_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string> LicenseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_type");
        set => SetProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    public TerraformProperty<double> MaxBidPrice
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_bid_price");
        set => SetProperty("max_bid_price", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    public List<TerraformProperty<string>> NetworkInterfaceIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("network_interface_ids");
        set => SetProperty("network_interface_ids", value);
    }

    /// <summary>
    /// The os_managed_disk_id attribute.
    /// </summary>
    public TerraformProperty<string> OsManagedDiskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_managed_disk_id");
        set => SetProperty("os_managed_disk_id", value);
    }

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    public TerraformProperty<string> PatchAssessmentMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("patch_assessment_mode");
        set => SetProperty("patch_assessment_mode", value);
    }

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    public TerraformProperty<string> PatchMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("patch_mode");
        set => SetProperty("patch_mode", value);
    }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    public TerraformProperty<double> PlatformFaultDomain
    {
        get => GetRequiredOutput<TerraformProperty<double>>("platform_fault_domain");
        set => SetProperty("platform_fault_domain", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string> Priority
    {
        get => GetRequiredOutput<TerraformProperty<string>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformProperty<bool> ProvisionVmAgent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("provision_vm_agent");
        set => SetProperty("provision_vm_agent", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string> ProximityPlacementGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("proximity_placement_group_id");
        set => SetProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The reboot_setting attribute.
    /// </summary>
    public TerraformProperty<string> RebootSetting
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reboot_setting");
        set => SetProperty("reboot_setting", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SecureBootEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("secure_boot_enabled");
        set => SetProperty("secure_boot_enabled", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<string> Size
    {
        get => GetRequiredOutput<TerraformProperty<string>>("size");
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceImageId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_image_id");
        set => SetProperty("source_image_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string> Timezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timezone");
        set => SetProperty("timezone", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string> UserData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_data");
        set => SetProperty("user_data", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformProperty<string> VirtualMachineScaleSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_machine_scale_set_id");
        set => SetProperty("virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The vm_agent_platform_updates_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool> VmAgentPlatformUpdatesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("vm_agent_platform_updates_enabled");
        set => SetProperty("vm_agent_platform_updates_enabled", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> VtpmEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("vtpm_enabled");
        set => SetProperty("vtpm_enabled", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public List<AzurermWindowsVirtualMachineAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        set => SetProperty("additional_capabilities", value);
    }

    /// <summary>
    /// Block for additional_unattend_content.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermWindowsVirtualMachineAdditionalUnattendContentBlock>? AdditionalUnattendContent
    {
        set => SetProperty("additional_unattend_content", value);
    }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public List<AzurermWindowsVirtualMachineBootDiagnosticsBlock>? BootDiagnostics
    {
        set => SetProperty("boot_diagnostics", value);
    }

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    public List<AzurermWindowsVirtualMachineGalleryApplicationBlock>? GalleryApplication
    {
        set => SetProperty("gallery_application", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermWindowsVirtualMachineIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public List<AzurermWindowsVirtualMachineOsDiskBlock>? OsDisk
    {
        set => SetProperty("os_disk", value);
    }

    /// <summary>
    /// Block for os_image_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsImageNotification block(s) allowed")]
    public List<AzurermWindowsVirtualMachineOsImageNotificationBlock>? OsImageNotification
    {
        set => SetProperty("os_image_notification", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermWindowsVirtualMachinePlanBlock>? Plan
    {
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermWindowsVirtualMachineSecretBlock>? Secret
    {
        set => SetProperty("secret", value);
    }

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    public List<AzurermWindowsVirtualMachineSourceImageReferenceBlock>? SourceImageReference
    {
        set => SetProperty("source_image_reference", value);
    }

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    public List<AzurermWindowsVirtualMachineTerminationNotificationBlock>? TerminationNotification
    {
        set => SetProperty("termination_notification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWindowsVirtualMachineTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for winrm_listener.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermWindowsVirtualMachineWinrmListenerBlock>? WinrmListener
    {
        set => SetProperty("winrm_listener", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddress => this["private_ip_address"];

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddresses => this["private_ip_addresses"];

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    public TerraformExpression PublicIpAddress => this["public_ip_address"];

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PublicIpAddresses => this["public_ip_addresses"];

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformExpression VirtualMachineId => this["virtual_machine_id"];

}
