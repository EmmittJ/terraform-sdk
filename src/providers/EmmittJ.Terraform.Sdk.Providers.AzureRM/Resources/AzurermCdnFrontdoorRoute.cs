using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cache in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRouteCacheBlock : ITerraformBlock
{
    /// <summary>
    /// The compression_enabled attribute.
    /// </summary>
    [TerraformPropertyName("compression_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CompressionEnabled { get; set; }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    [TerraformPropertyName("content_types_to_compress")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ContentTypesToCompress { get; set; }

    /// <summary>
    /// The query_string_caching_behavior attribute.
    /// </summary>
    [TerraformPropertyName("query_string_caching_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryStringCachingBehavior { get; set; }

    /// <summary>
    /// The query_strings attribute.
    /// </summary>
    [TerraformPropertyName("query_strings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? QueryStrings { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorRouteTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_route resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnFrontdoorRoute : TerraformResource
{
    public AzurermCdnFrontdoorRoute(string name) : base("azurerm_cdn_frontdoor_route", name)
    {
    }

    /// <summary>
    /// The cdn_frontdoor_custom_domain_ids attribute.
    /// </summary>
    [TerraformPropertyName("cdn_frontdoor_custom_domain_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CdnFrontdoorCustomDomainIds { get; set; }

    /// <summary>
    /// The cdn_frontdoor_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorEndpointId is required")]
    [TerraformPropertyName("cdn_frontdoor_endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CdnFrontdoorEndpointId { get; set; }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginGroupId is required")]
    [TerraformPropertyName("cdn_frontdoor_origin_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>
    /// The cdn_frontdoor_origin_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginIds is required")]
    [TerraformPropertyName("cdn_frontdoor_origin_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? CdnFrontdoorOriginIds { get; set; }

    /// <summary>
    /// The cdn_frontdoor_origin_path attribute.
    /// </summary>
    [TerraformPropertyName("cdn_frontdoor_origin_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CdnFrontdoorOriginPath { get; set; }

    /// <summary>
    /// The cdn_frontdoor_rule_set_ids attribute.
    /// </summary>
    [TerraformPropertyName("cdn_frontdoor_rule_set_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CdnFrontdoorRuleSetIds { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The forwarding_protocol attribute.
    /// </summary>
    [TerraformPropertyName("forwarding_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForwardingProtocol { get; set; }

    /// <summary>
    /// The https_redirect_enabled attribute.
    /// </summary>
    [TerraformPropertyName("https_redirect_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HttpsRedirectEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The link_to_default_domain attribute.
    /// </summary>
    [TerraformPropertyName("link_to_default_domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LinkToDefaultDomain { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    [TerraformPropertyName("patterns_to_match")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? PatternsToMatch { get; set; }

    /// <summary>
    /// The supported_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedProtocols is required")]
    [TerraformPropertyName("supported_protocols")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SupportedProtocols { get; set; }

    /// <summary>
    /// Block for cache.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    [TerraformPropertyName("cache")]
    public TerraformList<TerraformBlock<AzurermCdnFrontdoorRouteCacheBlock>>? Cache { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCdnFrontdoorRouteTimeoutsBlock>? Timeouts { get; set; } = new();

}
