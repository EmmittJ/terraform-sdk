using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fallback_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Display name of the selected prompt.
    /// </summary>
    public TerraformProperty<string>? SelectedPrompt
    {
        get => GetProperty<TerraformProperty<string>>("selected_prompt");
        set => WithProperty("selected_prompt", value);
    }

}

/// <summary>
/// Block type for generative_safety_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Default phrase match strategy for banned phrases.
    /// See [PhraseMatchStrategy](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/GenerativeSettings#phrasematchstrategy) for valid values.
    /// </summary>
    public TerraformProperty<string>? DefaultBannedPhraseMatchStrategy
    {
        get => GetProperty<TerraformProperty<string>>("default_banned_phrase_match_strategy");
        set => WithProperty("default_banned_phrase_match_strategy", value);
    }

}

/// <summary>
/// Block type for knowledge_connector_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Name of the virtual agent. Used for LLM prompt. Can be left empty.
    /// </summary>
    public TerraformProperty<string>? Agent
    {
        get => GetProperty<TerraformProperty<string>>("agent");
        set => WithProperty("agent", value);
    }

    /// <summary>
    /// Identity of the agent, e.g. &amp;quot;virtual agent&amp;quot;, &amp;quot;AI assistant&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? AgentIdentity
    {
        get => GetProperty<TerraformProperty<string>>("agent_identity");
        set => WithProperty("agent_identity", value);
    }

    /// <summary>
    /// Agent scope, e.g. &amp;quot;Example company website&amp;quot;, &amp;quot;internal Example company website for employees&amp;quot;, &amp;quot;manual of car owner&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? AgentScope
    {
        get => GetProperty<TerraformProperty<string>>("agent_scope");
        set => WithProperty("agent_scope", value);
    }

    /// <summary>
    /// Name of the company, organization or other entity that the agent represents. Used for knowledge connector LLM prompt and for knowledge search.
    /// </summary>
    public TerraformProperty<string>? Business
    {
        get => GetProperty<TerraformProperty<string>>("business");
        set => WithProperty("business", value);
    }

    /// <summary>
    /// Company description, used for LLM prompt, e.g. &amp;quot;a family company selling freshly roasted coffee beans&amp;quot;.&#39;&#39;
    /// </summary>
    public TerraformProperty<string>? BusinessDescription
    {
        get => GetProperty<TerraformProperty<string>>("business_description");
        set => WithProperty("business_description", value);
    }

    /// <summary>
    /// Whether to disable fallback to Data Store search results (in case the LLM couldn&#39;t pick a proper answer). Per default the feature is enabled.
    /// </summary>
    public TerraformProperty<bool>? DisableDataStoreFallback
    {
        get => GetProperty<TerraformProperty<bool>>("disable_data_store_fallback");
        set => WithProperty("disable_data_store_fallback", value);
    }

}

/// <summary>
/// Block type for llm_model_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The selected LLM model.
    /// </summary>
    public TerraformProperty<string>? Model
    {
        get => GetProperty<TerraformProperty<string>>("model");
        set => WithProperty("model", value);
    }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    public TerraformProperty<string>? PromptText
    {
        get => GetProperty<TerraformProperty<string>>("prompt_text");
        set => WithProperty("prompt_text", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsTimeoutsBlock : TerraformBlock
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
/// Manages a google_dialogflow_cx_generative_settings resource.
/// </summary>
public class GoogleDialogflowCxGenerativeSettings : TerraformResource
{
    public GoogleDialogflowCxGenerativeSettings(string name) : base("google_dialogflow_cx_generative_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
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
    /// Language for this settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformProperty<string> LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Block for fallback_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackSettings block(s) allowed")]
    public List<GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock>? FallbackSettings
    {
        get => GetProperty<List<GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock>>("fallback_settings");
        set => this.WithProperty("fallback_settings", value);
    }

    /// <summary>
    /// Block for generative_safety_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerativeSafetySettings block(s) allowed")]
    public List<GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock>? GenerativeSafetySettings
    {
        get => GetProperty<List<GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock>>("generative_safety_settings");
        set => this.WithProperty("generative_safety_settings", value);
    }

    /// <summary>
    /// Block for knowledge_connector_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    public List<GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock>? KnowledgeConnectorSettings
    {
        get => GetProperty<List<GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock>>("knowledge_connector_settings");
        set => this.WithProperty("knowledge_connector_settings", value);
    }

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    public List<GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock>? LlmModelSettings
    {
        get => GetProperty<List<GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock>>("llm_model_settings");
        set => this.WithProperty("llm_model_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxGenerativeSettingsTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowCxGenerativeSettingsTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The unique identifier of the generativeSettings.
    /// Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/generativeSettings.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
