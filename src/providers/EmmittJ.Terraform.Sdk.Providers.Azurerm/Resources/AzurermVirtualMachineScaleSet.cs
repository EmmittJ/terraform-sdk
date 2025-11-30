using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for boot_diagnostics in AzurermVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetBootDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_diagnostics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
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
/// Block type for extension in AzurermVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetExtensionBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "auto_upgrade_minor_version");
        set => SetArgument("auto_upgrade_minor_version", value);
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
    /// The provision_after_extensions attribute.
    /// </summary>
    public TerraformSet<string>? ProvisionAfterExtensions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "provision_after_extensions").ResolveNodes(ctx));
        set => SetArgument("provision_after_extensions", value);
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

}


/// <summary>
/// Block type for identity in AzurermVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetIdentityBlock : TerraformBlock
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
/// Block type for network_profile in AzurermVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_profile";

    /// <summary>
    /// The accelerated_networking attribute.
    /// </summary>
    public TerraformValue<bool>? AcceleratedNetworking
    {
        get => new TerraformReference<bool>(this, "accelerated_networking");
        set => SetArgument("accelerated_networking", value);
    }

    /// <summary>
    /// The ip_forwarding attribute.
    /// </summary>
    public TerraformValue<bool>? IpForwarding
    {
        get => new TerraformReference<bool>(this, "ip_forwarding");
        set => SetArgument("ip_forwarding", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    public required TerraformValue<bool> Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// DnsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    public TerraformList<AzurermVirtualMachineScaleSetNetworkProfileBlockDnsSettingsBlock>? DnsSettings
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetNetworkProfileBlockDnsSettingsBlock>>("dns_settings");
        set => SetArgument("dns_settings", value);
    }

    /// <summary>
    /// IpConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    public required TerraformList<AzurermVirtualMachineScaleSetNetworkProfileBlockIpConfigurationBlock> IpConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermVirtualMachineScaleSetNetworkProfileBlockIpConfigurationBlock>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

}

/// <summary>
/// Block type for dns_settings in AzurermVirtualMachineScaleSetNetworkProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetNetworkProfileBlockDnsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_settings";

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsServers is required")]
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

}

/// <summary>
/// Block type for ip_configuration in AzurermVirtualMachineScaleSetNetworkProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetNetworkProfileBlockIpConfigurationBlock : TerraformBlock
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
    /// The load_balancer_inbound_nat_rules_ids attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancerInboundNatRulesIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "load_balancer_inbound_nat_rules_ids").ResolveNodes(ctx));
        set => SetArgument("load_balancer_inbound_nat_rules_ids", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    public required TerraformValue<bool> Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// PublicIpAddressConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicIpAddressConfiguration block(s) allowed")]
    public TerraformList<AzurermVirtualMachineScaleSetNetworkProfileBlockIpConfigurationBlockPublicIpAddressConfigurationBlock>? PublicIpAddressConfiguration
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetNetworkProfileBlockIpConfigurationBlockPublicIpAddressConfigurationBlock>>("public_ip_address_configuration");
        set => SetArgument("public_ip_address_configuration", value);
    }

}

/// <summary>
/// Block type for public_ip_address_configuration in AzurermVirtualMachineScaleSetNetworkProfileBlockIpConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetNetworkProfileBlockIpConfigurationBlockPublicIpAddressConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_ip_address_configuration";

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNameLabel is required")]
    public required TerraformValue<string> DomainNameLabel
    {
        get => new TerraformReference<string>(this, "domain_name_label");
        set => SetArgument("domain_name_label", value);
    }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdleTimeout is required")]
    public required TerraformValue<double> IdleTimeout
    {
        get => new TerraformReference<double>(this, "idle_timeout");
        set => SetArgument("idle_timeout", value);
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

}


/// <summary>
/// Block type for os_profile in AzurermVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileBlock : TerraformBlock
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
    /// The computer_name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputerNamePrefix is required")]
    public required TerraformValue<string> ComputerNamePrefix
    {
        get => new TerraformReference<string>(this, "computer_name_prefix");
        set => SetArgument("computer_name_prefix", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformValue<string>? CustomData
    {
        get => new TerraformReference<string>(this, "custom_data");
        set => SetArgument("custom_data", value);
    }

}


/// <summary>
/// Block type for os_profile_linux_config in AzurermVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_profile_linux_config";

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    public TerraformValue<bool>? DisablePasswordAuthentication
    {
        get => new TerraformReference<bool>(this, "disable_password_authentication");
        set => SetArgument("disable_password_authentication", value);
    }

    /// <summary>
    /// SshKeys block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlockSshKeysBlock>? SshKeys
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlockSshKeysBlock>>("ssh_keys");
        set => SetArgument("ssh_keys", value);
    }

}

