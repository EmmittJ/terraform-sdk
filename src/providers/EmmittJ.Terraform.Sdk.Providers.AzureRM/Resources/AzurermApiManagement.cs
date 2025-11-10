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
        get => GetProperty<TerraformProperty<double>>("capacity");
        set => WithProperty("capacity", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GatewayDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("gateway_disabled");
        set => WithProperty("gateway_disabled", value);
    }

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayRegionalUrl
    {
        get => GetProperty<TerraformProperty<string>>("gateway_regional_url");
        set => WithProperty("gateway_regional_url", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PrivateIpAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("private_ip_addresses");
        set => WithProperty("private_ip_addresses", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpAddressId
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_address_id");
        set => WithProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PublicIpAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("public_ip_addresses");
        set => WithProperty("public_ip_addresses", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => WithProperty("zones", value);
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
        get => GetProperty<TerraformProperty<string>>("certificate_password");
        set => WithProperty("certificate_password", value);
    }

    /// <summary>
    /// The encoded_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncodedCertificate is required")]
    public required TerraformProperty<string> EncodedCertificate
    {
        get => GetRequiredProperty<TerraformProperty<string>>("encoded_certificate");
        set => WithProperty("encoded_certificate", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformProperty<string>? Expiry
    {
        get => GetProperty<TerraformProperty<string>>("expiry");
        set => WithProperty("expiry", value);
    }

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreName is required")]
    public required TerraformProperty<string> StoreName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("store_name");
        set => WithProperty("store_name", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformProperty<string>? Subject
    {
        get => GetProperty<TerraformProperty<string>>("subject");
        set => WithProperty("subject", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? Thumbprint
    {
        get => GetProperty<TerraformProperty<string>>("thumbprint");
        set => WithProperty("thumbprint", value);
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
        get => GetProperty<TerraformProperty<bool>>("subscriptions_enabled");
        set => WithProperty("subscriptions_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

    /// <summary>
    /// The user_registration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UserRegistrationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("user_registration_enabled");
        set => WithProperty("user_registration_enabled", value);
    }

    /// <summary>
    /// The validation_key attribute.
    /// </summary>
    public TerraformProperty<string>? ValidationKey
    {
        get => GetProperty<TerraformProperty<string>>("validation_key");
        set => WithProperty("validation_key", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<bool>>("enable_http2");
        set => WithProperty("enable_http2", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Http2Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("http2_enabled");
        set => WithProperty("http2_enabled", value);
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
        get => GetProperty<TerraformProperty<bool>>("backend_ssl30_enabled");
        set => WithProperty("backend_ssl30_enabled", value);
    }

    /// <summary>
    /// The backend_tls10_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BackendTls10Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("backend_tls10_enabled");
        set => WithProperty("backend_tls10_enabled", value);
    }

    /// <summary>
    /// The backend_tls11_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BackendTls11Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("backend_tls11_enabled");
        set => WithProperty("backend_tls11_enabled", value);
    }

    /// <summary>
    /// The enable_backend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableBackendSsl30
    {
        get => GetProperty<TerraformProperty<bool>>("enable_backend_ssl30");
        set => WithProperty("enable_backend_ssl30", value);
    }

    /// <summary>
    /// The enable_backend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableBackendTls10
    {
        get => GetProperty<TerraformProperty<bool>>("enable_backend_tls10");
        set => WithProperty("enable_backend_tls10", value);
    }

    /// <summary>
    /// The enable_backend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableBackendTls11
    {
        get => GetProperty<TerraformProperty<bool>>("enable_backend_tls11");
        set => WithProperty("enable_backend_tls11", value);
    }

    /// <summary>
    /// The enable_frontend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableFrontendSsl30
    {
        get => GetProperty<TerraformProperty<bool>>("enable_frontend_ssl30");
        set => WithProperty("enable_frontend_ssl30", value);
    }

    /// <summary>
    /// The enable_frontend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableFrontendTls10
    {
        get => GetProperty<TerraformProperty<bool>>("enable_frontend_tls10");
        set => WithProperty("enable_frontend_tls10", value);
    }

    /// <summary>
    /// The enable_frontend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableFrontendTls11
    {
        get => GetProperty<TerraformProperty<bool>>("enable_frontend_tls11");
        set => WithProperty("enable_frontend_tls11", value);
    }

    /// <summary>
    /// The frontend_ssl30_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FrontendSsl30Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("frontend_ssl30_enabled");
        set => WithProperty("frontend_ssl30_enabled", value);
    }

    /// <summary>
    /// The frontend_tls10_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FrontendTls10Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("frontend_tls10_enabled");
        set => WithProperty("frontend_tls10_enabled", value);
    }

    /// <summary>
    /// The frontend_tls11_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FrontendTls11Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("frontend_tls11_enabled");
        set => WithProperty("frontend_tls11_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled");
        set => WithProperty("tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled");
        set => WithProperty("tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEcdheRsaWithAes128CbcShaCiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled");
        set => WithProperty("tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEcdheRsaWithAes256CbcShaCiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled");
        set => WithProperty("tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes128CbcSha256CiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_rsa_with_aes128_cbc_sha256_ciphers_enabled");
        set => WithProperty("tls_rsa_with_aes128_cbc_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes128CbcShaCiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_rsa_with_aes128_cbc_sha_ciphers_enabled");
        set => WithProperty("tls_rsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_gcm_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes128GcmSha256CiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_rsa_with_aes128_gcm_sha256_ciphers_enabled");
        set => WithProperty("tls_rsa_with_aes128_gcm_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes256CbcSha256CiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_rsa_with_aes256_cbc_sha256_ciphers_enabled");
        set => WithProperty("tls_rsa_with_aes256_cbc_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes256CbcShaCiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_rsa_with_aes256_cbc_sha_ciphers_enabled");
        set => WithProperty("tls_rsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_gcm_sha384_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsRsaWithAes256GcmSha384CiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_rsa_with_aes256_gcm_sha384_ciphers_enabled");
        set => WithProperty("tls_rsa_with_aes256_gcm_sha384_ciphers_enabled", value);
    }

    /// <summary>
    /// The triple_des_ciphers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TripleDesCiphersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("triple_des_ciphers_enabled");
        set => WithProperty("triple_des_ciphers_enabled", value);
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
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
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
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
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
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryKey
    {
        get => GetProperty<TerraformProperty<string>>("primary_key");
        set => WithProperty("primary_key", value);
    }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformProperty<string>? SecondaryKey
    {
        get => GetProperty<TerraformProperty<string>>("secondary_key");
        set => WithProperty("secondary_key", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
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
        this.WithOutput("developer_portal_url");
        this.WithOutput("gateway_regional_url");
        this.WithOutput("gateway_url");
        this.WithOutput("management_api_url");
        this.WithOutput("portal_url");
        this.WithOutput("private_ip_addresses");
        this.WithOutput("public_ip_addresses");
        this.WithOutput("scm_url");
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ClientCertificateEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("client_certificate_enabled");
        set => this.WithProperty("client_certificate_enabled", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GatewayDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("gateway_disabled");
        set => this.WithProperty("gateway_disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The min_api_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinApiVersion
    {
        get => GetProperty<TerraformProperty<string>>("min_api_version");
        set => this.WithProperty("min_api_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notification_sender_email attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationSenderEmail
    {
        get => GetProperty<TerraformProperty<string>>("notification_sender_email");
        set => this.WithProperty("notification_sender_email", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpAddressId
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_address_id");
        set => this.WithProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherEmail is required")]
    public required TerraformProperty<string> PublisherEmail
    {
        get => GetRequiredProperty<TerraformProperty<string>>("publisher_email");
        set => this.WithProperty("publisher_email", value);
    }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherName is required")]
    public required TerraformProperty<string> PublisherName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("publisher_name");
        set => this.WithProperty("publisher_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_network_type attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkType
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_type");
        set => this.WithProperty("virtual_network_type", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for additional_location.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementAdditionalLocationBlock>? AdditionalLocation
    {
        get => GetProperty<List<AzurermApiManagementAdditionalLocationBlock>>("additional_location");
        set => this.WithProperty("additional_location", value);
    }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Certificate block(s) allowed")]
    public List<AzurermApiManagementCertificateBlock>? Certificate
    {
        get => GetProperty<List<AzurermApiManagementCertificateBlock>>("certificate");
        set => this.WithProperty("certificate", value);
    }

    /// <summary>
    /// Block for delegation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delegation block(s) allowed")]
    public List<AzurermApiManagementDelegationBlock>? Delegation
    {
        get => GetProperty<List<AzurermApiManagementDelegationBlock>>("delegation");
        set => this.WithProperty("delegation", value);
    }

    /// <summary>
    /// Block for hostname_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostnameConfiguration block(s) allowed")]
    public List<AzurermApiManagementHostnameConfigurationBlock>? HostnameConfiguration
    {
        get => GetProperty<List<AzurermApiManagementHostnameConfigurationBlock>>("hostname_configuration");
        set => this.WithProperty("hostname_configuration", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermApiManagementIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermApiManagementIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for protocols.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocols block(s) allowed")]
    public List<AzurermApiManagementProtocolsBlock>? Protocols
    {
        get => GetProperty<List<AzurermApiManagementProtocolsBlock>>("protocols");
        set => this.WithProperty("protocols", value);
    }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    public List<AzurermApiManagementSecurityBlock>? Security
    {
        get => GetProperty<List<AzurermApiManagementSecurityBlock>>("security");
        set => this.WithProperty("security", value);
    }

    /// <summary>
    /// Block for sign_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignIn block(s) allowed")]
    public List<AzurermApiManagementSignInBlock>? SignIn
    {
        get => GetProperty<List<AzurermApiManagementSignInBlock>>("sign_in");
        set => this.WithProperty("sign_in", value);
    }

    /// <summary>
    /// Block for sign_up.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignUp block(s) allowed")]
    public List<AzurermApiManagementSignUpBlock>? SignUp
    {
        get => GetProperty<List<AzurermApiManagementSignUpBlock>>("sign_up");
        set => this.WithProperty("sign_up", value);
    }

    /// <summary>
    /// Block for tenant_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TenantAccess block(s) allowed")]
    public List<AzurermApiManagementTenantAccessBlock>? TenantAccess
    {
        get => GetProperty<List<AzurermApiManagementTenantAccessBlock>>("tenant_access");
        set => this.WithProperty("tenant_access", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    public List<AzurermApiManagementVirtualNetworkConfigurationBlock>? VirtualNetworkConfiguration
    {
        get => GetProperty<List<AzurermApiManagementVirtualNetworkConfigurationBlock>>("virtual_network_configuration");
        set => this.WithProperty("virtual_network_configuration", value);
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
