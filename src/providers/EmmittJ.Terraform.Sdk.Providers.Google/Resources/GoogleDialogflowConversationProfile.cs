using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_agent_config in GoogleDialogflowConversationProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileAutomatedAgentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automated_agent_config";

    /// <summary>
    /// ID of the Dialogflow agent environment to use.
    /// Expects the format &amp;quot;projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent/environments/&amp;lt;EnvironmentID&amp;gt;&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Agent is required")]
    public required TerraformValue<string> Agent
    {
        get => GetRequiredArgument<TerraformValue<string>>("agent");
        set => SetArgument("agent", value);
    }

    /// <summary>
    /// Configure lifetime of the Dialogflow session.
    /// </summary>
    public TerraformValue<string>? SessionTtl
    {
        get => GetArgument<TerraformValue<string>>("session_ttl");
        set => SetArgument("session_ttl", value);
    }

}


/// <summary>
/// Block type for human_agent_assistant_config in GoogleDialogflowConversationProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "human_agent_assistant_config";

    /// <summary>
    /// EndUserSuggestionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndUserSuggestionConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlock>? EndUserSuggestionConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlock>>("end_user_suggestion_config");
        set => SetArgument("end_user_suggestion_config", value);
    }

    /// <summary>
    /// HumanAgentSuggestionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentSuggestionConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlock>? HumanAgentSuggestionConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlock>>("human_agent_suggestion_config");
        set => SetArgument("human_agent_suggestion_config", value);
    }

    /// <summary>
    /// MessageAnalysisConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MessageAnalysisConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockMessageAnalysisConfigBlock>? MessageAnalysisConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockMessageAnalysisConfigBlock>>("message_analysis_config");
        set => SetArgument("message_analysis_config", value);
    }

    /// <summary>
    /// NotificationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockNotificationConfigBlock>? NotificationConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockNotificationConfigBlock>>("notification_config");
        set => SetArgument("notification_config", value);
    }

}

/// <summary>
/// Block type for end_user_suggestion_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end_user_suggestion_config";

    /// <summary>
    /// When disableHighLatencyFeaturesSyncDelivery is true and using the AnalyzeContent API, we will not deliver the responses from high latency features in the API response. The humanAgentAssistantConfig.notification_config must be configured and enableEventBasedSuggestion must be set to true to receive the responses from high latency features in Pub/Sub. High latency feature(s): KNOWLEDGE_ASSIST
    /// </summary>
    public TerraformValue<bool>? DisableHighLatencyFeaturesSyncDelivery
    {
        get => GetArgument<TerraformValue<bool>>("disable_high_latency_features_sync_delivery");
        set => SetArgument("disable_high_latency_features_sync_delivery", value);
    }

    /// <summary>
    /// List of various generator resource names used in the conversation profile.
    /// </summary>
    public TerraformList<string>? Generators
    {
        get => GetArgument<TerraformList<string>>("generators");
        set => SetArgument("generators", value);
    }

    /// <summary>
    /// If groupSuggestionResponses is false, and there are multiple featureConfigs in event based suggestion or StreamingAnalyzeContent, we will try to deliver suggestions to customers as soon as we get new suggestion. Different type of suggestions based on the same context will be in separate Pub/Sub event or StreamingAnalyzeContentResponse.
    /// 
    /// If groupSuggestionResponses set to true. All the suggestions to the same participant based on the same context will be grouped into a single Pub/Sub event or StreamingAnalyzeContentResponse.
    /// </summary>
    public TerraformValue<bool>? GroupSuggestionResponses
    {
        get => GetArgument<TerraformValue<bool>>("group_suggestion_responses");
        set => SetArgument("group_suggestion_responses", value);
    }

    /// <summary>
    /// FeatureConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlock>? FeatureConfigs
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlock>>("feature_configs");
        set => SetArgument("feature_configs", value);
    }

}

