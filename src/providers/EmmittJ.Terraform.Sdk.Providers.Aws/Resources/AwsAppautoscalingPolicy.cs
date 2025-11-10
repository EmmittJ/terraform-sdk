using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predictive_scaling_policy_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock : ITerraformBlock
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
    public TerraformProperty<TerraformProperty<double>>? MaxCapacityBuffer { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Mode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "mode");

    /// <summary>
    /// The scheduling_buffer_time attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_buffer_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> SchedulingBufferTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "scheduling_buffer_time");

}

/// <summary>
/// Block type for step_scaling_policy_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The adjustment_type attribute.
    /// </summary>
    [TerraformPropertyName("adjustment_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdjustmentType { get; set; }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    [TerraformPropertyName("cooldown")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Cooldown { get; set; }

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    [TerraformPropertyName("metric_aggregation_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MetricAggregationType { get; set; }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    [TerraformPropertyName("min_adjustment_magnitude")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinAdjustmentMagnitude { get; set; }

}

/// <summary>
/// Block type for target_tracking_scaling_policy_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The disable_scale_in attribute.
    /// </summary>
    [TerraformPropertyName("disable_scale_in")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableScaleIn { get; set; }

    /// <summary>
    /// The scale_in_cooldown attribute.
    /// </summary>
    [TerraformPropertyName("scale_in_cooldown")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ScaleInCooldown { get; set; }

    /// <summary>
    /// The scale_out_cooldown attribute.
    /// </summary>
    [TerraformPropertyName("scale_out_cooldown")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ScaleOutCooldown { get; set; }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    [TerraformPropertyName("target_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> TargetValue { get; set; }

}

/// <summary>
/// Manages a aws_appautoscaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppautoscalingPolicy : TerraformResource
{
    public AwsAppautoscalingPolicy(string name) : base("aws_appautoscaling_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceId { get; set; }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    [TerraformPropertyName("scalable_dimension")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScalableDimension { get; set; }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    [TerraformPropertyName("service_namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceNamespace { get; set; }

    /// <summary>
    /// Block for predictive_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingPolicyConfiguration block(s) allowed")]
    [TerraformPropertyName("predictive_scaling_policy_configuration")]
    public TerraformList<TerraformBlock<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock>>? PredictiveScalingPolicyConfiguration { get; set; } = new();

    /// <summary>
    /// Block for step_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StepScalingPolicyConfiguration block(s) allowed")]
    [TerraformPropertyName("step_scaling_policy_configuration")]
    public TerraformList<TerraformBlock<AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock>>? StepScalingPolicyConfiguration { get; set; } = new();

    /// <summary>
    /// Block for target_tracking_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingScalingPolicyConfiguration block(s) allowed")]
    [TerraformPropertyName("target_tracking_scaling_policy_configuration")]
    public TerraformList<TerraformBlock<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock>>? TargetTrackingScalingPolicyConfiguration { get; set; } = new();

    /// <summary>
    /// The alarm_arns attribute.
    /// </summary>
    [TerraformPropertyName("alarm_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AlarmArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "alarm_arns");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
