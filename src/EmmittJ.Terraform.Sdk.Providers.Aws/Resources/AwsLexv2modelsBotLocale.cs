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
    public TerraformLiteralProperty<string>? BotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bot_id");
        set => this.WithProperty("bot_id", value);
    }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BotVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bot_version");
        set => this.WithProperty("bot_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LocaleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("locale_id");
        set => this.WithProperty("locale_id", value);
    }

    /// <summary>
    /// The n_lu_intent_confidence_threshold attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NLuIntentConfidenceThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("n_lu_intent_confidence_threshold");
        set => this.WithProperty("n_lu_intent_confidence_threshold", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
