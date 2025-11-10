using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_branch_creation_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppAutoBranchCreationConfigBlock : TerraformBlock
{
    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    public TerraformProperty<string>? BasicAuthCredentials
    {
        set => SetProperty("basic_auth_credentials", value);
    }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    public TerraformProperty<string>? BuildSpec
    {
        set => SetProperty("build_spec", value);
    }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAutoBuild
    {
        set => SetProperty("enable_auto_build", value);
    }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableBasicAuth
    {
        set => SetProperty("enable_basic_auth", value);
    }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePerformanceMode
    {
        set => SetProperty("enable_performance_mode", value);
    }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePullRequestPreview
    {
        set => SetProperty("enable_pull_request_preview", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    public TerraformProperty<string>? Framework
    {
        set => SetProperty("framework", value);
    }

    /// <summary>
    /// The pull_request_environment_name attribute.
    /// </summary>
    public TerraformProperty<string>? PullRequestEnvironmentName
    {
        set => SetProperty("pull_request_environment_name", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    public TerraformProperty<string>? Stage
    {
        set => SetProperty("stage", value);
    }

}

/// <summary>
/// Block type for cache_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppCacheConfigBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for custom_rule in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppCustomRuleBlock : TerraformBlock
{
    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformProperty<string>? Condition
    {
        set => SetProperty("condition", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        set => SetProperty("target", value);
    }

}

/// <summary>
/// Block type for job_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppJobConfigBlock : TerraformBlock
{
    /// <summary>
    /// The build_compute_type attribute.
    /// </summary>
    public TerraformProperty<string>? BuildComputeType
    {
        set => SetProperty("build_compute_type", value);
    }

}

/// <summary>
/// Manages a aws_amplify_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAmplifyApp : TerraformResource
{
    public AwsAmplifyApp(string name) : base("aws_amplify_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("default_domain");
        SetOutput("production_branch");
        SetOutput("access_token");
        SetOutput("auto_branch_creation_patterns");
        SetOutput("basic_auth_credentials");
        SetOutput("build_spec");
        SetOutput("compute_role_arn");
        SetOutput("custom_headers");
        SetOutput("description");
        SetOutput("enable_auto_branch_creation");
        SetOutput("enable_basic_auth");
        SetOutput("enable_branch_auto_build");
        SetOutput("enable_branch_auto_deletion");
        SetOutput("environment_variables");
        SetOutput("iam_service_role_arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("oauth_token");
        SetOutput("platform");
        SetOutput("region");
        SetOutput("repository");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformProperty<string> AccessToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_token");
        set => SetProperty("access_token", value);
    }

    /// <summary>
    /// The auto_branch_creation_patterns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AutoBranchCreationPatterns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("auto_branch_creation_patterns");
        set => SetProperty("auto_branch_creation_patterns", value);
    }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    public TerraformProperty<string> BasicAuthCredentials
    {
        get => GetRequiredOutput<TerraformProperty<string>>("basic_auth_credentials");
        set => SetProperty("basic_auth_credentials", value);
    }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    public TerraformProperty<string> BuildSpec
    {
        get => GetRequiredOutput<TerraformProperty<string>>("build_spec");
        set => SetProperty("build_spec", value);
    }

    /// <summary>
    /// The compute_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ComputeRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compute_role_arn");
        set => SetProperty("compute_role_arn", value);
    }

    /// <summary>
    /// The custom_headers attribute.
    /// </summary>
    public TerraformProperty<string> CustomHeaders
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_headers");
        set => SetProperty("custom_headers", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enable_auto_branch_creation attribute.
    /// </summary>
    public TerraformProperty<bool> EnableAutoBranchCreation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_auto_branch_creation");
        set => SetProperty("enable_auto_branch_creation", value);
    }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    public TerraformProperty<bool> EnableBasicAuth
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_basic_auth");
        set => SetProperty("enable_basic_auth", value);
    }

    /// <summary>
    /// The enable_branch_auto_build attribute.
    /// </summary>
    public TerraformProperty<bool> EnableBranchAutoBuild
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_branch_auto_build");
        set => SetProperty("enable_branch_auto_build", value);
    }

    /// <summary>
    /// The enable_branch_auto_deletion attribute.
    /// </summary>
    public TerraformProperty<bool> EnableBranchAutoDeletion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_branch_auto_deletion");
        set => SetProperty("enable_branch_auto_deletion", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> EnvironmentVariables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// The iam_service_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> IamServiceRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_service_role_arn");
        set => SetProperty("iam_service_role_arn", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The oauth_token attribute.
    /// </summary>
    public TerraformProperty<string> OauthToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("oauth_token");
        set => SetProperty("oauth_token", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformProperty<string> Platform
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform");
        set => SetProperty("platform", value);
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
    /// The repository attribute.
    /// </summary>
    public TerraformProperty<string> Repository
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository");
        set => SetProperty("repository", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for auto_branch_creation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBranchCreationConfig block(s) allowed")]
    public List<AwsAmplifyAppAutoBranchCreationConfigBlock>? AutoBranchCreationConfig
    {
        set => SetProperty("auto_branch_creation_config", value);
    }

    /// <summary>
    /// Block for cache_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheConfig block(s) allowed")]
    public List<AwsAmplifyAppCacheConfigBlock>? CacheConfig
    {
        set => SetProperty("cache_config", value);
    }

    /// <summary>
    /// Block for custom_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAmplifyAppCustomRuleBlock>? CustomRule
    {
        set => SetProperty("custom_rule", value);
    }

    /// <summary>
    /// Block for job_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobConfig block(s) allowed")]
    public List<AwsAmplifyAppJobConfigBlock>? JobConfig
    {
        set => SetProperty("job_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_domain attribute.
    /// </summary>
    public TerraformExpression DefaultDomain => this["default_domain"];

    /// <summary>
    /// The production_branch attribute.
    /// </summary>
    public TerraformExpression ProductionBranch => this["production_branch"];

}
