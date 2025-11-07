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
    public TerraformLiteralProperty<string>? ArtifactId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("artifact_id");
        set => this.WithProperty("artifact_id", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
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
