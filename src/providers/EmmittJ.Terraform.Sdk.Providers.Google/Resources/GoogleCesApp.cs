using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audio_processing_config in GoogleCesApp.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppAudioProcessingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_processing_config";

    /// <summary>
    /// The duration of user inactivity (no speech or interaction) before the agent
    /// prompts the user for reengagement. If not set, the agent will not prompt
    /// the user for reengagement.
    /// </summary>
    public TerraformValue<string>? InactivityTimeout
    {
        get => GetArgument<TerraformValue<string>>("inactivity_timeout");
        set => SetArgument("inactivity_timeout", value);
    }

    /// <summary>
    /// AmbientSoundConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmbientSoundConfig block(s) allowed")]
    public TerraformList<GoogleCesAppAudioProcessingConfigBlockAmbientSoundConfigBlock>? AmbientSoundConfig
    {
        get => GetArgument<TerraformList<GoogleCesAppAudioProcessingConfigBlockAmbientSoundConfigBlock>>("ambient_sound_config");
        set => SetArgument("ambient_sound_config", value);
    }

    /// <summary>
    /// BargeInConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BargeInConfig block(s) allowed")]
    public TerraformList<GoogleCesAppAudioProcessingConfigBlockBargeInConfigBlock>? BargeInConfig
    {
        get => GetArgument<TerraformList<GoogleCesAppAudioProcessingConfigBlockBargeInConfigBlock>>("barge_in_config");
        set => SetArgument("barge_in_config", value);
    }

    /// <summary>
    /// SynthesizeSpeechConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleCesAppAudioProcessingConfigBlockSynthesizeSpeechConfigsBlock>? SynthesizeSpeechConfigs
    {
        get => GetArgument<TerraformSet<GoogleCesAppAudioProcessingConfigBlockSynthesizeSpeechConfigsBlock>>("synthesize_speech_configs");
        set => SetArgument("synthesize_speech_configs", value);
    }

}

/// <summary>
/// Block type for ambient_sound_config in GoogleCesAppAudioProcessingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppAudioProcessingConfigBlockAmbientSoundConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ambient_sound_config";

    /// <summary>
    /// Ambient noise as a mono-channel, 16kHz WAV file stored in [Cloud
    /// Storage](https://cloud.google.com/storage).
    /// Note: Please make sure the CES service agent
    /// &#39;service-@gcp-sa-ces.iam.gserviceaccount.com&#39; has
    /// &#39;storage.objects.get&#39; permission to the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? GcsUri
    {
        get => GetArgument<TerraformValue<string>>("gcs_uri");
        set => SetArgument("gcs_uri", value);
    }

    /// <summary>
    /// Name of the prebuilt ambient sound.
    /// Valid values are: - &amp;quot;coffee_shop&amp;quot; - &amp;quot;keyboard&amp;quot; - &amp;quot;keypad&amp;quot; - &amp;quot;hum&amp;quot;
    /// -&amp;quot;office_1&amp;quot; - &amp;quot;office_2&amp;quot; - &amp;quot;office_3&amp;quot;
    /// -&amp;quot;room_1&amp;quot; - &amp;quot;room_2&amp;quot; - &amp;quot;room_3&amp;quot;
    /// -&amp;quot;room_4&amp;quot; - &amp;quot;room_5&amp;quot; - &amp;quot;air_conditioner&amp;quot;
    /// </summary>
    public TerraformValue<string>? PrebuiltAmbientSound
    {
        get => GetArgument<TerraformValue<string>>("prebuilt_ambient_sound");
        set => SetArgument("prebuilt_ambient_sound", value);
    }

    /// <summary>
    /// Volume gain (in dB) of the normal native volume supported by
    /// ambient noise, in the range [-96.0, 16.0]. If unset, or set to a value of
    /// 0.0 (dB), will play at normal native signal amplitude. A value of -6.0 (dB)
    /// will play at approximately half the amplitude of the normal native signal
    /// amplitude. A value of +6.0 (dB) will play at approximately twice the
    /// amplitude of the normal native signal amplitude. We strongly recommend not
    /// to exceed +10 (dB) as there&#39;s usually no effective increase in loudness for
    /// any value greater than that.
    /// </summary>
    public TerraformValue<double>? VolumeGainDb
    {
        get => GetArgument<TerraformValue<double>>("volume_gain_db");
        set => SetArgument("volume_gain_db", value);
    }

}

