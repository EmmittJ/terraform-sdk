using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for actions in AzurermCdnFrontdoorRule.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// RequestHeaderAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleActionsBlockRequestHeaderActionBlock>? RequestHeaderAction
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleActionsBlockRequestHeaderActionBlock>>("request_header_action");
        set => SetArgument("request_header_action", value);
    }

    /// <summary>
    /// ResponseHeaderAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleActionsBlockResponseHeaderActionBlock>? ResponseHeaderAction
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleActionsBlockResponseHeaderActionBlock>>("response_header_action");
        set => SetArgument("response_header_action", value);
    }

    /// <summary>
    /// RouteConfigurationOverrideAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RouteConfigurationOverrideAction block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorRuleActionsBlockRouteConfigurationOverrideActionBlock>? RouteConfigurationOverrideAction
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleActionsBlockRouteConfigurationOverrideActionBlock>>("route_configuration_override_action");
        set => SetArgument("route_configuration_override_action", value);
    }

    /// <summary>
    /// UrlRedirectAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRedirectAction block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorRuleActionsBlockUrlRedirectActionBlock>? UrlRedirectAction
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleActionsBlockUrlRedirectActionBlock>>("url_redirect_action");
        set => SetArgument("url_redirect_action", value);
    }

    /// <summary>
    /// UrlRewriteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewriteAction block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorRuleActionsBlockUrlRewriteActionBlock>? UrlRewriteAction
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleActionsBlockUrlRewriteActionBlock>>("url_rewrite_action");
        set => SetArgument("url_rewrite_action", value);
    }

}

