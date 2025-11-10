using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorCustomDomainTimeoutsBlock : TerraformBlock
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
/// Block type for tls in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorCustomDomainTlsBlock : TerraformBlock
{
    /// <summary>
    /// The cdn_frontdoor_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? CdnFrontdoorSecretId
    {
        set => SetProperty("cdn_frontdoor_secret_id", value);
    }

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateType
    {
        set => SetProperty("certificate_type", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? MinimumTlsVersion
    {
        set => SetProperty("minimum_tls_version", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_custom_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnFrontdoorCustomDomain : TerraformResource
{
    public AzurermCdnFrontdoorCustomDomain(string name) : base("azurerm_cdn_frontdoor_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("expiration_date");
        SetOutput("validation_token");
        SetOutput("cdn_frontdoor_profile_id");
        SetOutput("dns_zone_id");
        SetOutput("host_name");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    public required TerraformProperty<string> CdnFrontdoorProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdn_frontdoor_profile_id");
        set => SetProperty("cdn_frontdoor_profile_id", value);
    }

    /// <summary>
    /// The dns_zone_id attribute.
    /// </summary>
    public TerraformProperty<string> DnsZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_zone_id");
        set => SetProperty("dns_zone_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorCustomDomainTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tls is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Tls block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public List<AzurermCdnFrontdoorCustomDomainTlsBlock>? Tls
    {
        set => SetProperty("tls", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    public TerraformExpression ValidationToken => this["validation_token"];

}
