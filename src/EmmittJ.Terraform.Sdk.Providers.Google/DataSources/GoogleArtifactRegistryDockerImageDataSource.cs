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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image name to fetch.
    /// </summary>
    public string? ImageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_name")?.Value;
        set => this.WithProperty("image_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region of the artifact registry repository. For example, &amp;quot;us-west1&amp;quot;.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The last part of the repository name to fetch from.
    /// </summary>
    public string? RepositoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_id")?.Value;
        set => this.WithProperty("repository_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
