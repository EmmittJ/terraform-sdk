using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_algorithm in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock : ITerraformBlock
{
    /// <summary>
    /// Duration between scaling events. A scaling period starts after the
    /// update operation from the previous event has completed.
    /// 
    /// Bounds: [2m, 1d]. Default: 2m.
    /// </summary>
    [TerraformPropertyName("cooldown_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CooldownPeriod { get; set; }

}

/// <summary>
/// Block type for secondary_worker_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Maximum number of instances for this group. Note that by default, clusters will not use
    /// secondary workers. Required for secondary workers if the minimum secondary instances is set.
    /// Bounds: [minInstances, ). Defaults to 0.
    /// </summary>
    [TerraformPropertyName("max_instances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxInstances { get; set; }

    /// <summary>
    /// Minimum number of instances for this group. Bounds: [0, maxInstances]. Defaults to 0.
    /// </summary>
    [TerraformPropertyName("min_instances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinInstances { get; set; }

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
    [TerraformPropertyName("weight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Weight { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocAutoscalingPolicyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for worker_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocAutoscalingPolicyWorkerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Maximum number of instances for this group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxInstances is required")]
    [TerraformPropertyName("max_instances")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxInstances { get; set; }

    /// <summary>
    /// Minimum number of instances for this group. Bounds: [2, maxInstances]. Defaults to 2.
    /// </summary>
    [TerraformPropertyName("min_instances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinInstances { get; set; }

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
    [TerraformPropertyName("weight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Weight { get; set; }

}

/// <summary>
/// Manages a google_dataproc_autoscaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocAutoscalingPolicy : TerraformResource
{
    public GoogleDataprocAutoscalingPolicy(string name) : base("google_dataproc_autoscaling_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The  location where the autoscaling policy should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The policy id. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 50 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    [TerraformPropertyName("policy_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PolicyId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for basic_algorithm.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAlgorithm block(s) allowed")]
    [TerraformPropertyName("basic_algorithm")]
    public TerraformList<TerraformBlock<GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock>>? BasicAlgorithm { get; set; } = new();

    /// <summary>
    /// Block for secondary_worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryWorkerConfig block(s) allowed")]
    [TerraformPropertyName("secondary_worker_config")]
    public TerraformList<TerraformBlock<GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock>>? SecondaryWorkerConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataprocAutoscalingPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfig block(s) allowed")]
    [TerraformPropertyName("worker_config")]
    public TerraformList<TerraformBlock<GoogleDataprocAutoscalingPolicyWorkerConfigBlock>>? WorkerConfig { get; set; } = new();

    /// <summary>
    /// The &amp;quot;resource name&amp;quot; of the autoscaling policy.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
