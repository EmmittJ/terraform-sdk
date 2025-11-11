using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_repositories.
/// </summary>
public class GoogleArtifactRegistryRepositoriesDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryRepositoriesDataSource(string name) : base("google_artifact_registry_repositories", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name_filter attribute.
    /// </summary>
    [TerraformPropertyName("name_filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NameFilter { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The repositories attribute.
    /// </summary>
    [TerraformPropertyName("repositories")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Repositories => new TerraformReference(this, "repositories");

}
