using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for annotator_selector in .
/// Nesting mode: list
/// </summary>
public class GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock : TerraformBlock
{
    /// <summary>
    /// The issue model to run. If not provided, the most recently deployed topic
    /// model will be used. The provided issue model will only be used for
    /// inference if the issue model is deployed and if run_issue_model_annotator
    /// is set to true. If more than one issue model is provided, only the first
    /// provided issue model will be used for inference.
    /// </summary>
    public List<TerraformProperty<string>>? IssueModels
    {
        get => GetProperty<List<TerraformProperty<string>>>("issue_models");
        set => WithProperty("issue_models", value);
    }

    /// <summary>
    /// The list of phrase matchers to run. If not provided, all active phrase
    /// matchers will be used. If inactive phrase matchers are provided, they will
    /// not be used. Phrase matchers will be run only if
    /// run_phrase_matcher_annotator is set to true. Format:
    /// projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}
    /// </summary>
    public List<TerraformProperty<string>>? PhraseMatchers
    {
        get => GetProperty<List<TerraformProperty<string>>>("phrase_matchers");
        set => WithProperty("phrase_matchers", value);
    }

    /// <summary>
    /// Whether to run the entity annotator.
    /// </summary>
    public TerraformProperty<bool>? RunEntityAnnotator
    {
        get => GetProperty<TerraformProperty<bool>>("run_entity_annotator");
        set => WithProperty("run_entity_annotator", value);
    }

    /// <summary>
    /// Whether to run the intent annotator.
    /// </summary>
    public TerraformProperty<bool>? RunIntentAnnotator
    {
        get => GetProperty<TerraformProperty<bool>>("run_intent_annotator");
        set => WithProperty("run_intent_annotator", value);
    }

    /// <summary>
    /// Whether to run the interruption annotator.
    /// </summary>
    public TerraformProperty<bool>? RunInterruptionAnnotator
    {
        get => GetProperty<TerraformProperty<bool>>("run_interruption_annotator");
        set => WithProperty("run_interruption_annotator", value);
    }

    /// <summary>
    /// Whether to run the issue model annotator. A model should have already been
    /// deployed for this to take effect.
    /// </summary>
    public TerraformProperty<bool>? RunIssueModelAnnotator
    {
        get => GetProperty<TerraformProperty<bool>>("run_issue_model_annotator");
        set => WithProperty("run_issue_model_annotator", value);
    }

    /// <summary>
    /// Whether to run the active phrase matcher annotator(s).
    /// </summary>
    public TerraformProperty<bool>? RunPhraseMatcherAnnotator
    {
        get => GetProperty<TerraformProperty<bool>>("run_phrase_matcher_annotator");
        set => WithProperty("run_phrase_matcher_annotator", value);
    }

    /// <summary>
    /// Whether to run the QA annotator.
    /// </summary>
    public TerraformProperty<bool>? RunQaAnnotator
    {
        get => GetProperty<TerraformProperty<bool>>("run_qa_annotator");
        set => WithProperty("run_qa_annotator", value);
    }

    /// <summary>
    /// Whether to run the sentiment annotator.
    /// </summary>
    public TerraformProperty<bool>? RunSentimentAnnotator
    {
        get => GetProperty<TerraformProperty<bool>>("run_sentiment_annotator");
        set => WithProperty("run_sentiment_annotator", value);
    }

    /// <summary>
    /// Whether to run the silence annotator.
    /// </summary>
    public TerraformProperty<bool>? RunSilenceAnnotator
    {
        get => GetProperty<TerraformProperty<bool>>("run_silence_annotator");
        set => WithProperty("run_silence_annotator", value);
    }

    /// <summary>
    /// Whether to run the summarization annotator.
    /// </summary>
    public TerraformProperty<bool>? RunSummarizationAnnotator
    {
        get => GetProperty<TerraformProperty<bool>>("run_summarization_annotator");
        set => WithProperty("run_summarization_annotator", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock : TerraformBlock
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
/// Manages a google_contact_center_insights_analysis_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContactCenterInsightsAnalysisRule : TerraformResource
{
    public GoogleContactCenterInsightsAnalysisRule(string name) : base("google_contact_center_insights_analysis_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// If true, apply this rule to conversations. Otherwise, this rule is
    /// inactive and saved as a draft.
    /// </summary>
    public TerraformProperty<bool>? Active
    {
        get => GetProperty<TerraformProperty<bool>>("active");
        set => this.WithProperty("active", value);
    }

    /// <summary>
    /// Percentage of conversations that we should apply this analysis setting
    /// automatically, between [0, 1]. For example, 0.1 means 10%. Conversations
    /// are sampled in a determenestic way. The original runtime_percentage &amp;amp;
    /// upload percentage will be replaced by defining filters on the conversation.
    /// </summary>
    public TerraformProperty<double>? AnalysisPercentage
    {
        get => GetProperty<TerraformProperty<double>>("analysis_percentage");
        set => this.WithProperty("analysis_percentage", value);
    }

    /// <summary>
    /// Filter for the conversations that should apply this analysis
    /// rule. An empty filter means this analysis rule applies to all
    /// conversations.
    /// Refer to https://cloud.google.com/contact-center/insights/docs/filtering
    /// for details.
    /// </summary>
    public TerraformProperty<string>? ConversationFilter
    {
        get => GetProperty<TerraformProperty<string>>("conversation_filter");
        set => this.WithProperty("conversation_filter", value);
    }

    /// <summary>
    /// Display Name of the analysis rule.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for annotator_selector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnnotatorSelector block(s) allowed")]
    public List<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock>? AnnotatorSelector
    {
        get => GetProperty<List<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock>>("annotator_selector");
        set => this.WithProperty("annotator_selector", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time at which this analysis rule was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The resource name of the analysis rule. Randomly generated by Insights.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The most recent time at which this analysis rule was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
