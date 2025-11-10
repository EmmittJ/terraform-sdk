using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_registry_image.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class GoogleContainerRegistryImageDataSource : TerraformDataSource
{
    public GoogleContainerRegistryImageDataSource(string name) : base("google_container_registry_image", name)
    {
    }

    /// <summary>
    /// The digest attribute.
    /// </summary>
    [TerraformPropertyName("digest")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Digest { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tag { get; set; }

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    [TerraformPropertyName("image_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_url");

}
