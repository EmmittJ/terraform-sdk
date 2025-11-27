using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_redis_cluster Terraform data source.
/// Retrieves information about a google_redis_cluster.
/// </summary>
public partial class GoogleRedisClusterDataSource(string name) : TerraformDataSource("google_redis_cluster", name)
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
    /// Unique name of the resource in this scope including project and location using the form:
    /// projects/{projectId}/locations/{locationId}/clusters/{clusterId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The name of the region of the Redis cluster.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value: &amp;quot;AUTH_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;AUTH_MODE_UNSPECIFIED&amp;quot;, &amp;quot;AUTH_MODE_IAM_AUTH&amp;quot;, &amp;quot;AUTH_MODE_DISABLED&amp;quot;]
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
    /// The timestamp associated with the cluster creation request. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Cross cluster replication config
    /// </summary>
    public TerraformList<TerraformMap<object>> CrossClusterReplicationConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cross_cluster_replication_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Optional. Indicates if the cluster is deletion protected or not.
    /// If the value if set to true, any delete cluster operation will fail.
    /// Default value is true.
    /// </summary>
    public TerraformValue<bool> DeletionProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "deletion_protection_enabled");
    }

    /// <summary>
    /// Output only. Endpoints created on each given network,
    /// for Redis clients to connect to the cluster.
    /// Currently only one endpoint is supported.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiscoveryEndpoints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "discovery_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    public TerraformValue<string> EffectiveMaintenanceVersion
    {
        get => new TerraformReference<string>(this, "effective_maintenance_version");
    }

    /// <summary>
    /// Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> GcsSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "gcs_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster.
    /// </summary>
    public TerraformValue<string> KmsKey
    {
        get => new TerraformReference<string>(this, "kms_key");
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
    /// Backups that generated and managed by memorystore.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedBackupSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "managed_backup_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// Cluster&#39;s Certificate Authority. This field will only be populated if Redis Cluster&#39;s transit_encryption_mode is TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedServerCa
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "managed_server_ca").ResolveNodes(ctx));
    }

    /// <summary>
    /// The nodeType for the Redis cluster.
    /// If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values: [&amp;quot;REDIS_SHARED_CORE_NANO&amp;quot;, &amp;quot;REDIS_HIGHMEM_MEDIUM&amp;quot;, &amp;quot;REDIS_HIGHMEM_XLARGE&amp;quot;, &amp;quot;REDIS_STANDARD_SMALL&amp;quot;]
    /// </summary>
    public TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
    }

    /// <summary>
    /// Persistence config (RDB, AOF) for the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> PersistenceConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "persistence_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Redis memory precise size in GB for the entire cluster.
    /// </summary>
    public TerraformValue<double> PreciseSizeGb
    {
        get => new TerraformReference<double>(this, "precise_size_gb");
    }

    /// <summary>
    /// Required. Each PscConfig configures the consumer network where two
    /// network addresses will be designated to the cluster for client access.
    /// Currently, only one PscConfig is supported.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscConfigs
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "psc_configs").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. PSC connections for discovery of the cluster topology and accessing the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscConnections
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "psc_connections").ResolveNodes(ctx));
    }

    /// <summary>
    /// Service attachment details to configure Psc connections.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscServiceAttachments
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "psc_service_attachments").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configure Redis Cluster behavior using a subset of native Redis configuration parameters.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations
    /// </summary>
    public TerraformMap<string> RedisConfigs
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "redis_configs").ResolveNodes(ctx));
    }

    /// <summary>
    /// Optional. The number of replica nodes per shard.
    /// </summary>
    public TerraformValue<double> ReplicaCount
    {
        get => new TerraformReference<double>(this, "replica_count");
    }

    /// <summary>
    /// Required. Number of shards for the Redis cluster.
    /// </summary>
    public TerraformValue<double> ShardCount
    {
        get => new TerraformReference<double>(this, "shard_count");
    }

    /// <summary>
    /// Output only. Redis memory size in GB for the entire cluster.
    /// </summary>
    public TerraformValue<double> SizeGb
    {
        get => new TerraformReference<double>(this, "size_gb");
    }

    /// <summary>
    /// The current state of this cluster. Can be CREATING, READY, UPDATING, DELETING and SUSPENDED
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Output only. Additional information about the current state of the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> StateInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "state_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// Optional. The in-transit encryption for the Redis cluster.
    /// If not provided, encryption is disabled for the cluster. Default value: &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;TRANSIT_ENCRYPTION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION&amp;quot;]
    /// </summary>
    public TerraformValue<string> TransitEncryptionMode
    {
        get => new TerraformReference<string>(this, "transit_encryption_mode");
    }

    /// <summary>
    /// System assigned, unique identifier for the cluster.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Immutable. Zone distribution config for Memorystore Redis cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> ZoneDistributionConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "zone_distribution_config").ResolveNodes(ctx));
    }

}
