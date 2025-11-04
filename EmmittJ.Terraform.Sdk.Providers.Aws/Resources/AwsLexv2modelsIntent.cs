using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lexv2models_intent resource.
/// </summary>
public class AwsLexv2modelsIntent : TerraformResource
{
    public AwsLexv2modelsIntent(string name) : base("aws_lexv2models_intent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_date_time");
        this.DeclareOutput("id");
        this.DeclareOutput("intent_id");
        this.DeclareOutput("last_updated_date_time");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_intent_signature attribute.
    /// </summary>
    public string? ParentIntentSignature
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_intent_signature")?.Value;
        set => this.WithProperty("parent_intent_signature", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The creation_date_time attribute.
    /// </summary>
    public TerraformExpression CreationDateTime => this["creation_date_time"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The intent_id attribute.
    /// </summary>
    public TerraformExpression IntentId => this["intent_id"];

    /// <summary>
    /// The last_updated_date_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDateTime => this["last_updated_date_time"];

}
