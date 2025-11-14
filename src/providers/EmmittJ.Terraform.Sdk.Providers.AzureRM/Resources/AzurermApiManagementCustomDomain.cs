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
/// Block type for developer_portal in .
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
    [TerraformArgument("certificate")]
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformArgument("host_name")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_certificate_id")]
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("key_vault_id")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformArgument("negotiate_client_certificate")]
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => new TerraformReference<bool>(this, "negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformArgument("ssl_keyvault_identity_client_id")]
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => new TerraformReference<string>(this, "ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }



}

/// <summary>
/// Block type for gateway in .
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
    [TerraformArgument("certificate")]
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

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
    /// The default_ssl_binding attribute.
    /// </summary>
    [TerraformArgument("default_ssl_binding")]
    public TerraformValue<bool> DefaultSslBinding
    {
        get => new TerraformReference<bool>(this, "default_ssl_binding");
        set => SetArgument("default_ssl_binding", value);
    }


    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformArgument("host_name")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_certificate_id")]
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("key_vault_id")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformArgument("negotiate_client_certificate")]
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => new TerraformReference<bool>(this, "negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformArgument("ssl_keyvault_identity_client_id")]
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => new TerraformReference<string>(this, "ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }



}

/// <summary>
/// Block type for management in .
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
    [TerraformArgument("certificate")]
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformArgument("host_name")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_certificate_id")]
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("key_vault_id")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformArgument("negotiate_client_certificate")]
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => new TerraformReference<bool>(this, "negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformArgument("ssl_keyvault_identity_client_id")]
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => new TerraformReference<string>(this, "ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }



}

/// <summary>
/// Block type for portal in .
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
    [TerraformArgument("certificate")]
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformArgument("host_name")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_certificate_id")]
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("key_vault_id")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformArgument("negotiate_client_certificate")]
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => new TerraformReference<bool>(this, "negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformArgument("ssl_keyvault_identity_client_id")]
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => new TerraformReference<string>(this, "ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }



}

/// <summary>
/// Block type for scm in .
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
    [TerraformArgument("certificate")]
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformArgument("host_name")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_certificate_id")]
    public TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("key_vault_id")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The negotiate_client_certificate attribute.
    /// </summary>
    [TerraformArgument("negotiate_client_certificate")]
    public TerraformValue<bool>? NegotiateClientCertificate
    {
        get => new TerraformReference<bool>(this, "negotiate_client_certificate");
        set => SetArgument("negotiate_client_certificate", value);
    }

    /// <summary>
    /// The ssl_keyvault_identity_client_id attribute.
    /// </summary>
    [TerraformArgument("ssl_keyvault_identity_client_id")]
    public TerraformValue<string>? SslKeyvaultIdentityClientId
    {
        get => new TerraformReference<string>(this, "ssl_keyvault_identity_client_id");
        set => SetArgument("ssl_keyvault_identity_client_id", value);
    }



}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("api_management_id")]
    public required TerraformValue<string> ApiManagementId
    {
        get => new TerraformReference<string>(this, "api_management_id");
        set => SetArgument("api_management_id", value);
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
    /// Block for developer_portal.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("developer_portal")]
    public TerraformList<AzurermApiManagementCustomDomainDeveloperPortalBlock> DeveloperPortal { get; set; } = new();

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("gateway")]
    public TerraformList<AzurermApiManagementCustomDomainGatewayBlock> Gateway { get; set; } = new();

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("management")]
    public TerraformList<AzurermApiManagementCustomDomainManagementBlock> Management { get; set; } = new();

    /// <summary>
    /// Block for portal.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("portal")]
    public TerraformList<AzurermApiManagementCustomDomainPortalBlock> Portal { get; set; } = new();

    /// <summary>
    /// Block for scm.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("scm")]
    public TerraformList<AzurermApiManagementCustomDomainScmBlock> Scm { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementCustomDomainTimeoutsBlock Timeouts { get; set; } = new();

}
