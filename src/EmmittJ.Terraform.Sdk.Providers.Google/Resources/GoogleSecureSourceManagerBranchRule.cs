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
    public TerraformLiteralProperty<bool>? AllowStaleReviews
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_stale_reviews");
        set => this.WithProperty("allow_stale_reviews", value);
    }

    /// <summary>
    /// The ID for the BranchRule.
    /// </summary>
    public TerraformLiteralProperty<string>? BranchRuleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("branch_rule_id");
        set => this.WithProperty("branch_rule_id", value);
    }

    /// <summary>
    /// Determines if the branch rule is disabled or not.
    /// </summary>
    public TerraformLiteralProperty<bool>? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The BranchRule matches branches based on the specified regular expression. Use .* to match all branches.
    /// </summary>
    public TerraformLiteralProperty<string>? IncludePattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("include_pattern");
        set => this.WithProperty("include_pattern", value);
    }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The minimum number of approvals required for the branch rule to be matched.
    /// </summary>
    public TerraformLiteralProperty<double>? MinimumApprovalsCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("minimum_approvals_count");
        set => this.WithProperty("minimum_approvals_count", value);
    }

    /// <summary>
    /// The minimum number of reviews required for the branch rule to be matched.
    /// </summary>
    public TerraformLiteralProperty<double>? MinimumReviewsCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("minimum_reviews_count");
        set => this.WithProperty("minimum_reviews_count", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_id");
        set => this.WithProperty("repository_id", value);
    }

    /// <summary>
    /// Determines if require comments resolved before merging to the branch.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequireCommentsResolved
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_comments_resolved");
        set => this.WithProperty("require_comments_resolved", value);
    }

    /// <summary>
    /// Determines if require linear history before merging to the branch.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequireLinearHistory
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_linear_history");
        set => this.WithProperty("require_linear_history", value);
    }

    /// <summary>
    /// Determines if the branch rule requires a pull request or not.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequirePullRequest
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_pull_request");
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
