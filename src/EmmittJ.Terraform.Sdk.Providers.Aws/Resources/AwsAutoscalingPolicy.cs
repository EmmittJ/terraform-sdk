using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_policy resource.
/// </summary>
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
    public TerraformLiteralProperty<string>? AdjustmentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("adjustment_type");
        set => this.WithProperty("adjustment_type", value);
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutoscalingGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autoscaling_group_name");
        set => this.WithProperty("autoscaling_group_name", value);
    }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Cooldown
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cooldown");
        set => this.WithProperty("cooldown", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? EstimatedInstanceWarmup
    {
        get => GetProperty<TerraformLiteralProperty<double>>("estimated_instance_warmup");
        set => this.WithProperty("estimated_instance_warmup", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MetricAggregationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metric_aggregation_type");
        set => this.WithProperty("metric_aggregation_type", value);
    }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinAdjustmentMagnitude
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_adjustment_magnitude");
        set => this.WithProperty("min_adjustment_magnitude", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_type");
        set => this.WithProperty("policy_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ScalingAdjustment
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scaling_adjustment");
        set => this.WithProperty("scaling_adjustment", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
