using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled_standard_arns attribute.
    /// </summary>
    [TerraformProperty("enabled_standard_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EnabledStandardArns { get; set; }

    /// <summary>
    /// The service_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceEnabled is required")]
    [TerraformProperty("service_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> ServiceEnabled { get; set; }

}

/// <summary>
/// Manages a aws_securityhub_configuration_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSecurityhubConfigurationPolicy : TerraformResource
{
    public AwsSecurityhubConfigurationPolicy(string name) : base("aws_securityhub_configuration_policy", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for configuration_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConfigurationPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigurationPolicy block(s) allowed")]
    [TerraformProperty("configuration_policy")]
    public partial TerraformList<TerraformBlock<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock>>? ConfigurationPolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
