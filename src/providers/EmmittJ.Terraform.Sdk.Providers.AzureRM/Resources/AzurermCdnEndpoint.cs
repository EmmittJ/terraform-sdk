using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for delivery_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delivery_rule";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformArgument("order")]
    public required TerraformValue<double> Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

}

/// <summary>
/// Block type for geo_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGeoFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geo_filter";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformArgument("action")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The country_codes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCodes is required")]
    [TerraformArgument("country_codes")]
    public TerraformList<string>? CountryCodes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "country_codes").ResolveNodes(ctx));
        set => SetArgument("country_codes", value);
    }

    /// <summary>
    /// The relative_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativePath is required")]
    [TerraformArgument("relative_path")]
    public required TerraformValue<string> RelativePath
    {
        get => new TerraformReference<string>(this, "relative_path");
        set => SetArgument("relative_path", value);
    }

}

/// <summary>
/// Block type for global_delivery_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGlobalDeliveryRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "global_delivery_rule";

}

/// <summary>
/// Block type for origin in .
/// Nesting mode: set
/// </summary>
public class AzurermCdnEndpointOriginBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "origin";

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformArgument("host_name")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [TerraformArgument("http_port")]
    public TerraformValue<double>? HttpPort
    {
        get => new TerraformReference<double>(this, "http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [TerraformArgument("https_port")]
    public TerraformValue<double>? HttpsPort
    {
        get => new TerraformReference<double>(this, "https_port");
        set => SetArgument("https_port", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    [TerraformArgument("content_types_to_compress")]
    public TerraformSet<string>? ContentTypesToCompress
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "content_types_to_compress").ResolveNodes(ctx));
        set => SetArgument("content_types_to_compress", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_compression_enabled attribute.
    /// </summary>
    [TerraformArgument("is_compression_enabled")]
    public TerraformValue<bool>? IsCompressionEnabled
    {
        get => new TerraformReference<bool>(this, "is_compression_enabled");
        set => SetArgument("is_compression_enabled", value);
    }

    /// <summary>
    /// The is_http_allowed attribute.
    /// </summary>
    [TerraformArgument("is_http_allowed")]
    public TerraformValue<bool>? IsHttpAllowed
    {
        get => new TerraformReference<bool>(this, "is_http_allowed");
        set => SetArgument("is_http_allowed", value);
    }

    /// <summary>
    /// The is_https_allowed attribute.
    /// </summary>
    [TerraformArgument("is_https_allowed")]
    public TerraformValue<bool>? IsHttpsAllowed
    {
        get => new TerraformReference<bool>(this, "is_https_allowed");
        set => SetArgument("is_https_allowed", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The optimization_type attribute.
    /// </summary>
    [TerraformArgument("optimization_type")]
    public TerraformValue<string>? OptimizationType
    {
        get => new TerraformReference<string>(this, "optimization_type");
        set => SetArgument("optimization_type", value);
    }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    [TerraformArgument("origin_host_header")]
    public TerraformValue<string>? OriginHostHeader
    {
        get => new TerraformReference<string>(this, "origin_host_header");
        set => SetArgument("origin_host_header", value);
    }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    [TerraformArgument("origin_path")]
    public TerraformValue<string>? OriginPath
    {
        get => new TerraformReference<string>(this, "origin_path");
        set => SetArgument("origin_path", value);
    }

    /// <summary>
    /// The probe_path attribute.
    /// </summary>
    [TerraformArgument("probe_path")]
    public TerraformValue<string>? ProbePath
    {
        get => new TerraformReference<string>(this, "probe_path");
        set => SetArgument("probe_path", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformArgument("profile_name")]
    public required TerraformValue<string> ProfileName
    {
        get => new TerraformReference<string>(this, "profile_name");
        set => SetArgument("profile_name", value);
    }

    /// <summary>
    /// The querystring_caching_behaviour attribute.
    /// </summary>
    [TerraformArgument("querystring_caching_behaviour")]
    public TerraformValue<string>? QuerystringCachingBehaviour
    {
        get => new TerraformReference<string>(this, "querystring_caching_behaviour");
        set => SetArgument("querystring_caching_behaviour", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for delivery_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("delivery_rule")]
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlock> DeliveryRule { get; set; } = new();

    /// <summary>
    /// Block for geo_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("geo_filter")]
    public TerraformList<AzurermCdnEndpointGeoFilterBlock> GeoFilter { get; set; } = new();

    /// <summary>
    /// Block for global_delivery_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GlobalDeliveryRule block(s) allowed")]
    [TerraformArgument("global_delivery_rule")]
    public TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlock> GlobalDeliveryRule { get; set; } = new();

    /// <summary>
    /// Block for origin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [TerraformArgument("origin")]
    public required TerraformSet<AzurermCdnEndpointOriginBlock> Origin { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCdnEndpointTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

}
