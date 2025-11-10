using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_location in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementAdditionalLocationBlock : TerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double>? Capacity
    {
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GatewayDisabled
    {
        set => SetProperty("gateway_disabled", value);
    }

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayRegionalUrl
    {
        set => SetProperty("gateway_regional_url", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PrivateIpAddresses
    {
        set => SetProperty("private_ip_addresses", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpAddressId
    {
        set => SetProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PublicIpAddresses
    {
        set => SetProperty("public_ip_addresses", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        set => SetProperty("zones", value);
    }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        set => SetProperty("certificate_password", value);
    }

    /// <summary>
    /// The encoded_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncodedCertificate is required")]
    public required TerraformProperty<string> EncodedCertificate
    {
        set => SetProperty("encoded_certificate", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformProperty<string>? Expiry
    {
        set => SetProperty("expiry", value);
    }

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreName is required")]
    public required TerraformProperty<string> StoreName
    {
        set => SetProperty("store_name", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformProperty<string>? Subject
    {
        set => SetProperty("subject", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? Thumbprint
    {
        set => SetProperty("thumbprint", value);
    }

}

/// <summary>
/// Block type for delegation in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementDelegationBlock : TerraformBlock
{
    /// <summary>
    /// The subscriptions_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SubscriptionsEnabled
    {
        set => SetProperty("subscriptions_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        set => SetProperty("url", value);
    }

    /// <summary>
    /// The user_registration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UserRegistrationEnabled
    {
        set => SetProperty("user_registration_enabled", value);
    }

    /// <summary>
    /// The validation_key attribute.
    /// </summary>
    public TerraformProperty<string>? ValidationKey
    {
        set => SetProperty("validation_key", value);
    }

}

/// <summary>
/// Block type for hostname_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementHostnameConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementIdentityBlock : TerraformBlock
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
/// Block type for protocols in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementProtocolsBlock : TerraformBlock
{
    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableHttp2
    {
        set => SetProperty("enable_http2", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Http2Enabled
    {
        set => SetProperty("http2_enabled", value);
    }

}

/// <summary>
/// Block type for security in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementSecurityBlock : TerraformBlock
{
    /// <summary>
    /// The backend_ssl30_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BackendSsl30Enabled
    {
        set => SetProperty("backend_ssl30_enabled", value);
    }

    /// <summary>
    /// The backend_tls10_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BackendTls10Enabled
    {
        set => SetProperty("backend_tls10_enabled", value);
    }

    /// <summary>
    /// The backend_tls11_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BackendTls11Enabled
    {
        set => SetProperty("backend_tls11_enabled", value);
    }

    /// <summary>
    /// The enable_backend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableBackendSsl30
    {
        set => SetProperty("enable_backend_ssl30", value);
    }

    /// <summary>
    /// The enable_backend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableBackendTls10
    {
        set => SetProperty("enable_backend_tls10", value);
    }

    /// <summary>
    /// The enable_backend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableBackendTls11
    {
        set => SetProperty("enable_backend_tls11", value);
    }

    /// <summary>
    /// The enable_frontend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableFrontendSsl30
    {
        set => SetProperty("enable_frontend_ssl30", value);
    }

    /// <summary>
    /// The enable_frontend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableFrontendTls10
    {
        set => SetProperty("enable_frontend_tls10", value);
    }

    /// <summary>
    /// The enable_frontend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableFrontendTls11
    {
        set => SetProperty("enable_frontend_tls11", value);
    }

    /// <summary>
    /// The frontend_ssl30_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FrontendSsl30Enabled
    {
        set => SetProperty("frontend_ssl30_enabled", value);
    }

    /// <summary>
    /// The frontend_tls10_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FrontendTls10Enabled
    {
        set => SetProperty("frontend_tls10_enabled", value);
    }

    /// <summary>
    /// The frontend_tls11_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FrontendTls11Enabled
    {
        set => SetProperty("frontend_tls11_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled
    {
        set => SetProperty("tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled
    {
        set => SetProperty("tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEcdheRsaWithAes128CbcShaCiphersEnabled
    {
        set => SetProperty("tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEcdheRsaWithAes256CbcShaCiphersEnabled
    {
        set => SetProperty("tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes128CbcSha256CiphersEnabled
    {
        set => SetProperty("tls_rsa_with_aes128_cbc_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes128CbcShaCiphersEnabled
    {
        set => SetProperty("tls_rsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_gcm_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes128GcmSha256CiphersEnabled
    {
        set => SetProperty("tls_rsa_with_aes128_gcm_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes256CbcSha256CiphersEnabled
    {
        set => SetProperty("tls_rsa_with_aes256_cbc_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes256CbcShaCiphersEnabled
    {
        set => SetProperty("tls_rsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_gcm_sha384_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes256GcmSha384CiphersEnabled
    {
        set => SetProperty("tls_rsa_with_aes256_gcm_sha384_ciphers_enabled", value);
    }

    /// <summary>
    /// The triple_des_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TripleDesCiphersEnabled
    {
        set => SetProperty("triple_des_ciphers_enabled", value);
    }

}

/// <summary>
/// Block type for sign_in in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementSignInBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for sign_up in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementSignUpBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for tenant_access in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementTenantAccessBlock : TerraformBlock
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
    /// The primary_key attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryKey
    {
        set => SetProperty("primary_key", value);
    }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformProperty<string>? SecondaryKey
    {
        set => SetProperty("secondary_key", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementTimeoutsBlock : TerraformBlock
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
/// Block type for virtual_network_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementVirtualNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Manages a azurerm_api_management resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApiManagement : TerraformResource
{
    public AzurermApiManagement(string name) : base("azurerm_api_management", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("developer_portal_url");
        SetOutput("gateway_regional_url");
        SetOutput("gateway_url");
        SetOutput("management_api_url");
        SetOutput("portal_url");
        SetOutput("private_ip_addresses");
        SetOutput("public_ip_addresses");
        SetOutput("scm_url");
        SetOutput("client_certificate_enabled");
        SetOutput("gateway_disabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("min_api_version");
        SetOutput("name");
        SetOutput("notification_sender_email");
        SetOutput("public_ip_address_id");
        SetOutput("public_network_access_enabled");
        SetOutput("publisher_email");
        SetOutput("publisher_name");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("tags");
        SetOutput("virtual_network_type");
        SetOutput("zones");
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ClientCertificateEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("client_certificate_enabled");
        set => SetProperty("client_certificate_enabled", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    public TerraformProperty<bool> GatewayDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("gateway_disabled");
        set => SetProperty("gateway_disabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The min_api_version attribute.
    /// </summary>
    public TerraformProperty<string> MinApiVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("min_api_version");
        set => SetProperty("min_api_version", value);
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
    /// The notification_sender_email attribute.
    /// </summary>
    public TerraformProperty<string> NotificationSenderEmail
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_sender_email");
        set => SetProperty("notification_sender_email", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string> PublicIpAddressId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_ip_address_id");
        set => SetProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherEmail is required")]
    public required TerraformProperty<string> PublisherEmail
    {
        get => GetRequiredOutput<TerraformProperty<string>>("publisher_email");
        set => SetProperty("publisher_email", value);
    }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherName is required")]
    public required TerraformProperty<string> PublisherName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("publisher_name");
        set => SetProperty("publisher_name", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
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
    /// The virtual_network_type attribute.
    /// </summary>
    public TerraformProperty<string> VirtualNetworkType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_type");
        set => SetProperty("virtual_network_type", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for additional_location.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementAdditionalLocationBlock>? AdditionalLocation
    {
        set => SetProperty("additional_location", value);
    }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Certificate block(s) allowed")]
    public List<AzurermApiManagementCertificateBlock>? Certificate
    {
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// Block for delegation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delegation block(s) allowed")]
    public List<AzurermApiManagementDelegationBlock>? Delegation
    {
        set => SetProperty("delegation", value);
    }

    /// <summary>
    /// Block for hostname_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostnameConfiguration block(s) allowed")]
    public List<AzurermApiManagementHostnameConfigurationBlock>? HostnameConfiguration
    {
        set => SetProperty("hostname_configuration", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermApiManagementIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for protocols.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocols block(s) allowed")]
    public List<AzurermApiManagementProtocolsBlock>? Protocols
    {
        set => SetProperty("protocols", value);
    }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    public List<AzurermApiManagementSecurityBlock>? Security
    {
        set => SetProperty("security", value);
    }

    /// <summary>
    /// Block for sign_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignIn block(s) allowed")]
    public List<AzurermApiManagementSignInBlock>? SignIn
    {
        set => SetProperty("sign_in", value);
    }

    /// <summary>
    /// Block for sign_up.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignUp block(s) allowed")]
    public List<AzurermApiManagementSignUpBlock>? SignUp
    {
        set => SetProperty("sign_up", value);
    }

    /// <summary>
    /// Block for tenant_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TenantAccess block(s) allowed")]
    public List<AzurermApiManagementTenantAccessBlock>? TenantAccess
    {
        set => SetProperty("tenant_access", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    public List<AzurermApiManagementVirtualNetworkConfigurationBlock>? VirtualNetworkConfiguration
    {
        set => SetProperty("virtual_network_configuration", value);
    }

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    public TerraformExpression DeveloperPortalUrl => this["developer_portal_url"];

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformExpression GatewayRegionalUrl => this["gateway_regional_url"];

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    public TerraformExpression GatewayUrl => this["gateway_url"];

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    public TerraformExpression ManagementApiUrl => this["management_api_url"];

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    public TerraformExpression PortalUrl => this["portal_url"];

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddresses => this["private_ip_addresses"];

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PublicIpAddresses => this["public_ip_addresses"];

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    public TerraformExpression ScmUrl => this["scm_url"];

}