/// <summary>
/// Block type for barge_in_config in GoogleCesAppAudioProcessingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppAudioProcessingConfigBlockBargeInConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "barge_in_config";

    /// <summary>
    /// If enabled, the agent will adapt its next response based on the assumption
    /// that the user hasn&#39;t heard the full preceding agent message.
    /// This should not be used in scenarios where agent responses are displayed
    /// visually.
    /// </summary>
    public TerraformValue<bool>? BargeInAwareness
    {
        get => GetArgument<TerraformValue<bool>>("barge_in_awareness");
        set => SetArgument("barge_in_awareness", value);
    }

}

/// <summary>
/// Block type for synthesize_speech_configs in GoogleCesAppAudioProcessingConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleCesAppAudioProcessingConfigBlockSynthesizeSpeechConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "synthesize_speech_configs";

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The speaking rate/speed in the range [0.25, 2.0]. 1.0 is the normal native
    /// speed supported by the specific voice. 2.0 is twice as fast, and 0.5 is
    /// half as fast. Values outside of the range [0.25, 2.0] will return an error.
    /// </summary>
    public TerraformValue<double>? SpeakingRate
    {
        get => GetArgument<TerraformValue<double>>("speaking_rate");
        set => SetArgument("speaking_rate", value);
    }

    /// <summary>
    /// The name of the voice. If not set, the service will choose a
    /// voice based on the other parameters such as language_code.
    /// For the list of available voices, please refer to Supported voices and
    /// languages from Cloud Text-to-Speech.
    /// </summary>
    public TerraformValue<string>? Voice
    {
        get => GetArgument<TerraformValue<string>>("voice");
        set => SetArgument("voice", value);
    }

}


/// <summary>
/// Block type for data_store_settings in GoogleCesApp.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppDataStoreSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_store_settings";

    /// <summary>
    /// The engines for the app.
    /// </summary>
    public TerraformList<TerraformMap<object>> Engines
        => AsReference("engines");

}


/// <summary>
/// Block type for default_channel_profile in GoogleCesApp.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppDefaultChannelProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_channel_profile";

    /// <summary>
    /// The type of the channel profile.
    /// Possible values:
    /// UNKNOWN
    /// WEB_UI
    /// API
    /// TWILIO
    /// GOOGLE_TELEPHONY_PLATFORM
    /// CONTACT_CENTER_AS_A_SERVICE
    /// </summary>
    public TerraformValue<string>? ChannelType
    {
        get => GetArgument<TerraformValue<string>>("channel_type");
        set => SetArgument("channel_type", value);
    }

    /// <summary>
    /// Whether to disable user barge-in in the conversation.
    /// - true: User interruptions are disabled while the agent is speaking.
    /// - false: The agent retains automatic control over when the user can interrupt.
    /// </summary>
    public TerraformValue<bool>? DisableBargeInControl
    {
        get => GetArgument<TerraformValue<bool>>("disable_barge_in_control");
        set => SetArgument("disable_barge_in_control", value);
    }

    /// <summary>
    /// Whether to disable DTMF (dual-tone multi-frequency).
    /// </summary>
    public TerraformValue<bool>? DisableDtmf
    {
        get => GetArgument<TerraformValue<bool>>("disable_dtmf");
        set => SetArgument("disable_dtmf", value);
    }

    /// <summary>
    /// The unique identifier of the channel profile.
    /// </summary>
    public TerraformValue<string>? ProfileId
    {
        get => GetArgument<TerraformValue<string>>("profile_id");
        set => SetArgument("profile_id", value);
    }

    /// <summary>
    /// PersonaProperty block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersonaProperty block(s) allowed")]
    public TerraformList<GoogleCesAppDefaultChannelProfileBlockPersonaPropertyBlock>? PersonaProperty
    {
        get => GetArgument<TerraformList<GoogleCesAppDefaultChannelProfileBlockPersonaPropertyBlock>>("persona_property");
        set => SetArgument("persona_property", value);
    }

    /// <summary>
    /// WebWidgetConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebWidgetConfig block(s) allowed")]
    public TerraformList<GoogleCesAppDefaultChannelProfileBlockWebWidgetConfigBlock>? WebWidgetConfig
    {
        get => GetArgument<TerraformList<GoogleCesAppDefaultChannelProfileBlockWebWidgetConfigBlock>>("web_widget_config");
        set => SetArgument("web_widget_config", value);
    }

}

