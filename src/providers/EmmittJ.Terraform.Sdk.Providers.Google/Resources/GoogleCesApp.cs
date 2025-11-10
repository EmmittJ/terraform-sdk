using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audio_processing_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppAudioProcessingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The duration of user inactivity (no speech or interaction) before the agent
    /// prompts the user for reengagement. If not set, the agent will not prompt
    /// the user for reengagement.
    /// </summary>
    [TerraformPropertyName("inactivity_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InactivityTimeout { get; set; }

}

/// <summary>
/// Block type for data_store_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppDataStoreSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The engines for the app.
    /// </summary>
    [TerraformPropertyName("engines")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Engines => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "engines");

}

/// <summary>
/// Block type for default_channel_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppDefaultChannelProfileBlock : ITerraformBlock
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
    [TerraformPropertyName("channel_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ChannelType { get; set; }

    /// <summary>
    /// Whether to disable user barge-in in the conversation.
    /// - true: User interruptions are disabled while the agent is speaking.
    /// - false: The agent retains automatic control over when the user can interrupt.
    /// </summary>
    [TerraformPropertyName("disable_barge_in_control")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableBargeInControl { get; set; }

    /// <summary>
    /// Whether to disable DTMF (dual-tone multi-frequency).
    /// </summary>
    [TerraformPropertyName("disable_dtmf")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableDtmf { get; set; }

    /// <summary>
    /// The unique identifier of the channel profile.
    /// </summary>
    [TerraformPropertyName("profile_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProfileId { get; set; }

}

/// <summary>
/// Block type for evaluation_metrics_thresholds in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppEvaluationMetricsThresholdsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for language_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLanguageSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The default language code of the app.
    /// </summary>
    [TerraformPropertyName("default_language_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultLanguageCode { get; set; }

    /// <summary>
    /// Enables multilingual support. If true, agents in the app will use pre-built
    /// instructions to improve handling of multilingual input.
    /// </summary>
    [TerraformPropertyName("enable_multilingual_support")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableMultilingualSupport { get; set; }

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
    [TerraformPropertyName("fallback_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FallbackAction { get; set; }

    /// <summary>
    /// List of languages codes supported by the app, in addition to the
    /// &#39;default_language_code&#39;.
    /// </summary>
    [TerraformPropertyName("supported_language_codes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SupportedLanguageCodes { get; set; }

}

/// <summary>
/// Block type for logging_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLoggingSettingsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for model_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppModelSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The LLM model that the agent should use.
    /// If not set, the agent will inherit the model from its parent agent.
    /// </summary>
    [TerraformPropertyName("model")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Model { get; set; }

    /// <summary>
    /// If set, this temperature will be used for the LLM model. Temperature
    /// controls the randomness of the model&#39;s responses. Lower temperatures
    /// produce responses that are more predictable. Higher temperatures produce
    /// responses that are more creative.
    /// </summary>
    [TerraformPropertyName("temperature")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Temperature { get; set; }

}

/// <summary>
/// Block type for time_zone_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppTimeZoneSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The time zone of the app from the time zone database, e.g., America/Los_Angeles, Europe/Paris.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimeZone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCesAppTimeoutsBlock : ITerraformBlock
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
/// Block type for variable_declarations in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppVariableDeclarationsBlock : ITerraformBlock
{
    /// <summary>
    /// The description of the variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Description { get; set; }

    /// <summary>
    /// The name of the variable. The name must start with a letter or underscore
    /// and contain only letters, numbers, or underscores.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Manages a google_ces_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCesApp : TerraformResource
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
    [TerraformPropertyName("app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppId { get; set; }

    /// <summary>
    /// Human-readable description of the app.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Display name of the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Instructions for all the agents in the app.
    /// You can use this instruction to set up a stable identity or personality
    /// across all the agents.
    /// </summary>
    [TerraformPropertyName("global_instruction")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GlobalInstruction { get; set; }

    /// <summary>
    /// List of guardrails for the app.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}&#39;
    /// </summary>
    [TerraformPropertyName("guardrails")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Guardrails { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Metadata about the app. This field can be used to store additional
    /// information relevant to the app&#39;s details or intended usages.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Metadata { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The root agent is the entry point of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}/agents/{agent}&#39;
    /// </summary>
    [TerraformPropertyName("root_agent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RootAgent { get; set; }

    /// <summary>
    /// Block for audio_processing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioProcessingConfig block(s) allowed")]
    [TerraformPropertyName("audio_processing_config")]
    public TerraformList<TerraformBlock<GoogleCesAppAudioProcessingConfigBlock>>? AudioProcessingConfig { get; set; } = new();

    /// <summary>
    /// Block for data_store_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataStoreSettings block(s) allowed")]
    [TerraformPropertyName("data_store_settings")]
    public TerraformList<TerraformBlock<GoogleCesAppDataStoreSettingsBlock>>? DataStoreSettings { get; set; } = new();

    /// <summary>
    /// Block for default_channel_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultChannelProfile block(s) allowed")]
    [TerraformPropertyName("default_channel_profile")]
    public TerraformList<TerraformBlock<GoogleCesAppDefaultChannelProfileBlock>>? DefaultChannelProfile { get; set; } = new();

    /// <summary>
    /// Block for evaluation_metrics_thresholds.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvaluationMetricsThresholds block(s) allowed")]
    [TerraformPropertyName("evaluation_metrics_thresholds")]
    public TerraformList<TerraformBlock<GoogleCesAppEvaluationMetricsThresholdsBlock>>? EvaluationMetricsThresholds { get; set; } = new();

    /// <summary>
    /// Block for language_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LanguageSettings block(s) allowed")]
    [TerraformPropertyName("language_settings")]
    public TerraformList<TerraformBlock<GoogleCesAppLanguageSettingsBlock>>? LanguageSettings { get; set; } = new();

    /// <summary>
    /// Block for logging_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingSettings block(s) allowed")]
    [TerraformPropertyName("logging_settings")]
    public TerraformList<TerraformBlock<GoogleCesAppLoggingSettingsBlock>>? LoggingSettings { get; set; } = new();

    /// <summary>
    /// Block for model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelSettings block(s) allowed")]
    [TerraformPropertyName("model_settings")]
    public TerraformList<TerraformBlock<GoogleCesAppModelSettingsBlock>>? ModelSettings { get; set; } = new();

    /// <summary>
    /// Block for time_zone_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeZoneSettings block(s) allowed")]
    [TerraformPropertyName("time_zone_settings")]
    public TerraformList<TerraformBlock<GoogleCesAppTimeZoneSettingsBlock>>? TimeZoneSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCesAppTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for variable_declarations.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("variable_declarations")]
    public TerraformList<TerraformBlock<GoogleCesAppVariableDeclarationsBlock>>? VariableDeclarations { get; set; } = new();

    /// <summary>
    /// Timestamp when the app was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Number of deployments in the app.
    /// </summary>
    [TerraformPropertyName("deployment_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DeploymentCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "deployment_count");

    /// <summary>
    /// Etag used to ensure the object hasn&#39;t changed during a read-modify-write
    /// operation. If the etag is empty, the update will overwrite any concurrent
    /// changes.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Identifier. The unique identifier of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Timestamp when the app was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
