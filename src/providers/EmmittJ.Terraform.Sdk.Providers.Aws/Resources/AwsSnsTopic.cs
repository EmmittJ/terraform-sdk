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
        get => new TerraformReference<string>(this, "application_failure_feedback_role_arn");
        set => SetArgument("application_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The application_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ApplicationSuccessFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "application_success_feedback_role_arn");
        set => SetArgument("application_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The application_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? ApplicationSuccessFeedbackSampleRate
    {
        get => new TerraformReference<double>(this, "application_success_feedback_sample_rate");
        set => SetArgument("application_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The archive_policy attribute.
    /// </summary>
    public TerraformValue<string>? ArchivePolicy
    {
        get => new TerraformReference<string>(this, "archive_policy");
        set => SetArgument("archive_policy", value);
    }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    public TerraformValue<bool>? ContentBasedDeduplication
    {
        get => new TerraformReference<bool>(this, "content_based_deduplication");
        set => SetArgument("content_based_deduplication", value);
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryPolicy
    {
        get => new TerraformReference<string>(this, "delivery_policy");
        set => SetArgument("delivery_policy", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The fifo_throughput_scope attribute.
    /// </summary>
    public TerraformValue<string> FifoThroughputScope
    {
        get => new TerraformReference<string>(this, "fifo_throughput_scope");
        set => SetArgument("fifo_throughput_scope", value);
    }

    /// <summary>
    /// The fifo_topic attribute.
    /// </summary>
    public TerraformValue<bool>? FifoTopic
    {
        get => new TerraformReference<bool>(this, "fifo_topic");
        set => SetArgument("fifo_topic", value);
    }

    /// <summary>
    /// The firehose_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? FirehoseFailureFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "firehose_failure_feedback_role_arn");
        set => SetArgument("firehose_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The firehose_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? FirehoseSuccessFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "firehose_success_feedback_role_arn");
        set => SetArgument("firehose_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The firehose_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? FirehoseSuccessFeedbackSampleRate
    {
        get => new TerraformReference<double>(this, "firehose_success_feedback_sample_rate");
        set => SetArgument("firehose_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The http_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? HttpFailureFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "http_failure_feedback_role_arn");
        set => SetArgument("http_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The http_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? HttpSuccessFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "http_success_feedback_role_arn");
        set => SetArgument("http_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The http_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? HttpSuccessFeedbackSampleRate
    {
        get => new TerraformReference<double>(this, "http_success_feedback_sample_rate");
        set => SetArgument("http_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsMasterKeyId
    {
        get => new TerraformReference<string>(this, "kms_master_key_id");
        set => SetArgument("kms_master_key_id", value);
    }

    /// <summary>
    /// The lambda_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? LambdaFailureFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "lambda_failure_feedback_role_arn");
        set => SetArgument("lambda_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The lambda_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? LambdaSuccessFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "lambda_success_feedback_role_arn");
        set => SetArgument("lambda_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The lambda_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? LambdaSuccessFeedbackSampleRate
    {
        get => new TerraformReference<double>(this, "lambda_success_feedback_sample_rate");
        set => SetArgument("lambda_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The signature_version attribute.
    /// </summary>
    public TerraformValue<double> SignatureVersion
    {
        get => new TerraformReference<double>(this, "signature_version");
        set => SetArgument("signature_version", value);
    }

    /// <summary>
    /// The sqs_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? SqsFailureFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "sqs_failure_feedback_role_arn");
        set => SetArgument("sqs_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The sqs_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? SqsSuccessFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "sqs_success_feedback_role_arn");
        set => SetArgument("sqs_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The sqs_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? SqsSuccessFeedbackSampleRate
    {
        get => new TerraformReference<double>(this, "sqs_success_feedback_sample_rate");
        set => SetArgument("sqs_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    public TerraformValue<string> TracingConfig
    {
        get => new TerraformReference<string>(this, "tracing_config");
        set => SetArgument("tracing_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The beginning_archive_time attribute.
    /// </summary>
    public TerraformValue<string> BeginningArchiveTime
    {
        get => new TerraformReference<string>(this, "beginning_archive_time");
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
    }

}
