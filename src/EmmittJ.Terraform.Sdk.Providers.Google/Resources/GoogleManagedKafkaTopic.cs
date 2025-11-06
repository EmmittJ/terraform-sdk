using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_managed_kafka_topic resource.
/// </summary>
public class GoogleManagedKafkaTopic : TerraformResource
{
    public GoogleManagedKafkaTopic(string name) : base("google_managed_kafka_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The cluster name.
    /// </summary>
    public string? Cluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster")?.Value;
        set => this.WithProperty("cluster", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Configuration for the topic that are overridden from the cluster defaults. The key of the map is a Kafka topic property name, for example: &#39;cleanup.policy=compact&#39;, &#39;compression.type=producer&#39;.
    /// </summary>
    public Dictionary<string, string>? Configs
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("configs")?.Value;
        set => this.WithProperty("configs", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// ID of the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number of partitions in a topic. You can increase the partition count for a topic, but you cannot decrease it. Increasing partitions for a topic that uses a key might change how messages are distributed.
    /// </summary>
    public double? PartitionCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("partition_count")?.Value;
        set => this.WithProperty("partition_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The number of replicas of each partition. A replication factor of 3 is recommended for high availability.
    /// </summary>
    public double? ReplicationFactor
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replication_factor")?.Value;
        set => this.WithProperty("replication_factor", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ID to use for the topic, which will become the final component of the topic&#39;s name. This value is structured like: &#39;my-topic-name&#39;.
    /// </summary>
    public string? TopicId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_id")?.Value;
        set => this.WithProperty("topic_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the topic. The &#39;topic&#39; segment is used when connecting directly to the cluster. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID/topics/TOPIC_ID&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
