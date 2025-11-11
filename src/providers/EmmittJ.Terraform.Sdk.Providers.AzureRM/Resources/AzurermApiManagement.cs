using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_location in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementAdditionalLocationBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Capacity { get; set; } = default!;

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    [TerraformPropertyName("gateway_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GatewayDisabled { get; set; }


    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }


    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicIpAddressId { get; set; }


    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Zones { get; set; }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCertificateBlock
{
    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificatePassword { get; set; }

    /// <summary>
    /// The encoded_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncodedCertificate is required")]
    [TerraformPropertyName("encoded_certificate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EncodedCertificate { get; set; }


    /// <summary>
    /// The store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreName is required")]
    [TerraformPropertyName("store_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StoreName { get; set; }



}

/// <summary>
/// Block type for delegation in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementDelegationBlock
{
    /// <summary>
    /// The subscriptions_enabled attribute.
    /// </summary>
    [TerraformPropertyName("subscriptions_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SubscriptionsEnabled { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Url { get; set; }

    /// <summary>
    /// The user_registration_enabled attribute.
    /// </summary>
    [TerraformPropertyName("user_registration_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UserRegistrationEnabled { get; set; }

    /// <summary>
    /// The validation_key attribute.
    /// </summary>
    [TerraformPropertyName("validation_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ValidationKey { get; set; }

}

/// <summary>
/// Block type for hostname_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementHostnameConfigurationBlock
{
}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for protocols in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementProtocolsBlock
{
    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_http2")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableHttp2 { get; set; } = default!;

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http2_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Http2Enabled { get; set; } = default!;

}

/// <summary>
/// Block type for security in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementSecurityBlock
{
    /// <summary>
    /// The backend_ssl30_enabled attribute.
    /// </summary>
    [TerraformPropertyName("backend_ssl30_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> BackendSsl30Enabled { get; set; } = default!;

    /// <summary>
    /// The backend_tls10_enabled attribute.
    /// </summary>
    [TerraformPropertyName("backend_tls10_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> BackendTls10Enabled { get; set; } = default!;

    /// <summary>
    /// The backend_tls11_enabled attribute.
    /// </summary>
    [TerraformPropertyName("backend_tls11_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> BackendTls11Enabled { get; set; } = default!;

    /// <summary>
    /// The enable_backend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_backend_ssl30")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableBackendSsl30 { get; set; } = default!;

    /// <summary>
    /// The enable_backend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_backend_tls10")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableBackendTls10 { get; set; } = default!;

    /// <summary>
    /// The enable_backend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_backend_tls11")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableBackendTls11 { get; set; } = default!;

    /// <summary>
    /// The enable_frontend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_frontend_ssl30")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableFrontendSsl30 { get; set; } = default!;

    /// <summary>
    /// The enable_frontend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_frontend_tls10")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableFrontendTls10 { get; set; } = default!;

    /// <summary>
    /// The enable_frontend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_frontend_tls11")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableFrontendTls11 { get; set; } = default!;

    /// <summary>
    /// The frontend_ssl30_enabled attribute.
    /// </summary>
    [TerraformPropertyName("frontend_ssl30_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> FrontendSsl30Enabled { get; set; } = default!;

    /// <summary>
    /// The frontend_tls10_enabled attribute.
    /// </summary>
    [TerraformPropertyName("frontend_tls10_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> FrontendTls10Enabled { get; set; } = default!;

    /// <summary>
    /// The frontend_tls11_enabled attribute.
    /// </summary>
    [TerraformPropertyName("frontend_tls11_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> FrontendTls11Enabled { get; set; } = default!;

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsEcdheRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsEcdheRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_rsa_with_aes128_cbc_sha256_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsRsaWithAes128CbcSha256CiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_rsa_with_aes128_cbc_sha_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes128_gcm_sha256_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_rsa_with_aes128_gcm_sha256_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsRsaWithAes128GcmSha256CiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_rsa_with_aes256_cbc_sha256_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsRsaWithAes256CbcSha256CiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_rsa_with_aes256_cbc_sha_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes256_gcm_sha384_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_rsa_with_aes256_gcm_sha384_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsRsaWithAes256GcmSha384CiphersEnabled { get; set; }

    /// <summary>
    /// The triple_des_ciphers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("triple_des_ciphers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TripleDesCiphersEnabled { get; set; }

}

/// <summary>
/// Block type for sign_in in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementSignInBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for sign_up in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementSignUpBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for tenant_access in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementTenantAccessBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for virtual_network_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementVirtualNetworkConfigurationBlock
{
    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubnetId { get; set; }

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
    [TerraformPropertyName("client_certificate_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    [TerraformPropertyName("gateway_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GatewayDisabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The min_api_version attribute.
    /// </summary>
    [TerraformPropertyName("min_api_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinApiVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_sender_email attribute.
    /// </summary>
    [TerraformPropertyName("notification_sender_email")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NotificationSenderEmail { get; set; } = default!;

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherEmail is required")]
    [TerraformPropertyName("publisher_email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PublisherEmail { get; set; }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherName is required")]
    [TerraformPropertyName("publisher_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PublisherName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformPropertyName("sku_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_network_type attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VirtualNetworkType { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for additional_location.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("additional_location")]
    public TerraformList<TerraformBlock<AzurermApiManagementAdditionalLocationBlock>>? AdditionalLocation { get; set; }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Certificate block(s) allowed")]
    [TerraformPropertyName("certificate")]
    public TerraformList<TerraformBlock<AzurermApiManagementCertificateBlock>>? Certificate { get; set; }

    /// <summary>
    /// Block for delegation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delegation block(s) allowed")]
    [TerraformPropertyName("delegation")]
    public TerraformList<TerraformBlock<AzurermApiManagementDelegationBlock>>? Delegation { get; set; }

    /// <summary>
    /// Block for hostname_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostnameConfiguration block(s) allowed")]
    [TerraformPropertyName("hostname_configuration")]
    public TerraformList<TerraformBlock<AzurermApiManagementHostnameConfigurationBlock>>? HostnameConfiguration { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermApiManagementIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for protocols.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocols block(s) allowed")]
    [TerraformPropertyName("protocols")]
    public TerraformList<TerraformBlock<AzurermApiManagementProtocolsBlock>>? Protocols { get; set; }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    [TerraformPropertyName("security")]
    public TerraformList<TerraformBlock<AzurermApiManagementSecurityBlock>>? Security { get; set; }

    /// <summary>
    /// Block for sign_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignIn block(s) allowed")]
    [TerraformPropertyName("sign_in")]
    public TerraformList<TerraformBlock<AzurermApiManagementSignInBlock>>? SignIn { get; set; }

    /// <summary>
    /// Block for sign_up.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignUp block(s) allowed")]
    [TerraformPropertyName("sign_up")]
    public TerraformList<TerraformBlock<AzurermApiManagementSignUpBlock>>? SignUp { get; set; }

    /// <summary>
    /// Block for tenant_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TenantAccess block(s) allowed")]
    [TerraformPropertyName("tenant_access")]
    public TerraformList<TerraformBlock<AzurermApiManagementTenantAccessBlock>>? TenantAccess { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for virtual_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("virtual_network_configuration")]
    public TerraformList<TerraformBlock<AzurermApiManagementVirtualNetworkConfigurationBlock>>? VirtualNetworkConfiguration { get; set; }

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    [TerraformPropertyName("developer_portal_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeveloperPortalUrl => new TerraformReference(this, "developer_portal_url");

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    [TerraformPropertyName("gateway_regional_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayRegionalUrl => new TerraformReference(this, "gateway_regional_url");

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    [TerraformPropertyName("gateway_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayUrl => new TerraformReference(this, "gateway_url");

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    [TerraformPropertyName("management_api_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagementApiUrl => new TerraformReference(this, "management_api_url");

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    [TerraformPropertyName("portal_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PortalUrl => new TerraformReference(this, "portal_url");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PrivateIpAddresses => new TerraformReference(this, "private_ip_addresses");

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PublicIpAddresses => new TerraformReference(this, "public_ip_addresses");

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    [TerraformPropertyName("scm_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ScmUrl => new TerraformReference(this, "scm_url");

}
