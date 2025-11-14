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
/// Block type for additional_location in .
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
    [TerraformArgument("capacity")]
    public TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    [TerraformArgument("gateway_disabled")]
    public TerraformValue<bool>? GatewayDisabled
    {
        get => new TerraformReference<bool>(this, "gateway_disabled");
        set => SetArgument("gateway_disabled", value);
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
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformArgument("public_ip_address_id")]
    public TerraformValue<string>? PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }


    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

}

/// <summary>
/// Block type for certificate in .
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
    [TerraformArgument("certificate_password")]
    public TerraformValue<string>? CertificatePassword
    {
        get => new TerraformReference<string>(this, "certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The encoded_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncodedCertificate is required")]
    [TerraformArgument("encoded_certificate")]
    public required TerraformValue<string> EncodedCertificate
    {
        get => new TerraformReference<string>(this, "encoded_certificate");
        set => SetArgument("encoded_certificate", value);
    }


    /// <summary>
    /// The store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreName is required")]
    [TerraformArgument("store_name")]
    public required TerraformValue<string> StoreName
    {
        get => new TerraformReference<string>(this, "store_name");
        set => SetArgument("store_name", value);
    }



}

/// <summary>
/// Block type for delegation in .
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
    [TerraformArgument("subscriptions_enabled")]
    public TerraformValue<bool>? SubscriptionsEnabled
    {
        get => new TerraformReference<bool>(this, "subscriptions_enabled");
        set => SetArgument("subscriptions_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string>? Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The user_registration_enabled attribute.
    /// </summary>
    [TerraformArgument("user_registration_enabled")]
    public TerraformValue<bool>? UserRegistrationEnabled
    {
        get => new TerraformReference<bool>(this, "user_registration_enabled");
        set => SetArgument("user_registration_enabled", value);
    }

    /// <summary>
    /// The validation_key attribute.
    /// </summary>
    [TerraformArgument("validation_key")]
    public TerraformValue<string>? ValidationKey
    {
        get => new TerraformReference<string>(this, "validation_key");
        set => SetArgument("validation_key", value);
    }

}

/// <summary>
/// Block type for hostname_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementHostnameConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hostname_configuration";

}

/// <summary>
/// Block type for identity in .
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
/// Block type for protocols in .
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
    [TerraformArgument("enable_http2")]
    public TerraformValue<bool> EnableHttp2
    {
        get => new TerraformReference<bool>(this, "enable_http2");
        set => SetArgument("enable_http2", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformArgument("http2_enabled")]
    public TerraformValue<bool> Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
        set => SetArgument("http2_enabled", value);
    }

}

