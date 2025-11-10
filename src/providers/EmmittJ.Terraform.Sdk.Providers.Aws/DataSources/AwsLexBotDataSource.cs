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
        this.WithOutput("arn");
        this.WithOutput("checksum");
        this.WithOutput("child_directed");
        this.WithOutput("created_date");
        this.WithOutput("description");
        this.WithOutput("detect_sentiment");
        this.WithOutput("enable_model_improvements");
        this.WithOutput("failure_reason");
        this.WithOutput("idle_session_ttl_in_seconds");
        this.WithOutput("last_updated_date");
        this.WithOutput("locale");
        this.WithOutput("nlu_intent_confidence_threshold");
        this.WithOutput("status");
        this.WithOutput("voice_id");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
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
