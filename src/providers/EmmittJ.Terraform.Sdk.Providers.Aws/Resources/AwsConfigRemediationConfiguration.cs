using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for execution_controls in .
/// Nesting mode: list
/// </summary>
public partial class AwsConfigRemediationConfigurationExecutionControlsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for parameter in .
/// Nesting mode: list
/// </summary>
public partial class AwsConfigRemediationConfigurationParameterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_value attribute.
    /// </summary>
    [TerraformProperty("resource_value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceValue { get; set; }

    /// <summary>
    /// The static_value attribute.
    /// </summary>
    [TerraformProperty("static_value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StaticValue { get; set; }

    /// <summary>
    /// The static_values attribute.
    /// </summary>
    [TerraformProperty("static_values")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> StaticValues { get; set; }

}

/// <summary>
/// Manages a aws_config_remediation_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsConfigRemediationConfiguration : TerraformResource
{
    public AwsConfigRemediationConfiguration(string name) : base("aws_config_remediation_configuration", name)
    {
    }

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    [TerraformProperty("automatic")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Automatic { get; set; }

    /// <summary>
    /// The config_rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigRuleName is required")]
    [TerraformProperty("config_rule_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConfigRuleName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The maximum_automatic_attempts attribute.
    /// </summary>
    [TerraformProperty("maximum_automatic_attempts")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaximumAutomaticAttempts { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceType { get; set; }

    /// <summary>
    /// The retry_attempt_seconds attribute.
    /// </summary>
    [TerraformProperty("retry_attempt_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetryAttemptSeconds { get; set; }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetId is required")]
    [TerraformProperty("target_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetId { get; set; }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetType is required")]
    [TerraformProperty("target_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetType { get; set; }

    /// <summary>
    /// The target_version attribute.
    /// </summary>
    [TerraformProperty("target_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetVersion { get; set; }

    /// <summary>
    /// Block for execution_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionControls block(s) allowed")]
    [TerraformProperty("execution_controls")]
    public TerraformList<TerraformBlock<AwsConfigRemediationConfigurationExecutionControlsBlock>>? ExecutionControls { get; set; }

    /// <summary>
    /// Block for parameter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 Parameter block(s) allowed")]
    [TerraformProperty("parameter")]
    public TerraformList<TerraformBlock<AwsConfigRemediationConfigurationParameterBlock>>? Parameter { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
