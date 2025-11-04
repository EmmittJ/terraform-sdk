using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lexv2models_bot_version resource.
/// </summary>
public class AwsLexv2modelsBotVersion : TerraformResource
{
    public AwsLexv2modelsBotVersion(string name) : base("aws_lexv2models_bot_version", name)
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
    /// The locale_specification attribute.
    /// </summary>
    public Dictionary<string, object>? LocaleSpecification
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, object>>>("locale_specification")?.Value;
        set => this.WithProperty("locale_specification", value == null ? null : new TerraformLiteralProperty<Dictionary<string, object>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
