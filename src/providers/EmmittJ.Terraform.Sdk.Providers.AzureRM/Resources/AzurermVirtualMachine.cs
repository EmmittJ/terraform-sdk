using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineAdditionalCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_capabilities";

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UltraSsdEnabled is required")]
    [TerraformArgument("ultra_ssd_enabled")]
    public required TerraformValue<bool> UltraSsdEnabled
    {
        get => new TerraformReference<bool>(this, "ultra_ssd_enabled");
        set => SetArgument("ultra_ssd_enabled", value);
    }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineBootDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_diagnostics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformArgument("storage_uri")]
    public required TerraformValue<string> StorageUri
    {
        get => new TerraformReference<string>(this, "storage_uri");
        set => SetArgument("storage_uri", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for os_profile in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineOsProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_profile";

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformArgument("admin_password")]
    public TerraformValue<string>? AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformArgument("admin_username")]
    public required TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerName is required")]
    [TerraformArgument("computer_name")]
    public required TerraformValue<string> ComputerName
    {
        get => new TerraformReference<string>(this, "computer_name");
        set => SetArgument("computer_name", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformArgument("custom_data")]
    public TerraformValue<string> CustomData
    {
        get => new TerraformReference<string>(this, "custom_data");
        set => SetArgument("custom_data", value);
    }

}

/// <summary>
/// Block type for os_profile_linux_config in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineOsProfileLinuxConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_profile_linux_config";

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisablePasswordAuthentication is required")]
    [TerraformArgument("disable_password_authentication")]
    public required TerraformValue<bool> DisablePasswordAuthentication
    {
        get => new TerraformReference<bool>(this, "disable_password_authentication");
        set => SetArgument("disable_password_authentication", value);
    }

}

