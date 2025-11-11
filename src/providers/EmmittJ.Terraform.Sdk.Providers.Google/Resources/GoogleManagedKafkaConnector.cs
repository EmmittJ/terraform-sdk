using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for task_restart_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleManagedKafkaConnectorTaskRestartPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum amount of time to wait before retrying a failed task. This sets an upper bound for the backoff delay.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("maximum_backoff")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaximumBackoff { get; set; }

    /// <summary>
    /// The minimum amount of time to wait before retrying a failed task. This sets a lower bound for the backoff delay.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("minimum_backoff")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinimumBackoff { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleManagedKafkaConnectorTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_managed_kafka_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleManagedKafkaConnector : TerraformResource
{
    public GoogleManagedKafkaConnector(string name) : base("google_managed_kafka_connector", name)
    {
    }

    /// <summary>
    /// Connector config as keys/values. The keys of the map are connector property names, for example: &#39;connector.class&#39;, &#39;tasks.max&#39;, &#39;key.converter&#39;.
    /// </summary>
    [TerraformProperty("configs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Configs { get; set; }

    /// <summary>
    /// The connect cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectCluster is required")]
    [TerraformProperty("connect_cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectCluster { get; set; }

    /// <summary>
    /// The ID to use for the connector, which will become the final component of the connector&#39;s name. This value is structured like: &#39;my-connector-id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorId is required")]
    [TerraformProperty("connector_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectorId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// ID of the location of the Kafka Connect resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
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
    /// Block for task_restart_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskRestartPolicy block(s) allowed")]
    [TerraformProperty("task_restart_policy")]
    public partial TerraformList<TerraformBlock<GoogleManagedKafkaConnectorTaskRestartPolicyBlock>>? TaskRestartPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleManagedKafkaConnectorTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The name of the connector. The &#39;connector&#39; segment is used when connecting directly to the connect cluster. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/connectClusters/CONNECT_CLUSTER/connectors/CONNECTOR_ID&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The current state of the connect. Possible values: &#39;STATE_UNSPECIFIED&#39;, &#39;UNASSIGNED&#39;, &#39;RUNNING&#39;, &#39;PAUSED&#39;, &#39;FAILED&#39;, &#39;RESTARTING&#39;, and &#39;STOPPED&#39;.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
