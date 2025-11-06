using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_region_health_check resource.
/// </summary>
public class GoogleComputeRegionHealthCheck : TerraformResource
{
    public GoogleComputeRegionHealthCheck(string name) : base("google_compute_region_health_check", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("health_check_id");
        this.DeclareOutput("self_link");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    public double? CheckIntervalSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("check_interval_sec")?.Value;
        set => this.WithProperty("check_interval_sec", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    public double? HealthyThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("healthy_threshold")?.Value;
        set => this.WithProperty("healthy_threshold", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Region in which the created health check should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    public double? TimeoutSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout_sec")?.Value;
        set => this.WithProperty("timeout_sec", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    public double? UnhealthyThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("unhealthy_threshold")?.Value;
        set => this.WithProperty("unhealthy_threshold", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression HealthCheckId => this["health_check_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The type of the health check. One of HTTP, HTTP2, HTTPS, TCP, or SSL.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
