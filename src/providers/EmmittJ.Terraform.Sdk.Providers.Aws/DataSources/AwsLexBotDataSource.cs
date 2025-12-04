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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    public TerraformValue<string> Checksum
        => AsReference("checksum");

    /// <summary>
    /// The child_directed attribute.
    /// </summary>
    public TerraformValue<bool> ChildDirected
        => AsReference("child_directed");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    public TerraformValue<bool> DetectSentiment
        => AsReference("detect_sentiment");

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    public TerraformValue<bool> EnableModelImprovements
        => AsReference("enable_model_improvements");

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformValue<string> FailureReason
        => AsReference("failure_reason");

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> IdleSessionTtlInSeconds
        => AsReference("idle_session_ttl_in_seconds");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
        => AsReference("last_updated_date");

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformValue<string> Locale
        => AsReference("locale");

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    public TerraformValue<double> NluIntentConfidenceThreshold
        => AsReference("nlu_intent_confidence_threshold");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    public TerraformValue<string> VoiceId
        => AsReference("voice_id");

}
