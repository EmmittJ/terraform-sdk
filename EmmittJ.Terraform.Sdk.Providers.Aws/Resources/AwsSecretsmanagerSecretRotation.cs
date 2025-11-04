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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rotate_immediately attribute.
    /// </summary>
    public bool? RotateImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("rotate_immediately")?.Value;
        set => this.WithProperty("rotate_immediately", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    public string? RotationLambdaArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rotation_lambda_arn")?.Value;
        set => this.WithProperty("rotation_lambda_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}