/// <summary>
/// Block type for ssh_keys in AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlockSshKeysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_keys";

    /// <summary>
    /// The key_data attribute.
    /// </summary>
    public TerraformValue<string>? KeyData
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
/// Block type for os_profile_secrets in AzurermVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileSecretsBlock : TerraformBlock
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
    public TerraformList<AzurermVirtualMachineScaleSetOsProfileSecretsBlockVaultCertificatesBlock>? VaultCertificates
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetOsProfileSecretsBlockVaultCertificatesBlock>>("vault_certificates");
        set => SetArgument("vault_certificates", value);
    }

}

/// <summary>
/// Block type for vault_certificates in AzurermVirtualMachineScaleSetOsProfileSecretsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileSecretsBlockVaultCertificatesBlock : TerraformBlock
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
/// Block type for os_profile_windows_config in AzurermVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock : TerraformBlock
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
    /// AdditionalUnattendConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlockAdditionalUnattendConfigBlock>? AdditionalUnattendConfig
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlockAdditionalUnattendConfigBlock>>("additional_unattend_config");
        set => SetArgument("additional_unattend_config", value);
    }

    /// <summary>
    /// Winrm block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlockWinrmBlock>? Winrm
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlockWinrmBlock>>("winrm");
        set => SetArgument("winrm", value);
    }

}

