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
        set => SetProperty("approver_roles", value);
    }

    /// <summary>
    /// The requires_comment_approval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequiresCommentApproval is required")]
    public required TerraformProperty<string> RequiresCommentApproval
    {
        set => SetProperty("requires_comment_approval", value);
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
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        set => SetProperty("scope", value);
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
        SetOutput("payload_url");
        SetOutput("secret");
        SetOutput("url");
        SetOutput("branch_filter");
        SetOutput("build_type");
        SetOutput("id");
        SetOutput("manual_creation");
        SetOutput("project_name");
        SetOutput("region");
    }

    /// <summary>
    /// The branch_filter attribute.
    /// </summary>
    public TerraformProperty<string> BranchFilter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("branch_filter");
        set => SetProperty("branch_filter", value);
    }

    /// <summary>
    /// The build_type attribute.
    /// </summary>
    public TerraformProperty<string> BuildType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("build_type");
        set => SetProperty("build_type", value);
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
    /// The manual_creation attribute.
    /// </summary>
    public TerraformProperty<bool> ManualCreation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("manual_creation");
        set => SetProperty("manual_creation", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformProperty<string> ProjectName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project_name");
        set => SetProperty("project_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for filter_group.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodebuildWebhookFilterGroupBlock>? FilterGroup
    {
        set => SetProperty("filter_group", value);
    }

    /// <summary>
    /// Block for pull_request_build_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PullRequestBuildPolicy block(s) allowed")]
    public List<AwsCodebuildWebhookPullRequestBuildPolicyBlock>? PullRequestBuildPolicy
    {
        set => SetProperty("pull_request_build_policy", value);
    }

    /// <summary>
    /// Block for scope_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScopeConfiguration block(s) allowed")]
    public List<AwsCodebuildWebhookScopeConfigurationBlock>? ScopeConfiguration
    {
        set => SetProperty("scope_configuration", value);
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
