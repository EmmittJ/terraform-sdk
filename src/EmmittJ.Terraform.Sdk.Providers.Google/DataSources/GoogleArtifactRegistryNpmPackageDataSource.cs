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
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("tags");
        this.DeclareOutput("update_time");
        this.DeclareOutput("version");
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
    /// The region of the Artifact Registry repository.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the Npm package.
    /// </summary>
    public TerraformLiteralProperty<string>? PackageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_name");
        set => this.WithProperty("package_name", value);
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
    /// The repository ID containing the Npm package.
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_id");
        set => this.WithProperty("repository_id", value);
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
