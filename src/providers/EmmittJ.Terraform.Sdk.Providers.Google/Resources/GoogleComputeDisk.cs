using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for async_primary_disk in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeDiskAsyncPrimaryDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// Primary disk for asynchronous disk replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    [TerraformProperty("disk")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Disk { get; set; }

}

/// <summary>
/// Block type for disk_encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeDiskDiskEncryptionKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The self link of the encryption key used to encrypt the disk. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    [TerraformProperty("kms_key_service_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformProperty("raw_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RawKey { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// </summary>
    [TerraformProperty("rsa_encrypted_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RsaEncryptedKey { get; set; }


}

/// <summary>
/// Block type for guest_os_features in .
/// Nesting mode: set
/// </summary>
public partial class GoogleComputeDiskGuestOsFeaturesBlock : TerraformBlockBase
{
    /// <summary>
    /// The type of supported feature. Read [Enabling guest operating system features](https://cloud.google.com/compute/docs/images/create-delete-deprecate-private-images#guest-os-features) to see a list of available options.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeDiskParamsBlock : TerraformBlockBase
{
    /// <summary>
    /// Resource manager tags to be bound to the disk. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for source_image_encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeDiskSourceImageEncryptionKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The self link of the encryption key used to encrypt the disk. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    [TerraformProperty("kms_key_service_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformProperty("raw_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RawKey { get; set; }


}

/// <summary>
/// Block type for source_snapshot_encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeDiskSourceSnapshotEncryptionKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The self link of the encryption key used to encrypt the disk. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    [TerraformProperty("kms_key_service_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformProperty("raw_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RawKey { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeDiskTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_compute_disk resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeDisk : TerraformResource
{
    public GoogleComputeDisk(string name) : base("google_compute_disk", name)
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
    [TerraformProperty("access_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AccessMode { get; set; }

    /// <summary>
    /// The architecture of the disk. Values include &#39;X86_64&#39;, &#39;ARM64&#39;.
    /// </summary>
    [TerraformProperty("architecture")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Architecture { get; set; }

    /// <summary>
    /// If set to true, a snapshot of the disk will be created before it is destroyed.
    /// If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation.
    /// The name of the snapshot by default will be &#39;{{disk-name}}-YYYYMMDD-HHmm&#39;
    /// </summary>
    [TerraformProperty("create_snapshot_before_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CreateSnapshotBeforeDestroy { get; set; }

    /// <summary>
    /// This will set a custom name prefix for the snapshot that&#39;s created when the disk is deleted.
    /// </summary>
    [TerraformProperty("create_snapshot_before_destroy_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateSnapshotBeforeDestroyPrefix { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Whether this disk is using confidential compute mode.
    /// Note: Only supported on hyperdisk skus, disk_encryption_key is required when setting to true
    /// </summary>
    [TerraformProperty("enable_confidential_compute")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableConfidentialCompute { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image from which to initialize this disk. This can be
    /// one of: the image&#39;s &#39;self_link&#39;, &#39;projects/{project}/global/images/{image}&#39;,
    /// &#39;projects/{project}/global/images/family/{family}&#39;, &#39;global/images/{image}&#39;,
    /// &#39;global/images/family/{family}&#39;, &#39;family/{family}&#39;, &#39;{project}/{family}&#39;,
    /// &#39;{project}/{image}&#39;, &#39;{family}&#39;, or &#39;{image}&#39;. If referred by family, the
    /// images names must include the family name. If they don&#39;t, use the
    /// [google_compute_image data source](/docs/providers/google/d/compute_image.html).
    /// For instance, the image &#39;centos-6-v20180104&#39; includes its family name &#39;centos-6&#39;.
    /// These images can be referred by family name here.
    /// </summary>
    [TerraformProperty("image")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Image { get; set; }

    /// <summary>
    /// Labels to apply to this disk.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    [TerraformProperty("licenses")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> Licenses { get; set; }

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
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Physical block size of the persistent disk, in bytes. If not present
    /// in a request, a default value is used. Currently supported sizes
    /// are 4096 and 16384, other sizes may be added in the future.
    /// If an unsupported value is requested, the error message will list
    /// the supported values for the caller&#39;s project.
    /// </summary>
    [TerraformProperty("physical_block_size_bytes")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> PhysicalBlockSizeBytes { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Indicates how many IOPS must be provisioned for the disk.
    /// Note: Updating currently is only supported by hyperdisk skus without the need to delete and recreate the disk, hyperdisk
    /// allows for an update of IOPS every 4 hours. To update your hyperdisk more frequently, you&#39;ll need to manually delete and recreate it
    /// </summary>
    [TerraformProperty("provisioned_iops")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ProvisionedIops { get; set; }

    /// <summary>
    /// Indicates how much Throughput must be provisioned for the disk.
    /// Note: Updating currently is only supported by hyperdisk skus without the need to delete and recreate the disk, hyperdisk
    /// allows for an update of Throughput every 4 hours. To update your hyperdisk more frequently, you&#39;ll need to manually delete and recreate it
    /// </summary>
    [TerraformProperty("provisioned_throughput")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ProvisionedThroughput { get; set; }

    /// <summary>
    /// Size of the persistent disk, specified in GB. You can specify this
    /// field when creating a persistent disk using the &#39;image&#39; or
    /// &#39;snapshot&#39; parameter, or specify it alone to create an empty
    /// persistent disk.
    /// 
    /// If you specify this field along with &#39;image&#39; or &#39;snapshot&#39;,
    /// the value must not be less than the size of the image
    /// or the size of the snapshot.
    /// 
    /// ~&amp;gt;**NOTE** If you change the size, Terraform updates the disk size
    /// if upsizing is detected but recreates the disk if downsizing is requested.
    /// You can add &#39;lifecycle.prevent_destroy&#39; in the config to prevent destroying
    /// and recreating.
    /// </summary>
    [TerraformProperty("size")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Size { get; set; }

    /// <summary>
    /// The source snapshot used to create this disk. You can provide this as
    /// a partial or full URL to the resource. If the snapshot is in another
    /// project than this disk, you must supply a full URL. For example, the
    /// following are valid values:
    /// 
    /// * &#39;https://www.googleapis.com/compute/v1/projects/project/global/snapshots/snapshot&#39;
    /// * &#39;projects/project/global/snapshots/snapshot&#39;
    /// * &#39;global/snapshots/snapshot&#39;
    /// * &#39;snapshot&#39;
    /// </summary>
    [TerraformProperty("snapshot")]
    // Optional argument - source generator will implement get/set
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
    [TerraformProperty("source_disk")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceDisk { get; set; }

    /// <summary>
    /// The source instant snapshot used to create this disk. You can provide this as a partial or full URL to the resource.
    /// For example, the following are valid values:
    /// 
    /// * &#39;https://www.googleapis.com/compute/v1/projects/project/zones/zone/instantSnapshots/instantSnapshot&#39;
    /// * &#39;projects/project/zones/zone/instantSnapshots/instantSnapshot&#39;
    /// * &#39;zones/zone/instantSnapshots/instantSnapshot&#39;
    /// </summary>
    [TerraformProperty("source_instant_snapshot")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceInstantSnapshot { get; set; }

    /// <summary>
    /// The full Google Cloud Storage URI where the disk image is stored.
    /// This file must be a gzip-compressed tarball whose name ends in .tar.gz or virtual machine disk whose name ends in vmdk.
    /// Valid URIs may start with gs:// or https://storage.googleapis.com/.
    /// This flag is not optimized for creating multiple disks from a source storage object.
    /// To create many disks from a source storage object, use gcloud compute images import instead.
    /// </summary>
    [TerraformProperty("source_storage_object")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceStorageObject { get; set; }

    /// <summary>
    /// The URL or the name of the storage pool in which the new disk is created.
    /// For example:
    /// * https://www.googleapis.com/compute/v1/projects/{project}/zones/{zone}/storagePools/{storagePool}
    /// * /projects/{project}/zones/{zone}/storagePools/{storagePool}
    /// * /zones/{zone}/storagePools/{storagePool}
    /// * /{storagePool}
    /// </summary>
    [TerraformProperty("storage_pool")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StoragePool { get; set; }

    /// <summary>
    /// URL of the disk type resource describing which disk type to use to
    /// create the disk. Provide this when creating the disk.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// A reference to the zone where the disk resides.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for async_primary_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AsyncPrimaryDisk block(s) allowed")]
    [TerraformProperty("async_primary_disk")]
    public TerraformList<TerraformBlock<GoogleComputeDiskAsyncPrimaryDiskBlock>>? AsyncPrimaryDisk { get; set; }

    /// <summary>
    /// Block for disk_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskEncryptionKey block(s) allowed")]
    [TerraformProperty("disk_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeDiskDiskEncryptionKeyBlock>>? DiskEncryptionKey { get; set; }

    /// <summary>
    /// Block for guest_os_features.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("guest_os_features")]
    public TerraformSet<TerraformBlock<GoogleComputeDiskGuestOsFeaturesBlock>>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformProperty("params")]
    public TerraformList<TerraformBlock<GoogleComputeDiskParamsBlock>>? Params { get; set; }

    /// <summary>
    /// Block for source_image_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageEncryptionKey block(s) allowed")]
    [TerraformProperty("source_image_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeDiskSourceImageEncryptionKeyBlock>>? SourceImageEncryptionKey { get; set; }

    /// <summary>
    /// Block for source_snapshot_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSnapshotEncryptionKey block(s) allowed")]
    [TerraformProperty("source_snapshot_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeDiskSourceSnapshotEncryptionKeyBlock>>? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeDiskTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("disk_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DiskId { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// Last attach timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("last_attach_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastAttachTimestamp { get; }

    /// <summary>
    /// Last detach timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("last_detach_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastDetachTimestamp { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The ID value of the disk used to create this image. This value may
    /// be used to determine whether the image was taken from the current
    /// or a previous instance of a given disk name.
    /// </summary>
    [TerraformProperty("source_disk_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceDiskId { get; }

    /// <summary>
    /// The ID value of the image used to create this disk. This value
    /// identifies the exact image that was used to create this persistent
    /// disk. For example, if you created the persistent disk from an image
    /// that was later deleted and recreated under the same name, the source
    /// image ID would identify the exact version of the image that was used.
    /// </summary>
    [TerraformProperty("source_image_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceImageId { get; }

    /// <summary>
    /// The unique ID of the instant snapshot used to create this disk. This value identifies
    /// the exact instant snapshot that was used to create this persistent disk.
    /// For example, if you created the persistent disk from an instant snapshot that was later
    /// deleted and recreated under the same name, the source instant snapshot ID would identify
    /// the exact version of the instant snapshot that was used.
    /// </summary>
    [TerraformProperty("source_instant_snapshot_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceInstantSnapshotId { get; }

    /// <summary>
    /// The unique ID of the snapshot used to create this disk. This value
    /// identifies the exact snapshot that was used to create this persistent
    /// disk. For example, if you created the persistent disk from a snapshot
    /// that was later deleted and recreated under the same name, the source
    /// snapshot ID would identify the exact version of the snapshot that was
    /// used.
    /// </summary>
    [TerraformProperty("source_snapshot_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceSnapshotId { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Links to the users of the disk (attached instances) in form:
    /// project/zones/zone/instances/instance
    /// </summary>
    [TerraformProperty("users")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Users { get; }

}