/// <summary>
/// Block type for feature_configs in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feature_configs";

    /// <summary>
    /// Disable the logging of search queries sent by human agents. It can prevent those queries from being stored at answer records.
    /// This feature is only supported for types: KNOWLEDGE_SEARCH.
    /// </summary>
    public TerraformValue<bool>? DisableAgentQueryLogging
    {
        get => GetArgument<TerraformValue<bool>>("disable_agent_query_logging");
        set => SetArgument("disable_agent_query_logging", value);
    }

    /// <summary>
    /// Enable including conversation context during query answer generation.
    /// This feature is only supported for types: KNOWLEDGE_SEARCH.
    /// </summary>
    public TerraformValue<bool>? EnableConversationAugmentedQuery
    {
        get => GetArgument<TerraformValue<bool>>("enable_conversation_augmented_query");
        set => SetArgument("enable_conversation_augmented_query", value);
    }

    /// <summary>
    /// Automatically iterates all participants and tries to compile suggestions.
    /// This feature is only supported for types: ARTICLE_SUGGESTION, FAQ, DIALOGFLOW_ASSIST, KNOWLEDGE_ASSIST.
    /// </summary>
    public TerraformValue<bool>? EnableEventBasedSuggestion
    {
        get => GetArgument<TerraformValue<bool>>("enable_event_based_suggestion");
        set => SetArgument("enable_event_based_suggestion", value);
    }

    /// <summary>
    /// Enable query suggestion only.
    /// This feature is only supported for types: KNOWLEDGE_ASSIST
    /// </summary>
    public TerraformValue<bool>? EnableQuerySuggestionOnly
    {
        get => GetArgument<TerraformValue<bool>>("enable_query_suggestion_only");
        set => SetArgument("enable_query_suggestion_only", value);
    }

    /// <summary>
    /// Enable query suggestion even if we can&#39;t find its answer. By default, queries are suggested only if we find its answer.
    /// This feature is only supported for types: KNOWLEDGE_ASSIST.
    /// </summary>
    public TerraformValue<bool>? EnableQuerySuggestionWhenNoAnswer
    {
        get => GetArgument<TerraformValue<bool>>("enable_query_suggestion_when_no_answer");
        set => SetArgument("enable_query_suggestion_when_no_answer", value);
    }

    /// <summary>
    /// ConversationModelConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationModelConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockConversationModelConfigBlock>? ConversationModelConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockConversationModelConfigBlock>>("conversation_model_config");
        set => SetArgument("conversation_model_config", value);
    }

    /// <summary>
    /// ConversationProcessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationProcessConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockConversationProcessConfigBlock>? ConversationProcessConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockConversationProcessConfigBlock>>("conversation_process_config");
        set => SetArgument("conversation_process_config", value);
    }

    /// <summary>
    /// QueryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock>? QueryConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock>>("query_config");
        set => SetArgument("query_config", value);
    }

    /// <summary>
    /// SuggestionFeature block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuggestionFeature block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockSuggestionFeatureBlock>? SuggestionFeature
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockSuggestionFeatureBlock>>("suggestion_feature");
        set => SetArgument("suggestion_feature", value);
    }

    /// <summary>
    /// SuggestionTriggerSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuggestionTriggerSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockSuggestionTriggerSettingsBlock>? SuggestionTriggerSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockSuggestionTriggerSettingsBlock>>("suggestion_trigger_settings");
        set => SetArgument("suggestion_trigger_settings", value);
    }

}

/// <summary>
/// Block type for conversation_model_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockConversationModelConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_model_config";

    /// <summary>
    /// Version of current baseline model. It will be ignored if model is set. Valid versions are: Article Suggestion baseline model: - 0.9 - 1.0 (default) Summarization baseline model: - 1.0
    /// </summary>
    public TerraformValue<string>? BaselineModelVersion
    {
        get => GetArgument<TerraformValue<string>>("baseline_model_version");
        set => SetArgument("baseline_model_version", value);
    }

    /// <summary>
    /// Conversation model resource name. Format: projects/&amp;lt;Project ID&amp;gt;/conversationModels/&amp;lt;Model ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Model
    {
        get => GetArgument<TerraformValue<string>>("model");
        set => SetArgument("model", value);
    }

}

/// <summary>
/// Block type for conversation_process_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockConversationProcessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_process_config";

    /// <summary>
    /// Number of recent non-small-talk sentences to use as context for article and FAQ suggestion
    /// </summary>
    public TerraformValue<double>? RecentSentencesCount
    {
        get => GetArgument<TerraformValue<double>>("recent_sentences_count");
        set => SetArgument("recent_sentences_count", value);
    }

}

/// <summary>
/// Block type for query_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_config";

    /// <summary>
    /// Confidence threshold of query result.
    /// This feature is only supported for types: ARTICLE_SUGGESTION, FAQ, SMART_REPLY, SMART_COMPOSE, KNOWLEDGE_SEARCH, KNOWLEDGE_ASSIST, ENTITY_EXTRACTION.
    /// </summary>
    public TerraformValue<double>? ConfidenceThreshold
    {
        get => GetArgument<TerraformValue<double>>("confidence_threshold");
        set => SetArgument("confidence_threshold", value);
    }

    /// <summary>
    /// Maximum number of results to return.
    /// </summary>
    public TerraformValue<double>? MaxResults
    {
        get => GetArgument<TerraformValue<double>>("max_results");
        set => SetArgument("max_results", value);
    }

    /// <summary>
    /// ContextFilterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContextFilterSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockContextFilterSettingsBlock>? ContextFilterSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockContextFilterSettingsBlock>>("context_filter_settings");
        set => SetArgument("context_filter_settings", value);
    }

    /// <summary>
    /// DialogflowQuerySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DialogflowQuerySource block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlock>? DialogflowQuerySource
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlock>>("dialogflow_query_source");
        set => SetArgument("dialogflow_query_source", value);
    }

    /// <summary>
    /// DocumentQuerySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentQuerySource block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDocumentQuerySourceBlock>? DocumentQuerySource
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDocumentQuerySourceBlock>>("document_query_source");
        set => SetArgument("document_query_source", value);
    }

    /// <summary>
    /// KnowledgeBaseQuerySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KnowledgeBaseQuerySource block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockKnowledgeBaseQuerySourceBlock>? KnowledgeBaseQuerySource
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockKnowledgeBaseQuerySourceBlock>>("knowledge_base_query_source");
        set => SetArgument("knowledge_base_query_source", value);
    }

    /// <summary>
    /// Sections block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sections block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockSectionsBlock>? Sections
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockSectionsBlock>>("sections");
        set => SetArgument("sections", value);
    }

}

