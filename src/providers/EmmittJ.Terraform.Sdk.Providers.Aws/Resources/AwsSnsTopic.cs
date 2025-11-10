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
        SetOutput("arn");
        SetOutput("beginning_archive_time");
        SetOutput("owner");
        SetOutput("application_failure_feedback_role_arn");
        SetOutput("application_success_feedback_role_arn");
        SetOutput("application_success_feedback_sample_rate");
        SetOutput("archive_policy");
        SetOutput("content_based_deduplication");
        SetOutput("delivery_policy");
        SetOutput("display_name");
        SetOutput("fifo_throughput_scope");
        SetOutput("fifo_topic");
        SetOutput("firehose_failure_feedback_role_arn");
        SetOutput("firehose_success_feedback_role_arn");
        SetOutput("firehose_success_feedback_sample_rate");
        SetOutput("http_failure_feedback_role_arn");
        SetOutput("http_success_feedback_role_arn");
        SetOutput("http_success_feedback_sample_rate");
        SetOutput("id");
        SetOutput("kms_master_key_id");
        SetOutput("lambda_failure_feedback_role_arn");
        SetOutput("lambda_success_feedback_role_arn");
        SetOutput("lambda_success_feedback_sample_rate");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("policy");
        SetOutput("region");
        SetOutput("signature_version");
        SetOutput("sqs_failure_feedback_role_arn");
        SetOutput("sqs_success_feedback_role_arn");
        SetOutput("sqs_success_feedback_sample_rate");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tracing_config");
    }

    /// <summary>
    /// The application_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ApplicationFailureFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_failure_feedback_role_arn");
        set => SetProperty("application_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The application_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ApplicationSuccessFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_success_feedback_role_arn");
        set => SetProperty("application_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The application_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double> ApplicationSuccessFeedbackSampleRate
    {
        get => GetRequiredOutput<TerraformProperty<double>>("application_success_feedback_sample_rate");
        set => SetProperty("application_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The archive_policy attribute.
    /// </summary>
    public TerraformProperty<string> ArchivePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("archive_policy");
        set => SetProperty("archive_policy", value);
    }

    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    public TerraformProperty<bool> ContentBasedDeduplication
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("content_based_deduplication");
        set => SetProperty("content_based_deduplication", value);
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public TerraformProperty<string> DeliveryPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delivery_policy");
        set => SetProperty("delivery_policy", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The fifo_throughput_scope attribute.
    /// </summary>
    public TerraformProperty<string> FifoThroughputScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fifo_throughput_scope");
        set => SetProperty("fifo_throughput_scope", value);
    }

    /// <summary>
    /// The fifo_topic attribute.
    /// </summary>
    public TerraformProperty<bool> FifoTopic
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fifo_topic");
        set => SetProperty("fifo_topic", value);
    }

    /// <summary>
    /// The firehose_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> FirehoseFailureFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firehose_failure_feedback_role_arn");
        set => SetProperty("firehose_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The firehose_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> FirehoseSuccessFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firehose_success_feedback_role_arn");
        set => SetProperty("firehose_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The firehose_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double> FirehoseSuccessFeedbackSampleRate
    {
        get => GetRequiredOutput<TerraformProperty<double>>("firehose_success_feedback_sample_rate");
        set => SetProperty("firehose_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The http_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> HttpFailureFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_failure_feedback_role_arn");
        set => SetProperty("http_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The http_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> HttpSuccessFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_success_feedback_role_arn");
        set => SetProperty("http_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The http_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double> HttpSuccessFeedbackSampleRate
    {
        get => GetRequiredOutput<TerraformProperty<double>>("http_success_feedback_sample_rate");
        set => SetProperty("http_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsMasterKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_master_key_id");
        set => SetProperty("kms_master_key_id", value);
    }

    /// <summary>
    /// The lambda_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> LambdaFailureFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lambda_failure_feedback_role_arn");
        set => SetProperty("lambda_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The lambda_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> LambdaSuccessFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lambda_success_feedback_role_arn");
        set => SetProperty("lambda_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The lambda_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double> LambdaSuccessFeedbackSampleRate
    {
        get => GetRequiredOutput<TerraformProperty<double>>("lambda_success_feedback_sample_rate");
        set => SetProperty("lambda_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string> Policy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy");
        set => SetProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The signature_version attribute.
    /// </summary>
    public TerraformProperty<double> SignatureVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("signature_version");
        set => SetProperty("signature_version", value);
    }

    /// <summary>
    /// The sqs_failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> SqsFailureFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sqs_failure_feedback_role_arn");
        set => SetProperty("sqs_failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The sqs_success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> SqsSuccessFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sqs_success_feedback_role_arn");
        set => SetProperty("sqs_success_feedback_role_arn", value);
    }

    /// <summary>
    /// The sqs_success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double> SqsSuccessFeedbackSampleRate
    {
        get => GetRequiredOutput<TerraformProperty<double>>("sqs_success_feedback_sample_rate");
        set => SetProperty("sqs_success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The tracing_config attribute.
    /// </summary>
    public TerraformProperty<string> TracingConfig
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tracing_config");
        set => SetProperty("tracing_config", value);
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
