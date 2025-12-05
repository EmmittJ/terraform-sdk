using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in AwsLbListenerRuleDataSource.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformValue<double> Order
        => CreateReference("order");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// AuthenticateCognito block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceActionBlockAuthenticateCognitoBlock>? AuthenticateCognito
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceActionBlockAuthenticateCognitoBlock>>("authenticate_cognito");
        set => SetArgument("authenticate_cognito", value);
    }

    /// <summary>
    /// AuthenticateOidc block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceActionBlockAuthenticateOidcBlock>? AuthenticateOidc
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceActionBlockAuthenticateOidcBlock>>("authenticate_oidc");
        set => SetArgument("authenticate_oidc", value);
    }

    /// <summary>
    /// FixedResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceActionBlockFixedResponseBlock>? FixedResponse
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceActionBlockFixedResponseBlock>>("fixed_response");
        set => SetArgument("fixed_response", value);
    }

    /// <summary>
    /// Forward block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceActionBlockForwardBlock>? Forward
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceActionBlockForwardBlock>>("forward");
        set => SetArgument("forward", value);
    }

    /// <summary>
    /// Redirect block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceActionBlockRedirectBlock>? Redirect
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceActionBlockRedirectBlock>>("redirect");
        set => SetArgument("redirect", value);
    }

}

/// <summary>
/// Block type for authenticate_cognito in AwsLbListenerRuleDataSourceActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlockAuthenticateCognitoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authenticate_cognito";

    /// <summary>
    /// The authentication_request_extra_params attribute.
    /// </summary>
    public TerraformMap<string> AuthenticationRequestExtraParams
        => CreateReference("authentication_request_extra_params");

    /// <summary>
    /// The on_unauthenticated_request attribute.
    /// </summary>
    public TerraformValue<string> OnUnauthenticatedRequest
        => CreateReference("on_unauthenticated_request");

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string> Scope
        => CreateReference("scope");

    /// <summary>
    /// The session_cookie_name attribute.
    /// </summary>
    public TerraformValue<string> SessionCookieName
        => CreateReference("session_cookie_name");

    /// <summary>
    /// The session_timeout attribute.
    /// </summary>
    public TerraformValue<double> SessionTimeout
        => CreateReference("session_timeout");

    /// <summary>
    /// The user_pool_arn attribute.
    /// </summary>
    public TerraformValue<string> UserPoolArn
        => CreateReference("user_pool_arn");

    /// <summary>
    /// The user_pool_client_id attribute.
    /// </summary>
    public TerraformValue<string> UserPoolClientId
        => CreateReference("user_pool_client_id");

    /// <summary>
    /// The user_pool_domain attribute.
    /// </summary>
    public TerraformValue<string> UserPoolDomain
        => CreateReference("user_pool_domain");

}

/// <summary>
/// Block type for authenticate_oidc in AwsLbListenerRuleDataSourceActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlockAuthenticateOidcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authenticate_oidc";

    /// <summary>
    /// The authentication_request_extra_params attribute.
    /// </summary>
    public TerraformMap<string> AuthenticationRequestExtraParams
        => CreateReference("authentication_request_extra_params");

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationEndpoint
        => CreateReference("authorization_endpoint");

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string> ClientId
        => CreateReference("client_id");

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string> Issuer
        => CreateReference("issuer");

    /// <summary>
    /// The on_unauthenticated_request attribute.
    /// </summary>
    public TerraformValue<string> OnUnauthenticatedRequest
        => CreateReference("on_unauthenticated_request");

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string> Scope
        => CreateReference("scope");

    /// <summary>
    /// The session_cookie_name attribute.
    /// </summary>
    public TerraformValue<string> SessionCookieName
        => CreateReference("session_cookie_name");

    /// <summary>
    /// The session_timeout attribute.
    /// </summary>
    public TerraformValue<double> SessionTimeout
        => CreateReference("session_timeout");

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformValue<string> TokenEndpoint
        => CreateReference("token_endpoint");

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    public TerraformValue<string> UserInfoEndpoint
        => CreateReference("user_info_endpoint");

}

/// <summary>
/// Block type for fixed_response in AwsLbListenerRuleDataSourceActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlockFixedResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_response";

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformValue<string> ContentType
        => CreateReference("content_type");

    /// <summary>
    /// The message_body attribute.
    /// </summary>
    public TerraformValue<string> MessageBody
        => CreateReference("message_body");

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformValue<string> StatusCode
        => CreateReference("status_code");

}

