using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_settings in GoogleDialogflowCxAgent.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentAdvancedSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_settings";

    /// <summary>
    /// AudioExportGcsDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioExportGcsDestination block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlockAudioExportGcsDestinationBlock>? AudioExportGcsDestination
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlockAudioExportGcsDestinationBlock>>("audio_export_gcs_destination");
        set => SetArgument("audio_export_gcs_destination", value);
    }

    /// <summary>
    /// DtmfSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DtmfSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlockDtmfSettingsBlock>? DtmfSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlockDtmfSettingsBlock>>("dtmf_settings");
        set => SetArgument("dtmf_settings", value);
    }

    /// <summary>
    /// LoggingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlockLoggingSettingsBlock>? LoggingSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlockLoggingSettingsBlock>>("logging_settings");
        set => SetArgument("logging_settings", value);
    }

    /// <summary>
    /// SpeechSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpeechSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlockSpeechSettingsBlock>? SpeechSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlockSpeechSettingsBlock>>("speech_settings");
        set => SetArgument("speech_settings", value);
    }

}

/// <summary>
/// Block type for audio_export_gcs_destination in GoogleDialogflowCxAgentAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentAdvancedSettingsBlockAudioExportGcsDestinationBlock : TerraformBlock
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
/// Block type for dtmf_settings in GoogleDialogflowCxAgentAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentAdvancedSettingsBlockDtmfSettingsBlock : TerraformBlock
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
/// Block type for logging_settings in GoogleDialogflowCxAgentAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentAdvancedSettingsBlockLoggingSettingsBlock : TerraformBlock
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
/// Block type for speech_settings in GoogleDialogflowCxAgentAdvancedSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentAdvancedSettingsBlockSpeechSettingsBlock : TerraformBlock
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
/// Block type for answer_feedback_settings in GoogleDialogflowCxAgent.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentAnswerFeedbackSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "answer_feedback_settings";

    /// <summary>
    /// If enabled, end users will be able to provide [answer feedback](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.sessions/submitAnswerFeedback#body.AnswerFeedback)
    /// to Dialogflow responses. Feature works only if interaction logging is enabled in the Dialogflow agent.
    /// </summary>
    public TerraformValue<bool>? EnableAnswerFeedback
    {
        get => GetArgument<TerraformValue<bool>>("enable_answer_feedback");
        set => SetArgument("enable_answer_feedback", value);
    }

}


/// <summary>
/// Block type for client_certificate_settings in GoogleDialogflowCxAgent.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentClientCertificateSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_certificate_settings";

    /// <summary>
    /// The name of the SecretManager secret version resource storing the passphrase. &#39;passphrase&#39; should be left unset if the private key is not encrypted. Format: **projects/{project}/secrets/{secret}/versions/{version}**
    /// </summary>
    public TerraformValue<string>? Passphrase
    {
        get => GetArgument<TerraformValue<string>>("passphrase");
        set => SetArgument("passphrase", value);
    }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the private key encoded in PEM format. Format: **projects/{project}/secrets/{secret}/versions/{version}**
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformValue<string> PrivateKey
    {
        get => GetArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslCertificate is required")]
    public required TerraformValue<string> SslCertificate
    {
        get => GetArgument<TerraformValue<string>>("ssl_certificate");
        set => SetArgument("ssl_certificate", value);
    }

}


/// <summary>
/// Block type for gen_app_builder_settings in GoogleDialogflowCxAgent.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentGenAppBuilderSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gen_app_builder_settings";

    /// <summary>
    /// The full name of the Gen App Builder engine related to this agent if there is one.
    /// Format: projects/{Project ID}/locations/{Location ID}/collections/{Collection ID}/engines/{Engine ID}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformValue<string> Engine
    {
        get => GetArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
    }

}


/// <summary>
/// Block type for git_integration_settings in GoogleDialogflowCxAgent.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentGitIntegrationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git_integration_settings";

    /// <summary>
    /// GithubSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentGitIntegrationSettingsBlockGithubSettingsBlock>? GithubSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentGitIntegrationSettingsBlockGithubSettingsBlock>>("github_settings");
        set => SetArgument("github_settings", value);
    }

}

/// <summary>
/// Block type for github_settings in GoogleDialogflowCxAgentGitIntegrationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentGitIntegrationSettingsBlockGithubSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_settings";

    /// <summary>
    /// The access token used to authenticate the access to the GitHub repository.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// A list of branches configured to be used from Dialogflow.
    /// </summary>
    public TerraformList<string>? Branches
    {
        get => GetArgument<TerraformList<string>>("branches");
        set => SetArgument("branches", value);
    }

    /// <summary>
    /// The unique repository display name for the GitHub repository.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The GitHub repository URI related to the agent.
    /// </summary>
    public TerraformValue<string>? RepositoryUri
    {
        get => GetArgument<TerraformValue<string>>("repository_uri");
        set => SetArgument("repository_uri", value);
    }

    /// <summary>
    /// The branch of the GitHub repository tracked for this agent.
    /// </summary>
    public TerraformValue<string>? TrackingBranch
    {
        get => GetArgument<TerraformValue<string>>("tracking_branch");
        set => SetArgument("tracking_branch", value);
    }

}


