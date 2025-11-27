using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleSecureSourceManagerBranchRule.
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerBranchRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_secure_source_manager_branch_rule Terraform resource.
/// Manages a google_secure_source_manager_branch_rule resource.
/// </summary>
public partial class GoogleSecureSourceManagerBranchRule(string name) : TerraformResource("google_secure_source_manager_branch_rule", name)
{
    /// <summary>
    /// Determines if allow stale reviews or approvals before merging to the branch.
    /// </summary>
    public TerraformValue<bool>? AllowStaleReviews
    {
        get => new TerraformReference<bool>(this, "allow_stale_reviews");
        set => SetArgument("allow_stale_reviews", value);
    }

    /// <summary>
    /// The ID for the BranchRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchRuleId is required")]
    public required TerraformValue<string> BranchRuleId
    {
        get => new TerraformReference<string>(this, "branch_rule_id");
        set => SetArgument("branch_rule_id", value);
    }

    /// <summary>
    /// Determines if the branch rule is disabled or not.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
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
    /// The BranchRule matches branches based on the specified regular expression. Use .* to match all branches.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludePattern is required")]
    public required TerraformValue<string> IncludePattern
    {
        get => new TerraformReference<string>(this, "include_pattern");
        set => SetArgument("include_pattern", value);
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
    /// The minimum number of approvals required for the branch rule to be matched.
    /// </summary>
    public TerraformValue<double>? MinimumApprovalsCount
    {
        get => new TerraformReference<double>(this, "minimum_approvals_count");
        set => SetArgument("minimum_approvals_count", value);
    }

    /// <summary>
    /// The minimum number of reviews required for the branch rule to be matched.
    /// </summary>
    public TerraformValue<double>? MinimumReviewsCount
    {
        get => new TerraformReference<double>(this, "minimum_reviews_count");
        set => SetArgument("minimum_reviews_count", value);
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
    /// Determines if require comments resolved before merging to the branch.
    /// </summary>
    public TerraformValue<bool>? RequireCommentsResolved
    {
        get => new TerraformReference<bool>(this, "require_comments_resolved");
        set => SetArgument("require_comments_resolved", value);
    }

    /// <summary>
    /// Determines if require linear history before merging to the branch.
    /// </summary>
    public TerraformValue<bool>? RequireLinearHistory
    {
        get => new TerraformReference<bool>(this, "require_linear_history");
        set => SetArgument("require_linear_history", value);
    }

    /// <summary>
    /// Determines if the branch rule requires a pull request or not.
    /// </summary>
    public TerraformValue<bool>? RequirePullRequest
    {
        get => new TerraformReference<bool>(this, "require_pull_request");
        set => SetArgument("require_pull_request", value);
    }

    /// <summary>
    /// Time the BranchRule was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The resource name for the BranchRule.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Unique identifier of the BranchRule.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Time the BranchRule was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSecureSourceManagerBranchRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSecureSourceManagerBranchRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
