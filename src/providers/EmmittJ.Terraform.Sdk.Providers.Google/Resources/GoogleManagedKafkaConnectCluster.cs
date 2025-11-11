using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for capacity_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleManagedKafkaConnectClusterCapacityConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The memory to provision for the cluster in bytes. The CPU:memory ratio (vCPU:GiB) must be between 1:1 and 1:8. Minimum: 3221225472 (3 GiB).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryBytes is required")]
    [TerraformProperty("memory_bytes")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MemoryBytes { get; set; }

    /// <summary>
    /// The number of vCPUs to provision for the cluster. The minimum is 3.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VcpuCount is required")]
    [TerraformProperty("vcpu_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VcpuCount { get; set; }

}

/// <summary>
/// Block type for gcp_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleManagedKafkaConnectClusterGcpConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleManagedKafkaConnectClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_managed_kafka_connect_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleManagedKafkaConnectCluster : TerraformResource
{
    public GoogleManagedKafkaConnectCluster(string name) : base("google_managed_kafka_connect_cluster", name)
    {
    }

    /// <summary>
    /// The ID to use for the Connect Cluster, which will become the final component of the connect cluster&#39;s name. This value is structured like: &#39;my-connect-cluster-id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectClusterId is required")]
    [TerraformProperty("connect_cluster_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Kafka cluster this Kafka Connect cluster is attached to. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaCluster is required")]
    [TerraformProperty("kafka_cluster")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KafkaCluster { get; set; }

    /// <summary>
    /// List of label KEY=VALUE pairs to add. Keys must start with a lowercase character and contain only hyphens (-), underscores (&#160;), lowercase characters, and numbers. Values must contain only hyphens (-), underscores (&#160;), lowercase characters, and numbers.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// ID of the location of the Kafka Connect resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for capacity_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CapacityConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityConfig block(s) allowed")]
    [TerraformProperty("capacity_config")]
    public TerraformList<TerraformBlock<GoogleManagedKafkaConnectClusterCapacityConfigBlock>>? CapacityConfig { get; set; }

    /// <summary>
    /// Block for gcp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GcpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcpConfig block(s) allowed")]
    [TerraformProperty("gcp_config")]
    public TerraformList<TerraformBlock<GoogleManagedKafkaConnectClusterGcpConfigBlock>>? GcpConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleManagedKafkaConnectClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the cluster was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The name of the connect cluster. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/connectClusters/CONNECT_CLUSTER_ID&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The current state of the connect cluster. Possible values: &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;DELETING&#39;.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time when the cluster was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
