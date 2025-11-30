using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for additional_capabilities in AzurermVirtualMachine.
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
    public required TerraformValue<bool> UltraSsdEnabled
    {
        get => new TerraformReference<bool>(this, "ultra_ssd_enabled");
        set => SetArgument("ultra_ssd_enabled", value);
    }

}


/// <summary>
/// Block type for boot_diagnostics in AzurermVirtualMachine.
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
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformValue<string> StorageUri
    {
        get => new TerraformReference<string>(this, "storage_uri");
        set => SetArgument("storage_uri", value);
    }

}


/// <summary>
/// Block type for identity in AzurermVirtualMachine.
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
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for os_profile in AzurermVirtualMachine.
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
    public TerraformValue<string>? AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerName is required")]
    public required TerraformValue<string> ComputerName
    {
        get => new TerraformReference<string>(this, "computer_name");
        set => SetArgument("computer_name", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformValue<string> CustomData
    {
        get => new TerraformReference<string>(this, "custom_data");
        set => SetArgument("custom_data", value);
    }

}


/// <summary>
/// Block type for os_profile_linux_config in AzurermVirtualMachine.
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
    public required TerraformValue<bool> DisablePasswordAuthentication
    {
        get => new TerraformReference<bool>(this, "disable_password_authentication");
        set => SetArgument("disable_password_authentication", value);
    }

    /// <summary>
    /// SshKeys block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineOsProfileLinuxConfigBlockSshKeysBlock>? SshKeys
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineOsProfileLinuxConfigBlockSshKeysBlock>>("ssh_keys");
        set => SetArgument("ssh_keys", value);
    }

}

