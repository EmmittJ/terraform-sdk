using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_secretsmanager_secret_version.
/// </summary>
public class AwsSecretsmanagerSecretVersionDataSource : TerraformDataSource
{
    public AwsSecretsmanagerSecretVersionDataSource(string name) : base("aws_secretsmanager_secret_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_date");
        this.DeclareOutput("secret_binary");
        this.DeclareOutput("secret_string");
        this.DeclareOutput("version_stages");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    public string? SecretId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_id")?.Value;
        set => this.WithProperty("secret_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public string? VersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_id")?.Value;
        set => this.WithProperty("version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_stage attribute.
    /// </summary>
    public string? VersionStage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_stage")?.Value;
        set => this.WithProperty("version_stage", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The secret_binary attribute.
    /// </summary>
    public TerraformExpression SecretBinary => this["secret_binary"];

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    public TerraformExpression SecretString => this["secret_string"];

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    public TerraformExpression VersionStages => this["version_stages"];

}