/// <summary>
/// Block type for context_filter_settings in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockContextFilterSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context_filter_settings";

    /// <summary>
    /// If set to true, the last message from virtual agent (hand off message) and the message before it (trigger message of hand off) are dropped.
    /// </summary>
    public TerraformValue<bool>? DropHandoffMessages
    {
        get => GetArgument<TerraformValue<bool>>("drop_handoff_messages");
        set => SetArgument("drop_handoff_messages", value);
    }

    /// <summary>
    /// If set to true, all messages from ivr stage are dropped.
    /// </summary>
    public TerraformValue<bool>? DropIvrMessages
    {
        get => GetArgument<TerraformValue<bool>>("drop_ivr_messages");
        set => SetArgument("drop_ivr_messages", value);
    }

    /// <summary>
    /// If set to true, all messages from virtual agent are dropped.
    /// </summary>
    public TerraformValue<bool>? DropVirtualAgentMessages
    {
        get => GetArgument<TerraformValue<bool>>("drop_virtual_agent_messages");
        set => SetArgument("drop_virtual_agent_messages", value);
    }

}

/// <summary>
/// Block type for dialogflow_query_source in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dialogflow_query_source";

    /// <summary>
    /// he name of a Dialogflow virtual agent used for end user side intent detection and suggestion. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Agent is required")]
    public required TerraformValue<string> Agent
    {
        get => GetRequiredArgument<TerraformValue<string>>("agent");
        set => SetArgument("agent", value);
    }

    /// <summary>
    /// HumanAgentSideConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentSideConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlockHumanAgentSideConfigBlock>? HumanAgentSideConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlockHumanAgentSideConfigBlock>>("human_agent_side_config");
        set => SetArgument("human_agent_side_config", value);
    }

}

/// <summary>
/// Block type for human_agent_side_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlockHumanAgentSideConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "human_agent_side_config";

    /// <summary>
    /// The name of a dialogflow virtual agent used for intent detection and suggestion triggered by human agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent.
    /// </summary>
    public TerraformValue<string>? Agent
    {
        get => GetArgument<TerraformValue<string>>("agent");
        set => SetArgument("agent", value);
    }

}

/// <summary>
/// Block type for document_query_source in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDocumentQuerySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "document_query_source";

    /// <summary>
    /// Knowledge documents to query from. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/knowledgeBases/&amp;lt;KnowledgeBase ID&amp;gt;/documents/&amp;lt;Document ID&amp;gt;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Documents is required")]
    public TerraformList<string>? Documents
    {
        get => GetArgument<TerraformList<string>>("documents");
        set => SetArgument("documents", value);
    }

}

/// <summary>
/// Block type for knowledge_base_query_source in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockKnowledgeBaseQuerySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "knowledge_base_query_source";

    /// <summary>
    /// Knowledge bases to query. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/knowledgeBases/&amp;lt;Knowledge Base ID&amp;gt;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnowledgeBases is required")]
    public TerraformList<string>? KnowledgeBases
    {
        get => GetArgument<TerraformList<string>>("knowledge_bases");
        set => SetArgument("knowledge_bases", value);
    }

}

/// <summary>
/// Block type for sections in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockSectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sections";

    /// <summary>
    /// The selected sections chosen to return when requesting a summary of a conversation
    /// If not provided the default selection will be &amp;quot;{SITUATION, ACTION, RESULT}&amp;quot;. Possible values: [&amp;quot;SECTION_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;SITUATION&amp;quot;, &amp;quot;ACTION&amp;quot;, &amp;quot;RESOLUTION&amp;quot;, &amp;quot;REASON_FOR_CANCELLATION&amp;quot;, &amp;quot;CUSTOMER_SATISFACTION&amp;quot;, &amp;quot;ENTITIES&amp;quot;]
    /// </summary>
    public TerraformList<string>? SectionTypes
    {
        get => GetArgument<TerraformList<string>>("section_types");
        set => SetArgument("section_types", value);
    }

}

