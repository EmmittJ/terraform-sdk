using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for guest_os_features in GoogleComputeImage.
/// Nesting mode: set
/// </summary>
public class GoogleComputeImageGuestOsFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guest_os_features";

    /// <summary>
    /// The type of supported feature. Read [Enabling guest operating system features](https://cloud.google.com/compute/docs/images/create-delete-deprecate-private-images#guest-os-features) to see a list of available options. Possible values: [&amp;quot;MULTI_IP_SUBNET&amp;quot;, &amp;quot;SECURE_BOOT&amp;quot;, &amp;quot;SEV_CAPABLE&amp;quot;, &amp;quot;UEFI_COMPATIBLE&amp;quot;, &amp;quot;VIRTIO_SCSI_MULTIQUEUE&amp;quot;, &amp;quot;WINDOWS&amp;quot;, &amp;quot;GVNIC&amp;quot;, &amp;quot;IDPF&amp;quot;, &amp;quot;SEV_LIVE_MIGRATABLE&amp;quot;, &amp;quot;SEV_SNP_CAPABLE&amp;quot;, &amp;quot;SUSPEND_RESUME_COMPATIBLE&amp;quot;, &amp;quot;TDX_CAPABLE&amp;quot;, &amp;quot;SEV_LIVE_MIGRATABLE_V2&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for image_encryption_key in GoogleComputeImage.
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageImageEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_encryption_key";

    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud
    /// KMS.
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => GetArgument<TerraformValue<string>>("raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => GetArgument<TerraformValue<string>>("rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

}


/// <summary>
/// Block type for raw_disk in GoogleComputeImage.
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageRawDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "raw_disk";

    /// <summary>
    /// The format used to encode and transmit the block device, which
    /// should be TAR. This is just a container and transmission format
    /// and not a runtime format. Provided by the client when the disk
    /// image is created. Default value: &amp;quot;TAR&amp;quot; Possible values: [&amp;quot;TAR&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ContainerType
    {
        get => GetArgument<TerraformValue<string>>("container_type");
        set => SetArgument("container_type", value);
    }

    /// <summary>
    /// An optional SHA1 checksum of the disk image before unpackaging.
    /// This is provided by the client when the disk image is created.
    /// </summary>
    public TerraformValue<string>? Sha1
    {
        get => GetArgument<TerraformValue<string>>("sha1");
        set => SetArgument("sha1", value);
    }

    /// <summary>
    /// The full Google Cloud Storage URL where disk storage is stored
    /// You must provide either this property or the sourceDisk property
    /// but not both.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for shielded_instance_initial_state in GoogleComputeImage.
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageShieldedInstanceInitialStateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_initial_state";

    /// <summary>
    /// Dbs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeImageShieldedInstanceInitialStateBlockDbsBlock>? Dbs
    {
        get => GetArgument<TerraformList<GoogleComputeImageShieldedInstanceInitialStateBlockDbsBlock>>("dbs");
        set => SetArgument("dbs", value);
    }

    /// <summary>
    /// Dbxs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeImageShieldedInstanceInitialStateBlockDbxsBlock>? Dbxs
    {
        get => GetArgument<TerraformList<GoogleComputeImageShieldedInstanceInitialStateBlockDbxsBlock>>("dbxs");
        set => SetArgument("dbxs", value);
    }

    /// <summary>
    /// Keks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeImageShieldedInstanceInitialStateBlockKeksBlock>? Keks
    {
        get => GetArgument<TerraformList<GoogleComputeImageShieldedInstanceInitialStateBlockKeksBlock>>("keks");
        set => SetArgument("keks", value);
    }

    /// <summary>
    /// Pk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pk block(s) allowed")]
    public TerraformList<GoogleComputeImageShieldedInstanceInitialStateBlockPkBlock>? Pk
    {
        get => GetArgument<TerraformList<GoogleComputeImageShieldedInstanceInitialStateBlockPkBlock>>("pk");
        set => SetArgument("pk", value);
    }

}

