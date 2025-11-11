using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_config in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterAutomatedBackupConfigBlock
{
    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    [TerraformPropertyName("retention")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Retention { get; set; }

}

/// <summary>
/// Block type for cross_cluster_replication_config in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterCrossClusterReplicationConfigBlock
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
    [TerraformPropertyName("cluster_role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClusterRole { get; set; }



}

/// <summary>
/// Block type for gcs_source in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterGcsSourceBlock
{
    /// <summary>
    /// URIs of the GCS objects to import. Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    [TerraformPropertyName("uris")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Uris { get; set; }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterMaintenancePolicyBlock
{


}

/// <summary>
/// Block type for managed_backup_source in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterManagedBackupSourceBlock
{
    /// <summary>
    /// Example: &#39;projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [TerraformPropertyName("backup")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Backup { get; set; }

}

/// <summary>
/// Block type for persistence_config in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterPersistenceConfigBlock
{
    /// <summary>
    /// Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.
    /// 
    /// - DISABLED: 	Persistence (both backup and restore) is disabled for the cluster.
    /// - RDB: RDB based Persistence is enabled.
    /// - AOF: AOF based Persistence is enabled. Possible values: [&amp;quot;PERSISTENCE_MODE_UNSPECIFIED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;RDB&amp;quot;, &amp;quot;AOF&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mode { get; set; } = default!;

}

/// <summary>
/// Block type for psc_configs in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterPscConfigsBlock
{
    /// <summary>
    /// Required. The consumer network where the network address of
    /// the discovery endpoint will be reserved, in the form of
    /// projects/{network_project_id_or_number}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Network { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleRedisClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for zone_distribution_config in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterZoneDistributionConfigBlock
{
    /// <summary>
    /// Immutable. The mode for zone distribution for Memorystore Redis cluster.
    /// If not provided, MULTI_ZONE will be used as default Possible values: [&amp;quot;MULTI_ZONE&amp;quot;, &amp;quot;SINGLE_ZONE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mode { get; set; } = default!;

    /// <summary>
    /// Immutable. The zone for single zone Memorystore Redis cluster.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Zone { get; set; }

}

/// <summary>
/// Manages a google_redis_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleRedisCluster : TerraformResource
{
    public GoogleRedisCluster(string name) : base("google_redis_cluster", name)
    {
    }

    /// <summary>
    /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value: &amp;quot;AUTH_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;AUTH_MODE_UNSPECIFIED&amp;quot;, &amp;quot;AUTH_MODE_IAM_AUTH&amp;quot;, &amp;quot;AUTH_MODE_DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("authorization_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthorizationMode { get; set; }

    /// <summary>
    /// Optional. Indicates if the cluster is deletion protected or not.
    /// If the value if set to true, any delete cluster operation will fail.
    /// Default value is true.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    [TerraformPropertyName("maintenance_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaintenanceVersion { get; set; }

    /// <summary>
    /// Unique name of the resource in this scope including project and location using the form:
    /// projects/{projectId}/locations/{locationId}/clusters/{clusterId}
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The nodeType for the Redis cluster.
    /// If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values: [&amp;quot;REDIS_SHARED_CORE_NANO&amp;quot;, &amp;quot;REDIS_HIGHMEM_MEDIUM&amp;quot;, &amp;quot;REDIS_HIGHMEM_XLARGE&amp;quot;, &amp;quot;REDIS_STANDARD_SMALL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NodeType { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Configure Redis Cluster behavior using a subset of native Redis configuration parameters.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations
    /// </summary>
    [TerraformPropertyName("redis_configs")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? RedisConfigs { get; set; }

    /// <summary>
    /// The name of the region of the Redis cluster.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Optional. The number of replica nodes per shard.
    /// </summary>
    [TerraformPropertyName("replica_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ReplicaCount { get; set; }

    /// <summary>
    /// Required. Number of shards for the Redis cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShardCount is required")]
    [TerraformPropertyName("shard_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ShardCount { get; set; }

    /// <summary>
    /// Optional. The in-transit encryption for the Redis cluster.
    /// If not provided, encryption is disabled for the cluster. Default value: &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;TRANSIT_ENCRYPTION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION&amp;quot;]
    /// </summary>
    [TerraformPropertyName("transit_encryption_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransitEncryptionMode { get; set; }

    /// <summary>
    /// Block for automated_backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupConfig block(s) allowed")]
    [TerraformPropertyName("automated_backup_config")]
    public TerraformList<TerraformBlock<GoogleRedisClusterAutomatedBackupConfigBlock>>? AutomatedBackupConfig { get; set; }

    /// <summary>
    /// Block for cross_cluster_replication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CrossClusterReplicationConfig block(s) allowed")]
    [TerraformPropertyName("cross_cluster_replication_config")]
    public TerraformList<TerraformBlock<GoogleRedisClusterCrossClusterReplicationConfigBlock>>? CrossClusterReplicationConfig { get; set; }

    /// <summary>
    /// Block for gcs_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsSource block(s) allowed")]
    [TerraformPropertyName("gcs_source")]
    public TerraformList<TerraformBlock<GoogleRedisClusterGcsSourceBlock>>? GcsSource { get; set; }

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    [TerraformPropertyName("maintenance_policy")]
    public TerraformList<TerraformBlock<GoogleRedisClusterMaintenancePolicyBlock>>? MaintenancePolicy { get; set; }

    /// <summary>
    /// Block for managed_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedBackupSource block(s) allowed")]
    [TerraformPropertyName("managed_backup_source")]
    public TerraformList<TerraformBlock<GoogleRedisClusterManagedBackupSourceBlock>>? ManagedBackupSource { get; set; }

    /// <summary>
    /// Block for persistence_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistenceConfig block(s) allowed")]
    [TerraformPropertyName("persistence_config")]
    public TerraformList<TerraformBlock<GoogleRedisClusterPersistenceConfigBlock>>? PersistenceConfig { get; set; }

    /// <summary>
    /// Block for psc_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("psc_configs")]
    public TerraformList<TerraformBlock<GoogleRedisClusterPscConfigsBlock>>? PscConfigs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleRedisClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for zone_distribution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZoneDistributionConfig block(s) allowed")]
    [TerraformPropertyName("zone_distribution_config")]
    public TerraformList<TerraformBlock<GoogleRedisClusterZoneDistributionConfigBlock>>? ZoneDistributionConfig { get; set; }

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
    /// Upcoming maintenance schedule.
    /// </summary>
    [TerraformPropertyName("maintenance_schedule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceSchedule => new TerraformReference(this, "maintenance_schedule");

    /// <summary>
    /// Cluster&#39;s Certificate Authority. This field will only be populated if Redis Cluster&#39;s transit_encryption_mode is TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION
    /// </summary>
    [TerraformPropertyName("managed_server_ca")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagedServerCa => new TerraformReference(this, "managed_server_ca");

    /// <summary>
    /// Output only. Redis memory precise size in GB for the entire cluster.
    /// </summary>
    [TerraformPropertyName("precise_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PreciseSizeGb => new TerraformReference(this, "precise_size_gb");

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
    /// System assigned, unique identifier for the cluster.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

}
