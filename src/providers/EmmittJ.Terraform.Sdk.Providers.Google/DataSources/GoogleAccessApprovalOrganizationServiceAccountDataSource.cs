using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_access_approval_organization_service_account.
/// </summary>
public partial class GoogleAccessApprovalOrganizationServiceAccountDataSource : TerraformDataSource
{
    public GoogleAccessApprovalOrganizationServiceAccountDataSource(string name) : base("google_access_approval_organization_service_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    [TerraformProperty("organization_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrganizationId { get; set; }

    /// <summary>
    /// The account_email attribute.
    /// </summary>
    [TerraformProperty("account_email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccountEmail { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