/// <summary>
/// Block type for dbs in GoogleComputeImageShieldedInstanceInitialStateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageShieldedInstanceInitialStateBlockDbsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dbs";

    /// <summary>
    /// The raw content in the secure keys file.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The file type of source file.
    /// </summary>
    public TerraformValue<string>? FileType
    {
        get => GetArgument<TerraformValue<string>>("file_type");
        set => SetArgument("file_type", value);
    }

}

/// <summary>
/// Block type for dbxs in GoogleComputeImageShieldedInstanceInitialStateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageShieldedInstanceInitialStateBlockDbxsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dbxs";

    /// <summary>
    /// The raw content in the secure keys file.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The file type of source file.
    /// </summary>
    public TerraformValue<string>? FileType
    {
        get => GetArgument<TerraformValue<string>>("file_type");
        set => SetArgument("file_type", value);
    }

}

/// <summary>
/// Block type for keks in GoogleComputeImageShieldedInstanceInitialStateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageShieldedInstanceInitialStateBlockKeksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "keks";

    /// <summary>
    /// The raw content in the secure keys file.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The file type of source file.
    /// </summary>
    public TerraformValue<string>? FileType
    {
        get => GetArgument<TerraformValue<string>>("file_type");
        set => SetArgument("file_type", value);
    }

}

/// <summary>
/// Block type for pk in GoogleComputeImageShieldedInstanceInitialStateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageShieldedInstanceInitialStateBlockPkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pk";

    /// <summary>
    /// The raw content in the secure keys file.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The file type of source file.
    /// </summary>
    public TerraformValue<string>? FileType
    {
        get => GetArgument<TerraformValue<string>>("file_type");
        set => SetArgument("file_type", value);
    }

}


/// <summary>
/// Block type for source_disk_encryption_key in GoogleComputeImage.
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageSourceDiskEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_disk_encryption_key";

    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => GetArgument<TerraformValue<string>>("raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => GetArgument<TerraformValue<string>>("rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

}


/// <summary>
/// Block type for source_image_encryption_key in GoogleComputeImage.
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageSourceImageEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_image_encryption_key";

    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => GetArgument<TerraformValue<string>>("raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => GetArgument<TerraformValue<string>>("rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

}


