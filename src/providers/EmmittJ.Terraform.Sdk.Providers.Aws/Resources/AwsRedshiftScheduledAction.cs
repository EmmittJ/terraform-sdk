using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_action in .
/// Nesting mode: list
/// </summary>
public partial class AwsRedshiftScheduledActionTargetActionBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_redshift_scheduled_action resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsRedshiftScheduledAction : TerraformResource
{
    public AwsRedshiftScheduledAction(string name) : base("aws_redshift_scheduled_action", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [TerraformProperty("enable")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enable { get; set; }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformProperty("end_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EndTime { get; set; }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRole is required")]
    [TerraformProperty("iam_role")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IamRole { get; set; }

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
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// Block for target_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetAction block(s) allowed")]
    [TerraformProperty("target_action")]
    public TerraformList<TerraformBlock<AwsRedshiftScheduledActionTargetActionBlock>>? TargetAction { get; set; }

}
