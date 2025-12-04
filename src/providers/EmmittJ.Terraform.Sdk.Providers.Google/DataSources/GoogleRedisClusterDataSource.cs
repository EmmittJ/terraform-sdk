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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Unique name of the resource in this scope including project and location using the form:
    /// projects/{projectId}/locations/{locationId}/clusters/{clusterId}
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
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the region of the Redis cluster.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value: &amp;quot;AUTH_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;AUTH_MODE_UNSPECIFIED&amp;quot;, &amp;quot;AUTH_MODE_IAM_AUTH&amp;quot;, &amp;quot;AUTH_MODE_DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string> AuthorizationMode
        => AsReference("authorization_mode");

    /// <summary>
    /// The automated backup config for a instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutomatedBackupConfig
        => AsReference("automated_backup_config");

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    public TerraformList<string> AvailableMaintenanceVersions
        => AsReference("available_maintenance_versions");

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    public TerraformValue<string> BackupCollection
        => AsReference("backup_collection");

    /// <summary>
    /// The timestamp associated with the cluster creation request. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Cross cluster replication config
    /// </summary>
    public TerraformList<TerraformMap<object>> CrossClusterReplicationConfig
        => AsReference("cross_cluster_replication_config");

    /// <summary>
    /// Optional. Indicates if the cluster is deletion protected or not.
    /// If the value if set to true, any delete cluster operation will fail.
    /// Default value is true.
    /// </summary>
    public TerraformValue<bool> DeletionProtectionEnabled
        => AsReference("deletion_protection_enabled");

    /// <summary>
    /// Output only. Endpoints created on each given network,
    /// for Redis clients to connect to the cluster.
    /// Currently only one endpoint is supported.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiscoveryEndpoints
        => AsReference("discovery_endpoints");

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    public TerraformValue<string> EffectiveMaintenanceVersion
        => AsReference("effective_maintenance_version");

    /// <summary>
    /// Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> GcsSource
        => AsReference("gcs_source");

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster.
    /// </summary>
    public TerraformValue<string> KmsKey
        => AsReference("kms_key");

    /// <summary>
    /// Maintenance policy for a cluster
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenancePolicy
        => AsReference("maintenance_policy");

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceSchedule
        => AsReference("maintenance_schedule");

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    public TerraformValue<string> MaintenanceVersion
        => AsReference("maintenance_version");

    /// <summary>
    /// Backups that generated and managed by memorystore.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedBackupSource
        => AsReference("managed_backup_source");

    /// <summary>
    /// Cluster&#39;s Certificate Authority. This field will only be populated if Redis Cluster&#39;s transit_encryption_mode is TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedServerCa
        => AsReference("managed_server_ca");

    /// <summary>
    /// The nodeType for the Redis cluster.
    /// If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values: [&amp;quot;REDIS_SHARED_CORE_NANO&amp;quot;, &amp;quot;REDIS_HIGHMEM_MEDIUM&amp;quot;, &amp;quot;REDIS_HIGHMEM_XLARGE&amp;quot;, &amp;quot;REDIS_STANDARD_SMALL&amp;quot;]
    /// </summary>
    public TerraformValue<string> NodeType
        => AsReference("node_type");

    /// <summary>
    /// Persistence config (RDB, AOF) for the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> PersistenceConfig
        => AsReference("persistence_config");

    /// <summary>
    /// Output only. Redis memory precise size in GB for the entire cluster.
    /// </summary>
    public TerraformValue<double> PreciseSizeGb
        => AsReference("precise_size_gb");

    /// <summary>
    /// Required. Each PscConfig configures the consumer network where two
    /// network addresses will be designated to the cluster for client access.
    /// Currently, only one PscConfig is supported.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscConfigs
        => AsReference("psc_configs");

    /// <summary>
    /// Output only. PSC connections for discovery of the cluster topology and accessing the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscConnections
        => AsReference("psc_connections");

    /// <summary>
    /// Service attachment details to configure Psc connections.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscServiceAttachments
        => AsReference("psc_service_attachments");

    /// <summary>
    /// Configure Redis Cluster behavior using a subset of native Redis configuration parameters.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations
    /// </summary>
    public TerraformMap<string> RedisConfigs
        => AsReference("redis_configs");

    /// <summary>
    /// Optional. The number of replica nodes per shard.
    /// </summary>
    public TerraformValue<double> ReplicaCount
        => AsReference("replica_count");

    /// <summary>
    /// Required. Number of shards for the Redis cluster.
    /// </summary>
    public TerraformValue<double> ShardCount
        => AsReference("shard_count");

    /// <summary>
    /// Output only. Redis memory size in GB for the entire cluster.
    /// </summary>
    public TerraformValue<double> SizeGb
        => AsReference("size_gb");

    /// <summary>
    /// The current state of this cluster. Can be CREATING, READY, UPDATING, DELETING and SUSPENDED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Output only. Additional information about the current state of the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> StateInfo
        => AsReference("state_info");

    /// <summary>
    /// Optional. The in-transit encryption for the Redis cluster.
    /// If not provided, encryption is disabled for the cluster. Default value: &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;TRANSIT_ENCRYPTION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION&amp;quot;]
    /// </summary>
    public TerraformValue<string> TransitEncryptionMode
        => AsReference("transit_encryption_mode");

    /// <summary>
    /// System assigned, unique identifier for the cluster.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Immutable. Zone distribution config for Memorystore Redis cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> ZoneDistributionConfig
        => AsReference("zone_distribution_config");

}
