using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for additional_location in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementAdditionalLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_location";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? GatewayDisabled
    {
        get => new TerraformReference<bool>(this, "gateway_disabled");
        set => SetArgument("gateway_disabled", value);
    }

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayRegionalUrl
    {
        get => new TerraformReference<string>(this, "gateway_regional_url");
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
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PublicIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ip_addresses").ResolveNodes(ctx));
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
    /// VirtualNetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    public TerraformList<AzurermApiManagementAdditionalLocationBlockVirtualNetworkConfigurationBlock>? VirtualNetworkConfiguration
    {
        get => GetArgument<TerraformList<AzurermApiManagementAdditionalLocationBlockVirtualNetworkConfigurationBlock>>("virtual_network_configuration");
        set => SetArgument("virtual_network_configuration", value);
    }

}

/// <summary>
/// Block type for virtual_network_configuration in AzurermApiManagementAdditionalLocationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementAdditionalLocationBlockVirtualNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_network_configuration";

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for certificate in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => new TerraformReference<string>(this, "certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The encoded_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncodedCertificate is required")]
    public required TerraformValue<string> EncodedCertificate
    {
        get => new TerraformReference<string>(this, "encoded_certificate");
        set => SetArgument("encoded_certificate", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
    }

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreName is required")]
    public required TerraformValue<string> StoreName
    {
        get => new TerraformReference<string>(this, "store_name");
        set => SetArgument("store_name", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

}


/// <summary>
/// Block type for delegation in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementDelegationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delegation";

    /// <summary>
    /// The subscriptions_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SubscriptionsEnabled
    {
        get => new TerraformReference<bool>(this, "subscriptions_enabled");
        set => SetArgument("subscriptions_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The user_registration_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UserRegistrationEnabled
    {
        get => new TerraformReference<bool>(this, "user_registration_enabled");
        set => SetArgument("user_registration_enabled", value);
    }

    /// <summary>
    /// The validation_key attribute.
    /// </summary>
    public TerraformValue<string>? ValidationKey
    {
        get => new TerraformReference<string>(this, "validation_key");
        set => SetArgument("validation_key", value);
    }

}


/// <summary>
/// Block type for hostname_configuration in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementHostnameConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hostname_configuration";

    /// <summary>
    /// DeveloperPortal block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementHostnameConfigurationBlockDeveloperPortalBlock>? DeveloperPortal
    {
        get => GetArgument<TerraformList<AzurermApiManagementHostnameConfigurationBlockDeveloperPortalBlock>>("developer_portal");
        set => SetArgument("developer_portal", value);
    }

    /// <summary>
    /// Management block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementHostnameConfigurationBlockManagementBlock>? Management
    {
        get => GetArgument<TerraformList<AzurermApiManagementHostnameConfigurationBlockManagementBlock>>("management");
        set => SetArgument("management", value);
    }

    /// <summary>
    /// Portal block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementHostnameConfigurationBlockPortalBlock>? Portal
    {
        get => GetArgument<TerraformList<AzurermApiManagementHostnameConfigurationBlockPortalBlock>>("portal");
        set => SetArgument("portal", value);
    }

    /// <summary>
    /// Proxy block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementHostnameConfigurationBlockProxyBlock>? Proxy
    {
        get => GetArgument<TerraformList<AzurermApiManagementHostnameConfigurationBlockProxyBlock>>("proxy");
        set => SetArgument("proxy", value);
    }

    /// <summary>
    /// Scm block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementHostnameConfigurationBlockScmBlock>? Scm
    {
        get => GetArgument<TerraformList<AzurermApiManagementHostnameConfigurationBlockScmBlock>>("scm");
        set => SetArgument("scm", value);
    }

}

/// <summary>
/// Block type for developer_portal in AzurermApiManagementHostnameConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementHostnameConfigurationBlockDeveloperPortalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "developer_portal";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => new TerraformReference<string>(this, "certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
    {
        get => new TerraformReference<string>(this, "certificate_source");
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
    {
        get => new TerraformReference<string>(this, "certificate_status");
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => new TerraformReference<bool>(this, "negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => new TerraformReference<string>(this, "ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

}

/// <summary>
/// Block type for management in AzurermApiManagementHostnameConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementHostnameConfigurationBlockManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => new TerraformReference<string>(this, "certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
    {
        get => new TerraformReference<string>(this, "certificate_source");
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
    {
        get => new TerraformReference<string>(this, "certificate_status");
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => new TerraformReference<bool>(this, "negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => new TerraformReference<string>(this, "ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

}

/// <summary>
/// Block type for portal in AzurermApiManagementHostnameConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementHostnameConfigurationBlockPortalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "portal";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => new TerraformReference<string>(this, "certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
    {
        get => new TerraformReference<string>(this, "certificate_source");
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
    {
        get => new TerraformReference<string>(this, "certificate_status");
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => new TerraformReference<bool>(this, "negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => new TerraformReference<string>(this, "ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

}

/// <summary>
/// Block type for proxy in AzurermApiManagementHostnameConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementHostnameConfigurationBlockProxyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => new TerraformReference<string>(this, "certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
    {
        get => new TerraformReference<string>(this, "certificate_source");
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
    {
        get => new TerraformReference<string>(this, "certificate_status");
    }

    /// <summary>
    /// The default_ssl_binding attribute.
    /// </summary>
    public TerraformValue<bool> DefaultSslBinding
    {
        get => new TerraformReference<bool>(this, "default_ssl_binding");
        set => SetArgument("default_ssl_binding", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => new TerraformReference<bool>(this, "negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => new TerraformReference<string>(this, "ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

}

/// <summary>
/// Block type for scm in AzurermApiManagementHostnameConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementHostnameConfigurationBlockScmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scm";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => new TerraformReference<string>(this, "certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
    {
        get => new TerraformReference<string>(this, "certificate_source");
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
    {
        get => new TerraformReference<string>(this, "certificate_status");
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => new TerraformReference<bool>(this, "negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => new TerraformReference<string>(this, "ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

}


/// <summary>
/// Block type for identity in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementIdentityBlock : TerraformBlock
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
/// Block type for protocols in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementProtocolsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protocols";

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableHttp2
    {
        get => new TerraformReference<bool>(this, "enable_http2");
        set => SetArgument("enable_http2", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
        set => SetArgument("http2_enabled", value);
    }

}


/// <summary>
/// Block type for security in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementSecurityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security";

    /// <summary>
    /// The backend_ssl30_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BackendSsl30Enabled
    {
        get => new TerraformReference<bool>(this, "backend_ssl30_enabled");
        set => SetArgument("backend_ssl30_enabled", value);
    }

    /// <summary>
    /// The backend_tls10_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BackendTls10Enabled
    {
        get => new TerraformReference<bool>(this, "backend_tls10_enabled");
        set => SetArgument("backend_tls10_enabled", value);
    }

    /// <summary>
    /// The backend_tls11_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BackendTls11Enabled
    {
        get => new TerraformReference<bool>(this, "backend_tls11_enabled");
        set => SetArgument("backend_tls11_enabled", value);
    }

    /// <summary>
    /// The enable_backend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableBackendSsl30
    {
        get => new TerraformReference<bool>(this, "enable_backend_ssl30");
        set => SetArgument("enable_backend_ssl30", value);
    }

    /// <summary>
    /// The enable_backend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableBackendTls10
    {
        get => new TerraformReference<bool>(this, "enable_backend_tls10");
        set => SetArgument("enable_backend_tls10", value);
    }

    /// <summary>
    /// The enable_backend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableBackendTls11
    {
        get => new TerraformReference<bool>(this, "enable_backend_tls11");
        set => SetArgument("enable_backend_tls11", value);
    }

    /// <summary>
    /// The enable_frontend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableFrontendSsl30
    {
        get => new TerraformReference<bool>(this, "enable_frontend_ssl30");
        set => SetArgument("enable_frontend_ssl30", value);
    }

    /// <summary>
    /// The enable_frontend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableFrontendTls10
    {
        get => new TerraformReference<bool>(this, "enable_frontend_tls10");
        set => SetArgument("enable_frontend_tls10", value);
    }

    /// <summary>
    /// The enable_frontend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableFrontendTls11
    {
        get => new TerraformReference<bool>(this, "enable_frontend_tls11");
        set => SetArgument("enable_frontend_tls11", value);
    }

    /// <summary>
    /// The frontend_ssl30_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FrontendSsl30Enabled
    {
        get => new TerraformReference<bool>(this, "frontend_ssl30_enabled");
        set => SetArgument("frontend_ssl30_enabled", value);
    }

    /// <summary>
    /// The frontend_tls10_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FrontendTls10Enabled
    {
        get => new TerraformReference<bool>(this, "frontend_tls10_enabled");
        set => SetArgument("frontend_tls10_enabled", value);
    }

    /// <summary>
    /// The frontend_tls11_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FrontendTls11Enabled
    {
        get => new TerraformReference<bool>(this, "frontend_tls11_enabled");
        set => SetArgument("frontend_tls11_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEcdheRsaWithAes128CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEcdheRsaWithAes256CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes128CbcSha256CiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes128_cbc_sha256_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes128_cbc_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes128CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes128_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_gcm_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes128GcmSha256CiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes128_gcm_sha256_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes128_gcm_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes256CbcSha256CiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes256_cbc_sha256_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes256_cbc_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes256CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes256_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_gcm_sha384_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes256GcmSha384CiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes256_gcm_sha384_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes256_gcm_sha384_ciphers_enabled", value);
    }

    /// <summary>
    /// The triple_des_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TripleDesCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "triple_des_ciphers_enabled");
        set => SetArgument("triple_des_ciphers_enabled", value);
    }

}


/// <summary>
/// Block type for sign_in in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementSignInBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sign_in";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for sign_up in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementSignUpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sign_up";

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
    /// TermsOfService block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TermsOfService is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TermsOfService block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TermsOfService block(s) allowed")]
    public required TerraformList<AzurermApiManagementSignUpBlockTermsOfServiceBlock> TermsOfService
    {
        get => GetRequiredArgument<TerraformList<AzurermApiManagementSignUpBlockTermsOfServiceBlock>>("terms_of_service");
        set => SetArgument("terms_of_service", value);
    }

}

/// <summary>
/// Block type for terms_of_service in AzurermApiManagementSignUpBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementSignUpBlockTermsOfServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "terms_of_service";

    /// <summary>
    /// The consent_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsentRequired is required")]
    public required TerraformValue<bool> ConsentRequired
    {
        get => new TerraformReference<bool>(this, "consent_required");
        set => SetArgument("consent_required", value);
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
    /// The text attribute.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

}


/// <summary>
/// Block type for tenant_access in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementTenantAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tenant_access";

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
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
    }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryKey
    {
        get => new TerraformReference<string>(this, "secondary_key");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

}


/// <summary>
/// Block type for timeouts in AzurermApiManagement.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementTimeoutsBlock : TerraformBlock
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
/// Block type for virtual_network_configuration in AzurermApiManagement.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementVirtualNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_network_configuration";

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management Terraform resource.
/// Manages a azurerm_api_management resource.
/// </summary>
public partial class AzurermApiManagement(string name) : TerraformResource("azurerm_api_management", name)
{
    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClientCertificateEnabled
    {
        get => new TerraformReference<bool>(this, "client_certificate_enabled");
        set => SetArgument("client_certificate_enabled", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? GatewayDisabled
    {
        get => new TerraformReference<bool>(this, "gateway_disabled");
        set => SetArgument("gateway_disabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The min_api_version attribute.
    /// </summary>
    public TerraformValue<string>? MinApiVersion
    {
        get => new TerraformReference<string>(this, "min_api_version");
        set => SetArgument("min_api_version", value);
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
    /// The notification_sender_email attribute.
    /// </summary>
    public TerraformValue<string> NotificationSenderEmail
    {
        get => new TerraformReference<string>(this, "notification_sender_email");
        set => SetArgument("notification_sender_email", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherEmail is required")]
    public required TerraformValue<string> PublisherEmail
    {
        get => new TerraformReference<string>(this, "publisher_email");
        set => SetArgument("publisher_email", value);
    }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherName is required")]
    public required TerraformValue<string> PublisherName
    {
        get => new TerraformReference<string>(this, "publisher_name");
        set => SetArgument("publisher_name", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
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
    /// The virtual_network_type attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkType
    {
        get => new TerraformReference<string>(this, "virtual_network_type");
        set => SetArgument("virtual_network_type", value);
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
    /// The developer_portal_url attribute.
    /// </summary>
    public TerraformValue<string> DeveloperPortalUrl
    {
        get => new TerraformReference<string>(this, "developer_portal_url");
    }

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayRegionalUrl
    {
        get => new TerraformReference<string>(this, "gateway_regional_url");
    }

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayUrl
    {
        get => new TerraformReference<string>(this, "gateway_url");
    }

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    public TerraformValue<string> ManagementApiUrl
    {
        get => new TerraformReference<string>(this, "management_api_url");
    }

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    public TerraformValue<string> PortalUrl
    {
        get => new TerraformReference<string>(this, "portal_url");
    }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PublicIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    public TerraformValue<string> ScmUrl
    {
        get => new TerraformReference<string>(this, "scm_url");
    }

    /// <summary>
    /// AdditionalLocation block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementAdditionalLocationBlock>? AdditionalLocation
    {
        get => GetArgument<TerraformList<AzurermApiManagementAdditionalLocationBlock>>("additional_location");
        set => SetArgument("additional_location", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Certificate block(s) allowed")]
    public TerraformList<AzurermApiManagementCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformList<AzurermApiManagementCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// Delegation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delegation block(s) allowed")]
    public TerraformList<AzurermApiManagementDelegationBlock>? Delegation
    {
        get => GetArgument<TerraformList<AzurermApiManagementDelegationBlock>>("delegation");
        set => SetArgument("delegation", value);
    }

    /// <summary>
    /// HostnameConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostnameConfiguration block(s) allowed")]
    public TerraformList<AzurermApiManagementHostnameConfigurationBlock>? HostnameConfiguration
    {
        get => GetArgument<TerraformList<AzurermApiManagementHostnameConfigurationBlock>>("hostname_configuration");
        set => SetArgument("hostname_configuration", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermApiManagementIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermApiManagementIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Protocols block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocols block(s) allowed")]
    public TerraformList<AzurermApiManagementProtocolsBlock>? Protocols
    {
        get => GetArgument<TerraformList<AzurermApiManagementProtocolsBlock>>("protocols");
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// Security block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    public TerraformList<AzurermApiManagementSecurityBlock>? Security
    {
        get => GetArgument<TerraformList<AzurermApiManagementSecurityBlock>>("security");
        set => SetArgument("security", value);
    }

    /// <summary>
    /// SignIn block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignIn block(s) allowed")]
    public TerraformList<AzurermApiManagementSignInBlock>? SignIn
    {
        get => GetArgument<TerraformList<AzurermApiManagementSignInBlock>>("sign_in");
        set => SetArgument("sign_in", value);
    }

    /// <summary>
    /// SignUp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignUp block(s) allowed")]
    public TerraformList<AzurermApiManagementSignUpBlock>? SignUp
    {
        get => GetArgument<TerraformList<AzurermApiManagementSignUpBlock>>("sign_up");
        set => SetArgument("sign_up", value);
    }

    /// <summary>
    /// TenantAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TenantAccess block(s) allowed")]
    public TerraformList<AzurermApiManagementTenantAccessBlock>? TenantAccess
    {
        get => GetArgument<TerraformList<AzurermApiManagementTenantAccessBlock>>("tenant_access");
        set => SetArgument("tenant_access", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VirtualNetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    public TerraformList<AzurermApiManagementVirtualNetworkConfigurationBlock>? VirtualNetworkConfiguration
    {
        get => GetArgument<TerraformList<AzurermApiManagementVirtualNetworkConfigurationBlock>>("virtual_network_configuration");
        set => SetArgument("virtual_network_configuration", value);
    }

}
