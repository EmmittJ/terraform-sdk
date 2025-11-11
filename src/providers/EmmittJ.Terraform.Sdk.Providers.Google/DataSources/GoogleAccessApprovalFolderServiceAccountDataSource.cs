using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_access_approval_folder_service_account.
/// </summary>
public partial class GoogleAccessApprovalFolderServiceAccountDataSource : TerraformDataSource
{
    public GoogleAccessApprovalFolderServiceAccountDataSource(string name) : base("google_access_approval_folder_service_account", name)
    {
    }

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    [TerraformProperty("folder_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FolderId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The account_email attribute.
    /// </summary>
    [TerraformProperty("account_email")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccountEmail { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
