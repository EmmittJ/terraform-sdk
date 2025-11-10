using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predictive_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlock : TerraformBlock
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
    public TerraformProperty<string>? MaxCapacityBuffer
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
    public TerraformProperty<string>? SchedulingBufferTime
    {
        set => SetProperty("scheduling_buffer_time", value);
    }

}

/// <summary>
/// Block type for step_adjustment in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingPolicyStepAdjustmentBlock : TerraformBlock
{
    /// <summary>
    /// The metric_interval_lower_bound attribute.
    /// </summary>
    public TerraformProperty<string>? MetricIntervalLowerBound
    {
        set => SetProperty("metric_interval_lower_bound", value);
    }

    /// <summary>
    /// The metric_interval_upper_bound attribute.
    /// </summary>
    public TerraformProperty<string>? MetricIntervalUpperBound
    {
        set => SetProperty("metric_interval_upper_bound", value);
    }

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingAdjustment is required")]
    public required TerraformProperty<double> ScalingAdjustment
    {
        set => SetProperty("scaling_adjustment", value);
    }

}

/// <summary>
/// Block type for target_tracking_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The disable_scale_in attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableScaleIn
    {
        set => SetProperty("disable_scale_in", value);
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
/// Manages a aws_autoscaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAutoscalingPolicy : TerraformResource
{
    public AwsAutoscalingPolicy(string name) : base("aws_autoscaling_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("adjustment_type");
        SetOutput("autoscaling_group_name");
        SetOutput("cooldown");
        SetOutput("enabled");
        SetOutput("estimated_instance_warmup");
        SetOutput("id");
        SetOutput("metric_aggregation_type");
        SetOutput("min_adjustment_magnitude");
        SetOutput("name");
        SetOutput("policy_type");
        SetOutput("region");
        SetOutput("scaling_adjustment");
    }

    /// <summary>
    /// The adjustment_type attribute.
    /// </summary>
    public TerraformProperty<string> AdjustmentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("adjustment_type");
        set => SetProperty("adjustment_type", value);
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    public required TerraformProperty<string> AutoscalingGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("autoscaling_group_name");
        set => SetProperty("autoscaling_group_name", value);
    }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    public TerraformProperty<double> Cooldown
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cooldown");
        set => SetProperty("cooldown", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    public TerraformProperty<double> EstimatedInstanceWarmup
    {
        get => GetRequiredOutput<TerraformProperty<double>>("estimated_instance_warmup");
        set => SetProperty("estimated_instance_warmup", value);
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
    /// The metric_aggregation_type attribute.
    /// </summary>
    public TerraformProperty<string> MetricAggregationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metric_aggregation_type");
        set => SetProperty("metric_aggregation_type", value);
    }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    public TerraformProperty<double> MinAdjustmentMagnitude
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_adjustment_magnitude");
        set => SetProperty("min_adjustment_magnitude", value);
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
    /// The scaling_adjustment attribute.
    /// </summary>
    public TerraformProperty<double> ScalingAdjustment
    {
        get => GetRequiredOutput<TerraformProperty<double>>("scaling_adjustment");
        set => SetProperty("scaling_adjustment", value);
    }

    /// <summary>
    /// Block for predictive_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingConfiguration block(s) allowed")]
    public List<AwsAutoscalingPolicyPredictiveScalingConfigurationBlock>? PredictiveScalingConfiguration
    {
        set => SetProperty("predictive_scaling_configuration", value);
    }

    /// <summary>
    /// Block for step_adjustment.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAutoscalingPolicyStepAdjustmentBlock>? StepAdjustment
    {
        set => SetProperty("step_adjustment", value);
    }

    /// <summary>
    /// Block for target_tracking_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingConfiguration block(s) allowed")]
    public List<AwsAutoscalingPolicyTargetTrackingConfigurationBlock>? TargetTrackingConfiguration
    {
        set => SetProperty("target_tracking_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
