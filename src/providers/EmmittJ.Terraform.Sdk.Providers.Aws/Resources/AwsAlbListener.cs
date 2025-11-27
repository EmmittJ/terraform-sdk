using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in AwsAlbListener.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerDefaultActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_action";

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformValue<double> Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? TargetGroupArn
    {
        get => new TerraformReference<string>(this, "target_group_arn");
        set => SetArgument("target_group_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// AuthenticateCognito block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticateCognito block(s) allowed")]
    public TerraformList<AwsAlbListenerDefaultActionBlockAuthenticateCognitoBlock>? AuthenticateCognito
    {
        get => GetArgument<TerraformList<AwsAlbListenerDefaultActionBlockAuthenticateCognitoBlock>>("authenticate_cognito");
        set => SetArgument("authenticate_cognito", value);
    }

    /// <summary>
    /// AuthenticateOidc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticateOidc block(s) allowed")]
    public TerraformList<AwsAlbListenerDefaultActionBlockAuthenticateOidcBlock>? AuthenticateOidc
    {
        get => GetArgument<TerraformList<AwsAlbListenerDefaultActionBlockAuthenticateOidcBlock>>("authenticate_oidc");
        set => SetArgument("authenticate_oidc", value);
    }

    /// <summary>
    /// FixedResponse block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedResponse block(s) allowed")]
    public TerraformList<AwsAlbListenerDefaultActionBlockFixedResponseBlock>? FixedResponse
    {
        get => GetArgument<TerraformList<AwsAlbListenerDefaultActionBlockFixedResponseBlock>>("fixed_response");
        set => SetArgument("fixed_response", value);
    }

    /// <summary>
    /// Forward block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Forward block(s) allowed")]
    public TerraformList<AwsAlbListenerDefaultActionBlockForwardBlock>? Forward
    {
        get => GetArgument<TerraformList<AwsAlbListenerDefaultActionBlockForwardBlock>>("forward");
        set => SetArgument("forward", value);
    }

    /// <summary>
    /// Redirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redirect block(s) allowed")]
    public TerraformList<AwsAlbListenerDefaultActionBlockRedirectBlock>? Redirect
    {
        get => GetArgument<TerraformList<AwsAlbListenerDefaultActionBlockRedirectBlock>>("redirect");
        set => SetArgument("redirect", value);
    }

}

