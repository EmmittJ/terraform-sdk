using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_config in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterAutomatedBackupConfigBlock : TerraformBlock
{
    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    public required TerraformProperty<string> Retention
    {
        set => SetProperty("retention", value);
    }

}

/// <summary>
/// Block type for cross_cluster_replication_config in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterCrossClusterReplicationConfigBlock : TerraformBlock
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
    public TerraformProperty<string>? ClusterRole
    {
        set => SetProperty("cluster_role", value);
    }

    /// <summary>
    /// An output only view of all the member clusters participating in cross cluster replication. This field is populated for all the member clusters irrespective of their cluster role.
    /// </summary>
    public List<TerraformProperty<object>>? Membership
    {
        set => SetProperty("membership", value);
    }

    /// <summary>
    /// The last time cross cluster replication config was updated.
    /// </summary>
    public TerraformProperty<string>? UpdateTime
    {
        set => SetProperty("update_time", value);
    }

}

/// <summary>
/// Block type for gcs_source in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterGcsSourceBlock : TerraformBlock
{
    /// <summary>
    /// URIs of the GCS objects to import. Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    public HashSet<TerraformProperty<string>>? Uris
    {
        set => SetProperty("uris", value);
    }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Output only. The time when the policy was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    public TerraformProperty<string>? CreateTime
    {
        set => SetProperty("create_time", value);
    }

    /// <summary>
    /// Output only. The time when the policy was last updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    public TerraformProperty<string>? UpdateTime
    {
        set => SetProperty("update_time", value);
    }

}

/// <summary>
/// Block type for managed_backup_source in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterManagedBackupSourceBlock : TerraformBlock
{
    /// <summary>
    /// Example: &#39;projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    public required TerraformProperty<string> Backup
    {
        set => SetProperty("backup", value);
    }

}

/// <summary>
/// Block type for persistence_config in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterPersistenceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.
    /// 
    /// - DISABLED: 	Persistence (both backup and restore) is disabled for the cluster.
    /// - RDB: RDB based Persistence is enabled.
    /// - AOF: AOF based Persistence is enabled. Possible values: [&amp;quot;PERSISTENCE_MODE_UNSPECIFIED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;RDB&amp;quot;, &amp;quot;AOF&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

}

/// <summary>
/// Block type for psc_configs in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterPscConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Required. The consumer network where the network address of
    /// the discovery endpoint will be reserved, in the form of
    /// projects/{network_project_id_or_number}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        set => SetProperty("network", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleRedisClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for zone_distribution_config in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterZoneDistributionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Immutable. The mode for zone distribution for Memorystore Redis cluster.
    /// If not provided, MULTI_ZONE will be used as default Possible values: [&amp;quot;MULTI_ZONE&amp;quot;, &amp;quot;SINGLE_ZONE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// Immutable. The zone for single zone Memorystore Redis cluster.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        set => SetProperty("zone", value);
    }

}

