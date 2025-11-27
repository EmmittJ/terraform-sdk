using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lex_bot Terraform data source.
/// Retrieves information about a aws_lex_bot.
/// </summary>
public partial class AwsLexBotDataSource(string name) : TerraformDataSource("aws_lex_bot", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    public TerraformValue<string> Checksum
    {
        get => new TerraformReference<string>(this, "checksum");
    }

    /// <summary>
    /// The child_directed attribute.
    /// </summary>
    public TerraformValue<bool> ChildDirected
    {
        get => new TerraformReference<bool>(this, "child_directed");
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    public TerraformValue<bool> DetectSentiment
    {
        get => new TerraformReference<bool>(this, "detect_sentiment");
    }

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    public TerraformValue<bool> EnableModelImprovements
    {
        get => new TerraformReference<bool>(this, "enable_model_improvements");
    }

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformValue<string> FailureReason
    {
        get => new TerraformReference<string>(this, "failure_reason");
    }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> IdleSessionTtlInSeconds
    {
        get => new TerraformReference<double>(this, "idle_session_ttl_in_seconds");
    }

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
    {
        get => new TerraformReference<string>(this, "last_updated_date");
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformValue<string> Locale
    {
        get => new TerraformReference<string>(this, "locale");
    }

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    public TerraformValue<double> NluIntentConfidenceThreshold
    {
        get => new TerraformReference<double>(this, "nlu_intent_confidence_threshold");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    public TerraformValue<string> VoiceId
    {
        get => new TerraformReference<string>(this, "voice_id");
    }

}
