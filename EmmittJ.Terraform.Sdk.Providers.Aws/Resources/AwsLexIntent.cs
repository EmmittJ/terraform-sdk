using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lex_intent resource.
/// </summary>
public class AwsLexIntent : TerraformResource
{
    public AwsLexIntent(string name) : base("aws_lex_intent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("checksum");
        this.DeclareOutput("created_date");
        this.DeclareOutput("last_updated_date");
        this.DeclareOutput("version");
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
    /// The parent_intent_signature attribute.
    /// </summary>
    public string? ParentIntentSignature
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_intent_signature")?.Value;
        set => this.WithProperty("parent_intent_signature", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sample_utterances attribute.
    /// </summary>
    public HashSet<string>? SampleUtterances
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("sample_utterances")?.Value;
        set => this.WithProperty("sample_utterances", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDate => this["last_updated_date"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
