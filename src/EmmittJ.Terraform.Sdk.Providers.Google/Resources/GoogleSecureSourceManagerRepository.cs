using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for initial_config in .
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerRepositoryInitialConfigBlock : TerraformBlock
{
    /// <summary>
    /// Default branch name of the repository.
    /// </summary>
    public TerraformProperty<string>? DefaultBranch
    {
        get => GetProperty<TerraformProperty<string>>("default_branch");
        set => WithProperty("default_branch", value);
    }

    /// <summary>
    /// List of gitignore template names user can choose from.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    public List<TerraformProperty<string>>? Gitignores
    {
        get => GetProperty<List<TerraformProperty<string>>>("gitignores");
        set => WithProperty("gitignores", value);
    }

    /// <summary>
    /// License template name user can choose from.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    public TerraformProperty<string>? License
    {
        get => GetProperty<TerraformProperty<string>>("license");
        set => WithProperty("license", value);
    }

    /// <summary>
    /// README template name.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    public TerraformProperty<string>? Readme
    {
        get => GetProperty<TerraformProperty<string>>("readme");
        set => WithProperty("readme", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerRepositoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_secure_source_manager_repository resource.
/// </summary>
public class GoogleSecureSourceManagerRepository : TerraformResource
{
    public GoogleSecureSourceManagerRepository(string name) : base("google_secure_source_manager_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("uris");
    }

    /// <summary>
    /// The deletion policy for the repository. Setting &#39;ABANDON&#39; allows the resource
    /// to be abandoned, rather than deleted. Setting &#39;DELETE&#39; deletes the resource
    /// and all its contents. Setting &#39;PREVENT&#39; prevents the resource from accidental deletion
    /// by erroring out during plan.
    /// Default is &#39;PREVENT&#39;.  Possible values are:
    ///   * DELETE
    ///   * PREVENT
    ///   * ABANDON
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// Description of the repository, which cannot exceed 500 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name of the instance in which the repository is hosted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The ID for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformProperty<string> RepositoryId
    {
        get => GetProperty<TerraformProperty<string>>("repository_id");
        set => this.WithProperty("repository_id", value);
    }

    /// <summary>
    /// Block for initial_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialConfig block(s) allowed")]
    public List<GoogleSecureSourceManagerRepositoryInitialConfigBlock>? InitialConfig
    {
        get => GetProperty<List<GoogleSecureSourceManagerRepositoryInitialConfigBlock>>("initial_config");
        set => this.WithProperty("initial_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSecureSourceManagerRepositoryTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSecureSourceManagerRepositoryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Time the repository was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The resource name for the Repository.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Unique identifier of the repository.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time the repository was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// URIs for the repository.
    /// </summary>
    public TerraformExpression Uris => this["uris"];

}
