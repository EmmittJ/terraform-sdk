using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_settings in GoogleDialogflowCxPage.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageAdvancedSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_settings";

    /// <summary>
    /// DtmfSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DtmfSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageAdvancedSettingsBlockDtmfSettingsBlock>? DtmfSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageAdvancedSettingsBlockDtmfSettingsBlock>>("dtmf_settings");
        set => SetArgument("dtmf_settings", value);
    }

}

/// <summary>
/// Block type for dtmf_settings in GoogleDialogflowCxPageAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageAdvancedSettingsBlockDtmfSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dtmf_settings";

    /// <summary>
    /// If true, incoming audio is processed for DTMF (dual tone multi frequency) events. For example, if the caller presses a button on their telephone keypad and DTMF processing is enabled, Dialogflow will detect the event (e.g. a &amp;quot;3&amp;quot; was pressed) in the incoming audio and pass the event to the bot to drive business logic (e.g. when 3 is pressed, return the account balance).
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The digit that terminates a DTMF digit sequence.
    /// </summary>
    public TerraformValue<string>? FinishDigit
    {
        get => new TerraformReference<string>(this, "finish_digit");
        set => SetArgument("finish_digit", value);
    }

    /// <summary>
    /// Max length of DTMF digits.
    /// </summary>
    public TerraformValue<double>? MaxDigits
    {
        get => new TerraformReference<double>(this, "max_digits");
        set => SetArgument("max_digits", value);
    }

}


/// <summary>
/// Block type for entry_fulfillment in GoogleDialogflowCxPage.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entry_fulfillment";

    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    public TerraformValue<bool>? ReturnPartialResponses
    {
        get => new TerraformReference<bool>(this, "return_partial_responses");
        set => SetArgument("return_partial_responses", value);
    }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Webhook
    {
        get => new TerraformReference<string>(this, "webhook");
        set => SetArgument("webhook", value);
    }

    /// <summary>
    /// ConditionalCases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockConditionalCasesBlock>? ConditionalCases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockConditionalCasesBlock>>("conditional_cases");
        set => SetArgument("conditional_cases", value);
    }

    /// <summary>
    /// Messages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlock>? Messages
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlock>>("messages");
        set => SetArgument("messages", value);
    }

    /// <summary>
    /// SetParameterActions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockSetParameterActionsBlock>? SetParameterActions
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockSetParameterActionsBlock>>("set_parameter_actions");
        set => SetArgument("set_parameter_actions", value);
    }

}

/// <summary>
/// Block type for conditional_cases in GoogleDialogflowCxPageEntryFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlockConditionalCasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditional_cases";

    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.
    /// </summary>
    public TerraformValue<string>? Cases
    {
        get => new TerraformReference<string>(this, "cases");
        set => SetArgument("cases", value);
    }

}

/// <summary>
/// Block type for messages in GoogleDialogflowCxPageEntryFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "messages";

    /// <summary>
    /// The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.
    /// </summary>
    public TerraformValue<string>? Channel
    {
        get => new TerraformReference<string>(this, "channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// A custom, platform-specific payload.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => new TerraformReference<string>(this, "payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// ConversationSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationSuccess block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockConversationSuccessBlock>? ConversationSuccess
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockConversationSuccessBlock>>("conversation_success");
        set => SetArgument("conversation_success", value);
    }

    /// <summary>
    /// LiveAgentHandoff block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveAgentHandoff block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>? LiveAgentHandoff
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>>("live_agent_handoff");
        set => SetArgument("live_agent_handoff", value);
    }

    /// <summary>
    /// OutputAudioText block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputAudioText block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockOutputAudioTextBlock>? OutputAudioText
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockOutputAudioTextBlock>>("output_audio_text");
        set => SetArgument("output_audio_text", value);
    }

    /// <summary>
    /// PlayAudio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlayAudio block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockPlayAudioBlock>? PlayAudio
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockPlayAudioBlock>>("play_audio");
        set => SetArgument("play_audio", value);
    }

    /// <summary>
    /// TelephonyTransferCall block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelephonyTransferCall block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>? TelephonyTransferCall
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>>("telephony_transfer_call");
        set => SetArgument("telephony_transfer_call", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for conversation_success in GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockConversationSuccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_success";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for live_agent_handoff in GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockLiveAgentHandoffBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "live_agent_handoff";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for output_audio_text in GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockOutputAudioTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_audio_text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// The SSML text to be synthesized. For more information, see SSML.
    /// </summary>
    public TerraformValue<string>? Ssml
    {
        get => new TerraformReference<string>(this, "ssml");
        set => SetArgument("ssml", value);
    }

    /// <summary>
    /// The raw text to be synthesized.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for play_audio in GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockPlayAudioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "play_audio";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioUri is required")]
    public required TerraformValue<string> AudioUri
    {
        get => new TerraformReference<string>(this, "audio_uri");
        set => SetArgument("audio_uri", value);
    }

}

/// <summary>
/// Block type for telephony_transfer_call in GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockTelephonyTransferCallBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "telephony_transfer_call";

    /// <summary>
    /// Transfer the call to a phone number in E.164 format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for text in GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlockMessagesBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// A collection of text responses.
    /// </summary>
    public TerraformList<string>? Text
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "text").ResolveNodes(ctx));
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for set_parameter_actions in GoogleDialogflowCxPageEntryFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEntryFulfillmentBlockSetParameterActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "set_parameter_actions";

    /// <summary>
    /// Display name of the parameter.
    /// </summary>
    public TerraformValue<string>? Parameter
    {
        get => new TerraformReference<string>(this, "parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The new JSON-encoded value of the parameter. A null value clears the parameter.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for event_handlers in GoogleDialogflowCxPage.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_handlers";

    /// <summary>
    /// The name of the event to handle.
    /// </summary>
    public TerraformValue<string>? EventAttribute
    {
        get => new TerraformReference<string>(this, "event");
        set => SetArgument("event", value);
    }

    /// <summary>
    /// The unique identifier of this event handler.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? TargetFlow
    {
        get => new TerraformReference<string>(this, "target_flow");
        set => SetArgument("target_flow", value);
    }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? TargetPage
    {
        get => new TerraformReference<string>(this, "target_page");
        set => SetArgument("target_page", value);
    }

    /// <summary>
    /// TriggerFulfillment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerFulfillment block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlock>? TriggerFulfillment
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlock>>("trigger_fulfillment");
        set => SetArgument("trigger_fulfillment", value);
    }

}

