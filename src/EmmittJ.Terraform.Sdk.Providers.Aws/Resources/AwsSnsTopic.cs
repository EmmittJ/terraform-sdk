using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_topic resource.
/// </summary>
public class AwsSnsTopic : TerraformResource
{
    public AwsSnsTopic(string name) : base("aws_sns_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("beginning_archive_time");
        this.DeclareOutput("owner");
    }

    /// <summary>
    /// The application_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplicationFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_failure_feedback_role_arn");
        set => this.WithProperty("application_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The application_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplicationSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_success_feedback_role_arn");
        set => this.WithProperty("application_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The application_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ApplicationSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("application_success_feedback_sample_rate");
        set => this.WithProperty("application_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The archive_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ArchivePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("archive_policy");
        set => this.WithProperty("archive_policy", value);
    }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ContentBasedDeduplication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("content_based_deduplication");
        set => this.WithProperty("content_based_deduplication", value);
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeliveryPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_policy");
        set => this.WithProperty("delivery_policy", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The fifo_throughput_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FifoThroughputScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fifo_throughput_scope");
        set => this.WithProperty("fifo_throughput_scope", value);
    }

    /// <summary>
    /// The fifo_topic attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FifoTopic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fifo_topic");
        set => this.WithProperty("fifo_topic", value);
    }

    /// <summary>
    /// The firehose_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FirehoseFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firehose_failure_feedback_role_arn");
        set => this.WithProperty("firehose_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The firehose_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FirehoseSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firehose_success_feedback_role_arn");
        set => this.WithProperty("firehose_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The firehose_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? FirehoseSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("firehose_success_feedback_sample_rate");
        set => this.WithProperty("firehose_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The http_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HttpFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_failure_feedback_role_arn");
        set => this.WithProperty("http_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The http_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HttpSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_success_feedback_role_arn");
        set => this.WithProperty("http_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The http_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? HttpSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("http_success_feedback_sample_rate");
        set => this.WithProperty("http_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsMasterKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_master_key_id");
        set => this.WithProperty("kms_master_key_id", value);
    }

    /// <summary>
    /// The lambda_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LambdaFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lambda_failure_feedback_role_arn");
        set => this.WithProperty("lambda_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The lambda_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LambdaSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lambda_success_feedback_role_arn");
        set => this.WithProperty("lambda_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The lambda_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? LambdaSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("lambda_success_feedback_sample_rate");
        set => this.WithProperty("lambda_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The signature_version attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SignatureVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("signature_version");
        set => this.WithProperty("signature_version", value);
    }

    /// <summary>
    /// The sqs_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqsFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sqs_failure_feedback_role_arn");
        set => this.WithProperty("sqs_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The sqs_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqsSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sqs_success_feedback_role_arn");
        set => this.WithProperty("sqs_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The sqs_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SqsSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sqs_success_feedback_sample_rate");
        set => this.WithProperty("sqs_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TracingConfig
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tracing_config");
        set => this.WithProperty("tracing_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The beginning_archive_time attribute.
    /// </summary>
    public TerraformExpression BeginningArchiveTime => this["beginning_archive_time"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

}
