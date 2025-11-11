using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_branch_creation_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppAutoBranchCreationConfigBlock
{
    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    [TerraformPropertyName("basic_auth_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BasicAuthCredentials { get; set; }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    [TerraformPropertyName("build_spec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BuildSpec { get; set; }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    [TerraformPropertyName("enable_auto_build")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableAutoBuild { get; set; }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    [TerraformPropertyName("enable_basic_auth")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableBasicAuth { get; set; }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    [TerraformPropertyName("enable_performance_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnablePerformanceMode { get; set; }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    [TerraformPropertyName("enable_pull_request_preview")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnablePullRequestPreview { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    [TerraformPropertyName("framework")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Framework { get; set; }

    /// <summary>
    /// The pull_request_environment_name attribute.
    /// </summary>
    [TerraformPropertyName("pull_request_environment_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PullRequestEnvironmentName { get; set; }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [TerraformPropertyName("stage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Stage { get; set; }

}

/// <summary>
/// Block type for cache_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppCacheConfigBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for custom_rule in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppCustomRuleBlock
{
    /// <summary>
    /// The condition attribute.
    /// </summary>
    [TerraformPropertyName("condition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Condition { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformPropertyName("target")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Target { get; set; }

}

/// <summary>
/// Block type for job_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppJobConfigBlock
{
    /// <summary>
    /// The build_compute_type attribute.
    /// </summary>
    [TerraformPropertyName("build_compute_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BuildComputeType { get; set; } = default!;

}

/// <summary>
/// Manages a aws_amplify_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAmplifyApp : TerraformResource
{
    public AwsAmplifyApp(string name) : base("aws_amplify_app", name)
    {
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    [TerraformPropertyName("access_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccessToken { get; set; }

    /// <summary>
    /// The auto_branch_creation_patterns attribute.
    /// </summary>
    [TerraformPropertyName("auto_branch_creation_patterns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AutoBranchCreationPatterns { get; set; }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    [TerraformPropertyName("basic_auth_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BasicAuthCredentials { get; set; }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    [TerraformPropertyName("build_spec")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BuildSpec { get; set; } = default!;

    /// <summary>
    /// The compute_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("compute_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ComputeRoleArn { get; set; }

    /// <summary>
    /// The custom_headers attribute.
    /// </summary>
    [TerraformPropertyName("custom_headers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CustomHeaders { get; set; } = default!;

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enable_auto_branch_creation attribute.
    /// </summary>
    [TerraformPropertyName("enable_auto_branch_creation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableAutoBranchCreation { get; set; }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    [TerraformPropertyName("enable_basic_auth")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableBasicAuth { get; set; }

    /// <summary>
    /// The enable_branch_auto_build attribute.
    /// </summary>
    [TerraformPropertyName("enable_branch_auto_build")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableBranchAutoBuild { get; set; }

    /// <summary>
    /// The enable_branch_auto_deletion attribute.
    /// </summary>
    [TerraformPropertyName("enable_branch_auto_deletion")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableBranchAutoDeletion { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The iam_service_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_service_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IamServiceRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The oauth_token attribute.
    /// </summary>
    [TerraformPropertyName("oauth_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OauthToken { get; set; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Platform { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [TerraformPropertyName("repository")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Repository { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for auto_branch_creation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBranchCreationConfig block(s) allowed")]
    [TerraformPropertyName("auto_branch_creation_config")]
    public TerraformList<TerraformBlock<AwsAmplifyAppAutoBranchCreationConfigBlock>>? AutoBranchCreationConfig { get; set; }

    /// <summary>
    /// Block for cache_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheConfig block(s) allowed")]
    [TerraformPropertyName("cache_config")]
    public TerraformList<TerraformBlock<AwsAmplifyAppCacheConfigBlock>>? CacheConfig { get; set; }

    /// <summary>
    /// Block for custom_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("custom_rule")]
    public TerraformList<TerraformBlock<AwsAmplifyAppCustomRuleBlock>>? CustomRule { get; set; }

    /// <summary>
    /// Block for job_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobConfig block(s) allowed")]
    [TerraformPropertyName("job_config")]
    public TerraformList<TerraformBlock<AwsAmplifyAppJobConfigBlock>>? JobConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The default_domain attribute.
    /// </summary>
    [TerraformPropertyName("default_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultDomain => new TerraformReference(this, "default_domain");

    /// <summary>
    /// The production_branch attribute.
    /// </summary>
    [TerraformPropertyName("production_branch")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ProductionBranch => new TerraformReference(this, "production_branch");

}