/// <summary>
/// Block type for trigger_fulfillment in GoogleDialogflowCxPageEventHandlersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger_fulfillment";

    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    public TerraformValue<bool>? ReturnPartialResponses
    {
        get => new TerraformReference<bool>(this, "return_partial_responses");
        set => SetArgument("return_partial_responses", value);
    }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Webhook
    {
        get => new TerraformReference<string>(this, "webhook");
        set => SetArgument("webhook", value);
    }

    /// <summary>
    /// ConditionalCases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockConditionalCasesBlock>? ConditionalCases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockConditionalCasesBlock>>("conditional_cases");
        set => SetArgument("conditional_cases", value);
    }

    /// <summary>
    /// Messages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlock>? Messages
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlock>>("messages");
        set => SetArgument("messages", value);
    }

    /// <summary>
    /// SetParameterActions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockSetParameterActionsBlock>? SetParameterActions
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockSetParameterActionsBlock>>("set_parameter_actions");
        set => SetArgument("set_parameter_actions", value);
    }

}

/// <summary>
/// Block type for conditional_cases in GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockConditionalCasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditional_cases";

    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.
    /// </summary>
    public TerraformValue<string>? Cases
    {
        get => new TerraformReference<string>(this, "cases");
        set => SetArgument("cases", value);
    }

}

/// <summary>
/// Block type for messages in GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "messages";

    /// <summary>
    /// The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.
    /// </summary>
    public TerraformValue<string>? Channel
    {
        get => new TerraformReference<string>(this, "channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// A custom, platform-specific payload.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => new TerraformReference<string>(this, "payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// ConversationSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationSuccess block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>? ConversationSuccess
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>>("conversation_success");
        set => SetArgument("conversation_success", value);
    }

    /// <summary>
    /// LiveAgentHandoff block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveAgentHandoff block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>? LiveAgentHandoff
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>>("live_agent_handoff");
        set => SetArgument("live_agent_handoff", value);
    }

    /// <summary>
    /// OutputAudioText block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputAudioText block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>? OutputAudioText
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>>("output_audio_text");
        set => SetArgument("output_audio_text", value);
    }

    /// <summary>
    /// PlayAudio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlayAudio block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>? PlayAudio
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>>("play_audio");
        set => SetArgument("play_audio", value);
    }

    /// <summary>
    /// TelephonyTransferCall block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelephonyTransferCall block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>? TelephonyTransferCall
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>>("telephony_transfer_call");
        set => SetArgument("telephony_transfer_call", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for conversation_success in GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_success";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for live_agent_handoff in GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "live_agent_handoff";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for output_audio_text in GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_audio_text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// The SSML text to be synthesized. For more information, see SSML.
    /// </summary>
    public TerraformValue<string>? Ssml
    {
        get => new TerraformReference<string>(this, "ssml");
        set => SetArgument("ssml", value);
    }

    /// <summary>
    /// The raw text to be synthesized.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for play_audio in GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "play_audio";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioUri is required")]
    public required TerraformValue<string> AudioUri
    {
        get => new TerraformReference<string>(this, "audio_uri");
        set => SetArgument("audio_uri", value);
    }

}

/// <summary>
/// Block type for telephony_transfer_call in GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "telephony_transfer_call";

    /// <summary>
    /// Transfer the call to a phone number in E.164 format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for text in GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// A collection of text responses.
    /// </summary>
    public TerraformList<string>? Text
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "text").ResolveNodes(ctx));
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for set_parameter_actions in GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageEventHandlersBlockTriggerFulfillmentBlockSetParameterActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "set_parameter_actions";

    /// <summary>
    /// Display name of the parameter.
    /// </summary>
    public TerraformValue<string>? Parameter
    {
        get => new TerraformReference<string>(this, "parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The new JSON-encoded value of the parameter. A null value clears the parameter.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for form in GoogleDialogflowCxPage.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "form";

    /// <summary>
    /// Parameters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in GoogleDialogflowCxPageFormBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The default value of an optional parameter. If the parameter is required, the default value will be ignored.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => new TerraformReference<string>(this, "default_value");
        set => SetArgument("default_value", value);
    }

    /// <summary>
    /// The human-readable name of the parameter, unique within the form.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The entity type of the parameter.
    /// Format: projects/-/locations/-/agents/-/entityTypes/&amp;lt;System Entity Type ID&amp;gt; for system entity types (for example, projects/-/locations/-/agents/-/entityTypes/sys.date), or projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/entityTypes/&amp;lt;Entity Type ID&amp;gt; for developer entity types.
    /// </summary>
    public TerraformValue<string>? EntityType
    {
        get => new TerraformReference<string>(this, "entity_type");
        set => SetArgument("entity_type", value);
    }

    /// <summary>
    /// Indicates whether the parameter represents a list of values.
    /// </summary>
    public TerraformValue<bool>? IsList
    {
        get => new TerraformReference<bool>(this, "is_list");
        set => SetArgument("is_list", value);
    }

    /// <summary>
    /// Indicates whether the parameter content should be redacted in log.
    /// If redaction is enabled, the parameter content will be replaced by parameter name during logging. Note: the parameter content is subject to redaction if either parameter level redaction or entity type level redaction is enabled.
    /// </summary>
    public TerraformValue<bool>? Redact
    {
        get => new TerraformReference<bool>(this, "redact");
        set => SetArgument("redact", value);
    }

    /// <summary>
    /// Indicates whether the parameter is required. Optional parameters will not trigger prompts; however, they are filled if the user specifies them.
    /// Required parameters must be filled before form filling concludes.
    /// </summary>
    public TerraformValue<bool>? Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// AdvancedSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockAdvancedSettingsBlock>? AdvancedSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockAdvancedSettingsBlock>>("advanced_settings");
        set => SetArgument("advanced_settings", value);
    }

    /// <summary>
    /// FillBehavior block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FillBehavior block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlock>? FillBehavior
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlock>>("fill_behavior");
        set => SetArgument("fill_behavior", value);
    }

}

