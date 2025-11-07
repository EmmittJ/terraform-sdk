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
    /// The locale_specification attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, object>>? LocaleSpecification
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, object>>>("locale_specification");
        set => this.WithProperty("locale_specification", value);
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
