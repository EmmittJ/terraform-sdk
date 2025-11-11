using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_backup_selection.
/// </summary>
public partial class AwsBackupSelectionDataSource : TerraformDataSource
{
    public AwsBackupSelectionDataSource(string name) : base("aws_backup_selection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlanId is required")]
    [TerraformProperty("plan_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PlanId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The selection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelectionId is required")]
    [TerraformProperty("selection_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SelectionId { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("iam_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IamRoleArn { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformProperty("resources")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Resources { get; }

}
