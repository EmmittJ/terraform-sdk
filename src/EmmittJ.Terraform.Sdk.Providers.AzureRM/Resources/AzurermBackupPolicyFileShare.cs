using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareBackupBlock : TerraformBlock
{
    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        get => GetProperty<TerraformProperty<string>>("frequency");
        set => WithProperty("frequency", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    public TerraformProperty<string>? Time
    {
        get => GetProperty<TerraformProperty<string>>("time");
        set => WithProperty("time", value);
    }

}

/// <summary>
/// Block type for retention_daily in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionDailyBlock : TerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        get => GetProperty<TerraformProperty<double>>("count");
        set => WithProperty("count", value);
    }

}

/// <summary>
/// Block type for retention_monthly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionMonthlyBlock : TerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        get => GetProperty<TerraformProperty<double>>("count");
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
public class AzurermBackupPolicyFileShareRetentionWeeklyBlock : TerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        get => GetProperty<TerraformProperty<double>>("count");
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
public class AzurermBackupPolicyFileShareRetentionYearlyBlock : TerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        get => GetProperty<TerraformProperty<double>>("count");
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBackupPolicyFileShareTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_backup_policy_file_share resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBackupPolicyFileShare : TerraformResource
{
    public AzurermBackupPolicyFileShare(string name) : base("azurerm_backup_policy_file_share", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformProperty<string> RecoveryVaultName
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
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
    public List<AzurermBackupPolicyFileShareBackupBlock>? Backup
    {
        get => GetProperty<List<AzurermBackupPolicyFileShareBackupBlock>>("backup");
        set => this.WithProperty("backup", value);
    }

    /// <summary>
    /// Block for retention_daily.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionDaily block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    public List<AzurermBackupPolicyFileShareRetentionDailyBlock>? RetentionDaily
    {
        get => GetProperty<List<AzurermBackupPolicyFileShareRetentionDailyBlock>>("retention_daily");
        set => this.WithProperty("retention_daily", value);
    }

    /// <summary>
    /// Block for retention_monthly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    public List<AzurermBackupPolicyFileShareRetentionMonthlyBlock>? RetentionMonthly
    {
        get => GetProperty<List<AzurermBackupPolicyFileShareRetentionMonthlyBlock>>("retention_monthly");
        set => this.WithProperty("retention_monthly", value);
    }

    /// <summary>
    /// Block for retention_weekly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    public List<AzurermBackupPolicyFileShareRetentionWeeklyBlock>? RetentionWeekly
    {
        get => GetProperty<List<AzurermBackupPolicyFileShareRetentionWeeklyBlock>>("retention_weekly");
        set => this.WithProperty("retention_weekly", value);
    }

    /// <summary>
    /// Block for retention_yearly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    public List<AzurermBackupPolicyFileShareRetentionYearlyBlock>? RetentionYearly
    {
        get => GetProperty<List<AzurermBackupPolicyFileShareRetentionYearlyBlock>>("retention_yearly");
        set => this.WithProperty("retention_yearly", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBackupPolicyFileShareTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBackupPolicyFileShareTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
