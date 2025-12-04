using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_settings in GoogleDialogflowCxFlow.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowAdvancedSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_settings";

    /// <summary>
    /// AudioExportGcsDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioExportGcsDestination block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowAdvancedSettingsBlockAudioExportGcsDestinationBlock>? AudioExportGcsDestination
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowAdvancedSettingsBlockAudioExportGcsDestinationBlock>>("audio_export_gcs_destination");
        set => SetArgument("audio_export_gcs_destination", value);
    }

    /// <summary>
    /// DtmfSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DtmfSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowAdvancedSettingsBlockDtmfSettingsBlock>? DtmfSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowAdvancedSettingsBlockDtmfSettingsBlock>>("dtmf_settings");
        set => SetArgument("dtmf_settings", value);
    }

    /// <summary>
    /// LoggingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowAdvancedSettingsBlockLoggingSettingsBlock>? LoggingSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowAdvancedSettingsBlockLoggingSettingsBlock>>("logging_settings");
        set => SetArgument("logging_settings", value);
    }

    /// <summary>
    /// SpeechSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpeechSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowAdvancedSettingsBlockSpeechSettingsBlock>? SpeechSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowAdvancedSettingsBlockSpeechSettingsBlock>>("speech_settings");
        set => SetArgument("speech_settings", value);
    }

}

/// <summary>
/// Block type for audio_export_gcs_destination in GoogleDialogflowCxFlowAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowAdvancedSettingsBlockAudioExportGcsDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_export_gcs_destination";

    /// <summary>
    /// The Google Cloud Storage URI for the exported objects. Whether a full object name, or just a prefix, its usage depends on the Dialogflow operation.
    /// Format: gs://bucket/object-name-or-prefix
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for dtmf_settings in GoogleDialogflowCxFlowAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowAdvancedSettingsBlockDtmfSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The digit that terminates a DTMF digit sequence.
    /// </summary>
    public TerraformValue<string>? FinishDigit
    {
        get => GetArgument<TerraformValue<string>>("finish_digit");
        set => SetArgument("finish_digit", value);
    }

    /// <summary>
    /// Max length of DTMF digits.
    /// </summary>
    public TerraformValue<double>? MaxDigits
    {
        get => GetArgument<TerraformValue<double>>("max_digits");
        set => SetArgument("max_digits", value);
    }

}

/// <summary>
/// Block type for logging_settings in GoogleDialogflowCxFlowAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowAdvancedSettingsBlockLoggingSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("enable_consent_based_redaction");
        set => SetArgument("enable_consent_based_redaction", value);
    }

    /// <summary>
    /// Enables DF Interaction logging.
    /// </summary>
    public TerraformValue<bool>? EnableInteractionLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_interaction_logging");
        set => SetArgument("enable_interaction_logging", value);
    }

    /// <summary>
    /// Enables Google Cloud Logging.
    /// </summary>
    public TerraformValue<bool>? EnableStackdriverLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_stackdriver_logging");
        set => SetArgument("enable_stackdriver_logging", value);
    }

}

/// <summary>
/// Block type for speech_settings in GoogleDialogflowCxFlowAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowAdvancedSettingsBlockSpeechSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("endpointer_sensitivity");
        set => SetArgument("endpointer_sensitivity", value);
    }

    /// <summary>
    /// Mapping from language to Speech-to-Text model. The mapped Speech-to-Text model will be selected for requests from its corresponding language. For more information, see [Speech models](https://cloud.google.com/dialogflow/cx/docs/concept/speech-models).
    /// An object containing a list of **&amp;quot;key&amp;quot;: value** pairs. Example: **{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }**.
    /// </summary>
    public TerraformMap<string>? Models
    {
        get => GetArgument<TerraformMap<string>>("models");
        set => SetArgument("models", value);
    }

    /// <summary>
    /// Timeout before detecting no speech.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? NoSpeechTimeout
    {
        get => GetArgument<TerraformValue<string>>("no_speech_timeout");
        set => SetArgument("no_speech_timeout", value);
    }

    /// <summary>
    /// Use timeout based endpointing, interpreting endpointer sensitivity as seconds of timeout value.
    /// </summary>
    public TerraformValue<bool>? UseTimeoutBasedEndpointing
    {
        get => GetArgument<TerraformValue<bool>>("use_timeout_based_endpointing");
        set => SetArgument("use_timeout_based_endpointing", value);
    }

}


