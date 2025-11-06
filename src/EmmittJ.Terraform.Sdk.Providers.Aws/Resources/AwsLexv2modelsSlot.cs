using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lexv2models_slot resource.
/// </summary>
public class AwsLexv2modelsSlot : TerraformResource
{
    public AwsLexv2modelsSlot(string name) : base("aws_lexv2models_slot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("slot_id");
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
    /// The intent_id attribute.
    /// </summary>
    public string? IntentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("intent_id")?.Value;
        set => this.WithProperty("intent_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    public string? SlotTypeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("slot_type_id")?.Value;
        set => this.WithProperty("slot_type_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The slot_id attribute.
    /// </summary>
    public TerraformExpression SlotId => this["slot_id"];

}
