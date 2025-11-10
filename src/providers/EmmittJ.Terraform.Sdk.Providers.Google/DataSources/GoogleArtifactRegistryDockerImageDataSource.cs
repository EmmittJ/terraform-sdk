using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_docker_image.
/// </summary>
public class GoogleArtifactRegistryDockerImageDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryDockerImageDataSource(string name) : base("google_artifact_registry_docker_image", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The image name to fetch.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    [TerraformPropertyName("image_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ImageName { get; set; }

    /// <summary>
    /// The region of the artifact registry repository. For example, &amp;quot;us-west1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The last part of the repository name to fetch from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformPropertyName("repository_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryId { get; set; }

    /// <summary>
    /// The time, as a RFC 3339 string, this image was built.
    /// </summary>
    [TerraformPropertyName("build_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BuildTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "build_time");

    /// <summary>
    /// Calculated size of the image in bytes.
    /// </summary>
    [TerraformPropertyName("image_size_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageSizeBytes => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_size_bytes");

    /// <summary>
    /// Media type of this image.
    /// </summary>
    [TerraformPropertyName("media_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MediaType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "media_type");

    /// <summary>
    /// The fully qualified name of the fetched image.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The URI to access the image.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// All tags associated with the image.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Tags => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The time, as a RFC 3339 string, this image was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// The time, as a RFC 3339 string, the image was uploaded.
    /// </summary>
    [TerraformPropertyName("upload_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UploadTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "upload_time");

}