/// <summary>
/// Block type for event_handlers in GoogleDialogflowCxFlow.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("event");
        set => SetArgument("event", value);
    }

    /// <summary>
    /// The unique identifier of this event handler.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? TargetFlow
    {
        get => GetArgument<TerraformValue<string>>("target_flow");
        set => SetArgument("target_flow", value);
    }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? TargetPage
    {
        get => GetArgument<TerraformValue<string>>("target_page");
        set => SetArgument("target_page", value);
    }

    /// <summary>
    /// TriggerFulfillment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerFulfillment block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlock>? TriggerFulfillment
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlock>>("trigger_fulfillment");
        set => SetArgument("trigger_fulfillment", value);
    }

}

/// <summary>
/// Block type for trigger_fulfillment in GoogleDialogflowCxFlowEventHandlersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger_fulfillment";

    /// <summary>
    /// If the flag is true, the agent will utilize LLM to generate a text response.
    /// If LLM generation fails, the defined responses in the fulfillment will be respected.
    /// This flag is only useful for fulfillments associated with no-match event handlers.
    /// </summary>
    public TerraformValue<bool>? EnableGenerativeFallback
    {
        get => GetArgument<TerraformValue<bool>>("enable_generative_fallback");
        set => SetArgument("enable_generative_fallback", value);
    }

    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    public TerraformValue<bool>? ReturnPartialResponses
    {
        get => GetArgument<TerraformValue<bool>>("return_partial_responses");
        set => SetArgument("return_partial_responses", value);
    }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Webhook
    {
        get => GetArgument<TerraformValue<string>>("webhook");
        set => SetArgument("webhook", value);
    }

    /// <summary>
    /// ConditionalCases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockConditionalCasesBlock>? ConditionalCases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockConditionalCasesBlock>>("conditional_cases");
        set => SetArgument("conditional_cases", value);
    }

    /// <summary>
    /// Messages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlock>? Messages
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlock>>("messages");
        set => SetArgument("messages", value);
    }

    /// <summary>
    /// SetParameterActions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockSetParameterActionsBlock>? SetParameterActions
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockSetParameterActionsBlock>>("set_parameter_actions");
        set => SetArgument("set_parameter_actions", value);
    }

}

/// <summary>
/// Block type for conditional_cases in GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockConditionalCasesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("cases");
        set => SetArgument("cases", value);
    }

}

/// <summary>
/// Block type for messages in GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// A custom, platform-specific payload.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => GetArgument<TerraformValue<string>>("payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// ConversationSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationSuccess block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>? ConversationSuccess
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>>("conversation_success");
        set => SetArgument("conversation_success", value);
    }

    /// <summary>
    /// LiveAgentHandoff block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveAgentHandoff block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>? LiveAgentHandoff
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>>("live_agent_handoff");
        set => SetArgument("live_agent_handoff", value);
    }

    /// <summary>
    /// OutputAudioText block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputAudioText block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>? OutputAudioText
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>>("output_audio_text");
        set => SetArgument("output_audio_text", value);
    }

    /// <summary>
    /// PlayAudio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlayAudio block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>? PlayAudio
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>>("play_audio");
        set => SetArgument("play_audio", value);
    }

    /// <summary>
    /// TelephonyTransferCall block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelephonyTransferCall block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>? TelephonyTransferCall
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>>("telephony_transfer_call");
        set => SetArgument("telephony_transfer_call", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for conversation_success in GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for live_agent_handoff in GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for output_audio_text in GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_audio_text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
        => AsReference("allow_playback_interruption");

    /// <summary>
    /// The SSML text to be synthesized. For more information, see SSML.
    /// </summary>
    public TerraformValue<string>? Ssml
    {
        get => GetArgument<TerraformValue<string>>("ssml");
        set => SetArgument("ssml", value);
    }

    /// <summary>
    /// The raw text to be synthesized.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for play_audio in GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "play_audio";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
        => AsReference("allow_playback_interruption");

    /// <summary>
    /// URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioUri is required")]
    public required TerraformValue<string> AudioUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("audio_uri");
        set => SetArgument("audio_uri", value);
    }

}

