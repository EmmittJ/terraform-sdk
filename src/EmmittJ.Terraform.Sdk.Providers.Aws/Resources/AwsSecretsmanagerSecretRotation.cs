using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_secretsmanager_secret_rotation resource.
/// </summary>
public class AwsSecretsmanagerSecretRotation : TerraformResource
{
    public AwsSecretsmanagerSecretRotation(string name) : base("aws_secretsmanager_secret_rotation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("rotation_enabled");
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
    /// The rotate_immediately attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RotateImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("rotate_immediately");
        set => this.WithProperty("rotate_immediately", value);
    }

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RotationLambdaArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rotation_lambda_arn");
        set => this.WithProperty("rotation_lambda_arn", value);
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
    /// The rotation_enabled attribute.
    /// </summary>
    public TerraformExpression RotationEnabled => this["rotation_enabled"];

}
