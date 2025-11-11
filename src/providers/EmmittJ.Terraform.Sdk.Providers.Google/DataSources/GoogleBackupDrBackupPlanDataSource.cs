using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_backup_plan.
/// </summary>
public partial class GoogleBackupDrBackupPlanDataSource : TerraformDataSource
{
    public GoogleBackupDrBackupPlanDataSource(string name) : base("google_backup_dr_backup_plan", name)
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
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The backup rules for this &#39;BackupPlan&#39;. There must be at least one &#39;BackupRule&#39; message.
    /// </summary>
    [TerraformProperty("backup_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BackupRules { get; }

    /// <summary>
    /// Backup vault where the backups gets stored using this Backup plan.
    /// </summary>
    [TerraformProperty("backup_vault")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupVault { get; }

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
    /// The description allows for additional details about &#39;BackupPlan&#39; and its use cases to be provided.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// This is only applicable for CloudSql resource. Days for which logs will be stored. This value should be greater than or equal to minimum enforced log retention duration of the backup vault.
    /// </summary>
    [TerraformProperty("log_retention_days")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> LogRetentionDays { get; }

    /// <summary>
    /// The name of backup plan resource created
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The resource type to which the &#39;BackupPlan&#39; will be applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot; and &amp;quot;storage.googleapis.com/Bucket&amp;quot;.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceType { get; }

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
