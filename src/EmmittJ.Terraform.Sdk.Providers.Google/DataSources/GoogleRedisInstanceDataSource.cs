using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_redis_instance.
/// </summary>
public class GoogleRedisInstanceDataSource : TerraformDataSource
{
    public GoogleRedisInstanceDataSource(string name) : base("google_redis_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alternative_location_id");
        this.DeclareOutput("auth_enabled");
        this.DeclareOutput("auth_string");
        this.DeclareOutput("authorized_network");
        this.DeclareOutput("connect_mode");
        this.DeclareOutput("create_time");
        this.DeclareOutput("current_location_id");
        this.DeclareOutput("customer_managed_key");
        this.DeclareOutput("deletion_protection");
        this.DeclareOutput("display_name");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("effective_reserved_ip_range");
        this.DeclareOutput("host");
        this.DeclareOutput("labels");
        this.DeclareOutput("location_id");
        this.DeclareOutput("maintenance_policy");
        this.DeclareOutput("maintenance_schedule");
        this.DeclareOutput("maintenance_version");
        this.DeclareOutput("memory_size_gb");
        this.DeclareOutput("nodes");
        this.DeclareOutput("persistence_config");
        this.DeclareOutput("persistence_iam_identity");
        this.DeclareOutput("port");
        this.DeclareOutput("read_endpoint");
        this.DeclareOutput("read_endpoint_port");
        this.DeclareOutput("read_replicas_mode");
        this.DeclareOutput("redis_configs");
        this.DeclareOutput("redis_version");
        this.DeclareOutput("replica_count");
        this.DeclareOutput("reserved_ip_range");
        this.DeclareOutput("secondary_ip_range");
        this.DeclareOutput("server_ca_certs");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("tier");
        this.DeclareOutput("transit_encryption_mode");
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
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    /// The name of the Redis region of the instance.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Only applicable to STANDARD_HA tier which protects the instance
    /// against zonal failures by provisioning it across two zones.
    /// If provided, it must be a different zone from the one provided in
    /// [locationId].
    /// </summary>
    public TerraformExpression AlternativeLocationId => this["alternative_location_id"];

    /// <summary>
    /// Optional. Indicates whether OSS Redis AUTH is enabled for the
    /// instance. If set to &amp;quot;true&amp;quot; AUTH is enabled on the instance.
    /// Default value is &amp;quot;false&amp;quot; meaning AUTH is disabled.
    /// </summary>
    public TerraformExpression AuthEnabled => this["auth_enabled"];

    /// <summary>
    /// AUTH String set on the instance. This field will only be populated if auth_enabled is true.
    /// </summary>
    public TerraformExpression AuthString => this["auth_string"];

    /// <summary>
    /// The full name of the Google Compute Engine network to which the
    /// instance is connected. If left unspecified, the default network
    /// will be used.
    /// </summary>
    public TerraformExpression AuthorizedNetwork => this["authorized_network"];

    /// <summary>
    /// The connection mode of the Redis instance. Default value: &amp;quot;DIRECT_PEERING&amp;quot; Possible values: [&amp;quot;DIRECT_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;]
    /// </summary>
    public TerraformExpression ConnectMode => this["connect_mode"];

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
    /// Optional. The KMS key reference that you want to use to encrypt the data at rest for this Redis
    /// instance. If this is provided, CMEK is enabled.
    /// </summary>
    public TerraformExpression CustomerManagedKey => this["customer_managed_key"];

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// An arbitrary and optional user-provided name for the instance.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

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
    /// Resource labels to represent user provided metadata.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The zone where the instance will be provisioned. If not provided,
    /// the service will choose a zone for the instance. For STANDARD_HA tier,
    /// instances will be created across two zones for protection against
    /// zonal failures. If [alternativeLocationId] is also provided, it must
    /// be different from [locationId].
    /// </summary>
    public TerraformExpression LocationId => this["location_id"];

    /// <summary>
    /// Maintenance policy for an instance.
    /// </summary>
    public TerraformExpression MaintenancePolicy => this["maintenance_policy"];

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformExpression MaintenanceSchedule => this["maintenance_schedule"];

