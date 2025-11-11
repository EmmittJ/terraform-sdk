using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_schedule resource.
/// </summary>
public partial class AwsAutoscalingSchedule : TerraformResource
{
    public AwsAutoscalingSchedule(string name) : base("aws_autoscaling_schedule", name)
    {
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    [TerraformProperty("autoscaling_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutoscalingGroupName { get; set; }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [TerraformProperty("desired_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DesiredCapacity { get; set; }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformProperty("end_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndTime { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [TerraformProperty("max_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxSize { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformProperty("min_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MinSize { get; set; }

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    [TerraformProperty("recurrence")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Recurrence { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The scheduled_action_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduledActionName is required")]
    [TerraformProperty("scheduled_action_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScheduledActionName { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartTime { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TimeZone { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
