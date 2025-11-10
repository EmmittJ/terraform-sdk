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
        set => SetProperty("cooldown_period", value);
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
        set => SetProperty("max_instances", value);
    }

    /// <summary>
    /// Minimum number of instances for this group. Bounds: [0, maxInstances]. Defaults to 0.
    /// </summary>
    public TerraformProperty<double>? MinInstances
    {
        set => SetProperty("min_instances", value);
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
        set => SetProperty("weight", value);
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
        set => SetProperty("max_instances", value);
    }

    /// <summary>
    /// Minimum number of instances for this group. Bounds: [2, maxInstances]. Defaults to 2.
    /// </summary>
    public TerraformProperty<double>? MinInstances
    {
        set => SetProperty("min_instances", value);
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
        set => SetProperty("weight", value);
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
        SetOutput("name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("policy_id");
        SetOutput("project");
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
    /// The  location where the autoscaling policy should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The policy id. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 50 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformProperty<string> PolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_id");
        set => SetProperty("policy_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for basic_algorithm.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAlgorithm block(s) allowed")]
    public List<GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock>? BasicAlgorithm
    {
        set => SetProperty("basic_algorithm", value);
    }

    /// <summary>
    /// Block for secondary_worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryWorkerConfig block(s) allowed")]
    public List<GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock>? SecondaryWorkerConfig
    {
        set => SetProperty("secondary_worker_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocAutoscalingPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfig block(s) allowed")]
    public List<GoogleDataprocAutoscalingPolicyWorkerConfigBlock>? WorkerConfig
    {
        set => SetProperty("worker_config", value);
    }

    /// <summary>
    /// The &amp;quot;resource name&amp;quot; of the autoscaling policy.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