/// <summary>
/// Block type for request_header_action in AzurermCdnFrontdoorRuleActionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleActionsBlockRequestHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header_action";

    /// <summary>
    /// The header_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderAction is required")]
    public required TerraformValue<string> HeaderAction
    {
        get => GetArgument<TerraformValue<string>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for response_header_action in AzurermCdnFrontdoorRuleActionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleActionsBlockResponseHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_header_action";

    /// <summary>
    /// The header_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderAction is required")]
    public required TerraformValue<string> HeaderAction
    {
        get => GetArgument<TerraformValue<string>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for route_configuration_override_action in AzurermCdnFrontdoorRuleActionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleActionsBlockRouteConfigurationOverrideActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_configuration_override_action";

    /// <summary>
    /// The cache_behavior attribute.
    /// </summary>
    public TerraformValue<string>? CacheBehavior
    {
        get => GetArgument<TerraformValue<string>>("cache_behavior");
        set => SetArgument("cache_behavior", value);
    }

    /// <summary>
    /// The cache_duration attribute.
    /// </summary>
    public TerraformValue<string>? CacheDuration
    {
        get => GetArgument<TerraformValue<string>>("cache_duration");
        set => SetArgument("cache_duration", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    public TerraformValue<string>? CdnFrontdoorOriginGroupId
    {
        get => GetArgument<TerraformValue<string>>("cdn_frontdoor_origin_group_id");
        set => SetArgument("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The compression_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CompressionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("compression_enabled");
        set => SetArgument("compression_enabled", value);
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
    /// The query_string_caching_behavior attribute.
    /// </summary>
    public TerraformValue<string>? QueryStringCachingBehavior
    {
        get => GetArgument<TerraformValue<string>>("query_string_caching_behavior");
        set => SetArgument("query_string_caching_behavior", value);
    }

    /// <summary>
    /// The query_string_parameters attribute.
    /// </summary>
    public TerraformList<string>? QueryStringParameters
    {
        get => GetArgument<TerraformList<string>>("query_string_parameters");
        set => SetArgument("query_string_parameters", value);
    }

}

/// <summary>
/// Block type for url_redirect_action in AzurermCdnFrontdoorRuleActionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleActionsBlockUrlRedirectActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_redirect_action";

    /// <summary>
    /// The destination_fragment attribute.
    /// </summary>
    public TerraformValue<string>? DestinationFragment
    {
        get => GetArgument<TerraformValue<string>>("destination_fragment");
        set => SetArgument("destination_fragment", value);
    }

    /// <summary>
    /// The destination_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationHostname is required")]
    public required TerraformValue<string> DestinationHostname
    {
        get => GetArgument<TerraformValue<string>>("destination_hostname");
        set => SetArgument("destination_hostname", value);
    }

    /// <summary>
    /// The destination_path attribute.
    /// </summary>
    public TerraformValue<string>? DestinationPath
    {
        get => GetArgument<TerraformValue<string>>("destination_path");
        set => SetArgument("destination_path", value);
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    public TerraformValue<string>? QueryString
    {
        get => GetArgument<TerraformValue<string>>("query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// The redirect_protocol attribute.
    /// </summary>
    public TerraformValue<string>? RedirectProtocol
    {
        get => GetArgument<TerraformValue<string>>("redirect_protocol");
        set => SetArgument("redirect_protocol", value);
    }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    public required TerraformValue<string> RedirectType
    {
        get => GetArgument<TerraformValue<string>>("redirect_type");
        set => SetArgument("redirect_type", value);
    }

}

/// <summary>
/// Block type for url_rewrite_action in AzurermCdnFrontdoorRuleActionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleActionsBlockUrlRewriteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite_action";

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => GetArgument<TerraformValue<string>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The preserve_unmatched_path attribute.
    /// </summary>
    public TerraformValue<bool>? PreserveUnmatchedPath
    {
        get => GetArgument<TerraformValue<bool>>("preserve_unmatched_path");
        set => SetArgument("preserve_unmatched_path", value);
    }

    /// <summary>
    /// The source_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePattern is required")]
    public required TerraformValue<string> SourcePattern
    {
        get => GetArgument<TerraformValue<string>>("source_pattern");
        set => SetArgument("source_pattern", value);
    }

}


/// <summary>
/// Block type for conditions in AzurermCdnFrontdoorRule.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// ClientPortCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockClientPortConditionBlock>? ClientPortCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockClientPortConditionBlock>>("client_port_condition");
        set => SetArgument("client_port_condition", value);
    }

    /// <summary>
    /// CookiesCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockCookiesConditionBlock>? CookiesCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockCookiesConditionBlock>>("cookies_condition");
        set => SetArgument("cookies_condition", value);
    }

    /// <summary>
    /// HostNameCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockHostNameConditionBlock>? HostNameCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockHostNameConditionBlock>>("host_name_condition");
        set => SetArgument("host_name_condition", value);
    }

    /// <summary>
    /// HttpVersionCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockHttpVersionConditionBlock>? HttpVersionCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockHttpVersionConditionBlock>>("http_version_condition");
        set => SetArgument("http_version_condition", value);
    }

    /// <summary>
    /// IsDeviceCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockIsDeviceConditionBlock>? IsDeviceCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockIsDeviceConditionBlock>>("is_device_condition");
        set => SetArgument("is_device_condition", value);
    }

    /// <summary>
    /// PostArgsCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockPostArgsConditionBlock>? PostArgsCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockPostArgsConditionBlock>>("post_args_condition");
        set => SetArgument("post_args_condition", value);
    }

    /// <summary>
    /// QueryStringCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockQueryStringConditionBlock>? QueryStringCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockQueryStringConditionBlock>>("query_string_condition");
        set => SetArgument("query_string_condition", value);
    }

    /// <summary>
    /// RemoteAddressCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRemoteAddressConditionBlock>? RemoteAddressCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRemoteAddressConditionBlock>>("remote_address_condition");
        set => SetArgument("remote_address_condition", value);
    }

    /// <summary>
    /// RequestBodyCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRequestBodyConditionBlock>? RequestBodyCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRequestBodyConditionBlock>>("request_body_condition");
        set => SetArgument("request_body_condition", value);
    }

    /// <summary>
    /// RequestHeaderCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRequestHeaderConditionBlock>? RequestHeaderCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRequestHeaderConditionBlock>>("request_header_condition");
        set => SetArgument("request_header_condition", value);
    }

    /// <summary>
    /// RequestMethodCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRequestMethodConditionBlock>? RequestMethodCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRequestMethodConditionBlock>>("request_method_condition");
        set => SetArgument("request_method_condition", value);
    }

    /// <summary>
    /// RequestSchemeCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRequestSchemeConditionBlock>? RequestSchemeCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRequestSchemeConditionBlock>>("request_scheme_condition");
        set => SetArgument("request_scheme_condition", value);
    }

    /// <summary>
    /// RequestUriCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRequestUriConditionBlock>? RequestUriCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockRequestUriConditionBlock>>("request_uri_condition");
        set => SetArgument("request_uri_condition", value);
    }

    /// <summary>
    /// ServerPortCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockServerPortConditionBlock>? ServerPortCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockServerPortConditionBlock>>("server_port_condition");
        set => SetArgument("server_port_condition", value);
    }

    /// <summary>
    /// SocketAddressCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockSocketAddressConditionBlock>? SocketAddressCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockSocketAddressConditionBlock>>("socket_address_condition");
        set => SetArgument("socket_address_condition", value);
    }

    /// <summary>
    /// SslProtocolCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockSslProtocolConditionBlock>? SslProtocolCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockSslProtocolConditionBlock>>("ssl_protocol_condition");
        set => SetArgument("ssl_protocol_condition", value);
    }

    /// <summary>
    /// UrlFileExtensionCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockUrlFileExtensionConditionBlock>? UrlFileExtensionCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockUrlFileExtensionConditionBlock>>("url_file_extension_condition");
        set => SetArgument("url_file_extension_condition", value);
    }

    /// <summary>
    /// UrlFilenameCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockUrlFilenameConditionBlock>? UrlFilenameCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockUrlFilenameConditionBlock>>("url_filename_condition");
        set => SetArgument("url_filename_condition", value);
    }

    /// <summary>
    /// UrlPathCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlockUrlPathConditionBlock>? UrlPathCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlockUrlPathConditionBlock>>("url_path_condition");
        set => SetArgument("url_path_condition", value);
    }

}

