using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for developer_portal in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCustomDomainDeveloperPortalBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultCertificateId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformProperty("negotiate_client_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("ssl_keyvault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for gateway in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCustomDomainGatewayBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificatePassword { get; set; }



    /// <summary>
    /// The default_ssl_binding attribute.
    /// </summary>
    [TerraformProperty("default_ssl_binding")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DefaultSslBinding { get; set; }


    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultCertificateId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformProperty("negotiate_client_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("ssl_keyvault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCustomDomainManagementBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultCertificateId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformProperty("negotiate_client_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("ssl_keyvault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for portal in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCustomDomainPortalBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultCertificateId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformProperty("negotiate_client_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("ssl_keyvault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for scm in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCustomDomainScmBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultCertificateId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformProperty("negotiate_client_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("ssl_keyvault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementCustomDomainTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_api_management_custom_domain resource.
/// </summary>
public partial class AzurermApiManagementCustomDomain : TerraformResource
{
    public AzurermApiManagementCustomDomain(string name) : base("azurerm_api_management_custom_domain", name)
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    [TerraformProperty("api_management_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiManagementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for developer_portal.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("developer_portal")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainDeveloperPortalBlock>>? DeveloperPortal { get; set; }

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("gateway")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainGatewayBlock>>? Gateway { get; set; }

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("management")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainManagementBlock>>? Management { get; set; }

    /// <summary>
    /// Block for portal.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("portal")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainPortalBlock>>? Portal { get; set; }

    /// <summary>
    /// Block for scm.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("scm")]
    public TerraformList<TerraformBlock<AzurermApiManagementCustomDomainScmBlock>>? Scm { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermApiManagementCustomDomainTimeoutsBlock>? Timeouts { get; set; }

}
