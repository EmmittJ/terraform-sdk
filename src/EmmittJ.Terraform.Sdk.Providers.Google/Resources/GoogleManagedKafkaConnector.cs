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
    public TerraformProperty<Dictionary<string, string>>? Configs
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("configs");
        set => this.WithProperty("configs", value);
    }

    /// <summary>
    /// The connect cluster name.
    /// </summary>
    public TerraformProperty<string>? ConnectCluster
    {
        get => GetProperty<TerraformProperty<string>>("connect_cluster");
        set => this.WithProperty("connect_cluster", value);
    }

    /// <summary>
    /// The ID to use for the connector, which will become the final component of the connector&#39;s name. This value is structured like: &#39;my-connector-id&#39;.
    /// </summary>
    public TerraformProperty<string>? ConnectorId
    {
        get => GetProperty<TerraformProperty<string>>("connector_id");
        set => this.WithProperty("connector_id", value);
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
    /// ID of the location of the Kafka Connect resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The name of the connector. The &#39;connector&#39; segment is used when connecting directly to the connect cluster. Structured like: &#39;projects/PROJECT_ID/locations/LOCATION/connectClusters/CONNECT_CLUSTER/connectors/CONNECTOR_ID&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the connect. Possible values: &#39;STATE_UNSPECIFIED&#39;, &#39;UNASSIGNED&#39;, &#39;RUNNING&#39;, &#39;PAUSED&#39;, &#39;FAILED&#39;, &#39;RESTARTING&#39;, and &#39;STOPPED&#39;.
    /// </summary>
    public TerraformExpression State => this["state"];

}
