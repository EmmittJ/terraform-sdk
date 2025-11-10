using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in .
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerDefaultActionBlock : TerraformBlock
{
    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TargetGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("target_group_arn");
        set => WithProperty("target_group_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for mutual_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerMutualAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The advertise_trust_store_ca_names attribute.
    /// </summary>
    public TerraformProperty<string>? AdvertiseTrustStoreCaNames
    {
        get => GetProperty<TerraformProperty<string>>("advertise_trust_store_ca_names");
        set => WithProperty("advertise_trust_store_ca_names", value);
    }

    /// <summary>
    /// The ignore_client_certificate_expiry attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreClientCertificateExpiry
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_client_certificate_expiry");
        set => WithProperty("ignore_client_certificate_expiry", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TrustStoreArn
    {
        get => GetProperty<TerraformProperty<string>>("trust_store_arn");
        set => WithProperty("trust_store_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAlbListenerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_alb_listener resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAlbListener : TerraformResource
{
    public AwsAlbListener(string name) : base("aws_alb_listener", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    public TerraformProperty<string>? AlpnPolicy
    {
        get => GetProperty<TerraformProperty<string>>("alpn_policy");
        set => this.WithProperty("alpn_policy", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_arn");
        set => this.WithProperty("certificate_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerArn is required")]
    public required TerraformProperty<string> LoadBalancerArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("load_balancer_arn");
        set => this.WithProperty("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_header_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpRequestXAmznMtlsClientcertHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_header_name");
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_issuer_header_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name");
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_leaf_header_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name");
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name");
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_subject_header_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_subject_header_name");
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_subject_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_validity_header_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_request_x_amzn_mtls_clientcert_validity_header_name");
        set => this.WithProperty("routing_http_request_x_amzn_mtls_clientcert_validity_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_cipher_suite_header_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpRequestXAmznTlsCipherSuiteHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_request_x_amzn_tls_cipher_suite_header_name");
        set => this.WithProperty("routing_http_request_x_amzn_tls_cipher_suite_header_name", value);
    }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_version_header_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpRequestXAmznTlsVersionHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_request_x_amzn_tls_version_header_name");
        set => this.WithProperty("routing_http_request_x_amzn_tls_version_header_name", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_credentials_header_value attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpResponseAccessControlAllowCredentialsHeaderValue
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_response_access_control_allow_credentials_header_value");
        set => this.WithProperty("routing_http_response_access_control_allow_credentials_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_headers_header_value attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpResponseAccessControlAllowHeadersHeaderValue
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_response_access_control_allow_headers_header_value");
        set => this.WithProperty("routing_http_response_access_control_allow_headers_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_methods_header_value attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpResponseAccessControlAllowMethodsHeaderValue
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_response_access_control_allow_methods_header_value");
        set => this.WithProperty("routing_http_response_access_control_allow_methods_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_allow_origin_header_value attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpResponseAccessControlAllowOriginHeaderValue
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_response_access_control_allow_origin_header_value");
        set => this.WithProperty("routing_http_response_access_control_allow_origin_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_expose_headers_header_value attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpResponseAccessControlExposeHeadersHeaderValue
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_response_access_control_expose_headers_header_value");
        set => this.WithProperty("routing_http_response_access_control_expose_headers_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_access_control_max_age_header_value attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpResponseAccessControlMaxAgeHeaderValue
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_response_access_control_max_age_header_value");
        set => this.WithProperty("routing_http_response_access_control_max_age_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_content_security_policy_header_value attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpResponseContentSecurityPolicyHeaderValue
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_response_content_security_policy_header_value");
        set => this.WithProperty("routing_http_response_content_security_policy_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_server_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RoutingHttpResponseServerEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("routing_http_response_server_enabled");
        set => this.WithProperty("routing_http_response_server_enabled", value);
    }

    /// <summary>
    /// The routing_http_response_strict_transport_security_header_value attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpResponseStrictTransportSecurityHeaderValue
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_response_strict_transport_security_header_value");
        set => this.WithProperty("routing_http_response_strict_transport_security_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_x_content_type_options_header_value attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpResponseXContentTypeOptionsHeaderValue
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_response_x_content_type_options_header_value");
        set => this.WithProperty("routing_http_response_x_content_type_options_header_value", value);
    }

    /// <summary>
    /// The routing_http_response_x_frame_options_header_value attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingHttpResponseXFrameOptionsHeaderValue
    {
        get => GetProperty<TerraformProperty<string>>("routing_http_response_x_frame_options_header_value");
        set => this.WithProperty("routing_http_response_x_frame_options_header_value", value);
    }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SslPolicy
    {
        get => GetProperty<TerraformProperty<string>>("ssl_policy");
        set => this.WithProperty("ssl_policy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tcp_idle_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TcpIdleTimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tcp_idle_timeout_seconds");
        set => this.WithProperty("tcp_idle_timeout_seconds", value);
    }

    /// <summary>
    /// Block for default_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    public List<AwsAlbListenerDefaultActionBlock>? DefaultAction
    {
        get => GetProperty<List<AwsAlbListenerDefaultActionBlock>>("default_action");
        set => this.WithProperty("default_action", value);
    }

    /// <summary>
    /// Block for mutual_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualAuthentication block(s) allowed")]
    public List<AwsAlbListenerMutualAuthenticationBlock>? MutualAuthentication
    {
        get => GetProperty<List<AwsAlbListenerMutualAuthenticationBlock>>("mutual_authentication");
        set => this.WithProperty("mutual_authentication", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAlbListenerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsAlbListenerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
