using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dialogflow_cx_agent resource.
/// </summary>
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
    public string? AvatarUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("avatar_uri")?.Value;
        set => this.WithProperty("avatar_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    public string? DefaultLanguageCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_language_code")?.Value;
        set => this.WithProperty("default_language_code", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public bool? DeleteChatEngineOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_chat_engine_on_destroy")?.Value;
        set => this.WithProperty("delete_chat_engine_on_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The human-readable name of the agent, unique within the location.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Enable training multi-lingual models for this agent. These models will be trained on all the languages supported by the agent.
    /// </summary>
    public bool? EnableMultiLanguageTraining
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_multi_language_training")?.Value;
        set => this.WithProperty("enable_multi_language_training", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Indicates if automatic spell correction is enabled in detect intent requests.
    /// </summary>
    public bool? EnableSpellCorrection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_spell_correction")?.Value;
        set => this.WithProperty("enable_spell_correction", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Determines whether this agent should log conversation queries.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? EnableStackdriverLogging
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_stackdriver_logging")?.Value;
        set => this.WithProperty("enable_stackdriver_logging", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the location this agent is located in.
    /// 
    /// ~&amp;gt; **Note:** The first time you are deploying an Agent in your project you must configure location settings.
    ///  This is a one time step but at the moment you can only [configure location settings](https://cloud.google.com/dialogflow/cx/docs/concept/region#location-settings) via the Dialogflow CX console.
    ///  Another options is to use global location so you don&#39;t need to manually configure location settings.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Indicates whether the agent is locked for changes. If the agent is locked, modifications to the agent will be rejected except for [agents.restore][].
    /// </summary>
    public bool? Locked
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("locked")?.Value;
        set => this.WithProperty("locked", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the SecuritySettings reference for the agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/securitySettings/&amp;lt;Security Settings ID&amp;gt;.
    /// </summary>
    public string? SecuritySettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_settings")?.Value;
        set => this.WithProperty("security_settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the start playbook in this agent. A start playbook will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: **projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/playbooks/&amp;lt;PlaybookID&amp;gt;**. Currently only the default playbook with id &amp;quot;00000000-0000-0000-0000-000000000000&amp;quot; is allowed.
    /// </summary>
    public string? StartPlaybook
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_playbook")?.Value;
        set => this.WithProperty("start_playbook", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of all languages supported by this agent (except for the default_language_code).
    /// </summary>
    public List<string>? SupportedLanguageCodes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("supported_language_codes")?.Value;
        set => this.WithProperty("supported_language_codes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    public string? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone")?.Value;
        set => this.WithProperty("time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
