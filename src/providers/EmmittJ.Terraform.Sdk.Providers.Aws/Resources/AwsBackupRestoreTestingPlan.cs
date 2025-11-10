using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recovery_point_selection in .
/// Nesting mode: list
/// </summary>
public class AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock : ITerraformBlock
{
    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    [TerraformPropertyName("algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Algorithm { get; set; }

    /// <summary>
    /// The exclude_vaults attribute.
    /// </summary>
    [TerraformPropertyName("exclude_vaults")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ExcludeVaults { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "exclude_vaults");

    /// <summary>
    /// The include_vaults attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludeVaults is required")]
    [TerraformPropertyName("include_vaults")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IncludeVaults { get; set; }

    /// <summary>
    /// The recovery_point_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointTypes is required")]
    [TerraformPropertyName("recovery_point_types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? RecoveryPointTypes { get; set; }

    /// <summary>
    /// The selection_window_days attribute.
    /// </summary>
    [TerraformPropertyName("selection_window_days")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> SelectionWindowDays { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "selection_window_days");

}

/// <summary>
/// Manages a aws_backup_restore_testing_plan resource.
/// </summary>
public class AwsBackupRestoreTestingPlan : TerraformResource
{
    public AwsBackupRestoreTestingPlan(string name) : base("aws_backup_restore_testing_plan", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    [TerraformPropertyName("schedule_expression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScheduleExpression { get; set; }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    [TerraformPropertyName("schedule_expression_timezone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScheduleExpressionTimezone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "schedule_expression_timezone");

    /// <summary>
    /// The start_window_hours attribute.
    /// </summary>
    [TerraformPropertyName("start_window_hours")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> StartWindowHours { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "start_window_hours");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for recovery_point_selection.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("recovery_point_selection")]
    public TerraformList<TerraformBlock<AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock>>? RecoveryPointSelection { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
