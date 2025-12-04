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
        get => GetArgument<TerraformValue<bool>>("ultra_ssd_enabled");
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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformValue<string> StorageUri
    {
        get => GetArgument<TerraformValue<string>>("storage_uri");
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<string>>("admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformValue<string> AdminUsername
    {
        get => GetArgument<TerraformValue<string>>("admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerName is required")]
    public required TerraformValue<string> ComputerName
    {
        get => GetArgument<TerraformValue<string>>("computer_name");
        set => SetArgument("computer_name", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformValue<string>? CustomData
    {
        get => GetArgument<TerraformValue<string>>("custom_data");
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
        get => GetArgument<TerraformValue<bool>>("disable_password_authentication");
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
        get => GetArgument<TerraformValue<string>>("key_data");
        set => SetArgument("key_data", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
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
        get => GetArgument<TerraformValue<string>>("source_vault_id");
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
        get => GetArgument<TerraformValue<string>>("certificate_store");
        set => SetArgument("certificate_store", value);
    }

    /// <summary>
    /// The certificate_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateUrl is required")]
    public required TerraformValue<string> CertificateUrl
    {
        get => GetArgument<TerraformValue<string>>("certificate_url");
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
        get => GetArgument<TerraformValue<bool>>("enable_automatic_upgrades");
        set => SetArgument("enable_automatic_upgrades", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformValue<bool>? ProvisionVmAgent
    {
        get => GetArgument<TerraformValue<bool>>("provision_vm_agent");
        set => SetArgument("provision_vm_agent", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => GetArgument<TerraformValue<string>>("timezone");
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
        get => GetArgument<TerraformValue<string>>("component");
        set => SetArgument("component", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The pass attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pass is required")]
    public required TerraformValue<string> Pass
    {
        get => GetArgument<TerraformValue<string>>("pass");
        set => SetArgument("pass", value);
    }

    /// <summary>
    /// The setting_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SettingName is required")]
    public required TerraformValue<string> SettingName
    {
        get => GetArgument<TerraformValue<string>>("setting_name");
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
        get => GetArgument<TerraformValue<string>>("certificate_url");
        set => SetArgument("certificate_url", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformValue<string> Product
    {
        get => GetArgument<TerraformValue<string>>("product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetArgument<TerraformValue<string>>("publisher");
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
    public TerraformValue<string>? Caching
    {
        get => GetArgument<TerraformValue<string>>("caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformValue<string> CreateOption
    {
        get => GetArgument<TerraformValue<string>>("create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double>? DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformValue<double> Lun
    {
        get => GetArgument<TerraformValue<double>>("lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskId
    {
        get => GetArgument<TerraformValue<string>>("managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskType
    {
        get => GetArgument<TerraformValue<string>>("managed_disk_type");
        set => SetArgument("managed_disk_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    public TerraformValue<string>? VhdUri
    {
        get => GetArgument<TerraformValue<string>>("vhd_uri");
        set => SetArgument("vhd_uri", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => GetArgument<TerraformValue<bool>>("write_accelerator_enabled");
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
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    public TerraformValue<string>? Offer
    {
        get => GetArgument<TerraformValue<string>>("offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformValue<string>? Publisher
    {
        get => GetArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
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
    public TerraformValue<string>? Caching
    {
        get => GetArgument<TerraformValue<string>>("caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformValue<string> CreateOption
    {
        get => GetArgument<TerraformValue<string>>("create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double>? DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    public TerraformValue<string>? ImageUri
    {
        get => GetArgument<TerraformValue<string>>("image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskId
    {
        get => GetArgument<TerraformValue<string>>("managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The managed_disk_type attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskType
    {
        get => GetArgument<TerraformValue<string>>("managed_disk_type");
        set => SetArgument("managed_disk_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string>? OsType
    {
        get => GetArgument<TerraformValue<string>>("os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The vhd_uri attribute.
    /// </summary>
    public TerraformValue<string>? VhdUri
    {
        get => GetArgument<TerraformValue<string>>("vhd_uri");
        set => SetArgument("vhd_uri", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => GetArgument<TerraformValue<bool>>("write_accelerator_enabled");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
    public TerraformValue<string>? AvailabilitySetId
    {
        get => GetArgument<TerraformValue<string>>("availability_set_id");
        set => SetArgument("availability_set_id", value);
    }

    /// <summary>
    /// The delete_data_disks_on_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteDataDisksOnTermination
    {
        get => GetArgument<TerraformValue<bool>>("delete_data_disks_on_termination");
        set => SetArgument("delete_data_disks_on_termination", value);
    }

    /// <summary>
    /// The delete_os_disk_on_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteOsDiskOnTermination
    {
        get => GetArgument<TerraformValue<bool>>("delete_os_disk_on_termination");
        set => SetArgument("delete_os_disk_on_termination", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string>? LicenseType
    {
        get => GetArgument<TerraformValue<string>>("license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceIds is required")]
    public TerraformList<string>? NetworkInterfaceIds
    {
        get => GetArgument<TerraformList<string>>("network_interface_ids");
        set => SetArgument("network_interface_ids", value);
    }

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryNetworkInterfaceId
    {
        get => GetArgument<TerraformValue<string>>("primary_network_interface_id");
        set => SetArgument("primary_network_interface_id", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => GetArgument<TerraformValue<string>>("proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformValue<string> VmSize
    {
        get => GetArgument<TerraformValue<string>>("vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string>? Zones
    {
        get => GetArgument<TerraformList<string>>("zones");
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
