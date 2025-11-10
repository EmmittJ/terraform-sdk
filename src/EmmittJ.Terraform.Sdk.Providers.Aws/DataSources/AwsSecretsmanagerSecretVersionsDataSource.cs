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
    public TerraformProperty<bool>? IncludeDeprecated
    {
        get => GetProperty<TerraformProperty<bool>>("include_deprecated");
        set => this.WithProperty("include_deprecated", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformProperty<string> SecretId
    {
        get => GetProperty<TerraformProperty<string>>("secret_id");
        set => this.WithProperty("secret_id", value);
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
