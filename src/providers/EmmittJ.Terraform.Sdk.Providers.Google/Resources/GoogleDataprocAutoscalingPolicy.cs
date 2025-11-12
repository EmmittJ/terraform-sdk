using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_algorithm in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock() : TerraformBlock("basic_algorithm")
{
    /// <summary>
    /// Duration between scaling events. A scaling period starts after the
    /// update operation from the previous event has completed.
    /// 
    /// Bounds: [2m, 1d]. Default: 2m.
    /// </summary>
    [TerraformProperty("cooldown_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CooldownPeriod { get; set; }

}

/// <summary>
/// Block type for secondary_worker_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock() : TerraformBlock("secondary_worker_config")
{
    /// <summary>
    /// Maximum number of instances for this group. Note that by default, clusters will not use
    /// secondary workers. Required for secondary workers if the minimum secondary instances is set.
    /// Bounds: [minInstances, ). Defaults to 0.
    /// </summary>
    [TerraformProperty("max_instances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxInstances { get; set; }

    /// <summary>
    /// Minimum number of instances for this group. Bounds: [0, maxInstances]. Defaults to 0.
    /// </summary>
    [TerraformProperty("min_instances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinInstances { get; set; }

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
    [TerraformProperty("weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Weight { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataprocAutoscalingPolicyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for worker_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocAutoscalingPolicyWorkerConfigBlock() : TerraformBlock("worker_config")
{
    /// <summary>
    /// Maximum number of instances for this group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxInstances is required")]
    [TerraformProperty("max_instances")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxInstances { get; set; }

    /// <summary>
    /// Minimum number of instances for this group. Bounds: [2, maxInstances]. Defaults to 2.
    /// </summary>
    [TerraformProperty("min_instances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinInstances { get; set; }

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
    [TerraformProperty("weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Weight { get; set; }

}

/// <summary>
/// Manages a google_dataproc_autoscaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataprocAutoscalingPolicy : TerraformResource
{
    public GoogleDataprocAutoscalingPolicy(string name) : base("google_dataproc_autoscaling_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The  location where the autoscaling policy should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The policy id. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 50 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    [TerraformProperty("policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for basic_algorithm.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAlgorithm block(s) allowed")]
    [TerraformProperty("basic_algorithm")]
    public TerraformList<GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock> BasicAlgorithm { get; set; } = new();

    /// <summary>
    /// Block for secondary_worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryWorkerConfig block(s) allowed")]
    [TerraformProperty("secondary_worker_config")]
    public TerraformList<GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock> SecondaryWorkerConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDataprocAutoscalingPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfig block(s) allowed")]
    [TerraformProperty("worker_config")]
    public TerraformList<GoogleDataprocAutoscalingPolicyWorkerConfigBlock> WorkerConfig { get; set; } = new();

    /// <summary>
    /// The &amp;quot;resource name&amp;quot; of the autoscaling policy.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
