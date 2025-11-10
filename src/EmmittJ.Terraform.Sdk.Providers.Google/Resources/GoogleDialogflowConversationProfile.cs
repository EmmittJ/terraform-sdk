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
        get => GetProperty<TerraformProperty<string>>("agent");
        set => WithProperty("agent", value);
    }

    /// <summary>
    /// Configure lifetime of the Dialogflow session.
    /// </summary>
    public TerraformProperty<string>? SessionTtl
    {
        get => GetProperty<TerraformProperty<string>>("session_ttl");
        set => WithProperty("session_ttl", value);
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
        get => GetProperty<TerraformProperty<bool>>("enable_stackdriver_logging");
        set => WithProperty("enable_stackdriver_logging", value);
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
        get => GetProperty<TerraformProperty<string>>("message_format");
        set => WithProperty("message_format", value);
    }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    public TerraformProperty<string>? Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
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
        get => GetProperty<TerraformProperty<string>>("message_format");
        set => WithProperty("message_format", value);
    }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events like CONVERSATION_STARTED as serialized ConversationEvent protos.
    /// For telephony integration to receive notification, make sure either this topic is in the same project as the conversation or you grant service-&amp;lt;Conversation Project Number&amp;gt;@gcp-sa-dialogflow.iam.gserviceaccount.com the Dialogflow Service Agent role in the topic project.
    /// For chat integration to receive notification, make sure API caller has been granted the Dialogflow Service Agent role for the topic.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/topics/&amp;lt;Topic ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
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
        get => GetProperty<TerraformProperty<string>>("message_format");
        set => WithProperty("message_format", value);
    }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    public TerraformProperty<string>? Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
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
        get => GetProperty<TerraformProperty<string>>("audio_encoding");
        set => WithProperty("audio_encoding", value);
    }

    /// <summary>
    /// If true, Dialogflow returns SpeechWordInfo in StreamingRecognitionResult with information about the recognized speech words.
    /// </summary>
    public TerraformProperty<bool>? EnableWordInfo
    {
        get => GetProperty<TerraformProperty<bool>>("enable_word_info");
        set => WithProperty("enable_word_info", value);
    }

    /// <summary>
    /// The language of the supplied audio.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => WithProperty("language_code", value);
    }

    /// <summary>
    /// Which Speech model to select.
    /// Leave this field unspecified to use Agent Speech settings for model selection.
    /// </summary>
    public TerraformProperty<string>? Model
    {
        get => GetProperty<TerraformProperty<string>>("model");
        set => WithProperty("model", value);
    }

    /// <summary>
    /// Sample rate (in Hertz) of the audio content sent in the query.
    /// </summary>
    public TerraformProperty<double>? SampleRateHertz
    {
        get => GetProperty<TerraformProperty<double>>("sample_rate_hertz");
        set => WithProperty("sample_rate_hertz", value);
    }

    /// <summary>
    /// The speech model used in speech to text. Possible values: [&amp;quot;SPEECH_MODEL_VARIANT_UNSPECIFIED&amp;quot;, &amp;quot;USE_BEST_AVAILABLE&amp;quot;, &amp;quot;USE_STANDARD&amp;quot;, &amp;quot;USE_ENHANCED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SpeechModelVariant
    {
        get => GetProperty<TerraformProperty<string>>("speech_model_variant");
        set => WithProperty("speech_model_variant", value);
    }

    /// <summary>
    /// Use timeout based endpointing, interpreting endpointer sensitivy as seconds of timeout value.
    /// </summary>
    public TerraformProperty<bool>? UseTimeoutBasedEndpointing
    {
        get => GetProperty<TerraformProperty<bool>>("use_timeout_based_endpointing");
        set => WithProperty("use_timeout_based_endpointing", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("effects_profile_id");
        set => WithProperty("effects_profile_id", value);
    }

    /// <summary>
    /// Speaking pitch, in the range [-20.0, 20.0]. 20 means increase 20 semitones from the original pitch. -20 means decrease 20 semitones from the original pitch.
    /// </summary>
    public TerraformProperty<double>? Pitch
    {
        get => GetProperty<TerraformProperty<double>>("pitch");
        set => WithProperty("pitch", value);
    }

    /// <summary>
    /// Speaking rate/speed, in the range [0.25, 4.0].
    /// </summary>
    public TerraformProperty<double>? SpeakingRate
    {
        get => GetProperty<TerraformProperty<double>>("speaking_rate");
        set => WithProperty("speaking_rate", value);
    }

    /// <summary>
    /// Volume gain (in dB) of the normal native volume supported by the specific voice.
    /// </summary>
    public TerraformProperty<double>? VolumeGainDb
    {
        get => GetProperty<TerraformProperty<double>>("volume_gain_db");
        set => WithProperty("volume_gain_db", value);
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
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Required. Human readable name for this profile. Max length 1024 bytes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Language code for the conversation profile. This should be a BCP-47 language tag.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// desc
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Name of the CX SecuritySettings reference for the agent.
    /// </summary>
    public TerraformProperty<string>? SecuritySettings
    {
        get => GetProperty<TerraformProperty<string>>("security_settings");
        set => this.WithProperty("security_settings", value);
    }

    /// <summary>
    /// The time zone of this conversational profile.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// Block for automated_agent_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedAgentConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileAutomatedAgentConfigBlock>? AutomatedAgentConfig
    {
        get => GetProperty<List<GoogleDialogflowConversationProfileAutomatedAgentConfigBlock>>("automated_agent_config");
        set => this.WithProperty("automated_agent_config", value);
    }

    /// <summary>
    /// Block for human_agent_assistant_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentAssistantConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock>? HumanAgentAssistantConfig
    {
        get => GetProperty<List<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock>>("human_agent_assistant_config");
        set => this.WithProperty("human_agent_assistant_config", value);
    }

    /// <summary>
    /// Block for human_agent_handoff_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentHandoffConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock>? HumanAgentHandoffConfig
    {
        get => GetProperty<List<GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock>>("human_agent_handoff_config");
        set => this.WithProperty("human_agent_handoff_config", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileLoggingConfigBlock>? LoggingConfig
    {
        get => GetProperty<List<GoogleDialogflowConversationProfileLoggingConfigBlock>>("logging_config");
        set => this.WithProperty("logging_config", value);
    }

    /// <summary>
    /// Block for new_message_event_notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewMessageEventNotificationConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock>? NewMessageEventNotificationConfig
    {
        get => GetProperty<List<GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock>>("new_message_event_notification_config");
        set => this.WithProperty("new_message_event_notification_config", value);
    }

    /// <summary>
    /// Block for new_recognition_result_notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewRecognitionResultNotificationConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock>? NewRecognitionResultNotificationConfig
    {
        get => GetProperty<List<GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock>>("new_recognition_result_notification_config");
        set => this.WithProperty("new_recognition_result_notification_config", value);
    }

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileNotificationConfigBlock>? NotificationConfig
    {
        get => GetProperty<List<GoogleDialogflowConversationProfileNotificationConfigBlock>>("notification_config");
        set => this.WithProperty("notification_config", value);
    }

    /// <summary>
    /// Block for stt_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SttConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileSttConfigBlock>? SttConfig
    {
        get => GetProperty<List<GoogleDialogflowConversationProfileSttConfigBlock>>("stt_config");
        set => this.WithProperty("stt_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowConversationProfileTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowConversationProfileTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tts_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtsConfig block(s) allowed")]
    public List<GoogleDialogflowConversationProfileTtsConfigBlock>? TtsConfig
    {
        get => GetProperty<List<GoogleDialogflowConversationProfileTtsConfigBlock>>("tts_config");
        set => this.WithProperty("tts_config", value);
    }

    /// <summary>
    /// name
    /// </summary>
    public TerraformExpression Name => this["name"];

}
