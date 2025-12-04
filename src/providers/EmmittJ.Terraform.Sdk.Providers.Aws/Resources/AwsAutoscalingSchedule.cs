using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_autoscaling_schedule Terraform resource.
/// Manages a aws_autoscaling_schedule resource.
/// </summary>
public partial class AwsAutoscalingSchedule(string name) : TerraformResource("aws_autoscaling_schedule", name)
{
    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    public required TerraformValue<string> AutoscalingGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("autoscaling_group_name");
        set => SetArgument("autoscaling_group_name", value);
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformValue<double> DesiredCapacity
    {
        get => GetArgument<TerraformValue<double>>("desired_capacity") ?? AsReference("desired_capacity");
        set => SetArgument("desired_capacity", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string> EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time") ?? AsReference("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformValue<double> MaxSize
    {
        get => GetArgument<TerraformValue<double>>("max_size") ?? AsReference("max_size");
        set => SetArgument("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformValue<double> MinSize
    {
        get => GetArgument<TerraformValue<double>>("min_size") ?? AsReference("min_size");
        set => SetArgument("min_size", value);
    }

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    public TerraformValue<string> Recurrence
    {
        get => GetArgument<TerraformValue<string>>("recurrence") ?? AsReference("recurrence");
        set => SetArgument("recurrence", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The scheduled_action_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduledActionName is required")]
    public required TerraformValue<string> ScheduledActionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("scheduled_action_name");
        set => SetArgument("scheduled_action_name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time") ?? AsReference("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string> TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone") ?? AsReference("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
