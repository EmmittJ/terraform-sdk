using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_region_disk resource.
/// </summary>
public class GoogleComputeRegionDisk : TerraformResource
{
    public GoogleComputeRegionDisk(string name) : base("google_compute_region_disk", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("disk_id");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("last_attach_timestamp");
        this.DeclareOutput("last_detach_timestamp");
        this.DeclareOutput("self_link");
        this.DeclareOutput("source_disk_id");
        this.DeclareOutput("source_snapshot_id");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("users");
    }

    /// <summary>
    /// The access mode of the disk.
    /// For example:
    ///   * READ_WRITE_SINGLE: The default AccessMode, means the disk can be attached to single instance in RW mode.
    ///   * READ_WRITE_MANY: The AccessMode means the disk can be attached to multiple instances in RW mode.
    ///   * READ_ONLY_SINGLE: The AccessMode means the disk can be attached to multiple instances in RO mode.
    /// The AccessMode is only valid for Hyperdisk disk types.
    /// </summary>
    public string? AccessMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_mode")?.Value;
        set => this.WithProperty("access_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If set to true, a snapshot of the disk will be created before it is destroyed.
    /// If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation.
    /// The name of the snapshot by default will be &#39;{{disk-name}}-YYYYMMDD-HHmm&#39;
    /// </summary>
    public bool? CreateSnapshotBeforeDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_snapshot_before_destroy")?.Value;
        set => this.WithProperty("create_snapshot_before_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// This will set a custom name prefix for the snapshot that&#39;s created when the disk is deleted.
    /// </summary>
    public string? CreateSnapshotBeforeDestroyPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_snapshot_before_destroy_prefix")?.Value;
        set => this.WithProperty("create_snapshot_before_destroy_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Labels to apply to this disk.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    public List<string>? Licenses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("licenses")?.Value;
        set => this.WithProperty("licenses", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Physical block size of the persistent disk, in bytes. If not present
    /// in a request, a default value is used. Currently supported sizes
    /// are 4096 and 16384, other sizes may be added in the future.
    /// If an unsupported value is requested, the error message will list
    /// the supported values for the caller&#39;s project.
    /// </summary>
    public double? PhysicalBlockSizeBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("physical_block_size_bytes")?.Value;
        set => this.WithProperty("physical_block_size_bytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second
    /// that the disk can handle. Values must be between 10,000 and 120,000.
    /// For more details, see the Extreme persistent disk [documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk).
    /// </summary>
    public double? ProvisionedIops
    {
        get => GetProperty<TerraformLiteralProperty<double>>("provisioned_iops")?.Value;
        set => this.WithProperty("provisioned_iops", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Indicates how much throughput to provision for the disk. This sets the number of throughput
    /// mb per second that the disk can handle. Values must be greater than or equal to 1.
    /// </summary>
    public double? ProvisionedThroughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("provisioned_throughput")?.Value;
        set => this.WithProperty("provisioned_throughput", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// A reference to the region where the disk resides.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URLs of the zones where the disk should be replicated to.
    /// </summary>
    public List<string>? ReplicaZones
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("replica_zones")?.Value;
        set => this.WithProperty("replica_zones", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

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
    public double? Size
    {
        get => GetProperty<TerraformLiteralProperty<double>>("size")?.Value;
        set => this.WithProperty("size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

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
    public string? Snapshot
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot")?.Value;
        set => this.WithProperty("snapshot", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public string? SourceDisk
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_disk")?.Value;
        set => this.WithProperty("source_disk", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL of the disk type resource describing which disk type to use to
    /// create the disk. Provide this when creating the disk.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression DiskId => this["disk_id"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// Last attach timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression LastAttachTimestamp => this["last_attach_timestamp"];

    /// <summary>
    /// Last detach timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression LastDetachTimestamp => this["last_detach_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The ID value of the disk used to create this image. This value may
    /// be used to determine whether the image was taken from the current
    /// or a previous instance of a given disk name.
    /// </summary>
    public TerraformExpression SourceDiskId => this["source_disk_id"];

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
    /// Links to the users of the disk (attached instances) in form:
    /// project/zones/zone/instances/instance
    /// </summary>
    public TerraformExpression Users => this["users"];

}