/// <summary>
/// Block type for suggestion_feature in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockSuggestionFeatureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "suggestion_feature";

    /// <summary>
    /// Type of Human Agent Assistant API feature to request.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for suggestion_trigger_settings in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockEndUserSuggestionConfigBlockFeatureConfigsBlockSuggestionTriggerSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "suggestion_trigger_settings";

    /// <summary>
    /// Do not trigger if last utterance is small talk.
    /// </summary>
    public TerraformValue<bool>? NoSmallTalk
    {
        get => GetArgument<TerraformValue<bool>>("no_small_talk");
        set => SetArgument("no_small_talk", value);
    }

    /// <summary>
    /// Only trigger suggestion if participant role of last utterance is END_USER.
    /// </summary>
    public TerraformValue<bool>? OnlyEndUser
    {
        get => GetArgument<TerraformValue<bool>>("only_end_user");
        set => SetArgument("only_end_user", value);
    }

}

/// <summary>
/// Block type for human_agent_suggestion_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "human_agent_suggestion_config";

    /// <summary>
    /// When disableHighLatencyFeaturesSyncDelivery is true and using the AnalyzeContent API, we will not deliver the responses from high latency features in the API response. The humanAgentAssistantConfig.notification_config must be configured and enableEventBasedSuggestion must be set to true to receive the responses from high latency features in Pub/Sub. High latency feature(s): KNOWLEDGE_ASSIST
    /// </summary>
    public TerraformValue<bool>? DisableHighLatencyFeaturesSyncDelivery
    {
        get => GetArgument<TerraformValue<bool>>("disable_high_latency_features_sync_delivery");
        set => SetArgument("disable_high_latency_features_sync_delivery", value);
    }

    /// <summary>
    /// List of various generator resource names used in the conversation profile.
    /// </summary>
    public TerraformList<string>? Generators
    {
        get => GetArgument<TerraformList<string>>("generators");
        set => SetArgument("generators", value);
    }

    /// <summary>
    /// If groupSuggestionResponses is false, and there are multiple featureConfigs in event based suggestion or StreamingAnalyzeContent, we will try to deliver suggestions to customers as soon as we get new suggestion. Different type of suggestions based on the same context will be in separate Pub/Sub event or StreamingAnalyzeContentResponse.
    /// 
    /// If groupSuggestionResponses set to true. All the suggestions to the same participant based on the same context will be grouped into a single Pub/Sub event or StreamingAnalyzeContentResponse.
    /// </summary>
    public TerraformValue<bool>? GroupSuggestionResponses
    {
        get => GetArgument<TerraformValue<bool>>("group_suggestion_responses");
        set => SetArgument("group_suggestion_responses", value);
    }

    /// <summary>
    /// FeatureConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlock>? FeatureConfigs
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlock>>("feature_configs");
        set => SetArgument("feature_configs", value);
    }

}

/// <summary>
/// Block type for feature_configs in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feature_configs";

    /// <summary>
    /// Disable the logging of search queries sent by human agents. It can prevent those queries from being stored at answer records.
    /// This feature is only supported for types: KNOWLEDGE_SEARCH.
    /// </summary>
    public TerraformValue<bool>? DisableAgentQueryLogging
    {
        get => GetArgument<TerraformValue<bool>>("disable_agent_query_logging");
        set => SetArgument("disable_agent_query_logging", value);
    }

    /// <summary>
    /// Enable including conversation context during query answer generation.
    /// This feature is only supported for types: KNOWLEDGE_SEARCH.
    /// </summary>
    public TerraformValue<bool>? EnableConversationAugmentedQuery
    {
        get => GetArgument<TerraformValue<bool>>("enable_conversation_augmented_query");
        set => SetArgument("enable_conversation_augmented_query", value);
    }

    /// <summary>
    /// Automatically iterates all participants and tries to compile suggestions.
    /// This feature is only supported for types: ARTICLE_SUGGESTION, FAQ, DIALOGFLOW_ASSIST, KNOWLEDGE_ASSIST.
    /// </summary>
    public TerraformValue<bool>? EnableEventBasedSuggestion
    {
        get => GetArgument<TerraformValue<bool>>("enable_event_based_suggestion");
        set => SetArgument("enable_event_based_suggestion", value);
    }

    /// <summary>
    /// Enable query suggestion only.
    /// This feature is only supported for types: KNOWLEDGE_ASSIST
    /// </summary>
    public TerraformValue<bool>? EnableQuerySuggestionOnly
    {
        get => GetArgument<TerraformValue<bool>>("enable_query_suggestion_only");
        set => SetArgument("enable_query_suggestion_only", value);
    }

    /// <summary>
    /// Enable query suggestion even if we can&#39;t find its answer. By default, queries are suggested only if we find its answer.
    /// This feature is only supported for types: KNOWLEDGE_ASSIST.
    /// </summary>
    public TerraformValue<bool>? EnableQuerySuggestionWhenNoAnswer
    {
        get => GetArgument<TerraformValue<bool>>("enable_query_suggestion_when_no_answer");
        set => SetArgument("enable_query_suggestion_when_no_answer", value);
    }

    /// <summary>
    /// ConversationModelConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationModelConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockConversationModelConfigBlock>? ConversationModelConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockConversationModelConfigBlock>>("conversation_model_config");
        set => SetArgument("conversation_model_config", value);
    }

    /// <summary>
    /// ConversationProcessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConversationProcessConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockConversationProcessConfigBlock>? ConversationProcessConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockConversationProcessConfigBlock>>("conversation_process_config");
        set => SetArgument("conversation_process_config", value);
    }

    /// <summary>
    /// QueryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock>? QueryConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock>>("query_config");
        set => SetArgument("query_config", value);
    }

    /// <summary>
    /// SuggestionFeature block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuggestionFeature block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockSuggestionFeatureBlock>? SuggestionFeature
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockSuggestionFeatureBlock>>("suggestion_feature");
        set => SetArgument("suggestion_feature", value);
    }

    /// <summary>
    /// SuggestionTriggerSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuggestionTriggerSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockSuggestionTriggerSettingsBlock>? SuggestionTriggerSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockSuggestionTriggerSettingsBlock>>("suggestion_trigger_settings");
        set => SetArgument("suggestion_trigger_settings", value);
    }

}

