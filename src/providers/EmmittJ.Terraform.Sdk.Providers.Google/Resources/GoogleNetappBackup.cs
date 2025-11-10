using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappBackupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_netapp_backup resource.
/// </summary>
public class GoogleNetappBackup : TerraformResource
{
    public GoogleNetappBackup(string name) : base("google_netapp_backup", name)
    {
    }

    /// <summary>
    /// A description of the backup with 2048 characters or less. Requests with longer descriptions will be rejected.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Location of the backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The resource name of the backup. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// If specified, backup will be created from the given snapshot. If not specified,
    /// there will be a new snapshot taken to initiate the backup creation.
    /// Format: &#39;projects/{{projectId}}/locations/{{location}}/volumes/{{volumename}}/snapshots/{{snapshotname}}&#39;&#39;
    /// </summary>
    [TerraformPropertyName("source_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceSnapshot { get; set; }

    /// <summary>
    /// ID of volumes this backup belongs to. Format: &#39;projects/{{projects_id}}/locations/{{location}}/volumes/{{name}}&#39;&#39;
    /// </summary>
    [TerraformPropertyName("source_volume")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceVolume { get; set; }

    /// <summary>
    /// Name of the backup vault to store the backup in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultName is required")]
    [TerraformPropertyName("vault_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VaultName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetappBackupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Region in which backup is stored.
    /// </summary>
    [TerraformPropertyName("backup_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_region");

    /// <summary>
    /// Type of backup, manually created or created by a backup policy. Possible Values : [TYPE_UNSPECIFIED, MANUAL, SCHEDULED]
    /// </summary>
    [TerraformPropertyName("backup_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_type");

    /// <summary>
    /// Backups of a volume build incrementally on top of each other. They form a &amp;quot;backup chain&amp;quot;.
    /// Total size of all backups in a chain in bytes = baseline backup size + sum(incremental backup size)
    /// </summary>
    [TerraformPropertyName("chain_storage_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ChainStorageBytes => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "chain_storage_bytes");

    /// <summary>
    /// Create time of the backup. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The state of the Backup Vault. Possible Values : [STATE_UNSPECIFIED, CREATING, UPLOADING, READY, DELETING, ERROR, UPDATING]
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Region of the volume from which the backup was created.
    /// </summary>
    [TerraformPropertyName("volume_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_region");

    /// <summary>
    /// Size of the file system when the backup was created. When creating a new volume from the backup, the volume capacity will have to be at least as big.
    /// </summary>
    [TerraformPropertyName("volume_usage_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeUsageBytes => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_usage_bytes");

}
