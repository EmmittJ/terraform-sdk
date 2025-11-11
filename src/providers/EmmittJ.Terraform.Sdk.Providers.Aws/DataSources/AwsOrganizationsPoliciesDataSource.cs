using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_policies.
/// </summary>
public partial class AwsOrganizationsPoliciesDataSource : TerraformDataSource
{
    public AwsOrganizationsPoliciesDataSource(string name) : base("aws_organizations_policies", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [TerraformProperty("ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Ids { get; }

}
