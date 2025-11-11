using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for annotator_selector in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock : TerraformBlockBase
{
    /// <summary>
    /// The issue model to run. If not provided, the most recently deployed topic
    /// model will be used. The provided issue model will only be used for
    /// inference if the issue model is deployed and if run_issue_model_annotator
    /// is set to true. If more than one issue model is provided, only the first
    /// provided issue model will be used for inference.
    /// </summary>
    [TerraformProperty("issue_models")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? IssueModels { get; set; }

    /// <summary>
    /// The list of phrase matchers to run. If not provided, all active phrase
    /// matchers will be used. If inactive phrase matchers are provided, they will
    /// not be used. Phrase matchers will be run only if
    /// run_phrase_matcher_annotator is set to true. Format:
    /// projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}
    /// </summary>
    [TerraformProperty("phrase_matchers")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? PhraseMatchers { get; set; }

    /// <summary>
    /// Whether to run the entity annotator.
    /// </summary>
    [TerraformProperty("run_entity_annotator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RunEntityAnnotator { get; set; }

    /// <summary>
    /// Whether to run the intent annotator.
    /// </summary>
    [TerraformProperty("run_intent_annotator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RunIntentAnnotator { get; set; }

    /// <summary>
    /// Whether to run the interruption annotator.
    /// </summary>
    [TerraformProperty("run_interruption_annotator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RunInterruptionAnnotator { get; set; }

    /// <summary>
    /// Whether to run the issue model annotator. A model should have already been
    /// deployed for this to take effect.
    /// </summary>
    [TerraformProperty("run_issue_model_annotator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RunIssueModelAnnotator { get; set; }

    /// <summary>
    /// Whether to run the active phrase matcher annotator(s).
    /// </summary>
    [TerraformProperty("run_phrase_matcher_annotator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RunPhraseMatcherAnnotator { get; set; }

    /// <summary>
    /// Whether to run the QA annotator.
    /// </summary>
    [TerraformProperty("run_qa_annotator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RunQaAnnotator { get; set; }

    /// <summary>
    /// Whether to run the sentiment annotator.
    /// </summary>
    [TerraformProperty("run_sentiment_annotator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RunSentimentAnnotator { get; set; }

    /// <summary>
    /// Whether to run the silence annotator.
    /// </summary>
    [TerraformProperty("run_silence_annotator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RunSilenceAnnotator { get; set; }

    /// <summary>
    /// Whether to run the summarization annotator.
    /// </summary>
    [TerraformProperty("run_summarization_annotator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RunSummarizationAnnotator { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_contact_center_insights_analysis_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleContactCenterInsightsAnalysisRule : TerraformResource
{
    public GoogleContactCenterInsightsAnalysisRule(string name) : base("google_contact_center_insights_analysis_rule", name)
    {
    }

    /// <summary>
    /// If true, apply this rule to conversations. Otherwise, this rule is
    /// inactive and saved as a draft.
    /// </summary>
    [TerraformProperty("active")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Active { get; set; }

    /// <summary>
    /// Percentage of conversations that we should apply this analysis setting
    /// automatically, between [0, 1]. For example, 0.1 means 10%. Conversations
    /// are sampled in a determenestic way. The original runtime_percentage &amp;amp;
    /// upload percentage will be replaced by defining filters on the conversation.
    /// </summary>
    [TerraformProperty("analysis_percentage")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? AnalysisPercentage { get; set; }

    /// <summary>
    /// Filter for the conversations that should apply this analysis
    /// rule. An empty filter means this analysis rule applies to all
    /// conversations.
    /// Refer to https://cloud.google.com/contact-center/insights/docs/filtering
    /// for details.
    /// </summary>
    [TerraformProperty("conversation_filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConversationFilter { get; set; }

    /// <summary>
    /// Display Name of the analysis rule.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for annotator_selector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnnotatorSelector block(s) allowed")]
    [TerraformProperty("annotator_selector")]
    public TerraformList<TerraformBlock<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock>>? AnnotatorSelector { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The time at which this analysis rule was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The resource name of the analysis rule. Randomly generated by Insights.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The most recent time at which this analysis rule was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