/// <summary>
/// Block type for advanced_settings in GoogleDialogflowCxPageFormBlockParametersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockAdvancedSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_settings";

    /// <summary>
    /// DtmfSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DtmfSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockAdvancedSettingsBlockDtmfSettingsBlock>? DtmfSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockAdvancedSettingsBlockDtmfSettingsBlock>>("dtmf_settings");
        set => SetArgument("dtmf_settings", value);
    }

}

/// <summary>
/// Block type for dtmf_settings in GoogleDialogflowCxPageFormBlockParametersBlockAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockAdvancedSettingsBlockDtmfSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dtmf_settings";

    /// <summary>
    /// If true, incoming audio is processed for DTMF (dual tone multi frequency) events. For example, if the caller presses a button on their telephone keypad and DTMF processing is enabled, Dialogflow will detect the event (e.g. a &amp;quot;3&amp;quot; was pressed) in the incoming audio and pass the event to the bot to drive business logic (e.g. when 3 is pressed, return the account balance).
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The digit that terminates a DTMF digit sequence.
    /// </summary>
    public TerraformValue<string>? FinishDigit
    {
        get => new TerraformReference<string>(this, "finish_digit");
        set => SetArgument("finish_digit", value);
    }

    /// <summary>
    /// Max length of DTMF digits.
    /// </summary>
    public TerraformValue<double>? MaxDigits
    {
        get => new TerraformReference<double>(this, "max_digits");
        set => SetArgument("max_digits", value);
    }

}

/// <summary>
/// Block type for fill_behavior in GoogleDialogflowCxPageFormBlockParametersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fill_behavior";

    /// <summary>
    /// InitialPromptFulfillment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialPromptFulfillment block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlock>? InitialPromptFulfillment
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlock>>("initial_prompt_fulfillment");
        set => SetArgument("initial_prompt_fulfillment", value);
    }

    /// <summary>
    /// RepromptEventHandlers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlock>? RepromptEventHandlers
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlock>>("reprompt_event_handlers");
        set => SetArgument("reprompt_event_handlers", value);
    }

}

/// <summary>
/// Block type for initial_prompt_fulfillment in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initial_prompt_fulfillment";

    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    public TerraformValue<bool>? ReturnPartialResponses
    {
        get => new TerraformReference<bool>(this, "return_partial_responses");
        set => SetArgument("return_partial_responses", value);
    }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Webhook
    {
        get => new TerraformReference<string>(this, "webhook");
        set => SetArgument("webhook", value);
    }

    /// <summary>
    /// ConditionalCases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockConditionalCasesBlock>? ConditionalCases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockConditionalCasesBlock>>("conditional_cases");
        set => SetArgument("conditional_cases", value);
    }

    /// <summary>
    /// Messages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlock>? Messages
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlock>>("messages");
        set => SetArgument("messages", value);
    }

    /// <summary>
    /// SetParameterActions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockSetParameterActionsBlock>? SetParameterActions
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockSetParameterActionsBlock>>("set_parameter_actions");
        set => SetArgument("set_parameter_actions", value);
    }

}

/// <summary>
/// Block type for conditional_cases in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockConditionalCasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditional_cases";

    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.
    /// </summary>
    public TerraformValue<string>? Cases
    {
        get => new TerraformReference<string>(this, "cases");
        set => SetArgument("cases", value);
    }

}

/// <summary>
/// Block type for messages in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "messages";

    /// <summary>
    /// The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.
    /// </summary>
    public TerraformValue<string>? Channel
    {
        get => new TerraformReference<string>(this, "channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// A custom, platform-specific payload.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => new TerraformReference<string>(this, "payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// ConversationSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationSuccess block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockConversationSuccessBlock>? ConversationSuccess
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockConversationSuccessBlock>>("conversation_success");
        set => SetArgument("conversation_success", value);
    }

    /// <summary>
    /// LiveAgentHandoff block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveAgentHandoff block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>? LiveAgentHandoff
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>>("live_agent_handoff");
        set => SetArgument("live_agent_handoff", value);
    }

    /// <summary>
    /// OutputAudioText block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputAudioText block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockOutputAudioTextBlock>? OutputAudioText
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockOutputAudioTextBlock>>("output_audio_text");
        set => SetArgument("output_audio_text", value);
    }

    /// <summary>
    /// PlayAudio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlayAudio block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockPlayAudioBlock>? PlayAudio
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockPlayAudioBlock>>("play_audio");
        set => SetArgument("play_audio", value);
    }

    /// <summary>
    /// TelephonyTransferCall block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelephonyTransferCall block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>? TelephonyTransferCall
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>>("telephony_transfer_call");
        set => SetArgument("telephony_transfer_call", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for conversation_success in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockConversationSuccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_success";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for live_agent_handoff in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockLiveAgentHandoffBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "live_agent_handoff";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for output_audio_text in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockOutputAudioTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_audio_text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// The SSML text to be synthesized. For more information, see SSML.
    /// </summary>
    public TerraformValue<string>? Ssml
    {
        get => new TerraformReference<string>(this, "ssml");
        set => SetArgument("ssml", value);
    }

    /// <summary>
    /// The raw text to be synthesized.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for play_audio in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockPlayAudioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "play_audio";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioUri is required")]
    public required TerraformValue<string> AudioUri
    {
        get => new TerraformReference<string>(this, "audio_uri");
        set => SetArgument("audio_uri", value);
    }

}

