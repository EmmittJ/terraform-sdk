using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for delivery_rule in AzurermCdnEndpoint.
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

    /// <summary>
    /// CacheExpirationAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheExpirationAction block(s) allowed")]
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockCacheExpirationActionBlock>? CacheExpirationAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockCacheExpirationActionBlock>>("cache_expiration_action");
        set => SetArgument("cache_expiration_action", value);
    }

    /// <summary>
    /// CacheKeyQueryStringAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheKeyQueryStringAction block(s) allowed")]
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockCacheKeyQueryStringActionBlock>? CacheKeyQueryStringAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockCacheKeyQueryStringActionBlock>>("cache_key_query_string_action");
        set => SetArgument("cache_key_query_string_action", value);
    }

    /// <summary>
    /// CookiesCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockCookiesConditionBlock>? CookiesCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockCookiesConditionBlock>>("cookies_condition");
        set => SetArgument("cookies_condition", value);
    }

    /// <summary>
    /// DeviceCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceCondition block(s) allowed")]
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockDeviceConditionBlock>? DeviceCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockDeviceConditionBlock>>("device_condition");
        set => SetArgument("device_condition", value);
    }

    /// <summary>
    /// HttpVersionCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockHttpVersionConditionBlock>? HttpVersionCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockHttpVersionConditionBlock>>("http_version_condition");
        set => SetArgument("http_version_condition", value);
    }

    /// <summary>
    /// ModifyRequestHeaderAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockModifyRequestHeaderActionBlock>? ModifyRequestHeaderAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockModifyRequestHeaderActionBlock>>("modify_request_header_action");
        set => SetArgument("modify_request_header_action", value);
    }

    /// <summary>
    /// ModifyResponseHeaderAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockModifyResponseHeaderActionBlock>? ModifyResponseHeaderAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockModifyResponseHeaderActionBlock>>("modify_response_header_action");
        set => SetArgument("modify_response_header_action", value);
    }

    /// <summary>
    /// PostArgCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockPostArgConditionBlock>? PostArgCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockPostArgConditionBlock>>("post_arg_condition");
        set => SetArgument("post_arg_condition", value);
    }

    /// <summary>
    /// QueryStringCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockQueryStringConditionBlock>? QueryStringCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockQueryStringConditionBlock>>("query_string_condition");
        set => SetArgument("query_string_condition", value);
    }

    /// <summary>
    /// RemoteAddressCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockRemoteAddressConditionBlock>? RemoteAddressCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockRemoteAddressConditionBlock>>("remote_address_condition");
        set => SetArgument("remote_address_condition", value);
    }

    /// <summary>
    /// RequestBodyCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockRequestBodyConditionBlock>? RequestBodyCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockRequestBodyConditionBlock>>("request_body_condition");
        set => SetArgument("request_body_condition", value);
    }

    /// <summary>
    /// RequestHeaderCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockRequestHeaderConditionBlock>? RequestHeaderCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockRequestHeaderConditionBlock>>("request_header_condition");
        set => SetArgument("request_header_condition", value);
    }

    /// <summary>
    /// RequestMethodCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestMethodCondition block(s) allowed")]
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockRequestMethodConditionBlock>? RequestMethodCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockRequestMethodConditionBlock>>("request_method_condition");
        set => SetArgument("request_method_condition", value);
    }

    /// <summary>
    /// RequestSchemeCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestSchemeCondition block(s) allowed")]
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockRequestSchemeConditionBlock>? RequestSchemeCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockRequestSchemeConditionBlock>>("request_scheme_condition");
        set => SetArgument("request_scheme_condition", value);
    }

    /// <summary>
    /// RequestUriCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockRequestUriConditionBlock>? RequestUriCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockRequestUriConditionBlock>>("request_uri_condition");
        set => SetArgument("request_uri_condition", value);
    }

    /// <summary>
    /// UrlFileExtensionCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockUrlFileExtensionConditionBlock>? UrlFileExtensionCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockUrlFileExtensionConditionBlock>>("url_file_extension_condition");
        set => SetArgument("url_file_extension_condition", value);
    }

    /// <summary>
    /// UrlFileNameCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockUrlFileNameConditionBlock>? UrlFileNameCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockUrlFileNameConditionBlock>>("url_file_name_condition");
        set => SetArgument("url_file_name_condition", value);
    }

    /// <summary>
    /// UrlPathCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockUrlPathConditionBlock>? UrlPathCondition
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockUrlPathConditionBlock>>("url_path_condition");
        set => SetArgument("url_path_condition", value);
    }

    /// <summary>
    /// UrlRedirectAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRedirectAction block(s) allowed")]
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockUrlRedirectActionBlock>? UrlRedirectAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockUrlRedirectActionBlock>>("url_redirect_action");
        set => SetArgument("url_redirect_action", value);
    }

    /// <summary>
    /// UrlRewriteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewriteAction block(s) allowed")]
    public TerraformList<AzurermCdnEndpointDeliveryRuleBlockUrlRewriteActionBlock>? UrlRewriteAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointDeliveryRuleBlockUrlRewriteActionBlock>>("url_rewrite_action");
        set => SetArgument("url_rewrite_action", value);
    }

}

