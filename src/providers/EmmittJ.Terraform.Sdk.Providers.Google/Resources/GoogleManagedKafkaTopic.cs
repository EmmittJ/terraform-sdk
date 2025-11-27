using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleManagedKafkaTopic.
/// Nesting mode: single
/// </summary>
public class GoogleManagedKafkaTopicTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_managed_kafka_topic Terraform resource.
/// Manages a google_managed_kafka_topic resource.
/// </summary>
public partial class GoogleManagedKafkaTopic(string name) : TerraformResource("google_managed_kafka_topic", name)
{
    /// <summary>
    /// The cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => new TerraformReference<string>(this, "cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// Configuration for the topic that are overridden from the cluster defaults. The key of the map is a Kafka topic property name, for example: &#39;cleanup.policy=compact&#39;, &#39;compression.type=producer&#39;.
    /// </summary>
    public TerraformMap<string>? Configs
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "configs").ResolveNodes(ctx));
        set => SetArgument("configs", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ID of the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The number of partitions in a topic. You can increase the partition count for a topic, but you cannot decrease it. Increasing partitions for a topic that uses a key might change how messages are distributed.
    /// </summary>
    public TerraformValue<double>? PartitionCount
    {
        get => new TerraformReference<double>(this, "partition_count");
        set => SetArgument("partition_count", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The number of replicas of each partition. A replication factor of 3 is recommended for high availability.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFactor is required")]
    public required TerraformValue<double> ReplicationFactor
    {
        get => new TerraformReference<double>(this, "replication_factor");
        set => SetArgument("replication_factor", value);
    }

    /// <summary>
    /// The ID to use for the topic, which will become the final component of the topic&#39;s name. This value is structured like: &#39;my-topic-name&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicId is required")]
    public required TerraformValue<string> TopicId
    {
        get => new TerraformReference<string>(this, "topic_id");
        set => SetArgument("topic_id", value);
    }

    /// <summary>
    /// The name of the topic. The &#39;topic&#39; segment is used when connecting directly to the cluster. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID/topics/TOPIC_ID&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleManagedKafkaTopicTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleManagedKafkaTopicTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
