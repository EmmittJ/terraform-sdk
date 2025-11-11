using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_topic resource.
/// </summary>
public class AwsSnsTopic : TerraformResource
{
    public AwsSnsTopic(string name) : base("aws_sns_topic", name)
    {
    }

    /// <summary>
    /// The application_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("application_failure_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApplicationFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The application_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("application_success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApplicationSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The application_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("application_success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ApplicationSuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The archive_policy attribute.
    /// </summary>
    [TerraformPropertyName("archive_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ArchivePolicy { get; set; }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    [TerraformPropertyName("content_based_deduplication")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ContentBasedDeduplication { get; set; }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    [TerraformPropertyName("delivery_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeliveryPolicy { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The fifo_throughput_scope attribute.
    /// </summary>
    [TerraformPropertyName("fifo_throughput_scope")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FifoThroughputScope { get; set; } = default!;

    /// <summary>
    /// The fifo_topic attribute.
    /// </summary>
    [TerraformPropertyName("fifo_topic")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FifoTopic { get; set; }

    /// <summary>
    /// The firehose_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("firehose_failure_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FirehoseFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The firehose_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("firehose_success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FirehoseSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The firehose_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("firehose_success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FirehoseSuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The http_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("http_failure_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The http_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("http_success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The http_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("http_success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? HttpSuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_master_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsMasterKeyId { get; set; }

    /// <summary>
    /// The lambda_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("lambda_failure_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LambdaFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The lambda_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("lambda_success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LambdaSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The lambda_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("lambda_success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? LambdaSuccessFeedbackSampleRate { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The signature_version attribute.
    /// </summary>
    [TerraformPropertyName("signature_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SignatureVersion { get; set; } = default!;

    /// <summary>
    /// The sqs_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("sqs_failure_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SqsFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The sqs_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("sqs_success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SqsSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The sqs_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("sqs_success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SqsSuccessFeedbackSampleRate { get; set; }

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
    /// The tracing_config attribute.
    /// </summary>
    [TerraformPropertyName("tracing_config")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TracingConfig { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The beginning_archive_time attribute.
    /// </summary>
    [TerraformPropertyName("beginning_archive_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BeginningArchiveTime => new TerraformReference(this, "beginning_archive_time");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Owner => new TerraformReference(this, "owner");

}
