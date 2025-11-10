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
        set => SetProperty("default_branch", value);
    }

    /// <summary>
    /// List of gitignore template names user can choose from.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    public List<TerraformProperty<string>>? Gitignores
    {
        set => SetProperty("gitignores", value);
    }

    /// <summary>
    /// License template name user can choose from.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    public TerraformProperty<string>? License
    {
        set => SetProperty("license", value);
    }

    /// <summary>
    /// README template name.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    public TerraformProperty<string>? Readme
    {
        set => SetProperty("readme", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_secure_source_manager_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSecureSourceManagerRepository : TerraformResource
{
    public GoogleSecureSourceManagerRepository(string name) : base("google_secure_source_manager_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("uris");
        SetOutput("deletion_policy");
        SetOutput("description");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("location");
        SetOutput("project");
        SetOutput("repository_id");
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
    public TerraformProperty<string> DeletionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_policy");
        set => SetProperty("deletion_policy", value);
    }

    /// <summary>
    /// Description of the repository, which cannot exceed 500 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name of the instance in which the repository is hosted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformProperty<string> RepositoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_id");
        set => SetProperty("repository_id", value);
    }

    /// <summary>
    /// Block for initial_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialConfig block(s) allowed")]
    public List<GoogleSecureSourceManagerRepositoryInitialConfigBlock>? InitialConfig
    {
        set => SetProperty("initial_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSecureSourceManagerRepositoryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
