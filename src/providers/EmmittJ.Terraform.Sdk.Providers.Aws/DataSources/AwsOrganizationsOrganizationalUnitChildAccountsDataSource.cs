using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_organizational_unit_child_accounts.
/// </summary>
public class AwsOrganizationsOrganizationalUnitChildAccountsDataSource : TerraformDataSource
{
    public AwsOrganizationsOrganizationalUnitChildAccountsDataSource(string name) : base("aws_organizations_organizational_unit_child_accounts", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    [TerraformPropertyName("parent_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ParentId { get; set; }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Accounts => new TerraformReference(this, "accounts");

}
