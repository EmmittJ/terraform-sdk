using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_secretsmanager_secret_version resource.
/// </summary>
public class AwsSecretsmanagerSecretVersion : TerraformResource
{
    public AwsSecretsmanagerSecretVersion(string name) : base("aws_secretsmanager_secret_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("has_secret_string_wo");
        this.DeclareOutput("version_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The secret_binary attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretBinary
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_binary");
        set => this.WithProperty("secret_binary", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_id");
        set => this.WithProperty("secret_id", value);
    }

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_string");
        set => this.WithProperty("secret_string", value);
    }

    /// <summary>
    /// The secret_string_wo attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretStringWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_string_wo");
        set => this.WithProperty("secret_string_wo", value);
    }

    /// <summary>
    /// The secret_string_wo_version attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SecretStringWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("secret_string_wo_version");
        set => this.WithProperty("secret_string_wo_version", value);
    }

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? VersionStages
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("version_stages");
        set => this.WithProperty("version_stages", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The has_secret_string_wo attribute.
    /// </summary>
    public TerraformExpression HasSecretStringWo => this["has_secret_string_wo"];

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformExpression VersionId => this["version_id"];

}
