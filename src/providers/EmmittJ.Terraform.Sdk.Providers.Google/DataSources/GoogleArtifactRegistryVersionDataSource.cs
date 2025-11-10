using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_version.
/// </summary>
public class GoogleArtifactRegistryVersionDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryVersionDataSource(string name) : base("google_artifact_registry_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("annotations");
        SetOutput("create_time");
        SetOutput("description");
        SetOutput("name");
        SetOutput("related_tags");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("location");
        SetOutput("package_name");
        SetOutput("project");
        SetOutput("repository_id");
        SetOutput("version_name");
        SetOutput("view");
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The package_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    public required TerraformProperty<string> PackageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("package_name");
        set => SetProperty("package_name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformProperty<string> RepositoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_id");
        set => SetProperty("repository_id", value);
    }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionName is required")]
    public required TerraformProperty<string> VersionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_name");
        set => SetProperty("version_name", value);
    }

    /// <summary>
    /// The view attribute.
    /// </summary>
    public TerraformProperty<string> View
    {
        get => GetRequiredOutput<TerraformProperty<string>>("view");
        set => SetProperty("view", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformExpression Annotations => this["annotations"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The related_tags attribute.
    /// </summary>
    public TerraformExpression RelatedTags => this["related_tags"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
