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
        set => SetProperty("issue_models", value);
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
        set => SetProperty("phrase_matchers", value);
    }

    /// <summary>
    /// Whether to run the entity annotator.
    /// </summary>
    public TerraformProperty<bool>? RunEntityAnnotator
    {
        set => SetProperty("run_entity_annotator", value);
    }

    /// <summary>
    /// Whether to run the intent annotator.
    /// </summary>
    public TerraformProperty<bool>? RunIntentAnnotator
    {
        set => SetProperty("run_intent_annotator", value);
    }

    /// <summary>
    /// Whether to run the interruption annotator.
    /// </summary>
    public TerraformProperty<bool>? RunInterruptionAnnotator
    {
        set => SetProperty("run_interruption_annotator", value);
    }

    /// <summary>
    /// Whether to run the issue model annotator. A model should have already been
    /// deployed for this to take effect.
    /// </summary>
    public TerraformProperty<bool>? RunIssueModelAnnotator
    {
        set => SetProperty("run_issue_model_annotator", value);
    }

    /// <summary>
    /// Whether to run the active phrase matcher annotator(s).
    /// </summary>
    public TerraformProperty<bool>? RunPhraseMatcherAnnotator
    {
        set => SetProperty("run_phrase_matcher_annotator", value);
    }

    /// <summary>
    /// Whether to run the QA annotator.
    /// </summary>
    public TerraformProperty<bool>? RunQaAnnotator
    {
        set => SetProperty("run_qa_annotator", value);
    }

    /// <summary>
    /// Whether to run the sentiment annotator.
    /// </summary>
    public TerraformProperty<bool>? RunSentimentAnnotator
    {
        set => SetProperty("run_sentiment_annotator", value);
    }

    /// <summary>
    /// Whether to run the silence annotator.
    /// </summary>
    public TerraformProperty<bool>? RunSilenceAnnotator
    {
        set => SetProperty("run_silence_annotator", value);
    }

    /// <summary>
    /// Whether to run the summarization annotator.
    /// </summary>
    public TerraformProperty<bool>? RunSummarizationAnnotator
    {
        set => SetProperty("run_summarization_annotator", value);
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
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("active");
        SetOutput("analysis_percentage");
        SetOutput("conversation_filter");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// If true, apply this rule to conversations. Otherwise, this rule is
    /// inactive and saved as a draft.
    /// </summary>
    public TerraformProperty<bool> Active
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("active");
        set => SetProperty("active", value);
    }

    /// <summary>
    /// Percentage of conversations that we should apply this analysis setting
    /// automatically, between [0, 1]. For example, 0.1 means 10%. Conversations
    /// are sampled in a determenestic way. The original runtime_percentage &amp;amp;
    /// upload percentage will be replaced by defining filters on the conversation.
    /// </summary>
    public TerraformProperty<double> AnalysisPercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("analysis_percentage");
        set => SetProperty("analysis_percentage", value);
    }

    /// <summary>
    /// Filter for the conversations that should apply this analysis
    /// rule. An empty filter means this analysis rule applies to all
    /// conversations.
    /// Refer to https://cloud.google.com/contact-center/insights/docs/filtering
    /// for details.
    /// </summary>
    public TerraformProperty<string> ConversationFilter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("conversation_filter");
        set => SetProperty("conversation_filter", value);
    }

    /// <summary>
    /// Display Name of the analysis rule.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// Location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for annotator_selector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnnotatorSelector block(s) allowed")]
    public List<GoogleContactCenterInsightsAnalysisRuleAnnotatorSelectorBlock>? AnnotatorSelector
    {
        set => SetProperty("annotator_selector", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContactCenterInsightsAnalysisRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