/// <summary>
/// Block type for persona_property in GoogleCesAppDefaultChannelProfileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppDefaultChannelProfileBlockPersonaPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "persona_property";

    /// <summary>
    /// The persona of the channel.
    /// Possible values:
    /// UNKNOWN
    /// CONCISE
    /// CHATTY
    /// </summary>
    public TerraformValue<string>? Persona
    {
        get => GetArgument<TerraformValue<string>>("persona");
        set => SetArgument("persona", value);
    }

}

/// <summary>
/// Block type for web_widget_config in GoogleCesAppDefaultChannelProfileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppDefaultChannelProfileBlockWebWidgetConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_widget_config";

    /// <summary>
    /// The modality of the web widget.
    /// Possible values:
    /// UNKNOWN_MODALITY
    /// CHAT_AND_VOICE
    /// VOICE_ONLY
    /// CHAT_ONLY
    /// </summary>
    public TerraformValue<string>? Modality
    {
        get => GetArgument<TerraformValue<string>>("modality");
        set => SetArgument("modality", value);
    }

    /// <summary>
    /// The theme of the web widget.
    /// Possible values:
    /// UNKNOWN_THEME
    /// LIGHT
    /// DARK
    /// </summary>
    public TerraformValue<string>? Theme
    {
        get => GetArgument<TerraformValue<string>>("theme");
        set => SetArgument("theme", value);
    }

    /// <summary>
    /// The title of the web widget.
    /// </summary>
    public TerraformValue<string>? WebWidgetTitle
    {
        get => GetArgument<TerraformValue<string>>("web_widget_title");
        set => SetArgument("web_widget_title", value);
    }

}


/// <summary>
/// Block type for evaluation_metrics_thresholds in GoogleCesApp.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppEvaluationMetricsThresholdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "evaluation_metrics_thresholds";

    /// <summary>
    /// GoldenEvaluationMetricsThresholds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoldenEvaluationMetricsThresholds block(s) allowed")]
    public TerraformList<GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlock>? GoldenEvaluationMetricsThresholds
    {
        get => GetArgument<TerraformList<GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlock>>("golden_evaluation_metrics_thresholds");
        set => SetArgument("golden_evaluation_metrics_thresholds", value);
    }

}

/// <summary>
/// Block type for golden_evaluation_metrics_thresholds in GoogleCesAppEvaluationMetricsThresholdsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "golden_evaluation_metrics_thresholds";

    /// <summary>
    /// ExpectationLevelMetricsThresholds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpectationLevelMetricsThresholds block(s) allowed")]
    public TerraformList<GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlockExpectationLevelMetricsThresholdsBlock>? ExpectationLevelMetricsThresholds
    {
        get => GetArgument<TerraformList<GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlockExpectationLevelMetricsThresholdsBlock>>("expectation_level_metrics_thresholds");
        set => SetArgument("expectation_level_metrics_thresholds", value);
    }

    /// <summary>
    /// TurnLevelMetricsThresholds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TurnLevelMetricsThresholds block(s) allowed")]
    public TerraformList<GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlockTurnLevelMetricsThresholdsBlock>? TurnLevelMetricsThresholds
    {
        get => GetArgument<TerraformList<GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlockTurnLevelMetricsThresholdsBlock>>("turn_level_metrics_thresholds");
        set => SetArgument("turn_level_metrics_thresholds", value);
    }

}

/// <summary>
/// Block type for expectation_level_metrics_thresholds in GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlockExpectationLevelMetricsThresholdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expectation_level_metrics_thresholds";

    /// <summary>
    /// The success threshold for individual tool invocation parameter
    /// correctness. Must be a float between 0 and 1. Default is 1.0.
    /// </summary>
    public TerraformValue<double>? ToolInvocationParameterCorrectnessThreshold
    {
        get => GetArgument<TerraformValue<double>>("tool_invocation_parameter_correctness_threshold");
        set => SetArgument("tool_invocation_parameter_correctness_threshold", value);
    }

}

