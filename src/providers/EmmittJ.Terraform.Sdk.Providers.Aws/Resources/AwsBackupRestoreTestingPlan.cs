using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recovery_point_selection in AwsBackupRestoreTestingPlan.
/// Nesting mode: list
/// </summary>
public class AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recovery_point_selection";

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    public required TerraformValue<string> Algorithm
    {
        get => GetArgument<TerraformValue<string>>("algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The exclude_vaults attribute.
    /// </summary>
    public TerraformSet<string>? ExcludeVaults
    {
        get => GetArgument<TerraformSet<string>>("exclude_vaults");
        set => SetArgument("exclude_vaults", value);
    }

    /// <summary>
    /// The include_vaults attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludeVaults is required")]
    public required TerraformSet<string> IncludeVaults
    {
        get => GetArgument<TerraformSet<string>>("include_vaults");
        set => SetArgument("include_vaults", value);
    }

    /// <summary>
    /// The recovery_point_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointTypes is required")]
    public required TerraformSet<string> RecoveryPointTypes
    {
        get => GetArgument<TerraformSet<string>>("recovery_point_types");
        set => SetArgument("recovery_point_types", value);
    }

    /// <summary>
    /// The selection_window_days attribute.
    /// </summary>
    public TerraformValue<double>? SelectionWindowDays
    {
        get => GetArgument<TerraformValue<double>>("selection_window_days");
        set => SetArgument("selection_window_days", value);
    }

}


/// <summary>
/// Represents a aws_backup_restore_testing_plan Terraform resource.
/// Manages a aws_backup_restore_testing_plan resource.
/// </summary>
public partial class AwsBackupRestoreTestingPlan(string name) : TerraformResource("aws_backup_restore_testing_plan", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformValue<string> ScheduleExpression
    {
        get => GetArgument<TerraformValue<string>>("schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleExpressionTimezone
    {
        get => GetArgument<TerraformValue<string>>("schedule_expression_timezone");
        set => SetArgument("schedule_expression_timezone", value);
    }

    /// <summary>
    /// The start_window_hours attribute.
    /// </summary>
    public TerraformValue<double>? StartWindowHours
    {
        get => GetArgument<TerraformValue<double>>("start_window_hours");
        set => SetArgument("start_window_hours", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// RecoveryPointSelection block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock>? RecoveryPointSelection
    {
        get => GetArgument<TerraformList<AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock>>("recovery_point_selection");
        set => SetArgument("recovery_point_selection", value);
    }

}
