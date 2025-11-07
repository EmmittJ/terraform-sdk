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
    public TerraformProperty<string>? BotId
    {
        get => GetProperty<TerraformProperty<string>>("bot_id");
        set => this.WithProperty("bot_id", value);
    }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    public TerraformProperty<string>? BotVersion
    {
        get => GetProperty<TerraformProperty<string>>("bot_version");
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
    public TerraformProperty<string>? LocaleId
    {
        get => GetProperty<TerraformProperty<string>>("locale_id");
        set => this.WithProperty("locale_id", value);
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
    /// The parent_intent_signature attribute.
    /// </summary>
    public TerraformProperty<string>? ParentIntentSignature
    {
        get => GetProperty<TerraformProperty<string>>("parent_intent_signature");
        set => this.WithProperty("parent_intent_signature", value);
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
