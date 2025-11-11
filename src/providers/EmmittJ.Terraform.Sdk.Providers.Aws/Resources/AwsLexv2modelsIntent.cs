using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for closing_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsIntentClosingSettingBlock : TerraformBlockBase
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformProperty("active")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Active { get; set; }

}

/// <summary>
/// Block type for confirmation_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsIntentConfirmationSettingBlock : TerraformBlockBase
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformProperty("active")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Active { get; set; }

}

/// <summary>
/// Block type for dialog_code_hook in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsIntentDialogCodeHookBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for fulfillment_code_hook in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsIntentFulfillmentCodeHookBlock : TerraformBlockBase
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformProperty("active")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Active { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for initial_response_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsIntentInitialResponseSettingBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for input_context in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsIntentInputContextBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for kendra_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsIntentKendraConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The kendra_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KendraIndex is required")]
    [TerraformProperty("kendra_index")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KendraIndex { get; set; }

    /// <summary>
    /// The query_filter_string attribute.
    /// </summary>
    [TerraformProperty("query_filter_string")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? QueryFilterString { get; set; }

    /// <summary>
    /// The query_filter_string_enabled attribute.
    /// </summary>
    [TerraformProperty("query_filter_string_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? QueryFilterStringEnabled { get; set; }

}

/// <summary>
/// Block type for output_context in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsIntentOutputContextBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The time_to_live_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeToLiveInSeconds is required")]
    [TerraformProperty("time_to_live_in_seconds")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> TimeToLiveInSeconds { get; set; }

    /// <summary>
    /// The turns_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TurnsToLive is required")]
    [TerraformProperty("turns_to_live")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> TurnsToLive { get; set; }

}

/// <summary>
/// Block type for sample_utterance in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsIntentSampleUtteranceBlock : TerraformBlockBase
{
    /// <summary>
    /// The utterance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Utterance is required")]
    [TerraformProperty("utterance")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Utterance { get; set; }

}

/// <summary>
/// Block type for slot_priority in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexv2modelsIntentSlotPriorityBlock : TerraformBlockBase
{
    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The slot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    [TerraformProperty("slot_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SlotId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLexv2modelsIntentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_lexv2models_intent resource.
/// </summary>
public partial class AwsLexv2modelsIntent : TerraformResource
{
    public AwsLexv2modelsIntent(string name) : base("aws_lexv2models_intent", name)
    {
    }

    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    [TerraformProperty("bot_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BotId { get; set; }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    [TerraformProperty("bot_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BotVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    [TerraformProperty("locale_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LocaleId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_intent_signature attribute.
    /// </summary>
    [TerraformProperty("parent_intent_signature")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ParentIntentSignature { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for closing_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("closing_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentClosingSettingBlock>>? ClosingSetting { get; set; }

    /// <summary>
    /// Block for confirmation_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("confirmation_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentConfirmationSettingBlock>>? ConfirmationSetting { get; set; }

    /// <summary>
    /// Block for dialog_code_hook.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("dialog_code_hook")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentDialogCodeHookBlock>>? DialogCodeHook { get; set; }

    /// <summary>
    /// Block for fulfillment_code_hook.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("fulfillment_code_hook")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentFulfillmentCodeHookBlock>>? FulfillmentCodeHook { get; set; }

    /// <summary>
    /// Block for initial_response_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("initial_response_setting")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentInitialResponseSettingBlock>>? InitialResponseSetting { get; set; }

    /// <summary>
    /// Block for input_context.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("input_context")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentInputContextBlock>>? InputContext { get; set; }

    /// <summary>
    /// Block for kendra_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("kendra_configuration")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentKendraConfigurationBlock>>? KendraConfiguration { get; set; }

    /// <summary>
    /// Block for output_context.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("output_context")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentOutputContextBlock>>? OutputContext { get; set; }

    /// <summary>
    /// Block for sample_utterance.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("sample_utterance")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentSampleUtteranceBlock>>? SampleUtterance { get; set; }

    /// <summary>
    /// Block for slot_priority.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("slot_priority")]
    public TerraformList<TerraformBlock<AwsLexv2modelsIntentSlotPriorityBlock>>? SlotPriority { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsLexv2modelsIntentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The creation_date_time attribute.
    /// </summary>
    [TerraformProperty("creation_date_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationDateTime { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The intent_id attribute.
    /// </summary>
    [TerraformProperty("intent_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IntentId { get; }

    /// <summary>
    /// The last_updated_date_time attribute.
    /// </summary>
    [TerraformProperty("last_updated_date_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdatedDateTime { get; }

}
