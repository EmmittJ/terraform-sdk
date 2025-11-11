using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSecureSourceManagerBranchRuleTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_secure_source_manager_branch_rule resource.
/// </summary>
public partial class GoogleSecureSourceManagerBranchRule : TerraformResource
{
    public GoogleSecureSourceManagerBranchRule(string name) : base("google_secure_source_manager_branch_rule", name)
    {
    }

    /// <summary>
    /// Determines if allow stale reviews or approvals before merging to the branch.
    /// </summary>
    [TerraformProperty("allow_stale_reviews")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowStaleReviews { get; set; }

    /// <summary>
    /// The ID for the BranchRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchRuleId is required")]
    [TerraformProperty("branch_rule_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BranchRuleId { get; set; }

    /// <summary>
    /// Determines if the branch rule is disabled or not.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The BranchRule matches branches based on the specified regular expression. Use .* to match all branches.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludePattern is required")]
    [TerraformProperty("include_pattern")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IncludePattern { get; set; }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The minimum number of approvals required for the branch rule to be matched.
    /// </summary>
    [TerraformProperty("minimum_approvals_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinimumApprovalsCount { get; set; }

    /// <summary>
    /// The minimum number of reviews required for the branch rule to be matched.
    /// </summary>
    [TerraformProperty("minimum_reviews_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinimumReviewsCount { get; set; }

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
    /// Determines if require comments resolved before merging to the branch.
    /// </summary>
    [TerraformProperty("require_comments_resolved")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireCommentsResolved { get; set; }

    /// <summary>
    /// Determines if require linear history before merging to the branch.
    /// </summary>
    [TerraformProperty("require_linear_history")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireLinearHistory { get; set; }

    /// <summary>
    /// Determines if the branch rule requires a pull request or not.
    /// </summary>
    [TerraformProperty("require_pull_request")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequirePullRequest { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleSecureSourceManagerBranchRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the BranchRule was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The resource name for the BranchRule.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Unique identifier of the BranchRule.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Time the BranchRule was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
