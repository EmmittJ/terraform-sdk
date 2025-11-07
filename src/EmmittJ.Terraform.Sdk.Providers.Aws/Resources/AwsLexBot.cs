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
    public TerraformProperty<bool>? ChildDirected
    {
        get => GetProperty<TerraformProperty<bool>>("child_directed");
        set => this.WithProperty("child_directed", value);
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    public TerraformProperty<bool>? CreateVersion
    {
        get => GetProperty<TerraformProperty<bool>>("create_version");
        set => this.WithProperty("create_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    public TerraformProperty<bool>? DetectSentiment
    {
        get => GetProperty<TerraformProperty<bool>>("detect_sentiment");
        set => this.WithProperty("detect_sentiment", value);
    }

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableModelImprovements
    {
        get => GetProperty<TerraformProperty<bool>>("enable_model_improvements");
        set => this.WithProperty("enable_model_improvements", value);
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
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IdleSessionTtlInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("idle_session_ttl_in_seconds");
        set => this.WithProperty("idle_session_ttl_in_seconds", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformProperty<string>? Locale
    {
        get => GetProperty<TerraformProperty<string>>("locale");
        set => this.WithProperty("locale", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? NluIntentConfidenceThreshold
    {
        get => GetProperty<TerraformProperty<double>>("nlu_intent_confidence_threshold");
        set => this.WithProperty("nlu_intent_confidence_threshold", value);
    }

    /// <summary>
    /// The process_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? ProcessBehavior
    {
        get => GetProperty<TerraformProperty<string>>("process_behavior");
        set => this.WithProperty("process_behavior", value);
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
    /// The voice_id attribute.
    /// </summary>
    public TerraformProperty<string>? VoiceId
    {
        get => GetProperty<TerraformProperty<string>>("voice_id");
        set => this.WithProperty("voice_id", value);
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
