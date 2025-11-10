using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleManagedKafkaTopicTimeoutsBlock : TerraformBlock
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
        SetOutput("name");
        SetOutput("cluster");
        SetOutput("configs");
        SetOutput("id");
        SetOutput("location");
        SetOutput("partition_count");
        SetOutput("project");
        SetOutput("replication_factor");
        SetOutput("topic_id");
    }

    /// <summary>
    /// The cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster");
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// Configuration for the topic that are overridden from the cluster defaults. The key of the map is a Kafka topic property name, for example: &#39;cleanup.policy=compact&#39;, &#39;compression.type=producer&#39;.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Configs
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("configs");
        set => SetProperty("configs", value);
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
    /// ID of the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The number of partitions in a topic. You can increase the partition count for a topic, but you cannot decrease it. Increasing partitions for a topic that uses a key might change how messages are distributed.
    /// </summary>
    public TerraformProperty<double> PartitionCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("partition_count");
        set => SetProperty("partition_count", value);
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
    /// The number of replicas of each partition. A replication factor of 3 is recommended for high availability.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFactor is required")]
    public required TerraformProperty<double> ReplicationFactor
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replication_factor");
        set => SetProperty("replication_factor", value);
    }

    /// <summary>
    /// The ID to use for the topic, which will become the final component of the topic&#39;s name. This value is structured like: &#39;my-topic-name&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicId is required")]
    public required TerraformProperty<string> TopicId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("topic_id");
        set => SetProperty("topic_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleManagedKafkaTopicTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The name of the topic. The &#39;topic&#39; segment is used when connecting directly to the cluster. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID/topics/TOPIC_ID&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
