using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_docker_image.
/// </summary>
public class GoogleArtifactRegistryDockerImageDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryDockerImageDataSource(string name) : base("google_artifact_registry_docker_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("build_time");
        SetOutput("image_size_bytes");
        SetOutput("media_type");
        SetOutput("name");
        SetOutput("self_link");
        SetOutput("tags");
        SetOutput("update_time");
        SetOutput("upload_time");
        SetOutput("id");
        SetOutput("image_name");
        SetOutput("location");
        SetOutput("project");
        SetOutput("repository_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The image name to fetch.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformProperty<string> ImageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_name");
        set => SetProperty("image_name", value);
    }

    /// <summary>
    /// The region of the artifact registry repository. For example, &amp;quot;us-west1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The last part of the repository name to fetch from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformProperty<string> RepositoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_id");
        set => SetProperty("repository_id", value);
    }

    /// <summary>
    /// The time, as a RFC 3339 string, this image was built.
    /// </summary>
    public TerraformExpression BuildTime => this["build_time"];

    /// <summary>
    /// Calculated size of the image in bytes.
    /// </summary>
    public TerraformExpression ImageSizeBytes => this["image_size_bytes"];

    /// <summary>
    /// Media type of this image.
    /// </summary>
    public TerraformExpression MediaType => this["media_type"];

    /// <summary>
    /// The fully qualified name of the fetched image.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The URI to access the image.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// All tags associated with the image.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The time, as a RFC 3339 string, this image was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// The time, as a RFC 3339 string, the image was uploaded.
    /// </summary>
    public TerraformExpression UploadTime => this["upload_time"];

}
