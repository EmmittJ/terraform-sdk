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
    public string? AdjustmentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("adjustment_type")?.Value;
        set => this.WithProperty("adjustment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    public string? AutoscalingGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autoscaling_group_name")?.Value;
        set => this.WithProperty("autoscaling_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    public double? Cooldown
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cooldown")?.Value;
        set => this.WithProperty("cooldown", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    public double? EstimatedInstanceWarmup
    {
        get => GetProperty<TerraformLiteralProperty<double>>("estimated_instance_warmup")?.Value;
        set => this.WithProperty("estimated_instance_warmup", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    public string? MetricAggregationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metric_aggregation_type")?.Value;
        set => this.WithProperty("metric_aggregation_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    public double? MinAdjustmentMagnitude
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_adjustment_magnitude")?.Value;
        set => this.WithProperty("min_adjustment_magnitude", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public string? PolicyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_type")?.Value;
        set => this.WithProperty("policy_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    public double? ScalingAdjustment
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scaling_adjustment")?.Value;
        set => this.WithProperty("scaling_adjustment", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
