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
    public bool? AllowStaleReviews
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_stale_reviews")?.Value;
        set => this.WithProperty("allow_stale_reviews", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ID for the BranchRule.
    /// </summary>
    public string? BranchRuleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("branch_rule_id")?.Value;
        set => this.WithProperty("branch_rule_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Determines if the branch rule is disabled or not.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The BranchRule matches branches based on the specified regular expression. Use .* to match all branches.
    /// </summary>
    public string? IncludePattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("include_pattern")?.Value;
        set => this.WithProperty("include_pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The minimum number of approvals required for the branch rule to be matched.
    /// </summary>
    public double? MinimumApprovalsCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("minimum_approvals_count")?.Value;
        set => this.WithProperty("minimum_approvals_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The minimum number of reviews required for the branch rule to be matched.
    /// </summary>
    public double? MinimumReviewsCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("minimum_reviews_count")?.Value;
        set => this.WithProperty("minimum_reviews_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    public string? RepositoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_id")?.Value;
        set => this.WithProperty("repository_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Determines if require comments resolved before merging to the branch.
    /// </summary>
    public bool? RequireCommentsResolved
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_comments_resolved")?.Value;
        set => this.WithProperty("require_comments_resolved", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Determines if require linear history before merging to the branch.
    /// </summary>
    public bool? RequireLinearHistory
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_linear_history")?.Value;
        set => this.WithProperty("require_linear_history", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Determines if the branch rule requires a pull request or not.
    /// </summary>
    public bool? RequirePullRequest
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_pull_request")?.Value;
        set => this.WithProperty("require_pull_request", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
