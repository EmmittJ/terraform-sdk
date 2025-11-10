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
        set => SetProperty("algorithm", value);
    }

    /// <summary>
    /// The exclude_vaults attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludeVaults
    {
        set => SetProperty("exclude_vaults", value);
    }

    /// <summary>
    /// The include_vaults attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludeVaults is required")]
    public HashSet<TerraformProperty<string>>? IncludeVaults
    {
        set => SetProperty("include_vaults", value);
    }

    /// <summary>
    /// The recovery_point_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointTypes is required")]
    public HashSet<TerraformProperty<string>>? RecoveryPointTypes
    {
        set => SetProperty("recovery_point_types", value);
    }

    /// <summary>
    /// The selection_window_days attribute.
    /// </summary>
    public TerraformProperty<double>? SelectionWindowDays
    {
        set => SetProperty("selection_window_days", value);
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
        SetOutput("arn");
        SetOutput("tags_all");
        SetOutput("name");
        SetOutput("region");
        SetOutput("schedule_expression");
        SetOutput("schedule_expression_timezone");
        SetOutput("start_window_hours");
        SetOutput("tags");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformProperty<string> ScheduleExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule_expression");
        set => SetProperty("schedule_expression", value);
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public TerraformProperty<string> ScheduleExpressionTimezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule_expression_timezone");
        set => SetProperty("schedule_expression_timezone", value);
    }

    /// <summary>
    /// The start_window_hours attribute.
    /// </summary>
    public TerraformProperty<double> StartWindowHours
    {
        get => GetRequiredOutput<TerraformProperty<double>>("start_window_hours");
        set => SetProperty("start_window_hours", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for recovery_point_selection.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBackupRestoreTestingPlanRecoveryPointSelectionBlock>? RecoveryPointSelection
    {
        set => SetProperty("recovery_point_selection", value);
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
