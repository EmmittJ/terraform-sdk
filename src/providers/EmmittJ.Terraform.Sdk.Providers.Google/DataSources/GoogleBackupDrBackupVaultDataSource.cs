using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_backup_vault.
/// </summary>
public partial class GoogleBackupDrBackupVaultDataSource : TerraformDataSource
{
    public GoogleBackupDrBackupVaultDataSource(string name) : base("google_backup_dr_backup_vault", name)
    {
    }

    /// <summary>
    /// Required. ID of the requesting object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    [TerraformProperty("backup_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupVaultId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The GCP location for the backup vault.
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
    /// Access restriction for the backup vault. Default value is &#39;WITHIN_ORGANIZATION&#39; if not provided during creation. Default value: &amp;quot;WITHIN_ORGANIZATION&amp;quot; Possible values: [&amp;quot;ACCESS_RESTRICTION_UNSPECIFIED&amp;quot;, &amp;quot;WITHIN_PROJECT&amp;quot;, &amp;quot;WITHIN_ORGANIZATION&amp;quot;, &amp;quot;UNRESTRICTED&amp;quot;, &amp;quot;WITHIN_ORG_BUT_UNRESTRICTED_FOR_BA&amp;quot;]
    /// </summary>
    [TerraformProperty("access_restriction")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessRestriction { get; }

    /// <summary>
    /// Allow idempotent deletion of backup vault. The request will still succeed in case the backup vault does not exist.
    /// </summary>
    [TerraformProperty("allow_missing")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AllowMissing { get; }

    /// <summary>
    /// Optional. User annotations. See https://google.aip.dev/128#annotations
    /// Stores small amounts of arbitrary data. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Annotations { get; }

    /// <summary>
    /// Output only. The number of backups in this backup vault.
    /// </summary>
    [TerraformProperty("backup_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupCount { get; }

    /// <summary>
    /// Required. The default and minimum enforced retention for each backup within the backup vault. The enforced retention for each backup can be extended.
    /// </summary>
    [TerraformProperty("backup_minimum_enforced_retention_duration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupMinimumEnforcedRetentionDuration { get; }

    /// <summary>
    /// How a backup&#39;s enforced retention end time is inherited. Default value is &#39;INHERIT_VAULT_RETENTION&#39; if not provided during creation. Possible values: [&amp;quot;BACKUP_RETENTION_INHERITANCE_UNSPECIFIED&amp;quot;, &amp;quot;INHERIT_VAULT_RETENTION&amp;quot;, &amp;quot;MATCH_BACKUP_EXPIRE_TIME&amp;quot;]
    /// </summary>
    [TerraformProperty("backup_retention_inheritance")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupRetentionInheritance { get; }

    /// <summary>
    /// Output only. The time when the instance was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. Set to true when there are no backups nested under this resource.
    /// </summary>
    [TerraformProperty("deletable")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Deletable { get; }

    /// <summary>
    /// Optional. The description of the BackupVault instance (2048 characters or less).
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Optional. Time after which the BackupVault resource is locked.
    /// </summary>
    [TerraformProperty("effective_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EffectiveTime { get; }

    /// <summary>
    /// Optional. Server specified ETag for the backup vault resource to prevent simultaneous updates from overwiting each other.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance containing no backups, but still containing empty datasources.
    ///    * deletion of a backup vault instance that is being referenced by an active backup plan.
    /// </summary>
    [TerraformProperty("force_delete")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ForceDelete { get; }

    /// <summary>
    /// If set, allow update to extend the minimum enforced retention for backup vault. This overrides
    ///  the restriction against conflicting retention periods. This conflict may occur when the
    ///  expiration schedule defined by the associated backup plan is shorter than the minimum
    ///  retention set by the backup vault.
    /// </summary>
    [TerraformProperty("force_update")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ForceUpdate { get; }

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance that is being referenced by an active backup plan.
    /// </summary>
    [TerraformProperty("ignore_backup_plan_references")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IgnoreBackupPlanReferences { get; }

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance containing no backups, but still containing empty datasources.
    /// </summary>
    [TerraformProperty("ignore_inactive_datasources")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IgnoreInactiveDatasources { get; }

    /// <summary>
    /// Optional. Resource labels to represent user provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Labels { get; }

    /// <summary>
    /// Output only. Identifier. The resource name.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. Service account used by the BackupVault Service for this BackupVault.  The user should grant this account permissions in their workload project to enable the service to run backups and restores there.
    /// </summary>
    [TerraformProperty("service_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceAccount { get; }

    /// <summary>
    /// Output only. The BackupVault resource instance state. 
    ///  Possible values:
    ///  STATE_UNSPECIFIED
    ///  CREATING
    ///  ACTIVE
    ///  DELETING
    ///  ERROR
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. Total size of the storage used by all backup resources.
    /// </summary>
    [TerraformProperty("total_stored_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TotalStoredBytes { get; }

    /// <summary>
    /// Output only. Output only Immutable after resource creation until resource deletion.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. The time when the instance was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
