using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for guest_os_features in .
/// Nesting mode: set
/// </summary>
public partial class GoogleComputeImageGuestOsFeaturesBlock : TerraformBlockBase
{
    /// <summary>
    /// The type of supported feature. Read [Enabling guest operating system features](https://cloud.google.com/compute/docs/images/create-delete-deprecate-private-images#guest-os-features) to see a list of available options. Possible values: [&amp;quot;MULTI_IP_SUBNET&amp;quot;, &amp;quot;SECURE_BOOT&amp;quot;, &amp;quot;SEV_CAPABLE&amp;quot;, &amp;quot;UEFI_COMPATIBLE&amp;quot;, &amp;quot;VIRTIO_SCSI_MULTIQUEUE&amp;quot;, &amp;quot;WINDOWS&amp;quot;, &amp;quot;GVNIC&amp;quot;, &amp;quot;IDPF&amp;quot;, &amp;quot;SEV_LIVE_MIGRATABLE&amp;quot;, &amp;quot;SEV_SNP_CAPABLE&amp;quot;, &amp;quot;SUSPEND_RESUME_COMPATIBLE&amp;quot;, &amp;quot;TDX_CAPABLE&amp;quot;, &amp;quot;SEV_LIVE_MIGRATABLE_V2&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for image_encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeImageImageEncryptionKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud
    /// KMS.
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
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
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformProperty("rsa_encrypted_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RsaEncryptedKey { get; set; }

}

/// <summary>
/// Block type for raw_disk in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeImageRawDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The format used to encode and transmit the block device, which
    /// should be TAR. This is just a container and transmission format
    /// and not a runtime format. Provided by the client when the disk
    /// image is created. Default value: &amp;quot;TAR&amp;quot; Possible values: [&amp;quot;TAR&amp;quot;]
    /// </summary>
    [TerraformProperty("container_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContainerType { get; set; }

    /// <summary>
    /// An optional SHA1 checksum of the disk image before unpackaging.
    /// This is provided by the client when the disk image is created.
    /// </summary>
    [TerraformProperty("sha1")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Sha1 { get; set; }

    /// <summary>
    /// The full Google Cloud Storage URL where disk storage is stored
    /// You must provide either this property or the sourceDisk property
    /// but not both.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Source { get; set; }

}

/// <summary>
/// Block type for shielded_instance_initial_state in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeImageShieldedInstanceInitialStateBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for source_disk_encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeImageSourceDiskEncryptionKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
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
/// Block type for source_image_encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeImageSourceImageEncryptionKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
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
/// Block type for source_snapshot_encryption_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeImageSourceSnapshotEncryptionKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [TerraformProperty("kms_key_self_link")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeImageTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_compute_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeImage : TerraformResource
{
    public GoogleComputeImage(string name) : base("google_compute_image", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Size of the image when restored onto a persistent disk (in GB).
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The name of the image family to which this image belongs. You can
    /// create disks by specifying an image family instead of a specific
    /// image name. The image family always returns its latest image that is
    /// not deprecated. The name of the image family must comply with
    /// RFC1035.
    /// </summary>
    [TerraformProperty("family")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Family { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels to apply to this Image.
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
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The source disk to create this image based on.
    /// You must provide either this property or the
    /// rawDisk.source property but not both to create an image.
    /// </summary>
    [TerraformProperty("source_disk")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceDisk { get; set; }

    /// <summary>
    /// URL of the source image used to create this image. In order to create an image, you must provide the full or partial
    /// URL of one of the following:
    /// 
    /// * The selfLink URL
    /// * This property
    /// * The rawDisk.source URL
    /// * The sourceDisk URL
    /// </summary>
    [TerraformProperty("source_image")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceImage { get; set; }

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
    [TerraformProperty("source_snapshot")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceSnapshot { get; set; }

    /// <summary>
    /// Cloud Storage bucket storage location of the image
    /// (regional or multi-regional).
    /// Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images
    /// </summary>
    [TerraformProperty("storage_locations")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> StorageLocations { get; set; }

    /// <summary>
    /// Block for guest_os_features.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("guest_os_features")]
    public TerraformSet<TerraformBlock<GoogleComputeImageGuestOsFeaturesBlock>>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Block for image_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageEncryptionKey block(s) allowed")]
    [TerraformProperty("image_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeImageImageEncryptionKeyBlock>>? ImageEncryptionKey { get; set; }

    /// <summary>
    /// Block for raw_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RawDisk block(s) allowed")]
    [TerraformProperty("raw_disk")]
    public TerraformList<TerraformBlock<GoogleComputeImageRawDiskBlock>>? RawDisk { get; set; }

    /// <summary>
    /// Block for shielded_instance_initial_state.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceInitialState block(s) allowed")]
    [TerraformProperty("shielded_instance_initial_state")]
    public TerraformList<TerraformBlock<GoogleComputeImageShieldedInstanceInitialStateBlock>>? ShieldedInstanceInitialState { get; set; }

    /// <summary>
    /// Block for source_disk_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceDiskEncryptionKey block(s) allowed")]
    [TerraformProperty("source_disk_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeImageSourceDiskEncryptionKeyBlock>>? SourceDiskEncryptionKey { get; set; }

    /// <summary>
    /// Block for source_image_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageEncryptionKey block(s) allowed")]
    [TerraformProperty("source_image_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeImageSourceImageEncryptionKeyBlock>>? SourceImageEncryptionKey { get; set; }

    /// <summary>
    /// Block for source_snapshot_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSnapshotEncryptionKey block(s) allowed")]
    [TerraformProperty("source_snapshot_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeImageSourceSnapshotEncryptionKeyBlock>>? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeImageTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Size of the image tar.gz archive stored in Google Cloud Storage (in
    /// bytes).
    /// </summary>
    [TerraformProperty("archive_size_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ArchiveSizeBytes { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

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
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
