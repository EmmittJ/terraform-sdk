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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("url");
        SetOutput("content_based_deduplication");
        SetOutput("deduplication_scope");
        SetOutput("delay_seconds");
        SetOutput("fifo_queue");
        SetOutput("fifo_throughput_limit");
        SetOutput("id");
        SetOutput("kms_data_key_reuse_period_seconds");
        SetOutput("kms_master_key_id");
        SetOutput("max_message_size");
        SetOutput("message_retention_seconds");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("policy");
        SetOutput("receive_wait_time_seconds");
        SetOutput("redrive_allow_policy");
        SetOutput("redrive_policy");
        SetOutput("region");
        SetOutput("sqs_managed_sse_enabled");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("visibility_timeout_seconds");
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
    /// The deduplication_scope attribute.
    /// </summary>
    public TerraformProperty<string> DeduplicationScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deduplication_scope");
        set => SetProperty("deduplication_scope", value);
    }

    /// <summary>
    /// The delay_seconds attribute.
    /// </summary>
    public TerraformProperty<double> DelaySeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("delay_seconds");
        set => SetProperty("delay_seconds", value);
    }

    /// <summary>
    /// The fifo_queue attribute.
    /// </summary>
    public TerraformProperty<bool> FifoQueue
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fifo_queue");
        set => SetProperty("fifo_queue", value);
    }

    /// <summary>
    /// The fifo_throughput_limit attribute.
    /// </summary>
    public TerraformProperty<string> FifoThroughputLimit
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fifo_throughput_limit");
        set => SetProperty("fifo_throughput_limit", value);
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
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    public TerraformProperty<double> KmsDataKeyReusePeriodSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("kms_data_key_reuse_period_seconds");
        set => SetProperty("kms_data_key_reuse_period_seconds", value);
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
    /// The max_message_size attribute.
    /// </summary>
    public TerraformProperty<double> MaxMessageSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_message_size");
        set => SetProperty("max_message_size", value);
    }

    /// <summary>
    /// The message_retention_seconds attribute.
    /// </summary>
    public TerraformProperty<double> MessageRetentionSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("message_retention_seconds");
        set => SetProperty("message_retention_seconds", value);
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
    /// The receive_wait_time_seconds attribute.
    /// </summary>
    public TerraformProperty<double> ReceiveWaitTimeSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("receive_wait_time_seconds");
        set => SetProperty("receive_wait_time_seconds", value);
    }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    public TerraformProperty<string> RedriveAllowPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redrive_allow_policy");
        set => SetProperty("redrive_allow_policy", value);
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    public TerraformProperty<string> RedrivePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redrive_policy");
        set => SetProperty("redrive_policy", value);
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
    /// The sqs_managed_sse_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SqsManagedSseEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sqs_managed_sse_enabled");
        set => SetProperty("sqs_managed_sse_enabled", value);
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
    /// The visibility_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double> VisibilityTimeoutSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("visibility_timeout_seconds");
        set => SetProperty("visibility_timeout_seconds", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSqsQueueTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