/// <summary>
/// Block type for additional_unattend_config in AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlockAdditionalUnattendConfigBlock : TerraformBlock
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
/// Block type for winrm in AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlockWinrmBlock : TerraformBlock
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
/// Block type for plan in AzurermVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetPlanBlock : TerraformBlock
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
/// Block type for rolling_upgrade_policy in AzurermVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rolling_upgrade_policy";

    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    public TerraformValue<double>? MaxBatchInstancePercent
    {
        get => new TerraformReference<double>(this, "max_batch_instance_percent");
        set => SetArgument("max_batch_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    public TerraformValue<double>? MaxUnhealthyInstancePercent
    {
        get => new TerraformReference<double>(this, "max_unhealthy_instance_percent");
        set => SetArgument("max_unhealthy_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    public TerraformValue<double>? MaxUnhealthyUpgradedInstancePercent
    {
        get => new TerraformReference<double>(this, "max_unhealthy_upgraded_instance_percent");
        set => SetArgument("max_unhealthy_upgraded_instance_percent", value);
    }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    public TerraformValue<string>? PauseTimeBetweenBatches
    {
        get => new TerraformReference<string>(this, "pause_time_between_batches");
        set => SetArgument("pause_time_between_batches", value);
    }

}


/// <summary>
/// Block type for sku in AzurermVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
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
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

}


/// <summary>
/// Block type for storage_profile_data_disk in AzurermVirtualMachineScaleSet.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_profile_data_disk";

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
    /// The managed_disk_type attribute.
    /// </summary>
    public TerraformValue<string> ManagedDiskType
    {
        get => new TerraformReference<string>(this, "managed_disk_type");
        set => SetArgument("managed_disk_type", value);
    }

}


/// <summary>
/// Block type for storage_profile_image_reference in AzurermVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_profile_image_reference";

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
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for storage_profile_os_disk in AzurermVirtualMachineScaleSet.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_profile_os_disk";

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
    /// The image attribute.
    /// </summary>
    public TerraformValue<string>? Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
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
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string>? OsType
    {
        get => new TerraformReference<string>(this, "os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The vhd_containers attribute.
    /// </summary>
    public TerraformSet<string>? VhdContainers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vhd_containers").ResolveNodes(ctx));
        set => SetArgument("vhd_containers", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualMachineScaleSet.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineScaleSetTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_machine_scale_set Terraform resource.
/// Manages a azurerm_virtual_machine_scale_set resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermVirtualMachineScaleSet(string name) : TerraformResource("azurerm_virtual_machine_scale_set", name)
{
    /// <summary>
    /// The automatic_os_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticOsUpgrade
    {
        get => new TerraformReference<bool>(this, "automatic_os_upgrade");
        set => SetArgument("automatic_os_upgrade", value);
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
    /// The health_probe_id attribute.
    /// </summary>
    public TerraformValue<string>? HealthProbeId
    {
        get => new TerraformReference<string>(this, "health_probe_id");
        set => SetArgument("health_probe_id", value);
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
    /// The overprovision attribute.
    /// </summary>
    public TerraformValue<bool>? Overprovision
    {
        get => new TerraformReference<bool>(this, "overprovision");
        set => SetArgument("overprovision", value);
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
    public TerraformValue<bool>? SinglePlacementGroup
    {
        get => new TerraformReference<bool>(this, "single_placement_group");
        set => SetArgument("single_placement_group", value);
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
    /// The upgrade_policy_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradePolicyMode is required")]
    public required TerraformValue<string> UpgradePolicyMode
    {
        get => new TerraformReference<string>(this, "upgrade_policy_mode");
        set => SetArgument("upgrade_policy_mode", value);
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
    /// BootDiagnostics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public TerraformList<AzurermVirtualMachineScaleSetBootDiagnosticsBlock>? BootDiagnostics
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetBootDiagnosticsBlock>>("boot_diagnostics");
        set => SetArgument("boot_diagnostics", value);
    }

    /// <summary>
    /// Extension block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVirtualMachineScaleSetExtensionBlock>? Extension
    {
        get => GetArgument<TerraformSet<AzurermVirtualMachineScaleSetExtensionBlock>>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermVirtualMachineScaleSetIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// NetworkProfile block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    public required TerraformSet<AzurermVirtualMachineScaleSetNetworkProfileBlock> NetworkProfile
    {
        get => GetRequiredArgument<TerraformSet<AzurermVirtualMachineScaleSetNetworkProfileBlock>>("network_profile");
        set => SetArgument("network_profile", value);
    }

    /// <summary>
    /// OsProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public required TerraformList<AzurermVirtualMachineScaleSetOsProfileBlock> OsProfile
    {
        get => GetRequiredArgument<TerraformList<AzurermVirtualMachineScaleSetOsProfileBlock>>("os_profile");
        set => SetArgument("os_profile", value);
    }

    /// <summary>
    /// OsProfileLinuxConfig block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileLinuxConfig block(s) allowed")]
    public TerraformSet<AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock>? OsProfileLinuxConfig
    {
        get => GetArgument<TerraformSet<AzurermVirtualMachineScaleSetOsProfileLinuxConfigBlock>>("os_profile_linux_config");
        set => SetArgument("os_profile_linux_config", value);
    }

    /// <summary>
    /// OsProfileSecrets block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVirtualMachineScaleSetOsProfileSecretsBlock>? OsProfileSecrets
    {
        get => GetArgument<TerraformSet<AzurermVirtualMachineScaleSetOsProfileSecretsBlock>>("os_profile_secrets");
        set => SetArgument("os_profile_secrets", value);
    }

    /// <summary>
    /// OsProfileWindowsConfig block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfileWindowsConfig block(s) allowed")]
    public TerraformSet<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock>? OsProfileWindowsConfig
    {
        get => GetArgument<TerraformSet<AzurermVirtualMachineScaleSetOsProfileWindowsConfigBlock>>("os_profile_windows_config");
        set => SetArgument("os_profile_windows_config", value);
    }

    /// <summary>
    /// Plan block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public TerraformSet<AzurermVirtualMachineScaleSetPlanBlock>? Plan
    {
        get => GetArgument<TerraformSet<AzurermVirtualMachineScaleSetPlanBlock>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// RollingUpgradePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    public TerraformList<AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock>? RollingUpgradePolicy
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetRollingUpgradePolicyBlock>>("rolling_upgrade_policy");
        set => SetArgument("rolling_upgrade_policy", value);
    }

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermVirtualMachineScaleSetSkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermVirtualMachineScaleSetSkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// StorageProfileDataDisk block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock>? StorageProfileDataDisk
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetStorageProfileDataDiskBlock>>("storage_profile_data_disk");
        set => SetArgument("storage_profile_data_disk", value);
    }

    /// <summary>
    /// StorageProfileImageReference block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfileImageReference block(s) allowed")]
    public TerraformSet<AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock>? StorageProfileImageReference
    {
        get => GetArgument<TerraformSet<AzurermVirtualMachineScaleSetStorageProfileImageReferenceBlock>>("storage_profile_image_reference");
        set => SetArgument("storage_profile_image_reference", value);
    }

    /// <summary>
    /// StorageProfileOsDisk block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageProfileOsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageProfileOsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageProfileOsDisk block(s) allowed")]
    public required TerraformSet<AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock> StorageProfileOsDisk
    {
        get => GetRequiredArgument<TerraformSet<AzurermVirtualMachineScaleSetStorageProfileOsDiskBlock>>("storage_profile_os_disk");
        set => SetArgument("storage_profile_os_disk", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualMachineScaleSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualMachineScaleSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