/// <summary>
/// Block type for personalization_settings in GoogleDialogflowCxAgent.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentPersonalizationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "personalization_settings";

    /// <summary>
    /// Default end user metadata, used when processing DetectIntent requests. Recommended to be filled as a template instead of hard-coded value, for example { &amp;quot;age&amp;quot;: &amp;quot;$session.params.age&amp;quot; }.
    /// The data will be merged with the [QueryParameters.end_user_metadata](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/QueryParameters#FIELDS.end_user_metadata)
    /// in [DetectIntentRequest.query_params](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.sessions/detectIntent#body.request_body.FIELDS.query_params) during query processing.
    /// 
    /// This field uses JSON data as a string. The value provided must be a valid JSON representation documented in [Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct).
    /// </summary>
    public TerraformValue<string>? DefaultEndUserMetadata
    {
        get => GetArgument<TerraformValue<string>>("default_end_user_metadata");
        set => SetArgument("default_end_user_metadata", value);
    }

}


/// <summary>
/// Block type for speech_to_text_settings in GoogleDialogflowCxAgent.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentSpeechToTextSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "speech_to_text_settings";

    /// <summary>
    /// Whether to use speech adaptation for speech recognition.
    /// </summary>
    public TerraformValue<bool>? EnableSpeechAdaptation
    {
        get => GetArgument<TerraformValue<bool>>("enable_speech_adaptation");
        set => SetArgument("enable_speech_adaptation", value);
    }

}


