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
        get => new TerraformReference<string>(this, "id");
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    public TerraformValue<double> CheckIntervalSec
    {
        get => new TerraformReference<double>(this, "check_interval_sec");
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> GrpcHealthCheck
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "grpc_health_check").ResolveNodes(ctx));
    }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> GrpcTlsHealthCheck
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "grpc_tls_health_check").ResolveNodes(ctx));
    }

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    public TerraformValue<double> HealthyThreshold
    {
        get => new TerraformReference<double>(this, "healthy_threshold");
    }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> Http2HealthCheck
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "http2_health_check").ResolveNodes(ctx));
    }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> HttpHealthCheck
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "http_health_check").ResolveNodes(ctx));
    }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> HttpsHealthCheck
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "https_health_check").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configure logging on this health check.
    /// </summary>
    public TerraformList<TerraformMap<object>> LogConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "log_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

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
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_regions").ResolveNodes(ctx));
    }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslHealthCheck
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ssl_health_check").ResolveNodes(ctx));
    }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> TcpHealthCheck
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "tcp_health_check").ResolveNodes(ctx));
    }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    public TerraformValue<double> TimeoutSec
    {
        get => new TerraformReference<double>(this, "timeout_sec");
    }

    /// <summary>
    /// The type of the health check. One of HTTP, HTTPS, TCP, or SSL.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    public TerraformValue<double> UnhealthyThreshold
    {
        get => new TerraformReference<double>(this, "unhealthy_threshold");
    }

}
