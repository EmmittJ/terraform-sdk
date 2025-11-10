using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSqsQueueTimeoutsBlock : ITerraformBlock
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
    public TerraformProperty<TerraformProperty<bool>>? ContentBasedDeduplication { get; set; }

    /// <summary>
    /// The deduplication_scope attribute.
    /// </summary>
    [TerraformPropertyName("deduplication_scope")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DeduplicationScope { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deduplication_scope");

    /// <summary>
    /// The delay_seconds attribute.
    /// </summary>
    [TerraformPropertyName("delay_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DelaySeconds { get; set; }

    /// <summary>
    /// The fifo_queue attribute.
    /// </summary>
    [TerraformPropertyName("fifo_queue")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FifoQueue { get; set; }

    /// <summary>
    /// The fifo_throughput_limit attribute.
    /// </summary>
    [TerraformPropertyName("fifo_throughput_limit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FifoThroughputLimit { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fifo_throughput_limit");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    [TerraformPropertyName("kms_data_key_reuse_period_seconds")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> KmsDataKeyReusePeriodSeconds { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "kms_data_key_reuse_period_seconds");

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_master_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsMasterKeyId { get; set; }

    /// <summary>
    /// The max_message_size attribute.
    /// </summary>
    [TerraformPropertyName("max_message_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxMessageSize { get; set; }

    /// <summary>
    /// The message_retention_seconds attribute.
    /// </summary>
    [TerraformPropertyName("message_retention_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MessageRetentionSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Policy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy");

    /// <summary>
    /// The receive_wait_time_seconds attribute.
    /// </summary>
    [TerraformPropertyName("receive_wait_time_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ReceiveWaitTimeSeconds { get; set; }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    [TerraformPropertyName("redrive_allow_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RedriveAllowPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "redrive_allow_policy");

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    [TerraformPropertyName("redrive_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RedrivePolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "redrive_policy");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The sqs_managed_sse_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sqs_managed_sse_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SqsManagedSseEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "sqs_managed_sse_enabled");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The visibility_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("visibility_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? VisibilityTimeoutSeconds { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSqsQueueTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