/// <summary>
/// Block type for os_profile_secrets in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineOsProfileSecretsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_profile_secrets";

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    [TerraformArgument("source_vault_id")]
    public required TerraformValue<string> SourceVaultId
    {
        get => new TerraformReference<string>(this, "source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

}

/// <summary>
/// Block type for os_profile_windows_config in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineOsProfileWindowsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_profile_windows_config";

    /// <summary>
    /// The enable_automatic_upgrades attribute.
    /// </summary>
    [TerraformArgument("enable_automatic_upgrades")]
    public TerraformValue<bool>? EnableAutomaticUpgrades
    {
        get => new TerraformReference<bool>(this, "enable_automatic_upgrades");
        set => SetArgument("enable_automatic_upgrades", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformArgument("provision_vm_agent")]
    public TerraformValue<bool>? ProvisionVmAgent
    {
        get => new TerraformReference<bool>(this, "provision_vm_agent");
        set => SetArgument("provision_vm_agent", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformArgument("timezone")]
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachinePlanBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plan";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformArgument("product")]
    public required TerraformValue<string> Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformArgument("publisher")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

}

/// <summary>
/// Block type for storage_data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineStorageDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_data_disk";

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformArgument("caching")]
    public TerraformValue<string> Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformArgument("create_option")]
    public required TerraformValue<string> CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformArgument("disk_size_gb")]
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformArgument("lun")]
    public required TerraformValue<double> Lun
    {
        get => new TerraformReference<double>(this, "lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformArgument("managed_disk_id")]
    public TerraformValue<string> ManagedDiskId
    {
        get => new TerraformReference<string>(this, "managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformArgument("managed_disk_type")]
    public TerraformValue<string> ManagedDiskType
    {
        get => new TerraformReference<string>(this, "managed_disk_type");
        set => SetArgument("managed_disk_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    [TerraformArgument("vhd_uri")]
    public TerraformValue<string>? VhdUri
    {
        get => new TerraformReference<string>(this, "vhd_uri");
        set => SetArgument("vhd_uri", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformArgument("write_accelerator_enabled")]
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for storage_image_reference in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineStorageImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_image_reference";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [TerraformArgument("offer")]
    public TerraformValue<string>? Offer
    {
        get => new TerraformReference<string>(this, "offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [TerraformArgument("publisher")]
    public TerraformValue<string>? Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for storage_os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineStorageOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_os_disk";

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformArgument("caching")]
    public TerraformValue<string> Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformArgument("create_option")]
    public required TerraformValue<string> CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformArgument("disk_size_gb")]
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformArgument("image_uri")]
    public TerraformValue<string>? ImageUri
    {
        get => new TerraformReference<string>(this, "image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [TerraformArgument("managed_disk_id")]
    public TerraformValue<string> ManagedDiskId
    {
        get => new TerraformReference<string>(this, "managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    [TerraformArgument("managed_disk_type")]
    public TerraformValue<string> ManagedDiskType
    {
        get => new TerraformReference<string>(this, "managed_disk_type");
        set => SetArgument("managed_disk_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformArgument("os_type")]
    public TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    [TerraformArgument("vhd_uri")]
    public TerraformValue<string>? VhdUri
    {
        get => new TerraformReference<string>(this, "vhd_uri");
        set => SetArgument("vhd_uri", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformArgument("write_accelerator_enabled")]
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    [TerraformArgument("availability_set_id")]
    public TerraformValue<string> AvailabilitySetId
    {
        get => new TerraformReference<string>(this, "availability_set_id");
        set => SetArgument("availability_set_id", value);
    }

    /// <summary>
    /// The delete_data_disks_on_termination attribute.
    /// </summary>
    [TerraformArgument("delete_data_disks_on_termination")]
    public TerraformValue<bool>? DeleteDataDisksOnTermination
    {
        get => new TerraformReference<bool>(this, "delete_data_disks_on_termination");
        set => SetArgument("delete_data_disks_on_termination", value);
    }

    /// <summary>
    /// The delete_os_disk_on_termination attribute.
    /// </summary>
    [TerraformArgument("delete_os_disk_on_termination")]
    public TerraformValue<bool>? DeleteOsDiskOnTermination
    {
        get => new TerraformReference<bool>(this, "delete_os_disk_on_termination");
        set => SetArgument("delete_os_disk_on_termination", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformArgument("license_type")]
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    [TerraformArgument("network_interface_ids")]
    public TerraformList<string>? NetworkInterfaceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "network_interface_ids").ResolveNodes(ctx));
        set => SetArgument("network_interface_ids", value);
    }

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    [TerraformArgument("primary_network_interface_id")]
    public TerraformValue<string>? PrimaryNetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "primary_network_interface_id");
        set => SetArgument("primary_network_interface_id", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformArgument("proximity_placement_group_id")]
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformArgument("vm_size")]
    public required TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformList<string>? Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformArgument("additional_capabilities")]
    public TerraformList<AzurermVirtualMachineAdditionalCapabilitiesBlock> AdditionalCapabilities { get; set; } = new();

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformArgument("boot_diagnostics")]
    public TerraformList<AzurermVirtualMachineBootDiagnosticsBlock> BootDiagnostics { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermVirtualMachineIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    [TerraformArgument("os_profile")]
    public TerraformSet<AzurermVirtualMachineOsProfileBlock> OsProfile { get; set; } = new();

    /// <summary>
    /// Block for os_profile_linux_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    [TerraformArgument("os_profile_linux_config")]
    public TerraformSet<AzurermVirtualMachineOsProfileLinuxConfigBlock> OsProfileLinuxConfig { get; set; } = new();

    /// <summary>
    /// Block for os_profile_secrets.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("os_profile_secrets")]
    public TerraformList<AzurermVirtualMachineOsProfileSecretsBlock> OsProfileSecrets { get; set; } = new();

    /// <summary>
    /// Block for os_profile_windows_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    [TerraformArgument("os_profile_windows_config")]
    public TerraformSet<AzurermVirtualMachineOsProfileWindowsConfigBlock> OsProfileWindowsConfig { get; set; } = new();

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformArgument("plan")]
    public TerraformList<AzurermVirtualMachinePlanBlock> Plan { get; set; } = new();

    /// <summary>
    /// Block for storage_data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("storage_data_disk")]
    public TerraformList<AzurermVirtualMachineStorageDataDiskBlock> StorageDataDisk { get; set; } = new();

    /// <summary>
    /// Block for storage_image_reference.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    [TerraformArgument("storage_image_reference")]
    public TerraformSet<AzurermVirtualMachineStorageImageReferenceBlock> StorageImageReference { get; set; } = new();

    /// <summary>
    /// Block for storage_os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageOsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageOsDisk block(s) allowed")]
    [TerraformArgument("storage_os_disk")]
    public required TerraformList<AzurermVirtualMachineStorageOsDiskBlock> StorageOsDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualMachineTimeoutsBlock Timeouts { get; set; } = new();

}
