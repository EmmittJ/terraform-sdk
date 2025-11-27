using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for initial_config in GoogleSecureSourceManagerRepository.
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerRepositoryInitialConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initial_config";

    /// <summary>
    /// Default branch name of the repository.
    /// </summary>
    public TerraformValue<string>? DefaultBranch
    {
        get => new TerraformReference<string>(this, "default_branch");
        set => SetArgument("default_branch", value);
    }

    /// <summary>
    /// List of gitignore template names user can choose from.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    public TerraformList<string>? Gitignores
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "gitignores").ResolveNodes(ctx));
        set => SetArgument("gitignores", value);
    }

    /// <summary>
    /// License template name user can choose from.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    public TerraformValue<string>? License
    {
        get => new TerraformReference<string>(this, "license");
        set => SetArgument("license", value);
    }

    /// <summary>
    /// README template name.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    public TerraformValue<string>? Readme
    {
        get => new TerraformReference<string>(this, "readme");
        set => SetArgument("readme", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSecureSourceManagerRepository.
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerRepositoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_secure_source_manager_repository Terraform resource.
/// Manages a google_secure_source_manager_repository resource.
/// </summary>
public partial class GoogleSecureSourceManagerRepository(string name) : TerraformResource("google_secure_source_manager_repository", name)
{
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
    public TerraformValue<string>? DeletionPolicy
    {
        get => new TerraformReference<string>(this, "deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// Description of the repository, which cannot exceed 500 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the instance in which the repository is hosted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformValue<string> RepositoryId
    {
        get => new TerraformReference<string>(this, "repository_id");
        set => SetArgument("repository_id", value);
    }

    /// <summary>
    /// Time the repository was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The resource name for the Repository.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Unique identifier of the repository.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Time the repository was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// URIs for the repository.
    /// </summary>
    public TerraformList<TerraformMap<object>> Uris
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "uris").ResolveNodes(ctx));
    }

    /// <summary>
    /// InitialConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialConfig block(s) allowed")]
    public TerraformList<GoogleSecureSourceManagerRepositoryInitialConfigBlock>? InitialConfig
    {
        get => GetArgument<TerraformList<GoogleSecureSourceManagerRepositoryInitialConfigBlock>>("initial_config");
        set => SetArgument("initial_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSecureSourceManagerRepositoryTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSecureSourceManagerRepositoryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
