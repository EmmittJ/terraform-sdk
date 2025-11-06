using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_sourcerepo_repository resource.
/// </summary>
public class GoogleSourcerepoRepository : TerraformResource
{
    public GoogleSourcerepoRepository(string name) : base("google_sourcerepo_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("size");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// If set to true, skip repository creation if a repository with the same name already exists.
    /// </summary>
    public bool? CreateIgnoreAlreadyExists
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_ignore_already_exists")?.Value;
        set => this.WithProperty("create_ignore_already_exists", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The disk usage of the repo, in bytes.
    /// </summary>
    public TerraformExpression Size => this["size"];

    /// <summary>
    /// URL to clone the repository from Google Cloud Source Repositories.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
