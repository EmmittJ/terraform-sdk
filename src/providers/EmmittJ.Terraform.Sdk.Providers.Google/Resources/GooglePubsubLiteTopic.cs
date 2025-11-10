using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for partition_config in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteTopicPartitionConfigBlock : TerraformBlock
{
    /// <summary>
    /// The number of partitions in the topic. Must be at least 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        get => GetRequiredProperty<TerraformProperty<double>>("count");
        set => WithProperty("count", value);
    }

}

/// <summary>
/// Block type for reservation_config in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteTopicReservationConfigBlock : TerraformBlock
{
    /// <summary>
    /// The Reservation to use for this topic&#39;s throughput capacity.
    /// </summary>
    public TerraformProperty<string>? ThroughputReservation
    {
        get => GetProperty<TerraformProperty<string>>("throughput_reservation");
        set => WithProperty("throughput_reservation", value);
    }

}

/// <summary>
/// Block type for retention_config in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteTopicRetentionConfigBlock : TerraformBlock
{
    /// <summary>
    /// The provisioned storage, in bytes, per partition. If the number of bytes stored
    /// in any of the topic&#39;s partitions grows beyond this value, older messages will be
    /// dropped to make room for newer ones, regardless of the value of period.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerPartitionBytes is required")]
    public required TerraformProperty<string> PerPartitionBytes
    {
        get => GetRequiredProperty<TerraformProperty<string>>("per_partition_bytes");
        set => WithProperty("per_partition_bytes", value);
    }

    /// <summary>
    /// How long a published message is retained. If unset, messages will be retained as
    /// long as the bytes retained for each partition is below perPartitionBytes. A
    /// duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Period
    {
        get => GetProperty<TerraformProperty<string>>("period");
        set => WithProperty("period", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePubsubLiteTopicTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_pubsub_lite_topic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePubsubLiteTopic : TerraformResource
{
    public GooglePubsubLiteTopic(string name) : base("google_pubsub_lite_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// Name of the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The region of the pubsub lite topic.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The zone of the pubsub lite topic.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for partition_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartitionConfig block(s) allowed")]
    public List<GooglePubsubLiteTopicPartitionConfigBlock>? PartitionConfig
    {
        get => GetProperty<List<GooglePubsubLiteTopicPartitionConfigBlock>>("partition_config");
        set => this.WithProperty("partition_config", value);
    }

    /// <summary>
    /// Block for reservation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationConfig block(s) allowed")]
    public List<GooglePubsubLiteTopicReservationConfigBlock>? ReservationConfig
    {
        get => GetProperty<List<GooglePubsubLiteTopicReservationConfigBlock>>("reservation_config");
        set => this.WithProperty("reservation_config", value);
    }

    /// <summary>
    /// Block for retention_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionConfig block(s) allowed")]
    public List<GooglePubsubLiteTopicRetentionConfigBlock>? RetentionConfig
    {
        get => GetProperty<List<GooglePubsubLiteTopicRetentionConfigBlock>>("retention_config");
        set => this.WithProperty("retention_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePubsubLiteTopicTimeoutsBlock? Timeouts
    {
        get => GetProperty<GooglePubsubLiteTopicTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