/// <summary>
/// Block type for security in .
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
    [TerraformArgument("backend_ssl30_enabled")]
    public TerraformValue<bool> BackendSsl30Enabled
    {
        get => new TerraformReference<bool>(this, "backend_ssl30_enabled");
        set => SetArgument("backend_ssl30_enabled", value);
    }

    /// <summary>
    /// The backend_tls10_enabled attribute.
    /// </summary>
    [TerraformArgument("backend_tls10_enabled")]
    public TerraformValue<bool> BackendTls10Enabled
    {
        get => new TerraformReference<bool>(this, "backend_tls10_enabled");
        set => SetArgument("backend_tls10_enabled", value);
    }

    /// <summary>
    /// The backend_tls11_enabled attribute.
    /// </summary>
    [TerraformArgument("backend_tls11_enabled")]
    public TerraformValue<bool> BackendTls11Enabled
    {
        get => new TerraformReference<bool>(this, "backend_tls11_enabled");
        set => SetArgument("backend_tls11_enabled", value);
    }

    /// <summary>
    /// The enable_backend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("enable_backend_ssl30")]
    public TerraformValue<bool> EnableBackendSsl30
    {
        get => new TerraformReference<bool>(this, "enable_backend_ssl30");
        set => SetArgument("enable_backend_ssl30", value);
    }

    /// <summary>
    /// The enable_backend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("enable_backend_tls10")]
    public TerraformValue<bool> EnableBackendTls10
    {
        get => new TerraformReference<bool>(this, "enable_backend_tls10");
        set => SetArgument("enable_backend_tls10", value);
    }

    /// <summary>
    /// The enable_backend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("enable_backend_tls11")]
    public TerraformValue<bool> EnableBackendTls11
    {
        get => new TerraformReference<bool>(this, "enable_backend_tls11");
        set => SetArgument("enable_backend_tls11", value);
    }

    /// <summary>
    /// The enable_frontend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("enable_frontend_ssl30")]
    public TerraformValue<bool> EnableFrontendSsl30
    {
        get => new TerraformReference<bool>(this, "enable_frontend_ssl30");
        set => SetArgument("enable_frontend_ssl30", value);
    }

    /// <summary>
    /// The enable_frontend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("enable_frontend_tls10")]
    public TerraformValue<bool> EnableFrontendTls10
    {
        get => new TerraformReference<bool>(this, "enable_frontend_tls10");
        set => SetArgument("enable_frontend_tls10", value);
    }

    /// <summary>
    /// The enable_frontend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("enable_frontend_tls11")]
    public TerraformValue<bool> EnableFrontendTls11
    {
        get => new TerraformReference<bool>(this, "enable_frontend_tls11");
        set => SetArgument("enable_frontend_tls11", value);
    }

    /// <summary>
    /// The frontend_ssl30_enabled attribute.
    /// </summary>
    [TerraformArgument("frontend_ssl30_enabled")]
    public TerraformValue<bool> FrontendSsl30Enabled
    {
        get => new TerraformReference<bool>(this, "frontend_ssl30_enabled");
        set => SetArgument("frontend_ssl30_enabled", value);
    }

    /// <summary>
    /// The frontend_tls10_enabled attribute.
    /// </summary>
    [TerraformArgument("frontend_tls10_enabled")]
    public TerraformValue<bool> FrontendTls10Enabled
    {
        get => new TerraformReference<bool>(this, "frontend_tls10_enabled");
        set => SetArgument("frontend_tls10_enabled", value);
    }

    /// <summary>
    /// The frontend_tls11_enabled attribute.
    /// </summary>
    [TerraformArgument("frontend_tls11_enabled")]
    public TerraformValue<bool> FrontendTls11Enabled
    {
        get => new TerraformReference<bool>(this, "frontend_tls11_enabled");
        set => SetArgument("frontend_tls11_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled")]
    public TerraformValue<bool>? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled")]
    public TerraformValue<bool>? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled")]
    public TerraformValue<bool>? TlsEcdheRsaWithAes128CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled")]
    public TerraformValue<bool>? TlsEcdheRsaWithAes256CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_rsa_with_aes128_cbc_sha256_ciphers_enabled")]
    public TerraformValue<bool>? TlsRsaWithAes128CbcSha256CiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes128_cbc_sha256_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes128_cbc_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_rsa_with_aes128_cbc_sha_ciphers_enabled")]
    public TerraformValue<bool>? TlsRsaWithAes128CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes128_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes128_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes128_gcm_sha256_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_rsa_with_aes128_gcm_sha256_ciphers_enabled")]
    public TerraformValue<bool>? TlsRsaWithAes128GcmSha256CiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes128_gcm_sha256_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes128_gcm_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_rsa_with_aes256_cbc_sha256_ciphers_enabled")]
    public TerraformValue<bool>? TlsRsaWithAes256CbcSha256CiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes256_cbc_sha256_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes256_cbc_sha256_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_rsa_with_aes256_cbc_sha_ciphers_enabled")]
    public TerraformValue<bool>? TlsRsaWithAes256CbcShaCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes256_cbc_sha_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes256_cbc_sha_ciphers_enabled", value);
    }

    /// <summary>
    /// The tls_rsa_with_aes256_gcm_sha384_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_rsa_with_aes256_gcm_sha384_ciphers_enabled")]
    public TerraformValue<bool>? TlsRsaWithAes256GcmSha384CiphersEnabled
    {
        get => new TerraformReference<bool>(this, "tls_rsa_with_aes256_gcm_sha384_ciphers_enabled");
        set => SetArgument("tls_rsa_with_aes256_gcm_sha384_ciphers_enabled", value);
    }

    /// <summary>
    /// The triple_des_ciphers_enabled attribute.
    /// </summary>
    [TerraformArgument("triple_des_ciphers_enabled")]
    public TerraformValue<bool>? TripleDesCiphersEnabled
    {
        get => new TerraformReference<bool>(this, "triple_des_ciphers_enabled");
        set => SetArgument("triple_des_ciphers_enabled", value);
    }

}

/// <summary>
/// Block type for sign_in in .
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
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for sign_up in .
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
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for tenant_access in .
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
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }




}

