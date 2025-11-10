using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lex_bot.
/// </summary>
public class AwsLexBotDataSource : TerraformDataSource
{
    public AwsLexBotDataSource(string name) : base("aws_lex_bot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("checksum");
        SetOutput("child_directed");
        SetOutput("created_date");
        SetOutput("description");
        SetOutput("detect_sentiment");
        SetOutput("enable_model_improvements");
        SetOutput("failure_reason");
        SetOutput("idle_session_ttl_in_seconds");
        SetOutput("last_updated_date");
        SetOutput("locale");
        SetOutput("nlu_intent_confidence_threshold");
        SetOutput("status");
        SetOutput("voice_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("version");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
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
    /// The child_directed attribute.
    /// </summary>
    public TerraformExpression ChildDirected => this["child_directed"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    public TerraformExpression DetectSentiment => this["detect_sentiment"];

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    public TerraformExpression EnableModelImprovements => this["enable_model_improvements"];

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformExpression FailureReason => this["failure_reason"];

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformExpression IdleSessionTtlInSeconds => this["idle_session_ttl_in_seconds"];

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDate => this["last_updated_date"];

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformExpression Locale => this["locale"];

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    public TerraformExpression NluIntentConfidenceThreshold => this["nlu_intent_confidence_threshold"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    public TerraformExpression VoiceId => this["voice_id"];

}
