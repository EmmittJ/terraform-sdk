using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for repositories in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGeminiRepositoryGroupRepositoriesBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The Git branch pattern used for indexing in RE2 syntax.
    /// See https://github.com/google/re2/wiki/syntax for syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchPattern is required")]
    [TerraformProperty("branch_pattern")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BranchPattern { get; set; }

    /// <summary>
    /// Required. The DeveloperConnect repository full resource name, relative resource name
    /// or resource URL to be indexed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    [TerraformProperty("resource")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Resource { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGeminiRepositoryGroupTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_gemini_repository_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGeminiRepositoryGroup : TerraformResource
{
    public GoogleGeminiRepositoryGroup(string name) : base("google_gemini_repository_group", name)
    {
    }

    /// <summary>
    /// Required. Id of the Code Repository Index.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeRepositoryIndex is required")]
    [TerraformProperty("code_repository_index")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CodeRepositoryIndex { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional. Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the Code Repository Index, for example &#39;us-central1&#39;.
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
    /// Required. Id of the Repository Group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryGroupId is required")]
    [TerraformProperty("repository_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryGroupId { get; set; }

    /// <summary>
    /// Block for repositories.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repositories is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Repositories block(s) required")]
    [TerraformProperty("repositories")]
    public TerraformList<TerraformBlock<GoogleGeminiRepositoryGroupRepositoriesBlock>>? Repositories { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleGeminiRepositoryGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Create time stamp.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Immutable. Identifier. Name of Repository Group.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. Update time stamp.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
