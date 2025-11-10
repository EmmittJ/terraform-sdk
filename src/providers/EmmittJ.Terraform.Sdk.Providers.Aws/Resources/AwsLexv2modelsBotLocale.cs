using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsBotLocaleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for voice_settings in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsBotLocaleVoiceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => WithProperty("engine", value);
    }

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceId is required")]
    public required TerraformProperty<string> VoiceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("voice_id");
        set => WithProperty("voice_id", value);
    }

}

/// <summary>
/// Manages a aws_lexv2models_bot_locale resource.
/// </summary>
public class AwsLexv2modelsBotLocale : TerraformResource
{
    public AwsLexv2modelsBotLocale(string name) : base("aws_lexv2models_bot_locale", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("id");
    }

    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    public required TerraformProperty<string> BotId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bot_id");
        set => this.WithProperty("bot_id", value);
    }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    public required TerraformProperty<string> BotVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bot_version");
        set => this.WithProperty("bot_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    public required TerraformProperty<string> LocaleId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("locale_id");
        set => this.WithProperty("locale_id", value);
    }

    /// <summary>
    /// The n_lu_intent_confidence_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NLuIntentConfidenceThreshold is required")]
    public required TerraformProperty<double> NLuIntentConfidenceThreshold
    {
        get => GetRequiredProperty<TerraformProperty<double>>("n_lu_intent_confidence_threshold");
        set => this.WithProperty("n_lu_intent_confidence_threshold", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLexv2modelsBotLocaleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLexv2modelsBotLocaleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for voice_settings.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsBotLocaleVoiceSettingsBlock>? VoiceSettings
    {
        get => GetProperty<List<AwsLexv2modelsBotLocaleVoiceSettingsBlock>>("voice_settings");
        set => this.WithProperty("voice_settings", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
