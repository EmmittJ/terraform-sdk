using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_redis_instance.
/// </summary>
public class GoogleRedisInstanceDataSource : TerraformDataSource
{
    public GoogleRedisInstanceDataSource(string name) : base("google_redis_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The name of the Redis region of the instance.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// Only applicable to STANDARD_HA tier which protects the instance
    /// against zonal failures by provisioning it across two zones.
    /// If provided, it must be a different zone from the one provided in
    /// [locationId].
    /// </summary>
    [TerraformPropertyName("alternative_location_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AlternativeLocationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "alternative_location_id");

    /// <summary>
    /// Optional. Indicates whether OSS Redis AUTH is enabled for the
    /// instance. If set to &amp;quot;true&amp;quot; AUTH is enabled on the instance.
    /// Default value is &amp;quot;false&amp;quot; meaning AUTH is disabled.
    /// </summary>
    [TerraformPropertyName("auth_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AuthEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auth_enabled");

    /// <summary>
    /// AUTH String set on the instance. This field will only be populated if auth_enabled is true.
    /// </summary>
    [TerraformPropertyName("auth_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auth_string");

    /// <summary>
    /// The full name of the Google Compute Engine network to which the
    /// instance is connected. If left unspecified, the default network
    /// will be used.
    /// </summary>
    [TerraformPropertyName("authorized_network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthorizedNetwork => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authorized_network");

    /// <summary>
    /// The connection mode of the Redis instance. Default value: &amp;quot;DIRECT_PEERING&amp;quot; Possible values: [&amp;quot;DIRECT_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("connect_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connect_mode");

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The current zone where the Redis endpoint is placed.
    /// For Basic Tier instances, this will always be the same as the
    /// [locationId] provided by the user at creation time. For Standard Tier
    /// instances, this can be either [locationId] or [alternativeLocationId]
    /// and can change after a failover event.
    /// </summary>
    [TerraformPropertyName("current_location_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrentLocationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "current_location_id");

    /// <summary>
    /// Optional. The KMS key reference that you want to use to encrypt the data at rest for this Redis
    /// instance. If this is provided, CMEK is enabled.
    /// </summary>
    [TerraformPropertyName("customer_managed_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerManagedKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_managed_key");

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// An arbitrary and optional user-provided name for the instance.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this
    /// instance. If not provided, the service will choose an unused /29
    /// block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
    /// unique and non-overlapping with existing subnets in an authorized
    /// network.
    /// </summary>
    [TerraformPropertyName("effective_reserved_ip_range")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EffectiveReservedIpRange => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "effective_reserved_ip_range");

    /// <summary>
    /// Hostname or IP address of the exposed Redis endpoint used by clients
    /// to connect to the service.
    /// </summary>
    [TerraformPropertyName("host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Host => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host");

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The zone where the instance will be provisioned. If not provided,
    /// the service will choose a zone for the instance. For STANDARD_HA tier,
    /// instances will be created across two zones for protection against
    /// zonal failures. If [alternativeLocationId] is also provided, it must
    /// be different from [locationId].
    /// </summary>
    [TerraformPropertyName("location_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location_id");

    /// <summary>
    /// Maintenance policy for an instance.
    /// </summary>
    [TerraformPropertyName("maintenance_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenancePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_policy");

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    [TerraformPropertyName("maintenance_schedule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceSchedule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_schedule");

    /// <summary>
    /// The self service update maintenance version.
    /// </summary>
    [TerraformPropertyName("maintenance_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MaintenanceVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "maintenance_version");

    /// <summary>
    /// Redis memory size in GiB.
    /// </summary>
    [TerraformPropertyName("memory_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySizeGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_gb");

    /// <summary>
    /// Output only. Info per node.
    /// </summary>
    [TerraformPropertyName("nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Nodes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "nodes");

    /// <summary>
    /// Persistence configuration for an instance.
    /// </summary>
    [TerraformPropertyName("persistence_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PersistenceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "persistence_config");

    /// <summary>
    /// Output only. Cloud IAM identity used by import / export operations
    /// to transfer data to/from Cloud Storage. Format is &amp;quot;serviceAccount:&amp;quot;.
    /// The value may change over time for a given instance so should be
    /// checked before each import/export operation.
    /// </summary>
    [TerraformPropertyName("persistence_iam_identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PersistenceIamIdentity => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "persistence_iam_identity");

    /// <summary>
    /// The port number of the exposed Redis endpoint.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// Output only. Hostname or IP address of the exposed readonly Redis endpoint. Standard tier only.
    /// Targets all healthy replica nodes in instance. Replication is asynchronous and replica nodes
    /// will exhibit some lag behind the primary. Write requests must target &#39;host&#39;.
    /// </summary>
    [TerraformPropertyName("read_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReadEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "read_endpoint");

    /// <summary>
    /// Output only. The port number of the exposed readonly redis endpoint. Standard tier only.
    /// Write requests should target &#39;port&#39;.
    /// </summary>
    [TerraformPropertyName("read_endpoint_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ReadEndpointPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "read_endpoint_port");

    /// <summary>
    /// Optional. Read replica mode. Can only be specified when trying to create the instance.
    /// If not set, Memorystore Redis backend will default to READ_REPLICAS_DISABLED.
    /// - READ_REPLICAS_DISABLED: If disabled, read endpoint will not be provided and the
    /// instance cannot scale up or down the number of replicas.
    /// - READ_REPLICAS_ENABLED: If enabled, read endpoint will be provided and the instance
    /// can scale up and down the number of replicas. Possible values: [&amp;quot;READ_REPLICAS_DISABLED&amp;quot;, &amp;quot;READ_REPLICAS_ENABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("read_replicas_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReadReplicasMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "read_replicas_mode");

    /// <summary>
    /// Redis configuration parameters, according to http://redis.io/topics/config.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs
    /// </summary>
    [TerraformPropertyName("redis_configs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> RedisConfigs => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "redis_configs");

    /// <summary>
    /// The version of Redis software. If not provided, latest supported
    /// version will be used. Please check the API documentation linked
    /// at the top for the latest valid values.
    /// </summary>
    [TerraformPropertyName("redis_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RedisVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "redis_version");

    /// <summary>
    /// Optional. The number of replica nodes. The valid range for the Standard Tier with
    /// read replicas enabled is [1-5] and defaults to 2. If read replicas are not enabled
    /// for a Standard Tier instance, the only valid value is 1 and the default is 1.
    /// The valid value for basic tier is 0 and the default is also 0.
    /// </summary>
    [TerraformPropertyName("replica_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ReplicaCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "replica_count");

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this
    /// instance. If not provided, the service will choose an unused /29
    /// block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
    /// unique and non-overlapping with existing subnets in an authorized
    /// network.
    /// </summary>
    [TerraformPropertyName("reserved_ip_range")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReservedIpRange => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reserved_ip_range");

    /// <summary>
    /// Optional. Additional IP range for node placement. Required when enabling read replicas on
    /// an existing instance. For DIRECT_PEERING mode value must be a CIDR range of size /28, or
    /// &amp;quot;auto&amp;quot;. For PRIVATE_SERVICE_ACCESS mode value must be the name of an allocated address
    /// range associated with the private service access connection, or &amp;quot;auto&amp;quot;.
    /// </summary>
    [TerraformPropertyName("secondary_ip_range")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryIpRange => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_ip_range");

    /// <summary>
    /// List of server CA certificates for the instance.
    /// </summary>
    [TerraformPropertyName("server_ca_certs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServerCaCerts => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "server_ca_certs");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The service tier of the instance. Must be one of these values:
    /// 
    /// - BASIC: standalone instance
    /// - STANDARD_HA: highly available primary/replica instances Default value: &amp;quot;BASIC&amp;quot; Possible values: [&amp;quot;BASIC&amp;quot;, &amp;quot;STANDARD_HA&amp;quot;]
    /// </summary>
    [TerraformPropertyName("tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tier");

    /// <summary>
    /// The TLS mode of the Redis instance, If not provided, TLS is disabled for the instance.
    /// 
    /// - SERVER_AUTHENTICATION: Client to Server traffic encryption enabled with server authentication Default value: &amp;quot;DISABLED&amp;quot; Possible values: [&amp;quot;SERVER_AUTHENTICATION&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("transit_encryption_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitEncryptionMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_encryption_mode");

}
