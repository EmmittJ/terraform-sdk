using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for retention_rule in AzurermDataProtectionBackupPolicyDisk.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyDiskRetentionRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_rule";

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => GetRequiredArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
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
    public required TerraformList<AzurermDataProtectionBackupPolicyDiskRetentionRuleBlockCriteriaBlock> Criteria
    {
        get => GetRequiredArgument<TerraformList<AzurermDataProtectionBackupPolicyDiskRetentionRuleBlockCriteriaBlock>>("criteria");
        set => SetArgument("criteria", value);
    }

}

/// <summary>
/// Block type for criteria in AzurermDataProtectionBackupPolicyDiskRetentionRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyDiskRetentionRuleBlockCriteriaBlock : TerraformBlock
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

}


/// <summary>
/// Block type for timeouts in AzurermDataProtectionBackupPolicyDisk.
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupPolicyDiskTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_data_protection_backup_policy_disk Terraform resource.
/// Manages a azurerm_data_protection_backup_policy_disk resource.
/// </summary>
public partial class AzurermDataProtectionBackupPolicyDisk(string name) : TerraformResource("azurerm_data_protection_backup_policy_disk", name)
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
    /// The default_retention_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRetentionDuration is required")]
    public required TerraformValue<string> DefaultRetentionDuration
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_retention_duration");
        set => SetArgument("default_retention_duration", value);
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
    /// RetentionRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataProtectionBackupPolicyDiskRetentionRuleBlock>? RetentionRule
    {
        get => GetArgument<TerraformList<AzurermDataProtectionBackupPolicyDiskRetentionRuleBlock>>("retention_rule");
        set => SetArgument("retention_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataProtectionBackupPolicyDiskTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataProtectionBackupPolicyDiskTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
