using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for snapshot_encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeSnapshotSnapshotEncryptionKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    [TerraformProperty("kms_key_service_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformProperty("raw_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RawKey { get; set; }

    /// <summary>
    /// Specifies an encryption key stored in Google Cloud KMS, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformProperty("rsa_encrypted_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RsaEncryptedKey { get; set; }


}

/// <summary>
/// Block type for source_disk_encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeSnapshotSourceDiskEncryptionKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    [TerraformProperty("kms_key_service_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformProperty("raw_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RawKey { get; set; }

    /// <summary>
    /// Specifies an encryption key stored in Google Cloud KMS, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformProperty("rsa_encrypted_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RsaEncryptedKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeSnapshotTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_compute_snapshot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeSnapshot : TerraformResource
{
    public GoogleComputeSnapshot(string name) : base("google_compute_snapshot", name)
    {
    }

    /// <summary>
    /// Creates the new snapshot in the snapshot chain labeled with the
    /// specified name. The chain name must be 1-63 characters long and
    /// comply with RFC1035. This is an uncommon option only for advanced
    /// service owners who needs to create separate snapshot chains, for
    /// example, for chargeback tracking.  When you describe your snapshot
    /// resource, this field is visible only if it has a non-empty value.
    /// </summary>
    [TerraformProperty("chain_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ChainName { get; set; }

    /// <summary>
    /// An optional description of this resource.
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
    /// Labels to apply to this Snapshot.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// A reference to the disk used to create this snapshot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDisk is required")]
    [TerraformProperty("source_disk")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceDisk { get; set; }

    /// <summary>
    /// Cloud Storage bucket storage location of the snapshot (regional or multi-regional).
    /// </summary>
    [TerraformProperty("storage_locations")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> StorageLocations { get; set; }

    /// <summary>
    /// A reference to the zone where the disk is hosted.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for snapshot_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotEncryptionKey block(s) allowed")]
    [TerraformProperty("snapshot_encryption_key")]
    public partial TerraformList<TerraformBlock<GoogleComputeSnapshotSnapshotEncryptionKeyBlock>>? SnapshotEncryptionKey { get; set; }

    /// <summary>
    /// Block for source_disk_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceDiskEncryptionKey block(s) allowed")]
    [TerraformProperty("source_disk_encryption_key")]
    public partial TerraformList<TerraformBlock<GoogleComputeSnapshotSourceDiskEncryptionKeyBlock>>? SourceDiskEncryptionKey { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputeSnapshotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// Size of the snapshot, specified in GB.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DiskSizeGb { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource. Used
    /// internally during updates.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// A list of public visible licenses that apply to this snapshot. This
    /// can be because the original image had licenses attached (such as a
    /// Windows image).  snapshotEncryptionKey nested object Encrypts the
    /// snapshot using a customer-supplied encryption key.
    /// </summary>
    [TerraformProperty("licenses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Licenses { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    [TerraformProperty("snapshot_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SnapshotId { get; }

    /// <summary>
    /// A size of the storage used by the snapshot. As snapshots share
    /// storage, this number is expected to change with snapshot
    /// creation/deletion.
    /// </summary>
    [TerraformProperty("storage_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> StorageBytes { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