/// <summary>
/// Block type for telephony_transfer_call in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockTelephonyTransferCallBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "telephony_transfer_call";

    /// <summary>
    /// Transfer the call to a phone number in E.164 format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for text in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockMessagesBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// A collection of text responses.
    /// </summary>
    public TerraformList<string>? Text
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "text").ResolveNodes(ctx));
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for set_parameter_actions in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockInitialPromptFulfillmentBlockSetParameterActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "set_parameter_actions";

    /// <summary>
    /// Display name of the parameter.
    /// </summary>
    public TerraformValue<string>? Parameter
    {
        get => new TerraformReference<string>(this, "parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The new JSON-encoded value of the parameter. A null value clears the parameter.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for reprompt_event_handlers in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reprompt_event_handlers";

    /// <summary>
    /// The name of the event to handle.
    /// </summary>
    public TerraformValue<string>? EventAttribute
    {
        get => new TerraformReference<string>(this, "event");
        set => SetArgument("event", value);
    }

    /// <summary>
    /// The unique identifier of this event handler.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? TargetFlow
    {
        get => new TerraformReference<string>(this, "target_flow");
        set => SetArgument("target_flow", value);
    }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? TargetPage
    {
        get => new TerraformReference<string>(this, "target_page");
        set => SetArgument("target_page", value);
    }

    /// <summary>
    /// TriggerFulfillment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerFulfillment block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlock>? TriggerFulfillment
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlock>>("trigger_fulfillment");
        set => SetArgument("trigger_fulfillment", value);
    }

}

/// <summary>
/// Block type for trigger_fulfillment in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger_fulfillment";

    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    public TerraformValue<bool>? ReturnPartialResponses
    {
        get => new TerraformReference<bool>(this, "return_partial_responses");
        set => SetArgument("return_partial_responses", value);
    }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Webhook
    {
        get => new TerraformReference<string>(this, "webhook");
        set => SetArgument("webhook", value);
    }

    /// <summary>
    /// ConditionalCases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockConditionalCasesBlock>? ConditionalCases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockConditionalCasesBlock>>("conditional_cases");
        set => SetArgument("conditional_cases", value);
    }

    /// <summary>
    /// Messages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlock>? Messages
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlock>>("messages");
        set => SetArgument("messages", value);
    }

    /// <summary>
    /// SetParameterActions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockSetParameterActionsBlock>? SetParameterActions
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockSetParameterActionsBlock>>("set_parameter_actions");
        set => SetArgument("set_parameter_actions", value);
    }

}

/// <summary>
/// Block type for conditional_cases in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockConditionalCasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditional_cases";

    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.
    /// </summary>
    public TerraformValue<string>? Cases
    {
        get => new TerraformReference<string>(this, "cases");
        set => SetArgument("cases", value);
    }

}

/// <summary>
/// Block type for messages in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "messages";

    /// <summary>
    /// The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.
    /// </summary>
    public TerraformValue<string>? Channel
    {
        get => new TerraformReference<string>(this, "channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// A custom, platform-specific payload.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => new TerraformReference<string>(this, "payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// ConversationSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationSuccess block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>? ConversationSuccess
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>>("conversation_success");
        set => SetArgument("conversation_success", value);
    }

    /// <summary>
    /// LiveAgentHandoff block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveAgentHandoff block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>? LiveAgentHandoff
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>>("live_agent_handoff");
        set => SetArgument("live_agent_handoff", value);
    }

    /// <summary>
    /// OutputAudioText block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputAudioText block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>? OutputAudioText
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>>("output_audio_text");
        set => SetArgument("output_audio_text", value);
    }

    /// <summary>
    /// PlayAudio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlayAudio block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>? PlayAudio
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>>("play_audio");
        set => SetArgument("play_audio", value);
    }

    /// <summary>
    /// TelephonyTransferCall block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelephonyTransferCall block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>? TelephonyTransferCall
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>>("telephony_transfer_call");
        set => SetArgument("telephony_transfer_call", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for conversation_success in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_success";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for live_agent_handoff in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "live_agent_handoff";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for output_audio_text in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_audio_text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// The SSML text to be synthesized. For more information, see SSML.
    /// </summary>
    public TerraformValue<string>? Ssml
    {
        get => new TerraformReference<string>(this, "ssml");
        set => SetArgument("ssml", value);
    }

    /// <summary>
    /// The raw text to be synthesized.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for play_audio in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "play_audio";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioUri is required")]
    public required TerraformValue<string> AudioUri
    {
        get => new TerraformReference<string>(this, "audio_uri");
        set => SetArgument("audio_uri", value);
    }

}

