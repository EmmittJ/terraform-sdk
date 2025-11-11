using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for abort_statement in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexBotAbortStatementBlock : TerraformBlockBase
{
    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformProperty("response_card")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResponseCard { get; set; }

}

/// <summary>
/// Block type for clarification_prompt in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexBotClarificationPromptBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAttempts is required")]
    [TerraformProperty("max_attempts")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxAttempts { get; set; }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformProperty("response_card")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResponseCard { get; set; }

}

/// <summary>
/// Block type for intent in .
/// Nesting mode: set
/// </summary>
public partial class AwsLexBotIntentBlock : TerraformBlockBase
{
    /// <summary>
    /// The intent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentName is required")]
    [TerraformProperty("intent_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IntentName { get; set; }

    /// <summary>
    /// The intent_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentVersion is required")]
    [TerraformProperty("intent_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IntentVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLexBotTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_lex_bot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLexBot : TerraformResource
{
    public AwsLexBot(string name) : base("aws_lex_bot", name)
    {
    }

    /// <summary>
    /// The child_directed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChildDirected is required")]
    [TerraformProperty("child_directed")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> ChildDirected { get; set; }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    [TerraformProperty("create_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CreateVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    [TerraformProperty("detect_sentiment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DetectSentiment { get; set; }

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    [TerraformProperty("enable_model_improvements")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableModelImprovements { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    [TerraformProperty("idle_session_ttl_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IdleSessionTtlInSeconds { get; set; }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformProperty("locale")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Locale { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    [TerraformProperty("nlu_intent_confidence_threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NluIntentConfidenceThreshold { get; set; }

    /// <summary>
    /// The process_behavior attribute.
    /// </summary>
    [TerraformProperty("process_behavior")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProcessBehavior { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    [TerraformProperty("voice_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VoiceId { get; set; }

    /// <summary>
    /// Block for abort_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AbortStatement is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AbortStatement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AbortStatement block(s) allowed")]
    [TerraformProperty("abort_statement")]
    public partial TerraformList<TerraformBlock<AwsLexBotAbortStatementBlock>>? AbortStatement { get; set; }

    /// <summary>
    /// Block for clarification_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClarificationPrompt block(s) allowed")]
    [TerraformProperty("clarification_prompt")]
    public partial TerraformList<TerraformBlock<AwsLexBotClarificationPromptBlock>>? ClarificationPrompt { get; set; }

    /// <summary>
    /// Block for intent.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Intent is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(250, ErrorMessage = "Maximum 250 Intent block(s) allowed")]
    [TerraformProperty("intent")]
    public partial TerraformSet<TerraformBlock<AwsLexBotIntentBlock>>? Intent { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsLexBotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    [TerraformProperty("checksum")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Checksum { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    [TerraformProperty("failure_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FailureReason { get; }

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformProperty("last_updated_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdatedDate { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

}