/// <summary>
/// Manages a google_redis_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleRedisCluster : TerraformResource
{
    public GoogleRedisCluster(string name) : base("google_redis_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("available_maintenance_versions");
        SetOutput("backup_collection");
        SetOutput("create_time");
        SetOutput("discovery_endpoints");
        SetOutput("effective_maintenance_version");
        SetOutput("maintenance_schedule");
        SetOutput("managed_server_ca");
        SetOutput("precise_size_gb");
        SetOutput("psc_connections");
        SetOutput("psc_service_attachments");
        SetOutput("size_gb");
        SetOutput("state");
        SetOutput("state_info");
        SetOutput("uid");
        SetOutput("authorization_mode");
        SetOutput("deletion_protection_enabled");
        SetOutput("id");
        SetOutput("kms_key");
        SetOutput("maintenance_version");
        SetOutput("name");
        SetOutput("node_type");
        SetOutput("project");
        SetOutput("redis_configs");
        SetOutput("region");
        SetOutput("replica_count");
        SetOutput("shard_count");
        SetOutput("transit_encryption_mode");
    }

    /// <summary>
    /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value: &amp;quot;AUTH_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;AUTH_MODE_UNSPECIFIED&amp;quot;, &amp;quot;AUTH_MODE_IAM_AUTH&amp;quot;, &amp;quot;AUTH_MODE_DISABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> AuthorizationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorization_mode");
        set => SetProperty("authorization_mode", value);
    }

    /// <summary>
    /// Optional. Indicates if the cluster is deletion protected or not.
    /// If the value if set to true, any delete cluster operation will fail.
    /// Default value is true.
    /// </summary>
    public TerraformProperty<bool> DeletionProtectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection_enabled");
        set => SetProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster.
    /// </summary>
    public TerraformProperty<string> KmsKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key");
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    public TerraformProperty<string> MaintenanceVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_version");
        set => SetProperty("maintenance_version", value);
    }

    /// <summary>
    /// Unique name of the resource in this scope including project and location using the form:
    /// projects/{projectId}/locations/{locationId}/clusters/{clusterId}
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The nodeType for the Redis cluster.
    /// If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values: [&amp;quot;REDIS_SHARED_CORE_NANO&amp;quot;, &amp;quot;REDIS_HIGHMEM_MEDIUM&amp;quot;, &amp;quot;REDIS_HIGHMEM_XLARGE&amp;quot;, &amp;quot;REDIS_STANDARD_SMALL&amp;quot;]
    /// </summary>
    public TerraformProperty<string> NodeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_type");
        set => SetProperty("node_type", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Configure Redis Cluster behavior using a subset of native Redis configuration parameters.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> RedisConfigs
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("redis_configs");
        set => SetProperty("redis_configs", value);
    }

    /// <summary>
    /// The name of the region of the Redis cluster.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Optional. The number of replica nodes per shard.
    /// </summary>
    public TerraformProperty<double> ReplicaCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replica_count");
        set => SetProperty("replica_count", value);
    }

    /// <summary>
    /// Required. Number of shards for the Redis cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShardCount is required")]
    public required TerraformProperty<double> ShardCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("shard_count");
        set => SetProperty("shard_count", value);
    }

    /// <summary>
    /// Optional. The in-transit encryption for the Redis cluster.
    /// If not provided, encryption is disabled for the cluster. Default value: &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;TRANSIT_ENCRYPTION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION&amp;quot;]
    /// </summary>
    public TerraformProperty<string> TransitEncryptionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_encryption_mode");
        set => SetProperty("transit_encryption_mode", value);
    }

    /// <summary>
    /// Block for automated_backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupConfig block(s) allowed")]
    public List<GoogleRedisClusterAutomatedBackupConfigBlock>? AutomatedBackupConfig
    {
        set => SetProperty("automated_backup_config", value);
    }

    /// <summary>
    /// Block for cross_cluster_replication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CrossClusterReplicationConfig block(s) allowed")]
    public List<GoogleRedisClusterCrossClusterReplicationConfigBlock>? CrossClusterReplicationConfig
    {
        set => SetProperty("cross_cluster_replication_config", value);
    }

    /// <summary>
    /// Block for gcs_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsSource block(s) allowed")]
    public List<GoogleRedisClusterGcsSourceBlock>? GcsSource
    {
        set => SetProperty("gcs_source", value);
    }

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    public List<GoogleRedisClusterMaintenancePolicyBlock>? MaintenancePolicy
    {
        set => SetProperty("maintenance_policy", value);
    }

    /// <summary>
    /// Block for managed_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedBackupSource block(s) allowed")]
    public List<GoogleRedisClusterManagedBackupSourceBlock>? ManagedBackupSource
    {
        set => SetProperty("managed_backup_source", value);
    }

    /// <summary>
    /// Block for persistence_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistenceConfig block(s) allowed")]
    public List<GoogleRedisClusterPersistenceConfigBlock>? PersistenceConfig
    {
        set => SetProperty("persistence_config", value);
    }

    /// <summary>
    /// Block for psc_configs.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleRedisClusterPscConfigsBlock>? PscConfigs
    {
        set => SetProperty("psc_configs", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleRedisClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for zone_distribution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZoneDistributionConfig block(s) allowed")]
    public List<GoogleRedisClusterZoneDistributionConfigBlock>? ZoneDistributionConfig
    {
        set => SetProperty("zone_distribution_config", value);
    }

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    public TerraformExpression AvailableMaintenanceVersions => this["available_maintenance_versions"];

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    public TerraformExpression BackupCollection => this["backup_collection"];

    /// <summary>
    /// The timestamp associated with the cluster creation request. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. Endpoints created on each given network,
    /// for Redis clients to connect to the cluster.
    /// Currently only one endpoint is supported.
    /// </summary>
    public TerraformExpression DiscoveryEndpoints => this["discovery_endpoints"];

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    public TerraformExpression EffectiveMaintenanceVersion => this["effective_maintenance_version"];

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformExpression MaintenanceSchedule => this["maintenance_schedule"];

    /// <summary>
    /// Cluster&#39;s Certificate Authority. This field will only be populated if Redis Cluster&#39;s transit_encryption_mode is TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION
    /// </summary>
    public TerraformExpression ManagedServerCa => this["managed_server_ca"];

    /// <summary>
    /// Output only. Redis memory precise size in GB for the entire cluster.
    /// </summary>
    public TerraformExpression PreciseSizeGb => this["precise_size_gb"];

    /// <summary>
    /// Output only. PSC connections for discovery of the cluster topology and accessing the cluster.
    /// </summary>
    public TerraformExpression PscConnections => this["psc_connections"];

    /// <summary>
    /// Service attachment details to configure Psc connections.
    /// </summary>
    public TerraformExpression PscServiceAttachments => this["psc_service_attachments"];

    /// <summary>
    /// Output only. Redis memory size in GB for the entire cluster.
    /// </summary>
    public TerraformExpression SizeGb => this["size_gb"];

    /// <summary>
    /// The current state of this cluster. Can be CREATING, READY, UPDATING, DELETING and SUSPENDED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. Additional information about the current state of the cluster.
    /// </summary>
    public TerraformExpression StateInfo => this["state_info"];

    /// <summary>
    /// System assigned, unique identifier for the cluster.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

}
