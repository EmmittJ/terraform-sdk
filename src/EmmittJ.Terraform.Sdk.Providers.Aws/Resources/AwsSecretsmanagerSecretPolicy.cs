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
    public TerraformLiteralProperty<bool>? BlockPublicPolicy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("block_public_policy");
        set => this.WithProperty("block_public_policy", value);
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
    /// The policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy");
        set => this.WithProperty("policy", value);
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
    /// The secret_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_arn");
        set => this.WithProperty("secret_arn", value);
    }

}
