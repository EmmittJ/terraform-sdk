using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_projects.
/// </summary>
public partial class GoogleProjectsDataSource : TerraformDataSource
{
    public GoogleProjectsDataSource(string name) : base("google_projects", name)
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
    /// The projects attribute.
    /// </summary>
    [TerraformProperty("projects")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Projects { get; }

}
