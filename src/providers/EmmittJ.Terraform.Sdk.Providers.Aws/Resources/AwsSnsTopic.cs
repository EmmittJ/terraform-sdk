using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sns_topic Terraform resource.
/// Manages a aws_sns_topic resource.
/// </summary>
public partial class AwsSnsTopic(string name) : TerraformResource("aws_sns_topic", name)
{
    /// <summary>
    /// The application_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ApplicationFailureFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("application_failure_feedback_role_arn");
        set => SetArgument("application_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The application_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ApplicationSuccessFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("application_success_feedback_role_arn");
        set => SetArgument("application_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The application_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? ApplicationSuccessFeedbackSampleRate
    {
        get => GetArgument<TerraformValue<double>>("application_success_feedback_sample_rate");
        set => SetArgument("application_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The archive_policy attribute.
    /// </summary>
    public TerraformValue<string>? ArchivePolicy
    {
        get => GetArgument<TerraformValue<string>>("archive_policy");
        set => SetArgument("archive_policy", value);
    }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    public TerraformValue<bool>? ContentBasedDeduplication
    {
        get => GetArgument<TerraformValue<bool>>("content_based_deduplication");
        set => SetArgument("content_based_deduplication", value);
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryPolicy
    {
        get => GetArgument<TerraformValue<string>>("delivery_policy");
        set => SetArgument("delivery_policy", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The fifo_throughput_scope attribute.
    /// </summary>
    public TerraformValue<string>? FifoThroughputScope
    {
        get => GetArgument<TerraformValue<string>>("fifo_throughput_scope");
        set => SetArgument("fifo_throughput_scope", value);
    }

    /// <summary>
    /// The fifo_topic attribute.
    /// </summary>
    public TerraformValue<bool>? FifoTopic
    {
        get => GetArgument<TerraformValue<bool>>("fifo_topic");
        set => SetArgument("fifo_topic", value);
    }

    /// <summary>
    /// The firehose_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? FirehoseFailureFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("firehose_failure_feedback_role_arn");
        set => SetArgument("firehose_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The firehose_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? FirehoseSuccessFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("firehose_success_feedback_role_arn");
        set => SetArgument("firehose_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The firehose_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? FirehoseSuccessFeedbackSampleRate
    {
        get => GetArgument<TerraformValue<double>>("firehose_success_feedback_sample_rate");
        set => SetArgument("firehose_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The http_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? HttpFailureFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("http_failure_feedback_role_arn");
        set => SetArgument("http_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The http_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? HttpSuccessFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("http_success_feedback_role_arn");
        set => SetArgument("http_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The http_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? HttpSuccessFeedbackSampleRate
    {
        get => GetArgument<TerraformValue<double>>("http_success_feedback_sample_rate");
        set => SetArgument("http_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsMasterKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_master_key_id");
        set => SetArgument("kms_master_key_id", value);
    }

    /// <summary>
    /// The lambda_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? LambdaFailureFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_failure_feedback_role_arn");
        set => SetArgument("lambda_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The lambda_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? LambdaSuccessFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_success_feedback_role_arn");
        set => SetArgument("lambda_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The lambda_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? LambdaSuccessFeedbackSampleRate
    {
        get => GetArgument<TerraformValue<double>>("lambda_success_feedback_sample_rate");
        set => SetArgument("lambda_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The signature_version attribute.
    /// </summary>
    public TerraformValue<double>? SignatureVersion
    {
        get => GetArgument<TerraformValue<double>>("signature_version");
        set => SetArgument("signature_version", value);
    }

    /// <summary>
    /// The sqs_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? SqsFailureFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("sqs_failure_feedback_role_arn");
        set => SetArgument("sqs_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The sqs_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? SqsSuccessFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("sqs_success_feedback_role_arn");
        set => SetArgument("sqs_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The sqs_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? SqsSuccessFeedbackSampleRate
    {
        get => GetArgument<TerraformValue<double>>("sqs_success_feedback_sample_rate");
        set => SetArgument("sqs_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    public TerraformValue<string>? TracingConfig
    {
        get => GetArgument<TerraformValue<string>>("tracing_config");
        set => SetArgument("tracing_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The beginning_archive_time attribute.
    /// </summary>
    public TerraformValue<string> BeginningArchiveTime
        => AsReference("beginning_archive_time");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
        => AsReference("owner");

}
