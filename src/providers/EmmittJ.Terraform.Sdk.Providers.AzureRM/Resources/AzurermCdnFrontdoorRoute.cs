using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cache in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCdnFrontdoorRouteCacheBlock : TerraformBlockBase
{
    /// <summary>
    /// The compression_enabled attribute.
    /// </summary>
    [TerraformProperty("compression_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CompressionEnabled { get; set; }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    [TerraformProperty("content_types_to_compress")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ContentTypesToCompress { get; set; }

    /// <summary>
    /// The query_string_caching_behavior attribute.
    /// </summary>
    [TerraformProperty("query_string_caching_behavior")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QueryStringCachingBehavior { get; set; }

    /// <summary>
    /// The query_strings attribute.
    /// </summary>
    [TerraformProperty("query_strings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? QueryStrings { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnFrontdoorRouteTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_cdn_frontdoor_route resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCdnFrontdoorRoute : TerraformResource
{
    public AzurermCdnFrontdoorRoute(string name) : base("azurerm_cdn_frontdoor_route", name)
    {
    }

    /// <summary>
    /// The cdn_frontdoor_custom_domain_ids attribute.
    /// </summary>
    [TerraformProperty("cdn_frontdoor_custom_domain_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? CdnFrontdoorCustomDomainIds { get; set; }

    /// <summary>
    /// The cdn_frontdoor_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorEndpointId is required")]
    [TerraformProperty("cdn_frontdoor_endpoint_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CdnFrontdoorEndpointId { get; set; }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginGroupId is required")]
    [TerraformProperty("cdn_frontdoor_origin_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>
    /// The cdn_frontdoor_origin_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginIds is required")]
    [TerraformProperty("cdn_frontdoor_origin_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? CdnFrontdoorOriginIds { get; set; }

    /// <summary>
    /// The cdn_frontdoor_origin_path attribute.
    /// </summary>
    [TerraformProperty("cdn_frontdoor_origin_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CdnFrontdoorOriginPath { get; set; }

    /// <summary>
    /// The cdn_frontdoor_rule_set_ids attribute.
    /// </summary>
    [TerraformProperty("cdn_frontdoor_rule_set_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? CdnFrontdoorRuleSetIds { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The forwarding_protocol attribute.
    /// </summary>
    [TerraformProperty("forwarding_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForwardingProtocol { get; set; }

    /// <summary>
    /// The https_redirect_enabled attribute.
    /// </summary>
    [TerraformProperty("https_redirect_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HttpsRedirectEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The link_to_default_domain attribute.
    /// </summary>
    [TerraformProperty("link_to_default_domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LinkToDefaultDomain { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    [TerraformProperty("patterns_to_match")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? PatternsToMatch { get; set; }

    /// <summary>
    /// The supported_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedProtocols is required")]
    [TerraformProperty("supported_protocols")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SupportedProtocols { get; set; }

    /// <summary>
    /// Block for cache.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    [TerraformProperty("cache")]
    public partial TerraformList<TerraformBlock<AzurermCdnFrontdoorRouteCacheBlock>>? Cache { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCdnFrontdoorRouteTimeoutsBlock>? Timeouts { get; set; }

}
