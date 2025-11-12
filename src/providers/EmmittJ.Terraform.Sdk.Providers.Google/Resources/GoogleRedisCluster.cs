using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRedisClusterAutomatedBackupConfigBlock() : TerraformBlock("automated_backup_config")
{
    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    [TerraformProperty("retention")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Retention { get; set; }

}

/// <summary>
/// Block type for cross_cluster_replication_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRedisClusterCrossClusterReplicationConfigBlock() : TerraformBlock("cross_cluster_replication_config")
{
    /// <summary>
    /// The role of the cluster in cross cluster replication. Supported values are:
    /// 
    /// 1. &#39;CLUSTER_ROLE_UNSPECIFIED&#39;: This is an independent cluster that has never participated in cross cluster replication. It allows both reads and writes.
    /// 
    /// 1. &#39;NONE&#39;: This is an independent cluster that previously participated in cross cluster replication(either as a &#39;PRIMARY&#39; or &#39;SECONDARY&#39; cluster). It allows both reads and writes.
    /// 
    /// 1. &#39;PRIMARY&#39;: This cluster serves as the replication source for secondary clusters that are replicating from it. Any data written to it is automatically replicated to its secondary clusters. It allows both reads and writes.
    /// 
    /// 1. &#39;SECONDARY&#39;: This cluster replicates data from the primary cluster. It allows only reads. Possible values: [&amp;quot;CLUSTER_ROLE_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    [TerraformProperty("cluster_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterRole { get; set; }



}

/// <summary>
/// Block type for gcs_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRedisClusterGcsSourceBlock() : TerraformBlock("gcs_source")
{
    /// <summary>
    /// URIs of the GCS objects to import. Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    [TerraformProperty("uris")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Uris { get; set; }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRedisClusterMaintenancePolicyBlock() : TerraformBlock("maintenance_policy")
{


}

/// <summary>
/// Block type for managed_backup_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRedisClusterManagedBackupSourceBlock() : TerraformBlock("managed_backup_source")
{
    /// <summary>
    /// Example: &#39;projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [TerraformProperty("backup")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Backup { get; set; }

}

/// <summary>
/// Block type for persistence_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRedisClusterPersistenceConfigBlock() : TerraformBlock("persistence_config")
{
    /// <summary>
    /// Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.
    /// 
    /// - DISABLED: 	Persistence (both backup and restore) is disabled for the cluster.
    /// - RDB: RDB based Persistence is enabled.
    /// - AOF: AOF based Persistence is enabled. Possible values: [&amp;quot;PERSISTENCE_MODE_UNSPECIFIED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;RDB&amp;quot;, &amp;quot;AOF&amp;quot;]
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for psc_configs in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRedisClusterPscConfigsBlock() : TerraformBlock("psc_configs")
{
    /// <summary>
    /// Required. The consumer network where the network address of
    /// the discovery endpoint will be reserved, in the form of
    /// projects/{network_project_id_or_number}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Network { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleRedisClusterTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for zone_distribution_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRedisClusterZoneDistributionConfigBlock() : TerraformBlock("zone_distribution_config")
{
    /// <summary>
    /// Immutable. The mode for zone distribution for Memorystore Redis cluster.
    /// If not provided, MULTI_ZONE will be used as default Possible values: [&amp;quot;MULTI_ZONE&amp;quot;, &amp;quot;SINGLE_ZONE&amp;quot;]
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// Immutable. The zone for single zone Memorystore Redis cluster.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Zone { get; set; }

}

/// <summary>
/// Manages a google_redis_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleRedisCluster : TerraformResource
{
    public GoogleRedisCluster(string name) : base("google_redis_cluster", name)
    {
    }

    /// <summary>
    /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value: &amp;quot;AUTH_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;AUTH_MODE_UNSPECIFIED&amp;quot;, &amp;quot;AUTH_MODE_IAM_AUTH&amp;quot;, &amp;quot;AUTH_MODE_DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("authorization_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizationMode { get; set; }

    /// <summary>
    /// Optional. Indicates if the cluster is deletion protected or not.
    /// If the value if set to true, any delete cluster operation will fail.
    /// Default value is true.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    [TerraformProperty("maintenance_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaintenanceVersion { get; set; }

    /// <summary>
    /// Unique name of the resource in this scope including project and location using the form:
    /// projects/{projectId}/locations/{locationId}/clusters/{clusterId}
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The nodeType for the Redis cluster.
    /// If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values: [&amp;quot;REDIS_SHARED_CORE_NANO&amp;quot;, &amp;quot;REDIS_HIGHMEM_MEDIUM&amp;quot;, &amp;quot;REDIS_HIGHMEM_XLARGE&amp;quot;, &amp;quot;REDIS_STANDARD_SMALL&amp;quot;]
    /// </summary>
    [TerraformProperty("node_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Configure Redis Cluster behavior using a subset of native Redis configuration parameters.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations
    /// </summary>
    [TerraformProperty("redis_configs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? RedisConfigs { get; set; }

    /// <summary>
    /// The name of the region of the Redis cluster.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Optional. The number of replica nodes per shard.
    /// </summary>
    [TerraformProperty("replica_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReplicaCount { get; set; }

    /// <summary>
    /// Required. Number of shards for the Redis cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShardCount is required")]
    [TerraformProperty("shard_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ShardCount { get; set; }

    /// <summary>
    /// Optional. The in-transit encryption for the Redis cluster.
    /// If not provided, encryption is disabled for the cluster. Default value: &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;TRANSIT_ENCRYPTION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION&amp;quot;]
    /// </summary>
    [TerraformProperty("transit_encryption_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransitEncryptionMode { get; set; }

    /// <summary>
    /// Block for automated_backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupConfig block(s) allowed")]
    [TerraformProperty("automated_backup_config")]
    public TerraformList<GoogleRedisClusterAutomatedBackupConfigBlock> AutomatedBackupConfig { get; set; } = new();

    /// <summary>
    /// Block for cross_cluster_replication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CrossClusterReplicationConfig block(s) allowed")]
    [TerraformProperty("cross_cluster_replication_config")]
    public TerraformList<GoogleRedisClusterCrossClusterReplicationConfigBlock> CrossClusterReplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for gcs_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsSource block(s) allowed")]
    [TerraformProperty("gcs_source")]
    public TerraformList<GoogleRedisClusterGcsSourceBlock> GcsSource { get; set; } = new();

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    [TerraformProperty("maintenance_policy")]
    public TerraformList<GoogleRedisClusterMaintenancePolicyBlock> MaintenancePolicy { get; set; } = new();

    /// <summary>
    /// Block for managed_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedBackupSource block(s) allowed")]
    [TerraformProperty("managed_backup_source")]
    public TerraformList<GoogleRedisClusterManagedBackupSourceBlock> ManagedBackupSource { get; set; } = new();

    /// <summary>
    /// Block for persistence_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistenceConfig block(s) allowed")]
    [TerraformProperty("persistence_config")]
    public TerraformList<GoogleRedisClusterPersistenceConfigBlock> PersistenceConfig { get; set; } = new();

    /// <summary>
    /// Block for psc_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("psc_configs")]
    public TerraformList<GoogleRedisClusterPscConfigsBlock> PscConfigs { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleRedisClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for zone_distribution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZoneDistributionConfig block(s) allowed")]
    [TerraformProperty("zone_distribution_config")]
    public TerraformList<GoogleRedisClusterZoneDistributionConfigBlock> ZoneDistributionConfig { get; set; } = new();

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
    /// Upcoming maintenance schedule.
    /// </summary>
    [TerraformProperty("maintenance_schedule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MaintenanceSchedule { get; }

    /// <summary>
    /// Cluster&#39;s Certificate Authority. This field will only be populated if Redis Cluster&#39;s transit_encryption_mode is TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION
    /// </summary>
    [TerraformProperty("managed_server_ca")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ManagedServerCa { get; }

    /// <summary>
    /// Output only. Redis memory precise size in GB for the entire cluster.
    /// </summary>
    [TerraformProperty("precise_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PreciseSizeGb { get; }

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
    /// System assigned, unique identifier for the cluster.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

}