/// <summary>
/// Block type for telephony_transfer_call in GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for text in GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockMessagesBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
        => AsReference("allow_playback_interruption");

    /// <summary>
    /// A collection of text responses.
    /// </summary>
    public TerraformList<string>? Text
    {
        get => GetArgument<TerraformList<string>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for set_parameter_actions in GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowEventHandlersBlockTriggerFulfillmentBlockSetParameterActionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The new JSON-encoded value of the parameter. A null value clears the parameter.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for knowledge_connector_settings in GoogleDialogflowCxFlow.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The target flow to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;.
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    public TerraformValue<string>? TargetFlow
    {
        get => GetArgument<TerraformValue<string>>("target_flow");
        set => SetArgument("target_flow", value);
    }

    /// <summary>
    /// The target page to transition to. Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/flows/&amp;lt;FlowID&amp;gt;/pages/&amp;lt;PageID&amp;gt;.
    /// The page must be in the same host flow (the flow that owns this &#39;KnowledgeConnectorSettings&#39;).
    /// This field is part of a union field &#39;target&#39;: Only one of &#39;targetPage&#39; or &#39;targetFlow&#39; may be set.
    /// </summary>
    public TerraformValue<string>? TargetPage
    {
        get => GetArgument<TerraformValue<string>>("target_page");
        set => SetArgument("target_page", value);
    }

    /// <summary>
    /// DataStoreConnections block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockDataStoreConnectionsBlock>? DataStoreConnections
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockDataStoreConnectionsBlock>>("data_store_connections");
        set => SetArgument("data_store_connections", value);
    }

    /// <summary>
    /// TriggerFulfillment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerFulfillment block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock>? TriggerFulfillment
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock>>("trigger_fulfillment");
        set => SetArgument("trigger_fulfillment", value);
    }

}

/// <summary>
/// Block type for data_store_connections in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockDataStoreConnectionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("data_store");
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
        get => GetArgument<TerraformValue<string>>("data_store_type");
        set => SetArgument("data_store_type", value);
    }

    /// <summary>
    /// The document processing mode for the data store connection. Should only be set for PUBLIC_WEB and UNSTRUCTURED data stores. If not set it is considered as DOCUMENTS, as this is the legacy mode.
    /// * DOCUMENTS: Documents are processed as documents.
    /// * CHUNKS: Documents are converted to chunks. Possible values: [&amp;quot;DOCUMENTS&amp;quot;, &amp;quot;CHUNKS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DocumentProcessingMode
    {
        get => GetArgument<TerraformValue<string>>("document_processing_mode");
        set => SetArgument("document_processing_mode", value);
    }

}

/// <summary>
/// Block type for trigger_fulfillment in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("enable_generative_fallback");
        set => SetArgument("enable_generative_fallback", value);
    }

    /// <summary>
    /// Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.
    /// </summary>
    public TerraformValue<bool>? ReturnPartialResponses
    {
        get => GetArgument<TerraformValue<bool>>("return_partial_responses");
        set => SetArgument("return_partial_responses", value);
    }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Webhook
    {
        get => GetArgument<TerraformValue<string>>("webhook");
        set => SetArgument("webhook", value);
    }

    /// <summary>
    /// AdvancedSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock>? AdvancedSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock>>("advanced_settings");
        set => SetArgument("advanced_settings", value);
    }

    /// <summary>
    /// ConditionalCases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockConditionalCasesBlock>? ConditionalCases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockConditionalCasesBlock>>("conditional_cases");
        set => SetArgument("conditional_cases", value);
    }

    /// <summary>
    /// Messages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock>? Messages
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock>>("messages");
        set => SetArgument("messages", value);
    }

    /// <summary>
    /// SetParameterActions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockSetParameterActionsBlock>? SetParameterActions
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockSetParameterActionsBlock>>("set_parameter_actions");
        set => SetArgument("set_parameter_actions", value);
    }

}

/// <summary>
/// Block type for advanced_settings in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_settings";

    /// <summary>
    /// DtmfSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DtmfSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockDtmfSettingsBlock>? DtmfSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockDtmfSettingsBlock>>("dtmf_settings");
        set => SetArgument("dtmf_settings", value);
    }

    /// <summary>
    /// LoggingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockLoggingSettingsBlock>? LoggingSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockLoggingSettingsBlock>>("logging_settings");
        set => SetArgument("logging_settings", value);
    }

    /// <summary>
    /// SpeechSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpeechSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockSpeechSettingsBlock>? SpeechSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockSpeechSettingsBlock>>("speech_settings");
        set => SetArgument("speech_settings", value);
    }

}

