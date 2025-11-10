using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_agent_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileAutomatedAgentConfigBlock : TerraformBlock
{
    /// <summary>
    /// ID of the Dialogflow agent environment to use.
    /// Expects the format &amp;quot;projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent/environments/&amp;lt;EnvironmentID&amp;gt;&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Agent is required")]
    public required TerraformProperty<string> Agent
    {
        set => SetProperty("agent", value);
    }

    /// <summary>
    /// Configure lifetime of the Dialogflow session.
    /// </summary>
    public TerraformProperty<string>? SessionTtl
    {
        set => SetProperty("session_ttl", value);
    }

}

/// <summary>
/// Block type for human_agent_assistant_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for human_agent_handoff_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether to log conversation events
    /// </summary>
    public TerraformProperty<bool>? EnableStackdriverLogging
    {
        set => SetProperty("enable_stackdriver_logging", value);
    }

}

/// <summary>
/// Block type for new_message_event_notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Format of the message Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? MessageFormat
    {
        set => SetProperty("message_format", value);
    }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    public TerraformProperty<string>? Topic
    {
        set => SetProperty("topic", value);
    }

}

/// <summary>
/// Block type for new_recognition_result_notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Format of message. Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? MessageFormat
    {
        set => SetProperty("message_format", value);
    }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events like CONVERSATION_STARTED as serialized ConversationEvent protos.
    /// For telephony integration to receive notification, make sure either this topic is in the same project as the conversation or you grant service-&amp;lt;Conversation Project Number&amp;gt;@gcp-sa-dialogflow.iam.gserviceaccount.com the Dialogflow Service Agent role in the topic project.
    /// For chat integration to receive notification, make sure API caller has been granted the Dialogflow Service Agent role for the topic.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/topics/&amp;lt;Topic ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Topic
    {
        set => SetProperty("topic", value);
    }

}

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Format of the message Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? MessageFormat
    {
        set => SetProperty("message_format", value);
    }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    public TerraformProperty<string>? Topic
    {
        set => SetProperty("topic", value);
    }

}

