using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fallback_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock
{
    /// <summary>
    /// Display name of the selected prompt.
    /// </summary>
    [TerraformPropertyName("selected_prompt")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SelectedPrompt { get; set; }

}

/// <summary>
/// Block type for generative_safety_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock
{
    /// <summary>
    /// Optional. Default phrase match strategy for banned phrases.
    /// See [PhraseMatchStrategy](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/GenerativeSettings#phrasematchstrategy) for valid values.
    /// </summary>
    [TerraformPropertyName("default_banned_phrase_match_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultBannedPhraseMatchStrategy { get; set; }

}

/// <summary>
/// Block type for knowledge_connector_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock
{
    /// <summary>
    /// Name of the virtual agent. Used for LLM prompt. Can be left empty.
    /// </summary>
    [TerraformPropertyName("agent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Agent { get; set; }

    /// <summary>
    /// Identity of the agent, e.g. &amp;quot;virtual agent&amp;quot;, &amp;quot;AI assistant&amp;quot;.
    /// </summary>
    [TerraformPropertyName("agent_identity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AgentIdentity { get; set; }

    /// <summary>
    /// Agent scope, e.g. &amp;quot;Example company website&amp;quot;, &amp;quot;internal Example company website for employees&amp;quot;, &amp;quot;manual of car owner&amp;quot;.
    /// </summary>
    [TerraformPropertyName("agent_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AgentScope { get; set; }

    /// <summary>
    /// Name of the company, organization or other entity that the agent represents. Used for knowledge connector LLM prompt and for knowledge search.
    /// </summary>
    [TerraformPropertyName("business")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Business { get; set; }

    /// <summary>
    /// Company description, used for LLM prompt, e.g. &amp;quot;a family company selling freshly roasted coffee beans&amp;quot;.&#39;&#39;
    /// </summary>
    [TerraformPropertyName("business_description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BusinessDescription { get; set; }

    /// <summary>
    /// Whether to disable fallback to Data Store search results (in case the LLM couldn&#39;t pick a proper answer). Per default the feature is enabled.
    /// </summary>
    [TerraformPropertyName("disable_data_store_fallback")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableDataStoreFallback { get; set; }

}

/// <summary>
/// Block type for llm_model_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock
{
    /// <summary>
    /// The selected LLM model.
    /// </summary>
    [TerraformPropertyName("model")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Model { get; set; }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    [TerraformPropertyName("prompt_text")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PromptText { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_generative_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxGenerativeSettings : TerraformResource
{
    public GoogleDialogflowCxGenerativeSettings(string name) : base("google_dialogflow_cx_generative_settings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Language for this settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    [TerraformPropertyName("language_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LanguageCode { get; set; }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Block for fallback_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackSettings block(s) allowed")]
    [TerraformPropertyName("fallback_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock>>? FallbackSettings { get; set; }

    /// <summary>
    /// Block for generative_safety_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerativeSafetySettings block(s) allowed")]
    [TerraformPropertyName("generative_safety_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock>>? GenerativeSafetySettings { get; set; }

    /// <summary>
    /// Block for knowledge_connector_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    [TerraformPropertyName("knowledge_connector_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock>>? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    [TerraformPropertyName("llm_model_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock>>? LlmModelSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowCxGenerativeSettingsTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique identifier of the generativeSettings.
    /// Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/generativeSettings.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
