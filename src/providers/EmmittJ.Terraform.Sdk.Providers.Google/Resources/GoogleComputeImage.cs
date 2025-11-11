using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for guest_os_features in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeImageGuestOsFeaturesBlock
{
    /// <summary>
    /// The type of supported feature. Read [Enabling guest operating system features](https://cloud.google.com/compute/docs/images/create-delete-deprecate-private-images#guest-os-features) to see a list of available options. Possible values: [&amp;quot;MULTI_IP_SUBNET&amp;quot;, &amp;quot;SECURE_BOOT&amp;quot;, &amp;quot;SEV_CAPABLE&amp;quot;, &amp;quot;UEFI_COMPATIBLE&amp;quot;, &amp;quot;VIRTIO_SCSI_MULTIQUEUE&amp;quot;, &amp;quot;WINDOWS&amp;quot;, &amp;quot;GVNIC&amp;quot;, &amp;quot;IDPF&amp;quot;, &amp;quot;SEV_LIVE_MIGRATABLE&amp;quot;, &amp;quot;SEV_SNP_CAPABLE&amp;quot;, &amp;quot;SUSPEND_RESUME_COMPATIBLE&amp;quot;, &amp;quot;TDX_CAPABLE&amp;quot;, &amp;quot;SEV_LIVE_MIGRATABLE_V2&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for image_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageImageEncryptionKeyBlock
{
    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud
    /// KMS.
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [TerraformPropertyName("kms_key_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformPropertyName("raw_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RawKey { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [TerraformPropertyName("rsa_encrypted_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RsaEncryptedKey { get; set; }

}

/// <summary>
/// Block type for raw_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageRawDiskBlock
{
    /// <summary>
    /// The format used to encode and transmit the block device, which
    /// should be TAR. This is just a container and transmission format
    /// and not a runtime format. Provided by the client when the disk
    /// image is created. Default value: &amp;quot;TAR&amp;quot; Possible values: [&amp;quot;TAR&amp;quot;]
    /// </summary>
    [TerraformPropertyName("container_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerType { get; set; }

    /// <summary>
    /// An optional SHA1 checksum of the disk image before unpackaging.
    /// This is provided by the client when the disk image is created.
    /// </summary>
    [TerraformPropertyName("sha1")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Sha1 { get; set; }

    /// <summary>
    /// The full Google Cloud Storage URL where disk storage is stored
    /// You must provide either this property or the sourceDisk property
    /// but not both.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Source { get; set; }

}

/// <summary>
/// Block type for shielded_instance_initial_state in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageShieldedInstanceInitialStateBlock
{
}

/// <summary>
/// Block type for source_disk_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageSourceDiskEncryptionKeyBlock
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [TerraformPropertyName("kms_key_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyServiceAccount { get; set; }

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
/// Block type for source_image_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageSourceImageEncryptionKeyBlock
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [TerraformPropertyName("kms_key_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyServiceAccount { get; set; }

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
/// Block type for source_snapshot_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageSourceSnapshotEncryptionKeyBlock
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [TerraformPropertyName("kms_key_self_link")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [TerraformPropertyName("kms_key_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyServiceAccount { get; set; }

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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeImageTimeoutsBlock
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
/// Manages a google_compute_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeImage : TerraformResource
{
    public GoogleComputeImage(string name) : base("google_compute_image", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Size of the image when restored onto a persistent disk (in GB).
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskSizeGb { get; set; } = default!;

    /// <summary>
    /// The name of the image family to which this image belongs. You can
    /// create disks by specifying an image family instead of a specific
    /// image name. The image family always returns its latest image that is
    /// not deprecated. The name of the image family must comply with
    /// RFC1035.
    /// </summary>
    [TerraformPropertyName("family")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Family { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Labels to apply to this Image.
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
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The source disk to create this image based on.
    /// You must provide either this property or the
    /// rawDisk.source property but not both to create an image.
    /// </summary>
    [TerraformPropertyName("source_disk")]
    // Optional argument - user may or may not set a value
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
    [TerraformPropertyName("source_image")]
    // Optional argument - user may or may not set a value
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
    [TerraformPropertyName("source_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceSnapshot { get; set; }

    /// <summary>
    /// Cloud Storage bucket storage location of the image
    /// (regional or multi-regional).
    /// Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images
    /// </summary>
    [TerraformPropertyName("storage_locations")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> StorageLocations { get; set; } = default!;

    /// <summary>
    /// Block for guest_os_features.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("guest_os_features")]
    public TerraformSet<TerraformBlock<GoogleComputeImageGuestOsFeaturesBlock>>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Block for image_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageEncryptionKey block(s) allowed")]
    [TerraformPropertyName("image_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeImageImageEncryptionKeyBlock>>? ImageEncryptionKey { get; set; }

    /// <summary>
    /// Block for raw_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RawDisk block(s) allowed")]
    [TerraformPropertyName("raw_disk")]
    public TerraformList<TerraformBlock<GoogleComputeImageRawDiskBlock>>? RawDisk { get; set; }

    /// <summary>
    /// Block for shielded_instance_initial_state.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceInitialState block(s) allowed")]
    [TerraformPropertyName("shielded_instance_initial_state")]
    public TerraformList<TerraformBlock<GoogleComputeImageShieldedInstanceInitialStateBlock>>? ShieldedInstanceInitialState { get; set; }

    /// <summary>
    /// Block for source_disk_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceDiskEncryptionKey block(s) allowed")]
    [TerraformPropertyName("source_disk_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeImageSourceDiskEncryptionKeyBlock>>? SourceDiskEncryptionKey { get; set; }

    /// <summary>
    /// Block for source_image_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageEncryptionKey block(s) allowed")]
    [TerraformPropertyName("source_image_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeImageSourceImageEncryptionKeyBlock>>? SourceImageEncryptionKey { get; set; }

    /// <summary>
    /// Block for source_snapshot_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSnapshotEncryptionKey block(s) allowed")]
    [TerraformPropertyName("source_snapshot_encryption_key")]
    public TerraformList<TerraformBlock<GoogleComputeImageSourceSnapshotEncryptionKeyBlock>>? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeImageTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Size of the image tar.gz archive stored in Google Cloud Storage (in
    /// bytes).
    /// </summary>
    [TerraformPropertyName("archive_size_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ArchiveSizeBytes => new TerraformReference(this, "archive_size_bytes");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource. Used
    /// internally during updates.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
