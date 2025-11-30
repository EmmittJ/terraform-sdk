using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for default_retention_rule in AzurermDataProtectionBackupPolicyKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleBlock : TerraformBlock
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
    public required TerraformList<AzurermDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleBlockLifeCycleAttributeBlock> LifeCycleAttribute
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleBlockLifeCycleAttributeBlock>>("life_cycle");
        set => SetArgument("life_cycle", value);
    }

}

/// <summary>
/// Block type for life_cycle in AzurermDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleBlockLifeCycleAttributeBlock : TerraformBlock
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
/// Block type for retention_rule in AzurermDataProtectionBackupPolicyKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlock : TerraformBlock
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
    public required TerraformList<AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlockCriteriaBlock> Criteria
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlockCriteriaBlock>>("criteria");
        set => SetArgument("criteria", value);
    }

    /// <summary>
    /// LifeCycleAttribute block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifeCycleAttribute is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LifeCycleAttribute block(s) required")]
    public required TerraformList<AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlockLifeCycleAttributeBlock> LifeCycleAttribute
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlockLifeCycleAttributeBlock>>("life_cycle");
        set => SetArgument("life_cycle", value);
    }

}

/// <summary>
/// Block type for criteria in AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlockCriteriaBlock : TerraformBlock
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
/// Block type for life_cycle in AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlockLifeCycleAttributeBlock : TerraformBlock
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
/// Block type for timeouts in AzurermDataProtectionBackupPolicyKubernetesCluster.
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupPolicyKubernetesClusterTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_data_protection_backup_policy_kubernetes_cluster Terraform resource.
/// Manages a azurerm_data_protection_backup_policy_kubernetes_cluster resource.
/// </summary>
public partial class AzurermDataProtectionBackupPolicyKubernetesCluster(string name) : TerraformResource("azurerm_data_protection_backup_policy_kubernetes_cluster", name)
{
    /// <summary>
    /// The backup_repeating_time_intervals attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRepeatingTimeIntervals is required")]
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultName is required")]
    public required TerraformValue<string> VaultName
    {
        get => new TerraformReference<string>(this, "vault_name");
        set => SetArgument("vault_name", value);
    }

    /// <summary>
    /// DefaultRetentionRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRetentionRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultRetentionRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRetentionRule block(s) allowed")]
    public required TerraformList<AzurermDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleBlock> DefaultRetentionRule
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyKubernetesClusterDefaultRetentionRuleBlock>>("default_retention_rule");
        set => SetArgument("default_retention_rule", value);
    }

    /// <summary>
    /// RetentionRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlock>? RetentionRule
    {
        get => GetArgument<TerraformList<AzurermDataProtectionBackupPolicyKubernetesClusterRetentionRuleBlock>>("retention_rule");
        set => SetArgument("retention_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataProtectionBackupPolicyKubernetesClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataProtectionBackupPolicyKubernetesClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
