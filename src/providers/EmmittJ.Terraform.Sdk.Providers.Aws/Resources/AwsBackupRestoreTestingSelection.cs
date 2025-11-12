using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for protected_resource_conditions in .
/// Nesting mode: list
/// </summary>
public partial class AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock() : TerraformBlock("protected_resource_conditions")
{
}

/// <summary>
/// Manages a aws_backup_restore_testing_selection resource.
/// </summary>
public partial class AwsBackupRestoreTestingSelection : TerraformResource
{
    public AwsBackupRestoreTestingSelection(string name) : base("aws_backup_restore_testing_selection", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protected_resource_arns attribute.
    /// </summary>
    [TerraformProperty("protected_resource_arns")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> ProtectedResourceArns { get; set; }

    /// <summary>
    /// The protected_resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedResourceType is required")]
    [TerraformProperty("protected_resource_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProtectedResourceType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The restore_metadata_overrides attribute.
    /// </summary>
    [TerraformProperty("restore_metadata_overrides")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> RestoreMetadataOverrides { get; set; }

    /// <summary>
    /// The restore_testing_plan_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreTestingPlanName is required")]
    [TerraformProperty("restore_testing_plan_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RestoreTestingPlanName { get; set; }

    /// <summary>
    /// The validation_window_hours attribute.
    /// </summary>
    [TerraformProperty("validation_window_hours")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ValidationWindowHours { get; set; }

    /// <summary>
    /// Block for protected_resource_conditions.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("protected_resource_conditions")]
    public TerraformList<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock> ProtectedResourceConditions { get; set; } = new();

}
