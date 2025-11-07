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
        this.DeclareOutput("build_time");
        this.DeclareOutput("image_size_bytes");
        this.DeclareOutput("media_type");
        this.DeclareOutput("name");
        this.DeclareOutput("self_link");
        this.DeclareOutput("tags");
        this.DeclareOutput("update_time");
        this.DeclareOutput("upload_time");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The image name to fetch.
    /// </summary>
    public TerraformLiteralProperty<string>? ImageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_name");
        set => this.WithProperty("image_name", value);
    }

    /// <summary>
    /// The region of the artifact registry repository. For example, &amp;quot;us-west1&amp;quot;.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The last part of the repository name to fetch from.
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_id");
        set => this.WithProperty("repository_id", value);
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
