using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rotation_rules in .
/// Nesting mode: list
/// </summary>
public partial class AwsSecretsmanagerSecretRotationRotationRulesBlock : TerraformBlockBase
{
    /// <summary>
    /// The automatically_after_days attribute.
    /// </summary>
    [TerraformProperty("automatically_after_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AutomaticallyAfterDays { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformProperty("duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Duration { get; set; }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [TerraformProperty("schedule_expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScheduleExpression { get; set; }

}

/// <summary>
/// Manages a aws_secretsmanager_secret_rotation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSecretsmanagerSecretRotation : TerraformResource
{
    public AwsSecretsmanagerSecretRotation(string name) : base("aws_secretsmanager_secret_rotation", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rotate_immediately attribute.
    /// </summary>
    [TerraformProperty("rotate_immediately")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RotateImmediately { get; set; }

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    [TerraformProperty("rotation_lambda_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RotationLambdaArn { get; set; }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformProperty("secret_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecretId { get; set; }

    /// <summary>
    /// Block for rotation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RotationRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationRules block(s) allowed")]
    [TerraformProperty("rotation_rules")]
    public partial TerraformList<TerraformBlock<AwsSecretsmanagerSecretRotationRotationRulesBlock>>? RotationRules { get; set; }

    /// <summary>
    /// The rotation_enabled attribute.
    /// </summary>
    [TerraformProperty("rotation_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> RotationEnabled { get; }

}
