using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_group in .
/// Nesting mode: set
/// </summary>
public class AwsCodebuildWebhookFilterGroupBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for pull_request_build_policy in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildWebhookPullRequestBuildPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The approver_roles attribute.
    /// </summary>
    [TerraformPropertyName("approver_roles")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ApproverRoles { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "approver_roles");

    /// <summary>
    /// The requires_comment_approval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequiresCommentApproval is required")]
    [TerraformPropertyName("requires_comment_approval")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RequiresCommentApproval { get; set; }

}

/// <summary>
/// Block type for scope_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildWebhookScopeConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Domain { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Scope { get; set; }

}

/// <summary>
/// Manages a aws_codebuild_webhook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodebuildWebhook : TerraformResource
{
    public AwsCodebuildWebhook(string name) : base("aws_codebuild_webhook", name)
    {
    }

    /// <summary>
    /// The branch_filter attribute.
    /// </summary>
    [TerraformPropertyName("branch_filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BranchFilter { get; set; }

    /// <summary>
    /// The build_type attribute.
    /// </summary>
    [TerraformPropertyName("build_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BuildType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The manual_creation attribute.
    /// </summary>
    [TerraformPropertyName("manual_creation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ManualCreation { get; set; }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    [TerraformPropertyName("project_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for filter_group.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter_group")]
    public TerraformSet<TerraformBlock<AwsCodebuildWebhookFilterGroupBlock>>? FilterGroup { get; set; } = new();

    /// <summary>
    /// Block for pull_request_build_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PullRequestBuildPolicy block(s) allowed")]
    [TerraformPropertyName("pull_request_build_policy")]
    public TerraformList<TerraformBlock<AwsCodebuildWebhookPullRequestBuildPolicyBlock>>? PullRequestBuildPolicy { get; set; } = new();

    /// <summary>
    /// Block for scope_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScopeConfiguration block(s) allowed")]
    [TerraformPropertyName("scope_configuration")]
    public TerraformList<TerraformBlock<AwsCodebuildWebhookScopeConfigurationBlock>>? ScopeConfiguration { get; set; } = new();

    /// <summary>
    /// The payload_url attribute.
    /// </summary>
    [TerraformPropertyName("payload_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PayloadUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "payload_url");

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformPropertyName("secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Secret => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
