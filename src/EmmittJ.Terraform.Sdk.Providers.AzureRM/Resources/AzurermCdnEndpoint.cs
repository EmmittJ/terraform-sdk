using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for delivery_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

}

/// <summary>
/// Block type for geo_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGeoFilterBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The country_codes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCodes is required")]
    public List<TerraformProperty<string>>? CountryCodes
    {
        get => GetProperty<List<TerraformProperty<string>>>("country_codes");
        set => WithProperty("country_codes", value);
    }

    /// <summary>
    /// The relative_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativePath is required")]
    public required TerraformProperty<string> RelativePath
    {
        get => GetProperty<TerraformProperty<string>>("relative_path");
        set => WithProperty("relative_path", value);
    }

}

/// <summary>
/// Block type for global_delivery_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGlobalDeliveryRuleBlock : TerraformBlock
{
}

/// <summary>
/// Block type for origin in .
/// Nesting mode: set
/// </summary>
public class AzurermCdnEndpointOriginBlock : TerraformBlock
{
    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => WithProperty("host_name", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpPort
    {
        get => GetProperty<TerraformProperty<double>>("http_port");
        set => WithProperty("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpsPort
    {
        get => GetProperty<TerraformProperty<double>>("https_port");
        set => WithProperty("https_port", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_endpoint resource.
/// </summary>
public class AzurermCdnEndpoint : TerraformResource
{
    public AzurermCdnEndpoint(string name) : base("azurerm_cdn_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ContentTypesToCompress
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("content_types_to_compress");
        set => this.WithProperty("content_types_to_compress", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The is_compression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsCompressionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_compression_enabled");
        set => this.WithProperty("is_compression_enabled", value);
    }

    /// <summary>
    /// The is_http_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? IsHttpAllowed
    {
        get => GetProperty<TerraformProperty<bool>>("is_http_allowed");
        set => this.WithProperty("is_http_allowed", value);
    }

    /// <summary>
    /// The is_https_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? IsHttpsAllowed
    {
        get => GetProperty<TerraformProperty<bool>>("is_https_allowed");
        set => this.WithProperty("is_https_allowed", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The optimization_type attribute.
    /// </summary>
    public TerraformProperty<string>? OptimizationType
    {
        get => GetProperty<TerraformProperty<string>>("optimization_type");
        set => this.WithProperty("optimization_type", value);
    }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    public TerraformProperty<string>? OriginHostHeader
    {
        get => GetProperty<TerraformProperty<string>>("origin_host_header");
        set => this.WithProperty("origin_host_header", value);
    }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    public TerraformProperty<string>? OriginPath
    {
        get => GetProperty<TerraformProperty<string>>("origin_path");
        set => this.WithProperty("origin_path", value);
    }

    /// <summary>
    /// The probe_path attribute.
    /// </summary>
    public TerraformProperty<string>? ProbePath
    {
        get => GetProperty<TerraformProperty<string>>("probe_path");
        set => this.WithProperty("probe_path", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformProperty<string> ProfileName
    {
        get => GetProperty<TerraformProperty<string>>("profile_name");
        set => this.WithProperty("profile_name", value);
    }

    /// <summary>
    /// The querystring_caching_behaviour attribute.
    /// </summary>
    public TerraformProperty<string>? QuerystringCachingBehaviour
    {
        get => GetProperty<TerraformProperty<string>>("querystring_caching_behaviour");
        set => this.WithProperty("querystring_caching_behaviour", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for delivery_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermCdnEndpointDeliveryRuleBlock>? DeliveryRule
    {
        get => GetProperty<List<AzurermCdnEndpointDeliveryRuleBlock>>("delivery_rule");
        set => this.WithProperty("delivery_rule", value);
    }

    /// <summary>
    /// Block for geo_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermCdnEndpointGeoFilterBlock>? GeoFilter
    {
        get => GetProperty<List<AzurermCdnEndpointGeoFilterBlock>>("geo_filter");
        set => this.WithProperty("geo_filter", value);
    }

    /// <summary>
    /// Block for global_delivery_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GlobalDeliveryRule block(s) allowed")]
    public List<AzurermCdnEndpointGlobalDeliveryRuleBlock>? GlobalDeliveryRule
    {
        get => GetProperty<List<AzurermCdnEndpointGlobalDeliveryRuleBlock>>("global_delivery_rule");
        set => this.WithProperty("global_delivery_rule", value);
    }

    /// <summary>
    /// Block for origin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    public HashSet<AzurermCdnEndpointOriginBlock>? Origin
    {
        get => GetProperty<HashSet<AzurermCdnEndpointOriginBlock>>("origin");
        set => this.WithProperty("origin", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCdnEndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
