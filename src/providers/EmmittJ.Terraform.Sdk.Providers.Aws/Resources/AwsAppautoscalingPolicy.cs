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
        get => GetProperty<TerraformProperty<string>>("max_capacity_breach_behavior");
        set => WithProperty("max_capacity_breach_behavior", value);
    }

    /// <summary>
    /// The max_capacity_buffer attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacityBuffer
    {
        get => GetProperty<TerraformProperty<double>>("max_capacity_buffer");
        set => WithProperty("max_capacity_buffer", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The scheduling_buffer_time attribute.
    /// </summary>
    public TerraformProperty<double>? SchedulingBufferTime
    {
        get => GetProperty<TerraformProperty<double>>("scheduling_buffer_time");
        set => WithProperty("scheduling_buffer_time", value);
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
        get => GetProperty<TerraformProperty<string>>("adjustment_type");
        set => WithProperty("adjustment_type", value);
    }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    public TerraformProperty<double>? Cooldown
    {
        get => GetProperty<TerraformProperty<double>>("cooldown");
        set => WithProperty("cooldown", value);
    }

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    public TerraformProperty<string>? MetricAggregationType
    {
        get => GetProperty<TerraformProperty<string>>("metric_aggregation_type");
        set => WithProperty("metric_aggregation_type", value);
    }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    public TerraformProperty<double>? MinAdjustmentMagnitude
    {
        get => GetProperty<TerraformProperty<double>>("min_adjustment_magnitude");
        set => WithProperty("min_adjustment_magnitude", value);
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
        get => GetProperty<TerraformProperty<bool>>("disable_scale_in");
        set => WithProperty("disable_scale_in", value);
    }

    /// <summary>
    /// The scale_in_cooldown attribute.
    /// </summary>
    public TerraformProperty<double>? ScaleInCooldown
    {
        get => GetProperty<TerraformProperty<double>>("scale_in_cooldown");
        set => WithProperty("scale_in_cooldown", value);
    }

    /// <summary>
    /// The scale_out_cooldown attribute.
    /// </summary>
    public TerraformProperty<double>? ScaleOutCooldown
    {
        get => GetProperty<TerraformProperty<double>>("scale_out_cooldown");
        set => WithProperty("scale_out_cooldown", value);
    }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    public required TerraformProperty<double> TargetValue
    {
        get => GetRequiredProperty<TerraformProperty<double>>("target_value");
        set => WithProperty("target_value", value);
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
        this.DeclareOutput("alarm_arns");
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyType
    {
        get => GetProperty<TerraformProperty<string>>("policy_type");
        set => this.WithProperty("policy_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformProperty<string> ScalableDimension
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scalable_dimension");
        set => this.WithProperty("scalable_dimension", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformProperty<string> ServiceNamespace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_namespace");
        set => this.WithProperty("service_namespace", value);
    }

    /// <summary>
    /// Block for predictive_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingPolicyConfiguration block(s) allowed")]
    public List<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock>? PredictiveScalingPolicyConfiguration
    {
        get => GetProperty<List<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock>>("predictive_scaling_policy_configuration");
        set => this.WithProperty("predictive_scaling_policy_configuration", value);
    }

    /// <summary>
    /// Block for step_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StepScalingPolicyConfiguration block(s) allowed")]
    public List<AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock>? StepScalingPolicyConfiguration
    {
        get => GetProperty<List<AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock>>("step_scaling_policy_configuration");
        set => this.WithProperty("step_scaling_policy_configuration", value);
    }

    /// <summary>
    /// Block for target_tracking_scaling_policy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingScalingPolicyConfiguration block(s) allowed")]
    public List<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock>? TargetTrackingScalingPolicyConfiguration
    {
        get => GetProperty<List<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock>>("target_tracking_scaling_policy_configuration");
        set => this.WithProperty("target_tracking_scaling_policy_configuration", value);
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
