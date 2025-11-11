using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for composite_slot_type_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock
{
}

/// <summary>
/// Block type for external_source_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeExternalSourceSettingBlock
{
}

/// <summary>
/// Block type for slot_type_values in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeSlotTypeValuesBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsSlotTypeTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for value_selection_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeValueSelectionSettingBlock
{
    /// <summary>
    /// The resolution_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResolutionStrategy is required")]
    [TerraformPropertyName("resolution_strategy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResolutionStrategy { get; set; }

}

/// <summary>
/// Manages a aws_lexv2models_slot_type resource.
/// </summary>
public class AwsLexv2modelsSlotType : TerraformResource
{
    public AwsLexv2modelsSlotType(string name) : base("aws_lexv2models_slot_type", name)
    {
    }

    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    [TerraformPropertyName("bot_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BotId { get; set; }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    [TerraformPropertyName("bot_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BotVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    [TerraformPropertyName("locale_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LocaleId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_slot_type_signature attribute.
    /// </summary>
    [TerraformPropertyName("parent_slot_type_signature")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ParentSlotTypeSignature { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for composite_slot_type_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("composite_slot_type_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock>>? CompositeSlotTypeSetting { get; set; }

    /// <summary>
    /// Block for external_source_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("external_source_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsSlotTypeExternalSourceSettingBlock>>? ExternalSourceSetting { get; set; }

    /// <summary>
    /// Block for slot_type_values.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("slot_type_values")]
    public TerraformList<TerraformBlock<AwsLexv2modelsSlotTypeSlotTypeValuesBlock>>? SlotTypeValues { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLexv2modelsSlotTypeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for value_selection_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("value_selection_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsSlotTypeValueSelectionSettingBlock>>? ValueSelectionSetting { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    [TerraformPropertyName("slot_type_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SlotTypeId => new TerraformReference(this, "slot_type_id");

}
