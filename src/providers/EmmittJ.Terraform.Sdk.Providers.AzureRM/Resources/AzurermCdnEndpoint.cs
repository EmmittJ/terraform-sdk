using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for delivery_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCdnEndpointDeliveryRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformProperty("order")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Order { get; set; }

}

/// <summary>
/// Block type for geo_filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCdnEndpointGeoFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The country_codes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCodes is required")]
    [TerraformProperty("country_codes")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? CountryCodes { get; set; }

    /// <summary>
    /// The relative_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativePath is required")]
    [TerraformProperty("relative_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RelativePath { get; set; }

}

/// <summary>
/// Block type for global_delivery_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCdnEndpointGlobalDeliveryRuleBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for origin in .
/// Nesting mode: set
/// </summary>
public partial class AzurermCdnEndpointOriginBlock : TerraformBlockBase
{
    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [TerraformProperty("http_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HttpPort { get; set; }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [TerraformProperty("https_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HttpsPort { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnEndpointTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_cdn_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCdnEndpoint : TerraformResource
{
    public AzurermCdnEndpoint(string name) : base("azurerm_cdn_endpoint", name)
    {
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    [TerraformProperty("content_types_to_compress")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ContentTypesToCompress { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The is_compression_enabled attribute.
    /// </summary>
    [TerraformProperty("is_compression_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsCompressionEnabled { get; set; }

    /// <summary>
    /// The is_http_allowed attribute.
    /// </summary>
    [TerraformProperty("is_http_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsHttpAllowed { get; set; }

    /// <summary>
    /// The is_https_allowed attribute.
    /// </summary>
    [TerraformProperty("is_https_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsHttpsAllowed { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The optimization_type attribute.
    /// </summary>
    [TerraformProperty("optimization_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OptimizationType { get; set; }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    [TerraformProperty("origin_host_header")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OriginHostHeader { get; set; }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    [TerraformProperty("origin_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OriginPath { get; set; }

    /// <summary>
    /// The probe_path attribute.
    /// </summary>
    [TerraformProperty("probe_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProbePath { get; set; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformProperty("profile_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProfileName { get; set; }

    /// <summary>
    /// The querystring_caching_behaviour attribute.
    /// </summary>
    [TerraformProperty("querystring_caching_behaviour")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QuerystringCachingBehaviour { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for delivery_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("delivery_rule")]
    public partial TerraformList<TerraformBlock<AzurermCdnEndpointDeliveryRuleBlock>>? DeliveryRule { get; set; }

    /// <summary>
    /// Block for geo_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("geo_filter")]
    public partial TerraformList<TerraformBlock<AzurermCdnEndpointGeoFilterBlock>>? GeoFilter { get; set; }

    /// <summary>
    /// Block for global_delivery_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GlobalDeliveryRule block(s) allowed")]
    [TerraformProperty("global_delivery_rule")]
    public partial TerraformList<TerraformBlock<AzurermCdnEndpointGlobalDeliveryRuleBlock>>? GlobalDeliveryRule { get; set; }

    /// <summary>
    /// Block for origin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [TerraformProperty("origin")]
    public partial TerraformSet<TerraformBlock<AzurermCdnEndpointOriginBlock>>? Origin { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCdnEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

}
