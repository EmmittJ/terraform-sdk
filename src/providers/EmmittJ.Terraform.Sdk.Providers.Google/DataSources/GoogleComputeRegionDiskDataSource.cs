using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_region_disk.
/// </summary>
public class GoogleComputeRegionDiskDataSource : TerraformDataSource
{
    public GoogleComputeRegionDiskDataSource(string name) : base("google_compute_region_disk", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_mode");
        SetOutput("async_primary_disk");
        SetOutput("create_snapshot_before_destroy");
        SetOutput("create_snapshot_before_destroy_prefix");
        SetOutput("creation_timestamp");
        SetOutput("description");
        SetOutput("disk_encryption_key");
        SetOutput("disk_id");
        SetOutput("effective_labels");
        SetOutput("guest_os_features");
        SetOutput("label_fingerprint");
        SetOutput("labels");
        SetOutput("last_attach_timestamp");
        SetOutput("last_detach_timestamp");
        SetOutput("licenses");
        SetOutput("physical_block_size_bytes");
        SetOutput("provisioned_iops");
        SetOutput("provisioned_throughput");
        SetOutput("replica_zones");
        SetOutput("self_link");
        SetOutput("size");
        SetOutput("snapshot");
        SetOutput("source_disk");
        SetOutput("source_disk_id");
        SetOutput("source_snapshot_encryption_key");
        SetOutput("source_snapshot_id");
        SetOutput("terraform_labels");
        SetOutput("type");
        SetOutput("users");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

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
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// A reference to the region where the disk resides.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The access mode of the disk.
    /// For example:
    ///   * READ_WRITE_SINGLE: The default AccessMode, means the disk can be attached to single instance in RW mode.
    ///   * READ_WRITE_MANY: The AccessMode means the disk can be attached to multiple instances in RW mode.
    ///   * READ_ONLY_SINGLE: The AccessMode means the disk can be attached to multiple instances in RO mode.
    /// The AccessMode is only valid for Hyperdisk disk types.
    /// </summary>
    public TerraformExpression AccessMode => this["access_mode"];

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformExpression AsyncPrimaryDisk => this["async_primary_disk"];

    /// <summary>
    /// If set to true, a snapshot of the disk will be created before it is destroyed.
    /// If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation.
    /// The name of the snapshot by default will be &#39;{{disk-name}}-YYYYMMDD-HHmm&#39;
    /// </summary>
    public TerraformExpression CreateSnapshotBeforeDestroy => this["create_snapshot_before_destroy"];

    /// <summary>
    /// This will set a custom name prefix for the snapshot that&#39;s created when the disk is deleted.
    /// </summary>
    public TerraformExpression CreateSnapshotBeforeDestroyPrefix => this["create_snapshot_before_destroy_prefix"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformExpression Description => this["description"];

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
    public TerraformExpression DiskEncryptionKey => this["disk_encryption_key"];

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression DiskId => this["disk_id"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// A list of features to enable on the guest operating system.
    /// Applicable only for bootable disks.
    /// </summary>
    public TerraformExpression GuestOsFeatures => this["guest_os_features"];

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// Labels to apply to this disk.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// Last attach timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression LastAttachTimestamp => this["last_attach_timestamp"];

    /// <summary>
    /// Last detach timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression LastDetachTimestamp => this["last_detach_timestamp"];

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    public TerraformExpression Licenses => this["licenses"];

    /// <summary>
    /// Physical block size of the persistent disk, in bytes. If not present
    /// in a request, a default value is used. Currently supported sizes
    /// are 4096 and 16384, other sizes may be added in the future.
    /// If an unsupported value is requested, the error message will list
    /// the supported values for the caller&#39;s project.
    /// </summary>
    public TerraformExpression PhysicalBlockSizeBytes => this["physical_block_size_bytes"];

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second
    /// that the disk can handle. Values must be between 10,000 and 120,000.
    /// For more details, see the Extreme persistent disk [documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk).
    /// </summary>
    public TerraformExpression ProvisionedIops => this["provisioned_iops"];

    /// <summary>
    /// Indicates how much throughput to provision for the disk. This sets the number of throughput
    /// mb per second that the disk can handle. Values must be greater than or equal to 1.
    /// </summary>
    public TerraformExpression ProvisionedThroughput => this["provisioned_throughput"];

    /// <summary>
    /// URLs of the zones where the disk should be replicated to.
    /// </summary>
    public TerraformExpression ReplicaZones => this["replica_zones"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

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
    public TerraformExpression Size => this["size"];

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
    public TerraformExpression Snapshot => this["snapshot"];

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
    public TerraformExpression SourceDisk => this["source_disk"];

    /// <summary>
    /// The ID value of the disk used to create this image. This value may
    /// be used to determine whether the image was taken from the current
    /// or a previous instance of a given disk name.
    /// </summary>
    public TerraformExpression SourceDiskId => this["source_disk_id"];

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required
    /// if the source snapshot is protected by a customer-supplied encryption
    /// key.
    /// </summary>
    public TerraformExpression SourceSnapshotEncryptionKey => this["source_snapshot_encryption_key"];

    /// <summary>
    /// The unique ID of the snapshot used to create this disk. This value
    /// identifies the exact snapshot that was used to create this persistent
    /// disk. For example, if you created the persistent disk from a snapshot
    /// that was later deleted and recreated under the same name, the source
    /// snapshot ID would identify the exact version of the snapshot that was
    /// used.
    /// </summary>
    public TerraformExpression SourceSnapshotId => this["source_snapshot_id"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// URL of the disk type resource describing which disk type to use to
    /// create the disk. Provide this when creating the disk.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// Links to the users of the disk (attached instances) in form:
    /// project/zones/zone/instances/instance
    /// </summary>
    public TerraformExpression Users => this["users"];

}
