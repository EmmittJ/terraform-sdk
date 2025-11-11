using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_macie2_organization_configuration resource.
/// </summary>
public partial class AwsMacie2OrganizationConfiguration : TerraformResource
{
    public AwsMacie2OrganizationConfiguration(string name) : base("aws_macie2_organization_configuration", name)
    {
    }

    /// <summary>
    /// Whether to enable Amazon Macie automatically for accounts that are added to the organization in AWS Organizations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    [TerraformProperty("auto_enable")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AutoEnable { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
