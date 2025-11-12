using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predictive_scaling_policy_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock() : TerraformBlock("predictive_scaling_policy_configuration")
{
    /// <summary>
    /// The max_capacity_breach_behavior attribute.
    /// </summary>
    [TerraformProperty("max_capacity_breach_behavior")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxCapacityBreachBehavior { get; set; }

    /// <summary>
    /// The max_capacity_buffer attribute.
    /// </summary>
    [TerraformProperty("max_capacity_buffer")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxCapacityBuffer { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// The scheduling_buffer_time attribute.
    /// </summary>
    [TerraformProperty("scheduling_buffer_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SchedulingBufferTime { get; set; }

}

/// <summary>
/// Block type for step_scaling_policy_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock() : TerraformBlock("step_scaling_policy_configuration")
{
    /// <summary>
    /// The adjustment_type attribute.
    /// </summary>
    [TerraformProperty("adjustment_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdjustmentType { get; set; }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    [TerraformProperty("cooldown")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Cooldown { get; set; }

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    [TerraformProperty("metric_aggregation_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MetricAggregationType { get; set; }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    [TerraformProperty("min_adjustment_magnitude")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinAdjustmentMagnitude { get; set; }

}

/// <summary>
/// Block type for target_tracking_scaling_policy_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock() : TerraformBlock("target_tracking_scaling_policy_configuration")
{
    /// <summary>
    /// The disable_scale_in attribute.
    /// </summary>
    [TerraformProperty("disable_scale_in")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableScaleIn { get; set; }

    /// <summary>
    /// The scale_in_cooldown attribute.
    /// </summary>
    [TerraformProperty("scale_in_cooldown")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ScaleInCooldown { get; set; }

    /// <summary>
    /// The scale_out_cooldown attribute.
    /// </summary>
    [TerraformProperty("scale_out_cooldown")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ScaleOutCooldown { get; set; }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    [TerraformProperty("target_value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> TargetValue { get; set; }

}

/// <summary>
/// Manages a aws_appautoscaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppautoscalingPolicy : TerraformResource
{
    public AwsAppautoscalingPolicy(string name) : base("aws_appautoscaling_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformProperty("policy_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    [TerraformProperty("scalable_dimension")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScalableDimension { get; set; }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    [TerraformProperty("service_namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceNamespace { get; set; }

    /// <summary>
    /// Block for predictive_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingPolicyConfiguration block(s) allowed")]
    [TerraformProperty("predictive_scaling_policy_configuration")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock> PredictiveScalingPolicyConfiguration { get; set; } = new();

    /// <summary>
    /// Block for step_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StepScalingPolicyConfiguration block(s) allowed")]
    [TerraformProperty("step_scaling_policy_configuration")]
    public TerraformList<AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock> StepScalingPolicyConfiguration { get; set; } = new();

    /// <summary>
    /// Block for target_tracking_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingScalingPolicyConfiguration block(s) allowed")]
    [TerraformProperty("target_tracking_scaling_policy_configuration")]
    public TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock> TargetTrackingScalingPolicyConfiguration { get; set; } = new();

    /// <summary>
    /// The alarm_arns attribute.
    /// </summary>
    [TerraformProperty("alarm_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AlarmArns { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
