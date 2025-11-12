using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audio_processing_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCesAppAudioProcessingConfigBlock() : TerraformBlock("audio_processing_config")
{
    /// <summary>
    /// The duration of user inactivity (no speech or interaction) before the agent
    /// prompts the user for reengagement. If not set, the agent will not prompt
    /// the user for reengagement.
    /// </summary>
    [TerraformProperty("inactivity_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InactivityTimeout { get; set; }

}

/// <summary>
/// Block type for data_store_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCesAppDataStoreSettingsBlock() : TerraformBlock("data_store_settings")
{

}

/// <summary>
/// Block type for default_channel_profile in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCesAppDefaultChannelProfileBlock() : TerraformBlock("default_channel_profile")
{
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
    [TerraformProperty("channel_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ChannelType { get; set; }

    /// <summary>
    /// Whether to disable user barge-in in the conversation.
    /// - true: User interruptions are disabled while the agent is speaking.
    /// - false: The agent retains automatic control over when the user can interrupt.
    /// </summary>
    [TerraformProperty("disable_barge_in_control")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableBargeInControl { get; set; }

    /// <summary>
    /// Whether to disable DTMF (dual-tone multi-frequency).
    /// </summary>
    [TerraformProperty("disable_dtmf")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableDtmf { get; set; }

    /// <summary>
    /// The unique identifier of the channel profile.
    /// </summary>
    [TerraformProperty("profile_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProfileId { get; set; }

}

/// <summary>
/// Block type for evaluation_metrics_thresholds in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCesAppEvaluationMetricsThresholdsBlock() : TerraformBlock("evaluation_metrics_thresholds")
{
}

/// <summary>
/// Block type for language_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCesAppLanguageSettingsBlock() : TerraformBlock("language_settings")
{
    /// <summary>
    /// The default language code of the app.
    /// </summary>
    [TerraformProperty("default_language_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultLanguageCode { get; set; }

    /// <summary>
    /// Enables multilingual support. If true, agents in the app will use pre-built
    /// instructions to improve handling of multilingual input.
    /// </summary>
    [TerraformProperty("enable_multilingual_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableMultilingualSupport { get; set; }

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
    [TerraformProperty("fallback_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FallbackAction { get; set; }

    /// <summary>
    /// List of languages codes supported by the app, in addition to the
    /// &#39;default_language_code&#39;.
    /// </summary>
    [TerraformProperty("supported_language_codes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SupportedLanguageCodes { get; set; }

}

/// <summary>
/// Block type for logging_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCesAppLoggingSettingsBlock() : TerraformBlock("logging_settings")
{
}

/// <summary>
/// Block type for model_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCesAppModelSettingsBlock() : TerraformBlock("model_settings")
{
    /// <summary>
    /// The LLM model that the agent should use.
    /// If not set, the agent will inherit the model from its parent agent.
    /// </summary>
    [TerraformProperty("model")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Model { get; set; }

    /// <summary>
    /// If set, this temperature will be used for the LLM model. Temperature
    /// controls the randomness of the model&#39;s responses. Lower temperatures
    /// produce responses that are more predictable. Higher temperatures produce
    /// responses that are more creative.
    /// </summary>
    [TerraformProperty("temperature")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Temperature { get; set; }

}

/// <summary>
/// Block type for time_zone_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCesAppTimeZoneSettingsBlock() : TerraformBlock("time_zone_settings")
{
    /// <summary>
    /// The time zone of the app from the time zone database, e.g., America/Los_Angeles, Europe/Paris.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimeZone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCesAppTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for variable_declarations in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCesAppVariableDeclarationsBlock() : TerraformBlock("variable_declarations")
{
    /// <summary>
    /// The description of the variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The name of the variable. The name must start with a letter or underscore
    /// and contain only letters, numbers, or underscores.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a google_ces_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCesApp : TerraformResource
{
    public GoogleCesApp(string name) : base("google_ces_app", name)
    {
    }

    /// <summary>
    /// The ID to use for the app, which will become the final component of
    /// the app&#39;s resource name. If not provided, a unique ID will be
    /// automatically assigned for the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformProperty("app_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// Human-readable description of the app.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Display name of the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Instructions for all the agents in the app.
    /// You can use this instruction to set up a stable identity or personality
    /// across all the agents.
    /// </summary>
    [TerraformProperty("global_instruction")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GlobalInstruction { get; set; }

    /// <summary>
    /// List of guardrails for the app.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}&#39;
    /// </summary>
    [TerraformProperty("guardrails")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Guardrails { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Metadata about the app. This field can be used to store additional
    /// information relevant to the app&#39;s details or intended usages.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The root agent is the entry point of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}/agents/{agent}&#39;
    /// </summary>
    [TerraformProperty("root_agent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RootAgent { get; set; }

    /// <summary>
    /// Block for audio_processing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioProcessingConfig block(s) allowed")]
    [TerraformProperty("audio_processing_config")]
    public TerraformList<GoogleCesAppAudioProcessingConfigBlock> AudioProcessingConfig { get; set; } = new();

    /// <summary>
    /// Block for data_store_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataStoreSettings block(s) allowed")]
    [TerraformProperty("data_store_settings")]
    public TerraformList<GoogleCesAppDataStoreSettingsBlock> DataStoreSettings { get; set; } = new();

    /// <summary>
    /// Block for default_channel_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultChannelProfile block(s) allowed")]
    [TerraformProperty("default_channel_profile")]
    public TerraformList<GoogleCesAppDefaultChannelProfileBlock> DefaultChannelProfile { get; set; } = new();

    /// <summary>
    /// Block for evaluation_metrics_thresholds.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvaluationMetricsThresholds block(s) allowed")]
    [TerraformProperty("evaluation_metrics_thresholds")]
    public TerraformList<GoogleCesAppEvaluationMetricsThresholdsBlock> EvaluationMetricsThresholds { get; set; } = new();

    /// <summary>
    /// Block for language_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LanguageSettings block(s) allowed")]
    [TerraformProperty("language_settings")]
    public TerraformList<GoogleCesAppLanguageSettingsBlock> LanguageSettings { get; set; } = new();

    /// <summary>
    /// Block for logging_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingSettings block(s) allowed")]
    [TerraformProperty("logging_settings")]
    public TerraformList<GoogleCesAppLoggingSettingsBlock> LoggingSettings { get; set; } = new();

    /// <summary>
    /// Block for model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelSettings block(s) allowed")]
    [TerraformProperty("model_settings")]
    public TerraformList<GoogleCesAppModelSettingsBlock> ModelSettings { get; set; } = new();

    /// <summary>
    /// Block for time_zone_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeZoneSettings block(s) allowed")]
    [TerraformProperty("time_zone_settings")]
    public TerraformList<GoogleCesAppTimeZoneSettingsBlock> TimeZoneSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleCesAppTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for variable_declarations.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("variable_declarations")]
    public TerraformList<GoogleCesAppVariableDeclarationsBlock> VariableDeclarations { get; set; } = new();

    /// <summary>
    /// Timestamp when the app was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Number of deployments in the app.
    /// </summary>
    [TerraformProperty("deployment_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DeploymentCount { get; }

    /// <summary>
    /// Etag used to ensure the object hasn&#39;t changed during a read-modify-write
    /// operation. If the etag is empty, the update will overwrite any concurrent
    /// changes.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Identifier. The unique identifier of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Timestamp when the app was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
