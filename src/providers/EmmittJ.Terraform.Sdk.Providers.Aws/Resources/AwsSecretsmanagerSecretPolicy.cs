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
        SetOutput("block_public_policy");
        SetOutput("id");
        SetOutput("policy");
        SetOutput("region");
        SetOutput("secret_arn");
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformProperty<bool> BlockPublicPolicy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("block_public_policy");
        set => SetProperty("block_public_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformProperty<string> Policy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy");
        set => SetProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretArn is required")]
    public required TerraformProperty<string> SecretArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_arn");
        set => SetProperty("secret_arn", value);
    }

}
