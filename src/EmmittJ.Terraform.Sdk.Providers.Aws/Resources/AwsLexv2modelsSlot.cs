using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiple_values_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotMultipleValuesSettingBlock : TerraformBlock
{
    /// <summary>
    /// The allow_multiple_values attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowMultipleValues
    {
        get => GetProperty<TerraformProperty<bool>>("allow_multiple_values");
        set => WithProperty("allow_multiple_values", value);
    }

}

/// <summary>
/// Block type for obfuscation_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotObfuscationSettingBlock : TerraformBlock
{
    /// <summary>
    /// The obfuscation_setting_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObfuscationSettingType is required")]
    public required TerraformProperty<string> ObfuscationSettingType
    {
        get => GetProperty<TerraformProperty<string>>("obfuscation_setting_type");
        set => WithProperty("obfuscation_setting_type", value);
    }

}

/// <summary>
/// Block type for sub_slot_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlock : TerraformBlock
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformProperty<string>? Expression
    {
        get => GetProperty<TerraformProperty<string>>("expression");
        set => WithProperty("expression", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsSlotTimeoutsBlock : TerraformBlock
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
/// Block type for value_elicitation_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlock : TerraformBlock
{
    /// <summary>
    /// The slot_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotConstraint is required")]
    public required TerraformProperty<string> SlotConstraint
    {
        get => GetProperty<TerraformProperty<string>>("slot_constraint");
        set => WithProperty("slot_constraint", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    public required TerraformProperty<string> BotId
    {
        get => GetProperty<TerraformProperty<string>>("bot_id");
        set => this.WithProperty("bot_id", value);
    }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    public required TerraformProperty<string> BotVersion
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentId is required")]
    public required TerraformProperty<string> IntentId
    {
        get => GetProperty<TerraformProperty<string>>("intent_id");
        set => this.WithProperty("intent_id", value);
    }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    public required TerraformProperty<string> LocaleId
    {
        get => GetProperty<TerraformProperty<string>>("locale_id");
        set => this.WithProperty("locale_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// Block for multiple_values_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotMultipleValuesSettingBlock>? MultipleValuesSetting
    {
        get => GetProperty<List<AwsLexv2modelsSlotMultipleValuesSettingBlock>>("multiple_values_setting");
        set => this.WithProperty("multiple_values_setting", value);
    }

    /// <summary>
    /// Block for obfuscation_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotObfuscationSettingBlock>? ObfuscationSetting
    {
        get => GetProperty<List<AwsLexv2modelsSlotObfuscationSettingBlock>>("obfuscation_setting");
        set => this.WithProperty("obfuscation_setting", value);
    }

    /// <summary>
    /// Block for sub_slot_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotSubSlotSettingBlock>? SubSlotSetting
    {
        get => GetProperty<List<AwsLexv2modelsSlotSubSlotSettingBlock>>("sub_slot_setting");
        set => this.WithProperty("sub_slot_setting", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLexv2modelsSlotTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLexv2modelsSlotTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for value_elicitation_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotValueElicitationSettingBlock>? ValueElicitationSetting
    {
        get => GetProperty<List<AwsLexv2modelsSlotValueElicitationSettingBlock>>("value_elicitation_setting");
        set => this.WithProperty("value_elicitation_setting", value);
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
