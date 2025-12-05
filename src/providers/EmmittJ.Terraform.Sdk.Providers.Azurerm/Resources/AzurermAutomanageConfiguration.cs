using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for antimalware in AzurermAutomanageConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationAntimalwareBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "antimalware";

    /// <summary>
    /// The real_time_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RealTimeProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("real_time_protection_enabled");
        set => SetArgument("real_time_protection_enabled", value);
    }

    /// <summary>
    /// The scheduled_scan_day attribute.
    /// </summary>
    public TerraformValue<double>? ScheduledScanDay
    {
        get => GetArgument<TerraformValue<double>>("scheduled_scan_day");
        set => SetArgument("scheduled_scan_day", value);
    }

    /// <summary>
    /// The scheduled_scan_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ScheduledScanEnabled
    {
        get => GetArgument<TerraformValue<bool>>("scheduled_scan_enabled");
        set => SetArgument("scheduled_scan_enabled", value);
    }

    /// <summary>
    /// The scheduled_scan_time_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? ScheduledScanTimeInMinutes
    {
        get => GetArgument<TerraformValue<double>>("scheduled_scan_time_in_minutes");
        set => SetArgument("scheduled_scan_time_in_minutes", value);
    }

    /// <summary>
    /// The scheduled_scan_type attribute.
    /// </summary>
    public TerraformValue<string>? ScheduledScanType
    {
        get => GetArgument<TerraformValue<string>>("scheduled_scan_type");
        set => SetArgument("scheduled_scan_type", value);
    }

    /// <summary>
    /// Exclusions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Exclusions block(s) allowed")]
    public TerraformList<AzurermAutomanageConfigurationAntimalwareBlockExclusionsBlock>? Exclusions
    {
        get => GetArgument<TerraformList<AzurermAutomanageConfigurationAntimalwareBlockExclusionsBlock>>("exclusions");
        set => SetArgument("exclusions", value);
    }

}

/// <summary>
/// Block type for exclusions in AzurermAutomanageConfigurationAntimalwareBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationAntimalwareBlockExclusionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusions";

    /// <summary>
    /// The extensions attribute.
    /// </summary>
    public TerraformValue<string>? Extensions
    {
        get => GetArgument<TerraformValue<string>>("extensions");
        set => SetArgument("extensions", value);
    }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    public TerraformValue<string>? Paths
    {
        get => GetArgument<TerraformValue<string>>("paths");
        set => SetArgument("paths", value);
    }

    /// <summary>
    /// The processes attribute.
    /// </summary>
    public TerraformValue<string>? Processes
    {
        get => GetArgument<TerraformValue<string>>("processes");
        set => SetArgument("processes", value);
    }

}


/// <summary>
/// Block type for azure_security_baseline in AzurermAutomanageConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationAzureSecurityBaselineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_security_baseline";

    /// <summary>
    /// The assignment_type attribute.
    /// </summary>
    public TerraformValue<string>? AssignmentType
    {
        get => GetArgument<TerraformValue<string>>("assignment_type");
        set => SetArgument("assignment_type", value);
    }

}


/// <summary>
/// Block type for backup in AzurermAutomanageConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup";

    /// <summary>
    /// The instant_rp_retention_range_in_days attribute.
    /// </summary>
    public TerraformValue<double>? InstantRpRetentionRangeInDays
    {
        get => GetArgument<TerraformValue<double>>("instant_rp_retention_range_in_days");
        set => SetArgument("instant_rp_retention_range_in_days", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public TerraformValue<string>? PolicyName
    {
        get => GetArgument<TerraformValue<string>>("policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// RetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public TerraformList<AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetArgument<TerraformList<AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlock>>("retention_policy");
        set => SetArgument("retention_policy", value);
    }

    /// <summary>
    /// SchedulePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchedulePolicy block(s) allowed")]
    public TerraformList<AzurermAutomanageConfigurationBackupBlockSchedulePolicyBlock>? SchedulePolicy
    {
        get => GetArgument<TerraformList<AzurermAutomanageConfigurationBackupBlockSchedulePolicyBlock>>("schedule_policy");
        set => SetArgument("schedule_policy", value);
    }

}

/// <summary>
/// Block type for retention_policy in AzurermAutomanageConfigurationBackupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_policy";

    /// <summary>
    /// The retention_policy_type attribute.
    /// </summary>
    public TerraformValue<string>? RetentionPolicyType
    {
        get => GetArgument<TerraformValue<string>>("retention_policy_type");
        set => SetArgument("retention_policy_type", value);
    }

    /// <summary>
    /// DailySchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailySchedule block(s) allowed")]
    public TerraformList<AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockDailyScheduleBlock>? DailySchedule
    {
        get => GetArgument<TerraformList<AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockDailyScheduleBlock>>("daily_schedule");
        set => SetArgument("daily_schedule", value);
    }

    /// <summary>
    /// WeeklySchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklySchedule block(s) allowed")]
    public TerraformList<AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockWeeklyScheduleBlock>? WeeklySchedule
    {
        get => GetArgument<TerraformList<AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockWeeklyScheduleBlock>>("weekly_schedule");
        set => SetArgument("weekly_schedule", value);
    }

}

/// <summary>
/// Block type for daily_schedule in AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockDailyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "daily_schedule";

    /// <summary>
    /// The retention_times attribute.
    /// </summary>
    public TerraformList<string>? RetentionTimes
    {
        get => GetArgument<TerraformList<string>>("retention_times");
        set => SetArgument("retention_times", value);
    }

    /// <summary>
    /// RetentionDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDuration block(s) allowed")]
    public TerraformList<AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockDailyScheduleBlockRetentionDurationBlock>? RetentionDuration
    {
        get => GetArgument<TerraformList<AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockDailyScheduleBlockRetentionDurationBlock>>("retention_duration");
        set => SetArgument("retention_duration", value);
    }

}