/// <summary>
/// Block type for timeouts in .
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
/// Block type for virtual_network_configuration in .
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
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    [TerraformArgument("client_certificate_enabled")]
    public TerraformValue<bool>? ClientCertificateEnabled
    {
        get => new TerraformReference<bool>(this, "client_certificate_enabled");
        set => SetArgument("client_certificate_enabled", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    [TerraformArgument("gateway_disabled")]
    public TerraformValue<bool>? GatewayDisabled
    {
        get => new TerraformReference<bool>(this, "gateway_disabled");
        set => SetArgument("gateway_disabled", value);
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
    /// The min_api_version attribute.
    /// </summary>
    [TerraformArgument("min_api_version")]
    public TerraformValue<string>? MinApiVersion
    {
        get => new TerraformReference<string>(this, "min_api_version");
        set => SetArgument("min_api_version", value);
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
    /// The notification_sender_email attribute.
    /// </summary>
    [TerraformArgument("notification_sender_email")]
    public TerraformValue<string> NotificationSenderEmail
    {
        get => new TerraformReference<string>(this, "notification_sender_email");
        set => SetArgument("notification_sender_email", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformArgument("public_ip_address_id")]
    public TerraformValue<string>? PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherEmail is required")]
    [TerraformArgument("publisher_email")]
    public required TerraformValue<string> PublisherEmail
    {
        get => new TerraformReference<string>(this, "publisher_email");
        set => SetArgument("publisher_email", value);
    }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherName is required")]
    [TerraformArgument("publisher_name")]
    public required TerraformValue<string> PublisherName
    {
        get => new TerraformReference<string>(this, "publisher_name");
        set => SetArgument("publisher_name", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformArgument("sku_name")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
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
    /// The virtual_network_type attribute.
    /// </summary>
    [TerraformArgument("virtual_network_type")]
    public TerraformValue<string>? VirtualNetworkType
    {
        get => new TerraformReference<string>(this, "virtual_network_type");
        set => SetArgument("virtual_network_type", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for additional_location.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("additional_location")]
    public TerraformList<AzurermApiManagementAdditionalLocationBlock> AdditionalLocation { get; set; } = new();

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Certificate block(s) allowed")]
    [TerraformArgument("certificate")]
    public TerraformList<AzurermApiManagementCertificateBlock> Certificate { get; set; } = new();

    /// <summary>
    /// Block for delegation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delegation block(s) allowed")]
    [TerraformArgument("delegation")]
    public TerraformList<AzurermApiManagementDelegationBlock> Delegation { get; set; } = new();

    /// <summary>
    /// Block for hostname_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostnameConfiguration block(s) allowed")]
    [TerraformArgument("hostname_configuration")]
    public TerraformList<AzurermApiManagementHostnameConfigurationBlock> HostnameConfiguration { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermApiManagementIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for protocols.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocols block(s) allowed")]
    [TerraformArgument("protocols")]
    public TerraformList<AzurermApiManagementProtocolsBlock> Protocols { get; set; } = new();

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    [TerraformArgument("security")]
    public TerraformList<AzurermApiManagementSecurityBlock> Security { get; set; } = new();

    /// <summary>
    /// Block for sign_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignIn block(s) allowed")]
    [TerraformArgument("sign_in")]
    public TerraformList<AzurermApiManagementSignInBlock> SignIn { get; set; } = new();

    /// <summary>
    /// Block for sign_up.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignUp block(s) allowed")]
    [TerraformArgument("sign_up")]
    public TerraformList<AzurermApiManagementSignUpBlock> SignUp { get; set; } = new();

    /// <summary>
    /// Block for tenant_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TenantAccess block(s) allowed")]
    [TerraformArgument("tenant_access")]
    public TerraformList<AzurermApiManagementTenantAccessBlock> TenantAccess { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    [TerraformArgument("virtual_network_configuration")]
    public TerraformList<AzurermApiManagementVirtualNetworkConfigurationBlock> VirtualNetworkConfiguration { get; set; } = new();

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    [TerraformArgument("developer_portal_url")]
    public TerraformValue<string> DeveloperPortalUrl
    {
        get => new TerraformReference<string>(this, "developer_portal_url");
    }

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    [TerraformArgument("gateway_regional_url")]
    public TerraformValue<string> GatewayRegionalUrl
    {
        get => new TerraformReference<string>(this, "gateway_regional_url");
    }

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    [TerraformArgument("gateway_url")]
    public TerraformValue<string> GatewayUrl
    {
        get => new TerraformReference<string>(this, "gateway_url");
    }

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    [TerraformArgument("management_api_url")]
    public TerraformValue<string> ManagementApiUrl
    {
        get => new TerraformReference<string>(this, "management_api_url");
    }

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    [TerraformArgument("portal_url")]
    public TerraformValue<string> PortalUrl
    {
        get => new TerraformReference<string>(this, "portal_url");
    }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("private_ip_addresses")]
    public TerraformList<string> PrivateIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("public_ip_addresses")]
    public TerraformList<string> PublicIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    [TerraformArgument("scm_url")]
    public TerraformValue<string> ScmUrl
    {
        get => new TerraformReference<string>(this, "scm_url");
    }

}
