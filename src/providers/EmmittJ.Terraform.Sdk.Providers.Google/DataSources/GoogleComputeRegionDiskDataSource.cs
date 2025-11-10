using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_region_disk.
/// </summary>
public class GoogleComputeRegionDiskDataSource : TerraformDataSource
{
    public GoogleComputeRegionDiskDataSource(string name) : base("google_compute_region_disk", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// A reference to the region where the disk resides.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The access mode of the disk.
    /// For example:
    ///   * READ_WRITE_SINGLE: The default AccessMode, means the disk can be attached to single instance in RW mode.
    ///   * READ_WRITE_MANY: The AccessMode means the disk can be attached to multiple instances in RW mode.
    ///   * READ_ONLY_SINGLE: The AccessMode means the disk can be attached to multiple instances in RO mode.
    /// The AccessMode is only valid for Hyperdisk disk types.
    /// </summary>
    [TerraformPropertyName("access_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_mode");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformPropertyName("async_primary_disk")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AsyncPrimaryDisk => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "async_primary_disk");

    /// <summary>
    /// If set to true, a snapshot of the disk will be created before it is destroyed.
    /// If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation.
    /// The name of the snapshot by default will be &#39;{{disk-name}}-YYYYMMDD-HHmm&#39;
    /// </summary>
    [TerraformPropertyName("create_snapshot_before_destroy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> CreateSnapshotBeforeDestroy => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "create_snapshot_before_destroy");

    /// <summary>
    /// This will set a custom name prefix for the snapshot that&#39;s created when the disk is deleted.
    /// </summary>
    [TerraformPropertyName("create_snapshot_before_destroy_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateSnapshotBeforeDestroyPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_snapshot_before_destroy_prefix");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Encrypts the disk using a customer-supplied encryption key.
    /// 
    /// After you encrypt a disk with a customer-supplied key, you must
    /// provide the same key if you use the disk later (e.g. to create a disk
    /// snapshot or an image, or to attach the disk to a virtual machine).
    /// 
    /// Customer-supplied encryption keys do not protect access to metadata of
    /// the disk.
    /// 
    /// If you do not provide an encryption key when creating the disk, then
    /// the disk will be encrypted using an automatically generated key and
    /// you do not need to provide a key to use the disk later.
    /// </summary>
    [TerraformPropertyName("disk_encryption_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DiskEncryptionKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "disk_encryption_key");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("disk_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_id");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// A list of features to enable on the guest operating system.
    /// Applicable only for bootable disks.
    /// </summary>
    [TerraformPropertyName("guest_os_features")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> GuestOsFeatures => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "guest_os_features");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LabelFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label_fingerprint");

    /// <summary>
    /// Labels to apply to this disk.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// Last attach timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("last_attach_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastAttachTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_attach_timestamp");

    /// <summary>
    /// Last detach timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("last_detach_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastDetachTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_detach_timestamp");

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    [TerraformPropertyName("licenses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Licenses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "licenses");

    /// <summary>
    /// Physical block size of the persistent disk, in bytes. If not present
    /// in a request, a default value is used. Currently supported sizes
    /// are 4096 and 16384, other sizes may be added in the future.
    /// If an unsupported value is requested, the error message will list
    /// the supported values for the caller&#39;s project.
    /// </summary>
    [TerraformPropertyName("physical_block_size_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PhysicalBlockSizeBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "physical_block_size_bytes");

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second
    /// that the disk can handle. Values must be between 10,000 and 120,000.
    /// For more details, see the Extreme persistent disk [documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk).
    /// </summary>
    [TerraformPropertyName("provisioned_iops")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ProvisionedIops => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "provisioned_iops");

    /// <summary>
    /// Indicates how much throughput to provision for the disk. This sets the number of throughput
    /// mb per second that the disk can handle. Values must be greater than or equal to 1.
    /// </summary>
    [TerraformPropertyName("provisioned_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ProvisionedThroughput => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "provisioned_throughput");

    /// <summary>
    /// URLs of the zones where the disk should be replicated to.
    /// </summary>
    [TerraformPropertyName("replica_zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ReplicaZones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "replica_zones");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

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
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Size => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "size");

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
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Snapshot => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "snapshot");

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
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceDisk => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_disk");

    /// <summary>
    /// The ID value of the disk used to create this image. This value may
    /// be used to determine whether the image was taken from the current
    /// or a previous instance of a given disk name.
    /// </summary>
    [TerraformPropertyName("source_disk_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceDiskId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_disk_id");

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required
    /// if the source snapshot is protected by a customer-supplied encryption
    /// key.
    /// </summary>
    [TerraformPropertyName("source_snapshot_encryption_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SourceSnapshotEncryptionKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "source_snapshot_encryption_key");

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
    public TerraformProperty<TerraformProperty<string>> SourceSnapshotId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_snapshot_id");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// URL of the disk type resource describing which disk type to use to
    /// create the disk. Provide this when creating the disk.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// Links to the users of the disk (attached instances) in form:
    /// project/zones/zone/instances/instance
    /// </summary>
    [TerraformPropertyName("users")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Users => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "users");

}
