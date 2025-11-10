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
        get => GetProperty<TerraformProperty<string>>("max_capacity_breach_behavior");
        set => WithProperty("max_capacity_breach_behavior", value);
    }

    /// <summary>
    /// The max_capacity_buffer attribute.
    /// </summary>
    public TerraformProperty<string>? MaxCapacityBuffer
    {
        get => GetProperty<TerraformProperty<string>>("max_capacity_buffer");
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
    public TerraformProperty<string>? SchedulingBufferTime
    {
        get => GetProperty<TerraformProperty<string>>("scheduling_buffer_time");
        set => WithProperty("scheduling_buffer_time", value);
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
        get => GetProperty<TerraformProperty<string>>("metric_interval_lower_bound");
        set => WithProperty("metric_interval_lower_bound", value);
    }

    /// <summary>
    /// The metric_interval_upper_bound attribute.
    /// </summary>
    public TerraformProperty<string>? MetricIntervalUpperBound
    {
        get => GetProperty<TerraformProperty<string>>("metric_interval_upper_bound");
        set => WithProperty("metric_interval_upper_bound", value);
    }

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingAdjustment is required")]
    public required TerraformProperty<double> ScalingAdjustment
    {
        get => GetProperty<TerraformProperty<double>>("scaling_adjustment");
        set => WithProperty("scaling_adjustment", value);
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
        get => GetProperty<TerraformProperty<bool>>("disable_scale_in");
        set => WithProperty("disable_scale_in", value);
    }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    public required TerraformProperty<double> TargetValue
    {
        get => GetProperty<TerraformProperty<double>>("target_value");
        set => WithProperty("target_value", value);
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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The adjustment_type attribute.
    /// </summary>
    public TerraformProperty<string>? AdjustmentType
    {
        get => GetProperty<TerraformProperty<string>>("adjustment_type");
        set => this.WithProperty("adjustment_type", value);
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    public required TerraformProperty<string> AutoscalingGroupName
    {
        get => GetProperty<TerraformProperty<string>>("autoscaling_group_name");
        set => this.WithProperty("autoscaling_group_name", value);
    }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    public TerraformProperty<double>? Cooldown
    {
        get => GetProperty<TerraformProperty<double>>("cooldown");
        set => this.WithProperty("cooldown", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    public TerraformProperty<double>? EstimatedInstanceWarmup
    {
        get => GetProperty<TerraformProperty<double>>("estimated_instance_warmup");
        set => this.WithProperty("estimated_instance_warmup", value);
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
    /// The metric_aggregation_type attribute.
    /// </summary>
    public TerraformProperty<string>? MetricAggregationType
    {
        get => GetProperty<TerraformProperty<string>>("metric_aggregation_type");
        set => this.WithProperty("metric_aggregation_type", value);
    }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    public TerraformProperty<double>? MinAdjustmentMagnitude
    {
        get => GetProperty<TerraformProperty<double>>("min_adjustment_magnitude");
        set => this.WithProperty("min_adjustment_magnitude", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    /// The scaling_adjustment attribute.
    /// </summary>
    public TerraformProperty<double>? ScalingAdjustment
    {
        get => GetProperty<TerraformProperty<double>>("scaling_adjustment");
        set => this.WithProperty("scaling_adjustment", value);
    }

    /// <summary>
    /// Block for predictive_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingConfiguration block(s) allowed")]
    public List<AwsAutoscalingPolicyPredictiveScalingConfigurationBlock>? PredictiveScalingConfiguration
    {
        get => GetProperty<List<AwsAutoscalingPolicyPredictiveScalingConfigurationBlock>>("predictive_scaling_configuration");
        set => this.WithProperty("predictive_scaling_configuration", value);
    }

    /// <summary>
    /// Block for step_adjustment.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAutoscalingPolicyStepAdjustmentBlock>? StepAdjustment
    {
        get => GetProperty<HashSet<AwsAutoscalingPolicyStepAdjustmentBlock>>("step_adjustment");
        set => this.WithProperty("step_adjustment", value);
    }

    /// <summary>
    /// Block for target_tracking_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingConfiguration block(s) allowed")]
    public List<AwsAutoscalingPolicyTargetTrackingConfigurationBlock>? TargetTrackingConfiguration
    {
        get => GetProperty<List<AwsAutoscalingPolicyTargetTrackingConfigurationBlock>>("target_tracking_configuration");
        set => this.WithProperty("target_tracking_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
