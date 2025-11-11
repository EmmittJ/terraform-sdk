using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_secretsmanager_secret_rotation.
/// </summary>
public partial class AwsSecretsmanagerSecretRotationDataSource : TerraformDataSource
{
    public AwsSecretsmanagerSecretRotationDataSource(string name) : base("aws_secretsmanager_secret_rotation", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformProperty("secret_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecretId { get; set; }

    /// <summary>
    /// The rotation_enabled attribute.
    /// </summary>
    [TerraformProperty("rotation_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RotationEnabled { get; }

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    [TerraformProperty("rotation_lambda_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RotationLambdaArn { get; }

    /// <summary>
    /// The rotation_rules attribute.
    /// </summary>
    [TerraformProperty("rotation_rules")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RotationRules { get; }

}
