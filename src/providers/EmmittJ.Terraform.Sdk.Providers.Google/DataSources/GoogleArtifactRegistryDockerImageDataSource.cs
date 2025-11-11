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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image name to fetch.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    [TerraformPropertyName("image_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ImageName { get; set; }

    /// <summary>
    /// The region of the artifact registry repository. For example, &amp;quot;us-west1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The last part of the repository name to fetch from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformPropertyName("repository_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepositoryId { get; set; }

    /// <summary>
    /// The time, as a RFC 3339 string, this image was built.
    /// </summary>
    [TerraformPropertyName("build_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BuildTime => new TerraformReference(this, "build_time");

    /// <summary>
    /// Calculated size of the image in bytes.
    /// </summary>
    [TerraformPropertyName("image_size_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageSizeBytes => new TerraformReference(this, "image_size_bytes");

    /// <summary>
    /// Media type of this image.
    /// </summary>
    [TerraformPropertyName("media_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MediaType => new TerraformReference(this, "media_type");

    /// <summary>
    /// The fully qualified name of the fetched image.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The URI to access the image.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// All tags associated with the image.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The time, as a RFC 3339 string, this image was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

    /// <summary>
    /// The time, as a RFC 3339 string, the image was uploaded.
    /// </summary>
    [TerraformPropertyName("upload_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UploadTime => new TerraformReference(this, "upload_time");

}
