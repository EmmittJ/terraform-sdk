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
        this.WithOutput("create_ignore_already_exists");
        this.WithOutput("pubsub_configs");
        this.WithOutput("size");
        this.WithOutput("url");
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
    /// Resource name of the repository, of the form &#39;{{repo}}&#39;.
    /// The repo name may contain slashes. eg, &#39;name/with/slash&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
