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
        set => SetProperty("certificate_type", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    public required TerraformProperty<string> ProtocolType
    {
        set => SetProperty("protocol_type", value);
    }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? TlsVersion
    {
        set => SetProperty("tls_version", value);
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
        set => SetProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? TlsVersion
    {
        set => SetProperty("tls_version", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_endpoint_custom_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnEndpointCustomDomain : TerraformResource
{
    public AzurermCdnEndpointCustomDomain(string name) : base("azurerm_cdn_endpoint_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cdn_endpoint_id");
        SetOutput("host_name");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The cdn_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnEndpointId is required")]
    public required TerraformProperty<string> CdnEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdn_endpoint_id");
        set => SetProperty("cdn_endpoint_id", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_name");
        set => SetProperty("host_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for cdn_managed_https.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnManagedHttps block(s) allowed")]
    public List<AzurermCdnEndpointCustomDomainCdnManagedHttpsBlock>? CdnManagedHttps
    {
        set => SetProperty("cdn_managed_https", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnEndpointCustomDomainTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_managed_https.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManagedHttps block(s) allowed")]
    public List<AzurermCdnEndpointCustomDomainUserManagedHttpsBlock>? UserManagedHttps
    {
        set => SetProperty("user_managed_https", value);
    }

}
