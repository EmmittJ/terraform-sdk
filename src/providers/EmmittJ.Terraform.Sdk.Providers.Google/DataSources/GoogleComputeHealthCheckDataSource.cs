using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_health_check Terraform data source.
/// Retrieves information about a google_compute_health_check.
/// </summary>
public partial class GoogleComputeHealthCheckDataSource(string name) : TerraformDataSource("google_compute_health_check", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

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
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    public TerraformValue<double> CheckIntervalSec
        => CreateReference("check_interval_sec");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> GrpcHealthCheck
        => CreateReference("grpc_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> GrpcTlsHealthCheck
        => CreateReference("grpc_tls_health_check");

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    public TerraformValue<double> HealthyThreshold
        => CreateReference("healthy_threshold");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> Http2HealthCheck
        => CreateReference("http2_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> HttpHealthCheck
        => CreateReference("http_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> HttpsHealthCheck
        => CreateReference("https_health_check");

    /// <summary>
    /// Configure logging on this health check.
    /// </summary>
    public TerraformList<TerraformMap<object>> LogConfig
        => CreateReference("log_config");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

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
    public TerraformList<string> SourceRegions
        => CreateReference("source_regions");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslHealthCheck
        => CreateReference("ssl_health_check");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> TcpHealthCheck
        => CreateReference("tcp_health_check");

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    public TerraformValue<double> TimeoutSec
        => CreateReference("timeout_sec");

    /// <summary>
    /// The type of the health check. One of HTTP, HTTPS, TCP, or SSL.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    public TerraformValue<double> UnhealthyThreshold
        => CreateReference("unhealthy_threshold");

}