/// <summary>
/// Block type for telephony_transfer_call in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "telephony_transfer_call";

    /// <summary>
    /// Transfer the call to a phone number in E.164 format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for text in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// A collection of text responses.
    /// </summary>
    public TerraformList<string>? Text
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "text").ResolveNodes(ctx));
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for set_parameter_actions in GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageFormBlockParametersBlockFillBehaviorBlockRepromptEventHandlersBlockTriggerFulfillmentBlockSetParameterActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "set_parameter_actions";

    /// <summary>
    /// Display name of the parameter.
    /// </summary>
    public TerraformValue<string>? Parameter
    {
        get => new TerraformReference<string>(this, "parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The new JSON-encoded value of the parameter. A null value clears the parameter.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for knowledge_connector_settings in GoogleDialogflowCxPage.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "knowledge_connector_settings";

    /// <summary>
    /// Whether Knowledge Connector is enabled or not.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The target flow to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;.
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    public TerraformValue<string>? TargetFlow
    {
        get => new TerraformReference<string>(this, "target_flow");
        set => SetArgument("target_flow", value);
    }

    /// <summary>
    /// The target page to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;/pages/&amp;lt;PageID&amp;gt;.
    /// The page must be in the same host flow (the flow that owns this &#39;KnowledgeConnectorSettings&#39;).
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    public TerraformValue<string>? TargetPage
    {
        get => new TerraformReference<string>(this, "target_page");
        set => SetArgument("target_page", value);
    }

    /// <summary>
    /// DataStoreConnections block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockDataStoreConnectionsBlock>? DataStoreConnections
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockDataStoreConnectionsBlock>>("data_store_connections");
        set => SetArgument("data_store_connections", value);
    }

    /// <summary>
    /// TriggerFulfillment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerFulfillment block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock>? TriggerFulfillment
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock>>("trigger_fulfillment");
        set => SetArgument("trigger_fulfillment", value);
    }

}

/// <summary>
/// Block type for data_store_connections in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockDataStoreConnectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_store_connections";

    /// <summary>
    /// The full name of the referenced data store. Formats: projects/{project}/locations/{location}/collections/{collection}/dataStores/{dataStore} projects/{project}/locations/{location}/dataStores/{dataStore}
    /// </summary>
    public TerraformValue<string>? DataStore
    {
        get => new TerraformReference<string>(this, "data_store");
        set => SetArgument("data_store", value);
    }

    /// <summary>
    /// The type of the connected data store.
    /// * PUBLIC_WEB: A data store that contains public web content.
    /// * UNSTRUCTURED: A data store that contains unstructured private data.
    /// * STRUCTURED: A data store that contains structured data (for example FAQ). Possible values: [&amp;quot;PUBLIC_WEB&amp;quot;, &amp;quot;UNSTRUCTURED&amp;quot;, &amp;quot;STRUCTURED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DataStoreType
    {
        get => new TerraformReference<string>(this, "data_store_type");
        set => SetArgument("data_store_type", value);
    }

    /// <summary>
    /// The document processing mode for the data store connection. Should only be set for PUBLIC_WEB and UNSTRUCTURED data stores. If not set it is considered as DOCUMENTS, as this is the legacy mode.
    /// * DOCUMENTS: Documents are processed as documents.
    /// * CHUNKS: Documents are converted to chunks. Possible values: [&amp;quot;DOCUMENTS&amp;quot;, &amp;quot;CHUNKS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DocumentProcessingMode
    {
        get => new TerraformReference<string>(this, "document_processing_mode");
        set => SetArgument("document_processing_mode", value);
    }

}

/// <summary>
/// Block type for trigger_fulfillment in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger_fulfillment";

    /// <summary>
    /// If the flag is true, the agent will utilize LLM to generate a text response. If LLM generation fails, the defined responses in the fulfillment will be respected. This flag is only useful for fulfillments associated with no-match event handlers.
    /// </summary>
    public TerraformValue<bool>? EnableGenerativeFallback
    {
        get => new TerraformReference<bool>(this, "enable_generative_fallback");
        set => SetArgument("enable_generative_fallback", value);
    }

    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    public TerraformValue<bool>? ReturnPartialResponses
    {
        get => new TerraformReference<bool>(this, "return_partial_responses");
        set => SetArgument("return_partial_responses", value);
    }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Webhook
    {
        get => new TerraformReference<string>(this, "webhook");
        set => SetArgument("webhook", value);
    }

    /// <summary>
    /// AdvancedSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock>? AdvancedSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock>>("advanced_settings");
        set => SetArgument("advanced_settings", value);
    }

    /// <summary>
    /// ConditionalCases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockConditionalCasesBlock>? ConditionalCases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockConditionalCasesBlock>>("conditional_cases");
        set => SetArgument("conditional_cases", value);
    }

    /// <summary>
    /// Messages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock>? Messages
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock>>("messages");
        set => SetArgument("messages", value);
    }

    /// <summary>
    /// SetParameterActions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockSetParameterActionsBlock>? SetParameterActions
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockSetParameterActionsBlock>>("set_parameter_actions");
        set => SetArgument("set_parameter_actions", value);
    }

}

/// <summary>
/// Block type for advanced_settings in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_settings";

    /// <summary>
    /// DtmfSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DtmfSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockDtmfSettingsBlock>? DtmfSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockDtmfSettingsBlock>>("dtmf_settings");
        set => SetArgument("dtmf_settings", value);
    }

    /// <summary>
    /// LoggingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockLoggingSettingsBlock>? LoggingSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockLoggingSettingsBlock>>("logging_settings");
        set => SetArgument("logging_settings", value);
    }

    /// <summary>
    /// SpeechSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpeechSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockSpeechSettingsBlock>? SpeechSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockSpeechSettingsBlock>>("speech_settings");
        set => SetArgument("speech_settings", value);
    }

}

