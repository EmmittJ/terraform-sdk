using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for developer_portal in AzurermApiManagementCustomDomain.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainDeveloperPortalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "developer_portal";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
        => AsReference("certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
        => AsReference("certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_certificate_id") ?? AsReference("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id") ?? AsReference("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => GetArgument<TerraformValue<bool>>("negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

}


/// <summary>
/// Block type for gateway in AzurermApiManagementCustomDomain.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainGatewayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gateway";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
        => AsReference("certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
        => AsReference("certificate_status");

    /// <summary>
    /// The default_ssl_binding attribute.
    /// </summary>
    public TerraformValue<bool> DefaultSslBinding
    {
        get => GetArgument<TerraformValue<bool>>("default_ssl_binding") ?? AsReference("default_ssl_binding");
        set => SetArgument("default_ssl_binding", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_certificate_id") ?? AsReference("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id") ?? AsReference("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => GetArgument<TerraformValue<bool>>("negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

}


/// <summary>
/// Block type for management in AzurermApiManagementCustomDomain.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
        => AsReference("certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
        => AsReference("certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_certificate_id") ?? AsReference("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id") ?? AsReference("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => GetArgument<TerraformValue<bool>>("negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

}


/// <summary>
/// Block type for portal in AzurermApiManagementCustomDomain.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainPortalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "portal";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
        => AsReference("certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
        => AsReference("certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_certificate_id") ?? AsReference("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id") ?? AsReference("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => GetArgument<TerraformValue<bool>>("negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

}


/// <summary>
/// Block type for scm in AzurermApiManagementCustomDomain.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementCustomDomainScmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scm";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string> CertificateSource
        => AsReference("certificate_source");

    /// <summary>
    /// The certificate_status attribute.
    /// </summary>
    public TerraformValue<string> CertificateStatus
        => AsReference("certificate_status");

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string> Expiry
        => AsReference("expiry");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_certificate_id") ?? AsReference("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id") ?? AsReference("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => GetArgument<TerraformValue<bool>>("negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

}


/// <summary>
/// Block type for timeouts in AzurermApiManagementCustomDomain.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementCustomDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management_custom_domain Terraform resource.
/// Manages a azurerm_api_management_custom_domain resource.
/// </summary>
public partial class AzurermApiManagementCustomDomain(string name) : TerraformResource("azurerm_api_management_custom_domain", name)
{
    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    public required TerraformValue<string> ApiManagementId
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_management_id");
        set => SetArgument("api_management_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// DeveloperPortal block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementCustomDomainDeveloperPortalBlock>? DeveloperPortal
    {
        get => GetArgument<TerraformList<AzurermApiManagementCustomDomainDeveloperPortalBlock>>("developer_portal");
        set => SetArgument("developer_portal", value);
    }

    /// <summary>
    /// Gateway block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementCustomDomainGatewayBlock>? Gateway
    {
        get => GetArgument<TerraformList<AzurermApiManagementCustomDomainGatewayBlock>>("gateway");
        set => SetArgument("gateway", value);
    }

    /// <summary>
    /// Management block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementCustomDomainManagementBlock>? Management
    {
        get => GetArgument<TerraformList<AzurermApiManagementCustomDomainManagementBlock>>("management");
        set => SetArgument("management", value);
    }

    /// <summary>
    /// Portal block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementCustomDomainPortalBlock>? Portal
    {
        get => GetArgument<TerraformList<AzurermApiManagementCustomDomainPortalBlock>>("portal");
        set => SetArgument("portal", value);
    }

    /// <summary>
    /// Scm block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementCustomDomainScmBlock>? Scm
    {
        get => GetArgument<TerraformList<AzurermApiManagementCustomDomainScmBlock>>("scm");
        set => SetArgument("scm", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementCustomDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
