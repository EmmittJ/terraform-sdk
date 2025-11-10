using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_branch_creation_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppAutoBranchCreationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    [TerraformPropertyName("basic_auth_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BasicAuthCredentials { get; set; }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    [TerraformPropertyName("build_spec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BuildSpec { get; set; }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    [TerraformPropertyName("enable_auto_build")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableAutoBuild { get; set; }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    [TerraformPropertyName("enable_basic_auth")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableBasicAuth { get; set; }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    [TerraformPropertyName("enable_performance_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnablePerformanceMode { get; set; }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    [TerraformPropertyName("enable_pull_request_preview")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnablePullRequestPreview { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    [TerraformPropertyName("framework")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Framework { get; set; }

    /// <summary>
    /// The pull_request_environment_name attribute.
    /// </summary>
    [TerraformPropertyName("pull_request_environment_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PullRequestEnvironmentName { get; set; }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [TerraformPropertyName("stage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Stage { get; set; }

}

/// <summary>
/// Block type for cache_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppCacheConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for custom_rule in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppCustomRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The condition attribute.
    /// </summary>
    [TerraformPropertyName("condition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Condition { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Source { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformPropertyName("target")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Target { get; set; }

}

/// <summary>
/// Block type for job_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppJobConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The build_compute_type attribute.
    /// </summary>
    [TerraformPropertyName("build_compute_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BuildComputeType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "build_compute_type");

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
    public TerraformProperty<TerraformProperty<string>>? AccessToken { get; set; }

    /// <summary>
    /// The auto_branch_creation_patterns attribute.
    /// </summary>
    [TerraformPropertyName("auto_branch_creation_patterns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AutoBranchCreationPatterns { get; set; }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    [TerraformPropertyName("basic_auth_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BasicAuthCredentials { get; set; }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    [TerraformPropertyName("build_spec")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BuildSpec { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "build_spec");

    /// <summary>
    /// The compute_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("compute_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ComputeRoleArn { get; set; }

    /// <summary>
    /// The custom_headers attribute.
    /// </summary>
    [TerraformPropertyName("custom_headers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CustomHeaders { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_headers");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The enable_auto_branch_creation attribute.
    /// </summary>
    [TerraformPropertyName("enable_auto_branch_creation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableAutoBranchCreation { get; set; }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    [TerraformPropertyName("enable_basic_auth")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableBasicAuth { get; set; }

    /// <summary>
    /// The enable_branch_auto_build attribute.
    /// </summary>
    [TerraformPropertyName("enable_branch_auto_build")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableBranchAutoBuild { get; set; }

    /// <summary>
    /// The enable_branch_auto_deletion attribute.
    /// </summary>
    [TerraformPropertyName("enable_branch_auto_deletion")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableBranchAutoDeletion { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The iam_service_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_service_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IamServiceRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The oauth_token attribute.
    /// </summary>
    [TerraformPropertyName("oauth_token")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OauthToken { get; set; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Platform { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [TerraformPropertyName("repository")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Repository { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for auto_branch_creation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBranchCreationConfig block(s) allowed")]
    [TerraformPropertyName("auto_branch_creation_config")]
    public TerraformList<TerraformBlock<AwsAmplifyAppAutoBranchCreationConfigBlock>>? AutoBranchCreationConfig { get; set; } = new();

    /// <summary>
    /// Block for cache_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheConfig block(s) allowed")]
    [TerraformPropertyName("cache_config")]
    public TerraformList<TerraformBlock<AwsAmplifyAppCacheConfigBlock>>? CacheConfig { get; set; } = new();

    /// <summary>
    /// Block for custom_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("custom_rule")]
    public TerraformList<TerraformBlock<AwsAmplifyAppCustomRuleBlock>>? CustomRule { get; set; } = new();

    /// <summary>
    /// Block for job_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobConfig block(s) allowed")]
    [TerraformPropertyName("job_config")]
    public TerraformList<TerraformBlock<AwsAmplifyAppJobConfigBlock>>? JobConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The default_domain attribute.
    /// </summary>
    [TerraformPropertyName("default_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_domain");

    /// <summary>
    /// The production_branch attribute.
    /// </summary>
    [TerraformPropertyName("production_branch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ProductionBranch => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "production_branch");

}
