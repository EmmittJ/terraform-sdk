using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for annotator_selector in GoogleContactCenterInsightsAnalysisRule.
/// Nesting mode: list
/// </summary>
public class GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "annotator_selector";

    /// <summary>
    /// The issue model to run. If not provided, the most recently deployed topic
    /// model will be used. The provided issue model will only be used for
    /// inference if the issue model is deployed and if run_issue_model_annotator
    /// is set to true. If more than one issue model is provided, only the first
    /// provided issue model will be used for inference.
    /// </summary>
    public TerraformList<string>? IssueModels
    {
        get => GetArgument<TerraformList<string>>("issue_models");
        set => SetArgument("issue_models", value);
    }

    /// <summary>
    /// The list of phrase matchers to run. If not provided, all active phrase
    /// matchers will be used. If inactive phrase matchers are provided, they will
    /// not be used. Phrase matchers will be run only if
    /// run_phrase_matcher_annotator is set to true. Format:
    /// projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}
    /// </summary>
    public TerraformList<string>? PhraseMatchers
    {
        get => GetArgument<TerraformList<string>>("phrase_matchers");
        set => SetArgument("phrase_matchers", value);
    }

    /// <summary>
    /// Whether to run the entity annotator.
    /// </summary>
    public TerraformValue<bool>? RunEntityAnnotator
    {
        get => GetArgument<TerraformValue<bool>>("run_entity_annotator");
        set => SetArgument("run_entity_annotator", value);
    }

    /// <summary>
    /// Whether to run the intent annotator.
    /// </summary>
    public TerraformValue<bool>? RunIntentAnnotator
    {
        get => GetArgument<TerraformValue<bool>>("run_intent_annotator");
        set => SetArgument("run_intent_annotator", value);
    }

    /// <summary>
    /// Whether to run the interruption annotator.
    /// </summary>
    public TerraformValue<bool>? RunInterruptionAnnotator
    {
        get => GetArgument<TerraformValue<bool>>("run_interruption_annotator");
        set => SetArgument("run_interruption_annotator", value);
    }

    /// <summary>
    /// Whether to run the issue model annotator. A model should have already been
    /// deployed for this to take effect.
    /// </summary>
    public TerraformValue<bool>? RunIssueModelAnnotator
    {
        get => GetArgument<TerraformValue<bool>>("run_issue_model_annotator");
        set => SetArgument("run_issue_model_annotator", value);
    }

    /// <summary>
    /// Whether to run the active phrase matcher annotator(s).
    /// </summary>
    public TerraformValue<bool>? RunPhraseMatcherAnnotator
    {
        get => GetArgument<TerraformValue<bool>>("run_phrase_matcher_annotator");
        set => SetArgument("run_phrase_matcher_annotator", value);
    }

    /// <summary>
    /// Whether to run the QA annotator.
    /// </summary>
    public TerraformValue<bool>? RunQaAnnotator
    {
        get => GetArgument<TerraformValue<bool>>("run_qa_annotator");
        set => SetArgument("run_qa_annotator", value);
    }

    /// <summary>
    /// Whether to run the sentiment annotator.
    /// </summary>
    public TerraformValue<bool>? RunSentimentAnnotator
    {
        get => GetArgument<TerraformValue<bool>>("run_sentiment_annotator");
        set => SetArgument("run_sentiment_annotator", value);
    }

    /// <summary>
    /// Whether to run the silence annotator.
    /// </summary>
    public TerraformValue<bool>? RunSilenceAnnotator
    {
        get => GetArgument<TerraformValue<bool>>("run_silence_annotator");
        set => SetArgument("run_silence_annotator", value);
    }

    /// <summary>
    /// Whether to run the summarization annotator.
    /// </summary>
    public TerraformValue<bool>? RunSummarizationAnnotator
    {
        get => GetArgument<TerraformValue<bool>>("run_summarization_annotator");
        set => SetArgument("run_summarization_annotator", value);
    }

    /// <summary>
    /// QaConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QaConfig block(s) allowed")]
    public TerraformList<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlockQaConfigBlock>? QaConfig
    {
        get => GetArgument<TerraformList<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlockQaConfigBlock>>("qa_config");
        set => SetArgument("qa_config", value);
    }

    /// <summary>
    /// SummarizationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SummarizationConfig block(s) allowed")]
    public TerraformList<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlockSummarizationConfigBlock>? SummarizationConfig
    {
        get => GetArgument<TerraformList<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlockSummarizationConfigBlock>>("summarization_config");
        set => SetArgument("summarization_config", value);
    }

}

