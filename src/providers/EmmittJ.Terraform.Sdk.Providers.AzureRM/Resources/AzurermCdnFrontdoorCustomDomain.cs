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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorCustomDomainTimeoutsBlock : TerraformBlock
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
/// Block type for tls in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorCustomDomainTlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls";

    /// <summary>
    /// The cdn_frontdoor_secret_id attribute.
    /// </summary>
    [TerraformArgument("cdn_frontdoor_secret_id")]
    public TerraformValue<string> CdnFrontdoorSecretId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_secret_id");
        set => SetArgument("cdn_frontdoor_secret_id", value);
    }

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [TerraformArgument("certificate_type")]
    public TerraformValue<string>? CertificateType
    {
        get => new TerraformReference<string>(this, "certificate_type");
        set => SetArgument("certificate_type", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("minimum_tls_version")]
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
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
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    [TerraformArgument("cdn_frontdoor_profile_id")]
    public required TerraformValue<string> CdnFrontdoorProfileId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_profile_id");
        set => SetArgument("cdn_frontdoor_profile_id", value);
    }

    /// <summary>
    /// The dns_zone_id attribute.
    /// </summary>
    [TerraformArgument("dns_zone_id")]
    public TerraformValue<string>? DnsZoneId
    {
        get => new TerraformReference<string>(this, "dns_zone_id");
        set => SetArgument("dns_zone_id", value);
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
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCdnFrontdoorCustomDomainTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tls is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Tls block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    [TerraformArgument("tls")]
    public required TerraformList<AzurermCdnFrontdoorCustomDomainTlsBlock> Tls { get; set; } = new();

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformArgument("expiration_date")]
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
    }

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    [TerraformArgument("validation_token")]
    public TerraformValue<string> ValidationToken
    {
        get => new TerraformReference<string>(this, "validation_token");
    }

}
