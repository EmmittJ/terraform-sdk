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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    [TerraformPropertyName("check_interval_sec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CheckIntervalSec => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "check_interval_sec");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("grpc_health_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> GrpcHealthCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "grpc_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("grpc_tls_health_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> GrpcTlsHealthCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "grpc_tls_health_check");

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    [TerraformPropertyName("healthy_threshold")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> HealthyThreshold => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "healthy_threshold");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("http2_health_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Http2HealthCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "http2_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("http_health_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HttpHealthCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "http_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("https_health_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HttpsHealthCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "https_health_check");

    /// <summary>
    /// Configure logging on this health check.
    /// </summary>
    [TerraformPropertyName("log_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LogConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "log_config");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

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
    public TerraformProperty<List<TerraformProperty<string>>> SourceRegions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "source_regions");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("ssl_health_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SslHealthCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ssl_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("tcp_health_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TcpHealthCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "tcp_health_check");

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    [TerraformPropertyName("timeout_sec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TimeoutSec => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "timeout_sec");

    /// <summary>
    /// The type of the health check. One of HTTP, HTTPS, TCP, or SSL.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    [TerraformPropertyName("unhealthy_threshold")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> UnhealthyThreshold => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "unhealthy_threshold");

}
