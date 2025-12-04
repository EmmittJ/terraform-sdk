using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_artifact_registry_docker_images Terraform data source.
/// Retrieves information about a google_artifact_registry_docker_images.
/// </summary>
public partial class GoogleArtifactRegistryDockerImagesDataSource(string name) : TerraformDataSource("google_artifact_registry_docker_images", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformValue<string> RepositoryId
    {
        get => GetArgument<TerraformValue<string>>("repository_id");
        set => SetArgument("repository_id", value);
    }

    /// <summary>
    /// The docker_images attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DockerImages
        => AsReference("docker_images");

}
