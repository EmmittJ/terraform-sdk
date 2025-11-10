using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetBootDiagnosticsBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformPropertyName("storage_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageUri { get; set; }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetExtensionBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    [TerraformPropertyName("auto_upgrade_minor_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformPropertyName("protected_settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProtectedSettings { get; set; }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    [TerraformPropertyName("provision_after_extensions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ProvisionAfterExtensions { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Publisher { get; set; }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    [TerraformPropertyName("settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Settings { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    [TerraformPropertyName("type_handler_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TypeHandlerVersion { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetIdentityBlock : ITerraformBlock
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
/// Block type for network_profile in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetNetworkProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The accelerated_networking attribute.
    /// </summary>
    [TerraformPropertyName("accelerated_networking")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AcceleratedNetworking { get; set; }

    /// <summary>
    /// The ip_forwarding attribute.
    /// </summary>
    [TerraformPropertyName("ip_forwarding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IpForwarding { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("network_security_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NetworkSecurityGroupId { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    [TerraformPropertyName("primary")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Primary { get; set; }

}

/// <summary>
/// Block type for os_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileBlock : ITerraformBlock
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
    /// The computer_name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerNamePrefix is required")]
    [TerraformPropertyName("computer_name_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ComputerNamePrefix { get; set; }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformPropertyName("custom_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomData { get; set; }

}

/// <summary>
/// Block type for os_profile_linux_config in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [TerraformPropertyName("disable_password_authentication")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisablePasswordAuthentication { get; set; }

}

/// <summary>
/// Block type for os_profile_secrets in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileSecretsBlock : ITerraformBlock
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
public class AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock : ITerraformBlock
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

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetPlanBlock : ITerraformBlock
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
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [TerraformPropertyName("max_batch_instance_percent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxBatchInstancePercent { get; set; }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [TerraformPropertyName("max_unhealthy_instance_percent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxUnhealthyInstancePercent { get; set; }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [TerraformPropertyName("max_unhealthy_upgraded_instance_percent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [TerraformPropertyName("pause_time_between_batches")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PauseTimeBetweenBatches { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetSkuBlock : ITerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformPropertyName("capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Tier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "tier");

}

/// <summary>
/// Block type for storage_profile_data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock : ITerraformBlock
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
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedDiskType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "managed_disk_type");

}

/// <summary>
/// Block type for storage_profile_image_reference in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock : ITerraformBlock
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
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

}

/// <summary>
/// Block type for storage_profile_os_disk in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock : ITerraformBlock
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
    /// The image attribute.
    /// </summary>
    [TerraformPropertyName("image")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Image { get; set; }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedDiskType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "managed_disk_type");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OsType { get; set; }

    /// <summary>
    /// The vhd_containers attribute.
    /// </summary>
    [TerraformPropertyName("vhd_containers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? VhdContainers { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineScaleSetTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_virtual_machine_scale_set resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualMachineScaleSet : TerraformResource
{
    public AzurermVirtualMachineScaleSet(string name) : base("azurerm_virtual_machine_scale_set", name)
    {
    }

    /// <summary>
    /// The automatic_os_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("automatic_os_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutomaticOsUpgrade { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformPropertyName("eviction_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EvictionPolicy { get; set; }

    /// <summary>
    /// The health_probe_id attribute.
    /// </summary>
    [TerraformPropertyName("health_probe_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthProbeId { get; set; }

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
    /// The overprovision attribute.
    /// </summary>
    [TerraformPropertyName("overprovision")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Overprovision { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Priority { get; set; }

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
    /// The single_placement_group attribute.
    /// </summary>
    [TerraformPropertyName("single_placement_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SinglePlacementGroup { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The upgrade_policy_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradePolicyMode is required")]
    [TerraformPropertyName("upgrade_policy_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UpgradePolicyMode { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Zones { get; set; }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformPropertyName("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetBootDiagnosticsBlock>>? BootDiagnostics { get; set; } = new();

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("extension")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetExtensionBlock>>? Extension { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [TerraformPropertyName("network_profile")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetNetworkProfileBlock>>? NetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    [TerraformPropertyName("os_profile")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetOsProfileBlock>>? OsProfile { get; set; } = new();

    /// <summary>
    /// Block for os_profile_linux_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    [TerraformPropertyName("os_profile_linux_config")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock>>? OsProfileLinuxConfig { get; set; } = new();

    /// <summary>
    /// Block for os_profile_secrets.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("os_profile_secrets")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetOsProfileSecretsBlock>>? OsProfileSecrets { get; set; } = new();

    /// <summary>
    /// Block for os_profile_windows_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    [TerraformPropertyName("os_profile_windows_config")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock>>? OsProfileWindowsConfig { get; set; } = new();

    /// <summary>
    /// Block for plan.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformPropertyName("plan")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetPlanBlock>>? Plan { get; set; } = new();

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    [TerraformPropertyName("rolling_upgrade_policy")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock>>? RollingUpgradePolicy { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformPropertyName("sku")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetSkuBlock>>? Sku { get; set; } = new();

    /// <summary>
    /// Block for storage_profile_data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("storage_profile_data_disk")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock>>? StorageProfileDataDisk { get; set; } = new();

    /// <summary>
    /// Block for storage_profile_image_reference.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfileImageReference block(s) allowed")]
    [TerraformPropertyName("storage_profile_image_reference")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock>>? StorageProfileImageReference { get; set; } = new();

    /// <summary>
    /// Block for storage_profile_os_disk.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageProfileOsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageProfileOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfileOsDisk block(s) allowed")]
    [TerraformPropertyName("storage_profile_os_disk")]
    public TerraformSet<TerraformBlock<AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock>>? StorageProfileOsDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualMachineScaleSetTimeoutsBlock>? Timeouts { get; set; } = new();

}
