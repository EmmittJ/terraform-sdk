using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ami_launch_permission resource.
/// </summary>
public partial class AwsAmiLaunchPermission : TerraformResource
{
    public AwsAmiLaunchPermission(string name) : base("aws_ami_launch_permission", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountId { get; set; }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformProperty("group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageId is required")]
    [TerraformProperty("image_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ImageId { get; set; }

    /// <summary>
    /// The organization_arn attribute.
    /// </summary>
    [TerraformProperty("organization_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrganizationArn { get; set; }

    /// <summary>
    /// The organizational_unit_arn attribute.
    /// </summary>
    [TerraformProperty("organizational_unit_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrganizationalUnitArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