/// <summary>
/// Block type for dtmf_settings in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockDtmfSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dtmf_settings";

    /// <summary>
    /// If true, incoming audio is processed for DTMF (dual tone multi frequtectency) events. For example, if the caller presses a button on their telephone keypad and DTMF processing is enabled, Dialogflow will de the event (e.g. a &amp;quot;3&amp;quot; was pressed) in the incoming audio and pass the event to the bot to drive business logic (e.g. when 3 is pressed, return the account balance).
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Endpoint timeout setting for matching dtmf input to regex.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.500s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? EndpointingTimeoutDuration
    {
        get => new TerraformReference<string>(this, "endpointing_timeout_duration");
        set => SetArgument("endpointing_timeout_duration", value);
    }

    /// <summary>
    /// The digit that terminates a DTMF digit sequence.
    /// </summary>
    public TerraformValue<string>? FinishDigit
    {
        get => new TerraformReference<string>(this, "finish_digit");
        set => SetArgument("finish_digit", value);
    }

    /// <summary>
    /// Interdigit timeout setting for matching dtmf input to regex.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.500s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? InterdigitTimeoutDuration
    {
        get => new TerraformReference<string>(this, "interdigit_timeout_duration");
        set => SetArgument("interdigit_timeout_duration", value);
    }

    /// <summary>
    /// Max length of DTMF digits.
    /// </summary>
    public TerraformValue<double>? MaxDigits
    {
        get => new TerraformReference<double>(this, "max_digits");
        set => SetArgument("max_digits", value);
    }

}

/// <summary>
/// Block type for logging_settings in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockLoggingSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_settings";

    /// <summary>
    /// Enables consent-based end-user input redaction, if true, a pre-defined session parameter **$session.params.conversation-redaction** will be used to determine if the utterance should be redacted.
    /// </summary>
    public TerraformValue<bool>? EnableConsentBasedRedaction
    {
        get => new TerraformReference<bool>(this, "enable_consent_based_redaction");
        set => SetArgument("enable_consent_based_redaction", value);
    }

    /// <summary>
    /// Enables DF Interaction logging.
    /// </summary>
    public TerraformValue<bool>? EnableInteractionLogging
    {
        get => new TerraformReference<bool>(this, "enable_interaction_logging");
        set => SetArgument("enable_interaction_logging", value);
    }

    /// <summary>
    /// Enables Google Cloud Logging.
    /// </summary>
    public TerraformValue<bool>? EnableStackdriverLogging
    {
        get => new TerraformReference<bool>(this, "enable_stackdriver_logging");
        set => SetArgument("enable_stackdriver_logging", value);
    }

}

/// <summary>
/// Block type for speech_settings in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockSpeechSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "speech_settings";

    /// <summary>
    /// Sensitivity of the speech model that detects the end of speech. Scale from 0 to 100.
    /// </summary>
    public TerraformValue<double>? EndpointerSensitivity
    {
        get => new TerraformReference<double>(this, "endpointer_sensitivity");
        set => SetArgument("endpointer_sensitivity", value);
    }

    /// <summary>
    /// Mapping from language to Speech-to-Text model. The mapped Speech-to-Text model will be selected for requests from its corresponding language. For more information, see [Speech models](https://cloud.google.com/dialogflow/cx/docs/concept/speech-models).
    /// An object containing a list of **&amp;quot;key&amp;quot;: value** pairs. Example: **{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }**.
    /// </summary>
    public TerraformMap<string>? Models
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "models").ResolveNodes(ctx));
        set => SetArgument("models", value);
    }

    /// <summary>
    /// Timeout before detecting no speech.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.500s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? NoSpeechTimeout
    {
        get => new TerraformReference<string>(this, "no_speech_timeout");
        set => SetArgument("no_speech_timeout", value);
    }

    /// <summary>
    /// Use timeout based endpointing, interpreting endpointer sensitivity as seconds of timeout value.
    /// </summary>
    public TerraformValue<bool>? UseTimeoutBasedEndpointing
    {
        get => new TerraformReference<bool>(this, "use_timeout_based_endpointing");
        set => SetArgument("use_timeout_based_endpointing", value);
    }

}

/// <summary>
/// Block type for conditional_cases in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockConditionalCasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditional_cases";

    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.
    /// </summary>
    public TerraformValue<string>? Cases
    {
        get => new TerraformReference<string>(this, "cases");
        set => SetArgument("cases", value);
    }

}

