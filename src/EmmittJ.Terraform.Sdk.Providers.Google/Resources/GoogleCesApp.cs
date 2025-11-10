using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audio_processing_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppAudioProcessingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The duration of user inactivity (no speech or interaction) before the agent
    /// prompts the user for reengagement. If not set, the agent will not prompt
    /// the user for reengagement.
    /// </summary>
    public TerraformProperty<string>? InactivityTimeout
    {
        get => GetProperty<TerraformProperty<string>>("inactivity_timeout");
        set => WithProperty("inactivity_timeout", value);
    }

}

/// <summary>
/// Block type for data_store_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppDataStoreSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The engines for the app.
    /// </summary>
    public List<TerraformProperty<object>>? Engines
    {
        get => GetProperty<List<TerraformProperty<object>>>("engines");
        set => WithProperty("engines", value);
    }

}

/// <summary>
/// Block type for default_channel_profile in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppDefaultChannelProfileBlock : TerraformBlock
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
    public TerraformProperty<string>? ChannelType
    {
        get => GetProperty<TerraformProperty<string>>("channel_type");
        set => WithProperty("channel_type", value);
    }

    /// <summary>
    /// Whether to disable user barge-in in the conversation.
    /// - true: User interruptions are disabled while the agent is speaking.
    /// - false: The agent retains automatic control over when the user can interrupt.
    /// </summary>
    public TerraformProperty<bool>? DisableBargeInControl
    {
        get => GetProperty<TerraformProperty<bool>>("disable_barge_in_control");
        set => WithProperty("disable_barge_in_control", value);
    }

    /// <summary>
    /// Whether to disable DTMF (dual-tone multi-frequency).
    /// </summary>
    public TerraformProperty<bool>? DisableDtmf
    {
        get => GetProperty<TerraformProperty<bool>>("disable_dtmf");
        set => WithProperty("disable_dtmf", value);
    }

    /// <summary>
    /// The unique identifier of the channel profile.
    /// </summary>
    public TerraformProperty<string>? ProfileId
    {
        get => GetProperty<TerraformProperty<string>>("profile_id");
        set => WithProperty("profile_id", value);
    }

}

/// <summary>
/// Block type for evaluation_metrics_thresholds in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppEvaluationMetricsThresholdsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for language_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLanguageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The default language code of the app.
    /// </summary>
    public TerraformProperty<string>? DefaultLanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("default_language_code");
        set => WithProperty("default_language_code", value);
    }

    /// <summary>
    /// Enables multilingual support. If true, agents in the app will use pre-built
    /// instructions to improve handling of multilingual input.
    /// </summary>
    public TerraformProperty<bool>? EnableMultilingualSupport
    {
        get => GetProperty<TerraformProperty<bool>>("enable_multilingual_support");
        set => WithProperty("enable_multilingual_support", value);
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
    public TerraformProperty<string>? FallbackAction
    {
        get => GetProperty<TerraformProperty<string>>("fallback_action");
        set => WithProperty("fallback_action", value);
    }

    /// <summary>
    /// List of languages codes supported by the app, in addition to the
    /// &#39;default_language_code&#39;.
    /// </summary>
    public List<TerraformProperty<string>>? SupportedLanguageCodes
    {
        get => GetProperty<List<TerraformProperty<string>>>("supported_language_codes");
        set => WithProperty("supported_language_codes", value);
    }

}

/// <summary>
/// Block type for logging_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppLoggingSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for model_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppModelSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The LLM model that the agent should use.
    /// If not set, the agent will inherit the model from its parent agent.
    /// </summary>
    public TerraformProperty<string>? Model
    {
        get => GetProperty<TerraformProperty<string>>("model");
        set => WithProperty("model", value);
    }

    /// <summary>
    /// If set, this temperature will be used for the LLM model. Temperature
    /// controls the randomness of the model&#39;s responses. Lower temperatures
    /// produce responses that are more predictable. Higher temperatures produce
    /// responses that are more creative.
    /// </summary>
    public TerraformProperty<double>? Temperature
    {
        get => GetProperty<TerraformProperty<double>>("temperature");
        set => WithProperty("temperature", value);
    }

}

