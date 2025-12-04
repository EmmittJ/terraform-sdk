using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in AwsLbListener.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerDefaultActionBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("order") ?? AsReference("order");
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
    public TerraformList<AwsLbListenerDefaultActionBlockAuthenticateCognitoBlock>? AuthenticateCognito
    {
        get => GetArgument<TerraformList<AwsLbListenerDefaultActionBlockAuthenticateCognitoBlock>>("authenticate_cognito");
        set => SetArgument("authenticate_cognito", value);
    }

    /// <summary>
    /// AuthenticateOidc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticateOidc block(s) allowed")]
    public TerraformList<AwsLbListenerDefaultActionBlockAuthenticateOidcBlock>? AuthenticateOidc
    {
        get => GetArgument<TerraformList<AwsLbListenerDefaultActionBlockAuthenticateOidcBlock>>("authenticate_oidc");
        set => SetArgument("authenticate_oidc", value);
    }

    /// <summary>
    /// FixedResponse block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedResponse block(s) allowed")]
    public TerraformList<AwsLbListenerDefaultActionBlockFixedResponseBlock>? FixedResponse
    {
        get => GetArgument<TerraformList<AwsLbListenerDefaultActionBlockFixedResponseBlock>>("fixed_response");
        set => SetArgument("fixed_response", value);
    }

    /// <summary>
    /// Forward block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Forward block(s) allowed")]
    public TerraformList<AwsLbListenerDefaultActionBlockForwardBlock>? Forward
    {
        get => GetArgument<TerraformList<AwsLbListenerDefaultActionBlockForwardBlock>>("forward");
        set => SetArgument("forward", value);
    }

    /// <summary>
    /// Redirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redirect block(s) allowed")]
    public TerraformList<AwsLbListenerDefaultActionBlockRedirectBlock>? Redirect
    {
        get => GetArgument<TerraformList<AwsLbListenerDefaultActionBlockRedirectBlock>>("redirect");
        set => SetArgument("redirect", value);
    }

}

