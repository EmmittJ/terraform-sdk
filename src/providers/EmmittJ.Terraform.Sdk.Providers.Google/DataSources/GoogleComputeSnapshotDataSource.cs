using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_snapshot.
/// </summary>
public class GoogleComputeSnapshotDataSource : TerraformDataSource
{
    public GoogleComputeSnapshotDataSource(string name) : base("google_compute_snapshot", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Creates the new snapshot in the snapshot chain labeled with the
    /// specified name. The chain name must be 1-63 characters long and
    /// comply with RFC1035. This is an uncommon option only for advanced
    /// service owners who needs to create separate snapshot chains, for
    /// example, for chargeback tracking.  When you describe your snapshot
    /// resource, this field is visible only if it has a non-empty value.
    /// </summary>
    [TerraformPropertyName("chain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ChainName => new TerraformReference(this, "chain_name");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Size of the snapshot, specified in GB.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DiskSizeGb => new TerraformReference(this, "disk_size_gb");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource. Used
    /// internally during updates.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// Labels to apply to this Snapshot.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// A list of public visible licenses that apply to this snapshot. This
    /// can be because the original image had licenses attached (such as a
    /// Windows image).  snapshotEncryptionKey nested object Encrypts the
    /// snapshot using a customer-supplied encryption key.
    /// </summary>
    [TerraformPropertyName("licenses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Licenses => new TerraformReference(this, "licenses");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// Encrypts the snapshot using a customer-supplied encryption key.
    /// 
    /// After you encrypt a snapshot using a customer-supplied key, you must
    /// provide the same key if you use the snapshot later. For example, you
    /// must provide the encryption key when you create a disk from the
    /// encrypted snapshot in a future request.
    /// 
    /// Customer-supplied encryption keys do not protect access to metadata of
    /// the snapshot.
    /// 
    /// If you do not provide an encryption key when creating the snapshot,
    /// then the snapshot will be encrypted using an automatically generated
    /// key and you do not need to provide a key to use the snapshot later.
    /// </summary>
    [TerraformPropertyName("snapshot_encryption_key")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SnapshotEncryptionKey => new TerraformReference(this, "snapshot_encryption_key");

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SnapshotId => new TerraformReference(this, "snapshot_id");

    /// <summary>
    /// A reference to the disk used to create this snapshot.
    /// </summary>
    [TerraformPropertyName("source_disk")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceDisk => new TerraformReference(this, "source_disk");

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required
    /// if the source snapshot is protected by a customer-supplied encryption
    /// key.
    /// </summary>
    [TerraformPropertyName("source_disk_encryption_key")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SourceDiskEncryptionKey => new TerraformReference(this, "source_disk_encryption_key");

    /// <summary>
    /// A size of the storage used by the snapshot. As snapshots share
    /// storage, this number is expected to change with snapshot
    /// creation/deletion.
    /// </summary>
    [TerraformPropertyName("storage_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StorageBytes => new TerraformReference(this, "storage_bytes");

    /// <summary>
    /// Cloud Storage bucket storage location of the snapshot (regional or multi-regional).
    /// </summary>
    [TerraformPropertyName("storage_locations")]
    // Output-only attribute - read-only reference
    public TerraformList<string> StorageLocations => new TerraformReference(this, "storage_locations");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// A reference to the zone where the disk is hosted.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Zone => new TerraformReference(this, "zone");

}
