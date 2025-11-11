using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_policy in .
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock
{
    /// <summary>
    /// The enabled_standard_arns attribute.
    /// </summary>
    [TerraformPropertyName("enabled_standard_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? EnabledStandardArns { get; set; }

    /// <summary>
    /// The service_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceEnabled is required")]
    [TerraformPropertyName("service_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> ServiceEnabled { get; set; }

}

/// <summary>
/// Manages a aws_securityhub_configuration_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSecurityhubConfigurationPolicy : TerraformResource
{
    public AwsSecurityhubConfigurationPolicy(string name) : base("aws_securityhub_configuration_policy", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for configuration_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConfigurationPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigurationPolicy block(s) allowed")]
    [TerraformPropertyName("configuration_policy")]
    public TerraformList<TerraformBlock<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock>>? ConfigurationPolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
