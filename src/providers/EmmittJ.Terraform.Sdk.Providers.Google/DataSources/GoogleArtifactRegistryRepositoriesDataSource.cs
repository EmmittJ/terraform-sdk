using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_repositories.
/// </summary>
public class GoogleArtifactRegistryRepositoriesDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryRepositoriesDataSource(string name) : base("google_artifact_registry_repositories", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("repositories");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name_filter");
        SetOutput("project");
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
    /// The name_filter attribute.
    /// </summary>
    public TerraformProperty<string> NameFilter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_filter");
        set => SetProperty("name_filter", value);
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
    /// The repositories attribute.
    /// </summary>
    public TerraformExpression Repositories => this["repositories"];

}
