using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_redis_cluster.
/// </summary>
public partial class GoogleRedisClusterDataSource : TerraformDataSource
{
    public GoogleRedisClusterDataSource(string name) : base("google_redis_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Unique name of the resource in this scope including project and location using the form:
    /// projects/{projectId}/locations/{locationId}/clusters/{clusterId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The name of the region of the Redis cluster.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value: &amp;quot;AUTH_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;AUTH_MODE_UNSPECIFIED&amp;quot;, &amp;quot;AUTH_MODE_IAM_AUTH&amp;quot;, &amp;quot;AUTH_MODE_DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("authorization_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthorizationMode { get; }

    /// <summary>
    /// The automated backup config for a instance.
    /// </summary>
    [TerraformProperty("automated_backup_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AutomatedBackupConfig { get; }

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    [TerraformProperty("available_maintenance_versions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AvailableMaintenanceVersions { get; }

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    [TerraformProperty("backup_collection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupCollection { get; }

    /// <summary>
    /// The timestamp associated with the cluster creation request. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Cross cluster replication config
    /// </summary>
    [TerraformProperty("cross_cluster_replication_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CrossClusterReplicationConfig { get; }

    /// <summary>
    /// Optional. Indicates if the cluster is deletion protected or not.
    /// If the value if set to true, any delete cluster operation will fail.
    /// Default value is true.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtectionEnabled { get; }

    /// <summary>
    /// Output only. Endpoints created on each given network,
    /// for Redis clients to connect to the cluster.
    /// Currently only one endpoint is supported.
    /// </summary>
    [TerraformProperty("discovery_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DiscoveryEndpoints { get; }

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    [TerraformProperty("effective_maintenance_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EffectiveMaintenanceVersion { get; }

    /// <summary>
    /// Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters.
    /// </summary>
    [TerraformProperty("gcs_source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> GcsSource { get; }

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKey { get; }

    /// <summary>
    /// Maintenance policy for a cluster
    /// </summary>
    [TerraformProperty("maintenance_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MaintenancePolicy { get; }

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    [TerraformProperty("maintenance_schedule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MaintenanceSchedule { get; }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    [TerraformProperty("maintenance_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MaintenanceVersion { get; }

    /// <summary>
    /// Backups that generated and managed by memorystore.
    /// </summary>
    [TerraformProperty("managed_backup_source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ManagedBackupSource { get; }

    /// <summary>
    /// Cluster&#39;s Certificate Authority. This field will only be populated if Redis Cluster&#39;s transit_encryption_mode is TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION
    /// </summary>
    [TerraformProperty("managed_server_ca")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ManagedServerCa { get; }

    /// <summary>
    /// The nodeType for the Redis cluster.
    /// If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values: [&amp;quot;REDIS_SHARED_CORE_NANO&amp;quot;, &amp;quot;REDIS_HIGHMEM_MEDIUM&amp;quot;, &amp;quot;REDIS_HIGHMEM_XLARGE&amp;quot;, &amp;quot;REDIS_STANDARD_SMALL&amp;quot;]
    /// </summary>
    [TerraformProperty("node_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NodeType { get; }

    /// <summary>
    /// Persistence config (RDB, AOF) for the cluster.
    /// </summary>
    [TerraformProperty("persistence_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PersistenceConfig { get; }

    /// <summary>
    /// Output only. Redis memory precise size in GB for the entire cluster.
    /// </summary>
    [TerraformProperty("precise_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PreciseSizeGb { get; }

    /// <summary>
    /// Required. Each PscConfig configures the consumer network where two
    /// network addresses will be designated to the cluster for client access.
    /// Currently, only one PscConfig is supported.
    /// </summary>
    [TerraformProperty("psc_configs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PscConfigs { get; }

    /// <summary>
    /// Output only. PSC connections for discovery of the cluster topology and accessing the cluster.
    /// </summary>
    [TerraformProperty("psc_connections")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PscConnections { get; }

    /// <summary>
    /// Service attachment details to configure Psc connections.
    /// </summary>
    [TerraformProperty("psc_service_attachments")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PscServiceAttachments { get; }

    /// <summary>
    /// Configure Redis Cluster behavior using a subset of native Redis configuration parameters.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations
    /// </summary>
    [TerraformProperty("redis_configs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> RedisConfigs { get; }

    /// <summary>
    /// Optional. The number of replica nodes per shard.
    /// </summary>
    [TerraformProperty("replica_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ReplicaCount { get; }

    /// <summary>
    /// Required. Number of shards for the Redis cluster.
    /// </summary>
    [TerraformProperty("shard_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ShardCount { get; }

    /// <summary>
    /// Output only. Redis memory size in GB for the entire cluster.
    /// </summary>
    [TerraformProperty("size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SizeGb { get; }

    /// <summary>
    /// The current state of this cluster. Can be CREATING, READY, UPDATING, DELETING and SUSPENDED
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Output only. Additional information about the current state of the cluster.
    /// </summary>
    [TerraformProperty("state_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StateInfo { get; }

    /// <summary>
    /// Optional. The in-transit encryption for the Redis cluster.
    /// If not provided, encryption is disabled for the cluster. Default value: &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;TRANSIT_ENCRYPTION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION&amp;quot;]
    /// </summary>
    [TerraformProperty("transit_encryption_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransitEncryptionMode { get; }

    /// <summary>
    /// System assigned, unique identifier for the cluster.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Immutable. Zone distribution config for Memorystore Redis cluster.
    /// </summary>
    [TerraformProperty("zone_distribution_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ZoneDistributionConfig { get; }

}
