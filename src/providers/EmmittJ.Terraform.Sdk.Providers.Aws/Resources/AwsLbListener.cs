using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in .
/// Nesting mode: list
/// </summary>
public class AwsLbListenerDefaultActionBlock : ITerraformBlock
{
    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformPropertyName("order")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Order { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "order");

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("target_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetGroupArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for mutual_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsLbListenerMutualAuthenticationBlock : ITerraformBlock
{
    /// <summary>
    /// The advertise_trust_store_ca_names attribute.
    /// </summary>
    [TerraformPropertyName("advertise_trust_store_ca_names")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AdvertiseTrustStoreCaNames { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "advertise_trust_store_ca_names");

    /// <summary>
    /// The ignore_client_certificate_expiry attribute.
    /// </summary>
    [TerraformPropertyName("ignore_client_certificate_expiry")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreClientCertificateExpiry { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [TerraformPropertyName("trust_store_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TrustStoreArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbListenerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_lb_listener resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLbListener : TerraformResource
{
    public AwsLbListener(string name) : base("aws_lb_listener", name)
    {
    }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    [TerraformPropertyName("alpn_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AlpnPolicy { get; set; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerArn is required")]
    [TerraformPropertyName("load_balancer_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LoadBalancerArn { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Protocol { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protocol");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_header_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpRequestXAmznMtlsClientcertHeaderName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_request_x_amzn_mtls_clientcert_header_name");

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_issuer_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_request_x_amzn_mtls_clientcert_issuer_header_name");

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_leaf_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_request_x_amzn_mtls_clientcert_leaf_header_name");

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name");

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_subject_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_subject_header_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_request_x_amzn_mtls_clientcert_subject_header_name");

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_validity_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_mtls_clientcert_validity_header_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_request_x_amzn_mtls_clientcert_validity_header_name");

    /// <summary>
    /// The routing_http_request_x_amzn_tls_cipher_suite_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_tls_cipher_suite_header_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpRequestXAmznTlsCipherSuiteHeaderName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_request_x_amzn_tls_cipher_suite_header_name");

    /// <summary>
    /// The routing_http_request_x_amzn_tls_version_header_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_request_x_amzn_tls_version_header_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpRequestXAmznTlsVersionHeaderName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_request_x_amzn_tls_version_header_name");

    /// <summary>
    /// The routing_http_response_access_control_allow_credentials_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_allow_credentials_header_value")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpResponseAccessControlAllowCredentialsHeaderValue { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_response_access_control_allow_credentials_header_value");

    /// <summary>
    /// The routing_http_response_access_control_allow_headers_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_allow_headers_header_value")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpResponseAccessControlAllowHeadersHeaderValue { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_response_access_control_allow_headers_header_value");

    /// <summary>
    /// The routing_http_response_access_control_allow_methods_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_allow_methods_header_value")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpResponseAccessControlAllowMethodsHeaderValue { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_response_access_control_allow_methods_header_value");

    /// <summary>
    /// The routing_http_response_access_control_allow_origin_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_allow_origin_header_value")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpResponseAccessControlAllowOriginHeaderValue { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_response_access_control_allow_origin_header_value");

    /// <summary>
    /// The routing_http_response_access_control_expose_headers_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_expose_headers_header_value")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpResponseAccessControlExposeHeadersHeaderValue { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_response_access_control_expose_headers_header_value");

    /// <summary>
    /// The routing_http_response_access_control_max_age_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_access_control_max_age_header_value")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpResponseAccessControlMaxAgeHeaderValue { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_response_access_control_max_age_header_value");

    /// <summary>
    /// The routing_http_response_content_security_policy_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_content_security_policy_header_value")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpResponseContentSecurityPolicyHeaderValue { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_response_content_security_policy_header_value");

    /// <summary>
    /// The routing_http_response_server_enabled attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_server_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RoutingHttpResponseServerEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "routing_http_response_server_enabled");

    /// <summary>
    /// The routing_http_response_strict_transport_security_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_strict_transport_security_header_value")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpResponseStrictTransportSecurityHeaderValue { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_response_strict_transport_security_header_value");

    /// <summary>
    /// The routing_http_response_x_content_type_options_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_x_content_type_options_header_value")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpResponseXContentTypeOptionsHeaderValue { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_response_x_content_type_options_header_value");

    /// <summary>
    /// The routing_http_response_x_frame_options_header_value attribute.
    /// </summary>
    [TerraformPropertyName("routing_http_response_x_frame_options_header_value")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoutingHttpResponseXFrameOptionsHeaderValue { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_http_response_x_frame_options_header_value");

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SslPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ssl_policy");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The tcp_idle_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tcp_idle_timeout_seconds")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> TcpIdleTimeoutSeconds { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "tcp_idle_timeout_seconds");

    /// <summary>
    /// Block for default_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    [TerraformPropertyName("default_action")]
    public TerraformList<TerraformBlock<AwsLbListenerDefaultActionBlock>>? DefaultAction { get; set; } = new();

    /// <summary>
    /// Block for mutual_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualAuthentication block(s) allowed")]
    [TerraformPropertyName("mutual_authentication")]
    public TerraformList<TerraformBlock<AwsLbListenerMutualAuthenticationBlock>>? MutualAuthentication { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLbListenerTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
