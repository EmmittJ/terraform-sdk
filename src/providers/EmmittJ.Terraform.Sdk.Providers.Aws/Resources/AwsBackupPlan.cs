using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_backup_setting in .
/// Nesting mode: set
/// </summary>
public partial class AwsBackupPlanAdvancedBackupSettingBlock : TerraformBlockBase
{
    /// <summary>
    /// The backup_options attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupOptions is required")]
    [TerraformProperty("backup_options")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> BackupOptions { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformProperty("resource_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceType { get; set; }

}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public partial class AwsBackupPlanRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The completion_window attribute.
    /// </summary>
    [TerraformProperty("completion_window")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? CompletionWindow { get; set; }

    /// <summary>
    /// The enable_continuous_backup attribute.
    /// </summary>
    [TerraformProperty("enable_continuous_backup")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableContinuousBackup { get; set; }

    /// <summary>
    /// The recovery_point_tags attribute.
    /// </summary>
    [TerraformProperty("recovery_point_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? RecoveryPointTags { get; set; }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    [TerraformProperty("rule_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuleName { get; set; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformProperty("schedule")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Schedule { get; set; }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    [TerraformProperty("schedule_expression_timezone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScheduleExpressionTimezone { get; set; }

    /// <summary>
    /// The start_window attribute.
    /// </summary>
    [TerraformProperty("start_window")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? StartWindow { get; set; }

    /// <summary>
    /// The target_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVaultName is required")]
    [TerraformProperty("target_vault_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetVaultName { get; set; }

}

/// <summary>
/// Manages a aws_backup_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsBackupPlan : TerraformResource
{
    public AwsBackupPlan(string name) : base("aws_backup_plan", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for advanced_backup_setting.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("advanced_backup_setting")]
    public TerraformSet<TerraformBlock<AwsBackupPlanAdvancedBackupSettingBlock>>? AdvancedBackupSetting { get; set; }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [TerraformProperty("rule")]
    public TerraformSet<TerraformBlock<AwsBackupPlanRuleBlock>>? Rule { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

}
