using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_packages.
/// </summary>
public class GoogleArtifactRegistryPackagesDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryPackagesDataSource(string name) : base("google_artifact_registry_packages", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("packages");
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Filter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_id");
        set => this.WithProperty("repository_id", value);
    }

    /// <summary>
    /// The packages attribute.
    /// </summary>
    public TerraformExpression Packages => this["packages"];

}
