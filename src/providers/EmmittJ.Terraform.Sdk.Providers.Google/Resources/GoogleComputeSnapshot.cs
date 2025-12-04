using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for snapshot_encryption_key in GoogleComputeSnapshot.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSnapshotSnapshotEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snapshot_encryption_key";

    /// <summary>
    /// The name of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
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
    /// Specifies an encryption key stored in Google Cloud KMS, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => GetArgument<TerraformValue<string>>("rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

    /// <summary>
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied
    /// encryption key that protects this resource.
    /// </summary>
    public TerraformValue<string> Sha256
        => AsReference("sha256");

}


/// <summary>
/// Block type for source_disk_encryption_key in GoogleComputeSnapshot.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSnapshotSourceDiskEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_disk_encryption_key";

    /// <summary>
    /// The name of the encryption key that is stored in Google Cloud KMS.
    /// </summary>
    public TerraformValue<string>? KmsKeySelfLink
    {
        get => GetArgument<TerraformValue<string>>("kms_key_self_link");
        set => SetArgument("kms_key_self_link", value);
    }

    /// <summary>
    /// The service account used for the encryption request for the given KMS key.
    /// If absent, the Compute Engine Service Agent service account is used.
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
    /// Specifies an encryption key stored in Google Cloud KMS, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    public TerraformValue<string>? RsaEncryptedKey
    {
        get => GetArgument<TerraformValue<string>>("rsa_encrypted_key");
        set => SetArgument("rsa_encrypted_key", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeSnapshot.
/// Nesting mode: single
/// </summary>
public class GoogleComputeSnapshotTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_snapshot Terraform resource.
/// Manages a google_compute_snapshot resource.
/// </summary>
public partial class GoogleComputeSnapshot(string name) : TerraformResource("google_compute_snapshot", name)
{
    /// <summary>
    /// Creates the new snapshot in the snapshot chain labeled with the
    /// specified name. The chain name must be 1-63 characters long and
    /// comply with RFC1035. This is an uncommon option only for advanced
    /// service owners who needs to create separate snapshot chains, for
    /// example, for chargeback tracking.  When you describe your snapshot
    /// resource, this field is visible only if it has a non-empty value.
    /// </summary>
    public TerraformValue<string>? ChainName
    {
        get => GetArgument<TerraformValue<string>>("chain_name");
        set => SetArgument("chain_name", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels to apply to this Snapshot.
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
    /// Name of the resource; provided by the client when the resource is
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A reference to the disk used to create this snapshot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDisk is required")]
    public required TerraformValue<string> SourceDisk
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_disk");
        set => SetArgument("source_disk", value);
    }

    /// <summary>
    /// Cloud Storage bucket storage location of the snapshot (regional or multi-regional).
    /// </summary>
    public TerraformList<string> StorageLocations
    {
        get => GetArgument<TerraformList<string>>("storage_locations") ?? AsReference("storage_locations");
        set => SetArgument("storage_locations", value);
    }

    /// <summary>
    /// A reference to the zone where the disk is hosted.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => GetArgument<TerraformValue<string>>("zone") ?? AsReference("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// Size of the snapshot, specified in GB.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
        => AsReference("disk_size_gb");

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
    /// A list of public visible licenses that apply to this snapshot. This
    /// can be because the original image had licenses attached (such as a
    /// Windows image).  snapshotEncryptionKey nested object Encrypts the
    /// snapshot using a customer-supplied encryption key.
    /// </summary>
    public TerraformList<string> Licenses
        => AsReference("licenses");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformValue<double> SnapshotId
        => AsReference("snapshot_id");

    /// <summary>
    /// A size of the storage used by the snapshot. As snapshots share
    /// storage, this number is expected to change with snapshot
    /// creation/deletion.
    /// </summary>
    public TerraformValue<double> StorageBytes
        => AsReference("storage_bytes");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// SnapshotEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeSnapshotSnapshotEncryptionKeyBlock>? SnapshotEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeSnapshotSnapshotEncryptionKeyBlock>>("snapshot_encryption_key");
        set => SetArgument("snapshot_encryption_key", value);
    }

    /// <summary>
    /// SourceDiskEncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceDiskEncryptionKey block(s) allowed")]
    public TerraformList<GoogleComputeSnapshotSourceDiskEncryptionKeyBlock>? SourceDiskEncryptionKey
    {
        get => GetArgument<TerraformList<GoogleComputeSnapshotSourceDiskEncryptionKeyBlock>>("source_disk_encryption_key");
        set => SetArgument("source_disk_encryption_key", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeSnapshotTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeSnapshotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