/// <summary>
/// Block type for turn_level_metrics_thresholds in GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppEvaluationMetricsThresholdsBlockGoldenEvaluationMetricsThresholdsBlockTurnLevelMetricsThresholdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "turn_level_metrics_thresholds";

    /// <summary>
    /// The success threshold for overall tool invocation correctness. Must be
    /// a float between 0 and 1. Default is 1.0.
    /// </summary>
    public TerraformValue<double>? OverallToolInvocationCorrectnessThreshold
    {
        get => GetArgument<TerraformValue<double>>("overall_tool_invocation_correctness_threshold");
        set => SetArgument("overall_tool_invocation_correctness_threshold", value);
    }

    /// <summary>
    /// The success threshold for semantic similarity. Must be an integer
    /// between 0 and 4. Default is &amp;gt;= 3.
    /// </summary>
    public TerraformValue<double>? SemanticSimilaritySuccessThreshold
    {
        get => GetArgument<TerraformValue<double>>("semantic_similarity_success_threshold");
        set => SetArgument("semantic_similarity_success_threshold", value);
    }

}


/// <summary>
/// Block type for language_settings in GoogleCesApp.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLanguageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "language_settings";

    /// <summary>
    /// The default language code of the app.
    /// </summary>
    public TerraformValue<string>? DefaultLanguageCode
    {
        get => GetArgument<TerraformValue<string>>("default_language_code");
        set => SetArgument("default_language_code", value);
    }

    /// <summary>
    /// Enables multilingual support. If true, agents in the app will use pre-built
    /// instructions to improve handling of multilingual input.
    /// </summary>
    public TerraformValue<bool>? EnableMultilingualSupport
    {
        get => GetArgument<TerraformValue<bool>>("enable_multilingual_support");
        set => SetArgument("enable_multilingual_support", value);
    }

    /// <summary>
    /// The action to perform when an agent receives input in an unsupported
    /// language.
    /// This can be a predefined action or a custom tool call.
    /// Valid values are:
    /// - A tool&#39;s full resource name, which triggers a specific tool execution.
    /// - A predefined system action, such as &amp;quot;escalate&amp;quot; or &amp;quot;exit&amp;quot;, which triggers
    /// an EndSession signal with corresponding metadata
    /// to terminate the conversation.
    /// </summary>
    public TerraformValue<string>? FallbackAction
    {
        get => GetArgument<TerraformValue<string>>("fallback_action");
        set => SetArgument("fallback_action", value);
    }

    /// <summary>
    /// List of languages codes supported by the app, in addition to the
    /// &#39;default_language_code&#39;.
    /// </summary>
    public TerraformList<string>? SupportedLanguageCodes
    {
        get => GetArgument<TerraformList<string>>("supported_language_codes");
        set => SetArgument("supported_language_codes", value);
    }

}


/// <summary>
/// Block type for logging_settings in GoogleCesApp.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLoggingSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_settings";

    /// <summary>
    /// AudioRecordingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioRecordingConfig block(s) allowed")]
    public TerraformList<GoogleCesAppLoggingSettingsBlockAudioRecordingConfigBlock>? AudioRecordingConfig
    {
        get => GetArgument<TerraformList<GoogleCesAppLoggingSettingsBlockAudioRecordingConfigBlock>>("audio_recording_config");
        set => SetArgument("audio_recording_config", value);
    }

    /// <summary>
    /// BigqueryExportSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryExportSettings block(s) allowed")]
    public TerraformList<GoogleCesAppLoggingSettingsBlockBigqueryExportSettingsBlock>? BigqueryExportSettings
    {
        get => GetArgument<TerraformList<GoogleCesAppLoggingSettingsBlockBigqueryExportSettingsBlock>>("bigquery_export_settings");
        set => SetArgument("bigquery_export_settings", value);
    }

    /// <summary>
    /// CloudLoggingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudLoggingSettings block(s) allowed")]
    public TerraformList<GoogleCesAppLoggingSettingsBlockCloudLoggingSettingsBlock>? CloudLoggingSettings
    {
        get => GetArgument<TerraformList<GoogleCesAppLoggingSettingsBlockCloudLoggingSettingsBlock>>("cloud_logging_settings");
        set => SetArgument("cloud_logging_settings", value);
    }

    /// <summary>
    /// ConversationLoggingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationLoggingSettings block(s) allowed")]
    public TerraformList<GoogleCesAppLoggingSettingsBlockConversationLoggingSettingsBlock>? ConversationLoggingSettings
    {
        get => GetArgument<TerraformList<GoogleCesAppLoggingSettingsBlockConversationLoggingSettingsBlock>>("conversation_logging_settings");
        set => SetArgument("conversation_logging_settings", value);
    }

    /// <summary>
    /// RedactionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedactionConfig block(s) allowed")]
    public TerraformList<GoogleCesAppLoggingSettingsBlockRedactionConfigBlock>? RedactionConfig
    {
        get => GetArgument<TerraformList<GoogleCesAppLoggingSettingsBlockRedactionConfigBlock>>("redaction_config");
        set => SetArgument("redaction_config", value);
    }

}

