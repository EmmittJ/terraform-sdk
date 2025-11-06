using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lex_bot resource.
/// </summary>
public class AwsLexBot : TerraformResource
{
    public AwsLexBot(string name) : base("aws_lex_bot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("checksum");
        this.DeclareOutput("created_date");
        this.DeclareOutput("failure_reason");
        this.DeclareOutput("last_updated_date");
        this.DeclareOutput("status");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The child_directed attribute.
    /// </summary>
    public bool? ChildDirected
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("child_directed")?.Value;
        set => this.WithProperty("child_directed", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    public bool? CreateVersion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_version")?.Value;
        set => this.WithProperty("create_version", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    public bool? DetectSentiment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("detect_sentiment")?.Value;
        set => this.WithProperty("detect_sentiment", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    public bool? EnableModelImprovements
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_model_improvements")?.Value;
        set => this.WithProperty("enable_model_improvements", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public double? IdleSessionTtlInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_session_ttl_in_seconds")?.Value;
        set => this.WithProperty("idle_session_ttl_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public string? Locale
    {
        get => GetProperty<TerraformLiteralProperty<string>>("locale")?.Value;
        set => this.WithProperty("locale", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    public double? NluIntentConfidenceThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("nlu_intent_confidence_threshold")?.Value;
        set => this.WithProperty("nlu_intent_confidence_threshold", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The process_behavior attribute.
    /// </summary>
    public string? ProcessBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("process_behavior")?.Value;
        set => this.WithProperty("process_behavior", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The voice_id attribute.
    /// </summary>
    public string? VoiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("voice_id")?.Value;
        set => this.WithProperty("voice_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformExpression FailureReason => this["failure_reason"];

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDate => this["last_updated_date"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
