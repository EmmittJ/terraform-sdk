using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in AwsLbListenerRule.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformValue<double>? Order
    {
        get => GetArgument<TerraformValue<double>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? TargetGroupArn
    {
        get => GetArgument<TerraformValue<string>>("target_group_arn");
        set => SetArgument("target_group_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// AuthenticateCognito block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticateCognito block(s) allowed")]
    public TerraformList<AwsLbListenerRuleActionBlockAuthenticateCognitoBlock>? AuthenticateCognito
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleActionBlockAuthenticateCognitoBlock>>("authenticate_cognito");
        set => SetArgument("authenticate_cognito", value);
    }

    /// <summary>
    /// AuthenticateOidc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticateOidc block(s) allowed")]
    public TerraformList<AwsLbListenerRuleActionBlockAuthenticateOidcBlock>? AuthenticateOidc
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleActionBlockAuthenticateOidcBlock>>("authenticate_oidc");
        set => SetArgument("authenticate_oidc", value);
    }

    /// <summary>
    /// FixedResponse block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedResponse block(s) allowed")]
    public TerraformList<AwsLbListenerRuleActionBlockFixedResponseBlock>? FixedResponse
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleActionBlockFixedResponseBlock>>("fixed_response");
        set => SetArgument("fixed_response", value);
    }

    /// <summary>
    /// Forward block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Forward block(s) allowed")]
    public TerraformList<AwsLbListenerRuleActionBlockForwardBlock>? Forward
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleActionBlockForwardBlock>>("forward");
        set => SetArgument("forward", value);
    }

    /// <summary>
    /// Redirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redirect block(s) allowed")]
    public TerraformList<AwsLbListenerRuleActionBlockRedirectBlock>? Redirect
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleActionBlockRedirectBlock>>("redirect");
        set => SetArgument("redirect", value);
    }

}

