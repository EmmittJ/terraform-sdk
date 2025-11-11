using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_topic resource.
/// </summary>
public partial class AwsSnsTopic : TerraformResource
{
    public AwsSnsTopic(string name) : base("aws_sns_topic", name)
    {
    }

    /// <summary>
    /// The application_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("application_failure_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplicationFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The application_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("application_success_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplicationSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The application_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformProperty("application_success_feedback_sample_rate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ApplicationSuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The archive_policy attribute.
    /// </summary>
    [TerraformProperty("archive_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ArchivePolicy { get; set; }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    [TerraformProperty("content_based_deduplication")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ContentBasedDeduplication { get; set; }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    [TerraformProperty("delivery_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeliveryPolicy { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The fifo_throughput_scope attribute.
    /// </summary>
    [TerraformProperty("fifo_throughput_scope")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FifoThroughputScope { get; set; }

    /// <summary>
    /// The fifo_topic attribute.
    /// </summary>
    [TerraformProperty("fifo_topic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FifoTopic { get; set; }

    /// <summary>
    /// The firehose_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("firehose_failure_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirehoseFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The firehose_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("firehose_success_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirehoseSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The firehose_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformProperty("firehose_success_feedback_sample_rate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FirehoseSuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The http_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("http_failure_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The http_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("http_success_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The http_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformProperty("http_success_feedback_sample_rate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HttpSuccessFeedbackSampleRate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_master_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsMasterKeyId { get; set; }

    /// <summary>
    /// The lambda_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("lambda_failure_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LambdaFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The lambda_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("lambda_success_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LambdaSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The lambda_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformProperty("lambda_success_feedback_sample_rate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? LambdaSuccessFeedbackSampleRate { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The signature_version attribute.
    /// </summary>
    [TerraformProperty("signature_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SignatureVersion { get; set; }

    /// <summary>
    /// The sqs_failure_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("sqs_failure_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SqsFailureFeedbackRoleArn { get; set; }

    /// <summary>
    /// The sqs_success_feedback_role_arn attribute.
    /// </summary>
    [TerraformProperty("sqs_success_feedback_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SqsSuccessFeedbackRoleArn { get; set; }

    /// <summary>
    /// The sqs_success_feedback_sample_rate attribute.
    /// </summary>
    [TerraformProperty("sqs_success_feedback_sample_rate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SqsSuccessFeedbackSampleRate { get; set; }

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
    /// The tracing_config attribute.
    /// </summary>
    [TerraformProperty("tracing_config")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TracingConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The beginning_archive_time attribute.
    /// </summary>
    [TerraformProperty("beginning_archive_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BeginningArchiveTime { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Owner { get; }

}
