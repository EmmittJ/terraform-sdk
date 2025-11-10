using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_agent_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileAutomatedAgentConfigBlock : ITerraformBlock
{
    /// <summary>
    /// ID of the Dialogflow agent environment to use.
    /// Expects the format &amp;quot;projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent/environments/&amp;lt;EnvironmentID&amp;gt;&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Agent is required")]
    [TerraformPropertyName("agent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Agent { get; set; }

    /// <summary>
    /// Configure lifetime of the Dialogflow session.
    /// </summary>
    [TerraformPropertyName("session_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SessionTtl { get; set; }

}

/// <summary>
/// Block type for human_agent_assistant_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for human_agent_handoff_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileLoggingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether to log conversation events
    /// </summary>
    [TerraformPropertyName("enable_stackdriver_logging")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableStackdriverLogging { get; set; }

}

/// <summary>
/// Block type for new_message_event_notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Format of the message Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [TerraformPropertyName("message_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageFormat { get; set; }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    [TerraformPropertyName("topic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Topic { get; set; }

}

/// <summary>
/// Block type for new_recognition_result_notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Format of message. Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [TerraformPropertyName("message_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageFormat { get; set; }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events like CONVERSATION_STARTED as serialized ConversationEvent protos.
    /// For telephony integration to receive notification, make sure either this topic is in the same project as the conversation or you grant service-&amp;lt;Conversation Project Number&amp;gt;@gcp-sa-dialogflow.iam.gserviceaccount.com the Dialogflow Service Agent role in the topic project.
    /// For chat integration to receive notification, make sure API caller has been granted the Dialogflow Service Agent role for the topic.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/topics/&amp;lt;Topic ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("topic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Topic { get; set; }

}

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileNotificationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Format of the message Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [TerraformPropertyName("message_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageFormat { get; set; }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    [TerraformPropertyName("topic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Topic { get; set; }

}

/// <summary>
/// Block type for stt_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileSttConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Audio encoding of the audio content to process. Possible values: [&amp;quot;AUDIO_ENCODING_UNSPECIFIED&amp;quot;, &amp;quot;AUDIO_ENCODING_LINEAR_16&amp;quot;, &amp;quot;AUDIO_ENCODING_FLAC&amp;quot;, &amp;quot;AUDIO_ENCODING_MULAW&amp;quot;, &amp;quot;AUDIO_ENCODING_AMR&amp;quot;, &amp;quot;AUDIO_ENCODING_AMR_WB&amp;quot;, &amp;quot;AUDIO_ENCODING_OGG_OPUS&amp;quot;, &amp;quot;AUDIOENCODING_SPEEX_WITH_HEADER_BYTE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("audio_encoding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AudioEncoding { get; set; }

    /// <summary>
    /// If true, Dialogflow returns SpeechWordInfo in StreamingRecognitionResult with information about the recognized speech words.
    /// </summary>
    [TerraformPropertyName("enable_word_info")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableWordInfo { get; set; }

    /// <summary>
    /// The language of the supplied audio.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LanguageCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "language_code");

    /// <summary>
    /// Which Speech model to select.
    /// Leave this field unspecified to use Agent Speech settings for model selection.
    /// </summary>
    [TerraformPropertyName("model")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Model { get; set; }

    /// <summary>
    /// Sample rate (in Hertz) of the audio content sent in the query.
    /// </summary>
    [TerraformPropertyName("sample_rate_hertz")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SampleRateHertz { get; set; }

    /// <summary>
    /// The speech model used in speech to text. Possible values: [&amp;quot;SPEECH_MODEL_VARIANT_UNSPECIFIED&amp;quot;, &amp;quot;USE_BEST_AVAILABLE&amp;quot;, &amp;quot;USE_STANDARD&amp;quot;, &amp;quot;USE_ENHANCED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("speech_model_variant")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpeechModelVariant { get; set; }

    /// <summary>
    /// Use timeout based endpointing, interpreting endpointer sensitivy as seconds of timeout value.
    /// </summary>
    [TerraformPropertyName("use_timeout_based_endpointing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseTimeoutBasedEndpointing { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowConversationProfileTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for tts_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileTtsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// An identifier which selects &#39;audio effects&#39; profiles that are applied on (post synthesized) text to speech. Effects are applied on top of each other in the order they are given.
    /// </summary>
    [TerraformPropertyName("effects_profile_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? EffectsProfileId { get; set; }

    /// <summary>
    /// Speaking pitch, in the range [-20.0, 20.0]. 20 means increase 20 semitones from the original pitch. -20 means decrease 20 semitones from the original pitch.
    /// </summary>
    [TerraformPropertyName("pitch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Pitch { get; set; }

    /// <summary>
    /// Speaking rate/speed, in the range [0.25, 4.0].
    /// </summary>
    [TerraformPropertyName("speaking_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SpeakingRate { get; set; }

    /// <summary>
    /// Volume gain (in dB) of the normal native volume supported by the specific voice.
    /// </summary>
    [TerraformPropertyName("volume_gain_db")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? VolumeGainDb { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_conversation_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowConversationProfile : TerraformResource
{
    public GoogleDialogflowConversationProfile(string name) : base("google_dialogflow_conversation_profile", name)
    {
    }

    /// <summary>
    /// Required. Human readable name for this profile. Max length 1024 bytes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Language code for the conversation profile. This should be a BCP-47 language tag.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LanguageCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "language_code");

    /// <summary>
    /// desc
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Name of the CX SecuritySettings reference for the agent.
    /// </summary>
    [TerraformPropertyName("security_settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecuritySettings { get; set; }

    /// <summary>
    /// The time zone of this conversational profile.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimeZone { get; set; }

    /// <summary>
    /// Block for automated_agent_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedAgentConfig block(s) allowed")]
    [TerraformPropertyName("automated_agent_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowConversationProfileAutomatedAgentConfigBlock>>? AutomatedAgentConfig { get; set; } = new();

    /// <summary>
    /// Block for human_agent_assistant_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentAssistantConfig block(s) allowed")]
    [TerraformPropertyName("human_agent_assistant_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock>>? HumanAgentAssistantConfig { get; set; } = new();

    /// <summary>
    /// Block for human_agent_handoff_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentHandoffConfig block(s) allowed")]
    [TerraformPropertyName("human_agent_handoff_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock>>? HumanAgentHandoffConfig { get; set; } = new();

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowConversationProfileLoggingConfigBlock>>? LoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for new_message_event_notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewMessageEventNotificationConfig block(s) allowed")]
    [TerraformPropertyName("new_message_event_notification_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock>>? NewMessageEventNotificationConfig { get; set; } = new();

    /// <summary>
    /// Block for new_recognition_result_notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewRecognitionResultNotificationConfig block(s) allowed")]
    [TerraformPropertyName("new_recognition_result_notification_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock>>? NewRecognitionResultNotificationConfig { get; set; } = new();

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    [TerraformPropertyName("notification_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowConversationProfileNotificationConfigBlock>>? NotificationConfig { get; set; } = new();

    /// <summary>
    /// Block for stt_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SttConfig block(s) allowed")]
    [TerraformPropertyName("stt_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowConversationProfileSttConfigBlock>>? SttConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowConversationProfileTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tts_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtsConfig block(s) allowed")]
    [TerraformPropertyName("tts_config")]
    public TerraformList<TerraformBlock<GoogleDialogflowConversationProfileTtsConfigBlock>>? TtsConfig { get; set; } = new();

    /// <summary>
    /// name
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
