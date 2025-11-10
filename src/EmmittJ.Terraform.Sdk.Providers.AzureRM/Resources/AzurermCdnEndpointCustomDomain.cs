using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cdn_managed_https in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointCustomDomainCdnManagedHttpsBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateType is required")]
    public required TerraformProperty<string> CertificateType
    {
        get => GetProperty<TerraformProperty<string>>("certificate_type");
        set => WithProperty("certificate_type", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    public required TerraformProperty<string> ProtocolType
    {
        get => GetProperty<TerraformProperty<string>>("protocol_type");
        set => WithProperty("protocol_type", value);
    }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? TlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("tls_version");
        set => WithProperty("tls_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnEndpointCustomDomainTimeoutsBlock : TerraformBlock
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
/// Block type for user_managed_https in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointCustomDomainUserManagedHttpsBlock : TerraformBlock
{
    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultSecretId is required")]
    public required TerraformProperty<string> KeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_secret_id");
        set => WithProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? TlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("tls_version");
        set => WithProperty("tls_version", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_endpoint_custom_domain resource.
/// </summary>
public class AzurermCdnEndpointCustomDomain : TerraformResource
{
    public AzurermCdnEndpointCustomDomain(string name) : base("azurerm_cdn_endpoint_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cdn_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnEndpointId is required")]
    public required TerraformProperty<string> CdnEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_endpoint_id");
        set => this.WithProperty("cdn_endpoint_id", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => this.WithProperty("host_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for cdn_managed_https.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnManagedHttps block(s) allowed")]
    public List<AzurermCdnEndpointCustomDomainCdnManagedHttpsBlock>? CdnManagedHttps
    {
        get => GetProperty<List<AzurermCdnEndpointCustomDomainCdnManagedHttpsBlock>>("cdn_managed_https");
        set => this.WithProperty("cdn_managed_https", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnEndpointCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCdnEndpointCustomDomainTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_managed_https.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManagedHttps block(s) allowed")]
    public List<AzurermCdnEndpointCustomDomainUserManagedHttpsBlock>? UserManagedHttps
    {
        get => GetProperty<List<AzurermCdnEndpointCustomDomainUserManagedHttpsBlock>>("user_managed_https");
        set => this.WithProperty("user_managed_https", value);
    }

}
