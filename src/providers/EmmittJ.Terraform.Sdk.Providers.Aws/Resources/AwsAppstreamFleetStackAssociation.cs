using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appstream_fleet_stack_association resource.
/// </summary>
public partial class AwsAppstreamFleetStackAssociation : TerraformResource
{
    public AwsAppstreamFleetStackAssociation(string name) : base("aws_appstream_fleet_stack_association", name)
    {
    }

    /// <summary>
    /// The fleet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FleetName is required")]
    [TerraformProperty("fleet_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FleetName { get; set; }

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
    /// The stack_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackName is required")]
    [TerraformProperty("stack_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StackName { get; set; }

}
