using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineAdditionalCapabilitiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UltraSsdEnabled is required")]
    [TerraformProperty("ultra_ssd_enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineBootDiagnosticsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformProperty("storage_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageUri { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineIdentityBlock : TerraformBlockBase
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
/// Block type for os_profile in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineOsProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformProperty("admin_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformProperty("admin_username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AdminUsername { get; set; }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerName is required")]
    [TerraformProperty("computer_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ComputerName { get; set; }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformProperty("custom_data")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CustomData { get; set; }

}

/// <summary>
/// Block type for os_profile_linux_config in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineOsProfileLinuxConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisablePasswordAuthentication is required")]
    [TerraformProperty("disable_password_authentication")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> DisablePasswordAuthentication { get; set; }

}

/// <summary>
/// Block type for os_profile_secrets in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineOsProfileSecretsBlock : TerraformBlockBase
{
    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    [TerraformProperty("source_vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceVaultId { get; set; }

}

/// <summary>
/// Block type for os_profile_windows_config in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineOsProfileWindowsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The enable_automatic_upgrades attribute.
    /// </summary>
    [TerraformProperty("enable_automatic_upgrades")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableAutomaticUpgrades { get; set; }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformProperty("provision_vm_agent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ProvisionVmAgent { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformProperty("timezone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Timezone { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachinePlanBlock : TerraformBlockBase
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
/// Block type for storage_data_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineStorageDataDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformProperty("caching")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Caching { get; set; }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformProperty("create_option")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CreateOption { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformProperty("lun")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Lun { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformProperty("managed_disk_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedDiskId { get; set; }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformProperty("managed_disk_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedDiskType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    [TerraformProperty("vhd_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VhdUri { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformProperty("write_accelerator_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for storage_image_reference in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineStorageImageReferenceBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [TerraformProperty("offer")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [TerraformProperty("publisher")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for storage_os_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineStorageOsDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformProperty("caching")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Caching { get; set; }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformProperty("create_option")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CreateOption { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformProperty("image_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageUri { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformProperty("managed_disk_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedDiskId { get; set; }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformProperty("managed_disk_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedDiskType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OsType { get; set; }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    [TerraformProperty("vhd_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VhdUri { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformProperty("write_accelerator_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualMachineTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualMachine : TerraformResource
{
    public AzurermVirtualMachine(string name) : base("azurerm_virtual_machine", name)
    {
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    [TerraformProperty("availability_set_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AvailabilitySetId { get; set; }

    /// <summary>
    /// The delete_data_disks_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_data_disks_on_termination")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteDataDisksOnTermination { get; set; }

    /// <summary>
    /// The delete_os_disk_on_termination attribute.
    /// </summary>
    [TerraformProperty("delete_os_disk_on_termination")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteOsDiskOnTermination { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

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
    /// The primary_network_interface_id attribute.
    /// </summary>
    [TerraformProperty("primary_network_interface_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrimaryNetworkInterfaceId { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformProperty("proximity_placement_group_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformProperty("vm_size")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VmSize { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Zones { get; set; }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformProperty("additional_capabilities")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineAdditionalCapabilitiesBlock>>? AdditionalCapabilities { get; set; }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformProperty("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineBootDiagnosticsBlock>>? BootDiagnostics { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    [TerraformProperty("os_profile")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineOsProfileBlock>>? OsProfile { get; set; }

    /// <summary>
    /// Block for os_profile_linux_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    [TerraformProperty("os_profile_linux_config")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineOsProfileLinuxConfigBlock>>? OsProfileLinuxConfig { get; set; }

    /// <summary>
    /// Block for os_profile_secrets.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("os_profile_secrets")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineOsProfileSecretsBlock>>? OsProfileSecrets { get; set; }

    /// <summary>
    /// Block for os_profile_windows_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    [TerraformProperty("os_profile_windows_config")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineOsProfileWindowsConfigBlock>>? OsProfileWindowsConfig { get; set; }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformProperty("plan")]
    public TerraformList<TerraformBlock<AzurermVirtualMachinePlanBlock>>? Plan { get; set; }

    /// <summary>
    /// Block for storage_data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("storage_data_disk")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineStorageDataDiskBlock>>? StorageDataDisk { get; set; }

    /// <summary>
    /// Block for storage_image_reference.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    [TerraformProperty("storage_image_reference")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineStorageImageReferenceBlock>>? StorageImageReference { get; set; }

    /// <summary>
    /// Block for storage_os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageOsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageOsDisk block(s) allowed")]
    [TerraformProperty("storage_os_disk")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineStorageOsDiskBlock>>? StorageOsDisk { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualMachineTimeoutsBlock>? Timeouts { get; set; }

}
