using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_schedule resource.
/// </summary>
public class AwsAutoscalingSchedule : TerraformResource
{
    public AwsAutoscalingSchedule(string name) : base("aws_autoscaling_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The desired_capacity attribute.
    /// </summary>
    public double? DesiredCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("desired_capacity")?.Value;
        set => this.WithProperty("desired_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public string? EndTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_time")?.Value;
        set => this.WithProperty("end_time", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The max_size attribute.
    /// </summary>
    public double? MaxSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size")?.Value;
        set => this.WithProperty("max_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public double? MinSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_size")?.Value;
        set => this.WithProperty("min_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    public string? Recurrence
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recurrence")?.Value;
        set => this.WithProperty("recurrence", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The scheduled_action_name attribute.
    /// </summary>
    public string? ScheduledActionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scheduled_action_name")?.Value;
        set => this.WithProperty("scheduled_action_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public string? StartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_time")?.Value;
        set => this.WithProperty("start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public string? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone")?.Value;
        set => this.WithProperty("time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
