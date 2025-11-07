using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sqs_queue resource.
/// </summary>
public class AwsSqsQueue : TerraformResource
{
    public AwsSqsQueue(string name) : base("aws_sqs_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("url");
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
    /// The deduplication_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeduplicationScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deduplication_scope");
        set => this.WithProperty("deduplication_scope", value);
    }

    /// <summary>
    /// The delay_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DelaySeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("delay_seconds");
        set => this.WithProperty("delay_seconds", value);
    }

    /// <summary>
    /// The fifo_queue attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FifoQueue
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fifo_queue");
        set => this.WithProperty("fifo_queue", value);
    }

    /// <summary>
    /// The fifo_throughput_limit attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FifoThroughputLimit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fifo_throughput_limit");
        set => this.WithProperty("fifo_throughput_limit", value);
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
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? KmsDataKeyReusePeriodSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("kms_data_key_reuse_period_seconds");
        set => this.WithProperty("kms_data_key_reuse_period_seconds", value);
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
    /// The max_message_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxMessageSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_message_size");
        set => this.WithProperty("max_message_size", value);
    }

    /// <summary>
    /// The message_retention_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MessageRetentionSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("message_retention_seconds");
        set => this.WithProperty("message_retention_seconds", value);
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
    /// The receive_wait_time_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ReceiveWaitTimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("receive_wait_time_seconds");
        set => this.WithProperty("receive_wait_time_seconds", value);
    }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RedriveAllowPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redrive_allow_policy");
        set => this.WithProperty("redrive_allow_policy", value);
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RedrivePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redrive_policy");
        set => this.WithProperty("redrive_policy", value);
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
    /// The sqs_managed_sse_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SqsManagedSseEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sqs_managed_sse_enabled");
        set => this.WithProperty("sqs_managed_sse_enabled", value);
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
    /// The visibility_timeout_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? VisibilityTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("visibility_timeout_seconds");
        set => this.WithProperty("visibility_timeout_seconds", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
