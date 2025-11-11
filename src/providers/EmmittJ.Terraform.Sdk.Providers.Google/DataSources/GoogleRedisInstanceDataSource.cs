using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_redis_instance.
/// </summary>
public partial class GoogleRedisInstanceDataSource : TerraformDataSource
{
    public GoogleRedisInstanceDataSource(string name) : base("google_redis_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
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
    /// The name of the Redis region of the instance.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Only applicable to STANDARD_HA tier which protects the instance
    /// against zonal failures by provisioning it across two zones.
    /// If provided, it must be a different zone from the one provided in
    /// [locationId].
    /// </summary>
    [TerraformProperty("alternative_location_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AlternativeLocationId { get; }

    /// <summary>
    /// Optional. Indicates whether OSS Redis AUTH is enabled for the
    /// instance. If set to &amp;quot;true&amp;quot; AUTH is enabled on the instance.
    /// Default value is &amp;quot;false&amp;quot; meaning AUTH is disabled.
    /// </summary>
    [TerraformProperty("auth_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AuthEnabled { get; }

    /// <summary>
    /// AUTH String set on the instance. This field will only be populated if auth_enabled is true.
    /// </summary>
    [TerraformProperty("auth_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthString { get; }

    /// <summary>
    /// The full name of the Google Compute Engine network to which the
    /// instance is connected. If left unspecified, the default network
    /// will be used.
    /// </summary>
    [TerraformProperty("authorized_network")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthorizedNetwork { get; }

    /// <summary>
    /// The connection mode of the Redis instance. Default value: &amp;quot;DIRECT_PEERING&amp;quot; Possible values: [&amp;quot;DIRECT_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;]
    /// </summary>
    [TerraformProperty("connect_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectMode { get; }

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The current zone where the Redis endpoint is placed.
    /// For Basic Tier instances, this will always be the same as the
    /// [locationId] provided by the user at creation time. For Standard Tier
    /// instances, this can be either [locationId] or [alternativeLocationId]
    /// and can change after a failover event.
    /// </summary>
    [TerraformProperty("current_location_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CurrentLocationId { get; }

    /// <summary>
    /// Optional. The KMS key reference that you want to use to encrypt the data at rest for this Redis
    /// instance. If this is provided, CMEK is enabled.
    /// </summary>
    [TerraformProperty("customer_managed_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomerManagedKey { get; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// An arbitrary and optional user-provided name for the instance.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this
    /// instance. If not provided, the service will choose an unused /29
    /// block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
    /// unique and non-overlapping with existing subnets in an authorized
    /// network.
    /// </summary>
    [TerraformProperty("effective_reserved_ip_range")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EffectiveReservedIpRange { get; }

    /// <summary>
    /// Hostname or IP address of the exposed Redis endpoint used by clients
    /// to connect to the service.
    /// </summary>
    [TerraformProperty("host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Host { get; }

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Labels { get; }

    /// <summary>
    /// The zone where the instance will be provisioned. If not provided,
    /// the service will choose a zone for the instance. For STANDARD_HA tier,
    /// instances will be created across two zones for protection against
    /// zonal failures. If [alternativeLocationId] is also provided, it must
    /// be different from [locationId].
    /// </summary>
    [TerraformProperty("location_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LocationId { get; }

    /// <summary>
    /// Maintenance policy for an instance.
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
    /// The self service update maintenance version.
    /// </summary>
    [TerraformProperty("maintenance_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MaintenanceVersion { get; }

    /// <summary>
    /// Redis memory size in GiB.
    /// </summary>
    [TerraformProperty("memory_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MemorySizeGb { get; }

    /// <summary>
    /// Output only. Info per node.
    /// </summary>
    [TerraformProperty("nodes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Nodes { get; }

    /// <summary>
    /// Persistence configuration for an instance.
    /// </summary>
    [TerraformProperty("persistence_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PersistenceConfig { get; }

    /// <summary>
    /// Output only. Cloud IAM identity used by import / export operations
    /// to transfer data to/from Cloud Storage. Format is &amp;quot;serviceAccount:&amp;quot;.
    /// The value may change over time for a given instance so should be
    /// checked before each import/export operation.
    /// </summary>
    [TerraformProperty("persistence_iam_identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PersistenceIamIdentity { get; }

    /// <summary>
    /// The port number of the exposed Redis endpoint.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// Output only. Hostname or IP address of the exposed readonly Redis endpoint. Standard tier only.
    /// Targets all healthy replica nodes in instance. Replication is asynchronous and replica nodes
    /// will exhibit some lag behind the primary. Write requests must target &#39;host&#39;.
    /// </summary>
    [TerraformProperty("read_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReadEndpoint { get; }

    /// <summary>
    /// Output only. The port number of the exposed readonly redis endpoint. Standard tier only.
    /// Write requests should target &#39;port&#39;.
    /// </summary>
    [TerraformProperty("read_endpoint_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ReadEndpointPort { get; }

    /// <summary>
    /// Optional. Read replica mode. Can only be specified when trying to create the instance.
    /// If not set, Memorystore Redis backend will default to READ_REPLICAS_DISABLED.
    /// - READ_REPLICAS_DISABLED: If disabled, read endpoint will not be provided and the
    /// instance cannot scale up or down the number of replicas.
    /// - READ_REPLICAS_ENABLED: If enabled, read endpoint will be provided and the instance
    /// can scale up and down the number of replicas. Possible values: [&amp;quot;READ_REPLICAS_DISABLED&amp;quot;, &amp;quot;READ_REPLICAS_ENABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("read_replicas_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReadReplicasMode { get; }

    /// <summary>
    /// Redis configuration parameters, according to http://redis.io/topics/config.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs
    /// </summary>
    [TerraformProperty("redis_configs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> RedisConfigs { get; }

    /// <summary>
    /// The version of Redis software. If not provided, latest supported
    /// version will be used. Please check the API documentation linked
    /// at the top for the latest valid values.
    /// </summary>
    [TerraformProperty("redis_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RedisVersion { get; }

    /// <summary>
    /// Optional. The number of replica nodes. The valid range for the Standard Tier with
    /// read replicas enabled is [1-5] and defaults to 2. If read replicas are not enabled
    /// for a Standard Tier instance, the only valid value is 1 and the default is 1.
    /// The valid value for basic tier is 0 and the default is also 0.
    /// </summary>
    [TerraformProperty("replica_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ReplicaCount { get; }

    /// <summary>
    /// The CIDR range of internal addresses that are reserved for this
    /// instance. If not provided, the service will choose an unused /29
    /// block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
    /// unique and non-overlapping with existing subnets in an authorized
    /// network.
    /// </summary>
    [TerraformProperty("reserved_ip_range")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReservedIpRange { get; }

    /// <summary>
    /// Optional. Additional IP range for node placement. Required when enabling read replicas on
    /// an existing instance. For DIRECT_PEERING mode value must be a CIDR range of size /28, or
    /// &amp;quot;auto&amp;quot;. For PRIVATE_SERVICE_ACCESS mode value must be the name of an allocated address
    /// range associated with the private service access connection, or &amp;quot;auto&amp;quot;.
    /// </summary>
    [TerraformProperty("secondary_ip_range")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryIpRange { get; }

    /// <summary>
    /// List of server CA certificates for the instance.
    /// </summary>
    [TerraformProperty("server_ca_certs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ServerCaCerts { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The service tier of the instance. Must be one of these values:
    /// 
    /// - BASIC: standalone instance
    /// - STANDARD_HA: highly available primary/replica instances Default value: &amp;quot;BASIC&amp;quot; Possible values: [&amp;quot;BASIC&amp;quot;, &amp;quot;STANDARD_HA&amp;quot;]
    /// </summary>
    [TerraformProperty("tier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tier { get; }

    /// <summary>
    /// The TLS mode of the Redis instance, If not provided, TLS is disabled for the instance.
    /// 
    /// - SERVER_AUTHENTICATION: Client to Server traffic encryption enabled with server authentication Default value: &amp;quot;DISABLED&amp;quot; Possible values: [&amp;quot;SERVER_AUTHENTICATION&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("transit_encryption_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransitEncryptionMode { get; }

}