/// <summary>
/// Block type for time_zone_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppTimeZoneSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The time zone of the app from the time zone database, e.g., America/Los_Angeles, Europe/Paris.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => WithProperty("time_zone", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCesAppTimeoutsBlock : TerraformBlock
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
/// Block type for variable_declarations in .
/// Nesting mode: list
/// </summary>
public class GoogleCesAppVariableDeclarationsBlock : TerraformBlock
{
    /// <summary>
    /// The description of the variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The name of the variable. The name must start with a letter or underscore
    /// and contain only letters, numbers, or underscores.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Manages a google_ces_app resource.
/// </summary>
public class GoogleCesApp : TerraformResource
{
    public GoogleCesApp(string name) : base("google_ces_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("deployment_count");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The ID to use for the app, which will become the final component of
    /// the app&#39;s resource name. If not provided, a unique ID will be
    /// automatically assigned for the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformProperty<string> AppId
    {
        get => GetProperty<TerraformProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
    }

    /// <summary>
    /// Human-readable description of the app.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Display name of the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Instructions for all the agents in the app.
    /// You can use this instruction to set up a stable identity or personality
    /// across all the agents.
    /// </summary>
    public TerraformProperty<string>? GlobalInstruction
    {
        get => GetProperty<TerraformProperty<string>>("global_instruction");
        set => this.WithProperty("global_instruction", value);
    }

    /// <summary>
    /// List of guardrails for the app.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}&#39;
    /// </summary>
    public List<TerraformProperty<string>>? Guardrails
    {
        get => GetProperty<List<TerraformProperty<string>>>("guardrails");
        set => this.WithProperty("guardrails", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Metadata about the app. This field can be used to store additional
    /// information relevant to the app&#39;s details or intended usages.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
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
    /// The root agent is the entry point of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}/agents/{agent}&#39;
    /// </summary>
    public TerraformProperty<string>? RootAgent
    {
        get => GetProperty<TerraformProperty<string>>("root_agent");
        set => this.WithProperty("root_agent", value);
    }

    /// <summary>
    /// Block for audio_processing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioProcessingConfig block(s) allowed")]
    public List<GoogleCesAppAudioProcessingConfigBlock>? AudioProcessingConfig
    {
        get => GetProperty<List<GoogleCesAppAudioProcessingConfigBlock>>("audio_processing_config");
        set => this.WithProperty("audio_processing_config", value);
    }

    /// <summary>
    /// Block for data_store_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataStoreSettings block(s) allowed")]
    public List<GoogleCesAppDataStoreSettingsBlock>? DataStoreSettings
    {
        get => GetProperty<List<GoogleCesAppDataStoreSettingsBlock>>("data_store_settings");
        set => this.WithProperty("data_store_settings", value);
    }

    /// <summary>
    /// Block for default_channel_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultChannelProfile block(s) allowed")]
    public List<GoogleCesAppDefaultChannelProfileBlock>? DefaultChannelProfile
    {
        get => GetProperty<List<GoogleCesAppDefaultChannelProfileBlock>>("default_channel_profile");
        set => this.WithProperty("default_channel_profile", value);
    }

    /// <summary>
    /// Block for evaluation_metrics_thresholds.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EvaluationMetricsThresholds block(s) allowed")]
    public List<GoogleCesAppEvaluationMetricsThresholdsBlock>? EvaluationMetricsThresholds
    {
        get => GetProperty<List<GoogleCesAppEvaluationMetricsThresholdsBlock>>("evaluation_metrics_thresholds");
        set => this.WithProperty("evaluation_metrics_thresholds", value);
    }

    /// <summary>
    /// Block for language_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LanguageSettings block(s) allowed")]
    public List<GoogleCesAppLanguageSettingsBlock>? LanguageSettings
    {
        get => GetProperty<List<GoogleCesAppLanguageSettingsBlock>>("language_settings");
        set => this.WithProperty("language_settings", value);
    }

    /// <summary>
    /// Block for logging_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingSettings block(s) allowed")]
    public List<GoogleCesAppLoggingSettingsBlock>? LoggingSettings
    {
        get => GetProperty<List<GoogleCesAppLoggingSettingsBlock>>("logging_settings");
        set => this.WithProperty("logging_settings", value);
    }

    /// <summary>
    /// Block for model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelSettings block(s) allowed")]
    public List<GoogleCesAppModelSettingsBlock>? ModelSettings
    {
        get => GetProperty<List<GoogleCesAppModelSettingsBlock>>("model_settings");
        set => this.WithProperty("model_settings", value);
    }

    /// <summary>
    /// Block for time_zone_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeZoneSettings block(s) allowed")]
    public List<GoogleCesAppTimeZoneSettingsBlock>? TimeZoneSettings
    {
        get => GetProperty<List<GoogleCesAppTimeZoneSettingsBlock>>("time_zone_settings");
        set => this.WithProperty("time_zone_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCesAppTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCesAppTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for variable_declarations.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleCesAppVariableDeclarationsBlock>? VariableDeclarations
    {
        get => GetProperty<List<GoogleCesAppVariableDeclarationsBlock>>("variable_declarations");
        set => this.WithProperty("variable_declarations", value);
    }

    /// <summary>
    /// Timestamp when the app was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Number of deployments in the app.
    /// </summary>
    public TerraformExpression DeploymentCount => this["deployment_count"];

    /// <summary>
    /// Etag used to ensure the object hasn&#39;t changed during a read-modify-write
    /// operation. If the etag is empty, the update will overwrite any concurrent
    /// changes.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Identifier. The unique identifier of the app.
    /// Format: &#39;projects/{project}/locations/{location}/apps/{app}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Timestamp when the app was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
