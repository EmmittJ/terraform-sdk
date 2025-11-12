using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxAgentAdvancedSettingsBlock() : TerraformBlock("advanced_settings")
{
}

/// <summary>
/// Block type for answer_feedback_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxAgentAnswerFeedbackSettingsBlock() : TerraformBlock("answer_feedback_settings")
{
    /// <summary>
    /// If enabled, end users will be able to provide [answer feedback](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.sessions/submitAnswerFeedback#body.AnswerFeedback)
    /// to Dialogflow responses. Feature works only if interaction logging is enabled in the Dialogflow agent.
    /// </summary>
    [TerraformProperty("enable_answer_feedback")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableAnswerFeedback { get; set; }

}

/// <summary>
/// Block type for client_certificate_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxAgentClientCertificateSettingsBlock() : TerraformBlock("client_certificate_settings")
{
    /// <summary>
    /// The name of the SecretManager secret version resource storing the passphrase. &#39;passphrase&#39; should be left unset if the private key is not encrypted. Format: **projects/{project}/secrets/{secret}/versions/{version}**
    /// </summary>
    [TerraformProperty("passphrase")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Passphrase { get; set; }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the private key encoded in PEM format. Format: **projects/{project}/secrets/{secret}/versions/{version}**
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    [TerraformProperty("private_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateKey { get; set; }

    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslCertificate is required")]
    [TerraformProperty("ssl_certificate")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SslCertificate { get; set; }

}

/// <summary>
/// Block type for gen_app_builder_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxAgentGenAppBuilderSettingsBlock() : TerraformBlock("gen_app_builder_settings")
{
    /// <summary>
    /// The full name of the Gen App Builder engine related to this agent if there is one.
    /// Format: projects/{Project ID}/locations/{Location ID}/collections/{Collection ID}/engines/{Engine ID}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformProperty("engine")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Engine { get; set; }

}

/// <summary>
/// Block type for git_integration_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxAgentGitIntegrationSettingsBlock() : TerraformBlock("git_integration_settings")
{
}

/// <summary>
/// Block type for personalization_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxAgentPersonalizationSettingsBlock() : TerraformBlock("personalization_settings")
{
    /// <summary>
    /// Default end user metadata, used when processing DetectIntent requests. Recommended to be filled as a template instead of hard-coded value, for example { &amp;quot;age&amp;quot;: &amp;quot;$session.params.age&amp;quot; }.
    /// The data will be merged with the [QueryParameters.end_user_metadata](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/QueryParameters#FIELDS.end_user_metadata)
    /// in [DetectIntentRequest.query_params](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.sessions/detectIntent#body.request_body.FIELDS.query_params) during query processing.
    /// 
    /// This field uses JSON data as a string. The value provided must be a valid JSON representation documented in [Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct).
    /// </summary>
    [TerraformProperty("default_end_user_metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultEndUserMetadata { get; set; }

}

/// <summary>
/// Block type for speech_to_text_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxAgentSpeechToTextSettingsBlock() : TerraformBlock("speech_to_text_settings")
{
    /// <summary>
    /// Whether to use speech adaptation for speech recognition.
    /// </summary>
    [TerraformProperty("enable_speech_adaptation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableSpeechAdaptation { get; set; }

}

/// <summary>
/// Block type for text_to_speech_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxAgentTextToSpeechSettingsBlock() : TerraformBlock("text_to_speech_settings")
{
    /// <summary>
    /// Configuration of how speech should be synthesized, mapping from [language](https://cloud.google.com/dialogflow/cx/docs/reference/language) to [SynthesizeSpeechConfig](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents#synthesizespeechconfig).
    /// These settings affect:
    /// * The phone gateway synthesize configuration set via Agent.text_to_speech_settings.
    /// * How speech is synthesized when invoking session APIs. &#39;Agent.text_to_speech_settings&#39; only applies if &#39;OutputAudioConfig.synthesize_speech_config&#39; is not specified.
    /// </summary>
    [TerraformProperty("synthesize_speech_configs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SynthesizeSpeechConfigs { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowCxAgentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_dialogflow_cx_agent resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowCxAgent : TerraformResource
{
    public GoogleDialogflowCxAgent(string name) : base("google_dialogflow_cx_agent", name)
    {
    }

    /// <summary>
    /// The URI of the agent&#39;s avatar. Avatars are used throughout the Dialogflow console and in the self-hosted Web Demo integration.
    /// </summary>
    [TerraformProperty("avatar_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AvatarUri { get; set; }

    /// <summary>
    /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLanguageCode is required")]
    [TerraformProperty("default_language_code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultLanguageCode { get; set; }

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
    [TerraformProperty("delete_chat_engine_on_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteChatEngineOnDestroy { get; set; }

    /// <summary>
    /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The human-readable name of the agent, unique within the location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Enable training multi-lingual models for this agent. These models will be trained on all the languages supported by the agent.
    /// </summary>
    [TerraformProperty("enable_multi_language_training")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableMultiLanguageTraining { get; set; }

    /// <summary>
    /// Indicates if automatic spell correction is enabled in detect intent requests.
    /// </summary>
    [TerraformProperty("enable_spell_correction")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableSpellCorrection { get; set; }

    /// <summary>
    /// Determines whether this agent should log conversation queries.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_stackdriver_logging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableStackdriverLogging { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the location this agent is located in.
    /// 
    /// ~&amp;gt; **Note:** The first time you are deploying an Agent in your project you must configure location settings.
    ///  This is a one time step but at the moment you can only [configure location settings](https://cloud.google.com/dialogflow/cx/docs/concept/region#location-settings) via the Dialogflow CX console.
    ///  Another options is to use global location so you don&#39;t need to manually configure location settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Indicates whether the agent is locked for changes. If the agent is locked, modifications to the agent will be rejected except for [agents.restore][].
    /// </summary>
    [TerraformProperty("locked")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Locked { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Name of the SecuritySettings reference for the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    [TerraformProperty("security_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecuritySettings { get; set; }

    /// <summary>
    /// Name of the start playbook in this agent. A start playbook will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: **projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/playbooks/&amp;lt;PlaybookID&amp;gt;**. Currently only the default playbook with id &amp;quot;00000000-0000-0000-0000-000000000000&amp;quot; is allowed.
    /// </summary>
    [TerraformProperty("start_playbook")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartPlaybook { get; set; }

    /// <summary>
    /// The list of all languages supported by this agent (except for the default_language_code).
    /// </summary>
    [TerraformProperty("supported_language_codes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SupportedLanguageCodes { get; set; }

    /// <summary>
    /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformProperty("time_zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeZone { get; set; }

    /// <summary>
    /// Block for advanced_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    [TerraformProperty("advanced_settings")]
    public TerraformList<GoogleDialogflowCxAgentAdvancedSettingsBlock> AdvancedSettings { get; set; } = new();

    /// <summary>
    /// Block for answer_feedback_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnswerFeedbackSettings block(s) allowed")]
    [TerraformProperty("answer_feedback_settings")]
    public TerraformList<GoogleDialogflowCxAgentAnswerFeedbackSettingsBlock> AnswerFeedbackSettings { get; set; } = new();

    /// <summary>
    /// Block for client_certificate_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificateSettings block(s) allowed")]
    [TerraformProperty("client_certificate_settings")]
    public TerraformList<GoogleDialogflowCxAgentClientCertificateSettingsBlock> ClientCertificateSettings { get; set; } = new();

    /// <summary>
    /// Block for gen_app_builder_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenAppBuilderSettings block(s) allowed")]
    [TerraformProperty("gen_app_builder_settings")]
    public TerraformList<GoogleDialogflowCxAgentGenAppBuilderSettingsBlock> GenAppBuilderSettings { get; set; } = new();

    /// <summary>
    /// Block for git_integration_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitIntegrationSettings block(s) allowed")]
    [TerraformProperty("git_integration_settings")]
    public TerraformList<GoogleDialogflowCxAgentGitIntegrationSettingsBlock> GitIntegrationSettings { get; set; } = new();

    /// <summary>
    /// Block for personalization_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersonalizationSettings block(s) allowed")]
    [TerraformProperty("personalization_settings")]
    public TerraformList<GoogleDialogflowCxAgentPersonalizationSettingsBlock> PersonalizationSettings { get; set; } = new();

    /// <summary>
    /// Block for speech_to_text_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpeechToTextSettings block(s) allowed")]
    [TerraformProperty("speech_to_text_settings")]
    public TerraformList<GoogleDialogflowCxAgentSpeechToTextSettingsBlock> SpeechToTextSettings { get; set; } = new();

    /// <summary>
    /// Block for text_to_speech_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TextToSpeechSettings block(s) allowed")]
    [TerraformProperty("text_to_speech_settings")]
    public TerraformList<GoogleDialogflowCxAgentTextToSpeechSettingsBlock> TextToSpeechSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDialogflowCxAgentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The unique identifier of the agent.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// A read only boolean field reflecting Zone Isolation status of the agent.
    /// </summary>
    [TerraformProperty("satisfies_pzi")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SatisfiesPzi { get; }

    /// <summary>
    /// A read only boolean field reflecting Zone Separation status of the agent.
    /// </summary>
    [TerraformProperty("satisfies_pzs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SatisfiesPzs { get; }

    /// <summary>
    /// Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    [TerraformProperty("start_flow")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartFlow { get; }

}
