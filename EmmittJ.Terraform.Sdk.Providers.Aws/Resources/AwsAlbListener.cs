using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_alb_listener resource.
/// </summary>
public class AwsAlbListener : TerraformResource
{
    public AwsAlbListener(string name) : base("aws_alb_listener", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    public string? AlpnPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alpn_policy")?.Value;
        set => this.WithProperty("alpn_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public string? CertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_arn")?.Value;
        set => this.WithProperty("certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    public string? LoadBalancerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer_arn")?.Value;
        set => this.WithProperty("load_balancer_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_header_name attribute.
    /// </summary>
    public string? RoutingHttpRequestXAmznMtlsClientcertHeaderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_header_name")?.Value;
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_header_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_issuer_header_name attribute.
    /// </summary>
    public string? RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name")?.Value;
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_leaf_header_name attribute.
    /// </summary>
    public string? RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name")?.Value;
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name attribute.
    /// </summary>
    public string? RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name")?.Value;
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_subject_header_name attribute.
    /// </summary>
    public string? RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_subject_header_name")?.Value;
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_subject_header_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_validity_header_name attribute.
    /// </summary>
    public string? RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_validity_header_name")?.Value;
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_validity_header_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_cipher_suite_header_name attribute.
    /// </summary>
    public string? RoutingHttpRequestXAmznTlsCipherSuiteHeaderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_request_x_amzn_tls_cipher_suite_header_name")?.Value;
        set => this.WithProperty("routing_http_request_x_amzn_tls_cipher_suite_header_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_version_header_name attribute.
    /// </summary>
    public string? RoutingHttpRequestXAmznTlsVersionHeaderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_request_x_amzn_tls_version_header_name")?.Value;
        set => this.WithProperty("routing_http_request_x_amzn_tls_version_header_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_credentials_header_value attribute.
    /// </summary>
    public string? RoutingHttpResponseAccessControlAllowCredentialsHeaderValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_response_access_control_allow_credentials_header_value")?.Value;
        set => this.WithProperty("routing_http_response_access_control_allow_credentials_header_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_headers_header_value attribute.
    /// </summary>
    public string? RoutingHttpResponseAccessControlAllowHeadersHeaderValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_response_access_control_allow_headers_header_value")?.Value;
        set => this.WithProperty("routing_http_response_access_control_allow_headers_header_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_methods_header_value attribute.
    /// </summary>
    public string? RoutingHttpResponseAccessControlAllowMethodsHeaderValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_response_access_control_allow_methods_header_value")?.Value;
        set => this.WithProperty("routing_http_response_access_control_allow_methods_header_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_origin_header_value attribute.
    /// </summary>
    public string? RoutingHttpResponseAccessControlAllowOriginHeaderValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_response_access_control_allow_origin_header_value")?.Value;
        set => this.WithProperty("routing_http_response_access_control_allow_origin_header_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_response_access_control_expose_headers_header_value attribute.
    /// </summary>
    public string? RoutingHttpResponseAccessControlExposeHeadersHeaderValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_response_access_control_expose_headers_header_value")?.Value;
        set => this.WithProperty("routing_http_response_access_control_expose_headers_header_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_response_access_control_max_age_header_value attribute.
    /// </summary>
    public string? RoutingHttpResponseAccessControlMaxAgeHeaderValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_response_access_control_max_age_header_value")?.Value;
        set => this.WithProperty("routing_http_response_access_control_max_age_header_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_response_content_security_policy_header_value attribute.
    /// </summary>
    public string? RoutingHttpResponseContentSecurityPolicyHeaderValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_response_content_security_policy_header_value")?.Value;
        set => this.WithProperty("routing_http_response_content_security_policy_header_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_response_server_enabled attribute.
    /// </summary>
    public bool? RoutingHttpResponseServerEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("routing_http_response_server_enabled")?.Value;
        set => this.WithProperty("routing_http_response_server_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The routing_http_response_strict_transport_security_header_value attribute.
    /// </summary>
    public string? RoutingHttpResponseStrictTransportSecurityHeaderValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_response_strict_transport_security_header_value")?.Value;
        set => this.WithProperty("routing_http_response_strict_transport_security_header_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_response_x_content_type_options_header_value attribute.
    /// </summary>
    public string? RoutingHttpResponseXContentTypeOptionsHeaderValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_response_x_content_type_options_header_value")?.Value;
        set => this.WithProperty("routing_http_response_x_content_type_options_header_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_http_response_x_frame_options_header_value attribute.
    /// </summary>
    public string? RoutingHttpResponseXFrameOptionsHeaderValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_http_response_x_frame_options_header_value")?.Value;
        set => this.WithProperty("routing_http_response_x_frame_options_header_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public string? SslPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_policy")?.Value;
        set => this.WithProperty("ssl_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tcp_idle_timeout_seconds attribute.
    /// </summary>
    public double? TcpIdleTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tcp_idle_timeout_seconds")?.Value;
        set => this.WithProperty("tcp_idle_timeout_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
