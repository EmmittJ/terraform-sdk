using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmBackupBlock : TerraformBlock
{
    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        set => SetProperty("frequency", value);
    }

    /// <summary>
    /// The hour_duration attribute.
    /// </summary>
    public TerraformProperty<double>? HourDuration
    {
        set => SetProperty("hour_duration", value);
    }

    /// <summary>
    /// The hour_interval attribute.
    /// </summary>
    public TerraformProperty<double>? HourInterval
    {
        set => SetProperty("hour_interval", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformProperty<string> Time
    {
        set => SetProperty("time", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Weekdays
    {
        set => SetProperty("weekdays", value);
    }

}

/// <summary>
/// Block type for instant_restore_resource_group in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmInstantRestoreResourceGroupBlock : TerraformBlock
{
    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformProperty<string> Prefix
    {
        set => SetProperty("prefix", value);
    }

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    public TerraformProperty<string>? Suffix
    {
        set => SetProperty("suffix", value);
    }

}

/// <summary>
/// Block type for retention_daily in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmRetentionDailyBlock : TerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        set => SetProperty("count", value);
    }

}

/// <summary>
/// Block type for retention_monthly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmRetentionMonthlyBlock : TerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        set => SetProperty("count", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? Days
    {
        set => SetProperty("days", value);
    }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeLastDays
    {
        set => SetProperty("include_last_days", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Weekdays
    {
        set => SetProperty("weekdays", value);
    }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Weeks
    {
        set => SetProperty("weeks", value);
    }

}

/// <summary>
/// Block type for retention_weekly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmRetentionWeeklyBlock : TerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        set => SetProperty("count", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weekdays is required")]
    public HashSet<TerraformProperty<string>>? Weekdays
    {
        set => SetProperty("weekdays", value);
    }

}

/// <summary>
/// Block type for retention_yearly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmRetentionYearlyBlock : TerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        set => SetProperty("count", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? Days
    {
        set => SetProperty("days", value);
    }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeLastDays
    {
        set => SetProperty("include_last_days", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Months is required")]
    public HashSet<TerraformProperty<string>>? Months
    {
        set => SetProperty("months", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Weekdays
    {
        set => SetProperty("weekdays", value);
    }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Weeks
    {
        set => SetProperty("weeks", value);
    }

}

/// <summary>
/// Block type for tiering_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmTieringPolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBackupPolicyVmTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_backup_policy_vm resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBackupPolicyVm : TerraformResource
{
    public AzurermBackupPolicyVm(string name) : base("azurerm_backup_policy_vm", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("instant_restore_retention_days");
        SetOutput("name");
        SetOutput("policy_type");
        SetOutput("recovery_vault_name");
        SetOutput("resource_group_name");
        SetOutput("timezone");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instant_restore_retention_days attribute.
    /// </summary>
    public TerraformProperty<double> InstantRestoreRetentionDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("instant_restore_retention_days");
        set => SetProperty("instant_restore_retention_days", value);
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
    /// The policy_type attribute.
    /// </summary>
    public TerraformProperty<string> PolicyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_type");
        set => SetProperty("policy_type", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformProperty<string> RecoveryVaultName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_vault_name");
        set => SetProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string> Timezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timezone");
        set => SetProperty("timezone", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Backup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public List<AzurermBackupPolicyVmBackupBlock>? Backup
    {
        set => SetProperty("backup", value);
    }

    /// <summary>
    /// Block for instant_restore_resource_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstantRestoreResourceGroup block(s) allowed")]
    public List<AzurermBackupPolicyVmInstantRestoreResourceGroupBlock>? InstantRestoreResourceGroup
    {
        set => SetProperty("instant_restore_resource_group", value);
    }

    /// <summary>
    /// Block for retention_daily.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    public List<AzurermBackupPolicyVmRetentionDailyBlock>? RetentionDaily
    {
        set => SetProperty("retention_daily", value);
    }

    /// <summary>
    /// Block for retention_monthly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    public List<AzurermBackupPolicyVmRetentionMonthlyBlock>? RetentionMonthly
    {
        set => SetProperty("retention_monthly", value);
    }

    /// <summary>
    /// Block for retention_weekly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    public List<AzurermBackupPolicyVmRetentionWeeklyBlock>? RetentionWeekly
    {
        set => SetProperty("retention_weekly", value);
    }

    /// <summary>
    /// Block for retention_yearly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    public List<AzurermBackupPolicyVmRetentionYearlyBlock>? RetentionYearly
    {
        set => SetProperty("retention_yearly", value);
    }

    /// <summary>
    /// Block for tiering_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    public List<AzurermBackupPolicyVmTieringPolicyBlock>? TieringPolicy
    {
        set => SetProperty("tiering_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBackupPolicyVmTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
