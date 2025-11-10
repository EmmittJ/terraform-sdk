using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for snapshot_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSnapshotSnapshotEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// The name of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    public TerraformProperty<string>? KmsKeySelfLink
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_self_link");
        set => WithProperty("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    public TerraformProperty<string>? KmsKeyServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_service_account");
        set => WithProperty("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformProperty<string>? RawKey
    {
        get => GetProperty<TerraformProperty<string>>("raw_key");
        set => WithProperty("raw_key", value);
    }

    /// <summary>
    /// Specifies an encryption key stored in Google Cloud KMS, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformProperty<string>? RsaEncryptedKey
    {
        get => GetProperty<TerraformProperty<string>>("rsa_encrypted_key");
        set => WithProperty("rsa_encrypted_key", value);
    }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied
    /// encryption key that protects this resource.
    /// </summary>
    public TerraformProperty<string>? Sha256
    {
        get => GetProperty<TerraformProperty<string>>("sha256");
        set => WithProperty("sha256", value);
    }

}

/// <summary>
/// Block type for source_disk_encryption_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSnapshotSourceDiskEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// The name of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    public TerraformProperty<string>? KmsKeySelfLink
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_self_link");
        set => WithProperty("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
    /// </summary>
    public TerraformProperty<string>? KmsKeyServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_service_account");
        set => WithProperty("kms_key_service_account", value);
    }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformProperty<string>? RawKey
    {
        get => GetProperty<TerraformProperty<string>>("raw_key");
        set => WithProperty("raw_key", value);
    }

    /// <summary>
    /// Specifies an encryption key stored in Google Cloud KMS, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformProperty<string>? RsaEncryptedKey
    {
        get => GetProperty<TerraformProperty<string>>("rsa_encrypted_key");
        set => WithProperty("rsa_encrypted_key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeSnapshotTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_snapshot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeSnapshot : TerraformResource
{
    public GoogleComputeSnapshot(string name) : base("google_compute_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("disk_size_gb");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("licenses");
        this.DeclareOutput("self_link");
        this.DeclareOutput("snapshot_id");
        this.DeclareOutput("storage_bytes");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Creates the new snapshot in the snapshot chain labeled with the
    /// specified name. The chain name must be 1-63 characters long and
    /// comply with RFC1035. This is an uncommon option only for advanced
    /// service owners who needs to create separate snapshot chains, for
    /// example, for chargeback tracking.  When you describe your snapshot
    /// resource, this field is visible only if it has a non-empty value.
    /// </summary>
    public TerraformProperty<string>? ChainName
    {
        get => GetProperty<TerraformProperty<string>>("chain_name");
        set => this.WithProperty("chain_name", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Labels to apply to this Snapshot.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// A reference to the disk used to create this snapshot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDisk is required")]
    public required TerraformProperty<string> SourceDisk
    {
        get => GetProperty<TerraformProperty<string>>("source_disk");
        set => this.WithProperty("source_disk", value);
    }

    /// <summary>
    /// Cloud Storage bucket storage location of the snapshot (regional or multi-regional).
    /// </summary>
    public List<TerraformProperty<string>>? StorageLocations
    {
        get => GetProperty<List<TerraformProperty<string>>>("storage_locations");
        set => this.WithProperty("storage_locations", value);
    }

    /// <summary>
    /// A reference to the zone where the disk is hosted.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for snapshot_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotEncryptionKey block(s) allowed")]
    public List<GoogleComputeSnapshotSnapshotEncryptionKeyBlock>? SnapshotEncryptionKey
    {
        get => GetProperty<List<GoogleComputeSnapshotSnapshotEncryptionKeyBlock>>("snapshot_encryption_key");
        set => this.WithProperty("snapshot_encryption_key", value);
    }

    /// <summary>
    /// Block for source_disk_encryption_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceDiskEncryptionKey block(s) allowed")]
    public List<GoogleComputeSnapshotSourceDiskEncryptionKeyBlock>? SourceDiskEncryptionKey
    {
        get => GetProperty<List<GoogleComputeSnapshotSourceDiskEncryptionKeyBlock>>("source_disk_encryption_key");
        set => this.WithProperty("source_disk_encryption_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeSnapshotTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeSnapshotTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Size of the snapshot, specified in GB.
    /// </summary>
    public TerraformExpression DiskSizeGb => this["disk_size_gb"];

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
    /// A list of public visible licenses that apply to this snapshot. This
    /// can be because the original image had licenses attached (such as a
    /// Windows image).  snapshotEncryptionKey nested object Encrypts the
    /// snapshot using a customer-supplied encryption key.
    /// </summary>
    public TerraformExpression Licenses => this["licenses"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformExpression SnapshotId => this["snapshot_id"];

    /// <summary>
    /// A size of the storage used by the snapshot. As snapshots share
    /// storage, this number is expected to change with snapshot
    /// creation/deletion.
    /// </summary>
    public TerraformExpression StorageBytes => this["storage_bytes"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