/// <summary>
/// Block type for conversation_model_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockConversationModelConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_model_config";

    /// <summary>
    /// Version of current baseline model. It will be ignored if model is set. Valid versions are: Article Suggestion baseline model: - 0.9 - 1.0 (default) Summarization baseline model: - 1.0
    /// </summary>
    public TerraformValue<string>? BaselineModelVersion
    {
        get => GetArgument<TerraformValue<string>>("baseline_model_version");
        set => SetArgument("baseline_model_version", value);
    }

    /// <summary>
    /// Conversation model resource name. Format: projects/&amp;lt;Project ID&amp;gt;/conversationModels/&amp;lt;Model ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Model
    {
        get => GetArgument<TerraformValue<string>>("model");
        set => SetArgument("model", value);
    }

}

/// <summary>
/// Block type for conversation_process_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockConversationProcessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conversation_process_config";

    /// <summary>
    /// Number of recent non-small-talk sentences to use as context for article and FAQ suggestion
    /// </summary>
    public TerraformValue<double>? RecentSentencesCount
    {
        get => GetArgument<TerraformValue<double>>("recent_sentences_count");
        set => SetArgument("recent_sentences_count", value);
    }

}

/// <summary>
/// Block type for query_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_config";

    /// <summary>
    /// Confidence threshold of query result.
    /// This feature is only supported for types: ARTICLE_SUGGESTION, FAQ, SMART_REPLY, SMART_COMPOSE, KNOWLEDGE_SEARCH, KNOWLEDGE_ASSIST, ENTITY_EXTRACTION.
    /// </summary>
    public TerraformValue<double>? ConfidenceThreshold
    {
        get => GetArgument<TerraformValue<double>>("confidence_threshold");
        set => SetArgument("confidence_threshold", value);
    }

    /// <summary>
    /// Maximum number of results to return.
    /// </summary>
    public TerraformValue<double>? MaxResults
    {
        get => GetArgument<TerraformValue<double>>("max_results");
        set => SetArgument("max_results", value);
    }

    /// <summary>
    /// ContextFilterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContextFilterSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockContextFilterSettingsBlock>? ContextFilterSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockContextFilterSettingsBlock>>("context_filter_settings");
        set => SetArgument("context_filter_settings", value);
    }

    /// <summary>
    /// DialogflowQuerySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DialogflowQuerySource block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlock>? DialogflowQuerySource
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlock>>("dialogflow_query_source");
        set => SetArgument("dialogflow_query_source", value);
    }

    /// <summary>
    /// Sections block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sections block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockSectionsBlock>? Sections
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockSectionsBlock>>("sections");
        set => SetArgument("sections", value);
    }

}

/// <summary>
/// Block type for context_filter_settings in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockContextFilterSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context_filter_settings";

    /// <summary>
    /// If set to true, the last message from virtual agent (hand off message) and the message before it (trigger message of hand off) are dropped.
    /// </summary>
    public TerraformValue<bool>? DropHandoffMessages
    {
        get => GetArgument<TerraformValue<bool>>("drop_handoff_messages");
        set => SetArgument("drop_handoff_messages", value);
    }

    /// <summary>
    /// If set to true, all messages from ivr stage are dropped.
    /// </summary>
    public TerraformValue<bool>? DropIvrMessages
    {
        get => GetArgument<TerraformValue<bool>>("drop_ivr_messages");
        set => SetArgument("drop_ivr_messages", value);
    }

    /// <summary>
    /// If set to true, all messages from virtual agent are dropped.
    /// </summary>
    public TerraformValue<bool>? DropVirtualAgentMessages
    {
        get => GetArgument<TerraformValue<bool>>("drop_virtual_agent_messages");
        set => SetArgument("drop_virtual_agent_messages", value);
    }

}

