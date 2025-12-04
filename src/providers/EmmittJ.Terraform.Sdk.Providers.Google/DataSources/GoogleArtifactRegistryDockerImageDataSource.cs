using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_artifact_registry_docker_image Terraform data source.
/// Retrieves information about a google_artifact_registry_docker_image.
/// </summary>
public partial class GoogleArtifactRegistryDockerImageDataSource(string name) : TerraformDataSource("google_artifact_registry_docker_image", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image name to fetch.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The region of the artifact registry repository. For example, &amp;quot;us-west1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The last part of the repository name to fetch from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformValue<string> RepositoryId
    {
        get => GetArgument<TerraformValue<string>>("repository_id");
        set => SetArgument("repository_id", value);
    }

    /// <summary>
    /// The time, as a RFC 3339 string, this image was built.
    /// </summary>
    public TerraformValue<string> BuildTime
        => AsReference("build_time");

    /// <summary>
    /// Calculated size of the image in bytes.
    /// </summary>
    public TerraformValue<string> ImageSizeBytes
        => AsReference("image_size_bytes");

    /// <summary>
    /// Media type of this image.
    /// </summary>
    public TerraformValue<string> MediaType
        => AsReference("media_type");

    /// <summary>
    /// The fully qualified name of the fetched image.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The URI to access the image.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// All tags associated with the image.
    /// </summary>
    public TerraformList<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The time, as a RFC 3339 string, this image was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// The time, as a RFC 3339 string, the image was uploaded.
    /// </summary>
    public TerraformValue<string> UploadTime
        => AsReference("upload_time");

}
