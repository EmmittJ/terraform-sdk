using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiple_values_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsSlotMultipleValuesSettingBlock() : TerraformBlock("multiple_values_setting")
{
    /// <summary>
    /// The allow_multiple_values attribute.
    /// </summary>
    [TerraformProperty("allow_multiple_values")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowMultipleValues { get; set; }

}

/// <summary>
/// Block type for obfuscation_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsSlotObfuscationSettingBlock() : TerraformBlock("obfuscation_setting")
{
    /// <summary>
    /// The obfuscation_setting_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObfuscationSettingType is required")]
    [TerraformProperty("obfuscation_setting_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ObfuscationSettingType { get; set; }

}

/// <summary>
/// Block type for sub_slot_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsSlotSubSlotSettingBlock() : TerraformBlock("sub_slot_setting")
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    [TerraformProperty("expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Expression { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLexv2modelsSlotTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for value_elicitation_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsSlotValueElicitationSettingBlock() : TerraformBlock("value_elicitation_setting")
{
    /// <summary>
    /// The slot_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotConstraint is required")]
    [TerraformProperty("slot_constraint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SlotConstraint { get; set; }

}

/// <summary>
/// Manages a aws_lexv2models_slot resource.
/// </summary>
public partial class AwsLexv2modelsSlot : TerraformResource
{
    public AwsLexv2modelsSlot(string name) : base("aws_lexv2models_slot", name)
    {
    }

    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    [TerraformProperty("bot_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BotId { get; set; }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    [TerraformProperty("bot_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BotVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The intent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentId is required")]
    [TerraformProperty("intent_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IntentId { get; set; }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    [TerraformProperty("locale_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LocaleId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    [TerraformProperty("slot_type_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SlotTypeId { get; set; }

    /// <summary>
    /// Block for multiple_values_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("multiple_values_setting")]
    public TerraformList<AwsLexv2modelsSlotMultipleValuesSettingBlock> MultipleValuesSetting { get; set; } = new();

    /// <summary>
    /// Block for obfuscation_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("obfuscation_setting")]
    public TerraformList<AwsLexv2modelsSlotObfuscationSettingBlock> ObfuscationSetting { get; set; } = new();

    /// <summary>
    /// Block for sub_slot_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("sub_slot_setting")]
    public TerraformList<AwsLexv2modelsSlotSubSlotSettingBlock> SubSlotSetting { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsLexv2modelsSlotTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for value_elicitation_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("value_elicitation_setting")]
    public TerraformList<AwsLexv2modelsSlotValueElicitationSettingBlock> ValueElicitationSetting { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The slot_id attribute.
    /// </summary>
    [TerraformProperty("slot_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SlotId { get; }

}
