using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in .
/// Nesting mode: list
/// </summary>
public class AwsLbListenerDefaultActionBlock : TerraformBlock
{
    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        set => SetProperty("order", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TargetGroupArn
    {
        set => SetProperty("target_group_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for mutual_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsLbListenerMutualAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The advertise_trust_store_ca_names attribute.
    /// </summary>
    public TerraformProperty<string>? AdvertiseTrustStoreCaNames
    {
        set => SetProperty("advertise_trust_store_ca_names", value);
    }

    /// <summary>
    /// The ignore_client_certificate_expiry attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreClientCertificateExpiry
    {
        set => SetProperty("ignore_client_certificate_expiry", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TrustStoreArn
    {
        set => SetProperty("trust_store_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbListenerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_lb_listener resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLbListener : TerraformResource
{
    public AwsLbListener(string name) : base("aws_lb_listener", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("alpn_policy");
        SetOutput("certificate_arn");
        SetOutput("id");
        SetOutput("load_balancer_arn");
        SetOutput("port");
        SetOutput("protocol");
        SetOutput("region");
        SetOutput("routing_http_request_x_amzn_mtls_clientcert_header_name");
        SetOutput("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name");
        SetOutput("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name");
        SetOutput("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name");
        SetOutput("routing_http_request_x_amzn_mtls_clientcert_subject_header_name");
        SetOutput("routing_http_request_x_amzn_mtls_clientcert_validity_header_name");
        SetOutput("routing_http_request_x_amzn_tls_cipher_suite_header_name");
        SetOutput("routing_http_request_x_amzn_tls_version_header_name");
        SetOutput("routing_http_response_access_control_allow_credentials_header_value");
        SetOutput("routing_http_response_access_control_allow_headers_header_value");
        SetOutput("routing_http_response_access_control_allow_methods_header_value");
        SetOutput("routing_http_response_access_control_allow_origin_header_value");
        SetOutput("routing_http_response_access_control_expose_headers_header_value");
        SetOutput("routing_http_response_access_control_max_age_header_value");
        SetOutput("routing_http_response_content_security_policy_header_value");
        SetOutput("routing_http_response_server_enabled");
        SetOutput("routing_http_response_strict_transport_security_header_value");
        SetOutput("routing_http_response_x_content_type_options_header_value");
        SetOutput("routing_http_response_x_frame_options_header_value");
        SetOutput("ssl_policy");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tcp_idle_timeout_seconds");
    }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    public TerraformProperty<string> AlpnPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alpn_policy");
        set => SetProperty("alpn_policy", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string> CertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_arn");
        set => SetProperty("certificate_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerArn is required")]
    public required TerraformProperty<string> LoadBalancerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancer_arn");
        set => SetProperty("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_header_name attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpRequestXAmznMtlsClientcertHeaderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_header_name");
        set => SetProperty("routing_http_request_x_amzn_mtls_clientcert_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_issuer_header_name attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name");
        set => SetProperty("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_leaf_header_name attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name");
        set => SetProperty("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name");
        set => SetProperty("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_subject_header_name attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_subject_header_name");
        set => SetProperty("routing_http_request_x_amzn_mtls_clientcert_subject_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_validity_header_name attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_validity_header_name");
        set => SetProperty("routing_http_request_x_amzn_mtls_clientcert_validity_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_cipher_suite_header_name attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpRequestXAmznTlsCipherSuiteHeaderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_request_x_amzn_tls_cipher_suite_header_name");
        set => SetProperty("routing_http_request_x_amzn_tls_cipher_suite_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_version_header_name attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpRequestXAmznTlsVersionHeaderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_request_x_amzn_tls_version_header_name");
        set => SetProperty("routing_http_request_x_amzn_tls_version_header_name", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_credentials_header_value attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpResponseAccessControlAllowCredentialsHeaderValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_response_access_control_allow_credentials_header_value");
        set => SetProperty("routing_http_response_access_control_allow_credentials_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_headers_header_value attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpResponseAccessControlAllowHeadersHeaderValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_response_access_control_allow_headers_header_value");
        set => SetProperty("routing_http_response_access_control_allow_headers_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_methods_header_value attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpResponseAccessControlAllowMethodsHeaderValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_response_access_control_allow_methods_header_value");
        set => SetProperty("routing_http_response_access_control_allow_methods_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_origin_header_value attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpResponseAccessControlAllowOriginHeaderValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_response_access_control_allow_origin_header_value");
        set => SetProperty("routing_http_response_access_control_allow_origin_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_expose_headers_header_value attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpResponseAccessControlExposeHeadersHeaderValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_response_access_control_expose_headers_header_value");
        set => SetProperty("routing_http_response_access_control_expose_headers_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_max_age_header_value attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpResponseAccessControlMaxAgeHeaderValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_response_access_control_max_age_header_value");
        set => SetProperty("routing_http_response_access_control_max_age_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_content_security_policy_header_value attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpResponseContentSecurityPolicyHeaderValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_response_content_security_policy_header_value");
        set => SetProperty("routing_http_response_content_security_policy_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_server_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RoutingHttpResponseServerEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("routing_http_response_server_enabled");
        set => SetProperty("routing_http_response_server_enabled", value);
    }

    /// <summary>
    /// The routing_http_response_strict_transport_security_header_value attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpResponseStrictTransportSecurityHeaderValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_response_strict_transport_security_header_value");
        set => SetProperty("routing_http_response_strict_transport_security_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_x_content_type_options_header_value attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpResponseXContentTypeOptionsHeaderValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_response_x_content_type_options_header_value");
        set => SetProperty("routing_http_response_x_content_type_options_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_x_frame_options_header_value attribute.
    /// </summary>
    public TerraformProperty<string> RoutingHttpResponseXFrameOptionsHeaderValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_http_response_x_frame_options_header_value");
        set => SetProperty("routing_http_response_x_frame_options_header_value", value);
    }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformProperty<string> SslPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ssl_policy");
        set => SetProperty("ssl_policy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The tcp_idle_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double> TcpIdleTimeoutSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tcp_idle_timeout_seconds");
        set => SetProperty("tcp_idle_timeout_seconds", value);
    }

    /// <summary>
    /// Block for default_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    public List<AwsLbListenerDefaultActionBlock>? DefaultAction
    {
        set => SetProperty("default_action", value);
    }

    /// <summary>
    /// Block for mutual_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualAuthentication block(s) allowed")]
    public List<AwsLbListenerMutualAuthenticationBlock>? MutualAuthentication
    {
        set => SetProperty("mutual_authentication", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLbListenerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
