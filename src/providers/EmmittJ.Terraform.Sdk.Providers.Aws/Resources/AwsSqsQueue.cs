using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSqsQueueTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_sqs_queue resource.
/// </summary>
public partial class AwsSqsQueue : TerraformResource
{
    public AwsSqsQueue(string name) : base("aws_sqs_queue", name)
    {
    }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    [TerraformProperty("content_based_deduplication")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ContentBasedDeduplication { get; set; }

    /// <summary>
    /// The deduplication_scope attribute.
    /// </summary>
    [TerraformProperty("deduplication_scope")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DeduplicationScope { get; set; }

    /// <summary>
    /// The delay_seconds attribute.
    /// </summary>
    [TerraformProperty("delay_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DelaySeconds { get; set; }

    /// <summary>
    /// The fifo_queue attribute.
    /// </summary>
    [TerraformProperty("fifo_queue")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FifoQueue { get; set; }

    /// <summary>
    /// The fifo_throughput_limit attribute.
    /// </summary>
    [TerraformProperty("fifo_throughput_limit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FifoThroughputLimit { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    [TerraformProperty("kms_data_key_reuse_period_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> KmsDataKeyReusePeriodSeconds { get; set; }

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_master_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsMasterKeyId { get; set; }

    /// <summary>
    /// The max_message_size attribute.
    /// </summary>
    [TerraformProperty("max_message_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxMessageSize { get; set; }

    /// <summary>
    /// The message_retention_seconds attribute.
    /// </summary>
    [TerraformProperty("message_retention_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MessageRetentionSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// The receive_wait_time_seconds attribute.
    /// </summary>
    [TerraformProperty("receive_wait_time_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReceiveWaitTimeSeconds { get; set; }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    [TerraformProperty("redrive_allow_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RedriveAllowPolicy { get; set; }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    [TerraformProperty("redrive_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RedrivePolicy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The sqs_managed_sse_enabled attribute.
    /// </summary>
    [TerraformProperty("sqs_managed_sse_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SqsManagedSseEnabled { get; set; }

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
    /// The visibility_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("visibility_timeout_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VisibilityTimeoutSeconds { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsSqsQueueTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
