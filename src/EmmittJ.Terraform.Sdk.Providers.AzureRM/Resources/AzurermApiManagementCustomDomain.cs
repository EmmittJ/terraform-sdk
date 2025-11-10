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
        get => GetProperty<TerraformProperty<string>>("certificate");
        set => WithProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        get => GetProperty<TerraformProperty<string>>("certificate_password");
        set => WithProperty("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        get => GetProperty<TerraformProperty<string>>("certificate_source");
        set => WithProperty("certificate_source", value);
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateStatus
    {
        get => GetProperty<TerraformProperty<string>>("certificate_status");
        set => WithProperty("certificate_status", value);
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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => WithProperty("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_certificate_id");
        set => WithProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? NegotiateClientCertificate
    {
        get => GetProperty<TerraformProperty<bool>>("negotiate_client_certificate");
        set => WithProperty("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslKeyvaultIdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("ssl_keyvault_identity_client_id");
        set => WithProperty("ssl_keyvault_identity_client_id", value);
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
        get => GetProperty<TerraformProperty<string>>("certificate");
        set => WithProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        get => GetProperty<TerraformProperty<string>>("certificate_password");
        set => WithProperty("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        get => GetProperty<TerraformProperty<string>>("certificate_source");
        set => WithProperty("certificate_source", value);
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateStatus
    {
        get => GetProperty<TerraformProperty<string>>("certificate_status");
        set => WithProperty("certificate_status", value);
    }

    /// <summary>
    /// The default_ssl_binding attribute.
    /// </summary>
    public TerraformProperty<bool>? DefaultSslBinding
    {
        get => GetProperty<TerraformProperty<bool>>("default_ssl_binding");
        set => WithProperty("default_ssl_binding", value);
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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => WithProperty("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_certificate_id");
        set => WithProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? NegotiateClientCertificate
    {
        get => GetProperty<TerraformProperty<bool>>("negotiate_client_certificate");
        set => WithProperty("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslKeyvaultIdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("ssl_keyvault_identity_client_id");
        set => WithProperty("ssl_keyvault_identity_client_id", value);
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
        get => GetProperty<TerraformProperty<string>>("certificate");
        set => WithProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        get => GetProperty<TerraformProperty<string>>("certificate_password");
        set => WithProperty("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        get => GetProperty<TerraformProperty<string>>("certificate_source");
        set => WithProperty("certificate_source", value);
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateStatus
    {
        get => GetProperty<TerraformProperty<string>>("certificate_status");
        set => WithProperty("certificate_status", value);
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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => WithProperty("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_certificate_id");
        set => WithProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? NegotiateClientCertificate
    {
        get => GetProperty<TerraformProperty<bool>>("negotiate_client_certificate");
        set => WithProperty("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslKeyvaultIdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("ssl_keyvault_identity_client_id");
        set => WithProperty("ssl_keyvault_identity_client_id", value);
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
        get => GetProperty<TerraformProperty<string>>("certificate");
        set => WithProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        get => GetProperty<TerraformProperty<string>>("certificate_password");
        set => WithProperty("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        get => GetProperty<TerraformProperty<string>>("certificate_source");
        set => WithProperty("certificate_source", value);
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateStatus
    {
        get => GetProperty<TerraformProperty<string>>("certificate_status");
        set => WithProperty("certificate_status", value);
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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => WithProperty("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_certificate_id");
        set => WithProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? NegotiateClientCertificate
    {
        get => GetProperty<TerraformProperty<bool>>("negotiate_client_certificate");
        set => WithProperty("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslKeyvaultIdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("ssl_keyvault_identity_client_id");
        set => WithProperty("ssl_keyvault_identity_client_id", value);
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
        get => GetProperty<TerraformProperty<string>>("certificate");
        set => WithProperty("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePassword
    {
        get => GetProperty<TerraformProperty<string>>("certificate_password");
        set => WithProperty("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        get => GetProperty<TerraformProperty<string>>("certificate_source");
        set => WithProperty("certificate_source", value);
    }

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateStatus
    {
        get => GetProperty<TerraformProperty<string>>("certificate_status");
        set => WithProperty("certificate_status", value);
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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => WithProperty("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_certificate_id");
        set => WithProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? NegotiateClientCertificate
    {
        get => GetProperty<TerraformProperty<bool>>("negotiate_client_certificate");
        set => WithProperty("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslKeyvaultIdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("ssl_keyvault_identity_client_id");
        set => WithProperty("ssl_keyvault_identity_client_id", value);
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
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    public required TerraformProperty<string> ApiManagementId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
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
    /// Block for developer_portal.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementCustomDomainDeveloperPortalBlock>? DeveloperPortal
    {
        get => GetProperty<List<AzurermApiManagementCustomDomainDeveloperPortalBlock>>("developer_portal");
        set => this.WithProperty("developer_portal", value);
    }

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementCustomDomainGatewayBlock>? Gateway
    {
        get => GetProperty<List<AzurermApiManagementCustomDomainGatewayBlock>>("gateway");
        set => this.WithProperty("gateway", value);
    }

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementCustomDomainManagementBlock>? Management
    {
        get => GetProperty<List<AzurermApiManagementCustomDomainManagementBlock>>("management");
        set => this.WithProperty("management", value);
    }

    /// <summary>
    /// Block for portal.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementCustomDomainPortalBlock>? Portal
    {
        get => GetProperty<List<AzurermApiManagementCustomDomainPortalBlock>>("portal");
        set => this.WithProperty("portal", value);
    }

    /// <summary>
    /// Block for scm.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementCustomDomainScmBlock>? Scm
    {
        get => GetProperty<List<AzurermApiManagementCustomDomainScmBlock>>("scm");
        set => this.WithProperty("scm", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementCustomDomainTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