/// <summary>
/// Block type for authenticate_cognito in AwsAlbListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerDefaultActionBlockAuthenticateCognitoBlock : TerraformBlock
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "authentication_request_extra_params").ResolveNodes(ctx));
        set => SetArgument("authentication_request_extra_params", value);
    }

    /// <summary>
    /// The on_unauthenticated_request attribute.
    /// </summary>
    public TerraformValue<string> OnUnauthenticatedRequest
    {
        get => new TerraformReference<string>(this, "on_unauthenticated_request");
        set => SetArgument("on_unauthenticated_request", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The session_cookie_name attribute.
    /// </summary>
    public TerraformValue<string> SessionCookieName
    {
        get => new TerraformReference<string>(this, "session_cookie_name");
        set => SetArgument("session_cookie_name", value);
    }

    /// <summary>
    /// The session_timeout attribute.
    /// </summary>
    public TerraformValue<double> SessionTimeout
    {
        get => new TerraformReference<double>(this, "session_timeout");
        set => SetArgument("session_timeout", value);
    }

    /// <summary>
    /// The user_pool_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolArn is required")]
    public required TerraformValue<string> UserPoolArn
    {
        get => new TerraformReference<string>(this, "user_pool_arn");
        set => SetArgument("user_pool_arn", value);
    }

    /// <summary>
    /// The user_pool_client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolClientId is required")]
    public required TerraformValue<string> UserPoolClientId
    {
        get => new TerraformReference<string>(this, "user_pool_client_id");
        set => SetArgument("user_pool_client_id", value);
    }

    /// <summary>
    /// The user_pool_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolDomain is required")]
    public required TerraformValue<string> UserPoolDomain
    {
        get => new TerraformReference<string>(this, "user_pool_domain");
        set => SetArgument("user_pool_domain", value);
    }

}

/// <summary>
/// Block type for authenticate_oidc in AwsAlbListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerDefaultActionBlockAuthenticateOidcBlock : TerraformBlock
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "authentication_request_extra_params").ResolveNodes(ctx));
        set => SetArgument("authentication_request_extra_params", value);
    }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    public required TerraformValue<string> AuthorizationEndpoint
    {
        get => new TerraformReference<string>(this, "authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The on_unauthenticated_request attribute.
    /// </summary>
    public TerraformValue<string> OnUnauthenticatedRequest
    {
        get => new TerraformReference<string>(this, "on_unauthenticated_request");
        set => SetArgument("on_unauthenticated_request", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The session_cookie_name attribute.
    /// </summary>
    public TerraformValue<string> SessionCookieName
    {
        get => new TerraformReference<string>(this, "session_cookie_name");
        set => SetArgument("session_cookie_name", value);
    }

    /// <summary>
    /// The session_timeout attribute.
    /// </summary>
    public TerraformValue<double> SessionTimeout
    {
        get => new TerraformReference<double>(this, "session_timeout");
        set => SetArgument("session_timeout", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    public required TerraformValue<string> TokenEndpoint
    {
        get => new TerraformReference<string>(this, "token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserInfoEndpoint is required")]
    public required TerraformValue<string> UserInfoEndpoint
    {
        get => new TerraformReference<string>(this, "user_info_endpoint");
        set => SetArgument("user_info_endpoint", value);
    }

}

/// <summary>
/// Block type for fixed_response in AwsAlbListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerDefaultActionBlockFixedResponseBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The message_body attribute.
    /// </summary>
    public TerraformValue<string>? MessageBody
    {
        get => new TerraformReference<string>(this, "message_body");
        set => SetArgument("message_body", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformValue<string> StatusCode
    {
        get => new TerraformReference<string>(this, "status_code");
        set => SetArgument("status_code", value);
    }

}

/// <summary>
/// Block type for forward in AwsAlbListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerDefaultActionBlockForwardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forward";

    /// <summary>
    /// Stickiness block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stickiness block(s) allowed")]
    public TerraformList<AwsAlbListenerDefaultActionBlockForwardBlockStickinessBlock>? Stickiness
    {
        get => GetArgument<TerraformList<AwsAlbListenerDefaultActionBlockForwardBlockStickinessBlock>>("stickiness");
        set => SetArgument("stickiness", value);
    }

    /// <summary>
    /// TargetGroup block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 TargetGroup block(s) allowed")]
    public required TerraformSet<AwsAlbListenerDefaultActionBlockForwardBlockTargetGroupBlock> TargetGroup
    {
        get => GetRequiredArgument<TerraformSet<AwsAlbListenerDefaultActionBlockForwardBlockTargetGroupBlock>>("target_group");
        set => SetArgument("target_group", value);
    }

}

/// <summary>
/// Block type for stickiness in AwsAlbListenerDefaultActionBlockForwardBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerDefaultActionBlockForwardBlockStickinessBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for target_group in AwsAlbListenerDefaultActionBlockForwardBlock.
/// Nesting mode: set
/// </summary>
public class AwsAlbListenerDefaultActionBlockForwardBlockTargetGroupBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for redirect in AwsAlbListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerDefaultActionBlockRedirectBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
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
    /// The port attribute.
    /// </summary>
    public TerraformValue<string>? Port
    {
        get => new TerraformReference<string>(this, "port");
        set => SetArgument("port", value);
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
    /// The query attribute.
    /// </summary>
    public TerraformValue<string>? Query
    {
        get => new TerraformReference<string>(this, "query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<string> StatusCode
    {
        get => new TerraformReference<string>(this, "status_code");
        set => SetArgument("status_code", value);
    }

}


/// <summary>
/// Block type for mutual_authentication in AwsAlbListener.
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerMutualAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mutual_authentication";

    /// <summary>
    /// The advertise_trust_store_ca_names attribute.
    /// </summary>
    public TerraformValue<string> AdvertiseTrustStoreCaNames
    {
        get => new TerraformReference<string>(this, "advertise_trust_store_ca_names");
        set => SetArgument("advertise_trust_store_ca_names", value);
    }

    /// <summary>
    /// The ignore_client_certificate_expiry attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreClientCertificateExpiry
    {
        get => new TerraformReference<bool>(this, "ignore_client_certificate_expiry");
        set => SetArgument("ignore_client_certificate_expiry", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformValue<string>? TrustStoreArn
    {
        get => new TerraformReference<string>(this, "trust_store_arn");
        set => SetArgument("trust_store_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAlbListener.
/// Nesting mode: single
/// </summary>
public class AwsAlbListenerTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_alb_listener Terraform resource.
/// Manages a aws_alb_listener resource.
/// </summary>
public partial class AwsAlbListener(string name) : TerraformResource("aws_alb_listener", name)
{
    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    public TerraformValue<string>? AlpnPolicy
    {
        get => new TerraformReference<string>(this, "alpn_policy");
        set => SetArgument("alpn_policy", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
        set => SetArgument("certificate_arn", value);
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
    /// The load_balancer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerArn is required")]
    public required TerraformValue<string> LoadBalancerArn
    {
        get => new TerraformReference<string>(this, "load_balancer_arn");
        set => SetArgument("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertHeaderName
    {
        get => new TerraformReference<string>(this, "routing_http_request_x_amzn_mtls_clientcert_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_issuer_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName
    {
        get => new TerraformReference<string>(this, "routing_http_request_x_amzn_mtls_clientcert_issuer_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_leaf_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName
    {
        get => new TerraformReference<string>(this, "routing_http_request_x_amzn_mtls_clientcert_leaf_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName
    {
        get => new TerraformReference<string>(this, "routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_subject_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName
    {
        get => new TerraformReference<string>(this, "routing_http_request_x_amzn_mtls_clientcert_subject_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_subject_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_validity_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName
    {
        get => new TerraformReference<string>(this, "routing_http_request_x_amzn_mtls_clientcert_validity_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_validity_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_cipher_suite_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznTlsCipherSuiteHeaderName
    {
        get => new TerraformReference<string>(this, "routing_http_request_x_amzn_tls_cipher_suite_header_name");
        set => SetArgument("routing_http_request_x_amzn_tls_cipher_suite_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_version_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznTlsVersionHeaderName
    {
        get => new TerraformReference<string>(this, "routing_http_request_x_amzn_tls_version_header_name");
        set => SetArgument("routing_http_request_x_amzn_tls_version_header_name", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_credentials_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowCredentialsHeaderValue
    {
        get => new TerraformReference<string>(this, "routing_http_response_access_control_allow_credentials_header_value");
        set => SetArgument("routing_http_response_access_control_allow_credentials_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_headers_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowHeadersHeaderValue
    {
        get => new TerraformReference<string>(this, "routing_http_response_access_control_allow_headers_header_value");
        set => SetArgument("routing_http_response_access_control_allow_headers_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_methods_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowMethodsHeaderValue
    {
        get => new TerraformReference<string>(this, "routing_http_response_access_control_allow_methods_header_value");
        set => SetArgument("routing_http_response_access_control_allow_methods_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_origin_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowOriginHeaderValue
    {
        get => new TerraformReference<string>(this, "routing_http_response_access_control_allow_origin_header_value");
        set => SetArgument("routing_http_response_access_control_allow_origin_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_expose_headers_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlExposeHeadersHeaderValue
    {
        get => new TerraformReference<string>(this, "routing_http_response_access_control_expose_headers_header_value");
        set => SetArgument("routing_http_response_access_control_expose_headers_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_max_age_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlMaxAgeHeaderValue
    {
        get => new TerraformReference<string>(this, "routing_http_response_access_control_max_age_header_value");
        set => SetArgument("routing_http_response_access_control_max_age_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_content_security_policy_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseContentSecurityPolicyHeaderValue
    {
        get => new TerraformReference<string>(this, "routing_http_response_content_security_policy_header_value");
        set => SetArgument("routing_http_response_content_security_policy_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_server_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RoutingHttpResponseServerEnabled
    {
        get => new TerraformReference<bool>(this, "routing_http_response_server_enabled");
        set => SetArgument("routing_http_response_server_enabled", value);
    }

    /// <summary>
    /// The routing_http_response_strict_transport_security_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseStrictTransportSecurityHeaderValue
    {
        get => new TerraformReference<string>(this, "routing_http_response_strict_transport_security_header_value");
        set => SetArgument("routing_http_response_strict_transport_security_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_x_content_type_options_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseXContentTypeOptionsHeaderValue
    {
        get => new TerraformReference<string>(this, "routing_http_response_x_content_type_options_header_value");
        set => SetArgument("routing_http_response_x_content_type_options_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_x_frame_options_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseXFrameOptionsHeaderValue
    {
        get => new TerraformReference<string>(this, "routing_http_response_x_frame_options_header_value");
        set => SetArgument("routing_http_response_x_frame_options_header_value", value);
    }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformValue<string> SslPolicy
    {
        get => new TerraformReference<string>(this, "ssl_policy");
        set => SetArgument("ssl_policy", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tcp_idle_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double> TcpIdleTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "tcp_idle_timeout_seconds");
        set => SetArgument("tcp_idle_timeout_seconds", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// DefaultAction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    public required TerraformList<AwsAlbListenerDefaultActionBlock> DefaultAction
    {
        get => GetRequiredArgument<TerraformList<AwsAlbListenerDefaultActionBlock>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// MutualAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualAuthentication block(s) allowed")]
    public TerraformList<AwsAlbListenerMutualAuthenticationBlock>? MutualAuthentication
    {
        get => GetArgument<TerraformList<AwsAlbListenerMutualAuthenticationBlock>>("mutual_authentication");
        set => SetArgument("mutual_authentication", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAlbListenerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAlbListenerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
