using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
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
    public TerraformValue<string> CdnFrontdoorSecretId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_secret_id");
        set => SetArgument("cdn_frontdoor_secret_id", value);
    }

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    public TerraformValue<string>? CertificateType
    {
        get => new TerraformReference<string>(this, "certificate_type");
        set => SetArgument("certificate_type", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
    }

}

/// <summary>
/// Represents a azurerm_cdn_frontdoor_custom_domain Terraform resource.
/// Manages a azurerm_cdn_frontdoor_custom_domain resource.
/// </summary>
public partial class AzurermCdnFrontdoorCustomDomain(string name) : TerraformResource("azurerm_cdn_frontdoor_custom_domain", name)
{
    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    public required TerraformValue<string> CdnFrontdoorProfileId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_profile_id");
        set => SetArgument("cdn_frontdoor_profile_id", value);
    }

    /// <summary>
    /// The dns_zone_id attribute.
    /// </summary>
    public TerraformValue<string>? DnsZoneId
    {
        get => new TerraformReference<string>(this, "dns_zone_id");
        set => SetArgument("dns_zone_id", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorCustomDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Tls block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tls is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Tls block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public required AzurermCdnFrontdoorCustomDomainTlsBlock Tls
    {
        get => GetRequiredArgument<AzurermCdnFrontdoorCustomDomainTlsBlock>("tls");
        set => SetArgument("tls", value);
    }

}
