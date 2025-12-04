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
        get => GetArgument<TerraformValue<string>>("stream_mode");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionType
    {
        get => GetArgument<TerraformValue<string>>("encryption_type");
        set => SetArgument("encryption_type", value);
    }

    /// <summary>
    /// The enforce_consumer_deletion attribute.
    /// </summary>
    public TerraformValue<bool>? EnforceConsumerDeletion
    {
        get => GetArgument<TerraformValue<bool>>("enforce_consumer_deletion");
        set => SetArgument("enforce_consumer_deletion", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("retention_period");
        set => SetArgument("retention_period", value);
    }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    public TerraformValue<double>? ShardCount
    {
        get => GetArgument<TerraformValue<double>>("shard_count");
        set => SetArgument("shard_count", value);
    }

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    public TerraformSet<string>? ShardLevelMetrics
    {
        get => GetArgument<TerraformSet<string>>("shard_level_metrics");
        set => SetArgument("shard_level_metrics", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
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
