using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for message_review_handler in AwsIvschatRoom.
/// Nesting mode: list
/// </summary>
public class AwsIvschatRoomMessageReviewHandlerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_review_handler";

    /// <summary>
    /// The fallback_result attribute.
    /// </summary>
    public TerraformValue<string> FallbackResult
    {
        get => new TerraformReference<string>(this, "fallback_result");
        set => SetArgument("fallback_result", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsIvschatRoom.
/// Nesting mode: single
/// </summary>
public class AwsIvschatRoomTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ivschat_room Terraform resource.
/// Manages a aws_ivschat_room resource.
/// </summary>
public partial class AwsIvschatRoom(string name) : TerraformResource("aws_ivschat_room", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The logging_configuration_identifiers attribute.
    /// </summary>
    public TerraformList<string>? LoggingConfigurationIdentifiers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "logging_configuration_identifiers").ResolveNodes(ctx));
        set => SetArgument("logging_configuration_identifiers", value);
    }

    /// <summary>
    /// The maximum_message_length attribute.
    /// </summary>
    public TerraformValue<double> MaximumMessageLength
    {
        get => new TerraformReference<double>(this, "maximum_message_length");
        set => SetArgument("maximum_message_length", value);
    }

    /// <summary>
    /// The maximum_message_rate_per_second attribute.
    /// </summary>
    public TerraformValue<double> MaximumMessageRatePerSecond
    {
        get => new TerraformReference<double>(this, "maximum_message_rate_per_second");
        set => SetArgument("maximum_message_rate_per_second", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
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
    /// MessageReviewHandler block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MessageReviewHandler block(s) allowed")]
    public TerraformList<AwsIvschatRoomMessageReviewHandlerBlock>? MessageReviewHandler
    {
        get => GetArgument<TerraformList<AwsIvschatRoomMessageReviewHandlerBlock>>("message_review_handler");
        set => SetArgument("message_review_handler", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsIvschatRoomTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsIvschatRoomTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
