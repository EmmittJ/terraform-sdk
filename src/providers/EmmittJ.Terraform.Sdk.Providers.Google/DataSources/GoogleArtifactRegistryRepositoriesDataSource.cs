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
        this.WithOutput("repositories");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name_filter attribute.
    /// </summary>
    public TerraformProperty<string>? NameFilter
    {
        get => GetProperty<TerraformProperty<string>>("name_filter");
        set => this.WithProperty("name_filter", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The repositories attribute.
    /// </summary>
    public TerraformExpression Repositories => this["repositories"];

}
