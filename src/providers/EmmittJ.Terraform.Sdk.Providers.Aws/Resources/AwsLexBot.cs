using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for abort_statement in .
/// Nesting mode: list
/// </summary>
public class AwsLexBotAbortStatementBlock
{
    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformPropertyName("response_card")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResponseCard { get; set; }

}

/// <summary>
/// Block type for clarification_prompt in .
/// Nesting mode: list
/// </summary>
public class AwsLexBotClarificationPromptBlock
{
    /// <summary>
    /// The max_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAttempts is required")]
    [TerraformPropertyName("max_attempts")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxAttempts { get; set; }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformPropertyName("response_card")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResponseCard { get; set; }

}

/// <summary>
/// Block type for intent in .
/// Nesting mode: set
/// </summary>
public class AwsLexBotIntentBlock
{
    /// <summary>
    /// The intent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentName is required")]
    [TerraformPropertyName("intent_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IntentName { get; set; }

    /// <summary>
    /// The intent_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentVersion is required")]
    [TerraformPropertyName("intent_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IntentVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexBotTimeoutsBlock
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
/// Manages a aws_lex_bot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLexBot : TerraformResource
{
    public AwsLexBot(string name) : base("aws_lex_bot", name)
    {
    }

    /// <summary>
    /// The child_directed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChildDirected is required")]
    [TerraformPropertyName("child_directed")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> ChildDirected { get; set; }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    [TerraformPropertyName("create_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CreateVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    [TerraformPropertyName("detect_sentiment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DetectSentiment { get; set; }

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    [TerraformPropertyName("enable_model_improvements")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableModelImprovements { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("idle_session_ttl_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IdleSessionTtlInSeconds { get; set; }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Locale { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    [TerraformPropertyName("nlu_intent_confidence_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NluIntentConfidenceThreshold { get; set; }

    /// <summary>
    /// The process_behavior attribute.
    /// </summary>
    [TerraformPropertyName("process_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProcessBehavior { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    [TerraformPropertyName("voice_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VoiceId { get; set; } = default!;

    /// <summary>
    /// Block for abort_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AbortStatement is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AbortStatement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AbortStatement block(s) allowed")]
    [TerraformPropertyName("abort_statement")]
    public TerraformList<TerraformBlock<AwsLexBotAbortStatementBlock>>? AbortStatement { get; set; }

    /// <summary>
    /// Block for clarification_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClarificationPrompt block(s) allowed")]
    [TerraformPropertyName("clarification_prompt")]
    public TerraformList<TerraformBlock<AwsLexBotClarificationPromptBlock>>? ClarificationPrompt { get; set; }

    /// <summary>
    /// Block for intent.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Intent is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(250, ErrorMessage = "Maximum 250 Intent block(s) allowed")]
    [TerraformPropertyName("intent")]
    public TerraformSet<TerraformBlock<AwsLexBotIntentBlock>>? Intent { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLexBotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    [TerraformPropertyName("checksum")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Checksum => new TerraformReference(this, "checksum");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedDate => new TerraformReference(this, "created_date");

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    [TerraformPropertyName("failure_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FailureReason => new TerraformReference(this, "failure_reason");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedDate => new TerraformReference(this, "last_updated_date");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
