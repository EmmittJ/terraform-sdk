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
    public string? ApplicationFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_failure_feedback_role_arn")?.Value;
        set => this.WithProperty("application_failure_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The application_success_feedback_role_arn attribute.
    /// </summary>
    public string? ApplicationSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_success_feedback_role_arn")?.Value;
        set => this.WithProperty("application_success_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The application_success_feedback_sample_rate attribute.
    /// </summary>
    public double? ApplicationSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("application_success_feedback_sample_rate")?.Value;
        set => this.WithProperty("application_success_feedback_sample_rate", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The archive_policy attribute.
    /// </summary>
    public string? ArchivePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("archive_policy")?.Value;
        set => this.WithProperty("archive_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    public bool? ContentBasedDeduplication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("content_based_deduplication")?.Value;
        set => this.WithProperty("content_based_deduplication", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public string? DeliveryPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_policy")?.Value;
        set => this.WithProperty("delivery_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fifo_throughput_scope attribute.
    /// </summary>
    public string? FifoThroughputScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fifo_throughput_scope")?.Value;
        set => this.WithProperty("fifo_throughput_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fifo_topic attribute.
    /// </summary>
    public bool? FifoTopic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fifo_topic")?.Value;
        set => this.WithProperty("fifo_topic", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The firehose_failure_feedback_role_arn attribute.
    /// </summary>
    public string? FirehoseFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firehose_failure_feedback_role_arn")?.Value;
        set => this.WithProperty("firehose_failure_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The firehose_success_feedback_role_arn attribute.
    /// </summary>
    public string? FirehoseSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firehose_success_feedback_role_arn")?.Value;
        set => this.WithProperty("firehose_success_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The firehose_success_feedback_sample_rate attribute.
    /// </summary>
    public double? FirehoseSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("firehose_success_feedback_sample_rate")?.Value;
        set => this.WithProperty("firehose_success_feedback_sample_rate", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The http_failure_feedback_role_arn attribute.
    /// </summary>
    public string? HttpFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_failure_feedback_role_arn")?.Value;
        set => this.WithProperty("http_failure_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The http_success_feedback_role_arn attribute.
    /// </summary>
    public string? HttpSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_success_feedback_role_arn")?.Value;
        set => this.WithProperty("http_success_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The http_success_feedback_sample_rate attribute.
    /// </summary>
    public double? HttpSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("http_success_feedback_sample_rate")?.Value;
        set => this.WithProperty("http_success_feedback_sample_rate", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    public string? KmsMasterKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_master_key_id")?.Value;
        set => this.WithProperty("kms_master_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lambda_failure_feedback_role_arn attribute.
    /// </summary>
    public string? LambdaFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lambda_failure_feedback_role_arn")?.Value;
        set => this.WithProperty("lambda_failure_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lambda_success_feedback_role_arn attribute.
    /// </summary>
    public string? LambdaSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lambda_success_feedback_role_arn")?.Value;
        set => this.WithProperty("lambda_success_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lambda_success_feedback_sample_rate attribute.
    /// </summary>
    public double? LambdaSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("lambda_success_feedback_sample_rate")?.Value;
        set => this.WithProperty("lambda_success_feedback_sample_rate", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The signature_version attribute.
    /// </summary>
    public double? SignatureVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("signature_version")?.Value;
        set => this.WithProperty("signature_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sqs_failure_feedback_role_arn attribute.
    /// </summary>
    public string? SqsFailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sqs_failure_feedback_role_arn")?.Value;
        set => this.WithProperty("sqs_failure_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sqs_success_feedback_role_arn attribute.
    /// </summary>
    public string? SqsSuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sqs_success_feedback_role_arn")?.Value;
        set => this.WithProperty("sqs_success_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sqs_success_feedback_sample_rate attribute.
    /// </summary>
    public double? SqsSuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sqs_success_feedback_sample_rate")?.Value;
        set => this.WithProperty("sqs_success_feedback_sample_rate", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    public string? TracingConfig
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tracing_config")?.Value;
        set => this.WithProperty("tracing_config", value == null ? null : new TerraformLiteralProperty<string>(value));
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
