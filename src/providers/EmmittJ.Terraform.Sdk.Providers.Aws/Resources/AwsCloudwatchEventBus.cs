using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dead_letter_config in AwsCloudwatchEventBus.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventBusDeadLetterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dead_letter_config";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

}


/// <summary>
/// Block type for log_config in AwsCloudwatchEventBus.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventBusLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_config";

    /// <summary>
    /// The include_detail attribute.
    /// </summary>
    public TerraformValue<string>? IncludeDetail
    {
        get => new TerraformReference<string>(this, "include_detail");
        set => SetArgument("include_detail", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformValue<string>? Level
    {
        get => new TerraformReference<string>(this, "level");
        set => SetArgument("level", value);
    }

}


/// <summary>
/// Represents a aws_cloudwatch_event_bus Terraform resource.
/// Manages a aws_cloudwatch_event_bus resource.
/// </summary>
public partial class AwsCloudwatchEventBus(string name) : TerraformResource("aws_cloudwatch_event_bus", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The event_source_name attribute.
    /// </summary>
    public TerraformValue<string>? EventSourceName
    {
        get => new TerraformReference<string>(this, "event_source_name");
        set => SetArgument("event_source_name", value);
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
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyIdentifier
    {
        get => new TerraformReference<string>(this, "kms_key_identifier");
        set => SetArgument("kms_key_identifier", value);
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
    /// DeadLetterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public TerraformList<AwsCloudwatchEventBusDeadLetterConfigBlock>? DeadLetterConfig
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventBusDeadLetterConfigBlock>>("dead_letter_config");
        set => SetArgument("dead_letter_config", value);
    }

    /// <summary>
    /// LogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public TerraformList<AwsCloudwatchEventBusLogConfigBlock>? LogConfig
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventBusLogConfigBlock>>("log_config");
        set => SetArgument("log_config", value);
    }

}
