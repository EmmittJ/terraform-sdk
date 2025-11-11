using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lex_bot.
/// </summary>
public partial class AwsLexBotDataSource : TerraformDataSource
{
    public AwsLexBotDataSource(string name) : base("aws_lex_bot", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    [TerraformProperty("checksum")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Checksum { get; }

    /// <summary>
    /// The child_directed attribute.
    /// </summary>
    [TerraformProperty("child_directed")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ChildDirected { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    [TerraformProperty("detect_sentiment")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DetectSentiment { get; }

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    [TerraformProperty("enable_model_improvements")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableModelImprovements { get; }

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    [TerraformProperty("failure_reason")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FailureReason { get; }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    [TerraformProperty("idle_session_ttl_in_seconds")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> IdleSessionTtlInSeconds { get; }

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformProperty("last_updated_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdatedDate { get; }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformProperty("locale")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Locale { get; }

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    [TerraformProperty("nlu_intent_confidence_threshold")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NluIntentConfidenceThreshold { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    [TerraformProperty("voice_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VoiceId { get; }

}
