using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for async_primary_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionDiskAsyncPrimaryDiskBlock
{
    /// <summary>
    /// Primary disk for asynchronous disk replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    [TerraformPropertyName("disk")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Disk { get; set; }

}

/// <summary>
/// Block type for disk_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionDiskDiskEncryptionKeyBlock
{
    /// <summary>
    /// The name of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformPropertyName("raw_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RawKey { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// </summary>
    [TerraformPropertyName("rsa_encrypted_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RsaEncryptedKey { get; set; }


}

/// <summary>
/// Block type for guest_os_features in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeRegionDiskGuestOsFeaturesBlock
{
    /// <summary>
    /// The type of supported feature. Read [Enabling guest operating system features](https://cloud.google.com/compute/docs/images/create-delete-deprecate-private-images#guest-os-features) to see a list of available options. Possible values: [&amp;quot;MULTI_IP_SUBNET&amp;quot;, &amp;quot;SECURE_BOOT&amp;quot;, &amp;quot;SEV_CAPABLE&amp;quot;, &amp;quot;UEFI_COMPATIBLE&amp;quot;, &amp;quot;VIRTIO_SCSI_MULTIQUEUE&amp;quot;, &amp;quot;WINDOWS&amp;quot;, &amp;quot;GVNIC&amp;quot;, &amp;quot;SEV_LIVE_MIGRATABLE&amp;quot;, &amp;quot;SEV_SNP_CAPABLE&amp;quot;, &amp;quot;SUSPEND_RESUME_COMPATIBLE&amp;quot;, &amp;quot;TDX_CAPABLE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for source_snapshot_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionDiskSourceSnapshotEncryptionKeyBlock
{
    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformPropertyName("raw_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RawKey { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionDiskTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_region_disk resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRegionDisk : TerraformResource
{
    public GoogleComputeRegionDisk(string name) : base("google_compute_region_disk", name)
    {
    }

    /// <summary>
    /// The access mode of the disk.
    /// For example:
    ///   * READ_WRITE_SINGLE: The default AccessMode, means the disk can be attached to single instance in RW mode.
    ///   * READ_WRITE_MANY: The AccessMode means the disk can be attached to multiple instances in RW mode.
    ///   * READ_ONLY_SINGLE: The AccessMode means the disk can be attached to multiple instances in RO mode.
    /// The AccessMode is only valid for Hyperdisk disk types.
    /// </summary>
    [TerraformPropertyName("access_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccessMode { get; set; } = default!;

    /// <summary>
    /// If set to true, a snapshot of the disk will be created before it is destroyed.
    /// If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation.
    /// The name of the snapshot by default will be &#39;{{disk-name}}-YYYYMMDD-HHmm&#39;
    /// </summary>
    [TerraformPropertyName("create_snapshot_before_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CreateSnapshotBeforeDestroy { get; set; }

    /// <summary>
    /// This will set a custom name prefix for the snapshot that&#39;s created when the disk is deleted.
    /// </summary>
    [TerraformPropertyName("create_snapshot_before_destroy_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateSnapshotBeforeDestroyPrefix { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Labels to apply to this disk.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    [TerraformPropertyName("licenses")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Licenses { get; set; } = default!;

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
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
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Physical block size of the persistent disk, in bytes. If not present
    /// in a request, a default value is used. Currently supported sizes
    /// are 4096 and 16384, other sizes may be added in the future.
    /// If an unsupported value is requested, the error message will list
    /// the supported values for the caller&#39;s project.
    /// </summary>
    [TerraformPropertyName("physical_block_size_bytes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> PhysicalBlockSizeBytes { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second
    /// that the disk can handle. Values must be between 10,000 and 120,000.
    /// For more details, see the Extreme persistent disk [documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk).
    /// </summary>
    [TerraformPropertyName("provisioned_iops")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ProvisionedIops { get; set; } = default!;

    /// <summary>
    /// Indicates how much throughput to provision for the disk. This sets the number of throughput
    /// mb per second that the disk can handle. Values must be greater than or equal to 1.
    /// </summary>
    [TerraformPropertyName("provisioned_throughput")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ProvisionedThroughput { get; set; } = default!;

    /// <summary>
    /// A reference to the region where the disk resides.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// URLs of the zones where the disk should be replicated to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaZones is required")]
    [TerraformPropertyName("replica_zones")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? ReplicaZones { get; set; }

    /// <summary>
    /// Size of the persistent disk, specified in GB. You can specify this
    /// field when creating a persistent disk using the sourceImage or
    /// sourceSnapshot parameter, or specify it alone to create an empty
    /// persistent disk.
    /// 
    /// If you specify this field along with sourceImage or sourceSnapshot,
    /// the value of sizeGb must not be less than the size of the sourceImage
    /// or the size of the snapshot.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Size { get; set; } = default!;

    /// <summary>
    /// The source snapshot used to create this disk. You can provide this as
    /// a partial or full URL to the resource. For example, the following are
    /// valid values:
    /// 
    /// * &#39;https://www.googleapis.com/compute/v1/projects/project/global/snapshots/snapshot&#39;
    /// * &#39;projects/project/global/snapshots/snapshot&#39;
    /// * &#39;global/snapshots/snapshot&#39;
    /// * &#39;snapshot&#39;
    /// </summary>
    [TerraformPropertyName("snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Snapshot { get; set; }

    /// <summary>
    /// The source disk used to create this disk. You can provide this as a partial or full URL to the resource.
    /// For example, the following are valid values:
    /// 
    /// * https://www.googleapis.com/compute/v1/projects/{project}/zones/{zone}/disks/{disk}
    /// * https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/disks/{disk}
    /// * projects/{project}/zones/{zone}/disks/{disk}
    /// * projects/{project}/regions/{region}/disks/{disk}
    /// * zones/{zone}/disks/{disk}
    /// * regions/{region}/disks/{disk}
    /// </summary>
    [TerraformPropertyName("source_disk")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceDisk { get; set; }

    /// <summary>
    /// URL of the disk type resource describing which disk type to use to
    /// create the disk. Provide this when creating the disk.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for async_primary_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AsyncPrimaryDisk block(s) allowed")]
    [TerraformPropertyName("async_primary_disk")]
    public TerraformList<TerraformBlock<GoogleComputeRegionDiskAsyncPrimaryDiskBlock>>? AsyncPrimaryDisk { get; set; }

    /// <summary>
    /// Block for disk_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskEncryptionKey block(s) allowed")]
    [TerraformPropertyName("disk_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeRegionDiskDiskEncryptionKeyBlock>>? DiskEncryptionKey { get; set; }

    /// <summary>
    /// Block for guest_os_features.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("guest_os_features")]
    public TerraformSet<TerraformBlock<GoogleComputeRegionDiskGuestOsFeaturesBlock>>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Block for source_snapshot_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSnapshotEncryptionKey block(s) allowed")]
    [TerraformPropertyName("source_snapshot_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeRegionDiskSourceSnapshotEncryptionKeyBlock>>? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRegionDiskTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("disk_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DiskId => new TerraformReference(this, "disk_id");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// Last attach timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("last_attach_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastAttachTimestamp => new TerraformReference(this, "last_attach_timestamp");

    /// <summary>
    /// Last detach timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("last_detach_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastDetachTimestamp => new TerraformReference(this, "last_detach_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The ID value of the disk used to create this image. This value may
    /// be used to determine whether the image was taken from the current
    /// or a previous instance of a given disk name.
    /// </summary>
    [TerraformPropertyName("source_disk_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceDiskId => new TerraformReference(this, "source_disk_id");

    /// <summary>
    /// The unique ID of the snapshot used to create this disk. This value
    /// identifies the exact snapshot that was used to create this persistent
    /// disk. For example, if you created the persistent disk from a snapshot
    /// that was later deleted and recreated under the same name, the source
    /// snapshot ID would identify the exact version of the snapshot that was
    /// used.
    /// </summary>
    [TerraformPropertyName("source_snapshot_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceSnapshotId => new TerraformReference(this, "source_snapshot_id");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Links to the users of the disk (attached instances) in form:
    /// project/zones/zone/instances/instance
    /// </summary>
    [TerraformPropertyName("users")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Users => new TerraformReference(this, "users");

}