/// <summary>
/// Block type for ssh_keys in AzurermVirtualMachineOsProfileLinuxConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineOsProfileLinuxConfigBlockSshKeysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_keys";

    /// <summary>
    /// The key_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyData is required")]
    public required TerraformValue<string> KeyData
    {
        get => new TerraformReference<string>(this, "key_data");
        set => SetArgument("key_data", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for os_profile_secrets in AzurermVirtualMachine.
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
    public required TerraformValue<string> SourceVaultId
    {
        get => new TerraformReference<string>(this, "source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

    /// <summary>
    /// VaultCertificates block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineOsProfileSecretsBlockVaultCertificatesBlock>? VaultCertificates
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineOsProfileSecretsBlockVaultCertificatesBlock>>("vault_certificates");
        set => SetArgument("vault_certificates", value);
    }

}

/// <summary>
/// Block type for vault_certificates in AzurermVirtualMachineOsProfileSecretsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineOsProfileSecretsBlockVaultCertificatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vault_certificates";

    /// <summary>
    /// The certificate_store attribute.
    /// </summary>
    public TerraformValue<string>? CertificateStore
    {
        get => new TerraformReference<string>(this, "certificate_store");
        set => SetArgument("certificate_store", value);
    }

    /// <summary>
    /// The certificate_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateUrl is required")]
    public required TerraformValue<string> CertificateUrl
    {
        get => new TerraformReference<string>(this, "certificate_url");
        set => SetArgument("certificate_url", value);
    }

}


/// <summary>
/// Block type for os_profile_windows_config in AzurermVirtualMachine.
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
    public TerraformValue<bool>? EnableAutomaticUpgrades
    {
        get => new TerraformReference<bool>(this, "enable_automatic_upgrades");
        set => SetArgument("enable_automatic_upgrades", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformValue<bool>? ProvisionVmAgent
    {
        get => new TerraformReference<bool>(this, "provision_vm_agent");
        set => SetArgument("provision_vm_agent", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// AdditionalUnattendConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineOsProfileWindowsConfigBlockAdditionalUnattendConfigBlock>? AdditionalUnattendConfig
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineOsProfileWindowsConfigBlockAdditionalUnattendConfigBlock>>("additional_unattend_config");
        set => SetArgument("additional_unattend_config", value);
    }

    /// <summary>
    /// Winrm block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineOsProfileWindowsConfigBlockWinrmBlock>? Winrm
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineOsProfileWindowsConfigBlockWinrmBlock>>("winrm");
        set => SetArgument("winrm", value);
    }

}

/// <summary>
/// Block type for additional_unattend_config in AzurermVirtualMachineOsProfileWindowsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineOsProfileWindowsConfigBlockAdditionalUnattendConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_unattend_config";

    /// <summary>
    /// The component attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Component is required")]
    public required TerraformValue<string> Component
    {
        get => new TerraformReference<string>(this, "component");
        set => SetArgument("component", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The pass attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pass is required")]
    public required TerraformValue<string> Pass
    {
        get => new TerraformReference<string>(this, "pass");
        set => SetArgument("pass", value);
    }

    /// <summary>
    /// The setting_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SettingName is required")]
    public required TerraformValue<string> SettingName
    {
        get => new TerraformReference<string>(this, "setting_name");
        set => SetArgument("setting_name", value);
    }

}

/// <summary>
/// Block type for winrm in AzurermVirtualMachineOsProfileWindowsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineOsProfileWindowsConfigBlockWinrmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "winrm";

    /// <summary>
    /// The certificate_url attribute.
    /// </summary>
    public TerraformValue<string>? CertificateUrl
    {
        get => new TerraformReference<string>(this, "certificate_url");
        set => SetArgument("certificate_url", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for plan in AzurermVirtualMachine.
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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformValue<string> Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

}


/// <summary>
/// Block type for storage_data_disk in AzurermVirtualMachine.
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
    public TerraformValue<string> Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformValue<string> CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformValue<double> Lun
    {
        get => new TerraformReference<double>(this, "lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformValue<string> ManagedDiskId
    {
        get => new TerraformReference<string>(this, "managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    public TerraformValue<string> ManagedDiskType
    {
        get => new TerraformReference<string>(this, "managed_disk_type");
        set => SetArgument("managed_disk_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    public TerraformValue<string>? VhdUri
    {
        get => new TerraformReference<string>(this, "vhd_uri");
        set => SetArgument("vhd_uri", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

}


/// <summary>
/// Block type for storage_image_reference in AzurermVirtualMachine.
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
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    public TerraformValue<string>? Offer
    {
        get => new TerraformReference<string>(this, "offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformValue<string>? Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for storage_os_disk in AzurermVirtualMachine.
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
    public TerraformValue<string> Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformValue<string> CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    public TerraformValue<string>? ImageUri
    {
        get => new TerraformReference<string>(this, "image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformValue<string> ManagedDiskId
    {
        get => new TerraformReference<string>(this, "managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    public TerraformValue<string> ManagedDiskType
    {
        get => new TerraformReference<string>(this, "managed_disk_type");
        set => SetArgument("managed_disk_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    public TerraformValue<string>? VhdUri
    {
        get => new TerraformReference<string>(this, "vhd_uri");
        set => SetArgument("vhd_uri", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualMachine.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_virtual_machine Terraform resource.
/// Manages a azurerm_virtual_machine resource.
/// </summary>
public partial class AzurermVirtualMachine(string name) : TerraformResource("azurerm_virtual_machine", name)
{
    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilitySetId
    {
        get => new TerraformReference<string>(this, "availability_set_id");
        set => SetArgument("availability_set_id", value);
    }

    /// <summary>
    /// The delete_data_disks_on_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteDataDisksOnTermination
    {
        get => new TerraformReference<bool>(this, "delete_data_disks_on_termination");
        set => SetArgument("delete_data_disks_on_termination", value);
    }

    /// <summary>
    /// The delete_os_disk_on_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteOsDiskOnTermination
    {
        get => new TerraformReference<bool>(this, "delete_os_disk_on_termination");
        set => SetArgument("delete_os_disk_on_termination", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    public TerraformList<string>? NetworkInterfaceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "network_interface_ids").ResolveNodes(ctx));
        set => SetArgument("network_interface_ids", value);
    }

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryNetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "primary_network_interface_id");
        set => SetArgument("primary_network_interface_id", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string>? Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// AdditionalCapabilities block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public TerraformList<AzurermVirtualMachineAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineAdditionalCapabilitiesBlock>>("additional_capabilities");
        set => SetArgument("additional_capabilities", value);
    }

    /// <summary>
    /// BootDiagnostics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public TerraformList<AzurermVirtualMachineBootDiagnosticsBlock>? BootDiagnostics
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineBootDiagnosticsBlock>>("boot_diagnostics");
        set => SetArgument("boot_diagnostics", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermVirtualMachineIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// OsProfile block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public TerraformSet<AzurermVirtualMachineOsProfileBlock>? OsProfile
    {
        get => GetArgument<TerraformSet<AzurermVirtualMachineOsProfileBlock>>("os_profile");
        set => SetArgument("os_profile", value);
    }

    /// <summary>
    /// OsProfileLinuxConfig block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    public TerraformSet<AzurermVirtualMachineOsProfileLinuxConfigBlock>? OsProfileLinuxConfig
    {
        get => GetArgument<TerraformSet<AzurermVirtualMachineOsProfileLinuxConfigBlock>>("os_profile_linux_config");
        set => SetArgument("os_profile_linux_config", value);
    }

    /// <summary>
    /// OsProfileSecrets block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineOsProfileSecretsBlock>? OsProfileSecrets
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineOsProfileSecretsBlock>>("os_profile_secrets");
        set => SetArgument("os_profile_secrets", value);
    }

    /// <summary>
    /// OsProfileWindowsConfig block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    public TerraformSet<AzurermVirtualMachineOsProfileWindowsConfigBlock>? OsProfileWindowsConfig
    {
        get => GetArgument<TerraformSet<AzurermVirtualMachineOsProfileWindowsConfigBlock>>("os_profile_windows_config");
        set => SetArgument("os_profile_windows_config", value);
    }

    /// <summary>
    /// Plan block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public TerraformList<AzurermVirtualMachinePlanBlock>? Plan
    {
        get => GetArgument<TerraformList<AzurermVirtualMachinePlanBlock>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// StorageDataDisk block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineStorageDataDiskBlock>? StorageDataDisk
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineStorageDataDiskBlock>>("storage_data_disk");
        set => SetArgument("storage_data_disk", value);
    }

    /// <summary>
    /// StorageImageReference block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    public TerraformSet<AzurermVirtualMachineStorageImageReferenceBlock>? StorageImageReference
    {
        get => GetArgument<TerraformSet<AzurermVirtualMachineStorageImageReferenceBlock>>("storage_image_reference");
        set => SetArgument("storage_image_reference", value);
    }

    /// <summary>
    /// StorageOsDisk block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageOsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageOsDisk block(s) allowed")]
    public required TerraformList<AzurermVirtualMachineStorageOsDiskBlock> StorageOsDisk
    {
        get => GetRequiredArgument<TerraformList<AzurermVirtualMachineStorageOsDiskBlock>>("storage_os_disk");
        set => SetArgument("storage_os_disk", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualMachineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualMachineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
