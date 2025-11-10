using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_algorithm in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock : TerraformBlock
{
    /// <summary>
    /// Duration between scaling events. A scaling period starts after the
    /// update operation from the previous event has completed.
    /// 
    /// Bounds: [2m, 1d]. Default: 2m.
    /// </summary>
    public TerraformProperty<string>? CooldownPeriod
    {
        get => GetProperty<TerraformProperty<string>>("cooldown_period");
        set => WithProperty("cooldown_period", value);
    }

}

/// <summary>
/// Block type for secondary_worker_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Maximum number of instances for this group. Note that by default, clusters will not use
    /// secondary workers. Required for secondary workers if the minimum secondary instances is set.
    /// Bounds: [minInstances, ). Defaults to 0.
    /// </summary>
    public TerraformProperty<double>? MaxInstances
    {
        get => GetProperty<TerraformProperty<double>>("max_instances");
        set => WithProperty("max_instances", value);
    }

    /// <summary>
    /// Minimum number of instances for this group. Bounds: [0, maxInstances]. Defaults to 0.
    /// </summary>
    public TerraformProperty<double>? MinInstances
    {
        get => GetProperty<TerraformProperty<double>>("min_instances");
        set => WithProperty("min_instances", value);
    }

    /// <summary>
    /// Weight for the instance group, which is used to determine the fraction of total workers
    /// in the cluster from this instance group. For example, if primary workers have weight 2,
    /// and secondary workers have weight 1, the cluster will have approximately 2 primary workers
    /// for each secondary worker.
    /// 
    /// The cluster may not reach the specified balance if constrained by min/max bounds or other
    /// autoscaling settings. For example, if maxInstances for secondary workers is 0, then only
    /// primary workers will be added. The cluster can also be out of balance when created.
    /// 
    /// If weight is not set on any instance group, the cluster will default to equal weight for
    /// all groups: the cluster will attempt to maintain an equal number of workers in each group
    /// within the configured size bounds for each group. If weight is set for one group only,
    /// the cluster will default to zero weight on the unset group. For example if weight is set
    /// only on primary workers, the cluster will use primary workers only and no secondary workers.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        get => GetProperty<TerraformProperty<double>>("weight");
        set => WithProperty("weight", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocAutoscalingPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for worker_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocAutoscalingPolicyWorkerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Maximum number of instances for this group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxInstances is required")]
    public required TerraformProperty<double> MaxInstances
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_instances");
        set => WithProperty("max_instances", value);
    }

    /// <summary>
    /// Minimum number of instances for this group. Bounds: [2, maxInstances]. Defaults to 2.
    /// </summary>
    public TerraformProperty<double>? MinInstances
    {
        get => GetProperty<TerraformProperty<double>>("min_instances");
        set => WithProperty("min_instances", value);
    }

    /// <summary>
    /// Weight for the instance group, which is used to determine the fraction of total workers
    /// in the cluster from this instance group. For example, if primary workers have weight 2,
    /// and secondary workers have weight 1, the cluster will have approximately 2 primary workers
    /// for each secondary worker.
    /// 
    /// The cluster may not reach the specified balance if constrained by min/max bounds or other
    /// autoscaling settings. For example, if maxInstances for secondary workers is 0, then only
    /// primary workers will be added. The cluster can also be out of balance when created.
    /// 
    /// If weight is not set on any instance group, the cluster will default to equal weight for
    /// all groups: the cluster will attempt to maintain an equal number of workers in each group
    /// within the configured size bounds for each group. If weight is set for one group only,
    /// the cluster will default to zero weight on the unset group. For example if weight is set
    /// only on primary workers, the cluster will use primary workers only and no secondary workers.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        get => GetProperty<TerraformProperty<double>>("weight");
        set => WithProperty("weight", value);
    }

}

/// <summary>
/// Manages a google_dataproc_autoscaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocAutoscalingPolicy : TerraformResource
{
    public GoogleDataprocAutoscalingPolicy(string name) : base("google_dataproc_autoscaling_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
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
    /// The  location where the autoscaling policy should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The policy id. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 50 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformProperty<string> PolicyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("policy_id");
        set => this.WithProperty("policy_id", value);
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
    /// Block for basic_algorithm.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAlgorithm block(s) allowed")]
    public List<GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock>? BasicAlgorithm
    {
        get => GetProperty<List<GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock>>("basic_algorithm");
        set => this.WithProperty("basic_algorithm", value);
    }

    /// <summary>
    /// Block for secondary_worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryWorkerConfig block(s) allowed")]
    public List<GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock>? SecondaryWorkerConfig
    {
        get => GetProperty<List<GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock>>("secondary_worker_config");
        set => this.WithProperty("secondary_worker_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocAutoscalingPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataprocAutoscalingPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfig block(s) allowed")]
    public List<GoogleDataprocAutoscalingPolicyWorkerConfigBlock>? WorkerConfig
    {
        get => GetProperty<List<GoogleDataprocAutoscalingPolicyWorkerConfigBlock>>("worker_config");
        set => this.WithProperty("worker_config", value);
    }

    /// <summary>
    /// The &amp;quot;resource name&amp;quot; of the autoscaling policy.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
