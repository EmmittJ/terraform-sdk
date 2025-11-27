using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fallback_settings in GoogleDialogflowCxGenerativeSettings.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fallback_settings";

    /// <summary>
    /// Display name of the selected prompt.
    /// </summary>
    public TerraformValue<string>? SelectedPrompt
    {
        get => new TerraformReference<string>(this, "selected_prompt");
        set => SetArgument("selected_prompt", value);
    }

    /// <summary>
    /// PromptTemplates block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlockPromptTemplatesBlock>? PromptTemplates
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlockPromptTemplatesBlock>>("prompt_templates");
        set => SetArgument("prompt_templates", value);
    }

}

/// <summary>
/// Block type for prompt_templates in GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlockPromptTemplatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prompt_templates";

    /// <summary>
    /// Prompt name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// If the flag is true, the prompt is frozen and cannot be modified by users.
    /// </summary>
    public TerraformValue<bool>? Frozen
    {
        get => new TerraformReference<bool>(this, "frozen");
        set => SetArgument("frozen", value);
    }

    /// <summary>
    /// Prompt text that is sent to a LLM on no-match default, placeholders are filled downstream. For example: &amp;quot;Here is a conversation $conversation, a response is: &amp;quot;
    /// </summary>
    public TerraformValue<string>? PromptText
    {
        get => new TerraformReference<string>(this, "prompt_text");
        set => SetArgument("prompt_text", value);
    }

}


/// <summary>
/// Block type for generative_safety_settings in GoogleDialogflowCxGenerativeSettings.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "generative_safety_settings";

    /// <summary>
    /// Optional. Default phrase match strategy for banned phrases.
    /// See [PhraseMatchStrategy](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/GenerativeSettings#phrasematchstrategy) for valid values.
    /// </summary>
    public TerraformValue<string>? DefaultBannedPhraseMatchStrategy
    {
        get => new TerraformReference<string>(this, "default_banned_phrase_match_strategy");
        set => SetArgument("default_banned_phrase_match_strategy", value);
    }

    /// <summary>
    /// BannedPhrases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlockBannedPhrasesBlock>? BannedPhrases
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlockBannedPhrasesBlock>>("banned_phrases");
        set => SetArgument("banned_phrases", value);
    }

}

/// <summary>
/// Block type for banned_phrases in GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlockBannedPhrasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "banned_phrases";

    /// <summary>
    /// Language code of the phrase.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// Text input which can be used for prompt or banned phrases.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

}


/// <summary>
/// Block type for knowledge_connector_settings in GoogleDialogflowCxGenerativeSettings.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "knowledge_connector_settings";

    /// <summary>
    /// Name of the virtual agent. Used for LLM prompt. Can be left empty.
    /// </summary>
    public TerraformValue<string>? Agent
    {
        get => new TerraformReference<string>(this, "agent");
        set => SetArgument("agent", value);
    }

    /// <summary>
    /// Identity of the agent, e.g. &amp;quot;virtual agent&amp;quot;, &amp;quot;AI assistant&amp;quot;.
    /// </summary>
    public TerraformValue<string>? AgentIdentity
    {
        get => new TerraformReference<string>(this, "agent_identity");
        set => SetArgument("agent_identity", value);
    }

    /// <summary>
    /// Agent scope, e.g. &amp;quot;Example company website&amp;quot;, &amp;quot;internal Example company website for employees&amp;quot;, &amp;quot;manual of car owner&amp;quot;.
    /// </summary>
    public TerraformValue<string>? AgentScope
    {
        get => new TerraformReference<string>(this, "agent_scope");
        set => SetArgument("agent_scope", value);
    }

    /// <summary>
    /// Name of the company, organization or other entity that the agent represents. Used for knowledge connector LLM prompt and for knowledge search.
    /// </summary>
    public TerraformValue<string>? Business
    {
        get => new TerraformReference<string>(this, "business");
        set => SetArgument("business", value);
    }

    /// <summary>
    /// Company description, used for LLM prompt, e.g. &amp;quot;a family company selling freshly roasted coffee beans&amp;quot;.&#39;&#39;
    /// </summary>
    public TerraformValue<string>? BusinessDescription
    {
        get => new TerraformReference<string>(this, "business_description");
        set => SetArgument("business_description", value);
    }

    /// <summary>
    /// Whether to disable fallback to Data Store search results (in case the LLM couldn&#39;t pick a proper answer). Per default the feature is enabled.
    /// </summary>
    public TerraformValue<bool>? DisableDataStoreFallback
    {
        get => new TerraformReference<bool>(this, "disable_data_store_fallback");
        set => SetArgument("disable_data_store_fallback", value);
    }

}


/// <summary>
/// Block type for llm_model_settings in GoogleDialogflowCxGenerativeSettings.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "llm_model_settings";

    /// <summary>
    /// The selected LLM model.
    /// </summary>
    public TerraformValue<string>? Model
    {
        get => new TerraformReference<string>(this, "model");
        set => SetArgument("model", value);
    }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    public TerraformValue<string>? PromptText
    {
        get => new TerraformReference<string>(this, "prompt_text");
        set => SetArgument("prompt_text", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxGenerativeSettings.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxGenerativeSettingsTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dialogflow_cx_generative_settings Terraform resource.
/// Manages a google_dialogflow_cx_generative_settings resource.
/// </summary>
public partial class GoogleDialogflowCxGenerativeSettings(string name) : TerraformResource("google_dialogflow_cx_generative_settings", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Language for this settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The unique identifier of the generativeSettings.
    /// Format: projects/&amp;lt;ProjectID&amp;gt;/locations/&amp;lt;LocationID&amp;gt;/agents/&amp;lt;AgentID&amp;gt;/generativeSettings.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// FallbackSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock>? FallbackSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxGenerativeSettingsFallbackSettingsBlock>>("fallback_settings");
        set => SetArgument("fallback_settings", value);
    }

    /// <summary>
    /// GenerativeSafetySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerativeSafetySettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock>? GenerativeSafetySettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxGenerativeSettingsGenerativeSafetySettingsBlock>>("generative_safety_settings");
        set => SetArgument("generative_safety_settings", value);
    }

    /// <summary>
    /// KnowledgeConnectorSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeConnectorSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock>? KnowledgeConnectorSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxGenerativeSettingsKnowledgeConnectorSettingsBlock>>("knowledge_connector_settings");
        set => SetArgument("knowledge_connector_settings", value);
    }

    /// <summary>
    /// LlmModelSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock>? LlmModelSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxGenerativeSettingsLlmModelSettingsBlock>>("llm_model_settings");
        set => SetArgument("llm_model_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxGenerativeSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxGenerativeSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
