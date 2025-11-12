using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for stage in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmcontactsPlanStageBlock() : TerraformBlock("stage")
{
    /// <summary>
    /// The duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DurationInMinutes is required")]
    [TerraformProperty("duration_in_minutes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DurationInMinutes { get; set; }

}

/// <summary>
/// Manages a aws_ssmcontacts_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSsmcontactsPlan : TerraformResource
{
    public AwsSsmcontactsPlan(string name) : base("aws_ssmcontacts_plan", name)
    {
    }

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactId is required")]
    [TerraformProperty("contact_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContactId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for stage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Stage block(s) required")]
    [TerraformProperty("stage")]
    public required TerraformList<AwsSsmcontactsPlanStageBlock> Stage { get; set; } = new();

}
