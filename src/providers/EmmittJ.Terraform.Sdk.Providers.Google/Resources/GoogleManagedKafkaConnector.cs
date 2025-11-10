using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for task_restart_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaConnectorTaskRestartPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The maximum amount of time to wait before retrying a failed task. This sets an upper bound for the backoff delay.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? MaximumBackoff
    {
        set => SetProperty("maximum_backoff", value);
    }

    /// <summary>
    /// The minimum amount of time to wait before retrying a failed task. This sets a lower bound for the backoff delay.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? MinimumBackoff
    {
        set => SetProperty("minimum_backoff", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleManagedKafkaConnectorTimeoutsBlock : TerraformBlock
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
/// Manages a google_managed_kafka_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleManagedKafkaConnector : TerraformResource
{
    public GoogleManagedKafkaConnector(string name) : base("google_managed_kafka_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("state");
        SetOutput("configs");
        SetOutput("connect_cluster");
        SetOutput("connector_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// Connector config as keys/values. The keys of the map are connector property names, for example: &#39;connector.class&#39;, &#39;tasks.max&#39;, &#39;key.converter&#39;.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Configs
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("configs");
        set => SetProperty("configs", value);
    }

    /// <summary>
    /// The connect cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectCluster is required")]
    public required TerraformProperty<string> ConnectCluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connect_cluster");
        set => SetProperty("connect_cluster", value);
    }

    /// <summary>
    /// The ID to use for the connector, which will become the final component of the connector&#39;s name. This value is structured like: &#39;my-connector-id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorId is required")]
    public required TerraformProperty<string> ConnectorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connector_id");
        set => SetProperty("connector_id", value);
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
    /// ID of the location of the Kafka Connect resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// Block for task_restart_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskRestartPolicy block(s) allowed")]
    public List<GoogleManagedKafkaConnectorTaskRestartPolicyBlock>? TaskRestartPolicy
    {
        set => SetProperty("task_restart_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleManagedKafkaConnectorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The name of the connector. The &#39;connector&#39; segment is used when connecting directly to the connect cluster. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/connectClusters/CONNECT_CLUSTER/connectors/CONNECTOR_ID&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the connect. Possible values: &#39;STATE_UNSPECIFIED&#39;, &#39;UNASSIGNED&#39;, &#39;RUNNING&#39;, &#39;PAUSED&#39;, &#39;FAILED&#39;, &#39;RESTARTING&#39;, and &#39;STOPPED&#39;.
    /// </summary>
    public TerraformExpression State => this["state"];

}
