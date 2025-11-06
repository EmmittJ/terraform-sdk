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
        this.DeclareOutput("annotations");
        this.DeclareOutput("create_time");
        this.DeclareOutput("description");
        this.DeclareOutput("name");
        this.DeclareOutput("related_tags");
        this.DeclareOutput("update_time");
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
    /// The version_name attribute.
    /// </summary>
    public string? VersionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_name")?.Value;
        set => this.WithProperty("version_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The view attribute.
    /// </summary>
    public string? View
    {
        get => GetProperty<TerraformLiteralProperty<string>>("view")?.Value;
        set => this.WithProperty("view", value == null ? null : new TerraformLiteralProperty<string>(value));
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
