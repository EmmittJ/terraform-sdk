using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBackupDrBackupPlanAssociationTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_backup_dr_backup_plan_association resource.
/// </summary>
public partial class GoogleBackupDrBackupPlanAssociation : TerraformResource
{
    public GoogleBackupDrBackupPlanAssociation(string name) : base("google_backup_dr_backup_plan_association", name)
    {
    }

    /// <summary>
    /// The BP with which resource needs to be created
    /// Note:
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Instance&#39;, can only protect instance type resources.
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Disk&#39; can be used to protect both standard Disks and Regional Disks resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlan is required")]
    [TerraformProperty("backup_plan")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupPlan { get; set; }

    /// <summary>
    /// The id of backupplan association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanAssociationId is required")]
    [TerraformProperty("backup_plan_association_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupPlanAssociationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the backupplan association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The resource for which BPA needs to be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    [TerraformProperty("resource")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Resource { get; set; }

    /// <summary>
    /// The resource type of workload on which backupplan is applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, and &amp;quot;compute.googleapis.com/RegionDisk&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformProperty("resource_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceType { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleBackupDrBackupPlanAssociationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the instance was created
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Resource name of data source which will be used as storage location for backups taken
    /// </summary>
    [TerraformProperty("data_source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataSource { get; }

    /// <summary>
    /// The point in time when the last successful backup was captured from the source
    /// </summary>
    [TerraformProperty("last_successful_backup_consistency_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastSuccessfulBackupConsistencyTime { get; }

    /// <summary>
    /// The name of backup plan association resource created
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Message for rules config info
    /// </summary>
    [TerraformProperty("rules_config_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RulesConfigInfo { get; }

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
