using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in AwsAlbListenerRule.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformValue<double> Order
    {
        get => GetArgument<TerraformValue<double>>("order") ?? CreateReference("order");
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
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// AuthenticateCognito block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticateCognito block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleActionBlockAuthenticateCognitoBlock>? AuthenticateCognito
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleActionBlockAuthenticateCognitoBlock>>("authenticate_cognito");
        set => SetArgument("authenticate_cognito", value);
    }

    /// <summary>
    /// AuthenticateOidc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticateOidc block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleActionBlockAuthenticateOidcBlock>? AuthenticateOidc
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleActionBlockAuthenticateOidcBlock>>("authenticate_oidc");
        set => SetArgument("authenticate_oidc", value);
    }

    /// <summary>
    /// FixedResponse block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedResponse block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleActionBlockFixedResponseBlock>? FixedResponse
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleActionBlockFixedResponseBlock>>("fixed_response");
        set => SetArgument("fixed_response", value);
    }

    /// <summary>
    /// Forward block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Forward block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleActionBlockForwardBlock>? Forward
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleActionBlockForwardBlock>>("forward");
        set => SetArgument("forward", value);
    }

    /// <summary>
    /// Redirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redirect block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleActionBlockRedirectBlock>? Redirect
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleActionBlockRedirectBlock>>("redirect");
        set => SetArgument("redirect", value);
    }

}

/// <summary>
/// Block type for authenticate_cognito in AwsAlbListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleActionBlockAuthenticateCognitoBlock : TerraformBlock
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
    public TerraformValue<string> OnUnauthenticatedRequest
    {
        get => GetArgument<TerraformValue<string>>("on_unauthenticated_request") ?? CreateReference("on_unauthenticated_request");
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
        get => GetRequiredArgument<TerraformValue<string>>("user_pool_arn");
        set => SetArgument("user_pool_arn", value);
    }

    /// <summary>
    /// The user_pool_client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolClientId is required")]
    public required TerraformValue<string> UserPoolClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_pool_client_id");
        set => SetArgument("user_pool_client_id", value);
    }

    /// <summary>
    /// The user_pool_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolDomain is required")]
    public required TerraformValue<string> UserPoolDomain
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_pool_domain");
        set => SetArgument("user_pool_domain", value);
    }

}

/// <summary>
/// Block type for authenticate_oidc in AwsAlbListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleActionBlockAuthenticateOidcBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetRequiredArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The on_unauthenticated_request attribute.
    /// </summary>
    public TerraformValue<string> OnUnauthenticatedRequest
    {
        get => GetArgument<TerraformValue<string>>("on_unauthenticated_request") ?? CreateReference("on_unauthenticated_request");
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
        get => GetRequiredArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserInfoEndpoint is required")]
    public required TerraformValue<string> UserInfoEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_info_endpoint");
        set => SetArgument("user_info_endpoint", value);
    }

}

/// <summary>
/// Block type for fixed_response in AwsAlbListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleActionBlockFixedResponseBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("content_type");
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
    public TerraformValue<string> StatusCode
    {
        get => GetArgument<TerraformValue<string>>("status_code") ?? CreateReference("status_code");
        set => SetArgument("status_code", value);
    }

}

/// <summary>
/// Block type for forward in AwsAlbListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleActionBlockForwardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forward";

    /// <summary>
    /// Stickiness block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stickiness block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleActionBlockForwardBlockStickinessBlock>? Stickiness
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleActionBlockForwardBlockStickinessBlock>>("stickiness");
        set => SetArgument("stickiness", value);
    }

    /// <summary>
    /// TargetGroup block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 TargetGroup block(s) allowed")]
    public required TerraformSet<AwsAlbListenerRuleActionBlockForwardBlockTargetGroupBlock> TargetGroup
    {
        get => GetRequiredArgument<TerraformSet<AwsAlbListenerRuleActionBlockForwardBlockTargetGroupBlock>>("target_group");
        set => SetArgument("target_group", value);
    }

}

/// <summary>
/// Block type for stickiness in AwsAlbListenerRuleActionBlockForwardBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleActionBlockForwardBlockStickinessBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("duration");
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
/// Block type for target_group in AwsAlbListenerRuleActionBlockForwardBlock.
/// Nesting mode: set
/// </summary>
public class AwsAlbListenerRuleActionBlockForwardBlockTargetGroupBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("arn");
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
/// Block type for redirect in AwsAlbListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleActionBlockRedirectBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("status_code");
        set => SetArgument("status_code", value);
    }

}


