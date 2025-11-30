using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for backup in AzurermBackupPolicyFileShare.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup";

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    public TerraformValue<string>? Time
    {
        get => new TerraformReference<string>(this, "time");
        set => SetArgument("time", value);
    }

    /// <summary>
    /// Hourly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hourly block(s) allowed")]
    public TerraformList<AzurermBackupPolicyFileShareBackupBlockHourlyBlock>? Hourly
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyFileShareBackupBlockHourlyBlock>>("hourly");
        set => SetArgument("hourly", value);
    }

}

/// <summary>
/// Block type for hourly in AzurermBackupPolicyFileShareBackupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareBackupBlockHourlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hourly";

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The window_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowDuration is required")]
    public required TerraformValue<double> WindowDuration
    {
        get => new TerraformReference<double>(this, "window_duration");
        set => SetArgument("window_duration", value);
    }

}


/// <summary>
/// Block type for retention_daily in AzurermBackupPolicyFileShare.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionDailyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_daily";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

}


/// <summary>
/// Block type for retention_monthly in AzurermBackupPolicyFileShare.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionMonthlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_monthly";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformSet<double>? Days
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "days").ResolveNodes(ctx));
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeLastDays
    {
        get => new TerraformReference<bool>(this, "include_last_days");
        set => SetArgument("include_last_days", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public TerraformSet<string>? Weekdays
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weekdays").ResolveNodes(ctx));
        set => SetArgument("weekdays", value);
    }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    public TerraformSet<string>? Weeks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weeks").ResolveNodes(ctx));
        set => SetArgument("weeks", value);
    }

}


/// <summary>
/// Block type for retention_weekly in AzurermBackupPolicyFileShare.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionWeeklyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_weekly";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weekdays is required")]
    public required TerraformSet<string> Weekdays
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weekdays").ResolveNodes(ctx));
        set => SetArgument("weekdays", value);
    }

}


/// <summary>
/// Block type for retention_yearly in AzurermBackupPolicyFileShare.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionYearlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_yearly";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformSet<double>? Days
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "days").ResolveNodes(ctx));
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeLastDays
    {
        get => new TerraformReference<bool>(this, "include_last_days");
        set => SetArgument("include_last_days", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Months is required")]
    public required TerraformSet<string> Months
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "months").ResolveNodes(ctx));
        set => SetArgument("months", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public TerraformSet<string>? Weekdays
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weekdays").ResolveNodes(ctx));
        set => SetArgument("weekdays", value);
    }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    public TerraformSet<string>? Weeks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weeks").ResolveNodes(ctx));
        set => SetArgument("weeks", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermBackupPolicyFileShare.
/// Nesting mode: single
/// </summary>
public class AzurermBackupPolicyFileShareTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_backup_policy_file_share Terraform resource.
/// Manages a azurerm_backup_policy_file_share resource.
/// </summary>
public partial class AzurermBackupPolicyFileShare(string name) : TerraformResource("azurerm_backup_policy_file_share", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

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
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformValue<string> RecoveryVaultName
    {
        get => new TerraformReference<string>(this, "recovery_vault_name");
        set => SetArgument("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// Backup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Backup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public required TerraformList<AzurermBackupPolicyFileShareBackupBlock> Backup
    {
        get => GetRequiredArgument<TerraformList<AzurermBackupPolicyFileShareBackupBlock>>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// RetentionDaily block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDaily is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionDaily block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    public required TerraformList<AzurermBackupPolicyFileShareRetentionDailyBlock> RetentionDaily
    {
        get => GetRequiredArgument<TerraformList<AzurermBackupPolicyFileShareRetentionDailyBlock>>("retention_daily");
        set => SetArgument("retention_daily", value);
    }

    /// <summary>
    /// RetentionMonthly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    public TerraformList<AzurermBackupPolicyFileShareRetentionMonthlyBlock>? RetentionMonthly
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyFileShareRetentionMonthlyBlock>>("retention_monthly");
        set => SetArgument("retention_monthly", value);
    }

    /// <summary>
    /// RetentionWeekly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    public TerraformList<AzurermBackupPolicyFileShareRetentionWeeklyBlock>? RetentionWeekly
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyFileShareRetentionWeeklyBlock>>("retention_weekly");
        set => SetArgument("retention_weekly", value);
    }

    /// <summary>
    /// RetentionYearly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    public TerraformList<AzurermBackupPolicyFileShareRetentionYearlyBlock>? RetentionYearly
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyFileShareRetentionYearlyBlock>>("retention_yearly");
        set => SetArgument("retention_yearly", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBackupPolicyFileShareTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBackupPolicyFileShareTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