/// <summary>
/// Block type for authenticate_cognito in AwsLbListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleActionBlockAuthenticateCognitoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authenticate_cognito";

    /// <summary>
    /// The authentication_request_extra_params attribute.
    /// </summary>
    public TerraformMap<string>? AuthenticationRequestExtraParams
    {
        get => GetArgument<TerraformMap<string>>("authentication_request_extra_params");
        set => SetArgument("authentication_request_extra_params", value);
    }

    /// <summary>
    /// The on_unauthenticated_request attribute.
    /// </summary>
    public TerraformValue<string>? OnUnauthenticatedRequest
    {
        get => GetArgument<TerraformValue<string>>("on_unauthenticated_request");
        set => SetArgument("on_unauthenticated_request", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The session_cookie_name attribute.
    /// </summary>
    public TerraformValue<string>? SessionCookieName
    {
        get => GetArgument<TerraformValue<string>>("session_cookie_name");
        set => SetArgument("session_cookie_name", value);
    }

    /// <summary>
    /// The session_timeout attribute.
    /// </summary>
    public TerraformValue<double>? SessionTimeout
    {
        get => GetArgument<TerraformValue<double>>("session_timeout");
        set => SetArgument("session_timeout", value);
    }

    /// <summary>
    /// The user_pool_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolArn is required")]
    public required TerraformValue<string> UserPoolArn
    {
        get => GetArgument<TerraformValue<string>>("user_pool_arn");
        set => SetArgument("user_pool_arn", value);
    }

    /// <summary>
    /// The user_pool_client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolClientId is required")]
    public required TerraformValue<string> UserPoolClientId
    {
        get => GetArgument<TerraformValue<string>>("user_pool_client_id");
        set => SetArgument("user_pool_client_id", value);
    }

    /// <summary>
    /// The user_pool_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolDomain is required")]
    public required TerraformValue<string> UserPoolDomain
    {
        get => GetArgument<TerraformValue<string>>("user_pool_domain");
        set => SetArgument("user_pool_domain", value);
    }

}

/// <summary>
/// Block type for authenticate_oidc in AwsLbListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleActionBlockAuthenticateOidcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authenticate_oidc";

    /// <summary>
    /// The authentication_request_extra_params attribute.
    /// </summary>
    public TerraformMap<string>? AuthenticationRequestExtraParams
    {
        get => GetArgument<TerraformMap<string>>("authentication_request_extra_params");
        set => SetArgument("authentication_request_extra_params", value);
    }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    public required TerraformValue<string> AuthorizationEndpoint
    {
        get => GetArgument<TerraformValue<string>>("authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The on_unauthenticated_request attribute.
    /// </summary>
    public TerraformValue<string>? OnUnauthenticatedRequest
    {
        get => GetArgument<TerraformValue<string>>("on_unauthenticated_request");
        set => SetArgument("on_unauthenticated_request", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The session_cookie_name attribute.
    /// </summary>
    public TerraformValue<string>? SessionCookieName
    {
        get => GetArgument<TerraformValue<string>>("session_cookie_name");
        set => SetArgument("session_cookie_name", value);
    }

    /// <summary>
    /// The session_timeout attribute.
    /// </summary>
    public TerraformValue<double>? SessionTimeout
    {
        get => GetArgument<TerraformValue<double>>("session_timeout");
        set => SetArgument("session_timeout", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    public required TerraformValue<string> TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserInfoEndpoint is required")]
    public required TerraformValue<string> UserInfoEndpoint
    {
        get => GetArgument<TerraformValue<string>>("user_info_endpoint");
        set => SetArgument("user_info_endpoint", value);
    }

}

/// <summary>
/// Block type for fixed_response in AwsLbListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleActionBlockFixedResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_response";

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    public required TerraformValue<string> ContentType
    {
        get => GetArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The message_body attribute.
    /// </summary>
    public TerraformValue<string>? MessageBody
    {
        get => GetArgument<TerraformValue<string>>("message_body");
        set => SetArgument("message_body", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformValue<string>? StatusCode
    {
        get => GetArgument<TerraformValue<string>>("status_code");
        set => SetArgument("status_code", value);
    }

}

/// <summary>
/// Block type for forward in AwsLbListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleActionBlockForwardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forward";

    /// <summary>
    /// Stickiness block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stickiness block(s) allowed")]
    public TerraformList<AwsLbListenerRuleActionBlockForwardBlockStickinessBlock>? Stickiness
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleActionBlockForwardBlockStickinessBlock>>("stickiness");
        set => SetArgument("stickiness", value);
    }

    /// <summary>
    /// TargetGroup block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 TargetGroup block(s) allowed")]
    public required TerraformSet<AwsLbListenerRuleActionBlockForwardBlockTargetGroupBlock> TargetGroup
    {
        get => GetRequiredArgument<TerraformSet<AwsLbListenerRuleActionBlockForwardBlockTargetGroupBlock>>("target_group");
        set => SetArgument("target_group", value);
    }

}

/// <summary>
/// Block type for stickiness in AwsLbListenerRuleActionBlockForwardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleActionBlockForwardBlockStickinessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stickiness";

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<double> Duration
    {
        get => GetArgument<TerraformValue<double>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for target_group in AwsLbListenerRuleActionBlockForwardBlock.
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleActionBlockForwardBlockTargetGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_group";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for redirect in AwsLbListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleActionBlockRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redirect";

    /// <summary>
    /// The host attribute.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<string>? Port
    {
        get => GetArgument<TerraformValue<string>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformValue<string>? Query
    {
        get => GetArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<string> StatusCode
    {
        get => GetArgument<TerraformValue<string>>("status_code");
        set => SetArgument("status_code", value);
    }

}


/// <summary>
/// Block type for condition in AwsLbListenerRule.
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// HostHeader block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostHeader block(s) allowed")]
    public TerraformList<AwsLbListenerRuleConditionBlockHostHeaderBlock>? HostHeader
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleConditionBlockHostHeaderBlock>>("host_header");
        set => SetArgument("host_header", value);
    }

    /// <summary>
    /// HttpHeader block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpHeader block(s) allowed")]
    public TerraformList<AwsLbListenerRuleConditionBlockHttpHeaderBlock>? HttpHeader
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleConditionBlockHttpHeaderBlock>>("http_header");
        set => SetArgument("http_header", value);
    }

    /// <summary>
    /// HttpRequestMethod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpRequestMethod block(s) allowed")]
    public TerraformList<AwsLbListenerRuleConditionBlockHttpRequestMethodBlock>? HttpRequestMethod
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleConditionBlockHttpRequestMethodBlock>>("http_request_method");
        set => SetArgument("http_request_method", value);
    }

    /// <summary>
    /// PathPattern block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PathPattern block(s) allowed")]
    public TerraformList<AwsLbListenerRuleConditionBlockPathPatternBlock>? PathPattern
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleConditionBlockPathPatternBlock>>("path_pattern");
        set => SetArgument("path_pattern", value);
    }

    /// <summary>
    /// QueryString block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLbListenerRuleConditionBlockQueryStringBlock>? QueryString
    {
        get => GetArgument<TerraformSet<AwsLbListenerRuleConditionBlockQueryStringBlock>>("query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// SourceIp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceIp block(s) allowed")]
    public TerraformList<AwsLbListenerRuleConditionBlockSourceIpBlock>? SourceIp
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleConditionBlockSourceIpBlock>>("source_ip");
        set => SetArgument("source_ip", value);
    }

}

/// <summary>
/// Block type for host_header in AwsLbListenerRuleConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleConditionBlockHostHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_header";

    /// <summary>
    /// The regex_values attribute.
    /// </summary>
    public TerraformSet<string>? RegexValues
    {
        get => GetArgument<TerraformSet<string>>("regex_values");
        set => SetArgument("regex_values", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for http_header in AwsLbListenerRuleConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleConditionBlockHttpHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_header";

    /// <summary>
    /// The http_header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpHeaderName is required")]
    public required TerraformValue<string> HttpHeaderName
    {
        get => GetArgument<TerraformValue<string>>("http_header_name");
        set => SetArgument("http_header_name", value);
    }

    /// <summary>
    /// The regex_values attribute.
    /// </summary>
    public TerraformSet<string>? RegexValues
    {
        get => GetArgument<TerraformSet<string>>("regex_values");
        set => SetArgument("regex_values", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for http_request_method in AwsLbListenerRuleConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleConditionBlockHttpRequestMethodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_request_method";

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for path_pattern in AwsLbListenerRuleConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleConditionBlockPathPatternBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path_pattern";

    /// <summary>
    /// The regex_values attribute.
    /// </summary>
    public TerraformSet<string>? RegexValues
    {
        get => GetArgument<TerraformSet<string>>("regex_values");
        set => SetArgument("regex_values", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for query_string in AwsLbListenerRuleConditionBlock.
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleConditionBlockQueryStringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_string";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for source_ip in AwsLbListenerRuleConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleConditionBlockSourceIpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_ip";

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for transform in AwsLbListenerRule.
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleTransformBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transform";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// HostHeaderRewriteConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostHeaderRewriteConfig block(s) allowed")]
    public TerraformList<AwsLbListenerRuleTransformBlockHostHeaderRewriteConfigBlock>? HostHeaderRewriteConfig
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleTransformBlockHostHeaderRewriteConfigBlock>>("host_header_rewrite_config");
        set => SetArgument("host_header_rewrite_config", value);
    }

    /// <summary>
    /// UrlRewriteConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewriteConfig block(s) allowed")]
    public TerraformList<AwsLbListenerRuleTransformBlockUrlRewriteConfigBlock>? UrlRewriteConfig
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleTransformBlockUrlRewriteConfigBlock>>("url_rewrite_config");
        set => SetArgument("url_rewrite_config", value);
    }

}

/// <summary>
/// Block type for host_header_rewrite_config in AwsLbListenerRuleTransformBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleTransformBlockHostHeaderRewriteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_header_rewrite_config";

    /// <summary>
    /// Rewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rewrite block(s) allowed")]
    public TerraformList<AwsLbListenerRuleTransformBlockHostHeaderRewriteConfigBlockRewriteBlock>? Rewrite
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleTransformBlockHostHeaderRewriteConfigBlockRewriteBlock>>("rewrite");
        set => SetArgument("rewrite", value);
    }

}

/// <summary>
/// Block type for rewrite in AwsLbListenerRuleTransformBlockHostHeaderRewriteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleTransformBlockHostHeaderRewriteConfigBlockRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rewrite";

    /// <summary>
    /// The regex attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regex is required")]
    public required TerraformValue<string> Regex
    {
        get => GetArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// The replace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replace is required")]
    public required TerraformValue<string> Replace
    {
        get => GetArgument<TerraformValue<string>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for url_rewrite_config in AwsLbListenerRuleTransformBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleTransformBlockUrlRewriteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite_config";

    /// <summary>
    /// Rewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rewrite block(s) allowed")]
    public TerraformList<AwsLbListenerRuleTransformBlockUrlRewriteConfigBlockRewriteBlock>? Rewrite
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleTransformBlockUrlRewriteConfigBlockRewriteBlock>>("rewrite");
        set => SetArgument("rewrite", value);
    }

}

/// <summary>
/// Block type for rewrite in AwsLbListenerRuleTransformBlockUrlRewriteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleTransformBlockUrlRewriteConfigBlockRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rewrite";

    /// <summary>
    /// The regex attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regex is required")]
    public required TerraformValue<string> Regex
    {
        get => GetArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// The replace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replace is required")]
    public required TerraformValue<string> Replace
    {
        get => GetArgument<TerraformValue<string>>("replace");
        set => SetArgument("replace", value);
    }

}


/// <summary>
/// Represents a aws_lb_listener_rule Terraform resource.
/// Manages a aws_lb_listener_rule resource.
/// </summary>
public partial class AwsLbListenerRule(string name) : TerraformResource("aws_lb_listener_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    public required TerraformValue<string> ListenerArn
    {
        get => GetArgument<TerraformValue<string>>("listener_arn");
        set => SetArgument("listener_arn", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    public required TerraformList<AwsLbListenerRuleActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsLbListenerRuleActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Condition block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Condition block(s) required")]
    public required TerraformSet<AwsLbListenerRuleConditionBlock> Condition
    {
        get => GetRequiredArgument<TerraformSet<AwsLbListenerRuleConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Transform block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Transform block(s) allowed")]
    public TerraformSet<AwsLbListenerRuleTransformBlock>? Transform
    {
        get => GetArgument<TerraformSet<AwsLbListenerRuleTransformBlock>>("transform");
        set => SetArgument("transform", value);
    }

}
