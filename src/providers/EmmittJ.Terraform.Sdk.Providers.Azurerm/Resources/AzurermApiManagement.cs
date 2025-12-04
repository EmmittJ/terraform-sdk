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
        get => GetArgument<TerraformValue<double>>("capacity") ?? AsReference("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? GatewayDisabled
    {
        get => GetArgument<TerraformValue<bool>>("gateway_disabled");
        set => SetArgument("gateway_disabled", value);
    }

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayRegionalUrl
        => AsReference("gateway_regional_url");

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
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
        => AsReference("private_ip_addresses");

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpAddressId
    {
        get => GetArgument<TerraformValue<string>>("public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PublicIpAddresses
        => AsReference("public_ip_addresses");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => GetArgument<TerraformSet<string>>("zones");
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
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
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
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The encoded_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncodedCertificate is required")]
    public required TerraformValue<string> EncodedCertificate
    {
        get => GetRequiredArgument<TerraformValue<string>>("encoded_certificate");
        set => SetArgument("encoded_certificate", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreName is required")]
    public required TerraformValue<string> StoreName
    {
        get => GetRequiredArgument<TerraformValue<string>>("store_name");
        set => SetArgument("store_name", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

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
        get => GetArgument<TerraformValue<bool>>("subscriptions_enabled");
        set => SetArgument("subscriptions_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The user_registration_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UserRegistrationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("user_registration_enabled");
        set => SetArgument("user_registration_enabled", value);
    }

    /// <summary>
    /// The validation_key attribute.
    /// </summary>
    public TerraformValue<string>? ValidationKey
    {
        get => GetArgument<TerraformValue<string>>("validation_key");
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
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
        => AsReference("certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
        => AsReference("certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_certificate_id") ?? AsReference("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id") ?? AsReference("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => GetArgument<TerraformValue<bool>>("negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

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
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
        => AsReference("certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
        => AsReference("certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_certificate_id") ?? AsReference("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id") ?? AsReference("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => GetArgument<TerraformValue<bool>>("negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

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
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
        => AsReference("certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
        => AsReference("certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_certificate_id") ?? AsReference("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id") ?? AsReference("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => GetArgument<TerraformValue<bool>>("negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

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
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
        => AsReference("certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
        => AsReference("certificate_status");

    /// <summary>
    /// The default_ssl_binding attribute.
    /// </summary>
    public TerraformValue<bool> DefaultSslBinding
    {
        get => GetArgument<TerraformValue<bool>>("default_ssl_binding") ?? AsReference("default_ssl_binding");
        set => SetArgument("default_ssl_binding", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_certificate_id") ?? AsReference("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id") ?? AsReference("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => GetArgument<TerraformValue<bool>>("negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

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
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
        => AsReference("certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
        => AsReference("certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_certificate_id") ?? AsReference("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id") ?? AsReference("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => GetArgument<TerraformValue<bool>>("negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

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
        get => GetArgument<TerraformValue<bool>>("enable_http2") ?? AsReference("enable_http2");
        set => SetArgument("enable_http2", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Http2Enabled
    {
        get => GetArgument<TerraformValue<bool>>("http2_enabled") ?? AsReference("http2_enabled");
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
        get => GetArgument<TerraformValue<bool>>("backend_ssl30_enabled") ?? AsReference("backend_ssl30_enabled");
        set => SetArgument("backend_ssl30_enabled", value);
    }

    /// <summary>
    /// The backend_tls10_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BackendTls10Enabled
    {
        get => GetArgument<TerraformValue<bool>>("backend_tls10_enabled") ?? AsReference("backend_tls10_enabled");
        set => SetArgument("backend_tls10_enabled", value);
    }

    /// <summary>
    /// The backend_tls11_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BackendTls11Enabled
    {
        get => GetArgument<TerraformValue<bool>>("backend_tls11_enabled") ?? AsReference("backend_tls11_enabled");
        set => SetArgument("backend_tls11_enabled", value);
    }

    /// <summary>
    /// The enable_backend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableBackendSsl30
    {
        get => GetArgument<TerraformValue<bool>>("enable_backend_ssl30") ?? AsReference("enable_backend_ssl30");
        set => SetArgument("enable_backend_ssl30", value);
    }

    /// <summary>
    /// The enable_backend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableBackendTls10
    {
        get => GetArgument<TerraformValue<bool>>("enable_backend_tls10") ?? AsReference("enable_backend_tls10");
        set => SetArgument("enable_backend_tls10", value);
    }

    /// <summary>
    /// The enable_backend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableBackendTls11
    {
        get => GetArgument<TerraformValue<bool>>("enable_backend_tls11") ?? AsReference("enable_backend_tls11");
        set => SetArgument("enable_backend_tls11", value);
    }

    /// <summary>
    /// The enable_frontend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableFrontendSsl30
    {
        get => GetArgument<TerraformValue<bool>>("enable_frontend_ssl30") ?? AsReference("enable_frontend_ssl30");
        set => SetArgument("enable_frontend_ssl30", value);
    }

    /// <summary>
    /// The enable_frontend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableFrontendTls10
    {
        get => GetArgument<TerraformValue<bool>>("enable_frontend_tls10") ?? AsReference("enable_frontend_tls10");
        set => SetArgument("enable_frontend_tls10", value);
    }

    /// <summary>
    /// The enable_frontend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableFrontendTls11
    {
        get => GetArgument<TerraformValue<bool>>("enable_frontend_tls11") ?? AsReference("enable_frontend_tls11");
        set => SetArgument("enable_frontend_tls11", value);
    }

    /// <summary>
    /// The frontend_ssl30_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FrontendSsl30Enabled
    {
        get => GetArgument<TerraformValue<bool>>("frontend_ssl30_enabled") ?? AsReference("frontend_ssl30_enabled");
        set => SetArgument("frontend_ssl30_enabled", value);
    }

    /// <summary>
    /// The frontend_tls10_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FrontendTls10Enabled
    {
        get => GetArgument<TerraformValue<bool>>("frontend_tls10_enabled") ?? AsReference("frontend_tls10_enabled");
        set => SetArgument("frontend_tls10_enabled", value);
    }

    /// <summary>
    /// The frontend_tls11_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FrontendTls11Enabled
    {
        get => GetArgument<TerraformValue<bool>>("frontend_tls11_enabled") ?? AsReference("frontend_tls11_enabled");
        set => SetArgument("frontend_tls11_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEcdheRsaWithAes128CbcShaCiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEcdheRsaWithAes256CbcShaCiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes128CbcSha256CiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_rsa_with_aes128_cbc_sha256_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes128_cbc_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes128CbcShaCiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_rsa_with_aes128_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_gcm_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes128GcmSha256CiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_rsa_with_aes128_gcm_sha256_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes128_gcm_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes256CbcSha256CiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_rsa_with_aes256_cbc_sha256_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes256_cbc_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes256CbcShaCiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_rsa_with_aes256_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_gcm_sha384_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsRsaWithAes256GcmSha384CiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_rsa_with_aes256_gcm_sha384_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes256_gcm_sha384_ciphers_enabled", value);
    }

    /// <summary>
    /// The triple_des_ciphers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TripleDesCiphersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("triple_des_ciphers_enabled");
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
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
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
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
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
        get => GetRequiredArgument<TerraformValue<bool>>("consent_required");
        set => SetArgument("consent_required", value);
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
    /// The text attribute.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => GetArgument<TerraformValue<string>>("text");
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
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryKey
        => AsReference("secondary_key");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

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
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
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
        get => GetArgument<TerraformValue<bool>>("client_certificate_enabled");
        set => SetArgument("client_certificate_enabled", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? GatewayDisabled
    {
        get => GetArgument<TerraformValue<bool>>("gateway_disabled");
        set => SetArgument("gateway_disabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The min_api_version attribute.
    /// </summary>
    public TerraformValue<string>? MinApiVersion
    {
        get => GetArgument<TerraformValue<string>>("min_api_version");
        set => SetArgument("min_api_version", value);
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
    /// The notification_sender_email attribute.
    /// </summary>
    public TerraformValue<string> NotificationSenderEmail
    {
        get => GetArgument<TerraformValue<string>>("notification_sender_email") ?? AsReference("notification_sender_email");
        set => SetArgument("notification_sender_email", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpAddressId
    {
        get => GetArgument<TerraformValue<string>>("public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherEmail is required")]
    public required TerraformValue<string> PublisherEmail
    {
        get => GetRequiredArgument<TerraformValue<string>>("publisher_email");
        set => SetArgument("publisher_email", value);
    }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherName is required")]
    public required TerraformValue<string> PublisherName
    {
        get => GetRequiredArgument<TerraformValue<string>>("publisher_name");
        set => SetArgument("publisher_name", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
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
    /// The virtual_network_type attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkType
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_type");
        set => SetArgument("virtual_network_type", value);
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
    /// The developer_portal_url attribute.
    /// </summary>
    public TerraformValue<string> DeveloperPortalUrl
        => AsReference("developer_portal_url");

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayRegionalUrl
        => AsReference("gateway_regional_url");

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayUrl
        => AsReference("gateway_url");

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    public TerraformValue<string> ManagementApiUrl
        => AsReference("management_api_url");

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    public TerraformValue<string> PortalUrl
        => AsReference("portal_url");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
        => AsReference("private_ip_addresses");

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PublicIpAddresses
        => AsReference("public_ip_addresses");

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    public TerraformValue<string> ScmUrl
        => AsReference("scm_url");

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
