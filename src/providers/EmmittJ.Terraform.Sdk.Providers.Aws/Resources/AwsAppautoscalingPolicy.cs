using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predictive_scaling_policy_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The max_capacity_breach_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? MaxCapacityBreachBehavior
    {
        set => SetProperty("max_capacity_breach_behavior", value);
    }

    /// <summary>
    /// The max_capacity_buffer attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacityBuffer
    {
        set => SetProperty("max_capacity_buffer", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The scheduling_buffer_time attribute.
    /// </summary>
    public TerraformProperty<double>? SchedulingBufferTime
    {
        set => SetProperty("scheduling_buffer_time", value);
    }

}

/// <summary>
/// Block type for step_scaling_policy_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The adjustment_type attribute.
    /// </summary>
    public TerraformProperty<string>? AdjustmentType
    {
        set => SetProperty("adjustment_type", value);
    }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    public TerraformProperty<double>? Cooldown
    {
        set => SetProperty("cooldown", value);
    }

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    public TerraformProperty<string>? MetricAggregationType
    {
        set => SetProperty("metric_aggregation_type", value);
    }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    public TerraformProperty<double>? MinAdjustmentMagnitude
    {
        set => SetProperty("min_adjustment_magnitude", value);
    }

}

/// <summary>
/// Block type for target_tracking_scaling_policy_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The disable_scale_in attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableScaleIn
    {
        set => SetProperty("disable_scale_in", value);
    }

    /// <summary>
    /// The scale_in_cooldown attribute.
    /// </summary>
    public TerraformProperty<double>? ScaleInCooldown
    {
        set => SetProperty("scale_in_cooldown", value);
    }

    /// <summary>
    /// The scale_out_cooldown attribute.
    /// </summary>
    public TerraformProperty<double>? ScaleOutCooldown
    {
        set => SetProperty("scale_out_cooldown", value);
    }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    public required TerraformProperty<double> TargetValue
    {
        set => SetProperty("target_value", value);
    }

}

/// <summary>
/// Manages a aws_appautoscaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppautoscalingPolicy : TerraformResource
{
    public AwsAppautoscalingPolicy(string name) : base("aws_appautoscaling_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("alarm_arns");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("policy_type");
        SetOutput("region");
        SetOutput("resource_id");
        SetOutput("scalable_dimension");
        SetOutput("service_namespace");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformProperty<string> PolicyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_type");
        set => SetProperty("policy_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_id");
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformProperty<string> ScalableDimension
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scalable_dimension");
        set => SetProperty("scalable_dimension", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformProperty<string> ServiceNamespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_namespace");
        set => SetProperty("service_namespace", value);
    }

    /// <summary>
    /// Block for predictive_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingPolicyConfiguration block(s) allowed")]
    public List<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock>? PredictiveScalingPolicyConfiguration
    {
        set => SetProperty("predictive_scaling_policy_configuration", value);
    }

    /// <summary>
    /// Block for step_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StepScalingPolicyConfiguration block(s) allowed")]
    public List<AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock>? StepScalingPolicyConfiguration
    {
        set => SetProperty("step_scaling_policy_configuration", value);
    }

    /// <summary>
    /// Block for target_tracking_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingScalingPolicyConfiguration block(s) allowed")]
    public List<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock>? TargetTrackingScalingPolicyConfiguration
    {
        set => SetProperty("target_tracking_scaling_policy_configuration", value);
    }

    /// <summary>
    /// The alarm_arns attribute.
    /// </summary>
    public TerraformExpression AlarmArns => this["alarm_arns"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
