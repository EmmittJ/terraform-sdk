using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for stream_mode_details in AwsKinesisStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisStreamStreamModeDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stream_mode_details";

    /// <summary>
    /// The stream_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamMode is required")]
    public required TerraformValue<string> StreamMode
    {
        get => new TerraformReference<string>(this, "stream_mode");
        set => SetArgument("stream_mode", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsKinesisStream.
/// Nesting mode: single
/// </summary>
public class AwsKinesisStreamTimeoutsBlock : TerraformBlock
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
/// Represents a aws_kinesis_stream Terraform resource.
/// Manages a aws_kinesis_stream resource.
/// </summary>
public partial class AwsKinesisStream(string name) : TerraformResource("aws_kinesis_stream", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionType
    {
        get => new TerraformReference<string>(this, "encryption_type");
        set => SetArgument("encryption_type", value);
    }

    /// <summary>
    /// The enforce_consumer_deletion attribute.
    /// </summary>
    public TerraformValue<bool>? EnforceConsumerDeletion
    {
        get => new TerraformReference<bool>(this, "enforce_consumer_deletion");
        set => SetArgument("enforce_consumer_deletion", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPeriod
    {
        get => new TerraformReference<double>(this, "retention_period");
        set => SetArgument("retention_period", value);
    }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    public TerraformValue<double>? ShardCount
    {
        get => new TerraformReference<double>(this, "shard_count");
        set => SetArgument("shard_count", value);
    }

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    public TerraformSet<string>? ShardLevelMetrics
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "shard_level_metrics").ResolveNodes(ctx));
        set => SetArgument("shard_level_metrics", value);
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
    /// StreamModeDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamModeDetails block(s) allowed")]
    public TerraformList<AwsKinesisStreamStreamModeDetailsBlock>? StreamModeDetails
    {
        get => GetArgument<TerraformList<AwsKinesisStreamStreamModeDetailsBlock>>("stream_mode_details");
        set => SetArgument("stream_mode_details", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKinesisStreamTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKinesisStreamTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
