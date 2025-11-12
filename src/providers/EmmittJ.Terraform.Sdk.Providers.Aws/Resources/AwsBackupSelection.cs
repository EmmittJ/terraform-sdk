using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for condition in .
/// Nesting mode: set
/// </summary>
public partial class AwsBackupSelectionConditionBlock() : TerraformBlock("condition")
{
}

/// <summary>
/// Block type for selection_tag in .
/// Nesting mode: set
/// </summary>
public partial class AwsBackupSelectionSelectionTagBlock() : TerraformBlock("selection_tag")
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a aws_backup_selection resource.
/// </summary>
public partial class AwsBackupSelection : TerraformResource
{
    public AwsBackupSelection(string name) : base("aws_backup_selection", name)
    {
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    [TerraformProperty("iam_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The not_resources attribute.
    /// </summary>
    [TerraformProperty("not_resources")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> NotResources { get; set; }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlanId is required")]
    [TerraformProperty("plan_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PlanId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformProperty("resources")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Resources { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("condition")]
    public TerraformSet<AwsBackupSelectionConditionBlock> Condition { get; set; } = new();

    /// <summary>
    /// Block for selection_tag.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("selection_tag")]
    public TerraformSet<AwsBackupSelectionSelectionTagBlock> SelectionTag { get; set; } = new();

}
