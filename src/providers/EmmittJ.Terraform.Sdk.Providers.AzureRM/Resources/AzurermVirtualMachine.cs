using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineAdditionalCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UltraSsdEnabled is required")]
    public required TerraformProperty<bool> UltraSsdEnabled
    {
        set => SetProperty("ultra_ssd_enabled", value);
    }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineBootDiagnosticsBlock : TerraformBlock
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
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformProperty<string> StorageUri
    {
        set => SetProperty("storage_uri", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineIdentityBlock : TerraformBlock
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
/// Block type for os_profile in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineOsProfileBlock : TerraformBlock
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
    /// The computer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerName is required")]
    public required TerraformProperty<string> ComputerName
    {
        set => SetProperty("computer_name", value);
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
public class AzurermVirtualMachineOsProfileLinuxConfigBlock : TerraformBlock
{
    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisablePasswordAuthentication is required")]
    public required TerraformProperty<bool> DisablePasswordAuthentication
    {
        set => SetProperty("disable_password_authentication", value);
    }

}

/// <summary>
/// Block type for os_profile_secrets in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineOsProfileSecretsBlock : TerraformBlock
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
public class AzurermVirtualMachineOsProfileWindowsConfigBlock : TerraformBlock
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

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        set => SetProperty("timezone", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachinePlanBlock : TerraformBlock
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
/// Block type for storage_data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineStorageDataDiskBlock : TerraformBlock
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
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskId
    {
        set => SetProperty("managed_disk_id", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    public TerraformProperty<string>? VhdUri
    {
        set => SetProperty("vhd_uri", value);
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
/// Block type for storage_image_reference in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineStorageImageReferenceBlock : TerraformBlock
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
/// Block type for storage_os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineStorageOsDiskBlock : TerraformBlock
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
    /// The image_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ImageUri
    {
        set => SetProperty("image_uri", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskId
    {
        set => SetProperty("managed_disk_id", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// The vhd_uri attribute.
    /// </summary>
    public TerraformProperty<string>? VhdUri
    {
        set => SetProperty("vhd_uri", value);
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualMachine : TerraformResource
{
    public AzurermVirtualMachine(string name) : base("azurerm_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("availability_set_id");
        SetOutput("delete_data_disks_on_termination");
        SetOutput("delete_os_disk_on_termination");
        SetOutput("id");
        SetOutput("license_type");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network_interface_ids");
        SetOutput("primary_network_interface_id");
        SetOutput("proximity_placement_group_id");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("vm_size");
        SetOutput("zones");
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
    /// The delete_data_disks_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool> DeleteDataDisksOnTermination
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_data_disks_on_termination");
        set => SetProperty("delete_data_disks_on_termination", value);
    }

    /// <summary>
    /// The delete_os_disk_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool> DeleteOsDiskOnTermination
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_os_disk_on_termination");
        set => SetProperty("delete_os_disk_on_termination", value);
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
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    public List<TerraformProperty<string>> NetworkInterfaceIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("network_interface_ids");
        set => SetProperty("network_interface_ids", value);
    }

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string> PrimaryNetworkInterfaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("primary_network_interface_id");
        set => SetProperty("primary_network_interface_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformProperty<string> VmSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vm_size");
        set => SetProperty("vm_size", value);
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
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public List<AzurermVirtualMachineAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        set => SetProperty("additional_capabilities", value);
    }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public List<AzurermVirtualMachineBootDiagnosticsBlock>? BootDiagnostics
    {
        set => SetProperty("boot_diagnostics", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermVirtualMachineIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public HashSet<AzurermVirtualMachineOsProfileBlock>? OsProfile
    {
        set => SetProperty("os_profile", value);
    }

    /// <summary>
    /// Block for os_profile_linux_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    public HashSet<AzurermVirtualMachineOsProfileLinuxConfigBlock>? OsProfileLinuxConfig
    {
        set => SetProperty("os_profile_linux_config", value);
    }

    /// <summary>
    /// Block for os_profile_secrets.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualMachineOsProfileSecretsBlock>? OsProfileSecrets
    {
        set => SetProperty("os_profile_secrets", value);
    }

    /// <summary>
    /// Block for os_profile_windows_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    public HashSet<AzurermVirtualMachineOsProfileWindowsConfigBlock>? OsProfileWindowsConfig
    {
        set => SetProperty("os_profile_windows_config", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermVirtualMachinePlanBlock>? Plan
    {
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// Block for storage_data_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualMachineStorageDataDiskBlock>? StorageDataDisk
    {
        set => SetProperty("storage_data_disk", value);
    }

    /// <summary>
    /// Block for storage_image_reference.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    public HashSet<AzurermVirtualMachineStorageImageReferenceBlock>? StorageImageReference
    {
        set => SetProperty("storage_image_reference", value);
    }

    /// <summary>
    /// Block for storage_os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageOsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageOsDisk block(s) allowed")]
    public List<AzurermVirtualMachineStorageOsDiskBlock>? StorageOsDisk
    {
        set => SetProperty("storage_os_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
