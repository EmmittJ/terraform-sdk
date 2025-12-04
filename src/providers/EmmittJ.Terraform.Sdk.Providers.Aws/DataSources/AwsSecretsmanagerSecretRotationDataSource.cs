using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_secretsmanager_secret_rotation Terraform data source.
/// Retrieves information about a aws_secretsmanager_secret_rotation.
/// </summary>
public partial class AwsSecretsmanagerSecretRotationDataSource(string name) : TerraformDataSource("aws_secretsmanager_secret_rotation", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformValue<string> SecretId
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_id");
        set => SetArgument("secret_id", value);
    }

    /// <summary>
    /// The rotation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RotationEnabled
        => AsReference("rotation_enabled");

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    public TerraformValue<string> RotationLambdaArn
        => AsReference("rotation_lambda_arn");

    /// <summary>
    /// The rotation_rules attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RotationRules
        => AsReference("rotation_rules");

}
