using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsLexv2modelsBotLocale.
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsBotLocaleTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for voice_settings in AwsLexv2modelsBotLocale.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsBotLocaleVoiceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "voice_settings";

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceId is required")]
    public required TerraformValue<string> VoiceId
    {
        get => new TerraformReference<string>(this, "voice_id");
        set => SetArgument("voice_id", value);
    }

}


/// <summary>
/// Represents a aws_lexv2models_bot_locale Terraform resource.
/// Manages a aws_lexv2models_bot_locale resource.
/// </summary>
public partial class AwsLexv2modelsBotLocale(string name) : TerraformResource("aws_lexv2models_bot_locale", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    public required TerraformValue<string> BotVersion
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
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    public required TerraformValue<string> LocaleId
    {
        get => new TerraformReference<string>(this, "locale_id");
        set => SetArgument("locale_id", value);
    }

    /// <summary>
    /// The n_lu_intent_confidence_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NLuIntentConfidenceThreshold is required")]
    public required TerraformValue<double> NLuIntentConfidenceThreshold
    {
        get => new TerraformReference<double>(this, "n_lu_intent_confidence_threshold");
        set => SetArgument("n_lu_intent_confidence_threshold", value);
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
    public AwsLexv2modelsBotLocaleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLexv2modelsBotLocaleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VoiceSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsBotLocaleVoiceSettingsBlock>? VoiceSettings
    {
        get => GetArgument<TerraformList<AwsLexv2modelsBotLocaleVoiceSettingsBlock>>("voice_settings");
        set => SetArgument("voice_settings", value);
    }

}