/// <summary>
/// Block type for text_to_speech_settings in GoogleDialogflowCxAgent.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentTextToSpeechSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text_to_speech_settings";

    /// <summary>
    /// Configuration of how speech should be synthesized, mapping from [language](https://cloud.google.com/dialogflow/cx/docs/reference/language) to [SynthesizeSpeechConfig](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents#synthesizespeechconfig).
    /// These settings affect:
    /// * The phone gateway synthesize configuration set via Agent.text_to_speech_settings.
    /// * How speech is synthesized when invoking session APIs. &#39;Agent.text_to_speech_settings&#39; only applies if &#39;OutputAudioConfig.synthesize_speech_config&#39; is not specified.
    /// </summary>
    public TerraformValue<string>? SynthesizeSpeechConfigs
    {
        get => GetArgument<TerraformValue<string>>("synthesize_speech_configs");
        set => SetArgument("synthesize_speech_configs", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxAgent.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxAgentTimeoutsBlock : TerraformBlock
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
/// Represents a google_dialogflow_cx_agent Terraform resource.
/// Manages a google_dialogflow_cx_agent resource.
/// </summary>
public partial class GoogleDialogflowCxAgent(string name) : TerraformResource("google_dialogflow_cx_agent", name)
{
    /// <summary>
    /// The URI of the agent&#39;s avatar. Avatars are used throughout the Dialogflow console and in the self-hosted Web Demo integration.
    /// </summary>
    public TerraformValue<string>? AvatarUri
    {
        get => GetArgument<TerraformValue<string>>("avatar_uri");
        set => SetArgument("avatar_uri", value);
    }

    /// <summary>
    /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLanguageCode is required")]
    public required TerraformValue<string> DefaultLanguageCode
    {
        get => GetArgument<TerraformValue<string>>("default_language_code");
        set => SetArgument("default_language_code", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, Terraform will delete the chat engine associated with the agent when the agent is destroyed.
    /// Otherwise, the chat engine will persist.
    /// 
    /// This virtual field addresses a critical dependency chain: &#39;agent&#39; -&amp;gt; &#39;engine&#39; -&amp;gt; &#39;data store&#39;. The chat engine is automatically
    /// provisioned when a data store is linked to the agent, meaning Terraform doesn&#39;t have direct control over its lifecycle as a managed
    /// resource. This creates a problem when both the agent and data store are managed by Terraform and need to be destroyed. Without
    /// delete_chat_engine_on_destroy set to true, the data store&#39;s deletion would fail because the unmanaged chat engine would still be
    /// using it. This setting ensures that the entire dependency chain can be properly torn down.
    /// See &#39;mmv1/templates/terraform/examples/dialogflowcx_tool_data_store.tf.tmpl&#39; as an example.
    /// 
    /// Data store can be linked to an agent through the &#39;knowledgeConnectorSettings&#39; field of a [flow](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.flows#resource:-flow)
    /// or a [page](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.flows.pages#resource:-page)
    /// or the &#39;dataStoreSpec&#39; field of a [tool](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.tools#resource:-tool).
    /// The ID of the implicitly created engine is stored in the &#39;genAppBuilderSettings&#39; field of the [agent](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents#resource:-agent).
    /// </summary>
    public TerraformValue<bool>? DeleteChatEngineOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("delete_chat_engine_on_destroy");
        set => SetArgument("delete_chat_engine_on_destroy", value);
    }

    /// <summary>
    /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The human-readable name of the agent, unique within the location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Enable training multi-lingual models for this agent. These models will be trained on all the languages supported by the agent.
    /// </summary>
    public TerraformValue<bool>? EnableMultiLanguageTraining
    {
        get => GetArgument<TerraformValue<bool>>("enable_multi_language_training");
        set => SetArgument("enable_multi_language_training", value);
    }

    /// <summary>
    /// Indicates if automatic spell correction is enabled in detect intent requests.
    /// </summary>
    public TerraformValue<bool>? EnableSpellCorrection
    {
        get => GetArgument<TerraformValue<bool>>("enable_spell_correction");
        set => SetArgument("enable_spell_correction", value);
    }

    /// <summary>
    /// Determines whether this agent should log conversation queries.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? EnableStackdriverLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_stackdriver_logging");
        set => SetArgument("enable_stackdriver_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the location this agent is located in.
    /// 
    /// ~&amp;gt; **Note:** The first time you are deploying an Agent in your project you must configure location settings.
    ///  This is a one time step but at the moment you can only [configure location settings](https://cloud.google.com/dialogflow/cx/docs/concept/region#location-settings) via the Dialogflow CX console.
    ///  Another options is to use global location so you don&#39;t need to manually configure location settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Indicates whether the agent is locked for changes. If the agent is locked, modifications to the agent will be rejected except for [agents.restore][].
    /// </summary>
    public TerraformValue<bool>? Locked
    {
        get => GetArgument<TerraformValue<bool>>("locked");
        set => SetArgument("locked", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Name of the SecuritySettings reference for the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? SecuritySettings
    {
        get => GetArgument<TerraformValue<string>>("security_settings");
        set => SetArgument("security_settings", value);
    }

    /// <summary>
    /// Name of the start playbook in this agent. A start playbook will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: **projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/playbooks/&amp;lt;PlaybookID&amp;gt;**. Currently only the default playbook with id &amp;quot;00000000-0000-0000-0000-000000000000&amp;quot; is allowed.
    /// </summary>
    public TerraformValue<string>? StartPlaybook
    {
        get => GetArgument<TerraformValue<string>>("start_playbook");
        set => SetArgument("start_playbook", value);
    }

    /// <summary>
    /// The list of all languages supported by this agent (except for the default_language_code).
    /// </summary>
    public TerraformList<string>? SupportedLanguageCodes
    {
        get => GetArgument<TerraformList<string>>("supported_language_codes");
        set => SetArgument("supported_language_codes", value);
    }

    /// <summary>
    /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The unique identifier of the agent.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// A read only boolean field reflecting Zone Isolation status of the agent.
    /// </summary>
    public TerraformValue<bool> SatisfiesPzi
        => AsReference("satisfies_pzi");

    /// <summary>
    /// A read only boolean field reflecting Zone Separation status of the agent.
    /// </summary>
    public TerraformValue<bool> SatisfiesPzs
        => AsReference("satisfies_pzs");

    /// <summary>
    /// Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> StartFlow
        => AsReference("start_flow");

    /// <summary>
    /// AdvancedSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlock>? AdvancedSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlock>>("advanced_settings");
        set => SetArgument("advanced_settings", value);
    }

    /// <summary>
    /// AnswerFeedbackSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnswerFeedbackSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentAnswerFeedbackSettingsBlock>? AnswerFeedbackSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentAnswerFeedbackSettingsBlock>>("answer_feedback_settings");
        set => SetArgument("answer_feedback_settings", value);
    }

    /// <summary>
    /// ClientCertificateSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificateSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentClientCertificateSettingsBlock>? ClientCertificateSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentClientCertificateSettingsBlock>>("client_certificate_settings");
        set => SetArgument("client_certificate_settings", value);
    }

    /// <summary>
    /// GenAppBuilderSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenAppBuilderSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentGenAppBuilderSettingsBlock>? GenAppBuilderSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentGenAppBuilderSettingsBlock>>("gen_app_builder_settings");
        set => SetArgument("gen_app_builder_settings", value);
    }

    /// <summary>
    /// GitIntegrationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitIntegrationSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentGitIntegrationSettingsBlock>? GitIntegrationSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentGitIntegrationSettingsBlock>>("git_integration_settings");
        set => SetArgument("git_integration_settings", value);
    }

    /// <summary>
    /// PersonalizationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersonalizationSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentPersonalizationSettingsBlock>? PersonalizationSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentPersonalizationSettingsBlock>>("personalization_settings");
        set => SetArgument("personalization_settings", value);
    }

    /// <summary>
    /// SpeechToTextSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpeechToTextSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentSpeechToTextSettingsBlock>? SpeechToTextSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentSpeechToTextSettingsBlock>>("speech_to_text_settings");
        set => SetArgument("speech_to_text_settings", value);
    }

    /// <summary>
    /// TextToSpeechSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TextToSpeechSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxAgentTextToSpeechSettingsBlock>? TextToSpeechSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxAgentTextToSpeechSettingsBlock>>("text_to_speech_settings");
        set => SetArgument("text_to_speech_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxAgentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxAgentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
