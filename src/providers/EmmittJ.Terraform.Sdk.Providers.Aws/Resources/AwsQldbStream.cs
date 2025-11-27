using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kinesis_configuration in AwsQldbStream.
/// Nesting mode: list
/// </summary>
public class AwsQldbStreamKinesisConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_configuration";

    /// <summary>
    /// The aggregation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AggregationEnabled
    {
        get => new TerraformReference<bool>(this, "aggregation_enabled");
        set => SetArgument("aggregation_enabled", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    public required TerraformValue<string> StreamArn
    {
        get => new TerraformReference<string>(this, "stream_arn");
        set => SetArgument("stream_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsQldbStream.
/// Nesting mode: single
/// </summary>
public class AwsQldbStreamTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_qldb_stream Terraform resource.
/// Manages a aws_qldb_stream resource.
/// </summary>
public partial class AwsQldbStream(string name) : TerraformResource("aws_qldb_stream", name)
{
    /// <summary>
    /// The exclusive_end_time attribute.
    /// </summary>
    public TerraformValue<string>? ExclusiveEndTime
    {
        get => new TerraformReference<string>(this, "exclusive_end_time");
        set => SetArgument("exclusive_end_time", value);
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
    /// The inclusive_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InclusiveStartTime is required")]
    public required TerraformValue<string> InclusiveStartTime
    {
        get => new TerraformReference<string>(this, "inclusive_start_time");
        set => SetArgument("inclusive_start_time", value);
    }

    /// <summary>
    /// The ledger_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerName is required")]
    public required TerraformValue<string> LedgerName
    {
        get => new TerraformReference<string>(this, "ledger_name");
        set => SetArgument("ledger_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformValue<string> StreamName
    {
        get => new TerraformReference<string>(this, "stream_name");
        set => SetArgument("stream_name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// KinesisConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KinesisConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KinesisConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisConfiguration block(s) allowed")]
    public required TerraformList<AwsQldbStreamKinesisConfigurationBlock> KinesisConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsQldbStreamKinesisConfigurationBlock>>("kinesis_configuration");
        set => SetArgument("kinesis_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsQldbStreamTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsQldbStreamTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
