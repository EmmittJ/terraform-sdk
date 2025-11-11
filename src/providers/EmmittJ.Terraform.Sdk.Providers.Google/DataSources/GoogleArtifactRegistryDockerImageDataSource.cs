using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_docker_image.
/// </summary>
public partial class GoogleArtifactRegistryDockerImageDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryDockerImageDataSource(string name) : base("google_artifact_registry_docker_image", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image name to fetch.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    [TerraformProperty("image_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ImageName { get; set; }

    /// <summary>
    /// The region of the artifact registry repository. For example, &amp;quot;us-west1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The last part of the repository name to fetch from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformProperty("repository_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryId { get; set; }

    /// <summary>
    /// The time, as a RFC 3339 string, this image was built.
    /// </summary>
    [TerraformProperty("build_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BuildTime { get; }

    /// <summary>
    /// Calculated size of the image in bytes.
    /// </summary>
    [TerraformProperty("image_size_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageSizeBytes { get; }

    /// <summary>
    /// Media type of this image.
    /// </summary>
    [TerraformProperty("media_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MediaType { get; }

    /// <summary>
    /// The fully qualified name of the fetched image.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The URI to access the image.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// All tags associated with the image.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Tags { get; }

    /// <summary>
    /// The time, as a RFC 3339 string, this image was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// The time, as a RFC 3339 string, the image was uploaded.
    /// </summary>
    [TerraformProperty("upload_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UploadTime { get; }

}