/// <summary>
/// Block type for forward in AwsLbListenerRuleDataSourceActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlockForwardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forward";

    /// <summary>
    /// Stickiness block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceActionBlockForwardBlockStickinessBlock>? Stickiness
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceActionBlockForwardBlockStickinessBlock>>("stickiness");
        set => SetArgument("stickiness", value);
    }

    /// <summary>
    /// TargetGroup block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLbListenerRuleDataSourceActionBlockForwardBlockTargetGroupBlock>? TargetGroup
    {
        get => GetArgument<TerraformSet<AwsLbListenerRuleDataSourceActionBlockForwardBlockTargetGroupBlock>>("target_group");
        set => SetArgument("target_group", value);
    }

}

/// <summary>
/// Block type for stickiness in AwsLbListenerRuleDataSourceActionBlockForwardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlockForwardBlockStickinessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stickiness";

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<double> Duration
        => CreateReference("duration");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => CreateReference("enabled");

}

/// <summary>
/// Block type for target_group in AwsLbListenerRuleDataSourceActionBlockForwardBlock.
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlockForwardBlockTargetGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_group";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double> Weight
        => CreateReference("weight");

}

/// <summary>
/// Block type for redirect in AwsLbListenerRuleDataSourceActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlockRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redirect";

    /// <summary>
    /// The host attribute.
    /// </summary>
    public TerraformValue<string> Host
        => CreateReference("host");

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
        => CreateReference("path");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<string> Port
        => CreateReference("port");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
        => CreateReference("protocol");

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformValue<string> Query
        => CreateReference("query");

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformValue<string> StatusCode
        => CreateReference("status_code");

}


/// <summary>
/// Block type for condition in AwsLbListenerRuleDataSource.
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// HostHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceConditionBlockHostHeaderBlock>? HostHeader
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceConditionBlockHostHeaderBlock>>("host_header");
        set => SetArgument("host_header", value);
    }

    /// <summary>
    /// HttpHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceConditionBlockHttpHeaderBlock>? HttpHeader
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceConditionBlockHttpHeaderBlock>>("http_header");
        set => SetArgument("http_header", value);
    }

    /// <summary>
    /// HttpRequestMethod block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceConditionBlockHttpRequestMethodBlock>? HttpRequestMethod
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceConditionBlockHttpRequestMethodBlock>>("http_request_method");
        set => SetArgument("http_request_method", value);
    }

    /// <summary>
    /// PathPattern block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceConditionBlockPathPatternBlock>? PathPattern
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceConditionBlockPathPatternBlock>>("path_pattern");
        set => SetArgument("path_pattern", value);
    }

    /// <summary>
    /// QueryString block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceConditionBlockQueryStringBlock>? QueryString
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceConditionBlockQueryStringBlock>>("query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// SourceIp block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceConditionBlockSourceIpBlock>? SourceIp
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceConditionBlockSourceIpBlock>>("source_ip");
        set => SetArgument("source_ip", value);
    }

}

/// <summary>
/// Block type for host_header in AwsLbListenerRuleDataSourceConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlockHostHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_header";

    /// <summary>
    /// The regex_values attribute.
    /// </summary>
    public TerraformSet<string> RegexValues
        => CreateReference("regex_values");

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string> ValuesAttribute
        => CreateReference("values");

}

/// <summary>
/// Block type for http_header in AwsLbListenerRuleDataSourceConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlockHttpHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_header";

    /// <summary>
    /// The http_header_name attribute.
    /// </summary>
    public TerraformValue<string> HttpHeaderName
        => CreateReference("http_header_name");

    /// <summary>
    /// The regex_values attribute.
    /// </summary>
    public TerraformSet<string> RegexValues
        => CreateReference("regex_values");

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string> ValuesAttribute
        => CreateReference("values");

}

/// <summary>
/// Block type for http_request_method in AwsLbListenerRuleDataSourceConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlockHttpRequestMethodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_request_method";

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string> ValuesAttribute
        => CreateReference("values");

}

/// <summary>
/// Block type for path_pattern in AwsLbListenerRuleDataSourceConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlockPathPatternBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path_pattern";

    /// <summary>
    /// The regex_values attribute.
    /// </summary>
    public TerraformSet<string> RegexValues
        => CreateReference("regex_values");

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string> ValuesAttribute
        => CreateReference("values");

}

