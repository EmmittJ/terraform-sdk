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
    public TerraformLiteralProperty<string>? AutoscalingGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autoscaling_group_name");
        set => this.WithProperty("autoscaling_group_name", value);
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DesiredCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("desired_capacity");
        set => this.WithProperty("desired_capacity", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_time");
        set => this.WithProperty("end_time", value);
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
    /// The max_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size");
        set => this.WithProperty("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_size");
        set => this.WithProperty("min_size", value);
    }

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Recurrence
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recurrence");
        set => this.WithProperty("recurrence", value);
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
    /// The scheduled_action_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScheduledActionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scheduled_action_name");
        set => this.WithProperty("scheduled_action_name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
