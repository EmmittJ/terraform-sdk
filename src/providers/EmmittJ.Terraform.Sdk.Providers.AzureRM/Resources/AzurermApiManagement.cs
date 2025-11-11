using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_location in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementAdditionalLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    [TerraformProperty("gateway_disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GatewayDisabled { get; set; }


    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }


    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformProperty("public_ip_address_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PublicIpAddressId { get; set; }


    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Zones { get; set; }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCertificateBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificatePassword { get; set; }

    /// <summary>
    /// The encoded_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncodedCertificate is required")]
    [TerraformProperty("encoded_certificate")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EncodedCertificate { get; set; }


    /// <summary>
    /// The store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreName is required")]
    [TerraformProperty("store_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StoreName { get; set; }



}

/// <summary>
/// Block type for delegation in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementDelegationBlock : TerraformBlockBase
{
    /// <summary>
    /// The subscriptions_enabled attribute.
    /// </summary>
    [TerraformProperty("subscriptions_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SubscriptionsEnabled { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Url { get; set; }

    /// <summary>
    /// The user_registration_enabled attribute.
    /// </summary>
    [TerraformProperty("user_registration_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UserRegistrationEnabled { get; set; }

    /// <summary>
    /// The validation_key attribute.
    /// </summary>
    [TerraformProperty("validation_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ValidationKey { get; set; }

}

/// <summary>
/// Block type for hostname_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementHostnameConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for protocols in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementProtocolsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_http2")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableHttp2 { get; set; }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformProperty("http2_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Http2Enabled { get; set; }

}

/// <summary>
/// Block type for security in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementSecurityBlock : TerraformBlockBase
{
    /// <summary>
    /// The backend_ssl30_enabled attribute.
    /// </summary>
    [TerraformProperty("backend_ssl30_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> BackendSsl30Enabled { get; set; }

    /// <summary>
    /// The backend_tls10_enabled attribute.
    /// </summary>
    [TerraformProperty("backend_tls10_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> BackendTls10Enabled { get; set; }

    /// <summary>
    /// The backend_tls11_enabled attribute.
    /// </summary>
    [TerraformProperty("backend_tls11_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> BackendTls11Enabled { get; set; }

    /// <summary>
    /// The enable_backend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_backend_ssl30")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableBackendSsl30 { get; set; }

    /// <summary>
    /// The enable_backend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_backend_tls10")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableBackendTls10 { get; set; }

    /// <summary>
    /// The enable_backend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_backend_tls11")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableBackendTls11 { get; set; }

    /// <summary>
    /// The enable_frontend_ssl30 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_frontend_ssl30")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableFrontendSsl30 { get; set; }

    /// <summary>
    /// The enable_frontend_tls10 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_frontend_tls10")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableFrontendTls10 { get; set; }

    /// <summary>
    /// The enable_frontend_tls11 attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_frontend_tls11")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableFrontendTls11 { get; set; }

    /// <summary>
    /// The frontend_ssl30_enabled attribute.
    /// </summary>
    [TerraformProperty("frontend_ssl30_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> FrontendSsl30Enabled { get; set; }

    /// <summary>
    /// The frontend_tls10_enabled attribute.
    /// </summary>
    [TerraformProperty("frontend_tls10_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> FrontendTls10Enabled { get; set; }

    /// <summary>
    /// The frontend_tls11_enabled attribute.
    /// </summary>
    [TerraformProperty("frontend_tls11_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> FrontendTls11Enabled { get; set; }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_ecdhe_ecdsa_with_aes128_cbc_sha_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_ecdhe_ecdsa_with_aes256_cbc_sha_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_ecdhe_rsa_with_aes128_cbc_sha_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsEcdheRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_ecdhe_rsa_with_aes256_cbc_sha_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsEcdheRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_rsa_with_aes128_cbc_sha256_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsRsaWithAes128CbcSha256CiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes128_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_rsa_with_aes128_cbc_sha_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes128_gcm_sha256_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_rsa_with_aes128_gcm_sha256_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsRsaWithAes128GcmSha256CiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha256_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_rsa_with_aes256_cbc_sha256_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsRsaWithAes256CbcSha256CiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes256_cbc_sha_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_rsa_with_aes256_cbc_sha_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>
    /// The tls_rsa_with_aes256_gcm_sha384_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_rsa_with_aes256_gcm_sha384_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsRsaWithAes256GcmSha384CiphersEnabled { get; set; }

    /// <summary>
    /// The triple_des_ciphers_enabled attribute.
    /// </summary>
    [TerraformProperty("triple_des_ciphers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TripleDesCiphersEnabled { get; set; }

}

/// <summary>
/// Block type for sign_in in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementSignInBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for sign_up in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementSignUpBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for tenant_access in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementTenantAccessBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for virtual_network_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementVirtualNetworkConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Manages a azurerm_api_management resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermApiManagement : TerraformResource
{
    public AzurermApiManagement(string name) : base("azurerm_api_management", name)
    {
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    [TerraformProperty("client_certificate_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    [TerraformProperty("gateway_disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GatewayDisabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The min_api_version attribute.
    /// </summary>
    [TerraformProperty("min_api_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MinApiVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_sender_email attribute.
    /// </summary>
    [TerraformProperty("notification_sender_email")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NotificationSenderEmail { get; set; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformProperty("public_ip_address_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherEmail is required")]
    [TerraformProperty("publisher_email")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PublisherEmail { get; set; }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherName is required")]
    [TerraformProperty("publisher_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PublisherName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_network_type attribute.
    /// </summary>
    [TerraformProperty("virtual_network_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VirtualNetworkType { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for additional_location.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("additional_location")]
    public TerraformList<TerraformBlock<AzurermApiManagementAdditionalLocationBlock>>? AdditionalLocation { get; set; }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Certificate block(s) allowed")]
    [TerraformProperty("certificate")]
    public TerraformList<TerraformBlock<AzurermApiManagementCertificateBlock>>? Certificate { get; set; }

    /// <summary>
    /// Block for delegation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delegation block(s) allowed")]
    [TerraformProperty("delegation")]
    public TerraformList<TerraformBlock<AzurermApiManagementDelegationBlock>>? Delegation { get; set; }

    /// <summary>
    /// Block for hostname_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostnameConfiguration block(s) allowed")]
    [TerraformProperty("hostname_configuration")]
    public TerraformList<TerraformBlock<AzurermApiManagementHostnameConfigurationBlock>>? HostnameConfiguration { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermApiManagementIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for protocols.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocols block(s) allowed")]
    [TerraformProperty("protocols")]
    public TerraformList<TerraformBlock<AzurermApiManagementProtocolsBlock>>? Protocols { get; set; }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    [TerraformProperty("security")]
    public TerraformList<TerraformBlock<AzurermApiManagementSecurityBlock>>? Security { get; set; }

    /// <summary>
    /// Block for sign_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignIn block(s) allowed")]
    [TerraformProperty("sign_in")]
    public TerraformList<TerraformBlock<AzurermApiManagementSignInBlock>>? SignIn { get; set; }

    /// <summary>
    /// Block for sign_up.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignUp block(s) allowed")]
    [TerraformProperty("sign_up")]
    public TerraformList<TerraformBlock<AzurermApiManagementSignUpBlock>>? SignUp { get; set; }

    /// <summary>
    /// Block for tenant_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TenantAccess block(s) allowed")]
    [TerraformProperty("tenant_access")]
    public TerraformList<TerraformBlock<AzurermApiManagementTenantAccessBlock>>? TenantAccess { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermApiManagementTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for virtual_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    [TerraformProperty("virtual_network_configuration")]
    public TerraformList<TerraformBlock<AzurermApiManagementVirtualNetworkConfigurationBlock>>? VirtualNetworkConfiguration { get; set; }

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    [TerraformProperty("developer_portal_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeveloperPortalUrl { get; }

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    [TerraformProperty("gateway_regional_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GatewayRegionalUrl { get; }

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    [TerraformProperty("gateway_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GatewayUrl { get; }

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    [TerraformProperty("management_api_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ManagementApiUrl { get; }

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    [TerraformProperty("portal_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PortalUrl { get; }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("private_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> PrivateIpAddresses { get; }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("public_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> PublicIpAddresses { get; }

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    [TerraformProperty("scm_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ScmUrl { get; }

}
