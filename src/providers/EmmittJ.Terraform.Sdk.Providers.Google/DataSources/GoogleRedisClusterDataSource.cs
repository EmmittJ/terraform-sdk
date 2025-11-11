using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_redis_cluster.
/// </summary>
public class GoogleRedisClusterDataSource : TerraformDataSource
{
    public GoogleRedisClusterDataSource(string name) : base("google_redis_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Unique name of the resource in this scope including project and location using the form:
    /// projects/{projectId}/locations/{locationId}/clusters/{clusterId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The name of the region of the Redis cluster.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value: &amp;quot;AUTH_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;AUTH_MODE_UNSPECIFIED&amp;quot;, &amp;quot;AUTH_MODE_IAM_AUTH&amp;quot;, &amp;quot;AUTH_MODE_DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("authorization_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AuthorizationMode => new TerraformReference(this, "authorization_mode");

    /// <summary>
    /// The automated backup config for a instance.
    /// </summary>
    [TerraformPropertyName("automated_backup_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutomatedBackupConfig => new TerraformReference(this, "automated_backup_config");

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    [TerraformPropertyName("available_maintenance_versions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AvailableMaintenanceVersions => new TerraformReference(this, "available_maintenance_versions");

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    [TerraformPropertyName("backup_collection")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupCollection => new TerraformReference(this, "backup_collection");

    /// <summary>
    /// The timestamp associated with the cluster creation request. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Cross cluster replication config
    /// </summary>
    [TerraformPropertyName("cross_cluster_replication_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CrossClusterReplicationConfig => new TerraformReference(this, "cross_cluster_replication_config");

    /// <summary>
    /// Optional. Indicates if the cluster is deletion protected or not.
    /// If the value if set to true, any delete cluster operation will fail.
    /// Default value is true.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtectionEnabled => new TerraformReference(this, "deletion_protection_enabled");

    /// <summary>
    /// Output only. Endpoints created on each given network,
    /// for Redis clients to connect to the cluster.
    /// Currently only one endpoint is supported.
    /// </summary>
    [TerraformPropertyName("discovery_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DiscoveryEndpoints => new TerraformReference(this, "discovery_endpoints");

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    [TerraformPropertyName("effective_maintenance_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EffectiveMaintenanceVersion => new TerraformReference(this, "effective_maintenance_version");

    /// <summary>
    /// Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters.
    /// </summary>
    [TerraformPropertyName("gcs_source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GcsSource => new TerraformReference(this, "gcs_source");

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKey => new TerraformReference(this, "kms_key");

    /// <summary>
    /// Maintenance policy for a cluster
    /// </summary>
    [TerraformPropertyName("maintenance_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenancePolicy => new TerraformReference(this, "maintenance_policy");

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    [TerraformPropertyName("maintenance_schedule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceSchedule => new TerraformReference(this, "maintenance_schedule");

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    [TerraformPropertyName("maintenance_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MaintenanceVersion => new TerraformReference(this, "maintenance_version");

    /// <summary>
    /// Backups that generated and managed by memorystore.
    /// </summary>
    [TerraformPropertyName("managed_backup_source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagedBackupSource => new TerraformReference(this, "managed_backup_source");

    /// <summary>
    /// Cluster&#39;s Certificate Authority. This field will only be populated if Redis Cluster&#39;s transit_encryption_mode is TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION
    /// </summary>
    [TerraformPropertyName("managed_server_ca")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagedServerCa => new TerraformReference(this, "managed_server_ca");

    /// <summary>
    /// The nodeType for the Redis cluster.
    /// If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values: [&amp;quot;REDIS_SHARED_CORE_NANO&amp;quot;, &amp;quot;REDIS_HIGHMEM_MEDIUM&amp;quot;, &amp;quot;REDIS_HIGHMEM_XLARGE&amp;quot;, &amp;quot;REDIS_STANDARD_SMALL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeType => new TerraformReference(this, "node_type");

    /// <summary>
    /// Persistence config (RDB, AOF) for the cluster.
    /// </summary>
    [TerraformPropertyName("persistence_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PersistenceConfig => new TerraformReference(this, "persistence_config");

    /// <summary>
    /// Output only. Redis memory precise size in GB for the entire cluster.
    /// </summary>
    [TerraformPropertyName("precise_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PreciseSizeGb => new TerraformReference(this, "precise_size_gb");

    /// <summary>
    /// Required. Each PscConfig configures the consumer network where two
    /// network addresses will be designated to the cluster for client access.
    /// Currently, only one PscConfig is supported.
    /// </summary>
    [TerraformPropertyName("psc_configs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PscConfigs => new TerraformReference(this, "psc_configs");

    /// <summary>
    /// Output only. PSC connections for discovery of the cluster topology and accessing the cluster.
    /// </summary>
    [TerraformPropertyName("psc_connections")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PscConnections => new TerraformReference(this, "psc_connections");

    /// <summary>
    /// Service attachment details to configure Psc connections.
    /// </summary>
    [TerraformPropertyName("psc_service_attachments")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PscServiceAttachments => new TerraformReference(this, "psc_service_attachments");

    /// <summary>
    /// Configure Redis Cluster behavior using a subset of native Redis configuration parameters.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations
    /// </summary>
    [TerraformPropertyName("redis_configs")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> RedisConfigs => new TerraformReference(this, "redis_configs");

    /// <summary>
    /// Optional. The number of replica nodes per shard.
    /// </summary>
    [TerraformPropertyName("replica_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ReplicaCount => new TerraformReference(this, "replica_count");

    /// <summary>
    /// Required. Number of shards for the Redis cluster.
    /// </summary>
    [TerraformPropertyName("shard_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ShardCount => new TerraformReference(this, "shard_count");

    /// <summary>
    /// Output only. Redis memory size in GB for the entire cluster.
    /// </summary>
    [TerraformPropertyName("size_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SizeGb => new TerraformReference(this, "size_gb");

    /// <summary>
    /// The current state of this cluster. Can be CREATING, READY, UPDATING, DELETING and SUSPENDED
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Output only. Additional information about the current state of the cluster.
    /// </summary>
    [TerraformPropertyName("state_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StateInfo => new TerraformReference(this, "state_info");

    /// <summary>
    /// Optional. The in-transit encryption for the Redis cluster.
    /// If not provided, encryption is disabled for the cluster. Default value: &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;TRANSIT_ENCRYPTION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION&amp;quot;]
    /// </summary>
    [TerraformPropertyName("transit_encryption_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitEncryptionMode => new TerraformReference(this, "transit_encryption_mode");

    /// <summary>
    /// System assigned, unique identifier for the cluster.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// Immutable. Zone distribution config for Memorystore Redis cluster.
    /// </summary>
    [TerraformPropertyName("zone_distribution_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ZoneDistributionConfig => new TerraformReference(this, "zone_distribution_config");

}
