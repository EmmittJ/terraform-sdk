using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_branch_creation_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAmplifyAppAutoBranchCreationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    [TerraformProperty("basic_auth_credentials")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BasicAuthCredentials { get; set; }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    [TerraformProperty("build_spec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BuildSpec { get; set; }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    [TerraformProperty("enable_auto_build")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableAutoBuild { get; set; }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    [TerraformProperty("enable_basic_auth")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableBasicAuth { get; set; }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    [TerraformProperty("enable_performance_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnablePerformanceMode { get; set; }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    [TerraformProperty("enable_pull_request_preview")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnablePullRequestPreview { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    [TerraformProperty("framework")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Framework { get; set; }

    /// <summary>
    /// The pull_request_environment_name attribute.
    /// </summary>
    [TerraformProperty("pull_request_environment_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PullRequestEnvironmentName { get; set; }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [TerraformProperty("stage")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Stage { get; set; }

}

/// <summary>
/// Block type for cache_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAmplifyAppCacheConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for custom_rule in .
/// Nesting mode: list
/// </summary>
public partial class AwsAmplifyAppCustomRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The condition attribute.
    /// </summary>
    [TerraformProperty("condition")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Condition { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformProperty("target")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Target { get; set; }

}

/// <summary>
/// Block type for job_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAmplifyAppJobConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The build_compute_type attribute.
    /// </summary>
    [TerraformProperty("build_compute_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BuildComputeType { get; set; }

}

/// <summary>
/// Manages a aws_amplify_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAmplifyApp : TerraformResource
{
    public AwsAmplifyApp(string name) : base("aws_amplify_app", name)
    {
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    [TerraformProperty("access_token")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AccessToken { get; set; }

    /// <summary>
    /// The auto_branch_creation_patterns attribute.
    /// </summary>
    [TerraformProperty("auto_branch_creation_patterns")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AutoBranchCreationPatterns { get; set; }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    [TerraformProperty("basic_auth_credentials")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BasicAuthCredentials { get; set; }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    [TerraformProperty("build_spec")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BuildSpec { get; set; }

    /// <summary>
    /// The compute_role_arn attribute.
    /// </summary>
    [TerraformProperty("compute_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ComputeRoleArn { get; set; }

    /// <summary>
    /// The custom_headers attribute.
    /// </summary>
    [TerraformProperty("custom_headers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CustomHeaders { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enable_auto_branch_creation attribute.
    /// </summary>
    [TerraformProperty("enable_auto_branch_creation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableAutoBranchCreation { get; set; }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    [TerraformProperty("enable_basic_auth")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableBasicAuth { get; set; }

    /// <summary>
    /// The enable_branch_auto_build attribute.
    /// </summary>
    [TerraformProperty("enable_branch_auto_build")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableBranchAutoBuild { get; set; }

    /// <summary>
    /// The enable_branch_auto_deletion attribute.
    /// </summary>
    [TerraformProperty("enable_branch_auto_deletion")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableBranchAutoDeletion { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The iam_service_role_arn attribute.
    /// </summary>
    [TerraformProperty("iam_service_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IamServiceRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The oauth_token attribute.
    /// </summary>
    [TerraformProperty("oauth_token")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OauthToken { get; set; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Platform { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [TerraformProperty("repository")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Repository { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for auto_branch_creation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBranchCreationConfig block(s) allowed")]
    [TerraformProperty("auto_branch_creation_config")]
    public TerraformList<TerraformBlock<AwsAmplifyAppAutoBranchCreationConfigBlock>>? AutoBranchCreationConfig { get; set; }

    /// <summary>
    /// Block for cache_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheConfig block(s) allowed")]
    [TerraformProperty("cache_config")]
    public TerraformList<TerraformBlock<AwsAmplifyAppCacheConfigBlock>>? CacheConfig { get; set; }

    /// <summary>
    /// Block for custom_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("custom_rule")]
    public TerraformList<TerraformBlock<AwsAmplifyAppCustomRuleBlock>>? CustomRule { get; set; }

    /// <summary>
    /// Block for job_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobConfig block(s) allowed")]
    [TerraformProperty("job_config")]
    public TerraformList<TerraformBlock<AwsAmplifyAppJobConfigBlock>>? JobConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The default_domain attribute.
    /// </summary>
    [TerraformProperty("default_domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultDomain { get; }

    /// <summary>
    /// The production_branch attribute.
    /// </summary>
    [TerraformProperty("production_branch")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ProductionBranch { get; }

}
