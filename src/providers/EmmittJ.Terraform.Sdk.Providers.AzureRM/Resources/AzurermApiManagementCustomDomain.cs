using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for developer_portal in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainDeveloperPortalBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificatePassword { get; set; }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    [TerraformPropertyName("certificate_source")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateSource => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    [TerraformPropertyName("certificate_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformPropertyName("expiry")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Expiry => new TerraformReferenceProperty<TerraformProperty<string>>("", "expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_certificate_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultCertificateId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_vault_certificate_id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key_vault_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_vault_id");

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("negotiate_client_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_keyvault_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subject => new TerraformReferenceProperty<TerraformProperty<string>>("", "subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>("", "thumbprint");

}

/// <summary>
/// Block type for gateway in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainGatewayBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificatePassword { get; set; }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    [TerraformPropertyName("certificate_source")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateSource => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    [TerraformPropertyName("certificate_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_status");

    /// <summary>
    /// The default_ssl_binding attribute.
    /// </summary>
    [TerraformPropertyName("default_ssl_binding")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DefaultSslBinding { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "default_ssl_binding");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformPropertyName("expiry")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Expiry => new TerraformReferenceProperty<TerraformProperty<string>>("", "expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_certificate_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultCertificateId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_vault_certificate_id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key_vault_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_vault_id");

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("negotiate_client_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_keyvault_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subject => new TerraformReferenceProperty<TerraformProperty<string>>("", "subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>("", "thumbprint");

}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainManagementBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificatePassword { get; set; }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    [TerraformPropertyName("certificate_source")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateSource => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    [TerraformPropertyName("certificate_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformPropertyName("expiry")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Expiry => new TerraformReferenceProperty<TerraformProperty<string>>("", "expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_certificate_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultCertificateId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_vault_certificate_id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key_vault_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_vault_id");

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("negotiate_client_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_keyvault_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subject => new TerraformReferenceProperty<TerraformProperty<string>>("", "subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>("", "thumbprint");

}

/// <summary>
/// Block type for portal in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainPortalBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificatePassword { get; set; }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    [TerraformPropertyName("certificate_source")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateSource => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    [TerraformPropertyName("certificate_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformPropertyName("expiry")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Expiry => new TerraformReferenceProperty<TerraformProperty<string>>("", "expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_certificate_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultCertificateId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_vault_certificate_id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key_vault_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_vault_id");

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("negotiate_client_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_keyvault_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subject => new TerraformReferenceProperty<TerraformProperty<string>>("", "subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>("", "thumbprint");

}

/// <summary>
/// Block type for scm in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainScmBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificatePassword { get; set; }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    [TerraformPropertyName("certificate_source")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateSource => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    [TerraformPropertyName("certificate_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformPropertyName("expiry")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Expiry => new TerraformReferenceProperty<TerraformProperty<string>>("", "expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_certificate_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultCertificateId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_vault_certificate_id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key_vault_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "key_vault_id");

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("negotiate_client_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_keyvault_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subject => new TerraformReferenceProperty<TerraformProperty<string>>("", "subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>("", "thumbprint");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementCustomDomainTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_api_management_custom_domain resource.
/// </summary>
public class AzurermApiManagementCustomDomain : TerraformResource
{
    public AzurermApiManagementCustomDomain(string name) : base("azurerm_api_management_custom_domain", name)
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    [TerraformPropertyName("api_management_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiManagementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for developer_portal.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("developer_portal")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainDeveloperPortalBlock>>? DeveloperPortal { get; set; } = new();

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("gateway")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainGatewayBlock>>? Gateway { get; set; } = new();

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("management")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainManagementBlock>>? Management { get; set; } = new();

    /// <summary>
    /// Block for portal.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("portal")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainPortalBlock>>? Portal { get; set; } = new();

    /// <summary>
    /// Block for scm.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("scm")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainScmBlock>>? Scm { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementCustomDomainTimeoutsBlock>? Timeouts { get; set; } = new();

}
