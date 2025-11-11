using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predictive_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlock
{
    /// <summary>
    /// The max_capacity_breach_behavior attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity_breach_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxCapacityBreachBehavior { get; set; }

    /// <summary>
    /// The max_capacity_buffer attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity_buffer")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxCapacityBuffer { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The scheduling_buffer_time attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_buffer_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SchedulingBufferTime { get; set; }

}

/// <summary>
/// Block type for step_adjustment in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingPolicyStepAdjustmentBlock
{
    /// <summary>
    /// The metric_interval_lower_bound attribute.
    /// </summary>
    [TerraformPropertyName("metric_interval_lower_bound")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MetricIntervalLowerBound { get; set; }

    /// <summary>
    /// The metric_interval_upper_bound attribute.
    /// </summary>
    [TerraformPropertyName("metric_interval_upper_bound")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MetricIntervalUpperBound { get; set; }

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingAdjustment is required")]
    [TerraformPropertyName("scaling_adjustment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ScalingAdjustment { get; set; }

}

/// <summary>
/// Block type for target_tracking_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlock
{
    /// <summary>
    /// The disable_scale_in attribute.
    /// </summary>
    [TerraformPropertyName("disable_scale_in")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableScaleIn { get; set; }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    [TerraformPropertyName("target_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> TargetValue { get; set; }

}

/// <summary>
/// Manages a aws_autoscaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAutoscalingPolicy : TerraformResource
{
    public AwsAutoscalingPolicy(string name) : base("aws_autoscaling_policy", name)
    {
    }

    /// <summary>
    /// The adjustment_type attribute.
    /// </summary>
    [TerraformPropertyName("adjustment_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdjustmentType { get; set; }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    [TerraformPropertyName("autoscaling_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AutoscalingGroupName { get; set; }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    [TerraformPropertyName("cooldown")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Cooldown { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    [TerraformPropertyName("estimated_instance_warmup")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? EstimatedInstanceWarmup { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    [TerraformPropertyName("metric_aggregation_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MetricAggregationType { get; set; } = default!;

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    [TerraformPropertyName("min_adjustment_magnitude")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinAdjustmentMagnitude { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformPropertyName("policy_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    [TerraformPropertyName("scaling_adjustment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ScalingAdjustment { get; set; }

    /// <summary>
    /// Block for predictive_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingConfiguration block(s) allowed")]
    [TerraformPropertyName("predictive_scaling_configuration")]
    public TerraformList<TerraformBlock<AwsAutoscalingPolicyPredictiveScalingConfigurationBlock>>? PredictiveScalingConfiguration { get; set; }

    /// <summary>
    /// Block for step_adjustment.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("step_adjustment")]
    public TerraformSet<TerraformBlock<AwsAutoscalingPolicyStepAdjustmentBlock>>? StepAdjustment { get; set; }

    /// <summary>
    /// Block for target_tracking_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingConfiguration block(s) allowed")]
    [TerraformPropertyName("target_tracking_configuration")]
    public TerraformList<TerraformBlock<AwsAutoscalingPolicyTargetTrackingConfigurationBlock>>? TargetTrackingConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
