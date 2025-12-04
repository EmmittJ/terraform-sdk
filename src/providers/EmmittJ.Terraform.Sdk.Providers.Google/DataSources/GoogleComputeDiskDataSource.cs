using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_disk Terraform data source.
/// Retrieves information about a google_compute_disk.
/// </summary>
public partial class GoogleComputeDiskDataSource(string name) : TerraformDataSource("google_compute_disk", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A reference to the zone where the disk resides.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The access mode of the disk.
    /// For example:
    ///   * READ_WRITE_SINGLE: The default AccessMode, means the disk can be attached to single instance in RW mode.
    ///   * READ_WRITE_MANY: The AccessMode means the disk can be attached to multiple instances in RW mode.
    ///   * READ_ONLY_SINGLE: The AccessMode means the disk can be attached to multiple instances in RO mode.
    /// The AccessMode is only valid for Hyperdisk disk types.
    /// </summary>
    public TerraformValue<string> AccessMode
        => AsReference("access_mode");

    /// <summary>
    /// The architecture of the disk. Values include &#39;X86_64&#39;, &#39;ARM64&#39;.
    /// </summary>
    public TerraformValue<string> Architecture
        => AsReference("architecture");

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> AsyncPrimaryDisk
        => AsReference("async_primary_disk");

    /// <summary>
    /// If set to true, a snapshot of the disk will be created before it is destroyed.
    /// If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation.
    /// The name of the snapshot by default will be &#39;{{disk-name}}-YYYYMMDD-HHmm&#39;
    /// </summary>
    public TerraformValue<bool> CreateSnapshotBeforeDestroy
        => AsReference("create_snapshot_before_destroy");

    /// <summary>
    /// This will set a custom name prefix for the snapshot that&#39;s created when the disk is deleted.
    /// </summary>
    public TerraformValue<string> CreateSnapshotBeforeDestroyPrefix
        => AsReference("create_snapshot_before_destroy_prefix");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

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
    public TerraformList<TerraformMap<object>> DiskEncryptionKey
        => AsReference("disk_encryption_key");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<string> DiskId
        => AsReference("disk_id");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Whether this disk is using confidential compute mode.
    /// Note: Only supported on hyperdisk skus, disk_encryption_key is required when setting to true
    /// </summary>
    public TerraformValue<bool> EnableConfidentialCompute
        => AsReference("enable_confidential_compute");

    /// <summary>
    /// A list of features to enable on the guest operating system.
    /// Applicable only for bootable disks.
    /// </summary>
    public TerraformSet<TerraformMap<object>> GuestOsFeatures
        => AsReference("guest_os_features");

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
    public TerraformValue<string> Image
        => AsReference("image");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => AsReference("label_fingerprint");

    /// <summary>
    /// Labels to apply to this disk.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
        => AsReference("labels");

    /// <summary>
    /// Last attach timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> LastAttachTimestamp
        => AsReference("last_attach_timestamp");

    /// <summary>
    /// Last detach timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> LastDetachTimestamp
        => AsReference("last_detach_timestamp");

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    public TerraformList<string> Licenses
        => AsReference("licenses");

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// </summary>
    public TerraformList<TerraformMap<object>> ParamsAttribute
        => AsReference("params");

    /// <summary>
    /// Physical block size of the persistent disk, in bytes. If not present
    /// in a request, a default value is used. Currently supported sizes
    /// are 4096 and 16384, other sizes may be added in the future.
    /// If an unsupported value is requested, the error message will list
    /// the supported values for the caller&#39;s project.
    /// </summary>
    public TerraformValue<double> PhysicalBlockSizeBytes
        => AsReference("physical_block_size_bytes");

    /// <summary>
    /// Indicates how many IOPS must be provisioned for the disk.
    /// Note: Updating currently is only supported by hyperdisk skus without the need to delete and recreate the disk, hyperdisk
    /// allows for an update of IOPS every 4 hours. To update your hyperdisk more frequently, you&#39;ll need to manually delete and recreate it
    /// </summary>
    public TerraformValue<double> ProvisionedIops
        => AsReference("provisioned_iops");

    /// <summary>
    /// Indicates how much Throughput must be provisioned for the disk.
    /// Note: Updating currently is only supported by hyperdisk skus without the need to delete and recreate the disk, hyperdisk
    /// allows for an update of Throughput every 4 hours. To update your hyperdisk more frequently, you&#39;ll need to manually delete and recreate it
    /// </summary>
    public TerraformValue<double> ProvisionedThroughput
        => AsReference("provisioned_throughput");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

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
    public TerraformValue<double> Size
        => AsReference("size");

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
    public TerraformValue<string> Snapshot
        => AsReference("snapshot");

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
    public TerraformValue<string> SourceDisk
        => AsReference("source_disk");

    /// <summary>
    /// The ID value of the disk used to create this image. This value may
    /// be used to determine whether the image was taken from the current
    /// or a previous instance of a given disk name.
    /// </summary>
    public TerraformValue<string> SourceDiskId
        => AsReference("source_disk_id");

    /// <summary>
    /// The customer-supplied encryption key of the source image. Required if
    /// the source image is protected by a customer-supplied encryption key.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceImageEncryptionKey
        => AsReference("source_image_encryption_key");

    /// <summary>
    /// The ID value of the image used to create this disk. This value
    /// identifies the exact image that was used to create this persistent
    /// disk. For example, if you created the persistent disk from an image
    /// that was later deleted and recreated under the same name, the source
    /// image ID would identify the exact version of the image that was used.
    /// </summary>
    public TerraformValue<string> SourceImageId
        => AsReference("source_image_id");

    /// <summary>
    /// The source instant snapshot used to create this disk. You can provide this as a partial or full URL to the resource.
    /// For example, the following are valid values:
    /// 
    /// * &#39;https://www.googleapis.com/compute/v1/projects/project/zones/zone/instantSnapshots/instantSnapshot&#39;
    /// * &#39;projects/project/zones/zone/instantSnapshots/instantSnapshot&#39;
    /// * &#39;zones/zone/instantSnapshots/instantSnapshot&#39;
    /// </summary>
    public TerraformValue<string> SourceInstantSnapshot
        => AsReference("source_instant_snapshot");

    /// <summary>
    /// The unique ID of the instant snapshot used to create this disk. This value identifies
    /// the exact instant snapshot that was used to create this persistent disk.
    /// For example, if you created the persistent disk from an instant snapshot that was later
    /// deleted and recreated under the same name, the source instant snapshot ID would identify
    /// the exact version of the instant snapshot that was used.
    /// </summary>
    public TerraformValue<string> SourceInstantSnapshotId
        => AsReference("source_instant_snapshot_id");

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required
    /// if the source snapshot is protected by a customer-supplied encryption
    /// key.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceSnapshotEncryptionKey
        => AsReference("source_snapshot_encryption_key");

    /// <summary>
    /// The unique ID of the snapshot used to create this disk. This value
    /// identifies the exact snapshot that was used to create this persistent
    /// disk. For example, if you created the persistent disk from a snapshot
    /// that was later deleted and recreated under the same name, the source
    /// snapshot ID would identify the exact version of the snapshot that was
    /// used.
    /// </summary>
    public TerraformValue<string> SourceSnapshotId
        => AsReference("source_snapshot_id");

    /// <summary>
    /// The full Google Cloud Storage URI where the disk image is stored.
    /// This file must be a gzip-compressed tarball whose name ends in .tar.gz or virtual machine disk whose name ends in vmdk.
    /// Valid URIs may start with gs:// or https://storage.googleapis.com/.
    /// This flag is not optimized for creating multiple disks from a source storage object.
    /// To create many disks from a source storage object, use gcloud compute images import instead.
    /// </summary>
    public TerraformValue<string> SourceStorageObject
        => AsReference("source_storage_object");

    /// <summary>
    /// The URL or the name of the storage pool in which the new disk is created.
    /// For example:
    /// * https://www.googleapis.com/compute/v1/projects/{project}/zones/{zone}/storagePools/{storagePool}
    /// * /projects/{project}/zones/{zone}/storagePools/{storagePool}
    /// * /zones/{zone}/storagePools/{storagePool}
    /// * /{storagePool}
    /// </summary>
    public TerraformValue<string> StoragePool
        => AsReference("storage_pool");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// URL of the disk type resource describing which disk type to use to
    /// create the disk. Provide this when creating the disk.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Links to the users of the disk (attached instances) in form:
    /// project/zones/zone/instances/instance
    /// </summary>
    public TerraformList<string> Users
        => AsReference("users");

}
