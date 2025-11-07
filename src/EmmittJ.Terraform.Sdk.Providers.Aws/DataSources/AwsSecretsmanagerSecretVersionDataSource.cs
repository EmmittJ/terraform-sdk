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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? SecretId
    {
        get => GetProperty<TerraformProperty<string>>("secret_id");
        set => this.WithProperty("secret_id", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformProperty<string>? VersionId
    {
        get => GetProperty<TerraformProperty<string>>("version_id");
        set => this.WithProperty("version_id", value);
    }

    /// <summary>
    /// The version_stage attribute.
    /// </summary>
    public TerraformProperty<string>? VersionStage
    {
        get => GetProperty<TerraformProperty<string>>("version_stage");
        set => this.WithProperty("version_stage", value);
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
