using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for additional_capabilities in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_capabilities";

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UltraSsdEnabled
    {
        get => new TerraformReference<bool>(this, "ultra_ssd_enabled");
        set => SetArgument("ultra_ssd_enabled", value);
    }

}


/// <summary>
/// Block type for automatic_instance_repair in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic_instance_repair";

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

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
    /// The grace_period attribute.
    /// </summary>
    public TerraformValue<string> GracePeriod
    {
        get => new TerraformReference<string>(this, "grace_period");
        set => SetArgument("grace_period", value);
    }

}


/// <summary>
/// Block type for boot_diagnostics in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_diagnostics";

    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountUri
    {
        get => new TerraformReference<string>(this, "storage_account_uri");
        set => SetArgument("storage_account_uri", value);
    }

}


/// <summary>
/// Block type for data_disk in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_disk";

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformValue<string> Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformValue<string>? CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
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
    public TerraformValue<double> Lun
    {
        get => new TerraformReference<double>(this, "lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_iops_read_write attribute.
    /// </summary>
    public TerraformValue<double> UltraSsdDiskIopsReadWrite
    {
        get => new TerraformReference<double>(this, "ultra_ssd_disk_iops_read_write");
        set => SetArgument("ultra_ssd_disk_iops_read_write", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_mbps_read_write attribute.
    /// </summary>
    public TerraformValue<double> UltraSsdDiskMbpsReadWrite
    {
        get => new TerraformReference<double>(this, "ultra_ssd_disk_mbps_read_write");
        set => SetArgument("ultra_ssd_disk_mbps_read_write", value);
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
/// Block type for extension in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetExtensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extension";

    /// <summary>
    /// The auto_upgrade_minor_version_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoUpgradeMinorVersionEnabled
    {
        get => new TerraformReference<bool>(this, "auto_upgrade_minor_version_enabled");
        set => SetArgument("auto_upgrade_minor_version_enabled", value);
    }

    /// <summary>
    /// The extensions_to_provision_after_vm_creation attribute.
    /// </summary>
    public TerraformList<string>? ExtensionsToProvisionAfterVmCreation
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "extensions_to_provision_after_vm_creation").ResolveNodes(ctx));
        set => SetArgument("extensions_to_provision_after_vm_creation", value);
    }

    /// <summary>
    /// The failure_suppression_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FailureSuppressionEnabled
    {
        get => new TerraformReference<bool>(this, "failure_suppression_enabled");
        set => SetArgument("failure_suppression_enabled", value);
    }

    /// <summary>
    /// The force_extension_execution_on_change attribute.
    /// </summary>
    public TerraformValue<string>? ForceExtensionExecutionOnChange
    {
        get => new TerraformReference<string>(this, "force_extension_execution_on_change");
        set => SetArgument("force_extension_execution_on_change", value);
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
    /// The protected_settings attribute.
    /// </summary>
    public TerraformValue<string>? ProtectedSettings
    {
        get => new TerraformReference<string>(this, "protected_settings");
        set => SetArgument("protected_settings", value);
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

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public TerraformValue<string>? Settings
    {
        get => new TerraformReference<string>(this, "settings");
        set => SetArgument("settings", value);
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

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    public required TerraformValue<string> TypeHandlerVersion
    {
        get => new TerraformReference<string>(this, "type_handler_version");
        set => SetArgument("type_handler_version", value);
    }

    /// <summary>
    /// ProtectedSettingsFromKeyVault block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtectedSettingsFromKeyVault block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetExtensionBlockProtectedSettingsFromKeyVaultBlock>? ProtectedSettingsFromKeyVault
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetExtensionBlockProtectedSettingsFromKeyVaultBlock>>("protected_settings_from_key_vault");
        set => SetArgument("protected_settings_from_key_vault", value);
    }

}

/// <summary>
/// Block type for protected_settings_from_key_vault in AzurermOrchestratedVirtualMachineScaleSetExtensionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetExtensionBlockProtectedSettingsFromKeyVaultBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protected_settings_from_key_vault";

    /// <summary>
    /// The secret_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretUrl is required")]
    public required TerraformValue<string> SecretUrl
    {
        get => new TerraformReference<string>(this, "secret_url");
        set => SetArgument("secret_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformValue<string> SourceVaultId
    {
        get => new TerraformReference<string>(this, "source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public required TerraformSet<string> IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
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
/// Block type for network_interface in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface";

    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    public TerraformValue<string>? AuxiliaryMode
    {
        get => new TerraformReference<string>(this, "auxiliary_mode");
        set => SetArgument("auxiliary_mode", value);
    }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    public TerraformValue<string>? AuxiliarySku
    {
        get => new TerraformReference<string>(this, "auxiliary_sku");
        set => SetArgument("auxiliary_sku", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The enable_accelerated_networking attribute.
    /// </summary>
    public TerraformValue<bool>? EnableAcceleratedNetworking
    {
        get => new TerraformReference<bool>(this, "enable_accelerated_networking");
        set => SetArgument("enable_accelerated_networking", value);
    }

    /// <summary>
    /// The enable_ip_forwarding attribute.
    /// </summary>
    public TerraformValue<bool>? EnableIpForwarding
    {
        get => new TerraformReference<bool>(this, "enable_ip_forwarding");
        set => SetArgument("enable_ip_forwarding", value);
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
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformValue<string>? NetworkSecurityGroupId
    {
        get => new TerraformReference<string>(this, "network_security_group_id");
        set => SetArgument("network_security_group_id", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// IpConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    public required TerraformList<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlock> IpConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlock>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

}

/// <summary>
/// Block type for ip_configuration in AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configuration";

    /// <summary>
    /// The application_gateway_backend_address_pool_ids attribute.
    /// </summary>
    public TerraformSet<string>? ApplicationGatewayBackendAddressPoolIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "application_gateway_backend_address_pool_ids").ResolveNodes(ctx));
        set => SetArgument("application_gateway_backend_address_pool_ids", value);
    }

    /// <summary>
    /// The application_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? ApplicationSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "application_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("application_security_group_ids", value);
    }

    /// <summary>
    /// The load_balancer_backend_address_pool_ids attribute.
    /// </summary>
    public TerraformSet<string>? LoadBalancerBackendAddressPoolIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "load_balancer_backend_address_pool_ids").ResolveNodes(ctx));
        set => SetArgument("load_balancer_backend_address_pool_ids", value);
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
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// PublicIpAddress block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlock>? PublicIpAddress
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlock>>("public_ip_address");
        set => SetArgument("public_ip_address", value);
    }

}

/// <summary>
/// Block type for public_ip_address in AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_ip_address";

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    public TerraformValue<string>? DomainNameLabel
    {
        get => new TerraformReference<string>(this, "domain_name_label");
        set => SetArgument("domain_name_label", value);
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> IdleTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
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
    /// The public_ip_prefix_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpPrefixId
    {
        get => new TerraformReference<string>(this, "public_ip_prefix_id");
        set => SetArgument("public_ip_prefix_id", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string>? SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// IpTag block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlockIpTagBlock>? IpTag
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlockIpTagBlock>>("ip_tag");
        set => SetArgument("ip_tag", value);
    }

}

/// <summary>
/// Block type for ip_tag in AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlockIpTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_tag";

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tag is required")]
    public required TerraformValue<string> Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
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
/// Block type for os_disk in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_disk";

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformValue<string> Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
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
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

    /// <summary>
    /// DiffDiskSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiffDiskSettings block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsDiskBlockDiffDiskSettingsBlock>? DiffDiskSettings
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsDiskBlockDiffDiskSettingsBlock>>("diff_disk_settings");
        set => SetArgument("diff_disk_settings", value);
    }

}

/// <summary>
/// Block type for diff_disk_settings in AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsDiskBlockDiffDiskSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "diff_disk_settings";

    /// <summary>
    /// The option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Option is required")]
    public required TerraformValue<string> Option
    {
        get => new TerraformReference<string>(this, "option");
        set => SetArgument("option", value);
    }

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformValue<string>? Placement
    {
        get => new TerraformReference<string>(this, "placement");
        set => SetArgument("placement", value);
    }

}


/// <summary>
/// Block type for os_profile in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_profile";

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformValue<string>? CustomData
    {
        get => new TerraformReference<string>(this, "custom_data");
        set => SetArgument("custom_data", value);
    }

    /// <summary>
    /// LinuxConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxConfiguration block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlock>? LinuxConfiguration
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlock>>("linux_configuration");
        set => SetArgument("linux_configuration", value);
    }

    /// <summary>
    /// WindowsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsConfiguration block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlock>? WindowsConfiguration
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlock>>("windows_configuration");
        set => SetArgument("windows_configuration", value);
    }

}

