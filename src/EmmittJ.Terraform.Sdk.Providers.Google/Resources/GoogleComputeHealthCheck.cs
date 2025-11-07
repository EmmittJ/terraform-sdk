using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_health_check resource.
/// </summary>
public class GoogleComputeHealthCheck : TerraformResource
{
    public GoogleComputeHealthCheck(string name) : base("google_compute_health_check", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("self_link");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    public TerraformProperty<double>? CheckIntervalSec
    {
        get => GetProperty<TerraformProperty<double>>("check_interval_sec");
        set => this.WithProperty("check_interval_sec", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    public TerraformProperty<double>? HealthyThreshold
    {
        get => GetProperty<TerraformProperty<double>>("healthy_threshold");
        set => this.WithProperty("healthy_threshold", value);
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
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
    public TerraformProperty<List<string>>? SourceRegions
    {
        get => GetProperty<TerraformProperty<List<string>>>("source_regions");
        set => this.WithProperty("source_regions", value);
    }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    public TerraformProperty<double>? TimeoutSec
    {
        get => GetProperty<TerraformProperty<double>>("timeout_sec");
        set => this.WithProperty("timeout_sec", value);
    }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    public TerraformProperty<double>? UnhealthyThreshold
    {
        get => GetProperty<TerraformProperty<double>>("unhealthy_threshold");
        set => this.WithProperty("unhealthy_threshold", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The type of the health check. One of HTTP, HTTPS, TCP, or SSL.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