/// <summary>
/// Block type for audio_recording_config in GoogleCesAppLoggingSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLoggingSettingsBlockAudioRecordingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_recording_config";

    /// <summary>
    /// The [Cloud Storage](https://cloud.google.com/storage) bucket to store the
    /// session audio recordings. The URI must start with &amp;quot;gs://&amp;quot;.
    /// Note: If the Cloud Storage bucket is in a different project from the app,
    /// you should grant &#39;storage.objects.create&#39; permission to the CES service
    /// agent &#39;service-@gcp-sa-ces.iam.gserviceaccount.com&#39;.
    /// </summary>
    public TerraformValue<string>? GcsBucket
    {
        get => GetArgument<TerraformValue<string>>("gcs_bucket");
        set => SetArgument("gcs_bucket", value);
    }

    /// <summary>
    /// The Cloud Storage path prefix for audio recordings.
    /// This prefix can include the following placeholders, which will be
    /// dynamically substituted at serving time:
    /// - $project:   project ID
    /// - $location:  app location
    /// - $app:       app ID
    /// - $date:      session date in YYYY-MM-DD format
    /// - $session:   session ID
    /// If the path prefix is not specified, the default prefix
    /// &#39;$project/$location/$app/$date/$session/&#39; will be used.
    /// </summary>
    public TerraformValue<string>? GcsPathPrefix
    {
        get => GetArgument<TerraformValue<string>>("gcs_path_prefix");
        set => SetArgument("gcs_path_prefix", value);
    }

}

/// <summary>
/// Block type for bigquery_export_settings in GoogleCesAppLoggingSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLoggingSettingsBlockBigqueryExportSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_export_settings";

    /// <summary>
    /// The BigQuery dataset to export the data to.
    /// </summary>
    public TerraformValue<string>? Dataset
    {
        get => GetArgument<TerraformValue<string>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Indicates whether the BigQuery export is enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The project ID of the BigQuery dataset to export the data to.
    /// Note: If the BigQuery dataset is in a different project from the app, you should grant
    /// roles/bigquery.admin role to the CES service agent service-&amp;lt;PROJECT-
    /// NUMBER&amp;gt;@gcp-sa-ces.iam.gserviceaccount.com.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

}

/// <summary>
/// Block type for cloud_logging_settings in GoogleCesAppLoggingSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLoggingSettingsBlockCloudLoggingSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_logging_settings";

    /// <summary>
    /// Whether to enable Cloud Logging for the sessions.
    /// </summary>
    public TerraformValue<bool>? EnableCloudLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_cloud_logging");
        set => SetArgument("enable_cloud_logging", value);
    }

}

/// <summary>
/// Block type for conversation_logging_settings in GoogleCesAppLoggingSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLoggingSettingsBlockConversationLoggingSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_logging_settings";

    /// <summary>
    /// Whether to disable conversation logging for the sessions.
    /// </summary>
    public TerraformValue<bool>? DisableConversationLogging
    {
        get => GetArgument<TerraformValue<bool>>("disable_conversation_logging");
        set => SetArgument("disable_conversation_logging", value);
    }

}

