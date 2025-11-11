using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iam_role.
/// </summary>
public partial class GoogleIamRoleDataSource : TerraformDataSource
{
    public GoogleIamRoleDataSource(string name) : base("google_iam_role", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The included_permissions attribute.
    /// </summary>
    [TerraformProperty("included_permissions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> IncludedPermissions { get; }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [TerraformProperty("stage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Stage { get; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformProperty("title")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Title { get; }

}
