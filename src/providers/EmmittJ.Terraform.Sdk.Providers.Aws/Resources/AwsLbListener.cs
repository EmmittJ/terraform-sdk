using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in .
/// Nesting mode: list
/// </summary>
public partial class AwsLbListenerDefaultActionBlock() : TerraformBlock("default_action")
{
    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformProperty("order")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [TerraformProperty("target_group_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetGroupArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for mutual_authentication in .
/// Nesting mode: list
/// </summary>
public partial class AwsLbListenerMutualAuthenticationBlock() : TerraformBlock("mutual_authentication")
{
    /// <summary>
    /// The advertise_trust_store_ca_names attribute.
    /// </summary>
    [TerraformProperty("advertise_trust_store_ca_names")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AdvertiseTrustStoreCaNames { get; set; }

    /// <summary>
    /// The ignore_client_certificate_expiry attribute.
    /// </summary>
    [TerraformProperty("ignore_client_certificate_expiry")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreClientCertificateExpiry { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [TerraformProperty("trust_store_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TrustStoreArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLbListenerTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_lb_listener resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLbListener : TerraformResource
{
    public AwsLbListener(string name) : base("aws_lb_listener", name)
    {
    }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    [TerraformProperty("alpn_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AlpnPolicy { get; set; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerArn is required")]
    [TerraformProperty("load_balancer_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LoadBalancerArn { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_header_name attribute.
    /// </summary>
    [TerraformProperty("routing_http_request_x_amzn_mtls_clientcert_header_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertHeaderName { get; set; }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_issuer_header_name attribute.
    /// </summary>
    [TerraformProperty("routing_http_request_x_amzn_mtls_clientcert_issuer_header_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName { get; set; }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_leaf_header_name attribute.
    /// </summary>
    [TerraformProperty("routing_http_request_x_amzn_mtls_clientcert_leaf_header_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName { get; set; }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name attribute.
    /// </summary>
    [TerraformProperty("routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName { get; set; }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_subject_header_name attribute.
    /// </summary>
    [TerraformProperty("routing_http_request_x_amzn_mtls_clientcert_subject_header_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName { get; set; }

    /// <summary>
    /// The routing_http_request_x_amzn_mtls_clientcert_validity_header_name attribute.
    /// </summary>
    [TerraformProperty("routing_http_request_x_amzn_mtls_clientcert_validity_header_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName { get; set; }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_cipher_suite_header_name attribute.
    /// </summary>
    [TerraformProperty("routing_http_request_x_amzn_tls_cipher_suite_header_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpRequestXAmznTlsCipherSuiteHeaderName { get; set; }

    /// <summary>
    /// The routing_http_request_x_amzn_tls_version_header_name attribute.
    /// </summary>
    [TerraformProperty("routing_http_request_x_amzn_tls_version_header_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpRequestXAmznTlsVersionHeaderName { get; set; }

    /// <summary>
    /// The routing_http_response_access_control_allow_credentials_header_value attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_access_control_allow_credentials_header_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpResponseAccessControlAllowCredentialsHeaderValue { get; set; }

    /// <summary>
    /// The routing_http_response_access_control_allow_headers_header_value attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_access_control_allow_headers_header_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpResponseAccessControlAllowHeadersHeaderValue { get; set; }

    /// <summary>
    /// The routing_http_response_access_control_allow_methods_header_value attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_access_control_allow_methods_header_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpResponseAccessControlAllowMethodsHeaderValue { get; set; }

    /// <summary>
    /// The routing_http_response_access_control_allow_origin_header_value attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_access_control_allow_origin_header_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpResponseAccessControlAllowOriginHeaderValue { get; set; }

    /// <summary>
    /// The routing_http_response_access_control_expose_headers_header_value attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_access_control_expose_headers_header_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpResponseAccessControlExposeHeadersHeaderValue { get; set; }

    /// <summary>
    /// The routing_http_response_access_control_max_age_header_value attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_access_control_max_age_header_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpResponseAccessControlMaxAgeHeaderValue { get; set; }

    /// <summary>
    /// The routing_http_response_content_security_policy_header_value attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_content_security_policy_header_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpResponseContentSecurityPolicyHeaderValue { get; set; }

    /// <summary>
    /// The routing_http_response_server_enabled attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_server_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> RoutingHttpResponseServerEnabled { get; set; }

    /// <summary>
    /// The routing_http_response_strict_transport_security_header_value attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_strict_transport_security_header_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpResponseStrictTransportSecurityHeaderValue { get; set; }

    /// <summary>
    /// The routing_http_response_x_content_type_options_header_value attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_x_content_type_options_header_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpResponseXContentTypeOptionsHeaderValue { get; set; }

    /// <summary>
    /// The routing_http_response_x_frame_options_header_value attribute.
    /// </summary>
    [TerraformProperty("routing_http_response_x_frame_options_header_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingHttpResponseXFrameOptionsHeaderValue { get; set; }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformProperty("ssl_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SslPolicy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The tcp_idle_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("tcp_idle_timeout_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> TcpIdleTimeoutSeconds { get; set; }

    /// <summary>
    /// Block for default_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    [TerraformProperty("default_action")]
    public required TerraformList<AwsLbListenerDefaultActionBlock> DefaultAction { get; set; } = new();

    /// <summary>
    /// Block for mutual_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualAuthentication block(s) allowed")]
    [TerraformProperty("mutual_authentication")]
    public TerraformList<AwsLbListenerMutualAuthenticationBlock> MutualAuthentication { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsLbListenerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
