using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_backup_plan.
/// </summary>
public class GoogleBackupDrBackupPlanDataSource : TerraformDataSource
{
    public GoogleBackupDrBackupPlanDataSource(string name) : base("google_backup_dr_backup_plan", name)
    {
    }

    /// <summary>
    /// The ID of the backup plan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanId is required")]
    [TerraformPropertyName("backup_plan_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackupPlanId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location for the backup plan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The backup rules for this &#39;BackupPlan&#39;. There must be at least one &#39;BackupRule&#39; message.
    /// </summary>
    [TerraformPropertyName("backup_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BackupRules => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "backup_rules");

    /// <summary>
    /// Backup vault where the backups gets stored using this Backup plan.
    /// </summary>
    [TerraformPropertyName("backup_vault")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupVault => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_vault");

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the BackupVault for taking backups.
    /// </summary>
    [TerraformPropertyName("backup_vault_service_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupVaultServiceAccount => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_vault_service_account");

    /// <summary>
    /// When the &#39;BackupPlan&#39; was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The description allows for additional details about &#39;BackupPlan&#39; and its use cases to be provided.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// This is only applicable for CloudSql resource. Days for which logs will be stored. This value should be greater than or equal to minimum enforced log retention duration of the backup vault.
    /// </summary>
    [TerraformPropertyName("log_retention_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LogRetentionDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "log_retention_days");

    /// <summary>
    /// The name of backup plan resource created
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The resource type to which the &#39;BackupPlan&#39; will be applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot; and &amp;quot;storage.googleapis.com/Bucket&amp;quot;.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_type");

    /// <summary>
    /// The list of all resource types to which the &#39;BackupPlan&#39; can be applied.
    /// </summary>
    [TerraformPropertyName("supported_resource_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedResourceTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_resource_types");

    /// <summary>
    /// When the &#39;BackupPlan&#39; was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
