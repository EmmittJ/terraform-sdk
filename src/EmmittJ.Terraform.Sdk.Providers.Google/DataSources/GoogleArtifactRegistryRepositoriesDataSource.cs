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
        this.DeclareOutput("repositories");
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name_filter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NameFilter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_filter");
        set => this.WithProperty("name_filter", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The repositories attribute.
    /// </summary>
    public TerraformExpression Repositories => this["repositories"];

}