/// <summary>
/// Block type for dtmf_settings in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockDtmfSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Endpoint timeout setting for matching dtmf input to regex.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.500s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? EndpointingTimeoutDuration
    {
        get => GetArgument<TerraformValue<string>>("endpointing_timeout_duration");
        set => SetArgument("endpointing_timeout_duration", value);
    }

    /// <summary>
    /// The digit that terminates a DTMF digit sequence.
    /// </summary>
    public TerraformValue<string>? FinishDigit
    {
        get => GetArgument<TerraformValue<string>>("finish_digit");
        set => SetArgument("finish_digit", value);
    }

    /// <summary>
    /// Interdigit timeout setting for matching dtmf input to regex.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.500s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? InterdigitTimeoutDuration
    {
        get => GetArgument<TerraformValue<string>>("interdigit_timeout_duration");
        set => SetArgument("interdigit_timeout_duration", value);
    }

    /// <summary>
    /// Max length of DTMF digits.
    /// </summary>
    public TerraformValue<double>? MaxDigits
    {
        get => GetArgument<TerraformValue<double>>("max_digits");
        set => SetArgument("max_digits", value);
    }

}

/// <summary>
/// Block type for logging_settings in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockLoggingSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("enable_consent_based_redaction");
        set => SetArgument("enable_consent_based_redaction", value);
    }

    /// <summary>
    /// Enables DF Interaction logging.
    /// </summary>
    public TerraformValue<bool>? EnableInteractionLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_interaction_logging");
        set => SetArgument("enable_interaction_logging", value);
    }

    /// <summary>
    /// Enables Google Cloud Logging.
    /// </summary>
    public TerraformValue<bool>? EnableStackdriverLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_stackdriver_logging");
        set => SetArgument("enable_stackdriver_logging", value);
    }

}

/// <summary>
/// Block type for speech_settings in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockAdvancedSettingsBlockSpeechSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("endpointer_sensitivity");
        set => SetArgument("endpointer_sensitivity", value);
    }

    /// <summary>
    /// Mapping from language to Speech-to-Text model. The mapped Speech-to-Text model will be selected for requests from its corresponding language. For more information, see [Speech models](https://cloud.google.com/dialogflow/cx/docs/concept/speech-models).
    /// An object containing a list of **&amp;quot;key&amp;quot;: value** pairs. Example: **{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }**.
    /// </summary>
    public TerraformMap<string>? Models
    {
        get => GetArgument<TerraformMap<string>>("models");
        set => SetArgument("models", value);
    }

    /// <summary>
    /// Timeout before detecting no speech.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.500s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? NoSpeechTimeout
    {
        get => GetArgument<TerraformValue<string>>("no_speech_timeout");
        set => SetArgument("no_speech_timeout", value);
    }

    /// <summary>
    /// Use timeout based endpointing, interpreting endpointer sensitivity as seconds of timeout value.
    /// </summary>
    public TerraformValue<bool>? UseTimeoutBasedEndpointing
    {
        get => GetArgument<TerraformValue<bool>>("use_timeout_based_endpointing");
        set => SetArgument("use_timeout_based_endpointing", value);
    }

}

/// <summary>
/// Block type for conditional_cases in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockConditionalCasesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("cases");
        set => SetArgument("cases", value);
    }

}

