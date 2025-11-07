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
    public TerraformProperty<string>? BackupPool
    {
        get => GetProperty<TerraformProperty<string>>("backup_pool");
        set => this.WithProperty("backup_pool", value);
    }

    /// <summary>
    /// Textual description field.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Ratio (0 to 1) of failed nodes before using the backup pool (which must also be set).
    /// </summary>
    public TerraformProperty<double>? FailoverRatio
    {
        get => GetProperty<TerraformProperty<double>>("failover_ratio");
        set => this.WithProperty("failover_ratio", value);
    }

    /// <summary>
    /// List of zero or one health check name or self_link. Only legacy google_compute_http_health_check is supported.
    /// </summary>
    public TerraformProperty<List<string>>? HealthChecks
    {
        get => GetProperty<TerraformProperty<List<string>>>("health_checks");
        set => this.WithProperty("health_checks", value);
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
    /// List of instances in the pool. They can be given as URLs, or in the form of &amp;quot;zone/name&amp;quot;. Note that the instances need not exist at the time of target pool creation, so there is no need to use the Terraform interpolators to create a dependency on the instances from the target pool.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Instances
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("instances");
        set => this.WithProperty("instances", value);
    }

    /// <summary>
    /// A unique name for the resource, required by GCE. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Where the target pool resides. Defaults to project region.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// How to distribute load. Options are &amp;quot;NONE&amp;quot; (no affinity). &amp;quot;CLIENT_IP&amp;quot; (hash of the source/dest addresses / ports), and &amp;quot;CLIENT_IP_PROTO&amp;quot; also includes the protocol (default &amp;quot;NONE&amp;quot;).
    /// </summary>
    public TerraformProperty<string>? SessionAffinity
    {
        get => GetProperty<TerraformProperty<string>>("session_affinity");
        set => this.WithProperty("session_affinity", value);
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
