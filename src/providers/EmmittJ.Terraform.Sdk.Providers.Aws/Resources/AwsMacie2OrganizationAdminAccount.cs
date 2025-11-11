using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_macie2_organization_admin_account resource.
/// </summary>
public partial class AwsMacie2OrganizationAdminAccount : TerraformResource
{
    public AwsMacie2OrganizationAdminAccount(string name) : base("aws_macie2_organization_admin_account", name)
    {
    }

    /// <summary>
    /// The admin_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccountId is required")]
    [TerraformProperty("admin_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AdminAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

}
