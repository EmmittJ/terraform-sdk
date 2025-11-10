using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetBootDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformProperty<string> StorageUri
    {
        set => SetProperty("storage_uri", value);
    }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetExtensionBlock : TerraformBlock
{
    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoUpgradeMinorVersion
    {
        set => SetProperty("auto_upgrade_minor_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformProperty<string>? ProtectedSettings
    {
        set => SetProperty("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ProvisionAfterExtensions
    {
        set => SetProperty("provision_after_extensions", value);
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
    /// The settings attribute.
    /// </summary>
    public TerraformProperty<string>? Settings
    {
        set => SetProperty("settings", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    public required TerraformProperty<string> TypeHandlerVersion
    {
        set => SetProperty("type_handler_version", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetIdentityBlock : TerraformBlock
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
/// Block type for network_profile in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// The accelerated_networking attribute.
    /// </summary>
    public TerraformProperty<bool>? AcceleratedNetworking
    {
        set => SetProperty("accelerated_networking", value);
    }

    /// <summary>
    /// The ip_forwarding attribute.
    /// </summary>
    public TerraformProperty<bool>? IpForwarding
    {
        set => SetProperty("ip_forwarding", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkSecurityGroupId
    {
        set => SetProperty("network_security_group_id", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    public required TerraformProperty<bool> Primary
    {
        set => SetProperty("primary", value);
    }

}

/// <summary>
/// Block type for os_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileBlock : TerraformBlock
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdminPassword
    {
        set => SetProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformProperty<string> AdminUsername
    {
        set => SetProperty("admin_username", value);
    }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerNamePrefix is required")]
    public required TerraformProperty<string> ComputerNamePrefix
    {
        set => SetProperty("computer_name_prefix", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformProperty<string>? CustomData
    {
        set => SetProperty("custom_data", value);
    }

}

/// <summary>
/// Block type for os_profile_linux_config in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock : TerraformBlock
{
    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    public TerraformProperty<bool>? DisablePasswordAuthentication
    {
        set => SetProperty("disable_password_authentication", value);
    }

}

/// <summary>
/// Block type for os_profile_secrets in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileSecretsBlock : TerraformBlock
{
    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformProperty<string> SourceVaultId
    {
        set => SetProperty("source_vault_id", value);
    }

}

/// <summary>
/// Block type for os_profile_windows_config in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The enable_automatic_upgrades attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAutomaticUpgrades
    {
        set => SetProperty("enable_automatic_upgrades", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformProperty<bool>? ProvisionVmAgent
    {
        set => SetProperty("provision_vm_agent", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetPlanBlock : TerraformBlock
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
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MaxBatchInstancePercent
    {
        set => SetProperty("max_batch_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnhealthyInstancePercent
    {
        set => SetProperty("max_unhealthy_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnhealthyUpgradedInstancePercent
    {
        set => SetProperty("max_unhealthy_upgraded_instance_percent", value);
    }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    public TerraformProperty<string>? PauseTimeBetweenBatches
    {
        set => SetProperty("pause_time_between_batches", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetSkuBlock : TerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformProperty<double> Capacity
    {
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        set => SetProperty("tier", value);
    }

}

/// <summary>
/// Block type for storage_profile_data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformProperty<string>? Caching
    {
        set => SetProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformProperty<string> CreateOption
    {
        set => SetProperty("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        set => SetProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformProperty<double> Lun
    {
        set => SetProperty("lun", value);
    }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskType
    {
        set => SetProperty("managed_disk_type", value);
    }

}

/// <summary>
/// Block type for storage_profile_image_reference in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    public TerraformProperty<string>? Offer
    {
        set => SetProperty("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformProperty<string>? Publisher
    {
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for storage_profile_os_disk in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformProperty<string>? Caching
    {
        set => SetProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformProperty<string> CreateOption
    {
        set => SetProperty("create_option", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformProperty<string>? Image
    {
        set => SetProperty("image", value);
    }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskType
    {
        set => SetProperty("managed_disk_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsType
    {
        set => SetProperty("os_type", value);
    }

    /// <summary>
    /// The vhd_containers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VhdContainers
    {
        set => SetProperty("vhd_containers", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineScaleSetTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_machine_scale_set resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualMachineScaleSet : TerraformResource
{
    public AzurermVirtualMachineScaleSet(string name) : base("azurerm_virtual_machine_scale_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("automatic_os_upgrade");
        SetOutput("eviction_policy");
        SetOutput("health_probe_id");
        SetOutput("id");
        SetOutput("license_type");
        SetOutput("location");
        SetOutput("name");
        SetOutput("overprovision");
        SetOutput("priority");
        SetOutput("proximity_placement_group_id");
        SetOutput("resource_group_name");
        SetOutput("single_placement_group");
        SetOutput("tags");
        SetOutput("upgrade_policy_mode");
        SetOutput("zones");
    }

    /// <summary>
    /// The automatic_os_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AutomaticOsUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatic_os_upgrade");
        set => SetProperty("automatic_os_upgrade", value);
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
    /// The health_probe_id attribute.
    /// </summary>
    public TerraformProperty<string> HealthProbeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("health_probe_id");
        set => SetProperty("health_probe_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The overprovision attribute.
    /// </summary>
    public TerraformProperty<bool> Overprovision
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("overprovision");
        set => SetProperty("overprovision", value);
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
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string> ProximityPlacementGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("proximity_placement_group_id");
        set => SetProperty("proximity_placement_group_id", value);
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
    /// The single_placement_group attribute.
    /// </summary>
    public TerraformProperty<bool> SinglePlacementGroup
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("single_placement_group");
        set => SetProperty("single_placement_group", value);
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
    /// The upgrade_policy_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradePolicyMode is required")]
    public required TerraformProperty<string> UpgradePolicyMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("upgrade_policy_mode");
        set => SetProperty("upgrade_policy_mode", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public List<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetBootDiagnosticsBlock>? BootDiagnostics
    {
        set => SetProperty("boot_diagnostics", value);
    }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVirtualMachineScaleSetExtensionBlock>? Extension
    {
        set => SetProperty("extension", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    public HashSet<AzurermVirtualMachineScaleSetNetworkProfileBlock>? NetworkProfile
    {
        set => SetProperty("network_profile", value);
    }

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetOsProfileBlock>? OsProfile
    {
        set => SetProperty("os_profile", value);
    }

    /// <summary>
    /// Block for os_profile_linux_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    public HashSet<AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock>? OsProfileLinuxConfig
    {
        set => SetProperty("os_profile_linux_config", value);
    }

    /// <summary>
    /// Block for os_profile_secrets.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVirtualMachineScaleSetOsProfileSecretsBlock>? OsProfileSecrets
    {
        set => SetProperty("os_profile_secrets", value);
    }

    /// <summary>
    /// Block for os_profile_windows_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    public HashSet<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock>? OsProfileWindowsConfig
    {
        set => SetProperty("os_profile_windows_config", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public HashSet<AzurermVirtualMachineScaleSetPlanBlock>? Plan
    {
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock>? RollingUpgradePolicy
    {
        set => SetProperty("rolling_upgrade_policy", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetSkuBlock>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// Block for storage_profile_data_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock>? StorageProfileDataDisk
    {
        set => SetProperty("storage_profile_data_disk", value);
    }

    /// <summary>
    /// Block for storage_profile_image_reference.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfileImageReference block(s) allowed")]
    public HashSet<AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock>? StorageProfileImageReference
    {
        set => SetProperty("storage_profile_image_reference", value);
    }

    /// <summary>
    /// Block for storage_profile_os_disk.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageProfileOsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageProfileOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfileOsDisk block(s) allowed")]
    public HashSet<AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock>? StorageProfileOsDisk
    {
        set => SetProperty("storage_profile_os_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineScaleSetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
