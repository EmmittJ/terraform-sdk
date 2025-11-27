using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for async_primary_disk in GoogleComputeDisk.
/// Nesting mode: list
/// </summary>
public class GoogleComputeDiskAsyncPrimaryDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "async_primary_disk";

    /// <summary>
    /// Primary disk for asynchronous disk replication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    public required TerraformValue<string> Disk
    {
        get => new TerraformReference<string>(this, "disk");
        set => SetArgument("disk", value);
    }

}


/// <summary>
/// Block type for disk_encryption_key in GoogleComputeDisk.
/// Nesting mode: list
/// </summary>
public class GoogleComputeDiskDiskEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_encryption_key";

    /// <summary>
    /// The self link of the encryption key used to encrypt the disk. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => new TerraformReference<string>(this, "kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => new TerraformReference<string>(this, "kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => new TerraformReference<string>(this, "raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => new TerraformReference<string>(this, "rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied
    /// encryption key that protects this resource.
    /// </summary>
    public TerraformValue<string> Sha256
    {
        get => new TerraformReference<string>(this, "sha256");
    }

}


/// <summary>
/// Block type for guest_os_features in GoogleComputeDisk.
/// Nesting mode: set
/// </summary>
public class GoogleComputeDiskGuestOsFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guest_os_features";

    /// <summary>
    /// The type of supported feature. Read [Enabling guest operating system features](https://cloud.google.com/compute/docs/images/create-delete-deprecate-private-images#guest-os-features) to see a list of available options.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for params in GoogleComputeDisk.
/// Nesting mode: list
/// </summary>
public class GoogleComputeDiskParamsAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "params";

    /// <summary>
    /// Resource manager tags to be bound to the disk. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_manager_tags").ResolveNodes(ctx));
        set => SetArgument("resource_manager_tags", value);
    }

}


/// <summary>
/// Block type for source_image_encryption_key in GoogleComputeDisk.
/// Nesting mode: list
/// </summary>
public class GoogleComputeDiskSourceImageEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_image_encryption_key";

    /// <summary>
    /// The self link of the encryption key used to encrypt the disk. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => new TerraformReference<string>(this, "kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => new TerraformReference<string>(this, "kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => new TerraformReference<string>(this, "raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied
    /// encryption key that protects this resource.
    /// </summary>
    public TerraformValue<string> Sha256
    {
        get => new TerraformReference<string>(this, "sha256");
    }

}