/// <summary>
/// Block type for client_port_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockClientPortConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_port_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for cookies_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockCookiesConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cookies_condition";

    /// <summary>
    /// The cookie_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieName is required")]
    public required TerraformValue<string> CookieName
    {
        get => GetArgument<TerraformValue<string>>("cookie_name");
        set => SetArgument("cookie_name", value);
    }

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for host_name_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockHostNameConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_name_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for http_version_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockHttpVersionConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_version_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchValues is required")]
    public required TerraformSet<string> MatchValues
    {
        get => GetArgument<TerraformSet<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for is_device_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockIsDeviceConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "is_device_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for post_args_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockPostArgsConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_args_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The post_args_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostArgsName is required")]
    public required TerraformValue<string> PostArgsName
    {
        get => GetArgument<TerraformValue<string>>("post_args_name");
        set => SetArgument("post_args_name", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for query_string_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockQueryStringConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_string_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for remote_address_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockRemoteAddressConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote_address_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for request_body_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockRequestBodyConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_body_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchValues is required")]
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for request_header_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockRequestHeaderConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header_condition";

    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for request_method_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockRequestMethodConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_method_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchValues is required")]
    public required TerraformSet<string> MatchValues
    {
        get => GetArgument<TerraformSet<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for request_scheme_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockRequestSchemeConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_scheme_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for request_uri_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockRequestUriConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_uri_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for server_port_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockServerPortConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_port_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchValues is required")]
    public required TerraformSet<string> MatchValues
    {
        get => GetArgument<TerraformSet<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for socket_address_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockSocketAddressConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "socket_address_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for ssl_protocol_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockSslProtocolConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_protocol_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchValues is required")]
    public required TerraformSet<string> MatchValues
    {
        get => GetArgument<TerraformSet<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for url_file_extension_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockUrlFileExtensionConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_file_extension_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchValues is required")]
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for url_filename_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockUrlFilenameConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_filename_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for url_path_condition in AzurermCdnFrontdoorRuleConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlockUrlPathConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_path_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCdnFrontdoorRule.
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_cdn_frontdoor_rule Terraform resource.
/// Manages a azurerm_cdn_frontdoor_rule resource.
/// </summary>
public partial class AzurermCdnFrontdoorRule(string name) : TerraformResource("azurerm_cdn_frontdoor_rule", name)
{
    /// <summary>
    /// The behavior_on_match attribute.
    /// </summary>
    public TerraformValue<string>? BehaviorOnMatch
    {
        get => GetArgument<TerraformValue<string>>("behavior_on_match");
        set => SetArgument("behavior_on_match", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorRuleSetId is required")]
    public required TerraformValue<string> CdnFrontdoorRuleSetId
    {
        get => GetArgument<TerraformValue<string>>("cdn_frontdoor_rule_set_id");
        set => SetArgument("cdn_frontdoor_rule_set_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformValue<double> Order
    {
        get => GetArgument<TerraformValue<double>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_name attribute.
    /// </summary>
    public TerraformValue<string> CdnFrontdoorRuleSetName
        => AsReference("cdn_frontdoor_rule_set_name");

    /// <summary>
    /// Actions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Actions block(s) allowed")]
    public required TerraformList<AzurermCdnFrontdoorRuleActionsBlock> Actions
    {
        get => GetRequiredArgument<TerraformList<AzurermCdnFrontdoorRuleActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorRuleConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
