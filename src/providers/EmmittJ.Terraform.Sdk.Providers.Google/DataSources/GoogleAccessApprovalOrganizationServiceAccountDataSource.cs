using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_access_approval_organization_service_account.
/// </summary>
public class GoogleAccessApprovalOrganizationServiceAccountDataSource : TerraformDataSource
{
    public GoogleAccessApprovalOrganizationServiceAccountDataSource(string name) : base("google_access_approval_organization_service_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    [TerraformPropertyName("organization_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OrganizationId { get; set; }

    /// <summary>
    /// The account_email attribute.
    /// </summary>
    [TerraformPropertyName("account_email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccountEmail => new TerraformReference(this, "account_email");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
