using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_sourcerepo_repository Terraform data source.
/// Retrieves information about a google_sourcerepo_repository.
/// </summary>
public partial class GoogleSourcerepoRepositoryDataSource(string name) : TerraformDataSource("google_sourcerepo_repository", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource name of the repository, of the form &#39;{{repo}}&#39;.
    /// The repo name may contain slashes. eg, &#39;name/with/slash&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// If set to true, skip repository creation if a repository with the same name already exists.
    /// </summary>
    public TerraformValue<bool> CreateIgnoreAlreadyExists
    {
        get => new TerraformReference<bool>(this, "create_ignore_already_exists");
    }

    /// <summary>
    /// How this repository publishes a change in the repository through Cloud Pub/Sub.
    /// Keyed by the topic names.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PubsubConfigs
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "pubsub_configs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The disk usage of the repo, in bytes.
    /// </summary>
    public TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
    }

    /// <summary>
    /// URL to clone the repository from Google Cloud Source Repositories.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

}
