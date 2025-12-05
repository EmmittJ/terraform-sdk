using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for backup in AzurermBackupPolicyVm.
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
        get => GetRequiredArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The hour_duration attribute.
    /// </summary>
    public TerraformValue<double>? HourDuration
    {
        get => GetArgument<TerraformValue<double>>("hour_duration");
        set => SetArgument("hour_duration", value);
    }

    /// <summary>
    /// The hour_interval attribute.
    /// </summary>
    public TerraformValue<double>? HourInterval
    {
        get => GetArgument<TerraformValue<double>>("hour_interval");
        set => SetArgument("hour_interval", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformValue<string> Time
    {
        get => GetRequiredArgument<TerraformValue<string>>("time");
        set => SetArgument("time", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public TerraformSet<string>? Weekdays
    {
        get => GetArgument<TerraformSet<string>>("weekdays");
        set => SetArgument("weekdays", value);
    }

}


/// <summary>
/// Block type for instant_restore_resource_group in AzurermBackupPolicyVm.
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
        get => GetRequiredArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}


/// <summary>
/// Block type for retention_daily in AzurermBackupPolicyVm.
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
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

}


/// <summary>
/// Block type for retention_monthly in AzurermBackupPolicyVm.
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
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformSet<double>? Days
    {
        get => GetArgument<TerraformSet<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeLastDays
    {
        get => GetArgument<TerraformValue<bool>>("include_last_days");
        set => SetArgument("include_last_days", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public TerraformSet<string>? Weekdays
    {
        get => GetArgument<TerraformSet<string>>("weekdays");
        set => SetArgument("weekdays", value);
    }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    public TerraformSet<string>? Weeks
    {
        get => GetArgument<TerraformSet<string>>("weeks");
        set => SetArgument("weeks", value);
    }

}


/// <summary>
/// Block type for retention_weekly in AzurermBackupPolicyVm.
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
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weekdays is required")]
    public required TerraformSet<string> Weekdays
    {
        get => GetRequiredArgument<TerraformSet<string>>("weekdays");
        set => SetArgument("weekdays", value);
    }

}


/// <summary>
/// Block type for retention_yearly in AzurermBackupPolicyVm.
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
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformSet<double>? Days
    {
        get => GetArgument<TerraformSet<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeLastDays
    {
        get => GetArgument<TerraformValue<bool>>("include_last_days");
        set => SetArgument("include_last_days", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Months is required")]
    public required TerraformSet<string> Months
    {
        get => GetRequiredArgument<TerraformSet<string>>("months");
        set => SetArgument("months", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    public TerraformSet<string>? Weekdays
    {
        get => GetArgument<TerraformSet<string>>("weekdays");
        set => SetArgument("weekdays", value);
    }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    public TerraformSet<string>? Weeks
    {
        get => GetArgument<TerraformSet<string>>("weeks");
        set => SetArgument("weeks", value);
    }

}


/// <summary>
/// Block type for tiering_policy in AzurermBackupPolicyVm.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmTieringPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tiering_policy";

    /// <summary>
    /// ArchivedRestorePoint block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArchivedRestorePoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ArchivedRestorePoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArchivedRestorePoint block(s) allowed")]
    public required TerraformList<AzurermBackupPolicyVmTieringPolicyBlockArchivedRestorePointBlock> ArchivedRestorePoint
    {
        get => GetRequiredArgument<TerraformList<AzurermBackupPolicyVmTieringPolicyBlockArchivedRestorePointBlock>>("archived_restore_point");
        set => SetArgument("archived_restore_point", value);
    }

}

/// <summary>
/// Block type for archived_restore_point in AzurermBackupPolicyVmTieringPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmTieringPolicyBlockArchivedRestorePointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "archived_restore_point";

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<double>? Duration
    {
        get => GetArgument<TerraformValue<double>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The duration_type attribute.
    /// </summary>
    public TerraformValue<string>? DurationType
    {
        get => GetArgument<TerraformValue<string>>("duration_type");
        set => SetArgument("duration_type", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermBackupPolicyVm.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instant_restore_retention_days attribute.
    /// </summary>
    public TerraformValue<double> InstantRestoreRetentionDays
    {
        get => GetArgument<TerraformValue<double>>("instant_restore_retention_days") ?? CreateReference("instant_restore_retention_days");
        set => SetArgument("instant_restore_retention_days", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformValue<string>? PolicyType
    {
        get => GetArgument<TerraformValue<string>>("policy_type");
        set => SetArgument("policy_type", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformValue<string> RecoveryVaultName
    {
        get => GetRequiredArgument<TerraformValue<string>>("recovery_vault_name");
        set => SetArgument("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => GetArgument<TerraformValue<string>>("timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// Backup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Backup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public required TerraformList<AzurermBackupPolicyVmBackupBlock> Backup
    {
        get => GetRequiredArgument<TerraformList<AzurermBackupPolicyVmBackupBlock>>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// InstantRestoreResourceGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstantRestoreResourceGroup block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmInstantRestoreResourceGroupBlock>? InstantRestoreResourceGroup
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmInstantRestoreResourceGroupBlock>>("instant_restore_resource_group");
        set => SetArgument("instant_restore_resource_group", value);
    }

    /// <summary>
    /// RetentionDaily block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmRetentionDailyBlock>? RetentionDaily
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmRetentionDailyBlock>>("retention_daily");
        set => SetArgument("retention_daily", value);
    }

    /// <summary>
    /// RetentionMonthly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmRetentionMonthlyBlock>? RetentionMonthly
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmRetentionMonthlyBlock>>("retention_monthly");
        set => SetArgument("retention_monthly", value);
    }

    /// <summary>
    /// RetentionWeekly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmRetentionWeeklyBlock>? RetentionWeekly
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmRetentionWeeklyBlock>>("retention_weekly");
        set => SetArgument("retention_weekly", value);
    }

    /// <summary>
    /// RetentionYearly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmRetentionYearlyBlock>? RetentionYearly
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmRetentionYearlyBlock>>("retention_yearly");
        set => SetArgument("retention_yearly", value);
    }

    /// <summary>
    /// TieringPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmTieringPolicyBlock>? TieringPolicy
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmTieringPolicyBlock>>("tiering_policy");
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
