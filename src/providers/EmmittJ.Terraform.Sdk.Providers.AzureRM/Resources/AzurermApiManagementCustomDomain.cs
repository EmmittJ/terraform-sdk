using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for developer_portal in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCustomDomainDeveloperPortalBlock() : TerraformBlock("developer_portal")
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultCertificateId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformProperty("negotiate_client_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("ssl_keyvault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for gateway in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCustomDomainGatewayBlock() : TerraformBlock("gateway")
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificatePassword { get; set; }



    /// <summary>
    /// The default_ssl_binding attribute.
    /// </summary>
    [TerraformProperty("default_ssl_binding")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DefaultSslBinding { get; set; }


    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultCertificateId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformProperty("negotiate_client_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("ssl_keyvault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCustomDomainManagementBlock() : TerraformBlock("management")
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultCertificateId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformProperty("negotiate_client_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("ssl_keyvault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for portal in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCustomDomainPortalBlock() : TerraformBlock("portal")
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultCertificateId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformProperty("negotiate_client_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("ssl_keyvault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for scm in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementCustomDomainScmBlock() : TerraformBlock("scm")
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    [TerraformProperty("certificate_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificatePassword { get; set; }




    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultCertificateId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformProperty("negotiate_client_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NegotiateClientCertificate { get; set; }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("ssl_keyvault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslKeyvaultIdentityClientId { get; set; }



}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementCustomDomainTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

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
    public required partial TerraformValue<string> ApiManagementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for developer_portal.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("developer_portal")]
    public TerraformList<AzurermApiManagementCustomDomainDeveloperPortalBlock> DeveloperPortal { get; set; } = new();

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("gateway")]
    public TerraformList<AzurermApiManagementCustomDomainGatewayBlock> Gateway { get; set; } = new();

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("management")]
    public TerraformList<AzurermApiManagementCustomDomainManagementBlock> Management { get; set; } = new();

    /// <summary>
    /// Block for portal.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("portal")]
    public TerraformList<AzurermApiManagementCustomDomainPortalBlock> Portal { get; set; } = new();

    /// <summary>
    /// Block for scm.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("scm")]
    public TerraformList<AzurermApiManagementCustomDomainScmBlock> Scm { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermApiManagementCustomDomainTimeoutsBlock Timeouts { get; set; } = new();

}
