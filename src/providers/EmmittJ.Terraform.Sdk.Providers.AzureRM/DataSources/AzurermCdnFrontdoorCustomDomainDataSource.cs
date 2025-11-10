using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorCustomDomainDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_custom_domain.
/// </summary>
public class AzurermCdnFrontdoorCustomDomainDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorCustomDomainDataSource(string name) : base("azurerm_cdn_frontdoor_custom_domain", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformPropertyName("profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProfileName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCdnFrontdoorCustomDomainDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [TerraformPropertyName("cdn_frontdoor_profile_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CdnFrontdoorProfileId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cdn_frontdoor_profile_id");

    /// <summary>
    /// The dns_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("dns_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_zone_id");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpirationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_date");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformPropertyName("host_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_name");

    /// <summary>
    /// The tls attribute.
    /// </summary>
    [TerraformPropertyName("tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Tls => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "tls");

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    [TerraformPropertyName("validation_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ValidationToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "validation_token");

}
