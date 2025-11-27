using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_redis_instance Terraform data source.
/// Retrieves information about a google_redis_instance.
/// </summary>
public partial class GoogleRedisInstanceDataSource(string name) : TerraformDataSource("google_redis_instance", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the Redis region of the instance.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Only applicable to STANDARD_HA tier which protects the instance
    /// against zonal failures by provisioning it across two zones.
    /// If provided, it must be a different zone from the one provided in
    /// [locationId].
    /// </summary>
    public TerraformValue<string> AlternativeLocationId
    {
        get => new TerraformReference<string>(this, "alternative_location_id");
    }

    /// <summary>
    /// Optional. Indicates whether OSS Redis AUTH is enabled for the
    /// instance. If set to &amp;quot;true&amp;quot; AUTH is enabled on the instance.
    /// Default value is &amp;quot;false&amp;quot; meaning AUTH is disabled.
    /// </summary>
    public TerraformValue<bool> AuthEnabled
    {
        get => new TerraformReference<bool>(this, "auth_enabled");
    }

    /// <summary>
    /// AUTH String set on the instance. This field will only be populated if auth_enabled is true.
    /// </summary>
    public TerraformValue<string> AuthString
    {
        get => new TerraformReference<string>(this, "auth_string");
    }

    /// <summary>
    /// The full name of the Google Compute Engine network to which the
    /// instance is connected. If left unspecified, the default network
    /// will be used.
    /// </summary>
    public TerraformValue<string> AuthorizedNetwork
    {
        get => new TerraformReference<string>(this, "authorized_network");
    }

    /// <summary>
    /// The connection mode of the Redis instance. Default value: &amp;quot;DIRECT_PEERING&amp;quot; Possible values: [&amp;quot;DIRECT_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;]
    /// </summary>
    public TerraformValue<string> ConnectMode
    {
        get => new TerraformReference<string>(this, "connect_mode");
    }

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The current zone where the Redis endpoint is placed.
    /// For Basic Tier instances, this will always be the same as the
    /// [locationId] provided by the user at creation time. For Standard Tier
    /// instances, this can be either [locationId] or [alternativeLocationId]
    /// and can change after a failover event.
    /// </summary>
    public TerraformValue<string> CurrentLocationId
    {
        get => new TerraformReference<string>(this, "current_location_id");
    }

    /// <summary>
    /// Optional. The KMS key reference that you want to use to encrypt the data at rest for this Redis
    /// instance. If this is provided, CMEK is enabled.
    /// </summary>
    public TerraformValue<string> CustomerManagedKey
    {
        get => new TerraformReference<string>(this, "customer_managed_key");
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// An arbitrary and optional user-provided name for the instance.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this
    /// instance. If not provided, the service will choose an unused /29
    /// block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
    /// unique and non-overlapping with existing subnets in an authorized
    /// network.
    /// </summary>
    public TerraformValue<string> EffectiveReservedIpRange
    {
        get => new TerraformReference<string>(this, "effective_reserved_ip_range");
    }

    /// <summary>
    /// Hostname or IP address of the exposed Redis endpoint used by clients
    /// to connect to the service.
    /// </summary>
    public TerraformValue<string> Host
    {
        get => new TerraformReference<string>(this, "host");
    }

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zone where the instance will be provisioned. If not provided,
    /// the service will choose a zone for the instance. For STANDARD_HA tier,
    /// instances will be created across two zones for protection against
    /// zonal failures. If [alternativeLocationId] is also provided, it must
    /// be different from [locationId].
    /// </summary>
    public TerraformValue<string> LocationId
    {
        get => new TerraformReference<string>(this, "location_id");
    }

    /// <summary>
    /// Maintenance policy for an instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenancePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceSchedule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_schedule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The self service update maintenance version.
    /// </summary>
    public TerraformValue<string> MaintenanceVersion
    {
        get => new TerraformReference<string>(this, "maintenance_version");
    }

    /// <summary>
    /// Redis memory size in GiB.
    /// </summary>
    public TerraformValue<double> MemorySizeGb
    {
        get => new TerraformReference<double>(this, "memory_size_gb");
    }

    /// <summary>
    /// Output only. Info per node.
    /// </summary>
    public TerraformList<TerraformMap<object>> Nodes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "nodes").ResolveNodes(ctx));
    }

    /// <summary>
    /// Persistence configuration for an instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> PersistenceConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "persistence_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Cloud IAM identity used by import / export operations
    /// to transfer data to/from Cloud Storage. Format is &amp;quot;serviceAccount:&amp;quot;.
    /// The value may change over time for a given instance so should be
    /// checked before each import/export operation.
    /// </summary>
    public TerraformValue<string> PersistenceIamIdentity
    {
        get => new TerraformReference<string>(this, "persistence_iam_identity");
    }

    /// <summary>
    /// The port number of the exposed Redis endpoint.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// Output only. Hostname or IP address of the exposed readonly Redis endpoint. Standard tier only.
    /// Targets all healthy replica nodes in instance. Replication is asynchronous and replica nodes
    /// will exhibit some lag behind the primary. Write requests must target &#39;host&#39;.
    /// </summary>
    public TerraformValue<string> ReadEndpoint
    {
        get => new TerraformReference<string>(this, "read_endpoint");
    }

    /// <summary>
    /// Output only. The port number of the exposed readonly redis endpoint. Standard tier only.
    /// Write requests should target &#39;port&#39;.
    /// </summary>
    public TerraformValue<double> ReadEndpointPort
    {
        get => new TerraformReference<double>(this, "read_endpoint_port");
    }

    /// <summary>
    /// Optional. Read replica mode. Can only be specified when trying to create the instance.
    /// If not set, Memorystore Redis backend will default to READ_REPLICAS_DISABLED.
    /// - READ_REPLICAS_DISABLED: If disabled, read endpoint will not be provided and the
    /// instance cannot scale up or down the number of replicas.
    /// - READ_REPLICAS_ENABLED: If enabled, read endpoint will be provided and the instance
    /// can scale up and down the number of replicas. Possible values: [&amp;quot;READ_REPLICAS_DISABLED&amp;quot;, &amp;quot;READ_REPLICAS_ENABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string> ReadReplicasMode
    {
        get => new TerraformReference<string>(this, "read_replicas_mode");
    }

    /// <summary>
    /// Redis configuration parameters, according to http://redis.io/topics/config.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs
    /// </summary>
    public TerraformMap<string> RedisConfigs
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "redis_configs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The version of Redis software. If not provided, latest supported
    /// version will be used. Please check the API documentation linked
    /// at the top for the latest valid values.
    /// </summary>
    public TerraformValue<string> RedisVersion
    {
        get => new TerraformReference<string>(this, "redis_version");
    }

    /// <summary>
    /// Optional. The number of replica nodes. The valid range for the Standard Tier with
    /// read replicas enabled is [1-5] and defaults to 2. If read replicas are not enabled
    /// for a Standard Tier instance, the only valid value is 1 and the default is 1.
    /// The valid value for basic tier is 0 and the default is also 0.
    /// </summary>
    public TerraformValue<double> ReplicaCount
    {
        get => new TerraformReference<double>(this, "replica_count");
    }

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this
    /// instance. If not provided, the service will choose an unused /29
    /// block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
    /// unique and non-overlapping with existing subnets in an authorized
    /// network.
    /// </summary>
    public TerraformValue<string> ReservedIpRange
    {
        get => new TerraformReference<string>(this, "reserved_ip_range");
    }

    /// <summary>
    /// Optional. Additional IP range for node placement. Required when enabling read replicas on
    /// an existing instance. For DIRECT_PEERING mode value must be a CIDR range of size /28, or
    /// &amp;quot;auto&amp;quot;. For PRIVATE_SERVICE_ACCESS mode value must be the name of an allocated address
    /// range associated with the private service access connection, or &amp;quot;auto&amp;quot;.
    /// </summary>
    public TerraformValue<string> SecondaryIpRange
    {
        get => new TerraformReference<string>(this, "secondary_ip_range");
    }

    /// <summary>
    /// List of server CA certificates for the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServerCaCerts
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "server_ca_certs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service tier of the instance. Must be one of these values:
    /// 
    /// - BASIC: standalone instance
    /// - STANDARD_HA: highly available primary/replica instances Default value: &amp;quot;BASIC&amp;quot; Possible values: [&amp;quot;BASIC&amp;quot;, &amp;quot;STANDARD_HA&amp;quot;]
    /// </summary>
    public TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
    }

    /// <summary>
    /// The TLS mode of the Redis instance, If not provided, TLS is disabled for the instance.
    /// 
    /// - SERVER_AUTHENTICATION: Client to Server traffic encryption enabled with server authentication Default value: &amp;quot;DISABLED&amp;quot; Possible values: [&amp;quot;SERVER_AUTHENTICATION&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string> TransitEncryptionMode
    {
        get => new TerraformReference<string>(this, "transit_encryption_mode");
    }

}
