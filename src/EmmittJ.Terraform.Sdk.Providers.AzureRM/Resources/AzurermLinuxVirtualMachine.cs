using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HibernationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("hibernation_enabled");
        set => WithProperty("hibernation_enabled", value);
    }

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UltraSsdEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ultra_ssd_enabled");
        set => WithProperty("ultra_ssd_enabled", value);
    }

}

/// <summary>
/// Block type for admin_ssh_key in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineAdminSshKeyBlock : TerraformBlock
{
    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    public required TerraformProperty<string> PublicKey
    {
        get => GetProperty<TerraformProperty<string>>("public_key");
        set => WithProperty("public_key", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineBootDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountUri
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_uri");
        set => WithProperty("storage_account_uri", value);
    }

}

/// <summary>
/// Block type for gallery_application in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineGalleryApplicationBlock : TerraformBlock
{
    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticUpgradeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_upgrade_enabled");
        set => WithProperty("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationBlobUri
    {
        get => GetProperty<TerraformProperty<string>>("configuration_blob_uri");
        set => WithProperty("configuration_blob_uri", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        get => GetProperty<TerraformProperty<string>>("tag");
        set => WithProperty("tag", value);
    }

    /// <summary>
    /// The treat_failure_as_deployment_failure_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TreatFailureAsDeploymentFailureEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("treat_failure_as_deployment_failure_enabled");
        set => WithProperty("treat_failure_as_deployment_failure_enabled", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    public required TerraformProperty<string> VersionId
    {
        get => GetProperty<TerraformProperty<string>>("version_id");
        set => WithProperty("version_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformProperty<string> Caching
    {
        get => GetProperty<TerraformProperty<string>>("caching");
        set => WithProperty("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? SecureVmDiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("secure_vm_disk_encryption_set_id");
        set => WithProperty("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityEncryptionType
    {
        get => GetProperty<TerraformProperty<string>>("security_encryption_type");
        set => WithProperty("security_encryption_type", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountType
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_type");
        set => WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WriteAcceleratorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("write_accelerator_enabled");
        set => WithProperty("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for os_image_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineOsImageNotificationBlock : TerraformBlock
{
    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        get => GetProperty<TerraformProperty<string>>("timeout");
        set => WithProperty("timeout", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachinePlanBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformProperty<string> Product
    {
        get => GetProperty<TerraformProperty<string>>("product");
        set => WithProperty("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineSecretBlock : TerraformBlock
{
    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => WithProperty("key_vault_id", value);
    }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineSourceImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformProperty<string> Offer
    {
        get => GetProperty<TerraformProperty<string>>("offer");
        set => WithProperty("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => WithProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineTerminationNotificationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        get => GetProperty<TerraformProperty<string>>("timeout");
        set => WithProperty("timeout", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLinuxVirtualMachineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_linux_virtual_machine resource.
/// </summary>
public class AzurermLinuxVirtualMachine : TerraformResource
{
    public AzurermLinuxVirtualMachine(string name) : base("azurerm_linux_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("private_ip_address");
        this.DeclareOutput("private_ip_addresses");
        this.DeclareOutput("public_ip_address");
        this.DeclareOutput("public_ip_addresses");
        this.DeclareOutput("virtual_machine_id");
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdminPassword
    {
        get => GetProperty<TerraformProperty<string>>("admin_password");
        set => this.WithProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformProperty<string>? AdminUsername
    {
        get => GetProperty<TerraformProperty<string>>("admin_username");
        set => this.WithProperty("admin_username", value);
    }

    /// <summary>
    /// The allow_extension_operations attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowExtensionOperations
    {
        get => GetProperty<TerraformProperty<bool>>("allow_extension_operations");
        set => this.WithProperty("allow_extension_operations", value);
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilitySetId
    {
        get => GetProperty<TerraformProperty<string>>("availability_set_id");
        set => this.WithProperty("availability_set_id", value);
    }

    /// <summary>
    /// The bypass_platform_safety_checks_on_user_schedule_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BypassPlatformSafetyChecksOnUserScheduleEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("bypass_platform_safety_checks_on_user_schedule_enabled");
        set => this.WithProperty("bypass_platform_safety_checks_on_user_schedule_enabled", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityReservationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("capacity_reservation_group_id");
        set => this.WithProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformProperty<string>? ComputerName
    {
        get => GetProperty<TerraformProperty<string>>("computer_name");
        set => this.WithProperty("computer_name", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformProperty<string>? CustomData
    {
        get => GetProperty<TerraformProperty<string>>("custom_data");
        set => this.WithProperty("custom_data", value);
    }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? DedicatedHostGroupId
    {
        get => GetProperty<TerraformProperty<string>>("dedicated_host_group_id");
        set => this.WithProperty("dedicated_host_group_id", value);
    }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    public TerraformProperty<string>? DedicatedHostId
    {
        get => GetProperty<TerraformProperty<string>>("dedicated_host_id");
        set => this.WithProperty("dedicated_host_id", value);
    }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    public TerraformProperty<bool>? DisablePasswordAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("disable_password_authentication");
        set => this.WithProperty("disable_password_authentication", value);
    }

    /// <summary>
    /// The disk_controller_type attribute.
    /// </summary>
    public TerraformProperty<string>? DiskControllerType
    {
        get => GetProperty<TerraformProperty<string>>("disk_controller_type");
        set => this.WithProperty("disk_controller_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionAtHostEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_at_host_enabled");
        set => this.WithProperty("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string>? EvictionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("eviction_policy");
        set => this.WithProperty("eviction_policy", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public TerraformProperty<string>? ExtensionsTimeBudget
    {
        get => GetProperty<TerraformProperty<string>>("extensions_time_budget");
        set => this.WithProperty("extensions_time_budget", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    public TerraformProperty<double>? MaxBidPrice
    {
        get => GetProperty<TerraformProperty<double>>("max_bid_price");
        set => this.WithProperty("max_bid_price", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    public List<TerraformProperty<string>>? NetworkInterfaceIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("network_interface_ids");
        set => this.WithProperty("network_interface_ids", value);
    }

    /// <summary>
    /// The os_managed_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? OsManagedDiskId
    {
        get => GetProperty<TerraformProperty<string>>("os_managed_disk_id");
        set => this.WithProperty("os_managed_disk_id", value);
    }

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PatchAssessmentMode
    {
        get => GetProperty<TerraformProperty<string>>("patch_assessment_mode");
        set => this.WithProperty("patch_assessment_mode", value);
    }

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PatchMode
    {
        get => GetProperty<TerraformProperty<string>>("patch_mode");
        set => this.WithProperty("patch_mode", value);
    }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    public TerraformProperty<double>? PlatformFaultDomain
    {
        get => GetProperty<TerraformProperty<double>>("platform_fault_domain");
        set => this.WithProperty("platform_fault_domain", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string>? Priority
    {
        get => GetProperty<TerraformProperty<string>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformProperty<bool>? ProvisionVmAgent
    {
        get => GetProperty<TerraformProperty<bool>>("provision_vm_agent");
        set => this.WithProperty("provision_vm_agent", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("proximity_placement_group_id");
        set => this.WithProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The reboot_setting attribute.
    /// </summary>
    public TerraformProperty<string>? RebootSetting
    {
        get => GetProperty<TerraformProperty<string>>("reboot_setting");
        set => this.WithProperty("reboot_setting", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SecureBootEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("secure_boot_enabled");
        set => this.WithProperty("secure_boot_enabled", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<string> Size
    {
        get => GetProperty<TerraformProperty<string>>("size");
        set => this.WithProperty("size", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceImageId
    {
        get => GetProperty<TerraformProperty<string>>("source_image_id");
        set => this.WithProperty("source_image_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        get => GetProperty<TerraformProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualMachineScaleSetId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_scale_set_id");
        set => this.WithProperty("virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The vm_agent_platform_updates_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? VmAgentPlatformUpdatesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vm_agent_platform_updates_enabled");
        set => this.WithProperty("vm_agent_platform_updates_enabled", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VtpmEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vtpm_enabled");
        set => this.WithProperty("vtpm_enabled", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public List<AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineAdditionalCapabilitiesBlock>>("additional_capabilities");
        set => this.WithProperty("additional_capabilities", value);
    }

    /// <summary>
    /// Block for admin_ssh_key.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermLinuxVirtualMachineAdminSshKeyBlock>? AdminSshKey
    {
        get => GetProperty<HashSet<AzurermLinuxVirtualMachineAdminSshKeyBlock>>("admin_ssh_key");
        set => this.WithProperty("admin_ssh_key", value);
    }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public List<AzurermLinuxVirtualMachineBootDiagnosticsBlock>? BootDiagnostics
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineBootDiagnosticsBlock>>("boot_diagnostics");
        set => this.WithProperty("boot_diagnostics", value);
    }

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    public List<AzurermLinuxVirtualMachineGalleryApplicationBlock>? GalleryApplication
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineGalleryApplicationBlock>>("gallery_application");
        set => this.WithProperty("gallery_application", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermLinuxVirtualMachineIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public List<AzurermLinuxVirtualMachineOsDiskBlock>? OsDisk
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineOsDiskBlock>>("os_disk");
        set => this.WithProperty("os_disk", value);
    }

    /// <summary>
    /// Block for os_image_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsImageNotification block(s) allowed")]
    public List<AzurermLinuxVirtualMachineOsImageNotificationBlock>? OsImageNotification
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineOsImageNotificationBlock>>("os_image_notification");
        set => this.WithProperty("os_image_notification", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermLinuxVirtualMachinePlanBlock>? Plan
    {
        get => GetProperty<List<AzurermLinuxVirtualMachinePlanBlock>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermLinuxVirtualMachineSecretBlock>? Secret
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineSecretBlock>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    public List<AzurermLinuxVirtualMachineSourceImageReferenceBlock>? SourceImageReference
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineSourceImageReferenceBlock>>("source_image_reference");
        set => this.WithProperty("source_image_reference", value);
    }

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    public List<AzurermLinuxVirtualMachineTerminationNotificationBlock>? TerminationNotification
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineTerminationNotificationBlock>>("termination_notification");
        set => this.WithProperty("termination_notification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLinuxVirtualMachineTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLinuxVirtualMachineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
