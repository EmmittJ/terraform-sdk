using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rotation_rules in .
/// Nesting mode: list
/// </summary>
public class AwsSecretsmanagerSecretRotationRotationRulesBlock : ITerraformBlock
{
    /// <summary>
    /// The automatically_after_days attribute.
    /// </summary>
    [TerraformPropertyName("automatically_after_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AutomaticallyAfterDays { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformPropertyName("duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Duration { get; set; }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [TerraformPropertyName("schedule_expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScheduleExpression { get; set; }

}

/// <summary>
/// Manages a aws_secretsmanager_secret_rotation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSecretsmanagerSecretRotation : TerraformResource
{
    public AwsSecretsmanagerSecretRotation(string name) : base("aws_secretsmanager_secret_rotation", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The rotate_immediately attribute.
    /// </summary>
    [TerraformPropertyName("rotate_immediately")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RotateImmediately { get; set; }

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    [TerraformPropertyName("rotation_lambda_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RotationLambdaArn { get; set; }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformPropertyName("secret_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecretId { get; set; }

    /// <summary>
    /// Block for rotation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RotationRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationRules block(s) allowed")]
    [TerraformPropertyName("rotation_rules")]
    public TerraformList<TerraformBlock<AwsSecretsmanagerSecretRotationRotationRulesBlock>>? RotationRules { get; set; } = new();

    /// <summary>
    /// The rotation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("rotation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RotationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "rotation_enabled");

}
