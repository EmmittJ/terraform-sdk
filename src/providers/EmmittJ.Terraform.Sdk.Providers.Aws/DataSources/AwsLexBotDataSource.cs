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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    [TerraformPropertyName("checksum")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Checksum => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "checksum");

    /// <summary>
    /// The child_directed attribute.
    /// </summary>
    [TerraformPropertyName("child_directed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ChildDirected => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "child_directed");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    [TerraformPropertyName("detect_sentiment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DetectSentiment => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "detect_sentiment");

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    [TerraformPropertyName("enable_model_improvements")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableModelImprovements => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_model_improvements");

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    [TerraformPropertyName("failure_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FailureReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "failure_reason");

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("idle_session_ttl_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> IdleSessionTtlInSeconds => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "idle_session_ttl_in_seconds");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_date");

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Locale => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "locale");

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    [TerraformPropertyName("nlu_intent_confidence_threshold")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NluIntentConfidenceThreshold => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "nlu_intent_confidence_threshold");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    [TerraformPropertyName("voice_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VoiceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "voice_id");

}
