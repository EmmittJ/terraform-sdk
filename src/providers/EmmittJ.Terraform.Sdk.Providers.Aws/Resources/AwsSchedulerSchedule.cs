using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for flexible_time_window in .
/// Nesting mode: list
/// </summary>
public partial class AwsSchedulerScheduleFlexibleTimeWindowBlock() : TerraformBlock("flexible_time_window")
{
    /// <summary>
    /// The maximum_window_in_minutes attribute.
    /// </summary>
    [TerraformProperty("maximum_window_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumWindowInMinutes { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public partial class AwsSchedulerScheduleTargetBlock() : TerraformBlock("target")
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The input attribute.
    /// </summary>
    [TerraformProperty("input")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Input { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Manages a aws_scheduler_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSchedulerSchedule : TerraformResource
{
    public AwsSchedulerSchedule(string name) : base("aws_scheduler_schedule", name)
    {
    }

    /// <summary>
    /// The action_after_completion attribute.
    /// </summary>
    [TerraformProperty("action_after_completion")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ActionAfterCompletion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [TerraformProperty("end_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndDate { get; set; }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [TerraformProperty("group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> GroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    [TerraformProperty("schedule_expression")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScheduleExpression { get; set; }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    [TerraformProperty("schedule_expression_timezone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScheduleExpressionTimezone { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformProperty("start_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartDate { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? State { get; set; }

    /// <summary>
    /// Block for flexible_time_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlexibleTimeWindow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FlexibleTimeWindow block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlexibleTimeWindow block(s) allowed")]
    [TerraformProperty("flexible_time_window")]
    public required TerraformList<AwsSchedulerScheduleFlexibleTimeWindowBlock> FlexibleTimeWindow { get; set; } = new();

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformProperty("target")]
    public required TerraformList<AwsSchedulerScheduleTargetBlock> Target { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
