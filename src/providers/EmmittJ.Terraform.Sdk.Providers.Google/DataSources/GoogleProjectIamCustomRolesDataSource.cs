using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_iam_custom_roles.
/// </summary>
public partial class GoogleProjectIamCustomRolesDataSource : TerraformDataSource
{
    public GoogleProjectIamCustomRolesDataSource(string name) : base("google_project_iam_custom_roles", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The show_deleted attribute.
    /// </summary>
    [TerraformProperty("show_deleted")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ShowDeleted { get; set; }

    /// <summary>
    /// The view attribute.
    /// </summary>
    [TerraformProperty("view")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? View { get; set; }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    [TerraformProperty("roles")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Roles { get; }

}