/// <summary>
/// Block type for linux_configuration in AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux_configuration";

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
    /// The computer_name_prefix attribute.
    /// </summary>
    public TerraformValue<string> ComputerNamePrefix
    {
        get => new TerraformReference<string>(this, "computer_name_prefix");
        set => SetArgument("computer_name_prefix", value);
    }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    public TerraformValue<bool>? DisablePasswordAuthentication
    {
        get => new TerraformReference<bool>(this, "disable_password_authentication");
        set => SetArgument("disable_password_authentication", value);
    }

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    public TerraformValue<string>? PatchAssessmentMode
    {
        get => new TerraformReference<string>(this, "patch_assessment_mode");
        set => SetArgument("patch_assessment_mode", value);
    }

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    public TerraformValue<string>? PatchMode
    {
        get => new TerraformReference<string>(this, "patch_mode");
        set => SetArgument("patch_mode", value);
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
    /// AdminSshKey block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlockAdminSshKeyBlock>? AdminSshKey
    {
        get => GetArgument<TerraformSet<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlockAdminSshKeyBlock>>("admin_ssh_key");
        set => SetArgument("admin_ssh_key", value);
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlockSecretBlock>? Secret
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlockSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

}

/// <summary>
/// Block type for admin_ssh_key in AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlockAdminSshKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_ssh_key";

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    public required TerraformValue<string> PublicKey
    {
        get => new TerraformReference<string>(this, "public_key");
        set => SetArgument("public_key", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for secret in AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlockSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Certificate block(s) required")]
    public required TerraformSet<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlockSecretBlockCertificateBlock> Certificate
    {
        get => GetRequiredArgument<TerraformSet<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlockSecretBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

}

/// <summary>
/// Block type for certificate in AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlockSecretBlock.
/// Nesting mode: set
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockLinuxConfigurationBlockSecretBlockCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for windows_configuration in AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_configuration";

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    public required TerraformValue<string> AdminPassword
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
    /// The computer_name_prefix attribute.
    /// </summary>
    public TerraformValue<string> ComputerNamePrefix
    {
        get => new TerraformReference<string>(this, "computer_name_prefix");
        set => SetArgument("computer_name_prefix", value);
    }

    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    public TerraformValue<bool>? EnableAutomaticUpdates
    {
        get => new TerraformReference<bool>(this, "enable_automatic_updates");
        set => SetArgument("enable_automatic_updates", value);
    }

    /// <summary>
    /// The hotpatching_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HotpatchingEnabled
    {
        get => new TerraformReference<bool>(this, "hotpatching_enabled");
        set => SetArgument("hotpatching_enabled", value);
    }

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    public TerraformValue<string>? PatchAssessmentMode
    {
        get => new TerraformReference<string>(this, "patch_assessment_mode");
        set => SetArgument("patch_assessment_mode", value);
    }

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    public TerraformValue<string>? PatchMode
    {
        get => new TerraformReference<string>(this, "patch_mode");
        set => SetArgument("patch_mode", value);
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
    /// AdditionalUnattendContent block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockAdditionalUnattendContentBlock>? AdditionalUnattendContent
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockAdditionalUnattendContentBlock>>("additional_unattend_content");
        set => SetArgument("additional_unattend_content", value);
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockSecretBlock>? Secret
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// WinrmListener block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockWinrmListenerBlock>? WinrmListener
    {
        get => GetArgument<TerraformSet<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockWinrmListenerBlock>>("winrm_listener");
        set => SetArgument("winrm_listener", value);
    }

}

/// <summary>
/// Block type for additional_unattend_content in AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockAdditionalUnattendContentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_unattend_content";

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
    /// The setting attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Setting is required")]
    public required TerraformValue<string> Setting
    {
        get => new TerraformReference<string>(this, "setting");
        set => SetArgument("setting", value);
    }

}

/// <summary>
/// Block type for secret in AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Certificate block(s) required")]
    public required TerraformSet<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockSecretBlockCertificateBlock> Certificate
    {
        get => GetRequiredArgument<TerraformSet<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockSecretBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

}

/// <summary>
/// Block type for certificate in AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockSecretBlock.
/// Nesting mode: set
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockSecretBlockCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The store attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Store is required")]
    public required TerraformValue<string> Store
    {
        get => new TerraformReference<string>(this, "store");
        set => SetArgument("store", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for winrm_listener in AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlockWindowsConfigurationBlockWinrmListenerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "winrm_listener";

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
/// Block type for plan in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetPlanBlock : TerraformBlock
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
/// Block type for priority_mix in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "priority_mix";

    /// <summary>
    /// The base_regular_count attribute.
    /// </summary>
    public TerraformValue<double>? BaseRegularCount
    {
        get => new TerraformReference<double>(this, "base_regular_count");
        set => SetArgument("base_regular_count", value);
    }

    /// <summary>
    /// The regular_percentage_above_base attribute.
    /// </summary>
    public TerraformValue<double>? RegularPercentageAboveBase
    {
        get => new TerraformReference<double>(this, "regular_percentage_above_base");
        set => SetArgument("regular_percentage_above_base", value);
    }

}


/// <summary>
/// Block type for rolling_upgrade_policy in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rolling_upgrade_policy";

    /// <summary>
    /// The cross_zone_upgrades_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CrossZoneUpgradesEnabled
    {
        get => new TerraformReference<bool>(this, "cross_zone_upgrades_enabled");
        set => SetArgument("cross_zone_upgrades_enabled", value);
    }

    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxBatchInstancePercent is required")]
    public required TerraformValue<double> MaxBatchInstancePercent
    {
        get => new TerraformReference<double>(this, "max_batch_instance_percent");
        set => SetArgument("max_batch_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyInstancePercent is required")]
    public required TerraformValue<double> MaxUnhealthyInstancePercent
    {
        get => new TerraformReference<double>(this, "max_unhealthy_instance_percent");
        set => SetArgument("max_unhealthy_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyUpgradedInstancePercent is required")]
    public required TerraformValue<double> MaxUnhealthyUpgradedInstancePercent
    {
        get => new TerraformReference<double>(this, "max_unhealthy_upgraded_instance_percent");
        set => SetArgument("max_unhealthy_upgraded_instance_percent", value);
    }

    /// <summary>
    /// The maximum_surge_instances_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MaximumSurgeInstancesEnabled
    {
        get => new TerraformReference<bool>(this, "maximum_surge_instances_enabled");
        set => SetArgument("maximum_surge_instances_enabled", value);
    }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PauseTimeBetweenBatches is required")]
    public required TerraformValue<string> PauseTimeBetweenBatches
    {
        get => new TerraformReference<string>(this, "pause_time_between_batches");
        set => SetArgument("pause_time_between_batches", value);
    }

    /// <summary>
    /// The prioritize_unhealthy_instances_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrioritizeUnhealthyInstancesEnabled
    {
        get => new TerraformReference<bool>(this, "prioritize_unhealthy_instances_enabled");
        set => SetArgument("prioritize_unhealthy_instances_enabled", value);
    }

}


/// <summary>
/// Block type for sku_profile in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku_profile";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    public required TerraformValue<string> AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

    /// <summary>
    /// The vm_sizes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSizes is required")]
    public required TerraformSet<string> VmSizes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vm_sizes").ResolveNodes(ctx));
        set => SetArgument("vm_sizes", value);
    }

}