/// <summary>
/// Block type for redaction_config in GoogleCesAppLoggingSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLoggingSettingsBlockRedactionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redaction_config";

    /// <summary>
    /// [DLP](https://cloud.google.com/dlp/docs) deidentify template name to
    /// instruct on how to de-identify content.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}&#39;
    /// </summary>
    public TerraformValue<string>? DeidentifyTemplate
    {
        get => GetArgument<TerraformValue<string>>("deidentify_template");
        set => SetArgument("deidentify_template", value);
    }

    /// <summary>
    /// If true, redaction will be applied in various logging scenarios, including
    /// conversation history, Cloud Logging and audio recording.
    /// </summary>
    public TerraformValue<bool>? EnableRedaction
    {
        get => GetArgument<TerraformValue<bool>>("enable_redaction");
        set => SetArgument("enable_redaction", value);
    }

    /// <summary>
    /// [DLP](https://cloud.google.com/dlp/docs) inspect template name to configure
    /// detection of sensitive data types.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/inspectTemplates/{inspect_template}&#39;
    /// </summary>
    public TerraformValue<string>? InspectTemplate
    {
        get => GetArgument<TerraformValue<string>>("inspect_template");
        set => SetArgument("inspect_template", value);
    }

}


/// <summary>
/// Block type for model_settings in GoogleCesApp.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppModelSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model_settings";

    /// <summary>
    /// The LLM model that the agent should use.
    /// If not set, the agent will inherit the model from its parent agent.
    /// </summary>
    public TerraformValue<string>? Model
    {
        get => GetArgument<TerraformValue<string>>("model");
        set => SetArgument("model", value);
    }

    /// <summary>
    /// If set, this temperature will be used for the LLM model. Temperature
    /// controls the randomness of the model&#39;s responses. Lower temperatures
    /// produce responses that are more predictable. Higher temperatures produce
    /// responses that are more creative.
    /// </summary>
    public TerraformValue<double>? Temperature
    {
        get => GetArgument<TerraformValue<double>>("temperature");
        set => SetArgument("temperature", value);
    }

}


/// <summary>
/// Block type for time_zone_settings in GoogleCesApp.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppTimeZoneSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_zone_settings";

    /// <summary>
    /// The time zone of the app from the time zone database, e.g., America/Los_Angeles, Europe/Paris.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCesApp.
/// Nesting mode: single
/// </summary>
public class GoogleCesAppTimeoutsBlock : TerraformBlock
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
/// Block type for variable_declarations in GoogleCesApp.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppVariableDeclarationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "variable_declarations";

    /// <summary>
    /// The description of the variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetRequiredArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name of the variable. The name must start with a letter or underscore
    /// and contain only letters, numbers, or underscores.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Schema block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    public required TerraformList<GoogleCesAppVariableDeclarationsBlockSchemaBlock> Schema
    {
        get => GetRequiredArgument<TerraformList<GoogleCesAppVariableDeclarationsBlockSchemaBlock>>("schema");
        set => SetArgument("schema", value);
    }

}

