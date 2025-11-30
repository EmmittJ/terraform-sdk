using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for retention_rule in AzurermDataProtectionBackupPolicyBlobStorage.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// Criteria block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criteria block(s) allowed")]
    public required TerraformList<AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlockCriteriaBlock> Criteria
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlockCriteriaBlock>>("criteria");
        set => SetArgument("criteria", value);
    }

    /// <summary>
    /// LifeCycleAttribute block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifeCycleAttribute is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LifeCycleAttribute block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LifeCycleAttribute block(s) allowed")]
    public required TerraformList<AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlockLifeCycleAttributeBlock> LifeCycleAttribute
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlockLifeCycleAttributeBlock>>("life_cycle");
        set => SetArgument("life_cycle", value);
    }

}

/// <summary>
/// Block type for criteria in AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlockCriteriaBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "absolute_criteria");
        set => SetArgument("absolute_criteria", value);
    }

    /// <summary>
    /// The days_of_month attribute.
    /// </summary>
    public TerraformSet<double>? DaysOfMonth
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "days_of_month").ResolveNodes(ctx));
        set => SetArgument("days_of_month", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public TerraformSet<string>? DaysOfWeek
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "days_of_week").ResolveNodes(ctx));
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The months_of_year attribute.
    /// </summary>
    public TerraformSet<string>? MonthsOfYear
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "months_of_year").ResolveNodes(ctx));
        set => SetArgument("months_of_year", value);
    }

    /// <summary>
    /// The scheduled_backup_times attribute.
    /// </summary>
    public TerraformSet<string>? ScheduledBackupTimes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scheduled_backup_times").ResolveNodes(ctx));
        set => SetArgument("scheduled_backup_times", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public TerraformSet<string>? WeeksOfMonth
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weeks_of_month").ResolveNodes(ctx));
        set => SetArgument("weeks_of_month", value);
    }

}

/// <summary>
/// Block type for life_cycle in AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlockLifeCycleAttributeBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "data_store_type");
        set => SetArgument("data_store_type", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataProtectionBackupPolicyBlobStorage.
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupPolicyBlobStorageTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_data_protection_backup_policy_blob_storage Terraform resource.
/// Manages a azurerm_data_protection_backup_policy_blob_storage resource.
/// </summary>
public partial class AzurermDataProtectionBackupPolicyBlobStorage(string name) : TerraformResource("azurerm_data_protection_backup_policy_blob_storage", name)
{
    /// <summary>
    /// The backup_repeating_time_intervals attribute.
    /// </summary>
    public TerraformList<string>? BackupRepeatingTimeIntervals
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "backup_repeating_time_intervals").ResolveNodes(ctx));
        set => SetArgument("backup_repeating_time_intervals", value);
    }

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
    /// The operational_default_retention_duration attribute.
    /// </summary>
    public TerraformValue<string>? OperationalDefaultRetentionDuration
    {
        get => new TerraformReference<string>(this, "operational_default_retention_duration");
        set => SetArgument("operational_default_retention_duration", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The vault_default_retention_duration attribute.
    /// </summary>
    public TerraformValue<string>? VaultDefaultRetentionDuration
    {
        get => new TerraformReference<string>(this, "vault_default_retention_duration");
        set => SetArgument("vault_default_retention_duration", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformValue<string> VaultId
    {
        get => new TerraformReference<string>(this, "vault_id");
        set => SetArgument("vault_id", value);
    }

    /// <summary>
    /// RetentionRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock>? RetentionRule
    {
        get => GetArgument<TerraformList<AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock>>("retention_rule");
        set => SetArgument("retention_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataProtectionBackupPolicyBlobStorageTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataProtectionBackupPolicyBlobStorageTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
