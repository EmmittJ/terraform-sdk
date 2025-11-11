using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iam_testable_permissions.
/// </summary>
public partial class GoogleIamTestablePermissionsDataSource : TerraformDataSource
{
    public GoogleIamTestablePermissionsDataSource(string name) : base("google_iam_testable_permissions", name)
    {
    }

    /// <summary>
    /// The custom_support_level attribute.
    /// </summary>
    [TerraformProperty("custom_support_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomSupportLevel { get; set; }

    /// <summary>
    /// The full_resource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullResourceName is required")]
    [TerraformProperty("full_resource_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FullResourceName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The stages attribute.
    /// </summary>
    [TerraformProperty("stages")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Stages { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformProperty("permissions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Permissions { get; }

}
