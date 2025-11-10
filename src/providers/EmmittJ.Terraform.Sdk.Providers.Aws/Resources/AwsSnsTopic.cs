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
    public TerraformProperty<string>? ApplicationFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("application_failure_feedback_role_arn");
        set => this.WithProperty("application_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The application_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("application_success_feedback_role_arn");
        set => this.WithProperty("application_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The application_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double>? ApplicationSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformProperty<double>>("application_success_feedback_sample_rate");
        set => this.WithProperty("application_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The archive_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ArchivePolicy
    {
        get => GetProperty<TerraformProperty<string>>("archive_policy");
        set => this.WithProperty("archive_policy", value);
    }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    public TerraformProperty<bool>? ContentBasedDeduplication
    {
        get => GetProperty<TerraformProperty<bool>>("content_based_deduplication");
        set => this.WithProperty("content_based_deduplication", value);
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public TerraformProperty<string>? DeliveryPolicy
    {
        get => GetProperty<TerraformProperty<string>>("delivery_policy");
        set => this.WithProperty("delivery_policy", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The fifo_throughput_scope attribute.
    /// </summary>
    public TerraformProperty<string>? FifoThroughputScope
    {
        get => GetProperty<TerraformProperty<string>>("fifo_throughput_scope");
        set => this.WithProperty("fifo_throughput_scope", value);
    }

    /// <summary>
    /// The fifo_topic attribute.
    /// </summary>
    public TerraformProperty<bool>? FifoTopic
    {
        get => GetProperty<TerraformProperty<bool>>("fifo_topic");
        set => this.WithProperty("fifo_topic", value);
    }

    /// <summary>
    /// The firehose_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? FirehoseFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("firehose_failure_feedback_role_arn");
        set => this.WithProperty("firehose_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The firehose_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? FirehoseSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("firehose_success_feedback_role_arn");
        set => this.WithProperty("firehose_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The firehose_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double>? FirehoseSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformProperty<double>>("firehose_success_feedback_sample_rate");
        set => this.WithProperty("firehose_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The http_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? HttpFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("http_failure_feedback_role_arn");
        set => this.WithProperty("http_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The http_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? HttpSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("http_success_feedback_role_arn");
        set => this.WithProperty("http_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The http_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double>? HttpSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformProperty<double>>("http_success_feedback_sample_rate");
        set => this.WithProperty("http_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsMasterKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_master_key_id");
        set => this.WithProperty("kms_master_key_id", value);
    }

    /// <summary>
    /// The lambda_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LambdaFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("lambda_failure_feedback_role_arn");
        set => this.WithProperty("lambda_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The lambda_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LambdaSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("lambda_success_feedback_role_arn");
        set => this.WithProperty("lambda_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The lambda_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double>? LambdaSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformProperty<double>>("lambda_success_feedback_sample_rate");
        set => this.WithProperty("lambda_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The signature_version attribute.
    /// </summary>
    public TerraformProperty<double>? SignatureVersion
    {
        get => GetProperty<TerraformProperty<double>>("signature_version");
        set => this.WithProperty("signature_version", value);
    }

    /// <summary>
    /// The sqs_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SqsFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("sqs_failure_feedback_role_arn");
        set => this.WithProperty("sqs_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The sqs_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SqsSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("sqs_success_feedback_role_arn");
        set => this.WithProperty("sqs_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The sqs_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double>? SqsSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformProperty<double>>("sqs_success_feedback_sample_rate");
        set => this.WithProperty("sqs_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    public TerraformProperty<string>? TracingConfig
    {
        get => GetProperty<TerraformProperty<string>>("tracing_config");
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
