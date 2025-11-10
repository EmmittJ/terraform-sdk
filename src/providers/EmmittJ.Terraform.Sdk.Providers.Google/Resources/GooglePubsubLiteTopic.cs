using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for partition_config in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteTopicPartitionConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The number of partitions in the topic. Must be at least 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformPropertyName("count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Count { get; set; }

}

/// <summary>
/// Block type for reservation_config in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteTopicReservationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The Reservation to use for this topic&#39;s throughput capacity.
    /// </summary>
    [TerraformPropertyName("throughput_reservation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ThroughputReservation { get; set; }

}

/// <summary>
/// Block type for retention_config in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteTopicRetentionConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The provisioned storage, in bytes, per partition. If the number of bytes stored
    /// in any of the topic&#39;s partitions grows beyond this value, older messages will be
    /// dropped to make room for newer ones, regardless of the value of period.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerPartitionBytes is required")]
    [TerraformPropertyName("per_partition_bytes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PerPartitionBytes { get; set; }

    /// <summary>
    /// How long a published message is retained. If unset, messages will be retained as
    /// long as the bytes retained for each partition is below perPartitionBytes. A
    /// duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Period { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePubsubLiteTopicTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_pubsub_lite_topic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePubsubLiteTopic : TerraformResource
{
    public GooglePubsubLiteTopic(string name) : base("google_pubsub_lite_topic", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The region of the pubsub lite topic.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The zone of the pubsub lite topic.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Zone { get; set; }

    /// <summary>
    /// Block for partition_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartitionConfig block(s) allowed")]
    [TerraformPropertyName("partition_config")]
    public TerraformList<TerraformBlock<GooglePubsubLiteTopicPartitionConfigBlock>>? PartitionConfig { get; set; } = new();

    /// <summary>
    /// Block for reservation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationConfig block(s) allowed")]
    [TerraformPropertyName("reservation_config")]
    public TerraformList<TerraformBlock<GooglePubsubLiteTopicReservationConfigBlock>>? ReservationConfig { get; set; } = new();

    /// <summary>
    /// Block for retention_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionConfig block(s) allowed")]
    [TerraformPropertyName("retention_config")]
    public TerraformList<TerraformBlock<GooglePubsubLiteTopicRetentionConfigBlock>>? RetentionConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GooglePubsubLiteTopicTimeoutsBlock>? Timeouts { get; set; } = new();

}
