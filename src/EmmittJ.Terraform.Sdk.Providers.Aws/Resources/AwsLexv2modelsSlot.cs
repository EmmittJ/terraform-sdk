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
    /// The intent_id attribute.
    /// </summary>
    public TerraformProperty<string>? IntentId
    {
        get => GetProperty<TerraformProperty<string>>("intent_id");
        set => this.WithProperty("intent_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    public TerraformProperty<string>? SlotTypeId
    {
        get => GetProperty<TerraformProperty<string>>("slot_type_id");
        set => this.WithProperty("slot_type_id", value);
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
