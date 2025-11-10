using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineAdditionalCapabilitiesBlock : ITerraformBlock
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UltraSsdEnabled is required")]
    [TerraformPropertyName("ultra_ssd_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineBootDiagnosticsBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformPropertyName("storage_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageUri { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineIdentityBlock : ITerraformBlock
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
/// Block type for os_profile in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineOsProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformPropertyName("admin_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformPropertyName("admin_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AdminUsername { get; set; }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerName is required")]
    [TerraformPropertyName("computer_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ComputerName { get; set; }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformPropertyName("custom_data")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CustomData { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "custom_data");

}

/// <summary>
/// Block type for os_profile_linux_config in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineOsProfileLinuxConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisablePasswordAuthentication is required")]
    [TerraformPropertyName("disable_password_authentication")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> DisablePasswordAuthentication { get; set; }

}

/// <summary>
/// Block type for os_profile_secrets in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineOsProfileSecretsBlock : ITerraformBlock
{
    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    [TerraformPropertyName("source_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceVaultId { get; set; }

}

/// <summary>
/// Block type for os_profile_windows_config in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineOsProfileWindowsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The enable_automatic_upgrades attribute.
    /// </summary>
    [TerraformPropertyName("enable_automatic_upgrades")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableAutomaticUpgrades { get; set; }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformPropertyName("provision_vm_agent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ProvisionVmAgent { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Timezone { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachinePlanBlock : ITerraformBlock
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
/// Block type for storage_data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineStorageDataDiskBlock : ITerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformPropertyName("caching")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Caching { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "caching");

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformPropertyName("create_option")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CreateOption { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DiskSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "disk_size_gb");

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformPropertyName("lun")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Lun { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedDiskId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "managed_disk_id");

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedDiskType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "managed_disk_type");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    [TerraformPropertyName("vhd_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VhdUri { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("write_accelerator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for storage_image_reference in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineStorageImageReferenceBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Id { get; set; }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [TerraformPropertyName("offer")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [TerraformPropertyName("publisher")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "version");

}

/// <summary>
/// Block type for storage_os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineStorageOsDiskBlock : ITerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformPropertyName("caching")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Caching { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "caching");

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformPropertyName("create_option")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CreateOption { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DiskSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "disk_size_gb");

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformPropertyName("image_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageUri { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedDiskId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "managed_disk_id");

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedDiskType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "managed_disk_type");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OsType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "os_type");

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    [TerraformPropertyName("vhd_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VhdUri { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("write_accelerator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineTimeoutsBlock : ITerraformBlock
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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilitySetId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_set_id");

    /// <summary>
    /// The delete_data_disks_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_data_disks_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteDataDisksOnTermination { get; set; }

    /// <summary>
    /// The delete_os_disk_on_termination attribute.
    /// </summary>
    [TerraformPropertyName("delete_os_disk_on_termination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteOsDiskOnTermination { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LicenseType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

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
    /// The primary_network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("primary_network_interface_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrimaryNetworkInterfaceId { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformPropertyName("vm_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmSize { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Zones { get; set; }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformPropertyName("additional_capabilities")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineAdditionalCapabilitiesBlock>>? AdditionalCapabilities { get; set; } = new();

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformPropertyName("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineBootDiagnosticsBlock>>? BootDiagnostics { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    [TerraformPropertyName("os_profile")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineOsProfileBlock>>? OsProfile { get; set; } = new();

    /// <summary>
    /// Block for os_profile_linux_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    [TerraformPropertyName("os_profile_linux_config")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineOsProfileLinuxConfigBlock>>? OsProfileLinuxConfig { get; set; } = new();

    /// <summary>
    /// Block for os_profile_secrets.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("os_profile_secrets")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineOsProfileSecretsBlock>>? OsProfileSecrets { get; set; } = new();

    /// <summary>
    /// Block for os_profile_windows_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    [TerraformPropertyName("os_profile_windows_config")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineOsProfileWindowsConfigBlock>>? OsProfileWindowsConfig { get; set; } = new();

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformPropertyName("plan")]
    public TerraformList<TerraformBlock<AzurermVirtualMachinePlanBlock>>? Plan { get; set; } = new();

    /// <summary>
    /// Block for storage_data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("storage_data_disk")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineStorageDataDiskBlock>>? StorageDataDisk { get; set; } = new();

    /// <summary>
    /// Block for storage_image_reference.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    [TerraformPropertyName("storage_image_reference")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineStorageImageReferenceBlock>>? StorageImageReference { get; set; } = new();

    /// <summary>
    /// Block for storage_os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageOsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageOsDisk block(s) allowed")]
    [TerraformPropertyName("storage_os_disk")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineStorageOsDiskBlock>>? StorageOsDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualMachineTimeoutsBlock>? Timeouts { get; set; } = new();

}
