using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recovery_point_selection in .
/// Nesting mode: list
/// </summary>
public partial class AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock : TerraformBlockBase
{
    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    [TerraformProperty("algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Algorithm { get; set; }

    /// <summary>
    /// The exclude_vaults attribute.
    /// </summary>
    [TerraformProperty("exclude_vaults")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> ExcludeVaults { get; set; }

    /// <summary>
    /// The include_vaults attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludeVaults is required")]
    [TerraformProperty("include_vaults")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> IncludeVaults { get; set; }

    /// <summary>
    /// The recovery_point_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointTypes is required")]
    [TerraformProperty("recovery_point_types")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> RecoveryPointTypes { get; set; }

    /// <summary>
    /// The selection_window_days attribute.
    /// </summary>
    [TerraformProperty("selection_window_days")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SelectionWindowDays { get; set; }

}

/// <summary>
/// Manages a aws_backup_restore_testing_plan resource.
/// </summary>
public partial class AwsBackupRestoreTestingPlan : TerraformResource
{
    public AwsBackupRestoreTestingPlan(string name) : base("aws_backup_restore_testing_plan", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScheduleExpressionTimezone { get; set; }

    /// <summary>
    /// The start_window_hours attribute.
    /// </summary>
    [TerraformProperty("start_window_hours")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> StartWindowHours { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for recovery_point_selection.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("recovery_point_selection")]
    public partial TerraformList<TerraformBlock<AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock>>? RecoveryPointSelection { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
