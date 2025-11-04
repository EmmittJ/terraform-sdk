using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    public string? BotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bot_id")?.Value;
        set => this.WithProperty("bot_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    public string? BotVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bot_version")?.Value;
        set => this.WithProperty("bot_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    public string? LocaleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("locale_id")?.Value;
        set => this.WithProperty("locale_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The n_lu_intent_confidence_threshold attribute.
    /// </summary>
    public double? NLuIntentConfidenceThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("n_lu_intent_confidence_threshold")?.Value;
        set => this.WithProperty("n_lu_intent_confidence_threshold", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
