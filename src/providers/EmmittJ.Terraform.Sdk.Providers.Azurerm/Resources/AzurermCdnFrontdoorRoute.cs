using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for cache in AzurermCdnFrontdoorRoute.
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
        get => GetArgument<TerraformValue<bool>>("compression_enabled");
        set => SetArgument("compression_enabled", value);
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    public TerraformList<string>? ContentTypesToCompress
    {
        get => GetArgument<TerraformList<string>>("content_types_to_compress");
        set => SetArgument("content_types_to_compress", value);
    }

    /// <summary>
    /// The query_string_caching_behavior attribute.
    /// </summary>
    public TerraformValue<string>? QueryStringCachingBehavior
    {
        get => GetArgument<TerraformValue<string>>("query_string_caching_behavior");
        set => SetArgument("query_string_caching_behavior", value);
    }

    /// <summary>
    /// The query_strings attribute.
    /// </summary>
    public TerraformList<string>? QueryStrings
    {
        get => GetArgument<TerraformList<string>>("query_strings");
        set => SetArgument("query_strings", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCdnFrontdoorRoute.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformSet<string>>("cdn_frontdoor_custom_domain_ids");
        set => SetArgument("cdn_frontdoor_custom_domain_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorEndpointId is required")]
    public required TerraformValue<string> CdnFrontdoorEndpointId
    {
        get => GetArgument<TerraformValue<string>>("cdn_frontdoor_endpoint_id");
        set => SetArgument("cdn_frontdoor_endpoint_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginGroupId is required")]
    public required TerraformValue<string> CdnFrontdoorOriginGroupId
    {
        get => GetArgument<TerraformValue<string>>("cdn_frontdoor_origin_group_id");
        set => SetArgument("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginIds is required")]
    public TerraformList<string>? CdnFrontdoorOriginIds
    {
        get => GetArgument<TerraformList<string>>("cdn_frontdoor_origin_ids");
        set => SetArgument("cdn_frontdoor_origin_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_path attribute.
    /// </summary>
    public TerraformValue<string>? CdnFrontdoorOriginPath
    {
        get => GetArgument<TerraformValue<string>>("cdn_frontdoor_origin_path");
        set => SetArgument("cdn_frontdoor_origin_path", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_ids attribute.
    /// </summary>
    public TerraformSet<string>? CdnFrontdoorRuleSetIds
    {
        get => GetArgument<TerraformSet<string>>("cdn_frontdoor_rule_set_ids");
        set => SetArgument("cdn_frontdoor_rule_set_ids", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The forwarding_protocol attribute.
    /// </summary>
    public TerraformValue<string>? ForwardingProtocol
    {
        get => GetArgument<TerraformValue<string>>("forwarding_protocol");
        set => SetArgument("forwarding_protocol", value);
    }

    /// <summary>
    /// The https_redirect_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsRedirectEnabled
    {
        get => GetArgument<TerraformValue<bool>>("https_redirect_enabled");
        set => SetArgument("https_redirect_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The link_to_default_domain attribute.
    /// </summary>
    public TerraformValue<bool>? LinkToDefaultDomain
    {
        get => GetArgument<TerraformValue<bool>>("link_to_default_domain");
        set => SetArgument("link_to_default_domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    public TerraformList<string>? PatternsToMatch
    {
        get => GetArgument<TerraformList<string>>("patterns_to_match");
        set => SetArgument("patterns_to_match", value);
    }

    /// <summary>
    /// The supported_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedProtocols is required")]
    public required TerraformSet<string> SupportedProtocols
    {
        get => GetArgument<TerraformSet<string>>("supported_protocols");
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
