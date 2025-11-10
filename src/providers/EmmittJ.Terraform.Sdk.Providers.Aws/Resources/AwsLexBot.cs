using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for abort_statement in .
/// Nesting mode: list
/// </summary>
public class AwsLexBotAbortStatementBlock : TerraformBlock
{
    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseCard
    {
        set => SetProperty("response_card", value);
    }

}

/// <summary>
/// Block type for clarification_prompt in .
/// Nesting mode: list
/// </summary>
public class AwsLexBotClarificationPromptBlock : TerraformBlock
{
    /// <summary>
    /// The max_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAttempts is required")]
    public required TerraformProperty<double> MaxAttempts
    {
        set => SetProperty("max_attempts", value);
    }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseCard
    {
        set => SetProperty("response_card", value);
    }

}

/// <summary>
/// Block type for intent in .
/// Nesting mode: set
/// </summary>
public class AwsLexBotIntentBlock : TerraformBlock
{
    /// <summary>
    /// The intent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentName is required")]
    public required TerraformProperty<string> IntentName
    {
        set => SetProperty("intent_name", value);
    }

    /// <summary>
    /// The intent_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentVersion is required")]
    public required TerraformProperty<string> IntentVersion
    {
        set => SetProperty("intent_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexBotTimeoutsBlock : TerraformBlock
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
/// Manages a aws_lex_bot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLexBot : TerraformResource
{
    public AwsLexBot(string name) : base("aws_lex_bot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("checksum");
        SetOutput("created_date");
        SetOutput("failure_reason");
        SetOutput("last_updated_date");
        SetOutput("status");
        SetOutput("version");
        SetOutput("child_directed");
        SetOutput("create_version");
        SetOutput("description");
        SetOutput("detect_sentiment");
        SetOutput("enable_model_improvements");
        SetOutput("id");
        SetOutput("idle_session_ttl_in_seconds");
        SetOutput("locale");
        SetOutput("name");
        SetOutput("nlu_intent_confidence_threshold");
        SetOutput("process_behavior");
        SetOutput("region");
        SetOutput("voice_id");
    }

    /// <summary>
    /// The child_directed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChildDirected is required")]
    public required TerraformProperty<bool> ChildDirected
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("child_directed");
        set => SetProperty("child_directed", value);
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    public TerraformProperty<bool> CreateVersion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("create_version");
        set => SetProperty("create_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    public TerraformProperty<bool> DetectSentiment
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("detect_sentiment");
        set => SetProperty("detect_sentiment", value);
    }

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    public TerraformProperty<bool> EnableModelImprovements
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_model_improvements");
        set => SetProperty("enable_model_improvements", value);
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
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> IdleSessionTtlInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("idle_session_ttl_in_seconds");
        set => SetProperty("idle_session_ttl_in_seconds", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformProperty<string> Locale
    {
        get => GetRequiredOutput<TerraformProperty<string>>("locale");
        set => SetProperty("locale", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    public TerraformProperty<double> NluIntentConfidenceThreshold
    {
        get => GetRequiredOutput<TerraformProperty<double>>("nlu_intent_confidence_threshold");
        set => SetProperty("nlu_intent_confidence_threshold", value);
    }

    /// <summary>
    /// The process_behavior attribute.
    /// </summary>
    public TerraformProperty<string> ProcessBehavior
    {
        get => GetRequiredOutput<TerraformProperty<string>>("process_behavior");
        set => SetProperty("process_behavior", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    public TerraformProperty<string> VoiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("voice_id");
        set => SetProperty("voice_id", value);
    }

    /// <summary>
    /// Block for abort_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AbortStatement is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AbortStatement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AbortStatement block(s) allowed")]
    public List<AwsLexBotAbortStatementBlock>? AbortStatement
    {
        set => SetProperty("abort_statement", value);
    }

    /// <summary>
    /// Block for clarification_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClarificationPrompt block(s) allowed")]
    public List<AwsLexBotClarificationPromptBlock>? ClarificationPrompt
    {
        set => SetProperty("clarification_prompt", value);
    }

    /// <summary>
    /// Block for intent.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Intent is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(250, ErrorMessage = "Maximum 250 Intent block(s) allowed")]
    public HashSet<AwsLexBotIntentBlock>? Intent
    {
        set => SetProperty("intent", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLexBotTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    public TerraformExpression Checksum => this["checksum"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformExpression FailureReason => this["failure_reason"];

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDate => this["last_updated_date"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
