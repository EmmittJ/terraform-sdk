using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lex_bot.
/// </summary>
public class AwsLexBotDataSource : TerraformDataSource
{
    public AwsLexBotDataSource(string name) : base("aws_lex_bot", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

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
    /// The child_directed attribute.
    /// </summary>
    [TerraformPropertyName("child_directed")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ChildDirected => new TerraformReference(this, "child_directed");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedDate => new TerraformReference(this, "created_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    [TerraformPropertyName("detect_sentiment")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DetectSentiment => new TerraformReference(this, "detect_sentiment");

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    [TerraformPropertyName("enable_model_improvements")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableModelImprovements => new TerraformReference(this, "enable_model_improvements");

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    [TerraformPropertyName("failure_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FailureReason => new TerraformReference(this, "failure_reason");

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("idle_session_ttl_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> IdleSessionTtlInSeconds => new TerraformReference(this, "idle_session_ttl_in_seconds");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedDate => new TerraformReference(this, "last_updated_date");

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Locale => new TerraformReference(this, "locale");

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    [TerraformPropertyName("nlu_intent_confidence_threshold")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NluIntentConfidenceThreshold => new TerraformReference(this, "nlu_intent_confidence_threshold");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    [TerraformPropertyName("voice_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VoiceId => new TerraformReference(this, "voice_id");

}