/// <summary>
/// Block type for dialogflow_query_source in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dialogflow_query_source";

    /// <summary>
    /// he name of a Dialogflow virtual agent used for end user side intent detection and suggestion. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Agent is required")]
    public required TerraformValue<string> Agent
    {
        get => GetRequiredArgument<TerraformValue<string>>("agent");
        set => SetArgument("agent", value);
    }

    /// <summary>
    /// HumanAgentSideConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentSideConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlockHumanAgentSideConfigBlock>? HumanAgentSideConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlockHumanAgentSideConfigBlock>>("human_agent_side_config");
        set => SetArgument("human_agent_side_config", value);
    }

}

/// <summary>
/// Block type for human_agent_side_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockDialogflowQuerySourceBlockHumanAgentSideConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "human_agent_side_config";

    /// <summary>
    /// The name of a dialogflow virtual agent used for intent detection and suggestion triggered by human agent. Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent.
    /// </summary>
    public TerraformValue<string>? Agent
    {
        get => GetArgument<TerraformValue<string>>("agent");
        set => SetArgument("agent", value);
    }

}

/// <summary>
/// Block type for sections in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockQueryConfigBlockSectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sections";

    /// <summary>
    /// The selected sections chosen to return when requesting a summary of a conversation
    /// If not provided the default selection will be &amp;quot;{SITUATION, ACTION, RESULT}&amp;quot;. Possible values: [&amp;quot;SECTION_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;SITUATION&amp;quot;, &amp;quot;ACTION&amp;quot;, &amp;quot;RESOLUTION&amp;quot;, &amp;quot;REASON_FOR_CANCELLATION&amp;quot;, &amp;quot;CUSTOMER_SATISFACTION&amp;quot;, &amp;quot;ENTITIES&amp;quot;]
    /// </summary>
    public TerraformList<string>? SectionTypes
    {
        get => GetArgument<TerraformList<string>>("section_types");
        set => SetArgument("section_types", value);
    }

}

/// <summary>
/// Block type for suggestion_feature in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockSuggestionFeatureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "suggestion_feature";

    /// <summary>
    /// Type of Human Agent Assistant API feature to request.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for suggestion_trigger_settings in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockHumanAgentSuggestionConfigBlockFeatureConfigsBlockSuggestionTriggerSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "suggestion_trigger_settings";

    /// <summary>
    /// Do not trigger if last utterance is small talk.
    /// </summary>
    public TerraformValue<bool>? NoSmallTalk
    {
        get => GetArgument<TerraformValue<bool>>("no_small_talk");
        set => SetArgument("no_small_talk", value);
    }

    /// <summary>
    /// Only trigger suggestion if participant role of last utterance is END_USER.
    /// </summary>
    public TerraformValue<bool>? OnlyEndUser
    {
        get => GetArgument<TerraformValue<bool>>("only_end_user");
        set => SetArgument("only_end_user", value);
    }

}

/// <summary>
/// Block type for message_analysis_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockMessageAnalysisConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_analysis_config";

    /// <summary>
    /// Enable entity extraction in conversation messages on agent assist stage.
    /// </summary>
    public TerraformValue<bool>? EnableEntityExtraction
    {
        get => GetArgument<TerraformValue<bool>>("enable_entity_extraction");
        set => SetArgument("enable_entity_extraction", value);
    }

    /// <summary>
    /// Enable sentiment analysis in conversation messages on agent assist stage. Sentiment analysis inspects user input and identifies the prevailing subjective opinion, especially to determine a user&#39;s attitude as positive, negative, or neutral.
    /// </summary>
    public TerraformValue<bool>? EnableSentimentAnalysis
    {
        get => GetArgument<TerraformValue<bool>>("enable_sentiment_analysis");
        set => SetArgument("enable_sentiment_analysis", value);
    }

}

/// <summary>
/// Block type for notification_config in GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlockNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_config";

    /// <summary>
    /// Format of the message Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MessageFormat
    {
        get => GetArgument<TerraformValue<string>>("message_format");
        set => SetArgument("message_format", value);
    }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for human_agent_handoff_config in GoogleDialogflowConversationProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "human_agent_handoff_config";

    /// <summary>
    /// LivePersonConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LivePersonConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlockLivePersonConfigBlock>? LivePersonConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlockLivePersonConfigBlock>>("live_person_config");
        set => SetArgument("live_person_config", value);
    }

}

/// <summary>
/// Block type for live_person_config in GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlockLivePersonConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "live_person_config";

    /// <summary>
    /// Account number of the LivePerson account to connect.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountNumber is required")]
    public required TerraformValue<string> AccountNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_number");
        set => SetArgument("account_number", value);
    }

}


/// <summary>
/// Block type for logging_config in GoogleDialogflowConversationProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// Whether to log conversation events
    /// </summary>
    public TerraformValue<bool>? EnableStackdriverLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_stackdriver_logging");
        set => SetArgument("enable_stackdriver_logging", value);
    }

}


