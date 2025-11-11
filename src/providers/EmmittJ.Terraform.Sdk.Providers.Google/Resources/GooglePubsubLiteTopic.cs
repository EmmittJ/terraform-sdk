using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for partition_config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubLiteTopicPartitionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The number of partitions in the topic. Must be at least 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformProperty("count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Count { get; set; }

}

/// <summary>
/// Block type for reservation_config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubLiteTopicReservationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The Reservation to use for this topic&#39;s throughput capacity.
    /// </summary>
    [TerraformProperty("throughput_reservation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ThroughputReservation { get; set; }

}

/// <summary>
/// Block type for retention_config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubLiteTopicRetentionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The provisioned storage, in bytes, per partition. If the number of bytes stored
    /// in any of the topic&#39;s partitions grows beyond this value, older messages will be
    /// dropped to make room for newer ones, regardless of the value of period.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerPartitionBytes is required")]
    [TerraformProperty("per_partition_bytes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PerPartitionBytes { get; set; }

    /// <summary>
    /// How long a published message is retained. If unset, messages will be retained as
    /// long as the bytes retained for each partition is below perPartitionBytes. A
    /// duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Period { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GooglePubsubLiteTopicTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_pubsub_lite_topic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GooglePubsubLiteTopic : TerraformResource
{
    public GooglePubsubLiteTopic(string name) : base("google_pubsub_lite_topic", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region of the pubsub lite topic.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The zone of the pubsub lite topic.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for partition_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartitionConfig block(s) allowed")]
    [TerraformProperty("partition_config")]
    public partial TerraformList<TerraformBlock<GooglePubsubLiteTopicPartitionConfigBlock>>? PartitionConfig { get; set; }

    /// <summary>
    /// Block for reservation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationConfig block(s) allowed")]
    [TerraformProperty("reservation_config")]
    public partial TerraformList<TerraformBlock<GooglePubsubLiteTopicReservationConfigBlock>>? ReservationConfig { get; set; }

    /// <summary>
    /// Block for retention_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionConfig block(s) allowed")]
    [TerraformProperty("retention_config")]
    public partial TerraformList<TerraformBlock<GooglePubsubLiteTopicRetentionConfigBlock>>? RetentionConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GooglePubsubLiteTopicTimeoutsBlock>? Timeouts { get; set; }

}
