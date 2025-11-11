using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_health_check.
/// </summary>
public class GoogleComputeHealthCheckDataSource : TerraformDataSource
{
    public GoogleComputeHealthCheckDataSource(string name) : base("google_compute_health_check", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    [TerraformPropertyName("check_interval_sec")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CheckIntervalSec => new TerraformReference(this, "check_interval_sec");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("grpc_health_check")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GrpcHealthCheck => new TerraformReference(this, "grpc_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("grpc_tls_health_check")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GrpcTlsHealthCheck => new TerraformReference(this, "grpc_tls_health_check");

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    [TerraformPropertyName("healthy_threshold")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> HealthyThreshold => new TerraformReference(this, "healthy_threshold");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("http2_health_check")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Http2HealthCheck => new TerraformReference(this, "http2_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("http_health_check")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HttpHealthCheck => new TerraformReference(this, "http_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("https_health_check")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HttpsHealthCheck => new TerraformReference(this, "https_health_check");

    /// <summary>
    /// Configure logging on this health check.
    /// </summary>
    [TerraformPropertyName("log_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LogConfig => new TerraformReference(this, "log_config");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The list of cloud regions from which health checks are performed. If
    /// any regions are specified, then exactly 3 regions should be specified.
    /// The region names must be valid names of Google Cloud regions. This can
    /// only be set for global health check. If this list is non-empty, then
    /// there are restrictions on what other health check fields are supported
    /// and what other resources can use this health check:
    /// 
    /// * SSL, HTTP2, and GRPC protocols are not supported.
    /// 
    /// * The TCP request field is not supported.
    /// 
    /// * The proxyHeader field for HTTP, HTTPS, and TCP is not supported.
    /// 
    /// * The checkIntervalSec field must be at least 30.
    /// 
    /// * The health check cannot be used with BackendService nor with managed
    /// instance group auto-healing.
    /// </summary>
    [TerraformPropertyName("source_regions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SourceRegions => new TerraformReference(this, "source_regions");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("ssl_health_check")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SslHealthCheck => new TerraformReference(this, "ssl_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("tcp_health_check")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TcpHealthCheck => new TerraformReference(this, "tcp_health_check");

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    [TerraformPropertyName("timeout_sec")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TimeoutSec => new TerraformReference(this, "timeout_sec");

    /// <summary>
    /// The type of the health check. One of HTTP, HTTPS, TCP, or SSL.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    [TerraformPropertyName("unhealthy_threshold")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> UnhealthyThreshold => new TerraformReference(this, "unhealthy_threshold");

}