/// <summary>
/// Block type for messages in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "messages";

    /// <summary>
    /// The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.
    /// </summary>
    public TerraformValue<string>? Channel
    {
        get => new TerraformReference<string>(this, "channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// This type has no fields.
    /// Indicates that interaction with the Dialogflow agent has ended. This message is generated by Dialogflow only and not supposed to be defined by the user.
    /// This field is part of a union field &#39;message&#39;: Only one of &#39;text&#39;, &#39;payload&#39;, &#39;conversationSuccess&#39;, &#39;outputAudioText&#39;, &#39;liveAgentHandoff&#39;, &#39;endInteraction&#39;, &#39;playAudio&#39;, &#39;mixedAudio&#39;, &#39;telephonyTransferCall&#39;, or &#39;knowledgeInfoCard&#39; may be set.
    /// </summary>
    public TerraformList<TerraformMap<object>> EndInteraction
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "end_interaction").ResolveNodes(ctx));
    }

    /// <summary>
    /// Represents an audio message that is composed of both segments synthesized from the Dialogflow agent prompts and ones hosted externally at the specified URIs. The external URIs are specified via playAudio. This message is generated by Dialogflow only and not supposed to be defined by the user.
    /// This field is part of a union field &#39;message&#39;: Only one of &#39;text&#39;, &#39;payload&#39;, &#39;conversationSuccess&#39;, &#39;outputAudioText&#39;, &#39;liveAgentHandoff&#39;, &#39;endInteraction&#39;, &#39;playAudio&#39;, &#39;mixedAudio&#39;, &#39;telephonyTransferCall&#39;, or &#39;knowledgeInfoCard&#39; may be set.
    /// </summary>
    public TerraformList<TerraformMap<object>> MixedAudio
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "mixed_audio").ResolveNodes(ctx));
    }

    /// <summary>
    /// Returns a response containing a custom, platform-specific payload.
    /// This field is part of a union field &#39;message&#39;: Only one of &#39;text&#39;, &#39;payload&#39;, &#39;conversationSuccess&#39;, &#39;outputAudioText&#39;, &#39;liveAgentHandoff&#39;, &#39;endInteraction&#39;, &#39;playAudio&#39;, &#39;mixedAudio&#39;, &#39;telephonyTransferCall&#39;, or &#39;knowledgeInfoCard&#39; may be set.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => new TerraformReference<string>(this, "payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// ConversationSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationSuccess block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>? ConversationSuccess
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>>("conversation_success");
        set => SetArgument("conversation_success", value);
    }

    /// <summary>
    /// KnowledgeInfoCard block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeInfoCard block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockKnowledgeInfoCardBlock>? KnowledgeInfoCard
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockKnowledgeInfoCardBlock>>("knowledge_info_card");
        set => SetArgument("knowledge_info_card", value);
    }

    /// <summary>
    /// LiveAgentHandoff block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveAgentHandoff block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>? LiveAgentHandoff
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>>("live_agent_handoff");
        set => SetArgument("live_agent_handoff", value);
    }

    /// <summary>
    /// OutputAudioText block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputAudioText block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>? OutputAudioText
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>>("output_audio_text");
        set => SetArgument("output_audio_text", value);
    }

    /// <summary>
    /// PlayAudio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlayAudio block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>? PlayAudio
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>>("play_audio");
        set => SetArgument("play_audio", value);
    }

    /// <summary>
    /// TelephonyTransferCall block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelephonyTransferCall block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>? TelephonyTransferCall
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>>("telephony_transfer_call");
        set => SetArgument("telephony_transfer_call", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for conversation_success in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_success";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for knowledge_info_card in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockKnowledgeInfoCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "knowledge_info_card";

}

/// <summary>
/// Block type for live_agent_handoff in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "live_agent_handoff";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for output_audio_text in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_audio_text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// The SSML text to be synthesized. For more information, see SSML.
    /// This field is part of a union field &#39;source&#39;: Only one of &#39;text&#39; or &#39;ssml&#39; may be set.
    /// </summary>
    public TerraformValue<string>? Ssml
    {
        get => new TerraformReference<string>(this, "ssml");
        set => SetArgument("ssml", value);
    }

    /// <summary>
    /// The raw text to be synthesized.
    /// This field is part of a union field &#39;source&#39;: Only one of &#39;text&#39; or &#39;ssml&#39; may be set.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for play_audio in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "play_audio";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioUri is required")]
    public required TerraformValue<string> AudioUri
    {
        get => new TerraformReference<string>(this, "audio_uri");
        set => SetArgument("audio_uri", value);
    }

}

/// <summary>
/// Block type for telephony_transfer_call in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "telephony_transfer_call";

    /// <summary>
    /// Transfer the call to a phone number in E.164 format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for text in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// A collection of text response variants. If multiple variants are defined, only one text response variant is returned at runtime.
    /// required: true
    /// </summary>
    public TerraformList<string>? Text
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "text").ResolveNodes(ctx));
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for set_parameter_actions in GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockSetParameterActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "set_parameter_actions";

    /// <summary>
    /// Display name of the parameter.
    /// </summary>
    public TerraformValue<string>? Parameter
    {
        get => new TerraformReference<string>(this, "parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The new JSON-encoded value of the parameter. A null value clears the parameter.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxPage.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxPageTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for transition_routes in GoogleDialogflowCxPage.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transition_routes";

    /// <summary>
    /// The condition to evaluate against form parameters or session parameters.
    /// At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    public TerraformValue<string>? Condition
    {
        get => new TerraformReference<string>(this, "condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// The unique identifier of an Intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/intents/&amp;lt;Intent ID&amp;gt;. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    public TerraformValue<string>? Intent
    {
        get => new TerraformReference<string>(this, "intent");
        set => SetArgument("intent", value);
    }

    /// <summary>
    /// The unique identifier of this transition route.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? TargetFlow
    {
        get => new TerraformReference<string>(this, "target_flow");
        set => SetArgument("target_flow", value);
    }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? TargetPage
    {
        get => new TerraformReference<string>(this, "target_page");
        set => SetArgument("target_page", value);
    }

    /// <summary>
    /// TriggerFulfillment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerFulfillment block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlock>? TriggerFulfillment
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlock>>("trigger_fulfillment");
        set => SetArgument("trigger_fulfillment", value);
    }

}

/// <summary>
/// Block type for trigger_fulfillment in GoogleDialogflowCxPageTransitionRoutesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger_fulfillment";

    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    public TerraformValue<bool>? ReturnPartialResponses
    {
        get => new TerraformReference<bool>(this, "return_partial_responses");
        set => SetArgument("return_partial_responses", value);
    }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Webhook
    {
        get => new TerraformReference<string>(this, "webhook");
        set => SetArgument("webhook", value);
    }

    /// <summary>
    /// ConditionalCases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockConditionalCasesBlock>? ConditionalCases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockConditionalCasesBlock>>("conditional_cases");
        set => SetArgument("conditional_cases", value);
    }

    /// <summary>
    /// Messages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock>? Messages
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock>>("messages");
        set => SetArgument("messages", value);
    }

    /// <summary>
    /// SetParameterActions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockSetParameterActionsBlock>? SetParameterActions
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockSetParameterActionsBlock>>("set_parameter_actions");
        set => SetArgument("set_parameter_actions", value);
    }

}

