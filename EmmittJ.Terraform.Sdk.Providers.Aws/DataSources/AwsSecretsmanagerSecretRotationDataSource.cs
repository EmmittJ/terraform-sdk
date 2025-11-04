using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_secretsmanager_secret_rotation.
/// </summary>
public class AwsSecretsmanagerSecretRotationDataSource : TerraformDataSource
{
    public AwsSecretsmanagerSecretRotationDataSource(string name) : base("aws_secretsmanager_secret_rotation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("rotation_enabled");
        this.DeclareOutput("rotation_lambda_arn");
        this.DeclareOutput("rotation_rules");
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
    /// The rotation_enabled attribute.
    /// </summary>
    public TerraformExpression RotationEnabled => this["rotation_enabled"];

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    public TerraformExpression RotationLambdaArn => this["rotation_lambda_arn"];

    /// <summary>
    /// The rotation_rules attribute.
    /// </summary>
    public TerraformExpression RotationRules => this["rotation_rules"];

}
