using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for delivery_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformPropertyName("order")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Order { get; set; }

}

/// <summary>
/// Block type for geo_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGeoFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// The country_codes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCodes is required")]
    [TerraformPropertyName("country_codes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? CountryCodes { get; set; }

    /// <summary>
    /// The relative_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativePath is required")]
    [TerraformPropertyName("relative_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RelativePath { get; set; }

}

/// <summary>
/// Block type for global_delivery_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGlobalDeliveryRuleBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for origin in .
/// Nesting mode: set
/// </summary>
public class AzurermCdnEndpointOriginBlock : ITerraformBlock
{
    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostName { get; set; }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [TerraformPropertyName("http_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HttpPort { get; set; }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [TerraformPropertyName("https_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HttpsPort { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnEndpointTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_cdn_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnEndpoint : TerraformResource
{
    public AzurermCdnEndpoint(string name) : base("azurerm_cdn_endpoint", name)
    {
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    [TerraformPropertyName("content_types_to_compress")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ContentTypesToCompress { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The is_compression_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_compression_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsCompressionEnabled { get; set; }

    /// <summary>
    /// The is_http_allowed attribute.
    /// </summary>
    [TerraformPropertyName("is_http_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsHttpAllowed { get; set; }

    /// <summary>
    /// The is_https_allowed attribute.
    /// </summary>
    [TerraformPropertyName("is_https_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsHttpsAllowed { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The optimization_type attribute.
    /// </summary>
    [TerraformPropertyName("optimization_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OptimizationType { get; set; }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    [TerraformPropertyName("origin_host_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OriginHostHeader { get; set; }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    [TerraformPropertyName("origin_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OriginPath { get; set; }

    /// <summary>
    /// The probe_path attribute.
    /// </summary>
    [TerraformPropertyName("probe_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProbePath { get; set; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformPropertyName("profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProfileName { get; set; }

    /// <summary>
    /// The querystring_caching_behaviour attribute.
    /// </summary>
    [TerraformPropertyName("querystring_caching_behaviour")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QuerystringCachingBehaviour { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for delivery_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("delivery_rule")]
    public TerraformList<TerraformBlock<AzurermCdnEndpointDeliveryRuleBlock>>? DeliveryRule { get; set; } = new();

    /// <summary>
    /// Block for geo_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("geo_filter")]
    public TerraformList<TerraformBlock<AzurermCdnEndpointGeoFilterBlock>>? GeoFilter { get; set; } = new();

    /// <summary>
    /// Block for global_delivery_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GlobalDeliveryRule block(s) allowed")]
    [TerraformPropertyName("global_delivery_rule")]
    public TerraformList<TerraformBlock<AzurermCdnEndpointGlobalDeliveryRuleBlock>>? GlobalDeliveryRule { get; set; } = new();

    /// <summary>
    /// Block for origin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [TerraformPropertyName("origin")]
    public TerraformSet<TerraformBlock<AzurermCdnEndpointOriginBlock>>? Origin { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCdnEndpointTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fqdn");

}
