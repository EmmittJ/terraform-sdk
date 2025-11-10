using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentAdvancedSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for answer_feedback_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentAnswerFeedbackSettingsBlock : TerraformBlock
{
    /// <summary>
    /// If enabled, end users will be able to provide [answer feedback](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.sessions/submitAnswerFeedback#body.AnswerFeedback)
    /// to Dialogflow responses. Feature works only if interaction logging is enabled in the Dialogflow agent.
    /// </summary>
    public TerraformProperty<bool>? EnableAnswerFeedback
    {
        get => GetProperty<TerraformProperty<bool>>("enable_answer_feedback");
        set => WithProperty("enable_answer_feedback", value);
    }

}

/// <summary>
/// Block type for client_certificate_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentClientCertificateSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The name of the SecretManager secret version resource storing the passphrase. &#39;passphrase&#39; should be left unset if the private key is not encrypted. Format: **projects/{project}/secrets/{secret}/versions/{version}**
    /// </summary>
    public TerraformProperty<string>? Passphrase
    {
        get => GetProperty<TerraformProperty<string>>("passphrase");
        set => WithProperty("passphrase", value);
    }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the private key encoded in PEM format. Format: **projects/{project}/secrets/{secret}/versions/{version}**
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformProperty<string> PrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("private_key");
        set => WithProperty("private_key", value);
    }

    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslCertificate is required")]
    public required TerraformProperty<string> SslCertificate
    {
        get => GetProperty<TerraformProperty<string>>("ssl_certificate");
        set => WithProperty("ssl_certificate", value);
    }

}

/// <summary>
/// Block type for gen_app_builder_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentGenAppBuilderSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The full name of the Gen App Builder engine related to this agent if there is one.
    /// Format: projects/{Project ID}/locations/{Location ID}/collections/{Collection ID}/engines/{Engine ID}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformProperty<string> Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => WithProperty("engine", value);
    }

}

/// <summary>
/// Block type for git_integration_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentGitIntegrationSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for personalization_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentPersonalizationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Default end user metadata, used when processing DetectIntent requests. Recommended to be filled as a template instead of hard-coded value, for example { &amp;quot;age&amp;quot;: &amp;quot;$session.params.age&amp;quot; }.
    /// The data will be merged with the [QueryParameters.end_user_metadata](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/QueryParameters#FIELDS.end_user_metadata)
    /// in [DetectIntentRequest.query_params](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.sessions/detectIntent#body.request_body.FIELDS.query_params) during query processing.
    /// 
    /// This field uses JSON data as a string. The value provided must be a valid JSON representation documented in [Struct](https://protobuf.dev/reference/protobuf/google.protobuf/#struct).
    /// </summary>
    public TerraformProperty<string>? DefaultEndUserMetadata
    {
        get => GetProperty<TerraformProperty<string>>("default_end_user_metadata");
        set => WithProperty("default_end_user_metadata", value);
    }

}

/// <summary>
/// Block type for speech_to_text_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentSpeechToTextSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Whether to use speech adaptation for speech recognition.
    /// </summary>
    public TerraformProperty<bool>? EnableSpeechAdaptation
    {
        get => GetProperty<TerraformProperty<bool>>("enable_speech_adaptation");
        set => WithProperty("enable_speech_adaptation", value);
    }

}

