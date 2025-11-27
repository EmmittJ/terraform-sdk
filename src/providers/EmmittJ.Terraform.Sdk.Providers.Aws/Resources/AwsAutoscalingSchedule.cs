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
        get => new TerraformReference<string>(this, "autoscaling_group_name");
        set => SetArgument("autoscaling_group_name", value);
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformValue<double> DesiredCapacity
    {
        get => new TerraformReference<double>(this, "desired_capacity");
        set => SetArgument("desired_capacity", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string> EndTime
    {
        get => new TerraformReference<string>(this, "end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformValue<double> MaxSize
    {
        get => new TerraformReference<double>(this, "max_size");
        set => SetArgument("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformValue<double> MinSize
    {
        get => new TerraformReference<double>(this, "min_size");
        set => SetArgument("min_size", value);
    }

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    public TerraformValue<string> Recurrence
    {
        get => new TerraformReference<string>(this, "recurrence");
        set => SetArgument("recurrence", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The scheduled_action_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduledActionName is required")]
    public required TerraformValue<string> ScheduledActionName
    {
        get => new TerraformReference<string>(this, "scheduled_action_name");
        set => SetArgument("scheduled_action_name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
