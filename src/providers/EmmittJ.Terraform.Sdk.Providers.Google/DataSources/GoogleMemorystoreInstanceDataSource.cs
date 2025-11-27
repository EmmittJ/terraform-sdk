using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_memorystore_instance Terraform data source.
/// Retrieves information about a google_memorystore_instance.
/// </summary>
public partial class GoogleMemorystoreInstanceDataSource(string name) : TerraformDataSource("google_memorystore_instance", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Required. The ID to use for the instance, which will become the final component of
    /// the instance&#39;s resource name.
    /// 
    /// This value is subject to the following restrictions:
    /// 
    /// * Must be 4-63 characters in length
    /// * Must begin with a letter or digit
    /// * Must contain only lowercase letters, digits, and hyphens
    /// * Must not end with a hyphen
    /// * Must be unique within a location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;memorystore.googleapis.com/CertificateAuthority&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    ///  AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    public TerraformValue<string> AuthorizationMode
    {
        get => new TerraformReference<string>(this, "authorization_mode");
    }

    /// <summary>
    /// The automated backup config for a instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutomatedBackupConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "automated_backup_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    public TerraformList<string> AvailableMaintenanceVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "available_maintenance_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    public TerraformValue<string> BackupCollection
    {
        get => new TerraformReference<string>(this, "backup_collection");
    }

    /// <summary>
    /// Output only. Creation timestamp of the instance.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Cross instance replication config
    /// </summary>
    public TerraformList<TerraformMap<object>> CrossInstanceReplicationConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cross_instance_replication_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Optional. If set to true deletion of the instance will fail.
    /// </summary>
    public TerraformValue<bool> DeletionProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "deletion_protection_enabled");
    }

    /// <summary>
    /// Immutable. User inputs for the auto-created endpoints connections.
    /// </summary>
    public TerraformList<TerraformMap<object>> DesiredAutoCreatedEndpoints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "desired_auto_created_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// &#39;desired_psc_auto_connections&#39; is deprecated  Use &#39;desired_auto_created_endpoints&#39; instead &#39;terraform import&#39; will only work with desired_auto_created_endpoints&#39;.
    /// </summary>
    public TerraformList<TerraformMap<object>> DesiredPscAutoConnections
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "desired_psc_auto_connections").ResolveNodes(ctx));
    }

    /// <summary>
    /// Deprecated. Output only. Endpoints clients can connect to the instance through.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiscoveryEndpoints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "discovery_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    public TerraformValue<string> EffectiveMaintenanceVersion
    {
        get => new TerraformReference<string>(this, "effective_maintenance_version");
    }

    /// <summary>
    /// Endpoints for the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// Optional. User-provided engine configurations for the instance.
    /// </summary>
    public TerraformMap<string> EngineConfigs
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "engine_configs").ResolveNodes(ctx));
    }

    /// <summary>
    /// Optional. Engine version of the instance.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// GCS source for the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> GcsSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "gcs_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster
    /// </summary>
    public TerraformValue<string> KmsKey
    {
        get => new TerraformReference<string>(this, "kms_key");
    }

    /// <summary>
    /// Optional. Labels to represent user-provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Maintenance policy for a cluster
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenancePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceSchedule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_schedule").ResolveNodes(ctx));
    }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    public TerraformValue<string> MaintenanceVersion
    {
        get => new TerraformReference<string>(this, "maintenance_version");
    }

    /// <summary>
    /// Managed backup source for the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedBackupSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "managed_backup_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// Instance&#39;s Certificate Authority. This field will only be populated if instance&#39;s transit_encryption_mode is SERVER_AUTHENTICATION
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedServerCa
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "managed_server_ca").ResolveNodes(ctx));
    }

    /// <summary>
    /// Optional. cluster or cluster-disabled. 
    ///  Possible values:
    ///  CLUSTER
    ///  CLUSTER_DISABLED Possible values: [&amp;quot;CLUSTER&amp;quot;, &amp;quot;CLUSTER_DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
    }

    /// <summary>
    /// Identifier. Unique name of the instance.
    /// Format: projects/{project}/locations/{location}/instances/{instance}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Represents configuration for nodes of the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodeConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "node_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Optional. Machine type for individual nodes of the instance. 
    ///  Possible values:
    ///  SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    public TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
    }

    /// <summary>
    /// Represents persistence configuration for a instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> PersistenceConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "persistence_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration of a service attachment of the cluster, for creating PSC connections.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscAttachmentDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "psc_attachment_details").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. User inputs and resource details of the auto-created PSC connections.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscAutoConnections
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "psc_auto_connections").ResolveNodes(ctx));
    }

    /// <summary>
    /// Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.
    /// </summary>
    public TerraformValue<double> ReplicaCount
    {
        get => new TerraformReference<double>(this, "replica_count");
    }

    /// <summary>
    /// Required. Number of shards for the instance.
    /// </summary>
    public TerraformValue<double> ShardCount
    {
        get => new TerraformReference<double>(this, "shard_count");
    }

    /// <summary>
    /// Output only. Current state of the instance. 
    ///  Possible values:
    ///  CREATING
    /// ACTIVE
    /// UPDATING
    /// DELETING
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Additional information about the state of the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> StateInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "state_info").ResolveNodes(ctx));
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
    /// Optional. Immutable. In-transit encryption mode of the instance. 
    ///  Possible values:
    ///  TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    public TerraformValue<string> TransitEncryptionMode
    {
        get => new TerraformReference<string>(this, "transit_encryption_mode");
    }

    /// <summary>
    /// Output only. System assigned, unique identifier for the instance.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Output only. Latest update timestamp of the instance.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Zone distribution configuration for allocation of instance resources.
    /// </summary>
    public TerraformList<TerraformMap<object>> ZoneDistributionConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "zone_distribution_config").ResolveNodes(ctx));
    }

}
