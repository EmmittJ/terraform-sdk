using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_group in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodebuildWebhookFilterGroupBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for pull_request_build_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildWebhookPullRequestBuildPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The approver_roles attribute.
    /// </summary>
    [TerraformProperty("approver_roles")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> ApproverRoles { get; set; }

    /// <summary>
    /// The requires_comment_approval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequiresCommentApproval is required")]
    [TerraformProperty("requires_comment_approval")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RequiresCommentApproval { get; set; }

}

/// <summary>
/// Block type for scope_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildWebhookScopeConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Domain { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

}

/// <summary>
/// Manages a aws_codebuild_webhook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodebuildWebhook : TerraformResource
{
    public AwsCodebuildWebhook(string name) : base("aws_codebuild_webhook", name)
    {
    }

    /// <summary>
    /// The branch_filter attribute.
    /// </summary>
    [TerraformProperty("branch_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BranchFilter { get; set; }

    /// <summary>
    /// The build_type attribute.
    /// </summary>
    [TerraformProperty("build_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BuildType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The manual_creation attribute.
    /// </summary>
    [TerraformProperty("manual_creation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ManualCreation { get; set; }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    [TerraformProperty("project_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for filter_group.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter_group")]
    public partial TerraformSet<TerraformBlock<AwsCodebuildWebhookFilterGroupBlock>>? FilterGroup { get; set; }

    /// <summary>
    /// Block for pull_request_build_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PullRequestBuildPolicy block(s) allowed")]
    [TerraformProperty("pull_request_build_policy")]
    public partial TerraformList<TerraformBlock<AwsCodebuildWebhookPullRequestBuildPolicyBlock>>? PullRequestBuildPolicy { get; set; }

    /// <summary>
    /// Block for scope_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScopeConfiguration block(s) allowed")]
    [TerraformProperty("scope_configuration")]
    public partial TerraformList<TerraformBlock<AwsCodebuildWebhookScopeConfigurationBlock>>? ScopeConfiguration { get; set; }

    /// <summary>
    /// The payload_url attribute.
    /// </summary>
    [TerraformProperty("payload_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PayloadUrl { get; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformProperty("secret")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Secret { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
