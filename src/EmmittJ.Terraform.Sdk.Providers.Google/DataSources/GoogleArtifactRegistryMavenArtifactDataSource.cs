using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_maven_artifact.
/// </summary>
public class GoogleArtifactRegistryMavenArtifactDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryMavenArtifactDataSource(string name) : base("google_artifact_registry_maven_artifact", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("pom_uri");
        this.DeclareOutput("update_time");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The artifact_id attribute.
    /// </summary>
    public string? ArtifactId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("artifact_id")?.Value;
        set => this.WithProperty("artifact_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public string? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id")?.Value;
        set => this.WithProperty("group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The pom_uri attribute.
    /// </summary>
    public TerraformExpression PomUri => this["pom_uri"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
