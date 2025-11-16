using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
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
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The country_codes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCodes is required")]
    public TerraformList<string>? CountryCodes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "country_codes").ResolveNodes(ctx));
        set => SetArgument("country_codes", value);
    }

    /// <summary>
    /// The relative_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativePath is required")]
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
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformValue<double>? HttpPort
    {
        get => new TerraformReference<double>(this, "http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformValue<double>? HttpsPort
    {
        get => new TerraformReference<double>(this, "https_port");
        set => SetArgument("https_port", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_cdn_endpoint Terraform resource.
/// Manages a azurerm_cdn_endpoint resource.
/// </summary>
public partial class AzurermCdnEndpoint(string name) : TerraformResource("azurerm_cdn_endpoint", name)
{
    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    public TerraformSet<string>? ContentTypesToCompress
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "content_types_to_compress").ResolveNodes(ctx));
        set => SetArgument("content_types_to_compress", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_compression_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsCompressionEnabled
    {
        get => new TerraformReference<bool>(this, "is_compression_enabled");
        set => SetArgument("is_compression_enabled", value);
    }

    /// <summary>
    /// The is_http_allowed attribute.
    /// </summary>
    public TerraformValue<bool>? IsHttpAllowed
    {
        get => new TerraformReference<bool>(this, "is_http_allowed");
        set => SetArgument("is_http_allowed", value);
    }

    /// <summary>
    /// The is_https_allowed attribute.
    /// </summary>
    public TerraformValue<bool>? IsHttpsAllowed
    {
        get => new TerraformReference<bool>(this, "is_https_allowed");
        set => SetArgument("is_https_allowed", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The optimization_type attribute.
    /// </summary>
    public TerraformValue<string>? OptimizationType
    {
        get => new TerraformReference<string>(this, "optimization_type");
        set => SetArgument("optimization_type", value);
    }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    public TerraformValue<string>? OriginHostHeader
    {
        get => new TerraformReference<string>(this, "origin_host_header");
        set => SetArgument("origin_host_header", value);
    }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    public TerraformValue<string>? OriginPath
    {
        get => new TerraformReference<string>(this, "origin_path");
        set => SetArgument("origin_path", value);
    }

    /// <summary>
    /// The probe_path attribute.
    /// </summary>
    public TerraformValue<string>? ProbePath
    {
        get => new TerraformReference<string>(this, "probe_path");
        set => SetArgument("probe_path", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformValue<string> ProfileName
    {
        get => new TerraformReference<string>(this, "profile_name");
        set => SetArgument("profile_name", value);
    }

    /// <summary>
    /// The querystring_caching_behaviour attribute.
    /// </summary>
    public TerraformValue<string>? QuerystringCachingBehaviour
    {
        get => new TerraformReference<string>(this, "querystring_caching_behaviour");
        set => SetArgument("querystring_caching_behaviour", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// DeliveryRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlock>? DeliveryRule
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlock>>("delivery_rule");
        set => SetArgument("delivery_rule", value);
    }

    /// <summary>
    /// GeoFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointGeoFilterBlock>? GeoFilter
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointGeoFilterBlock>>("geo_filter");
        set => SetArgument("geo_filter", value);
    }

    /// <summary>
    /// GlobalDeliveryRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GlobalDeliveryRule block(s) allowed")]
    public TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlock>? GlobalDeliveryRule
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlock>>("global_delivery_rule");
        set => SetArgument("global_delivery_rule", value);
    }

    /// <summary>
    /// Origin block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    public required TerraformSet<AzurermCdnEndpointOriginBlock> Origin
    {
        get => GetRequiredArgument<TerraformSet<AzurermCdnEndpointOriginBlock>>("origin");
        set => SetArgument("origin", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
