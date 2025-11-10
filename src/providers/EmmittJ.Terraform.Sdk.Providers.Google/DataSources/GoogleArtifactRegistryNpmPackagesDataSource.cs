using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_npm_packages.
/// </summary>
public class GoogleArtifactRegistryNpmPackagesDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryNpmPackagesDataSource(string name) : base("google_artifact_registry_npm_packages", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformPropertyName("repository_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryId { get; set; }

    /// <summary>
    /// The npm_packages attribute.
    /// </summary>
    [TerraformPropertyName("npm_packages")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NpmPackages => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "npm_packages");

}
