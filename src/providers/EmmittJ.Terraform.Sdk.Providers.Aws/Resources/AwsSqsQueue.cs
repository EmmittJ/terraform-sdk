using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSqsQueueTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
        this.WithOutput("arn");
        this.WithOutput("url");
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
    /// The deduplication_scope attribute.
    /// </summary>
    public TerraformProperty<string>? DeduplicationScope
    {
        get => GetProperty<TerraformProperty<string>>("deduplication_scope");
        set => this.WithProperty("deduplication_scope", value);
    }

    /// <summary>
    /// The delay_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DelaySeconds
    {
        get => GetProperty<TerraformProperty<double>>("delay_seconds");
        set => this.WithProperty("delay_seconds", value);
    }

    /// <summary>
    /// The fifo_queue attribute.
    /// </summary>
    public TerraformProperty<bool>? FifoQueue
    {
        get => GetProperty<TerraformProperty<bool>>("fifo_queue");
        set => this.WithProperty("fifo_queue", value);
    }

    /// <summary>
    /// The fifo_throughput_limit attribute.
    /// </summary>
    public TerraformProperty<string>? FifoThroughputLimit
    {
        get => GetProperty<TerraformProperty<string>>("fifo_throughput_limit");
        set => this.WithProperty("fifo_throughput_limit", value);
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
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? KmsDataKeyReusePeriodSeconds
    {
        get => GetProperty<TerraformProperty<double>>("kms_data_key_reuse_period_seconds");
        set => this.WithProperty("kms_data_key_reuse_period_seconds", value);
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
    /// The max_message_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxMessageSize
    {
        get => GetProperty<TerraformProperty<double>>("max_message_size");
        set => this.WithProperty("max_message_size", value);
    }

    /// <summary>
    /// The message_retention_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MessageRetentionSeconds
    {
        get => GetProperty<TerraformProperty<double>>("message_retention_seconds");
        set => this.WithProperty("message_retention_seconds", value);
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
    /// The receive_wait_time_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ReceiveWaitTimeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("receive_wait_time_seconds");
        set => this.WithProperty("receive_wait_time_seconds", value);
    }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    public TerraformProperty<string>? RedriveAllowPolicy
    {
        get => GetProperty<TerraformProperty<string>>("redrive_allow_policy");
        set => this.WithProperty("redrive_allow_policy", value);
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    public TerraformProperty<string>? RedrivePolicy
    {
        get => GetProperty<TerraformProperty<string>>("redrive_policy");
        set => this.WithProperty("redrive_policy", value);
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
    /// The sqs_managed_sse_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SqsManagedSseEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sqs_managed_sse_enabled");
        set => this.WithProperty("sqs_managed_sse_enabled", value);
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
    /// The visibility_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? VisibilityTimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("visibility_timeout_seconds");
        set => this.WithProperty("visibility_timeout_seconds", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSqsQueueTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsSqsQueueTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
