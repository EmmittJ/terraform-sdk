using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbBackupEncryptionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAlloydbBackupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_alloydb_backup resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAlloydbBackup : TerraformResource
{
    public GoogleAlloydbBackup(string name) : base("google_alloydb_backup", name)
    {
    }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. https://google.aip.dev/128
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The ID of the alloydb backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupId is required")]
    [TerraformProperty("backup_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BackupId { get; set; }

    /// <summary>
    /// The full resource name of the backup source cluster (e.g., projects/{project}/locations/{location}/clusters/{clusterId}).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// User-provided description of the backup.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User-settable and human-readable display name for the Backup.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-defined labels for the alloydb backup. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where the alloydb backup should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The backup type, which suggests the trigger for the backup. Possible values: [&amp;quot;TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ON_DEMAND&amp;quot;, &amp;quot;AUTOMATED&amp;quot;, &amp;quot;CONTINUOUS&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformProperty("encryption_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbBackupEncryptionConfigBlock>>? EncryptionConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAlloydbBackupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The system-generated UID of the cluster which was used to create this resource.
    /// </summary>
    [TerraformProperty("cluster_uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterUid { get; }

    /// <summary>
    /// Output only. Create time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. Delete time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// EncryptionInfo describes the encryption information of a cluster or a backup.
    /// </summary>
    [TerraformProperty("encryption_info")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EncryptionInfo { get; }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// Output only. The QuantityBasedExpiry of the backup, specified by the backup&#39;s retention policy.
    /// Once the expiry quantity is over retention, the backup is eligible to be garbage collected.
    /// </summary>
    [TerraformProperty("expiry_quantity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ExpiryQuantity { get; }

    /// <summary>
    /// Output only. The time at which after the backup is eligible to be garbage collected.
    /// It is the duration specified by the backup&#39;s retention policy, added to the backup&#39;s createTime.
    /// </summary>
    [TerraformProperty("expiry_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExpiryTime { get; }

    /// <summary>
    /// Output only. The name of the backup resource with the format: * projects/{project}/locations/{region}/backups/{backupId}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. Reconciling (https://google.aip.dev/128#reconciliation), if true, indicates that the service is actively updating the resource.
    /// This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// Output only. The size of the backup in bytes.
    /// </summary>
    [TerraformProperty("size_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SizeBytes { get; }

    /// <summary>
    /// Output only. The current state of the backup.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. The system-generated UID of the resource. The UID is assigned when the resource is created, and it is retained until it is deleted.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. Update time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
