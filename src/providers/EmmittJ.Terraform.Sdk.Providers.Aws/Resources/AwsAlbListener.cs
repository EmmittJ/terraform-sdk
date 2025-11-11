using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in .
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerDefaultActionBlock
{
    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformPropertyName("order")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Order { get; set; } = default!;

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("target_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetGroupArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for mutual_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsAlbListenerMutualAuthenticationBlock
{
    /// <summary>
    /// The advertise_trust_store_ca_names attribute.
    /// </summary>
    [TerraformPropertyName("advertise_trust_store_ca_names")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AdvertiseTrustStoreCaNames { get; set; } = default!;

    /// <summary>
    /// The ignore_client_certificate_expiry attribute.
    /// </summary>
    [TerraformPropertyName("ignore_client_certificate_expiry")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreClientCertificateExpiry { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [TerraformPropertyName("trust_store_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TrustStoreArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAlbListenerTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_alb_listener resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAlbListener : TerraformResource
{
    public AwsAlbListener(string name) : base("aws_alb_listener", name)
    {
    }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    [TerraformPropertyName("alpn_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AlpnPolicy { get; set; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerArn is required")]
    [TerraformPropertyName("load_balancer_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LoadBalancerArn { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Protocol { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_header_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertHeaderName { get; set; } = default!;

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_issuer_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName { get; set; } = default!;

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_leaf_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName { get; set; } = default!;

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName { get; set; } = default!;

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_subject_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_subject_header_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName { get; set; } = default!;

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_validity_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_validity_header_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName { get; set; } = default!;

    /// <summary>
    /// The routing_http_request_x_amzn_tls_cipher_suite_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_tls_cipher_suite_header_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpRequestXAmznTlsCipherSuiteHeaderName { get; set; } = default!;

    /// <summary>
    /// The routing_http_request_x_amzn_tls_version_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_tls_version_header_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpRequestXAmznTlsVersionHeaderName { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_access_control_allow_credentials_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_allow_credentials_header_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowCredentialsHeaderValue { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_access_control_allow_headers_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_allow_headers_header_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowHeadersHeaderValue { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_access_control_allow_methods_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_allow_methods_header_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowMethodsHeaderValue { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_access_control_allow_origin_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_allow_origin_header_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpResponseAccessControlAllowOriginHeaderValue { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_access_control_expose_headers_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_expose_headers_header_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpResponseAccessControlExposeHeadersHeaderValue { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_access_control_max_age_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_max_age_header_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpResponseAccessControlMaxAgeHeaderValue { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_content_security_policy_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_content_security_policy_header_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpResponseContentSecurityPolicyHeaderValue { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_server_enabled attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_server_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RoutingHttpResponseServerEnabled { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_strict_transport_security_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_strict_transport_security_header_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpResponseStrictTransportSecurityHeaderValue { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_x_content_type_options_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_x_content_type_options_header_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpResponseXContentTypeOptionsHeaderValue { get; set; } = default!;

    /// <summary>
    /// The routing_http_response_x_frame_options_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_x_frame_options_header_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingHttpResponseXFrameOptionsHeaderValue { get; set; } = default!;

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SslPolicy { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The tcp_idle_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tcp_idle_timeout_seconds")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> TcpIdleTimeoutSeconds { get; set; } = default!;

    /// <summary>
    /// Block for default_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    [TerraformPropertyName("default_action")]
    public TerraformList<TerraformBlock<AwsAlbListenerDefaultActionBlock>>? DefaultAction { get; set; }

    /// <summary>
    /// Block for mutual_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualAuthentication block(s) allowed")]
    [TerraformPropertyName("mutual_authentication")]
    public TerraformList<TerraformBlock<AwsAlbListenerMutualAuthenticationBlock>>? MutualAuthentication { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAlbListenerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
