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
    public TerraformLiteralProperty<bool>? CreateVersion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_version");
        set => this.WithProperty("create_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_intent_signature attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParentIntentSignature
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_intent_signature");
        set => this.WithProperty("parent_intent_signature", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The sample_utterances attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SampleUtterances
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("sample_utterances");
        set => this.WithProperty("sample_utterances", value);
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