/// <summary>
/// Block type for qa_config in GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlockQaConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "qa_config";

    /// <summary>
    /// ScorecardList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScorecardList block(s) allowed")]
    public TerraformList<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlockQaConfigBlockScorecardListBlock>? ScorecardList
    {
        get => GetArgument<TerraformList<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlockQaConfigBlockScorecardListBlock>>("scorecard_list");
        set => SetArgument("scorecard_list", value);
    }

}

/// <summary>
/// Block type for scorecard_list in GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlockQaConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlockQaConfigBlockScorecardListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scorecard_list";

    /// <summary>
    /// List of QaScorecardRevisions.
    /// </summary>
    public TerraformList<string>? QaScorecardRevisions
    {
        get => GetArgument<TerraformList<string>>("qa_scorecard_revisions");
        set => SetArgument("qa_scorecard_revisions", value);
    }

}

/// <summary>
/// Block type for summarization_config in GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlockSummarizationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "summarization_config";

    /// <summary>
    /// Resource name of the Dialogflow conversation profile.
    /// Format:
    /// projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}
    /// </summary>
    public TerraformValue<string>? ConversationProfile
    {
        get => GetArgument<TerraformValue<string>>("conversation_profile");
        set => SetArgument("conversation_profile", value);
    }

    /// <summary>
    /// Default summarization model to be used.
    /// Possible values:
    /// SUMMARIZATION_MODEL_UNSPECIFIED
    /// BASELINE_MODEL
    /// BASELINE_MODEL_V2_0 Possible values: [&amp;quot;BASELINE_MODEL&amp;quot;, &amp;quot;BASELINE_MODEL_V2_0&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SummarizationModel
    {
        get => GetArgument<TerraformValue<string>>("summarization_model");
        set => SetArgument("summarization_model", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleContactCenterInsightsAnalysisRule.
/// Nesting mode: single
/// </summary>
public class GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_contact_center_insights_analysis_rule Terraform resource.
/// Manages a google_contact_center_insights_analysis_rule resource.
/// </summary>
public partial class GoogleContactCenterInsightsAnalysisRule(string name) : TerraformResource("google_contact_center_insights_analysis_rule", name)
{
    /// <summary>
    /// If true, apply this rule to conversations. Otherwise, this rule is
    /// inactive and saved as a draft.
    /// </summary>
    public TerraformValue<bool>? Active
    {
        get => GetArgument<TerraformValue<bool>>("active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// Percentage of conversations that we should apply this analysis setting
    /// automatically, between [0, 1]. For example, 0.1 means 10%. Conversations
    /// are sampled in a determenestic way. The original runtime_percentage &amp;amp;
    /// upload percentage will be replaced by defining filters on the conversation.
    /// </summary>
    public TerraformValue<double>? AnalysisPercentage
    {
        get => GetArgument<TerraformValue<double>>("analysis_percentage");
        set => SetArgument("analysis_percentage", value);
    }

    /// <summary>
    /// Filter for the conversations that should apply this analysis
    /// rule. An empty filter means this analysis rule applies to all
    /// conversations.
    /// Refer to https://cloud.google.com/contact-center/insights/docs/filtering
    /// for details.
    /// </summary>
    public TerraformValue<string>? ConversationFilter
    {
        get => GetArgument<TerraformValue<string>>("conversation_filter");
        set => SetArgument("conversation_filter", value);
    }

    /// <summary>
    /// Display Name of the analysis rule.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// Location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// Output only. The time at which this analysis rule was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The resource name of the analysis rule. Randomly generated by Insights.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Output only. The most recent time at which this analysis rule was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// AnnotatorSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnnotatorSelector block(s) allowed")]
    public TerraformList<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock>? AnnotatorSelector
    {
        get => GetArgument<TerraformList<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock>>("annotator_selector");
        set => SetArgument("annotator_selector", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
