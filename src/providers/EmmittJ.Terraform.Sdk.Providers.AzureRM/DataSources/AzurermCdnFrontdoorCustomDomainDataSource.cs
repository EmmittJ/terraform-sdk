using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnFrontdoorCustomDomainDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_custom_domain.
/// </summary>
public partial class AzurermCdnFrontdoorCustomDomainDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorCustomDomainDataSource(string name) : base("azurerm_cdn_frontdoor_custom_domain", name)
    {
    }

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
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformProperty("profile_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProfileName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCdnFrontdoorCustomDomainDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [TerraformProperty("cdn_frontdoor_profile_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CdnFrontdoorProfileId { get; }

    /// <summary>
    /// The dns_zone_id attribute.
    /// </summary>
    [TerraformProperty("dns_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsZoneId { get; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpirationDate { get; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformProperty("host_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostName { get; }

    /// <summary>
    /// The tls attribute.
    /// </summary>
    [TerraformProperty("tls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Tls { get; }

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    [TerraformProperty("validation_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ValidationToken { get; }

}
