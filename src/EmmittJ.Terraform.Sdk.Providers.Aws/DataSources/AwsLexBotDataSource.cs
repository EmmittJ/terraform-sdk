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
        this.DeclareOutput("arn");
        this.DeclareOutput("checksum");
        this.DeclareOutput("child_directed");
        this.DeclareOutput("created_date");
        this.DeclareOutput("description");
        this.DeclareOutput("detect_sentiment");
        this.DeclareOutput("enable_model_improvements");
        this.DeclareOutput("failure_reason");
        this.DeclareOutput("idle_session_ttl_in_seconds");
        this.DeclareOutput("last_updated_date");
        this.DeclareOutput("locale");
        this.DeclareOutput("nlu_intent_confidence_threshold");
        this.DeclareOutput("status");
        this.DeclareOutput("voice_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