/// <summary>
/// Block type for cache_expiration_action in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockCacheExpirationActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_expiration_action";

    /// <summary>
    /// The behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformValue<string> Behavior
    {
        get => new TerraformReference<string>(this, "behavior");
        set => SetArgument("behavior", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

}

/// <summary>
/// Block type for cache_key_query_string_action in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockCacheKeyQueryStringActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_key_query_string_action";

    /// <summary>
    /// The behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformValue<string> Behavior
    {
        get => new TerraformReference<string>(this, "behavior");
        set => SetArgument("behavior", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => new TerraformReference<string>(this, "parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for cookies_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockCookiesConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cookies_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformSet<string>? MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    public required TerraformValue<string> Selector
    {
        get => new TerraformReference<string>(this, "selector");
        set => SetArgument("selector", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transforms").ResolveNodes(ctx));
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for device_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockDeviceConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "device_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchValues is required")]
    public required TerraformSet<string> MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for http_version_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockHttpVersionConditionBlock : TerraformBlock
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for modify_request_header_action in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockModifyRequestHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "modify_request_header_action";

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for modify_response_header_action in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockModifyResponseHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "modify_response_header_action";

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for post_arg_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockPostArgConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_arg_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformSet<string>? MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    public required TerraformValue<string> Selector
    {
        get => new TerraformReference<string>(this, "selector");
        set => SetArgument("selector", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transforms").ResolveNodes(ctx));
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for query_string_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockQueryStringConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_string_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformSet<string>? MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transforms").ResolveNodes(ctx));
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for remote_address_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockRemoteAddressConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote_address_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformSet<string>? MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for request_body_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockRequestBodyConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_body_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformSet<string>? MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transforms").ResolveNodes(ctx));
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for request_header_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockRequestHeaderConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformSet<string>? MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    public required TerraformValue<string> Selector
    {
        get => new TerraformReference<string>(this, "selector");
        set => SetArgument("selector", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transforms").ResolveNodes(ctx));
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for request_method_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockRequestMethodConditionBlock : TerraformBlock
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for request_scheme_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockRequestSchemeConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_scheme_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchValues is required")]
    public required TerraformSet<string> MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

}

/// <summary>
/// Block type for request_uri_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockRequestUriConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_uri_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformSet<string>? MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transforms").ResolveNodes(ctx));
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for url_file_extension_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockUrlFileExtensionConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_file_extension_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformSet<string>? MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transforms").ResolveNodes(ctx));
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for url_file_name_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockUrlFileNameConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_file_name_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformSet<string>? MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transforms").ResolveNodes(ctx));
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for url_path_condition in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockUrlPathConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_path_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformSet<string>? MatchValues
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => new TerraformReference<bool>(this, "negate_condition");
        set => SetArgument("negate_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transforms").ResolveNodes(ctx));
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for url_redirect_action in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockUrlRedirectActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_redirect_action";

    /// <summary>
    /// The fragment attribute.
    /// </summary>
    public TerraformValue<string>? Fragment
    {
        get => new TerraformReference<string>(this, "fragment");
        set => SetArgument("fragment", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string>? Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    public TerraformValue<string>? QueryString
    {
        get => new TerraformReference<string>(this, "query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    public required TerraformValue<string> RedirectType
    {
        get => new TerraformReference<string>(this, "redirect_type");
        set => SetArgument("redirect_type", value);
    }

}

/// <summary>
/// Block type for url_rewrite_action in AzurermCdnEndpointDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointDeliveryRuleBlockUrlRewriteActionBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The preserve_unmatched_path attribute.
    /// </summary>
    public TerraformValue<bool>? PreserveUnmatchedPath
    {
        get => new TerraformReference<bool>(this, "preserve_unmatched_path");
        set => SetArgument("preserve_unmatched_path", value);
    }

    /// <summary>
    /// The source_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePattern is required")]
    public required TerraformValue<string> SourcePattern
    {
        get => new TerraformReference<string>(this, "source_pattern");
        set => SetArgument("source_pattern", value);
    }

}


/// <summary>
/// Block type for geo_filter in AzurermCdnEndpoint.
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
/// Block type for global_delivery_rule in AzurermCdnEndpoint.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGlobalDeliveryRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "global_delivery_rule";

    /// <summary>
    /// CacheExpirationAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheExpirationAction block(s) allowed")]
    public TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockCacheExpirationActionBlock>? CacheExpirationAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockCacheExpirationActionBlock>>("cache_expiration_action");
        set => SetArgument("cache_expiration_action", value);
    }

    /// <summary>
    /// CacheKeyQueryStringAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheKeyQueryStringAction block(s) allowed")]
    public TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockCacheKeyQueryStringActionBlock>? CacheKeyQueryStringAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockCacheKeyQueryStringActionBlock>>("cache_key_query_string_action");
        set => SetArgument("cache_key_query_string_action", value);
    }

    /// <summary>
    /// ModifyRequestHeaderAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockModifyRequestHeaderActionBlock>? ModifyRequestHeaderAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockModifyRequestHeaderActionBlock>>("modify_request_header_action");
        set => SetArgument("modify_request_header_action", value);
    }

    /// <summary>
    /// ModifyResponseHeaderAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockModifyResponseHeaderActionBlock>? ModifyResponseHeaderAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockModifyResponseHeaderActionBlock>>("modify_response_header_action");
        set => SetArgument("modify_response_header_action", value);
    }

    /// <summary>
    /// UrlRedirectAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRedirectAction block(s) allowed")]
    public TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockUrlRedirectActionBlock>? UrlRedirectAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockUrlRedirectActionBlock>>("url_redirect_action");
        set => SetArgument("url_redirect_action", value);
    }

    /// <summary>
    /// UrlRewriteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewriteAction block(s) allowed")]
    public TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockUrlRewriteActionBlock>? UrlRewriteAction
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointGlobalDeliveryRuleBlockUrlRewriteActionBlock>>("url_rewrite_action");
        set => SetArgument("url_rewrite_action", value);
    }

}

/// <summary>
/// Block type for cache_expiration_action in AzurermCdnEndpointGlobalDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGlobalDeliveryRuleBlockCacheExpirationActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_expiration_action";

    /// <summary>
    /// The behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformValue<string> Behavior
    {
        get => new TerraformReference<string>(this, "behavior");
        set => SetArgument("behavior", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

}

/// <summary>
/// Block type for cache_key_query_string_action in AzurermCdnEndpointGlobalDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGlobalDeliveryRuleBlockCacheKeyQueryStringActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_key_query_string_action";

    /// <summary>
    /// The behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformValue<string> Behavior
    {
        get => new TerraformReference<string>(this, "behavior");
        set => SetArgument("behavior", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => new TerraformReference<string>(this, "parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for modify_request_header_action in AzurermCdnEndpointGlobalDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGlobalDeliveryRuleBlockModifyRequestHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "modify_request_header_action";

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for modify_response_header_action in AzurermCdnEndpointGlobalDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGlobalDeliveryRuleBlockModifyResponseHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "modify_response_header_action";

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for url_redirect_action in AzurermCdnEndpointGlobalDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGlobalDeliveryRuleBlockUrlRedirectActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_redirect_action";

    /// <summary>
    /// The fragment attribute.
    /// </summary>
    public TerraformValue<string>? Fragment
    {
        get => new TerraformReference<string>(this, "fragment");
        set => SetArgument("fragment", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string>? Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    public TerraformValue<string>? QueryString
    {
        get => new TerraformReference<string>(this, "query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    public required TerraformValue<string> RedirectType
    {
        get => new TerraformReference<string>(this, "redirect_type");
        set => SetArgument("redirect_type", value);
    }

}

/// <summary>
/// Block type for url_rewrite_action in AzurermCdnEndpointGlobalDeliveryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointGlobalDeliveryRuleBlockUrlRewriteActionBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The preserve_unmatched_path attribute.
    /// </summary>
    public TerraformValue<bool>? PreserveUnmatchedPath
    {
        get => new TerraformReference<bool>(this, "preserve_unmatched_path");
        set => SetArgument("preserve_unmatched_path", value);
    }

    /// <summary>
    /// The source_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePattern is required")]
    public required TerraformValue<string> SourcePattern
    {
        get => new TerraformReference<string>(this, "source_pattern");
        set => SetArgument("source_pattern", value);
    }

}


/// <summary>
/// Block type for origin in AzurermCdnEndpoint.
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
/// Block type for timeouts in AzurermCdnEndpoint.
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
