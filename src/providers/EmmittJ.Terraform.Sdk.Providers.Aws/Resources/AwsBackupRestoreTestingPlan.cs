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
        get => new TerraformReference<string>(this, "algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The exclude_vaults attribute.
    /// </summary>
    public TerraformSet<string> ExcludeVaults
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "exclude_vaults").ResolveNodes(ctx));
        set => SetArgument("exclude_vaults", value);
    }

    /// <summary>
    /// The include_vaults attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludeVaults is required")]
    public required TerraformSet<string> IncludeVaults
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "include_vaults").ResolveNodes(ctx));
        set => SetArgument("include_vaults", value);
    }

    /// <summary>
    /// The recovery_point_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointTypes is required")]
    public required TerraformSet<string> RecoveryPointTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "recovery_point_types").ResolveNodes(ctx));
        set => SetArgument("recovery_point_types", value);
    }

    /// <summary>
    /// The selection_window_days attribute.
    /// </summary>
    public TerraformValue<double> SelectionWindowDays
    {
        get => new TerraformReference<double>(this, "selection_window_days");
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformValue<string> ScheduleExpression
    {
        get => new TerraformReference<string>(this, "schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public TerraformValue<string> ScheduleExpressionTimezone
    {
        get => new TerraformReference<string>(this, "schedule_expression_timezone");
        set => SetArgument("schedule_expression_timezone", value);
    }

    /// <summary>
    /// The start_window_hours attribute.
    /// </summary>
    public TerraformValue<double> StartWindowHours
    {
        get => new TerraformReference<double>(this, "start_window_hours");
        set => SetArgument("start_window_hours", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// RecoveryPointSelection block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock>? RecoveryPointSelection
    {
        get => GetArgument<TerraformList<AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock>>("recovery_point_selection");
        set => SetArgument("recovery_point_selection", value);
    }

}