/// <summary>
/// Block type for stt_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileSttConfigBlock : TerraformBlock
{
    /// <summary>
    /// Audio encoding of the audio content to process. Possible values: [&amp;quot;AUDIO_ENCODING_UNSPECIFIED&amp;quot;, &amp;quot;AUDIO_ENCODING_LINEAR_16&amp;quot;, &amp;quot;AUDIO_ENCODING_FLAC&amp;quot;, &amp;quot;AUDIO_ENCODING_MULAW&amp;quot;, &amp;quot;AUDIO_ENCODING_AMR&amp;quot;, &amp;quot;AUDIO_ENCODING_AMR_WB&amp;quot;, &amp;quot;AUDIO_ENCODING_OGG_OPUS&amp;quot;, &amp;quot;AUDIOENCODING_SPEEX_WITH_HEADER_BYTE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AudioEncoding
    {
        set => SetProperty("audio_encoding", value);
    }

    /// <summary>
    /// If true, Dialogflow returns SpeechWordInfo in StreamingRecognitionResult with information about the recognized speech words.
    /// </summary>
    public TerraformProperty<bool>? EnableWordInfo
    {
        set => SetProperty("enable_word_info", value);
    }

    /// <summary>
    /// The language of the supplied audio.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        set => SetProperty("language_code", value);
    }

    /// <summary>
    /// Which Speech model to select.
    /// Leave this field unspecified to use Agent Speech settings for model selection.
    /// </summary>
    public TerraformProperty<string>? Model
    {
        set => SetProperty("model", value);
    }

    /// <summary>
    /// Sample rate (in Hertz) of the audio content sent in the query.
    /// </summary>
    public TerraformProperty<double>? SampleRateHertz
    {
        set => SetProperty("sample_rate_hertz", value);
    }

    /// <summary>
    /// The speech model used in speech to text. Possible values: [&amp;quot;SPEECH_MODEL_VARIANT_UNSPECIFIED&amp;quot;, &amp;quot;USE_BEST_AVAILABLE&amp;quot;, &amp;quot;USE_STANDARD&amp;quot;, &amp;quot;USE_ENHANCED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SpeechModelVariant
    {
        set => SetProperty("speech_model_variant", value);
    }

    /// <summary>
    /// Use timeout based endpointing, interpreting endpointer sensitivy as seconds of timeout value.
    /// </summary>
    public TerraformProperty<bool>? UseTimeoutBasedEndpointing
    {
        set => SetProperty("use_timeout_based_endpointing", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowConversationProfileTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for tts_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileTtsConfigBlock : TerraformBlock
{
    /// <summary>
    /// An identifier which selects &#39;audio effects&#39; profiles that are applied on (post synthesized) text to speech. Effects are applied on top of each other in the order they are given.
    /// </summary>
    public List<TerraformProperty<string>>? EffectsProfileId
    {
        set => SetProperty("effects_profile_id", value);
    }

    /// <summary>
    /// Speaking pitch, in the range [-20.0, 20.0]. 20 means increase 20 semitones from the original pitch. -20 means decrease 20 semitones from the original pitch.
    /// </summary>
    public TerraformProperty<double>? Pitch
    {
        set => SetProperty("pitch", value);
    }

    /// <summary>
    /// Speaking rate/speed, in the range [0.25, 4.0].
    /// </summary>
    public TerraformProperty<double>? SpeakingRate
    {
        set => SetProperty("speaking_rate", value);
    }

    /// <summary>
    /// Volume gain (in dB) of the normal native volume supported by the specific voice.
    /// </summary>
    public TerraformProperty<double>? VolumeGainDb
    {
        set => SetProperty("volume_gain_db", value);
    }

}

/// <summary>
/// Manages a google_dialogflow_conversation_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowConversationProfile : TerraformResource
{
    public GoogleDialogflowConversationProfile(string name) : base("google_dialogflow_conversation_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("language_code");
        SetOutput("location");
        SetOutput("project");
        SetOutput("security_settings");
        SetOutput("time_zone");
    }

    /// <summary>
    /// Required. Human readable name for this profile. Max length 1024 bytes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Language code for the conversation profile. This should be a BCP-47 language tag.
    /// </summary>
    public TerraformProperty<string> LanguageCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language_code");
        set => SetProperty("language_code", value);
    }

    /// <summary>
    /// desc
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Name of the CX SecuritySettings reference for the agent.
    /// </summary>
    public TerraformProperty<string> SecuritySettings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_settings");
        set => SetProperty("security_settings", value);
    }

    /// <summary>
    /// The time zone of this conversational profile.
    /// </summary>
    public TerraformProperty<string> TimeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_zone");
        set => SetProperty("time_zone", value);
    }

    /// <summary>
    /// Block for automated_agent_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedAgentConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileAutomatedAgentConfigBlock>? AutomatedAgentConfig
    {
        set => SetProperty("automated_agent_config", value);
    }

    /// <summary>
    /// Block for human_agent_assistant_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentAssistantConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock>? HumanAgentAssistantConfig
    {
        set => SetProperty("human_agent_assistant_config", value);
    }

    /// <summary>
    /// Block for human_agent_handoff_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentHandoffConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock>? HumanAgentHandoffConfig
    {
        set => SetProperty("human_agent_handoff_config", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileLoggingConfigBlock>? LoggingConfig
    {
        set => SetProperty("logging_config", value);
    }

    /// <summary>
    /// Block for new_message_event_notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewMessageEventNotificationConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock>? NewMessageEventNotificationConfig
    {
        set => SetProperty("new_message_event_notification_config", value);
    }

    /// <summary>
    /// Block for new_recognition_result_notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewRecognitionResultNotificationConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock>? NewRecognitionResultNotificationConfig
    {
        set => SetProperty("new_recognition_result_notification_config", value);
    }

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileNotificationConfigBlock>? NotificationConfig
    {
        set => SetProperty("notification_config", value);
    }

    /// <summary>
    /// Block for stt_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SttConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileSttConfigBlock>? SttConfig
    {
        set => SetProperty("stt_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowConversationProfileTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tts_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtsConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileTtsConfigBlock>? TtsConfig
    {
        set => SetProperty("tts_config", value);
    }

    /// <summary>
    /// name
    /// </summary>
    public TerraformExpression Name => this["name"];

}