/// <summary>
/// Block type for text_to_speech_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxAgentTextToSpeechSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Configuration of how speech should be synthesized, mapping from [language](https://cloud.google.com/dialogflow/cx/docs/reference/language) to [SynthesizeSpeechConfig](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents#synthesizespeechconfig).
    /// These settings affect:
    /// * The phone gateway synthesize configuration set via Agent.text_to_speech_settings.
    /// * How speech is synthesized when invoking session APIs. &#39;Agent.text_to_speech_settings&#39; only applies if &#39;OutputAudioConfig.synthesize_speech_config&#39; is not specified.
    /// </summary>
    public TerraformProperty<string>? SynthesizeSpeechConfigs
    {
        get => GetProperty<TerraformProperty<string>>("synthesize_speech_configs");
        set => WithProperty("synthesize_speech_configs", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxAgentTimeoutsBlock : TerraformBlock
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
/// Manages a google_dialogflow_cx_agent resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxAgent : TerraformResource
{
    public GoogleDialogflowCxAgent(string name) : base("google_dialogflow_cx_agent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("satisfies_pzi");
        this.DeclareOutput("satisfies_pzs");
        this.DeclareOutput("start_flow");
    }

    /// <summary>
    /// The URI of the agent&#39;s avatar. Avatars are used throughout the Dialogflow console and in the self-hosted Web Demo integration.
    /// </summary>
    public TerraformProperty<string>? AvatarUri
    {
        get => GetProperty<TerraformProperty<string>>("avatar_uri");
        set => this.WithProperty("avatar_uri", value);
    }

    /// <summary>
    /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLanguageCode is required")]
    public required TerraformProperty<string> DefaultLanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("default_language_code");
        set => this.WithProperty("default_language_code", value);
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
    public TerraformProperty<bool>? DeleteChatEngineOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("delete_chat_engine_on_destroy");
        set => this.WithProperty("delete_chat_engine_on_destroy", value);
    }

    /// <summary>
    /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The human-readable name of the agent, unique within the location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Enable training multi-lingual models for this agent. These models will be trained on all the languages supported by the agent.
    /// </summary>
    public TerraformProperty<bool>? EnableMultiLanguageTraining
    {
        get => GetProperty<TerraformProperty<bool>>("enable_multi_language_training");
        set => this.WithProperty("enable_multi_language_training", value);
    }

    /// <summary>
    /// Indicates if automatic spell correction is enabled in detect intent requests.
    /// </summary>
    public TerraformProperty<bool>? EnableSpellCorrection
    {
        get => GetProperty<TerraformProperty<bool>>("enable_spell_correction");
        set => this.WithProperty("enable_spell_correction", value);
    }

    /// <summary>
    /// Determines whether this agent should log conversation queries.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableStackdriverLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_stackdriver_logging");
        set => this.WithProperty("enable_stackdriver_logging", value);
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
    /// The name of the location this agent is located in.
    /// 
    /// ~&amp;gt; **Note:** The first time you are deploying an Agent in your project you must configure location settings.
    ///  This is a one time step but at the moment you can only [configure location settings](https://cloud.google.com/dialogflow/cx/docs/concept/region#location-settings) via the Dialogflow CX console.
    ///  Another options is to use global location so you don&#39;t need to manually configure location settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Indicates whether the agent is locked for changes. If the agent is locked, modifications to the agent will be rejected except for [agents.restore][].
    /// </summary>
    public TerraformProperty<bool>? Locked
    {
        get => GetProperty<TerraformProperty<bool>>("locked");
        set => this.WithProperty("locked", value);
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
    /// Name of the SecuritySettings reference for the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? SecuritySettings
    {
        get => GetProperty<TerraformProperty<string>>("security_settings");
        set => this.WithProperty("security_settings", value);
    }

    /// <summary>
    /// Name of the start playbook in this agent. A start playbook will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: **projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/playbooks/&amp;lt;PlaybookID&amp;gt;**. Currently only the default playbook with id &amp;quot;00000000-0000-0000-0000-000000000000&amp;quot; is allowed.
    /// </summary>
    public TerraformProperty<string>? StartPlaybook
    {
        get => GetProperty<TerraformProperty<string>>("start_playbook");
        set => this.WithProperty("start_playbook", value);
    }

    /// <summary>
    /// The list of all languages supported by this agent (except for the default_language_code).
    /// </summary>
    public List<TerraformProperty<string>>? SupportedLanguageCodes
    {
        get => GetProperty<List<TerraformProperty<string>>>("supported_language_codes");
        set => this.WithProperty("supported_language_codes", value);
    }

    /// <summary>
    /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// Block for advanced_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSettings block(s) allowed")]
    public List<GoogleDialogflowCxAgentAdvancedSettingsBlock>? AdvancedSettings
    {
        get => GetProperty<List<GoogleDialogflowCxAgentAdvancedSettingsBlock>>("advanced_settings");
        set => this.WithProperty("advanced_settings", value);
    }

    /// <summary>
    /// Block for answer_feedback_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnswerFeedbackSettings block(s) allowed")]
    public List<GoogleDialogflowCxAgentAnswerFeedbackSettingsBlock>? AnswerFeedbackSettings
    {
        get => GetProperty<List<GoogleDialogflowCxAgentAnswerFeedbackSettingsBlock>>("answer_feedback_settings");
        set => this.WithProperty("answer_feedback_settings", value);
    }

    /// <summary>
    /// Block for client_certificate_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificateSettings block(s) allowed")]
    public List<GoogleDialogflowCxAgentClientCertificateSettingsBlock>? ClientCertificateSettings
    {
        get => GetProperty<List<GoogleDialogflowCxAgentClientCertificateSettingsBlock>>("client_certificate_settings");
        set => this.WithProperty("client_certificate_settings", value);
    }

    /// <summary>
    /// Block for gen_app_builder_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenAppBuilderSettings block(s) allowed")]
    public List<GoogleDialogflowCxAgentGenAppBuilderSettingsBlock>? GenAppBuilderSettings
    {
        get => GetProperty<List<GoogleDialogflowCxAgentGenAppBuilderSettingsBlock>>("gen_app_builder_settings");
        set => this.WithProperty("gen_app_builder_settings", value);
    }

    /// <summary>
    /// Block for git_integration_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitIntegrationSettings block(s) allowed")]
    public List<GoogleDialogflowCxAgentGitIntegrationSettingsBlock>? GitIntegrationSettings
    {
        get => GetProperty<List<GoogleDialogflowCxAgentGitIntegrationSettingsBlock>>("git_integration_settings");
        set => this.WithProperty("git_integration_settings", value);
    }

    /// <summary>
    /// Block for personalization_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersonalizationSettings block(s) allowed")]
    public List<GoogleDialogflowCxAgentPersonalizationSettingsBlock>? PersonalizationSettings
    {
        get => GetProperty<List<GoogleDialogflowCxAgentPersonalizationSettingsBlock>>("personalization_settings");
        set => this.WithProperty("personalization_settings", value);
    }

    /// <summary>
    /// Block for speech_to_text_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpeechToTextSettings block(s) allowed")]
    public List<GoogleDialogflowCxAgentSpeechToTextSettingsBlock>? SpeechToTextSettings
    {
        get => GetProperty<List<GoogleDialogflowCxAgentSpeechToTextSettingsBlock>>("speech_to_text_settings");
        set => this.WithProperty("speech_to_text_settings", value);
    }

    /// <summary>
    /// Block for text_to_speech_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TextToSpeechSettings block(s) allowed")]
    public List<GoogleDialogflowCxAgentTextToSpeechSettingsBlock>? TextToSpeechSettings
    {
        get => GetProperty<List<GoogleDialogflowCxAgentTextToSpeechSettingsBlock>>("text_to_speech_settings");
        set => this.WithProperty("text_to_speech_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxAgentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowCxAgentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The unique identifier of the agent.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// A read only boolean field reflecting Zone Isolation status of the agent.
    /// </summary>
    public TerraformExpression SatisfiesPzi => this["satisfies_pzi"];

    /// <summary>
    /// A read only boolean field reflecting Zone Separation status of the agent.
    /// </summary>
    public TerraformExpression SatisfiesPzs => this["satisfies_pzs"];

    /// <summary>
    /// Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// </summary>
    public TerraformExpression StartFlow => this["start_flow"];

}
