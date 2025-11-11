using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for capacity_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleManagedKafkaClusterCapacityConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The memory to provision for the cluster in bytes. The value must be between 1 GiB and 8 GiB per vCPU. Ex. 1024Mi, 4Gi.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryBytes is required")]
    [TerraformProperty("memory_bytes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MemoryBytes { get; set; }

    /// <summary>
    /// The number of vCPUs to provision for the cluster. The minimum is 3.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VcpuCount is required")]
    [TerraformProperty("vcpu_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VcpuCount { get; set; }

}

/// <summary>
/// Block type for gcp_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleManagedKafkaClusterGcpConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The Cloud KMS Key name to use for encryption. The key must be located in the same region as the cluster and cannot be changed. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY&#39;.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKey { get; set; }

}

/// <summary>
/// Block type for rebalance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleManagedKafkaClusterRebalanceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The rebalance behavior for the cluster. When not specified, defaults to &#39;NO_REBALANCE&#39;. Possible values: &#39;MODE_UNSPECIFIED&#39;, &#39;NO_REBALANCE&#39;, &#39;AUTO_REBALANCE_ON_SCALE_UP&#39;.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleManagedKafkaClusterTimeoutsBlock : TerraformBlockBase
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
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleManagedKafkaClusterTlsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The rules for mapping mTLS certificate Distinguished Names (DNs) to shortened principal names for Kafka ACLs. This field corresponds exactly to the ssl.principal.mapping.rules broker config and matches the format and syntax defined in the Apache Kafka documentation. Setting or modifying this field will trigger a rolling restart of the Kafka brokers to apply the change. An empty string means that the default Kafka behavior is used. Example: &#39;RULE:^CN=(.?),OU=ServiceUsers.$/$1@example.com/,DEFAULT&#39;
    /// </summary>
    [TerraformProperty("ssl_principal_mapping_rules")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslPrincipalMappingRules { get; set; }

}

/// <summary>
/// Manages a google_managed_kafka_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleManagedKafkaCluster : TerraformResource
{
    public GoogleManagedKafkaCluster(string name) : base("google_managed_kafka_cluster", name)
    {
    }

    /// <summary>
    /// The ID to use for the cluster, which will become the final component of the cluster&#39;s name. The ID must be 1-63 characters long, and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; to comply with RFC 1035. This value is structured like: &#39;my-cluster-id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// List of label KEY=VALUE pairs to add. Keys must start with a lowercase character and contain only hyphens (-), underscores (&#160;), lowercase characters, and numbers. Values must contain only hyphens (-), underscores (&#160;), lowercase characters, and numbers.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// ID of the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for capacity_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CapacityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityConfig block(s) allowed")]
    [TerraformProperty("capacity_config")]
    public partial TerraformList<TerraformBlock<GoogleManagedKafkaClusterCapacityConfigBlock>>? CapacityConfig { get; set; }

    /// <summary>
    /// Block for gcp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpConfig block(s) allowed")]
    [TerraformProperty("gcp_config")]
    public partial TerraformList<TerraformBlock<GoogleManagedKafkaClusterGcpConfigBlock>>? GcpConfig { get; set; }

    /// <summary>
    /// Block for rebalance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RebalanceConfig block(s) allowed")]
    [TerraformProperty("rebalance_config")]
    public partial TerraformList<TerraformBlock<GoogleManagedKafkaClusterRebalanceConfigBlock>>? RebalanceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleManagedKafkaClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    [TerraformProperty("tls_config")]
    public partial TerraformList<TerraformBlock<GoogleManagedKafkaClusterTlsConfigBlock>>? TlsConfig { get; set; }

    /// <summary>
    /// The time when the cluster was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The name of the cluster. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The current state of the cluster. Possible values: &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;DELETING&#39;.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time when the cluster was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
