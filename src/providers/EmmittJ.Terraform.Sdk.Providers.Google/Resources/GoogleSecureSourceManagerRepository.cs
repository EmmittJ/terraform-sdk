using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for initial_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSecureSourceManagerRepositoryInitialConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Default branch name of the repository.
    /// </summary>
    [TerraformProperty("default_branch")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultBranch { get; set; }

    /// <summary>
    /// List of gitignore template names user can choose from.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    [TerraformProperty("gitignores")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Gitignores { get; set; }

    /// <summary>
    /// License template name user can choose from.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    [TerraformProperty("license")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? License { get; set; }

    /// <summary>
    /// README template name.
    /// Valid values can be viewed at https://cloud.google.com/secure-source-manager/docs/reference/rest/v1/projects.locations.repositories#initialconfig.
    /// </summary>
    [TerraformProperty("readme")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Readme { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSecureSourceManagerRepositoryTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_secure_source_manager_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleSecureSourceManagerRepository : TerraformResource
{
    public GoogleSecureSourceManagerRepository(string name) : base("google_secure_source_manager_repository", name)
    {
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
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// Description of the repository, which cannot exceed 500 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the instance in which the repository is hosted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformProperty("repository_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryId { get; set; }

    /// <summary>
    /// Block for initial_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialConfig block(s) allowed")]
    [TerraformProperty("initial_config")]
    public TerraformList<TerraformBlock<GoogleSecureSourceManagerRepositoryInitialConfigBlock>>? InitialConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleSecureSourceManagerRepositoryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the repository was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The resource name for the Repository.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Unique identifier of the repository.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Time the repository was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// URIs for the repository.
    /// </summary>
    [TerraformProperty("uris")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Uris { get; }

}