/// <summary>
/// Block type for conditional_cases in GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockConditionalCasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditional_cases";

    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.
    /// </summary>
    public TerraformValue<string>? Cases
    {
        get => new TerraformReference<string>(this, "cases");
        set => SetArgument("cases", value);
    }

}

/// <summary>
/// Block type for messages in GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "messages";

    /// <summary>
    /// The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.
    /// </summary>
    public TerraformValue<string>? Channel
    {
        get => new TerraformReference<string>(this, "channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// A custom, platform-specific payload.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => new TerraformReference<string>(this, "payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// ConversationSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationSuccess block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>? ConversationSuccess
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>>("conversation_success");
        set => SetArgument("conversation_success", value);
    }

    /// <summary>
    /// LiveAgentHandoff block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveAgentHandoff block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>? LiveAgentHandoff
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>>("live_agent_handoff");
        set => SetArgument("live_agent_handoff", value);
    }

    /// <summary>
    /// OutputAudioText block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputAudioText block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>? OutputAudioText
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>>("output_audio_text");
        set => SetArgument("output_audio_text", value);
    }

    /// <summary>
    /// PlayAudio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlayAudio block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>? PlayAudio
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>>("play_audio");
        set => SetArgument("play_audio", value);
    }

    /// <summary>
    /// TelephonyTransferCall block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelephonyTransferCall block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>? TelephonyTransferCall
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>>("telephony_transfer_call");
        set => SetArgument("telephony_transfer_call", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for conversation_success in GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_success";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for live_agent_handoff in GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "live_agent_handoff";

    /// <summary>
    /// Custom metadata. Dialogflow doesn&#39;t impose any structure on this.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for output_audio_text in GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_audio_text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// The SSML text to be synthesized. For more information, see SSML.
    /// </summary>
    public TerraformValue<string>? Ssml
    {
        get => new TerraformReference<string>(this, "ssml");
        set => SetArgument("ssml", value);
    }

    /// <summary>
    /// The raw text to be synthesized.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for play_audio in GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "play_audio";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioUri is required")]
    public required TerraformValue<string> AudioUri
    {
        get => new TerraformReference<string>(this, "audio_uri");
        set => SetArgument("audio_uri", value);
    }

}

/// <summary>
/// Block type for telephony_transfer_call in GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "telephony_transfer_call";

    /// <summary>
    /// Transfer the call to a phone number in E.164 format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for text in GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
    {
        get => new TerraformReference<bool>(this, "allow_playback_interruption");
    }

    /// <summary>
    /// A collection of text responses.
    /// </summary>
    public TerraformList<string>? Text
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "text").ResolveNodes(ctx));
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for set_parameter_actions in GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPageTransitionRoutesBlockTriggerFulfillmentBlockSetParameterActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "set_parameter_actions";

    /// <summary>
    /// Display name of the parameter.
    /// </summary>
    public TerraformValue<string>? Parameter
    {
        get => new TerraformReference<string>(this, "parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The new JSON-encoded value of the parameter. A null value clears the parameter.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a google_dialogflow_cx_page Terraform resource.
/// Manages a google_dialogflow_cx_page resource.
/// </summary>
public partial class GoogleDialogflowCxPage(string name) : TerraformResource("google_dialogflow_cx_page", name)
{
    /// <summary>
    /// The human-readable name of the page, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The language of the following fields in page:
    /// 
    /// Page.entry_fulfillment.messages
    /// Page.entry_fulfillment.conditional_cases
    /// Page.event_handlers.trigger_fulfillment.messages
    /// Page.event_handlers.trigger_fulfillment.conditional_cases
    /// Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages
    /// Page.form.parameters.fill_behavior.initial_prompt_fulfillment.conditional_cases
    /// Page.form.parameters.fill_behavior.reprompt_event_handlers.messages
    /// Page.form.parameters.fill_behavior.reprompt_event_handlers.conditional_cases
    /// Page.transition_routes.trigger_fulfillment.messages
    /// Page.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    public TerraformValue<string>? LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The flow to create a page for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Ordered list of TransitionRouteGroups associated with the page. Transition route groups must be unique within a page.
    /// If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page&#39;s transition route -&amp;gt; page&#39;s transition route group -&amp;gt; flow&#39;s transition routes.
    /// If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence.
    /// Format:projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/transitionRouteGroups/&amp;lt;TransitionRouteGroup ID&amp;gt;.
    /// </summary>
    public TerraformList<string>? TransitionRouteGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transition_route_groups").ResolveNodes(ctx));
        set => SetArgument("transition_route_groups", value);
    }

    /// <summary>
    /// The unique identifier of the page.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// AdvancedSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageAdvancedSettingsBlock>? AdvancedSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageAdvancedSettingsBlock>>("advanced_settings");
        set => SetArgument("advanced_settings", value);
    }

    /// <summary>
    /// EntryFulfillment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntryFulfillment block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlock>? EntryFulfillment
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEntryFulfillmentBlock>>("entry_fulfillment");
        set => SetArgument("entry_fulfillment", value);
    }

    /// <summary>
    /// EventHandlers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageEventHandlersBlock>? EventHandlers
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageEventHandlersBlock>>("event_handlers");
        set => SetArgument("event_handlers", value);
    }

    /// <summary>
    /// Form block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Form block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageFormBlock>? Form
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageFormBlock>>("form");
        set => SetArgument("form", value);
    }

    /// <summary>
    /// KnowledgeConnectorSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock>? KnowledgeConnectorSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageKnowledgeConnectorSettingsBlock>>("knowledge_connector_settings");
        set => SetArgument("knowledge_connector_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxPageTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxPageTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TransitionRoutes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPageTransitionRoutesBlock>? TransitionRoutes
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPageTransitionRoutesBlock>>("transition_routes");
        set => SetArgument("transition_routes", value);
    }

}