/// <summary>
/// Block type for query_string in AwsLbListenerRuleDataSourceConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlockQueryStringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_string";

    /// <summary>
    /// ValuesAttribute block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLbListenerRuleDataSourceConditionBlockQueryStringBlockValuesAttributeBlock>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<AwsLbListenerRuleDataSourceConditionBlockQueryStringBlockValuesAttributeBlock>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for values in AwsLbListenerRuleDataSourceConditionBlockQueryStringBlock.
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlockQueryStringBlockValuesAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "values";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
        => CreateReference("key");

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
        => CreateReference("value");

}

/// <summary>
/// Block type for source_ip in AwsLbListenerRuleDataSourceConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlockSourceIpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_ip";

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string> ValuesAttribute
        => CreateReference("values");

}


/// <summary>
/// Block type for transform in AwsLbListenerRuleDataSource.
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleDataSourceTransformBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transform";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// HostHeaderRewriteConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceTransformBlockHostHeaderRewriteConfigBlock>? HostHeaderRewriteConfig
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceTransformBlockHostHeaderRewriteConfigBlock>>("host_header_rewrite_config");
        set => SetArgument("host_header_rewrite_config", value);
    }

    /// <summary>
    /// UrlRewriteConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceTransformBlockUrlRewriteConfigBlock>? UrlRewriteConfig
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceTransformBlockUrlRewriteConfigBlock>>("url_rewrite_config");
        set => SetArgument("url_rewrite_config", value);
    }

}

/// <summary>
/// Block type for host_header_rewrite_config in AwsLbListenerRuleDataSourceTransformBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceTransformBlockHostHeaderRewriteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_header_rewrite_config";

    /// <summary>
    /// Rewrite block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceTransformBlockHostHeaderRewriteConfigBlockRewriteBlock>? Rewrite
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceTransformBlockHostHeaderRewriteConfigBlockRewriteBlock>>("rewrite");
        set => SetArgument("rewrite", value);
    }

}

/// <summary>
/// Block type for rewrite in AwsLbListenerRuleDataSourceTransformBlockHostHeaderRewriteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceTransformBlockHostHeaderRewriteConfigBlockRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rewrite";

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformValue<string> Regex
        => CreateReference("regex");

    /// <summary>
    /// The replace attribute.
    /// </summary>
    public TerraformValue<string> Replace
        => CreateReference("replace");

}

/// <summary>
/// Block type for url_rewrite_config in AwsLbListenerRuleDataSourceTransformBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceTransformBlockUrlRewriteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite_config";

    /// <summary>
    /// Rewrite block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceTransformBlockUrlRewriteConfigBlockRewriteBlock>? Rewrite
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceTransformBlockUrlRewriteConfigBlockRewriteBlock>>("rewrite");
        set => SetArgument("rewrite", value);
    }

}

/// <summary>
/// Block type for rewrite in AwsLbListenerRuleDataSourceTransformBlockUrlRewriteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceTransformBlockUrlRewriteConfigBlockRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rewrite";

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformValue<string> Regex
        => CreateReference("regex");

    /// <summary>
    /// The replace attribute.
    /// </summary>
    public TerraformValue<string> Replace
        => CreateReference("replace");

}


/// <summary>
/// Represents a aws_lb_listener_rule Terraform data source.
/// Retrieves information about a aws_lb_listener_rule.
/// </summary>
public partial class AwsLbListenerRuleDataSource(string name) : TerraformDataSource("aws_lb_listener_rule", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn") ?? CreateReference("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    public TerraformValue<string> ListenerArn
    {
        get => GetArgument<TerraformValue<string>>("listener_arn") ?? CreateReference("listener_arn");
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
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLbListenerRuleDataSourceActionBlock>? Action
    {
        get => GetArgument<TerraformList<AwsLbListenerRuleDataSourceActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Condition block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLbListenerRuleDataSourceConditionBlock>? Condition
    {
        get => GetArgument<TerraformSet<AwsLbListenerRuleDataSourceConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Transform block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLbListenerRuleDataSourceTransformBlock>? Transform
    {
        get => GetArgument<TerraformSet<AwsLbListenerRuleDataSourceTransformBlock>>("transform");
        set => SetArgument("transform", value);
    }

}
