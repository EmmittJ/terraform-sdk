using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for annotator_selector in .
/// Nesting mode: list
/// </summary>
public class GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock : ITerraformBlock
{
    /// <summary>
    /// The issue model to run. If not provided, the most recently deployed topic
    /// model will be used. The provided issue model will only be used for
    /// inference if the issue model is deployed and if run_issue_model_annotator
    /// is set to true. If more than one issue model is provided, only the first
    /// provided issue model will be used for inference.
    /// </summary>
    [TerraformPropertyName("issue_models")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? IssueModels { get; set; }

    /// <summary>
    /// The list of phrase matchers to run. If not provided, all active phrase
    /// matchers will be used. If inactive phrase matchers are provided, they will
    /// not be used. Phrase matchers will be run only if
    /// run_phrase_matcher_annotator is set to true. Format:
    /// projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}
    /// </summary>
    [TerraformPropertyName("phrase_matchers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PhraseMatchers { get; set; }

    /// <summary>
    /// Whether to run the entity annotator.
    /// </summary>
    [TerraformPropertyName("run_entity_annotator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunEntityAnnotator { get; set; }

    /// <summary>
    /// Whether to run the intent annotator.
    /// </summary>
    [TerraformPropertyName("run_intent_annotator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunIntentAnnotator { get; set; }

    /// <summary>
    /// Whether to run the interruption annotator.
    /// </summary>
    [TerraformPropertyName("run_interruption_annotator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunInterruptionAnnotator { get; set; }

    /// <summary>
    /// Whether to run the issue model annotator. A model should have already been
    /// deployed for this to take effect.
    /// </summary>
    [TerraformPropertyName("run_issue_model_annotator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunIssueModelAnnotator { get; set; }

    /// <summary>
    /// Whether to run the active phrase matcher annotator(s).
    /// </summary>
    [TerraformPropertyName("run_phrase_matcher_annotator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunPhraseMatcherAnnotator { get; set; }

    /// <summary>
    /// Whether to run the QA annotator.
    /// </summary>
    [TerraformPropertyName("run_qa_annotator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunQaAnnotator { get; set; }

    /// <summary>
    /// Whether to run the sentiment annotator.
    /// </summary>
    [TerraformPropertyName("run_sentiment_annotator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunSentimentAnnotator { get; set; }

    /// <summary>
    /// Whether to run the silence annotator.
    /// </summary>
    [TerraformPropertyName("run_silence_annotator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunSilenceAnnotator { get; set; }

    /// <summary>
    /// Whether to run the summarization annotator.
    /// </summary>
    [TerraformPropertyName("run_summarization_annotator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RunSummarizationAnnotator { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_contact_center_insights_analysis_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContactCenterInsightsAnalysisRule : TerraformResource
{
    public GoogleContactCenterInsightsAnalysisRule(string name) : base("google_contact_center_insights_analysis_rule", name)
    {
    }

    /// <summary>
    /// If true, apply this rule to conversations. Otherwise, this rule is
    /// inactive and saved as a draft.
    /// </summary>
    [TerraformPropertyName("active")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Active { get; set; }

    /// <summary>
    /// Percentage of conversations that we should apply this analysis setting
    /// automatically, between [0, 1]. For example, 0.1 means 10%. Conversations
    /// are sampled in a determenestic way. The original runtime_percentage &amp;amp;
    /// upload percentage will be replaced by defining filters on the conversation.
    /// </summary>
    [TerraformPropertyName("analysis_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AnalysisPercentage { get; set; }

    /// <summary>
    /// Filter for the conversations that should apply this analysis
    /// rule. An empty filter means this analysis rule applies to all
    /// conversations.
    /// Refer to https://cloud.google.com/contact-center/insights/docs/filtering
    /// for details.
    /// </summary>
    [TerraformPropertyName("conversation_filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConversationFilter { get; set; }

    /// <summary>
    /// Display Name of the analysis rule.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for annotator_selector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnnotatorSelector block(s) allowed")]
    [TerraformPropertyName("annotator_selector")]
    public TerraformList<TerraformBlock<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock>>? AnnotatorSelector { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time at which this analysis rule was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The resource name of the analysis rule. Randomly generated by Insights.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. The most recent time at which this analysis rule was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
