using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_group in AwsCodebuildWebhook.
/// Nesting mode: set
/// </summary>
public class AwsCodebuildWebhookFilterGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_group";

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCodebuildWebhookFilterGroupBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsCodebuildWebhookFilterGroupBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for filter in AwsCodebuildWebhookFilterGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildWebhookFilterGroupBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The exclude_matched_pattern attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeMatchedPattern
    {
        get => new TerraformReference<bool>(this, "exclude_matched_pattern");
        set => SetArgument("exclude_matched_pattern", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => new TerraformReference<string>(this, "pattern");
        set => SetArgument("pattern", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for pull_request_build_policy in AwsCodebuildWebhook.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildWebhookPullRequestBuildPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pull_request_build_policy";

    /// <summary>
    /// The approver_roles attribute.
    /// </summary>
    public TerraformSet<string> ApproverRoles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "approver_roles").ResolveNodes(ctx));
        set => SetArgument("approver_roles", value);
    }

    /// <summary>
    /// The requires_comment_approval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequiresCommentApproval is required")]
    public required TerraformValue<string> RequiresCommentApproval
    {
        get => new TerraformReference<string>(this, "requires_comment_approval");
        set => SetArgument("requires_comment_approval", value);
    }

}


/// <summary>
/// Block type for scope_configuration in AwsCodebuildWebhook.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildWebhookScopeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope_configuration";

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

}


/// <summary>
/// Represents a aws_codebuild_webhook Terraform resource.
/// Manages a aws_codebuild_webhook resource.
/// </summary>
public partial class AwsCodebuildWebhook(string name) : TerraformResource("aws_codebuild_webhook", name)
{
    /// <summary>
    /// The branch_filter attribute.
    /// </summary>
    public TerraformValue<string>? BranchFilter
    {
        get => new TerraformReference<string>(this, "branch_filter");
        set => SetArgument("branch_filter", value);
    }

    /// <summary>
    /// The build_type attribute.
    /// </summary>
    public TerraformValue<string>? BuildType
    {
        get => new TerraformReference<string>(this, "build_type");
        set => SetArgument("build_type", value);
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
    /// The manual_creation attribute.
    /// </summary>
    public TerraformValue<bool>? ManualCreation
    {
        get => new TerraformReference<bool>(this, "manual_creation");
        set => SetArgument("manual_creation", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformValue<string> ProjectName
    {
        get => new TerraformReference<string>(this, "project_name");
        set => SetArgument("project_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The payload_url attribute.
    /// </summary>
    public TerraformValue<string> PayloadUrl
    {
        get => new TerraformReference<string>(this, "payload_url");
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformValue<string> Secret
    {
        get => new TerraformReference<string>(this, "secret");
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

    /// <summary>
    /// FilterGroup block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCodebuildWebhookFilterGroupBlock>? FilterGroup
    {
        get => GetArgument<TerraformSet<AwsCodebuildWebhookFilterGroupBlock>>("filter_group");
        set => SetArgument("filter_group", value);
    }

    /// <summary>
    /// PullRequestBuildPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PullRequestBuildPolicy block(s) allowed")]
    public TerraformList<AwsCodebuildWebhookPullRequestBuildPolicyBlock>? PullRequestBuildPolicy
    {
        get => GetArgument<TerraformList<AwsCodebuildWebhookPullRequestBuildPolicyBlock>>("pull_request_build_policy");
        set => SetArgument("pull_request_build_policy", value);
    }

    /// <summary>
    /// ScopeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScopeConfiguration block(s) allowed")]
    public TerraformList<AwsCodebuildWebhookScopeConfigurationBlock>? ScopeConfiguration
    {
        get => GetArgument<TerraformList<AwsCodebuildWebhookScopeConfigurationBlock>>("scope_configuration");
        set => SetArgument("scope_configuration", value);
    }

}
