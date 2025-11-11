using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for protected_resource_conditions in .
/// Nesting mode: list
/// </summary>
public class AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock
{
}

/// <summary>
/// Manages a aws_backup_restore_testing_selection resource.
/// </summary>
public class AwsBackupRestoreTestingSelection : TerraformResource
{
    public AwsBackupRestoreTestingSelection(string name) : base("aws_backup_restore_testing_selection", name)
    {
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    [TerraformPropertyName("iam_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IamRoleArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protected_resource_arns attribute.
    /// </summary>
    [TerraformPropertyName("protected_resource_arns")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> ProtectedResourceArns { get; set; } = default!;

    /// <summary>
    /// The protected_resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedResourceType is required")]
    [TerraformPropertyName("protected_resource_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProtectedResourceType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The restore_metadata_overrides attribute.
    /// </summary>
    [TerraformPropertyName("restore_metadata_overrides")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> RestoreMetadataOverrides { get; set; } = default!;

    /// <summary>
    /// The restore_testing_plan_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreTestingPlanName is required")]
    [TerraformPropertyName("restore_testing_plan_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RestoreTestingPlanName { get; set; }

    /// <summary>
    /// The validation_window_hours attribute.
    /// </summary>
    [TerraformPropertyName("validation_window_hours")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ValidationWindowHours { get; set; } = default!;

    /// <summary>
    /// Block for protected_resource_conditions.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("protected_resource_conditions")]
    public TerraformList<TerraformBlock<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock>>? ProtectedResourceConditions { get; set; }

}