/// <summary>
/// Block type for messages in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// This type has no fields.
    /// Indicates that interaction with the Dialogflow agent has ended. This message is generated by Dialogflow only and not supposed to be defined by the user.
    /// This field is part of a union field &#39;message&#39;: Only one of &#39;text&#39;, &#39;payload&#39;, &#39;conversationSuccess&#39;, &#39;outputAudioText&#39;, &#39;liveAgentHandoff&#39;, &#39;endInteraction&#39;, &#39;playAudio&#39;, &#39;mixedAudio&#39;, &#39;telephonyTransferCall&#39;, or &#39;knowledgeInfoCard&#39; may be set.
    /// </summary>
    public TerraformList<TerraformMap<object>> EndInteraction
        => AsReference("end_interaction");

    /// <summary>
    /// Represents an audio message that is composed of both segments synthesized from the Dialogflow agent prompts and ones hosted externally at the specified URIs. The external URIs are specified via playAudio. This message is generated by Dialogflow only and not supposed to be defined by the user.
    /// This field is part of a union field &#39;message&#39;: Only one of &#39;text&#39;, &#39;payload&#39;, &#39;conversationSuccess&#39;, &#39;outputAudioText&#39;, &#39;liveAgentHandoff&#39;, &#39;endInteraction&#39;, &#39;playAudio&#39;, &#39;mixedAudio&#39;, &#39;telephonyTransferCall&#39;, or &#39;knowledgeInfoCard&#39; may be set.
    /// </summary>
    public TerraformList<TerraformMap<object>> MixedAudio
        => AsReference("mixed_audio");

    /// <summary>
    /// Returns a response containing a custom, platform-specific payload.
    /// This field is part of a union field &#39;message&#39;: Only one of &#39;text&#39;, &#39;payload&#39;, &#39;conversationSuccess&#39;, &#39;outputAudioText&#39;, &#39;liveAgentHandoff&#39;, &#39;endInteraction&#39;, &#39;playAudio&#39;, &#39;mixedAudio&#39;, &#39;telephonyTransferCall&#39;, or &#39;knowledgeInfoCard&#39; may be set.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => GetArgument<TerraformValue<string>>("payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// ConversationSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationSuccess block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>? ConversationSuccess
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>>("conversation_success");
        set => SetArgument("conversation_success", value);
    }

    /// <summary>
    /// KnowledgeInfoCard block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeInfoCard block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockKnowledgeInfoCardBlock>? KnowledgeInfoCard
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockKnowledgeInfoCardBlock>>("knowledge_info_card");
        set => SetArgument("knowledge_info_card", value);
    }

    /// <summary>
    /// LiveAgentHandoff block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveAgentHandoff block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>? LiveAgentHandoff
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>>("live_agent_handoff");
        set => SetArgument("live_agent_handoff", value);
    }

    /// <summary>
    /// OutputAudioText block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputAudioText block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>? OutputAudioText
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>>("output_audio_text");
        set => SetArgument("output_audio_text", value);
    }

    /// <summary>
    /// PlayAudio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlayAudio block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>? PlayAudio
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>>("play_audio");
        set => SetArgument("play_audio", value);
    }

    /// <summary>
    /// TelephonyTransferCall block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelephonyTransferCall block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>? TelephonyTransferCall
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>>("telephony_transfer_call");
        set => SetArgument("telephony_transfer_call", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for conversation_success in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for knowledge_info_card in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockKnowledgeInfoCardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "knowledge_info_card";

}

/// <summary>
/// Block type for live_agent_handoff in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for output_audio_text in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_audio_text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
        => AsReference("allow_playback_interruption");

    /// <summary>
    /// The SSML text to be synthesized. For more information, see SSML.
    /// This field is part of a union field &#39;source&#39;: Only one of &#39;text&#39; or &#39;ssml&#39; may be set.
    /// </summary>
    public TerraformValue<string>? Ssml
    {
        get => GetArgument<TerraformValue<string>>("ssml");
        set => SetArgument("ssml", value);
    }

    /// <summary>
    /// The raw text to be synthesized.
    /// This field is part of a union field &#39;source&#39;: Only one of &#39;text&#39; or &#39;ssml&#39; may be set.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for play_audio in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "play_audio";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
        => AsReference("allow_playback_interruption");

    /// <summary>
    /// URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioUri is required")]
    public required TerraformValue<string> AudioUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("audio_uri");
        set => SetArgument("audio_uri", value);
    }

}

