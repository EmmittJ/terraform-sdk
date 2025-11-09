using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_snapshot resource.
/// </summary>
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
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
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
    public TerraformProperty<string>? Name
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
    public TerraformProperty<string>? SourceDisk
    {
        get => GetProperty<TerraformProperty<string>>("source_disk");
        set => this.WithProperty("source_disk", value);
    }

    /// <summary>
    /// Cloud Storage bucket storage location of the snapshot (regional or multi-regional).
    /// </summary>
    public TerraformProperty<List<string>>? StorageLocations
    {
        get => GetProperty<TerraformProperty<List<string>>>("storage_locations");
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
