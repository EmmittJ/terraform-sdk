using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineAdditionalCapabilitiesBlock
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UltraSsdEnabled is required")]
    [TerraformPropertyName("ultra_ssd_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineBootDiagnosticsBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformPropertyName("storage_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageUri { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineIdentityBlock
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
/// Block type for os_profile in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineOsProfileBlock
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformPropertyName("admin_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformPropertyName("admin_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdminUsername { get; set; }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerName is required")]
    [TerraformPropertyName("computer_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ComputerName { get; set; }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformPropertyName("custom_data")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CustomData { get; set; } = default!;

}

/// <summary>
/// Block type for os_profile_linux_config in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineOsProfileLinuxConfigBlock
{
    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisablePasswordAuthentication is required")]
    [TerraformPropertyName("disable_password_authentication")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> DisablePasswordAuthentication { get; set; }

}

/// <summary>
/// Block type for os_profile_secrets in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineOsProfileSecretsBlock
{
    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    [TerraformPropertyName("source_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceVaultId { get; set; }

}

/// <summary>
/// Block type for os_profile_windows_config in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineOsProfileWindowsConfigBlock
{
    /// <summary>
    /// The enable_automatic_upgrades attribute.
    /// </summary>
    [TerraformPropertyName("enable_automatic_upgrades")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableAutomaticUpgrades { get; set; }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformPropertyName("provision_vm_agent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ProvisionVmAgent { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Timezone { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachinePlanBlock
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
/// Block type for storage_data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineStorageDataDiskBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformPropertyName("caching")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Caching { get; set; } = default!;

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformPropertyName("create_option")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CreateOption { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskSizeGb { get; set; } = default!;

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformPropertyName("lun")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Lun { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ManagedDiskId { get; set; } = default!;

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ManagedDiskType { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    [TerraformPropertyName("vhd_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VhdUri { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("write_accelerator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for storage_image_reference in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineStorageImageReferenceBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [TerraformPropertyName("offer")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [TerraformPropertyName("publisher")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

}

/// <summary>
/// Block type for storage_os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineStorageOsDiskBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformPropertyName("caching")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Caching { get; set; } = default!;

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformPropertyName("create_option")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CreateOption { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskSizeGb { get; set; } = default!;

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformPropertyName("image_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageUri { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ManagedDiskId { get; set; } = default!;

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ManagedDiskType { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OsType { get; set; } = default!;

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    [TerraformPropertyName("vhd_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VhdUri { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("write_accelerator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineTimeoutsBlock
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
/// Manages a azurerm_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualMachine : TerraformResource
{
    public AzurermVirtualMachine(string name) : base("azurerm_virtual_machine", name)
    {
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_set_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilitySetId { get; set; } = default!;

    /// <summary>
    /// The delete_data_disks_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_data_disks_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeleteDataDisksOnTermination { get; set; }

    /// <summary>
    /// The delete_os_disk_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_os_disk_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeleteOsDiskOnTermination { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LicenseType { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

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
    /// The primary_network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("primary_network_interface_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrimaryNetworkInterfaceId { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformPropertyName("vm_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VmSize { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Zones { get; set; }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformPropertyName("additional_capabilities")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineAdditionalCapabilitiesBlock>>? AdditionalCapabilities { get; set; }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformPropertyName("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineBootDiagnosticsBlock>>? BootDiagnostics { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    [TerraformPropertyName("os_profile")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineOsProfileBlock>>? OsProfile { get; set; }

    /// <summary>
    /// Block for os_profile_linux_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    [TerraformPropertyName("os_profile_linux_config")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineOsProfileLinuxConfigBlock>>? OsProfileLinuxConfig { get; set; }

    /// <summary>
    /// Block for os_profile_secrets.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("os_profile_secrets")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineOsProfileSecretsBlock>>? OsProfileSecrets { get; set; }

    /// <summary>
    /// Block for os_profile_windows_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    [TerraformPropertyName("os_profile_windows_config")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineOsProfileWindowsConfigBlock>>? OsProfileWindowsConfig { get; set; }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformPropertyName("plan")]
    public TerraformList<TerraformBlock<AzurermVirtualMachinePlanBlock>>? Plan { get; set; }

    /// <summary>
    /// Block for storage_data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("storage_data_disk")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineStorageDataDiskBlock>>? StorageDataDisk { get; set; }

    /// <summary>
    /// Block for storage_image_reference.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    [TerraformPropertyName("storage_image_reference")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineStorageImageReferenceBlock>>? StorageImageReference { get; set; }

    /// <summary>
    /// Block for storage_os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageOsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageOsDisk block(s) allowed")]
    [TerraformPropertyName("storage_os_disk")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineStorageOsDiskBlock>>? StorageOsDisk { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualMachineTimeoutsBlock>? Timeouts { get; set; }

}
