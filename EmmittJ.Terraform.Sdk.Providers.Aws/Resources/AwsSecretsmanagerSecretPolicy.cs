using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_secretsmanager_secret_policy resource.
/// </summary>
public class AwsSecretsmanagerSecretPolicy : TerraformResource
{
    public AwsSecretsmanagerSecretPolicy(string name) : base("aws_secretsmanager_secret_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public bool? BlockPublicPolicy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("block_public_policy")?.Value;
        set => this.WithProperty("block_public_policy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public string? SecretArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_arn")?.Value;
        set => this.WithProperty("secret_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
