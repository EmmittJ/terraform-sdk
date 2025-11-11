using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_thing_group_membership resource.
/// </summary>
public partial class AwsIotThingGroupMembership : TerraformResource
{
    public AwsIotThingGroupMembership(string name) : base("aws_iot_thing_group_membership", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The override_dynamic_group attribute.
    /// </summary>
    [TerraformProperty("override_dynamic_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OverrideDynamicGroup { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The thing_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingGroupName is required")]
    [TerraformProperty("thing_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ThingGroupName { get; set; }

    /// <summary>
    /// The thing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingName is required")]
    [TerraformProperty("thing_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ThingName { get; set; }

}
