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
/// Block type for cache in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRouteCacheBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache";

    /// <summary>
    /// The compression_enabled attribute.
    /// </summary>
    [TerraformArgument("compression_enabled")]
    public TerraformValue<bool>? CompressionEnabled
    {
        get => new TerraformReference<bool>(this, "compression_enabled");
        set => SetArgument("compression_enabled", value);
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    [TerraformArgument("content_types_to_compress")]
    public TerraformList<string>? ContentTypesToCompress
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "content_types_to_compress").ResolveNodes(ctx));
        set => SetArgument("content_types_to_compress", value);
    }

    /// <summary>
    /// The query_string_caching_behavior attribute.
    /// </summary>
    [TerraformArgument("query_string_caching_behavior")]
    public TerraformValue<string>? QueryStringCachingBehavior
    {
        get => new TerraformReference<string>(this, "query_string_caching_behavior");
        set => SetArgument("query_string_caching_behavior", value);
    }

    /// <summary>
    /// The query_strings attribute.
    /// </summary>
    [TerraformArgument("query_strings")]
    public TerraformList<string>? QueryStrings
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "query_strings").ResolveNodes(ctx));
        set => SetArgument("query_strings", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorRouteTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("cdn_frontdoor_custom_domain_ids")]
    public TerraformSet<string>? CdnFrontdoorCustomDomainIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cdn_frontdoor_custom_domain_ids").ResolveNodes(ctx));
        set => SetArgument("cdn_frontdoor_custom_domain_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorEndpointId is required")]
    [TerraformArgument("cdn_frontdoor_endpoint_id")]
    public required TerraformValue<string> CdnFrontdoorEndpointId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_endpoint_id");
        set => SetArgument("cdn_frontdoor_endpoint_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginGroupId is required")]
    [TerraformArgument("cdn_frontdoor_origin_group_id")]
    public required TerraformValue<string> CdnFrontdoorOriginGroupId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_origin_group_id");
        set => SetArgument("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginIds is required")]
    [TerraformArgument("cdn_frontdoor_origin_ids")]
    public TerraformList<string>? CdnFrontdoorOriginIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cdn_frontdoor_origin_ids").ResolveNodes(ctx));
        set => SetArgument("cdn_frontdoor_origin_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_path attribute.
    /// </summary>
    [TerraformArgument("cdn_frontdoor_origin_path")]
    public TerraformValue<string>? CdnFrontdoorOriginPath
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_origin_path");
        set => SetArgument("cdn_frontdoor_origin_path", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_ids attribute.
    /// </summary>
    [TerraformArgument("cdn_frontdoor_rule_set_ids")]
    public TerraformSet<string>? CdnFrontdoorRuleSetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cdn_frontdoor_rule_set_ids").ResolveNodes(ctx));
        set => SetArgument("cdn_frontdoor_rule_set_ids", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The forwarding_protocol attribute.
    /// </summary>
    [TerraformArgument("forwarding_protocol")]
    public TerraformValue<string>? ForwardingProtocol
    {
        get => new TerraformReference<string>(this, "forwarding_protocol");
        set => SetArgument("forwarding_protocol", value);
    }

    /// <summary>
    /// The https_redirect_enabled attribute.
    /// </summary>
    [TerraformArgument("https_redirect_enabled")]
    public TerraformValue<bool>? HttpsRedirectEnabled
    {
        get => new TerraformReference<bool>(this, "https_redirect_enabled");
        set => SetArgument("https_redirect_enabled", value);
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
    /// The link_to_default_domain attribute.
    /// </summary>
    [TerraformArgument("link_to_default_domain")]
    public TerraformValue<bool>? LinkToDefaultDomain
    {
        get => new TerraformReference<bool>(this, "link_to_default_domain");
        set => SetArgument("link_to_default_domain", value);
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
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    [TerraformArgument("patterns_to_match")]
    public TerraformList<string>? PatternsToMatch
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "patterns_to_match").ResolveNodes(ctx));
        set => SetArgument("patterns_to_match", value);
    }

    /// <summary>
    /// The supported_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedProtocols is required")]
    [TerraformArgument("supported_protocols")]
    public required TerraformSet<string> SupportedProtocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_protocols").ResolveNodes(ctx));
        set => SetArgument("supported_protocols", value);
    }

    /// <summary>
    /// Block for cache.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    [TerraformArgument("cache")]
    public TerraformList<AzurermCdnFrontdoorRouteCacheBlock> Cache { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCdnFrontdoorRouteTimeoutsBlock Timeouts { get; set; } = new();

}
