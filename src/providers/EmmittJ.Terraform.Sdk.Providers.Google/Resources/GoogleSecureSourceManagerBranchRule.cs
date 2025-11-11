using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerBranchRuleTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_secure_source_manager_branch_rule resource.
/// </summary>
public class GoogleSecureSourceManagerBranchRule : TerraformResource
{
    public GoogleSecureSourceManagerBranchRule(string name) : base("google_secure_source_manager_branch_rule", name)
    {
    }

    /// <summary>
    /// Determines if allow stale reviews or approvals before merging to the branch.
    /// </summary>
    [TerraformPropertyName("allow_stale_reviews")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowStaleReviews { get; set; }

    /// <summary>
    /// The ID for the BranchRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchRuleId is required")]
    [TerraformPropertyName("branch_rule_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BranchRuleId { get; set; }

    /// <summary>
    /// Determines if the branch rule is disabled or not.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The BranchRule matches branches based on the specified regular expression. Use .* to match all branches.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludePattern is required")]
    [TerraformPropertyName("include_pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IncludePattern { get; set; }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The minimum number of approvals required for the branch rule to be matched.
    /// </summary>
    [TerraformPropertyName("minimum_approvals_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinimumApprovalsCount { get; set; }

    /// <summary>
    /// The minimum number of reviews required for the branch rule to be matched.
    /// </summary>
    [TerraformPropertyName("minimum_reviews_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinimumReviewsCount { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformPropertyName("repository_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepositoryId { get; set; }

    /// <summary>
    /// Determines if require comments resolved before merging to the branch.
    /// </summary>
    [TerraformPropertyName("require_comments_resolved")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireCommentsResolved { get; set; }

    /// <summary>
    /// Determines if require linear history before merging to the branch.
    /// </summary>
    [TerraformPropertyName("require_linear_history")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireLinearHistory { get; set; }

    /// <summary>
    /// Determines if the branch rule requires a pull request or not.
    /// </summary>
    [TerraformPropertyName("require_pull_request")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequirePullRequest { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSecureSourceManagerBranchRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the BranchRule was created in UTC.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The resource name for the BranchRule.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Unique identifier of the BranchRule.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// Time the BranchRule was updated in UTC.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
