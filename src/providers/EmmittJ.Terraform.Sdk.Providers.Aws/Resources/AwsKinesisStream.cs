using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for stream_mode_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisStreamStreamModeDetailsBlock : TerraformBlockBase
{
    /// <summary>
    /// The stream_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamMode is required")]
    [TerraformProperty("stream_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StreamMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsKinesisStreamTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_kinesis_stream resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsKinesisStream : TerraformResource
{
    public AwsKinesisStream(string name) : base("aws_kinesis_stream", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformProperty("encryption_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptionType { get; set; }

    /// <summary>
    /// The enforce_consumer_deletion attribute.
    /// </summary>
    [TerraformProperty("enforce_consumer_deletion")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnforceConsumerDeletion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    [TerraformProperty("retention_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetentionPeriod { get; set; }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    [TerraformProperty("shard_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ShardCount { get; set; }

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    [TerraformProperty("shard_level_metrics")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ShardLevelMetrics { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for stream_mode_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamModeDetails block(s) allowed")]
    [TerraformProperty("stream_mode_details")]
    public partial TerraformList<TerraformBlock<AwsKinesisStreamStreamModeDetailsBlock>>? StreamModeDetails { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsKinesisStreamTimeoutsBlock>? Timeouts { get; set; }

}
