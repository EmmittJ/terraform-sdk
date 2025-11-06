using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sourcerepo_repository.
/// </summary>
public class GoogleSourcerepoRepositoryDataSource : TerraformDataSource
{
    public GoogleSourcerepoRepositoryDataSource(string name) : base("google_sourcerepo_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_ignore_already_exists");
        this.DeclareOutput("pubsub_configs");
        this.DeclareOutput("size");
        this.DeclareOutput("url");
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
    /// Resource name of the repository, of the form &#39;{{repo}}&#39;.
    /// The repo name may contain slashes. eg, &#39;name/with/slash&#39;
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// If set to true, skip repository creation if a repository with the same name already exists.
    /// </summary>
    public TerraformExpression CreateIgnoreAlreadyExists => this["create_ignore_already_exists"];

    /// <summary>
    /// How this repository publishes a change in the repository through Cloud Pub/Sub.
    /// Keyed by the topic names.
    /// </summary>
    public TerraformExpression PubsubConfigs => this["pubsub_configs"];

    /// <summary>
    /// The disk usage of the repo, in bytes.
    /// </summary>
    public TerraformExpression Size => this["size"];

    /// <summary>
    /// URL to clone the repository from Google Cloud Source Repositories.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
