using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_health_check.
/// </summary>
public partial class GoogleComputeHealthCheckDataSource : TerraformDataSource
{
    public GoogleComputeHealthCheckDataSource(string name) : base("google_compute_health_check", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    [TerraformProperty("check_interval_sec")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CheckIntervalSec { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformProperty("grpc_health_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> GrpcHealthCheck { get; }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformProperty("grpc_tls_health_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> GrpcTlsHealthCheck { get; }

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    [TerraformProperty("healthy_threshold")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> HealthyThreshold { get; }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformProperty("http2_health_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Http2HealthCheck { get; }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformProperty("http_health_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HttpHealthCheck { get; }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformProperty("https_health_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HttpsHealthCheck { get; }

    /// <summary>
    /// Configure logging on this health check.
    /// </summary>
    [TerraformProperty("log_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LogConfig { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

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
    [TerraformProperty("source_regions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SourceRegions { get; }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformProperty("ssl_health_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SslHealthCheck { get; }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformProperty("tcp_health_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TcpHealthCheck { get; }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    [TerraformProperty("timeout_sec")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TimeoutSec { get; }

    /// <summary>
    /// The type of the health check. One of HTTP, HTTPS, TCP, or SSL.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    [TerraformProperty("unhealthy_threshold")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> UnhealthyThreshold { get; }

}