    /// <summary>
    /// The self service update maintenance version.
    /// </summary>
    public TerraformExpression MaintenanceVersion => this["maintenance_version"];

    /// <summary>
    /// Redis memory size in GiB.
    /// </summary>
    public TerraformExpression MemorySizeGb => this["memory_size_gb"];

    /// <summary>
    /// Output only. Info per node.
    /// </summary>
    public TerraformExpression Nodes => this["nodes"];

    /// <summary>
    /// Persistence configuration for an instance.
    /// </summary>
    public TerraformExpression PersistenceConfig => this["persistence_config"];

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
    /// Optional. Read replica mode. Can only be specified when trying to create the instance.
    /// If not set, Memorystore Redis backend will default to READ_REPLICAS_DISABLED.
    /// - READ_REPLICAS_DISABLED: If disabled, read endpoint will not be provided and the
    /// instance cannot scale up or down the number of replicas.
    /// - READ_REPLICAS_ENABLED: If enabled, read endpoint will be provided and the instance
    /// can scale up and down the number of replicas. Possible values: [&amp;quot;READ_REPLICAS_DISABLED&amp;quot;, &amp;quot;READ_REPLICAS_ENABLED&amp;quot;]
    /// </summary>
    public TerraformExpression ReadReplicasMode => this["read_replicas_mode"];

    /// <summary>
    /// Redis configuration parameters, according to http://redis.io/topics/config.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs
    /// </summary>
    public TerraformExpression RedisConfigs => this["redis_configs"];

    /// <summary>
    /// The version of Redis software. If not provided, latest supported
    /// version will be used. Please check the API documentation linked
    /// at the top for the latest valid values.
    /// </summary>
    public TerraformExpression RedisVersion => this["redis_version"];

    /// <summary>
    /// Optional. The number of replica nodes. The valid range for the Standard Tier with
    /// read replicas enabled is [1-5] and defaults to 2. If read replicas are not enabled
    /// for a Standard Tier instance, the only valid value is 1 and the default is 1.
    /// The valid value for basic tier is 0 and the default is also 0.
    /// </summary>
    public TerraformExpression ReplicaCount => this["replica_count"];

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this
    /// instance. If not provided, the service will choose an unused /29
    /// block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
    /// unique and non-overlapping with existing subnets in an authorized
    /// network.
    /// </summary>
    public TerraformExpression ReservedIpRange => this["reserved_ip_range"];

    /// <summary>
    /// Optional. Additional IP range for node placement. Required when enabling read replicas on
    /// an existing instance. For DIRECT_PEERING mode value must be a CIDR range of size /28, or
    /// &amp;quot;auto&amp;quot;. For PRIVATE_SERVICE_ACCESS mode value must be the name of an allocated address
    /// range associated with the private service access connection, or &amp;quot;auto&amp;quot;.
    /// </summary>
    public TerraformExpression SecondaryIpRange => this["secondary_ip_range"];

    /// <summary>
    /// List of server CA certificates for the instance.
    /// </summary>
    public TerraformExpression ServerCaCerts => this["server_ca_certs"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The service tier of the instance. Must be one of these values:
    /// 
    /// - BASIC: standalone instance
    /// - STANDARD_HA: highly available primary/replica instances Default value: &amp;quot;BASIC&amp;quot; Possible values: [&amp;quot;BASIC&amp;quot;, &amp;quot;STANDARD_HA&amp;quot;]
    /// </summary>
    public TerraformExpression Tier => this["tier"];

    /// <summary>
    /// The TLS mode of the Redis instance, If not provided, TLS is disabled for the instance.
    /// 
    /// - SERVER_AUTHENTICATION: Client to Server traffic encryption enabled with server authentication Default value: &amp;quot;DISABLED&amp;quot; Possible values: [&amp;quot;SERVER_AUTHENTICATION&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformExpression TransitEncryptionMode => this["transit_encryption_mode"];

}
