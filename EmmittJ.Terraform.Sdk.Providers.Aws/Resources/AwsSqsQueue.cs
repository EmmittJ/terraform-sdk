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
    public bool? ContentBasedDeduplication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("content_based_deduplication")?.Value;
        set => this.WithProperty("content_based_deduplication", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The deduplication_scope attribute.
    /// </summary>
    public string? DeduplicationScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deduplication_scope")?.Value;
        set => this.WithProperty("deduplication_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delay_seconds attribute.
    /// </summary>
    public double? DelaySeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("delay_seconds")?.Value;
        set => this.WithProperty("delay_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The fifo_queue attribute.
    /// </summary>
    public bool? FifoQueue
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fifo_queue")?.Value;
        set => this.WithProperty("fifo_queue", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The fifo_throughput_limit attribute.
    /// </summary>
    public string? FifoThroughputLimit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fifo_throughput_limit")?.Value;
        set => this.WithProperty("fifo_throughput_limit", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    public double? KmsDataKeyReusePeriodSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("kms_data_key_reuse_period_seconds")?.Value;
        set => this.WithProperty("kms_data_key_reuse_period_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The max_message_size attribute.
    /// </summary>
    public double? MaxMessageSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_message_size")?.Value;
        set => this.WithProperty("max_message_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The message_retention_seconds attribute.
    /// </summary>
    public double? MessageRetentionSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("message_retention_seconds")?.Value;
        set => this.WithProperty("message_retention_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The receive_wait_time_seconds attribute.
    /// </summary>
    public double? ReceiveWaitTimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("receive_wait_time_seconds")?.Value;
        set => this.WithProperty("receive_wait_time_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    public string? RedriveAllowPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redrive_allow_policy")?.Value;
        set => this.WithProperty("redrive_allow_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    public string? RedrivePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redrive_policy")?.Value;
        set => this.WithProperty("redrive_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sqs_managed_sse_enabled attribute.
    /// </summary>
    public bool? SqsManagedSseEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sqs_managed_sse_enabled")?.Value;
        set => this.WithProperty("sqs_managed_sse_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The visibility_timeout_seconds attribute.
    /// </summary>
    public double? VisibilityTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("visibility_timeout_seconds")?.Value;
        set => this.WithProperty("visibility_timeout_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
