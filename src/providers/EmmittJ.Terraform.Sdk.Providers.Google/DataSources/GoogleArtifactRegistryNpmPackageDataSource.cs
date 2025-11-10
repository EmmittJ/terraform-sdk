using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_npm_package.
/// </summary>
public class GoogleArtifactRegistryNpmPackageDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryNpmPackageDataSource(string name) : base("google_artifact_registry_npm_package", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("tags");
        SetOutput("update_time");
        SetOutput("version");
        SetOutput("id");
        SetOutput("location");
        SetOutput("package_name");
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
    /// The region of the Artifact Registry repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of the Npm package.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    public required TerraformProperty<string> PackageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("package_name");
        set => SetProperty("package_name", value);
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
    /// The repository ID containing the Npm package.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformProperty<string> RepositoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_id");
        set => SetProperty("repository_id", value);
    }

    /// <summary>
    /// The time the package was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The fully qualified name of the Npm package.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The tags associated with the Npm package.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The time the package was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// The version of the Npm package.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
