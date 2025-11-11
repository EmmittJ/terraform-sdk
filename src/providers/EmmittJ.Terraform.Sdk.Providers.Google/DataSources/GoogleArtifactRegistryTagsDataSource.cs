using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_tags.
/// </summary>
public partial class GoogleArtifactRegistryTagsDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryTagsDataSource(string name) : base("google_artifact_registry_tags", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filter { get; set; }

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
    /// The package_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    [TerraformProperty("package_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PackageName { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformProperty("repository_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Tags { get; }

}
