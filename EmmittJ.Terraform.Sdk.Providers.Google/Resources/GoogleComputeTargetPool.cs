using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_target_pool resource.
/// </summary>
public class GoogleComputeTargetPool : TerraformResource
{
    public GoogleComputeTargetPool(string name) : base("google_compute_target_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// URL to the backup target pool. Must also set failover_ratio.
    /// </summary>
    public string? BackupPool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_pool")?.Value;
        set => this.WithProperty("backup_pool", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Textual description field.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Ratio (0 to 1) of failed nodes before using the backup pool (which must also be set).
    /// </summary>
    public double? FailoverRatio
    {
        get => GetProperty<TerraformLiteralProperty<double>>("failover_ratio")?.Value;
        set => this.WithProperty("failover_ratio", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// List of zero or one health check name or self_link. Only legacy google_compute_http_health_check is supported.
    /// </summary>
    public List<string>? HealthChecks
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("health_checks")?.Value;
        set => this.WithProperty("health_checks", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// List of instances in the pool. They can be given as URLs, or in the form of &amp;quot;zone/name&amp;quot;. Note that the instances need not exist at the time of target pool creation, so there is no need to use the Terraform interpolators to create a dependency on the instances from the target pool.
    /// </summary>
    public HashSet<string>? Instances
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("instances")?.Value;
        set => this.WithProperty("instances", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// A unique name for the resource, required by GCE. Changing this forces a new resource to be created.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Where the target pool resides. Defaults to project region.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// How to distribute load. Options are &amp;quot;NONE&amp;quot; (no affinity). &amp;quot;CLIENT_IP&amp;quot; (hash of the source/dest addresses / ports), and &amp;quot;CLIENT_IP_PROTO&amp;quot; also includes the protocol (default &amp;quot;NONE&amp;quot;).
    /// </summary>
    public string? SessionAffinity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("session_affinity")?.Value;
        set => this.WithProperty("session_affinity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
