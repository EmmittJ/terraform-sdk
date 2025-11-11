using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_thing_principal_attachment resource.
/// </summary>
public partial class AwsIotThingPrincipalAttachment : TerraformResource
{
    public AwsIotThingPrincipalAttachment(string name) : base("aws_iot_thing_principal_attachment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Principal { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The thing attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thing is required")]
    [TerraformProperty("thing")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Thing { get; set; }

    /// <summary>
    /// The thing_principal_type attribute.
    /// </summary>
    [TerraformProperty("thing_principal_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ThingPrincipalType { get; set; }

}
