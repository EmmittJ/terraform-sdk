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
        get => GetRequiredProperty<TerraformProperty<string>>("frequency");
        set => WithProperty("frequency", value);
    }

    /// <summary>
    /// The hour_duration attribute.
    /// </summary>
    public TerraformProperty<double>? HourDuration
    {
        get => GetProperty<TerraformProperty<double>>("hour_duration");
        set => WithProperty("hour_duration", value);
    }

    /// <summary>
    /// The hour_interval attribute.
    /// </summary>
    public TerraformProperty<double>? HourInterval
    {
        get => GetProperty<TerraformProperty<double>>("hour_interval");
        set => WithProperty("hour_interval", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformProperty<string> Time
    {
        get => GetRequiredProperty<TerraformProperty<string>>("time");
        set => WithProperty("time", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Weekdays
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("weekdays");
        set => WithProperty("weekdays", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("prefix");
        set => WithProperty("prefix", value);
    }

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    public TerraformProperty<string>? Suffix
    {
        get => GetProperty<TerraformProperty<string>>("suffix");
        set => WithProperty("suffix", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("count");
        set => WithProperty("count", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("count");
        set => WithProperty("count", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? Days
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("days");
        set => WithProperty("days", value);
    }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeLastDays
    {
        get => GetProperty<TerraformProperty<bool>>("include_last_days");
        set => WithProperty("include_last_days", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Weekdays
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("weekdays");
        set => WithProperty("weekdays", value);
    }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Weeks
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("weeks");
        set => WithProperty("weeks", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("count");
        set => WithProperty("count", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weekdays is required")]
    public HashSet<TerraformProperty<string>>? Weekdays
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("weekdays");
        set => WithProperty("weekdays", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("count");
        set => WithProperty("count", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? Days
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("days");
        set => WithProperty("days", value);
    }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeLastDays
    {
        get => GetProperty<TerraformProperty<bool>>("include_last_days");
        set => WithProperty("include_last_days", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Months is required")]
    public HashSet<TerraformProperty<string>>? Months
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("months");
        set => WithProperty("months", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Weekdays
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("weekdays");
        set => WithProperty("weekdays", value);
    }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Weeks
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("weeks");
        set => WithProperty("weeks", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instant_restore_retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? InstantRestoreRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("instant_restore_retention_days");
        set => this.WithProperty("instant_restore_retention_days", value);
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
    /// The policy_type attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyType
    {
        get => GetProperty<TerraformProperty<string>>("policy_type");
        set => this.WithProperty("policy_type", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformProperty<string> RecoveryVaultName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        get => GetProperty<TerraformProperty<string>>("timezone");
        set => this.WithProperty("timezone", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Backup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public List<AzurermBackupPolicyVmBackupBlock>? Backup
    {
        get => GetProperty<List<AzurermBackupPolicyVmBackupBlock>>("backup");
        set => this.WithProperty("backup", value);
    }

    /// <summary>
    /// Block for instant_restore_resource_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstantRestoreResourceGroup block(s) allowed")]
    public List<AzurermBackupPolicyVmInstantRestoreResourceGroupBlock>? InstantRestoreResourceGroup
    {
        get => GetProperty<List<AzurermBackupPolicyVmInstantRestoreResourceGroupBlock>>("instant_restore_resource_group");
        set => this.WithProperty("instant_restore_resource_group", value);
    }

    /// <summary>
    /// Block for retention_daily.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    public List<AzurermBackupPolicyVmRetentionDailyBlock>? RetentionDaily
    {
        get => GetProperty<List<AzurermBackupPolicyVmRetentionDailyBlock>>("retention_daily");
        set => this.WithProperty("retention_daily", value);
    }

    /// <summary>
    /// Block for retention_monthly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    public List<AzurermBackupPolicyVmRetentionMonthlyBlock>? RetentionMonthly
    {
        get => GetProperty<List<AzurermBackupPolicyVmRetentionMonthlyBlock>>("retention_monthly");
        set => this.WithProperty("retention_monthly", value);
    }

    /// <summary>
    /// Block for retention_weekly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    public List<AzurermBackupPolicyVmRetentionWeeklyBlock>? RetentionWeekly
    {
        get => GetProperty<List<AzurermBackupPolicyVmRetentionWeeklyBlock>>("retention_weekly");
        set => this.WithProperty("retention_weekly", value);
    }

    /// <summary>
    /// Block for retention_yearly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    public List<AzurermBackupPolicyVmRetentionYearlyBlock>? RetentionYearly
    {
        get => GetProperty<List<AzurermBackupPolicyVmRetentionYearlyBlock>>("retention_yearly");
        set => this.WithProperty("retention_yearly", value);
    }

    /// <summary>
    /// Block for tiering_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    public List<AzurermBackupPolicyVmTieringPolicyBlock>? TieringPolicy
    {
        get => GetProperty<List<AzurermBackupPolicyVmTieringPolicyBlock>>("tiering_policy");
        set => this.WithProperty("tiering_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBackupPolicyVmTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBackupPolicyVmTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
