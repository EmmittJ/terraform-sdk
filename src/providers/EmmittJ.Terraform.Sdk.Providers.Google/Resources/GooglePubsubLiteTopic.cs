using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for partition_config in GooglePubsubLiteTopic.
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteTopicPartitionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "partition_config";

    /// <summary>
    /// The number of partitions in the topic. Must be at least 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Capacity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    public TerraformList<GooglePubsubLiteTopicPartitionConfigBlockCapacityBlock>? Capacity
    {
        get => GetArgument<TerraformList<GooglePubsubLiteTopicPartitionConfigBlockCapacityBlock>>("capacity");
        set => SetArgument("capacity", value);
    }

}

/// <summary>
/// Block type for capacity in GooglePubsubLiteTopicPartitionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteTopicPartitionConfigBlockCapacityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity";

    /// <summary>
    /// Subscribe throughput capacity per partition in MiB/s. Must be &amp;gt;= 4 and &amp;lt;= 16.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublishMibPerSec is required")]
    public required TerraformValue<double> PublishMibPerSec
    {
        get => new TerraformReference<double>(this, "publish_mib_per_sec");
        set => SetArgument("publish_mib_per_sec", value);
    }

    /// <summary>
    /// Publish throughput capacity per partition in MiB/s. Must be &amp;gt;= 4 and &amp;lt;= 16.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscribeMibPerSec is required")]
    public required TerraformValue<double> SubscribeMibPerSec
    {
        get => new TerraformReference<double>(this, "subscribe_mib_per_sec");
        set => SetArgument("subscribe_mib_per_sec", value);
    }

}


/// <summary>
/// Block type for reservation_config in GooglePubsubLiteTopic.
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteTopicReservationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_config";

    /// <summary>
    /// The Reservation to use for this topic&#39;s throughput capacity.
    /// </summary>
    public TerraformValue<string>? ThroughputReservation
    {
        get => new TerraformReference<string>(this, "throughput_reservation");
        set => SetArgument("throughput_reservation", value);
    }

}


/// <summary>
/// Block type for retention_config in GooglePubsubLiteTopic.
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteTopicRetentionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_config";

    /// <summary>
    /// The provisioned storage, in bytes, per partition. If the number of bytes stored
    /// in any of the topic&#39;s partitions grows beyond this value, older messages will be
    /// dropped to make room for newer ones, regardless of the value of period.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerPartitionBytes is required")]
    public required TerraformValue<string> PerPartitionBytes
    {
        get => new TerraformReference<string>(this, "per_partition_bytes");
        set => SetArgument("per_partition_bytes", value);
    }

    /// <summary>
    /// How long a published message is retained. If unset, messages will be retained as
    /// long as the bytes retained for each partition is below perPartitionBytes. A
    /// duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Period
    {
        get => new TerraformReference<string>(this, "period");
        set => SetArgument("period", value);
    }

}


/// <summary>
/// Block type for timeouts in GooglePubsubLiteTopic.
/// Nesting mode: single
/// </summary>
public class GooglePubsubLiteTopicTimeoutsBlock : TerraformBlock
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
/// Represents a google_pubsub_lite_topic Terraform resource.
/// Manages a google_pubsub_lite_topic resource.
/// </summary>
public partial class GooglePubsubLiteTopic(string name) : TerraformResource("google_pubsub_lite_topic", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The region of the pubsub lite topic.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The zone of the pubsub lite topic.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// PartitionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartitionConfig block(s) allowed")]
    public TerraformList<GooglePubsubLiteTopicPartitionConfigBlock>? PartitionConfig
    {
        get => GetArgument<TerraformList<GooglePubsubLiteTopicPartitionConfigBlock>>("partition_config");
        set => SetArgument("partition_config", value);
    }

    /// <summary>
    /// ReservationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationConfig block(s) allowed")]
    public TerraformList<GooglePubsubLiteTopicReservationConfigBlock>? ReservationConfig
    {
        get => GetArgument<TerraformList<GooglePubsubLiteTopicReservationConfigBlock>>("reservation_config");
        set => SetArgument("reservation_config", value);
    }

    /// <summary>
    /// RetentionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionConfig block(s) allowed")]
    public TerraformList<GooglePubsubLiteTopicRetentionConfigBlock>? RetentionConfig
    {
        get => GetArgument<TerraformList<GooglePubsubLiteTopicRetentionConfigBlock>>("retention_config");
        set => SetArgument("retention_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GooglePubsubLiteTopicTimeoutsBlock? Timeouts
    {
        get => GetArgument<GooglePubsubLiteTopicTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
