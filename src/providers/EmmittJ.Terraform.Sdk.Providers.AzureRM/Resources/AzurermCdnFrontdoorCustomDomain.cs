using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorCustomDomainTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for tls in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorCustomDomainTlsBlock
{
    /// <summary>
    /// The cdn_frontdoor_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("cdn_frontdoor_secret_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CdnFrontdoorSecretId { get; set; } = default!;

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [TerraformPropertyName("certificate_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateType { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinimumTlsVersion { get; set; }

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
    [TerraformPropertyName("cdn_frontdoor_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CdnFrontdoorProfileId { get; set; }

    /// <summary>
    /// The dns_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("dns_zone_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsZoneId { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCdnFrontdoorCustomDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for tls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tls is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Tls block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    [TerraformPropertyName("tls")]
    public TerraformList<TerraformBlock<AzurermCdnFrontdoorCustomDomainTlsBlock>>? Tls { get; set; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpirationDate => new TerraformReference(this, "expiration_date");

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    [TerraformPropertyName("validation_token")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ValidationToken => new TerraformReference(this, "validation_token");

}
