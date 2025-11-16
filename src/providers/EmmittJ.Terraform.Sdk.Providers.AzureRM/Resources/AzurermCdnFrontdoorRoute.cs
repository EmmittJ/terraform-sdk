using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<bool>? CompressionEnabled
    {
        get => new TerraformReference<bool>(this, "compression_enabled");
        set => SetArgument("compression_enabled", value);
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    public TerraformList<string>? ContentTypesToCompress
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "content_types_to_compress").ResolveNodes(ctx));
        set => SetArgument("content_types_to_compress", value);
    }

    /// <summary>
    /// The query_string_caching_behavior attribute.
    /// </summary>
    public TerraformValue<string>? QueryStringCachingBehavior
    {
        get => new TerraformReference<string>(this, "query_string_caching_behavior");
        set => SetArgument("query_string_caching_behavior", value);
    }

    /// <summary>
    /// The query_strings attribute.
    /// </summary>
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
/// Represents a azurerm_cdn_frontdoor_route Terraform resource.
/// Manages a azurerm_cdn_frontdoor_route resource.
/// </summary>
public partial class AzurermCdnFrontdoorRoute(string name) : TerraformResource("azurerm_cdn_frontdoor_route", name)
{
    /// <summary>
    /// The cdn_frontdoor_custom_domain_ids attribute.
    /// </summary>
    public TerraformSet<string>? CdnFrontdoorCustomDomainIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cdn_frontdoor_custom_domain_ids").ResolveNodes(ctx));
        set => SetArgument("cdn_frontdoor_custom_domain_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorEndpointId is required")]
    public required TerraformValue<string> CdnFrontdoorEndpointId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_endpoint_id");
        set => SetArgument("cdn_frontdoor_endpoint_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginGroupId is required")]
    public required TerraformValue<string> CdnFrontdoorOriginGroupId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_origin_group_id");
        set => SetArgument("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginIds is required")]
    public TerraformList<string>? CdnFrontdoorOriginIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cdn_frontdoor_origin_ids").ResolveNodes(ctx));
        set => SetArgument("cdn_frontdoor_origin_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_path attribute.
    /// </summary>
    public TerraformValue<string>? CdnFrontdoorOriginPath
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_origin_path");
        set => SetArgument("cdn_frontdoor_origin_path", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_ids attribute.
    /// </summary>
    public TerraformSet<string>? CdnFrontdoorRuleSetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cdn_frontdoor_rule_set_ids").ResolveNodes(ctx));
        set => SetArgument("cdn_frontdoor_rule_set_ids", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The forwarding_protocol attribute.
    /// </summary>
    public TerraformValue<string>? ForwardingProtocol
    {
        get => new TerraformReference<string>(this, "forwarding_protocol");
        set => SetArgument("forwarding_protocol", value);
    }

    /// <summary>
    /// The https_redirect_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsRedirectEnabled
    {
        get => new TerraformReference<bool>(this, "https_redirect_enabled");
        set => SetArgument("https_redirect_enabled", value);
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
    /// The link_to_default_domain attribute.
    /// </summary>
    public TerraformValue<bool>? LinkToDefaultDomain
    {
        get => new TerraformReference<bool>(this, "link_to_default_domain");
        set => SetArgument("link_to_default_domain", value);
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
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    public TerraformList<string>? PatternsToMatch
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "patterns_to_match").ResolveNodes(ctx));
        set => SetArgument("patterns_to_match", value);
    }

    /// <summary>
    /// The supported_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedProtocols is required")]
    public required TerraformSet<string> SupportedProtocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_protocols").ResolveNodes(ctx));
        set => SetArgument("supported_protocols", value);
    }

    /// <summary>
    /// Cache block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorRouteCacheBlock>? Cache
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRouteCacheBlock>>("cache");
        set => SetArgument("cache", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorRouteTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorRouteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
