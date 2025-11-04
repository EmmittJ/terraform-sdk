using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lexv2models_slot_type resource.
/// </summary>
public class AwsLexv2modelsSlotType : TerraformResource
{
    public AwsLexv2modelsSlotType(string name) : base("aws_lexv2models_slot_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("slot_type_id");
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
    /// The parent_slot_type_signature attribute.
    /// </summary>
    public string? ParentSlotTypeSignature
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_slot_type_signature")?.Value;
        set => this.WithProperty("parent_slot_type_signature", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    public TerraformExpression SlotTypeId => this["slot_type_id"];

}
