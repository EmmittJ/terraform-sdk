using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for execution_controls in .
/// Nesting mode: list
/// </summary>
public class AwsConfigRemediationConfigurationExecutionControlsBlock
{
}

/// <summary>
/// Block type for parameter in .
/// Nesting mode: list
/// </summary>
public class AwsConfigRemediationConfigurationParameterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_value attribute.
    /// </summary>
    [TerraformPropertyName("resource_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceValue { get; set; }

    /// <summary>
    /// The static_value attribute.
    /// </summary>
    [TerraformPropertyName("static_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StaticValue { get; set; }

    /// <summary>
    /// The static_values attribute.
    /// </summary>
    [TerraformPropertyName("static_values")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> StaticValues { get; set; } = default!;

}

/// <summary>
/// Manages a aws_config_remediation_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigRemediationConfiguration : TerraformResource
{
    public AwsConfigRemediationConfiguration(string name) : base("aws_config_remediation_configuration", name)
    {
    }

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    [TerraformPropertyName("automatic")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Automatic { get; set; }

    /// <summary>
    /// The config_rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigRuleName is required")]
    [TerraformPropertyName("config_rule_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConfigRuleName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The maximum_automatic_attempts attribute.
    /// </summary>
    [TerraformPropertyName("maximum_automatic_attempts")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaximumAutomaticAttempts { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceType { get; set; }

    /// <summary>
    /// The retry_attempt_seconds attribute.
    /// </summary>
    [TerraformPropertyName("retry_attempt_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryAttemptSeconds { get; set; }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetId is required")]
    [TerraformPropertyName("target_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetId { get; set; }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetType is required")]
    [TerraformPropertyName("target_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetType { get; set; }

    /// <summary>
    /// The target_version attribute.
    /// </summary>
    [TerraformPropertyName("target_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetVersion { get; set; }

    /// <summary>
    /// Block for execution_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionControls block(s) allowed")]
    [TerraformPropertyName("execution_controls")]
    public TerraformList<TerraformBlock<AwsConfigRemediationConfigurationExecutionControlsBlock>>? ExecutionControls { get; set; }

    /// <summary>
    /// Block for parameter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 Parameter block(s) allowed")]
    [TerraformPropertyName("parameter")]
    public TerraformList<TerraformBlock<AwsConfigRemediationConfigurationParameterBlock>>? Parameter { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
