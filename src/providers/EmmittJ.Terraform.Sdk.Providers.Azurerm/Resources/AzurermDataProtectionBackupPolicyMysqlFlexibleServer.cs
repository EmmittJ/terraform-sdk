using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for default_retention_rule in AzurermDataProtectionBackupPolicyMysqlFlexibleServer.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_retention_rule";

    /// <summary>
    /// LifeCycleAttribute block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifeCycleAttribute is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LifeCycleAttribute block(s) required")]
    public required TerraformList<AzurermDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleBlockLifeCycleAttributeBlock> LifeCycleAttribute
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleBlockLifeCycleAttributeBlock>>("life_cycle");
        set => SetArgument("life_cycle", value);
    }

}

/// <summary>
/// Block type for life_cycle in AzurermDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleBlockLifeCycleAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "life_cycle";

    /// <summary>
    /// The data_store_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreType is required")]
    public required TerraformValue<string> DataStoreType
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_store_type");
        set => SetArgument("data_store_type", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => GetRequiredArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

}


/// <summary>
/// Block type for retention_rule in AzurermDataProtectionBackupPolicyMysqlFlexibleServer.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_rule";

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
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// Criteria block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criteria block(s) allowed")]
    public required TerraformList<AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlockCriteriaBlock> Criteria
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlockCriteriaBlock>>("criteria");
        set => SetArgument("criteria", value);
    }

    /// <summary>
    /// LifeCycleAttribute block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifeCycleAttribute is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LifeCycleAttribute block(s) required")]
    public required TerraformList<AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlockLifeCycleAttributeBlock> LifeCycleAttribute
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlockLifeCycleAttributeBlock>>("life_cycle");
        set => SetArgument("life_cycle", value);
    }

}

/// <summary>
/// Block type for criteria in AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlockCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criteria";

    /// <summary>
    /// The absolute_criteria attribute.
    /// </summary>
    public TerraformValue<string>? AbsoluteCriteria
    {
        get => GetArgument<TerraformValue<string>>("absolute_criteria");
        set => SetArgument("absolute_criteria", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public TerraformSet<string>? DaysOfWeek
    {
        get => GetArgument<TerraformSet<string>>("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The months_of_year attribute.
    /// </summary>
    public TerraformSet<string>? MonthsOfYear
    {
        get => GetArgument<TerraformSet<string>>("months_of_year");
        set => SetArgument("months_of_year", value);
    }

    /// <summary>
    /// The scheduled_backup_times attribute.
    /// </summary>
    public TerraformSet<string>? ScheduledBackupTimes
    {
        get => GetArgument<TerraformSet<string>>("scheduled_backup_times");
        set => SetArgument("scheduled_backup_times", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public TerraformSet<string>? WeeksOfMonth
    {
        get => GetArgument<TerraformSet<string>>("weeks_of_month");
        set => SetArgument("weeks_of_month", value);
    }

}

/// <summary>
/// Block type for life_cycle in AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlockLifeCycleAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "life_cycle";

    /// <summary>
    /// The data_store_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreType is required")]
    public required TerraformValue<string> DataStoreType
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_store_type");
        set => SetArgument("data_store_type", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => GetRequiredArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataProtectionBackupPolicyMysqlFlexibleServer.
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupPolicyMysqlFlexibleServerTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_data_protection_backup_policy_mysql_flexible_server Terraform resource.
/// Manages a azurerm_data_protection_backup_policy_mysql_flexible_server resource.
/// </summary>
public partial class AzurermDataProtectionBackupPolicyMysqlFlexibleServer(string name) : TerraformResource("azurerm_data_protection_backup_policy_mysql_flexible_server", name)
{
    /// <summary>
    /// The backup_repeating_time_intervals attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRepeatingTimeIntervals is required")]
    public TerraformList<string>? BackupRepeatingTimeIntervals
    {
        get => GetArgument<TerraformList<string>>("backup_repeating_time_intervals");
        set => SetArgument("backup_repeating_time_intervals", value);
    }

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
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformValue<string> VaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vault_id");
        set => SetArgument("vault_id", value);
    }

    /// <summary>
    /// DefaultRetentionRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRetentionRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultRetentionRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRetentionRule block(s) allowed")]
    public required TerraformList<AzurermDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleBlock> DefaultRetentionRule
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleBlock>>("default_retention_rule");
        set => SetArgument("default_retention_rule", value);
    }

    /// <summary>
    /// RetentionRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlock>? RetentionRule
    {
        get => GetArgument<TerraformList<AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlock>>("retention_rule");
        set => SetArgument("retention_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataProtectionBackupPolicyMysqlFlexibleServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataProtectionBackupPolicyMysqlFlexibleServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
