using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for task_restart_policy in GoogleManagedKafkaConnector.
/// Nesting mode: list
/// </summary>
public class GoogleManagedKafkaConnectorTaskRestartPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "task_restart_policy";

    /// <summary>
    /// The maximum amount of time to wait before retrying a failed task. This sets an upper bound for the backoff delay.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MaximumBackoff
    {
        get => GetArgument<TerraformValue<string>>("maximum_backoff");
        set => SetArgument("maximum_backoff", value);
    }

    /// <summary>
    /// The minimum amount of time to wait before retrying a failed task. This sets a lower bound for the backoff delay.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MinimumBackoff
    {
        get => GetArgument<TerraformValue<string>>("minimum_backoff");
        set => SetArgument("minimum_backoff", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleManagedKafkaConnector.
/// Nesting mode: single
/// </summary>
public class GoogleManagedKafkaConnectorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_managed_kafka_connector Terraform resource.
/// Manages a google_managed_kafka_connector resource.
/// </summary>
public partial class GoogleManagedKafkaConnector(string name) : TerraformResource("google_managed_kafka_connector", name)
{
    /// <summary>
    /// Connector config as keys/values. The keys of the map are connector property names, for example: &#39;connector.class&#39;, &#39;tasks.max&#39;, &#39;key.converter&#39;.
    /// </summary>
    public TerraformMap<string>? Configs
    {
        get => GetArgument<TerraformMap<string>>("configs");
        set => SetArgument("configs", value);
    }

    /// <summary>
    /// The connect cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectCluster is required")]
    public required TerraformValue<string> ConnectCluster
    {
        get => GetRequiredArgument<TerraformValue<string>>("connect_cluster");
        set => SetArgument("connect_cluster", value);
    }

    /// <summary>
    /// The ID to use for the connector, which will become the final component of the connector&#39;s name. This value is structured like: &#39;my-connector-id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorId is required")]
    public required TerraformValue<string> ConnectorId
    {
        get => GetRequiredArgument<TerraformValue<string>>("connector_id");
        set => SetArgument("connector_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ID of the location of the Kafka Connect resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the connector. The &#39;connector&#39; segment is used when connecting directly to the connect cluster. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/connectClusters/CONNECT_CLUSTER/connectors/CONNECTOR_ID&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The current state of the connect. Possible values: &#39;STATE_UNSPECIFIED&#39;, &#39;UNASSIGNED&#39;, &#39;RUNNING&#39;, &#39;PAUSED&#39;, &#39;FAILED&#39;, &#39;RESTARTING&#39;, and &#39;STOPPED&#39;.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// TaskRestartPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskRestartPolicy block(s) allowed")]
    public TerraformList<GoogleManagedKafkaConnectorTaskRestartPolicyBlock>? TaskRestartPolicy
    {
        get => GetArgument<TerraformList<GoogleManagedKafkaConnectorTaskRestartPolicyBlock>>("task_restart_policy");
        set => SetArgument("task_restart_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleManagedKafkaConnectorTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleManagedKafkaConnectorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
