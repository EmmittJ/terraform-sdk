using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_backup_setting in .
/// Nesting mode: set
/// </summary>
public class AwsBackupPlanAdvancedBackupSettingBlock
{
    /// <summary>
    /// The backup_options attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupOptions is required")]
    [TerraformPropertyName("backup_options")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformMap<string> BackupOptions { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformPropertyName("resource_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceType { get; set; }

}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public class AwsBackupPlanRuleBlock
{
    /// <summary>
    /// The completion_window attribute.
    /// </summary>
    [TerraformPropertyName("completion_window")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CompletionWindow { get; set; }

    /// <summary>
    /// The enable_continuous_backup attribute.
    /// </summary>
    [TerraformPropertyName("enable_continuous_backup")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableContinuousBackup { get; set; }

    /// <summary>
    /// The recovery_point_tags attribute.
    /// </summary>
    [TerraformPropertyName("recovery_point_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? RecoveryPointTags { get; set; }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    [TerraformPropertyName("rule_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RuleName { get; set; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformPropertyName("schedule")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Schedule { get; set; }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    [TerraformPropertyName("schedule_expression_timezone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScheduleExpressionTimezone { get; set; }

    /// <summary>
    /// The start_window attribute.
    /// </summary>
    [TerraformPropertyName("start_window")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? StartWindow { get; set; }

    /// <summary>
    /// The target_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVaultName is required")]
    [TerraformPropertyName("target_vault_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetVaultName { get; set; }

}

/// <summary>
/// Manages a aws_backup_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBackupPlan : TerraformResource
{
    public AwsBackupPlan(string name) : base("aws_backup_plan", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for advanced_backup_setting.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("advanced_backup_setting")]
    public TerraformSet<TerraformBlock<AwsBackupPlanAdvancedBackupSettingBlock>>? AdvancedBackupSetting { get; set; }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [TerraformPropertyName("rule")]
    public TerraformSet<TerraformBlock<AwsBackupPlanRuleBlock>>? Rule { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
