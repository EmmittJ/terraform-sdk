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
        set => SetProperty("selected_prompt", value);
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
        set => SetProperty("default_banned_phrase_match_strategy", value);
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
        set => SetProperty("agent", value);
    }

    /// <summary>
    /// Identity of the agent, e.g. &amp;quot;virtual agent&amp;quot;, &amp;quot;AI assistant&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? AgentIdentity
    {
        set => SetProperty("agent_identity", value);
    }

    /// <summary>
    /// Agent scope, e.g. &amp;quot;Example company website&amp;quot;, &amp;quot;internal Example company website for employees&amp;quot;, &amp;quot;manual of car owner&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? AgentScope
    {
        set => SetProperty("agent_scope", value);
    }

    /// <summary>
    /// Name of the company, organization or other entity that the agent represents. Used for knowledge connector LLM prompt and for knowledge search.
    /// </summary>
    public TerraformProperty<string>? Business
    {
        set => SetProperty("business", value);
    }

    /// <summary>
    /// Company description, used for LLM prompt, e.g. &amp;quot;a family company selling freshly roasted coffee beans&amp;quot;.&#39;&#39;
    /// </summary>
    public TerraformProperty<string>? BusinessDescription
    {
        set => SetProperty("business_description", value);
    }

    /// <summary>
    /// Whether to disable fallback to Data Store search results (in case the LLM couldn&#39;t pick a proper answer). Per default the feature is enabled.
    /// </summary>
    public TerraformProperty<bool>? DisableDataStoreFallback
    {
        set => SetProperty("disable_data_store_fallback", value);
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
        set => SetProperty("model", value);
    }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    public TerraformProperty<string>? PromptText
    {
        set => SetProperty("prompt_text", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dialogflow_cx_generative_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxGenerativeSettings : TerraformResource
{
    public GoogleDialogflowCxGenerativeSettings(string name) : base("google_dialogflow_cx_generative_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("id");
        SetOutput("language_code");
        SetOutput("parent");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Language for this settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformProperty<string> LanguageCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language_code");
        set => SetProperty("language_code", value);
    }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Block for fallback_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackSettings block(s) allowed")]
    public List<GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock>? FallbackSettings
    {
        set => SetProperty("fallback_settings", value);
    }

    /// <summary>
    /// Block for generative_safety_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerativeSafetySettings block(s) allowed")]
    public List<GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock>? GenerativeSafetySettings
    {
        set => SetProperty("generative_safety_settings", value);
    }

    /// <summary>
    /// Block for knowledge_connector_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    public List<GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock>? KnowledgeConnectorSettings
    {
        set => SetProperty("knowledge_connector_settings", value);
    }

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    public List<GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock>? LlmModelSettings
    {
        set => SetProperty("llm_model_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxGenerativeSettingsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The unique identifier of the generativeSettings.
    /// Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/generativeSettings.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
