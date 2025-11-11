using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fallback_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Display name of the selected prompt.
    /// </summary>
    [TerraformProperty("selected_prompt")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SelectedPrompt { get; set; }

}

/// <summary>
/// Block type for generative_safety_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Default phrase match strategy for banned phrases.
    /// See [PhraseMatchStrategy](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/GenerativeSettings#phrasematchstrategy) for valid values.
    /// </summary>
    [TerraformProperty("default_banned_phrase_match_strategy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultBannedPhraseMatchStrategy { get; set; }

}

/// <summary>
/// Block type for knowledge_connector_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the virtual agent. Used for LLM prompt. Can be left empty.
    /// </summary>
    [TerraformProperty("agent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Agent { get; set; }

    /// <summary>
    /// Identity of the agent, e.g. &amp;quot;virtual agent&amp;quot;, &amp;quot;AI assistant&amp;quot;.
    /// </summary>
    [TerraformProperty("agent_identity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AgentIdentity { get; set; }

    /// <summary>
    /// Agent scope, e.g. &amp;quot;Example company website&amp;quot;, &amp;quot;internal Example company website for employees&amp;quot;, &amp;quot;manual of car owner&amp;quot;.
    /// </summary>
    [TerraformProperty("agent_scope")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AgentScope { get; set; }

    /// <summary>
    /// Name of the company, organization or other entity that the agent represents. Used for knowledge connector LLM prompt and for knowledge search.
    /// </summary>
    [TerraformProperty("business")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Business { get; set; }

    /// <summary>
    /// Company description, used for LLM prompt, e.g. &amp;quot;a family company selling freshly roasted coffee beans&amp;quot;.&#39;&#39;
    /// </summary>
    [TerraformProperty("business_description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BusinessDescription { get; set; }

    /// <summary>
    /// Whether to disable fallback to Data Store search results (in case the LLM couldn&#39;t pick a proper answer). Per default the feature is enabled.
    /// </summary>
    [TerraformProperty("disable_data_store_fallback")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisableDataStoreFallback { get; set; }

}

/// <summary>
/// Block type for llm_model_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The selected LLM model.
    /// </summary>
    [TerraformProperty("model")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Model { get; set; }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    [TerraformProperty("prompt_text")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PromptText { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowCxGenerativeSettingsTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_generative_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowCxGenerativeSettings : TerraformResource
{
    public GoogleDialogflowCxGenerativeSettings(string name) : base("google_dialogflow_cx_generative_settings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Language for this settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    [TerraformProperty("language_code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LanguageCode { get; set; }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Block for fallback_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackSettings block(s) allowed")]
    [TerraformProperty("fallback_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock>>? FallbackSettings { get; set; }

    /// <summary>
    /// Block for generative_safety_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerativeSafetySettings block(s) allowed")]
    [TerraformProperty("generative_safety_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock>>? GenerativeSafetySettings { get; set; }

    /// <summary>
    /// Block for knowledge_connector_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    [TerraformProperty("knowledge_connector_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock>>? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    [TerraformProperty("llm_model_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock>>? LlmModelSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDialogflowCxGenerativeSettingsTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique identifier of the generativeSettings.
    /// Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/generativeSettings.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
