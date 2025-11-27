using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsLexv2modelsBotVersion.
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsBotVersionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_lexv2models_bot_version Terraform resource.
/// Manages a aws_lexv2models_bot_version resource.
/// </summary>
public partial class AwsLexv2modelsBotVersion(string name) : TerraformResource("aws_lexv2models_bot_version", name)
{
    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    public required TerraformValue<string> BotId
    {
        get => new TerraformReference<string>(this, "bot_id");
        set => SetArgument("bot_id", value);
    }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    public TerraformValue<string> BotVersion
    {
        get => new TerraformReference<string>(this, "bot_version");
        set => SetArgument("bot_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The locale_specification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleSpecification is required")]
    public required TerraformMap<TerraformMap<object>> LocaleSpecification
    {
        get => TerraformMap<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformMap<TerraformMap<object>>>(this, "locale_specification").ResolveNodes(ctx));
        set => SetArgument("locale_specification", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLexv2modelsBotVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLexv2modelsBotVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