/// <summary>
/// Block type for source_image_reference in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_image_reference";

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformValue<string> Offer
    {
        get => new TerraformReference<string>(this, "offer");
        set => SetArgument("offer", value);
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

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for termination_notification in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "termination_notification";

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
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => new TerraformReference<string>(this, "timeout");
        set => SetArgument("timeout", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermOrchestratedVirtualMachineScaleSet.
/// Nesting mode: single
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_orchestrated_virtual_machine_scale_set Terraform resource.
/// Manages a azurerm_orchestrated_virtual_machine_scale_set resource.
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSet(string name) : TerraformResource("azurerm_orchestrated_virtual_machine_scale_set", name)
{
    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationGroupId
    {
        get => new TerraformReference<string>(this, "capacity_reservation_group_id");
        set => SetArgument("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionAtHostEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_at_host_enabled");
        set => SetArgument("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformValue<string>? EvictionPolicy
    {
        get => new TerraformReference<string>(this, "eviction_policy");
        set => SetArgument("eviction_policy", value);
    }

    /// <summary>
    /// The extension_operations_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExtensionOperationsEnabled
    {
        get => new TerraformReference<bool>(this, "extension_operations_enabled");
        set => SetArgument("extension_operations_enabled", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public TerraformValue<string>? ExtensionsTimeBudget
    {
        get => new TerraformReference<string>(this, "extensions_time_budget");
        set => SetArgument("extensions_time_budget", value);
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
    /// The instances attribute.
    /// </summary>
    public TerraformValue<double> Instances
    {
        get => new TerraformReference<double>(this, "instances");
        set => SetArgument("instances", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string>? LicenseType
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
    /// The max_bid_price attribute.
    /// </summary>
    public TerraformValue<double>? MaxBidPrice
    {
        get => new TerraformReference<double>(this, "max_bid_price");
        set => SetArgument("max_bid_price", value);
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
    /// The network_api_version attribute.
    /// </summary>
    public TerraformValue<string>? NetworkApiVersion
    {
        get => new TerraformReference<string>(this, "network_api_version");
        set => SetArgument("network_api_version", value);
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformFaultDomainCount is required")]
    public required TerraformValue<double> PlatformFaultDomainCount
    {
        get => new TerraformReference<double>(this, "platform_fault_domain_count");
        set => SetArgument("platform_fault_domain_count", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<string>? Priority
    {
        get => new TerraformReference<string>(this, "priority");
        set => SetArgument("priority", value);
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
    /// The single_placement_group attribute.
    /// </summary>
    public TerraformValue<bool> SinglePlacementGroup
    {
        get => new TerraformReference<bool>(this, "single_placement_group");
        set => SetArgument("single_placement_group", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string>? SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceImageId
    {
        get => new TerraformReference<string>(this, "source_image_id");
        set => SetArgument("source_image_id", value);
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
    /// The upgrade_mode attribute.
    /// </summary>
    public TerraformValue<string>? UpgradeMode
    {
        get => new TerraformReference<string>(this, "upgrade_mode");
        set => SetArgument("upgrade_mode", value);
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformValue<string>? UserDataBase64
    {
        get => new TerraformReference<string>(this, "user_data_base64");
        set => SetArgument("user_data_base64", value);
    }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneBalance
    {
        get => new TerraformReference<bool>(this, "zone_balance");
        set => SetArgument("zone_balance", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformValue<string> UniqueId
    {
        get => new TerraformReference<string>(this, "unique_id");
    }

    /// <summary>
    /// AdditionalCapabilities block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock>>("additional_capabilities");
        set => SetArgument("additional_capabilities", value);
    }

    /// <summary>
    /// AutomaticInstanceRepair block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock>? AutomaticInstanceRepair
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock>>("automatic_instance_repair");
        set => SetArgument("automatic_instance_repair", value);
    }

    /// <summary>
    /// BootDiagnostics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock>? BootDiagnostics
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock>>("boot_diagnostics");
        set => SetArgument("boot_diagnostics", value);
    }

    /// <summary>
    /// DataDisk block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock>? DataDisk
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock>>("data_disk");
        set => SetArgument("data_disk", value);
    }

    /// <summary>
    /// Extension block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermOrchestratedVirtualMachineScaleSetExtensionBlock>? Extension
    {
        get => GetArgument<TerraformSet<AzurermOrchestratedVirtualMachineScaleSetExtensionBlock>>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// NetworkInterface block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock>>("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// OsDisk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock>? OsDisk
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock>>("os_disk");
        set => SetArgument("os_disk", value);
    }

    /// <summary>
    /// OsProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock>? OsProfile
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock>>("os_profile");
        set => SetArgument("os_profile", value);
    }

    /// <summary>
    /// Plan block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetPlanBlock>? Plan
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetPlanBlock>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// PriorityMix block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PriorityMix block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock>? PriorityMix
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock>>("priority_mix");
        set => SetArgument("priority_mix", value);
    }

    /// <summary>
    /// RollingUpgradePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock>? RollingUpgradePolicy
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock>>("rolling_upgrade_policy");
        set => SetArgument("rolling_upgrade_policy", value);
    }

    /// <summary>
    /// SkuProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SkuProfile block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock>? SkuProfile
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock>>("sku_profile");
        set => SetArgument("sku_profile", value);
    }

    /// <summary>
    /// SourceImageReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock>? SourceImageReference
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock>>("source_image_reference");
        set => SetArgument("source_image_reference", value);
    }

    /// <summary>
    /// TerminationNotification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock>? TerminationNotification
    {
        get => GetArgument<TerraformList<AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock>>("termination_notification");
        set => SetArgument("termination_notification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
