using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_secretsmanager_secret_policy Terraform resource.
/// Manages a aws_secretsmanager_secret_policy resource.
/// </summary>
public partial class AwsSecretsmanagerSecretPolicy(string name) : TerraformResource("aws_secretsmanager_secret_policy", name)
{
    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformValue<bool>? BlockPublicPolicy
    {
        get => new TerraformReference<bool>(this, "block_public_policy");
        set => SetArgument("block_public_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretArn is required")]
    public required TerraformValue<string> SecretArn
    {
        get => new TerraformReference<string>(this, "secret_arn");
        set => SetArgument("secret_arn", value);
    }

}
