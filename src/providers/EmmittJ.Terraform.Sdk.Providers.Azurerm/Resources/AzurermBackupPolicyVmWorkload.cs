using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for protection_policy in AzurermBackupPolicyVmWorkload.
/// Nesting mode: set
/// </summary>
public class AzurermBackupPolicyVmWorkloadProtectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protection_policy";

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyType is required")]
    public required TerraformValue<string> PolicyType
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_type");
        set => SetArgument("policy_type", value);
    }

    /// <summary>
    /// Backup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Backup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public required TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockBackupBlock> Backup
    {
        get => GetRequiredArgument<TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockBackupBlock>>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// RetentionDaily block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionDailyBlock>? RetentionDaily
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionDailyBlock>>("retention_daily");
        set => SetArgument("retention_daily", value);
    }

    /// <summary>
    /// RetentionMonthly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionMonthlyBlock>? RetentionMonthly
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionMonthlyBlock>>("retention_monthly");
        set => SetArgument("retention_monthly", value);
    }

    /// <summary>
    /// RetentionWeekly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionWeeklyBlock>? RetentionWeekly
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionWeeklyBlock>>("retention_weekly");
        set => SetArgument("retention_weekly", value);
    }

    /// <summary>
    /// RetentionYearly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionYearlyBlock>? RetentionYearly
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionYearlyBlock>>("retention_yearly");
        set => SetArgument("retention_yearly", value);
    }

    /// <summary>
    /// SimpleRetention block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SimpleRetention block(s) allowed")]
    public TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockSimpleRetentionBlock>? SimpleRetention
    {
        get => GetArgument<TerraformList<AzurermBackupPolicyVmWorkloadProtectionPolicyBlockSimpleRetentionBlock>>("simple_retention");
        set => SetArgument("simple_retention", value);
    }

}

/// <summary>
/// Block type for backup in AzurermBackupPolicyVmWorkloadProtectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmWorkloadProtectionPolicyBlockBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup";

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<string>? Frequency
    {
        get => GetArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The frequency_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? FrequencyInMinutes
    {
        get => GetArgument<TerraformValue<double>>("frequency_in_minutes");
        set => SetArgument("frequency_in_minutes", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    public TerraformValue<string>? Time
    {
        get => GetArgument<TerraformValue<string>>("time");
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
/// Block type for retention_daily in AzurermBackupPolicyVmWorkloadProtectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionDailyBlock : TerraformBlock
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
/// Block type for retention_monthly in AzurermBackupPolicyVmWorkloadProtectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionMonthlyBlock : TerraformBlock
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
    /// The format_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FormatType is required")]
    public required TerraformValue<string> FormatType
    {
        get => GetRequiredArgument<TerraformValue<string>>("format_type");
        set => SetArgument("format_type", value);
    }

    /// <summary>
    /// The monthdays attribute.
    /// </summary>
    public TerraformSet<double>? Monthdays
    {
        get => GetArgument<TerraformSet<double>>("monthdays");
        set => SetArgument("monthdays", value);
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
/// Block type for retention_weekly in AzurermBackupPolicyVmWorkloadProtectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionWeeklyBlock : TerraformBlock
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
/// Block type for retention_yearly in AzurermBackupPolicyVmWorkloadProtectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmWorkloadProtectionPolicyBlockRetentionYearlyBlock : TerraformBlock
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
    /// The format_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FormatType is required")]
    public required TerraformValue<string> FormatType
    {
        get => GetRequiredArgument<TerraformValue<string>>("format_type");
        set => SetArgument("format_type", value);
    }

    /// <summary>
    /// The monthdays attribute.
    /// </summary>
    public TerraformSet<double>? Monthdays
    {
        get => GetArgument<TerraformSet<double>>("monthdays");
        set => SetArgument("monthdays", value);
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
/// Block type for simple_retention in AzurermBackupPolicyVmWorkloadProtectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmWorkloadProtectionPolicyBlockSimpleRetentionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "simple_retention";

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
/// Block type for settings in AzurermBackupPolicyVmWorkload.
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmWorkloadSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "settings";

    /// <summary>
    /// The compression_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CompressionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("compression_enabled");
        set => SetArgument("compression_enabled", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermBackupPolicyVmWorkload.
/// Nesting mode: single
/// </summary>
public class AzurermBackupPolicyVmWorkloadTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_backup_policy_vm_workload Terraform resource.
/// Manages a azurerm_backup_policy_vm_workload resource.
/// </summary>
public partial class AzurermBackupPolicyVmWorkload(string name) : TerraformResource("azurerm_backup_policy_vm_workload", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The workload_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadType is required")]
    public required TerraformValue<string> WorkloadType
    {
        get => GetRequiredArgument<TerraformValue<string>>("workload_type");
        set => SetArgument("workload_type", value);
    }

    /// <summary>
    /// ProtectionPolicy block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectionPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProtectionPolicy block(s) required")]
    public required TerraformSet<AzurermBackupPolicyVmWorkloadProtectionPolicyBlock> ProtectionPolicy
    {
        get => GetRequiredArgument<TerraformSet<AzurermBackupPolicyVmWorkloadProtectionPolicyBlock>>("protection_policy");
        set => SetArgument("protection_policy", value);
    }

    /// <summary>
    /// Settings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Settings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Settings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public required TerraformList<AzurermBackupPolicyVmWorkloadSettingsBlock> Settings
    {
        get => GetRequiredArgument<TerraformList<AzurermBackupPolicyVmWorkloadSettingsBlock>>("settings");
        set => SetArgument("settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBackupPolicyVmWorkloadTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBackupPolicyVmWorkloadTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
