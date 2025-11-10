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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformProperty<string> StorageUri
    {
        get => GetProperty<TerraformProperty<string>>("storage_uri");
        set => WithProperty("storage_uri", value);
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
        get => GetProperty<TerraformProperty<bool>>("auto_upgrade_minor_version");
        set => WithProperty("auto_upgrade_minor_version", value);
    }

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
    /// The protected_settings attribute.
    /// </summary>
    public TerraformProperty<string>? ProtectedSettings
    {
        get => GetProperty<TerraformProperty<string>>("protected_settings");
        set => WithProperty("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ProvisionAfterExtensions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("provision_after_extensions");
        set => WithProperty("provision_after_extensions", value);
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
    /// The settings attribute.
    /// </summary>
    public TerraformProperty<string>? Settings
    {
        get => GetProperty<TerraformProperty<string>>("settings");
        set => WithProperty("settings", value);
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

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    public required TerraformProperty<string> TypeHandlerVersion
    {
        get => GetProperty<TerraformProperty<string>>("type_handler_version");
        set => WithProperty("type_handler_version", value);
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
        get => GetProperty<TerraformProperty<bool>>("accelerated_networking");
        set => WithProperty("accelerated_networking", value);
    }

    /// <summary>
    /// The ip_forwarding attribute.
    /// </summary>
    public TerraformProperty<bool>? IpForwarding
    {
        get => GetProperty<TerraformProperty<bool>>("ip_forwarding");
        set => WithProperty("ip_forwarding", value);
    }

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
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkSecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("network_security_group_id");
        set => WithProperty("network_security_group_id", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    public required TerraformProperty<bool> Primary
    {
        get => GetProperty<TerraformProperty<bool>>("primary");
        set => WithProperty("primary", value);
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
        get => GetProperty<TerraformProperty<string>>("admin_password");
        set => WithProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformProperty<string> AdminUsername
    {
        get => GetProperty<TerraformProperty<string>>("admin_username");
        set => WithProperty("admin_username", value);
    }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerNamePrefix is required")]
    public required TerraformProperty<string> ComputerNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("computer_name_prefix");
        set => WithProperty("computer_name_prefix", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformProperty<string>? CustomData
    {
        get => GetProperty<TerraformProperty<string>>("custom_data");
        set => WithProperty("custom_data", value);
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
        get => GetProperty<TerraformProperty<bool>>("disable_password_authentication");
        set => WithProperty("disable_password_authentication", value);
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
        get => GetProperty<TerraformProperty<string>>("source_vault_id");
        set => WithProperty("source_vault_id", value);
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
        get => GetProperty<TerraformProperty<bool>>("enable_automatic_upgrades");
        set => WithProperty("enable_automatic_upgrades", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformProperty<bool>? ProvisionVmAgent
    {
        get => GetProperty<TerraformProperty<bool>>("provision_vm_agent");
        set => WithProperty("provision_vm_agent", value);
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
        get => GetProperty<TerraformProperty<double>>("max_batch_instance_percent");
        set => WithProperty("max_batch_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnhealthyInstancePercent
    {
        get => GetProperty<TerraformProperty<double>>("max_unhealthy_instance_percent");
        set => WithProperty("max_unhealthy_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUnhealthyUpgradedInstancePercent
    {
        get => GetProperty<TerraformProperty<double>>("max_unhealthy_upgraded_instance_percent");
        set => WithProperty("max_unhealthy_upgraded_instance_percent", value);
    }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    public TerraformProperty<string>? PauseTimeBetweenBatches
    {
        get => GetProperty<TerraformProperty<string>>("pause_time_between_batches");
        set => WithProperty("pause_time_between_batches", value);
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
        get => GetProperty<TerraformProperty<double>>("capacity");
        set => WithProperty("capacity", value);
    }

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
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => WithProperty("tier", value);
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
        get => GetProperty<TerraformProperty<string>>("caching");
        set => WithProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformProperty<string> CreateOption
    {
        get => GetProperty<TerraformProperty<string>>("create_option");
        set => WithProperty("create_option", value);
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
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformProperty<double> Lun
    {
        get => GetProperty<TerraformProperty<double>>("lun");
        set => WithProperty("lun", value);
    }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskType
    {
        get => GetProperty<TerraformProperty<string>>("managed_disk_type");
        set => WithProperty("managed_disk_type", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    public TerraformProperty<string>? Offer
    {
        get => GetProperty<TerraformProperty<string>>("offer");
        set => WithProperty("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformProperty<string>? Publisher
    {
        get => GetProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => WithProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
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
        get => GetProperty<TerraformProperty<string>>("caching");
        set => WithProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformProperty<string> CreateOption
    {
        get => GetProperty<TerraformProperty<string>>("create_option");
        set => WithProperty("create_option", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformProperty<string>? Image
    {
        get => GetProperty<TerraformProperty<string>>("image");
        set => WithProperty("image", value);
    }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskType
    {
        get => GetProperty<TerraformProperty<string>>("managed_disk_type");
        set => WithProperty("managed_disk_type", value);
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
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsType
    {
        get => GetProperty<TerraformProperty<string>>("os_type");
        set => WithProperty("os_type", value);
    }

    /// <summary>
    /// The vhd_containers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VhdContainers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vhd_containers");
        set => WithProperty("vhd_containers", value);
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
/// Manages a azurerm_virtual_machine_scale_set resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermVirtualMachineScaleSet : TerraformResource
{
    public AzurermVirtualMachineScaleSet(string name) : base("azurerm_virtual_machine_scale_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automatic_os_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticOsUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_os_upgrade");
        set => this.WithProperty("automatic_os_upgrade", value);
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
    /// The health_probe_id attribute.
    /// </summary>
    public TerraformProperty<string>? HealthProbeId
    {
        get => GetProperty<TerraformProperty<string>>("health_probe_id");
        set => this.WithProperty("health_probe_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The overprovision attribute.
    /// </summary>
    public TerraformProperty<bool>? Overprovision
    {
        get => GetProperty<TerraformProperty<bool>>("overprovision");
        set => this.WithProperty("overprovision", value);
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
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("proximity_placement_group_id");
        set => this.WithProperty("proximity_placement_group_id", value);
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
    /// The single_placement_group attribute.
    /// </summary>
    public TerraformProperty<bool>? SinglePlacementGroup
    {
        get => GetProperty<TerraformProperty<bool>>("single_placement_group");
        set => this.WithProperty("single_placement_group", value);
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
    /// The upgrade_policy_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradePolicyMode is required")]
    public required TerraformProperty<string> UpgradePolicyMode
    {
        get => GetProperty<TerraformProperty<string>>("upgrade_policy_mode");
        set => this.WithProperty("upgrade_policy_mode", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Zones
    {
        get => GetProperty<List<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetBootDiagnosticsBlock>? BootDiagnostics
    {
        get => GetProperty<List<AzurermVirtualMachineScaleSetBootDiagnosticsBlock>>("boot_diagnostics");
        set => this.WithProperty("boot_diagnostics", value);
    }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVirtualMachineScaleSetExtensionBlock>? Extension
    {
        get => GetProperty<HashSet<AzurermVirtualMachineScaleSetExtensionBlock>>("extension");
        set => this.WithProperty("extension", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermVirtualMachineScaleSetIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    public HashSet<AzurermVirtualMachineScaleSetNetworkProfileBlock>? NetworkProfile
    {
        get => GetProperty<HashSet<AzurermVirtualMachineScaleSetNetworkProfileBlock>>("network_profile");
        set => this.WithProperty("network_profile", value);
    }

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetOsProfileBlock>? OsProfile
    {
        get => GetProperty<List<AzurermVirtualMachineScaleSetOsProfileBlock>>("os_profile");
        set => this.WithProperty("os_profile", value);
    }

    /// <summary>
    /// Block for os_profile_linux_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    public HashSet<AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock>? OsProfileLinuxConfig
    {
        get => GetProperty<HashSet<AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock>>("os_profile_linux_config");
        set => this.WithProperty("os_profile_linux_config", value);
    }

    /// <summary>
    /// Block for os_profile_secrets.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVirtualMachineScaleSetOsProfileSecretsBlock>? OsProfileSecrets
    {
        get => GetProperty<HashSet<AzurermVirtualMachineScaleSetOsProfileSecretsBlock>>("os_profile_secrets");
        set => this.WithProperty("os_profile_secrets", value);
    }

    /// <summary>
    /// Block for os_profile_windows_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    public HashSet<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock>? OsProfileWindowsConfig
    {
        get => GetProperty<HashSet<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock>>("os_profile_windows_config");
        set => this.WithProperty("os_profile_windows_config", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public HashSet<AzurermVirtualMachineScaleSetPlanBlock>? Plan
    {
        get => GetProperty<HashSet<AzurermVirtualMachineScaleSetPlanBlock>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock>? RollingUpgradePolicy
    {
        get => GetProperty<List<AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock>>("rolling_upgrade_policy");
        set => this.WithProperty("rolling_upgrade_policy", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetSkuBlock>? Sku
    {
        get => GetProperty<List<AzurermVirtualMachineScaleSetSkuBlock>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// Block for storage_profile_data_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock>? StorageProfileDataDisk
    {
        get => GetProperty<List<AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock>>("storage_profile_data_disk");
        set => this.WithProperty("storage_profile_data_disk", value);
    }

    /// <summary>
    /// Block for storage_profile_image_reference.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfileImageReference block(s) allowed")]
    public HashSet<AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock>? StorageProfileImageReference
    {
        get => GetProperty<HashSet<AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock>>("storage_profile_image_reference");
        set => this.WithProperty("storage_profile_image_reference", value);
    }

    /// <summary>
    /// Block for storage_profile_os_disk.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageProfileOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfileOsDisk block(s) allowed")]
    public HashSet<AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock>? StorageProfileOsDisk
    {
        get => GetProperty<HashSet<AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock>>("storage_profile_os_disk");
        set => this.WithProperty("storage_profile_os_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineScaleSetTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualMachineScaleSetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