/// <summary>
/// Block type for new_message_event_notification_config in GoogleDialogflowConversationProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "new_message_event_notification_config";

    /// <summary>
    /// Format of the message Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MessageFormat
    {
        get => GetArgument<TerraformValue<string>>("message_format");
        set => SetArgument("message_format", value);
    }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for new_recognition_result_notification_config in GoogleDialogflowConversationProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "new_recognition_result_notification_config";

    /// <summary>
    /// Format of message. Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MessageFormat
    {
        get => GetArgument<TerraformValue<string>>("message_format");
        set => SetArgument("message_format", value);
    }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events like CONVERSATION_STARTED as serialized ConversationEvent protos.
    /// For telephony integration to receive notification, make sure either this topic is in the same project as the conversation or you grant service-&amp;lt;Conversation Project Number&amp;gt;@gcp-sa-dialogflow.iam.gserviceaccount.com the Dialogflow Service Agent role in the topic project.
    /// For chat integration to receive notification, make sure API caller has been granted the Dialogflow Service Agent role for the topic.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/topics/&amp;lt;Topic ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for notification_config in GoogleDialogflowConversationProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_config";

    /// <summary>
    /// Format of the message Possible values: [&amp;quot;MESSAGE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;PROTO&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MessageFormat
    {
        get => GetArgument<TerraformValue<string>>("message_format");
        set => SetArgument("message_format", value);
    }

    /// <summary>
    /// Name of the Pub/Sub topic to publish conversation events
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for stt_config in GoogleDialogflowConversationProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileSttConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stt_config";

    /// <summary>
    /// Audio encoding of the audio content to process. Possible values: [&amp;quot;AUDIO_ENCODING_UNSPECIFIED&amp;quot;, &amp;quot;AUDIO_ENCODING_LINEAR_16&amp;quot;, &amp;quot;AUDIO_ENCODING_FLAC&amp;quot;, &amp;quot;AUDIO_ENCODING_MULAW&amp;quot;, &amp;quot;AUDIO_ENCODING_AMR&amp;quot;, &amp;quot;AUDIO_ENCODING_AMR_WB&amp;quot;, &amp;quot;AUDIO_ENCODING_OGG_OPUS&amp;quot;, &amp;quot;AUDIOENCODING_SPEEX_WITH_HEADER_BYTE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AudioEncoding
    {
        get => GetArgument<TerraformValue<string>>("audio_encoding");
        set => SetArgument("audio_encoding", value);
    }

    /// <summary>
    /// If true, Dialogflow returns SpeechWordInfo in StreamingRecognitionResult with information about the recognized speech words.
    /// </summary>
    public TerraformValue<bool>? EnableWordInfo
    {
        get => GetArgument<TerraformValue<bool>>("enable_word_info");
        set => SetArgument("enable_word_info", value);
    }

    /// <summary>
    /// The language of the supplied audio.
    /// </summary>
    public TerraformValue<string> LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code") ?? CreateReference("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// Which Speech model to select.
    /// Leave this field unspecified to use Agent Speech settings for model selection.
    /// </summary>
    public TerraformValue<string>? Model
    {
        get => GetArgument<TerraformValue<string>>("model");
        set => SetArgument("model", value);
    }

    /// <summary>
    /// Sample rate (in Hertz) of the audio content sent in the query.
    /// </summary>
    public TerraformValue<double>? SampleRateHertz
    {
        get => GetArgument<TerraformValue<double>>("sample_rate_hertz");
        set => SetArgument("sample_rate_hertz", value);
    }

    /// <summary>
    /// The speech model used in speech to text. Possible values: [&amp;quot;SPEECH_MODEL_VARIANT_UNSPECIFIED&amp;quot;, &amp;quot;USE_BEST_AVAILABLE&amp;quot;, &amp;quot;USE_STANDARD&amp;quot;, &amp;quot;USE_ENHANCED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SpeechModelVariant
    {
        get => GetArgument<TerraformValue<string>>("speech_model_variant");
        set => SetArgument("speech_model_variant", value);
    }

    /// <summary>
    /// Use timeout based endpointing, interpreting endpointer sensitivy as seconds of timeout value.
    /// </summary>
    public TerraformValue<bool>? UseTimeoutBasedEndpointing
    {
        get => GetArgument<TerraformValue<bool>>("use_timeout_based_endpointing");
        set => SetArgument("use_timeout_based_endpointing", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowConversationProfile.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowConversationProfileTimeoutsBlock : TerraformBlock
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
/// Block type for tts_config in GoogleDialogflowConversationProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileTtsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tts_config";

    /// <summary>
    /// An identifier which selects &#39;audio effects&#39; profiles that are applied on (post synthesized) text to speech. Effects are applied on top of each other in the order they are given.
    /// </summary>
    public TerraformList<string>? EffectsProfileId
    {
        get => GetArgument<TerraformList<string>>("effects_profile_id");
        set => SetArgument("effects_profile_id", value);
    }

    /// <summary>
    /// Speaking pitch, in the range [-20.0, 20.0]. 20 means increase 20 semitones from the original pitch. -20 means decrease 20 semitones from the original pitch.
    /// </summary>
    public TerraformValue<double>? Pitch
    {
        get => GetArgument<TerraformValue<double>>("pitch");
        set => SetArgument("pitch", value);
    }

    /// <summary>
    /// Speaking rate/speed, in the range [0.25, 4.0].
    /// </summary>
    public TerraformValue<double>? SpeakingRate
    {
        get => GetArgument<TerraformValue<double>>("speaking_rate");
        set => SetArgument("speaking_rate", value);
    }

    /// <summary>
    /// Volume gain (in dB) of the normal native volume supported by the specific voice.
    /// </summary>
    public TerraformValue<double>? VolumeGainDb
    {
        get => GetArgument<TerraformValue<double>>("volume_gain_db");
        set => SetArgument("volume_gain_db", value);
    }

    /// <summary>
    /// Voice block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Voice block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileTtsConfigBlockVoiceBlock>? Voice
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileTtsConfigBlockVoiceBlock>>("voice");
        set => SetArgument("voice", value);
    }

}

