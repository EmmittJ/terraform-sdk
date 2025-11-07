using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Determines if allow stale reviews or approvals before merging to the branch.
    /// </summary>
    public TerraformProperty<bool>? AllowStaleReviews
    {
        get => GetProperty<TerraformProperty<bool>>("allow_stale_reviews");
        set => this.WithProperty("allow_stale_reviews", value);
    }

    /// <summary>
    /// The ID for the BranchRule.
    /// </summary>
    public TerraformProperty<string>? BranchRuleId
    {
        get => GetProperty<TerraformProperty<string>>("branch_rule_id");
        set => this.WithProperty("branch_rule_id", value);
    }

    /// <summary>
    /// Determines if the branch rule is disabled or not.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
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
    /// The BranchRule matches branches based on the specified regular expression. Use .* to match all branches.
    /// </summary>
    public TerraformProperty<string>? IncludePattern
    {
        get => GetProperty<TerraformProperty<string>>("include_pattern");
        set => this.WithProperty("include_pattern", value);
    }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The minimum number of approvals required for the branch rule to be matched.
    /// </summary>
    public TerraformProperty<double>? MinimumApprovalsCount
    {
        get => GetProperty<TerraformProperty<double>>("minimum_approvals_count");
        set => this.WithProperty("minimum_approvals_count", value);
    }

    /// <summary>
    /// The minimum number of reviews required for the branch rule to be matched.
    /// </summary>
    public TerraformProperty<double>? MinimumReviewsCount
    {
        get => GetProperty<TerraformProperty<double>>("minimum_reviews_count");
        set => this.WithProperty("minimum_reviews_count", value);
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
    public TerraformProperty<string>? RepositoryId
    {
        get => GetProperty<TerraformProperty<string>>("repository_id");
        set => this.WithProperty("repository_id", value);
    }

    /// <summary>
    /// Determines if require comments resolved before merging to the branch.
    /// </summary>
    public TerraformProperty<bool>? RequireCommentsResolved
    {
        get => GetProperty<TerraformProperty<bool>>("require_comments_resolved");
        set => this.WithProperty("require_comments_resolved", value);
    }

    /// <summary>
    /// Determines if require linear history before merging to the branch.
    /// </summary>
    public TerraformProperty<bool>? RequireLinearHistory
    {
        get => GetProperty<TerraformProperty<bool>>("require_linear_history");
        set => this.WithProperty("require_linear_history", value);
    }

    /// <summary>
    /// Determines if the branch rule requires a pull request or not.
    /// </summary>
    public TerraformProperty<bool>? RequirePullRequest
    {
        get => GetProperty<TerraformProperty<bool>>("require_pull_request");
        set => this.WithProperty("require_pull_request", value);
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