/// <summary>
/// Block type for source_snapshot_encryption_key in GoogleComputeDisk.
/// Nesting mode: list
/// </summary>
public class GoogleComputeDiskSourceSnapshotEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_snapshot_encryption_key";

    /// <summary>
    /// The self link of the encryption key used to encrypt the disk. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => new TerraformReference<string>(this, "kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => new TerraformReference<string>(this, "kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => new TerraformReference<string>(this, "raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied
    /// encryption key that protects this resource.
    /// </summary>
    public TerraformValue<string> Sha256
    {
        get => new TerraformReference<string>(this, "sha256");
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeDisk.
/// Nesting mode: single
/// </summary>
public class GoogleComputeDiskTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_disk Terraform resource.
/// Manages a google_compute_disk resource.
/// </summary>
public partial class GoogleComputeDisk(string name) : TerraformResource("google_compute_disk", name)
{
    /// <summary>
    /// The access mode of the disk.
    /// For example:
    ///   * READ_WRITE_SINGLE: The default AccessMode, means the disk can be attached to single instance in RW mode.
    ///   * READ_WRITE_MANY: The AccessMode means the disk can be attached to multiple instances in RW mode.
    ///   * READ_ONLY_SINGLE: The AccessMode means the disk can be attached to multiple instances in RO mode.
    /// The AccessMode is only valid for Hyperdisk disk types.
    /// </summary>
    public TerraformValue<string> AccessMode
    {
        get => new TerraformReference<string>(this, "access_mode");
        set => SetArgument("access_mode", value);
    }

    /// <summary>
    /// The architecture of the disk. Values include &#39;X86_64&#39;, &#39;ARM64&#39;.
    /// </summary>
    public TerraformValue<string>? Architecture
    {
        get => new TerraformReference<string>(this, "architecture");
        set => SetArgument("architecture", value);
    }

    /// <summary>
    /// If set to true, a snapshot of the disk will be created before it is destroyed.
    /// If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation.
    /// The name of the snapshot by default will be &#39;{{disk-name}}-YYYYMMDD-HHmm&#39;
    /// </summary>
    public TerraformValue<bool>? CreateSnapshotBeforeDestroy
    {
        get => new TerraformReference<bool>(this, "create_snapshot_before_destroy");
        set => SetArgument("create_snapshot_before_destroy", value);
    }

    /// <summary>
    /// This will set a custom name prefix for the snapshot that&#39;s created when the disk is deleted.
    /// </summary>
    public TerraformValue<string>? CreateSnapshotBeforeDestroyPrefix
    {
        get => new TerraformReference<string>(this, "create_snapshot_before_destroy_prefix");
        set => SetArgument("create_snapshot_before_destroy_prefix", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Whether this disk is using confidential compute mode.
    /// Note: Only supported on hyperdisk skus, disk_encryption_key is required when setting to true
    /// </summary>
    public TerraformValue<bool> EnableConfidentialCompute
    {
        get => new TerraformReference<bool>(this, "enable_confidential_compute");
        set => SetArgument("enable_confidential_compute", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

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
    public TerraformValue<string>? Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// Labels to apply to this disk.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    public TerraformList<string> Licenses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "licenses").ResolveNodes(ctx));
        set => SetArgument("licenses", value);
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Physical block size of the persistent disk, in bytes. If not present
    /// in a request, a default value is used. Currently supported sizes
    /// are 4096 and 16384, other sizes may be added in the future.
    /// If an unsupported value is requested, the error message will list
    /// the supported values for the caller&#39;s project.
    /// </summary>
    public TerraformValue<double> PhysicalBlockSizeBytes
    {
        get => new TerraformReference<double>(this, "physical_block_size_bytes");
        set => SetArgument("physical_block_size_bytes", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Indicates how many IOPS must be provisioned for the disk.
    /// Note: Updating currently is only supported by hyperdisk skus without the need to delete and recreate the disk, hyperdisk
    /// allows for an update of IOPS every 4 hours. To update your hyperdisk more frequently, you&#39;ll need to manually delete and recreate it
    /// </summary>
    public TerraformValue<double> ProvisionedIops
    {
        get => new TerraformReference<double>(this, "provisioned_iops");
        set => SetArgument("provisioned_iops", value);
    }

    /// <summary>
    /// Indicates how much Throughput must be provisioned for the disk.
    /// Note: Updating currently is only supported by hyperdisk skus without the need to delete and recreate the disk, hyperdisk
    /// allows for an update of Throughput every 4 hours. To update your hyperdisk more frequently, you&#39;ll need to manually delete and recreate it
    /// </summary>
    public TerraformValue<double> ProvisionedThroughput
    {
        get => new TerraformReference<double>(this, "provisioned_throughput");
        set => SetArgument("provisioned_throughput", value);
    }

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
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
    }

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
    public TerraformValue<string>? Snapshot
    {
        get => new TerraformReference<string>(this, "snapshot");
        set => SetArgument("snapshot", value);
    }

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
    public TerraformValue<string>? SourceDisk
    {
        get => new TerraformReference<string>(this, "source_disk");
        set => SetArgument("source_disk", value);
    }

    /// <summary>
    /// The source instant snapshot used to create this disk. You can provide this as a partial or full URL to the resource.
    /// For example, the following are valid values:
    /// 
    /// * &#39;https://www.googleapis.com/compute/v1/projects/project/zones/zone/instantSnapshots/instantSnapshot&#39;
    /// * &#39;projects/project/zones/zone/instantSnapshots/instantSnapshot&#39;
    /// * &#39;zones/zone/instantSnapshots/instantSnapshot&#39;
    /// </summary>
    public TerraformValue<string>? SourceInstantSnapshot
    {
        get => new TerraformReference<string>(this, "source_instant_snapshot");
        set => SetArgument("source_instant_snapshot", value);
    }

    /// <summary>
    /// The full Google Cloud Storage URI where the disk image is stored.
    /// This file must be a gzip-compressed tarball whose name ends in .tar.gz or virtual machine disk whose name ends in vmdk.
    /// Valid URIs may start with gs:// or https://storage.googleapis.com/.
    /// This flag is not optimized for creating multiple disks from a source storage object.
    /// To create many disks from a source storage object, use gcloud compute images import instead.
    /// </summary>
    public TerraformValue<string>? SourceStorageObject
    {
        get => new TerraformReference<string>(this, "source_storage_object");
        set => SetArgument("source_storage_object", value);
    }

    /// <summary>
    /// The URL or the name of the storage pool in which the new disk is created.
    /// For example:
    /// * https://www.googleapis.com/compute/v1/projects/{project}/zones/{zone}/storagePools/{storagePool}
    /// * /projects/{project}/zones/{zone}/storagePools/{storagePool}
    /// * /zones/{zone}/storagePools/{storagePool}
    /// * /{storagePool}
    /// </summary>
    public TerraformValue<string>? StoragePool
    {
        get => new TerraformReference<string>(this, "storage_pool");
        set => SetArgument("storage_pool", value);
    }

    /// <summary>
    /// URL of the disk type resource describing which disk type to use to
    /// create the disk. Provide this when creating the disk.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// A reference to the zone where the disk resides.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<string> DiskId
    {
        get => new TerraformReference<string>(this, "disk_id");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
    {
        get => new TerraformReference<string>(this, "label_fingerprint");
    }

    /// <summary>
    /// Last attach timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> LastAttachTimestamp
    {
        get => new TerraformReference<string>(this, "last_attach_timestamp");
    }

    /// <summary>
    /// Last detach timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> LastDetachTimestamp
    {
        get => new TerraformReference<string>(this, "last_detach_timestamp");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The ID value of the disk used to create this image. This value may
    /// be used to determine whether the image was taken from the current
    /// or a previous instance of a given disk name.
    /// </summary>
    public TerraformValue<string> SourceDiskId
    {
        get => new TerraformReference<string>(this, "source_disk_id");
    }

    /// <summary>
    /// The ID value of the image used to create this disk. This value
    /// identifies the exact image that was used to create this persistent
    /// disk. For example, if you created the persistent disk from an image
    /// that was later deleted and recreated under the same name, the source
    /// image ID would identify the exact version of the image that was used.
    /// </summary>
    public TerraformValue<string> SourceImageId
    {
        get => new TerraformReference<string>(this, "source_image_id");
    }

    /// <summary>
    /// The unique ID of the instant snapshot used to create this disk. This value identifies
    /// the exact instant snapshot that was used to create this persistent disk.
    /// For example, if you created the persistent disk from an instant snapshot that was later
    /// deleted and recreated under the same name, the source instant snapshot ID would identify
    /// the exact version of the instant snapshot that was used.
    /// </summary>
    public TerraformValue<string> SourceInstantSnapshotId
    {
        get => new TerraformReference<string>(this, "source_instant_snapshot_id");
    }

    /// <summary>
    /// The unique ID of the snapshot used to create this disk. This value
    /// identifies the exact snapshot that was used to create this persistent
    /// disk. For example, if you created the persistent disk from a snapshot
    /// that was later deleted and recreated under the same name, the source
    /// snapshot ID would identify the exact version of the snapshot that was
    /// used.
    /// </summary>
    public TerraformValue<string> SourceSnapshotId
    {
        get => new TerraformReference<string>(this, "source_snapshot_id");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Links to the users of the disk (attached instances) in form:
    /// project/zones/zone/instances/instance
    /// </summary>
    public TerraformList<string> Users
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "users").ResolveNodes(ctx));
    }

    /// <summary>
    /// AsyncPrimaryDisk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AsyncPrimaryDisk block(s) allowed")]
    public TerraformList<GoogleComputeDiskAsyncPrimaryDiskBlock>? AsyncPrimaryDisk
    {
        get => GetArgument<TerraformList<GoogleComputeDiskAsyncPrimaryDiskBlock>>("async_primary_disk");
        set => SetArgument("async_primary_disk", value);
    }

    /// <summary>
    /// DiskEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeDiskDiskEncryptionKeyBlock>? DiskEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeDiskDiskEncryptionKeyBlock>>("disk_encryption_key");
        set => SetArgument("disk_encryption_key", value);
    }

    /// <summary>
    /// GuestOsFeatures block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeDiskGuestOsFeaturesBlock>? GuestOsFeatures
    {
        get => GetArgument<TerraformSet<GoogleComputeDiskGuestOsFeaturesBlock>>("guest_os_features");
        set => SetArgument("guest_os_features", value);
    }

    /// <summary>
    /// ParamsAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParamsAttribute block(s) allowed")]
    public TerraformList<GoogleComputeDiskParamsAttributeBlock>? ParamsAttribute
    {
        get => GetArgument<TerraformList<GoogleComputeDiskParamsAttributeBlock>>("params");
        set => SetArgument("params", value);
    }

    /// <summary>
    /// SourceImageEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeDiskSourceImageEncryptionKeyBlock>? SourceImageEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeDiskSourceImageEncryptionKeyBlock>>("source_image_encryption_key");
        set => SetArgument("source_image_encryption_key", value);
    }

    /// <summary>
    /// SourceSnapshotEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSnapshotEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeDiskSourceSnapshotEncryptionKeyBlock>? SourceSnapshotEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeDiskSourceSnapshotEncryptionKeyBlock>>("source_snapshot_encryption_key");
        set => SetArgument("source_snapshot_encryption_key", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeDiskTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeDiskTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