/// <summary>
/// Block type for authenticate_cognito in AwsLbListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerDefaultActionBlockAuthenticateCognitoBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("on_unauthenticated_request") ?? AsReference("on_unauthenticated_request");
        set => SetArgument("on_unauthenticated_request", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string> Scope
    {
        get => GetArgument<TerraformValue<string>>("scope") ?? AsReference("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The session_cookie_name attribute.
    /// </summary>
    public TerraformValue<string> SessionCookieName
    {
        get => GetArgument<TerraformValue<string>>("session_cookie_name") ?? AsReference("session_cookie_name");
        set => SetArgument("session_cookie_name", value);
    }

    /// <summary>
    /// The session_timeout attribute.
    /// </summary>
    public TerraformValue<double> SessionTimeout
    {
        get => GetArgument<TerraformValue<double>>("session_timeout") ?? AsReference("session_timeout");
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
/// Block type for authenticate_oidc in AwsLbListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerDefaultActionBlockAuthenticateOidcBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("on_unauthenticated_request") ?? AsReference("on_unauthenticated_request");
        set => SetArgument("on_unauthenticated_request", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string> Scope
    {
        get => GetArgument<TerraformValue<string>>("scope") ?? AsReference("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The session_cookie_name attribute.
    /// </summary>
    public TerraformValue<string> SessionCookieName
    {
        get => GetArgument<TerraformValue<string>>("session_cookie_name") ?? AsReference("session_cookie_name");
        set => SetArgument("session_cookie_name", value);
    }

    /// <summary>
    /// The session_timeout attribute.
    /// </summary>
    public TerraformValue<double> SessionTimeout
    {
        get => GetArgument<TerraformValue<double>>("session_timeout") ?? AsReference("session_timeout");
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
/// Block type for fixed_response in AwsLbListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerDefaultActionBlockFixedResponseBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("status_code") ?? AsReference("status_code");
        set => SetArgument("status_code", value);
    }

}

/// <summary>
/// Block type for forward in AwsLbListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerDefaultActionBlockForwardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forward";

    /// <summary>
    /// Stickiness block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stickiness block(s) allowed")]
    public TerraformList<AwsLbListenerDefaultActionBlockForwardBlockStickinessBlock>? Stickiness
    {
        get => GetArgument<TerraformList<AwsLbListenerDefaultActionBlockForwardBlockStickinessBlock>>("stickiness");
        set => SetArgument("stickiness", value);
    }

    /// <summary>
    /// TargetGroup block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 TargetGroup block(s) allowed")]
    public required TerraformSet<AwsLbListenerDefaultActionBlockForwardBlockTargetGroupBlock> TargetGroup
    {
        get => GetRequiredArgument<TerraformSet<AwsLbListenerDefaultActionBlockForwardBlockTargetGroupBlock>>("target_group");
        set => SetArgument("target_group", value);
    }

}

/// <summary>
/// Block type for stickiness in AwsLbListenerDefaultActionBlockForwardBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerDefaultActionBlockForwardBlockStickinessBlock : TerraformBlock
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
/// Block type for target_group in AwsLbListenerDefaultActionBlockForwardBlock.
/// Nesting mode: set
/// </summary>
public class AwsLbListenerDefaultActionBlockForwardBlockTargetGroupBlock : TerraformBlock
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
/// Block type for redirect in AwsLbListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerDefaultActionBlockRedirectBlock : TerraformBlock
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
/// Block type for mutual_authentication in AwsLbListener.
/// Nesting mode: list
/// </summary>
public class AwsLbListenerMutualAuthenticationBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("advertise_trust_store_ca_names") ?? AsReference("advertise_trust_store_ca_names");
        set => SetArgument("advertise_trust_store_ca_names", value);
    }

    /// <summary>
    /// The ignore_client_certificate_expiry attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreClientCertificateExpiry
    {
        get => GetArgument<TerraformValue<bool>>("ignore_client_certificate_expiry");
        set => SetArgument("ignore_client_certificate_expiry", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformValue<string>? TrustStoreArn
    {
        get => GetArgument<TerraformValue<string>>("trust_store_arn");
        set => SetArgument("trust_store_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLbListener.
/// Nesting mode: single
/// </summary>
public class AwsLbListenerTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_lb_listener Terraform resource.
/// Manages a aws_lb_listener resource.
/// </summary>
public partial class AwsLbListener(string name) : TerraformResource("aws_lb_listener", name)
{
    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    public TerraformValue<string>? AlpnPolicy
    {
        get => GetArgument<TerraformValue<string>>("alpn_policy");
        set => SetArgument("alpn_policy", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? CertificateArn
    {
        get => GetArgument<TerraformValue<string>>("certificate_arn");
        set => SetArgument("certificate_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerArn is required")]
    public required TerraformValue<string> LoadBalancerArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("load_balancer_arn");
        set => SetArgument("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol") ?? AsReference("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertHeaderName
    {
        get => GetArgument<TerraformValue<string>>("routing_http_request_x_amzn_mtls_clientcert_header_name") ?? AsReference("routing_http_request_x_amzn_mtls_clientcert_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_issuer_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName
    {
        get => GetArgument<TerraformValue<string>>("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name") ?? AsReference("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_leaf_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName
    {
        get => GetArgument<TerraformValue<string>>("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name") ?? AsReference("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName
    {
        get => GetArgument<TerraformValue<string>>("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name") ?? AsReference("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_subject_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName
    {
        get => GetArgument<TerraformValue<string>>("routing_http_request_x_amzn_mtls_clientcert_subject_header_name") ?? AsReference("routing_http_request_x_amzn_mtls_clientcert_subject_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_subject_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_validity_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName
    {
        get => GetArgument<TerraformValue<string>>("routing_http_request_x_amzn_mtls_clientcert_validity_header_name") ?? AsReference("routing_http_request_x_amzn_mtls_clientcert_validity_header_name");
        set => SetArgument("routing_http_request_x_amzn_mtls_clientcert_validity_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_cipher_suite_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznTlsCipherSuiteHeaderName
    {
        get => GetArgument<TerraformValue<string>>("routing_http_request_x_amzn_tls_cipher_suite_header_name") ?? AsReference("routing_http_request_x_amzn_tls_cipher_suite_header_name");
        set => SetArgument("routing_http_request_x_amzn_tls_cipher_suite_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_version_header_name attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpRequestXAmznTlsVersionHeaderName
    {
        get => GetArgument<TerraformValue<string>>("routing_http_request_x_amzn_tls_version_header_name") ?? AsReference("routing_http_request_x_amzn_tls_version_header_name");
        set => SetArgument("routing_http_request_x_amzn_tls_version_header_name", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_credentials_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowCredentialsHeaderValue
    {
        get => GetArgument<TerraformValue<string>>("routing_http_response_access_control_allow_credentials_header_value") ?? AsReference("routing_http_response_access_control_allow_credentials_header_value");
        set => SetArgument("routing_http_response_access_control_allow_credentials_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_headers_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowHeadersHeaderValue
    {
        get => GetArgument<TerraformValue<string>>("routing_http_response_access_control_allow_headers_header_value") ?? AsReference("routing_http_response_access_control_allow_headers_header_value");
        set => SetArgument("routing_http_response_access_control_allow_headers_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_methods_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowMethodsHeaderValue
    {
        get => GetArgument<TerraformValue<string>>("routing_http_response_access_control_allow_methods_header_value") ?? AsReference("routing_http_response_access_control_allow_methods_header_value");
        set => SetArgument("routing_http_response_access_control_allow_methods_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_origin_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowOriginHeaderValue
    {
        get => GetArgument<TerraformValue<string>>("routing_http_response_access_control_allow_origin_header_value") ?? AsReference("routing_http_response_access_control_allow_origin_header_value");
        set => SetArgument("routing_http_response_access_control_allow_origin_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_expose_headers_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlExposeHeadersHeaderValue
    {
        get => GetArgument<TerraformValue<string>>("routing_http_response_access_control_expose_headers_header_value") ?? AsReference("routing_http_response_access_control_expose_headers_header_value");
        set => SetArgument("routing_http_response_access_control_expose_headers_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_max_age_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseAccessControlMaxAgeHeaderValue
    {
        get => GetArgument<TerraformValue<string>>("routing_http_response_access_control_max_age_header_value") ?? AsReference("routing_http_response_access_control_max_age_header_value");
        set => SetArgument("routing_http_response_access_control_max_age_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_content_security_policy_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseContentSecurityPolicyHeaderValue
    {
        get => GetArgument<TerraformValue<string>>("routing_http_response_content_security_policy_header_value") ?? AsReference("routing_http_response_content_security_policy_header_value");
        set => SetArgument("routing_http_response_content_security_policy_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_server_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RoutingHttpResponseServerEnabled
    {
        get => GetArgument<TerraformValue<bool>>("routing_http_response_server_enabled") ?? AsReference("routing_http_response_server_enabled");
        set => SetArgument("routing_http_response_server_enabled", value);
    }

    /// <summary>
    /// The routing_http_response_strict_transport_security_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseStrictTransportSecurityHeaderValue
    {
        get => GetArgument<TerraformValue<string>>("routing_http_response_strict_transport_security_header_value") ?? AsReference("routing_http_response_strict_transport_security_header_value");
        set => SetArgument("routing_http_response_strict_transport_security_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_x_content_type_options_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseXContentTypeOptionsHeaderValue
    {
        get => GetArgument<TerraformValue<string>>("routing_http_response_x_content_type_options_header_value") ?? AsReference("routing_http_response_x_content_type_options_header_value");
        set => SetArgument("routing_http_response_x_content_type_options_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_x_frame_options_header_value attribute.
    /// </summary>
    public TerraformValue<string> RoutingHttpResponseXFrameOptionsHeaderValue
    {
        get => GetArgument<TerraformValue<string>>("routing_http_response_x_frame_options_header_value") ?? AsReference("routing_http_response_x_frame_options_header_value");
        set => SetArgument("routing_http_response_x_frame_options_header_value", value);
    }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformValue<string> SslPolicy
    {
        get => GetArgument<TerraformValue<string>>("ssl_policy") ?? AsReference("ssl_policy");
        set => SetArgument("ssl_policy", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tcp_idle_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double> TcpIdleTimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("tcp_idle_timeout_seconds") ?? AsReference("tcp_idle_timeout_seconds");
        set => SetArgument("tcp_idle_timeout_seconds", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// DefaultAction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    public required TerraformList<AwsLbListenerDefaultActionBlock> DefaultAction
    {
        get => GetRequiredArgument<TerraformList<AwsLbListenerDefaultActionBlock>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// MutualAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualAuthentication block(s) allowed")]
    public TerraformList<AwsLbListenerMutualAuthenticationBlock>? MutualAuthentication
    {
        get => GetArgument<TerraformList<AwsLbListenerMutualAuthenticationBlock>>("mutual_authentication");
        set => SetArgument("mutual_authentication", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLbListenerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLbListenerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
