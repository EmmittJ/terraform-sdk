using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for developer_portal in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainDeveloperPortalBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_certificate_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultCertificateId { get; set; } = default!;

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key_vault_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultId { get; set; } = default!;

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("negotiate_client_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_keyvault_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for gateway in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainGatewayBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificatePassword { get; set; }



    /// <summary>
    /// The default_ssl_binding attribute.
    /// </summary>
    [TerraformPropertyName("default_ssl_binding")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DefaultSslBinding { get; set; } = default!;


    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_certificate_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultCertificateId { get; set; } = default!;

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key_vault_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultId { get; set; } = default!;

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("negotiate_client_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_keyvault_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainManagementBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_certificate_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultCertificateId { get; set; } = default!;

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key_vault_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultId { get; set; } = default!;

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("negotiate_client_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_keyvault_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for portal in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainPortalBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_certificate_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultCertificateId { get; set; } = default!;

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key_vault_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultId { get; set; } = default!;

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("negotiate_client_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_keyvault_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for scm in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainScmBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformPropertyName("certificate_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_certificate_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultCertificateId { get; set; } = default!;

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key_vault_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultId { get; set; } = default!;

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("negotiate_client_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_keyvault_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementCustomDomainTimeoutsBlock
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
    public required TerraformValue<string> ApiManagementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for developer_portal.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("developer_portal")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainDeveloperPortalBlock>>? DeveloperPortal { get; set; }

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("gateway")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainGatewayBlock>>? Gateway { get; set; }

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("management")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainManagementBlock>>? Management { get; set; }

    /// <summary>
    /// Block for portal.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("portal")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainPortalBlock>>? Portal { get; set; }

    /// <summary>
    /// Block for scm.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("scm")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainScmBlock>>? Scm { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementCustomDomainTimeoutsBlock>? Timeouts { get; set; }

}
