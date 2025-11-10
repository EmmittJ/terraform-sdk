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
        get => GetProperty<TerraformProperty<string>>("response_card");
        set => WithProperty("response_card", value);
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
        get => GetProperty<TerraformProperty<double>>("max_attempts");
        set => WithProperty("max_attempts", value);
    }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseCard
    {
        get => GetProperty<TerraformProperty<string>>("response_card");
        set => WithProperty("response_card", value);
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
        get => GetProperty<TerraformProperty<string>>("intent_name");
        set => WithProperty("intent_name", value);
    }

    /// <summary>
    /// The intent_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentVersion is required")]
    public required TerraformProperty<string> IntentVersion
    {
        get => GetProperty<TerraformProperty<string>>("intent_version");
        set => WithProperty("intent_version", value);
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
/// Manages a aws_lex_bot resource.
/// </summary>
public class AwsLexBot : TerraformResource
{
    public AwsLexBot(string name) : base("aws_lex_bot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("checksum");
        this.DeclareOutput("created_date");
        this.DeclareOutput("failure_reason");
        this.DeclareOutput("last_updated_date");
        this.DeclareOutput("status");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The child_directed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChildDirected is required")]
    public required TerraformProperty<bool> ChildDirected
    {
        get => GetProperty<TerraformProperty<bool>>("child_directed");
        set => this.WithProperty("child_directed", value);
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    public TerraformProperty<bool>? CreateVersion
    {
        get => GetProperty<TerraformProperty<bool>>("create_version");
        set => this.WithProperty("create_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    public TerraformProperty<bool>? DetectSentiment
    {
        get => GetProperty<TerraformProperty<bool>>("detect_sentiment");
        set => this.WithProperty("detect_sentiment", value);
    }

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableModelImprovements
    {
        get => GetProperty<TerraformProperty<bool>>("enable_model_improvements");
        set => this.WithProperty("enable_model_improvements", value);
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
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IdleSessionTtlInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("idle_session_ttl_in_seconds");
        set => this.WithProperty("idle_session_ttl_in_seconds", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformProperty<string>? Locale
    {
        get => GetProperty<TerraformProperty<string>>("locale");
        set => this.WithProperty("locale", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? NluIntentConfidenceThreshold
    {
        get => GetProperty<TerraformProperty<double>>("nlu_intent_confidence_threshold");
        set => this.WithProperty("nlu_intent_confidence_threshold", value);
    }

    /// <summary>
    /// The process_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? ProcessBehavior
    {
        get => GetProperty<TerraformProperty<string>>("process_behavior");
        set => this.WithProperty("process_behavior", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    public TerraformProperty<string>? VoiceId
    {
        get => GetProperty<TerraformProperty<string>>("voice_id");
        set => this.WithProperty("voice_id", value);
    }

    /// <summary>
    /// Block for abort_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AbortStatement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AbortStatement block(s) allowed")]
    public List<AwsLexBotAbortStatementBlock>? AbortStatement
    {
        get => GetProperty<List<AwsLexBotAbortStatementBlock>>("abort_statement");
        set => this.WithProperty("abort_statement", value);
    }

    /// <summary>
    /// Block for clarification_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClarificationPrompt block(s) allowed")]
    public List<AwsLexBotClarificationPromptBlock>? ClarificationPrompt
    {
        get => GetProperty<List<AwsLexBotClarificationPromptBlock>>("clarification_prompt");
        set => this.WithProperty("clarification_prompt", value);
    }

    /// <summary>
    /// Block for intent.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(250, ErrorMessage = "Maximum 250 Intent block(s) allowed")]
    public HashSet<AwsLexBotIntentBlock>? Intent
    {
        get => GetProperty<HashSet<AwsLexBotIntentBlock>>("intent");
        set => this.WithProperty("intent", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLexBotTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLexBotTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
