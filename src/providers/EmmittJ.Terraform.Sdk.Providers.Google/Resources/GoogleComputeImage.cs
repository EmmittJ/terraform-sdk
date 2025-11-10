using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for guest_os_features in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeImageGuestOsFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// The type of supported feature. Read [Enabling guest operating system features](https://cloud.google.com/compute/docs/images/create-delete-deprecate-private-images#guest-os-features) to see a list of available options. Possible values: [&amp;quot;MULTI_IP_SUBNET&amp;quot;, &amp;quot;SECURE_BOOT&amp;quot;, &amp;quot;SEV_CAPABLE&amp;quot;, &amp;quot;UEFI_COMPATIBLE&amp;quot;, &amp;quot;VIRTIO_SCSI_MULTIQUEUE&amp;quot;, &amp;quot;WINDOWS&amp;quot;, &amp;quot;GVNIC&amp;quot;, &amp;quot;IDPF&amp;quot;, &amp;quot;SEV_LIVE_MIGRATABLE&amp;quot;, &amp;quot;SEV_SNP_CAPABLE&amp;quot;, &amp;quot;SUSPEND_RESUME_COMPATIBLE&amp;quot;, &amp;quot;TDX_CAPABLE&amp;quot;, &amp;quot;SEV_LIVE_MIGRATABLE_V2&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for image_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageImageEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud
    /// KMS.
    /// </summary>
    public TerraformProperty<string>? KmsKeySelfLink
    {
        set => SetProperty("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    public TerraformProperty<string>? KmsKeyServiceAccount
    {
        set => SetProperty("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformProperty<string>? RawKey
    {
        set => SetProperty("raw_key", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformProperty<string>? RsaEncryptedKey
    {
        set => SetProperty("rsa_encrypted_key", value);
    }

}

/// <summary>
/// Block type for raw_disk in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageRawDiskBlock : TerraformBlock
{
    /// <summary>
    /// The format used to encode and transmit the block device, which
    /// should be TAR. This is just a container and transmission format
    /// and not a runtime format. Provided by the client when the disk
    /// image is created. Default value: &amp;quot;TAR&amp;quot; Possible values: [&amp;quot;TAR&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ContainerType
    {
        set => SetProperty("container_type", value);
    }

    /// <summary>
    /// An optional SHA1 checksum of the disk image before unpackaging.
    /// This is provided by the client when the disk image is created.
    /// </summary>
    public TerraformProperty<string>? Sha1
    {
        set => SetProperty("sha1", value);
    }

    /// <summary>
    /// The full Google Cloud Storage URL where disk storage is stored
    /// You must provide either this property or the sourceDisk property
    /// but not both.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        set => SetProperty("source", value);
    }

}

/// <summary>
/// Block type for shielded_instance_initial_state in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageShieldedInstanceInitialStateBlock : TerraformBlock
{
}

/// <summary>
/// Block type for source_disk_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageSourceDiskEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    public TerraformProperty<string>? KmsKeySelfLink
    {
        set => SetProperty("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    public TerraformProperty<string>? KmsKeyServiceAccount
    {
        set => SetProperty("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformProperty<string>? RawKey
    {
        set => SetProperty("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// </summary>
    public TerraformProperty<string>? RsaEncryptedKey
    {
        set => SetProperty("rsa_encrypted_key", value);
    }

}

/// <summary>
/// Block type for source_image_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageSourceImageEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    public TerraformProperty<string>? KmsKeySelfLink
    {
        set => SetProperty("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    public TerraformProperty<string>? KmsKeyServiceAccount
    {
        set => SetProperty("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformProperty<string>? RawKey
    {
        set => SetProperty("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// </summary>
    public TerraformProperty<string>? RsaEncryptedKey
    {
        set => SetProperty("rsa_encrypted_key", value);
    }

}

/// <summary>
/// Block type for source_snapshot_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeImageSourceSnapshotEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&#39;s Compute Engine System service account
    /// (&#39;service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    public TerraformProperty<string>? KmsKeySelfLink
    {
        set => SetProperty("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    public TerraformProperty<string>? KmsKeyServiceAccount
    {
        set => SetProperty("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformProperty<string>? RawKey
    {
        set => SetProperty("raw_key", value);
    }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// </summary>
    public TerraformProperty<string>? RsaEncryptedKey
    {
        set => SetProperty("rsa_encrypted_key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeImageTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeImage : TerraformResource
{
    public GoogleComputeImage(string name) : base("google_compute_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("archive_size_bytes");
        SetOutput("creation_timestamp");
        SetOutput("effective_labels");
        SetOutput("label_fingerprint");
        SetOutput("self_link");
        SetOutput("terraform_labels");
        SetOutput("description");
        SetOutput("disk_size_gb");
        SetOutput("family");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("licenses");
        SetOutput("name");
        SetOutput("project");
        SetOutput("source_disk");
        SetOutput("source_image");
        SetOutput("source_snapshot");
        SetOutput("storage_locations");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Size of the image when restored onto a persistent disk (in GB).
    /// </summary>
    public TerraformProperty<double> DiskSizeGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_size_gb");
        set => SetProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The name of the image family to which this image belongs. You can
    /// create disks by specifying an image family instead of a specific
    /// image name. The image family always returns its latest image that is
    /// not deprecated. The name of the image family must comply with
    /// RFC1035.
    /// </summary>
    public TerraformProperty<string> Family
    {
        get => GetRequiredOutput<TerraformProperty<string>>("family");
        set => SetProperty("family", value);
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
    /// Labels to apply to this Image.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    public List<TerraformProperty<string>> Licenses
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("licenses");
        set => SetProperty("licenses", value);
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
    /// The source disk to create this image based on.
    /// You must provide either this property or the
    /// rawDisk.source property but not both to create an image.
    /// </summary>
    public TerraformProperty<string> SourceDisk
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_disk");
        set => SetProperty("source_disk", value);
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
    public TerraformProperty<string> SourceImage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_image");
        set => SetProperty("source_image", value);
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
    public TerraformProperty<string> SourceSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_snapshot");
        set => SetProperty("source_snapshot", value);
    }

    /// <summary>
    /// Cloud Storage bucket storage location of the image
    /// (regional or multi-regional).
    /// Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images
    /// </summary>
    public List<TerraformProperty<string>> StorageLocations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("storage_locations");
        set => SetProperty("storage_locations", value);
    }

    /// <summary>
    /// Block for guest_os_features.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeImageGuestOsFeaturesBlock>? GuestOsFeatures
    {
        set => SetProperty("guest_os_features", value);
    }

    /// <summary>
    /// Block for image_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageEncryptionKey block(s) allowed")]
    public List<GoogleComputeImageImageEncryptionKeyBlock>? ImageEncryptionKey
    {
        set => SetProperty("image_encryption_key", value);
    }

    /// <summary>
    /// Block for raw_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RawDisk block(s) allowed")]
    public List<GoogleComputeImageRawDiskBlock>? RawDisk
    {
        set => SetProperty("raw_disk", value);
    }

    /// <summary>
    /// Block for shielded_instance_initial_state.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceInitialState block(s) allowed")]
    public List<GoogleComputeImageShieldedInstanceInitialStateBlock>? ShieldedInstanceInitialState
    {
        set => SetProperty("shielded_instance_initial_state", value);
    }

    /// <summary>
    /// Block for source_disk_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceDiskEncryptionKey block(s) allowed")]
    public List<GoogleComputeImageSourceDiskEncryptionKeyBlock>? SourceDiskEncryptionKey
    {
        set => SetProperty("source_disk_encryption_key", value);
    }

    /// <summary>
    /// Block for source_image_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageEncryptionKey block(s) allowed")]
    public List<GoogleComputeImageSourceImageEncryptionKeyBlock>? SourceImageEncryptionKey
    {
        set => SetProperty("source_image_encryption_key", value);
    }

    /// <summary>
    /// Block for source_snapshot_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSnapshotEncryptionKey block(s) allowed")]
    public List<GoogleComputeImageSourceSnapshotEncryptionKeyBlock>? SourceSnapshotEncryptionKey
    {
        set => SetProperty("source_snapshot_encryption_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeImageTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Size of the image tar.gz archive stored in Google Cloud Storage (in
    /// bytes).
    /// </summary>
    public TerraformExpression ArchiveSizeBytes => this["archive_size_bytes"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource. Used
    /// internally during updates.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