/// <summary>
/// Block type for schema in GoogleCesAppVariableDeclarationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCesAppVariableDeclarationsBlockSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema";

    /// <summary>
    /// Optional. Defines the schema for additional properties allowed in an object.
    /// The value must be a valid JSON string representing the Schema object.
    /// (Note: OpenAPI also allows a boolean, this definition expects a Schema JSON).
    /// </summary>
    public TerraformValue<string>? AdditionalProperties
    {
        get => GetArgument<TerraformValue<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// Optional. The instance value should be valid against at least one of the schemas in this list.
    /// </summary>
    public TerraformValue<string>? AnyOf
    {
        get => GetArgument<TerraformValue<string>>("any_of");
        set => SetArgument("any_of", value);
    }

    /// <summary>
    /// Optional. Default value of the data. Represents a dynamically typed value
    /// which can be either null, a number, a string, a boolean, a struct,
    /// or a list of values. The provided default value must be compatible
    /// with the defined &#39;type&#39; and other schema constraints.
    /// </summary>
    public TerraformValue<string>? DefaultAttribute
    {
        get => GetArgument<TerraformValue<string>>("default");
        set => SetArgument("default", value);
    }

    /// <summary>
    /// A map of definitions for use by ref. Only allowed at the root of the schema.
    /// </summary>
    public TerraformValue<string>? Defs
    {
        get => GetArgument<TerraformValue<string>>("defs");
        set => SetArgument("defs", value);
    }

    /// <summary>
    /// The description of the data.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Possible values of the element of primitive type with enum format.
    /// Examples:
    /// 1. We can define direction as :
    /// {type:STRING, format:enum, enum:[&amp;quot;EAST&amp;quot;, NORTH&amp;quot;, &amp;quot;SOUTH&amp;quot;, &amp;quot;WEST&amp;quot;]}
    /// 2. We can define apartment number as :
    /// {type:INTEGER, format:enum, enum:[&amp;quot;101&amp;quot;, &amp;quot;201&amp;quot;, &amp;quot;301&amp;quot;]}
    /// </summary>
    public TerraformList<string>? EnumAttribute
    {
        get => GetArgument<TerraformList<string>>("enum");
        set => SetArgument("enum", value);
    }

    /// <summary>
    /// Schema of the elements of Type.ARRAY.
    /// </summary>
    public TerraformValue<string>? Items
    {
        get => GetArgument<TerraformValue<string>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// Indicates if the value may be null.
    /// </summary>
    public TerraformValue<bool>? Nullable
    {
        get => GetArgument<TerraformValue<bool>>("nullable");
        set => SetArgument("nullable", value);
    }

    /// <summary>
    /// Optional. Schemas of initial elements of Type.ARRAY.
    /// </summary>
    public TerraformValue<string>? PrefixItems
    {
        get => GetArgument<TerraformValue<string>>("prefix_items");
        set => SetArgument("prefix_items", value);
    }

    /// <summary>
    /// Properties of Type.OBJECT.
    /// </summary>
    public TerraformValue<string>? Properties
    {
        get => GetArgument<TerraformValue<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Allows indirect references between schema nodes. The value should be a
    /// valid reference to a child of the root &#39;defs&#39;.
    /// For example, the following schema defines a reference to a schema node
    /// named &amp;quot;Pet&amp;quot;:
    /// type: object
    /// properties:
    ///   pet:
    ///     ref: #/defs/Pet
    /// defs:
    ///   Pet:
    ///     type: object
    ///     properties:
    ///       name:
    ///         type: string
    /// The value of the &amp;quot;pet&amp;quot; property is a reference to the schema node
    /// named &amp;quot;Pet&amp;quot;.
    /// See details in
    /// https://json-schema.org/understanding-json-schema/structuring.
    /// </summary>
    public TerraformValue<string>? RefAttribute
    {
        get => GetArgument<TerraformValue<string>>("ref");
        set => SetArgument("ref", value);
    }

    /// <summary>
    /// Required properties of Type.OBJECT.
    /// </summary>
    public TerraformList<string>? Required
    {
        get => GetArgument<TerraformList<string>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type of the data.
    /// Possible values:
    /// STRING
    /// INTEGER
    /// NUMBER
    /// BOOLEAN
    /// OBJECT
    /// ARRAY
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Indicate the items in the array must be unique. Only applies to TYPE.ARRAY.
    /// </summary>
    public TerraformValue<bool>? UniqueItems
    {
        get => GetArgument<TerraformValue<bool>>("unique_items");
        set => SetArgument("unique_items", value);
    }

}


/// <summary>
/// Represents a google_ces_app Terraform resource.
/// Manages a google_ces_app resource.
/// </summary>
public partial class GoogleCesApp(string name) : TerraformResource("google_ces_app", name)
{
    /// <summary>
    /// The ID to use for the app, which will become the final component of
    /// the app&#39;s resource name. If not provided, a unique ID will be
    /// automatically assigned for the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// Human-readable description of the app.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Display name of the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Instructions for all the agents in the app.
    /// You can use this instruction to set up a stable identity or personality
    /// across all the agents.
    /// </summary>
    public TerraformValue<string>? GlobalInstruction
    {
        get => GetArgument<TerraformValue<string>>("global_instruction");
        set => SetArgument("global_instruction", value);
    }

    /// <summary>
    /// List of guardrails for the app.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}&#39;
    /// </summary>
    public TerraformList<string>? Guardrails
    {
        get => GetArgument<TerraformList<string>>("guardrails");
        set => SetArgument("guardrails", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Metadata about the app. This field can be used to store additional
    /// information relevant to the app&#39;s details or intended usages.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The root agent is the entry point of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}/agents/{agent}&#39;
    /// </summary>
    public TerraformValue<string>? RootAgent
    {
        get => GetArgument<TerraformValue<string>>("root_agent");
        set => SetArgument("root_agent", value);
    }

    /// <summary>
    /// Timestamp when the app was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Number of deployments in the app.
    /// </summary>
    public TerraformValue<double> DeploymentCount
        => AsReference("deployment_count");

    /// <summary>
    /// Etag used to ensure the object hasn&#39;t changed during a read-modify-write
    /// operation. If the etag is empty, the update will overwrite any concurrent
    /// changes.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Identifier. The unique identifier of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Timestamp when the app was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// AudioProcessingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioProcessingConfig block(s) allowed")]
    public TerraformList<GoogleCesAppAudioProcessingConfigBlock>? AudioProcessingConfig
    {
        get => GetArgument<TerraformList<GoogleCesAppAudioProcessingConfigBlock>>("audio_processing_config");
        set => SetArgument("audio_processing_config", value);
    }

    /// <summary>
    /// DataStoreSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataStoreSettings block(s) allowed")]
    public TerraformList<GoogleCesAppDataStoreSettingsBlock>? DataStoreSettings
    {
        get => GetArgument<TerraformList<GoogleCesAppDataStoreSettingsBlock>>("data_store_settings");
        set => SetArgument("data_store_settings", value);
    }

    /// <summary>
    /// DefaultChannelProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultChannelProfile block(s) allowed")]
    public TerraformList<GoogleCesAppDefaultChannelProfileBlock>? DefaultChannelProfile
    {
        get => GetArgument<TerraformList<GoogleCesAppDefaultChannelProfileBlock>>("default_channel_profile");
        set => SetArgument("default_channel_profile", value);
    }

    /// <summary>
    /// EvaluationMetricsThresholds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvaluationMetricsThresholds block(s) allowed")]
    public TerraformList<GoogleCesAppEvaluationMetricsThresholdsBlock>? EvaluationMetricsThresholds
    {
        get => GetArgument<TerraformList<GoogleCesAppEvaluationMetricsThresholdsBlock>>("evaluation_metrics_thresholds");
        set => SetArgument("evaluation_metrics_thresholds", value);
    }

    /// <summary>
    /// LanguageSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LanguageSettings block(s) allowed")]
    public TerraformList<GoogleCesAppLanguageSettingsBlock>? LanguageSettings
    {
        get => GetArgument<TerraformList<GoogleCesAppLanguageSettingsBlock>>("language_settings");
        set => SetArgument("language_settings", value);
    }

    /// <summary>
    /// LoggingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingSettings block(s) allowed")]
    public TerraformList<GoogleCesAppLoggingSettingsBlock>? LoggingSettings
    {
        get => GetArgument<TerraformList<GoogleCesAppLoggingSettingsBlock>>("logging_settings");
        set => SetArgument("logging_settings", value);
    }

    /// <summary>
    /// ModelSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelSettings block(s) allowed")]
    public TerraformList<GoogleCesAppModelSettingsBlock>? ModelSettings
    {
        get => GetArgument<TerraformList<GoogleCesAppModelSettingsBlock>>("model_settings");
        set => SetArgument("model_settings", value);
    }

    /// <summary>
    /// TimeZoneSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeZoneSettings block(s) allowed")]
    public TerraformList<GoogleCesAppTimeZoneSettingsBlock>? TimeZoneSettings
    {
        get => GetArgument<TerraformList<GoogleCesAppTimeZoneSettingsBlock>>("time_zone_settings");
        set => SetArgument("time_zone_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCesAppTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCesAppTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VariableDeclarations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCesAppVariableDeclarationsBlock>? VariableDeclarations
    {
        get => GetArgument<TerraformList<GoogleCesAppVariableDeclarationsBlock>>("variable_declarations");
        set => SetArgument("variable_declarations", value);
    }

}
