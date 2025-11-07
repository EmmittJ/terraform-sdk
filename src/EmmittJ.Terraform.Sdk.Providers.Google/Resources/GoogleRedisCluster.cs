using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_redis_cluster resource.
/// </summary>
public class GoogleRedisCluster : TerraformResource
{
    public GoogleRedisCluster(string name) : base("google_redis_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("available_maintenance_versions");
        this.DeclareOutput("backup_collection");
        this.DeclareOutput("create_time");
        this.DeclareOutput("discovery_endpoints");
        this.DeclareOutput("effective_maintenance_version");
        this.DeclareOutput("maintenance_schedule");
        this.DeclareOutput("managed_server_ca");
        this.DeclareOutput("precise_size_gb");
        this.DeclareOutput("psc_connections");
        this.DeclareOutput("psc_service_attachments");
        this.DeclareOutput("size_gb");
        this.DeclareOutput("state");
        this.DeclareOutput("state_info");
        this.DeclareOutput("uid");
    }

    /// <summary>
    /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value: &amp;quot;AUTH_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;AUTH_MODE_UNSPECIFIED&amp;quot;, &amp;quot;AUTH_MODE_IAM_AUTH&amp;quot;, &amp;quot;AUTH_MODE_DISABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AuthorizationMode
    {
        get => GetProperty<TerraformProperty<string>>("authorization_mode");
        set => this.WithProperty("authorization_mode", value);
    }

    /// <summary>
    /// Optional. Indicates if the cluster is deletion protected or not.
    /// If the value if set to true, any delete cluster operation will fail.
    /// Default value is true.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection_enabled");
        set => this.WithProperty("deletion_protection_enabled", value);
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
    /// The KMS key used to encrypt the at-rest data of the cluster.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => this.WithProperty("kms_key", value);
    }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    public TerraformProperty<string>? MaintenanceVersion
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_version");
        set => this.WithProperty("maintenance_version", value);
    }

    /// <summary>
    /// Unique name of the resource in this scope including project and location using the form:
    /// projects/{projectId}/locations/{locationId}/clusters/{clusterId}
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The nodeType for the Redis cluster.
    /// If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values: [&amp;quot;REDIS_SHARED_CORE_NANO&amp;quot;, &amp;quot;REDIS_HIGHMEM_MEDIUM&amp;quot;, &amp;quot;REDIS_HIGHMEM_XLARGE&amp;quot;, &amp;quot;REDIS_STANDARD_SMALL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? NodeType
    {
        get => GetProperty<TerraformProperty<string>>("node_type");
        set => this.WithProperty("node_type", value);
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
    /// Configure Redis Cluster behavior using a subset of native Redis configuration parameters.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? RedisConfigs
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("redis_configs");
        set => this.WithProperty("redis_configs", value);
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
    /// Optional. The number of replica nodes per shard.
    /// </summary>
    public TerraformProperty<double>? ReplicaCount
    {
        get => GetProperty<TerraformProperty<double>>("replica_count");
        set => this.WithProperty("replica_count", value);
    }

    /// <summary>
    /// Required. Number of shards for the Redis cluster.
    /// </summary>
    public TerraformProperty<double>? ShardCount
    {
        get => GetProperty<TerraformProperty<double>>("shard_count");
        set => this.WithProperty("shard_count", value);
    }

    /// <summary>
    /// Optional. The in-transit encryption for the Redis cluster.
    /// If not provided, encryption is disabled for the cluster. Default value: &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;TRANSIT_ENCRYPTION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? TransitEncryptionMode
    {
        get => GetProperty<TerraformProperty<string>>("transit_encryption_mode");
        set => this.WithProperty("transit_encryption_mode", value);
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
