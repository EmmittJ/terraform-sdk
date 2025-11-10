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
        SetOutput("rotation_enabled");
        SetOutput("rotation_lambda_arn");
        SetOutput("rotation_rules");
        SetOutput("id");
        SetOutput("region");
        SetOutput("secret_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformProperty<string> SecretId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_id");
        set => SetProperty("secret_id", value);
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
