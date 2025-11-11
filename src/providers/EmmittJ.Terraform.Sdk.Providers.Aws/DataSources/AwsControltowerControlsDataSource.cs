using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_controltower_controls.
/// </summary>
public partial class AwsControltowerControlsDataSource : TerraformDataSource
{
    public AwsControltowerControlsDataSource(string name) : base("aws_controltower_controls", name)
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
    /// The target_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetIdentifier is required")]
    [TerraformProperty("target_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetIdentifier { get; set; }

    /// <summary>
    /// The enabled_controls attribute.
    /// </summary>
    [TerraformProperty("enabled_controls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> EnabledControls { get; }

}