/// <summary>
/// Block type for source_snapshot_encryption_key in GoogleComputeImage.
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageSourceSnapshotEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_snapshot_encryption_key";

    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    public TerraformValue<string>? KmsKeyServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("kms_key_service_account");
        set => SetArgument("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformValue<string>? RawKey
    {
        get => GetArgument<TerraformValue<string>>("raw_key");
        set => SetArgument("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => GetArgument<TerraformValue<string>>("rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeImage.
/// Nesting mode: single
/// </summary>
public class GoogleComputeImageTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_image Terraform resource.
/// Manages a google_compute_image resource.
/// </summary>
public partial class GoogleComputeImage(string name) : TerraformResource("google_compute_image", name)
{
    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Size of the image when restored onto a persistent disk (in GB).
    /// </summary>
    public TerraformValue<double>? DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The name of the image family to which this image belongs. You can
    /// create disks by specifying an image family instead of a specific
    /// image name. The image family always returns its latest image that is
    /// not deprecated. The name of the image family must comply with
    /// RFC1035.
    /// </summary>
    public TerraformValue<string>? Family
    {
        get => GetArgument<TerraformValue<string>>("family");
        set => SetArgument("family", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels to apply to this Image.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    public TerraformList<string>? Licenses
    {
        get => GetArgument<TerraformList<string>>("licenses");
        set => SetArgument("licenses", value);
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
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
    /// The source disk to create this image based on.
    /// You must provide either this property or the
    /// rawDisk.source property but not both to create an image.
    /// </summary>
    public TerraformValue<string>? SourceDisk
    {
        get => GetArgument<TerraformValue<string>>("source_disk");
        set => SetArgument("source_disk", value);
    }

    /// <summary>
    /// URL of the source image used to create this image. In order to create an image, you must provide the full or partial
    /// URL of one of the following:
    /// 
    /// * The selfLink URL
    /// * This property
    /// * The rawDisk.source URL
    /// * The sourceDisk URL
    /// </summary>
    public TerraformValue<string>? SourceImage
    {
        get => GetArgument<TerraformValue<string>>("source_image");
        set => SetArgument("source_image", value);
    }

    /// <summary>
    /// URL of the source snapshot used to create this image.
    /// 
    /// In order to create an image, you must provide the full or partial URL of one of the following:
    /// 
    /// * The selfLink URL
    /// * This property
    /// * The sourceImage URL
    /// * The rawDisk.source URL
    /// * The sourceDisk URL
    /// </summary>
    public TerraformValue<string>? SourceSnapshot
    {
        get => GetArgument<TerraformValue<string>>("source_snapshot");
        set => SetArgument("source_snapshot", value);
    }

    /// <summary>
    /// Cloud Storage bucket storage location of the image
    /// (regional or multi-regional).
    /// Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images
    /// </summary>
    public TerraformList<string>? StorageLocations
    {
        get => GetArgument<TerraformList<string>>("storage_locations");
        set => SetArgument("storage_locations", value);
    }

    /// <summary>
    /// Size of the image tar.gz archive stored in Google Cloud Storage (in
    /// bytes).
    /// </summary>
    public TerraformValue<double> ArchiveSizeBytes
        => AsReference("archive_size_bytes");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource. Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => AsReference("label_fingerprint");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// GuestOsFeatures block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeImageGuestOsFeaturesBlock>? GuestOsFeatures
    {
        get => GetArgument<TerraformSet<GoogleComputeImageGuestOsFeaturesBlock>>("guest_os_features");
        set => SetArgument("guest_os_features", value);
    }

    /// <summary>
    /// ImageEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeImageImageEncryptionKeyBlock>? ImageEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeImageImageEncryptionKeyBlock>>("image_encryption_key");
        set => SetArgument("image_encryption_key", value);
    }

    /// <summary>
    /// RawDisk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RawDisk block(s) allowed")]
    public TerraformList<GoogleComputeImageRawDiskBlock>? RawDisk
    {
        get => GetArgument<TerraformList<GoogleComputeImageRawDiskBlock>>("raw_disk");
        set => SetArgument("raw_disk", value);
    }

    /// <summary>
    /// ShieldedInstanceInitialState block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceInitialState block(s) allowed")]
    public TerraformList<GoogleComputeImageShieldedInstanceInitialStateBlock>? ShieldedInstanceInitialState
    {
        get => GetArgument<TerraformList<GoogleComputeImageShieldedInstanceInitialStateBlock>>("shielded_instance_initial_state");
        set => SetArgument("shielded_instance_initial_state", value);
    }

    /// <summary>
    /// SourceDiskEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceDiskEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeImageSourceDiskEncryptionKeyBlock>? SourceDiskEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeImageSourceDiskEncryptionKeyBlock>>("source_disk_encryption_key");
        set => SetArgument("source_disk_encryption_key", value);
    }

    /// <summary>
    /// SourceImageEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeImageSourceImageEncryptionKeyBlock>? SourceImageEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeImageSourceImageEncryptionKeyBlock>>("source_image_encryption_key");
        set => SetArgument("source_image_encryption_key", value);
    }

    /// <summary>
    /// SourceSnapshotEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSnapshotEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeImageSourceSnapshotEncryptionKeyBlock>? SourceSnapshotEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeImageSourceSnapshotEncryptionKeyBlock>>("source_snapshot_encryption_key");
        set => SetArgument("source_snapshot_encryption_key", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeImageTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeImageTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
