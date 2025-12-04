using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for additional_capabilities in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("ultra_ssd_enabled");
        set => SetArgument("ultra_ssd_enabled", value);
    }

}


/// <summary>
/// Block type for admin_ssh_key in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("public_key");
        set => SetArgument("public_key", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for automatic_instance_repair in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("action") ?? AsReference("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The grace_period attribute.
    /// </summary>
    public TerraformValue<string> GracePeriod
    {
        get => GetArgument<TerraformValue<string>>("grace_period") ?? AsReference("grace_period");
        set => SetArgument("grace_period", value);
    }

}


/// <summary>
/// Block type for automatic_os_upgrade_policy in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic_os_upgrade_policy";

    /// <summary>
    /// The disable_automatic_rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableAutomaticRollback is required")]
    public required TerraformValue<bool> DisableAutomaticRollback
    {
        get => GetRequiredArgument<TerraformValue<bool>>("disable_automatic_rollback");
        set => SetArgument("disable_automatic_rollback", value);
    }

    /// <summary>
    /// The enable_automatic_os_upgrade attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableAutomaticOsUpgrade is required")]
    public required TerraformValue<bool> EnableAutomaticOsUpgrade
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable_automatic_os_upgrade");
        set => SetArgument("enable_automatic_os_upgrade", value);
    }

}


/// <summary>
/// Block type for boot_diagnostics in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("storage_account_uri");
        set => SetArgument("storage_account_uri", value);
    }

}


