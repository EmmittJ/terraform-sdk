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
    public TerraformValue<string>? FallbackResult
    {
        get => GetArgument<TerraformValue<string>>("fallback_result");
        set => SetArgument("fallback_result", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
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
/// Represents a aws_ivschat_room Terraform resource.
/// Manages a aws_ivschat_room resource.
/// </summary>
public partial class AwsIvschatRoom(string name) : TerraformResource("aws_ivschat_room", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The logging_configuration_identifiers attribute.
    /// </summary>
    public TerraformList<string>? LoggingConfigurationIdentifiers
    {
        get => GetArgument<TerraformList<string>>("logging_configuration_identifiers");
        set => SetArgument("logging_configuration_identifiers", value);
    }

    /// <summary>
    /// The maximum_message_length attribute.
    /// </summary>
    public TerraformValue<double>? MaximumMessageLength
    {
        get => GetArgument<TerraformValue<double>>("maximum_message_length");
        set => SetArgument("maximum_message_length", value);
    }

    /// <summary>
    /// The maximum_message_rate_per_second attribute.
    /// </summary>
    public TerraformValue<double>? MaximumMessageRatePerSecond
    {
        get => GetArgument<TerraformValue<double>>("maximum_message_rate_per_second");
        set => SetArgument("maximum_message_rate_per_second", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

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
