using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_tag.
/// </summary>
public class GoogleArtifactRegistryTagDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryTagDataSource(string name) : base("google_artifact_registry_tag", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("version");
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The package_name attribute.
    /// </summary>
    public string? PackageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_name")?.Value;
        set => this.WithProperty("package_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    public string? RepositoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_id")?.Value;
        set => this.WithProperty("repository_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tag_name attribute.
    /// </summary>
    public string? TagName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_name")?.Value;
        set => this.WithProperty("tag_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
