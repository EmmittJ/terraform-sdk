using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_managed_kafka_connector resource.
/// </summary>
public class GoogleManagedKafkaConnector : TerraformResource
{
    public GoogleManagedKafkaConnector(string name) : base("google_managed_kafka_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// Connector config as keys/values. The keys of the map are connector property names, for example: &#39;connector.class&#39;, &#39;tasks.max&#39;, &#39;key.converter&#39;.
    /// </summary>
    public Dictionary<string, string>? Configs
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("configs")?.Value;
        set => this.WithProperty("configs", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The connect cluster name.
    /// </summary>
    public string? ConnectCluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connect_cluster")?.Value;
        set => this.WithProperty("connect_cluster", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID to use for the connector, which will become the final component of the connector&#39;s name. This value is structured like: &#39;my-connector-id&#39;.
    /// </summary>
    public string? ConnectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connector_id")?.Value;
        set => this.WithProperty("connector_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// ID of the location of the Kafka Connect resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
