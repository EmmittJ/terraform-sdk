using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predictive_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The max_capacity_breach_behavior attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity_breach_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxCapacityBreachBehavior { get; set; }

    /// <summary>
    /// The max_capacity_buffer attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity_buffer")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxCapacityBuffer { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The scheduling_buffer_time attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_buffer_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SchedulingBufferTime { get; set; }

}

/// <summary>
/// Block type for step_adjustment in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingPolicyStepAdjustmentBlock : ITerraformBlock
{
    /// <summary>
    /// The metric_interval_lower_bound attribute.
    /// </summary>
    [TerraformPropertyName("metric_interval_lower_bound")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MetricIntervalLowerBound { get; set; }

    /// <summary>
    /// The metric_interval_upper_bound attribute.
    /// </summary>
    [TerraformPropertyName("metric_interval_upper_bound")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MetricIntervalUpperBound { get; set; }

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingAdjustment is required")]
    [TerraformPropertyName("scaling_adjustment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ScalingAdjustment { get; set; }

}

/// <summary>
/// Block type for target_tracking_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The disable_scale_in attribute.
    /// </summary>
    [TerraformPropertyName("disable_scale_in")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableScaleIn { get; set; }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    [TerraformPropertyName("target_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> TargetValue { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? AdjustmentType { get; set; }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    [TerraformPropertyName("autoscaling_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutoscalingGroupName { get; set; }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    [TerraformPropertyName("cooldown")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Cooldown { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    [TerraformPropertyName("estimated_instance_warmup")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? EstimatedInstanceWarmup { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    [TerraformPropertyName("metric_aggregation_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MetricAggregationType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metric_aggregation_type");

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    [TerraformPropertyName("min_adjustment_magnitude")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinAdjustmentMagnitude { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformPropertyName("policy_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PolicyType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    [TerraformPropertyName("scaling_adjustment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ScalingAdjustment { get; set; }

    /// <summary>
    /// Block for predictive_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingConfiguration block(s) allowed")]
    [TerraformPropertyName("predictive_scaling_configuration")]
    public TerraformList<TerraformBlock<AwsAutoscalingPolicyPredictiveScalingConfigurationBlock>>? PredictiveScalingConfiguration { get; set; } = new();

    /// <summary>
    /// Block for step_adjustment.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("step_adjustment")]
    public TerraformSet<TerraformBlock<AwsAutoscalingPolicyStepAdjustmentBlock>>? StepAdjustment { get; set; } = new();

    /// <summary>
    /// Block for target_tracking_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingConfiguration block(s) allowed")]
    [TerraformPropertyName("target_tracking_configuration")]
    public TerraformList<TerraformBlock<AwsAutoscalingPolicyTargetTrackingConfigurationBlock>>? TargetTrackingConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
