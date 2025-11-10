using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for snapshot_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSnapshotSnapshotEncryptionKeyBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    [TerraformPropertyName("kms_key_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformPropertyName("raw_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RawKey { get; set; }

    /// <summary>
    /// Specifies an encryption key stored in Google Cloud KMS, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformPropertyName("rsa_encrypted_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RsaEncryptedKey { get; set; }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied
    /// encryption key that protects this resource.
    /// </summary>
    [TerraformPropertyName("sha256")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sha256 => new TerraformReferenceProperty<TerraformProperty<string>>("", "sha256");

}

/// <summary>
/// Block type for source_disk_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSnapshotSourceDiskEncryptionKeyBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    [TerraformPropertyName("kms_key_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformPropertyName("raw_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RawKey { get; set; }

    /// <summary>
    /// Specifies an encryption key stored in Google Cloud KMS, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformPropertyName("rsa_encrypted_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RsaEncryptedKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeSnapshotTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_snapshot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeSnapshot : TerraformResource
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
    [TerraformPropertyName("chain_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ChainName { get; set; }

    /// <summary>
    /// An optional description of this resource.
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
    /// Labels to apply to this Snapshot.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

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
    /// A reference to the disk used to create this snapshot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDisk is required")]
    [TerraformPropertyName("source_disk")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceDisk { get; set; }

    /// <summary>
    /// Cloud Storage bucket storage location of the snapshot (regional or multi-regional).
    /// </summary>
    [TerraformPropertyName("storage_locations")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> StorageLocations { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "storage_locations");

    /// <summary>
    /// A reference to the zone where the disk is hosted.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Zone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

    /// <summary>
    /// Block for snapshot_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotEncryptionKey block(s) allowed")]
    [TerraformPropertyName("snapshot_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeSnapshotSnapshotEncryptionKeyBlock>>? SnapshotEncryptionKey { get; set; } = new();

    /// <summary>
    /// Block for source_disk_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceDiskEncryptionKey block(s) allowed")]
    [TerraformPropertyName("source_disk_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeSnapshotSourceDiskEncryptionKeyBlock>>? SourceDiskEncryptionKey { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeSnapshotTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// Size of the snapshot, specified in GB.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DiskSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "disk_size_gb");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource. Used
    /// internally during updates.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LabelFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label_fingerprint");

    /// <summary>
    /// A list of public visible licenses that apply to this snapshot. This
    /// can be because the original image had licenses attached (such as a
    /// Windows image).  snapshotEncryptionKey nested object Encrypts the
    /// snapshot using a customer-supplied encryption key.
    /// </summary>
    [TerraformPropertyName("licenses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Licenses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "licenses");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("snapshot_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SnapshotId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "snapshot_id");

    /// <summary>
    /// A size of the storage used by the snapshot. As snapshots share
    /// storage, this number is expected to change with snapshot
    /// creation/deletion.
    /// </summary>
    [TerraformPropertyName("storage_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StorageBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_bytes");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
