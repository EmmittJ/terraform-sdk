using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_organizational_unit_child_accounts.
/// </summary>
public partial class AwsOrganizationsOrganizationalUnitChildAccountsDataSource : TerraformDataSource
{
    public AwsOrganizationsOrganizationalUnitChildAccountsDataSource(string name) : base("aws_organizations_organizational_unit_child_accounts", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    [TerraformProperty("parent_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ParentId { get; set; }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformProperty("accounts")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Accounts { get; }

}
