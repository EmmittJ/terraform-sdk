using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnFrontdoorCustomDomainAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_custom_domain_association resource.
/// </summary>
public partial class AzurermCdnFrontdoorCustomDomainAssociation : TerraformResource
{
    public AzurermCdnFrontdoorCustomDomainAssociation(string name) : base("azurerm_cdn_frontdoor_custom_domain_association", name)
    {
    }

    /// <summary>
    /// The cdn_frontdoor_custom_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorCustomDomainId is required")]
    [TerraformProperty("cdn_frontdoor_custom_domain_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CdnFrontdoorCustomDomainId { get; set; }

    /// <summary>
    /// The cdn_frontdoor_route_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorRouteIds is required")]
    [TerraformProperty("cdn_frontdoor_route_ids")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? CdnFrontdoorRouteIds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermCdnFrontdoorCustomDomainAssociationTimeoutsBlock>? Timeouts { get; set; }

}
