using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recovery_point_selection in .
/// Nesting mode: list
/// </summary>
public class AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock : TerraformBlock
{
    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    public required TerraformProperty<string> Algorithm
    {
        get => GetRequiredProperty<TerraformProperty<string>>("algorithm");
        set => WithProperty("algorithm", value);
    }

    /// <summary>
    /// The exclude_vaults attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludeVaults
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("exclude_vaults");
        set => WithProperty("exclude_vaults", value);
    }

    /// <summary>
    /// The include_vaults attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludeVaults is required")]
    public HashSet<TerraformProperty<string>>? IncludeVaults
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("include_vaults");
        set => WithProperty("include_vaults", value);
    }

    /// <summary>
    /// The recovery_point_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointTypes is required")]
    public HashSet<TerraformProperty<string>>? RecoveryPointTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("recovery_point_types");
        set => WithProperty("recovery_point_types", value);
    }

    /// <summary>
    /// The selection_window_days attribute.
    /// </summary>
    public TerraformProperty<double>? SelectionWindowDays
    {
        get => GetProperty<TerraformProperty<double>>("selection_window_days");
        set => WithProperty("selection_window_days", value);
    }

}

/// <summary>
/// Manages a aws_backup_restore_testing_plan resource.
/// </summary>
public class AwsBackupRestoreTestingPlan : TerraformResource
{
    public AwsBackupRestoreTestingPlan(string name) : base("aws_backup_restore_testing_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformProperty<string> ScheduleExpression
    {
        get => GetRequiredProperty<TerraformProperty<string>>("schedule_expression");
        set => this.WithProperty("schedule_expression", value);
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduleExpressionTimezone
    {
        get => GetProperty<TerraformProperty<string>>("schedule_expression_timezone");
        set => this.WithProperty("schedule_expression_timezone", value);
    }

    /// <summary>
    /// The start_window_hours attribute.
    /// </summary>
    public TerraformProperty<double>? StartWindowHours
    {
        get => GetProperty<TerraformProperty<double>>("start_window_hours");
        set => this.WithProperty("start_window_hours", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for recovery_point_selection.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock>? RecoveryPointSelection
    {
        get => GetProperty<List<AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock>>("recovery_point_selection");
        set => this.WithProperty("recovery_point_selection", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