/// <summary>
/// Block type for condition in AwsAlbListenerRule.
/// Nesting mode: set
/// </summary>
public class AwsAlbListenerRuleConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// HostHeader block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostHeader block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleConditionBlockHostHeaderBlock>? HostHeader
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleConditionBlockHostHeaderBlock>>("host_header");
        set => SetArgument("host_header", value);
    }

    /// <summary>
    /// HttpHeader block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpHeader block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleConditionBlockHttpHeaderBlock>? HttpHeader
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleConditionBlockHttpHeaderBlock>>("http_header");
        set => SetArgument("http_header", value);
    }

    /// <summary>
    /// HttpRequestMethod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpRequestMethod block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleConditionBlockHttpRequestMethodBlock>? HttpRequestMethod
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleConditionBlockHttpRequestMethodBlock>>("http_request_method");
        set => SetArgument("http_request_method", value);
    }

    /// <summary>
    /// PathPattern block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PathPattern block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleConditionBlockPathPatternBlock>? PathPattern
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleConditionBlockPathPatternBlock>>("path_pattern");
        set => SetArgument("path_pattern", value);
    }

    /// <summary>
    /// QueryString block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAlbListenerRuleConditionBlockQueryStringBlock>? QueryString
    {
        get => GetArgument<TerraformSet<AwsAlbListenerRuleConditionBlockQueryStringBlock>>("query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// SourceIp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceIp block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleConditionBlockSourceIpBlock>? SourceIp
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleConditionBlockSourceIpBlock>>("source_ip");
        set => SetArgument("source_ip", value);
    }

}

/// <summary>
/// Block type for host_header in AwsAlbListenerRuleConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleConditionBlockHostHeaderBlock : TerraformBlock
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
/// Block type for http_header in AwsAlbListenerRuleConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleConditionBlockHttpHeaderBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("http_header_name");
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
/// Block type for http_request_method in AwsAlbListenerRuleConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleConditionBlockHttpRequestMethodBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for path_pattern in AwsAlbListenerRuleConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleConditionBlockPathPatternBlock : TerraformBlock
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
/// Block type for query_string in AwsAlbListenerRuleConditionBlock.
/// Nesting mode: set
/// </summary>
public class AwsAlbListenerRuleConditionBlockQueryStringBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for source_ip in AwsAlbListenerRuleConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleConditionBlockSourceIpBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for transform in AwsAlbListenerRule.
/// Nesting mode: set
/// </summary>
public class AwsAlbListenerRuleTransformBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// HostHeaderRewriteConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostHeaderRewriteConfig block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleTransformBlockHostHeaderRewriteConfigBlock>? HostHeaderRewriteConfig
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleTransformBlockHostHeaderRewriteConfigBlock>>("host_header_rewrite_config");
        set => SetArgument("host_header_rewrite_config", value);
    }

    /// <summary>
    /// UrlRewriteConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewriteConfig block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleTransformBlockUrlRewriteConfigBlock>? UrlRewriteConfig
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleTransformBlockUrlRewriteConfigBlock>>("url_rewrite_config");
        set => SetArgument("url_rewrite_config", value);
    }

}

/// <summary>
/// Block type for host_header_rewrite_config in AwsAlbListenerRuleTransformBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleTransformBlockHostHeaderRewriteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_header_rewrite_config";

    /// <summary>
    /// Rewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rewrite block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleTransformBlockHostHeaderRewriteConfigBlockRewriteBlock>? Rewrite
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleTransformBlockHostHeaderRewriteConfigBlockRewriteBlock>>("rewrite");
        set => SetArgument("rewrite", value);
    }

}

/// <summary>
/// Block type for rewrite in AwsAlbListenerRuleTransformBlockHostHeaderRewriteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleTransformBlockHostHeaderRewriteConfigBlockRewriteBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// The replace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replace is required")]
    public required TerraformValue<string> Replace
    {
        get => GetRequiredArgument<TerraformValue<string>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for url_rewrite_config in AwsAlbListenerRuleTransformBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleTransformBlockUrlRewriteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite_config";

    /// <summary>
    /// Rewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rewrite block(s) allowed")]
    public TerraformList<AwsAlbListenerRuleTransformBlockUrlRewriteConfigBlockRewriteBlock>? Rewrite
    {
        get => GetArgument<TerraformList<AwsAlbListenerRuleTransformBlockUrlRewriteConfigBlockRewriteBlock>>("rewrite");
        set => SetArgument("rewrite", value);
    }

}

/// <summary>
/// Block type for rewrite in AwsAlbListenerRuleTransformBlockUrlRewriteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerRuleTransformBlockUrlRewriteConfigBlockRewriteBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// The replace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replace is required")]
    public required TerraformValue<string> Replace
    {
        get => GetRequiredArgument<TerraformValue<string>>("replace");
        set => SetArgument("replace", value);
    }

}


/// <summary>
/// Represents a aws_alb_listener_rule Terraform resource.
/// Manages a aws_alb_listener_rule resource.
/// </summary>
public partial class AwsAlbListenerRule(string name) : TerraformResource("aws_alb_listener_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    public required TerraformValue<string> ListenerArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("listener_arn");
        set => SetArgument("listener_arn", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority") ?? CreateReference("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    public required TerraformList<AwsAlbListenerRuleActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsAlbListenerRuleActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Condition block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Condition block(s) required")]
    public required TerraformSet<AwsAlbListenerRuleConditionBlock> Condition
    {
        get => GetRequiredArgument<TerraformSet<AwsAlbListenerRuleConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Transform block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Transform block(s) allowed")]
    public TerraformSet<AwsAlbListenerRuleTransformBlock>? Transform
    {
        get => GetArgument<TerraformSet<AwsAlbListenerRuleTransformBlock>>("transform");
        set => SetArgument("transform", value);
    }

}
