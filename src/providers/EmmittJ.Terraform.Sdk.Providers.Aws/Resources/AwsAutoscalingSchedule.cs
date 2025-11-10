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
        SetOutput("arn");
        SetOutput("autoscaling_group_name");
        SetOutput("desired_capacity");
        SetOutput("end_time");
        SetOutput("id");
        SetOutput("max_size");
        SetOutput("min_size");
        SetOutput("recurrence");
        SetOutput("region");
        SetOutput("scheduled_action_name");
        SetOutput("start_time");
        SetOutput("time_zone");
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
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformProperty<double> DesiredCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("desired_capacity");
        set => SetProperty("desired_capacity", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformProperty<string> EndTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_time");
        set => SetProperty("end_time", value);
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
    /// The max_size attribute.
    /// </summary>
    public TerraformProperty<double> MaxSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_size");
        set => SetProperty("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformProperty<double> MinSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_size");
        set => SetProperty("min_size", value);
    }

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    public TerraformProperty<string> Recurrence
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recurrence");
        set => SetProperty("recurrence", value);
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
    /// The scheduled_action_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduledActionName is required")]
    public required TerraformProperty<string> ScheduledActionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scheduled_action_name");
        set => SetProperty("scheduled_action_name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string> StartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_time");
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string> TimeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_zone");
        set => SetProperty("time_zone", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
