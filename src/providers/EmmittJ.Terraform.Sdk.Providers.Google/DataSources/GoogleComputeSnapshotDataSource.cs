using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_snapshot.
/// </summary>
public partial class GoogleComputeSnapshotDataSource : TerraformDataSource
{
    public GoogleComputeSnapshotDataSource(string name) : base("google_compute_snapshot", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformProperty("most_recent")]
    // Optional argument - source generator will implement get/set
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
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Creates the new snapshot in the snapshot chain labeled with the
    /// specified name. The chain name must be 1-63 characters long and
    /// comply with RFC1035. This is an uncommon option only for advanced
    /// service owners who needs to create separate snapshot chains, for
    /// example, for chargeback tracking.  When you describe your snapshot
    /// resource, this field is visible only if it has a non-empty value.
    /// </summary>
    [TerraformProperty("chain_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ChainName { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// Size of the snapshot, specified in GB.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DiskSizeGb { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource. Used
    /// internally during updates.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// Labels to apply to this Snapshot.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// A list of public visible licenses that apply to this snapshot. This
    /// can be because the original image had licenses attached (such as a
    /// Windows image).  snapshotEncryptionKey nested object Encrypts the
    /// snapshot using a customer-supplied encryption key.
    /// </summary>
    [TerraformProperty("licenses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Licenses { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

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
    [TerraformProperty("snapshot_encryption_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SnapshotEncryptionKey { get; }

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    [TerraformProperty("snapshot_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SnapshotId { get; }

    /// <summary>
    /// A reference to the disk used to create this snapshot.
    /// </summary>
    [TerraformProperty("source_disk")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceDisk { get; }

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required
    /// if the source snapshot is protected by a customer-supplied encryption
    /// key.
    /// </summary>
    [TerraformProperty("source_disk_encryption_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SourceDiskEncryptionKey { get; }

    /// <summary>
    /// A size of the storage used by the snapshot. As snapshots share
    /// storage, this number is expected to change with snapshot
    /// creation/deletion.
    /// </summary>
    [TerraformProperty("storage_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> StorageBytes { get; }

    /// <summary>
    /// Cloud Storage bucket storage location of the snapshot (regional or multi-regional).
    /// </summary>
    [TerraformProperty("storage_locations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> StorageLocations { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// A reference to the zone where the disk is hosted.
    /// </summary>
    [TerraformProperty("zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Zone { get; }

}
