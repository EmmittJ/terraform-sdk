using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnFrontdoorCustomDomainTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for tls in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCdnFrontdoorCustomDomainTlsBlock() : TerraformBlock("tls")
{
    /// <summary>
    /// The cdn_frontdoor_secret_id attribute.
    /// </summary>
    [TerraformProperty("cdn_frontdoor_secret_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CdnFrontdoorSecretId { get; set; }

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [TerraformProperty("certificate_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateType { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinimumTlsVersion { get; set; }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_custom_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCdnFrontdoorCustomDomain : TerraformResource
{
    public AzurermCdnFrontdoorCustomDomain(string name) : base("azurerm_cdn_frontdoor_custom_domain", name)
    {
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    [TerraformProperty("cdn_frontdoor_profile_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CdnFrontdoorProfileId { get; set; }

    /// <summary>
    /// The dns_zone_id attribute.
    /// </summary>
    [TerraformProperty("dns_zone_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsZoneId { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermCdnFrontdoorCustomDomainTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tls is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Tls block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    [TerraformProperty("tls")]
    public required TerraformList<AzurermCdnFrontdoorCustomDomainTlsBlock> Tls { get; set; } = new();

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpirationDate { get; }

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    [TerraformProperty("validation_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ValidationToken { get; }

}
