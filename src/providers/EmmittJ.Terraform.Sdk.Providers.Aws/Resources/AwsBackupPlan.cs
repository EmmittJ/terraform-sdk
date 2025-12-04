using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_backup_setting in AwsBackupPlan.
/// Nesting mode: set
/// </summary>
public class AwsBackupPlanAdvancedBackupSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_backup_setting";

    /// <summary>
    /// The backup_options attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupOptions is required")]
    public required TerraformMap<string> BackupOptions
    {
        get => GetArgument<TerraformMap<string>>("backup_options");
        set => SetArgument("backup_options", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

}


/// <summary>
/// Block type for rule in AwsBackupPlan.
/// Nesting mode: set
/// </summary>
public class AwsBackupPlanRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The completion_window attribute.
    /// </summary>
    public TerraformValue<double>? CompletionWindow
    {
        get => GetArgument<TerraformValue<double>>("completion_window");
        set => SetArgument("completion_window", value);
    }

    /// <summary>
    /// The enable_continuous_backup attribute.
    /// </summary>
    public TerraformValue<bool>? EnableContinuousBackup
    {
        get => GetArgument<TerraformValue<bool>>("enable_continuous_backup");
        set => SetArgument("enable_continuous_backup", value);
    }

    /// <summary>
    /// The recovery_point_tags attribute.
    /// </summary>
    public TerraformMap<string>? RecoveryPointTags
    {
        get => GetArgument<TerraformMap<string>>("recovery_point_tags");
        set => SetArgument("recovery_point_tags", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformValue<string> RuleName
    {
        get => GetArgument<TerraformValue<string>>("rule_name");
        set => SetArgument("rule_name", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformValue<string>? Schedule
    {
        get => GetArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleExpressionTimezone
    {
        get => GetArgument<TerraformValue<string>>("schedule_expression_timezone");
        set => SetArgument("schedule_expression_timezone", value);
    }

    /// <summary>
    /// The start_window attribute.
    /// </summary>
    public TerraformValue<double>? StartWindow
    {
        get => GetArgument<TerraformValue<double>>("start_window");
        set => SetArgument("start_window", value);
    }

    /// <summary>
    /// The target_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVaultName is required")]
    public required TerraformValue<string> TargetVaultName
    {
        get => GetArgument<TerraformValue<string>>("target_vault_name");
        set => SetArgument("target_vault_name", value);
    }

    /// <summary>
    /// CopyAction block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBackupPlanRuleBlockCopyActionBlock>? CopyAction
    {
        get => GetArgument<TerraformSet<AwsBackupPlanRuleBlockCopyActionBlock>>("copy_action");
        set => SetArgument("copy_action", value);
    }

    /// <summary>
    /// LifecycleAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LifecycleAttribute block(s) allowed")]
    public TerraformList<AwsBackupPlanRuleBlockLifecycleAttributeBlock>? LifecycleAttribute
    {
        get => GetArgument<TerraformList<AwsBackupPlanRuleBlockLifecycleAttributeBlock>>("lifecycle");
        set => SetArgument("lifecycle", value);
    }

}

/// <summary>
/// Block type for copy_action in AwsBackupPlanRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsBackupPlanRuleBlockCopyActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "copy_action";

    /// <summary>
    /// The destination_vault_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationVaultArn is required")]
    public required TerraformValue<string> DestinationVaultArn
    {
        get => GetArgument<TerraformValue<string>>("destination_vault_arn");
        set => SetArgument("destination_vault_arn", value);
    }

    /// <summary>
    /// LifecycleAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LifecycleAttribute block(s) allowed")]
    public TerraformList<AwsBackupPlanRuleBlockCopyActionBlockLifecycleAttributeBlock>? LifecycleAttribute
    {
        get => GetArgument<TerraformList<AwsBackupPlanRuleBlockCopyActionBlockLifecycleAttributeBlock>>("lifecycle");
        set => SetArgument("lifecycle", value);
    }

}

/// <summary>
/// Block type for lifecycle in AwsBackupPlanRuleBlockCopyActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsBackupPlanRuleBlockCopyActionBlockLifecycleAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle";

    /// <summary>
    /// The cold_storage_after attribute.
    /// </summary>
    public TerraformValue<double>? ColdStorageAfter
    {
        get => GetArgument<TerraformValue<double>>("cold_storage_after");
        set => SetArgument("cold_storage_after", value);
    }

    /// <summary>
    /// The delete_after attribute.
    /// </summary>
    public TerraformValue<double>? DeleteAfter
    {
        get => GetArgument<TerraformValue<double>>("delete_after");
        set => SetArgument("delete_after", value);
    }

    /// <summary>
    /// The opt_in_to_archive_for_supported_resources attribute.
    /// </summary>
    public TerraformValue<bool>? OptInToArchiveForSupportedResources
    {
        get => GetArgument<TerraformValue<bool>>("opt_in_to_archive_for_supported_resources");
        set => SetArgument("opt_in_to_archive_for_supported_resources", value);
    }

}

/// <summary>
/// Block type for lifecycle in AwsBackupPlanRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsBackupPlanRuleBlockLifecycleAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle";

    /// <summary>
    /// The cold_storage_after attribute.
    /// </summary>
    public TerraformValue<double>? ColdStorageAfter
    {
        get => GetArgument<TerraformValue<double>>("cold_storage_after");
        set => SetArgument("cold_storage_after", value);
    }

    /// <summary>
    /// The delete_after attribute.
    /// </summary>
    public TerraformValue<double>? DeleteAfter
    {
        get => GetArgument<TerraformValue<double>>("delete_after");
        set => SetArgument("delete_after", value);
    }

    /// <summary>
    /// The opt_in_to_archive_for_supported_resources attribute.
    /// </summary>
    public TerraformValue<bool>? OptInToArchiveForSupportedResources
    {
        get => GetArgument<TerraformValue<bool>>("opt_in_to_archive_for_supported_resources");
        set => SetArgument("opt_in_to_archive_for_supported_resources", value);
    }

}


/// <summary>
/// Represents a aws_backup_plan Terraform resource.
/// Manages a aws_backup_plan resource.
/// </summary>
public partial class AwsBackupPlan(string name) : TerraformResource("aws_backup_plan", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// AdvancedBackupSetting block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBackupPlanAdvancedBackupSettingBlock>? AdvancedBackupSetting
    {
        get => GetArgument<TerraformSet<AwsBackupPlanAdvancedBackupSettingBlock>>("advanced_backup_setting");
        set => SetArgument("advanced_backup_setting", value);
    }

    /// <summary>
    /// Rule block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformSet<AwsBackupPlanRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformSet<AwsBackupPlanRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}
