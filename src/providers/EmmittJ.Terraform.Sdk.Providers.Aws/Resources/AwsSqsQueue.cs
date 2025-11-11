using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSqsQueueTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_sqs_queue resource.
/// </summary>
public class AwsSqsQueue : TerraformResource
{
    public AwsSqsQueue(string name) : base("aws_sqs_queue", name)
    {
    }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    [TerraformPropertyName("content_based_deduplication")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ContentBasedDeduplication { get; set; }

    /// <summary>
    /// The deduplication_scope attribute.
    /// </summary>
    [TerraformPropertyName("deduplication_scope")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DeduplicationScope { get; set; } = default!;

    /// <summary>
    /// The delay_seconds attribute.
    /// </summary>
    [TerraformPropertyName("delay_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DelaySeconds { get; set; }

    /// <summary>
    /// The fifo_queue attribute.
    /// </summary>
    [TerraformPropertyName("fifo_queue")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FifoQueue { get; set; }

    /// <summary>
    /// The fifo_throughput_limit attribute.
    /// </summary>
    [TerraformPropertyName("fifo_throughput_limit")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FifoThroughputLimit { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    [TerraformPropertyName("kms_data_key_reuse_period_seconds")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> KmsDataKeyReusePeriodSeconds { get; set; } = default!;

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_master_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsMasterKeyId { get; set; }

    /// <summary>
    /// The max_message_size attribute.
    /// </summary>
    [TerraformPropertyName("max_message_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxMessageSize { get; set; }

    /// <summary>
    /// The message_retention_seconds attribute.
    /// </summary>
    [TerraformPropertyName("message_retention_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MessageRetentionSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Policy { get; set; } = default!;

    /// <summary>
    /// The receive_wait_time_seconds attribute.
    /// </summary>
    [TerraformPropertyName("receive_wait_time_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ReceiveWaitTimeSeconds { get; set; }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    [TerraformPropertyName("redrive_allow_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RedriveAllowPolicy { get; set; } = default!;

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    [TerraformPropertyName("redrive_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RedrivePolicy { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The sqs_managed_sse_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sqs_managed_sse_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SqsManagedSseEnabled { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The visibility_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("visibility_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? VisibilityTimeoutSeconds { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSqsQueueTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Url => new TerraformReference(this, "url");

}
