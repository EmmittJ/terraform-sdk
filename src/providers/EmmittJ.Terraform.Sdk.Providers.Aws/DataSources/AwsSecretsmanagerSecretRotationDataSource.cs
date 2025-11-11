using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_secretsmanager_secret_rotation.
/// </summary>
public class AwsSecretsmanagerSecretRotationDataSource : TerraformDataSource
{
    public AwsSecretsmanagerSecretRotationDataSource(string name) : base("aws_secretsmanager_secret_rotation", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformPropertyName("secret_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SecretId { get; set; }

    /// <summary>
    /// The rotation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("rotation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RotationEnabled => new TerraformReference(this, "rotation_enabled");

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    [TerraformPropertyName("rotation_lambda_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RotationLambdaArn => new TerraformReference(this, "rotation_lambda_arn");

    /// <summary>
    /// The rotation_rules attribute.
    /// </summary>
    [TerraformPropertyName("rotation_rules")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RotationRules => new TerraformReference(this, "rotation_rules");

}
