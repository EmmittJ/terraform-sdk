using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisInstanceMaintenancePolicyBlock : TerraformBlock
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
    /// Optional. Description of what this policy is for.
    /// Create/Update methods return INVALID_ARGUMENT if the
    /// length is greater than 512.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
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
/// Block type for persistence_config in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisInstancePersistenceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.
    /// 
    /// - DISABLED: 	Persistence is disabled for the instance, and any existing snapshots are deleted.
    /// - RDB: RDB based Persistence is enabled. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;RDB&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? PersistenceMode
    {
        set => SetProperty("persistence_mode", value);
    }

    /// <summary>
    /// Output only. The next time that a snapshot attempt is scheduled to occur.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up
    /// to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? RdbNextSnapshotTime
    {
        set => SetProperty("rdb_next_snapshot_time", value);
    }

    /// <summary>
    /// Optional. Available snapshot periods for scheduling.
    /// 
    /// - ONE_HOUR:	Snapshot every 1 hour.
    /// - SIX_HOURS:	Snapshot every 6 hours.
    /// - TWELVE_HOURS:	Snapshot every 12 hours.
    /// - TWENTY_FOUR_HOURS:	Snapshot every 24 hours. Possible values: [&amp;quot;ONE_HOUR&amp;quot;, &amp;quot;SIX_HOURS&amp;quot;, &amp;quot;TWELVE_HOURS&amp;quot;, &amp;quot;TWENTY_FOUR_HOURS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RdbSnapshotPeriod
    {
        set => SetProperty("rdb_snapshot_period", value);
    }

    /// <summary>
    /// Optional. Date and time that the first snapshot was/will be attempted,
    /// and to which future snapshots will be aligned. If not provided,
    /// the current time will be used.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution
    /// and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? RdbSnapshotStartTime
    {
        set => SetProperty("rdb_snapshot_start_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleRedisInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a google_redis_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleRedisInstance : TerraformResource
{
    public GoogleRedisInstance(string name) : base("google_redis_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auth_string");
        SetOutput("create_time");
        SetOutput("current_location_id");
        SetOutput("effective_labels");
        SetOutput("effective_reserved_ip_range");
        SetOutput("host");
        SetOutput("maintenance_schedule");
        SetOutput("nodes");
        SetOutput("persistence_iam_identity");
        SetOutput("port");
        SetOutput("read_endpoint");
        SetOutput("read_endpoint_port");
        SetOutput("server_ca_certs");
        SetOutput("terraform_labels");
        SetOutput("alternative_location_id");
        SetOutput("auth_enabled");
        SetOutput("authorized_network");
        SetOutput("connect_mode");
        SetOutput("customer_managed_key");
        SetOutput("deletion_protection");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location_id");
        SetOutput("maintenance_version");
        SetOutput("memory_size_gb");
        SetOutput("name");
        SetOutput("project");
        SetOutput("read_replicas_mode");
        SetOutput("redis_configs");
        SetOutput("redis_version");
        SetOutput("region");
        SetOutput("replica_count");
        SetOutput("reserved_ip_range");
        SetOutput("secondary_ip_range");
        SetOutput("tier");
        SetOutput("transit_encryption_mode");
    }

    /// <summary>
    /// Only applicable to STANDARD_HA tier which protects the instance
    /// against zonal failures by provisioning it across two zones.
    /// If provided, it must be a different zone from the one provided in
    /// [locationId].
    /// </summary>
    public TerraformProperty<string> AlternativeLocationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alternative_location_id");
        set => SetProperty("alternative_location_id", value);
    }

    /// <summary>
    /// Optional. Indicates whether OSS Redis AUTH is enabled for the
    /// instance. If set to &amp;quot;true&amp;quot; AUTH is enabled on the instance.
    /// Default value is &amp;quot;false&amp;quot; meaning AUTH is disabled.
    /// </summary>
    public TerraformProperty<bool> AuthEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auth_enabled");
        set => SetProperty("auth_enabled", value);
    }

    /// <summary>
    /// The full name of the Google Compute Engine network to which the
    /// instance is connected. If left unspecified, the default network
    /// will be used.
    /// </summary>
    public TerraformProperty<string> AuthorizedNetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorized_network");
        set => SetProperty("authorized_network", value);
    }

    /// <summary>
    /// The connection mode of the Redis instance. Default value: &amp;quot;DIRECT_PEERING&amp;quot; Possible values: [&amp;quot;DIRECT_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;]
    /// </summary>
    public TerraformProperty<string> ConnectMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connect_mode");
        set => SetProperty("connect_mode", value);
    }

    /// <summary>
    /// Optional. The KMS key reference that you want to use to encrypt the data at rest for this Redis
    /// instance. If this is provided, CMEK is enabled.
    /// </summary>
    public TerraformProperty<string> CustomerManagedKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_managed_key");
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// An arbitrary and optional user-provided name for the instance.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// Resource labels to represent user provided metadata.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The zone where the instance will be provisioned. If not provided,
    /// the service will choose a zone for the instance. For STANDARD_HA tier,
    /// instances will be created across two zones for protection against
    /// zonal failures. If [alternativeLocationId] is also provided, it must
    /// be different from [locationId].
    /// </summary>
    public TerraformProperty<string> LocationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location_id");
        set => SetProperty("location_id", value);
    }

    /// <summary>
    /// The self service update maintenance version.
    /// </summary>
    public TerraformProperty<string> MaintenanceVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_version");
        set => SetProperty("maintenance_version", value);
    }

    /// <summary>
    /// Redis memory size in GiB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemorySizeGb is required")]
    public required TerraformProperty<double> MemorySizeGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("memory_size_gb");
        set => SetProperty("memory_size_gb", value);
    }

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Optional. Read replica mode. Can only be specified when trying to create the instance.
    /// If not set, Memorystore Redis backend will default to READ_REPLICAS_DISABLED.
    /// - READ_REPLICAS_DISABLED: If disabled, read endpoint will not be provided and the
    /// instance cannot scale up or down the number of replicas.
    /// - READ_REPLICAS_ENABLED: If enabled, read endpoint will be provided and the instance
    /// can scale up and down the number of replicas. Possible values: [&amp;quot;READ_REPLICAS_DISABLED&amp;quot;, &amp;quot;READ_REPLICAS_ENABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> ReadReplicasMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("read_replicas_mode");
        set => SetProperty("read_replicas_mode", value);
    }

    /// <summary>
    /// Redis configuration parameters, according to http://redis.io/topics/config.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> RedisConfigs
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("redis_configs");
        set => SetProperty("redis_configs", value);
    }

    /// <summary>
    /// The version of Redis software. If not provided, latest supported
    /// version will be used. Please check the API documentation linked
    /// at the top for the latest valid values.
    /// </summary>
    public TerraformProperty<string> RedisVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redis_version");
        set => SetProperty("redis_version", value);
    }

    /// <summary>
    /// The name of the Redis region of the instance.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Optional. The number of replica nodes. The valid range for the Standard Tier with
    /// read replicas enabled is [1-5] and defaults to 2. If read replicas are not enabled
    /// for a Standard Tier instance, the only valid value is 1 and the default is 1.
    /// The valid value for basic tier is 0 and the default is also 0.
    /// </summary>
    public TerraformProperty<double> ReplicaCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replica_count");
        set => SetProperty("replica_count", value);
    }

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this
    /// instance. If not provided, the service will choose an unused /29
    /// block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
    /// unique and non-overlapping with existing subnets in an authorized
    /// network.
    /// </summary>
    public TerraformProperty<string> ReservedIpRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reserved_ip_range");
        set => SetProperty("reserved_ip_range", value);
    }

    /// <summary>
    /// Optional. Additional IP range for node placement. Required when enabling read replicas on
    /// an existing instance. For DIRECT_PEERING mode value must be a CIDR range of size /28, or
    /// &amp;quot;auto&amp;quot;. For PRIVATE_SERVICE_ACCESS mode value must be the name of an allocated address
    /// range associated with the private service access connection, or &amp;quot;auto&amp;quot;.
    /// </summary>
    public TerraformProperty<string> SecondaryIpRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secondary_ip_range");
        set => SetProperty("secondary_ip_range", value);
    }

    /// <summary>
    /// The service tier of the instance. Must be one of these values:
    /// 
    /// - BASIC: standalone instance
    /// - STANDARD_HA: highly available primary/replica instances Default value: &amp;quot;BASIC&amp;quot; Possible values: [&amp;quot;BASIC&amp;quot;, &amp;quot;STANDARD_HA&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// The TLS mode of the Redis instance, If not provided, TLS is disabled for the instance.
    /// 
    /// - SERVER_AUTHENTICATION: Client to Server traffic encryption enabled with server authentication Default value: &amp;quot;DISABLED&amp;quot; Possible values: [&amp;quot;SERVER_AUTHENTICATION&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> TransitEncryptionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_encryption_mode");
        set => SetProperty("transit_encryption_mode", value);
    }

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    public List<GoogleRedisInstanceMaintenancePolicyBlock>? MaintenancePolicy
    {
        set => SetProperty("maintenance_policy", value);
    }

    /// <summary>
    /// Block for persistence_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistenceConfig block(s) allowed")]
    public List<GoogleRedisInstancePersistenceConfigBlock>? PersistenceConfig
    {
        set => SetProperty("persistence_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleRedisInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// AUTH String set on the instance. This field will only be populated if auth_enabled is true.
    /// </summary>
    public TerraformExpression AuthString => this["auth_string"];

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The current zone where the Redis endpoint is placed.
    /// For Basic Tier instances, this will always be the same as the
    /// [locationId] provided by the user at creation time. For Standard Tier
    /// instances, this can be either [locationId] or [alternativeLocationId]
    /// and can change after a failover event.
    /// </summary>
    public TerraformExpression CurrentLocationId => this["current_location_id"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this
    /// instance. If not provided, the service will choose an unused /29
    /// block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
    /// unique and non-overlapping with existing subnets in an authorized
    /// network.
    /// </summary>
    public TerraformExpression EffectiveReservedIpRange => this["effective_reserved_ip_range"];

    /// <summary>
    /// Hostname or IP address of the exposed Redis endpoint used by clients
    /// to connect to the service.
    /// </summary>
    public TerraformExpression Host => this["host"];

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformExpression MaintenanceSchedule => this["maintenance_schedule"];

    /// <summary>
    /// Output only. Info per node.
    /// </summary>
    public TerraformExpression Nodes => this["nodes"];

    /// <summary>
    /// Output only. Cloud IAM identity used by import / export operations
    /// to transfer data to/from Cloud Storage. Format is &amp;quot;serviceAccount:&amp;quot;.
    /// The value may change over time for a given instance so should be
    /// checked before each import/export operation.
    /// </summary>
    public TerraformExpression PersistenceIamIdentity => this["persistence_iam_identity"];

    /// <summary>
    /// The port number of the exposed Redis endpoint.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// Output only. Hostname or IP address of the exposed readonly Redis endpoint. Standard tier only.
    /// Targets all healthy replica nodes in instance. Replication is asynchronous and replica nodes
    /// will exhibit some lag behind the primary. Write requests must target &#39;host&#39;.
    /// </summary>
    public TerraformExpression ReadEndpoint => this["read_endpoint"];

    /// <summary>
    /// Output only. The port number of the exposed readonly redis endpoint. Standard tier only.
    /// Write requests should target &#39;port&#39;.
    /// </summary>
    public TerraformExpression ReadEndpointPort => this["read_endpoint_port"];

    /// <summary>
    /// List of server CA certificates for the instance.
    /// </summary>
    public TerraformExpression ServerCaCerts => this["server_ca_certs"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