/// <summary>
/// Block type for data_disk in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetDataDiskBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformValue<string>? CreateOption
    {
        get => GetArgument<TerraformValue<string>>("create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    public required TerraformValue<double> DiskSizeGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformValue<double> Lun
    {
        get => GetRequiredArgument<TerraformValue<double>>("lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformValue<string> StorageAccountType
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_iops_read_write attribute.
    /// </summary>
    public TerraformValue<double> UltraSsdDiskIopsReadWrite
    {
        get => GetArgument<TerraformValue<double>>("ultra_ssd_disk_iops_read_write") ?? AsReference("ultra_ssd_disk_iops_read_write");
        set => SetArgument("ultra_ssd_disk_iops_read_write", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_mbps_read_write attribute.
    /// </summary>
    public TerraformValue<double> UltraSsdDiskMbpsReadWrite
    {
        get => GetArgument<TerraformValue<double>>("ultra_ssd_disk_mbps_read_write") ?? AsReference("ultra_ssd_disk_mbps_read_write");
        set => SetArgument("ultra_ssd_disk_mbps_read_write", value);
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
/// Block type for extension in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetExtensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extension";

    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    public TerraformValue<bool>? AutoUpgradeMinorVersion
    {
        get => GetArgument<TerraformValue<bool>>("auto_upgrade_minor_version");
        set => SetArgument("auto_upgrade_minor_version", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticUpgradeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("automatic_upgrade_enabled");
        set => SetArgument("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformValue<string>? ForceUpdateTag
    {
        get => GetArgument<TerraformValue<string>>("force_update_tag");
        set => SetArgument("force_update_tag", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformValue<string>? ProtectedSettings
    {
        get => GetArgument<TerraformValue<string>>("protected_settings");
        set => SetArgument("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public TerraformList<string>? ProvisionAfterExtensions
    {
        get => GetArgument<TerraformList<string>>("provision_after_extensions");
        set => SetArgument("provision_after_extensions", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetRequiredArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public TerraformValue<string>? Settings
    {
        get => GetArgument<TerraformValue<string>>("settings");
        set => SetArgument("settings", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    public required TerraformValue<string> TypeHandlerVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("type_handler_version");
        set => SetArgument("type_handler_version", value);
    }

    /// <summary>
    /// ProtectedSettingsFromKeyVault block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtectedSettingsFromKeyVault block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetExtensionBlockProtectedSettingsFromKeyVaultBlock>? ProtectedSettingsFromKeyVault
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetExtensionBlockProtectedSettingsFromKeyVaultBlock>>("protected_settings_from_key_vault");
        set => SetArgument("protected_settings_from_key_vault", value);
    }

}

/// <summary>
/// Block type for protected_settings_from_key_vault in AzurermLinuxVirtualMachineScaleSetExtensionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetExtensionBlockProtectedSettingsFromKeyVaultBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("secret_url");
        set => SetArgument("secret_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformValue<string> SourceVaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

}


/// <summary>
/// Block type for gallery_application in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gallery_application";

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationBlobUri
    {
        get => GetArgument<TerraformValue<string>>("configuration_blob_uri");
        set => SetArgument("configuration_blob_uri", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformValue<double>? Order
    {
        get => GetArgument<TerraformValue<double>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    public required TerraformValue<string> VersionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("version_id");
        set => SetArgument("version_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetIdentityBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for network_interface in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("auxiliary_mode");
        set => SetArgument("auxiliary_mode", value);
    }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    public TerraformValue<string>? AuxiliarySku
    {
        get => GetArgument<TerraformValue<string>>("auxiliary_sku");
        set => SetArgument("auxiliary_sku", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string>? DnsServers
    {
        get => GetArgument<TerraformList<string>>("dns_servers");
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The enable_accelerated_networking attribute.
    /// </summary>
    public TerraformValue<bool>? EnableAcceleratedNetworking
    {
        get => GetArgument<TerraformValue<bool>>("enable_accelerated_networking");
        set => SetArgument("enable_accelerated_networking", value);
    }

    /// <summary>
    /// The enable_ip_forwarding attribute.
    /// </summary>
    public TerraformValue<bool>? EnableIpForwarding
    {
        get => GetArgument<TerraformValue<bool>>("enable_ip_forwarding");
        set => SetArgument("enable_ip_forwarding", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformValue<string>? NetworkSecurityGroupId
    {
        get => GetArgument<TerraformValue<string>>("network_security_group_id");
        set => SetArgument("network_security_group_id", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => GetArgument<TerraformValue<bool>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// IpConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    public required TerraformList<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlock> IpConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlock>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

}

/// <summary>
/// Block type for ip_configuration in AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("application_gateway_backend_address_pool_ids");
        set => SetArgument("application_gateway_backend_address_pool_ids", value);
    }

    /// <summary>
    /// The application_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? ApplicationSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("application_security_group_ids");
        set => SetArgument("application_security_group_ids", value);
    }

    /// <summary>
    /// The load_balancer_backend_address_pool_ids attribute.
    /// </summary>
    public TerraformSet<string>? LoadBalancerBackendAddressPoolIds
    {
        get => GetArgument<TerraformSet<string>>("load_balancer_backend_address_pool_ids");
        set => SetArgument("load_balancer_backend_address_pool_ids", value);
    }

    /// <summary>
    /// The load_balancer_inbound_nat_rules_ids attribute.
    /// </summary>
    public TerraformSet<string>? LoadBalancerInboundNatRulesIds
    {
        get => GetArgument<TerraformSet<string>>("load_balancer_inbound_nat_rules_ids");
        set => SetArgument("load_balancer_inbound_nat_rules_ids", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => GetArgument<TerraformValue<bool>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// PublicIpAddress block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlock>? PublicIpAddress
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlock>>("public_ip_address");
        set => SetArgument("public_ip_address", value);
    }

}

/// <summary>
/// Block type for public_ip_address in AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("domain_name_label");
        set => SetArgument("domain_name_label", value);
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> IdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("idle_timeout_in_minutes") ?? AsReference("idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_ip_prefix_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpPrefixId
    {
        get => GetArgument<TerraformValue<string>>("public_ip_prefix_id");
        set => SetArgument("public_ip_prefix_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// IpTag block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlockIpTagBlock>? IpTag
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlockIpTagBlock>>("ip_tag");
        set => SetArgument("ip_tag", value);
    }

}

/// <summary>
/// Block type for ip_tag in AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlockIpConfigurationBlockPublicIpAddressBlockIpTagBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for os_disk in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetOsDiskBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb") ?? AsReference("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string>? SecureVmDiskEncryptionSetId
    {
        get => GetArgument<TerraformValue<string>>("secure_vm_disk_encryption_set_id");
        set => SetArgument("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    public TerraformValue<string>? SecurityEncryptionType
    {
        get => GetArgument<TerraformValue<string>>("security_encryption_type");
        set => SetArgument("security_encryption_type", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformValue<string> StorageAccountType
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => GetArgument<TerraformValue<bool>>("write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

    /// <summary>
    /// DiffDiskSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiffDiskSettings block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetOsDiskBlockDiffDiskSettingsBlock>? DiffDiskSettings
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetOsDiskBlockDiffDiskSettingsBlock>>("diff_disk_settings");
        set => SetArgument("diff_disk_settings", value);
    }

}

/// <summary>
/// Block type for diff_disk_settings in AzurermLinuxVirtualMachineScaleSetOsDiskBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetOsDiskBlockDiffDiskSettingsBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("option");
        set => SetArgument("option", value);
    }

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformValue<string>? Placement
    {
        get => GetArgument<TerraformValue<string>>("placement");
        set => SetArgument("placement", value);
    }

}


/// <summary>
/// Block type for plan in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetPlanBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformValue<string> Product
    {
        get => GetRequiredArgument<TerraformValue<string>>("product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetRequiredArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

}


/// <summary>
/// Block type for rolling_upgrade_policy in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("cross_zone_upgrades_enabled");
        set => SetArgument("cross_zone_upgrades_enabled", value);
    }

    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxBatchInstancePercent is required")]
    public required TerraformValue<double> MaxBatchInstancePercent
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_batch_instance_percent");
        set => SetArgument("max_batch_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyInstancePercent is required")]
    public required TerraformValue<double> MaxUnhealthyInstancePercent
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_unhealthy_instance_percent");
        set => SetArgument("max_unhealthy_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyUpgradedInstancePercent is required")]
    public required TerraformValue<double> MaxUnhealthyUpgradedInstancePercent
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_unhealthy_upgraded_instance_percent");
        set => SetArgument("max_unhealthy_upgraded_instance_percent", value);
    }

    /// <summary>
    /// The maximum_surge_instances_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MaximumSurgeInstancesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("maximum_surge_instances_enabled");
        set => SetArgument("maximum_surge_instances_enabled", value);
    }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PauseTimeBetweenBatches is required")]
    public required TerraformValue<string> PauseTimeBetweenBatches
    {
        get => GetRequiredArgument<TerraformValue<string>>("pause_time_between_batches");
        set => SetArgument("pause_time_between_batches", value);
    }

    /// <summary>
    /// The prioritize_unhealthy_instances_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrioritizeUnhealthyInstancesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("prioritize_unhealthy_instances_enabled");
        set => SetArgument("prioritize_unhealthy_instances_enabled", value);
    }

}


/// <summary>
/// Block type for scale_in in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetScaleInBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scale_in";

    /// <summary>
    /// The force_deletion_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDeletionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("force_deletion_enabled");
        set => SetArgument("force_deletion_enabled", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    public TerraformValue<string>? Rule
    {
        get => GetArgument<TerraformValue<string>>("rule");
        set => SetArgument("rule", value);
    }

}


/// <summary>
/// Block type for secret in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetSecretBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Certificate block(s) required")]
    public required TerraformSet<AzurermLinuxVirtualMachineScaleSetSecretBlockCertificateBlock> Certificate
    {
        get => GetRequiredArgument<TerraformSet<AzurermLinuxVirtualMachineScaleSetSecretBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

}

/// <summary>
/// Block type for certificate in AzurermLinuxVirtualMachineScaleSetSecretBlock.
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetSecretBlockCertificateBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for source_image_reference in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetRequiredArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for spot_restore in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spot_restore";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

}


/// <summary>
/// Block type for termination_notification in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermLinuxVirtualMachineScaleSet.
/// Nesting mode: single
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_linux_virtual_machine_scale_set Terraform resource.
/// Manages a azurerm_linux_virtual_machine_scale_set resource.
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSet(string name) : TerraformResource("azurerm_linux_virtual_machine_scale_set", name)
{
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
        get => GetRequiredArgument<TerraformValue<string>>("admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformValue<string>? CapacityReservationGroupId
    {
        get => GetArgument<TerraformValue<string>>("capacity_reservation_group_id");
        set => SetArgument("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    public TerraformValue<string> ComputerNamePrefix
    {
        get => GetArgument<TerraformValue<string>>("computer_name_prefix") ?? AsReference("computer_name_prefix");
        set => SetArgument("computer_name_prefix", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformValue<string>? CustomData
    {
        get => GetArgument<TerraformValue<string>>("custom_data");
        set => SetArgument("custom_data", value);
    }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    public TerraformValue<bool>? DisablePasswordAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("disable_password_authentication");
        set => SetArgument("disable_password_authentication", value);
    }

    /// <summary>
    /// The do_not_run_extensions_on_overprovisioned_machines attribute.
    /// </summary>
    public TerraformValue<bool>? DoNotRunExtensionsOnOverprovisionedMachines
    {
        get => GetArgument<TerraformValue<bool>>("do_not_run_extensions_on_overprovisioned_machines");
        set => SetArgument("do_not_run_extensions_on_overprovisioned_machines", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => GetArgument<TerraformValue<string>>("edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionAtHostEnabled
    {
        get => GetArgument<TerraformValue<bool>>("encryption_at_host_enabled");
        set => SetArgument("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformValue<string>? EvictionPolicy
    {
        get => GetArgument<TerraformValue<string>>("eviction_policy");
        set => SetArgument("eviction_policy", value);
    }

    /// <summary>
    /// The extension_operations_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExtensionOperationsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("extension_operations_enabled");
        set => SetArgument("extension_operations_enabled", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public TerraformValue<string>? ExtensionsTimeBudget
    {
        get => GetArgument<TerraformValue<string>>("extensions_time_budget");
        set => SetArgument("extensions_time_budget", value);
    }

    /// <summary>
    /// The health_probe_id attribute.
    /// </summary>
    public TerraformValue<string>? HealthProbeId
    {
        get => GetArgument<TerraformValue<string>>("health_probe_id");
        set => SetArgument("health_probe_id", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformValue<string>? HostGroupId
    {
        get => GetArgument<TerraformValue<string>>("host_group_id");
        set => SetArgument("host_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformValue<double>? Instances
    {
        get => GetArgument<TerraformValue<double>>("instances");
        set => SetArgument("instances", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    public TerraformValue<double>? MaxBidPrice
    {
        get => GetArgument<TerraformValue<double>>("max_bid_price");
        set => SetArgument("max_bid_price", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The overprovision attribute.
    /// </summary>
    public TerraformValue<bool>? Overprovision
    {
        get => GetArgument<TerraformValue<bool>>("overprovision");
        set => SetArgument("overprovision", value);
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    public TerraformValue<double> PlatformFaultDomainCount
    {
        get => GetArgument<TerraformValue<double>>("platform_fault_domain_count") ?? AsReference("platform_fault_domain_count");
        set => SetArgument("platform_fault_domain_count", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<string>? Priority
    {
        get => GetArgument<TerraformValue<string>>("priority");
        set => SetArgument("priority", value);
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
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => GetArgument<TerraformValue<string>>("proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The resilient_vm_creation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ResilientVmCreationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("resilient_vm_creation_enabled");
        set => SetArgument("resilient_vm_creation_enabled", value);
    }

    /// <summary>
    /// The resilient_vm_deletion_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ResilientVmDeletionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("resilient_vm_deletion_enabled");
        set => SetArgument("resilient_vm_deletion_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SecureBootEnabled
    {
        get => GetArgument<TerraformValue<bool>>("secure_boot_enabled");
        set => SetArgument("secure_boot_enabled", value);
    }

    /// <summary>
    /// The single_placement_group attribute.
    /// </summary>
    public TerraformValue<bool>? SinglePlacementGroup
    {
        get => GetArgument<TerraformValue<bool>>("single_placement_group");
        set => SetArgument("single_placement_group", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceImageId
    {
        get => GetArgument<TerraformValue<string>>("source_image_id");
        set => SetArgument("source_image_id", value);
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
    /// The upgrade_mode attribute.
    /// </summary>
    public TerraformValue<string>? UpgradeMode
    {
        get => GetArgument<TerraformValue<string>>("upgrade_mode");
        set => SetArgument("upgrade_mode", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string>? UserData
    {
        get => GetArgument<TerraformValue<string>>("user_data");
        set => SetArgument("user_data", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VtpmEnabled
    {
        get => GetArgument<TerraformValue<bool>>("vtpm_enabled");
        set => SetArgument("vtpm_enabled", value);
    }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneBalance
    {
        get => GetArgument<TerraformValue<bool>>("zone_balance");
        set => SetArgument("zone_balance", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => GetArgument<TerraformSet<string>>("zones");
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformValue<string> UniqueId
        => AsReference("unique_id");

    /// <summary>
    /// AdditionalCapabilities block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock>>("additional_capabilities");
        set => SetArgument("additional_capabilities", value);
    }

    /// <summary>
    /// AdminSshKey block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock>? AdminSshKey
    {
        get => GetArgument<TerraformSet<AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock>>("admin_ssh_key");
        set => SetArgument("admin_ssh_key", value);
    }

    /// <summary>
    /// AutomaticInstanceRepair block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock>? AutomaticInstanceRepair
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock>>("automatic_instance_repair");
        set => SetArgument("automatic_instance_repair", value);
    }

    /// <summary>
    /// AutomaticOsUpgradePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticOsUpgradePolicy block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock>? AutomaticOsUpgradePolicy
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock>>("automatic_os_upgrade_policy");
        set => SetArgument("automatic_os_upgrade_policy", value);
    }

    /// <summary>
    /// BootDiagnostics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock>? BootDiagnostics
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock>>("boot_diagnostics");
        set => SetArgument("boot_diagnostics", value);
    }

    /// <summary>
    /// DataDisk block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLinuxVirtualMachineScaleSetDataDiskBlock>? DataDisk
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetDataDiskBlock>>("data_disk");
        set => SetArgument("data_disk", value);
    }

    /// <summary>
    /// Extension block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermLinuxVirtualMachineScaleSetExtensionBlock>? Extension
    {
        get => GetArgument<TerraformSet<AzurermLinuxVirtualMachineScaleSetExtensionBlock>>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// GalleryApplication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock>? GalleryApplication
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock>>("gallery_application");
        set => SetArgument("gallery_application", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// NetworkInterface block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterface is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkInterface block(s) required")]
    public required TerraformList<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock> NetworkInterface
    {
        get => GetRequiredArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock>>("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// OsDisk block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public required TerraformList<AzurermLinuxVirtualMachineScaleSetOsDiskBlock> OsDisk
    {
        get => GetRequiredArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetOsDiskBlock>>("os_disk");
        set => SetArgument("os_disk", value);
    }

    /// <summary>
    /// Plan block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetPlanBlock>? Plan
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetPlanBlock>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// RollingUpgradePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock>? RollingUpgradePolicy
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock>>("rolling_upgrade_policy");
        set => SetArgument("rolling_upgrade_policy", value);
    }

    /// <summary>
    /// ScaleIn block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleIn block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetScaleInBlock>? ScaleIn
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetScaleInBlock>>("scale_in");
        set => SetArgument("scale_in", value);
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLinuxVirtualMachineScaleSetSecretBlock>? Secret
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// SourceImageReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock>? SourceImageReference
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock>>("source_image_reference");
        set => SetArgument("source_image_reference", value);
    }

    /// <summary>
    /// SpotRestore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotRestore block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock>? SpotRestore
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock>>("spot_restore");
        set => SetArgument("spot_restore", value);
    }

    /// <summary>
    /// TerminationNotification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    public TerraformList<AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock>? TerminationNotification
    {
        get => GetArgument<TerraformList<AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock>>("termination_notification");
        set => SetArgument("termination_notification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLinuxVirtualMachineScaleSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLinuxVirtualMachineScaleSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
