using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_maintenance_window resource.
/// </summary>
public partial class AwsSsmMaintenanceWindow : TerraformResource
{
    public AwsSsmMaintenanceWindow(string name) : base("aws_ssm_maintenance_window", name)
    {
    }

    /// <summary>
    /// The allow_unassociated_targets attribute.
    /// </summary>
    [TerraformProperty("allow_unassociated_targets")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowUnassociatedTargets { get; set; }

    /// <summary>
    /// The cutoff attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cutoff is required")]
    [TerraformProperty("cutoff")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Cutoff { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformProperty("duration")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Duration { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [TerraformProperty("end_date")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EndDate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [TerraformProperty("schedule")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Schedule { get; set; }

    /// <summary>
    /// The schedule_offset attribute.
    /// </summary>
    [TerraformProperty("schedule_offset")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ScheduleOffset { get; set; }

    /// <summary>
    /// The schedule_timezone attribute.
    /// </summary>
    [TerraformProperty("schedule_timezone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScheduleTimezone { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformProperty("start_date")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StartDate { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

}
