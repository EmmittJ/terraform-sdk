using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerBranchRuleTimeoutsBlock : TerraformBlock
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
/// Manages a google_secure_source_manager_branch_rule resource.
/// </summary>
public class GoogleSecureSourceManagerBranchRule : TerraformResource
{
    public GoogleSecureSourceManagerBranchRule(string name) : base("google_secure_source_manager_branch_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("allow_stale_reviews");
        SetOutput("branch_rule_id");
        SetOutput("disabled");
        SetOutput("id");
        SetOutput("include_pattern");
        SetOutput("location");
        SetOutput("minimum_approvals_count");
        SetOutput("minimum_reviews_count");
        SetOutput("project");
        SetOutput("repository_id");
        SetOutput("require_comments_resolved");
        SetOutput("require_linear_history");
        SetOutput("require_pull_request");
    }

    /// <summary>
    /// Determines if allow stale reviews or approvals before merging to the branch.
    /// </summary>
    public TerraformProperty<bool> AllowStaleReviews
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_stale_reviews");
        set => SetProperty("allow_stale_reviews", value);
    }

    /// <summary>
    /// The ID for the BranchRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchRuleId is required")]
    public required TerraformProperty<string> BranchRuleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("branch_rule_id");
        set => SetProperty("branch_rule_id", value);
    }

    /// <summary>
    /// Determines if the branch rule is disabled or not.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
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
    /// The BranchRule matches branches based on the specified regular expression. Use .* to match all branches.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludePattern is required")]
    public required TerraformProperty<string> IncludePattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("include_pattern");
        set => SetProperty("include_pattern", value);
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
    /// The minimum number of approvals required for the branch rule to be matched.
    /// </summary>
    public TerraformProperty<double> MinimumApprovalsCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("minimum_approvals_count");
        set => SetProperty("minimum_approvals_count", value);
    }

    /// <summary>
    /// The minimum number of reviews required for the branch rule to be matched.
    /// </summary>
    public TerraformProperty<double> MinimumReviewsCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("minimum_reviews_count");
        set => SetProperty("minimum_reviews_count", value);
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
    /// Determines if require comments resolved before merging to the branch.
    /// </summary>
    public TerraformProperty<bool> RequireCommentsResolved
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_comments_resolved");
        set => SetProperty("require_comments_resolved", value);
    }

    /// <summary>
    /// Determines if require linear history before merging to the branch.
    /// </summary>
    public TerraformProperty<bool> RequireLinearHistory
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_linear_history");
        set => SetProperty("require_linear_history", value);
    }

    /// <summary>
    /// Determines if the branch rule requires a pull request or not.
    /// </summary>
    public TerraformProperty<bool> RequirePullRequest
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_pull_request");
        set => SetProperty("require_pull_request", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSecureSourceManagerBranchRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Time the BranchRule was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The resource name for the BranchRule.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Unique identifier of the BranchRule.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time the BranchRule was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
