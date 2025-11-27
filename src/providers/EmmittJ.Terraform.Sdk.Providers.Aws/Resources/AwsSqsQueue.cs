using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsSqsQueue.
/// Nesting mode: single
/// </summary>
public class AwsSqsQueueTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_sqs_queue Terraform resource.
/// Manages a aws_sqs_queue resource.
/// </summary>
public partial class AwsSqsQueue(string name) : TerraformResource("aws_sqs_queue", name)
{
    /// <summary>
    /// The content_based_deduplication attribute.
    /// </summary>
    public TerraformValue<bool>? ContentBasedDeduplication
    {
        get => new TerraformReference<bool>(this, "content_based_deduplication");
        set => SetArgument("content_based_deduplication", value);
    }

    /// <summary>
    /// The deduplication_scope attribute.
    /// </summary>
    public TerraformValue<string> DeduplicationScope
    {
        get => new TerraformReference<string>(this, "deduplication_scope");
        set => SetArgument("deduplication_scope", value);
    }

    /// <summary>
    /// The delay_seconds attribute.
    /// </summary>
    public TerraformValue<double>? DelaySeconds
    {
        get => new TerraformReference<double>(this, "delay_seconds");
        set => SetArgument("delay_seconds", value);
    }

    /// <summary>
    /// The fifo_queue attribute.
    /// </summary>
    public TerraformValue<bool>? FifoQueue
    {
        get => new TerraformReference<bool>(this, "fifo_queue");
        set => SetArgument("fifo_queue", value);
    }

    /// <summary>
    /// The fifo_throughput_limit attribute.
    /// </summary>
    public TerraformValue<string> FifoThroughputLimit
    {
        get => new TerraformReference<string>(this, "fifo_throughput_limit");
        set => SetArgument("fifo_throughput_limit", value);
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
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    public TerraformValue<double> KmsDataKeyReusePeriodSeconds
    {
        get => new TerraformReference<double>(this, "kms_data_key_reuse_period_seconds");
        set => SetArgument("kms_data_key_reuse_period_seconds", value);
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
    /// The max_message_size attribute.
    /// </summary>
    public TerraformValue<double>? MaxMessageSize
    {
        get => new TerraformReference<double>(this, "max_message_size");
        set => SetArgument("max_message_size", value);
    }

    /// <summary>
    /// The message_retention_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MessageRetentionSeconds
    {
        get => new TerraformReference<double>(this, "message_retention_seconds");
        set => SetArgument("message_retention_seconds", value);
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
    /// The receive_wait_time_seconds attribute.
    /// </summary>
    public TerraformValue<double>? ReceiveWaitTimeSeconds
    {
        get => new TerraformReference<double>(this, "receive_wait_time_seconds");
        set => SetArgument("receive_wait_time_seconds", value);
    }

    /// <summary>
    /// The redrive_allow_policy attribute.
    /// </summary>
    public TerraformValue<string> RedriveAllowPolicy
    {
        get => new TerraformReference<string>(this, "redrive_allow_policy");
        set => SetArgument("redrive_allow_policy", value);
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    public TerraformValue<string> RedrivePolicy
    {
        get => new TerraformReference<string>(this, "redrive_policy");
        set => SetArgument("redrive_policy", value);
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
    /// The sqs_managed_sse_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SqsManagedSseEnabled
    {
        get => new TerraformReference<bool>(this, "sqs_managed_sse_enabled");
        set => SetArgument("sqs_managed_sse_enabled", value);
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
    /// The visibility_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? VisibilityTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "visibility_timeout_seconds");
        set => SetArgument("visibility_timeout_seconds", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSqsQueueTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSqsQueueTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
