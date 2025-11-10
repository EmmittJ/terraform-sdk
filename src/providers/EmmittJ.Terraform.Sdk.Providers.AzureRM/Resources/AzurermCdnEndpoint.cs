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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        set => SetProperty("order", value);
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
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The country_codes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCodes is required")]
    public List<TerraformProperty<string>>? CountryCodes
    {
        set => SetProperty("country_codes", value);
    }

    /// <summary>
    /// The relative_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativePath is required")]
    public required TerraformProperty<string> RelativePath
    {
        set => SetProperty("relative_path", value);
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
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpPort
    {
        set => SetProperty("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpsPort
    {
        set => SetProperty("https_port", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnEndpoint : TerraformResource
{
    public AzurermCdnEndpoint(string name) : base("azurerm_cdn_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("fqdn");
        SetOutput("content_types_to_compress");
        SetOutput("id");
        SetOutput("is_compression_enabled");
        SetOutput("is_http_allowed");
        SetOutput("is_https_allowed");
        SetOutput("location");
        SetOutput("name");
        SetOutput("optimization_type");
        SetOutput("origin_host_header");
        SetOutput("origin_path");
        SetOutput("probe_path");
        SetOutput("profile_name");
        SetOutput("querystring_caching_behaviour");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ContentTypesToCompress
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("content_types_to_compress");
        set => SetProperty("content_types_to_compress", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The is_compression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> IsCompressionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_compression_enabled");
        set => SetProperty("is_compression_enabled", value);
    }

    /// <summary>
    /// The is_http_allowed attribute.
    /// </summary>
    public TerraformProperty<bool> IsHttpAllowed
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_http_allowed");
        set => SetProperty("is_http_allowed", value);
    }

    /// <summary>
    /// The is_https_allowed attribute.
    /// </summary>
    public TerraformProperty<bool> IsHttpsAllowed
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_https_allowed");
        set => SetProperty("is_https_allowed", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The optimization_type attribute.
    /// </summary>
    public TerraformProperty<string> OptimizationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("optimization_type");
        set => SetProperty("optimization_type", value);
    }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    public TerraformProperty<string> OriginHostHeader
    {
        get => GetRequiredOutput<TerraformProperty<string>>("origin_host_header");
        set => SetProperty("origin_host_header", value);
    }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    public TerraformProperty<string> OriginPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("origin_path");
        set => SetProperty("origin_path", value);
    }

    /// <summary>
    /// The probe_path attribute.
    /// </summary>
    public TerraformProperty<string> ProbePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("probe_path");
        set => SetProperty("probe_path", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformProperty<string> ProfileName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_name");
        set => SetProperty("profile_name", value);
    }

    /// <summary>
    /// The querystring_caching_behaviour attribute.
    /// </summary>
    public TerraformProperty<string> QuerystringCachingBehaviour
    {
        get => GetRequiredOutput<TerraformProperty<string>>("querystring_caching_behaviour");
        set => SetProperty("querystring_caching_behaviour", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for delivery_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermCdnEndpointDeliveryRuleBlock>? DeliveryRule
    {
        set => SetProperty("delivery_rule", value);
    }

    /// <summary>
    /// Block for geo_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermCdnEndpointGeoFilterBlock>? GeoFilter
    {
        set => SetProperty("geo_filter", value);
    }

    /// <summary>
    /// Block for global_delivery_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GlobalDeliveryRule block(s) allowed")]
    public List<AzurermCdnEndpointGlobalDeliveryRuleBlock>? GlobalDeliveryRule
    {
        set => SetProperty("global_delivery_rule", value);
    }

    /// <summary>
    /// Block for origin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    public HashSet<AzurermCdnEndpointOriginBlock>? Origin
    {
        set => SetProperty("origin", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
