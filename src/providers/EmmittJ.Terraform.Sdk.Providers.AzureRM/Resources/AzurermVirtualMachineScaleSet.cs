using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineScaleSetBootDiagnosticsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformProperty("storage_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageUri { get; set; }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineScaleSetExtensionBlock : TerraformBlockBase
{
    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    [TerraformProperty("auto_upgrade_minor_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformProperty("protected_settings")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProtectedSettings { get; set; }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    [TerraformProperty("provision_after_extensions")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    [TerraformProperty("settings")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Settings { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    [TerraformProperty("type_handler_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TypeHandlerVersion { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineScaleSetIdentityBlock : TerraformBlockBase
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
/// Block type for network_profile in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineScaleSetNetworkProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The accelerated_networking attribute.
    /// </summary>
    [TerraformProperty("accelerated_networking")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AcceleratedNetworking { get; set; }

    /// <summary>
    /// The ip_forwarding attribute.
    /// </summary>
    [TerraformProperty("ip_forwarding")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IpForwarding { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformProperty("network_security_group_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkSecurityGroupId { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    [TerraformProperty("primary")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Primary { get; set; }

}

/// <summary>
/// Block type for os_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineScaleSetOsProfileBlock : TerraformBlockBase
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
    /// The computer_name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerNamePrefix is required")]
    [TerraformProperty("computer_name_prefix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ComputerNamePrefix { get; set; }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformProperty("custom_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomData { get; set; }

}

/// <summary>
/// Block type for os_profile_linux_config in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [TerraformProperty("disable_password_authentication")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisablePasswordAuthentication { get; set; }

}

/// <summary>
/// Block type for os_profile_secrets in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineScaleSetOsProfileSecretsBlock : TerraformBlockBase
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
public partial class AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock : TerraformBlockBase
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

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineScaleSetPlanBlock : TerraformBlockBase
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
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [TerraformProperty("max_batch_instance_percent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxBatchInstancePercent { get; set; }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [TerraformProperty("max_unhealthy_instance_percent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxUnhealthyInstancePercent { get; set; }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [TerraformProperty("max_unhealthy_upgraded_instance_percent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [TerraformProperty("pause_time_between_batches")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PauseTimeBetweenBatches { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineScaleSetSkuBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformProperty("capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformProperty("tier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Tier { get; set; }

}

/// <summary>
/// Block type for storage_profile_data_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock : TerraformBlockBase
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
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformProperty("managed_disk_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedDiskType { get; set; }

}

/// <summary>
/// Block type for storage_profile_image_reference in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock : TerraformBlockBase
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
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for storage_profile_os_disk in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock : TerraformBlockBase
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
    /// The image attribute.
    /// </summary>
    [TerraformProperty("image")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Image { get; set; }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformProperty("managed_disk_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedDiskType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OsType { get; set; }

    /// <summary>
    /// The vhd_containers attribute.
    /// </summary>
    [TerraformProperty("vhd_containers")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? VhdContainers { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualMachineScaleSetTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_virtual_machine_scale_set resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualMachineScaleSet : TerraformResource
{
    public AzurermVirtualMachineScaleSet(string name) : base("azurerm_virtual_machine_scale_set", name)
    {
    }

    /// <summary>
    /// The automatic_os_upgrade attribute.
    /// </summary>
    [TerraformProperty("automatic_os_upgrade")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutomaticOsUpgrade { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformProperty("eviction_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EvictionPolicy { get; set; }

    /// <summary>
    /// The health_probe_id attribute.
    /// </summary>
    [TerraformProperty("health_probe_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HealthProbeId { get; set; }

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
    /// The overprovision attribute.
    /// </summary>
    [TerraformProperty("overprovision")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Overprovision { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Priority { get; set; }

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
    /// The single_placement_group attribute.
    /// </summary>
    [TerraformProperty("single_placement_group")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SinglePlacementGroup { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The upgrade_policy_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradePolicyMode is required")]
    [TerraformProperty("upgrade_policy_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UpgradePolicyMode { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Zones { get; set; }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformProperty("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetBootDiagnosticsBlock>>? BootDiagnostics { get; set; }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("extension")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetExtensionBlock>>? Extension { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [TerraformProperty("network_profile")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetNetworkProfileBlock>>? NetworkProfile { get; set; }

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    [TerraformProperty("os_profile")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetOsProfileBlock>>? OsProfile { get; set; }

    /// <summary>
    /// Block for os_profile_linux_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    [TerraformProperty("os_profile_linux_config")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock>>? OsProfileLinuxConfig { get; set; }

    /// <summary>
    /// Block for os_profile_secrets.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("os_profile_secrets")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetOsProfileSecretsBlock>>? OsProfileSecrets { get; set; }

    /// <summary>
    /// Block for os_profile_windows_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    [TerraformProperty("os_profile_windows_config")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock>>? OsProfileWindowsConfig { get; set; }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformProperty("plan")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetPlanBlock>>? Plan { get; set; }

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    [TerraformProperty("rolling_upgrade_policy")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock>>? RollingUpgradePolicy { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetSkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for storage_profile_data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("storage_profile_data_disk")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock>>? StorageProfileDataDisk { get; set; }

    /// <summary>
    /// Block for storage_profile_image_reference.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfileImageReference block(s) allowed")]
    [TerraformProperty("storage_profile_image_reference")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock>>? StorageProfileImageReference { get; set; }

    /// <summary>
    /// Block for storage_profile_os_disk.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageProfileOsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageProfileOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfileOsDisk block(s) allowed")]
    [TerraformProperty("storage_profile_os_disk")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock>>? StorageProfileOsDisk { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualMachineScaleSetTimeoutsBlock>? Timeouts { get; set; }

}