/// <summary>
/// Block type for telephony_transfer_call in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for text in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockMessagesBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
        => AsReference("allow_playback_interruption");

    /// <summary>
    /// A collection of text response variants. If multiple variants are defined, only one text response variant is returned at runtime.
    /// required: true
    /// </summary>
    public TerraformList<string>? Text
    {
        get => GetArgument<TerraformList<string>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for set_parameter_actions in GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlockTriggerFulfillmentBlockSetParameterActionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The new JSON-encoded value of the parameter. A null value clears the parameter.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for nlu_settings in GoogleDialogflowCxFlow.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowNluSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nlu_settings";

    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent, you can tune the machine learning classification threshold.
    /// If the returned score value is less than the threshold value, then a no-match event will be triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.
    /// </summary>
    public TerraformValue<double>? ClassificationThreshold
    {
        get => GetArgument<TerraformValue<double>>("classification_threshold");
        set => SetArgument("classification_threshold", value);
    }

    /// <summary>
    /// Indicates NLU model training mode.
    /// * MODEL_TRAINING_MODE_AUTOMATIC: NLU model training is automatically triggered when a flow gets modified. User can also manually trigger model training in this mode.
    /// * MODEL_TRAINING_MODE_MANUAL: User needs to manually trigger NLU model training. Best for large flows whose models take long time to train. Possible values: [&amp;quot;MODEL_TRAINING_MODE_AUTOMATIC&amp;quot;, &amp;quot;MODEL_TRAINING_MODE_MANUAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ModelTrainingMode
    {
        get => GetArgument<TerraformValue<string>>("model_training_mode");
        set => SetArgument("model_training_mode", value);
    }

    /// <summary>
    /// Indicates the type of NLU model.
    /// * MODEL_TYPE_STANDARD: Use standard NLU model.
    /// * MODEL_TYPE_ADVANCED: Use advanced NLU model. Possible values: [&amp;quot;MODEL_TYPE_STANDARD&amp;quot;, &amp;quot;MODEL_TYPE_ADVANCED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ModelType
    {
        get => GetArgument<TerraformValue<string>>("model_type");
        set => SetArgument("model_type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxFlow.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxFlowTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for transition_routes in GoogleDialogflowCxFlow.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// The unique identifier of an Intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/intents/&amp;lt;Intent ID&amp;gt;. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    public TerraformValue<string>? Intent
    {
        get => GetArgument<TerraformValue<string>>("intent");
        set => SetArgument("intent", value);
    }

    /// <summary>
    /// The unique identifier of this transition route.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? TargetFlow
    {
        get => GetArgument<TerraformValue<string>>("target_flow");
        set => SetArgument("target_flow", value);
    }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? TargetPage
    {
        get => GetArgument<TerraformValue<string>>("target_page");
        set => SetArgument("target_page", value);
    }

    /// <summary>
    /// TriggerFulfillment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerFulfillment block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlock>? TriggerFulfillment
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlock>>("trigger_fulfillment");
        set => SetArgument("trigger_fulfillment", value);
    }

}

/// <summary>
/// Block type for trigger_fulfillment in GoogleDialogflowCxFlowTransitionRoutesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("return_partial_responses");
        set => SetArgument("return_partial_responses", value);
    }

    /// <summary>
    /// The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The webhook to call. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/webhooks/&amp;lt;Webhook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Webhook
    {
        get => GetArgument<TerraformValue<string>>("webhook");
        set => SetArgument("webhook", value);
    }

    /// <summary>
    /// ConditionalCases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockConditionalCasesBlock>? ConditionalCases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockConditionalCasesBlock>>("conditional_cases");
        set => SetArgument("conditional_cases", value);
    }

    /// <summary>
    /// Messages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock>? Messages
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock>>("messages");
        set => SetArgument("messages", value);
    }

    /// <summary>
    /// SetParameterActions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockSetParameterActionsBlock>? SetParameterActions
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockSetParameterActionsBlock>>("set_parameter_actions");
        set => SetArgument("set_parameter_actions", value);
    }

}

/// <summary>
/// Block type for conditional_cases in GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockConditionalCasesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("cases");
        set => SetArgument("cases", value);
    }

}

/// <summary>
/// Block type for messages in GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// A custom, platform-specific payload.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => GetArgument<TerraformValue<string>>("payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// ConversationSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationSuccess block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>? ConversationSuccess
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock>>("conversation_success");
        set => SetArgument("conversation_success", value);
    }

    /// <summary>
    /// LiveAgentHandoff block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveAgentHandoff block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>? LiveAgentHandoff
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock>>("live_agent_handoff");
        set => SetArgument("live_agent_handoff", value);
    }

    /// <summary>
    /// OutputAudioText block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputAudioText block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>? OutputAudioText
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock>>("output_audio_text");
        set => SetArgument("output_audio_text", value);
    }

    /// <summary>
    /// PlayAudio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlayAudio block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>? PlayAudio
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock>>("play_audio");
        set => SetArgument("play_audio", value);
    }

    /// <summary>
    /// TelephonyTransferCall block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelephonyTransferCall block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>? TelephonyTransferCall
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock>>("telephony_transfer_call");
        set => SetArgument("telephony_transfer_call", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for conversation_success in GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockConversationSuccessBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for live_agent_handoff in GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockLiveAgentHandoffBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for output_audio_text in GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockOutputAudioTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_audio_text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
        => AsReference("allow_playback_interruption");

    /// <summary>
    /// The SSML text to be synthesized. For more information, see SSML.
    /// </summary>
    public TerraformValue<string>? Ssml
    {
        get => GetArgument<TerraformValue<string>>("ssml");
        set => SetArgument("ssml", value);
    }

    /// <summary>
    /// The raw text to be synthesized.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for play_audio in GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockPlayAudioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "play_audio";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
        => AsReference("allow_playback_interruption");

    /// <summary>
    /// URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioUri is required")]
    public required TerraformValue<string> AudioUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("audio_uri");
        set => SetArgument("audio_uri", value);
    }

}

