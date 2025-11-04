using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_netapp_volume resource.
/// </summary>
public class GoogleNetappVolume : TerraformResource
{
    public GoogleNetappVolume(string name) : base("google_netapp_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("active_directory");
        this.DeclareOutput("cold_tier_size_gib");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("encryption_type");
        this.DeclareOutput("has_replication");
        this.DeclareOutput("hot_tier_size_used_gib");
        this.DeclareOutput("kms_config");
        this.DeclareOutput("ldap_enabled");
        this.DeclareOutput("mount_options");
        this.DeclareOutput("network");
        this.DeclareOutput("psa_range");
        this.DeclareOutput("replica_zone");
        this.DeclareOutput("service_level");
        this.DeclareOutput("state");
        this.DeclareOutput("state_details");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("used_gib");
        this.DeclareOutput("zone");
    }

    /// <summary>
    /// Capacity of the volume (in GiB).
    /// </summary>
    public string? CapacityGib
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_gib")?.Value;
        set => this.WithProperty("capacity_gib", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Policy to determine if the volume should be deleted forcefully.
    /// Volumes may have nested snapshot resources. Deleting such a volume will fail.
    /// Setting this parameter to FORCE will delete volumes including nested snapshots.
    /// Possible values: DEFAULT, FORCE.
    /// </summary>
    public string? DeletionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deletion_policy")?.Value;
        set => this.WithProperty("deletion_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// Flag indicating if the volume is a kerberos volume or not, export policy rules control kerberos security modes (krb5, krb5i, krb5p).
    /// </summary>
    public bool? KerberosEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("kerberos_enabled")?.Value;
        set => this.WithProperty("kerberos_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
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
    /// Optional. Flag indicating if the volume will be a large capacity volume or a regular volume.
    /// </summary>
    public bool? LargeCapacity
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("large_capacity")?.Value;
        set => this.WithProperty("large_capacity", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Name of the pool location. Usually a region name, expect for some STANDARD service level pools which require a zone name.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Flag indicating if the volume will have an IP address per node for volumes supporting multiple IP endpoints.
    /// Only the volume with largeCapacity will be allowed to have multiple endpoints.
    /// </summary>
    public bool? MultipleEndpoints
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multiple_endpoints")?.Value;
        set => this.WithProperty("multiple_endpoints", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name of the volume. Needs to be unique per location.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The protocol of the volume. Allowed combinations are &#39;[&#39;NFSV3&#39;]&#39;, &#39;[&#39;NFSV4&#39;]&#39;, &#39;[&#39;SMB&#39;]&#39;, &#39;[&#39;NFSV3&#39;, &#39;NFSV4&#39;]&#39;, &#39;[&#39;SMB&#39;, &#39;NFSV3&#39;]&#39; and &#39;[&#39;SMB&#39;, &#39;NFSV4&#39;]&#39;. Possible values: [&amp;quot;NFSV3&amp;quot;, &amp;quot;NFSV4&amp;quot;, &amp;quot;SMB&amp;quot;]
    /// </summary>
    public List<string>? Protocols
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("protocols")?.Value;
        set => this.WithProperty("protocols", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// List of actions that are restricted on this volume. Possible values: [&amp;quot;DELETE&amp;quot;]
    /// </summary>
    public List<string>? RestrictedActions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("restricted_actions")?.Value;
        set => this.WithProperty("restricted_actions", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Security Style of the Volume. Use UNIX to use UNIX or NFSV4 ACLs for file permissions.
    /// Use NTFS to use NTFS ACLs for file permissions. Can only be set for volumes which use SMB together with NFS as protocol. Possible values: [&amp;quot;NTFS&amp;quot;, &amp;quot;UNIX&amp;quot;]
    /// </summary>
    public string? SecurityStyle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_style")?.Value;
        set => this.WithProperty("security_style", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Share name (SMB) or export path (NFS) of the volume. Needs to be unique per location.
    /// </summary>
    public string? ShareName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("share_name")?.Value;
        set => this.WithProperty("share_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Settings for volumes with SMB access. Possible values: [&amp;quot;ENCRYPT_DATA&amp;quot;, &amp;quot;BROWSABLE&amp;quot;, &amp;quot;CHANGE_NOTIFY&amp;quot;, &amp;quot;NON_BROWSABLE&amp;quot;, &amp;quot;OPLOCKS&amp;quot;, &amp;quot;SHOW_SNAPSHOT&amp;quot;, &amp;quot;SHOW_PREVIOUS_VERSIONS&amp;quot;, &amp;quot;ACCESS_BASED_ENUMERATION&amp;quot;, &amp;quot;CONTINUOUSLY_AVAILABLE&amp;quot;]
    /// </summary>
    public List<string>? SmbSettings
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("smb_settings")?.Value;
        set => this.WithProperty("smb_settings", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// If enabled, a NFS volume will contain a read-only .snapshot directory which provides access to each of the volume&#39;s snapshots. Will enable &amp;quot;Previous Versions&amp;quot; support for SMB.
    /// </summary>
    public bool? SnapshotDirectory
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("snapshot_directory")?.Value;
        set => this.WithProperty("snapshot_directory", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Name of the storage pool to create the volume in. Pool needs enough spare capacity to accommodate the volume.
    /// </summary>
    public string? StoragePool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_pool")?.Value;
        set => this.WithProperty("storage_pool", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Custom Performance Total Throughput of the pool (in MiB/s).
    /// </summary>
    public double? ThroughputMibps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput_mibps")?.Value;
        set => this.WithProperty("throughput_mibps", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Unix permission the mount point will be created with. Default is 0770. Applicable for UNIX security style volumes only.
    /// </summary>
    public string? UnixPermissions
    {
        get => GetProperty<TerraformLiteralProperty<string>>("unix_permissions")?.Value;
        set => this.WithProperty("unix_permissions", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Reports the resource name of the Active Directory policy being used. Inherited from storage pool.
    /// </summary>
    public TerraformExpression ActiveDirectory => this["active_directory"];

    /// <summary>
    /// Output only. Size of the volume cold tier data in GiB.
    /// </summary>
    public TerraformExpression ColdTierSizeGib => this["cold_tier_size_gib"];

    /// <summary>
    /// Create time of the volume. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Reports the data-at-rest encryption type of the volume. Inherited from storage pool.
    /// </summary>
    public TerraformExpression EncryptionType => this["encryption_type"];

    /// <summary>
    /// Indicates whether the volume is part of a volume replication relationship.
    /// </summary>
    public TerraformExpression HasReplication => this["has_replication"];

    /// <summary>
    /// Total hot tier data rounded down to the nearest GiB used by the volume. This field is only used for flex Service Level
    /// </summary>
    public TerraformExpression HotTierSizeUsedGib => this["hot_tier_size_used_gib"];

    /// <summary>
    /// Reports the CMEK policy resurce name being used for volume encryption. Inherited from storage pool.
    /// </summary>
    public TerraformExpression KmsConfig => this["kms_config"];

    /// <summary>
    /// Flag indicating if the volume is NFS LDAP enabled or not. Inherited from storage pool.
    /// </summary>
    public TerraformExpression LdapEnabled => this["ldap_enabled"];

    /// <summary>
    /// Reports mount instructions for this volume.
    /// </summary>
    public TerraformExpression MountOptions => this["mount_options"];

    /// <summary>
    /// VPC network name with format: &#39;projects/{{project}}/global/networks/{{network}}&#39;. Inherited from storage pool.
    /// </summary>
    public TerraformExpression Network => this["network"];

    /// <summary>
    /// Name of the Private Service Access allocated range. Inherited from storage pool.
    /// </summary>
    public TerraformExpression PsaRange => this["psa_range"];

    /// <summary>
    /// Specifies the replica zone for regional volume.
    /// </summary>
    public TerraformExpression ReplicaZone => this["replica_zone"];

    /// <summary>
    /// Service level of the volume. Inherited from storage pool. Supported values are : PREMIUM, EXTREME, STANDARD, FLEX.
    /// </summary>
    public TerraformExpression ServiceLevel => this["service_level"];

    /// <summary>
    /// State of the volume.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// State details of the volume.
    /// </summary>
    public TerraformExpression StateDetails => this["state_details"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Used capacity of the volume (in GiB). This is computed periodically and it does not represent the realtime usage.
    /// </summary>
    public TerraformExpression UsedGib => this["used_gib"];

    /// <summary>
    /// Specifies the active zone for regional volume.
    /// </summary>
    public TerraformExpression Zone => this["zone"];

}
