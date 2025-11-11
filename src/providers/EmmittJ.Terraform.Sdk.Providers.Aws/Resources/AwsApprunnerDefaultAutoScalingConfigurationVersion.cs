using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apprunner_default_auto_scaling_configuration_version resource.
/// </summary>
public partial class AwsApprunnerDefaultAutoScalingConfigurationVersion : TerraformResource
{
    public AwsApprunnerDefaultAutoScalingConfigurationVersion(string name) : base("aws_apprunner_default_auto_scaling_configuration_version", name)
    {
    }

    /// <summary>
    /// The auto_scaling_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingConfigurationArn is required")]
    [TerraformProperty("auto_scaling_configuration_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutoScalingConfigurationArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
