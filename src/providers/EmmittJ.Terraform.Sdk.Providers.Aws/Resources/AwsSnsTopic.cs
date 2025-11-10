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
    public TerraformProperty<TerraformProperty<string>>? ApplicationFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The application_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("application_success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApplicationSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The application_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("application_success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ApplicationSuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The archive_policy attribute.
    /// </summary>
    [TerraformPropertyName("archive_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ArchivePolicy { get; set; }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    [TerraformPropertyName("content_based_deduplication")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContentBasedDeduplication { get; set; }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    [TerraformPropertyName("delivery_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeliveryPolicy { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The fifo_throughput_scope attribute.
    /// </summary>
    [TerraformPropertyName("fifo_throughput_scope")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FifoThroughputScope { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fifo_throughput_scope");

    /// <summary>
    /// The fifo_topic attribute.
    /// </summary>
    [TerraformPropertyName("fifo_topic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FifoTopic { get; set; }

    /// <summary>
    /// The firehose_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("firehose_failure_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FirehoseFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The firehose_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("firehose_success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FirehoseSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The firehose_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("firehose_success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FirehoseSuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The http_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("http_failure_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The http_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("http_success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The http_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("http_success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HttpSuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_master_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsMasterKeyId { get; set; }

    /// <summary>
    /// The lambda_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("lambda_failure_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LambdaFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The lambda_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("lambda_success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LambdaSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The lambda_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("lambda_success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? LambdaSuccessFeedbackSampleRate { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The signature_version attribute.
    /// </summary>
    [TerraformPropertyName("signature_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> SignatureVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "signature_version");

    /// <summary>
    /// The sqs_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("sqs_failure_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SqsFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The sqs_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("sqs_success_feedback_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SqsSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The sqs_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("sqs_success_feedback_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SqsSuccessFeedbackSampleRate { get; set; }

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
    /// The tracing_config attribute.
    /// </summary>
    [TerraformPropertyName("tracing_config")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TracingConfig { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tracing_config");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The beginning_archive_time attribute.
    /// </summary>
    [TerraformPropertyName("beginning_archive_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BeginningArchiveTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "beginning_archive_time");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

}
