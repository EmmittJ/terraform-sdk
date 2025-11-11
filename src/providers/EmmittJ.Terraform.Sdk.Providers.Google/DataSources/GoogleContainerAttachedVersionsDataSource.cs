using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_attached_versions.
/// </summary>
public partial class GoogleContainerAttachedVersionsDataSource : TerraformDataSource
{
    public GoogleContainerAttachedVersionsDataSource(string name) : base("google_container_attached_versions", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformProperty("project")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The valid_versions attribute.
    /// </summary>
    [TerraformProperty("valid_versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ValidVersions { get; }

}