/// <summary>
/// Block type for voice in GoogleDialogflowConversationProfileTtsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowConversationProfileTtsConfigBlockVoiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "voice";

    /// <summary>
    /// The name of the voice.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The preferred gender of the voice. Possible values: [&amp;quot;SSML_VOICE_GENDER_UNSPECIFIED&amp;quot;, &amp;quot;SSML_VOICE_GENDER_MALE&amp;quot;, &amp;quot;SSML_VOICE_GENDER_FEMALE&amp;quot;, &amp;quot;SSML_VOICE_GENDER_NEUTRAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SsmlGender
    {
        get => GetArgument<TerraformValue<string>>("ssml_gender");
        set => SetArgument("ssml_gender", value);
    }

}


/// <summary>
/// Represents a google_dialogflow_conversation_profile Terraform resource.
/// Manages a google_dialogflow_conversation_profile resource.
/// </summary>
public partial class GoogleDialogflowConversationProfile(string name) : TerraformResource("google_dialogflow_conversation_profile", name)
{
    /// <summary>
    /// Required. Human readable name for this profile. Max length 1024 bytes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Language code for the conversation profile. This should be a BCP-47 language tag.
    /// </summary>
    public TerraformValue<string> LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code") ?? CreateReference("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// desc
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Name of the CX SecuritySettings reference for the agent.
    /// </summary>
    public TerraformValue<string>? SecuritySettings
    {
        get => GetArgument<TerraformValue<string>>("security_settings");
        set => SetArgument("security_settings", value);
    }

    /// <summary>
    /// The time zone of this conversational profile.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// name
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// AutomatedAgentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedAgentConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileAutomatedAgentConfigBlock>? AutomatedAgentConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileAutomatedAgentConfigBlock>>("automated_agent_config");
        set => SetArgument("automated_agent_config", value);
    }

    /// <summary>
    /// HumanAgentAssistantConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentAssistantConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock>? HumanAgentAssistantConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentAssistantConfigBlock>>("human_agent_assistant_config");
        set => SetArgument("human_agent_assistant_config", value);
    }

    /// <summary>
    /// HumanAgentHandoffConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanAgentHandoffConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock>? HumanAgentHandoffConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileHumanAgentHandoffConfigBlock>>("human_agent_handoff_config");
        set => SetArgument("human_agent_handoff_config", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

    /// <summary>
    /// NewMessageEventNotificationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewMessageEventNotificationConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock>? NewMessageEventNotificationConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileNewMessageEventNotificationConfigBlock>>("new_message_event_notification_config");
        set => SetArgument("new_message_event_notification_config", value);
    }

    /// <summary>
    /// NewRecognitionResultNotificationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewRecognitionResultNotificationConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock>? NewRecognitionResultNotificationConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileNewRecognitionResultNotificationConfigBlock>>("new_recognition_result_notification_config");
        set => SetArgument("new_recognition_result_notification_config", value);
    }

    /// <summary>
    /// NotificationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileNotificationConfigBlock>? NotificationConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileNotificationConfigBlock>>("notification_config");
        set => SetArgument("notification_config", value);
    }

    /// <summary>
    /// SttConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SttConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileSttConfigBlock>? SttConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileSttConfigBlock>>("stt_config");
        set => SetArgument("stt_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowConversationProfileTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowConversationProfileTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TtsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtsConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowConversationProfileTtsConfigBlock>? TtsConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowConversationProfileTtsConfigBlock>>("tts_config");
        set => SetArgument("tts_config", value);
    }

}
