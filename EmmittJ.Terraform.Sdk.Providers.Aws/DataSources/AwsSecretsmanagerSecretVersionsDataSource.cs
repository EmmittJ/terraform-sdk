using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_secretsmanager_secret_versions.
/// </summary>
public class AwsSecretsmanagerSecretVersionsDataSource : TerraformDataSource
{
    public AwsSecretsmanagerSecretVersionsDataSource(string name) : base("aws_secretsmanager_secret_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("name");
        this.DeclareOutput("versions");
    }

    /// <summary>
    /// The include_deprecated attribute.
    /// </summary>
    public bool? IncludeDeprecated
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_deprecated")?.Value;
        set => this.WithProperty("include_deprecated", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The versions attribute.
    /// </summary>
    public TerraformExpression Versions => this["versions"];

}
