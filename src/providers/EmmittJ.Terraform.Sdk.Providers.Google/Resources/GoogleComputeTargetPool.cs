using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetPoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("self_link");
        SetOutput("backup_pool");
        SetOutput("description");
        SetOutput("failover_ratio");
        SetOutput("health_checks");
        SetOutput("id");
        SetOutput("instances");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
        SetOutput("session_affinity");
    }

    /// <summary>
    /// URL to the backup target pool. Must also set failover_ratio.
    /// </summary>
    public TerraformProperty<string> BackupPool
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_pool");
        set => SetProperty("backup_pool", value);
    }

    /// <summary>
    /// Textual description field.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Ratio (0 to 1) of failed nodes before using the backup pool (which must also be set).
    /// </summary>
    public TerraformProperty<double> FailoverRatio
    {
        get => GetRequiredOutput<TerraformProperty<double>>("failover_ratio");
        set => SetProperty("failover_ratio", value);
    }

    /// <summary>
    /// List of zero or one health check name or self_link. Only legacy google_compute_http_health_check is supported.
    /// </summary>
    public List<TerraformProperty<string>> HealthChecks
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("health_checks");
        set => SetProperty("health_checks", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// List of instances in the pool. They can be given as URLs, or in the form of &amp;quot;zone/name&amp;quot;. Note that the instances need not exist at the time of target pool creation, so there is no need to use the Terraform interpolators to create a dependency on the instances from the target pool.
    /// </summary>
    public HashSet<TerraformProperty<string>> Instances
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("instances");
        set => SetProperty("instances", value);
    }

    /// <summary>
    /// A unique name for the resource, required by GCE. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Where the target pool resides. Defaults to project region.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// How to distribute load. Options are &amp;quot;NONE&amp;quot; (no affinity). &amp;quot;CLIENT_IP&amp;quot; (hash of the source/dest addresses / ports), and &amp;quot;CLIENT_IP_PROTO&amp;quot; also includes the protocol (default &amp;quot;NONE&amp;quot;).
    /// </summary>
    public TerraformProperty<string> SessionAffinity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("session_affinity");
        set => SetProperty("session_affinity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeTargetPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
