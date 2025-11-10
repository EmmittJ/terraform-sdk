using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_redis_cluster.
/// </summary>
public class GoogleRedisClusterDataSource : TerraformDataSource
{
    public GoogleRedisClusterDataSource(string name) : base("google_redis_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("authorization_mode");
        this.WithOutput("automated_backup_config");
        this.WithOutput("available_maintenance_versions");
        this.WithOutput("backup_collection");
        this.WithOutput("create_time");
        this.WithOutput("cross_cluster_replication_config");
        this.WithOutput("deletion_protection_enabled");
        this.WithOutput("discovery_endpoints");
        this.WithOutput("effective_maintenance_version");
        this.WithOutput("gcs_source");
        this.WithOutput("kms_key");
        this.WithOutput("maintenance_policy");
        this.WithOutput("maintenance_schedule");
        this.WithOutput("maintenance_version");
        this.WithOutput("managed_backup_source");
        this.WithOutput("managed_server_ca");
        this.WithOutput("node_type");
        this.WithOutput("persistence_config");
        this.WithOutput("precise_size_gb");
        this.WithOutput("psc_configs");
        this.WithOutput("psc_connections");
        this.WithOutput("psc_service_attachments");
        this.WithOutput("redis_configs");
        this.WithOutput("replica_count");
        this.WithOutput("shard_count");
        this.WithOutput("size_gb");
        this.WithOutput("state");
        this.WithOutput("state_info");
        this.WithOutput("transit_encryption_mode");
        this.WithOutput("uid");
        this.WithOutput("zone_distribution_config");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Unique name of the resource in this scope including project and location using the form:
    /// projects/{projectId}/locations/{locationId}/clusters/{clusterId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the region of the Redis cluster.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value: &amp;quot;AUTH_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;AUTH_MODE_UNSPECIFIED&amp;quot;, &amp;quot;AUTH_MODE_IAM_AUTH&amp;quot;, &amp;quot;AUTH_MODE_DISABLED&amp;quot;]
    /// </summary>
    public TerraformExpression AuthorizationMode => this["authorization_mode"];

    /// <summary>
    /// The automated backup config for a instance.
    /// </summary>
    public TerraformExpression AutomatedBackupConfig => this["automated_backup_config"];

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
    /// Cross cluster replication config
    /// </summary>
    public TerraformExpression CrossClusterReplicationConfig => this["cross_cluster_replication_config"];

    /// <summary>
    /// Optional. Indicates if the cluster is deletion protected or not.
    /// If the value if set to true, any delete cluster operation will fail.
    /// Default value is true.
    /// </summary>
    public TerraformExpression DeletionProtectionEnabled => this["deletion_protection_enabled"];

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
    /// Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters.
    /// </summary>
    public TerraformExpression GcsSource => this["gcs_source"];

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster.
    /// </summary>
    public TerraformExpression KmsKey => this["kms_key"];

    /// <summary>
    /// Maintenance policy for a cluster
    /// </summary>
    public TerraformExpression MaintenancePolicy => this["maintenance_policy"];

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformExpression MaintenanceSchedule => this["maintenance_schedule"];

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    public TerraformExpression MaintenanceVersion => this["maintenance_version"];

    /// <summary>
    /// Backups that generated and managed by memorystore.
    /// </summary>
    public TerraformExpression ManagedBackupSource => this["managed_backup_source"];

    /// <summary>
    /// Cluster&#39;s Certificate Authority. This field will only be populated if Redis Cluster&#39;s transit_encryption_mode is TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION
    /// </summary>
    public TerraformExpression ManagedServerCa => this["managed_server_ca"];

    /// <summary>
    /// The nodeType for the Redis cluster.
    /// If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values: [&amp;quot;REDIS_SHARED_CORE_NANO&amp;quot;, &amp;quot;REDIS_HIGHMEM_MEDIUM&amp;quot;, &amp;quot;REDIS_HIGHMEM_XLARGE&amp;quot;, &amp;quot;REDIS_STANDARD_SMALL&amp;quot;]
    /// </summary>
    public TerraformExpression NodeType => this["node_type"];

    /// <summary>
    /// Persistence config (RDB, AOF) for the cluster.
    /// </summary>
    public TerraformExpression PersistenceConfig => this["persistence_config"];

    /// <summary>
    /// Output only. Redis memory precise size in GB for the entire cluster.
    /// </summary>
    public TerraformExpression PreciseSizeGb => this["precise_size_gb"];

    /// <summary>
    /// Required. Each PscConfig configures the consumer network where two
    /// network addresses will be designated to the cluster for client access.
    /// Currently, only one PscConfig is supported.
    /// </summary>
    public TerraformExpression PscConfigs => this["psc_configs"];

    /// <summary>
    /// Output only. PSC connections for discovery of the cluster topology and accessing the cluster.
    /// </summary>
    public TerraformExpression PscConnections => this["psc_connections"];

    /// <summary>
    /// Service attachment details to configure Psc connections.
    /// </summary>
    public TerraformExpression PscServiceAttachments => this["psc_service_attachments"];

    /// <summary>
    /// Configure Redis Cluster behavior using a subset of native Redis configuration parameters.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations
    /// </summary>
    public TerraformExpression RedisConfigs => this["redis_configs"];

    /// <summary>
    /// Optional. The number of replica nodes per shard.
    /// </summary>
    public TerraformExpression ReplicaCount => this["replica_count"];

    /// <summary>
    /// Required. Number of shards for the Redis cluster.
    /// </summary>
    public TerraformExpression ShardCount => this["shard_count"];

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
    /// Optional. The in-transit encryption for the Redis cluster.
    /// If not provided, encryption is disabled for the cluster. Default value: &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;TRANSIT_ENCRYPTION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION&amp;quot;]
    /// </summary>
    public TerraformExpression TransitEncryptionMode => this["transit_encryption_mode"];

    /// <summary>
    /// System assigned, unique identifier for the cluster.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Immutable. Zone distribution config for Memorystore Redis cluster.
    /// </summary>
    public TerraformExpression ZoneDistributionConfig => this["zone_distribution_config"];

}
