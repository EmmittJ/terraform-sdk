using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predictive_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingPolicyPredictiveScalingConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_capacity_breach_behavior attribute.
    /// </summary>
    [TerraformProperty("max_capacity_breach_behavior")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxCapacityBreachBehavior { get; set; }

    /// <summary>
    /// The max_capacity_buffer attribute.
    /// </summary>
    [TerraformProperty("max_capacity_buffer")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxCapacityBuffer { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The scheduling_buffer_time attribute.
    /// </summary>
    [TerraformProperty("scheduling_buffer_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SchedulingBufferTime { get; set; }

}

/// <summary>
/// Block type for step_adjustment in .
/// Nesting mode: set
/// </summary>
public partial class AwsAutoscalingPolicyStepAdjustmentBlock : TerraformBlockBase
{
    /// <summary>
    /// The metric_interval_lower_bound attribute.
    /// </summary>
    [TerraformProperty("metric_interval_lower_bound")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetricIntervalLowerBound { get; set; }

    /// <summary>
    /// The metric_interval_upper_bound attribute.
    /// </summary>
    [TerraformProperty("metric_interval_upper_bound")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetricIntervalUpperBound { get; set; }

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingAdjustment is required")]
    [TerraformProperty("scaling_adjustment")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ScalingAdjustment { get; set; }

}

/// <summary>
/// Block type for target_tracking_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingPolicyTargetTrackingConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The disable_scale_in attribute.
    /// </summary>
    [TerraformProperty("disable_scale_in")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisableScaleIn { get; set; }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    [TerraformProperty("target_value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> TargetValue { get; set; }

}

/// <summary>
/// Manages a aws_autoscaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAutoscalingPolicy : TerraformResource
{
    public AwsAutoscalingPolicy(string name) : base("aws_autoscaling_policy", name)
    {
    }

    /// <summary>
    /// The adjustment_type attribute.
    /// </summary>
    [TerraformProperty("adjustment_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AdjustmentType { get; set; }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    [TerraformProperty("autoscaling_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AutoscalingGroupName { get; set; }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    [TerraformProperty("cooldown")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Cooldown { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    [TerraformProperty("estimated_instance_warmup")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? EstimatedInstanceWarmup { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    [TerraformProperty("metric_aggregation_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MetricAggregationType { get; set; }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    [TerraformProperty("min_adjustment_magnitude")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinAdjustmentMagnitude { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformProperty("policy_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PolicyType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    [TerraformProperty("scaling_adjustment")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ScalingAdjustment { get; set; }

    /// <summary>
    /// Block for predictive_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingConfiguration block(s) allowed")]
    [TerraformProperty("predictive_scaling_configuration")]
    public TerraformList<TerraformBlock<AwsAutoscalingPolicyPredictiveScalingConfigurationBlock>>? PredictiveScalingConfiguration { get; set; }

    /// <summary>
    /// Block for step_adjustment.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("step_adjustment")]
    public TerraformSet<TerraformBlock<AwsAutoscalingPolicyStepAdjustmentBlock>>? StepAdjustment { get; set; }

    /// <summary>
    /// Block for target_tracking_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingConfiguration block(s) allowed")]
    [TerraformProperty("target_tracking_configuration")]
    public TerraformList<TerraformBlock<AwsAutoscalingPolicyTargetTrackingConfigurationBlock>>? TargetTrackingConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
