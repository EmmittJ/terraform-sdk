using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for developer_portal in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainDeveloperPortalBlock : TerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformProperty<string>? Certificate
    {
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        set => SetProperty("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        set => SetProperty("certificate_source", value);
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateStatus
    {
        set => SetProperty("certificate_status", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformProperty<string>? Expiry
    {
        set => SetProperty("expiry", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        set => SetProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? KeyVaultId
    {
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? NegotiateClientCertificate
    {
        set => SetProperty("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslKeyvaultIdentityClientId
    {
        set => SetProperty("ssl_keyvault_identity_client_id", value);
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
/// Block type for gateway in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainGatewayBlock : TerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformProperty<string>? Certificate
    {
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        set => SetProperty("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        set => SetProperty("certificate_source", value);
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateStatus
    {
        set => SetProperty("certificate_status", value);
    }

    /// <summary>
    /// The default_ssl_binding attribute.
    /// </summary>
    public TerraformProperty<bool>? DefaultSslBinding
    {
        set => SetProperty("default_ssl_binding", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformProperty<string>? Expiry
    {
        set => SetProperty("expiry", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        set => SetProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? KeyVaultId
    {
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? NegotiateClientCertificate
    {
        set => SetProperty("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslKeyvaultIdentityClientId
    {
        set => SetProperty("ssl_keyvault_identity_client_id", value);
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
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainManagementBlock : TerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformProperty<string>? Certificate
    {
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        set => SetProperty("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        set => SetProperty("certificate_source", value);
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateStatus
    {
        set => SetProperty("certificate_status", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformProperty<string>? Expiry
    {
        set => SetProperty("expiry", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        set => SetProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? KeyVaultId
    {
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? NegotiateClientCertificate
    {
        set => SetProperty("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslKeyvaultIdentityClientId
    {
        set => SetProperty("ssl_keyvault_identity_client_id", value);
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
/// Block type for portal in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainPortalBlock : TerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformProperty<string>? Certificate
    {
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        set => SetProperty("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        set => SetProperty("certificate_source", value);
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateStatus
    {
        set => SetProperty("certificate_status", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformProperty<string>? Expiry
    {
        set => SetProperty("expiry", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        set => SetProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? KeyVaultId
    {
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? NegotiateClientCertificate
    {
        set => SetProperty("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslKeyvaultIdentityClientId
    {
        set => SetProperty("ssl_keyvault_identity_client_id", value);
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
/// Block type for scm in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainScmBlock : TerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformProperty<string>? Certificate
    {
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        set => SetProperty("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        set => SetProperty("certificate_source", value);
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateStatus
    {
        set => SetProperty("certificate_status", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformProperty<string>? Expiry
    {
        set => SetProperty("expiry", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        set => SetProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? KeyVaultId
    {
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? NegotiateClientCertificate
    {
        set => SetProperty("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslKeyvaultIdentityClientId
    {
        set => SetProperty("ssl_keyvault_identity_client_id", value);
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementCustomDomainTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_custom_domain resource.
/// </summary>
public class AzurermApiManagementCustomDomain : TerraformResource
{
    public AzurermApiManagementCustomDomain(string name) : base("azurerm_api_management_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_management_id");
        SetOutput("id");
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    public required TerraformProperty<string> ApiManagementId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_id");
        set => SetProperty("api_management_id", value);
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
    /// Block for developer_portal.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementCustomDomainDeveloperPortalBlock>? DeveloperPortal
    {
        set => SetProperty("developer_portal", value);
    }

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementCustomDomainGatewayBlock>? Gateway
    {
        set => SetProperty("gateway", value);
    }

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementCustomDomainManagementBlock>? Management
    {
        set => SetProperty("management", value);
    }

    /// <summary>
    /// Block for portal.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementCustomDomainPortalBlock>? Portal
    {
        set => SetProperty("portal", value);
    }

    /// <summary>
    /// Block for scm.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementCustomDomainScmBlock>? Scm
    {
        set => SetProperty("scm", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementCustomDomainTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
