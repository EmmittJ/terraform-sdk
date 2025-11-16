using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmBackupBlock : TerraformBlock
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
    /// The hour_duration attribute.
    /// </summary>
    public TerraformValue<double>? HourDuration
    {
        get => new TerraformReference<double>(this, "hour_duration");
        set => SetArgument("hour_duration", value);
    }

    /// <summary>
    /// The hour_interval attribute.
    /// </summary>
    public TerraformValue<double>? HourInterval
    {
        get => new TerraformReference<double>(this, "hour_interval");
        set => SetArgument("hour_interval", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformValue<string> Time
    {
        get => new TerraformReference<string>(this, "time");
        set => SetArgument("time", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public TerraformSet<string>? Weekdays
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weekdays").ResolveNodes(ctx));
        set => SetArgument("weekdays", value);
    }

}

/// <summary>
/// Block type for instant_restore_resource_group in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmInstantRestoreResourceGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instant_restore_resource_group";

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformValue<string> Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => new TerraformReference<string>(this, "suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for retention_daily in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmRetentionDailyBlock : TerraformBlock
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
/// Block type for retention_monthly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmRetentionMonthlyBlock : TerraformBlock
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
/// Block type for retention_weekly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmRetentionWeeklyBlock : TerraformBlock
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
/// Block type for retention_yearly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmRetentionYearlyBlock : TerraformBlock
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
/// Block type for tiering_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmTieringPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tiering_policy";

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBackupPolicyVmTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_backup_policy_vm Terraform resource.
/// Manages a azurerm_backup_policy_vm resource.
/// </summary>
public partial class AzurermBackupPolicyVm(string name) : TerraformResource("azurerm_backup_policy_vm", name)
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
    /// The instant_restore_retention_days attribute.
    /// </summary>
    public TerraformValue<double> InstantRestoreRetentionDays
    {
        get => new TerraformReference<double>(this, "instant_restore_retention_days");
        set => SetArgument("instant_restore_retention_days", value);
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
    /// The policy_type attribute.
    /// </summary>
    public TerraformValue<string>? PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
        set => SetArgument("policy_type", value);
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
    public required AzurermBackupPolicyVmBackupBlock Backup
    {
        get => GetRequiredArgument<AzurermBackupPolicyVmBackupBlock>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// InstantRestoreResourceGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstantRestoreResourceGroup block(s) allowed")]
    public AzurermBackupPolicyVmInstantRestoreResourceGroupBlock? InstantRestoreResourceGroup
    {
        get => GetArgument<AzurermBackupPolicyVmInstantRestoreResourceGroupBlock>("instant_restore_resource_group");
        set => SetArgument("instant_restore_resource_group", value);
    }

    /// <summary>
    /// RetentionDaily block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    public AzurermBackupPolicyVmRetentionDailyBlock? RetentionDaily
    {
        get => GetArgument<AzurermBackupPolicyVmRetentionDailyBlock>("retention_daily");
        set => SetArgument("retention_daily", value);
    }

    /// <summary>
    /// RetentionMonthly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    public AzurermBackupPolicyVmRetentionMonthlyBlock? RetentionMonthly
    {
        get => GetArgument<AzurermBackupPolicyVmRetentionMonthlyBlock>("retention_monthly");
        set => SetArgument("retention_monthly", value);
    }

    /// <summary>
    /// RetentionWeekly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    public AzurermBackupPolicyVmRetentionWeeklyBlock? RetentionWeekly
    {
        get => GetArgument<AzurermBackupPolicyVmRetentionWeeklyBlock>("retention_weekly");
        set => SetArgument("retention_weekly", value);
    }

    /// <summary>
    /// RetentionYearly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    public AzurermBackupPolicyVmRetentionYearlyBlock? RetentionYearly
    {
        get => GetArgument<AzurermBackupPolicyVmRetentionYearlyBlock>("retention_yearly");
        set => SetArgument("retention_yearly", value);
    }

    /// <summary>
    /// TieringPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    public AzurermBackupPolicyVmTieringPolicyBlock? TieringPolicy
    {
        get => GetArgument<AzurermBackupPolicyVmTieringPolicyBlock>("tiering_policy");
        set => SetArgument("tiering_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBackupPolicyVmTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBackupPolicyVmTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
