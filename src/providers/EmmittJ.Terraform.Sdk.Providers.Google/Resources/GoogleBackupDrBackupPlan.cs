using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_rules in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBackupDrBackupPlanBackupRulesBlock() : TerraformBlock("backup_rules")
{
    /// <summary>
    /// Configures the duration for which backup data will be kept. The value should be greater than or equal to minimum enforced retention of the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRetentionDays is required")]
    [TerraformProperty("backup_retention_days")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> BackupRetentionDays { get; set; }

    /// <summary>
    /// The unique ID of this &#39;BackupRule&#39;. The &#39;rule_id&#39; is unique per &#39;BackupPlan&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    [TerraformProperty("rule_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuleId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBackupDrBackupPlanTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_backup_dr_backup_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBackupDrBackupPlan : TerraformResource
{
    public GoogleBackupDrBackupPlan(string name) : base("google_backup_dr_backup_plan", name)
    {
    }

    /// <summary>
    /// The ID of the backup plan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanId is required")]
    [TerraformProperty("backup_plan_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupPlanId { get; set; }

    /// <summary>
    /// Backup vault where the backups gets stored using this Backup plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVault is required")]
    [TerraformProperty("backup_vault")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupVault { get; set; }

    /// <summary>
    /// The description allows for additional details about &#39;BackupPlan&#39; and its use cases to be provided.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the backup plan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// This is only applicable for CloudSql resource. Days for which logs will be stored. This value should be greater than or equal to minimum enforced log retention duration of the backup vault.
    /// </summary>
    [TerraformProperty("log_retention_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? LogRetentionDays { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The resource type to which the &#39;BackupPlan&#39; will be applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot; and &amp;quot;storage.googleapis.com/Bucket&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformProperty("resource_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceType { get; set; }

    /// <summary>
    /// Block for backup_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackupRules block(s) required")]
    [TerraformProperty("backup_rules")]
    public required TerraformList<GoogleBackupDrBackupPlanBackupRulesBlock> BackupRules { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBackupDrBackupPlanTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the BackupVault for taking backups.
    /// </summary>
    [TerraformProperty("backup_vault_service_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupVaultServiceAccount { get; }

    /// <summary>
    /// When the &#39;BackupPlan&#39; was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The name of backup plan resource created
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The list of all resource types to which the &#39;BackupPlan&#39; can be applied.
    /// </summary>
    [TerraformProperty("supported_resource_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SupportedResourceTypes { get; }

    /// <summary>
    /// When the &#39;BackupPlan&#39; was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
