using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_maintenance_window resource.
/// </summary>
public class AwsSsmMaintenanceWindow : TerraformResource
{
    public AwsSsmMaintenanceWindow(string name) : base("aws_ssm_maintenance_window", name)
    {
    }

    /// <summary>
    /// The allow_unassociated_targets attribute.
    /// </summary>
    [TerraformPropertyName("allow_unassociated_targets")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowUnassociatedTargets { get; set; }

    /// <summary>
    /// The cutoff attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cutoff is required")]
    [TerraformPropertyName("cutoff")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Cutoff { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformPropertyName("duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Duration { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [TerraformPropertyName("end_date")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EndDate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [TerraformPropertyName("schedule")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Schedule { get; set; }

    /// <summary>
    /// The schedule_offset attribute.
    /// </summary>
    [TerraformPropertyName("schedule_offset")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ScheduleOffset { get; set; }

    /// <summary>
    /// The schedule_timezone attribute.
    /// </summary>
    [TerraformPropertyName("schedule_timezone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScheduleTimezone { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StartDate { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

}
