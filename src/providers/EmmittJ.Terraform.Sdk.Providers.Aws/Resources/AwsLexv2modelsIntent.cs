using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for closing_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentClosingSettingBlock
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformPropertyName("active")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Active { get; set; }

}

/// <summary>
/// Block type for confirmation_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentConfirmationSettingBlock
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformPropertyName("active")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Active { get; set; }

}

/// <summary>
/// Block type for dialog_code_hook in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentDialogCodeHookBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for fulfillment_code_hook in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentFulfillmentCodeHookBlock
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformPropertyName("active")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Active { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for initial_response_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentInitialResponseSettingBlock
{
}

/// <summary>
/// Block type for input_context in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentInputContextBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for kendra_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentKendraConfigurationBlock
{
    /// <summary>
    /// The kendra_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KendraIndex is required")]
    [TerraformPropertyName("kendra_index")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KendraIndex { get; set; }

    /// <summary>
    /// The query_filter_string attribute.
    /// </summary>
    [TerraformPropertyName("query_filter_string")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? QueryFilterString { get; set; }

    /// <summary>
    /// The query_filter_string_enabled attribute.
    /// </summary>
    [TerraformPropertyName("query_filter_string_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? QueryFilterStringEnabled { get; set; }

}

/// <summary>
/// Block type for output_context in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentOutputContextBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The time_to_live_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeToLiveInSeconds is required")]
    [TerraformPropertyName("time_to_live_in_seconds")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> TimeToLiveInSeconds { get; set; }

    /// <summary>
    /// The turns_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TurnsToLive is required")]
    [TerraformPropertyName("turns_to_live")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> TurnsToLive { get; set; }

}

/// <summary>
/// Block type for sample_utterance in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentSampleUtteranceBlock
{
    /// <summary>
    /// The utterance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Utterance is required")]
    [TerraformPropertyName("utterance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Utterance { get; set; }

}

/// <summary>
/// Block type for slot_priority in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentSlotPriorityBlock
{
    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The slot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    [TerraformPropertyName("slot_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SlotId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsIntentTimeoutsBlock
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
/// Manages a aws_lexv2models_intent resource.
/// </summary>
public class AwsLexv2modelsIntent : TerraformResource
{
    public AwsLexv2modelsIntent(string name) : base("aws_lexv2models_intent", name)
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
    /// The parent_intent_signature attribute.
    /// </summary>
    [TerraformPropertyName("parent_intent_signature")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ParentIntentSignature { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for closing_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("closing_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentClosingSettingBlock>>? ClosingSetting { get; set; }

    /// <summary>
    /// Block for confirmation_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("confirmation_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentConfirmationSettingBlock>>? ConfirmationSetting { get; set; }

    /// <summary>
    /// Block for dialog_code_hook.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("dialog_code_hook")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentDialogCodeHookBlock>>? DialogCodeHook { get; set; }

    /// <summary>
    /// Block for fulfillment_code_hook.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("fulfillment_code_hook")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentFulfillmentCodeHookBlock>>? FulfillmentCodeHook { get; set; }

    /// <summary>
    /// Block for initial_response_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("initial_response_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentInitialResponseSettingBlock>>? InitialResponseSetting { get; set; }

    /// <summary>
    /// Block for input_context.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("input_context")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentInputContextBlock>>? InputContext { get; set; }

    /// <summary>
    /// Block for kendra_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("kendra_configuration")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentKendraConfigurationBlock>>? KendraConfiguration { get; set; }

    /// <summary>
    /// Block for output_context.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("output_context")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentOutputContextBlock>>? OutputContext { get; set; }

    /// <summary>
    /// Block for sample_utterance.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("sample_utterance")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentSampleUtteranceBlock>>? SampleUtterance { get; set; }

    /// <summary>
    /// Block for slot_priority.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("slot_priority")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentSlotPriorityBlock>>? SlotPriority { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLexv2modelsIntentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The creation_date_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_date_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationDateTime => new TerraformReference(this, "creation_date_time");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The intent_id attribute.
    /// </summary>
    [TerraformPropertyName("intent_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IntentId => new TerraformReference(this, "intent_id");

    /// <summary>
    /// The last_updated_date_time attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedDateTime => new TerraformReference(this, "last_updated_date_time");

}
