using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_group in .
/// Nesting mode: set
/// </summary>
public class AwsCodebuildWebhookFilterGroupBlock : TerraformBlock
{
}

/// <summary>
/// Block type for pull_request_build_policy in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildWebhookPullRequestBuildPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The approver_roles attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ApproverRoles
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("approver_roles");
        set => WithProperty("approver_roles", value);
    }

    /// <summary>
    /// The requires_comment_approval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequiresCommentApproval is required")]
    public required TerraformProperty<string> RequiresCommentApproval
    {
        get => GetRequiredProperty<TerraformProperty<string>>("requires_comment_approval");
        set => WithProperty("requires_comment_approval", value);
    }

}

/// <summary>
/// Block type for scope_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildWebhookScopeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => WithProperty("domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scope");
        set => WithProperty("scope", value);
    }

}

/// <summary>
/// Manages a aws_codebuild_webhook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodebuildWebhook : TerraformResource
{
    public AwsCodebuildWebhook(string name) : base("aws_codebuild_webhook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("payload_url");
        this.WithOutput("secret");
        this.WithOutput("url");
    }

    /// <summary>
    /// The branch_filter attribute.
    /// </summary>
    public TerraformProperty<string>? BranchFilter
    {
        get => GetProperty<TerraformProperty<string>>("branch_filter");
        set => this.WithProperty("branch_filter", value);
    }

    /// <summary>
    /// The build_type attribute.
    /// </summary>
    public TerraformProperty<string>? BuildType
    {
        get => GetProperty<TerraformProperty<string>>("build_type");
        set => this.WithProperty("build_type", value);
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
    /// The manual_creation attribute.
    /// </summary>
    public TerraformProperty<bool>? ManualCreation
    {
        get => GetProperty<TerraformProperty<bool>>("manual_creation");
        set => this.WithProperty("manual_creation", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformProperty<string> ProjectName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("project_name");
        set => this.WithProperty("project_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for filter_group.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodebuildWebhookFilterGroupBlock>? FilterGroup
    {
        get => GetProperty<HashSet<AwsCodebuildWebhookFilterGroupBlock>>("filter_group");
        set => this.WithProperty("filter_group", value);
    }

    /// <summary>
    /// Block for pull_request_build_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PullRequestBuildPolicy block(s) allowed")]
    public List<AwsCodebuildWebhookPullRequestBuildPolicyBlock>? PullRequestBuildPolicy
    {
        get => GetProperty<List<AwsCodebuildWebhookPullRequestBuildPolicyBlock>>("pull_request_build_policy");
        set => this.WithProperty("pull_request_build_policy", value);
    }

    /// <summary>
    /// Block for scope_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScopeConfiguration block(s) allowed")]
    public List<AwsCodebuildWebhookScopeConfigurationBlock>? ScopeConfiguration
    {
        get => GetProperty<List<AwsCodebuildWebhookScopeConfigurationBlock>>("scope_configuration");
        set => this.WithProperty("scope_configuration", value);
    }

    /// <summary>
    /// The payload_url attribute.
    /// </summary>
    public TerraformExpression PayloadUrl => this["payload_url"];

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformExpression Secret => this["secret"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
