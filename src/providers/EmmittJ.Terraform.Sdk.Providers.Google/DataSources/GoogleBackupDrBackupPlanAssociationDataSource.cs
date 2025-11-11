using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_backup_plan_association.
/// </summary>
public class GoogleBackupDrBackupPlanAssociationDataSource : TerraformDataSource
{
    public GoogleBackupDrBackupPlanAssociationDataSource(string name) : base("google_backup_dr_backup_plan_association", name)
    {
    }

    /// <summary>
    /// The id of backupplan association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanAssociationId is required")]
    [TerraformPropertyName("backup_plan_association_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BackupPlanAssociationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location for the backupplan association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The BP with which resource needs to be created
    /// Note:
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Instance&#39;, can only protect instance type resources.
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Disk&#39; can be used to protect both standard Disks and Regional Disks resources.
    /// </summary>
    [TerraformPropertyName("backup_plan")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupPlan => new TerraformReference(this, "backup_plan");

    /// <summary>
    /// The time when the instance was created
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Resource name of data source which will be used as storage location for backups taken
    /// </summary>
    [TerraformPropertyName("data_source")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DataSource => new TerraformReference(this, "data_source");

    /// <summary>
    /// The point in time when the last successful backup was captured from the source
    /// </summary>
    [TerraformPropertyName("last_successful_backup_consistency_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastSuccessfulBackupConsistencyTime => new TerraformReference(this, "last_successful_backup_consistency_time");

    /// <summary>
    /// The name of backup plan association resource created
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The resource for which BPA needs to be created
    /// </summary>
    [TerraformPropertyName("resource")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Resource => new TerraformReference(this, "resource");

    /// <summary>
    /// The resource type of workload on which backupplan is applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, and &amp;quot;compute.googleapis.com/RegionDisk&amp;quot;
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceType => new TerraformReference(this, "resource_type");

    /// <summary>
    /// Message for rules config info
    /// </summary>
    [TerraformPropertyName("rules_config_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RulesConfigInfo => new TerraformReference(this, "rules_config_info");

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
