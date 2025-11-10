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
        set => SetProperty("count", value);
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
        set => SetProperty("throughput_reservation", value);
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
        set => SetProperty("per_partition_bytes", value);
    }

    /// <summary>
    /// How long a published message is retained. If unset, messages will be retained as
    /// long as the bytes retained for each partition is below perPartitionBytes. A
    /// duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Period
    {
        set => SetProperty("period", value);
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
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
        SetOutput("zone");
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
    /// Name of the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The region of the pubsub lite topic.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The zone of the pubsub lite topic.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for partition_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartitionConfig block(s) allowed")]
    public List<GooglePubsubLiteTopicPartitionConfigBlock>? PartitionConfig
    {
        set => SetProperty("partition_config", value);
    }

    /// <summary>
    /// Block for reservation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationConfig block(s) allowed")]
    public List<GooglePubsubLiteTopicReservationConfigBlock>? ReservationConfig
    {
        set => SetProperty("reservation_config", value);
    }

    /// <summary>
    /// Block for retention_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionConfig block(s) allowed")]
    public List<GooglePubsubLiteTopicRetentionConfigBlock>? RetentionConfig
    {
        set => SetProperty("retention_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePubsubLiteTopicTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