/// <summary>
/// Block type for telephony_transfer_call in GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTelephonyTransferCallBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for text in GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockMessagesBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// Whether the playback of this message can be interrupted by the end user&#39;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    public TerraformValue<bool> AllowPlaybackInterruption
        => AsReference("allow_playback_interruption");

    /// <summary>
    /// A collection of text responses.
    /// </summary>
    public TerraformList<string>? Text
    {
        get => GetArgument<TerraformList<string>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for set_parameter_actions in GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxFlowTransitionRoutesBlockTriggerFulfillmentBlockSetParameterActionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The new JSON-encoded value of the parameter. A null value clears the parameter.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a google_dialogflow_cx_flow Terraform resource.
/// Manages a google_dialogflow_cx_flow resource.
/// </summary>
public partial class GoogleDialogflowCxFlow(string name) : TerraformResource("google_dialogflow_cx_flow", name)
{
    /// <summary>
    /// The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The human-readable name of the flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Marks this as the [Default Start Flow](https://cloud.google.com/dialogflow/cx/docs/concept/flow#start) for an agent. When you create an agent, the Default Start Flow is created automatically.
    /// The Default Start Flow cannot be deleted; deleting the &#39;google_dialogflow_cx_flow&#39; resource does nothing to the underlying GCP resources.
    /// 
    /// ~&amp;gt; Avoid having multiple &#39;google_dialogflow_cx_flow&#39; resources linked to the same agent with &#39;is_default_start_flow = true&#39; because they will compete to control a single Default Start Flow resource in GCP.
    /// </summary>
    public TerraformValue<bool>? IsDefaultStartFlow
    {
        get => GetArgument<TerraformValue<bool>>("is_default_start_flow");
        set => SetArgument("is_default_start_flow", value);
    }

    /// <summary>
    /// The language of the following fields in flow:
    /// Flow.event_handlers.trigger_fulfillment.messages
    /// Flow.event_handlers.trigger_fulfillment.conditional_cases
    /// Flow.transition_routes.trigger_fulfillment.messages
    /// Flow.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&#39;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    public TerraformValue<string>? LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// A flow&#39;s transition route group serve two purposes:
    /// They are responsible for matching the user&#39;s first utterances in the flow.
    /// They are inherited by every page&#39;s [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow.
    /// Format:projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/transitionRouteGroups/&amp;lt;TransitionRouteGroup ID&amp;gt;.
    /// </summary>
    public TerraformList<string>? TransitionRouteGroups
    {
        get => GetArgument<TerraformList<string>>("transition_route_groups");
        set => SetArgument("transition_route_groups", value);
    }

    /// <summary>
    /// The unique identifier of the flow.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// AdvancedSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowAdvancedSettingsBlock>? AdvancedSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowAdvancedSettingsBlock>>("advanced_settings");
        set => SetArgument("advanced_settings", value);
    }

    /// <summary>
    /// EventHandlers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowEventHandlersBlock>? EventHandlers
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowEventHandlersBlock>>("event_handlers");
        set => SetArgument("event_handlers", value);
    }

    /// <summary>
    /// KnowledgeConnectorSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlock>? KnowledgeConnectorSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowKnowledgeConnectorSettingsBlock>>("knowledge_connector_settings");
        set => SetArgument("knowledge_connector_settings", value);
    }

    /// <summary>
    /// NluSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NluSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxFlowNluSettingsBlock>? NluSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowNluSettingsBlock>>("nlu_settings");
        set => SetArgument("nlu_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxFlowTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxFlowTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TransitionRoutes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlock>? TransitionRoutes
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxFlowTransitionRoutesBlock>>("transition_routes");
        set => SetArgument("transition_routes", value);
    }

}
