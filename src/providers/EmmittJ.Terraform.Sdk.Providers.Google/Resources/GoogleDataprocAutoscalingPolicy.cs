using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_algorithm in GoogleDataprocAutoscalingPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic_algorithm";

    /// <summary>
    /// Duration between scaling events. A scaling period starts after the
    /// update operation from the previous event has completed.
    /// 
    /// Bounds: [2m, 1d]. Default: 2m.
    /// </summary>
    public TerraformValue<string>? CooldownPeriod
    {
        get => new TerraformReference<string>(this, "cooldown_period");
        set => SetArgument("cooldown_period", value);
    }

    /// <summary>
    /// YarnConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "YarnConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 YarnConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 YarnConfig block(s) allowed")]
    public required TerraformList<GoogleDataprocAutoscalingPolicyBasicAlgorithmBlockYarnConfigBlock> YarnConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocAutoscalingPolicyBasicAlgorithmBlockYarnConfigBlock>>("yarn_config");
        set => SetArgument("yarn_config", value);
    }

}

/// <summary>
/// Block type for yarn_config in GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocAutoscalingPolicyBasicAlgorithmBlockYarnConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "yarn_config";

    /// <summary>
    /// Timeout for YARN graceful decommissioning of Node Managers. Specifies the
    /// duration to wait for jobs to complete before forcefully removing workers
    /// (and potentially interrupting jobs). Only applicable to downscaling operations.
    /// 
    /// Bounds: [0s, 1d].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GracefulDecommissionTimeout is required")]
    public required TerraformValue<string> GracefulDecommissionTimeout
    {
        get => new TerraformReference<string>(this, "graceful_decommission_timeout");
        set => SetArgument("graceful_decommission_timeout", value);
    }

    /// <summary>
    /// Fraction of average pending memory in the last cooldown period for which to
    /// remove workers. A scale-down factor of 1 will result in scaling down so that there
    /// is no available memory remaining after the update (more aggressive scaling).
    /// A scale-down factor of 0 disables removing workers, which can be beneficial for
    /// autoscaling a single job.
    /// 
    /// Bounds: [0.0, 1.0].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleDownFactor is required")]
    public required TerraformValue<double> ScaleDownFactor
    {
        get => new TerraformReference<double>(this, "scale_down_factor");
        set => SetArgument("scale_down_factor", value);
    }

    /// <summary>
    /// Minimum scale-down threshold as a fraction of total cluster size before scaling occurs.
    /// For example, in a 20-worker cluster, a threshold of 0.1 means the autoscaler must
    /// recommend at least a 2 worker scale-down for the cluster to scale. A threshold of 0
    /// means the autoscaler will scale down on any recommended change.
    /// 
    /// Bounds: [0.0, 1.0]. Default: 0.0.
    /// </summary>
    public TerraformValue<double>? ScaleDownMinWorkerFraction
    {
        get => new TerraformReference<double>(this, "scale_down_min_worker_fraction");
        set => SetArgument("scale_down_min_worker_fraction", value);
    }

    /// <summary>
    /// Fraction of average pending memory in the last cooldown period for which to
    /// add workers. A scale-up factor of 1.0 will result in scaling up so that there
    /// is no pending memory remaining after the update (more aggressive scaling).
    /// A scale-up factor closer to 0 will result in a smaller magnitude of scaling up
    /// (less aggressive scaling).
    /// 
    /// Bounds: [0.0, 1.0].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleUpFactor is required")]
    public required TerraformValue<double> ScaleUpFactor
    {
        get => new TerraformReference<double>(this, "scale_up_factor");
        set => SetArgument("scale_up_factor", value);
    }

    /// <summary>
    /// Minimum scale-up threshold as a fraction of total cluster size before scaling
    /// occurs. For example, in a 20-worker cluster, a threshold of 0.1 means the autoscaler
    /// must recommend at least a 2-worker scale-up for the cluster to scale. A threshold of
    /// 0 means the autoscaler will scale up on any recommended change.
    /// 
    /// Bounds: [0.0, 1.0]. Default: 0.0.
    /// </summary>
    public TerraformValue<double>? ScaleUpMinWorkerFraction
    {
        get => new TerraformReference<double>(this, "scale_up_min_worker_fraction");
        set => SetArgument("scale_up_min_worker_fraction", value);
    }

}


/// <summary>
/// Block type for secondary_worker_config in GoogleDataprocAutoscalingPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_worker_config";

    /// <summary>
    /// Maximum number of instances for this group. Note that by default, clusters will not use
    /// secondary workers. Required for secondary workers if the minimum secondary instances is set.
    /// Bounds: [minInstances, ). Defaults to 0.
    /// </summary>
    public TerraformValue<double>? MaxInstances
    {
        get => new TerraformReference<double>(this, "max_instances");
        set => SetArgument("max_instances", value);
    }

    /// <summary>
    /// Minimum number of instances for this group. Bounds: [0, maxInstances]. Defaults to 0.
    /// </summary>
    public TerraformValue<double>? MinInstances
    {
        get => new TerraformReference<double>(this, "min_instances");
        set => SetArgument("min_instances", value);
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
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataprocAutoscalingPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleDataprocAutoscalingPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for worker_config in GoogleDataprocAutoscalingPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocAutoscalingPolicyWorkerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker_config";

    /// <summary>
    /// Maximum number of instances for this group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxInstances is required")]
    public required TerraformValue<double> MaxInstances
    {
        get => new TerraformReference<double>(this, "max_instances");
        set => SetArgument("max_instances", value);
    }

    /// <summary>
    /// Minimum number of instances for this group. Bounds: [2, maxInstances]. Defaults to 2.
    /// </summary>
    public TerraformValue<double>? MinInstances
    {
        get => new TerraformReference<double>(this, "min_instances");
        set => SetArgument("min_instances", value);
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
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Represents a google_dataproc_autoscaling_policy Terraform resource.
/// Manages a google_dataproc_autoscaling_policy resource.
/// </summary>
public partial class GoogleDataprocAutoscalingPolicy(string name) : TerraformResource("google_dataproc_autoscaling_policy", name)
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
    /// The  location where the autoscaling policy should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The policy id. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 50 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformValue<string> PolicyId
    {
        get => new TerraformReference<string>(this, "policy_id");
        set => SetArgument("policy_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The &amp;quot;resource name&amp;quot; of the autoscaling policy.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// BasicAlgorithm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAlgorithm block(s) allowed")]
    public TerraformList<GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock>? BasicAlgorithm
    {
        get => GetArgument<TerraformList<GoogleDataprocAutoscalingPolicyBasicAlgorithmBlock>>("basic_algorithm");
        set => SetArgument("basic_algorithm", value);
    }

    /// <summary>
    /// SecondaryWorkerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryWorkerConfig block(s) allowed")]
    public TerraformList<GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock>? SecondaryWorkerConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocAutoscalingPolicySecondaryWorkerConfigBlock>>("secondary_worker_config");
        set => SetArgument("secondary_worker_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataprocAutoscalingPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataprocAutoscalingPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WorkerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfig block(s) allowed")]
    public TerraformList<GoogleDataprocAutoscalingPolicyWorkerConfigBlock>? WorkerConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocAutoscalingPolicyWorkerConfigBlock>>("worker_config");
        set => SetArgument("worker_config", value);
    }

}
