using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_agent_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowConversationProfileAutomatedAgentConfigBlock() : TerraformBlock("automated_agent_config")
{
    /// <summary>
    /// ID of the Dialogflow agent environment to use.
    /// Expects the format &amp;quot;projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent/environments/&amp;lt;EnvironmentID&amp;gt;&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Agent is required")]
    [TerraformProperty("agent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Agent { get; set; }

    /// <summary>
    /// Configure lifetime of the Dialogflow session.
    /// </summary>
    [TerraformProperty("session_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SessionTtl { get; set; }

}

/// <summary>
/// Block type for human_agent_assistant_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock() : TerraformBlock("human_agent_assistant_config")
{
}

/// <summary>
/// Block type for human_agent_handoff_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock() : TerraformBlock("human_agent_handoff_config")
{
}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowConversationProfileLoggingConfigBlock() : TerraformBlock("logging_config")
{
    /// <summary>
    /// Whether to log conversation events
    /// </summary>
    [TerraformProperty("enable_stackdriver_logging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableStackdriverLogging { get; set; }

}

/// <summary>
/// Block type for new_message_event_notification_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock() : TerraformBlock("new_message_event_notification_config")
{
    /// <summary>
    /// Format of the message Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [TerraformProperty("message_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageFormat { get; set; }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    [TerraformProperty("topic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Topic { get; set; }

}

/// <summary>
/// Block type for new_recognition_result_notification_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock() : TerraformBlock("new_recognition_result_notification_config")
{
    /// <summary>
    /// Format of message. Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [TerraformProperty("message_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageFormat { get; set; }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events like CONVERSATION_STARTED as serialized ConversationEvent protos.
    /// For telephony integration to receive notification, make sure either this topic is in the same project as the conversation or you grant service-&amp;lt;Conversation Project Number&amp;gt;@gcp-sa-dialogflow.iam.gserviceaccount.com the Dialogflow Service Agent role in the topic project.
    /// For chat integration to receive notification, make sure API caller has been granted the Dialogflow Service Agent role for the topic.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/topics/&amp;lt;Topic ID&amp;gt;.
    /// </summary>
    [TerraformProperty("topic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Topic { get; set; }

}

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowConversationProfileNotificationConfigBlock() : TerraformBlock("notification_config")
{
    /// <summary>
    /// Format of the message Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [TerraformProperty("message_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageFormat { get; set; }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    [TerraformProperty("topic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Topic { get; set; }

}

/// <summary>
/// Block type for stt_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowConversationProfileSttConfigBlock() : TerraformBlock("stt_config")
{
    /// <summary>
    /// Audio encoding of the audio content to process. Possible values: [&amp;quot;AUDIO_ENCODING_UNSPECIFIED&amp;quot;, &amp;quot;AUDIO_ENCODING_LINEAR_16&amp;quot;, &amp;quot;AUDIO_ENCODING_FLAC&amp;quot;, &amp;quot;AUDIO_ENCODING_MULAW&amp;quot;, &amp;quot;AUDIO_ENCODING_AMR&amp;quot;, &amp;quot;AUDIO_ENCODING_AMR_WB&amp;quot;, &amp;quot;AUDIO_ENCODING_OGG_OPUS&amp;quot;, &amp;quot;AUDIOENCODING_SPEEX_WITH_HEADER_BYTE&amp;quot;]
    /// </summary>
    [TerraformProperty("audio_encoding")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AudioEncoding { get; set; }

    /// <summary>
    /// If true, Dialogflow returns SpeechWordInfo in StreamingRecognitionResult with information about the recognized speech words.
    /// </summary>
    [TerraformProperty("enable_word_info")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableWordInfo { get; set; }

    /// <summary>
    /// The language of the supplied audio.
    /// </summary>
    [TerraformProperty("language_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LanguageCode { get; set; }

    /// <summary>
    /// Which Speech model to select.
    /// Leave this field unspecified to use Agent Speech settings for model selection.
    /// </summary>
    [TerraformProperty("model")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Model { get; set; }

    /// <summary>
    /// Sample rate (in Hertz) of the audio content sent in the query.
    /// </summary>
    [TerraformProperty("sample_rate_hertz")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SampleRateHertz { get; set; }

    /// <summary>
    /// The speech model used in speech to text. Possible values: [&amp;quot;SPEECH_MODEL_VARIANT_UNSPECIFIED&amp;quot;, &amp;quot;USE_BEST_AVAILABLE&amp;quot;, &amp;quot;USE_STANDARD&amp;quot;, &amp;quot;USE_ENHANCED&amp;quot;]
    /// </summary>
    [TerraformProperty("speech_model_variant")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SpeechModelVariant { get; set; }

    /// <summary>
    /// Use timeout based endpointing, interpreting endpointer sensitivy as seconds of timeout value.
    /// </summary>
    [TerraformProperty("use_timeout_based_endpointing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseTimeoutBasedEndpointing { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowConversationProfileTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for tts_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowConversationProfileTtsConfigBlock() : TerraformBlock("tts_config")
{
    /// <summary>
    /// An identifier which selects &#39;audio effects&#39; profiles that are applied on (post synthesized) text to speech. Effects are applied on top of each other in the order they are given.
    /// </summary>
    [TerraformProperty("effects_profile_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? EffectsProfileId { get; set; }

    /// <summary>
    /// Speaking pitch, in the range [-20.0, 20.0]. 20 means increase 20 semitones from the original pitch. -20 means decrease 20 semitones from the original pitch.
    /// </summary>
    [TerraformProperty("pitch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Pitch { get; set; }

    /// <summary>
    /// Speaking rate/speed, in the range [0.25, 4.0].
    /// </summary>
    [TerraformProperty("speaking_rate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SpeakingRate { get; set; }

    /// <summary>
    /// Volume gain (in dB) of the normal native volume supported by the specific voice.
    /// </summary>
    [TerraformProperty("volume_gain_db")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VolumeGainDb { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_conversation_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowConversationProfile : TerraformResource
{
    public GoogleDialogflowConversationProfile(string name) : base("google_dialogflow_conversation_profile", name)
    {
    }

    /// <summary>
    /// Required. Human readable name for this profile. Max length 1024 bytes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Language code for the conversation profile. This should be a BCP-47 language tag.
    /// </summary>
    [TerraformProperty("language_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LanguageCode { get; set; }

    /// <summary>
    /// desc
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Name of the CX SecuritySettings reference for the agent.
    /// </summary>
    [TerraformProperty("security_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecuritySettings { get; set; }

    /// <summary>
    /// The time zone of this conversational profile.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimeZone { get; set; }

    /// <summary>
    /// Block for automated_agent_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedAgentConfig block(s) allowed")]
    [TerraformProperty("automated_agent_config")]
    public TerraformList<GoogleDialogflowConversationProfileAutomatedAgentConfigBlock> AutomatedAgentConfig { get; set; } = new();

    /// <summary>
    /// Block for human_agent_assistant_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentAssistantConfig block(s) allowed")]
    [TerraformProperty("human_agent_assistant_config")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock> HumanAgentAssistantConfig { get; set; } = new();

    /// <summary>
    /// Block for human_agent_handoff_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentHandoffConfig block(s) allowed")]
    [TerraformProperty("human_agent_handoff_config")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock> HumanAgentHandoffConfig { get; set; } = new();

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformProperty("logging_config")]
    public TerraformList<GoogleDialogflowConversationProfileLoggingConfigBlock> LoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for new_message_event_notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewMessageEventNotificationConfig block(s) allowed")]
    [TerraformProperty("new_message_event_notification_config")]
    public TerraformList<GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock> NewMessageEventNotificationConfig { get; set; } = new();

    /// <summary>
    /// Block for new_recognition_result_notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewRecognitionResultNotificationConfig block(s) allowed")]
    [TerraformProperty("new_recognition_result_notification_config")]
    public TerraformList<GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock> NewRecognitionResultNotificationConfig { get; set; } = new();

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    [TerraformProperty("notification_config")]
    public TerraformList<GoogleDialogflowConversationProfileNotificationConfigBlock> NotificationConfig { get; set; } = new();

    /// <summary>
    /// Block for stt_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SttConfig block(s) allowed")]
    [TerraformProperty("stt_config")]
    public TerraformList<GoogleDialogflowConversationProfileSttConfigBlock> SttConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDialogflowConversationProfileTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tts_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtsConfig block(s) allowed")]
    [TerraformProperty("tts_config")]
    public TerraformList<GoogleDialogflowConversationProfileTtsConfigBlock> TtsConfig { get; set; } = new();

    /// <summary>
    /// name
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
