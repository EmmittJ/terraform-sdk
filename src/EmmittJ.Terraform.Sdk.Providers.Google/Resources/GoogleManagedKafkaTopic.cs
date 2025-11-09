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
    public TerraformProperty<string>? Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// Configuration for the topic that are overridden from the cluster defaults. The key of the map is a Kafka topic property name, for example: &#39;cleanup.policy=compact&#39;, &#39;compression.type=producer&#39;.
    /// </summary>
    public TerraformMapProperty<string>? Configs
    {
        get => GetProperty<TerraformMapProperty<string>>("configs");
        set => this.WithProperty("configs", value);
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
    /// ID of the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The number of partitions in a topic. You can increase the partition count for a topic, but you cannot decrease it. Increasing partitions for a topic that uses a key might change how messages are distributed.
    /// </summary>
    public TerraformProperty<double>? PartitionCount
    {
        get => GetProperty<TerraformProperty<double>>("partition_count");
        set => this.WithProperty("partition_count", value);
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
    /// The number of replicas of each partition. A replication factor of 3 is recommended for high availability.
    /// </summary>
    public TerraformProperty<double>? ReplicationFactor
    {
        get => GetProperty<TerraformProperty<double>>("replication_factor");
        set => this.WithProperty("replication_factor", value);
    }

    /// <summary>
    /// The ID to use for the topic, which will become the final component of the topic&#39;s name. This value is structured like: &#39;my-topic-name&#39;.
    /// </summary>
    public TerraformProperty<string>? TopicId
    {
        get => GetProperty<TerraformProperty<string>>("topic_id");
        set => this.WithProperty("topic_id", value);
    }

    /// <summary>
    /// The name of the topic. The &#39;topic&#39; segment is used when connecting directly to the cluster. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID/topics/TOPIC_ID&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
