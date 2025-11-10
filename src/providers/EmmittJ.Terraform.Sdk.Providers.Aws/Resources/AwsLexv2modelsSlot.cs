using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiple_values_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotMultipleValuesSettingBlock : ITerraformBlock
{
    /// <summary>
    /// The allow_multiple_values attribute.
    /// </summary>
    [TerraformPropertyName("allow_multiple_values")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowMultipleValues { get; set; }

}

/// <summary>
/// Block type for obfuscation_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotObfuscationSettingBlock : ITerraformBlock
{
    /// <summary>
    /// The obfuscation_setting_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObfuscationSettingType is required")]
    [TerraformPropertyName("obfuscation_setting_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ObfuscationSettingType { get; set; }

}

/// <summary>
/// Block type for sub_slot_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotSubSlotSettingBlock : ITerraformBlock
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    [TerraformPropertyName("expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Expression { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsSlotTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for value_elicitation_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotValueElicitationSettingBlock : ITerraformBlock
{
    /// <summary>
    /// The slot_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotConstraint is required")]
    [TerraformPropertyName("slot_constraint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SlotConstraint { get; set; }

}

/// <summary>
/// Manages a aws_lexv2models_slot resource.
/// </summary>
public class AwsLexv2modelsSlot : TerraformResource
{
    public AwsLexv2modelsSlot(string name) : base("aws_lexv2models_slot", name)
    {
    }

    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    [TerraformPropertyName("bot_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BotId { get; set; }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    [TerraformPropertyName("bot_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BotVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The intent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentId is required")]
    [TerraformPropertyName("intent_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IntentId { get; set; }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    [TerraformPropertyName("locale_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LocaleId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    [TerraformPropertyName("slot_type_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SlotTypeId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "slot_type_id");

    /// <summary>
    /// Block for multiple_values_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("multiple_values_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsSlotMultipleValuesSettingBlock>>? MultipleValuesSetting { get; set; } = new();

    /// <summary>
    /// Block for obfuscation_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("obfuscation_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsSlotObfuscationSettingBlock>>? ObfuscationSetting { get; set; } = new();

    /// <summary>
    /// Block for sub_slot_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("sub_slot_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsSlotSubSlotSettingBlock>>? SubSlotSetting { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLexv2modelsSlotTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for value_elicitation_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("value_elicitation_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsSlotValueElicitationSettingBlock>>? ValueElicitationSetting { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The slot_id attribute.
    /// </summary>
    [TerraformPropertyName("slot_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SlotId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "slot_id");

}
