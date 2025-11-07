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
    public TerraformProperty<string>? AutoscalingGroupName
    {
        get => GetProperty<TerraformProperty<string>>("autoscaling_group_name");
        set => this.WithProperty("autoscaling_group_name", value);
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredCapacity
    {
        get => GetProperty<TerraformProperty<double>>("desired_capacity");
        set => this.WithProperty("desired_capacity", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformProperty<string>? EndTime
    {
        get => GetProperty<TerraformProperty<string>>("end_time");
        set => this.WithProperty("end_time", value);
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
    /// The max_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSize
    {
        get => GetProperty<TerraformProperty<double>>("max_size");
        set => this.WithProperty("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformProperty<double>? MinSize
    {
        get => GetProperty<TerraformProperty<double>>("min_size");
        set => this.WithProperty("min_size", value);
    }

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    public TerraformProperty<string>? Recurrence
    {
        get => GetProperty<TerraformProperty<string>>("recurrence");
        set => this.WithProperty("recurrence", value);
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
    /// The scheduled_action_name attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduledActionName
    {
        get => GetProperty<TerraformProperty<string>>("scheduled_action_name");
        set => this.WithProperty("scheduled_action_name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