/// <summary>
/// Block type for retention_duration in AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockDailyScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockDailyScheduleBlockRetentionDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_duration";

    /// <summary>
    /// The count attribute.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The duration_type attribute.
    /// </summary>
    public TerraformValue<string>? DurationType
    {
        get => GetArgument<TerraformValue<string>>("duration_type");
        set => SetArgument("duration_type", value);
    }

}

/// <summary>
/// Block type for weekly_schedule in AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockWeeklyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_schedule";

    /// <summary>
    /// The retention_times attribute.
    /// </summary>
    public TerraformList<string>? RetentionTimes
    {
        get => GetArgument<TerraformList<string>>("retention_times");
        set => SetArgument("retention_times", value);
    }

    /// <summary>
    /// RetentionDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDuration block(s) allowed")]
    public TerraformList<AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockWeeklyScheduleBlockRetentionDurationBlock>? RetentionDuration
    {
        get => GetArgument<TerraformList<AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockWeeklyScheduleBlockRetentionDurationBlock>>("retention_duration");
        set => SetArgument("retention_duration", value);
    }

}

/// <summary>
/// Block type for retention_duration in AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockWeeklyScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationBackupBlockRetentionPolicyBlockWeeklyScheduleBlockRetentionDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_duration";

    /// <summary>
    /// The count attribute.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The duration_type attribute.
    /// </summary>
    public TerraformValue<string>? DurationType
    {
        get => GetArgument<TerraformValue<string>>("duration_type");
        set => SetArgument("duration_type", value);
    }

}

/// <summary>
/// Block type for schedule_policy in AzurermAutomanageConfigurationBackupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationBackupBlockSchedulePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_policy";

    /// <summary>
    /// The schedule_policy_type attribute.
    /// </summary>
    public TerraformValue<string>? SchedulePolicyType
    {
        get => GetArgument<TerraformValue<string>>("schedule_policy_type");
        set => SetArgument("schedule_policy_type", value);
    }

    /// <summary>
    /// The schedule_run_days attribute.
    /// </summary>
    public TerraformList<string>? ScheduleRunDays
    {
        get => GetArgument<TerraformList<string>>("schedule_run_days");
        set => SetArgument("schedule_run_days", value);
    }

    /// <summary>
    /// The schedule_run_frequency attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleRunFrequency
    {
        get => GetArgument<TerraformValue<string>>("schedule_run_frequency");
        set => SetArgument("schedule_run_frequency", value);
    }

    /// <summary>
    /// The schedule_run_times attribute.
    /// </summary>
    public TerraformList<string>? ScheduleRunTimes
    {
        get => GetArgument<TerraformList<string>>("schedule_run_times");
        set => SetArgument("schedule_run_times", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAutomanageConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermAutomanageConfigurationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_automanage_configuration Terraform resource.
/// Manages a azurerm_automanage_configuration resource.
/// </summary>
public partial class AzurermAutomanageConfiguration(string name) : TerraformResource("azurerm_automanage_configuration", name)
{
    /// <summary>
    /// The automation_account_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomationAccountEnabled
    {
        get => GetArgument<TerraformValue<bool>>("automation_account_enabled");
        set => SetArgument("automation_account_enabled", value);
    }

    /// <summary>
    /// The boot_diagnostics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BootDiagnosticsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("boot_diagnostics_enabled");
        set => SetArgument("boot_diagnostics_enabled", value);
    }

    /// <summary>
    /// The defender_for_cloud_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DefenderForCloudEnabled
    {
        get => GetArgument<TerraformValue<bool>>("defender_for_cloud_enabled");
        set => SetArgument("defender_for_cloud_enabled", value);
    }

    /// <summary>
    /// The guest_configuration_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GuestConfigurationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("guest_configuration_enabled");
        set => SetArgument("guest_configuration_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The log_analytics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LogAnalyticsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("log_analytics_enabled");
        set => SetArgument("log_analytics_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The status_change_alert_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StatusChangeAlertEnabled
    {
        get => GetArgument<TerraformValue<bool>>("status_change_alert_enabled");
        set => SetArgument("status_change_alert_enabled", value);
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
    /// Antimalware block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Antimalware block(s) allowed")]
    public TerraformList<AzurermAutomanageConfigurationAntimalwareBlock>? Antimalware
    {
        get => GetArgument<TerraformList<AzurermAutomanageConfigurationAntimalwareBlock>>("antimalware");
        set => SetArgument("antimalware", value);
    }

    /// <summary>
    /// AzureSecurityBaseline block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureSecurityBaseline block(s) allowed")]
    public TerraformList<AzurermAutomanageConfigurationAzureSecurityBaselineBlock>? AzureSecurityBaseline
    {
        get => GetArgument<TerraformList<AzurermAutomanageConfigurationAzureSecurityBaselineBlock>>("azure_security_baseline");
        set => SetArgument("azure_security_baseline", value);
    }

    /// <summary>
    /// Backup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public TerraformList<AzurermAutomanageConfigurationBackupBlock>? Backup
    {
        get => GetArgument<TerraformList<AzurermAutomanageConfigurationBackupBlock>>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomanageConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomanageConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
