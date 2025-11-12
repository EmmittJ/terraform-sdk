using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for composite_slot_type_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock() : TerraformBlock("composite_slot_type_setting")
{
}

/// <summary>
/// Block type for external_source_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsSlotTypeExternalSourceSettingBlock() : TerraformBlock("external_source_setting")
{
}

/// <summary>
/// Block type for slot_type_values in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsSlotTypeSlotTypeValuesBlock() : TerraformBlock("slot_type_values")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLexv2modelsSlotTypeTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for value_selection_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsSlotTypeValueSelectionSettingBlock() : TerraformBlock("value_selection_setting")
{
    /// <summary>
    /// The resolution_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResolutionStrategy is required")]
    [TerraformProperty("resolution_strategy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResolutionStrategy { get; set; }

}

/// <summary>
/// Manages a aws_lexv2models_slot_type resource.
/// </summary>
public partial class AwsLexv2modelsSlotType : TerraformResource
{
    public AwsLexv2modelsSlotType(string name) : base("aws_lexv2models_slot_type", name)
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
    /// The parent_slot_type_signature attribute.
    /// </summary>
    [TerraformProperty("parent_slot_type_signature")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ParentSlotTypeSignature { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for composite_slot_type_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("composite_slot_type_setting")]
    public TerraformList<AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock> CompositeSlotTypeSetting { get; set; } = new();

    /// <summary>
    /// Block for external_source_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("external_source_setting")]
    public TerraformList<AwsLexv2modelsSlotTypeExternalSourceSettingBlock> ExternalSourceSetting { get; set; } = new();

    /// <summary>
    /// Block for slot_type_values.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("slot_type_values")]
    public TerraformList<AwsLexv2modelsSlotTypeSlotTypeValuesBlock> SlotTypeValues { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsLexv2modelsSlotTypeTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for value_selection_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("value_selection_setting")]
    public TerraformList<AwsLexv2modelsSlotTypeValueSelectionSettingBlock> ValueSelectionSetting { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    [TerraformProperty("slot_type_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SlotTypeId { get; }

}
